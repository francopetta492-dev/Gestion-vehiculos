public class Camion : Vehiculo
{
    public Camion(string marca, double velocidadActual) : base(marca, velocidadActual)
    {  
    }

    public override void Acelerar()
    {
        double aceleracion = VelocidadActual + 20;
        VelocidadActual = aceleracion;
    }
    
    public override void Frenar()
    {
        double frenado = VelocidadActual - 10;
        VelocidadActual = frenado;
    }
}