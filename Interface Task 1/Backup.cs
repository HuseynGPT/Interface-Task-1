using System.Reflection.Metadata.Ecma335;

namespace Interface_Task_1
{

    interface IMyInterface
    {
        public void mediaTypeSize();
        public void copy(int mediaTypeSize);
        public void freeMemory();


    }
    abstract class Storage
    {

        public Storage()
        {
            
        }
        protected Storage(string mediaName, string model)
        {
            MediaName = mediaName;
            Model = model;
        }

        public string MediaName { get; set; }

        public string Model{ get; set; }


        public abstract void Show();
    }


    internal class HDD:Storage,IMyInterface
    {

        public float Suret{ get; set; }

        public float memorySize{ get; set; }

        public HDD():base() { }

        public HDD(string mediaName, string model, float memorySize, float size):base(mediaName, model)
        {
            Suret = size;
            this.memorySize = memorySize;
        }

        public void copy(int mediaTypeSize)
        {
            float result = mediaTypeSize / Suret;
            Console.WriteLine("Reslt: " + result);
        }

        public void freeMemory()
        {
            Console.WriteLine($"Free memory: {memorySize}");
        }

        public void mediaTypeSize()
        {
            Console.WriteLine($"Media type: {MediaName}");
        }

        public override void Show()
        {

            Console.WriteLine("Model name: " +  Model);
            Console.WriteLine("Media name: " +  MediaName);
            Console.WriteLine($"Suret: {Suret}");
            Console.WriteLine($"Memory: {memorySize}");
        }
    }


    internal class DVD : Storage, IMyInterface
    {

        public float suret { get; set; }

        public float memorySize { get; set; }

        public DVD() : base() { }

        public DVD(string mediaName, string model, float memorySize, float suret) : base(mediaName, model)
        {
            this.memorySize = memorySize;
            this.suret = suret;
        }

        public void copy(int mediaTypeSize)
        {
            float result = mediaTypeSize / suret;
            Console.WriteLine("Reslt: " + result);
        }

        public void freeMemory()
        {
            Console.WriteLine($"Free memory: {memorySize}");
        }

        public void mediaTypeSize()
        {
            Console.WriteLine($"Media type: {MediaName}");
        }

        public override void Show()
        {

            Console.WriteLine("Model name: " + Model);
            Console.WriteLine("Media name: " + MediaName);
            Console.WriteLine($"Suret: {suret}");
            Console.WriteLine($"Memory: {memorySize}");
        }
    }

    internal class Flash : Storage, IMyInterface
    {

        public float suret { get; set; }

        public float memorySize { get; set; }

        public Flash() : base() { }

        public Flash(string mediaName, string model, float memorySize, float suret) : base(mediaName, model)
        {
            this.memorySize = memorySize;
            this.suret = suret;
        }

        public void copy(int mediaTypeSize)
        {
            float result = mediaTypeSize / suret;
            Console.WriteLine("Reslt: " + result);
        }

        public void freeMemory()
        {
            Console.WriteLine($"Free memory: {memorySize}");
        }

        public void mediaTypeSize()
        {
            Console.WriteLine($"Media type: {MediaName}");
        }

        public override void Show()
        {

            Console.WriteLine("Model name: " + Model);
            Console.WriteLine("Media name: " + MediaName);
            Console.WriteLine($"Suret: {suret}");
            Console.WriteLine($"Memory: {memorySize}");
        }
    }

}
