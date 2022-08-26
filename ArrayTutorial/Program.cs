
int[] scores = new int[3];

Console.Write("Enter 1st score: ");
string answer = Console.ReadLine();
scores[0] = Convert.ToInt32(answer);

Console.Write("Enter 2nd score: ");
answer = Console.ReadLine();
scores[1] = Convert.ToInt32(answer);

Console.Write("Enter last score: ");
answer = Console.ReadLine();
scores[2] = Convert.ToInt32(answer);

int total = scores[0] + scores[1] + scores[2];
Console.WriteLine($"The total of scores {scores[0]}, {scores[1]}, and {scores[2]} is {total}"); // 500




/* Code commented out
Console.Write("Guess a number from 1 to 10: ");
string answer = Console.ReadLine();
int myNumber = Convert.ToInt32(answer);
Console.WriteLine($"The number is {myNumber}");

Console.Write("Enter a string and press Enter: ");
string? response = Console.ReadLine();
Console.WriteLine($"You typed {response}");

// Bowling scores
int[] games = { 145, 264, 244 };
//int seriesScore = games[0] + games[1] + games[2];
Console.WriteLine($"Series score is {games[0] + games[1] + games[2]}");

// an array of names
string[] names = { "Josh", "Billy", "Karl", "Caleb", "Ian", "Jack", "Sam", "James" };

// an array in ints
int?[] scores2 = new int?[5] { 95, 97, 100, 93, 100 };
Console.WriteLine($"{scores2[0],8:N1}, {scores2[1],5}, {scores2[2],5}, {scores2[3],5}, {scores2[4],5}");

int[] scores = new int[5];
scores[0] = 100;
scores[1] = 95;
scores[2] = 97;
scores[3] = 100;
scores[4] = 7;
Console.WriteLine($"{scores[0],8:N1}, {scores[1],5}, {scores[2],5}, {scores[3],5}, {scores[4],5}");
*/