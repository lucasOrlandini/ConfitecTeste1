using Autofac;
using AutoMapper;
using ConfitecTeste.Application;
using ConfitecTeste.Application.Interfaces;
using ConfitecTeste.Application.Interfaces.Mappers;
using ConfitecTeste.Application.Mappers;
using ConfitecTeste.Domain.Core.Interfaces.Repositorys;
using ConfitecTeste.Domain.Core.Interfaces.Services;
using ConfitecTeste.Domain.Services;
using ConfitecTeste.Infrastructure.Data.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfitecTeste.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceUsuario>().As<IApplicationServiceUsuario>();
            builder.RegisterType<ApplicationServiceEscolaridade>().As<IApplicationServiceEscolaridade>();
            builder.RegisterType<ServiceUsuario>().As<IServiceUsuario>();
            builder.RegisterType<ServiceEscolaridade>().As<IServiceEscolaridade>();
            builder.RegisterType<RepositoryUsuario>().As<IRepositoryUsuario>();
            builder.RegisterType<RepositoryEscolaridade>().As<IRepositoryEscolaridade>();
            builder.RegisterType<MapperEscolaridade>().As<IMapperEscolaridade>();
            builder.RegisterType<MapperUsuario>().As<IMapperUsuario>();



            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }

        #endregion IOC
    }
}
