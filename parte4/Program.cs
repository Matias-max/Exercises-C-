using parte4.Models;

List<Celular> celulares = new List<Celular>();

celulares.Add (new Celular("wo12", "Samung galaxy A22", "Samsung", 2022));
celulares.Add (new Celular("elr42", "Moto G5", "Motorola", 2021));
celulares.Add (new Celular("effiel42", "Pphone 10", "Apple", 2017));



foreach (var nombre in celulares){
    System.Console.WriteLine("La lista de celulares son :{0},{1},{2},{3}", nombre.imei,nombre.modelo,nombre.marca,nombre.year);
}




System.Console.WriteLine();
System.Console.WriteLine("d");


    celulares.RemoveAll(borrar => borrar.year == 2022);

foreach (var actualizacion in celulares)
{
    

     System.Console.WriteLine("La nueva lista de celulares son :{0},{1},{2},{3}", actualizacion.imei,actualizacion.modelo,actualizacion.marca,actualizacion.year);
}


System.Console.WriteLine();
System.Console.WriteLine("e");

string telb="b";

foreach (var celab in celulares){
    if (celab.modelo.ToLower().StartsWith(telb.ToLower())){
       System.Console.WriteLine("Los celulares que empiezan con b son :{0},{1},{2},{3}", celab.imei,celab.modelo,celab.marca,celab.year);
    }
}



