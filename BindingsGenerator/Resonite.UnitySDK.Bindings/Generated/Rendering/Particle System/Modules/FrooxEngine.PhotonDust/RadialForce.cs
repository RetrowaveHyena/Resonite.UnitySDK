
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.RadialForce
// Generated on: čtvrtek 5. března 2026 18:24:30
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.RadialForce")]
public partial class RadialForce : global::FrooxEngine.PhotonDust.RadialForceBase<global::System.Object>

{
    public UnityEngine.Vector3 Center { get => Center_Element.Data; set => Center_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Center_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Center", Center_Element.ToLinkField(context));
}

}
}
