// See https://aka.ms/new-console-template for more information
namespace Porta{
class Program{
public static void Main(string [] args){
porta po = new porta();
Console.WriteLine("Digite a cor:");
po.cor = Console.ReadLine();
po.AbrirPorta();
Console.WriteLine(po.estadoPorta);
po.FecharPorta();
Console.WriteLine(po.estadoPorta);
}
}
}
namespace Porta{
public class porta{
public string cor;
public bool estadoPorta;
public bool AbrirPorta(){
return this.estadoPorta = true;
}
public bool FecharPorta(){
return this.estadoPorta = false;
}
}
}