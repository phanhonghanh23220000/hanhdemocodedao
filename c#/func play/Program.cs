using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func_play
{
    internal class Program
    {
        static void dientichhinhtron()
        {

        }
        static void dientichhinhchunhat()
        {

        }
        static void dientichhinhtamgiac()
        {

        }
        static void chuvihinnhtamgiac()
        {

        }
        static void chuvihinhchunhat()
        {

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập giá trị r = ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập giá trị a = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập giá trị b = ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập giá trị h = ");
            double h = double.Parse(Console.ReadLine());
            

            Console.WriteLine("     ============== HELLO=============    ");
            Console.WriteLine(" -------   VUI LÒNG CHỌN CHỨC NĂNG     --------");
            Console.WriteLine(" Bấm phím 1 : TÍNH DIỆN TÍCH HÌNH TRÒN");
            Console.WriteLine(" Bấm phím 2: TÍNH DIỆN TÍCH HÌNH CHỮ NHẬT");
            Console.WriteLine(" Bấm phím 3: TÍNH DIỆN TÍCH HÌNH TAM GIÁC");
            int choice = int .Parse(Console.ReadLine());
            switch (choice)
            {       

                    case 1:
                    double t = (3.14 * r *r ) ; 
                    Console.WriteLine("DIỆN TÍCH HÌNH TRÒN LÀ :" + t);
                    break;
                    case 2:
                    double n = (a * b);
                    Console.WriteLine("DIỆN TÍCH HÌNH CHỮ NHẬT LÀ : " + n);
                    break;
                    case 3:
                    double tg  = (1/2 * a * h );
                    Console.WriteLine("DIỆN TÍCH HÌNH TAM GIÁC LÀ: " + tg);
                    break;
                default:
                    Console.WriteLine(" BẠN ĐÃ NHẬP SAI CHỨC NĂNG");
                    Console.ReadKey();
                    break;
                


            }
            dientichhinhchunhat();
            dientichhinhtron();
            dientichhinhtamgiac();
            
            Console.ReadLine();
        }
    }
}
