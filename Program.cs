using teste.Models;



// DateTime dataAtual = DateTime.Now; // Data Atual
DateTime dataAtual = DateTime.Now.AddDays(5);

Console.WriteLine(dataAtual.ToString("dd/MM/yyyy  HH:mm")); // Colocar pra mostrar somente até os minutos e adicionar cindo dias a frente

 string apresentacao = "Olá, vamos que vamos";

 int quantidade = 1;

 quantidade = 10;

 double altura = 1.72;

 decimal preco = 1.80M;

 bool condicao = true;



 Console.WriteLine(apresentacao);

 Console.WriteLine("Valor da variavel quantidade :" + quantidade);
 Console.WriteLine("Valor da variavel altura :" + altura.ToString("0.00"));// tratamento toString serve para se tiver o 0 na terceira casa pra ele não perder a representatividade
 Console.WriteLine("Valor da variavel preco :" + preco);
 Console.WriteLine("Valor da variavel condicao :" + condicao);









//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Buta";
//pessoa1.Idade = 26;
//pessoa1.Apresentar();
