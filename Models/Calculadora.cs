using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace teste.Models
{
    public class Calculadora
    {


        // o $ Serve para fazer a interpolação que são itens que são substituidos pela referencia (SIGNIFICA QUE ESTÁ PEGANDO O VALOR DA VARIAVEL)
        public void Somar(int x, int y){

            Console.WriteLine($"{x} + {y} = {x + y}");
             
        }
        public void Subtrair(int x, int y){

            Console.WriteLine($"{x} - {y} = {x - y}");
             
        }
        public void Multiplicar(int x, int y){

            Console.WriteLine($"{x} * {y} = {x * y}");
             
        }public void Dividir(int x, int y){

            Console.WriteLine($"{x} / {y} = {x / y}");
             
        }
    
    }

}