 using teste.Models;

//Cast - Casting (Conversão de variavel para string/inteiro)

//Convert consegue tratar valores nulos enquanto o Parse não aceita null.

//int a = Convert.ToInt32("5");
 int a = int.Parse("5"); //converte o 5 em string para inteiro

Console.WriteLine(a);
 // Sinal= é o Operator de atribuição , quando você alterar o valor da sua variavel ou atribuir algo

// int a = 10;
// int b = 20;

// int c = a + b;

// // += é exatamente igual a esse operador c = c +5;
// c+= 5;
// //c-=5;
// Console.WriteLine(c);





// // DateTime dataAtual = DateTime.Now; // Data Atual
// DateTime dataAtual = DateTime.Now.AddDays(5);

// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy  HH:mm")); // Colocar pra mostrar somente até os minutos e adicionar cindo dias a frente

//  string apresentacao = "Olá, vamos que vamos";

//  int quantidade = 1;

//  quantidade = 10;

//  double altura = 1.72;

//  decimal preco = 1.80M;

//  bool condicao = true;


//  Console.WriteLine(apresentacao);

//  Console.WriteLine("Valor da variavel quantidade :" + quantidade);
//  Console.WriteLine("Valor da variavel altura :" + altura.ToString("0.00"));// tratamento toString serve para se tiver o 0 na terceira casa pra ele não perder a representatividade
//  Console.WriteLine("Valor da variavel preco :" + preco);
//  Console.WriteLine("Valor da variavel condicao :" + condicao);




// //Pessoa pessoa1 = new Pessoa();

// //pessoa1.Nome = "Buta";
// //pessoa1.Idade = 26;
// //pessoa1.Apresentar();
