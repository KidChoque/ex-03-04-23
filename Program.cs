Console.WriteLine(@$"

----------------------------------
|  Bem vindo a nossa calculadora |
|  operações:                    |
|  Digite a opeção:              |
| '+' adicao                     |
| '*' multiplicacao              |
| '-' subtracao                  |
| '/' divisao                    |
|--------------------------------|
");

char operation = char.Parse(Console.ReadLine());

float resultado = 0;


Console.WriteLine($"Digite o valor1");

float valor1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o valor2");

float valor2 = float.Parse(Console.ReadLine());

switch (operation)

{case '+': resultado = ( valor1 + valor2);
          Console.WriteLine($" O resultado da soma é {resultado} ");
          break;

case '*': resultado = ( valor1 * valor2 );
          Console.WriteLine($" O resultado da multiplicação é {resultado} ");
          break;

case '-': resultado = ( valor1 - valor2 );
          Console.WriteLine($" O resultado da subtração é {resultado} ");
          break;

case '/': resultado = ( valor1 / valor2 );
          Console.WriteLine($" O resultado da divisão é {resultado} ");
          break;

          default: Console.WriteLine($" A operação informada não é suportada pela calculadora ! ");
                   break;
                   }
                   
                    
   
