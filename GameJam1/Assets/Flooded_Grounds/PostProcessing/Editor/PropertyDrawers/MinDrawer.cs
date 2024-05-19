using UnityEngine;
using UnityEditor;

namespace MyNamespace
{
    public class MinimumAttribute : PropertyAttribute
    {
        public float min;

        public MinimumAttribute(float minValue)
        {
            min = minValue;
        }
    }

    [CustomPropertyDrawer(typeof(MinimumAttribute))]
    public class MinimumDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            MinimumAttribute attribute = attribute = (MinimumAttribute)base.attribute;

            if (property.propertyType == SerializedPropertyType.Integer)
            {
                int v = EditorGUI.IntField(position, label, property.intValue);
                property.intValue = (int)Mathf.Max(v, attribute.min);
            }
            else if (property.propertyType == SerializedPropertyType.Float)
            {
                float v = EditorGUI.FloatField(position, label, property.floatValue);
                property.floatValue = Mathf.Max(v, attribute.min);
            }
            else
            {
                EditorGUI.LabelField(position, label.text, "Use Minimum with float or int.");
            }
        }
    }
}
