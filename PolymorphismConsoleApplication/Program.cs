// ---------------------------------------------+
// Main application to test all the logic of the        
// polymorphism class library.                        
// ---------------------------------------------+

using System;
using PolymorphismClassLibrary.DynamicPolymorphism.DelegatePolymorphism;
using PolymorphismClassLibrary.DynamicPolymorphism.InterfacePolymorphism;
using PolymorphismClassLibrary.DynamicPolymorphism.MethodOverriding;
using PolymorphismClassLibrary.DynamicPolymorphism.PropertyOverriding;
using PolymorphismClassLibrary.StaticPolymorphism;

namespace PolymorphismConsoleApplication
{
    /// <summary>
    /// Class containing starting point of the program 
    /// and all the test methods.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Starting point of the program.
        /// </summary>
        public static void Main()
        {
            try
            {
                //Program.MethodOveloadingTest();

                //Program.AdditionOperatorTest();
                //Program.SubstrationOperatorTest();
                //Program.MultiplicationOperatorTest();
                //Program.DivitionOperatorTest();

                //Program.SayHelloTest();
                //Program.SayByeTest();

                //Program.PlayingGuiterTest();
                //Program.PlayingPianoTest();

                //Program.SqlServerTest();
                //Program.OracleTest();
                //Program.MySqlTest();

                //Program.EnterToCollegeTest();

                //Program.IndexerOverloadingTest();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey(true);
            }
        }

        #region Method Overloading Test
        private static void MethodOveloadingTest()
        {
            MethodOverloading theMethodOverloading = new MethodOverloading();
            Console.WriteLine(theMethodOverloading.Addition(12, 22, 10, 34, 55, 33, 33));
        }
        #endregion

        #region Operator Overloading Test
        private static void AdditionOperatorTest()
        {
            OperatorOverloading sourceOperatorOverloading1 = new OperatorOverloading(10, 20);
            OperatorOverloading sourceOperatorOverloading2 = new OperatorOverloading(20, 30);

            OperatorOverloading targetOperatorOverloading = sourceOperatorOverloading1 + sourceOperatorOverloading2;

            Console.WriteLine("X = {0}, Y = {1}", targetOperatorOverloading.X, targetOperatorOverloading.Y);
        }

        private static void SubstrationOperatorTest()
        {
            OperatorOverloading sourceOperatorOverloading1 = new OperatorOverloading(10, 20);
            OperatorOverloading sourceOperatorOverloading2 = new OperatorOverloading(20, 30);

            OperatorOverloading targetOperatorOverloading = sourceOperatorOverloading1 - sourceOperatorOverloading2;

            Console.WriteLine("X = {0}, Y = {1}", targetOperatorOverloading.X, targetOperatorOverloading.Y);
        }

        private static void MultiplicationOperatorTest()
        {
            OperatorOverloading sourceOperatorOverloading1 = new OperatorOverloading(10, 20);
            OperatorOverloading sourceOperatorOverloading2 = new OperatorOverloading(20, 30);

            OperatorOverloading targetOperatorOverloading = sourceOperatorOverloading1 * sourceOperatorOverloading2;

            Console.WriteLine("X = {0}, Y = {1}", targetOperatorOverloading.X, targetOperatorOverloading.Y);
        }

        private static void DivitionOperatorTest()
        {
            OperatorOverloading sourceOperatorOverloading1 = new OperatorOverloading(10, 20);
            OperatorOverloading sourceOperatorOverloading2 = new OperatorOverloading(20, 30);

            OperatorOverloading targetOperatorOverloading = sourceOperatorOverloading1 / sourceOperatorOverloading2;

            Console.WriteLine("X = {0}, Y = {1}", targetOperatorOverloading.X, targetOperatorOverloading.Y);
        }
        #endregion

        #region Delegate Polymorphism Test
        private static void SayHelloTest()
        {
            GetMessageForUserDelegate getMessageForUserDelegate;

            HelloUser helloUser = new HelloUser();
            getMessageForUserDelegate = helloUser.SayHello;

            SendMessageToUser sendMessageToUser = new SendMessageToUser();
            Console.WriteLine(sendMessageToUser.Send(getMessageForUserDelegate, "Rahul")); 
        }

        private static void SayByeTest()
        {
            GetMessageForUserDelegate getMessageForUserDelegate;

            ByeUser helloUser = new ByeUser();
            getMessageForUserDelegate = helloUser.SayHello;

            SendMessageToUser sendMessageToUser = new SendMessageToUser();
            Console.WriteLine(sendMessageToUser.Send(getMessageForUserDelegate, "Rahul"));
        }
        #endregion

        #region Method Overriding Test
        private static void PlayingGuiterTest()
        {
            PlayInstrument playInstrument = new PlayInstrument();
            Instrument instrument = new Guiter();

            Console.WriteLine(playInstrument.StartPlaying(instrument));
        }

        private static void PlayingPianoTest()
        {
            PlayInstrument playInstrument = new PlayInstrument();
            Instrument instrument = new Piano();

            Console.WriteLine(playInstrument.StartPlaying(instrument));
        }
        #endregion

        #region Interface Polymorphism Test
        private static void SqlServerTest()
        {
            IDatabase database = new SqlServer();
            UseDatabase useDatabase = new UseDatabase();

            Console.WriteLine(useDatabase.Use(database) + "\n");
        }

        private static void OracleTest()
        {
            IDatabase database = new Oracle();
            UseDatabase useDatabase = new UseDatabase();

            Console.WriteLine(useDatabase.Use(database) + "\n");
        }

        private static void MySqlTest()
        {
            IDatabase database = new MySql();
            UseDatabase useDatabase = new UseDatabase();

            Console.WriteLine(useDatabase.Use(database) + "\n");
        }
        #endregion

        #region Property Overriding Test
        private static void EnterToCollegeTest()
        {
            IStudent student = new CollegeStudent();

            EnterToCollege enterToCollege = new EnterToCollege();
            Console.WriteLine(enterToCollege.Enter(student));
        }
        #endregion

        #region Indexer Overloading
        private static void IndexerOverloadingTest() 
        {
            IndexerOverloading indexerOverloading = new IndexerOverloading();

            indexerOverloading[0] = "Rahul";
            indexerOverloading[1] = "Mita";
            indexerOverloading[2] = "Sam";

            Console.WriteLine(indexerOverloading["Position1"]);
            Console.WriteLine(indexerOverloading["Position2"]);
            Console.WriteLine(indexerOverloading["Position3"]);
        }
        #endregion
    }
}
