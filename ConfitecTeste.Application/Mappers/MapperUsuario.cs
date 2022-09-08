using ConfitecTeste.Application.Dtos;
using ConfitecTeste.Application.Interfaces.Mappers;
using ConfitecTeste.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfitecTeste.Application.Mappers
{
    public class MapperUsuario : IMapperUsuario
    {

        IEnumerable<UsuarioDto> usuarioDtos = new List<UsuarioDto>();
        public Usuario MapperDtoToEntity(UsuarioDto usuarioDto)
        {
            var usuario = new Usuario()
            {
                Id = usuarioDto.Id,
                Nome = usuarioDto.Nome,
                Sobrenome = usuarioDto.Sobrenome,
                Email = usuarioDto.Email,
                Data = usuarioDto.Data,
                EscolaridadeId = usuarioDto.EscolaridadeId,
                HistoricoEscolarId = usuarioDto.HistoricoEscolarId
            };
            return usuario;
        }

        public UsuarioDto MapperEntityToDto(Usuario usuario)
        {
            var usuarioDto = new UsuarioDto()
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Sobrenome = usuario.Sobrenome,
                Email = usuario.Email,
                Data = usuario.Data,
                EscolaridadeId = usuario.EscolaridadeId,
                HistoricoEscolarId = usuario.HistoricoEscolarId
            };
            return usuarioDto;
        }

        public IEnumerable<UsuarioDto> MapperListUsuariosDto(IEnumerable<Usuario> usuarios)
        {
            var dto = usuarios.Select(c => new UsuarioDto
            {
                Id = c.Id,
                Nome = c.Nome,
                Sobrenome = c.Sobrenome,
                Email = c.Email,
                Data = c.Data,
                EscolaridadeId = c.EscolaridadeId,
                HistoricoEscolarId = c.HistoricoEscolarId
            });
            return dto;
        }
    }
}
