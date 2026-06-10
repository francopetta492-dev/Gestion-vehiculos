public class Moto : Vehiculo
{
    public Moto(string marca, double velocidadActual) : base(marca, velocidadActual)
    {  
    }

    public override void Acelerar()
    {
        double aceleracion = VelocidadActual + 50;
        VelocidadActual = aceleracion;
    }
    
    public override void Frenar()
    {
        double frenado = VelocidadActual - 30;
        VelocidadActual = frenado;
    }
}