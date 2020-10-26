using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimplexCalculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void CriarLinhaDaFuncao(Point posicaoInicialVarDec, TextBox[] textBoxDecisao)
        {
            for (int i = 0; i < textBoxDecisao.Length; i++)
            {
                var txt = new TextBox();
                textBoxDecisao[i] = txt;
                txt.Name = $"x{i + 1}";
                txt.Size = new Size(60, 23);
                txt.Location = new Point(posicaoInicialVarDec.X, 142);
                txt.Visible = true;
                this.Controls.Add(txt);

                var label = new Label();
                label.Size = new Size(40, 23);
                label.Text = $"X{i + 1}";
                label.Location = new Point(txt.Location.X + 70, 142);
                this.Controls.Add(label);

                if (i != textBoxDecisao.Length - 1)
                {
                    var plus = new Label();
                    plus.Size = new Size(20, 23);
                    plus.Text = "+";
                    plus.Location = new Point(label.Location.X + 50, 142);
                    this.Controls.Add(plus);
                    posicaoInicialVarDec = new Point(plus.Location.X + 50, 142);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var textBoxDecisao = new TextBox[Global.QtdeVariaveisDecisao];
            var textBoxRestricoes = new TextBox[Global.QtdeRestricoes * Global.QtdeVariaveisDecisao];
            var textBoxResultadoRestricoes = new TextBox[Global.QtdeRestricoes];
            var comboIneq = new ComboBox[Global.QtdeRestricoes];
            var posicaoInicialVarDec = new Point(270, 142);
            var posicaoInicialRest = new Point(270, 260);

            CriarLinhaDaFuncao(posicaoInicialVarDec, textBoxDecisao);

            for (int i = 0; i < Global.QtdeRestricoes; i++)
            {
                //TODO: Corrigir criação da linha de restrições
                for (int y = 0; y < Global.QtdeVariaveisDecisao; y++)
                {
                    var index = y + 1;
                    var txt = new TextBox();
                    textBoxRestricoes[y] = txt;
                    txt.Size = new Size(60, 23);
                    txt.Name = $"R{index}X{index}";
                    txt.Location = posicaoInicialRest;
                    this.Controls.Add(txt);

                    var label = new Label();
                    label.Size = new Size(40, 23);
                    label.Text = $"X{i + 1}";
                    label.Location = new Point(txt.Location.X + 70, posicaoInicialRest.Y);
                    this.Controls.Add(label);

                    if (i != textBoxDecisao.Length - 1)
                    {
                        var plus = new Label();
                        plus.Size = new Size(20, 23);
                        plus.Text = "+";
                        plus.Location = new Point(label.Location.X + 50, posicaoInicialRest.Y);
                        this.Controls.Add(plus);
                        posicaoInicialRest = new Point(plus.Location.X + 50, posicaoInicialRest.Y);
                    }
                    else
                    {
                        var combo = new ComboBox();
                        combo.Size = new Size(20, 23);
                        combo.Items.AddRange(new[] { ">=", "<=", "=" });
                        combo.Name = $"operador{index}";
                        combo.Visible = true;
                        combo.Location = new Point(label.Location.X + 50, posicaoInicialRest.Y);

                        var txtResultadoRestricao = new TextBox();
                        textBoxResultadoRestricoes[i] = txtResultadoRestricao;
                        txtResultadoRestricao.Size = new Size(60, 23);
                        txtResultadoRestricao.Name = $"ResultadoRestricao{index}";
                        txtResultadoRestricao.Location = new Point(combo.Location.X + 50, posicaoInicialRest.Y);
                        
                    }
                }
                posicaoInicialRest = new Point(posicaoInicialRest.X, 300);

            }
        }
    }
}
