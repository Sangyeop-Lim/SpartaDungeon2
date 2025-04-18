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
        InventoryList = new List<Item>();

        ItemList.Add(new Item("수련자 갑옷", "방어구", 0, +5, "수련에 도움을 주는 갑옷입니다.", 1000));
        ItemList.Add(new Item("무쇠갑옷", "방어구", 0, +9, "무쇠로 만들어져 튼튼한 갑옷입니다.", 1500));
        ItemList.Add(new Item("스파르타의 갑옷", "방어구", 0, +15, "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 3500));
        ItemList.Add(new Item("낡은 검", "무기", +2, 0, "쉽게 볼 수 있는 낡은 검 입니다.", 600));
        ItemList.Add(new Item("청동 도끼", "무기", +5, 0, "어디선가 사용됐던거 같은 도끼입니다.", 1500));
        ItemList.Add(new Item("스파르타의 창", "무기", +7, 0, "스파르타의 전사들이 사용했다는 전설의 창입니다.", 3500));
    }

    public Stat Stat { get; private set; }

    public Shop Shop { get; private set; }

    public Inventory Inventory { get; private set; }

    public Equip Equip { get; private set; }

    public List<Item> ItemList { get; set; }

    public List<Item> InventoryList { get; set; }
}


