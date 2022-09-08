using ConfitecTeste.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfitecTeste.Application.Interfaces
{
    public interface IApplicationServiceUsuario
    {
        void Add(UsuarioDto usuarioDto);
        void Update(UsuarioDto usuarioDto);
        void Remove(UsuarioDto usuarioDto);
        IEnumerable<UsuarioDto> GetAll();
        UsuarioDto GetById(int id);

    }
}
