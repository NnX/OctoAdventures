using Naninovel;
using UnityEngine;

public class GameContext : MonoBehaviour
{
    private MiniGameService _miniGameService;

    private async void Start()
    {
        _miniGameService = Engine.FindService<MiniGameService>(service => service.CanPlay());
        //miniGameService.InitializeServiceAsync();
        await UniTask.Delay(5000);
        PlayMiniGame();

    }

    private void PlayMiniGame()
    {
        _miniGameService.PlayGame();
    }
}
