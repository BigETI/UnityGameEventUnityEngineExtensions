using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventUnityEngineExtensions.Objects
{
    [CreateAssetMenu(fileName = "PlaneGameEvent", menuName = "Game events/UnityEngine/Game event (Plane)")]
    public class UnityEnginePlaneGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Plane>, IUnityEnginePlaneGameEventListenerObject
    {
        // ...
    }
}
