namespace ConsoleProject;

public class ClasseSoma
{
  public int SomarNumeros(List<int> numeros)
  {
    int resultado = 0;
    numeros.ForEach(num => resultado += num);
    return resultado;
  }
}
