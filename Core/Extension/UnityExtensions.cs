namespace Core.Extension
{
    using UnityEngine;

    public static class UnityExtensions
    {
        public static Rect Rect(this Bounds bounds)
        {
            return new Rect(bounds.center - bounds.extents, bounds.size);
        }

        public static bool FastContains2D(this Bounds bounds, Vector2 position)
        {
            Vector3 min = bounds.min;
            if (position.x < min.x || position.y < bounds.min.y)
            {
                return false;
            } 
            Vector3 max = bounds.max;
            return position.x < max.x && position.y < max.y;
        }

        public static bool FastIntersects2D(this Bounds bounds, Bounds other)
        {
            Vector3 boundsMin = bounds.min;
            Vector3 otherMax = other.max;
            if (otherMax.x < boundsMin.x || otherMax.y < boundsMin.y)
            {
                return false;
            }

            Vector3 boundsMax = bounds.max;
            Vector3 otherMin = other.min;
            return boundsMax.x >= otherMin.x && boundsMax.y >= otherMin.y;
        }

        public static bool Overlaps2D(this Bounds bounds, Bounds other)
        {
            Vector3 boundsMin = bounds.min;
            Vector3 otherMin = other.min;
            if (otherMin.x < boundsMin.x || otherMin.y < boundsMin.y)
            {
                return false;
            }

            Vector3 boundsMax = bounds.max;
            Vector3 otherMax = other.max;
            return otherMax.x <= boundsMax.x && otherMax.y <= boundsMax.y;
        }
    }
}