using System;
using System.IO;
using Newtonsoft.Json;

namespace IOnetApp.IONET
{
    public class IoNetWorker
    {
        public string DeviceName;
        public string DeviceId;
        public string UserId;

        public static void SaveDataToLocal(IoNetWorker worker)
        {
            var jsonData = JsonConvert.SerializeObject(worker);
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = "worker.txt";
            string filePath = Path.Combine(baseDirectory, fileName);
            File.WriteAllText(filePath, jsonData);
        }

        public static IoNetWorker LoadDataObject()
        {
            IoNetWorker worker = null;
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = "worker.txt";
            string filePath = Path.Combine(baseDirectory, fileName);
            if (File.Exists(filePath))
            {
                var data =File.ReadAllText(filePath);
                worker = JsonConvert.DeserializeObject<IoNetWorker>(data);
            }
            return worker;
        }

        public static IoNetWorker ParseWorkerFromCommand(string commnad)
        {
            IoNetWorker worker = null;
            if (!string.IsNullOrEmpty(commnad))
            {
                worker = new IoNetWorker
                {
                    DeviceId = GetValueForKey(commnad, "DEVICE_ID"),
                    DeviceName = GetValueForKey(commnad, "DEVICE_NAME"),
                    UserId = GetValueForKey(commnad, "USER_ID")
                };
            }
            return worker;
        }
        static string GetValueForKey(string command, string key)
        {
            string keyWithEquals = key + "=";
            int startIndex = command.IndexOf(keyWithEquals) + keyWithEquals.Length;
            if (startIndex == keyWithEquals.Length - 1) return ""; // Key not found
        
            int endIndex = command.IndexOf(' ', startIndex);
            endIndex = endIndex == -1 ? command.Length : endIndex; // Handle if it's the last parameter

            string value = command.Substring(startIndex, endIndex - startIndex);
            value = value.Trim(new char[] { '\"' }); // Remove any quotes around the value
        
            return value;
        }
    }
    
    
    
    
}