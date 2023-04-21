using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LuaFramework
{
    public class TSUnit : MonoBehaviour
    {
        public Image img;

        public Vector4 center;
        private Vector4 _orgin;

        public float radius;
        private float currentradius;

        private void Update()
        {
            SetCenter();
            SetRadius();
        }

        private void SetCenter()
        {
            if (_orgin == center) return;
            if (img == null) img = GetComponent<Image>();
            if (img == null) return;
            img.material.SetVector($"_Center", center);
            _orgin = center;
        }

        private void SetRadius()
        {
            if (currentradius == radius) return;
            if (img == null) img = GetComponent<Image>();
            if (img == null) return;
            img.material.SetFloat($"_Radius", radius);
            currentradius = radius;
        }
    }
}