using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x0200003E RID: 62
	public class VertexHelper : Object
	{
		// Token: 0x060007EC RID: 2028 RVA: 0x00026138 File Offset: 0x00024338
		// Note: this type is marked as 'beforefieldinit'.
		static VertexHelper()
		{
			Il2CppClassPointerStore<VertexHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "VertexHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr);
			VertexHelper.NativeFieldInfoPtr_m_Positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Positions");
			VertexHelper.NativeFieldInfoPtr_m_Colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Colors");
			VertexHelper.NativeFieldInfoPtr_m_Uv0S = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Uv0S");
			VertexHelper.NativeFieldInfoPtr_m_Uv1S = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Uv1S");
			VertexHelper.NativeFieldInfoPtr_m_Uv2S = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Uv2S");
			VertexHelper.NativeFieldInfoPtr_m_Uv3S = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Uv3S");
			VertexHelper.NativeFieldInfoPtr_m_Normals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Normals");
			VertexHelper.NativeFieldInfoPtr_m_Tangents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Tangents");
			VertexHelper.NativeFieldInfoPtr_m_Indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_Indices");
			VertexHelper.NativeFieldInfoPtr_s_DefaultTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "s_DefaultTangent");
			VertexHelper.NativeFieldInfoPtr_s_DefaultNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "s_DefaultNormal");
			VertexHelper.NativeFieldInfoPtr_m_ListsInitalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, "m_ListsInitalized");
			VertexHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664597);
			VertexHelper.NativeMethodInfoPtr__ctor_Public_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664598);
			VertexHelper.NativeMethodInfoPtr_InitializeListIfRequired_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664599);
			VertexHelper.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664600);
			VertexHelper.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664601);
			VertexHelper.NativeMethodInfoPtr_get_currentVertCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664602);
			VertexHelper.NativeMethodInfoPtr_get_currentIndexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664603);
			VertexHelper.NativeMethodInfoPtr_PopulateUIVertex_Public_Void_byref_UIVertex_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664604);
			VertexHelper.NativeMethodInfoPtr_SetUIVertex_Public_Void_UIVertex_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664605);
			VertexHelper.NativeMethodInfoPtr_FillMesh_Public_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664606);
			VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_Vector4_Vector4_Vector4_Vector3_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664607);
			VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_Vector4_Vector3_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664608);
			VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664609);
			VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664610);
			VertexHelper.NativeMethodInfoPtr_AddTriangle_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664611);
			VertexHelper.NativeMethodInfoPtr_AddUIVertexQuad_Public_Void_Il2CppStructArray_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664612);
			VertexHelper.NativeMethodInfoPtr_AddUIVertexStream_Public_Void_List_1_UIVertex_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664613);
			VertexHelper.NativeMethodInfoPtr_AddUIVertexTriangleStream_Public_Void_List_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664614);
			VertexHelper.NativeMethodInfoPtr_GetUIVertexStream_Public_Void_List_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr, 100664615);
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x000263D4 File Offset: 0x000245D4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VertexHelper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00026410 File Offset: 0x00024610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1093547, RefRangeEnd = 1093548, XrefRangeStart = 1093507, XrefRangeEnd = 1093547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VertexHelper(Mesh m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VertexHelper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr__ctor_Public_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0002645C File Offset: 0x0002465C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1093591, RefRangeEnd = 1093603, XrefRangeStart = 1093548, XrefRangeEnd = 1093591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeListIfRequired()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_InitializeListIfRequired_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00026490 File Offset: 0x00024690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093603, XrefRangeEnd = 1093646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x000264C4 File Offset: 0x000246C4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1093650, RefRangeEnd = 1093661, XrefRangeStart = 1093646, XrefRangeEnd = 1093650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x000264F8 File Offset: 0x000246F8
		public unsafe int currentVertCount
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1093662, RefRangeEnd = 1093667, XrefRangeStart = 1093661, XrefRangeEnd = 1093662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_get_currentVertCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x00026534 File Offset: 0x00024734
		public unsafe int currentIndexCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093667, XrefRangeEnd = 1093668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_get_currentIndexCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00026570 File Offset: 0x00024770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1093688, RefRangeEnd = 1093689, XrefRangeStart = 1093668, XrefRangeEnd = 1093688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateUIVertex(ref UIVertex vertex, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &vertex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_PopulateUIVertex_Public_Void_byref_UIVertex_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x000265BC File Offset: 0x000247BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1093709, RefRangeEnd = 1093710, XrefRangeStart = 1093689, XrefRangeEnd = 1093709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUIVertex(UIVertex vertex, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vertex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_SetUIVertex_Public_Void_UIVertex_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00026608 File Offset: 0x00024808
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1093730, RefRangeEnd = 1093737, XrefRangeStart = 1093710, XrefRangeEnd = 1093730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillMesh(Mesh mesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_FillMesh_Public_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x0002664C File Offset: 0x0002484C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1093764, RefRangeEnd = 1093768, XrefRangeStart = 1093737, XrefRangeEnd = 1093764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv0;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv1;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv3;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normal;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tangent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_Vector4_Vector4_Vector4_Vector3_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x000266EC File Offset: 0x000248EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093768, XrefRangeEnd = 1093773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv0;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv1;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normal;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tangent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_Vector4_Vector3_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00026770 File Offset: 0x00024970
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1093784, RefRangeEnd = 1093802, XrefRangeStart = 1093773, XrefRangeEnd = 1093784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddVert(Vector3 position, Color32 color, Vector4 uv0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv0;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x000267CC File Offset: 0x000249CC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1093803, RefRangeEnd = 1093811, XrefRangeStart = 1093802, XrefRangeEnd = 1093803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddVert(UIVertex v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddVert_Public_Void_UIVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x0002680C File Offset: 0x00024A0C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1093821, RefRangeEnd = 1093838, XrefRangeStart = 1093811, XrefRangeEnd = 1093821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTriangle(int idx0, int idx1, int idx2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddTriangle_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00026868 File Offset: 0x00024A68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1093847, RefRangeEnd = 1093851, XrefRangeStart = 1093838, XrefRangeEnd = 1093847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUIVertexQuad(Il2CppStructArray<UIVertex> verts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddUIVertexQuad_Public_Void_Il2CppStructArray_1_UIVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x000268AC File Offset: 0x00024AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093851, XrefRangeEnd = 1093856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUIVertexStream(List<UIVertex> verts, List<int> indices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddUIVertexStream_Public_Void_List_1_UIVertex_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00026900 File Offset: 0x00024B00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1093858, RefRangeEnd = 1093859, XrefRangeStart = 1093856, XrefRangeEnd = 1093858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUIVertexTriangleStream(List<UIVertex> verts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(verts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_AddUIVertexTriangleStream_Public_Void_List_1_UIVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00026944 File Offset: 0x00024B44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1093861, RefRangeEnd = 1093862, XrefRangeStart = 1093859, XrefRangeEnd = 1093861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetUIVertexStream(List<UIVertex> stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexHelper.NativeMethodInfoPtr_GetUIVertexStream_Public_Void_List_1_UIVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00004B77 File Offset: 0x00002D77
		public VertexHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x00026988 File Offset: 0x00024B88
		// (set) Token: 0x06000802 RID: 2050 RVA: 0x00004B80 File Offset: 0x00002D80
		public unsafe List<Vector3> m_Positions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Positions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Positions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x000269B8 File Offset: 0x00024BB8
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x00004B9F File Offset: 0x00002D9F
		public unsafe List<Color32> m_Colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Color32>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x000269E8 File Offset: 0x00024BE8
		// (set) Token: 0x06000806 RID: 2054 RVA: 0x00004BBE File Offset: 0x00002DBE
		public unsafe List<Vector4> m_Uv0S
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv0S);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv0S), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x00026A18 File Offset: 0x00024C18
		// (set) Token: 0x06000808 RID: 2056 RVA: 0x00004BDD File Offset: 0x00002DDD
		public unsafe List<Vector4> m_Uv1S
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv1S);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv1S), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x00026A48 File Offset: 0x00024C48
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x00004BFC File Offset: 0x00002DFC
		public unsafe List<Vector4> m_Uv2S
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv2S);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv2S), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x00026A78 File Offset: 0x00024C78
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x00004C1B File Offset: 0x00002E1B
		public unsafe List<Vector4> m_Uv3S
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv3S);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Uv3S), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x00026AA8 File Offset: 0x00024CA8
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x00004C3A File Offset: 0x00002E3A
		public unsafe List<Vector3> m_Normals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Normals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Normals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00026AD8 File Offset: 0x00024CD8
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x00004C59 File Offset: 0x00002E59
		public unsafe List<Vector4> m_Tangents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Tangents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Tangents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x00026B08 File Offset: 0x00024D08
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x00004C78 File Offset: 0x00002E78
		public unsafe List<int> m_Indices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Indices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_Indices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x00026B38 File Offset: 0x00024D38
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x00004C97 File Offset: 0x00002E97
		public unsafe static Vector4 s_DefaultTangent
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(VertexHelper.NativeFieldInfoPtr_s_DefaultTangent, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VertexHelper.NativeFieldInfoPtr_s_DefaultTangent, (void*)(&value));
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x00026B54 File Offset: 0x00024D54
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x00004CA5 File Offset: 0x00002EA5
		public unsafe static Vector3 s_DefaultNormal
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(VertexHelper.NativeFieldInfoPtr_s_DefaultNormal, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VertexHelper.NativeFieldInfoPtr_s_DefaultNormal, (void*)(&value));
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x00026B70 File Offset: 0x00024D70
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x00004CB3 File Offset: 0x00002EB3
		public unsafe bool m_ListsInitalized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_ListsInitalized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VertexHelper.NativeFieldInfoPtr_m_ListsInitalized)) = value;
			}
		}

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeFieldInfoPtr_m_Positions;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeFieldInfoPtr_m_Colors;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeFieldInfoPtr_m_Uv0S;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeFieldInfoPtr_m_Uv1S;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeFieldInfoPtr_m_Uv2S;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeFieldInfoPtr_m_Uv3S;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeFieldInfoPtr_m_Normals;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeFieldInfoPtr_m_Tangents;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeFieldInfoPtr_m_Indices;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultTangent;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultNormal;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeFieldInfoPtr_m_ListsInitalized;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Mesh_0;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr_InitializeListIfRequired_Private_Void_0;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr_get_currentVertCount_Public_get_Int32_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr_get_currentIndexCount_Public_get_Int32_0;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr_PopulateUIVertex_Public_Void_byref_UIVertex_Int32_0;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr_SetUIVertex_Public_Void_UIVertex_Int32_0;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeMethodInfoPtr_FillMesh_Public_Void_Mesh_0;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_Vector4_Vector4_Vector4_Vector3_Vector4_0;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_Vector4_Vector3_Vector4_0;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr_AddVert_Public_Void_Vector3_Color32_Vector4_0;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_AddVert_Public_Void_UIVertex_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_AddTriangle_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr_AddUIVertexQuad_Public_Void_Il2CppStructArray_1_UIVertex_0;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr_AddUIVertexStream_Public_Void_List_1_UIVertex_List_1_Int32_0;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeMethodInfoPtr_AddUIVertexTriangleStream_Public_Void_List_1_UIVertex_0;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeMethodInfoPtr_GetUIVertexStream_Public_Void_List_1_UIVertex_0;
	}
}
