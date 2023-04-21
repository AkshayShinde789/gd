//Conditional Statements

// If Condition
// If ....Else Condition
//If ...elseif...elseif....else (ladder, chain)
// Ternary Opreator
// Case Staement
// Nested if else


class program
{
    static void Main()
    {



        //Console.WriteLine("****************Menu Card*********************");
        //Console.WriteLine("1. Biryani\n2. Chicken korma\n3. chicken 65\n4. Paneer Tika");
        //Console.WriteLine("Kay Khana Hai......? Bol Jaldi");
        //int a = Convert.ToInt32(Console.ReadLine());
        //#region ifcode
        ////if(a == 10)
        ////{
        ////    Console.WriteLine("You entered Ten");
        ////}
        ////Console.ReadLine();

        ////if (a == 10)
        ////{
        ////    Console.WriteLine("You entered Ten");
        ////}
        ////else if(a == 20) 
        ////{
        ////    Console.WriteLine("You  enterd twenty");
        ////}
        ////else if(a == 30) 
        ////{
        ////    Console.WriteLine("You enter Thirty");
        ////}
        ////else 
        ////{
        ////    Console.WriteLine("You entered wrong no.");
        //// }


        ////if(a == 10)
        ////{
        ////    Console.WriteLine( "Right");
        ////}
        ////if (a == 20)
        ////{
        ////    Console.WriteLine("Right");
        ////}
        ////if (a == 30)
        ////{
        ////    Console.WriteLine("Right");
        ////}
        ////if (a == 40)
        ////{
        ////    Console.WriteLine("Right");
        ////}
        ////if (a == 50)
        ////{
        ////    Console.WriteLine("Right");
        ////}
        ////if (a == 60)
        ////{
        ////    Console.WriteLine("Right");
        ////}
        ////if (a == 70)
        ////{
        ////    Console.WriteLine("Right");
        ////}

        //////else
        //////{
        //////    Console.WriteLine("Wrong");
        //////}
        /////     condition? true : false      ? :

        ////string result = (a == 10) ? "Ten" : "Not Ten";
        ////Console.WriteLine(result);

        //#endregion

        //// CASE STATEMENT

        //switch (a)
        //{
        //    case 1:
        //        Console.WriteLine("You Order Biryani.");
        //        break;
        //    case 2:
        //        Console.WriteLine("You Order Chicken korma");
        //        break;
        //    case 3:
        //        Console.WriteLine("You Order chicken 65");
        //        break;
        //    case 4:
        //        Console.WriteLine("You Order Paneer Tika");
        //        break;
        //    default:
        //        Console.WriteLine("You press Wrong key");
        //        break;
        //}

        Console.WriteLine("Enter 1st number");
        int a=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter 2nd number");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter 3rd number");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a > b)
        {
            if(a > c)
            {
                Console.WriteLine("A number is greater");
            }
            else
            {
                Console.WriteLine(" C number is greater" );
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine("B Number is greater");
            }
            else
            {
                Console.WriteLine("C Number is Greater");
            }

        }


        Console.ReadLine();


    }
}