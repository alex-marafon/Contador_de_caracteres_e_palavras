int sair = 0;
while(sair != 1){
Console.WriteLine("AI do Balta");
Console.WriteLine("Informe um texto, falarei quantos caracteres e palavras contem seu texto: ");
Console.WriteLine("----------------------------");
Console.WriteLine("Digite "+ " s " +" para sair");
Console.WriteLine("----------------------------");
var text = Console.ReadLine();
if(string.IsNullOrEmpty(text))
    Console.WriteLine($"Informe um texto");

if(text.Length == 1 && text == "s" ){
Environment.Exit(1);
}
int characters = 0, words = 0;
(characters, words) = (text.Length, text.Split(' ').Length );
Console.WriteLine("----------------------------");
Console.WriteLine($"{characters} caracteres, {words} palavras");
Console.WriteLine("----------------------------");
Console.ReadKey();
Console.Clear();
Console.WriteLine("----------------------------");
}
