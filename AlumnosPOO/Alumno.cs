namespace AlumnosPOO
{
    internal class Alumno
    {
        string nombre;
        string grupo;
        string contraseña;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;

            }

        }
    }
    public string Grupo
    {
        get
        {
            return grupo;
        }
        set
        {
            grupo = value;
        }
    }
    public string Contraseña
    {
        get
        {
            return contraseña;
        }
        set 
        {
            contraseña = value;
        }
    }
}
