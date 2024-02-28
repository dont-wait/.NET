namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithValueTypeArrayV2();
        }
        static void PlayWithValueTypeArrayV2()
        {   //kỹ thuật khai báo mảng style thứ 2, vẫn cùng kết quả, vẫn xử lí như nhau,
            //chỉ là khác cách gán giá trị
            int[] arr = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };  //new ngầm số phần tử mảng,
                                                                    //số biến trong mảng == số value đc gán, bài này mảng [10]

            //int[] arr = { 5,      10,     15, 20, 25, 30, 35, 40, 45, 50 };
            //          arr[0] arr[1]     arr[2]
            //      int a = 5,    b = 10
            //gán giá trị ngay khi khai báo mảng
            //các biến lẻ trong mảng sẽ đc gán ngay value, biến=thứ-i[i] = value gì???

            //CÓ ƯU VÀ NHƯỢC CHO MỖI CÁCH KHAI BÁO!!!
            Console.WriteLine("The array is printed by using traditional for");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine(@"


The array is printed by using foreach");
            foreach (int x in arr) //với mọi x thuộc R(arr)
            {
                Console.Write("{0} ", x); //x = arr[0] x = arr[1] với mọi mà
                                          //tại chỗ có giá trị = 0 lấp x vào chỗ 0 đó
                                          //cw(arr[i]) chính là cw(x)
            }
            //Console.WriteLine("\n\n\n");
            Console.WriteLine(@"

"); //verbatim - raw string
            foreach (var x in arr) //với mọi x thuộc R(arr), type inference ngầm
            {
                Console.Write("{0} ", x); //x = arr[0] x = arr[1] với mọi mà
                                          //tại chỗ có giá trị = 0 lấp x vào chỗ 0 đó
                                          //cw(arr[i]) chính là cw(x)
            }
            
        }

    }
}
