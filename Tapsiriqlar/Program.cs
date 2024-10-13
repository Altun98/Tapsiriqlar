using System.Security.Cryptography.X509Certificates;
using Tapsiriqlar.Tapsiriq;

namespace Tapsiriqlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tapsiriq23
            // 3 ededin cemini tapan sade int metodu
            //int cem = TapsiriqNumber23.ThreeNumberSum(74, 25, 84);
            //Console.WriteLine(cem);
            #endregion
            #region Tapsiriq24
            // int ededinin birinci reqemini geri qaytaran Extension method 
            // IntExtMetod24.GetOneNumber(38451);
            #endregion
            #region Tapsiriq25
            //array qaytaran ve hemin arrayin max ve min elementlerini out ile geri qaytaran metod yazmaq
            //int[] arrayL = ArrayMaxMin.GetMaxNin(out int maximum,out int minumum);
            //foreach (var item in arrayL)
            //{
            //    Console.Write(item+",");
            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine($"arrayin max:{maximum} arrayin minimumu:{minumum}");
            #endregion
            #region Tapsiriq26
            /*
             * while ile 3,3 e kv arrayi random doldurmaq
             * ic ice iki  for vasitesile  3x3 olculu massivin
             * doldurulmasi ve ekrana cixarilmasi
             * */
            //int[,] _array = new int[3, 3];
            //Random rd = new Random();
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        _array[i, j] = rd.Next(1, 25);
            //        Console.Write(_array[i, j] + ",");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Tapsiriq27
            //// massivin icinde olan tek ededleri gosterne ext method 
            //int[] arrayB = { 23, 44, 56, 67, 89, 3, 45, 67, 0, 31, 26, 77, 87, 88, 90, 43, 22, 20, 16, 18 };
            //arrayB.ArrayTek();
            #endregion
            #region Tapsiriq28
            //int deyisenini tersine stringe ceviren helper class ve metod   
            //helper class ve ya method dedikde hemin metod ve ya klasin statik olacaqi melum olur/
            //int number1 = 3456789;
            //number1.IntConvertString();
            #endregion
            #region Tapsiriq29
            // fiqurlarin sahesi  barede ovveroid method yazmaq
            // method seviyyesinde ovveroid metodun prametresinin tipine ve sayina gore olur
            //MethodOvveroid md = new MethodOvveroid();
            //md.Sahe(2);//kvadrar
            //md.Sahe(3, 4);//duzbucaqli
            #endregion
            #region Tapsiriq30  
            //partial  claslar bir clasin bir nece yere bolunmesidir  ve hemin hisseler
            //bir klas kimi rahatliqla davrana bilir
            //PartialClass pc = new PartialClass();
            //pc.ID = 1;
            //pc.Name = "Abbas";
            //pc.Surname = "Abdullayev";
            //pc.Age = 22;
            //pc.EduType = "Ali";
            //pc.EduName = "AZTU";
            //pc.PhoneNumber1 = "070-700-00-00";
            //pc.PhoneNumber2 = "055-555-55-55";
            //pc.Address = "Xalqlar dosdluqu";
            //pc.Print();

            #endregion
            #region Tapsiriq31
            //int[] arrayCevir = { 47, 75, 4, 1452, 25, 36, 87, 456, 2 };
            //ArrayMethods arM = new ArrayMethods();
            //arM.ArrMaxMinConvert(arrayCevir);
            #endregion
            #region Tapsiriq32
            // switch operatorunun izahi Dersde izah edecem
            #endregion
            #region Tapsiriq33  
            //boyuk herflerin kodlarin ekrana cixartmaq
            #endregion
            Console.ReadKey();
        }
    }
}