using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examensb
{
    class Vector
    {
        const int MAX = 50;
        private int[] v;
        private int n;

        public Vector()
        {
            n = 0;
            v = new int[MAX];
        }

        public void Cargar(int n1, int a, int b)
        {
            Random r = new Random();
            int i;
            n = n1;
            for (i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }
        }

        public void Cargar(int ele)
        {
            n++;
            v[n] = ele;
        }

        public void cargardato(int nele)
        {
            n = nele;
            int num = n;
            for (int i = 1; i <= num; i++)
            {
                v[i] = Conversions.ToInteger(Interaction.InputBox(" ", " "));
            }
        }

        public string Descargar()
        {
            string s = "";
            int i;
            for (i = 1; i <= n; i++)
            {
                s = s + v[i] + " | ";
            }
            return s;
        }

        //EXAMEN

        //PREGUNTA 1




        //PREGUNTA 2


        public void OrdenarEspiralInterno(int a, int b)
        {
            // Ordenar el rango a, b
            OrdBurbuja(a, b);

            // Crear un array temporal para almacenar los elementos ordenados
            int[] temp = new int[b - a + 1];
            for (int i = a; i <= b; i++)
            {
                temp[i - a] = v[i];
            }

            // Punteros para las posiciones izquierda y derecha
            int izquierda = a;
            int derecha = b;

            // Alternar la colocación de elementos de dos en dos desde el más pequeño
            bool turnoIzquierda = true;
            for (int i = 0; i < temp.Length; i += 2)
            {
                if (turnoIzquierda)
                {
                    if (i < temp.Length)
                    {
                        v[izquierda] = temp[i];
                        izquierda++;
                    }
                    if (i + 1 < temp.Length)
                    {
                        v[izquierda] = temp[i + 1];
                        izquierda++;
                    }
                }
                else
                {
                    if (i < temp.Length)
                    {
                        v[derecha] = temp[i];
                        derecha--;
                    }
                    if (i + 1 < temp.Length)
                    {
                        v[derecha] = temp[i + 1];
                        derecha--;
                    }
                }
                turnoIzquierda = !turnoIzquierda;
            }
        }


        public void OrdBurbuja(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                for (int j = a; j < b - (i - a); j++)
                {
                    if (v[j] > v[j + 1])
                    {
                        Intercambio(j, j + 1);
                    }
                }
            }
        }

        public void Intercambio(int a, int b)
        {
            int aux = v[a];
            v[a] = v[b];
            v[b] = aux;
        }

    }

}

