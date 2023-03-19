// See https://aka.ms/new-console-template for more information

internal class Program
{
    static void Main(string[] args)
    {
        DataGeneric<String> data = new DataGeneric<string>("1302200003");
        data.PrintData();
    }

    public class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine("data yang tersimpan adalah: " + this.data);
        }
    }
}