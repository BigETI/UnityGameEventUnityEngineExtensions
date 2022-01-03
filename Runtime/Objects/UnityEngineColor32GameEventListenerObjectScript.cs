using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventUnityEngineExtensions.Objects
{
    [CreateAssetMenu(fileName = "Color32GameEvent", menuName = "Game events/UnityEngine/Game event (Color32)")]
    public class UnityEngineColor32GameEventListenerObjectScript : AGameEventWithParameterObjectScript<Color32>, IUnityEngineColor32GameEventListenerObject
    {
        // ...
    }
}
