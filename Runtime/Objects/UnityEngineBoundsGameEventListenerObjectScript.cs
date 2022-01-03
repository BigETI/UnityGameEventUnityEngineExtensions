using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventUnityEngineExtensions.Objects
{
    [CreateAssetMenu(fileName = "BoundsGameEvent", menuName = "Game events/UnityEngine/Game event (Bounds)")]
    public class UnityEngineBoundsGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Bounds>, IUnityEngineBoundsGameEventListenerObject
    {
        // ...
    }
}
