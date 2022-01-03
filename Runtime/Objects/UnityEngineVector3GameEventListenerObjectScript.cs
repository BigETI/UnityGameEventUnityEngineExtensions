using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventUnityEngineExtensions.Objects
{
    [CreateAssetMenu(fileName = "Vector3GameEvent", menuName = "Game events/UnityEngine/Game event (Vector3)")]
    public class UnityEngineVector3GameEventListenerObjectScript : AGameEventWithParameterObjectScript<Vector3>, IUnityEngineVector3GameEventListenerObject
    {
        // ...
    }
}
