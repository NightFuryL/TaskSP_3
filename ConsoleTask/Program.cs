namespace ConsoleTask;
class Program
{
    unsafe static void SquareParam(int* p)
    {
        Console.WriteLine("Адреса: 0x{0:X}", (long)p);
        *p *= *p;
    }
    unsafe static void Main(string[] args)
    {
        int num = 10;

        SquareParam(&num);

        Console.WriteLine(num);
        UString str1 = new UString("Hello World!");
        Console.WriteLine(str1);
        Console.WriteLine(str1[5]);
        str1[0] = 'u';
        Console.WriteLine(str1);
        str1.Dispose();
        char[] chars = { 'a', 'b', 'c', 'e', 'f', 'g', 'h' };
        Console.WriteLine(chars);
        Console.WriteLine(FindFirstIndex(chars, 'f'));
    }
    public static unsafe void StackAllocUnsafe()
    {
        int* ptr = stackalloc int[100];
        for (int i = 0; i < 100; i++)
        {
            *(ptr + i) = i;
        }
    }
    public static void StackAllocSafe()
    {
        Span<int> buffer = stackalloc int[100];
        for(int i = 0;i < 100; i++)
        {
            buffer[i] = i;
        }
    }
    public static int FindFirstIndex(char[] data, char target)
    {
        // 1. Звичайна safe-частина: валідація
        if (data == null || data.Length == 0) return -1;

        // 2. Unsafe-блок
        unsafe
        {
            fixed (char* pStart = data)
            {
                char* ptr = pStart;
                char* pEnd = pStart + data.Length;

                while (ptr < pEnd)
                {                    
                    if (*ptr == target)
                    {
                        // Обчислюємо індекс через різницю адрес
                        // Садреса поточного елемента - адреса початку)
                        return (int)(ptr - pStart);
                    }
                    ptr++;
                }
            }

        }
        // 3. Знову safe-частина
        return -1;
    }
}