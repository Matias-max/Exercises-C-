namespace parte4.Models;


public class Celular{
    public int id {get; set;}
    public string imei {get; set;}
    public string modelo {get; set;}
    public string marca {get; set;}
    public int year {get; set;}

    public Celular(){
        this.id = generarId();
        this.modelo = string.Empty;
        this.marca = string.Empty;
        
    }
    public Celular(string imei, string modelo, string marca, int year){
        this.id = generarId();
        this.imei = imei;
        this.modelo = modelo;
        this.marca = mayusculaRamplazarMarca(marca);
        this.year = year;

    }

     private string mayusculaRamplazarMarca (string marca){
        string marca1 = marca.ToUpper();
        string remplazo = marca1.Replace("ñ", "n");
        return remplazo;
    }
    int generarId(){
        Random r = new Random();
        return r.Next();
    }

}