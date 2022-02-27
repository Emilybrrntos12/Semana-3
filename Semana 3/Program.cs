static void desglose()
{
    float cn50, cn25, cn10, cn5, cn1, CAN, C200, C100, C50, C20, C10, C5, C1;
    float centavos = 0.0f, cambiomoneda = 7.66f;
    CAN = C200= C100 = C50 = C20 = C10 = C5 = C1 = cn50 =  cn25 = cn10 = cn5 = cn1 = 0;
    string linea;

    Console.Write("\n\tIngrese una cantidad en Dolares: ");
    linea = Console.ReadLine();

    centavos = (float)Convert.ToDecimal(linea);
    centavos *= cambiomoneda; //variable linea almacena lo que el usuario a ingresado
    // centavos*cambio de moneda= lo que a ingresado el usuario multiplicado por 7.66

    Console.WriteLine($"\tSu cambio en Quetzales es de: {centavos}");
    //$$ a Q

    CAN = Convert.ToInt32(Math.Truncate(centavos));
    centavos = (centavos - CAN) * 100;
    //representacion para los centavos

    Console.WriteLine($"\tSus monedas son: {centavos}");
    // separacion de los centavos
    if (CAN >= 200)
    {
        C200 = (int)CAN / 200; //valor entero
        CAN -= (C200 * 200);
    }

    if (CAN >= 100)
    {
        C100 = (int)CAN / 100; //valor entero
        CAN -= (C100 * 100);

    }

    if (CAN >= 50)
    {
        C50 = (int)CAN / 50; //valor entero
        CAN -= (C50 * 50);
    }
    if (CAN >= 20)
    {
        C20 = (int)CAN / 20; //valor entero
        CAN -= (C20 * 20);
    }
    if (CAN >= 10)
    {
        C10 = (int)CAN / 10; //valor entero
        CAN -= (C10 * 10);
    }
    if (CAN >= 5)
    {
        C5 = (int)CAN / 5; //valor entero
        CAN -= (C5 * 5);
    }
    if (CAN >= 1)
    {
        C1 = (int)CAN / 1; //valor entero
        CAN -= (C1 * 1);
    }
    if (centavos >= 50)
    {
        cn50 = (int)centavos / 50; // valor entero pero con la representacion de los centavos
        centavos -= (cn50 * 50);
    }
    if (centavos >= 25)
    {
        cn25 = (int)centavos / 25; //centavos
        centavos -= (cn25 * 25);
    }
    if (centavos >= 10)
    {
        cn10 = (int)centavos / 10; //centavos
        centavos -= (cn10 * 10);
    }
    if (centavos >= 5)
    {
        cn5 = (int)centavos / 5; //centavos
        centavos -= (cn5 * 5);
    }
    if (centavos >= 1)
    {
        cn1 = (int)centavos / 1; //centavos
        centavos -= (cn1 * 1);
    }


    Console.WriteLine("\n\t\t--ESTOS SON BILLETES--");
    Console.WriteLine($"\tBillestes de Q.200: {C200}");
    Console.WriteLine($"\tBillestes de Q.100: {C100}");
    Console.WriteLine($"\tBillestes de Q.50: {C50}");
    Console.WriteLine($"\tBillestes de Q.20: {C20}");
    Console.WriteLine($"\tBillestes de Q.10: {C10}");
    Console.WriteLine($"\tBillestes de Q.5: {C5}");
    Console.WriteLine($"\tBillestes de Q.1: {C1}");
    Console.WriteLine("\n\t\t--ESTOS SON LOS CENTAVOS--");
    Console.WriteLine($"\tCentavos de Q.0.50: {cn50}");
    Console.WriteLine($"\tCentavos de Q.0.25: {cn25}");
    Console.WriteLine($"\tCentavos de Q.0.10: {cn10}");
    Console.WriteLine($"\tCentavos de Q.0.05: {cn5}");
    Console.WriteLine($"\tCentavos de Q.0.01: {cn1}");
    Console.WriteLine("\n\tGRACIAS POR UTILIZAR EL PROGRAMA!");

    Console.WriteLine();

    //FIN DEL PROGRAMA
}
desglose();
