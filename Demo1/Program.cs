using Demo1;

Influencer influencer1 = new()
{
    Username = "pesho",
    Followers = 100
};

var influencer2 = new Influencer(150, "Vasko");
var influencer3 = influencer2;
influencer3.Followers = 1500;

influencer1.AddNewPost(new Post() { Likes = 10});
influencer1.AddNewPost(new Post() { Likes = 10 });

Console.WriteLine(influencer2.VerifiedInfluencer());