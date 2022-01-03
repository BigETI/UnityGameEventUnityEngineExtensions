using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventUnityEngineExtensions.Objects
{
    [CreateAssetMenu(fileName = "RectGameEvent", menuName = "Game events/UnityEngine/Game event (Rect)")]
    public class UnityEngineRectGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Rect>, IUnityEngineRectGameEventListenerObject
    {
        // ...
    }
}
