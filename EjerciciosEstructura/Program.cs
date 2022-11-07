using Microsoft.VisualBasic;


estudiante estudianteUno = new estudiante("CARlo", 456765, "CR 54 a num 98-11", "juanpa@hotmial.com",true );
estudianteUno.Name = "juanpa";
Console.WriteLine(estudianteUno);

public struct estudiante
{

    public estudiante(string nombre, int telefono, string direccion, string email, bool nuevoCliente)
    {
        Name = nombre;
        Tel = telefono;
        DI = direccion;
        Correo = email;
        Esnuevo = nuevoCliente;
    }

    public string Name { get; set;}
    public int Tel { get; }
    public string DI { get; }
    public string Correo { get; }
    public bool Esnuevo { get; }

    public override string ToString() => $"(El nombre es :{Name} , Telefono :  {Tel} ,Direccion : {DI} , Correo: {Correo} ,  el empleado es: {Esnuevo})";

}
