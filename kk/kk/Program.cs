

User user1 = new("Mery", "213123");
User user2 = new("Kacper", "213970");
User user3 = new("Wiktoria", "21213123");

user1.AddScore(12);
user1.AddScore(4);
user1.AddScore(4);

user2.AddScore(7);
user2.AddScore(11);
user2.AddScore(5);

user3.AddScore(16);
user3.AddScore(1);
user3.AddScore(5);


List<User> users = new List<User>()
{
    user1 , user2 , user3
};

int maxResult = -1;

foreach (var user in users)
{
    if (user.Result > maxResult)
    {
        maxResult = users.Result;
    }
}
foreach (var user in users)
{
    if (User.Result == maxResult)
    {
        Console.WriteLine("Najwiecej punktów ma - " + users.Result + 
    }
}

