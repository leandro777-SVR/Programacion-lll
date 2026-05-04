using System;
using System.Collections.Generic;
using System.Linq;

// === PROBLEMA 1 — Archivo: FloresLeandro_Biblioteca_P1.cs ===

namespace Biblioteca_Sistema_de_Gestion
{
    // 1. CLASE ABSTRACTA
    public abstract class Material
    {
        // Campos privados
        private string _nombre;
        private string _idMaterial;
        private string _categoria;

        // Propiedades de solo lectura
        public string Nombre => _nombre;
        public string IdMaterial => _idMaterial;

        // Propiedad con validación en el setter
        public string Categoria
        {
            get => _categoria;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("La categoría no puede estar vacía.");
                }
                _categoria = value;
            }
        }

        // Propiedad auto-implementada
        public int Anio { get; set; }

        // Constructor
        public Material(string idMaterial, string nombre, string categoria, int anio)
        {
            _idMaterial = idMaterial;
            _nombre = nombre;
            Categoria = categoria;
            Anio = anio;
        }

        // Método abstracto
        public abstract decimal CalcularCostoBase();

        // Método virtual
        public virtual string ObtenerFicha()
        {
            return $"[{IdMaterial}] | {Nombre} | {Categoria} | Año: {Anio}";
        }
    }

    // 2. INTERFAZ
    public interface IPrestable
    {
        bool EstaDisponible { get; }
        void Prestar(string detalle);
        void Devolver();
        string ObtenerEstado(); // Solo la firma
    }

    // 3. CLASE LIBRO (Hereda de Material e implementa IPrestable)
    public class Libro : Material, IPrestable
    {
        // Propiedades encapsuladas
        public string Autor { get; set; }
        public int NroPaginas { get; set; }

        // Estado interno para la interfaz IPrestable
        private bool _estaDisponible = true;
        public bool EstaDisponible => _estaDisponible;

        // Constructor que llama a la clase base
        public Libro(string idMaterial, string nombre, string categoria, int anio, string autor, int nroPaginas)
            : base(idMaterial, nombre, categoria, anio)
        {
            Autor = autor;
            NroPaginas = nroPaginas;
        }

        // Override de CalcularCostoBase
        public override decimal CalcularCostoBase()
        {
            // Costo base: tarifa fija $1500 + $0.50 por cada página
            return 1500m + (NroPaginas * 0.5m);
        }

        // Override de ObtenerFicha
        public override string ObtenerFicha()
        {
            return $"{base.ObtenerFicha()} | Autor: {Autor} | Páginas: {NroPaginas}";
        }

        // Método propio
        public void AccionPropia()
        {
            Console.WriteLine($"Abriendo el libro de {Autor} y leyendo sus {NroPaginas} páginas...");
        }

        // Implementación de los métodos de IPrestable
        public void Prestar(string detalle)
        {
            if (_estaDisponible)
            {
                _estaDisponible = false;
                Console.WriteLine($"El libro ha sido prestado. Detalle: {detalle}");
            }
            else
            {
                Console.WriteLine("El libro no está disponible en este momento.");
            }
        }

        public void Devolver()
        {
            _estaDisponible = true;
            Console.WriteLine("El libro ha sido devuelto y vuelve a estar disponible.");
        }

        // Implementación corregida del estado
        public string ObtenerEstado()
        {
            return EstaDisponible ? "Disponible" : "Prestado";
        }
    }

    // 4. CLASE REVISTA (Hereda de Material)
    public class Revista : Material
    {
        // Propiedades encapsuladas
        public string Editorial { get; set; }
        public int NroEdicion { get; set; }

        // Constructor que llama a la clase base
        public Revista(string idMaterial, string nombre, string categoria, int anio, string editorial, int nroEdicion)
            : base(idMaterial, nombre, categoria, anio)
        {
            Editorial = editorial;
            NroEdicion = nroEdicion;
        }

        // Override de CalcularCostoBase
        public override decimal CalcularCostoBase()
        {
            // Costo base fijo de $800 para revistas
            return 800m;
        }

        // Override de ObtenerFicha
        public override string ObtenerFicha()
        {
            return $"{base.ObtenerFicha()} | Editorial: {Editorial} | Edición: {NroEdicion}";
        }
    }

    // 5. CLASE PRESTAMO (Reemplazo del Record para evitar errores de versión)
    public class Prestamo
    {
        public string IdPrestamo { get; set; }
        public string IdMaterial { get; set; }
        public string NombreSocio { get; set; }
        public string Motivo { get; set; }
        public decimal Multa { get; set; }
        public DateTime Fecha { get; set; }

        // Constructor
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

    // CLASE PRINCIPAL DEL PROGRAMA
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== PARTE B: CARGA Y OPERACIONES ==========\n");

            // ==========================================================
            Console.WriteLine("--- Paso 1: Cargar 6 registros ---");
            // ==========================================================
            List<Material> registros = new List<Material>
            {
                new Libro("M001", "El Aleph", "Ficción", 2000, "Borges, J.L.", 274),
                new Libro("M002", "Rayuela", "Ficción", 1963, "Cortázar, J.", 600),
                new Revista("M003", "National Geo", "Ciencia", 2023, "Nat Geo Ed.", 45),
                new Libro("M004", "Cien años", "Ficción", 1967, "García Márquez", 432),
                new Revista("M005", "Time Magazine", "Actualidad", 2024, "Time Inc.", 12),
                new Libro("M006", "Ficciones", "Ficción", 1944, "Borges, J.L.", 186)
            };

            foreach (var material in registros)
            {
                Console.WriteLine(material.ObtenerFicha());
            }
            Console.WriteLine();

            // ==========================================================
            Console.WriteLine("--- Paso 2: Cargar registros de Préstamos ---");
            // ==========================================================
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
            Console.WriteLine("✔ 8 préstamos cargados exitosamente.\n");

            // ==========================================================
            Console.WriteLine("--- Paso 3: Agregar un nuevo registro ---");
            // ==========================================================
            var donQuijote = new Libro("M007", "Don Quijote", "Clásico", 1605, "Cervantes, M.", 863);
            registros.Add(donQuijote);
            Console.WriteLine("✔ Don Quijote agregado exitosamente.");
            Console.WriteLine(donQuijote.ObtenerFicha());
            Console.WriteLine();

            // ==========================================================
            Console.WriteLine("--- Paso 4: Eliminar un registro ---");
            // ==========================================================
            var natGeo = registros.FirstOrDefault(m => m.Nombre == "National Geo");
            if (natGeo != null)
            {
                registros.Remove(natGeo);
                Console.WriteLine("✔ National Geo eliminado del sistema.");
            }

            var cienciaHoy = registros.FirstOrDefault(m => m.Nombre == "Ciencia Hoy");
            if (cienciaHoy == null)
            {
                Console.WriteLine("✘ No se encontró ningún registro con el nombre Ciencia Hoy.");
            }
            Console.WriteLine();

            // ==========================================================
            Console.WriteLine("--- Paso 5: Recorrido polimórfico ---");
            // ==========================================================
            // POLIMORFISMO: la lista es de tipo Material, pero en tiempo de ejecución
            // .NET invoca el ObtenerFicha() real de cada objeto (Libro o Revista).
            foreach (var material in registros)
            {
                Console.WriteLine(material.ObtenerFicha());

                // Pattern matching
                if (material is Libro libro)
                {
                    libro.AccionPropia();
                }
            }
            Console.WriteLine();

            // ==========================================================
            Console.WriteLine("--- Paso 6: Usar IPrestable ---");
            // ==========================================================
            var elAleph = registros.FirstOrDefault(m => m.Nombre == "El Aleph");
            if (elAleph is IPrestable prestableAleph)
            {
                prestableAleph.Prestar("prueba");
                Console.WriteLine("✔ Prestar aplicado a El Aleph.");

                prestableAleph.Devolver();
                Console.WriteLine("✔ Devolver ejecutado para El Aleph.");

                Console.WriteLine($"Estado de El Aleph: {prestableAleph.ObtenerEstado()}");
            }
            Console.WriteLine();


            Console.WriteLine("========== PARTE C: CONSULTAS LINQ ==========\n");

            // ==========================================================
            Console.WriteLine("--- Consulta 1: Materiales ordenados de mayor a menor por año ---");
            // ==========================================================
            var materialesOrdenados = registros.OrderByDescending(m => m.Anio);
            foreach (var m in materialesOrdenados)
            {
                Console.WriteLine($"{m.Nombre} — {m.Anio}");
            }
            Console.WriteLine();

            // ==========================================================
            Console.WriteLine("--- Consulta 2: Préstamos del Socio: Ana López en abril de 2026 ---");
            // ==========================================================
            var prestamosAna = registros2.Where(p =>
                p.NombreSocio == "Socio: Ana López" &&
                p.Fecha.Month == 4 &&
                p.Fecha.Year == 2026);

            foreach (var p in prestamosAna)
            {
                Console.WriteLine($"{p.Motivo} | ID: {p.IdPrestamo} | Importe: ${p.Multa}");
            }
            Console.WriteLine();

            // ==========================================================
            Console.WriteLine("--- Consulta 3: Total de multas por material ---");
            // ==========================================================
            var multasPorMaterial = registros2
                .GroupBy(p => p.IdMaterial)
                .Select(grupo => new
                {
                    IdMaterial = grupo.Key,
                    SumaMultas = grupo.Sum(p => p.Multa)
                })
                // Cruzamos con la lista de registros para obtener el Nombre
                .Join(registros,
                      multa => multa.IdMaterial,
                      mat => mat.IdMaterial,
                      (multa, mat) => new { mat.Nombre, multa.SumaMultas })
                .OrderByDescending(x => x.SumaMultas);

            foreach (var item in multasPorMaterial)
            {
                Console.WriteLine($"{item.Nombre}: ${item.SumaMultas}");
            }
            Console.WriteLine();

            // ==========================================================
            Console.WriteLine("--- Consulta 4: Estadísticas generales ---");
            // ==========================================================
            int totalMateriales = registros.Count;
            int cantidadLibros = registros.Count(m => m is Libro);
            int cantidadRevistas = registros.Count(m => m is Revista);

            // Verificación para evitar errores si no hay registros o multas
            decimal multaPromedio = registros2.Any() ? registros2.Average(p => p.Multa) : 0;
            decimal prestamoMayorMulta = registros2.Any() ? registros2.Max(p => p.Multa) : 0;

            Console.WriteLine($"Total de materiales registrados: {totalMateriales}");
            Console.WriteLine($"Cantidad de libros: {cantidadLibros}");
            Console.WriteLine($"Cantidad de revistas: {cantidadRevistas}");
            Console.WriteLine($"Multa promedio: {multaPromedio:F2}");
            Console.WriteLine($"Préstamo con mayor multa: {prestamoMayorMulta}");

            Console.ReadLine(); // Para que la consola no se cierre al instante al terminar
        }
    }
}