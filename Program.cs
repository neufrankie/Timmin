using System;

namespace FindMinValueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo mảng số nguyên
            int[] array = {4, 12, 7, 8, 1, 6, 9};

            // Gọi phương thức MinValue để tìm vị trí của phần tử có giá trị nhỏ nhất
            int minIndex = MinValue(array);

            // Hiển thị kết quả
            Console.WriteLine("Gia tri nho nhat nam o vi tri: " + minIndex);
            Console.WriteLine("Gia tri nho nhat trong mang la: " + array[minIndex]);
        }

        // Phương thức tìm kiếm giá trị nhỏ nhất trong mảng
        public static int MinValue(int[] array)
        {
            // Kiểm tra mảng có rỗng hay không
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Mảng không được rỗng.");
            }

            // Khởi tạo biến minIndex để lưu vị trí của giá trị nhỏ nhất
            int minIndex = 0;

            // Duyệt qua mảng để tìm giá trị nhỏ nhất
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }

            // Trả về vị trí của phần tử có giá trị nhỏ nhất
            return minIndex;
        }
    }
}
