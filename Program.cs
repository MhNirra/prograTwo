using Hotel;

List <Habitacion> habitaciones = new List <Habitacion> ();
List <Personal> trabajadores = new List <Personal> ();
List <Cliente> clientes = new List <Cliente> ();

const int maxClientes = 2;
const int maxHabitacion = 20;
const int maxPersonal = 3;

string aux;

for(int i = 0; i < maxClientes; i++)
{

    var cliente = new Cliente ();
    Console.Write("Ingrese rut: ");
    aux = Console.ReadLine ();
    cliente.Rut = int.Parse(aux);
    Console.Write("Ingrese nombre: ");
    aux = Console.ReadLine ();
    cliente.Nombre = aux;
    Console.Write("Ingrese apellido: ");
    aux = Console.ReadLine ();
    cliente.Apellido = aux;
    Console.Write("Ingrese numero de telefono: ");
    aux = Console.ReadLine ();
    cliente.NumeroTelefono = int.Parse(aux);

    clientes.Add (cliente);

}

Console.WriteLine("Clientes: ");

foreach (var cliente in clientes)
{
    Console.WriteLine($"Rut: {cliente.Rut}");
    Console.WriteLine($"Nombre: {cliente.Nombre} {cliente.Apellido}");
    Console.WriteLine($"Numero: {cliente.NumeroTelefono}");
}

for (int i = 1; i < maxHabitacion; i++)
{
    var tipo = (tipo_h)(i % 3);
    var estado = estado_h.DISPONIBLE;
    habitaciones.Add(new Habitacion
    {
        NumeroHabitacion = i,
        TipoHabitacion = tipo,
        
    });
}

foreach(var habitacion in habitaciones)
{
    Console.WriteLine(habitacion.ObtenerInformacionCompleta());
}

for (int i = 0; i < maxPersonal; i++)
{


    var personal = new Personal();
    personal.Identificar = i + 1;
    Console.Write("Ingrese nombre del trabajador: ");
    aux = Console.ReadLine();
    personal.NombreTrabajador = aux;
    Console.Write("Apellido del trabajado: ");
    aux = Console.ReadLine();
    personal.ApellidoTrabajador = aux;
    personal.Cargos = (cargos_t)(i % 3);

    trabajadores.Add(personal);

}

foreach( var personal in trabajadores)
{
    Console.WriteLine(personal.ObtenerInformacionCompleta());
}