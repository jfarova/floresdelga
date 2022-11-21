internal class Program
{
    private static void Main(string[] args)
    {
        int l1,l2,l3;
        Console.WriteLine("ingresa lado 1");
       l1=int.Parse(Console.ReadLine());
       Console.WriteLine("ingresa lado 2");
       l2=int.Parse(Console.ReadLine());
       Console.WriteLine("ingresa lado 3");
       l3=int.Parse(Console.ReadLine());
       if(l1 == l2  && l2 == l3){
        Console.WriteLine("los dados correspuediente a un triangulo equilatero ");}
        else if(l1==l2 || l1==l3 || l2 ==l3){
         Console.WriteLine("los lados correspoden a un triangulo isosceles");
        }
     
        else
        {
            Console.WriteLine("los lados correspondiente a un triangulo escaleno");
        }
        
        }
       }
    
   



