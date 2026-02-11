using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020000D9 RID: 217
	public class SkinnedMeshRenderer : Renderer
	{
		// Token: 0x06000EBE RID: 3774 RVA: 0x00048A0C File Offset: 0x00046C0C
		// Note: this type is marked as 'beforefieldinit'.
		static SkinnedMeshRenderer()
		{
			Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SkinnedMeshRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr);
			SkinnedMeshRenderer.NativeMethodInfoPtr_get_quality_Public_get_SkinQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665157);
			SkinnedMeshRenderer.NativeMethodInfoPtr_set_quality_Public_set_Void_SkinQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665158);
			SkinnedMeshRenderer.NativeMethodInfoPtr_get_updateWhenOffscreen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665159);
			SkinnedMeshRenderer.NativeMethodInfoPtr_set_updateWhenOffscreen_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665160);
			SkinnedMeshRenderer.NativeMethodInfoPtr_get_forceMatrixRecalculationPerRender_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665161);
			SkinnedMeshRenderer.NativeMethodInfoPtr_set_forceMatrixRecalculationPerRender_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665162);
			SkinnedMeshRenderer.NativeMethodInfoPtr_get_rootBone_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665163);
			SkinnedMeshRenderer.NativeMethodInfoPtr_set_rootBone_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665164);
			SkinnedMeshRenderer.NativeMethodInfoPtr_get_bones_Public_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665165);
			SkinnedMeshRenderer.NativeMethodInfoPtr_set_bones_Public_set_Void_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665166);
			SkinnedMeshRenderer.NativeMethodInfoPtr_get_sharedMesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665167);
			SkinnedMeshRenderer.NativeMethodInfoPtr_set_sharedMesh_Public_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665168);
			SkinnedMeshRenderer.NativeMethodInfoPtr_get_skinnedMotionVectors_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665169);
			SkinnedMeshRenderer.NativeMethodInfoPtr_set_skinnedMotionVectors_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665170);
			SkinnedMeshRenderer.NativeMethodInfoPtr_GetBlendShapeWeight_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665171);
			SkinnedMeshRenderer.NativeMethodInfoPtr_SetBlendShapeWeight_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665172);
			SkinnedMeshRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665173);
			SkinnedMeshRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665174);
			SkinnedMeshRenderer.NativeMethodInfoPtr_GetVertexBuffer_Public_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665175);
			SkinnedMeshRenderer.NativeMethodInfoPtr_GetPreviousVertexBuffer_Public_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665176);
			SkinnedMeshRenderer.NativeMethodInfoPtr_GetVertexBufferImpl_Private_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665177);
			SkinnedMeshRenderer.NativeMethodInfoPtr_GetPreviousVertexBufferImpl_Private_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665178);
			SkinnedMeshRenderer.NativeMethodInfoPtr_get_vertexBufferTarget_Public_get_Target_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665179);
			SkinnedMeshRenderer.NativeMethodInfoPtr_set_vertexBufferTarget_Public_set_Void_Target_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665180);
			SkinnedMeshRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr, 100665181);
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x00048C30 File Offset: 0x00046E30
		// (set) Token: 0x06000EC0 RID: 3776 RVA: 0x00048C6C File Offset: 0x00046E6C
		public unsafe SkinQuality quality
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653625, XrefRangeEnd = 653627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_quality_Public_get_SkinQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653627, XrefRangeEnd = 653629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_quality_Public_set_Void_SkinQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x00048CAC File Offset: 0x00046EAC
		// (set) Token: 0x06000EC2 RID: 3778 RVA: 0x00048CE8 File Offset: 0x00046EE8
		public unsafe bool updateWhenOffscreen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653629, XrefRangeEnd = 653631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_updateWhenOffscreen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653631, XrefRangeEnd = 653633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_updateWhenOffscreen_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x00048D28 File Offset: 0x00046F28
		// (set) Token: 0x06000EC4 RID: 3780 RVA: 0x00048D64 File Offset: 0x00046F64
		public unsafe bool forceMatrixRecalculationPerRender
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653633, XrefRangeEnd = 653635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_forceMatrixRecalculationPerRender_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653635, XrefRangeEnd = 653637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_forceMatrixRecalculationPerRender_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x00048DA4 File Offset: 0x00046FA4
		// (set) Token: 0x06000EC6 RID: 3782 RVA: 0x00048DE4 File Offset: 0x00046FE4
		public unsafe Transform rootBone
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653637, XrefRangeEnd = 653639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_rootBone_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653639, XrefRangeEnd = 653641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_rootBone_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x00048E28 File Offset: 0x00047028
		// (set) Token: 0x06000EC8 RID: 3784 RVA: 0x00048E68 File Offset: 0x00047068
		public unsafe Il2CppReferenceArray<Transform> bones
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653641, XrefRangeEnd = 653643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_bones_Public_get_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653643, XrefRangeEnd = 653645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_bones_Public_set_Void_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x00048EAC File Offset: 0x000470AC
		// (set) Token: 0x06000ECA RID: 3786 RVA: 0x00048EEC File Offset: 0x000470EC
		public unsafe Mesh sharedMesh
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653645, XrefRangeEnd = 653647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_sharedMesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653647, XrefRangeEnd = 653649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_sharedMesh_Public_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x00048F30 File Offset: 0x00047130
		// (set) Token: 0x06000ECC RID: 3788 RVA: 0x00048F6C File Offset: 0x0004716C
		public unsafe bool skinnedMotionVectors
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653649, XrefRangeEnd = 653651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_skinnedMotionVectors_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653651, XrefRangeEnd = 653653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_skinnedMotionVectors_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x00048FAC File Offset: 0x000471AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653653, XrefRangeEnd = 653655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetBlendShapeWeight(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_GetBlendShapeWeight_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00048FF8 File Offset: 0x000471F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653655, XrefRangeEnd = 653657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBlendShapeWeight(int index, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_SetBlendShapeWeight_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00049044 File Offset: 0x00047244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653657, XrefRangeEnd = 653659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BakeMesh(Mesh mesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x00049088 File Offset: 0x00047288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653659, XrefRangeEnd = 653661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BakeMesh(Mesh mesh, bool useScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x000490D8 File Offset: 0x000472D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653661, XrefRangeEnd = 653672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsBuffer GetVertexBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_GetVertexBuffer_Public_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr3) : null;
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00049118 File Offset: 0x00047318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653672, XrefRangeEnd = 653683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsBuffer GetPreviousVertexBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_GetPreviousVertexBuffer_Public_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr3) : null;
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00049158 File Offset: 0x00047358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653683, XrefRangeEnd = 653685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsBuffer GetVertexBufferImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_GetVertexBufferImpl_Private_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr3) : null;
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00049198 File Offset: 0x00047398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653685, XrefRangeEnd = 653687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsBuffer GetPreviousVertexBufferImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_GetPreviousVertexBufferImpl_Private_GraphicsBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr3) : null;
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x000491D8 File Offset: 0x000473D8
		// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x00049214 File Offset: 0x00047414
		public unsafe GraphicsBuffer.Target vertexBufferTarget
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653687, XrefRangeEnd = 653689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_get_vertexBufferTarget_Public_get_Target_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653689, XrefRangeEnd = 653691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr_set_vertexBufferTarget_Public_set_Void_Target_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00049254 File Offset: 0x00047454
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkinnedMeshRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkinnedMeshRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkinnedMeshRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x00007395 File Offset: 0x00005595
		public SkinnedMeshRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr_get_quality_Public_get_SkinQuality_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr_set_quality_Public_set_Void_SkinQuality_0;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeMethodInfoPtr_get_updateWhenOffscreen_Public_get_Boolean_0;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr_set_updateWhenOffscreen_Public_set_Void_Boolean_0;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr_get_forceMatrixRecalculationPerRender_Public_get_Boolean_0;

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeMethodInfoPtr_set_forceMatrixRecalculationPerRender_Public_set_Void_Boolean_0;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeMethodInfoPtr_get_rootBone_Public_get_Transform_0;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeMethodInfoPtr_set_rootBone_Public_set_Void_Transform_0;

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeMethodInfoPtr_get_bones_Public_get_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeMethodInfoPtr_set_bones_Public_set_Void_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeMethodInfoPtr_get_sharedMesh_Public_get_Mesh_0;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeMethodInfoPtr_set_sharedMesh_Public_set_Void_Mesh_0;

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeMethodInfoPtr_get_skinnedMotionVectors_Public_get_Boolean_0;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeMethodInfoPtr_set_skinnedMotionVectors_Public_set_Void_Boolean_0;

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeMethodInfoPtr_GetBlendShapeWeight_Public_Single_Int32_0;

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeMethodInfoPtr_SetBlendShapeWeight_Public_Void_Int32_Single_0;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_0;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Boolean_0;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexBuffer_Public_GraphicsBuffer_0;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousVertexBuffer_Public_GraphicsBuffer_0;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexBufferImpl_Private_GraphicsBuffer_0;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousVertexBufferImpl_Private_GraphicsBuffer_0;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeMethodInfoPtr_get_vertexBufferTarget_Public_get_Target_0;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeMethodInfoPtr_set_vertexBufferTarget_Public_set_Void_Target_0;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
