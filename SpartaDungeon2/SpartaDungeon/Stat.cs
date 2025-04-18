public class Stat
{
    public int Level = 1;
    public string Job = "Chad (전사)";
    public int Attack = 10;
    public int Defense = 5;
    public int Health = 100;
    public int Gold = 10000;

    public void Show()
    {
        while (true)
        {
            Console.WriteLine("상태보기\n캐릭터의 정보가 표시됩니다.");
            Console.WriteLine();
            Console.WriteLine($"Lv. {Level}");
            Console.WriteLine($"{Job}");
            Console.WriteLine($"공격력 : {Attack}");
            Console.WriteLine($"방어력 : {Defense}");
            Console.WriteLine($"체 력 : {Health}");
            Console.WriteLine($"Gold : {Gold} G");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");
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
