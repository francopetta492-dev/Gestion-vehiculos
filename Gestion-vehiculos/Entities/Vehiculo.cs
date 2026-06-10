using System.Diagnostics;
using System.Dynamic;

abstract class Vehiculo
{
    private string marca;
    private double velocidadActual;

    public string Marca{get {return this.marca;} set{value = this.marca;}}
    public double VelocidadActual{get{return this.velocidadActual;} set{value = this.velocidadActual;}}

    public Vehiculo(string marca, double velocidadActual)
    {
        this.Marca = marca;
        this.VelocidadActual = velocidadActual;
    }

    public abstract void Acelerar();
    public abstract void Frenar();
}