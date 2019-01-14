using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkshopMSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n***************************** GET / SET *****************************");
            #region Get / Set

            BaseModel bm = new BaseModel();

            bm.SetId(1);
            bm.BaseId = 1;
            bm.ExtendedId = 1;

            Console.WriteLine(" Varianta 1 - Java Style: {0} \n Varianta 2: {1} \n Varianta 3: {1}", bm.GetId(), bm.BaseId, bm.ExtendedId);

            #endregion

            Console.WriteLine("\n***************************** Indexatori *****************************");
            #region Indexatori
            // Java Style
            //ArrayList<int> list = new ArrayList<int>(); / /OR LinkedList

            // C# Style
            List<int> list = new List<int>();  // OR LinkedList
            for (var i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            //Java style 
            //int xJava = list.get(3);

            //C# style
            int xCsharp = list[3];

            Console.WriteLine("List[3]={0}", xCsharp);

            // Suplimentar - Implementarea indexatorilor
            BaseList<int> gList = new BaseList<int>();
            gList[0] = 4;
            Console.WriteLine("gList[0]={0}", xCsharp);

            #endregion

            Console.WriteLine("\n***************************** Ref *****************************");
            #region Ref
            int xRef = 1;

            Console.WriteLine("xRef - Inainte = {0}", xRef);

            BaseFunction.MultiplyNumber(ref xRef);

            Console.WriteLine("xRef - Dupa = {0} \n", xRef);

            // Java Style: NU SE POATE
            // ALTERNATIVA: 
            int xRefJava = 1;

            Console.WriteLine("xRefJava - Inainte = {0}", xRefJava);

            xRefJava = BaseFunction.MultiplyNumberJavaStyle(xRefJava);

            Console.WriteLine("xRefJava - Dupa = {0}", xRefJava);

            #endregion

            Console.WriteLine("\n***************************** Out *****************************");
            #region Out

            // Varianta 1
            int xOut;

            // Genereaza eroare
            //Console.WriteLine("xOut = {0}", xOut);

            BaseFunction.GetAnyNumber(out xOut);

            // Varianta 2
            BaseFunction.GetAnyNumber(out int xOut2);


            Console.WriteLine("xOut = {0}", xOut);
            Console.WriteLine("xOut2 = {0}", xOut2);

            // Alternativa Java - Nu exista. Varibila trebuie initiata

            #endregion

            Console.WriteLine("\n***************************** ExtensionFunctions *****************************");
            #region ExtensionFunctions

            // Doar in C#
            string myString = "Ana are portocale";
            Console.WriteLine(myString.RemoveAllA());

            #endregion

            Console.WriteLine("\n***************************** Enums *****************************");
            #region Enums
            int luni = (int)BasicEnum.Luni;

            // Java
            //int luniJava = BasicEnumJava.Luni.getValue();
            Console.WriteLine("luni = {0}", luni);
            #endregion

            Console.WriteLine("\n***************************** Var *****************************");
            #region Var
            // Var poate fi utilizat doar ca variabile de functie si nu ca atribute de clasa
            int varDefaultValue = 1;
            var temp = varDefaultValue;

            Console.WriteLine("VAR: {0} == {1}", varDefaultValue, temp);

            // In Java, incepand cu versiunea 10
            #endregion

            Console.WriteLine("\n***************************** Polimorfism *****************************");
            #region Polimorfism
            /* Java permite polimorfismul by deafult. C# NU - doar folosind keyword-ul virtual */

            PolymorphismClass pc = new PolymorphismClass();
            pc.DuplicateBad();
            pc.DuplicateGood();

            Console.WriteLine("IdBad = {0} ----- IdGood = {1}", pc.IdBad, pc.IdGood);
            #endregion

            Console.WriteLine("\n***************************** LINQ / stream + functii lambda *****************************");
            #region LINQ / stream + functii lambda
            /* 
                Au inceput de curand ceva asemanator, si anume "stream"
             */

            // Java
            //List<SmallUser> otherClients = list.getList().stream()
            //    .map(c-> PrepareSmallUser(c)) -> Nu permite crearea unei clase custom sau selectarea anumitor campuri
            //    .filter(c-> c.getId() != id)
            //    .sort( NECESITE UN COMPARATOR PREDEFINIT )
            //    .collect(Collectors.toList());

            // C#
            List<User> userList = new List<User>();
            userList = PrepareUserListForTest();
            List<SmallUser> resultList = userList
                    .Where(c => c.Age > 18)
                    .Select(c => new SmallUser() { Id = c.Id, FirstName = c.FirstName })
                    .OrderByDescending(c => c.Id)
                    .ToList();

            resultList.ForEach(Console.WriteLine);

            Console.WriteLine(userList.Any(c => c.Gender.Equals("Ms")));
            #endregion
        }

        static List<User> PrepareUserListForTest()
        {
            return new List<User>()
            {
                new User(){ Id = 6, FirstName = "Arya", LastName = "Stark", Age = 12, DogName = "Nymeria", Gender = "F"},
                new User(){ Id = 2, FirstName = "Sansa", LastName = "Stark", Age = 16, DogName = "Lady", Gender = "F"},
                new User(){ Id = 8, FirstName = "Robb", LastName = "Stark", Age = 31, DogName = "Grey Wind", Gender = "M"},
                new User(){ Id = 9, FirstName = "Bran", LastName = "Stark", Age = 35, DogName = "Summer", Gender = "M"},
                new User(){ Id = 3, FirstName = "Rickon", LastName = "Stark", Age = 20, DogName = "Shaggydog", Gender = "M"},
                new User(){ Id = 4, FirstName = "Jon", LastName = "Snow", Age = 29, DogName = "Ghost", Gender = "M"},
                new User(){ Id = 1, FirstName = "Jennifer", LastName = "Aniston", Age = 52, DogName = "Cliford", Gender = "F"},
                new User(){ Id = 5, FirstName = "Justin", LastName = "Timberlake", Age = 10, DogName = "Rex", Gender = "M"},
                new User(){ Id = 7, FirstName = "Marshall", LastName = "Mathers", Age = 8, DogName = "Kenzo", Gender = "M"},
                new User(){ Id = 10, FirstName = "Traian", LastName = "Basescu", Age = 67, DogName = "Hachiko", Gender = "M"}
            };
        }
    }

}
