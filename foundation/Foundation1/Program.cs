class Program
{
    static void Main(string[] args)
    {
        Video vid1 = new Video("a person", "John", 103);
        vid1.fullvid();
        Comment com1 = new Comment("a guy", "First");
        com1.display();

        Video vid2 = new Video("How I lost to a thing", "Bryan", 256);
        vid2.fullvid();
        Comment com2 = new Comment("Jake", "hello");
        com2.display();

        Video vid3 = new Video("I'M SORRY", "apologetic dude", 25);
        vid3.fullvid();
        Comment com3 = new Comment("John", "Ok a i guess");
    }
}