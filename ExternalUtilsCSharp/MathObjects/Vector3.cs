﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExternalUtilsCSharp.MathObjects
{
    /// <summary>
    /// Class that holds information about a 3d-coordinate and offers some basic operations
    /// </summary>
    public struct Vector3
    {
        #region VARIABLES
        private float[] data;
        #endregion

        #region PROPERTIES
        public float X
        {
            get { return data[0]; }
            set { data[0] = value; }
        }
        public float Y
        {
            get { return data[1]; }
            set { data[1] = value; }
        }
        public float Z
        {
            get { return data[2]; }
            set { data[2] = value; }
        }
        /// <summary>
        /// Returns a new Vector3 at (0,0,0)
        /// </summary>
        public static Vector3 Zero
        {
            get { return new Vector3(0, 0, 0); }
        }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Initializes a new Vector3 using the given values
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Vector3(float x, float y, float z)
        {
            data = new float[] { x, y, z };
        }
        /// <summary>
        /// Initializes a new Vector3 by copying the values of the given Vector3
        /// </summary>
        /// <param name="vec"></param>
        public Vector3(Vector3 vec) : this(vec.X, vec.Y, vec.Z) { }
        #endregion

        #region METHODS
        /// <summary>
        /// Returns the length of this Vector3
        /// </summary>
        /// <returns></returns>
        public float Length()
        {
            return (float)System.Math.Sqrt(System.Math.Pow(X, 2) + System.Math.Pow(Y, 2) + System.Math.Pow(Z, 2));
        }
        /// <summary>
        /// Returns the distance from this Vector3 to the given Vector3
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public float DistanceTo(Vector3 other)
        {
            return (this + other).Length();
        }
        #endregion

        #region OPERATORS
        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }
        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }
        public float this[int i]
        {
            get { return data[i]; }
            set { data[i] = value; }
        }
        #endregion
    }
}
