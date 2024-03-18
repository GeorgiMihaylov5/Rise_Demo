namespace Demo1
{
    public struct Post
    {
        private int comments;
        public int Likes { get; set; }
        public int Comments 
        { 
            get {  return comments; }
            set {  comments = value; } 
        }
    }
}
