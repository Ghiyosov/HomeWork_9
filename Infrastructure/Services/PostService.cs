using Domein.Models;

namespace Infrastructure.Services;

public class PostService
{
      public List<Post> posts = new List<Post>();

    public List<Post> GetPosts()
    {
        return posts;
    }
    public void AddPost(Post post)
    {
        if (post.Id==0)
        {
            post.Id = posts.Count + 1;
        } 
        posts.Add(post);
        System.Console.WriteLine($"Post {post.Title} is add");
    }
    public void UpdatePost(Post post)
    {
        if(post.Id == 0)
        {
            System.Console.WriteLine("Id is : zero");
            return;
        }
        foreach (var st in posts)
        {
            if(st.Id == post.Id)
            {
                st.Title = post.Title;
                st.Description = post.Description;
                st.VoitAmount =post.VoitAmount;
                st.CreatedAl = post.CreatedAl;
                
                System.Console.WriteLine($"Post {st.Title} is update");
                return;
            }

        }
    }
    public void DeletePost(int id)
    {
         if(id == 0)
        {
            System.Console.WriteLine("Id is : zero");
            return;
        }
        foreach (var stu in posts)
        {
            if (stu.Id == id)
            {
                posts.Remove(stu);
                System.Console.WriteLine($"Post {stu.Title} is delete");
                return;
            }
        }
    }
}
