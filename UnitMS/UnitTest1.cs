using ModulPm;

namespace UnitMS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 2;
            double b = 1;
            double oresult = a + b; //��������� ���������
            Methods methods = new Methods();

            double fresult = methods.Amount(a, b); //����������� ���������
            fresult.Equals(oresult);

        }

    }
}