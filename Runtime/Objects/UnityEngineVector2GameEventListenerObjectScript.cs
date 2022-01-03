using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventUnityEngineExtensions.Objects
{
    [CreateAssetMenu(fileName = "Vector2GameEvent", menuName = "Game events/UnityEngine/Game event (Vector2)")]
    public class UnityEngineVector2GameEventListenerObjectScript : AGameEventWithParameterObjectScript<Vector2>, IUnityEngineVector2GameEventListenerObject
    {
        // ...
    }
}
