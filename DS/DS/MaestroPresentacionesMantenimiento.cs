#region Using

using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using System.Collections.Generic;


using Gizmox.WebGUI;
using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Forms.Skins;
using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms.Design;
using Gizmox.WebGUI.Common.Interfaces;
using Gizmox.WebGUI.Common.Extensibility;


#endregion

namespace DS
{
    /// <summary>
    /// Summary description for MaestroPresentacionesMantenimiento
    /// </summary>
    [ToolboxItem(true)]
    [ToolboxBitmapAttribute(typeof(MaestroPresentacionesMantenimiento), "DS.MaestroPresentacionesMantenimiento.bmp")]
    [DesignTimeController("Gizmox.WebGUI.Forms.Design.PlaceHolderController, Gizmox.WebGUI.Forms.Design, Version=4.5.15701.0 , Culture=neutral, PublicKeyToken=dd2a1fd4d120c769")]
    [ClientController("Gizmox.WebGUI.Client.Controllers.PlaceHolderController, Gizmox.WebGUI.Client, Version=4.5.15701.0 , Culture=neutral, PublicKeyToken=0fb8f99bd6cd7e23")]
    [Serializable()]
    [MetadataTag("DS.MaestroPresentacionesMantenimiento")]
    [Skin(typeof(MaestroPresentacionesMantenimientoSkin))]
    public partial class MaestroPresentacionesMantenimiento : Control
    {
        public MaestroPresentacionesMantenimiento()
        {

            InitializeComponent();
        }


        protected override void RenderAttributes(IContext context, IAttributeWriter writer)
        {
            base.RenderAttributes(context, writer);

            writer.WriteAttributeString(WGAttributes.Text, Text);
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                if (base.Text != value)
                {
                    base.Text = value;
                    this.Update();
                }
            }
        }
    }
}