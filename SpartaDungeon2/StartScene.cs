public class StartScene
{
    static void Main(string[] args)
    {
    GameManager gameManager = new GameManager();
        Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.\n이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
        Console.WriteLine();
        while (true)
        {
            Console.WriteLine("1. 상태 보기\n2. 인벤토리\n3. 상점");
            Console.WriteLine();
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");

            string select = Console.ReadLine();

            switch (select)
            {
                case "1":
                    Console.Clear();
                    gameManager.Stat.Show();
                    break;
                case "2":
                    Console.Clear();
                    gameManager.Inventory.Show();
                    break;
                case "3":
                    Console.Clear();
                    gameManager.Shop.Show();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.WriteLine();
                    continue;
            }
        }
    }
}

