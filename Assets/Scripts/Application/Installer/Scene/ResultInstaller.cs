using DefaultNamespace;
using Domain.UseCase.Result;
using Presentation.Presenter.Result;
using UnityEngine;
using Zenject;

namespace MakeTen.Application.Installer.Scene
{
    public class ResultInstaller : MonoInstaller<ResultInstaller>
    {
        [SerializeField] private ResultView resultView;
        [SerializeField] private ReturnTitleButtonView returnTitleButtonView;
        [SerializeField] private RetryButtonView retryButtonView;
        
        public override void InstallBindings()
        {
            // UseCases
            Container.BindInterfacesTo<ResultUseCase>().AsCached();
            
            // Presenters
            Container.BindInterfacesTo<ResultPresenter>().AsCached();
            
            // Views
            Container.BindInterfacesTo<ResultView>().FromInstance(resultView).AsCached();
            Container.BindInterfacesTo<ReturnTitleButtonView>().FromInstance(returnTitleButtonView).AsCached();
            Container.BindInterfacesTo<RetryButtonView>().FromInstance(retryButtonView).AsCached();
        }
    }
}