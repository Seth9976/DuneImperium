using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.XR
{
	// Token: 0x02000017 RID: 23
	public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor>
	{
		// Token: 0x06000162 RID: 354 RVA: 0x00006558 File Offset: 0x00004758
		// Note: this type is marked as 'beforefieldinit'.
		static XRMeshSubsystem()
		{
			Il2CppClassPointerStore<XRMeshSubsystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRMeshSubsystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRMeshSubsystem>.NativeClassPtr);
			XRMeshSubsystem.NativeMethodInfoPtr_InvokeMeshReadyDelegate_Private_Void_MeshGenerationResult_Action_1_MeshGenerationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRMeshSubsystem>.NativeClassPtr, 100663383);
			XRMeshSubsystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRMeshSubsystem>.NativeClassPtr, 100663384);
			XRMeshSubsystem.get_meshDensityDelegateField = IL2CPP.ResolveICall<XRMeshSubsystem.get_meshDensityDelegate>("UnityEngine.XR.XRMeshSubsystem::get_meshDensity");
			XRMeshSubsystem.set_meshDensityDelegateField = IL2CPP.ResolveICall<XRMeshSubsystem.set_meshDensityDelegate>("UnityEngine.XR.XRMeshSubsystem::set_meshDensity");
			XRMeshSubsystem.GetUpdatedMeshTransformsDelegateField = IL2CPP.ResolveICall<XRMeshSubsystem.GetUpdatedMeshTransformsDelegate>("UnityEngine.XR.XRMeshSubsystem::GetUpdatedMeshTransforms");
			XRMeshSubsystem.GenerateMeshAsync_InjectedDelegateField = IL2CPP.ResolveICall<XRMeshSubsystem.GenerateMeshAsync_InjectedDelegate>("UnityEngine.XR.XRMeshSubsystem::GenerateMeshAsync_Injected");
			XRMeshSubsystem.SetBoundingVolume_InjectedDelegateField = IL2CPP.ResolveICall<XRMeshSubsystem.SetBoundingVolume_InjectedDelegate>("UnityEngine.XR.XRMeshSubsystem::SetBoundingVolume_Injected");
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000065FC File Offset: 0x000047FC
		[CallerCount(0)]
		public unsafe void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<MeshGenerationResult> onMeshGenerationComplete)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onMeshGenerationComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRMeshSubsystem.NativeMethodInfoPtr_InvokeMeshReadyDelegate_Private_Void_MeshGenerationResult_Action_1_MeshGenerationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00006658 File Offset: 0x00004858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258899, XrefRangeEnd = 1258902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XRMeshSubsystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRMeshSubsystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRMeshSubsystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002B86 File Offset: 0x00000D86
		public XRMeshSubsystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002B8F File Offset: 0x00000D8F
		public void GenerateMeshAsync(MeshId meshId, Mesh mesh, MeshCollider meshCollider, MeshVertexAttributes attributes, Action<MeshGenerationResult> onMeshGenerationComplete)
		{
			this.GenerateMeshAsync(meshId, mesh, meshCollider, attributes, onMeshGenerationComplete, MeshGenerationOptions.None);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002BA1 File Offset: 0x00000DA1
		public void GenerateMeshAsync(MeshId meshId, Mesh mesh, MeshCollider meshCollider, MeshVertexAttributes attributes, Action<MeshGenerationResult> onMeshGenerationComplete, MeshGenerationOptions options)
		{
			this.GenerateMeshAsync_Injected(ref meshId, mesh, meshCollider, attributes, onMeshGenerationComplete, options);
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00002BB3 File Offset: 0x00000DB3
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00002BC5 File Offset: 0x00000DC5
		public float meshDensity
		{
			get
			{
				return XRMeshSubsystem.get_meshDensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				XRMeshSubsystem.set_meshDensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002BD8 File Offset: 0x00000DD8
		public bool SetBoundingVolume(Vector3 origin, Vector3 extents)
		{
			return this.SetBoundingVolume_Injected(ref origin, ref extents);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002BE4 File Offset: 0x00000DE4
		public IntPtr GetUpdatedMeshTransforms()
		{
			return XRMeshSubsystem.GetUpdatedMeshTransformsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002BF6 File Offset: 0x00000DF6
		public void GenerateMeshAsync_Injected(ref MeshId meshId, Mesh mesh, MeshCollider meshCollider, MeshVertexAttributes attributes, Action<MeshGenerationResult> onMeshGenerationComplete, MeshGenerationOptions options)
		{
			XRMeshSubsystem.GenerateMeshAsync_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref meshId, IL2CPP.Il2CppObjectBaseToPtr(mesh), IL2CPP.Il2CppObjectBaseToPtr(meshCollider), attributes, IL2CPP.Il2CppObjectBaseToPtr(onMeshGenerationComplete), options);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002C20 File Offset: 0x00000E20
		public bool SetBoundingVolume_Injected(ref Vector3 origin, ref Vector3 extents)
		{
			return XRMeshSubsystem.SetBoundingVolume_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref origin, ref extents);
		}

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMeshReadyDelegate_Private_Void_MeshGenerationResult_Action_1_MeshGenerationResult_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000118 RID: 280
		private static readonly XRMeshSubsystem.get_meshDensityDelegate get_meshDensityDelegateField;

		// Token: 0x04000119 RID: 281
		private static readonly XRMeshSubsystem.set_meshDensityDelegate set_meshDensityDelegateField;

		// Token: 0x0400011A RID: 282
		private static readonly XRMeshSubsystem.GetUpdatedMeshTransformsDelegate GetUpdatedMeshTransformsDelegateField;

		// Token: 0x0400011B RID: 283
		private static readonly XRMeshSubsystem.GenerateMeshAsync_InjectedDelegate GenerateMeshAsync_InjectedDelegateField;

		// Token: 0x0400011C RID: 284
		private static readonly XRMeshSubsystem.SetBoundingVolume_InjectedDelegate SetBoundingVolume_InjectedDelegateField;

		// Token: 0x02000086 RID: 134
		[StructLayout(2)]
		public struct MeshTransformList
		{
			// Token: 0x06000255 RID: 597 RVA: 0x00006EE0 File Offset: 0x000050E0
			// Note: this type is marked as 'beforefieldinit'.
			static MeshTransformList()
			{
				Il2CppClassPointerStore<XRMeshSubsystem.MeshTransformList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XRMeshSubsystem>.NativeClassPtr, "MeshTransformList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRMeshSubsystem.MeshTransformList>.NativeClassPtr);
				XRMeshSubsystem.MeshTransformList.NativeFieldInfoPtr_m_Self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMeshSubsystem.MeshTransformList>.NativeClassPtr, "m_Self");
				XRMeshSubsystem.MeshTransformList.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRMeshSubsystem.MeshTransformList>.NativeClassPtr, 100663385);
				XRMeshSubsystem.MeshTransformList.NativeMethodInfoPtr_Dispose_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRMeshSubsystem.MeshTransformList>.NativeClassPtr, 100663386);
			}

			// Token: 0x06000256 RID: 598 RVA: 0x00006F48 File Offset: 0x00005148
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258895, XrefRangeEnd = 1258897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRMeshSubsystem.MeshTransformList.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000257 RID: 599 RVA: 0x00006F70 File Offset: 0x00005170
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258897, XrefRangeEnd = 1258899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Dispose(IntPtr self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref self;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRMeshSubsystem.MeshTransformList.NativeMethodInfoPtr_Dispose_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000258 RID: 600 RVA: 0x00002EAC File Offset: 0x000010AC
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XRMeshSubsystem.MeshTransformList>.NativeClassPtr, ref this));
			}

			// Token: 0x040001A2 RID: 418
			private static readonly IntPtr NativeFieldInfoPtr_m_Self;

			// Token: 0x040001A3 RID: 419
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040001A4 RID: 420
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Static_Void_IntPtr_0;

			// Token: 0x040001A5 RID: 421
			[FieldOffset(0)]
			public readonly IntPtr m_Self;
		}

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x0600025A RID: 602
		private delegate float get_meshDensityDelegate(IntPtr @this);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x0600025C RID: 604
		private delegate void set_meshDensityDelegate(IntPtr @this, float value);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x0600025E RID: 606
		private delegate IntPtr GetUpdatedMeshTransformsDelegate(IntPtr @this);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x06000260 RID: 608
		private delegate void GenerateMeshAsync_InjectedDelegate(IntPtr @this, IntPtr meshId, IntPtr mesh, IntPtr meshCollider, MeshVertexAttributes attributes, IntPtr onMeshGenerationComplete, MeshGenerationOptions options);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x06000262 RID: 610
		private delegate bool SetBoundingVolume_InjectedDelegate(IntPtr @this, IntPtr origin, IntPtr extents);
	}
}
