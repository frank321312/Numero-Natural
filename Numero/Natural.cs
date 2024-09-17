namespace Numero;
public class Natural
{
    public int Num { get; private set; }
    public Natural(int num) => Num = num;
    public Natural() { }
    public bool EsNatural()  => EsUno() || EsPrimo() || EsCompuesto();
    public bool EsUno() => Num == 1;
    public bool EsPrimo() 
    {
        bool primo = true;
        if (Num < 2)
        {
            return false;
        }
        for (int i = 2; i < Num; i++)
        {
            if (Num % i == 0)
            {
                primo = false;
                break;
            }
        }
        return primo;
    }
    public bool EsCompuesto() 
    {
        if (Num < 2)
        {
            return false;
        }
        return !EsPrimo();
    }
    public virtual void Sumar(int num1) => Console.WriteLine($"Suma: {Num + num1}");
    public virtual void Sumar(Natural natural) => Console.WriteLine($"Suma: {Num + natural.Num}");

}
