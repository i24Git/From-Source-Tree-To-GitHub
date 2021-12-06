using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KitTestConsoleApp1.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("unittest1 - Method1 begin");
            //Arrange 
            KitProgram p = new KitProgram();
            //Action
            Exception exception = null;
            try
            {
                p.Method1();
                Assert.Fail("An exception should have been thrown"); // If it gets to this line, no exception was thrown                 
            }
            catch (Exception e)
            {

                Console.WriteLine("UnitTest Exception is Catched while running Method1");
                //Method1 Catched Exception: {"Attempted to divide by zero."}
                //Method1 Catched Exception Type: {"Attempted to divide by zero."}                Assert.AreEqual("Exception Catched." , e.Message );

                //Assert.Fail("Should have Exception above", e.Message);
                exception = e; 

            }

            //Assert.IsNotNull(exception);
            Assert.IsNull(exception);




            //Assert.AreEqual("System.DivideByZeroException", e.Message );
            // Assert.AreEqual("Exception Catched.", e.Message);

            //Assert.Fail("Should have Exception above", ex.Message);


            //catch (ArgumentNullException ae)
            //{
            //    Assert.AreEqual("Parameter cannot be null or empty.", ae.Message);
            //}
            //catch (Exception e)
            //{
            //}                          

            //Assert
            Console.WriteLine("unittest1 - Method1 end");
        } // Method1



        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("unittest1 - Method2 begin");
            //Arrange 
            KitProgram p = new KitProgram();
            //Action
     //       try 
     //       {
                p.Method1();
     //           Assert.Fail("An exception should have been thrown"); // If it gets to this line, no exception was thrown                 
     //       }
     //       catch (Exception e)
     //       {

     //           Console.WriteLine("UnitTest Exception is Catched while running Method1");
                //Method1 Catched Exception: {"Attempted to divide by zero."}
                //Method1 Catched Exception Type: {"Attempted to divide by zero."}                Assert.AreEqual("Exception Catched." , e.Message );

                //Assert.Fail("Should have Exception above", e.Message);

     //       }

            //Assert.AreEqual("System.DivideByZeroException", e.Message );
            // Assert.AreEqual("Exception Catched.", e.Message);

            //Assert.Fail("Should have Exception above", ex.Message);


            //catch (ArgumentNullException ae)
            //{
            //    Assert.AreEqual("Parameter cannot be null or empty.", ae.Message);
            //}
            //catch (Exception e)
            //{
            //}                          

            //Assert




            Console.WriteLine("unittest1 - Method2 end");
        } // Method2









    } // class
} // namespace
