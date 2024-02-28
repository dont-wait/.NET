namespace Delegate
{
    public delegate void X();
    //public delegate void Y();
    internal class Program
    {

        static void Main(string[] args)
        {
<<<<<<< HEAD
            X CoGai = TuiVaCoAy;    //người tình đã qua của Ẻm
            CoGai = BanVaCoAy;      //người tình đã qua của Ẻm
            CoGai = KuKiaVaCoAy;    //người mới nhất của Ẻm
            
=======
            X CoGai = KuKiaVaCoAy;
>>>>>>> 5987436a64b6111de97aa3e18f1f07344c7ba6c3
            CoGai.Invoke();

        }
        static void KuKiaVaCoAy()
        {
            Console.WriteLine("Tối nay tao đi chơi với Ẻm");
            X DeKuNayLo = TuiVaCoAy;
            DeKuNayLo += BanVaCoAy;
            DeKuNayLo.Invoke();
        }
        static void TuiVaCoAy()
        {
            Console.WriteLine("Cuộc sống em ổn không? Xa anh em phải hạnh phúc");
        }
        static void BanVaCoAy()
        {
            Console.WriteLine("Chúc em hạnh phúc bên người! Thay anh lo cho Ku kia :> !!!");
        }
    }
}
