using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventUnityEngineExtensions.Objects
{
    [CreateAssetMenu(fileName = "RayGameEvent", menuName = "Game events/UnityEngine/Game event (Ray)")]
    public class UnityEngineRayGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Ray>, IUnityEngineRayGameEventListenerObject
    {
        // ...
    }
}
