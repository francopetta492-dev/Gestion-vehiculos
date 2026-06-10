public class Auto : Vehiculo
{
    public Auto(string marca, double velocidadActual) : base (marca, velocidadActual)
    {
        
    }

    public override void Acelerar()
    {
        double aceleracion = VelocidadActual + 35;
    }

    public override void Frenar()
    {
        double frenada = VelocidadActual - 20;
    }
}