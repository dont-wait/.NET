namespace ServicesV2
{
    public class Cabinet<T>
    {
        //danh sách các biến/object cần add vô từ từ
        //dùng mảng hoặc nhiều biến lẻ hoặc COLLECTION, TÚI CAO CẤP THAY CHO MẢNG CÙI BẮP

        //CRUD QUEN THUỘC
        private List<T> list = new List<T>();
        public void AddItem(T item) 
        {
            

        }
        public void PrintAll()
        {
            Console.WriteLine("There is/are...");
            //for gì đó, đc quyền for hết
            
        }
        
    }

}
