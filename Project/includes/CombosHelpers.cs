using FiscoCorretora.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiscoCorretora.Includes
{
    public class CombosHelpers : IDisposable
    {
        private static FiscoCorretoraContext db = new FiscoCorretoraContext();

        public static List<Tarefa> GetTarefas() {
            var tar = db.Tarefas.ToList();
            tar.Add(
                new Tarefa
                {
                    TarefaId = 0,
                    DesTar = "[Selecione uma tarefa]"
                });
            return tar.OrderBy(t => t.DesTar).ToList();
        }

        public static List<Usuario> GetUsuarios()
        {
            var usu = db.Usuarios.ToList();
            usu.Add(
                new Usuario
                {
                    UsuarioId = 0,
                    NomUsu = "[Selecione um usuário]"
                });
            return usu.OrderBy(u => u.NomUsu).ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}