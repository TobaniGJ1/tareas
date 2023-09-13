using System;

// Clase base Persona
public class Persona
{
    public string Nombre { get; set; }
    public string Direccion { get; set; }

    public Persona(string nombre, string direccion)
    {
        Nombre = nombre;
        Direccion = direccion;
    }
}

// Clase abstracta MiembroComunidad heredada de Persona
public abstract class MiembroComunidad : Persona
{
    public MiembroComunidad(string nombre, string direccion) : base(nombre, direccion)
    {
    }
}

// Clase Empleado heredada de MiembroComunidad
public class Empleado : MiembroComunidad
{
    public decimal Salario { get; set; }
    public string Cargo { get; set; }

    public Empleado(string nombre, string direccion, decimal salario, string cargo) : base(nombre, direccion)
    {
        Salario = salario;
        Cargo = cargo;
    }
}

// Clase Estudiante heredada de MiembroComunidad
public class Estudiante : MiembroComunidad
{
    public int NumeroEstudiante { get; set; }
    public string Programa { get; set; }

    public Estudiante(string nombre, string direccion, int numeroEstudiante, string programa) : base(nombre, direccion)
    {
        NumeroEstudiante = numeroEstudiante;
        Programa = programa;
    }
}

// Clase ExAlumno heredada de MiembroComunidad
public class ExAlumno : MiembroComunidad
{
    public int AnioGraduacion { get; set; }

    public ExAlumno(string nombre, string direccion, int anioGraduacion) : base(nombre, direccion)
    {
        AnioGraduacion = anioGraduacion;
    }
}

// Clase Docente heredada de Empleado
public class Docente : Empleado
{
    public string Materia { get; set; }

    public Docente(string nombre, string direccion, decimal salario, string cargo, string materia) : base(nombre, direccion, salario, cargo)
    {
        Materia = materia;
    }
}

// Clase Administrativo heredada de Empleado
public class Administrativo : Empleado
{
    public string Departamento { get; set; }

    public Administrativo(string nombre, string direccion, decimal salario, string cargo, string departamento) : base(nombre, direccion, salario, cargo)
    {
        Departamento = departamento;
    }
}

// Clase Administrador heredada de Empleado
public class Administrador : Empleado
{
    public string NivelAcceso { get; set; }

    public Administrador(string nombre, string direccion, decimal salario, string cargo, string nivelAcceso) : base(nombre, direccion, salario, cargo)
    {
        NivelAcceso = nivelAcceso;
    }
}

// Clase Maestro heredada de Docente
public class Maestro : Docente
{
    public Maestro(string nombre, string direccion, decimal salario, string cargo, string materia) : base(nombre, direccion, salario, cargo, materia)
    {
    }
}