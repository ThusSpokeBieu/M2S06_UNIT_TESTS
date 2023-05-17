namespace ConsoleProject;

public class ClasseInverte
{
    public List<T> InverterLista<T>(List<T> lista) {
      List<T> reverse = new List<T>();
      for (int i = 0; i < lista.Count; i++) reverse.Insert(0, lista[i]);
      return reverse;
    }
}
