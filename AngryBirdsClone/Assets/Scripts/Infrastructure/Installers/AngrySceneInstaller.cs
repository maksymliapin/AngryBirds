using Infrastructure.StateFactory;
using Infrastructure.StateMachine;
using Infrastructure.States;
using Zenject;

namespace Infrastructure.Installers
{
    public class AngrySceneInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindStateFactory();
            BindBootstrap();
            Container.Bind<IState>().WithId("InitializeState").To<InitializeState>().AsSingle();
            Container.Bind<Bootstrap>().AsSingle().NonLazy();
        }

        private void BindBootstrap()
        {
            Container.Bind<IStateMachine>().To<StateMachine.StateMachine>().AsSingle();
        }

        private void BindStateFactory()
        {
            Container.Bind<IStateFactory>().To<StateFactory.StateFactory>().AsSingle();
        }
    }
}