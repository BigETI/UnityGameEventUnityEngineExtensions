using UnityEngine;
using UnityGameEvents;
using UnityGameEventUnityEngineExtensions.Objects;

namespace UnityGameEventUnityEngineExtensions
{
    public interface IUnityEngineRayGameEventListenerController : IGameEventWithParameterListenerController<UnityEngineRayGameEventListenerObjectScript, Ray>
    {
        // ...
    }
}
