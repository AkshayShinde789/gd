// comments: single line, multiple line
//
/*

Collapse:- ctrl+m+o

*/


// Region:-  

#region First
/*class program
{
    static void Main()
    {
        Console.WriteLine("Batch 20 GD");
    }
}*/
#endregion 


// Type Conversion
// 1. Implicit :--copmlier Auto   convert datatype

//class program
//{
//    static void Main()
//    {
//        byte v1 = 10;
//        int v2 = v1;

//        //float v1 = 365.46523f;
//        //double v2 = v1;

//        Console.WriteLine(v2);

//        Console.ReadLine();
//    }
//}

// 2. Explicit :-

class Program
{
    static void Main()
    {
        #region Cast
        //long v1 = 123456789109273;
        //short v2 =(short) v1;

        decimal v1 = 1235454565745657.567m;
        float v2 = (short)v1;

        //long v1 = 123;
        //short v2 =(short) v1;
        #endregion

        // COvert class method

        //string number = "100";
        ////int a = number; ......error
        //int a= Convert.ToInt32(number);

        //string s1 = "Sagar";
        //int a =Convert.ToInt32 (s1);
        //a = (int)s1;


        Console.WriteLine(a);

        Console.ReadLine();
    }

}