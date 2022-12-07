namespace PercorrendoArrayComForForeach
{
  class program
  {
    public static void Main(string[] args)
    {
      int[] arrayInt = new int[5];

      arrayInt[0] = 75;
      arrayInt[1] = 13;
      arrayInt[2] = 102;
      arrayInt[3] = 65;
      arrayInt[4] = 1;
      
      // >> Array.Resize <<    
      // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 3);

      // >> Array.Copy <<
      // var arrayInteirosDois = new int[arrayInteiros.Length * 3];
      // Array.Copy(arrayInteiros, arrayInteirosDois, arrayInteiros.Length);

      Console.WriteLine("Percorrendo o Array com o FOR!");
      Console.WriteLine();

      for (int contador = 0; contador < arrayInt.Length; contador++)
      {
        Console.WriteLine($"Posição Nº {contador} - {arrayInt[contador]}.");
      }
      Console.WriteLine("Percorrendo o Array com o FOREACH!");
      Console.WriteLine();

      int contadorForeach = 0;
      foreach (int valor in arrayInt)
      {
        Console.WriteLine($"Posição Nº {contadorForeach} - {valor}.");
        contadorForeach++;
      }
    }
  }
}

