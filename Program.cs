// //1. Criar uma variável chamada curso, e guarde nela o nome do curso estudado.

// string curso = "C#: criando sua primeira aplicação";

// //2. Mostrar o conteúdo da variável curso no console.

// Console.WriteLine(curso);

// //3. Criar uma variável chamada nome e outra chamada sobrenome e guardar nelas seu nome e sobrenome. 

// string nome = "Carlos ";

// string sobrenome = "Carvalho";

// Console.WriteLine(nome + sobrenome);

// //4. Mostrar na tela o nome dos instrutores do curso.

// string primeiroInstrutor = "Daniel Portugal";
// string segundoInstrutor = "Guilherme Lima";
// Console.WriteLine(primeiroInstrutor + "\n" + segundoInstrutor);

//5. Criar uma variável chamada notaMedia e atribua um valor inteiro a ela.
//Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".

// int notaMedia = 5;
// if (notaMedia >= 5)
// {
//     Console.WriteLine("Nota suficiente para aprovação");
// }

//6. Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.

//List<string> linguagens = new List<string> {"C#", "Jaav", "JaavScript"};

//7. Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.

//Console.WriteLine(linguagens[0]);

//8.Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado,
//exibir a n-ésima posição de uma lista.

// List<int> duck = new List<int> {1,2,3,4,5,6,7,8,9,10};
// Console.Write("Digite a posição: ");
// string Op = Console.ReadLine()!;
// int OpN = int.Parse(Op);
// Console.WriteLine(duck[OpN]);

//9.Chegou a hora de você seguir todos os passos realizados durante esta aula e criar um jogo com os 
//conhecimentos adquiridos.Neste jogo, o programa gera um número aleatório entre 1 e 100 e o usuário deve 
//adivinhar qual é esse número. O programa utiliza o if-else e switch case para verificar se o número 
//digitado pelo usuário é maior ou menor do que o número gerado pelo programa.
//O programa também utiliza o conceito de laço de repetição do-while para permitir que o usuário faça várias
//tentativas até acertar o número. Quando o usuário acertar o número, o jogo acaba e o programa exibe uma 
//mensagem indicando que o jogo acabou.

// Random random = new Random();
// int randomNumber = random.Next(0,101);
// string valorDigitado;
// Console.WriteLine("Bem vindo ao jogo, tente acertar o número que estou pensando");

// Console.Write("Digite o número que deseja: ");
// valorDigitado = Console.ReadLine()!;
// int numeroDigitado = int.Parse(valorDigitado);

// while(numeroDigitado != randomNumber)
// {

//     if(numeroDigitado == randomNumber)
//     {
//         break;
//     }
//     else if(numeroDigitado < randomNumber)
//     {
//         Console.WriteLine("O número digitado é menor que o número que pensei\nTente Novamente!");
//     }
//     else
//     {
//         Console.WriteLine("O número digitado é maior que o número que pensei\nTente Novamente!");
//     }

//     Console.Write("Digite o número que deseja: ");
//     numeroDigitado = int.Parse(Console.ReadLine()!);

// }
// Console.WriteLine("Parabens, você conseguiu descobrir");

//10. Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o 
//resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando 
//interpolação de strings.

// Console.Write("Digite um número: ");
// string A = Console.ReadLine()!;
// float a = float.Parse(A);

// Console.Write("Digite outro número: ");
// string B = Console.ReadLine()!;
// float b = float.Parse(B);

// float adicao = a + b;
// float subtracao = a - b;
// float divisao1 = a / b;
// float divisao2 = b / a;
// float multiplicacao = a * b;

// Console.WriteLine($"Resultado:\nAdição: {adicao}\nSubtração: {subtracao}\nDivisão do primeiro pelo segundo: {divisao1}\nDivisão do segundo pelo primeiro: {divisao2}\nMultiplicação: {multiplicacao}");

//11. Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.
//12. Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.


// List<string> bandasPrediletas = new List<string>();
// void Menu()
// {
//     Console.WriteLine("Digite 1 para adicionar banda");
//     Console.WriteLine("Digite 2 para ver as bandas adicionadas");
//     Console.WriteLine("Digite 3 para sair");
//     string opcaoEscolhida = Console.ReadLine()!;
//     int chosenOption = int.Parse(opcaoEscolhida);
//     switch(chosenOption)
//     {
//         case 1: 
//         AddBand();
//         break;

//         case 2:
//         ShowBands();
//         break;

//         case 3:
//         Console.WriteLine("Saindo.......");
//         break;        

//         default:
//         Console.WriteLine("Opção inválida!!");
//         break;
//     }
// }
// Menu();
// void AddBand()
// {
//     Console.Clear();
//     Console.WriteLine("Adicionando bandas");
//     Console.Write("Digite a banda que deseja adicionar: ");
//     bandasPrediletas.Add(Console.ReadLine()!);
//     Console.WriteLine("Banda adicionada");
//     Console.Clear();
//     Menu();
// }

