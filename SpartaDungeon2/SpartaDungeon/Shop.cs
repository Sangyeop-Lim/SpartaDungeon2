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
                case "1":
                    Console.Clear();
                    Console.WriteLine("구매할 아이템 번호를 입력해주세요: ");
                    for (int i = 0; i < GameManager.Instance.ItemList.Count; i++)
                    {
                        Item item = GameManager.Instance.ItemList[i];
                        string status = item.isPurchased ? "구매완료" : $"{item.price} G";
                        string effect = item.type == "무기" ? $"공격력 + {item.attack}" : $"방어력 + {item.defense}";
                        Console.WriteLine($"{i + 1}.{item.name} | {item.type} | {effect} | {item.description} | {status} G");
                    }

                    Console.Write("\n>> ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int choice) &&
                        choice >= 1 && choice <= GameManager.Instance.ItemList.Count)
                    {
                        Item selectedItem = GameManager.Instance.ItemList[choice - 1];

                        if (selectedItem.isPurchased)
                        {
                            Console.WriteLine("\n이미 구매한 아이템입니다.");
                        }
                        else if (stat.Gold >= selectedItem.price)
                        {
                            stat.Gold -= selectedItem.price;
                            selectedItem.isPurchased = true;

                            Console.WriteLine($"\n{selectedItem.name}을(를) 구매했습니다!");
                            GameManager.Instance.InventoryList.Add(selectedItem);
                        }
                        else
                        {
                            Console.WriteLine("\nGold가 부족합니다.");
                        }
                    }
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
