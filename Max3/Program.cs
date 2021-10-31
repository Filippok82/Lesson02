/* Максимальное из трех */

int max(int a, int b, int c)
{
    if (a > b) return a; 
    if (b > c) return b; else return c;   
}

Console.WriteLine(max(99, 25, 47));