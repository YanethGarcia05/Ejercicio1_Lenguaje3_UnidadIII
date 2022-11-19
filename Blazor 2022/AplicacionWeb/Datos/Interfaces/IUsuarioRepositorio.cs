﻿using Modelos;
namespace Datos.Interfaces
{
    public interface IUsuarioRepositorio
    {
        //metodo devuelva un usuario
        Task<Usuario> GetPorCodigo(string codigo);
        Task<bool>Nuevo(Usuario usuario);
        Task<bool> Actualizar(Usuario usuario);
        Task<bool> Eliminar(string codigo);
        Task<IEnumerable<Usuario>> GetLista();
    }
}
