namespace Numerosaleatorio
{
    public partial class frmEmpleados : Form
    {
        private Random random = new Random();

        private string[] nombres = { "Carlos ", "Hector", "Martin", "Erick", "Luis" };

        private char[] grupos = { '1', '2', '3', '4', '5' };

        public class Empleado
        {
            private int _intNumero;
            private string _strNombre;
            private DateTime _dtmFechaNacimiento;
            private string _strSexo;
            private char _chrGrupo;
            private double _dblSueldo;
            private bool _blnSeguroMedico;

            public Empleado()
            {
                _intNumero = 0;
                _strNombre = string.Empty;
                _dtmFechaNacimiento = DateTime.Now;
                _strSexo = string.Empty;
                _chrGrupo = ' ';
                _dblSueldo = 0.0;
                _blnSeguroMedico = false;
            }

            public Empleado(int numero, string nombre, DateTime fechaNacimiento,
                           string sexo, char grupo, double sueldo, bool seguroMedico)
            {
                _intNumero = numero;
                _strNombre = nombre;
                _dtmFechaNacimiento = fechaNacimiento;
                _strSexo = sexo;
                _chrGrupo = grupo;
                _dblSueldo = sueldo;
                _blnSeguroMedico = seguroMedico;
            }

            public int Numero
            {
                get { return _intNumero; }
                set { _intNumero = value; }
            }

            public string Nombre
            {
                get { return _strNombre; }
                set { _strNombre = value; }
            }

            public DateTime FechaNacimiento
            {
                get { return _dtmFechaNacimiento; }
                set { _dtmFechaNacimiento = value; }
            }

            public string Sexo
            {
                get { return _strSexo; }
                set { _strSexo = value; }
            }

            public char Grupo
            {
                get { return _chrGrupo; }
                set { _chrGrupo = value; }
            }

            public double Sueldo
            {
                get { return _dblSueldo; }
                set { _dblSueldo = value; }
            }

            public bool SeguroMedico
            {
                get { return _blnSeguroMedico; }
                set { _blnSeguroMedico = value; }
            }

            public override string ToString()
            {
                return $"Empleado #{Numero}: {Nombre}, Nacido: {FechaNacimiento.ToShortDateString()}, " +
                       $"Sexo: {Sexo}, Grupo: {Grupo}, Sueldo: ${Sueldo:F2}, " +
                       $"Seguro Médico: {(SeguroMedico ? "Sí" : "No")}";
            }
        }

        public frmEmpleados()
        {
            InitializeComponent();
            InicializarGrupos();
        }

        private void InicializarGrupos()
        {
            cbgrupo.Items.Clear();
            foreach (char grupo in grupos)
            {
                cbgrupo.Items.Add(grupo);
            }
        }

        private void btnaleatorios_Click(object sender, EventArgs e)
        {
            GenerarCelularAleatorio();
            GenerarNombreAleatorio();
            GenerarFechaNacimientoAleatoria();
            GenerarSexoAleatorio();
            GenerarGrupoAleatorio();
            GenerarSueldoAleatorio();
            GenerarSeguroMedicoAleatorio();
        }
        private void GenerarNombreAleatorio()
        {
            int indiceAleatorio = random.Next(nombres.Length);
            string nombreSeleccionado = nombres[indiceAleatorio];
            tbnombre.Text = nombreSeleccionado; 
        }
        public Empleado CrearEmpleadoAleatorio()
        {
            int numero = int.Parse(tbnumero.Text);
            string nombre = tbnombre.Text;  
            DateTime fechaNacimiento = dtnacimiento.Value;
            string sexo = rbmasculino.Checked ? "Masculino" : "Femenino";
            char grupo = grupos[cbgrupo.SelectedIndex >= 0 ? cbgrupo.SelectedIndex : 0];
           
            double sueldo = double.Parse(tbsueldo.Text);
            bool seguroMedico = cbseguro.Checked;
            

            return new Empleado(numero, nombre, fechaNacimiento, sexo, grupo, sueldo, seguroMedico);
        }

        private void GenerarCelularAleatorio()
        {
            int ultimosSeis = random.Next(100000, 999999);
            string celular = "7752" + ultimosSeis.ToString();
            tbnumero.Text = celular;
        }


        private void GenerarFechaNacimientoAleatoria()
        {
            DateTime fechaMinima = new DateTime(1970, 1, 1);
            DateTime fechaMaxima = new DateTime(2000, 12, 31);

            int rango = (fechaMaxima - fechaMinima).Days;
            DateTime fechaAleatoria = fechaMinima.AddDays(random.Next(rango));

            dtnacimiento.Value = fechaAleatoria;
        }

        private void GenerarSexoAleatorio()
        {
            bool esMasculino = random.Next(2) == 0;

            rbmasculino.Checked = esMasculino;
            rbfemenino.Checked = !esMasculino;
        }

        private void GenerarGrupoAleatorio()
        {
            int indiceAleatorio = random.Next(grupos.Length);
            cbgrupo.SelectedIndex =  indiceAleatorio;

        }

        private void GenerarSueldoAleatorio()
        {
            double sueldoAleatorio = random.Next(10000, 20001);
            tbsueldo.Text = sueldoAleatorio.ToString("F2");
        }

        private void GenerarSeguroMedicoAleatorio()
        {
            bool tieneSeguro = random.Next(2) == 0;
            cbseguro.Checked = tieneSeguro;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void dtnacimiento_ValueChanged(object sender, EventArgs e)
        {
        }

        private void rbmasculino_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbfemenino_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cbgrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tbsueldo_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbseguro_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}