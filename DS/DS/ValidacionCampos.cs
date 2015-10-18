using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DS
{

    public enum TipoCampos
    {
        Texto = 0,
        Numero = 1
    }

    public struct ValidacionObjetos
    {
        public object Objeto { get; set; }
        public TipoCampos Tipo { get; set; }
        public string Mensaje { get; set; }

    }

    public class ValidacionCampos
    {

        List<ValidacionObjetos> objetosValidar = new List<ValidacionObjetos>();


        public void agregarValidacion(object objeto, TipoCampos tipo, string mensaje)
        {

            if (objetosValidar == null)
                objetosValidar = new List<ValidacionObjetos>();

            objetosValidar.Add(new ValidacionObjetos { Objeto = objeto, Tipo = tipo, Mensaje = mensaje });


        }

        public bool formValido(ErrorProvider errorProvider)
        {

            bool validado = true;

            foreach (var objeto in objetosValidar)
            {
                switch (objeto.Tipo)
                {
                    case TipoCampos.Texto:
                        if (((TextBox)objeto.Objeto).Text == string.Empty)
                        {
                            errorProvider.SetError((Control)objeto.Objeto, objeto.Mensaje == string.Empty ? "Debe ingresar el valor solicidado" : objeto.Mensaje);
                            validado = false;
                        }

                        break;
                    case TipoCampos.Numero:
                        break;
                    default:
                        break;
                }
            }


            return validado;

        }



    }
}
