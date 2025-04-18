public class Inventory
{
    public void Show()
    {
        while (true)
        {
            Console.WriteLine("인벤토리\n보유중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine();
            Console.WriteLine("1. 장착 관리\n0. 나가기");
            Console.WriteLine();
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");

            string select = Console.ReadLine();

            switch (select)
            {
                case "0":
                    Console.Clear();
                    return;
                case "1":
                    Console.Clear();
                GameManager.Instance.Equip.Show();
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
