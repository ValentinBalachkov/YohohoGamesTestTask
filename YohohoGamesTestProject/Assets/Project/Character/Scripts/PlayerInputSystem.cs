using Leopotam.Ecs;

namespace Project.Character.Scripts
{
    public class PlayerInputSystem : IEcsRunSystem
    {
        private readonly EcsFilter<PlayerTag,DirectionComponent> _directionFilter = null;
        public void Run()
        {
            foreach (var i in _directionFilter)
            {
                ref var directionComponent = ref _directionFilter.Get2(i);
            }
        }
    }
}