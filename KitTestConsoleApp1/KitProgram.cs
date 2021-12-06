using System;

namespace KitTestConsoleApp1
{
    public class KitProgram
    {
        internal KitProgram p; 

        public static void Main(string[] args)
        {
            Console.WriteLine("Kit Hello World Begin");
            KitProgram p = new KitProgram();
            p.Method();

            Console.WriteLine("Kit Hello World End");
            Environment.Exit(0);

        } //Main

        public void Method()
        {
            try
            {
                p.Method1();
                p.Method2();
            }
            catch (Exception e)
            {
                Console.WriteLine("Method Catched Exception" + e.ToString());
            }
        }
                              

        public void Method1() {
                Console.WriteLine("Method1 begin"); 
                try
                {
                    int Number1 = 10;
                    int NUmber2 = 1;
                    int Result = Number1 / NUmber2; 

                }
                catch (Exception e1)
                {
                    Console.WriteLine("Method1 catched Exception " + e1.ToString());
                    throw; 
                }
                Console.WriteLine("Method1 end");
        } // Method1

        public void Method2()
        {
            Console.WriteLine("Method2 begin");
            try
            {
                int Number1 = 10;
                int NUmber2 = 0;
                int Result = Number1 / NUmber2;

            }
            catch (Exception e2)
            {
                Console.WriteLine("method2 catched Exception " + e2.ToString());
                throw;
            }
            Console.WriteLine("Method2 end");
        } // Method2


        //        Console.WriteLine("Kit Hello World!");
        //
        //        if (args.Length > 0)  {
        //            Console.WriteLine(string.Format("{0} {1} {2} {3} {4} {5}", args.Length, args[0], args[1], args[2], args[3], args[4])
        //                      ) ;
        //            //Console.WriteLine("string.Format:");
        //            //Console.WriteLine("{G}", args.Length);
        //            //Console.WriteLine("{G} {G} {G} {G} {G}"
        //            //                  , System.Convert.ToInt32(args[0])
        //            //                  , System.Convert.ToInt32(args[1])
        //            //                  , System.Convert.ToInt32(args[2])
        //            //                  , System.Convert.ToInt32(args[3])
        //            //                  , System.Convert.ToInt32(args[4])
        //            //                  );
        //            Console.WriteLine("G Format:");
        //            Console.WriteLine(args.Length);
        //            Console.WriteLine(Convert.ToInt32(args[0]) ) ;
        //            Console.WriteLine(Convert.ToInt32(args[1]) ) ;
        //            Console.WriteLine(Convert.ToInt32(args[2]) ) ;
        //            Console.WriteLine(Convert.ToInt32(args[3]) ) ;
        //            Console.WriteLine(Convert.ToInt32(args[4]) ) ;

        //            //                , System.Convert.ToInt32(args[0])
        //            //                , System.Convert.ToInt32(args[1])
        //            //                , System.Convert.ToInt32(args[2])
        //            //                , System.Convert.ToInt32(args[3])
        //            //                , System.Convert.ToInt32(args[4])

        //            //Console.WriteLine("{G7} {G7} {G7} {G7} {G7}"
        //            //                  ,System.Convert.ToInt32(args[0])
        //            //                  ,System.Convert.ToInt32(args[1])
        //            //                  ,System.Convert.ToInt32(args[2])
        //            //                  ,System.Convert.ToInt32(args[3])
        //            //                  ,System.Convert.ToInt32(args[4])
        //            //                  );
        //        }
        //        else {
        //            Console.WriteLine("There is No Arguments");
        //        };
        //         //ERROR Console.WriteLine("args.Length = ' , args.Length , "args0 = " , args[0] , "args1 = " , args[1] );
        //        
        //   
        //    }
        //
        //    //ERROR - ARGS NOT RECOGNIZED
        //    //public static void TestArguments() {
        //    //    Console.WriteLine("Args0 = " + args[0] + "Args1 = " + args[1] );
        //    //}



    }  // class
} // namespace
