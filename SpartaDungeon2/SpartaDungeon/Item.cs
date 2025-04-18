using System.Security.Cryptography.X509Certificates;
public class Item
{
    public string name;
    public string type;
    public int attack;
    public int defense;
    public string description;
    public int price;

    public bool isPurchased;

    public Item(string name, string type, int attack, int defense, string description, int price) //아이템 객체를 생성할 때 안의 정보를 초기화 해준다.
    {
        this.name = name;
        this.type = type;
        this.attack = attack;
        this.defense = defense;
        this.description = description;
        this.price = price;
        this.isPurchased = false;
    }
}

