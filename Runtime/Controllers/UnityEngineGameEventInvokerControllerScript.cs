using UnityEngine;
using UnityGameEvents.Controllers;

/// <summary>
/// Unity game event "UnityEngine" extensions controllers namespace
/// </summary>
namespace UnityGameEventUnityEngineExtensions.Controllers
{
    /// <summary>
    /// A class that describes a "UnityEngine" game event invoker controller script
    /// </summary>
    public class UnityEngineGameEventInvokerControllerScript : GameEventInvokerControllerScript, IUnityEngineGameEventInvokerController
    {
        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Bounds value) => Invoke<Bounds>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(BoundsInt value) => Invoke<BoundsInt>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Color32 value) => Invoke<Color32>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Color value) => Invoke<Color>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Matrix4x4 value) => Invoke<Matrix4x4>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Plane value) => Invoke<Plane>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Quaternion value) => Invoke<Quaternion>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Ray2D value) => Invoke<Ray2D>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Ray value) => Invoke<Ray>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Rect value) => Invoke<Rect>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(RectInt value) => Invoke<RectInt>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Vector2 value) => Invoke<Vector2>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Vector2Int value) => Invoke<Vector2Int>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Vector3 value) => Invoke<Vector3>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Vector3Int value) => Invoke<Vector3Int>(value);

        /// <summary>
        /// Invokes this game event
        /// </summary>
        /// <param name="value">Game event parameter value</param>
        public void Invoke(Vector4 value) => Invoke<Vector4>(value);
    }
}
