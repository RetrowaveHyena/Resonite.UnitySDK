
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UnresolvedReferences
// Generated on: čtvrtek 5. března 2026 18:25:19
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UnresolvedReferences")]
public partial class UnresolvedReferences : global::FrooxEngine.Component

{
    public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.UnresolvedReferences.UnresolvedReference>, global::FrooxEngine.UnresolvedReferences.UnresolvedReference> References = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("References", References.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
