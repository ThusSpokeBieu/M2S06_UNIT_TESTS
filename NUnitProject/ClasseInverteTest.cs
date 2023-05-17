namespace NUnitProject;
using ConsoleProject;

public class ClasseInverteTest
{
    ClasseInverte c = new ClasseInverte();
    List<dynamic> lista1 = new List<dynamic>{1, 2, 3, 4, 5};
    List<dynamic> lista2 = new List<dynamic>{'a', 'b', 'c', 'd', 'e'};
    List<dynamic> lista3 = new List<dynamic>{1, 'b', 3, 'c', 5};
    List<dynamic> lista4 = new List<dynamic>{"um", 2, "três", 4, "cinco"};
    List<dynamic> lista5 = new List<dynamic>{5, 4, 3, 2, 1};
    
    [Test]
    public void TestInverte1()
    {
        
        List<dynamic> expected = new List<dynamic>{5,4,3,2,1};

        List<dynamic> result = c.InverterLista<dynamic>(lista1);
        Assert.AreEqual(expected, result);
    }
    
    public void TestInverte2()
    {
        
        List<dynamic> result = c.InverterLista<dynamic>(lista2);
        List<dynamic> expected = new List<dynamic>(lista2);
        expected.Reverse();
        Assert.AreEqual(expected, result);
    }

    public void TestInverte3()
    {
        
        List<dynamic> result = c.InverterLista<dynamic>(lista3);
        List<dynamic> expected = new List<dynamic>(lista3);
        expected.Reverse();
        Assert.AreEqual(expected, result);
    }

    public void TestInverte4()
    {
        
        List<dynamic> result = c.InverterLista<dynamic>(lista4);
        List<dynamic> expected = new List<dynamic>(lista4);
        expected.Reverse();
        Assert.AreEqual(expected, result);
    }
    
    public void TestInverte5()
    {
        
        List<dynamic> result = c.InverterLista<dynamic>(lista5);
        List<dynamic> expected = new List<dynamic>(lista5);
        expected.Reverse();
        Assert.AreEqual(expected, result);
    }
}
