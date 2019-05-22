using System;
using System.Collections.Generic;
using System.IO;
using EX2.Models;

namespace EX2.Repositorio {
    public class UsuarioRepositorio {
        public UsuarioModel Cadastrar (UsuarioModel usuario) {

            if (File.Exists ("usuarios.csv")) {
                usuario.Id = File.ReadAllLines ("usuarios.csv").Length + 1;
            } else {
                usuario.Id = 1;
            }

            StreamWriter SW = new StreamWriter ("usuarios.csv", true);
            SW.WriteLine ($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataNascimento}");
            SW.Close ();
            return usuario;
        }

        public List<UsuarioModel> ListarUsuarios() {
            List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();

            string[] linhas = File.ReadAllLines("usuarios.csv");
            UsuarioModel usuario;

            foreach (var item in linhas) {
                if (string.IsNullOrEmpty(item)) {
                    continue;
                }
                string[] linha = item.Split(";");
                usuario = new UsuarioModel(
                    id: int.Parse(linha[0]),
                    nome: linha[1],
                    email: linha[2],
                    senha: linha[3],
                    dataDeNascimento: DateTime.Parse(linha[4])
                );
                listaDeUsuarios.Add(usuario);
            }
            return listaDeUsuarios;
        }

        public UsuarioModel BuscarPorId(int id) {
            
            string[] linhas = File.ReadAllLines("usuarios.csv");

            foreach (var item in linhas) {
                string[] linha = item.Split(";");

                if (id.ToString().Equals(linha[0])) {
                    UsuarioModel usuario = new UsuarioModel(
                        id: int.Parse(linha[0]),
                        nome: linha[1],
                        email: linha[2],
                        senha: linha[3],
                        dataDeNascimento: DateTime.Parse(linha [4])
                    );
                    return usuario;
                }
            }
            return null;
        }

        public UsuarioModel Editar(UsuarioModel usuario) {
            string[] linhas = File.ReadAllLines("usuarios.csv");

            for (int i = 0; i < linhas.Length; i++) {
                string[] linha = linhas[i].Split(";");
                if(usuario.Id.ToString().Equals(linha[0])) {
                    linhas[i] = $"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataNascimento}";
                    break;
                }
            }
            File.WriteAllLines("usuarios.csv", linhas);

            return usuario;
        }
    }
}