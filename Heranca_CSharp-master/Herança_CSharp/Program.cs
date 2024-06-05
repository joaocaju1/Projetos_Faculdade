using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex 1
{
 public class Program
{
    public class Area
    {
        public float area;
    }
    public class quadrado : Area
    {
        public float l;
        public quadrado()
        {
            l = 4;
            area = l * l;
        }
        public void ExibeDados()
        {
            Console.WriteLine(area);
        }
    }
    public class triangulo : Area
    {
        public float b;
        public float h;
        public triangulo()
        {
            b = 2;
            h = 3;
            area = (b * h) / 2;
        }
        public void ExibeDados()
        {
            Console.WriteLine(area);
        }
    }
    public class retangulo : Area
    {
        public float b;
        public float h;
        public retangulo()
        {
            b = 3;
            h = 4;
            area = b * h;
        }
        public void ExibeDados()
        {
            Console.WriteLine(area);
        }
    }
    public class circulo : Area
    {
        public float r;
        public circulo()
        {
            r = 2;
            area = (float)Math.PI * (r * r);
        }
        public void ExibeDados()
        {
            Console.WriteLine(area);
        }
    }
    static void Main(string[] args)
    {
        triangulo tri = new triangulo();
        tri.ExibeDados();
        Console.ReadKey();
        quadrado qua = new quadrado();
        qua.ExibeDados();
        Console.ReadKey();
        retangulo re = new retangulo();
        re.ExibeDados();
        Console.ReadKey();
        circulo ci = new circulo();
        ci.ExibeDados();
        Console.ReadKey();
    }
}
}
-------------------------------------------------------------------------------------------------------------------
 namespace ex 2
using System;
public class Calculadora
{
    public int Soma(int a, int b)
    {
        return a + b;
    }
    public int Subtracao(int a, int b)
    {
        return a - b;
    }
    public int Multiplicacao(int a, int b)
    {
        return a * b;
    }
    public bool Divisao(int a, int b, out int resultado)
    {
        if (b == 0)
        {
            resultado = 0;
            return false;
        }
        resultado = a / b;
        return true;
    }
}
public class CalculadoraCientifica : Calculadora
{
    public bool Raiz(double a, out double resultado)
    {
        if (a < 0)
        {
            resultado = 0;
            return false;
        }
        resultado = Math.Sqrt(a);
        return true;
    }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o primeiro valor:");
        int valor1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor:");
        int valor2 = int.Parse(Console.ReadLine());
        Calculadora calculadora = new Calculadora();
        int soma = calculadora.Soma(valor1, valor2);
        int subtracao = calculadora.Subtracao(valor1, valor2);
        int multiplicacao = calculadora.Multiplicacao(valor1, valor2);
        int divisaoResultado;
        bool divisaoSucesso = calculadora.Divisao(valor1, valor2, out
       divisaoResultado);
        CalculadoraCientifica calculadoraCientifica = new
       CalculadoraCientifica();
        double raizResultado;
        bool raizSucesso = calculadoraCientifica.Raiz(valor1, out
       raizResultado);
        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {subtracao}");
        Console.WriteLine($"Multiplicação: {multiplicacao}");
        if (divisaoSucesso)
        {
            Console.WriteLine($"Divisão: {divisaoResultado}");
        }
        else
        {
            Console.WriteLine("Não é possível dividir por zero.");
        }
        if (raizSucesso)
        {
            Console.WriteLine($"Raiz: {raizResultado}");
        }
        else
        {
            Console.WriteLine("Não é possível calcular a raiz quadrada de
           um número negativo.");
        }
    }
}
------------------------------------------------------------------------------------------------------------------

