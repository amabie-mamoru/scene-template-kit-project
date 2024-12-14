using Cysharp.Threading.Tasks;

public class TransitionToA : TransitionBase
{
    protected override async UniTask OnEnabled()
    {
        await UniTask.Delay(3000);
        var scene = SceneHandler.Instance.GetScene<SceneA>();
        await scene.Enable();
        Disable().Forget();
    }
}
