namespace PassByDelegateV2
{
    //ngang cơ nhau: delegate, class, interface, struct

    internal class ShowBiz
    {
        //_field, properties { get; set; }, methods: ctor, ToString()...
        //một constructor default nếu class/khuôn ko có phễu đc tạo sẵn
        //_field, properties, methods: PUBLIC, PRIVATE, PROTECTED,
        //STATIC (THUỘC VỀ CỘNG ĐỒNG), NON-STATIC (THUỘC VỀ OBJECT)
        //. TRỰC TIẾP                       . QUA NEW OBJECT
        public static void PrintSongLyricsThe1()
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

        public void PrintSongLyricsLover()
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
    internal class Program
    {
        static void Main(string[] args)
        {
            //C#4: IN RA LỜI CÁC BÀI HÁT, GỌI HÀM NẰM Ở CLASS KHÁC
            // PHẢI DÙNG QUA DELEGATE

            Console.WriteLine("C#4: CALL THE METHODS OUTSIDE - IN ANOTHER CLASS");
            Action f1 = ShowBiz.PrintSongLyricsThe1;
            
            ShowBiz song = new ShowBiz();//default ctor

            Action f2 = song.PrintSongLyricsLover;  //kí họp đồng chưa phát ngôn

            Action f3 = new ShowBiz().PrintSongLyricsLover;
            //NGUYÊN LÍ DẤU BẰNG, A = B
            //Ở ĐÂU XÀI A ĐC THÌ Ở ĐÓ XÀI B

            
            f1.Invoke();    //run, phát ngôn qua nick name
            f2.Invoke();    //run, phát ngôn
            f3();   //IN LẠI BÀI LOVER 2 LẦN

        }
    }
}
