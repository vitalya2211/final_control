using System;

namespace final_control
{
    class Program
    {
        static void Main(string[] args)
        {
            /*необходимо:
            1. Создать репозиторий на GitHub
            2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной 
            части, если вы выделяете ее в отдельный метод)
            3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
            4. Написать программу, решающую поставленную задачу
            5. Использовать контроль версий в работе над этим небольшим проектом 
            (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 
            должны быть расположены в разных коммитах)
            **Задача**: Написать программу, которая из имеющегося массива строк формирует 
            массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив
            можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
            При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно 
            массивами.
            **Примеры**:
            ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
            ["1234", "1567", "-2", "computer science"] -> ["-2"]
            ["Russia", "Denmark", "Kazan"] -> []
             */
            void printString(string[] vs)
            { //for (int i = 0; i < vs.Length; i++)
               foreach (string i in vs)
                Console.Write(i + '\t');
                Console.WriteLine();
            }
            string sizeString(string[] vs)
            {
                string str = null;
                for (int i=0;i<vs.Length;i++)
                {
                    
                    if (vs[i].Length <= 3)
                        str += vs[i] + ' ';
                }
                return str;
            }
            //string sizeString(string[] vs,string[] vs2,string[]vs3)
            //{
            //    string str=null;
            //    for(int i=0;i<vs.Length;i++)
            //    {
            //        if (vs[i].Length <= 3)
            //            str += vs[i] + " ";
            //    }
            //    for(int i=0;i<vs2.Length;i++)
            //    {
            //        if (vs2[i].Length <= 3)
            //            str += vs2[i] + " ";
            //    }
            //    for (int i = 0; i < vs3.Length; i++)
            //    {
            //        if (vs3[i].Length <= 3)
            //            str += vs3[i] + " ";
            //    }
            //        return str;
            //}
            //Console.WriteLine("вариант первый, для дальнейшего использования контроля версий.\n " +
            //   "Выбор из заданных массивов строк, данных меньше либо равных 3 символам");
            Console.WriteLine("введите данные в массив, разделяя пробелом: ");
            string[] value = Console.ReadLine().Split(' ');
            string[] ferst= { "hello", "2", "world", ":-)" }, second= { "1234", "1567", "-2", "computer science" },
                third= { "Russia", "Denmark", "Kazan" };
            
            Console.WriteLine("имеющиеся массивы: ");
            //printString(ferst);
            //printString(second);
            //printString(third);
            //Console.WriteLine( sizeString(ferst,second,third));
            Console.WriteLine(sizeString(value));
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
