using System;
using System.Text;

class baihaiasm
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.BackgroundColor = ConsoleColor.Magenta;
        bool program = true;

        while (program)
        {
            Console.WriteLine("===== HELLO =====");
            Console.WriteLine("1. Giải phương trình bậc 1");
            Console.WriteLine("2. Giải phương trình bậc 2");
            Console.WriteLine("3. Exit");
            Console.Write("Nhập lựa chọn của bạn: ");

            string luachon = Console.ReadLine();//nhap vao lua chon

            switch (luachon)
            {
                case "1":
                    phuongtrinhbacnhat();//goi ham neu chon 1 se dan vao ham slove equation
                    break;
                case "2":
                    phuongtrinhbachai();//neu chon 2 se nhay vao ham thu 2 solve quadratic
                    break;
                case "3":
                    program = false;//neu k phai 1 2 thi dung
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");// ngoai 1 2 3 defau in ra thoaat
                    break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Chương trình kết thúc.");
        Console.ReadLine();
    }

    static void phuongtrinhbacnhat()
    {
        Console.WriteLine("Giải phương trình bậc 1");
        Console.Write("Nhập hệ số a: ");
        double a = double.Parse(Console.ReadLine()); //nghi ngay den kieu double chinh xac nhat
        Console.Write("Nhập hệ số b: ");   // nhap vao gia tri a va b
        double b = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phương trình có vô số nghiệm.");
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
        }
        else
        {
            double x = (-b / a);
            Console.WriteLine("Nghiệm của phương trình là: x =" +x);
        }
    }

    static void phuongtrinhbachai()
    {
        Console.WriteLine("Giải phương trình bậc 2");
        Console.Write("Nhập hệ số a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhập hệ số b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhập hệ số c: ");
        double c = double.Parse(Console.ReadLine());

        double delta = (b * b )- (4 * a * c); //khai bao denta

        if (delta < 0)//neu denta < 0 pt vo nghiem va neu delta=0 co nghiem -b/2a nguoc lai denta>0 
        {
            Console.WriteLine("Phương trình vô nghiệm.");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Phương trình có nghiệm kép: x = {0}", x);
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);//ham math nay de tinh can bac 2 cua delta
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);// nghia la -b + căn delta /2a và -b - căn đelta/2a
            Console.WriteLine("Phương trình có hai nghiệm phân biệt:");
            Console.WriteLine("x1 = ", +x1);
            Console.WriteLine("x2 = ", +x2);
        }
    }
}
