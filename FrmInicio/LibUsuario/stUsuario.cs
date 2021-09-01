namespace LibUsuario{ 
public enum Genero 
{ 
    Hombre, Mujer
}
public struct stUsuario 
{
    public string Nombre;
    public string Apellido;
    public int Edad;
    public Genero Sexo;
    public string [] Comentarios;
    public string Experiencia;
}
}