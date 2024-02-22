int Menu()
{
    string? i;
    int op;
    Console.WriteLine("===== FisicaApp =====");
    Console.WriteLine("1- Velocidade Média");
    Console.WriteLine("2- Aceleração");
    Console.WriteLine("3- Movimento Uniforme");
    Console.WriteLine("4- Torricelli");
    Console.WriteLine("0- Sair");
    Console.WriteLine();
    Console.Write("Opção: ");
    i = Console.ReadLine();
    Int32.TryParse(i, out op);
    return op;
}
double VelocidadeMedia()
{
    string? i;
    double s, t;
    Console.WriteLine("Espaço: ");
    i = Console.ReadLine();
    Double.TryParse(i, out s);
    Console.WriteLine("Tempo: ");
    i = Console.ReadLine();
    Double.TryParse(i, out t);
    return s / t;
}
double Aceleracao()
{
    string? i;
    double v, t;
    Console.WriteLine("Velocidade: ");
    i = Console.ReadLine();
    Double.TryParse(i, out v);
    Console.Write("Tempo: ");
    i = Console.ReadLine();
    Double.TryParse(i, out t);   
    return v / t;   
}
double MovimentoUniforme()
{
    string? i;
    double s0, v, t;
    Console.Write("Espaço Inicial: ");
    i = Console.ReadLine();
    Double.TryParse(i, out s0);
    Console.Write("Velocidade: ");
    i = Console.ReadLine();
    Double.TryParse(i, out v);
    Console.Write("Tempo: ");
    i = Console.ReadLine();
    Double.TryParse(i, out t);
    return s0 + v * t;
}
double Torricelli()
{
    string? i;
    double v0, a, s;
    Console.Write("Velocidade Inicial: ");
    i = Console.ReadLine();
    Double.TryParse(i, out v0);
    Console.Write("Aceleração: ");
    i = Console.ReadLine();
    Double.TryParse(i, out a);
    Console.Write("Espaço: ");
    i = Console.ReadLine();
    Double.TryParse(i, out s);
    return Math.Sqrt(Math.Pow(v0, 2) + 2 * a * s);
}
int escolha;
do
{
    escolha = Menu();
    if (escolha == 1) //velocidade media
    {
        double v = VelocidadeMedia();
        Console.WriteLine("Velocidade Média: " + String.Format("{0:.##}", v));
    }else if(escolha == 2) // aceleracao
    {
        double a = Aceleracao();
        Console.WriteLine("Aceleração: " + String.Format("{0:.##}", a));
    }else if(escolha == 3) // movimento uniforme
    {
        double s = MovimentoUniforme();
        Console.WriteLine("Espaço Final: " + String.Format("{0:.##}", s));
    }else if(escolha == 4) // torricelli
    {
        double v = Torricelli();
        Console.WriteLine("Velocidade Final: " + String.Format("{0:.##}", v));
    }
}while (escolha != 0);