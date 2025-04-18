namespace SpartaDungeon
{
    public class Stat
    {
        public static void Show()
        {
            Console.WriteLine("상태보기\n캐릭터의 정보가 표시됩니다.");
            Console.WriteLine();
            Console.WriteLine("Lv. 01\nChad (전사)\n공격력 : 10\n방어력 : 5\n체 력 : 100\nGold : 1500 G");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }
}
