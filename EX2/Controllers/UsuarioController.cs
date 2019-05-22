using System;
using EX2.Models;
using EX2.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EX2.Controllers {
    public class UsuarioController : Controller {
        [HttpGet]
        public IActionResult index () {

            return View ();
        }

        [HttpPost]
        public IActionResult Cadastrar (IFormCollection form) {
            UsuarioModel usuario = new UsuarioModel (
                nome: form["nome"],
                email: form["email"],
                senha: form["senha"],
                dataDeNascimento: DateTime.Parse (form["dataDeNascimento"])
            );

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();

            usuarioRepositorio.Cadastrar (usuario);

            TempData["mensagem"] = "Usuario Cadastrado com sucesso";
            return RedirectToAction ("Listar", "Usuario");
        }

        [HttpGet]
        public IActionResult Listar() {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            ViewData["usuarios"] = usuarioRepositorio.ListarUsuarios();

            return View();
        }

        [HttpGet]
        public IActionResult Editar(int id) {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            UsuarioModel usuarioRetornado = usuarioRepositorio.BuscarPorId(id);

            if (usuarioRetornado != null) {
                ViewBag.usuario = usuarioRetornado;
            } else {
                TempData["mensagem"] = "Usuario Não encontrado";
                return RedirectToAction("Listar");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Editar(IFormCollection form) {
            UsuarioModel usuario = new UsuarioModel (
                id: int.Parse(form["id"]),
                nome: form["nome"],
                email: form["email"],
                senha: form["senha"],
                dataDeNascimento: DateTime.Parse(form["dataDeNascimento"])
            );
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.Editar(usuario);

            TempData["mensagem"] = "Usuario editado com sucesso";
            return RedirectToAction ("Listar");
        }
    }
}