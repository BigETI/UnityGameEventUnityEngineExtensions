using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventUnityEngineExtensions.Objects
{
    [CreateAssetMenu(fileName = "Vector3IntGameEvent", menuName = "Game events/UnityEngine/Game event (Vector3Int)")]
    public class UnityEngineVector3IntGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Vector3Int>, IUnityEngineVector3IntGameEventListenerObject
    {
        // ...
    }
}
