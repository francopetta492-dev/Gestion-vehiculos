class Moto : Vehiculo
{
    public Moto(string marca, double velocidadActual) : base(marca, velocidadActual)
    {  
    }

    public override void Acelerar()
    {
        double aceleracion = VelocidadActual + 50;
    }
    
    public override void Frenar()
    {
        double frenado = VelocidadActual - 30;
    }
}