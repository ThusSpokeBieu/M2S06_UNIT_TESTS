namespace NUnitProject;
using ConsoleProject;

public class ClasseSomaTest
{
    
    ClasseSoma c;
    List<int> numeros1;
    List<int> numeros2;
    List<int> numeros3;
    List<int> numeros4;
    List<int> numeros5;

    [SetUp]
    public void Setup()
    {
        c = new ClasseSoma();
        numeros1 = new List<int>{1, 2, 3, 4, 5};
        numeros2 = new List<int>{10, -5};
        numeros3 = new List<int>{2, 8, 4, -10, 5};
        numeros4 = new List<int>{1000, 2000, 3000, 4000};
        numeros5 = new List<int>{-5, -7, -8, -10};
        
    }

    [Test]
    public void TestSoma1()
    {
        
        int expected = 15;

        int result = c.SomarNumeros(numeros1);
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void TestSoma2()
    {
        
        int expected = 5;

        int result = c.SomarNumeros(numeros2);
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void TestSoma3()
    {
        
        int expected = 9;

        int result = c.SomarNumeros(numeros3);
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void TestSoma4()
    {
        
        int expected = 10000;

        int result = c.SomarNumeros(numeros4);
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void TestSoma5()
    {
        
        int expected = -30;

        int result = c.SomarNumeros(numeros5);
        Assert.AreEqual(expected, result);
    }
}