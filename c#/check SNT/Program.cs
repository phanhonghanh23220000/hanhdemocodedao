using System;

namespace BaiTapCSharp
{
    class Program
    {
        //Tạo hàm kiểm tra số chính phương với tham số truyền vào là một số nguyen a
        static bool soCP(int n)
        {
            int sqr = (int)Math.Sqrt(n);
            if (sqr * sqr == n)
            {
                return true;
            }
            else return false;
        }

        static void Main(string[] args)
        {
            //khai báo biến n kiểu int là số phần tử của mảng.
            //sau đó yêu cầu người dùng nhập giá trị cho n
            Console.Write("\n Nhap vao so phan tu cua mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //khai báo một mảng arr kiểu double với số phần tử là n được nhập ở trên
            int[] arr = new int[n];

            //sử dụng vòng lặp for để lặp và yêu cầu người dùng nhập vào từng giá trị cho từng phần tử
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" Nhap vao gia tri cho phan tu thu {0}: ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //sử dụng vòng lặp for lặp từng phần tử trong mảng,
            //mỗi lần lặp ta gọi hàm kiểm tra số chính phương để kiểm tra phần tử đó, nếu là số hoàn hảo thì hiển thị ra màn hình.
            Console.Write("\n Cac so chinh phuong co trong mang la: ");
            for (int i = 1; i < n; i++)
            {
                if (soCP(arr[i]))
                {
                    Console.Write(arr[i] + " ");
                }
            }

            Console.WriteLine("\n-----Chuong trinh nay duoc dang tai Freetuts.net---");
        }
    }
}