using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroDataAccess;
using System.Text.RegularExpressions;

namespace CADASTROPESSOA
{
    public partial class telaShow : Form
    {
        public telaShow()
        {
            InitializeComponent();
            showView(ucView, false, false);
        }

        private void showView(UserControl screen, bool view, bool edit)
        {
            tstAdicionar.Enabled = false;
            tstEditar.Enabled = false;
            tstExcluir.Enabled = false;
            tstVisualizar.Enabled = false;
            tstSalvar.Enabled = false;
            tstCancelar.Enabled = false;
            tstEfetuarEdicao.Enabled = false;
            ucAcoes.tpContato.Enabled = true;
            ucAcoes.tpPessoa.Enabled = true;
            ucAcoes.tpEndereco.Enabled = true;
            ucAcoes.lvlErrors.Text = "";
            if (screen == ucView)
            {
                ucAcoes.Visible = false;
                ucView.Visible = true;

                tstAdicionar.Enabled = true;

                ucView.dgvTelaPrincipal.DataSource = Registro.GetAllPessoa();
                if (Registro.GetAllPessoa().Count != 0)
                {
                    tstEditar.Enabled = true;
                    tstExcluir.Enabled = true;
                    tstVisualizar.Enabled = true;
                }

            }
            else
            {
                ucAcoes.Visible = true;
                ucView.Visible = false;
                if (view)
                {
                    tstCancelar.Enabled = true;
                    ucAcoes.tpContato.Enabled = false;
                    ucAcoes.tpPessoa.Enabled = false;
                    ucAcoes.tpEndereco.Enabled = false;
                   
                }else
                {
                    if (edit)
                    {
                        tstEfetuarEdicao.Enabled = true;
                        tstCancelar.Enabled = true;
                    }else
                    {
                        tstSalvar.Enabled = true;
                        tstCancelar.Enabled = true;
                    }
                }    
            }    
        }

        private void tstAdicionar_Click(object sender, EventArgs e)
        {
            showView(ucAcoes, false, false);
        }

        private void tstCancelar_Click(object sender, EventArgs e)
        {
            showView(ucView, false, false);
            limparAcoes();
        }

        private void tstSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Nome = ucAcoes.txtNome.Text.ToUpper();
                pessoa.Religiao = ucAcoes.cbReligiao.Text.ToUpper();
                pessoa.RG = ucAcoes.mtxtRG.Text.ToUpper();
                pessoa.CPF = ucAcoes.mtxtCPF.Text.ToUpper();
                pessoa.Nascimento = DateTime.Parse(ucAcoes.mTxtNascimento.Text);
                pessoa.Sexo = ucAcoes.rbMasculino.Checked ? "M" : "F";
                pessoa.Data_Criacao = DateTime.UtcNow;
                Endereco endereco = new Endereco();
                endereco.Rua = ucAcoes.txtRua.Text.ToUpper();
                endereco.Numero = int.Parse(ucAcoes.nudNumero.Text);
                endereco.Bairro = ucAcoes.txtBairro.Text.ToUpper();
                endereco.Cidade = ucAcoes.txtCidade.Text.ToUpper();
                endereco.UF = ucAcoes.cbUf.Text.ToUpper();
                Contato contato = new Contato();
                contato.Tipo = ucAcoes.cbTipo.Text.ToUpper();
                contato.Numero = ucAcoes.mtbNumero.Text;
                Validacao validar = new Validacao();
                validar.ValidarPessoa(pessoa, false);
                validar.ValidarEndereco(endereco);
                validar.ValidarContato(contato);


