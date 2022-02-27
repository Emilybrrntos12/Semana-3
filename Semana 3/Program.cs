static void desglose()
{
    float cn50, cn25, cn10, cn5, cn1, CAN, C200, C100, C50, C20, C10, C5, C1;
    float moneda = 0.0f, cambiomoneda = 7.66f;
    CAN = C200= C100 = C50 = C20 = C10 = C5 = C1 = cn50 =  cn25 = cn10 = cn5 = cn1 = 0;
    string linea;

    Console.Write("Ingrese una cantidad en Dolares: ");
    linea = Console.ReadLine();

    moneda = (float)Convert.ToDecimal(linea);
    moneda *= cambiomoneda;

    Console.WriteLine($"Su cambio en Quetzales es de: {moneda}");

    CAN = Convert.ToInt32(Math.Truncate(moneda));
    moneda = (moneda - CAN) * 100;

    Console.WriteLine($"Sus monedas son: {moneda}");

    if (CAN >= 200)
    {
        C200 = (int)CAN / 200;
        CAN -= (C200 * 200);
    }

    if (CAN >= 100)
    {
        C100 = (int)CAN / 100;
        CAN -= (C100 * 100);

    }

    if (CAN >= 50)
    {
        C50 = (int)CAN / 50;
        CAN -= (C50 * 50);
    }
    if (CAN >= 20)
    {
        C20 = (int)CAN / 20;
        CAN -= (C20 * 20);
    }
    if (CAN >= 10)
    {
        C10 = (int)CAN / 10;
        CAN -= (C10 * 10);
    }
    if (CAN >= 5)
    {
        C5 = (int)CAN / 5;
        CAN -= (C5 * 5);
    }
    if (CAN >= 1)
    {
        C1 = (int)CAN / 1;
        CAN -= (C1 * 1);
    }
    if (moneda >= 50)
    {
        cn50 = (int)moneda / 50;
        moneda -= (cn50 * 50);
    }
    if (moneda >= 25)
    {
        cn25 = (int)moneda / 25;
        moneda -= (cn25 * 25);
    }
    if (moneda >= 10)
    {
        cn10 = (int)moneda / 10;
        moneda -= (cn10 * 10);
    }
    if (moneda >= 5)
    {
        cn5 = (int)moneda / 5;
        moneda -= (cn5 * 5);
    }
    if (moneda >= 1)
    {
        cn1 = (int)moneda / 1;
        moneda -= (cn1 * 1);
    }


    Console.WriteLine("\n--ESTOS SON BILLETES--");
    Console.WriteLine($"Billestes de 200: {C200}");
    Console.WriteLine($"Billestes de 100: {C100}");
    Console.WriteLine($"Billestes de 50: {C50}");
    Console.WriteLine($"Billestes de 20: {C20}");
    Console.WriteLine($"Billestes de 10: {C10}");
    Console.WriteLine($"Billestes de 5: {C5}");
    Console.WriteLine($"Billestes de 1: {C1}");
    Console.WriteLine("\n--ESTOS SON LOS CENTAVOS--");
    Console.WriteLine($"Centavos de 0.50: {cn50}");
    Console.WriteLine($"Centavos de 0.25: {cn25}");
    Console.WriteLine($"Centavos de 0.10: {cn10}");
    Console.WriteLine($"Centavos de 0.05: {cn5}");
    Console.WriteLine($"Centavos de 0.01: {cn1}");

    Console.WriteLine();
}
desglose();
