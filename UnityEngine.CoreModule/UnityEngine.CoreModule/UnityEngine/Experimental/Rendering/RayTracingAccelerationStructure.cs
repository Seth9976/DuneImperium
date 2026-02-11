using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000371 RID: 881
	public sealed class RayTracingAccelerationStructure
	{
		// Token: 0x06002F49 RID: 12105 RVA: 0x000B5C38 File Offset: 0x000B3E38
		public ~RayTracingAccelerationStructure()
		{
			this.Dispose(false);
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x00012F24 File Offset: 0x00011124
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x00012F36 File Offset: 0x00011136
		public void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002F4C RID: 12108 RVA: 0x00012F43 File Offset: 0x00011143
		public static void Destroy(RayTracingAccelerationStructure accelStruct)
		{
			RayTracingAccelerationStructure.DestroyDelegateField(IL2CPP.Il2CppObjectBaseToPtr(accelStruct));
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x00012F55 File Offset: 0x00011155
		public void Release()
		{
			this.Dispose();
		}

		// Token: 0x06002F4E RID: 12110 RVA: 0x00012F5F File Offset: 0x0001115F
		public void Build()
		{
			this.Build(Vector3.zero);
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x00012F6E File Offset: 0x0001116E
		public void AddInstance(Renderer targetRenderer, Il2CppStructArray<RayTracingSubMeshFlags> subMeshFlags, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] uint id)
		{
			this.AddInstanceSubMeshFlagsArray(targetRenderer, subMeshFlags, enableTriangleCulling, frontTriangleCounterClockwise, mask, id);
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x000B5C6C File Offset: 0x000B3E6C
		public int AddInstance(GraphicsBuffer aabbBuffer, uint aabbCount, bool dynamicData, Matrix4x4 matrix, Material material, bool opaqueMaterial, MaterialPropertyBlock properties, [Optional] uint mask, [Optional] uint id)
		{
			return this.AddInstance_Procedural(aabbBuffer, aabbCount, dynamicData, matrix, material, opaqueMaterial, properties, mask, id);
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x00012F81 File Offset: 0x00011181
		public void RemoveInstance(Renderer targetRenderer)
		{
			this.RemoveInstance_Renderer(targetRenderer);
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x00012F8C File Offset: 0x0001118C
		public void RemoveInstance(int handle)
		{
			this.RemoveInstance_InstanceID(handle);
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x00012F97 File Offset: 0x00011197
		public void UpdateInstanceTransform(Renderer renderer)
		{
			this.UpdateInstanceTransform_Renderer(renderer);
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x00012FA2 File Offset: 0x000111A2
		public void UpdateInstanceTransform(int handle, Matrix4x4 matrix)
		{
			this.UpdateInstanceTransform_InstanceID(handle, matrix);
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x00012FAE File Offset: 0x000111AE
		public void Update()
		{
			this.Build(Vector3.zero);
		}

		// Token: 0x06002F56 RID: 12118 RVA: 0x00012FBD File Offset: 0x000111BD
		public void Update(Vector3 relativeOrigin)
		{
			this.Update_Injected(ref relativeOrigin);
		}

		// Token: 0x06002F57 RID: 12119 RVA: 0x000B5C94 File Offset: 0x000B3E94
		public void AddInstance(Renderer targetRenderer, [Optional] Il2CppStructArray<bool> subMeshMask, [Optional] Il2CppStructArray<bool> subMeshTransparencyFlags, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] uint id)
		{
			RayTracingAccelerationStructure.AddInstanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targetRenderer), IL2CPP.Il2CppObjectBaseToPtr(subMeshMask), IL2CPP.Il2CppObjectBaseToPtr(subMeshTransparencyFlags), enableTriangleCulling, frontTriangleCounterClockwise, mask, id);
		}

		// Token: 0x06002F58 RID: 12120 RVA: 0x000B5CCC File Offset: 0x000B3ECC
		public void AddInstance(GraphicsBuffer aabbBuffer, uint numElements, Material material, bool isCutOff, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] bool reuseBounds, [Optional] uint id)
		{
			this.AddInstance_Procedural_Deprecated(aabbBuffer, numElements, material, Matrix4x4.identity, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds, id);
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x000B5CF8 File Offset: 0x000B3EF8
		public void AddInstance(GraphicsBuffer aabbBuffer, uint numElements, Material material, Matrix4x4 instanceTransform, bool isCutOff, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] bool reuseBounds, [Optional] uint id)
		{
			this.AddInstance_Procedural_Deprecated(aabbBuffer, numElements, material, instanceTransform, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds, id);
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x00012FC7 File Offset: 0x000111C7
		public void Build(Vector3 relativeOrigin)
		{
			this.Build_Injected(ref relativeOrigin);
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x000B5D20 File Offset: 0x000B3F20
		public void AddInstance_Procedural_Deprecated(GraphicsBuffer aabbBuffer, uint numElements, Material material, Matrix4x4 instanceTransform, bool isCutOff, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] bool reuseBounds, [Optional] uint id)
		{
			this.AddInstance_Procedural_Deprecated_Injected(aabbBuffer, numElements, material, ref instanceTransform, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds, id);
		}

		// Token: 0x06002F5C RID: 12124 RVA: 0x000B5D44 File Offset: 0x000B3F44
		public int AddInstance_Procedural(GraphicsBuffer aabbBuffer, uint aabbCount, bool dynamicData, Matrix4x4 matrix, Material material, bool opaqueMaterial, MaterialPropertyBlock properties, [Optional] uint mask, [Optional] uint id)
		{
			return this.AddInstance_Procedural_Injected(aabbBuffer, aabbCount, dynamicData, ref matrix, material, opaqueMaterial, properties, mask, id);
		}

		// Token: 0x06002F5D RID: 12125 RVA: 0x00012FD1 File Offset: 0x000111D1
		public void RemoveInstance_Renderer(Renderer targetRenderer)
		{
			RayTracingAccelerationStructure.RemoveInstance_RendererDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targetRenderer));
		}

		// Token: 0x06002F5E RID: 12126 RVA: 0x00012FE9 File Offset: 0x000111E9
		public void RemoveInstance_InstanceID(int instanceID)
		{
			RayTracingAccelerationStructure.RemoveInstance_InstanceIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), instanceID);
		}

		// Token: 0x06002F5F RID: 12127 RVA: 0x00012FFC File Offset: 0x000111FC
		public void UpdateInstanceTransform_Renderer(Renderer renderer)
		{
			RayTracingAccelerationStructure.UpdateInstanceTransform_RendererDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(renderer));
		}

		// Token: 0x06002F60 RID: 12128 RVA: 0x00013014 File Offset: 0x00011214
		public void UpdateInstanceTransform_InstanceID(int instanceID, Matrix4x4 matrix)
		{
			this.UpdateInstanceTransform_InstanceID_Injected(instanceID, ref matrix);
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x0001301F File Offset: 0x0001121F
		public void UpdateInstanceMask(Renderer renderer, uint mask)
		{
			RayTracingAccelerationStructure.UpdateInstanceMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(renderer), mask);
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x00013038 File Offset: 0x00011238
		public void UpdateInstanceID(Renderer renderer, uint instanceID)
		{
			RayTracingAccelerationStructure.UpdateInstanceIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(renderer), instanceID);
		}

		// Token: 0x06002F63 RID: 12131 RVA: 0x00013051 File Offset: 0x00011251
		public void UpdateInstancePropertyBlock(int handle, MaterialPropertyBlock properties)
		{
			RayTracingAccelerationStructure.UpdateInstancePropertyBlockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), handle, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06002F64 RID: 12132 RVA: 0x0001306A File Offset: 0x0001126A
		public ulong GetSize()
		{
			return RayTracingAccelerationStructure.GetSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06002F65 RID: 12133 RVA: 0x0001307C File Offset: 0x0001127C
		public uint GetInstanceCount()
		{
			return RayTracingAccelerationStructure.GetInstanceCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x0001308E File Offset: 0x0001128E
		public void ClearInstances()
		{
			RayTracingAccelerationStructure.ClearInstancesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06002F67 RID: 12135 RVA: 0x000130A0 File Offset: 0x000112A0
		public void AddInstanceSubMeshFlagsArray(Renderer targetRenderer, Il2CppStructArray<RayTracingSubMeshFlags> subMeshFlags, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] uint id)
		{
			RayTracingAccelerationStructure.AddInstanceSubMeshFlagsArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targetRenderer), IL2CPP.Il2CppObjectBaseToPtr(subMeshFlags), enableTriangleCulling, frontTriangleCounterClockwise, mask, id);
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x000130C5 File Offset: 0x000112C5
		public void Update_Injected(ref Vector3 relativeOrigin)
		{
			RayTracingAccelerationStructure.Update_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativeOrigin);
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x000130D8 File Offset: 0x000112D8
		public void Build_Injected(ref Vector3 relativeOrigin)
		{
			RayTracingAccelerationStructure.Build_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativeOrigin);
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x000B5D68 File Offset: 0x000B3F68
		public void AddInstance_Procedural_Deprecated_Injected(GraphicsBuffer aabbBuffer, uint numElements, Material material, ref Matrix4x4 instanceTransform, bool isCutOff, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] bool reuseBounds, [Optional] uint id)
		{
			RayTracingAccelerationStructure.AddInstance_Procedural_Deprecated_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(aabbBuffer), numElements, IL2CPP.Il2CppObjectBaseToPtr(material), ref instanceTransform, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds, id);
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x000B5DA0 File Offset: 0x000B3FA0
		public int AddInstance_Procedural_Injected(GraphicsBuffer aabbBuffer, uint aabbCount, bool dynamicData, ref Matrix4x4 matrix, Material material, bool opaqueMaterial, MaterialPropertyBlock properties, [Optional] uint mask, [Optional] uint id)
		{
			return RayTracingAccelerationStructure.AddInstance_Procedural_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(aabbBuffer), aabbCount, dynamicData, ref matrix, IL2CPP.Il2CppObjectBaseToPtr(material), opaqueMaterial, IL2CPP.Il2CppObjectBaseToPtr(properties), mask, id);
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x000130EB File Offset: 0x000112EB
		public void UpdateInstanceTransform_InstanceID_Injected(int instanceID, ref Matrix4x4 matrix)
		{
			RayTracingAccelerationStructure.UpdateInstanceTransform_InstanceID_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), instanceID, ref matrix);
		}

		// Token: 0x04002A89 RID: 10889
		private static readonly RayTracingAccelerationStructure.DestroyDelegate DestroyDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.DestroyDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::Destroy");

		// Token: 0x04002A8A RID: 10890
		private static readonly RayTracingAccelerationStructure.AddInstanceDelegate AddInstanceDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.AddInstanceDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::AddInstance");

		// Token: 0x04002A8B RID: 10891
		private static readonly RayTracingAccelerationStructure.RemoveInstance_RendererDelegate RemoveInstance_RendererDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.RemoveInstance_RendererDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::RemoveInstance_Renderer");

		// Token: 0x04002A8C RID: 10892
		private static readonly RayTracingAccelerationStructure.RemoveInstance_InstanceIDDelegate RemoveInstance_InstanceIDDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.RemoveInstance_InstanceIDDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::RemoveInstance_InstanceID");

		// Token: 0x04002A8D RID: 10893
		private static readonly RayTracingAccelerationStructure.UpdateInstanceTransform_RendererDelegate UpdateInstanceTransform_RendererDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.UpdateInstanceTransform_RendererDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::UpdateInstanceTransform_Renderer");

		// Token: 0x04002A8E RID: 10894
		private static readonly RayTracingAccelerationStructure.UpdateInstanceMaskDelegate UpdateInstanceMaskDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.UpdateInstanceMaskDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::UpdateInstanceMask");

		// Token: 0x04002A8F RID: 10895
		private static readonly RayTracingAccelerationStructure.UpdateInstanceIDDelegate UpdateInstanceIDDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.UpdateInstanceIDDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::UpdateInstanceID");

		// Token: 0x04002A90 RID: 10896
		private static readonly RayTracingAccelerationStructure.UpdateInstancePropertyBlockDelegate UpdateInstancePropertyBlockDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.UpdateInstancePropertyBlockDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::UpdateInstancePropertyBlock");

		// Token: 0x04002A91 RID: 10897
		private static readonly RayTracingAccelerationStructure.GetSizeDelegate GetSizeDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.GetSizeDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::GetSize");

		// Token: 0x04002A92 RID: 10898
		private static readonly RayTracingAccelerationStructure.GetInstanceCountDelegate GetInstanceCountDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.GetInstanceCountDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::GetInstanceCount");

		// Token: 0x04002A93 RID: 10899
		private static readonly RayTracingAccelerationStructure.ClearInstancesDelegate ClearInstancesDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.ClearInstancesDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::ClearInstances");

		// Token: 0x04002A94 RID: 10900
		private static readonly RayTracingAccelerationStructure.AddInstanceSubMeshFlagsArrayDelegate AddInstanceSubMeshFlagsArrayDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.AddInstanceSubMeshFlagsArrayDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::AddInstanceSubMeshFlagsArray");

		// Token: 0x04002A95 RID: 10901
		private static readonly RayTracingAccelerationStructure.Update_InjectedDelegate Update_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.Update_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::Update_Injected");

		// Token: 0x04002A96 RID: 10902
		private static readonly RayTracingAccelerationStructure.Build_InjectedDelegate Build_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.Build_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::Build_Injected");

		// Token: 0x04002A97 RID: 10903
		private static readonly RayTracingAccelerationStructure.AddInstance_Procedural_Deprecated_InjectedDelegate AddInstance_Procedural_Deprecated_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.AddInstance_Procedural_Deprecated_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::AddInstance_Procedural_Deprecated_Injected");

		// Token: 0x04002A98 RID: 10904
		private static readonly RayTracingAccelerationStructure.AddInstance_Procedural_InjectedDelegate AddInstance_Procedural_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.AddInstance_Procedural_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::AddInstance_Procedural_Injected");

		// Token: 0x04002A99 RID: 10905
		private static readonly RayTracingAccelerationStructure.UpdateInstanceTransform_InstanceID_InjectedDelegate UpdateInstanceTransform_InstanceID_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.UpdateInstanceTransform_InstanceID_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::UpdateInstanceTransform_InstanceID_Injected");

		// Token: 0x02000BB2 RID: 2994
		public enum RayTracingModeMask
		{
			// Token: 0x04002DBC RID: 11708
			Nothing,
			// Token: 0x04002DBD RID: 11709
			Static = 2,
			// Token: 0x04002DBE RID: 11710
			DynamicTransform = 4,
			// Token: 0x04002DBF RID: 11711
			DynamicGeometry = 8,
			// Token: 0x04002DC0 RID: 11712
			Everything = 14
		}

		// Token: 0x02000BB3 RID: 2995
		public enum ManagementMode
		{
			// Token: 0x04002DC2 RID: 11714
			Manual,
			// Token: 0x04002DC3 RID: 11715
			Automatic
		}

		// Token: 0x02000BB4 RID: 2996
		// (Invoke) Token: 0x06004055 RID: 16469
		private delegate void DestroyDelegate(IntPtr accelStruct);

		// Token: 0x02000BB5 RID: 2997
		// (Invoke) Token: 0x06004057 RID: 16471
		private delegate void AddInstanceDelegate(IntPtr @this, IntPtr targetRenderer, IntPtr subMeshMask, IntPtr subMeshTransparencyFlags, bool enableTriangleCulling, bool frontTriangleCounterClockwise, uint mask, uint id);

		// Token: 0x02000BB6 RID: 2998
		// (Invoke) Token: 0x06004059 RID: 16473
		private delegate void RemoveInstance_RendererDelegate(IntPtr @this, IntPtr targetRenderer);

		// Token: 0x02000BB7 RID: 2999
		// (Invoke) Token: 0x0600405B RID: 16475
		private delegate void RemoveInstance_InstanceIDDelegate(IntPtr @this, int instanceID);

		// Token: 0x02000BB8 RID: 3000
		// (Invoke) Token: 0x0600405D RID: 16477
		private delegate void UpdateInstanceTransform_RendererDelegate(IntPtr @this, IntPtr renderer);

		// Token: 0x02000BB9 RID: 3001
		// (Invoke) Token: 0x0600405F RID: 16479
		private delegate void UpdateInstanceMaskDelegate(IntPtr @this, IntPtr renderer, uint mask);

		// Token: 0x02000BBA RID: 3002
		// (Invoke) Token: 0x06004061 RID: 16481
		private delegate void UpdateInstanceIDDelegate(IntPtr @this, IntPtr renderer, uint instanceID);

		// Token: 0x02000BBB RID: 3003
		// (Invoke) Token: 0x06004063 RID: 16483
		private delegate void UpdateInstancePropertyBlockDelegate(IntPtr @this, int handle, IntPtr properties);

		// Token: 0x02000BBC RID: 3004
		// (Invoke) Token: 0x06004065 RID: 16485
		private delegate ulong GetSizeDelegate(IntPtr @this);

		// Token: 0x02000BBD RID: 3005
		// (Invoke) Token: 0x06004067 RID: 16487
		private delegate uint GetInstanceCountDelegate(IntPtr @this);

		// Token: 0x02000BBE RID: 3006
		// (Invoke) Token: 0x06004069 RID: 16489
		private delegate void ClearInstancesDelegate(IntPtr @this);

		// Token: 0x02000BBF RID: 3007
		// (Invoke) Token: 0x0600406B RID: 16491
		private delegate void AddInstanceSubMeshFlagsArrayDelegate(IntPtr @this, IntPtr targetRenderer, IntPtr subMeshFlags, bool enableTriangleCulling, bool frontTriangleCounterClockwise, uint mask, uint id);

		// Token: 0x02000BC0 RID: 3008
		// (Invoke) Token: 0x0600406D RID: 16493
		private delegate void Update_InjectedDelegate(IntPtr @this, IntPtr relativeOrigin);

		// Token: 0x02000BC1 RID: 3009
		// (Invoke) Token: 0x0600406F RID: 16495
		private delegate void Build_InjectedDelegate(IntPtr @this, IntPtr relativeOrigin);

		// Token: 0x02000BC2 RID: 3010
		// (Invoke) Token: 0x06004071 RID: 16497
		private delegate void AddInstance_Procedural_Deprecated_InjectedDelegate(IntPtr @this, IntPtr aabbBuffer, uint numElements, IntPtr material, IntPtr instanceTransform, bool isCutOff, bool enableTriangleCulling, bool frontTriangleCounterClockwise, uint mask, bool reuseBounds, uint id);

		// Token: 0x02000BC3 RID: 3011
		// (Invoke) Token: 0x06004073 RID: 16499
		private delegate int AddInstance_Procedural_InjectedDelegate(IntPtr @this, IntPtr aabbBuffer, uint aabbCount, bool dynamicData, IntPtr matrix, IntPtr material, bool opaqueMaterial, IntPtr properties, uint mask, uint id);

		// Token: 0x02000BC4 RID: 3012
		// (Invoke) Token: 0x06004075 RID: 16501
		private delegate void UpdateInstanceTransform_InstanceID_InjectedDelegate(IntPtr @this, int instanceID, IntPtr matrix);
	}
}
