using System;
using System.Collections;

namespace practicaIII
{
	class MainClass
	{	public string codigo;
		public string nombre;
		public string direccion;
		public string facebook;
		public string telefono;

		public static void Main (string[] args)
		{
			MainClass Persona = new MainClass ();
		    Hashtable tabla=new Hashtable();
			
		

		for(int i=0;i<4;i++){
				Console.Clear();

				Console.WriteLine("Ingresa Datos de 4 Personas");

				Console.WriteLine("Dame el codigo");
				Persona.codigo = Console.ReadLine();
				Console.WriteLine("Dame el nombre");
				Persona.nombre = Console.ReadLine();
				Console.WriteLine("Dame la dirección");
				Persona.direccion = Console.ReadLine();
				Console.WriteLine("Dame el teléfono");
				Persona.telefono = Console.ReadLine();
				Console.WriteLine("Dame el facebook");
				Persona.facebook = Console.ReadLine();
				tabla.Add (Persona.codigo,Persona);
			}

			for (int i = 0; i < 2; i++) {
				Console.Clear ();
				Console.WriteLine ("Dame el código para editar");
				string codigo = Console.ReadLine ();
				if (tabla.ContainsKey (codigo)) {
					tabla.Remove (codigo);


					Console.WriteLine ("Dame el nombre");
					Persona.nombre = Console.ReadLine ();
					Console.WriteLine ("Dame la dirección");
					Persona.direccion = Console.ReadLine ();
					Console.WriteLine ("Dame el teléfono");
					Persona.telefono = Console.ReadLine ();
					Console.WriteLine ("Dame el facebook");
					Persona.facebook = Console.ReadLine ();
					Console.WriteLine ("");
					tabla.Add(codigo,Persona);
				} else {
					Console.WriteLine ("No existe el código.");
					Console.WriteLine ("Presione cualquier tecla para continuar.");
					Console.ReadLine ();
				}
			}
				for(int e = 0; e < 2; e++){
					Console.Clear();
					Console.WriteLine("Dame el código para eliminar");
					string codigo = Console.ReadLine();
					if(tabla.ContainsKey(codigo)){


				
						Console.WriteLine("¿Esta seguro que desea eliminar?");
						Console.WriteLine("0 = No, 1 = Si");
						string opcion = Console.ReadLine();
						if(opcion != "0"){
						tabla.Remove(codigo);
					}else{
							Console.WriteLine("No existe el código.");
							Console.WriteLine("Presione cualquier tecla para continuar.");
							Console.ReadLine();					}
				
			
				}
				for(int i=0;i<4;i++){
				Console.WriteLine("Código: " + Persona.codigo);
				Console.WriteLine("Nombre: " + Persona.nombre);
				Console.WriteLine("Dirección: " + Persona.direccion);
				Console.WriteLine("Teléfono: " + Persona.telefono);
				Console.WriteLine("Facebook: " + Persona.facebook);
				Console.WriteLine("");
				}

			}
		}
	}
}



