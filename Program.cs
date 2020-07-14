using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoPhuc_Nhom2_De3
{
    class Program
    {
        static void Main(string[] args)
        {
            SoPhuc soPhuc = new SoPhuc();
            soPhuc.NhapSoPhuc(); // sau khi khoi tao đôi tượng,tien hành gọi den ham NhapSoPhuc
            
            // in số phức vừa nhập
            Console.WriteLine("\nSo phuc vua nhap: " + soPhuc.ConvertToString());

            SoPhuc soPhuc2 = new SoPhuc(3, 2);
            Console.WriteLine("\nSo phuc thu 2: " + soPhuc2.ConvertToString());

            Console.WriteLine("\nTong hai so: " + soPhuc.Cong(soPhuc2).ConvertToString());
            Console.WriteLine("\nHieu hai so: " + soPhuc.Tru(soPhuc2).ConvertToString());
            Console.WriteLine("\nTich hai so: " + soPhuc.Nhan(soPhuc2).ConvertToString());
            Console.WriteLine("\nThuong hai so: " + soPhuc.Chia(soPhuc2).ConvertToString());
            Console.WriteLine("\nBinh phuong so phuc " + soPhuc.ConvertToString() + "là : " + soPhuc.BinhPhuong().ConvertToString());
            Console.WriteLine("\nBinh phuong so phuc " + soPhuc2.ConvertToString() + " là : " + soPhuc2.BinhPhuong().ConvertToString());
            Console.Write("\n________________________END___________________________________");
            
            
            Console.ReadLine();
        }
    }
}
