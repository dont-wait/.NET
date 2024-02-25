namespace Delegate
{
    public delegate void X();
    //public delegate void Y();
    internal class Program
    {

        static void Main(string[] args)
        {
            X CoGai = KuKiaVaCoAy;
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
