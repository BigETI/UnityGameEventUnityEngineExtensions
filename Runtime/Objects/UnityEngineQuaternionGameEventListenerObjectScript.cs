using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventUnityEngineExtensions.Objects
{
    [CreateAssetMenu(fileName = "QuaternionGameEvent", menuName = "Game events/UnityEngine/Game event (Quaternion)")]
    public class UnityEngineQuaternionGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Quaternion>, IUnityEngineQuaternionGameEventListenerObject
    {
        // ...
    }
}
