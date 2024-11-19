using System;
class Program
{
static void Main()
{
// Minta pengguna memasukkan nilai alas
Console.Write("Masukkan nilai alas segitiga: ");
double alas = Convert.ToDouble(Console.ReadLine());
// Minta pengguna memasukkan nilai tinggi
Console.Write("Masukkan nilai tinggi segitiga: ");
double tinggi = Convert.ToDouble(Console.ReadLine());
// Hitung luas segitiga
double luas = 0.5 * alas * tinggi;
// Tampilkan hasil luas segitiga
Console.WriteLine("Luas segitiga adalah: " + luas);
}
}



