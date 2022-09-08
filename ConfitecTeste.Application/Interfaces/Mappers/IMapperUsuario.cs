using ConfitecTeste.Application.Dtos;
using ConfitecTeste.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfitecTeste.Application.Interfaces.Mappers
{
        public interface IMapperUsuario
        {
            Usuario MapperDtoToEntity(UsuarioDto usuarioDto);
            IEnumerable<UsuarioDto> MapperListUsuariosDto(IEnumerable<Usuario> usuarios);
            UsuarioDto MapperEntityToDto(Usuario usuario);
        }
    
}
