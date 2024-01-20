using System;

namespace ProjetoCalculadora.Models
{
    public class Calculadora
    {
        
        //Métodos
        public void Somar(int num1, int num2)
        {
            Console.WriteLine($"A somatória de: \n {num1} + {num2} = {num1 + num2}\n");
            
        }

        public void Subtrair(int num1, int num2)
        {
            Console.WriteLine($"A Subtração de: \n {num1} - {num2} = {num1 - num2}\n");
        }

         public void Multiplicar(int num1, int num2)
        {
            Console.WriteLine($"A Multiplicação de: \n {num1} * {num2} = {num1 * num2}\n");
        }

         public void Dividir(int num1, int num2)
        {
            if (num2 != 0)
                Console.WriteLine($"A Divisão de: \n {num1} / {num2} = {num1 / num2}\n");
            else
                Console.WriteLine("Não é possível dividir por zero. \n");            
            
        }

        // Método Potência

        public void Potencia(int num1, int num2)
        {
            double pot = Math.Pow(num1, num2);
            Console.WriteLine($"A Potência: {num1}^{num2} = {pot}\n");
        }  

        // Método Funções Trigonométricas
           public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Ângulo do Seno: \n{angulo}° = {Math.Round(seno, 4)}\n");
        } 
            public void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Sin(radiano);
            Console.WriteLine($"Ângulo do Coseno: \n{angulo}° = {Math.Round(coseno, 4)}\n");
        }  
            public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Sin(radiano);
            Console.WriteLine($"Ângulo da Tangent: \n{angulo}° = {Math.Round(tangente, 4)}\n");
        }

        //metodos 

        internal void Somar()
        {
             
        }

        internal void Subtrair()
        {
            
        }

        internal void Multiplicar()
        {
           
        }

        internal void Dividir()
        {
           
        }

        internal void Potencia()
        {
            
        }

        internal void Seno()
        {
           
        }

        internal void Cosseno()
        {
           
        }

        internal void Tangente()
        {
           
        }

      
    }
}