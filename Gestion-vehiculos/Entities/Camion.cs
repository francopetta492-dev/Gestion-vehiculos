class Camion : Vehiculo
{
    public Camion(string marca, double velocidadActual) : base(marca, velocidadActual)
    {  
    }

    public override void Acelerar()
    {
        double aceleracion = VelocidadActual + 20;
    }
    
    public override void Frenar()
    {
        double frenado = VelocidadActual - 10;
    }
}