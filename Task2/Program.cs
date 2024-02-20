 
Post post = new Post();
post.SetPost("It is text");
post.AddLike();
post.AddLike();
post.AddComment("Super");
post.AddComment("Great");
post.GetInfo();

class Post
{
     public string Text;
    public int Likes = 0;
    public  List<string> Comments = new List<string>();

    public void SetPost(string text)
    {
        Text = text;
    }

    public void AddLike()
    {
        Likes++;
    }

    public void AddComment(string comment)
    {
        Comments.Add(comment);
    }

    public void GetInfo()
    {
        Console.WriteLine($"Text: {Text}");
        Console.WriteLine($"Likes: {Likes}");
        Console.WriteLine($"Comments:");
        for (int i = 0; i < Comments.Count; i++)
        {
            Console.WriteLine(Comments[i]);
        }
    }
}



