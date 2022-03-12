using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDataAccess
{
    public class Registro
    {
        private static List<Pessoa> pessoas;
        public static bool SaveRegister(Pessoa pessoa, Endereco endereco, Contato contato)
        {
            try
            {
                //Instanciando conexão com o Banco de Dados
                CadastroDataClassesDataContext oDB = new CadastroDataClassesDataContext();
                //Inserindo dados
                oDB.Pessoas.InsertOnSubmit(pessoa);
                //Submetendo inserção
                oDB.SubmitChanges();
                //Pegando a pessoa a cadastrada
                pessoas = GetAllPessoa();
                int _id = pessoas.Last().Id;
                //Adicionar Id da Pessoa no Endereço e Contato
                endereco.IdPessoa = _id;
                contato.IdPessoa = _id;
                //Adicionar Endereço e contato
                oDB.Enderecos.InsertOnSubmit(endereco);
                oDB.Contatos.InsertOnSubmit(contato);
                oDB.SubmitChanges();
                
                //Fechado Conexão
                oDB.Dispose();
                return true;
            }catch (Exception e)
            {
                return false;
            }
        }

        public static List<Pessoa> GetAllPessoa()
        {
            CadastroDataClassesDataContext oDB = new CadastroDataClassesDataContext();
            List<Pessoa> oPessoas = (from Selecao in oDB.Pessoas select Selecao).ToList<Pessoa>();
            oDB.Dispose();
            return oPessoas;
        }

        public static Pessoa GetPessoa(int id)
        {
            CadastroDataClassesDataContext oDB = new CadastroDataClassesDataContext();
            Pessoa pessoa = (from Selecao in oDB.Pessoas where Selecao.Id == id select Selecao).SingleOrDefault();
            oDB.Dispose();
            return pessoa;
        }

        public static List<Endereco> GetAllEndereco()
        {
            CadastroDataClassesDataContext oDB = new CadastroDataClassesDataContext();
            List<Endereco> enderecos = (from Selecao in oDB.Enderecos select Selecao).ToList<Endereco>();
            oDB.Dispose();
            return enderecos;
        }

        public static Endereco GetEndereco(int id)
        {
            CadastroDataClassesDataContext oDB = new CadastroDataClassesDataContext();
            Endereco endereco = (from Selecao in oDB.Enderecos where Selecao.IdPessoa == id select Selecao).SingleOrDefault();
            return endereco;
        }

        public static List<Contato> GetAllContato()
        {
            CadastroDataClassesDataContext oDB = new CadastroDataClassesDataContext();
            List<Contato> contatos = (from Selecao in oDB.Contatos select Selecao).ToList<Contato>();
            oDB.Dispose();
            return contatos;
        }

        public static Contato GetContato(int id)
        {
            CadastroDataClassesDataContext oDB = new CadastroDataClassesDataContext();
            Contato contato = (from Selecao in oDB.Contatos where Selecao.IdPessoa == id select Selecao).SingleOrDefault();
            return contato;
        }

        public static void Delete(int id)
        {
            CadastroDataClassesDataContext oDB = new CadastroDataClassesDataContext();
            Endereco endereco = (from Selecao in oDB.Enderecos where Selecao.IdPessoa == id select Selecao).SingleOrDefault();
            Contato contato = (from Selecao in oDB.Contatos where Selecao.IdPessoa == id select Selecao).SingleOrDefault();
            oDB.Enderecos.DeleteOnSubmit(endereco);
            oDB.Contatos.DeleteOnSubmit(contato);
            oDB.SubmitChanges();
            Pessoa pessoa = (from Selecao in oDB.Pessoas where Selecao.Id == id select Selecao).SingleOrDefault();
            oDB.Pessoas.DeleteOnSubmit(pessoa);
            oDB.SubmitChanges();
            oDB.Dispose();
        }

        public static bool EditRegister(Pessoa pessoa, Endereco endereco, Contato contato)
        {
            try
            {
                CadastroDataClassesDataContext oDB = new CadastroDataClassesDataContext();
                Pessoa oPessoa = (from Selecao in oDB.Pessoas where Selecao.Id == pessoa.Id select Selecao).SingleOrDefault();
                Endereco oEndereco = (from Selecao in oDB.Enderecos where Selecao.IdPessoa == pessoa.Id select Selecao).SingleOrDefault();
                Contato oContato = (from Selecao in oDB.Contatos where Selecao.IdPessoa == pessoa.Id select Selecao).SingleOrDefault();

                oPessoa.Nome = pessoa.Nome;
                oPessoa.RG = pessoa.RG;
                oPessoa.CPF = pessoa.CPF;
                oPessoa.Religiao = pessoa.Religiao;
                oPessoa.Sexo = pessoa.Sexo;
                oPessoa.Nascimento = pessoa.Nascimento;

                oEndereco.Rua = endereco.Rua;
                oEndereco.Bairro = endereco.Bairro;
                oEndereco.Numero = endereco.Numero;
                oEndereco.Cidade = endereco.Cidade;
                oEndereco.UF = endereco.UF;

                oContato.Tipo = contato.Tipo;
                oContato.Numero = contato.Numero;

                oDB.SubmitChanges();
                oDB.Dispose();



                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }
    }
}
