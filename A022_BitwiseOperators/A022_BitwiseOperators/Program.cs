namespace A022_BitwiseOperators
{
    internal static class Program
    {
        static void Main()
        {

            int x = 14 , y = 11, result;

            result = x | y;
            Console.WriteLine("{0} | {1} = {2}",x,y,result);

            result = x & y;
            Console.WriteLine("{0} & {1} = {2}", x, y, result);

            result = x ^ y;
            Console.WriteLine("{0} ^ {1} = {2}", x, y, result);

            result = ~x;
            Console.WriteLine("~{0} = {1}", x, result); //x�� ����

            result = x << 2;
            Console.WriteLine("{0} << 2 = {1}", x, result); //x�� �������� 2��Ʈ ����Ʈ

            result = x >> 1;
            Console.WriteLine("{0} >> 1 = {1}", y, result); //y�� ���������� 1��Ʈ ����Ʈ
        }
    }
}