using DTT.MinigameMemory;
using Naninovel;
using UnityEngine;

[InitializeAtRuntime]
public class MiniGameService : IEngineService
{
    private readonly InputManager inputManager;
    private readonly ScriptPlayer scriptPlayer;

    private MemoryGameManager _gameManager;
    private MemoryGameSettings _gameSettings;

    public MiniGameService (/*InputManager inputManager, ScriptPlayer scriptPlayer*/)
    {
        Debug.Log("[test] MiniGameService ctor");
        /*// The services are potentially not yet initialized here,
        // refrain from using them.
        this.inputManager = inputManager;
        this.scriptPlayer = scriptPlayer;*/
    }

    public UniTask InitializeServiceAsync ()
    { 
        // Initialize the service here.
        // It's now safe to use services requested in the constructor.
        /*Debug.Log(inputManager.ProcessInput);
        Debug.Log(scriptPlayer.PlayedScript);*/
        return UniTask.CompletedTask;
    }

    public void ResetService ()
    {
        // Reset service state here.
    }

    public void DestroyService ()
    {
        // Stop the service and release any used resources here.
    }

    public bool CanPlay()
    {
        return true;
    }

    public void PlayGame()
    {
        Debug.Log("[test] Start mini game");
        if (_gameManager != null)
        {
            _gameManager.StartGame(_gameSettings);  
        }
    }
}