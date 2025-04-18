public class Shop
{
    public void Show()
    {
        Stat stat = GameManager.Instance.Stat; //메모리 주소를 참조시킨다
        while (true)
        {
            Console.WriteLine("상점\n필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine($"[보유골드]\n{stat.Gold} G");
            Console.WriteLine();
            //Console.WriteLine("[아이템 목록]\n- 수련자 갑옷 | 방어력 +5 | 수련에 도움을 주는 갑옷입니다. | 1000 G");
            //Console.WriteLine("- 무쇠갑옷 | 방어력 +9 | 무쇠로 만들어져 튼튼한 갑옷입니다. | 구매완료");
            //Console.WriteLine("- 스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다. | 3500 G");
            //Console.WriteLine("- 낡은 검 | 공격력 +2 | 쉽게 볼 수 있는 낡은 검 입니다. | 600 G");
            //Console.WriteLine("- 청동 도끼 | 공격력 +5 | 어디선가 사용됐던거 같은 도끼입니다. | 1500 G");
            //Console.WriteLine("- 스파르타의 창 | 공격력 +7 | 스파르타의 전사들이 사용했다는 전설의 창입니다. | 구매완료");
            Console.WriteLine("[아이템 목록]");
            for (int i = 0; GameManager.Instance.ItemList.Count > i; i++)
            {
                Console.WriteLine($"{GameManager.Instance.ItemList[i].name}");
            }
                Console.WriteLine();
                Console.WriteLine("1. 아이템 구매\n0. 나가기");
                Console.WriteLine();
                Console.Write("원하시는 행동을 입력해주세요.\n>> ");

            string select = Console.ReadLine();

            switch (select)
            {
                case "0":
                    Console.Clear();
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.WriteLine();
                    continue;
            }
        }
    }
}
