using System.Threading.Channels;

namespace ServicesV2
{
    public class Cabinet<T>
    {
        private List<T> list = new List<T>();
        public void AddItem(T item)
        {
            list.Add(item);
        }
        public void PrintAll()
        {
            Console.WriteLine( $"There is/are {list.Count} item");
            foreach( T x in list ) Console.WriteLine(x);
        }
        private T searchAStudent(String id)
        {
            bool isEmpty = !list.Any();
            if (isEmpty())
                return null;
           
        }
        public void searchAStudent()
        {
            String Id;
            Console.Write("Please input a Id that you want to search: ");
            Id = Console.ReadLine();
            searchAStudent(Id);
        }

    }
}
