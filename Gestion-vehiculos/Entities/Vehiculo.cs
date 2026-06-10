using System.Diagnostics;
using System.Dynamic;

public abstract class Vehiculo
{
    private string marca;
    private double velocidadActual;

    public string Marca{get {return this.marca;} set{this.marca = value;}}
    public double VelocidadActual{get{return this.velocidadActual;} set{this.velocidadActual = value;}}

    public Vehiculo(string marca, double velocidadActual)
    {
        this.Marca = marca;
        this.VelocidadActual = velocidadActual;
    }

    public abstract void Acelerar();
    public abstract void Frenar();
}