using System;
namespace ex 03
public class Ingresso
{
    protected double valor;
    public Ingresso(double valor)
    {
        this.valor = valor;
    }
    public virtual void ImprimeValor()
    {
        Console.WriteLine("Valor do ingresso: R$" + valor);
    }
}
public class VIP : Ingresso
{
    public double ValorAdicional { get; }
    public VIP(double valor, double valorAdicional) : base(valor)
    {
        this.ValorAdicional = valorAdicional;
    }
    public override void ImprimeValor()
    {
        Console.WriteLine("Valor do ingresso VIP: R$" + (valor +
       ValorAdicional));
    }
}
public class Normal : Ingresso
{
    public Normal(double valor) : base(valor)
    {
    }
    public override void ImprimeValor()
    {
        Console.WriteLine("Valor do ingresso normal: R$" + valor);
    }
}
public class CamaroteInferior : VIP
{
    private string localizacao;
    public CamaroteInferior(double valor, double valorAdicional, string
   localizacao) : base(valor, valorAdicional)
    {
        this.localizacao = localizacao;
    }
    public override void ImprimeValor()
    {
        Console.WriteLine("Valor do ingresso do camarote inferior: R$" +
       (valor + ValorAdicional));
    }
    public string GetLocalizacao()
    {
        return localizacao;
    }
    public void ImprimeLocalizacao()
    {
        Console.WriteLine("Localização do camarote inferior: " +
       localizacao);
    }
}
public class CamaroteSuperior : VIP
{
    private double valorAdicionalCamarote;
    public CamaroteSuperior(double valor, double valorAdicional, double
   valorAdicionalCamarote) : base(valor, valorAdicional)
    {
        this.valorAdicionalCamarote = valorAdicionalCamarote;
    }
    public override void ImprimeValor()
    {
        Console.WriteLine("Valor do ingresso do camarote superior: R$" +
       (valor + ValorAdicional + valorAdicionalCamarote));
    }
}
public class Program
{
    public static void Main()
    {
        Ingresso ingresso = new Ingresso(100);
        ingresso.ImprimeValor();
        VIP ingressoVIP = new VIP(100, 50);
        ingressoVIP.ImprimeValor();
        Ingresso ingressoNormal = new Normal(100);
        ingressoNormal.ImprimeValor();
        CamaroteInferior ingressoCamaroteInferior = new
       CamaroteInferior(100, 50, "Setor A");
        ingressoCamaroteInferior.ImprimeValor();
        ingressoCamaroteInferior.ImprimeLocalizacao();
        CamaroteSuperior ingressoCamaroteSuperior = new
       CamaroteSuperior(100, 50, 100);
        ingressoCamaroteSuperior.ImprimeValor();
    }
}
-------------------------------------------------------------------------------------------------------------------

using System;
namespace ex 04
public class Imovel
{
    private string endereco;
    private double preco;
    public Imovel(string endereco, double preco)
    {
        this.endereco = endereco;
        this.preco = preco;
    }
    public string Endereco
    {
        get { return endereco; }
        set { endereco = value; }
    }
    public double Preco
    {
        get { return preco; }
        set { preco = value; }
    }
}
public class Novo : Imovel
{
    private double adicional;
    public Novo(string endereco, double preco, double adicional)
    : base(endereco, preco)
    {
        this.adicional = adicional;
    }
    public double Adicional
    {
        get { return adicional; }
        set { adicional = value; }
    }
    public void ImprimirValorAdicional()
    {
        Console.WriteLine($"Valor adicional: {adicional:C}");
    }
}
public class Velho : Imovel
{
    private double desconto;
    public Velho(string endereco, double preco, double desconto)
    : base(endereco, preco)
    {
        this.desconto = desconto;
    }
    public double Desconto
    {
        get { return desconto; }
        set { desconto = value; }
    }
    public void ImprimirDesconto()
    {
        Console.WriteLine($"Desconto: {desconto:C}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Novo novoImovel = new Novo("Rua A, 123", 200000, 10000);
        novoImovel.ImprimirValorAdicional();
        Velho velhoImovel = new Velho("Rua B, 456", 150000, 5000);
        velhoImovel.ImprimirDesconto();
    }
}