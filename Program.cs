using Labaa2.Accounts;
using Labaa2.Factories;

AccountFactory accountFactory = new AccountFactory();
GameFactory gameFactory = new GameFactory();

var firstPlayer = accountFactory.CreateAccount("Anton");
var secondPlayer = accountFactory.CreatePremiumAccount("Rost");
var thirdPlayer = accountFactory.CreatePlatinumAccount("Kostya");

List<BaseAccount> accounts = new List<BaseAccount>();
accounts.Add(firstPlayer);
accounts.Add(secondPlayer);
accounts.Add(thirdPlayer);


try
{
    gameFactory.CreateGame(firstPlayer, thirdPlayer, DateTime.Now, -3).PlayGame();
} catch(ArgumentOutOfRangeException e)
{
    Console.WriteLine(e);
}


gameFactory.CreateGame(thirdPlayer, secondPlayer, DateTime.Now, 2).PlayGame();
gameFactory.CreateGame(thirdPlayer, secondPlayer, DateTime.Now, 1).PlayGame();
gameFactory.CreateGame(thirdPlayer, firstPlayer, DateTime.Now, 4).PlayGame();
gameFactory.CreateGame(firstPlayer, thirdPlayer, DateTime.Now, 7).PlayGame();
gameFactory.CreateBoostGame(firstPlayer, thirdPlayer, DateTime.Now, 12).PlayGame();
gameFactory.CreateBoostGame(thirdPlayer, secondPlayer, DateTime.Now, 2).PlayGame();
gameFactory.CreateBoostGame(firstPlayer, secondPlayer, DateTime.Now, 5).PlayGame();
gameFactory.CreateTrainingGame(firstPlayer, secondPlayer, DateTime.Now).PlayGame();
gameFactory.CreateTrainingGame(secondPlayer, thirdPlayer, DateTime.Now).PlayGame();
gameFactory.CreateTrainingGame(thirdPlayer, firstPlayer, DateTime.Now).PlayGame();

foreach (var account in accounts)
{
    Console.WriteLine(account.GetStats());
}