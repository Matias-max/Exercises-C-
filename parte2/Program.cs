System.Console.WriteLine();
System.Console.WriteLine("Ejercicio 2");
System.Console.WriteLine("a");

List<string> Computador = new List<string> ();

Computador.Add("A");
Computador.Add("B");
Computador.Add("C");
Computador.Add("D");

System.Console.WriteLine();
System.Console.WriteLine("b");

string pcsa = "A";
bool esta = false;

foreach (var pca in Computador){
    if (pca.ToLower().StartsWith(pcsa.ToLower())){
        System.Console.WriteLine("SI esta precente el computador a");
        esta=false;
        break;
    }else
    {
        if (esta == false){
            System.Console.WriteLine("NO esta presente el computador a");
        }
    }
}

System.Console.WriteLine();
System.Console.WriteLine("c");

int precio1 = 100;
int precio2 = 200;

foreach (var computador1 in Computador){
    if (computador1 == "A"){
        System.Console.WriteLine("EL precio del computador A es :{0}", precio1);
    }
   
}

foreach (var computador2 in Computador){
    if (computador2 == "B"){
        System.Console.WriteLine("El precio del computador B es :{0}", precio2);
    }
}


foreach (var computador3 in Computador){
    if (computador3 == "C"){
        System.Console.WriteLine("El precio del computador C es :{0}", precio1);
    }
}

foreach (var computador4 in Computador){
    if (computador4 == "D"){
        System.Console.WriteLine("El precio del computador B es :{0}", precio2);
    }
}
