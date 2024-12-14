using Cysharp.Threading.Tasks;

public class SceneBase : PageBase
{
    protected async UniTask GoTo<T>() where T : TransitionBase
    {
        var transition = SceneHandler.Instance.GetTransition<T>();
        await transition.Enable();
        Disable().Forget();
    }
}
