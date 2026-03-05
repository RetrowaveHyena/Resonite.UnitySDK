
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.FireOnFalse
// Generated on: čtvrtek 5. března 2026 18:23:35
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.FireOnFalse")]
public partial class FireOnFalse : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.Actions.FireOnChange<global::System.Boolean,global::ProtoFlux.Runtimes.Execution.Nodes.Actions.ValueProxy<global::System.Boolean>>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean> Condition { get => Condition_Element.Data; set => Condition_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>>, global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Boolean>> Condition_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Condition", Condition_Element.ToLinkReference(context));
}

}
}
