using Cysharp.Threading.Tasks;

public class TransitionBase : PageBase
{
    protected async UniTask GoTo<T>() where T : SceneBase
    {
        var scene = SceneHandler.Instance.GetScene<T>();
        await scene.Enable();
        Disable().Forget();
    }
}
