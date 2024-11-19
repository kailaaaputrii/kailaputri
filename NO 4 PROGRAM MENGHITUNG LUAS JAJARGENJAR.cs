using System;
class Program
{
static void Main()
{
// Minta pengguna memasukkan nilai alas
Console.Write("Masukkan nilai jajargenjang: ");
double alas = Convert.ToDouble(Console.ReadLine());
// Minta pengguna memasukkan nilai tinggi
Console.Write("Masukkan nilai tinggi jajargenjar: ");
double tinggi = Convert.ToDouble(Console.ReadLine());
// Hitung luas segitiga
double luas = alas * tinggi;
// Tampilkan hasil luas segitiga
Console.WriteLine("Luas jajargenjang adalah: " + luas);
}
}