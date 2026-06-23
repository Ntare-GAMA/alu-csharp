using System;

/// <summary>
/// Abstract base class that all entity types inherit from.
/// </summary>
public abstract class Base
{
    /// <summary>Gets or sets the name of the entity.</summary>
    public string name { get; set; } = "";

    /// <summary>Returns a string describing the entity's type and name.</summary>
    public override string ToString()
    {
        return $"{name} is a {GetType().Name}";
    }
}