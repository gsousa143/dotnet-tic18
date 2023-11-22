string[] pessoas = {"gabriel","girleide","allana","joka"};
char letra 'i';
Console.WriteLine( $"Pessoas com nome que tenham a letra {letra}: { string.Join(
pessoas.Where( x => x.Contains(letra) ) ) }");