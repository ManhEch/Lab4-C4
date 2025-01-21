using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVien sinhVien = new SinhVien();

            Console.WriteLine("Nhap thong tin sinh vien:");
            sinhVien.Nhap();

            Console.WriteLine("Thong tin sinh vien:");
            sinhVien.Xuat();
        }
    }
}
