using UnityEngine;
using UnityGameEvents;

/// <summary>
/// Unity game event "UnityEngine" extensions namespace
/// </summary>
namespace UnityGameEventUnityEngineExtensions
{
    /// <summary>
    /// An interface that represents an "UnityEngine" game event invoker controller
    /// </summary>
    interface IUnityEngineGameEventInvokerController : IGameEventInvokerController
    {
        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        void Invoke(Bounds value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        void Invoke(BoundsInt value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        void Invoke(Color32 value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        void Invoke(Color value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        void Invoke(Matrix4x4 value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        void Invoke(Plane value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        void Invoke(Quaternion value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        void Invoke(Ray2D value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        void Invoke(Ray value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        void Invoke(Rect value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        void Invoke(RectInt value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        void Invoke(Vector2 value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        void Invoke(Vector2Int value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        void Invoke(Vector3 value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        void Invoke(Vector3Int value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        void Invoke(Vector4 value);
    }
}
