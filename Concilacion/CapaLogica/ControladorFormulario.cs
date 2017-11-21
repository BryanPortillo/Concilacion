using Concilacion.CapaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concilacion.CapaLogica
{
    class ControladorFormulario
    {
        /**
         * Metodo utilizado para el llenado de datos de cualquier DataGrid
         * 
         * **/
        public void LLenarDataGrid(DataGridView dtLLenar) {
            Conector c = new Conector();
            c.OpenConnection();
            DataTable data  = c.informacion("Select * From vista_conciliacion");
            dtLLenar.DataSource = data;
            c.CloseConnection();
        }


    }
}
