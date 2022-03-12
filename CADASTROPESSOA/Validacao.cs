using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDataAccess;
using System.Text.RegularExpressions;

namespace CADASTROPESSOA
{
     class Validacao
    {
        private static List<Pessoa> pessoas;

        public Validacao()
        {
           pessoas = Registro.GetAllPessoa();
        }
        public void ValidarPessoa(Pessoa pessoa, bool edit)
        {
            ValidarNome(pessoa.Nome);
            if (edit)
            {
                ValidarCPF(pessoa.CPF, true);
                ValidarRG(pessoa.RG, true);
            }
            else
            {
                ValidarCPF(pessoa.CPF);
                ValidarRG(pessoa.RG);
            }
            ValidarReligiao(pessoa.Religiao);
        }

        public void ValidarEndereco(Endereco endereco)
        {
            ValidarRua(endereco.Rua);
            ValidarBairro(endereco.Bairro);
            ValidarCidade(endereco.Cidade);
            ValidarUf(endereco.UF);
        }

        public void ValidarContato(Contato contato)
        {
            ValidarTipo(contato.Tipo);
            ValidarNumero(contato.Numero);
        }
        private void ValidarNome(string nome)
        {
            if (nome.Length < 3 || Regex.IsMatch(nome, @"^[0-9]+$"))
            {
                throw new Exception("Informe um nome valido!");
            }
        }

        private void ValidarRG(string rg)
        {
            if (rg.Length < 13)
            {
                throw new Exception("Pessoa - Informe um RG válido!");
            }
            if (pessoas.Count(x => x.RG == rg) > 0)
            {
                throw new Exception("Pessoa - RG já cadastrado!");
            }
        }

        private void ValidarRG(string rg, bool edit)
        {
            if (rg.Length < 13)
            {
                throw new Exception("Pessoa - Informe um RG válido!");
            }
            if (pessoas.Count(x => x.RG == rg) > 0 && pessoas.Find(x => x.RG == rg).RG != rg)
            {
                throw new Exception("Pessoa - RG já cadastrado!");
            }
        }

        private void ValidarCPF(string cpf)
        {
            if (cpf.Length != 14)
            {
                throw new Exception("Pessoa - Informe um CPF Válido");
            }
            if (pessoas.Count(x => x.CPF == cpf) > 0)
            {
                throw new Exception("Pessoa - CPF já cadastrado!");
            }
        }

        private void ValidarCPF(string cpf, bool edit)
        {
            if (cpf.Length != 14)
            {
                throw new Exception("Pessoa - Informe um CPF Válido");
            }
            if (pessoas.Count(x => x.CPF == cpf) > 0 && pessoas.Find(x => x.CPF == cpf).CPF != cpf)
            {
                throw new Exception("Pessoa - CPF já cadastrado!");
            }
        }

        private void ValidarReligiao(string religiao)
        {
            if (religiao.Length < 6)
            {
                throw new Exception("Pessoa - Selecione uma religião!");
            }
        }

        private void ValidarRua(string rua)
        {
            if (rua.Length < 3)
            {
                throw new Exception("Endereço - Informe uma rua válida!");
            }
        }

        private void ValidarBairro(string bairro)
        {
            if (bairro.Length < 3)
            {
                throw new Exception("Endereço - Informe um bairro válido!");
            }
        }

        private void ValidarCidade(string cidade)
        {
            if (cidade.Length < 5)
            {
                throw new Exception("Endereço - Informe uma cidade válida!");
            }
        }

        private void ValidarUf(string uf)
        {
            if (uf.Length < 2)
            {
                throw new Exception("Endereço - Informe um estado válido!");
            }
        }

        private void ValidarTipo(string tipo)
        {
            if (tipo.Length != 3)
            {
                throw new Exception("Contato - Selecione um tipo válido!");
            }
        }

        private void ValidarNumero(string numero)
        {
            if (numero.Length < 13)
            {
                throw new Exception("Contato - Informe um número de contato válido!");
            }
        }
    }
}
