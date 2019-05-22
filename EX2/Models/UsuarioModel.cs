using System;

namespace EX2.Models {
    public class UsuarioModel {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }

        public UsuarioModel (string nome, string email, string senha, DateTime dataDeNascimento) {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataNascimento = dataDeNascimento;
        }

        public UsuarioModel (int id, string nome, string email, string senha, DateTime dataDeNascimento) {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataNascimento = dataDeNascimento;
        }
    }
}