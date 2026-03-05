
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiLineMesh
// Generated on: čtvrtek 5. března 2026 18:22:35
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MultiLineMesh")]
public partial class MultiLineMesh : global::FrooxEngine.ProceduralMesh

{
    public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.MultiLineMesh.Line>, global::FrooxEngine.MultiLineMesh.Line> Lines = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Lines", Lines.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}
