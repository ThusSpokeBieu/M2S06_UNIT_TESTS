namespace NUnitProject;
using ConsoleProject;

public class ClasseOrdenarTest
{
      
    ClasseOrdenar c;
    List<int> numeros1;
    List<int> numeros2;
    List<int> numeros3;
    List<int> numeros4;
    List<int> numeros5;

    [SetUp]
    public void Setup()
    {
        c = new ClasseOrdenar();
        numeros1 = new List<int>{1, 2, 3, 4, 5};
        numeros2 = new List<int>{10, -5};
        numeros3 = new List<int>{2, 8, 4, -10, 5};
        numeros4 = new List<int>{1000, 2000, 3000, 4000};
        numeros5 = new List<int>{-5, -7, -8, -10};
        
    }

    [Test]
    public void TestOrdenar1()
    {
        List<int> result = c.Ordenar(numeros1);
        List<int> expected = new List<int>(numeros1);
        expected.Sort();
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void TestOrdenar2()
    {
        List<int> result = c.Ordenar(numeros2);
        List<int> expected = new List<int>(numeros2);
        expected.Sort();
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void TestOrdenar3()
    {
        List<int> result = c.Ordenar(numeros3);
        List<int> expected = new List<int>(numeros3);
        expected.Sort();
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void TestOrdenar4()
    {
        List<int> result = c.Ordenar(numeros4);
        List<int> expected = new List<int>(numeros4);
        expected.Sort();
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void TestOrdenar5()
    {
        List<int> result = c.Ordenar(numeros5);
        List<int> expected = new List<int>(numeros5);
        expected.Sort();
        Assert.AreEqual(expected, result);
    }
}
