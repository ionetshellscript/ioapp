using System;
using System.Collections.Generic;
using System.Management;

namespace IOnetApp.Docker
{
    public static class DockerCommand
    {
        public static List<DockerContainer> CheckContainerStatus()
        {
            List<DockerContainer> containers = new List<DockerContainer>();
            var containersName = GetAllContainerId();
            foreach (var id in containersName)
            {
                containers.Add(GetContainerStatus(id));
            }
            return containers;
        }

        public static DockerContainer GetContainerStatus(string containerUID)
        {
            DockerContainer container = new DockerContainer();
            string data = CommandLine.RunCommand("docker", $"stats --no-stream {containerUID} --format \"{{{{.ID}}}}:{{{{.Name}}}}:{{{{.CPUPerc}}}}\"");
            var containerParams = data.Trim(new []{'\r', '\n'}).Split(':');
            if (containerParams.Length >= 3)
            {
                container.ID = containerParams[0];
                container.Name = containerParams[1];
                container.CPU = containerParams[2];
            }
            string imageName = CommandLine.RunCommand("docker", $"inspect --format \"{{{{.Config.Image}}}}\" {containerUID}").TrimEnd(new []{'\r', '\n'}).Split('@')[0];
            container.Image = imageName;
            // Format data to container obj
            return container;
        }
        public static void StopAllContainer()
        {
            var containerName = GetAllContainerId();
            foreach (var container in containerName)
            {
                // Check valid uuid
                if(container.Length == 12)
                    StopContainer(container);
            }
        }

        public static List<string> GetAllContainerId()
        {
            string containerList = CommandLine.RunCommand("docker", "container ls -q");
            var containerName = containerList.Split(new[] { "\r\n"}, StringSplitOptions.RemoveEmptyEntries);
            return new List<string>(containerName);
        }
        
        public static void StopContainer(string containerName)
        {
            // Stop container
            CommandLine.RunCommand("docker", $"container stop {containerName}");
            // Remove container
            CommandLine.RunCommand("docker", $"container rm {containerName}");
        }

        public static void RunNewWorker(string deviceName, string deviceID, string userID)
        {
            StopAllContainer();
            var param =
                $"run -d -v /var/run/docker.sock:/var/run/docker.sock -e DEVICE_NAME=\"{deviceName.Trim(new []{'\r', '\n', ' '})}\" -e DEVICE_ID=\"{deviceID.Trim(new []{'\r', '\n', ' '})}\" -e USER_ID=\"{userID.Trim(new []{'\r', '\n', ' '})}\" -e OPERATING_SYSTEM=\"Windows\" -e USEGPUS=true --pull always ionetcontainers/io-launch:v0.1";
        }

        public static bool CheckDocker()
        {
            try
            {
                var result = CommandLine.RunCommand("docker", "--version");
                if(result.Contains("version"))
                    return true;
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                
                return false;

            }
        }

        public static bool CheckNvidia()
        {
            // Tạo một truy vấn WMI để lấy thông tin về các driver video
            SelectQuery query = new SelectQuery("SELECT * FROM Win32_VideoController");

            // Sử dụng ManagementObjectSearcher để thực thi truy vấn
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            {
                // Duyệt qua kết quả để tìm driver NVIDIA
                foreach (ManagementObject mo in searcher.Get())
                {
                    // Lấy tên và phiên bản của driver
                    string name = mo["Name"] as string;
                    string driverVersion = mo["DriverVersion"] as string;

                    // Kiểm tra xem có phải là driver NVIDIA không
                    if (name != null && name.ToLower().Contains("nvidia"))
                    {
                        return true;
                    }
                }
            }

            return false;

        }
    }
}