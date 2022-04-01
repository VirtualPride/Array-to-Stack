using System;
using System.Collections.Generic;
class HelloWorld
{
  static void Main ()
  {
    int[] my_list = new int[]{ 10, 20, 30, 40, 50 };

      Console.WriteLine ("Element of Array:");	//Print the list
      foreach (int str in my_list)
    {
      Console.Write ("{0}   ", str);
    }

    Stack < int >isi = new Stack < int >();
    foreach (int str in my_list)
    {
      isi.Push (str);
    }

    Console.WriteLine ("\n\nChange to Stack:");	//Print the list
    foreach (int ini in isi)
    {
      Console.Write ("{0}   ", ini);
    }

    isi.Push (20);
    Console.WriteLine ("\n\nAfter Push: '20'");	//Print the list
    foreach (int ini in isi)
    {
      Console.Write ("{0}   ", ini);
    }

    Console.WriteLine ("\n\nTop of the Stack: ");
    Console.WriteLine (isi.Peek ());

    isi.Pop ();
    Console.WriteLine ("\nAfter Pop:");	//Print the list
    foreach (int ini in isi)
    {
      Console.Write ("{0}   ", ini);
    }
  }
}
