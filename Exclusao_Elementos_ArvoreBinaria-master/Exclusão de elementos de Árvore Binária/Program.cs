using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exclusão_de_elementos_de_Árvore_Binária
{
public class No
{
    public int Valor { get; set; }
    public No Esquerda { get; set; }
    public No Direita { get; set; }
    public No(int valor)
    {
        Valor = valor;
        Esquerda = null;
        Direita = null;
    }
}
public class ArvoreBinaria
{
    public No Raiz { get; set; }
    public void Adicionar(int valor)
    {
        if (Raiz == null)
        {
            Raiz = new No(valor);
            return;
        }
        AdicionarAuxiliar(Raiz, valor);
    }
    private void AdicionarAuxiliar(No no, int valor)
    {
        if (valor < no.Valor)
        {
            if (no.Esquerda == null)
            {
                no.Esquerda = new No(valor);
            }
            else
            {
                AdicionarAuxiliar(no.Esquerda, valor);
            }
        }
        else
        {
        if (no.Direita == null)
            {
                no.Direita = new No(valor);
            }
            else
            {
                AdicionarAuxiliar(no.Direita, valor);
            }
        }
    }
    public void Remover(int valor)
    {
        Raiz = RemoverAuxiliar(Raiz, valor);
    }
    private No RemoverAuxiliar(No no, int valor)
    {
        if (no == null)
        {
            return null;
        }
        if (valor < no.Valor)
        {
            no.Esquerda = RemoverAuxiliar(no.Esquerda, valor);
        }
        else if (valor > no.Valor)
        {
            no.Direita = RemoverAuxiliar(no.Direita, valor);
        }
        else
        {
            if (no.Esquerda == null)
            {
                return no.Direita;
            }
            else if (no.Direita == null)
            {
                return no.Esquerda;
            }
            else
            {
                No temp = no.Direita;
                while (temp.Esquerda != null)
                {
                    temp = temp.Esquerda;
                }
                no.Valor = temp.Valor;
                no.Direita = RemoverAuxiliar(no.Direita,
                temp.Valor);
            }
        }
    return no;
    }
}
public class Programa
{
    public static void Main()
    {
        int n;
        int j;
        ArvoreBinaria arvore = new ArvoreBinaria();
        arvore.Adicionar(5);
        arvore.Adicionar(3);
        arvore.Adicionar(7);
        arvore.Adicionar(1);
        arvore.Adicionar(4);
        arvore.Adicionar(6);
        arvore.Adicionar(8);
        Console.WriteLine("Árvore Binária Antes da Exclusão:");
        ImprimirArvore(arvore.Raiz);
        Console.Write("Escolha o nó a ser excluido:");
        n = int.Parse(Console.ReadLine());
        arvore.Remover(n);
        ImprimirArvore(arvore.Raiz);
        Console.Write("Escolha o nó a ser excluido:");
        j = int.Parse(Console.ReadLine());
        arvore.Remover(j);
        ImprimirArvore(arvore.Raiz);
    }
    private static void ImprimirArvore(No no)
    {
        if (no == null)
        {
            return;
        }
        ImprimirArvore(no.Esquerda);
        ImprimirArvore(no.Direita);
        Console.WriteLine(no.Valor);
        Console.ReadKey();
    }
}
}