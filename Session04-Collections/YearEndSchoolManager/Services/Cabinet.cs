using Repositories.Entities;

namespace Services
{
    public class Cabinet<T>    //cái tủ truyền thống có nhiều ko gian lưu trữ
                               //chính là mảng của gì đó: SV, GV, NV...
                               //cái Tủ có CRUD trên data bên trong nó, mảng gì gì đó
                               //T: type nào đó bạn muốn dùng,
                               //ví dụ Cabinet<Student> box = new Cabinet<Student>();
                               //ví dụ Cabinet<Lecturer> box = new Cabinet<Lecturer>();
    //KỸ THUẬT COI DATATYPE LÀ THAM SỐ, HÀM, CLASS NHẬN VÀO THAM SỐ MÀ LÀ 1 DATA TYPE
    //void F(int n)
    //void F(T x) -> F(<Dog> x)
    //DATA TYPE IS USED AS A PARAMETER, KỸ THUẬT GENERIC NHƯ BÊN JAVA KHI XÀI LIST,
    //ARRY LIST
    //CLASS THIẾT KẾ TỔNG QUÁT VỚI NHIỀU LOẠI DATA TYPE!!!!!!!!!!!!!!!!!!


    {

        /* private Student[] _list1 = new Student[300];
         private int _count1 = 0;
         private Student[] _list2 = new Lecturer[300];
         private int _count2 = 0;*/
        private T[] _list1 = new T[300];
        private int _count = 0;
        public void AddObject()
        {

        }
        public void PrintObjects()
        {

        }
    }
}
