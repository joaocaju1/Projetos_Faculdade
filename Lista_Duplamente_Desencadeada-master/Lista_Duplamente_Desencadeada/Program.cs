using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Duplamente_Desencadeada
{
        class ListaDupla
        {
            public ListaDupla() // Construtor
            {
                info = 0;
                next = prior = null;
            }
            public void Insere(int n, ref ListaDupla START, ref
            ListaDupla END)
            {
                this.info = n;
                if (START == null)
                    START = END = this;
                else
                {
                    END.next = this;
                    this.prior = END;
                    END = this;
                }
            }
            public bool Exclui(int n, ref ListaDupla START, ref
            ListaDupla END, out int resultado)
            {
                resultado = 0;
                bool achou = false;
                ListaDupla p = START;
                while (p != null && p.info != n)
                    p = p.next;
                if (p != null)
                {
                    resultado = p.info;
                    if (p == START)
                        START = p.next;
                    if (p == END)
                        END = p.prior;
                    if (p.prior != null)
                        p.prior.next = p.next;
                    if (p.next != null)
                        p.next.prior = p.prior;
                    achou = true;
                }
                return (achou);
            }
            private int info;
            ListaDupla next;
            ListaDupla prior;
}
        class Program
        {
            static void Main(string[] args)
            {
                ListaDupla START = null;
                ListaDupla END = null;
                ListaDupla ld;
                int n, escolha, resultado;
                do
                {
                    Console.Clear();
                    Console.WriteLine(" Menu Principal");
                    Console.WriteLine("(1) - Insere um elemento na ListaDupla");
                    Console.WriteLine("(2) - Exclui um elemento na ListaDupla");
                    Console.WriteLine("(7) - Para SAIR");
                    escolha = int.Parse(Console.ReadLine());
                    switch (escolha)
                    {
                        case 1: // Insere um elemento na Lista Dupla
                            Console.Clear();
                            ld = new ListaDupla();
                            Console.Write("Entre com um numero : ");
                            n = int.Parse(Console.ReadLine());
                            ld.Insere(n, ref START, ref END);
                            break;
                        case 2: //Exclui um elemento na Lista Dupla
                            Console.Clear();
                            //ld = new ListaDupla();
                            Console.Write("Entre com um numero para excluir: ");
                            n = int.Parse(Console.ReadLine());
                            bool retorno = START.Exclui(n, ref START,
                            ref END, out resultado);
                            if (retorno)
                            {
                                Console.WriteLine("O numero {0} foi excluído da lista.", resultado);
                            }
                            else
                            {
                                Console.WriteLine("Não Encontrado");
                            }
                            Console.ReadKey();
                            break;
                    }
                } while (escolha != 7);
            }
        }
    }

