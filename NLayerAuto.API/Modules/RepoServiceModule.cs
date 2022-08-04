using System.Reflection;
using Autofac;
using NLayerAuto.Core.Repositories;
using NLayerAuto.Core.Services;
using NLayerAuto.Core.UnitOfWorks;
using NLayerAuto.Repository;
using NLayerAuto.Repository.Repositories;
using NLayerAuto.Repository.UnitOfWorks;
using NLayerAuto.Service.Mapping;
using NLayerAuto.Service.Services;
using Module = Autofac.Module;

namespace NLayerAuto.API.Modules;

public class RepoServiceModule:Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
        builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();

        builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

        var apiAssembly = Assembly.GetExecutingAssembly();
        var repoAssemmbly = Assembly.GetAssembly(typeof(AppDbContext));
        var serviceAssemmbly = Assembly.GetAssembly(typeof(MapProfile));

        builder.RegisterAssemblyTypes(apiAssembly, repoAssemmbly,serviceAssemmbly).Where(x=>x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();
        builder.RegisterAssemblyTypes(apiAssembly, repoAssemmbly,serviceAssemmbly).Where(x=>x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();
    }
}