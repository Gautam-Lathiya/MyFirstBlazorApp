namespace MyFirstBlazorApp
{
    public class Service
    {
        public List<string> list = new List<string>();

        public void Add(string item)
        {
            list.Add(item);
        }
    }
}
