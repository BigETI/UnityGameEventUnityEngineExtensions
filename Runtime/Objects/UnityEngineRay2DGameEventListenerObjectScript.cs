using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventUnityEngineExtensions.Objects
{
    [CreateAssetMenu(fileName = "Ray2DGameEvent", menuName = "Game events/UnityEngine/Game event (Ray2D)")]
    public class UnityEngineRay2DGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Ray2D>, IUnityEngineRay2DGameEventListenerObject
    {
        // ...
    }
}
