class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
   
        videos.Add(new  Video("video 1", "Bryan", 256));
        videos.Add(new  Video("video 2", "Jake", 345));
        videos.Add(new  Video("video 3", "Guy", 1238));
     
        Comment newComment = new Comment("vid 1 commentor","vid 1 is common");
        int vidInd = videos.FindIndex(a => a._title == "video 1");
        videos[vidInd].addcomment(newComment); 
              
        newComment.addComment("Jake", "video 3 is awesome");
        videos[videos.FindIndex(a => a._title == "video 3")].addcomment(newComment); 

        newComment.addComment("Jake", "video 2 is better");
        videos[videos.FindIndex(a => a._title == "video 2")].addcomment(newComment); 

        newComment.addComment("John", "video 2 is way better");
        videos[videos.FindIndex(a => a._title == "video 2")].addcomment(newComment); 

        newComment.addComment("Jerry", "video 2 is way way better");
        videos[videos.FindIndex(a => a._title == "video 2")].addcomment(newComment);

        foreach(Video vid in videos)
        {
    
           vid.fullvid();
           vid.displaycomment();

        }
    }
}