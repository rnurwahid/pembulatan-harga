// 8. Membulatkan total belanja di swalayan
using System;
using System.Globalization;

class TotalBelanja{
    static void Main(string[] args){
        Console.WriteLine("===TRANSAKSI SWALAYAN===");
        Console.Write("Masukkan total belanja: ");
        double totBelanja = Convert.ToDouble(Console.ReadLine());
        
        int pokokBelanja = (int)(totBelanja / 100) * 100;
        
        double disc = totBelanja > 100 ? totBelanja - pokokBelanja : 0;
        
        double totalBayar = totBelanja - disc;
        
        // Menggunakan CultureInfo Indonesia untuk format pemisah ribuan
        CultureInfo indonesia = new CultureInfo("id-ID");
        
        Console.WriteLine("Total Belanja    : " + totBelanja.ToString("N0", indonesia));
        Console.WriteLine("Disc             : " + disc.ToString("N0", indonesia));
        Console.WriteLine("Total Bayar      : " + totalBayar.ToString("N0", indonesia));
        
        Console.Write("Masukkan uang tunai  : ");
        double uangTunai = Convert.ToDouble(Console.ReadLine());
        
        double kembalian = uangTunai - totalBayar;
        
        if(kembalian < 0){
            Console.WriteLine("Uang tunai tidak cukup. Anda masih harus membayar: " + Math.Abs(kembalian).ToString("N0", indonesia));
        } else {
            Console.WriteLine("Kembalian Anda       : " + kembalian.ToString("N0", indonesia));
        }
    }
}