// Заполнение массива случайными числами

int[] a = new int[10];// Создание массива
Random random;//Описание random
random = new Random();//Создание random
for(int i=0;i<10;i++)
{
  a[i]=random.Next (0,100);
}
for(int i=0;i<10;i++)
{
  Console.Write(a[i]+" ");
}
