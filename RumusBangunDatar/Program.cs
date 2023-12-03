using System;
class Math
{
    static void Main(string[] args)
    {

        Console.WriteLine("|===============================================|");
        Console.WriteLine("|  Menghitung Volume Dan Luas Permukaan Bangun  |");
        Console.WriteLine("|===============================================|");

        int pilihan, a, b, c, d;
        double volume, luas;
        double phi = 3.14;

        Console.WriteLine("|================================================|");
        Console.WriteLine("|                  Pilih Menu                    |");
        Console.WriteLine("|================================================|");
        Console.WriteLine("| 1.  Kubus                                      |");
        Console.WriteLine("| 2.  Balok                                      |");
        Console.WriteLine("| 3.  Bola                                       |");
        Console.WriteLine("| 4.  Limas Segi Empat                           |");
        Console.WriteLine("| 5.  Tabung                                     |");
        Console.WriteLine("| 6.  Kerucut                                    |");
        Console.WriteLine("| 7.  Prisma Tegak Segitiga                      |");
        Console.WriteLine("| 8.  Persegi                                    |");
        Console.WriteLine("| 9.  Persegi Panjang                            |");
        Console.WriteLine("| 10. Segitiga                                   |");
        Console.WriteLine("| 11. Trapesium                                  |");
        Console.WriteLine("| 12. Jajar Genjang                              |");
        Console.WriteLine("| 13. Belah Ketupat                              |");
        Console.WriteLine("| 14. Layang - Layang                            |");
        Console.WriteLine("|================================================|");
        Console.Write("Masukan Pilihan Mu : ");
        pilihan = int.Parse(Console.ReadLine());

        switch (pilihan)
        {
            case 1:
                Console.WriteLine("|=========|");
                Console.WriteLine("|  Kubus  |");
                Console.WriteLine("|=========|");
                Console.Write(" Panjang Rusuk Kubus : ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("=========================");
                volume = a * a * a;
                luas = a * a * 6;
                Console.WriteLine(" Volume Kubus = " + volume);
                Console.WriteLine(" Luas Kubus = " + luas);
                break;

            case 2:
                Console.WriteLine("|=========|");
                Console.WriteLine("|  Balok  |");
                Console.WriteLine("|=========|");
                Console.Write(" Panjang Balok : ");
                a = int.Parse(Console.ReadLine());
                Console.Write(" Lebar Balok : ");
                b = int.Parse(Console.ReadLine());
                Console.Write(" Tinggi Balok : ");
                c = int.Parse(Console.ReadLine());
                Console.WriteLine("=========================");
                volume = a * b * c;
                luas = 2 * (a * b + b * c + c * a);
                Console.WriteLine(" Volume Balok : " + volume);
                Console.WriteLine(" Luas Balok : " + luas);
                break;

            case 3:
                Console.WriteLine("|========|");
                Console.WriteLine("|  Bola  |");
                Console.WriteLine("|========|");
                Console.Write(" Panjang Jari-Jari : ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("=========================");
                volume = 4 / 3 * phi * a * a * a;
                luas = 4 * phi * a * a;
                Console.WriteLine(" Volume Lingkaran : " + volume);
                Console.WriteLine(" Luas Permukaan : " + luas);
                break;

            case 4:
                Console.WriteLine("|==================|");
                Console.WriteLine("| Limas Segi Empat |");
                Console.WriteLine("|==================|");
                Console.Write(" Panjang Alas Limas : ");
                a = int.Parse(Console.ReadLine());
                Console.Write(" Lebal Limas : ");
                b = int.Parse(Console.ReadLine());
                Console.Write(" Tinggi Limas : ");
                c = int.Parse(Console.ReadLine());
                Console.WriteLine("=========================");
                volume = (a * b * c * 1 / 3);
                luas = ((a + b) * c) + (a * b);
                Console.WriteLine("Volume Limas : " + volume);
                Console.WriteLine("Luas Permukaan Limas : " + luas);
                break;

            case 5:
                Console.WriteLine("|========|");
                Console.WriteLine("| Tabung |");
                Console.WriteLine("|========|");
                Console.Write("Jari-Jari Alas Tabung : ");
                a = int.Parse(Console.ReadLine());
                Console.Write(" Tinggi Tabung : ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("===============================");
                volume = phi * a * a * b;
                luas = (phi * a * 2) * (b * a);
                Console.WriteLine("Volume Tabung : " + volume);
                Console.WriteLine("Luas Permukaan Tabung : " + luas);
                break;

            case 6:
                Console.WriteLine("|=========|");
                Console.WriteLine("| Kerucut |");
                Console.WriteLine("|=========|");
                Console.Write("Jari-Jari Alas Kerucut : ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Tinggi Kerucut : ");
                b = int.Parse(Console.ReadLine());
                Console.Write(" Garis Pelukis Kerucut : ");
                c = int.Parse(Console.ReadLine());
                Console.WriteLine("=========================");
                volume = (phi * a * a * b) / 3;
                luas = (phi * a * (a + c));
                Console.WriteLine("Volume Kerucut : " + volume);
                Console.WriteLine("Luas Permukaan Kerucut : " + luas);
                break;

            case 7:
                Console.WriteLine("|=======================|");
                Console.WriteLine("| Prisma Tegak Segitiga |");
                Console.WriteLine("|=======================|");
                Console.Write("Alas Segitiga Prisma : ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Tinggi Segitiga Prisma : ");
                b = int.Parse(Console.ReadLine());
                Console.Write("Sisi Lengkung : ");
                c = int.Parse(Console.ReadLine());
                Console.Write("Tinggi Prisma Tegak : ");
                d = int.Parse(Console.ReadLine());
                Console.WriteLine("==============================");
                volume = (a * b / 2) * d;
                luas = (2 * (a * b / 2)) + ((a + b + c) * d);
                Console.WriteLine("Volume Prisma Tegak Segitiga : " + volume);
                Console.WriteLine("Luas Prisma Tegak Segitiga : " + luas);
                break;

            case 8:
                Console.WriteLine("|=========|");
                Console.WriteLine("| Persegi |");
                Console.WriteLine("|=========|");
                Console.Write("Masukan Sisi Persegi : ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("=========================");
                luas = a * a;
                Console.WriteLine("Luas Persegi : " + luas);
                break;

            case 9:
                Console.WriteLine("|=================|");
                Console.WriteLine("| Persegi Panjang |");
                Console.WriteLine("|=================|");
                Console.Write("Masukan Panjang : ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Masukan Lebar : ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("=======================");
                luas = a * b;
                Console.WriteLine("Luas Persegi Panjang : " + luas);
                break;

            case 10:
                Console.WriteLine("|==========|");
                Console.WriteLine("| Segitiga |");
                Console.WriteLine("|==========|");
                Console.Write("Masukan Alas Segitiga : ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Masukan Tinggi Segitiga : ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("=======================");
                luas = a * b * 1 / 2;
                Console.WriteLine("Luas Segitiga : " + luas);
                break;

            case 11:
                Console.WriteLine("|===========|");
                Console.WriteLine("| Trapesium |");
                Console.WriteLine("|===========|");
                Console.Write("Masukan A : ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Masukan B : ");
                b = int.Parse(Console.ReadLine());
                Console.Write("Masukan Tinggi Trapesium : ");
                c = int.Parse(Console.ReadLine());
                Console.WriteLine("==========================");
                luas = (a + b) * c * 1 / 2;
                Console.WriteLine("Luas Trapesium : " + luas);
                break;

            case 12:
                Console.WriteLine("|===============|");
                Console.WriteLine("| Jajar Genjang |");
                Console.WriteLine("|===============|");
                Console.Write("Masukan Alas Jajar Genjang : ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Masukan Tinggi Jajar Genjang : ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("==============================");
                luas = a * b;
                Console.WriteLine("Luas Jajar Genjang : " + luas);
                break;

            case 13:
                Console.WriteLine("|===============|");
                Console.WriteLine("| Belah Ketupat |");
                Console.WriteLine("|===============|");
                Console.Write("Masukan Diagonal 1 : ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Masukan Diagonal 2 : ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("=====================");
                luas = a * b * 1 / 2;
                Console.WriteLine("Luas Belah Ketupat : " + luas);
                break;

            case 14:
                Console.WriteLine("|=================|");
                Console.WriteLine("| Layang - Layang |");
                Console.WriteLine("|=================|");
                Console.Write("Masukan Diagonal 1 : ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Masukan Diagonal 2 : ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("========================");
                luas = a * b * 1 / 2 ;
                Console.WriteLine("Luas Layang - Layang : " + luas);
                break;


            default:
                Console.WriteLine("Pilihan Mu Ga Ada!!!");
                break;

        }
    }
}


