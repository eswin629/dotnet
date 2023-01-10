namespace WebMVC.Models;

public class InventoryViewModel
{
    public int Id { get; set; }

    public String Name { get; set; }

    public String Merk { get; set; }

    public int Tahun { get; set; }

    public InventoryViewModel()
    {
    }


    public InventoryViewModel(int id, string name, string merk, int tahun)
    {
        Id = id;
        Name = name;
        Merk = merk;
        Tahun = tahun;
    }
}
