using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_SE06205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Khai báo mảng số nguyên có 5 phần tử
            //int[] arr1 = new int[5];
            //// Khai báo mảng chuỗi vơí các giá trị ban đầu
            //string[] arr2 = { " Hương", "Thao", "Minh" };
            ////Truy cập đến các phần tử 
            //Console.WriteLine(arr1[1]);
            ////Tim kich thuoc cua mang(so phan tu trong mang)
            //Console.WriteLine(arr2.Length);
            //// in lan luot cac phan tu cua mang
            //for(int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine(arr1[i]);

            //}
            //// Hoac dung vong loop foreach
            //foreach(string item in arr2)
            //{
            //    Console.WriteLine(item);
            //}
            //// Nhap cac phan tu cho mang kich thuoc n tu ban phim
            //Console.WriteLine("n = ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr3 = new int[n];
            //for(int i = 0; i < n;i++)
            //{
            //    Console.Write(" Moi ban nhap phan tu thu " + i + ": ");
            //    arr3[i] = int.Parse(Console.ReadLine());
            //}            
            //// in ra cac phan tu ccua mang ttren cung 1 dong, cach nhau boi dau cach
            //for(int i = 0; i < n; i++)
            //{
            //    Console.Write(arr3[i] + " ");
            //}
            //Console.ReadLine();

            // Bai1: Tinh tong cac phan tu cua mang
            int[] arr = new int[5];
            int sum = 0;

            Console.WriteLine("Nhập vào 5 số nguyên:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }

            Console.WriteLine("Tổng các phần tử trong mảng là: " + sum);
            Console.ReadLine();

            // Bai 2 in ra phan tu lớn nhất
            int[] arr = new int[] { 3, 7, 2, 8, 1, 9, 4 };
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine("Các phần tử lớn nhất trong mảng là:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == max)
                {
                    Console.WriteLine(arr[i]);

                }



            }
        
        
        }
