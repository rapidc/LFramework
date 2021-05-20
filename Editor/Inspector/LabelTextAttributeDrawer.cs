using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(LabelTextAttribute))]
public class LabelTextAttributeDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        LabelTextAttribute attr = attribute as LabelTextAttribute;
        label = EditorGUI.BeginProperty(position, label, property);
        label.text = attr.Text;
        EditorGUI.PropertyField(position, property, label, property.isExpanded);
        EditorGUI.EndProperty();
    }
}
