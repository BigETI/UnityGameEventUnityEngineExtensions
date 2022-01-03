using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventUnityEngineExtensions.Objects
{
    [CreateAssetMenu(fileName = "Vector4GameEvent", menuName = "Game events/UnityEngine/Game event (Vector4)")]
    public class UnityEngineVector4GameEventListenerObjectScript : AGameEventWithParameterObjectScript<Vector4>, IUnityEngineVector4GameEventListenerObject
    {
        // ...
    }
}
