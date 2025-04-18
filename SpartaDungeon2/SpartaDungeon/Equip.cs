public class Equip
{
    public void Show()
    {
        Stat stat = GameManager.Instance.Stat;
        List<Item> inventory = GameManager.Instance.InventoryList;

        while (true)
        {
            Console.WriteLine("인벤토리 - 장착 관리\n보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();

            if (inventory.Count == 0)
            {
                Console.WriteLine("보유 중인 아이템이 없습니다.");
            }
            else
            {
                Console.WriteLine("[아이템 목록]");
                for (int i = 0; i < inventory.Count; i++)
                {
                    Item item = inventory[i];
                    string effect = item.type == "무기"
                        ? $"공격력 + {item.attack}"
                        : $"방어력 + {item.defense}";

                    string equipped = item.isEquipped ? " [E]" : "";
                    Console.WriteLine($"{i + 1}. {item.name} | {item.type} | {effect} | {item.description}{equipped}");
                }
            }

            Console.WriteLine() ;
            Console.WriteLine("장착할 아이템 번호를 입력하세요");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");

            string input = Console.ReadLine();
            
            if (input == "0")
            {
                Console.Clear();
                return;
            }

            if (int.TryParse(input, out int index) &&
                index >= 1 && index <= inventory.Count)
            {
                Item selectedItem = inventory[index - 1];

                if (selectedItem.isEquipped)
                {
                    stat.Attack -= selectedItem.attack;
                    stat.Defense -= selectedItem.defense;
                    selectedItem.isEquipped = false;

                    Console.Clear();
                    Console.WriteLine($"\n{selectedItem.name}의 장착을 해제했습니다.");
                }
                else
                {
                    stat.Attack += selectedItem.attack;
                    stat.Defense += selectedItem.defense;
                    selectedItem.isEquipped = true;
                    
                    Console.Clear();
                    Console.WriteLine($"\n{selectedItem.name}을(를) 장착했습니다.");
                }         
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }
        }
    }
}

