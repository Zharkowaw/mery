User user1 = new User("Mery", "213123");
#pragma warning disable IDE0090 // Użyj operatora „new(...)”
User user2 = new User("Kacper", "213970");
#pragma warning restore IDE0090 // Użyj operatora „new(...)”
User user3 = new User("Wiktoria", "21213123");

user1.AddScore(10);
user1.AddScore(4);
user1.AddScore(4);

user2.AddScore(7);
user2.AddScore(9);
user2.AddScore(5);

user3.AddScore(8);
user3.AddScore(1);
user3.AddScore(5);
