using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class SaveData
{
    public int CookieNum = 0;
    public int autoAdd = 0;
    public int _cane = 10;
    public int _wheelChair = 100;
    public int _supplement = 1000;
    public int _money = 5000;
    public List<ShopManager> shop= new List<ShopManager>();
}
