using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace IOnetApp.Docker
{
    public static class CommandLine
    {

        public static string RunCommand(string fileName, string argument)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = fileName, // Thiết lập docker làm lệnh cần chạy
                Arguments = argument, // Sử dụng "ps" để liệt kê các container đang chạy
                UseShellExecute = false,
                RedirectStandardOutput = true, // Định hướng lại đầu ra chuẩn để đọc
                CreateNoWindow = true // Không tạo cửa sổ mới
            };

            
            // Tạo và cấu hình Process
            using (Process process = new Process())
            {
                process.StartInfo = startInfo; ;
                StringBuilder output = new StringBuilder();
                process.OutputDataReceived += (sender, args) => output.AppendLine(args.Data); // Thu thập dữ liệu đầu ra

                process.Start(); // Bắt đầu process
                process.BeginOutputReadLine(); // Bắt đầu đọc đầu ra chuẩn

                process.WaitForExit(); // Chờ đợi cho đến khi process kết thúc
                
                return output.ToString();

            }
        }


    }
    
    
}