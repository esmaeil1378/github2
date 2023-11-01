int a=int.Parse(Console.ReadLine());
string s = a switch
{
    1=>"one",
    2=>"two",
    3=>"three",
    _=>"error"
};
Console.WriteLine($"number is :{s}");

//class program
//{

//    static void Main()
//    {

//        Console.WriteLine("please enter a number :");
//        int num;
//        num = int.Parse(Console.ReadLine());
//        switch (num)
//        {
//            case 1:
//                Console.WriteLine("one 1");
//                break;
//            case 2:
//                Console.WriteLine("two 2");
//                break;
//            case 3:
//                Console.WriteLine("three 3");
//                break;
//            default:
//                Console.WriteLine("error");
//                break;
//        }




//    }

//}