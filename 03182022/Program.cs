using System;

namespace _03182022
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task-1
            //1. Parameter olaraq integer array variable-i ve bir integer value qebul eden ve hemin integer value-nu integer
            //array-e yeni element kimi elave eden metod.
            // Misal üçün int[] nums = { 1, 5, 7 } deyə bir variable - mız var.
            // yazdığımız metodu çağırıb arqument olaraq nums və 3 göndərsək nums arrayının dəyəri  { 1,5,7,3}
            //olmalıdır.
            int[] array = { 7, 8, 9 };
            int newnum = 5;
            addNum(ref array, newnum);
            foreach(var nums in array)
            {
                Console.WriteLine(nums);
            }

            #endregion

            //7.Verilmis n ededinin son reqemini onun evveline getirerek yeni bir eded duzeldin
            //(misalcun daxil edilen eded 475 olarsa, geriye 547 qaytarsin).


            //string number = "234";
            //Console.WriteLine(ChangeDigit(number));

            #region Task-2
            //2. Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq
            //hala gətirən metod.Misal olaraq, name = " Hikmet  Abbasov " deyə bir variable - mız varsa onu yaratdigimiz
            //metoda göndərdikdə variable-daki dəyər "HikmətAbbasov" olmalıdır.


            //string words = "  Ayten     Zeynalova ";
           // rmvSpace(ref words);




            #endregion



            #region Task-3
            //3. Qəbul etdiyi integer parametrə həmin parametrin dəyərinin ən yaxın kökaltı dəyərini mənimsədən metod - misal üçün,
            //int num = 35 variable-mız var.Bu variable-ı həmin metoda göndərdikdə variable-ın dəyəri 5 olmalıdır.

            //int reqem;
            //int kok;
            //Console.WriteLine("include number:");
            //reqem = Convert.ToInt32(Console.ReadLine());
            //kok = 0;
            //Console.WriteLine(SquareRoot(reqem, kok));


            #endregion

        }


        #region Task-3
        static int SquareRoot(int number, int root)
        { 

            if (number > 0)
            {
                for (int i = 1; i < number; i++)
                {
                    if (i * i <= number)
                    {
                        root = i;
                    }

                }
            }

            return root;

        }

        #endregion

        #region Task-1
        static void addNum(ref int[] numbers, int num)
        {
            int[] newarr = new int[numbers.Length + 1];
            for (int i = 0; i < newarr.Length - 1; i++)
            {
                newarr[i] = numbers[i];
            }
            newarr[numbers.Length] = num;

            numbers = new int[numbers.Length + 1];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = newarr[i];
            }

        }
        #endregion


        #region Task-2
        static void rmvSpace(ref string word)
        {
            
           
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == )
                {

                }
                
            }
            Console.WriteLine(word);
        }




            #endregion




            static int ChangeDigit(string number)
        {
            int last= number[number.Length-1];
            int first=number[0];
            

            for (int i = 0; i < number.Length; i++)
            {
                if (true)
                {
                   first= first * 0 + number[number.Length - 1];
                    last = last * 0 + number[0];

                }
                
            }
            return Convert.ToInt32(number);




        }


    }
}
