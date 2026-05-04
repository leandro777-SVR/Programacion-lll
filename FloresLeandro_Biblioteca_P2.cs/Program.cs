using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// === PROBLEMA 2 — Archivo: FloresLeandro_Biblioteca_P2.cs ===

namespace Biblioteca_P2
{
    public abstract class Material
    {
        private string _nombre;
        private string _idMaterial;
        private string _categoria;

        public string Nombre => _nombre;
        public string IdMaterial => _idMaterial;

        public string Categoria
        {
            get => _categoria;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("La categoría no puede estar vacía.");
                _categoria = value;
            }
        }

        public int Anio { get; set; }

        public Material(string idMaterial, string nombre, string categoria, int anio)
        {
            _idMaterial = idMaterial;
            _nombre = nombre;
            Categoria = categoria;
            Anio = anio;
        }

        public abstract decimal CalcularCostoBase();

        public virtual string ObtenerFicha()
        {
            return $"[{IdMaterial}] | {Nombre} | {Categoria} | Año: {Anio}";
        }
    }

    public class Libro : Material
    {
        public string Autor { get; set; }
        public int NroPaginas { get; set; }

        public Libro(string idMaterial, string nombre, string categoria, int anio, string autor, int nroPaginas)
            : base(idMaterial, nombre, categoria, anio)
        {
            Autor = autor;
            NroPaginas = nroPaginas;
        }

        public override decimal CalcularCostoBase()
        {
            return 1500m + (NroPaginas * 0.5m);
        }

        public override string ObtenerFicha()
        {
            return $"{base.ObtenerFicha()} | Autor: {Autor} | Páginas: {NroPaginas}";
        }
    }

    public class Revista : Material
    {
        public string Editorial { get; set; }
        public int NroEdicion { get; set; }

        public Revista(string idMaterial, string nombre, string categoria, int anio, string editorial, int nroEdicion)
            : base(idMaterial, nombre, categoria, anio)
        {
            Editorial = editorial;
            NroEdicion = nroEdicion;
        }

        public override decimal CalcularCostoBase()
        {
            return 800m;
        }
    }

    public class Prestamo
    {
        public string IdPrestamo { get; set; }
        public string IdMaterial { get; set; }
        public string NombreSocio { get; set; }
        public string Motivo { get; set; }
        public decimal Multa { get; set; }
        public DateTime Fecha { get; set; }

        public Prestamo(string idPrestamo, string idMaterial, string nombreSocio, string motivo, decimal multa, DateTime fecha)
        {
            IdPrestamo = idPrestamo;
            IdMaterial = idMaterial;
            NombreSocio = nombreSocio;
            Motivo = motivo;
            Multa = multa;
            Fecha = fecha;
        }
    }

    public static class Buscador
    {
        public static Material BuscarMaterialPorId(List<Material> lista, string id, int indice = 0)
        {
            if (indice >= lista.Count) return null;
            if (lista[indice].IdMaterial == id) return lista[indice];
            return BuscarMaterialPorId(lista, id, indice + 1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Carga de datos inicial obligatoria para que el código funcione de forma independiente
            List<Material> registros = new List<Material>
            {
                new Libro("M001", "El Aleph", "Ficción", 2000, "Borges, J.L.", 274),
                new Libro("M002", "Rayuela", "Ficción", 1963, "Cortázar, J.", 600),
                new Revista("M003", "National Geo", "Ciencia", 2023, "Nat Geo Ed.", 45),
                new Libro("M004", "Cien años", "Ficción", 1967, "García Márquez", 432),
                new Revista("M005", "Time Magazine", "Actualidad", 2024, "Time Inc.", 12),
                new Libro("M006", "Ficciones", "Ficción", 1944, "Borges, J.L.", 186)
            };

            List<Prestamo> registros2 = new List<Prestamo>
            {
                new Prestamo("P001", "M001", "Socio: Ana López", "Lectura recreativa", 0m, new DateTime(2026, 4, 1)),
                new Prestamo("P002", "M001", "Socio: Luis Paz", "Investigación", 150m, new DateTime(2026, 4, 15)),
                new Prestamo("P003", "M002", "Socio: Ana López", "Tarea universitaria", 0m, new DateTime(2026, 4, 10)),
                new Prestamo("P004", "M003", "Socio: Mario Ruiz", "Información general", 0m, new DateTime(2026, 3, 20)),
                new Prestamo("P005", "M004", "Socio: Luis Paz", "Lectura recreativa", 200m, new DateTime(2026, 4, 5)),
                new Prestamo("P006", "M005", "Socio: Ana López", "Investigación", 0m, new DateTime(2026, 4, 22)),
                new Prestamo("P007", "M006", "Socio: Mario Ruiz", "Tarea universitaria", 0m, new DateTime(2026, 4, 25)),
                new Prestamo("P008", "M003", "Socio: Luis Paz", "Revisión periódica", 100m, new DateTime(2026, 2, 18))
            };

            Console.WriteLine("========== PARTE A: ESTRUCTURAS REPETITIVAS ==========\n");

            Console.WriteLine("--- Tarea 1: Historial de El Aleph ---");
            List<Prestamo> prestamosElAleph = new List<Prestamo>();
            decimal sumaElAleph = 0;

            for (int i = 0; i < registros2.Count; i++)
            {
                if (registros2[i].IdMaterial == "M001") prestamosElAleph.Add(registros2[i]);
            }

            foreach (var p in prestamosElAleph)
            {
                Console.WriteLine($"[{p.IdPrestamo}] | [{p.Fecha:dd/MM/yyyy}] | [{p.Motivo}] | Responsable: {p.NombreSocio} | ${p.Multa}");
                sumaElAleph += p.Multa;
            }
            Console.WriteLine($"Total acumulado de El Aleph: ${sumaElAleph}\n");


            Console.WriteLine("--- Tarea 2: Tabla de costos base ---");
            int indiceWhile = 0;
            while (indiceWhile < registros.Count)
            {
                Material m = registros[indiceWhile];
                Console.WriteLine($"{m.Nombre} ({m.Categoria}) → Costo base: ${m.CalcularCostoBase()}");
                indiceWhile++;
            }
            Console.WriteLine();


            Console.WriteLine("--- Tarea 3: Reporte por responsable ---");
            string[] responsables = { "Socio: Ana López", "Socio: Luis Paz", "Socio: Mario Ruiz" };
            int rIndex = 0;
            decimal totalGeneral = 0;

            Console.WriteLine("=== REPORTE POR RESPONSABLE ===");
            do
            {
                string responsableActual = responsables[rIndex];
                int cantidadRegistros = 0;
                decimal sumaResponsable = 0;

                for (int i = 0; i < registros2.Count; i++)
                {
                    if (registros2[i].NombreSocio == responsableActual)
                    {
                        cantidadRegistros++;
                        sumaResponsable += registros2[i].Multa;
                    }
                }

                Console.WriteLine($"{responsableActual} → {cantidadRegistros} registros | Total: ${sumaResponsable}");
                totalGeneral += sumaResponsable;
                rIndex++;

            } while (rIndex < responsables.Length);

            Console.WriteLine("─────────────────────────────");
            Console.WriteLine($"TOTAL GENERAL: ${totalGeneral}\n");


            Console.WriteLine("========== PARTE B: RECURSIVIDAD, ARRAYS Y MATRICES ==========\n");

            Console.WriteLine("--- Ejercicio 1: Búsqueda Recursiva ---");
            Material hallado = Buscador.BuscarMaterialPorId(registros, "M004");
            if (hallado != null) Console.WriteLine(hallado.ObtenerFicha());
            else Console.WriteLine("M004 no encontrado.");

            Material noHallado = Buscador.BuscarMaterialPorId(registros, "M999");
            if (noHallado != null) Console.WriteLine(noHallado.ObtenerFicha());
            else Console.WriteLine("M999 no encontrado.");
            Console.WriteLine();


            Console.WriteLine("--- Ejercicio 2: Array de Gastos ---");
            decimal[] costosPorMaterial = new decimal[registros.Count];

            for (int i = 0; i < registros.Count; i++)
            {
                for (int j = 0; j < registros2.Count; j++)
                {
                    if (registros[i].IdMaterial == registros2[j].IdMaterial)
                    {
                        costosPorMaterial[i] += registros2[j].Multa;
                    }
                }
            }

            decimal mayorGasto = -1;
            string nombreMayorGasto = "";
            decimal menorGasto = decimal.MaxValue;
            string nombreMenorGasto = "";
            decimal sumaGastosPromedio = 0;
            int elementosConGasto = 0;

            for (int i = 0; i < costosPorMaterial.Length; i++)
            {
                decimal gastoActual = costosPorMaterial[i];
                string nombreActual = registros[i].Nombre;

                if (gastoActual > mayorGasto)
                {
                    mayorGasto = gastoActual;
                    nombreMayorGasto = nombreActual;
                }

                if (gastoActual >= 0)
                {
                    bool tieneConsultas = false;
                    for (int j = 0; j < registros2.Count; j++)
                    {
                        if (registros2[j].IdMaterial == registros[i].IdMaterial)
                        {
                            tieneConsultas = true;
                            break;
                        }
                    }

                    if (tieneConsultas)
                    {
                        if (gastoActual < menorGasto)
                        {
                            menorGasto = gastoActual;
                            nombreMenorGasto = nombreActual;
                        }
                        sumaGastosPromedio += gastoActual;
                        elementosConGasto++;
                    }
                }
            }

            if (elementosConGasto > 0)
            {
                Console.WriteLine($"Mayor gasto: {nombreMayorGasto} — ${mayorGasto}");
                Console.WriteLine($"Menor gasto: {nombreMenorGasto} — ${menorGasto}");
                Console.WriteLine($"Promedio: ${(sumaGastosPromedio / elementosConGasto):F2}");
            }
            Console.WriteLine();


            Console.WriteLine("--- Ejercicio 3: Matriz ---");
            decimal[,] matriz = new decimal[registros.Count, responsables.Length];

            for (int i = 0; i < registros.Count; i++)
            {
                for (int j = 0; j < responsables.Length; j++)
                {
                    for (int k = 0; k < registros2.Count; k++)
                    {
                        if (registros2[k].IdMaterial == registros[i].IdMaterial &&
                            registros2[k].NombreSocio == responsables[j])
                        {
                            matriz[i, j] += registros2[k].Multa;
                        }
                    }
                }
            }

            decimal[] totalPorResponsable = new decimal[responsables.Length];
            decimal maxRecaudacion = -1;
            string responsableMax = "";

            Console.WriteLine($"{"Material",-15} | {responsables[0],-16} | {responsables[1],-15} | {responsables[2],-16}");
            Console.WriteLine(new string('-', 75));

            for (int i = 0; i < registros.Count; i++)
            {
                Console.Write($"{registros[i].Nombre,-15} | ");
                for (int j = 0; j < responsables.Length; j++)
                {
                    Console.Write($"${matriz[i, j],-15} | ");
                    totalPorResponsable[j] += matriz[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int j = 0; j < responsables.Length; j++)
            {
                int cantidadPrestamos = 0;
                for (int k = 0; k < registros2.Count; k++)
                {
                    if (registros2[k].NombreSocio == responsables[j]) cantidadPrestamos++;
                }

                Console.WriteLine($"{responsables[j].Replace("Socio: ", "")} {cantidadPrestamos} préstamos ${totalPorResponsable[j]}");

                if (totalPorResponsable[j] > maxRecaudacion)
                {
                    maxRecaudacion = totalPorResponsable[j];
                    responsableMax = responsables[j].Replace("Socio: ", "");
                }
            }

            Console.WriteLine($"\nEl responsable con mayor recaudación es: {responsableMax}");
        }
    }
}
