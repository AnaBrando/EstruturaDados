using Domain;
using System;
using System.Collections.Generic;

namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Aluno> minhaPilha = new Stack<Aluno>();
            var opcao = 0;
            var id = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bem vindos a pilha!");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Digite a opção desejada");
                Console.WriteLine("1- Cadastrar Aluno:");
                Console.WriteLine("2- Cadastrar Nota do Aluno:");
                Console.WriteLine("3- Ver Nota do Aluno:");
                Console.WriteLine("4- Ver Nota não cadastrada do Aluno:");
                Console.WriteLine("5- Buscar aluno pelo código");
                Console.WriteLine("6- Excluir aluno");
                Console.WriteLine("7- Ver Pilha");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("Digite o código do aluno:");
                        id = Convert.ToInt32(Console.ReadLine());
                        minhaPilha.Push(new Aluno { Id = id });
                        Console.WriteLine("Aluno cadastrado com sucesso!");
                        break;
                    case 2:
                        Console.WriteLine("Digite o código do aluno:");
                        id = Convert.ToInt32(Console.ReadLine());
                        foreach (var aluno in minhaPilha)
                        {
                            if (aluno.Id == id)
                            {
                                Console.WriteLine("Digite a nota do aluno:");
                                var nota = Convert.ToDouble(Console.ReadLine());
                                if (nota > 0)
                                {
                                    aluno.Nota = nota;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Nota não é maior que 0");
                                    break;
                                }

                            }
                            Console.WriteLine("Aluno não encontrado");
                            break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Digite o código do aluno:");
                        id = Convert.ToInt32(Console.ReadLine());
                        foreach (var aluno in minhaPilha)
                        {
                            var notas = 0.0;
                            if (aluno.Nota > 0)
                            {
                                notas = +aluno.Nota;
                            }
                            if (aluno.Id == id)
                            {
                                if (aluno.Nota > 0)
                                {
                                    Console.WriteLine("Média:" + (notas / minhaPilha.Count));
                                }
                                else
                                {
                                    Console.WriteLine("Aluno sem nota");
                                    break;
                                }
                            }

                        }
                        break;
                    case 4:
                        foreach (var item in minhaPilha)
                        {
                            if (item.Nota == 0)
                            {
                                Console.WriteLine($"Aluno {item.Id} sem nota: {item.Nota}");
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Digite o código do aluno:");
                        id = Convert.ToInt32(Console.ReadLine());
                        foreach (var item in minhaPilha)
                        {
                            if (item.Id == id)
                            {
                                Console.WriteLine($"[Aluno {item.Id} nota: {item.Nota}]");
                            }
                        }
                        break;
                    case 6:
                        minhaPilha.Pop();
                        break;
                    case 7:
                        foreach (var item in minhaPilha)
                        {
                            Console.WriteLine("[Aluno: " + item.Id + ", Nota: " + item.Nota + "]");
                            break;
                        }
                        Console.WriteLine("Pilha vazia");
                        break;

                }
            } while (opcao != 0);


        }
    }
}
