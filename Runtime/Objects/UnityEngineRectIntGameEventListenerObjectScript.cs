using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventUnityEngineExtensions.Objects
{
    [CreateAssetMenu(fileName = "RectIntGameEvent", menuName = "Game events/UnityEngine/Game event (RectInt)")]
    public class UnityEngineRectIntGameEventListenerObjectScript : AGameEventWithParameterObjectScript<RectInt>, IUnityEngineRectIntGameEventListenerObject
    {
        // ...
    }
}
