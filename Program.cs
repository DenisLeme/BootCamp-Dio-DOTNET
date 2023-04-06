 using teste.Models;

//Operador AND (&&) você só vai ter cenario positivo caso todas as condições forem verdadeiras , se uma for falsa todas suas condições irão falhar

bool possuiPresencaMin = false;
double media = 6.5;

if(possuiPresencaMin && media >= 7){
    Console.WriteLine("Aprovado");
}else{
    Console.WriteLine("Reprovado!!");
}



//Operador OR na pratica
// Operador OR (Pipe, || ) ou

// bool eMaiorDeIdade = false;

// bool possuiAutorizacao = true;

// if(eMaiorDeIdade || possuiAutorizacao)
// {
//     Console.WriteLine("Entrada Liberada!");
// }
// else{
//     Console.WriteLine("Entrada não liberada");
// }



// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine(); //ReadLine permite que o terminal espere o comando que você digite.

// switch(letra){
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//     Console.WriteLine("Vogal");
//     break;

//     default:
//     Console.WriteLine("Não é uma vogal");
//     break;
// }




// melhorando o código abaixo
// if (letra == "a " ||
//     letra == "e " ||
//     letra == "i " ||
//     letra == "o " ||
//     letra == "u ")
//     {
//         Console.WriteLine("Vogal");
//     }else{
//         Console.WriteLine("Não é vogal");
//     }

// if (letra == "a"){
//     Console.WriteLine("Vogal");

// }else if(letra == "e"){
//     Console.WriteLine("Vogal");
// }else if (letra == "i"){
//     Console.WriteLine("Vogal");
// }else if(letra == "o"){
//     Console.WriteLine("Vogal");
// }else if (letra == "u"){
//     Console.WriteLine("Vogal");
// }else{
//     Console.WriteLine("Não é uma vogal");
// }




// int quantidadeEmEstoque = 10;

// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra; // && = e 
// Console.WriteLine($"Quantidade em Estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É Possível realizar a venda? {possivelVenda}");

// if(quantidadeCompra == 0){ // == é comparação 
//     Console.WriteLine("Venda Inválida!!");
// }

// else if(possivelVenda)
// {
//     Console.WriteLine("Venda Realizada.");
// }
// else{
//     Console.WriteLine("Sem Saldo em estoque.");
// }



// Conversão da maneira mais segura
// string a = "15-";

// int b = 0;

// int.TryParse(a, out b);  <-- a para sair b 

// Console.WriteLine(b);
// Console.WriteLine("Conversão Realizada com Sucesso!!!");



// double a = 4/ (2 +2);
// Console.WriteLine(a);


// int a = 5;
// double b = a;


// cast implicito faz a conversão automatica
// int a = int.MaxValue;
// long b = a;

//  Console.WriteLine(b);


// int inteiro = 5;
// string a = inteiro.ToString(); conversao do inteiro para string


// Console.WriteLine(a);





//Cast - Casting (Conversão de variavel para string/inteiro)

//Convert consegue tratar valores nulos enquanto o Parse não aceita null.


//int a = Convert.ToInt32("5");
//int a = int.Parse("5"); //converte o 5 em string para inteiro ou o 5 int para string

//Console.WriteLine(a);
 
 
 

 
 
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
