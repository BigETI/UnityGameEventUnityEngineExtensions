using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventUnityEngineExtensions.Objects
{
    [CreateAssetMenu(fileName = "BoundsIntGameEvent", menuName = "Game events/UnityEngine/Game event (BoundsInt)")]
    public class UnityEngineBoundsIntGameEventListenerObjectScript : AGameEventWithParameterObjectScript<BoundsInt>, IUnityEngineBoundsIntGameEventListenerObject
    {
        // ...
    }
}
