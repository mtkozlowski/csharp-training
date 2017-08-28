using System;

namespace _07___Post
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("About anything", "This is description of About anything Post at StackOverflow website, which is very, very helpful!");
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.DownVote();
            post.DownVote();
            Console.WriteLine("VoteValue of the post is: {0}", post.GetVoteValue());
        }
    }
}
