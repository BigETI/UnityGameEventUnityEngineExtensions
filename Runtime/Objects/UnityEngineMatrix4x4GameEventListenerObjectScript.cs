using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventUnityEngineExtensions.Objects
{
    [CreateAssetMenu(fileName = "Matrix4x4GameEvent", menuName = "Game events/UnityEngine/Game event (Matrix4x4)")]
    public class UnityEngineMatrix4x4GameEventListenerObjectScript : AGameEventWithParameterObjectScript<Matrix4x4>, IUnityEngineMatrix4x4GameEventListenerObject
    {
        // ...
    }
}
