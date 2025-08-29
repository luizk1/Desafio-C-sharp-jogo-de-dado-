
/// ultilizando if && else  else if etc...
/// CRIANDO JOGO DE DADOS 
/*
Você usará o método Random.Next() para simular a rolagem de três dados de seis lados cada. Você avaliará os valores para calcular a pontuação. Se a pontuação for superior a um total arbitrário, você exibirá uma mensagem de vitória para o usuário. Se a pontuação estiver abaixo do corte, você exibirá uma mensagem de derrota para o usuário.

Se quaisquer dois dados rolados resultarem no mesmo valor, você receberá dois pontos de bônus pelo resultado duplicado.
Se os três dados rolados resultarem no mesmo valor, você receberá seis pontos de bônus pelo resultado triplicado.
Se a soma dos três dados rolados, mais quaisquer pontos de bônus, for igual ou maior que 15, você vencerá o jogo. Caso contrário, você perderá.

*/

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
int bonus = 0;

Console.WriteLine($"Voce Acertou: {roll1}, {roll2}, {roll3} (Total: {total})");

if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
{
    bonus = 2;
    Console.WriteLine("Voc Recebeu 2 pontos de bonus por dois numeros iguais");
}
else if (roll1 == roll2 && roll1 == roll3)
 {
     bonus = 6;
     Console.WriteLine("Voc Recebeu 6 pontos de bonus por tres numeros iguais");
 }

if (total >= 15)
{
    Console.WriteLine("Parabens, voce venceu!");
}
if (total < 15)
{
    Console.WriteLine("Voce perdeu, tente novamente");
}

total += bonus;
 Console.WriteLine($"Total with bonus: {total}");
