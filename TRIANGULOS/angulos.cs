using System;

namespace TRIANGULOS
{
    class angulos
    {
        static void Main()
        {
            float A1;
            float A2;
            float A3;
            String AUX;

            //PIDO EL INGRESO DE LOS ANGULOS:

            Console.Write("Ingrese ángulo 1: ");
            AUX = Console.ReadLine();
            A1 = float.Parse(AUX); //Ya que ReadLine lo toma como string, lo convierto a float y guardo en la variable float.

            Console.Write("Ingrese ángulo 2: ");
            AUX = Console.ReadLine();
            A2 = float.Parse(AUX);

            Console.Write("Ingrese ángulo 3: ");
            AUX = Console.ReadLine();
            A3 = float.Parse(AUX);

            //Pongo los parametros de cada triangulo

            if (A1 == A2 && A1 == A3)
                Console.Write("EL TRIANGULO ES EQUILATERO");

            if (A1 != A2 && A1 != A3 && A2 != A3)
                Console.Write("EL TRIANGULO ES ESCALENO");

            //EN EL TRIANGULO ISÓSCELES SE NOS PRESENTAN 3 CASOS POSIBLES
                //A1 == A2 PERO DISTINTO DE A3
                //A1 == A3 PERO DISTINTO DE A2
                //A2 == A3 PERO DISTINTO DE A1

            if (A1 == A2 && A1 != A3 || A1 != A2 && A1 == A3 || A2 == A3 && A2 != A1)
                Console.Write("EL TRIANGULO ES ISÓSCELES");

            //Por último, pondré un ReadLine() para que no se cierre el programa hasta que le demos "Enter", así podemos
            //observar el resultado

            Console.ReadLine();

        }
    }
}
