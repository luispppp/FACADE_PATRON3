class Impresora
{
    //creamos los atributos que tiene nuestra impresora
    protected string Nombre{get; set;}
    protected string Hoja{get; set;}
    protected string Texto{get; set;}
    protected int Nhoja{get; set;}

    //le damos valor a nuestros atributos     
    public Impresora(string Nombre, string Hoja, string Texto, int Nhoja)
    {
        this.Nombre=Nombre;
        this.Hoja=Hoja;
        this.Texto=Texto;
        this.Nhoja=Nhoja;
    }
    //creamos nuestro metodo para imprimir el documento
    public virtual void ImprirmirDoc()
    {

    }
   
}