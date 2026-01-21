
using System.Security.Cryptography.X509Certificates;

class bangundatar
{

    public double panjang;
    public double lebar;

    public virtual void luas(double panjang, double lebar)
    {

        Console.Write("panjang :");
        this.panjang = Convert.ToDouble(Console.ReadLine());
        Console.Write("lebar :");
        this.lebar = Convert.ToDouble(Console.ReadLine());

        double hasil = this.panjang * this.lebar;
        Console.WriteLine($"luas bangun datar persegi panjang dengan panjang : {this.panjang} dan lebar : {this.lebar} \nadalah : {hasil}");

    }
    public virtual void keliling(double panjang, double lebar)
    {

        Console.Write("panjang :");
        this.panjang = Convert.ToDouble(Console.ReadLine());
        Console.Write("lebar :");
        this.lebar = Convert.ToDouble(Console.ReadLine());

        double hasil = (2 * this.panjang) + (2 * this.lebar);
        Console.WriteLine($"keliling bangun datar persegi panjang dengan panjang : {this.panjang} dan lebar : {this.lebar} \nadalah : {hasil}");

    }
    public virtual void luassisi(int sisi)
    {
        Console.Write("sisi :");
        sisi= Convert.ToInt32(Console.ReadLine());

        double hasil = (sisi * sisi);
        Console.WriteLine($"luas bangun datar bujursangkar dengan panjang sisi : {sisi}\nadalah : {hasil}");

    }
    public virtual void kelilingsisi(int sisi)
    {
        Console.Write("sisi :");
        sisi = Convert.ToInt32(Console.ReadLine());
        double hasil = (4 * sisi);
        Console.WriteLine($"luas bangun datar bujursangkar dengan panjang : {sisi} dan lebar : {sisi} \nadalah : {hasil}");
    }
}
class segitiga : bangundatar
{
    public override void luas (double alas, double tinggi)
    {
        Console.Write("alas :");
        alas = Convert.ToDouble(Console.ReadLine());
        Console.Write("tinggi :");
        tinggi = Convert.ToDouble(Console.ReadLine());

        double hasil = (0.5 * alas * tinggi);
        Console.WriteLine($"luas segitiga dengan alas : {alas} dan tinggi : {tinggi} \nadalah : {hasil}");


    }
    public override void keliling(double alas, double tinggi)
    {
        Console.Write("Masukkan Sisi 1 : ");
        double s1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Masukkan Sisi 2 : ");
        double s2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Masukkan Sisi 3 : ");
        double s3 = Convert.ToDouble(Console.ReadLine());

        double hasil = (s1 + s2 + s3);
        Console.WriteLine($"keliling segitiga \nadalah : {hasil}");

    }
}
class lingkaran : bangundatar
{
    double pi = Math.PI;

    public override void luas(double alas, double tinggi)
    {
        Console.Write("jari-jari :");
        tinggi = Convert.ToDouble(Console.ReadLine());

        double hasil = pi *(tinggi * tinggi);
        Console.WriteLine($"luas lingkaran dengan jari-jari : {tinggi} dan phi : {pi} \nadalah : {hasil}");

    }
    public override void keliling(double alas, double tinggi)
    {
        Console.Write("jari-jari :");
        tinggi = Convert.ToDouble(Console.ReadLine());

        double hasil = 2 * pi * tinggi;
        Console.WriteLine($"keliling lingkaran dengan jari-jari : {tinggi} dan phi : {pi} \nadalah : {hasil}");

    }
}
class program
{
    static void Main( string[] args )
    {
        bangundatar bangundatar = new bangundatar();
        lingkaran lingkaran = new lingkaran();
        segitiga segitiga = new segitiga();

        Console.WriteLine("=================================");
        Console.WriteLine("nama     : damar areefa naraya");
        Console.WriteLine("kelas    : X-RPL 1");
        Console.WriteLine("no-absen : 7");
        Console.WriteLine("=================================\n");

        while(true)
        {
            
            Console.WriteLine("\n[1] cari luas persegi panjang dari class bangundatar");
            Console.WriteLine("[2] cari luas segitiga dengan overriding");
            Console.WriteLine("[3] cari luas dan keliling lingkaran dengan overriding");
            Console.WriteLine("[4] cari luas dan keliling bujursangker dengan overloading");
            Console.WriteLine("[5] keluar");
            Console.Write("\nPILIH AKSI : ");
            string pilihan = Console.ReadLine();

            switch ( pilihan )
            {
                case "1":
                    bangundatar.luas(0, 0);
                    break;
                case "2":
                    segitiga.luas(0, 0);
                    break;
                case "3":
                    lingkaran.luas(0, 0);
                    lingkaran.keliling(0, 0);
                    break;
                case "4":
                    bangundatar.luassisi(0);
                    bangundatar.kelilingsisi(0);
                    break;
                case "5":
                    Console.WriteLine("DADAH SAHABAT KUH");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("pilihan tidak ada");
                    break;
            }

        }
    }
}