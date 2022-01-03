using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventUnityEngineExtensions.Objects
{
    [CreateAssetMenu(fileName = "ColorGameEvent", menuName = "Game events/UnityEngine/Game event (Color)")]
    public class UnityEngineColorGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Color>, IUnityEngineColorGameEventListenerObject
    {
        // ...
    }
}
