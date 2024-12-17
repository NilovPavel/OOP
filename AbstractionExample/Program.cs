using CounterStrike;

IPlayer player = new BotPlayer();

IPlayer terrorist = new TerroristPlayer("John");
IPlayer contrTerrorist = new ContrTerroristPlayer("Adam");

//На момент начала игры мы даже не знаем кто с кем играет: человек с человеком, человек с машиной или машина с машиной
new Game().StartGame(player, terrorist);