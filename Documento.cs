  //heredamos a Documento para que utilice el metodo de imprimirDoc
class Documento: Impresora
{
   
    public Documento(string Nombre, string Hoja, string Texto, int Nhoja) : base(Nombre, Hoja, Texto, Nhoja)
    {
      
    }
    //utilizamos este metodo para informar al usuario las hojas que se imprimiran
    public void imprimir()
    {
         Console.WriteLine("el numero de hojas que se imprimira es: " + Nhoja);
    }
    //ahora en el metado sobreescrito mediante un for imprimiremos las hojas que requiera el usuario, con los demas detalles que solicite
    public override void ImprirmirDoc()
    {
        int i = 0;
        for(i=0; i<=Nhoja; i++)
        {
            Console.WriteLine("el nombre de su documento es: " + Nombre);
        Console.WriteLine("el formato de su documento es: " + Hoja);
        Console.WriteLine("el texto escrito en su documento es: " + Texto);
       
        }
    }
}