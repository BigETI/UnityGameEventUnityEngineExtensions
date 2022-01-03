using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventUnityEngineExtensions.Objects
{
    [CreateAssetMenu(fileName = "Vector2IntGameEvent", menuName = "Game events/UnityEngine/Game event (Vector2Int)")]
    public class UnityEngineVector2IntGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Vector2Int>, IUnityEngineVector2IntGameEventListenerObject
    {
        // ...
    }
}
