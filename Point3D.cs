using System;

namespace _20180315_Task1
{
    internal class Point3D : IEquatable<Point3D>
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        /// <summary>
        /// The constructor of the Point3D class.
        /// </summary>
        /// <param name="x">The coordinate of the point along the x axis.</param>
        /// <param name="y">The coordinate of the point along the y axis.</param>
        /// <param name="z">The coordinate of the point along the z axis.</param>
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// The Equals() method determines whether the given point3D is equal to the current point3D.
        /// </summary>
        /// <param name="other">Point3D for verification.</param>
        /// <returns>Result of checking.</returns>
        public bool Equals(Point3D other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z);
        }

        /// <summary>
        /// Equals() method determines whether the given object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to check.</param>
        /// <returns>Result of checking.</returns>
        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            return obj.GetType() == GetType() && Equals((Point3D)obj);
        }

        /// <summary>
        /// GetHashCode() method to check the equality of the object.
        /// </summary>
        /// <returns>HashCode of the current object.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = X.GetHashCode();
                hashCode = (hashCode * 397) ^ Y.GetHashCode();
                hashCode = (hashCode * 397) ^ Z.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// ToString() method allows you to display a point3D as a string.
        /// </summary>
        /// <returns>Point3D as a string.</returns>
        public override string ToString()
        {
            return $"[x = {X,4};  y = {Y,4};  z = {Z,4}]";
        }
    }
}