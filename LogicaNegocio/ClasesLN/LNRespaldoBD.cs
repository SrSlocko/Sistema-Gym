using System;
using System.Windows.Forms;
using CapaDatos.Conexion;
namespace LogicaNegocio.ClasesLN
{
    public class LNRespaldoBD
    {
        public string Ruta; public LNRespaldoBD() { } public LNRespaldoBD(string R) { Ruta = R; } public void RespaldarBase() { ConexionBDDataContext BD = null; try { using (BD = new ConexionBDDataContext()) { BD.sp_RespaldoBD(Ruta); BD.SubmitChanges(); MessageBox.Show("Base de Datos Respaldada"); } } catch (Exception mes) { MessageBox.Show(mes.Message); } finally { BD = null; } }
    }
}
