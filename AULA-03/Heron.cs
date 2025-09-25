public class Triangulo()
{
    double arestas1;
    double arestas2;
    double arestas3;
    double p;
    double area;


    public void Calcule()
    {
        p = (arestas1 + arestas2 + arestas3) / 2;

        area = (p * (p - arestas1) * (p - arestas2) * (p - arestas3));


        Console.WriteLine("Digite o valor da Aresta1");
        arestas1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor da Aresta2");
        arestas2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor da Aresta3");
        arestas3 = Convert.ToDouble(Console.ReadLine());

    }
}
// git clone -link- clonar outro projeto
// git pull -baixar atualizacao-
