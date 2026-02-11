using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal.LibTessDotNet
{
	// Token: 0x0200010A RID: 266
	public class Mesh : MeshUtils.Pooled<Mesh>
	{
		// Token: 0x06001647 RID: 5703 RVA: 0x0005FA3C File Offset: 0x0005DC3C
		// Note: this type is marked as 'beforefieldinit'.
		static Mesh()
		{
			Il2CppClassPointerStore<Mesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.LibTessDotNet", "Mesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mesh>.NativeClassPtr);
			Mesh.NativeFieldInfoPtr__vHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mesh>.NativeClassPtr, "_vHead");
			Mesh.NativeFieldInfoPtr__fHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mesh>.NativeClassPtr, "_fHead");
			Mesh.NativeFieldInfoPtr__eHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mesh>.NativeClassPtr, "_eHead");
			Mesh.NativeFieldInfoPtr__eHeadSym = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mesh>.NativeClassPtr, "_eHeadSym");
			Mesh.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665879);
			Mesh.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665880);
			Mesh.NativeMethodInfoPtr_OnFree_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665881);
			Mesh.NativeMethodInfoPtr_MakeEdge_Public_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665882);
			Mesh.NativeMethodInfoPtr_Splice_Public_Void_Edge_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665883);
			Mesh.NativeMethodInfoPtr_Delete_Public_Void_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665884);
			Mesh.NativeMethodInfoPtr_AddEdgeVertex_Public_Edge_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665885);
			Mesh.NativeMethodInfoPtr_SplitEdge_Public_Edge_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665886);
			Mesh.NativeMethodInfoPtr_Connect_Public_Edge_Edge_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665887);
			Mesh.NativeMethodInfoPtr_ZapFace_Public_Void_Face_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665888);
			Mesh.NativeMethodInfoPtr_MergeConvexFaces_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665889);
			Mesh.NativeMethodInfoPtr_Check_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mesh>.NativeClassPtr, 100665890);
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x0005FBAC File Offset: 0x0005DDAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 623096, RefRangeEnd = 623097, XrefRangeStart = 623049, XrefRangeEnd = 623096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mesh()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Mesh>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x0005FBE8 File Offset: 0x0005DDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623097, XrefRangeEnd = 623101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Mesh.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x0005FC24 File Offset: 0x0005DE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623101, XrefRangeEnd = 623110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnFree()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Mesh.NativeMethodInfoPtr_OnFree_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x0005FC60 File Offset: 0x0005DE60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 623114, RefRangeEnd = 623115, XrefRangeStart = 623110, XrefRangeEnd = 623114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshUtils.Edge MakeEdge()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_MakeEdge_Public_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr3) : null;
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x0005FCA0 File Offset: 0x0005DEA0
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 623125, RefRangeEnd = 623149, XrefRangeStart = 623115, XrefRangeEnd = 623125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Splice(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eOrg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eDst);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_Splice_Public_Void_Edge_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x0005FCF4 File Offset: 0x0005DEF4
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 623170, RefRangeEnd = 623192, XrefRangeStart = 623149, XrefRangeEnd = 623170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delete(MeshUtils.Edge eDel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eDel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_Delete_Public_Void_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x0005FD38 File Offset: 0x0005DF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623192, XrefRangeEnd = 623201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshUtils.Edge AddEdgeVertex(MeshUtils.Edge eOrg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eOrg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_AddEdgeVertex_Public_Edge_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr3) : null;
			}
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x0005FD88 File Offset: 0x0005DF88
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 623221, RefRangeEnd = 623227, XrefRangeStart = 623201, XrefRangeEnd = 623221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshUtils.Edge SplitEdge(MeshUtils.Edge eOrg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eOrg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_SplitEdge_Public_Edge_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr3) : null;
			}
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x0005FDD8 File Offset: 0x0005DFD8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 623243, RefRangeEnd = 623253, XrefRangeStart = 623227, XrefRangeEnd = 623243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshUtils.Edge Connect(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eOrg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eDst);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_Connect_Public_Edge_Edge_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr3) : null;
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x0005FE3C File Offset: 0x0005E03C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 623285, RefRangeEnd = 623286, XrefRangeStart = 623253, XrefRangeEnd = 623285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ZapFace(MeshUtils.Face fZap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fZap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_ZapFace_Public_Void_Face_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x0005FE80 File Offset: 0x0005E080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 623289, RefRangeEnd = 623290, XrefRangeStart = 623286, XrefRangeEnd = 623289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MergeConvexFaces(int maxVertsPerFace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxVertsPerFace;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_MergeConvexFaces_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x0005FEC0 File Offset: 0x0005E0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623290, XrefRangeEnd = 623293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Check()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mesh.NativeMethodInfoPtr_Check_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x0000CEB2 File Offset: 0x0000B0B2
		public Mesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001655 RID: 5717 RVA: 0x0005FEF4 File Offset: 0x0005E0F4
		// (set) Token: 0x06001656 RID: 5718 RVA: 0x0000CEBB File Offset: 0x0000B0BB
		public unsafe MeshUtils.Vertex _vHead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mesh.NativeFieldInfoPtr__vHead);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshUtils.Vertex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mesh.NativeFieldInfoPtr__vHead), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001657 RID: 5719 RVA: 0x0005FF24 File Offset: 0x0005E124
		// (set) Token: 0x06001658 RID: 5720 RVA: 0x0000CEDA File Offset: 0x0000B0DA
		public unsafe MeshUtils.Face _fHead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mesh.NativeFieldInfoPtr__fHead);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshUtils.Face>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mesh.NativeFieldInfoPtr__fHead), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x0005FF54 File Offset: 0x0005E154
		// (set) Token: 0x0600165A RID: 5722 RVA: 0x0000CEF9 File Offset: 0x0000B0F9
		public unsafe MeshUtils.Edge _eHead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mesh.NativeFieldInfoPtr__eHead);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mesh.NativeFieldInfoPtr__eHead), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x0600165B RID: 5723 RVA: 0x0005FF84 File Offset: 0x0005E184
		// (set) Token: 0x0600165C RID: 5724 RVA: 0x0000CF18 File Offset: 0x0000B118
		public unsafe MeshUtils.Edge _eHeadSym
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mesh.NativeFieldInfoPtr__eHeadSym);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mesh.NativeFieldInfoPtr__eHeadSym), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeFieldInfoPtr__vHead;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeFieldInfoPtr__fHead;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeFieldInfoPtr__eHead;

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeFieldInfoPtr__eHeadSym;

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeMethodInfoPtr_OnFree_Public_Virtual_Void_0;

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeMethodInfoPtr_MakeEdge_Public_Edge_0;

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeMethodInfoPtr_Splice_Public_Void_Edge_Edge_0;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Void_Edge_0;

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeMethodInfoPtr_AddEdgeVertex_Public_Edge_Edge_0;

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeMethodInfoPtr_SplitEdge_Public_Edge_Edge_0;

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Edge_Edge_Edge_0;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeMethodInfoPtr_ZapFace_Public_Void_Face_0;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeMethodInfoPtr_MergeConvexFaces_Public_Void_Int32_0;

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Void_0;
	}
}
