List<double> lista = new List<double> ();

System.Console.WriteLine("a");
lista.Add(2.89);
lista.Add(5.56);
lista.Add(4.14);


System.Console.WriteLine();
System.Console.WriteLine("b");

//double resultado = System.Math.Round(lista, 1);
foreach (var num in lista){
    double nota = System.Math.Round(num,0);
    System.Console.WriteLine(":{0}", nota);
}

System.Console.WriteLine();
System.Console.WriteLine("c");

foreach (var notaayor  in lista){
    if (notaayor > 3.9){
        System.Console.WriteLine("Las notas que son mayor a 3.9 son, :{0}", notaayor);
    }
}
