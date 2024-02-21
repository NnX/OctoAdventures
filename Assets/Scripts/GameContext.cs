using Naninovel;
using UnityEngine;

public class GameContext : MonoBehaviour
{
    private MiniGameService miniGameService;

    private async void Start()
    {
        miniGameService = Engine.FindService<MiniGameService>(service => service.CanPlay());
        //miniGameService.InitializeServiceAsync();
        await UniTask.Delay(5000);
        PlayMiniGame();

    }

    private void PlayMiniGame()
    {
        miniGameService.PlayGame();
    }
}
