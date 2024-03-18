// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace MODUL05_1302220093
{
    // Class dengan nama Penjumlahan
    public class Penjumlahan
    {
        // Membuat Method dengan Generic Method T dan parameter T yang sama sebanyak 3 kali
        public void JumlahTigaAngka<T>(T inp1, T inp2, T inp3)
        {
            // deklarasi 3 variabel dengan tipe data dynamic untuk menampung inputan 
            dynamic a = inp1;
            dynamic b = inp2;
            dynamic c = inp3;

            // mengubah penjumlahannya menjadi double dan menampilkan pada console
            double Hasil = a +  b + c;
            Console.WriteLine("Hasil : " + Hasil);
        }

        // Method Utama Untuk Run
        public static void Main(string[] args)
        {
            // Method atau Object untuk melakukan run class Penjumlahan
            Penjumlahan soal3 = new Penjumlahan();
            Console.WriteLine("Masukkan 3 Angka : ");
            double ang1 = float.Parse(Console.ReadLine());
            double ang2 = float.Parse(Console.ReadLine());
            double ang3 = float.Parse(Console.ReadLine());
            soal3.JumlahTigaAngka(ang1, ang2, ang3);
        }
    }
}