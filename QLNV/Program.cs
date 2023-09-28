using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLNV
{
    class Program
    {
        static void Main(string[] args)
        {
            Nhanvien nv1 = new Nhanvien();
            nv1.Xuat();
            Nhanvien nv2 = new Nhanvien("NV02", "Nguyen Van B", 2.5f, 2010);
            nv2.Xuat();
            Nhanvien nv3 = new Nhanvien("NV03", "Nguyen Van C", 3.5f, 2011);
            nv3.Xuat();
            nv1.Nhap();  
            nv1.Xuat();
        }
    }
}