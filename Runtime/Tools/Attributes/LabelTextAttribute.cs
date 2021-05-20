using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public class LabelTextAttribute : PropertyAttribute
{
    public string Text { get; private set; }

    public LabelTextAttribute(string text)
    {
        Text = text;
    }
}
