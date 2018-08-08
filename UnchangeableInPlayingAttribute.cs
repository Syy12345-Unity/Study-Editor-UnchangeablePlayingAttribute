using System;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

[AttributeUsage( AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public sealed class UnchangeableInPlayingAttribute : PropertyAttribute
{
    public UnchangeableInPlayingAttribute() { }
}

#if UNITY_EDITOR
[CustomPropertyDrawer( typeof( UnchangeableInPlayingAttribute ) )]
public sealed class UnchangeableInPlayingDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginDisabledGroup( Application.isPlaying );
        EditorGUI.PropertyField( position, property, label);
        EditorGUI.EndDisabledGroup();
    }
}
#endif
