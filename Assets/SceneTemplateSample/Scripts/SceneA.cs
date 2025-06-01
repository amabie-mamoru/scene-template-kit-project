using com.amabie.SceneTemplateKit;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class SceneA : SceneBase
{
    [SerializeField] private Button button;

    protected new void Start()
    {
        base.Start();
        button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        GoTo<TransitionToB>().Forget();
    }
}