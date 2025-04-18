public class GameManager
{
    public static GameManager Instance { get; private set; } //싱글톤 패턴, 대신 남발하진 말자

    public GameManager() //생성자
    {
        Instance = this;
        Stat = new Stat(); //초기화
        Shop = new Shop(); //나 임상엽의 프로젝트는 static을 15개나 써서 접근하였는데 이제 static 1개로 접근할 수 있다
        Inventory = new Inventory();
        Equip = new Equip();
        ItemList = new List<Item>();

        ItemList.Add(new Item("수련자 갑옷"));
        ItemList.Add(new Item("무쇠갑옷"));
        ItemList.Add(new Item("스파르타의 갑옷"));
        ItemList.Add(new Item("낡은 검"));
        ItemList.Add(new Item("청동 도끼"));
        ItemList.Add(new Item("스파르타의 창"));
    }

    public Stat Stat { get; private set; }

    public Shop Shop { get; private set; }

    public Inventory Inventory { get; private set; }

    public Equip Equip { get; private set; }

    public List<Item> ItemList { get; set; }
}