                if (!Registro.SaveRegister(pessoa, endereco, contato))
                {
                    throw new Exception("Error ao se conectar ao Banco de Dados");
                }
                showView(ucView, false, false);
            }catch (Exception ex)
            {
                ucAcoes.lvlErrors.Text = ex.Message;
            }       
        }

        private void tstExcluir_Click(object sender, EventArgs e)
        {
            if (ucView.dgvTelaPrincipal.SelectedRows.Count != 0)
            {
                int id = (int)ucView.dgvTelaPrincipal.SelectedRows[0].Cells[0].Value;
                Registro.Delete(id);
                showView(ucView, false, false);
            }
        }

        private void tstVisualizar_Click(object sender, EventArgs e)
        {
            int id = (int)ucView.dgvTelaPrincipal.SelectedRows[0].Cells[0].Value;
            Pessoa pessoa = Registro.GetPessoa(id);
            Endereco endereco = Registro.GetEndereco(id);
            Contato contato = Registro.GetContato(id);
            PreencherAcoes(pessoa, endereco, contato);
            
            showView(ucAcoes, true, false);
        }

        public void PreencherAcoes(Pessoa pessoa, Endereco endereco, Contato contato)
        {
            ucAcoes.txtNome.Text = pessoa.Nome.Trim();
            ucAcoes.cbReligiao.Text = pessoa.Religiao.Trim();
            ucAcoes.mtxtRG.Text = pessoa.RG.Trim();
            ucAcoes.mtxtCPF.Text = pessoa.CPF.Trim();
            string day;
            string month;
            if (pessoa.Nascimento.Day < 10)
            {
                day = $"0{pessoa.Nascimento.Day}";
            }else
            {
                day = $"{pessoa.Nascimento.Day}";
            }
            if (pessoa.Nascimento.Month < 10)
            {
                month = $"0{pessoa.Nascimento.Month}";
            }else
            {
                month = $"{pessoa.Nascimento.Month}";
            }
            string nascimento = $"{day}/{month}/{pessoa.Nascimento.Year}";
            ucAcoes.mTxtNascimento.Text = nascimento;
            if (pessoa.Sexo.Trim() == "M")
            {
                ucAcoes.rbMasculino.Checked = true;
            }
            else
            {
                ucAcoes.rbFeminino.Checked = true;
            }
            ucAcoes.txtRua.Text = endereco.Rua.Trim();
            ucAcoes.nudNumero.Text = $"{endereco.Numero}";
            ucAcoes.txtBairro.Text = endereco.Bairro.Trim();
            ucAcoes.txtCidade.Text = endereco.Cidade.Trim();
            ucAcoes.cbUf.Text = endereco.UF.Trim();
            ucAcoes.cbTipo.Text = contato.Tipo.Trim();
            ucAcoes.mtbNumero.Text = contato.Numero.Trim();
            ucAcoes.lblId.Text = $"{pessoa.Id}";
        }

        private void limparAcoes()
        {
            ucAcoes.txtNome.Text = "";
            ucAcoes.cbReligiao.Text = "";
            ucAcoes.mtxtRG.Text = "";
            ucAcoes.mtxtCPF.Text = "";
            ucAcoes.mTxtNascimento.Text = "";
            ucAcoes.rbMasculino.Checked = true;
            ucAcoes.txtRua.Text = "";
            ucAcoes.nudNumero.Text = "";
            ucAcoes.txtBairro.Text = "";
            ucAcoes.txtCidade.Text = "";
            ucAcoes.cbUf.Text = "";
            ucAcoes.cbTipo.Text = "";
            ucAcoes.mtbNumero.Text = "";
        }

        private void tstEditar_Click(object sender, EventArgs e)
        {
            int id = (int)ucView.dgvTelaPrincipal.SelectedRows[0].Cells[0].Value;
            Pessoa pessoa = Registro.GetPessoa(id);
            Endereco endereco = Registro.GetEndereco(id);
            Contato contato = Registro.GetContato(id);
            PreencherAcoes(pessoa, endereco, contato);

            showView(ucAcoes, false, true);
        }

        private void tstEfetuarEdicao_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Id = int.Parse(ucAcoes.lblId.Text);
                pessoa.Nome = ucAcoes.txtNome.Text.ToUpper();
                pessoa.Religiao = ucAcoes.cbReligiao.Text.ToUpper();
                pessoa.RG = ucAcoes.mtxtRG.Text.ToUpper();
                pessoa.CPF = ucAcoes.mtxtCPF.Text.ToUpper();
                pessoa.Nascimento = DateTime.Parse(ucAcoes.mTxtNascimento.Text);
                pessoa.Sexo = ucAcoes.rbMasculino.Checked ? "M" : "F";
                pessoa.Data_Criacao = DateTime.UtcNow;
                Endereco endereco = new Endereco();
                endereco.Rua = ucAcoes.txtRua.Text.ToUpper();
                endereco.Numero = int.Parse(ucAcoes.nudNumero.Text);
                endereco.Bairro = ucAcoes.txtBairro.Text.ToUpper();
                endereco.Cidade = ucAcoes.txtCidade.Text.ToUpper();
                endereco.UF = ucAcoes.cbUf.Text.ToUpper();
                Contato contato = new Contato();
                contato.Tipo = ucAcoes.cbTipo.Text.ToUpper();
                contato.Numero = ucAcoes.mtbNumero.Text;
                Validacao validar = new Validacao();
                validar.ValidarPessoa(pessoa, true);
                validar.ValidarEndereco(endereco);
                validar.ValidarContato(contato);


                if (!Registro.EditRegister(pessoa, endereco, contato))
                {
                    throw new Exception("Error ao se conectar ao Banco de Dados");
                }
                showView(ucView, false, false);
            }
            catch (Exception ex)
            {
                ucAcoes.lvlErrors.Text = ex.Message;
            }
        }
    }

   
}
