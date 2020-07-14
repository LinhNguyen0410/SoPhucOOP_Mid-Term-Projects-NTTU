using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoPhuc_Nhom2_De3
{
    public class SoPhuc
    {
        //public float phanThuc;
        //public float phanAo;

        private float phanThuc;   // Private Field cho phần thực,phần ảo
        private float phanAo;     //private(pvi truy cap)  chỉ được truy cập từ class chứa thuộc tính đó.

        // khai báo một thuộc tính phanThuc có kiểu dữ liệu float
        public float PhanThuc
        {
            get
            {
                return phanThuc;
            }
            set
            {
                phanThuc = value; // 'value' nó ám chỉ giá trị mới được gán cho property.
    
            }
        }


        // khai báo một thuộc tính phanAo có kiểu dữ liệu float
        public float PhanAo
        {
            get
            {
                return phanAo;   
            }
            set
            {
                phanAo = value;
            }
        }


        // Hàm khởi tạo có 2 tham số truyền vào
        public SoPhuc(float phanThuc, float phanAo)
        {
            this.phanThuc = phanThuc;
            this.phanAo = phanAo;
        }
        // Hàm khởi tạo mặc định
        public SoPhuc()
        {
        }
            
        // Hàm cộng hai số phức
        public SoPhuc Cong(SoPhuc b)
        {
            // Tạo một số phức kết quả của phép cộng, có giá trị của số hiện tại.
            SoPhuc result = new SoPhuc(phanThuc, phanAo);

            // Thực hiện cộng theo công thức, (a + bi) + (c + di) = (a + c) + (b + d)i
            result.phanThuc += b.phanThuc;  // = result.phanThuc = result.phanThuc + b.phanThuc;
            result.phanAo += b.phanAo;
            
            return result;
        }

        // Hàm trừ hai số phức
        public SoPhuc Tru(SoPhuc b)
        {
            // Tạo một số phức kết quả của phép trừ, có giá trị của số hiện tại.
            SoPhuc result = new SoPhuc(phanThuc, phanAo);

            // Thực hiện trừ theo công thức, (a+bi)−(c+di)=(a−c)+(b−d)i
            result.phanThuc -= b.phanThuc;  
            result.phanAo -= b.phanAo;

            return result;
        }

        // Hàm nhân hai số phức
        public SoPhuc Nhan(SoPhuc b)
        {
            // Tạo một số phức kết quả của phép nhân, có giá trị của số hiện tại.
            SoPhuc result = new SoPhuc(phanThuc, phanAo);

            // Thực hiện nhân theo công thức, (a+bi)(c+di)=(ac−bd)+(ad+bc)i
            result.phanThuc = result.phanThuc * b.phanThuc - result.phanAo * b.phanAo;
            result.phanAo = result.phanThuc * b.phanAo  + result.phanAo * b.phanThuc;

            return result;
        }

        // Hàm chia hai số phức
        public SoPhuc Chia(SoPhuc b)
        {
            // Tạo một số phức kết quả của phép chia, có giá trị của số hiện tại.
            SoPhuc result = new SoPhuc(phanThuc, phanAo);

            // Kiểm tra nếu số b = 0 thì trả về kết quả = số phức hiện tại
            if (b.phanThuc == 0 && b.phanAo == 0)
                return result;

            /* Thực hiện chia theo công thức, 
             (c + di)/(a + bi) 
             = (c + di)*(a - bi) / (a*a + b*b) (Nhân liên hợp với a - bi)
             = (ac + bd) / (a*a + b*b) + i * (ad - bc)/(a*a + b*b).
            */
            result.phanThuc = (result.phanThuc * b.phanThuc + result.phanAo * b.phanAo) / (result.phanThuc * result.phanThuc + b.phanAo * b.phanAo);
            result.phanAo = (result.phanThuc * b.phanAo + result.phanAo * b.phanThuc) / (result.phanThuc * result.phanThuc + b.phanAo * b.phanAo);

            return result;
        }

        // Hàm bình phương số phức
        public SoPhuc BinhPhuong()   //(a+bi) * (a+bi) = a*a -b *b ,2*a*b
        {
            return new SoPhuc(phanThuc * phanThuc - phanAo * phanAo , 2 * phanThuc * phanAo);
        }

        // Nhập số phức
        public void NhapSoPhuc()
        {
            Console.WriteLine("__________________LOP SO PHUC_______________________________");
            Console.WriteLine("So phuc a + bi");
            Console.Write("Vui long nhap a = ");
            // lặp đến khi nào nhập đúng định dạng
            while (!float.TryParse(Console.ReadLine(), out phanThuc))
                Console.Write("\nNhap lai a = ");

            Console.Write("Vui long nhap b = ");
            // lặp đến khi nào nhập đúng định dạng
            while (!float.TryParse(Console.ReadLine(), out phanAo))
                Console.Write("\nNhap lai b = ");
        }

        // Hàm trả về kết quả dạng string, có dạng a + bi.
        public string ConvertToString()
        {
            string result = phanThuc + 
                (phanAo >= 0 ? " + " + phanAo + "i " : " " + phanAo + "i");  // (dkien ? (toán hạng 1) : (toán hạng 2)

            // toán tử 3 ngôi, trả về định dạng + bi (với b >= 0) hoặc - bi (nếu b < 0)   
            return result;
            
        }
    }
}
    
