Console.WriteLine("Digite um numero");
string input=Console.ReadLine();
int num;
try{
num = Int32.Parse(input);
Console.WriteLine(num);
}
catch(FormatException){
    Console.WriteLine("Tem que digitar um numero, otario");
}

