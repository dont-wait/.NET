namespace PassByDelegateV1
{
    //CHALLENGE #1: IN RA 2 LỜI BÀI HÁT NÀO ĐÓ CỦA TAILOR SWIFT: THE 1,
    //LOVER
    //              LÀM THEO STYLE TRUYỀN THỐNG

    //CHALLENGE #2: DÙNG DELEGATE ĐỂ IN BÀI HÁT
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C#1: Call explicitmethod direcly as normal - gọi hàm có sẵn");
            PrintSongLyricsThe1();
            PrintSongLyricsLover(); //gọi hàm run thì có ()

            Console.WriteLine("C#2: Call explicit method using delegate ");
            //Action - void f()
            Action f1 = PrintSongLyricsThe1;    //luật sư = thân chủ, HỢP ĐỒNG ỦY QUYỀN
            f1();   //PrintSongLyricsThe1
            f1 += PrintSongLyricsLover;//+= nối thêm bài vào, trỏ 2 hàm
                                       //1 luật sư = 2 or nhiều thân chủ
            
            // = như gán biến xưa nay, chỉ trỏ 1 hàm
            //1 luật sư = 1 thân chủ
            f1.Invoke();

            //C#3: IN RA THÊM 2 BÀI HÁT NỮA, KO ĐC TẠO HÀM LẺ CÓ SẴN RỒI GÁN
            //              MÀ DÙNG HÀM ẨN DANH VÀ BIỂU THỨC LAMBDA

            Action f2 = delegate () 
            {
                Console.WriteLine("The song lyrics August - by Taylor Swift");
                Console.WriteLine();
                Console.WriteLine(@"Salt air, and the rust on your door
I never needed anything more
Whispers of ""Are you sure?""
""Never have I ever before""
..."
);

            };    //đầu vào & thân hàm. NHỚ SỦA ĐẦ VÀO CHO PHÙ HỢP

            Action f3 = () => 
            {
                Console.WriteLine("The song lyrics exile - by Taylor Swift");
                Console.WriteLine();
                Console.WriteLine(@"[Verse 1: Justin Vernon]
I can see you standing, honey
With his arms around your body
Laughin', but the joke's not funny at all
And it took you five whole minutes
To pack us up and leave me with it
Holdin' all this love out here in the hall
..."
);
            };  //VIP - CHỈ LÀ HỢP ĐỒNG LUẬT SƯ = THÂN CHỦ = HÀM ẨN DANH THAY 
                //                                           VÌ HÀM CÓ SẴN
            Console.WriteLine("C#3: Call ANONYMOUS/LAMBDA EXPRESSION METHODS");
            f2();   //LUẬT SƯ LÊN TIẾNG .INVOKE()
            f3();
        }

        static void PrintSongLyricsThe1()
        {
            Console.WriteLine("The song The 1 - by Tailor Swift");
            Console.WriteLine();
            Console.WriteLine(@"[Verse 1]
I'm doing good, I'm on some new shit
Been saying ""yes"" instead of ""no""
I thought I saw you at the bus stop, I didn't though
I hit the ground running each night
I hit the Sunday matinée
You know the greatest films of all time were never made
...
");  //@verbatim
        }
        static void PrintSongLyricsLover()
        {
            Console.WriteLine("The song Lover - by Tailor Swift");
            Console.WriteLine();
            Console.WriteLine(@"[Verse 1]
We could leave the Christmas lights up 'til January
And this is our place, we make the rules
And there's a dazzling haze, a mysterious way about you, dear
Have I known you twenty seconds or twenty years?

[Chorus]
Can I go where you go?
Can we always be this close?
Forever and ever, ah
Take me out and take me home
You're my, my, my, my lover
...
");
        }


    }
}
