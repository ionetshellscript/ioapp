namespace IOnetApp.Docker
{
    public class DockerContainer
    {
        public string ID;
        public string Name;
        public string Image;
        public string MemUsage;
        public float MemPercent;
        public string Status;
        public string CPU;
        public string Network;
        public string Block;
        public int pid;
    }
}