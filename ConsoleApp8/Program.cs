int maioresIdade = 0;
int menoresIdade = 0;


for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Digite a idade da pessoa " + i + ":");
    int idade = int.Parse(Console.ReadLine());


    if (idade >= 18)
    {
        maioresIdade++;
    }
    else
    {
        menoresIdade++;
    }
}

Console.WriteLine("Quantidade de pessoas maiores de idade: " + maioresIdade);
Console.WriteLine("Quantidade de pessoas menores de idade: " + menoresIdade);
