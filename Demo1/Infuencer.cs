namespace Demo1
{
    public class Influencer
    {
        private int followers;
        private string? username;
        private int postsCount;
        private const int maxLength = 1000;

        public Influencer()
        {
            Posts = new Post[maxLength];
        }

        public Influencer(int followers, string username)
        {
            Followers = followers;
            Username = username;
            postsCount = 0;
            Posts = new Post[maxLength];
        }

        public int PostsCount
        {
            get => postsCount;
            private set
            {
                if (value > maxLength)
                {
                    postsCount = maxLength - 1;
                }
                else
                {
                    postsCount = value;
                }
            }
        }

        public int Followers
        {
            get => followers;
            set
            {
                if (value < 0)
                {
                    followers = 0;
                }
                else
                {
                    followers = value;
                }
            }
        }

        public string? Username
        {
            get
            {
                return username;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    username = string.Empty;
                }
                else
                {
                    username = value;
                }
            }
        }

        public Post[] Posts { get; private set; }

        public void AddNewPost(Post post)
        {
            if (CheckIfPostIsValid(post))
            {
                Posts[PostsCount++] = post;
            }
        }

        private bool CheckIfPostIsValid(Post post)
        {
            if (post.Likes > 0)
            {
                return true;
            }
            return false;
        }
    }
}
