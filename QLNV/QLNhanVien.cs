using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace QLNV
{
    class Nhanvien
    {
        private string ms;
        private string ht;
        private float hsl;
        private int nvl;
        public static int MLTT = 1750000;

        public string MaSo 
        {
            get 
            { 
                return ms; 
            }
            set 
            { 
                ms = value; 
            }
        }
        public string HoTen
        {
            get 
            { 
                return ht; 
            }
            set 
            { 
                ht = value; 
            }
        }
        public float HeSoLuong
        {
            get 
            { 
                return hsl; 
            }
            set 
            {
                if (value <0)
                    hsl = 0;
                else
                hsl = value; 
            }
        }
        public int NamVaoLam
        {
            get 
            { 
                return nvl; 
            }
            set
            {
                if (value < 0)
                    nvl = 0;
                else
                nvl = value; 
            }
        }
        public Nhanvien()
        {
            ms = "";
            ht = "";
            hsl = 0;
            nvl = 0;
        }
        public Nhanvien (string ms, string ht, float hsl, int nvl)
        {
            MaSo = ms;
            HoTen = ht;
            HeSoLuong = hsl;
            NamVaoLam = nvl;
        }
        float LuongCoBan()
        {
            return HeSoLuong * MLTT;
        }
        public float HeSoPhuCapTN()
        {
            return (DateTime.Today.Year - NamVaoLam) / 100.0f;
        }
        public float Luong()
        {
            return LuongCoBan()*HeSoPhuCapTN();
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap vao ma so cho nhan vien");
            MaSo = Console.ReadLine();
            Console.WriteLine("Nhap vao ho ten cho nhan vien");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap vao he so luong cho nhan vien");
            HeSoLuong = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao nam vao lam cho nhan vien");
            NamVaoLam = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Ma so: {0}", MaSo);
            Console.WriteLine("Ho ten: {0}", HoTen);
            Console.WriteLine("He so luong: {0}", HeSoLuong);
            Console.WriteLine("Nam vao lam: {0}", NamVaoLam);
            Console.WriteLine("Luong co ban: {0}", LuongCoBan());
            Console.WriteLine("He so phu cap tham nien: {0}", HeSoPhuCapTN());
            Console.WriteLine("Luong: {0}", Luong());
        }
    }
}
