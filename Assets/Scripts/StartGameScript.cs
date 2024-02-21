using Naninovel;
using UnityEngine;

public class StartGameScript : MonoBehaviour
{
    private async void Start()
    {
        await RuntimeInitializer.InitializeAsync(); 
        if (Engine.Initialized)
        {
            DoMyCustomWork();
        }
        else
        {
            Engine.OnInitializationFinished += DoMyCustomWork;
        }
    }
  

    private async void DoMyCustomWork ()
    {
        // Engine is initialized here, it's safe to use the APIs. 
        var player = Engine.GetService<IScriptPlayer>();
        await player.PreloadAndPlayAsync("GameStart");
    }
}
