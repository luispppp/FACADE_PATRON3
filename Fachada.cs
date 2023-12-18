class Fachada
{
    private Impresora impresora;
    private Documento documento;
    public Fachada()
    {
        //instanciamos o podemos decir que llamamos a los subsistemas mediante la fachada
        this.impresora = new Impresora("Doc1","A4","paseme de semestre:(", 4);
        this.documento = new Documento("Doc1","A4","paseme de semestre:(", 4);
    }
    //mediante este metodo, utilizamos los metodos de los demas subsistemas paa hacerlo de manera simplificada para el usuario
    public void ImprimirHoja()
    {
        documento.imprimir();
        impresora.ImprirmirDoc();
        
    }
}