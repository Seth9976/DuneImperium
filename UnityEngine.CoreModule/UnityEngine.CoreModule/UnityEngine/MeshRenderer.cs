using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020000DA RID: 218
	public class MeshRenderer : Renderer
	{
		// Token: 0x06000ED9 RID: 3801 RVA: 0x00049290 File Offset: 0x00047490
		// Note: this type is marked as 'beforefieldinit'.
		static MeshRenderer()
		{
			Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MeshRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr);
			MeshRenderer.NativeMethodInfoPtr_DontStripMeshRenderer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr, 100665182);
			MeshRenderer.NativeMethodInfoPtr_get_additionalVertexStreams_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr, 100665183);
			MeshRenderer.NativeMethodInfoPtr_set_additionalVertexStreams_Public_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr, 100665184);
			MeshRenderer.NativeMethodInfoPtr_get_enlightenVertexStream_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr, 100665185);
			MeshRenderer.NativeMethodInfoPtr_set_enlightenVertexStream_Public_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr, 100665186);
			MeshRenderer.NativeMethodInfoPtr_get_subMeshStartIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr, 100665187);
			MeshRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr, 100665188);
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x0004934C File Offset: 0x0004754C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DontStripMeshRenderer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshRenderer.NativeMethodInfoPtr_DontStripMeshRenderer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x00049380 File Offset: 0x00047580
		// (set) Token: 0x06000EDC RID: 3804 RVA: 0x000493C0 File Offset: 0x000475C0
		public unsafe Mesh additionalVertexStreams
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653691, XrefRangeEnd = 653693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshRenderer.NativeMethodInfoPtr_get_additionalVertexStreams_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653693, XrefRangeEnd = 653695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshRenderer.NativeMethodInfoPtr_set_additionalVertexStreams_Public_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x00049404 File Offset: 0x00047604
		// (set) Token: 0x06000EDE RID: 3806 RVA: 0x00049444 File Offset: 0x00047644
		public unsafe Mesh enlightenVertexStream
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653695, XrefRangeEnd = 653697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshRenderer.NativeMethodInfoPtr_get_enlightenVertexStream_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653697, XrefRangeEnd = 653699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshRenderer.NativeMethodInfoPtr_set_enlightenVertexStream_Public_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x00049488 File Offset: 0x00047688
		public unsafe int subMeshStartIndex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653699, XrefRangeEnd = 653701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshRenderer.NativeMethodInfoPtr_get_subMeshStartIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x000494C4 File Offset: 0x000476C4
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0000739E File Offset: 0x0000559E
		public MeshRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr_DontStripMeshRenderer_Private_Void_0;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeMethodInfoPtr_get_additionalVertexStreams_Public_get_Mesh_0;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeMethodInfoPtr_set_additionalVertexStreams_Public_set_Void_Mesh_0;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeMethodInfoPtr_get_enlightenVertexStream_Public_get_Mesh_0;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeMethodInfoPtr_set_enlightenVertexStream_Public_set_Void_Mesh_0;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeMethodInfoPtr_get_subMeshStartIndex_Public_get_Int32_0;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
