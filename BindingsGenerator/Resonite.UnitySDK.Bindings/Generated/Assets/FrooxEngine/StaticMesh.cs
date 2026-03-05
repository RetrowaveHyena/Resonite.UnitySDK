
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StaticMesh
// Generated on: čtvrtek 5. března 2026 18:22:31
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StaticMesh")]
public partial class StaticMesh : global::FrooxEngine.StaticAssetProvider<global::FrooxEngine.Mesh,global::Elements.Assets.MeshMetadata,global::FrooxEngine.MeshVariantDescriptor>

{
    public global::System.Boolean Readable { get => Readable_Element.Data; set => Readable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Readable_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Readable", Readable_Element.ToLinkField(context));
}
public  async System.Threading.Tasks.Task<global::System.Boolean> RecalculateNormals(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> RecalculateNormalsMerged(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> RecalculateTangentsSimple(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> RecalculateTangentsMikktspace(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> RecalculateBlendshapeNormals(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> RecalculateBlendshapeNormalsMerged(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> RecalculateBlendshapeTangentsMikktspace(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> FlipNormals(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> ReverseWinding(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> MakeDualSided(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> ConvertToFlatShading(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> MergeDoubles(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> StripEmptyBlendshapes(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> MergeBlendshapes(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> StripBlendshapeNormals(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> StripBlendshapeTangents(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> TrimBoneWeightCount(global::System.Int32 maxBoneCount, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("maxBoneCount", maxBoneCount.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> ConvertToConvexHull(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> ConvertToPointCloud(IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}

public  async System.Threading.Tasks.Task<global::System.Boolean> TranslateUVs(UnityEngine.Vector4 offset, UnityEngine.Vector4 scale, IConversionContext context)
{
        var __message = new ResoniteLink.CallSyncMethod();
__message.TargetID = context.GetId(this);
                if(__message.TargetID == null)
                    throw new System.InvalidOperationException("Cannot call sync methods on objects that have not been synced to resonite yet.");
__message.Arguments.Add("offset", offset.ToData());
__message.Arguments.Add("scale", scale.ToData());
var result = await context.CallMethod(__message);
        if(!result.Success)
            throw new Exception("Error running method: " + result.ErrorInfo);
return ((ResoniteLink.Data_bool)result.Result).Value;
}


}
}
