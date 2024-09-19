namespace Numero;

public class Entero: Natural
{
    public Entero(int numero): base(numero) {}

    public bool EsEntero()
    {
        if (base.Num <= 0 || base.EsNatural())
        {
            return true;
        }
        return false;
    }
}