// void ShowBands()
// {
//     Console.WriteLine("Mostrando as bandas\n");
//     for (int i = 0; i < bandasPrediletas.Count;i++)
//     {
//         Console.WriteLine(bandasPrediletas[i]);
//     }
//     Console.WriteLine("\nDigite qualquer coisa para sair..");
//     Console.ReadKey();
//     Menu();
// }

// //13. Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.

// using System.Runtime.InteropServices;
// List<int> inteiros = new List<int>();
// int answer = 0;

// while(true)
// {
//     Console.Write("Digite um valor: ");
//     inteiros.Add(int.Parse(Console.ReadLine()!));
//     Console.Write("Deseja continuar? ");
//     string resposta = Console.ReadLine()!;
//     resposta = resposta.ToLower();
//     if (resposta == "n")
//     {
//         break;
//     }

// }
// foreach (int inteiro in inteiros)
// {
//     answer += inteiro;
// }   
// Console.WriteLine(answer);

//14. Crie uma lista de inteiros utilizando o List<int> e utilize o for e o foreach para iterar sobre essa lista e exibir apenas os números pares.
// No for, comece o índice em 0 e incremente a cada iteração. Defina a condição de continuação do loop como i < numeros.Count, ou seja, o loop continuará enquanto o valor de i for menor do que o número de elementos na lista. Acesse o valor de cada elemento utilizando a sintaxe numeros[i].
// Já no foreach, ao invés de utilizar um loop for com um contador i e acessar os elementos da lista através do índice i, é utilizado o foreach para percorrer a lista e acessar diretamente cada elemento com a variável número. Em seguida, é verificado se o número é par utilizando o operador de módulo (%) e, caso seja, o número é impresso no console.

// List<int> numeros = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

// for (int i = 0; i < numeros.Count;i++)
// {
//     if( numeros[i] % 2 == 0 )
//     {
//         Console.WriteLine(numeros[i]);
//     }
// }

// foreach (int numero in numeros)
// {
//     if (numero % 2 == 0)
//     {
//         Console.WriteLine($"O número {numero} é par");
//     }
// }

// Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
// Dictionary<string,List<int>> aluno = new Dictionary<string, List<int>>();
// aluno.Add("Rodrigo", new List<int> { 10, 9, 8});
// List<int> notas = aluno["Rodrigo"];
// Double notaMedia = notas.Average();
// Console.WriteLine($"A media das notas é: {notaMedia}");



// Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.

// Dictionary<string,int> estoque = new Dictionary<string, int>();
// estoque.Add("Prateleira",10);
// estoque.Add("Armario",8);
// estoque.Add("Gaveta",120);
// estoque.Add("Garrafa",2);
// Console.Write("Digite o item que deseja saber a quantidade: ");
// string item = Console.ReadLine()!;
// int quant = estoque[item];
// Console.WriteLine($"Existem {quant} de {item} no estoque");


// Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.

// Dictionary<string,string> quiz = new Dictionary<string, string>();
// quiz.Add("Qual a fruta que começa com B? ", "Banana");
// quiz.Add("Como se chama os animais voadores? ", "Ave");
// quiz.Add("Qual o nome da mulher mais linda e fofa do universo inteiro ", "Isabelly");

// foreach (var pergunta in quiz)
// {
//     Console.WriteLine(pergunta.Key);

//     Console.Write("Digite sua resposta: ");
//     string resposta = Console.ReadLine()!;

//     if(resposta.Equals(pergunta.Value, StringComparison.OrdinalIgnoreCase))
//     {
//         Console.WriteLine("Parabens, esta correto");
//     }
//     else
//     {
//         Console.WriteLine("Resposta Incorreta!");
//     }
// }


// Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.

// Dictionary<string,string> login = new Dictionary<string, string>();
// login.Add("Isabelly","ExtremamenteFofa007");

// Console.Write("Digite o seu usuário: ");
// string usuario = Console.ReadLine()!;
// if (login.ContainsKey(usuario))
// {
//     Console.Write("Digite a senha: ");
//     string senha = Console.ReadLine()!;
//     if(senha == login[usuario])
//     {
//         Console.WriteLine("Logado com sucesso");
//     }
//     else
//     {
//         Console.WriteLine("Senha incorreta");
//     }
// }
// else
// {
//     Console.WriteLine("Usuário incorreto");
// }

//Com base na lista de super carros fornecida abaixo, onde a chave é o nome do carro e os valores são quantas vezes esse carro foi vendido por ano, calcule a média de uma chave específica.

// Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
//     { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
//     { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
//     { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
//     { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
//     { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
// };

// double media;

// media = vendasCarros["Bugatti Veyron"].Average();
// Console.WriteLine(media);