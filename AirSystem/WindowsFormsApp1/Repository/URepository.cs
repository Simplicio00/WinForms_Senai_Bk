using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Repository
{
	class URepository
	{
		private static List<Usuario> Usuarios;

		public URepository()
		{
			if (Usuarios == null)
			{
				Usuarios = new List<Usuario>();

				Usuarios.Add(new Usuario
				{
					Nome = "usuario",
					usr = "usr",
					Senha = "12345",
					Email = "usr.usr@email.com",
					DataNascimento = DateTime.Today,
					Endereco = "pdr24",
					IdUsuario = 1,
					IsAdmin = true
				});

				Usuarios.Add(
					new Usuario
					{
						Nome = "regular",
						usr = "regularusr",
						Senha = "regularpwd",
						Email = "reg.usr@email.com",
						DataNascimento = DateTime.Today,
						Endereco = "pdr24",
						IdUsuario = 2,
						IsAdmin = false
					}
				);
			}
		}

		public void CadastroUsuario(Usuario usuario)
		{
			Usuarios.Add(usuario);
		}

		public List<Usuario> GetAll()
		{
			return Usuarios.ToList();
		}


		public void Editar(Usuario usuario)
		{
			List<Usuario> lista = GetAll();

			var usr = lista.FirstOrDefault(a => a.IdUsuario == usuario.IdUsuario);
			
			Usuarios.Remove(usr);
			
			if (usuario.Email != null)
			{
				usr = usuario;
			}

			Usuarios.Add(usr);
		}

		public Usuario BuscarPorId(int id)
		{
			var usr = Usuarios.FirstOrDefault(a => a.IdUsuario == id);
			return usr;
		}

		public void Excluir(int id)
		{
			List<Usuario> lista = GetAll();

			var usuario = lista.FirstOrDefault(a => a.IdUsuario == id);

			Usuarios.Remove(usuario);
		}
	}
}
