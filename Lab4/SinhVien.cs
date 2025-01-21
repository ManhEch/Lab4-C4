using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class SinhVien
    {
        //cac thuoc tinh cua lop sinh vien
        public string HoTen {  get; set; }
        public double Diem { get; set; }

        
        //public void sinhVien(double diem, string Hoten)
        //{
        //    this.Diem = diem;
        //    this.HoTen = Hoten;
        //}
        public void Nhap()
        {
            Console.WriteLine("Nhap ho va ten sinh vien:");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap diem sinh vien:");
            Diem = double.Parse(Console.ReadLine());
        }

        //
        public void Xuat()
        {
            Console.WriteLine($"Ho ten: {HoTen}, Diem: {Diem}, Hoc luc: {XepLoaiHocLuc()}");
        }
        public string XepLoaiHocLuc()
        {
            if (Diem < 5)
                return "Yeu";
            else if (Diem < 6.5)
                return "Trung Binh";
            else if (Diem < 7.5)
                return "Kha";
            else return "Gioi";
        } 
    
    }
}

