using System.Runtime;
using System.Runtime.CompilerServices;


class Program
{
   static void Main(string[] args)
   {
     //membuat variabel laptop1 dan laptop2 bertipe data Laptop
     Laptop laptop1 = new Vivobook();
     laptop1.vga = new nvidia();
     laptop1.processor = new corei5();
      
     Laptop laptop2 = new Ideapad();
     laptop2.vga = new amd();
     laptop2.processor = new ryzen();
      
     //membuat variabel predator bertipe data Predator
     Predator predator = new Predator();

     //memanggil method
     laptop2.LaptopDinyalakan();
     laptop2.LaptopDimatikan();
     predator.BermainGame();

     // code dibawah akan error karena method ngoding() merupakan method dari child class Laptop bukan dari parent class
     laptop1.Ngoding();
      
     //untuk memanggil nya tanpa terjadi error maka bisa menggunakan code dibawah
     //class yg awal diganti sama nama class baru, sehingga bisa akses method yg didalam nama class baru yang telah dibuat
     //((Vivobook)laptop1).Ngoding();
     ACER acer = new Predator();
     acer.BermainGame(); //code disamping jika dijalankan akan error karena parent class tidak memiliki method tsb
     
     //membuat spesifikasi laptop 1 
     Console.WriteLine("Spesifikasi laptop1 : merk vga " + laptop1.vga + " merk processor " + laptop1.processor);

   }
}

//membuat parent class processor
class Processor
{
    public string merk;
    public string tipe;

}

//membuat child class Intel
class Intel : Processor
{
    public Intel()
    {
        base.merk = "Intel"; 
        //base untuk mengakses member class(property dan method) dari parent kalau this mengakses di class tertentu 
    }
}

//membuat child class AMD dengan parent class Processor
class AMD : Processor
{
    public AMD()
    {
        base.merk = "AMD";
    }
}

//membuat child class di dalam child class dengan parent class Intel
class corei3 : Intel 
{
    public corei3()
    {
        base.tipe = "Corei3";
    }
}

//membuat child class di dalam child class dengan parent class Intel
class corei5 : Intel
{
    public corei5()
    {
        base.tipe = "Corei5";
    }
}

//membuat child class di dalam child class dengan parent class Intel
class corei7 : Intel
{
    public corei7()
    {
        base.tipe = "Corei7";
    }
}

//membuat child class di dalam child class dengan parent class AMD
class ryzen : AMD
{
    public ryzen()
    {
        base.tipe = "Ryzen";
    }
}

//membuat child class di dalam child class dengan parent class AMD
class athlon : AMD
{
    public athlon()
    {
        base.tipe = "Athlon";
    }
}

//membuat parent class VGA
class VGA
{
    public string merk;
}

//membuat child class dengan parent class VGA
class nvidia : VGA
{
    public nvidia()
    {
        base.merk = "Nvidia";
    }
}

//membuat child class dengan parent class VGA
class amd : VGA
{
    public amd()
    {
        base.merk = "AMD";
    }
}

//membuat parent class Laptop
class Laptop
{
    public string merk;
    public string tipe;
    public VGA vga; 
    public Processor processor;

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala");
    }
    //void tida mereturn

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati");
    }
}

//membuat child class dengan parent class Laptop
class ASUS : Laptop
{
    public ASUS()
    {
    base.merk = "ASUS";
    }
}

//membuat child class dengan parent class Laptop
class ACER : Laptop
{
    public ACER()
    {
        base.merk = "ACER";
    }
}

//membuat child class dengan parent class Laptop
class lenovo : Laptop
{
    public lenovo()
    {
        base.merk = "Lenovo";
    }
}

//membuat child class di dalam child class dengan parent class ASUS
class ROG : ASUS
{
    public ROG()
    {
        base.tipe = "ROG";
    }
}

//membuat child class di dalam child class dengan parent class ASUS
class Vivobook : ASUS
{
    public Vivobook()
    {
        base.tipe = "Vivobook";
    }

    public void Ngoding()
    {
        Console.WriteLine($"Ctak Ctak Ctak, error lagi!!" );
    }
}

//membuat child class di dalam child class dengan parent class ACER
class Swift : ACER
{
    public Swift()
    {
        base.tipe = "Swift";
    }
}

//membuat child class di dalam child class dengan parent class ACER
class Predator : ACER
{
    public Predator()
    {
        base.tipe = "Predator";
    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    }
}

//membuat child class di dalam child class dengan parent class lenovo
class Ideapad : lenovo
{
    public Ideapad()
    {
        base.tipe = "Ideapad";
    }
}

//membuat child class di dalam child class dengan parent class lenovo
class Legion : lenovo
{
    public Legion()
    {
        base.tipe = "Legion";
    }
}
