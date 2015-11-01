using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace DS
{
    public class GeneraXML
    {
        void generarXMLArticulo()
        {
            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);

            XmlNode articulosNodo = doc.CreateElement("ARTICULOS");
            doc.AppendChild(articulosNodo);

            XmlNode articuloNodo = doc.CreateElement("ARTICULO");
            articulosNodo.AppendChild(articuloNodo);


            XmlNode nodo = doc.CreateElement("CODIGO_ARTICULO");
            nodo.AppendChild(doc.CreateTextNode(""));
            articuloNodo.AppendChild(nodo);


            nodo = doc.CreateElement("NOMBRE_ARTICULO");
            nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
            articuloNodo.AppendChild(nodo);


            nodo = doc.CreateElement("NOMBRE_CORTO");
            nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
            articuloNodo.AppendChild(nodo);

            nodo = doc.CreateElement("DESCRIPCION");
            nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
            articuloNodo.AppendChild(nodo);


            nodo = doc.CreateElement("CODIGO_CATEGORIA");
            nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
            articuloNodo.AppendChild(nodo);


            nodo = doc.CreateElement("CLASIFICACION1");
            nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
            articuloNodo.AppendChild(nodo);


            nodo = doc.CreateElement("CLASIFICACION2");
            nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
            articuloNodo.AppendChild(nodo);


            nodo = doc.CreateElement("CLASIFICACION3");
            nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
            articuloNodo.AppendChild(nodo);

            nodo = doc.CreateElement("CLASIFICACION4");
            nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
            articuloNodo.AppendChild(nodo);


            nodo = doc.CreateElement("PRESENTACION_BASE");
            nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
            articuloNodo.AppendChild(nodo);


            nodo = doc.CreateElement("PERMITE_VENTA");
            nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
            articuloNodo.AppendChild(nodo);

            nodo = doc.CreateElement("PERMITE_COMPRA");
            nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
            articuloNodo.AppendChild(nodo);


            nodo = doc.CreateElement("CAMBIAR_DESCRIPCION");
            nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
            articuloNodo.AppendChild(nodo);


            nodo = doc.CreateElement("CONSULTAR_PRECIO");
            nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
            articuloNodo.AppendChild(nodo);


            nodo = doc.CreateElement("PAGA_IMPUESTO");
            nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
            articuloNodo.AppendChild(nodo);

            nodo = doc.CreateElement("PRECIO_VENTA");
            nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
            articuloNodo.AppendChild(nodo);

            nodo = doc.CreateElement("MANEJA_INVENTARIO");
            nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
            articuloNodo.AppendChild(nodo);

            nodo = doc.CreateElement("INVENTARIO_MINIMO");
            nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
            articuloNodo.AppendChild(nodo);

            nodo = doc.CreateElement("INVENTARIO_MAXIMO");
            nodo.AppendChild(doc.CreateTextNode("ESTOS ES UNA PRUEBA"));
            articuloNodo.AppendChild(nodo);



            XmlNode presentacionesNodo = doc.CreateElement("PRESENTACIONES");
            articuloNodo.AppendChild(presentacionesNodo);


            XmlNode presentacionesSubNodo = doc.CreateElement("PRESENTACION");
            presentacionesNodo.AppendChild(presentacionesSubNodo);


            XmlNode presentacionNodo = doc.CreateElement("CODIGO_PRESENTACION");
            presentacionNodo.AppendChild(doc.CreateTextNode("0001"));
            presentacionesSubNodo.AppendChild(presentacionNodo);

            presentacionNodo = doc.CreateElement("FACTOR");
            presentacionNodo.AppendChild(doc.CreateTextNode("1"));
            presentacionesSubNodo.AppendChild(presentacionNodo);

            presentacionesSubNodo = doc.CreateElement("PRESENTACION");
            presentacionesNodo.AppendChild(presentacionesSubNodo);


            presentacionNodo = doc.CreateElement("CODIGO_PRESENTACION");
            presentacionNodo.AppendChild(doc.CreateTextNode("0001"));
            presentacionesSubNodo.AppendChild(presentacionNodo);

            presentacionNodo = doc.CreateElement("FACTOR");
            presentacionNodo.AppendChild(doc.CreateTextNode("1"));
            presentacionesSubNodo.AppendChild(presentacionNodo);


            string xmlDoc = doc.InnerXml.ToString();

            

        }
    }
}
