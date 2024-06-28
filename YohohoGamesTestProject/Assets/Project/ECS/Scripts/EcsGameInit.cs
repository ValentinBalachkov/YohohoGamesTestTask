using Leopotam.Ecs;
using UnityEngine;
using Voody.UniLeo;

public class EcsGameInit : MonoBehaviour
{
    private EcsWorld _ecsWorld;
    private EcsSystems _ecsSystems;

    private void Start()
    {
        _ecsWorld = new EcsWorld();
        _ecsSystems = new EcsSystems(_ecsWorld);

        _ecsSystems.ConvertScene();

        AddInjections();
        AddSystems();
        AddOneFrames();
            
        _ecsSystems.Init();
    }

    private void Update()
    {
        _ecsSystems.Run();
    }

    private void OnDestroy()
    {
        _ecsSystems.Destroy();
        _ecsSystems = null;
        _ecsWorld.Destroy();
        _ecsWorld = null;
    }

    private void AddSystems()
    {
        
    }
    
    private void AddInjections()
    {
        
    }
    
    private void AddOneFrames()
    {
        
    }
}
