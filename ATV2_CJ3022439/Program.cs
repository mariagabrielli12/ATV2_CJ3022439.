// See https://aka.ms/new-console-template for more information
namespace ATV2_CJ3022439
{
    internal class Program
{
    static void Main(string[] args)
    {
        //10
        float bolsa;

        bolsa = 1000;

        bolsa = bolsa - ((bolsa / 100) * 3.4f);
        bolsa = bolsa + ((bolsa / 100) * 2.8f);
        bolsa = bolsa + ((bolsa / 100) * 14f);
        bolsa = bolsa - ((bolsa / 100) * 8.5f);

        Console.WriteLine("o valor atual dos investimentos é de R${0}", bolsa);

        //6

        float salario;

        Console.WriteLine("digite seu salário antigo:");

        salario = float.Parse(Console.ReadLine());

        salario = salario + (25.0f / 100.0f) * salario;

        Console.WriteLine("O novo salário é R$ {0}", salario);

        // 8


        int n;

        Console.WriteLine("Digite um número qualquer e decobriremos o sucessor de seu triplo com o antecessor de seu dobro:");

        n = int.Parse(Console.ReadLine());
        n = (((n * 3) + 1) + ((n * 2) - 1));

        Console.WriteLine("resultado é {0}", n);

        //1 



        float centimetro, m, milimetro;

        Console.WriteLine("Digite um valor em metros:");

        m = float.Parse(Console.ReadLine());


        centimetro = m * 100f;

        milimetro = m * 1000f;

        Console.WriteLine("o valor em centímetros é {0}", centimetro);

        Console.WriteLine("o valor em milímetro é {0}", milimetro);


        // 2
        //a

        float f, c;


        Console.WriteLine("Digite a temperatura em fahrenheit");

        f = float.Parse(Console.ReadLine());

        c = (f - 32.0f) * (5.0f / 9.0f);


        Console.WriteLine("A Temperatura em Celsius é:{0}", c);

        //b

        //R: Porque no inteiro o número mais próximo é zero

        // 3

        float peso, altura, imc;

        Console.WriteLine("Digite a sua altura");
        peso = float.Parse(Console.ReadLine());

        Console.WriteLine("digite seu peso");
        altura = float.Parse(Console.ReadLine());

            imc = ((altura / peso) * altura);

            Console.WriteLine("seu IMC é {0}:", imc);

        //4

        float n1, n2, n3, p1, p2, p3, media;

        Console.WriteLine("Digite três números:");
        n1 = float.Parse(Console.ReadLine());
        n2 = float.Parse(Console.ReadLine());
        n3 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite três números:");

        p1 = float.Parse(Console.ReadLine());
        p2 = float.Parse(Console.ReadLine());
        p3 = float.Parse(Console.ReadLine());


            media = (n1 + p1 * n2 + p2 * n3 + p3) / (p1 + p2 + p3);

             Console.WriteLine("A média Ponderada é de{0}:", media);

             // 5

                float velocidade, tempo, aceleracao, v;

        Console.WriteLine("digite a velocidade(m/s): ");

        velocidade = float.Parse(Console.ReadLine());

        Console.WriteLine("digite o tempo (s):");

        tempo = float.Parse(Console.ReadLine());

        Console.WriteLine("digite a aceleracão (m/s²");

        aceleracao = float.Parse(Console.ReadLine());

            v = velocidade + aceleracao * tempo;

         Console.WriteLine("A velocidade final é {0}:", v);


        //7 
        float dolar, real, cotacao;

        Console.WriteLine("digite o valor em reais");
        real = float.Parse(Console.ReadLine());

        Console.WriteLine("digite a cotação do dólar:");
        cotacao = float.Parse(Console.ReadLine());

            dolar = real / cotacao;

        Console.WriteLine("o valor em dólares é:{0}", dolar);

        //9
        int x;

        Console.WriteLine("digite um número de 4 dígitos:");

            x = int.Parse(Console.ReadLine());
                    
            Console.WriteLine("separando os dígitos:");

             Console.WriteLine(x / 1000);
        Console.WriteLine((x % 1000) / 100);
        Console.WriteLine((x % 100) / 10);
        Console.WriteLine(x % 10);


        //11

        int i, quadrado, cubo;

        Console.WriteLine("Digite um número:");

        i = int.Parse(Console.ReadLine());

            quadrado = i * i;
        cubo = i * i * i;

                Console.WriteLine("O número ao quadrado é:{0}", quadrado);
            Console.WriteLine("O número ao cubo é:{0}", cubo);

                //12

                double h, pm, ph;

            Console.WriteLine("digite sua altura:");

               h = double.Parse(Console.ReadLine());

        pm = (h * 62.1) - 44.7;
        ph = (h * 72.7) - 58;

        Console.WriteLine("peso ideal para mulher:{0}", pm);
        Console.WriteLine("Peso ideal para Homens:{0}",ph);




    }
} 
        
        
}



