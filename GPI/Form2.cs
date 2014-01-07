using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GPI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.Add("Gerente de operaciones");
            comboBox1.Items.Add("Gerente de tecnología");
            comboBox1.Items.Add("Gerente de marketing");
            comboBox1.Items.Add("Gerente de RRHH");
            comboBox1.Items.Add("Gerente de finanzas");
            comboBox1.Items.Add("Gerente de proyectos");
            comboBox1.Items.Add("Jefe de proyectos");
            comboBox1.Items.Add("Jefe de sucursal");
            comboBox1.Items.Add("Encargado de adquisiciones");
            comboBox1.Items.Add("Jefe de prevención de riesgos");
            comboBox1.Items.Add("Jefe de personal");
            comboBox1.Items.Add("Jefe de ventas");
            comboBox1.Items.Add("Programador");
            comboBox1.Items.Add("Vendedor");
            comboBox1.Items.Add("Testeador");
            comboBox1.Items.Add("Diseñador");
            comboBox1.Items.Add("Contador");
            comboBox1.Items.Add("Secretaria");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text.Contains("Gerente de operaciones"))
                textBox1.Text = "Habilidades: mandatario, futurista, competitivo, emprendedor. Competencias: Administración, procesos, ofimática, tecnología.";
            if(comboBox1.Text.Contains("Gerente de tecnología"))
                textBox1.Text = "Habilidades: mandatario, futurista, emprendedor. Competencias: Administración, procesos, ofimática, tecnología.";
            if(comboBox1.Text.Contains("Gerente de marketing"))
                textBox1.Text = "Habilidades: mandatario, futurista, emprendedor. Competencias: Administración, procesos, ofimática, tecnología, publicidad.";
            if(comboBox1.Text.Contains("Gerente de RRHH"))
                textBox1.Text = "Habilidades: mandatario, futurista, emprendedor. Competencias: Administración, procesos, ofimática, gestión de personal.";
            if(comboBox1.Text.Contains("Gerente de finanzas"))
                textBox1.Text = "Habilidades: mandatario, responsable, emprendedor. Competencias: Administración, procesos, ofimática, comercio internacional, contabilidad.";
            if(comboBox1.Text.Contains("Gerente de proyectos"))
                textBox1.Text = "Habilidades: mandatario, disciplinado, emprendedor. Competencias: Administración, procesos, ofimática, tecnología, gestión de proyectos.";
            if(comboBox1.Text.Contains("Jefe de proyectos"))
                textBox1.Text = "Habilidades: analítico, competitivo, emprendedor. Competencias: Gestión de proyectos, gestión de personal, tecnología.";
            if(comboBox1.Text.Contains("Jefe de sucursal"))
                textBox1.Text = "Habilidades: disciplinado, emprendedor, comunicador. Competencias: Ventas, administración, gestión de personal.";
            if(comboBox1.Text.Contains("Encargado de adquisiciones"))
                textBox1.Text = "Habilidades: futurista, comunicador, flexible. Competencias: Tecnología, comercio internacional, gestión de proyectos.";
            if(comboBox1.Text.Contains("Jefe de prevención de riesgos"))
                textBox1.Text = "Habilidades: comunicador, mandatario, disciplinado. Competencias: Prevención de riesgos, seguridad, gestión de personal.";
            if(comboBox1.Text.Contains("Jefe de personal"))
                textBox1.Text = "Habilidades: desarrollador, competitivo, mandatario. Competencias: Gestión de personal, administración.";
            if(comboBox1.Text.Contains("Jefe de ventas"))
                textBox1.Text = "Habilidades: desarrollador, emprendedor, mandatario. Competencias: Ventas, relaciones públicas, gestión de personal.";
            if(comboBox1.Text.Contains("Programador"))
                textBox1.Text = "Habilidades: responsable, disciplinado, armónico. Competencias: Programación, modelamiento de datos, ofimática.";
            if(comboBox1.Text.Contains("Vendedor"))
                textBox1.Text = "Habilidades: empático, competitivo, comunicador. Competencias: Relaciones públicas, ventas. ";
            if(comboBox1.Text.Contains("Testeador"))
                textBox1.Text = "Habilidades: armónico, flexible, futurista. Competencias: Testing, programación, ofimática.";
            if(comboBox1.Text.Contains("Diseñador"))
                textBox1.Text = "Habilidades: empático, futurista, responsable. Competencias: Diseño web, diseño gráfico.";
            if(comboBox1.Text.Contains("Contador"))
                textBox1.Text = "Habilidades: responsable, disciplinado, analítico. Competencias: Contabilidad, ofimática.";
            if(comboBox1.Text.Contains("Secretaria"))
                textBox1.Text = "Habilidades: armónico, flexible, empático. Competencias: Mecanografía, comunicaciones, ofimática.";
        }
    }
}
