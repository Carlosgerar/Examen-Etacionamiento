using System;
using System.Collections.Generic;

namespace Estacionamiento
{
    public class Cliente
    {
        
        private int horasEstacionado = 1;
        private int totalCostoEstacionamiento;
        private int numeroCliente = 0;

        public int horasEstacionadas;
        public float totalAPagar;
        public float totalApagarProductos;
        public float totalAPagarEstacionamiento;
        float costoTotalProductos;

        
        public int HorasEstacionado { get => horasEstacionado; set => horasEstacionado = value; }
        public int TotalCostoEstacionamiento { get => totalCostoEstacionamiento; set => totalCostoEstacionamiento = value; }
        
        
        public int NumeroCliente { get => numeroCliente; set => numeroCliente = value; }

        //public Cliente ProductoS { get => productoS; set => productoS = value; }

        public Dictionary<int,string> Nombre = new Dictionary<int, string>();
        public Dictionary<int, float> PrecioP = new Dictionary<int, float>();
        public Dictionary<int, int> cantidadProducto = new Dictionary<int, int>();
     
       


        public int estacionamiento(int horasEStacionada)
        {
            horasEstacionado = horasEStacionada;
            if (horasEstacionado < 0)
            {
                Console.WriteLine("las horas tienen que se mayor a 0");

            }
            if (horasEstacionado > 0 && horasEstacionado < 3)
            {
                totalCostoEstacionamiento = horasEstacionado * 5;
            }
            else if (horasEstacionado == 3)
            {
                totalCostoEstacionamiento = horasEstacionado * 10;
            }
            if (horasEstacionado > 4)
            {
                totalCostoEstacionamiento = horasEstacionado * 15;
            }
            return totalCostoEstacionamiento;

        }


        public override string ToString()
        {
            int[] cantidasd = new int[cantidadProducto.Count];

            int y = 0;
            foreach (var item in cantidadProducto)
            {
                cantidasd[y] = item.Value;
                y++;
            }

            float[] precioV = new float[PrecioP.Count];
            int i = 0;
            foreach (var item in PrecioP)
            {
                precioV[i] = item.Value * cantidasd[i];
                i++;
            }



            for (int m = 0; m < precioV.Length; m++)
            {
                costoTotalProductos += precioV[m];
            }


            y = 0;
            Console.WriteLine("numero   nombre     cantidad      coste");
            foreach (var item in Nombre)
            {
                Console.WriteLine(" {0}      {1}          {2}             {3}", item.Key, item.Value, cantidasd[y], precioV[y]);
                y++;
            }
            
           


            return "gracias por su compra";
        }



    }
}
