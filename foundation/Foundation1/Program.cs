class Program
{
    static void Main(string[] args)
    {
        Video vid1 = new Video("a person", "John", 103);
        vid1.fullvid();

        Video vid2 = new Video("How I lost to a thing", "Bryan", 256);
        vid2.fullvid();

        Video vid3 = new Video("I'M SORRY", "apologetic dude", 25);
        vid3.fullvid();
    }
}