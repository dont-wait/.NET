namespace MainUIV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithIntegerList();
        }
        static void PlayWithIntegerList()
        {
            //lưu trữ và in ra 10 số nguyên từ 1..10
            //int[] arr = new int[10];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr là biến con trỏ, là biến tham chiếu, là biến trỏ vùng new bự new int[10]
            //vùng nhớ bự này như cái túi chứa bên trong 10 biến int khác arr[0], arr[1]
            //ta nhẩn nha gán từng value cho từng biến int - mảng đã học rồi
            //arr là biến con trỏ, trỏ cái túi bự chứa nhiều biến khác bên trong là data ta sẽ
            //lưu trữ

            //Java: List<Integer> arr = newArrayList<Integer>()
            //Java: CẤM KO ĐC NEW LIST, LIST LÀ ABSTRACT LÀ INTERFACE, CHỈ ĐC NEW ARRAYLIST
            //arr là biế con trỏ, trỏ vùng new bự, chứa bên trong vùng new bự là các biến int
            //những sẽ đc adđ vào từ từ, nở từ từ các biến int được nhét vào - giống cái túi co giãn
            //arr.Add(value int nào đó)
            //arr[i] = value int nào đó nếu chơi mảng

            //lấy ra biế int nào đó arr.Get(pos)

            //C#: LIST VÀ ARRAYLIST ĐỀU NEW ĐC
            //    KHUYÊN DÙNG LIST, KO NÊN DÙNG ARRAYLIST VÌ KO AN TOÀN NẾU KO HIỂU RÕ VỀ NÓ

            //C# List<Student> List<int>
            
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            //list ~~~ arr bên mảng ~ Java là con trỏ, biến trỏ tới vùng new bự

            Console.WriteLine($"There is/are {list.Count} item(s) in the list/bag");
            Console.WriteLine("The integer list printed by using for i");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    //Console.WriteLine(List.get);    //Java
            //    Console.WriteLine(list[i]);     //xài như mảng [pos] kỹ thuật này gọi là INDEXER
            //                                    //XÀI DANH SÁCH ĐÓ NHƯ MẢNG
            //}
            Console.WriteLine("The integer list printed by using for each");

            foreach (var x in list)
            {
                Console.WriteLine(x);   //toán tử với mọi trong tập hợp bên Toán học
            }
        }

    }
}
