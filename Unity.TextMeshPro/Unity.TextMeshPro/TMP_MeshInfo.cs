using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000047 RID: 71
	public sealed class TMP_MeshInfo : ValueType
	{
		// Token: 0x060007D7 RID: 2007 RVA: 0x00024930 File Offset: 0x00022B30
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_MeshInfo()
		{
			Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_MeshInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr);
			TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "s_DefaultColor");
			TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "s_DefaultNormal");
			TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "s_DefaultTangent");
			TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "s_DefaultBounds");
			TMP_MeshInfo.NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "mesh");
			TMP_MeshInfo.NativeFieldInfoPtr_vertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "vertexCount");
			TMP_MeshInfo.NativeFieldInfoPtr_vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "vertices");
			TMP_MeshInfo.NativeFieldInfoPtr_normals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "normals");
			TMP_MeshInfo.NativeFieldInfoPtr_tangents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "tangents");
			TMP_MeshInfo.NativeFieldInfoPtr_uvs0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "uvs0");
			TMP_MeshInfo.NativeFieldInfoPtr_uvs2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "uvs2");
			TMP_MeshInfo.NativeFieldInfoPtr_colors32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "colors32");
			TMP_MeshInfo.NativeFieldInfoPtr_triangles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "triangles");
			TMP_MeshInfo.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, "material");
			TMP_MeshInfo.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664236);
			TMP_MeshInfo.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664237);
			TMP_MeshInfo.NativeMethodInfoPtr_ResizeMeshInfo_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664238);
			TMP_MeshInfo.NativeMethodInfoPtr_ResizeMeshInfo_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664239);
			TMP_MeshInfo.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664240);
			TMP_MeshInfo.NativeMethodInfoPtr_Clear_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664241);
			TMP_MeshInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664242);
			TMP_MeshInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664243);
			TMP_MeshInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664244);
			TMP_MeshInfo.NativeMethodInfoPtr_SortGeometry_Public_Void_VertexSortingOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664245);
			TMP_MeshInfo.NativeMethodInfoPtr_SortGeometry_Public_Void_IList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664246);
			TMP_MeshInfo.NativeMethodInfoPtr_SwapVertexData_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr, 100664247);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00024B68 File Offset: 0x00022D68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1044574, RefRangeEnd = 1044578, XrefRangeStart = 1044516, XrefRangeEnd = 1044574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_MeshInfo(Mesh mesh, int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00024BC8 File Offset: 0x00022DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044578, XrefRangeEnd = 1044636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_MeshInfo(Mesh mesh, int size, bool isVolumetric)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVolumetric;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr__ctor_Public_Void_Mesh_Int32_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00024C34 File Offset: 0x00022E34
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1044670, RefRangeEnd = 1044677, XrefRangeStart = 1044636, XrefRangeEnd = 1044670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeMeshInfo(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_ResizeMeshInfo_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00024C78 File Offset: 0x00022E78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1044721, RefRangeEnd = 1044722, XrefRangeStart = 1044677, XrefRangeEnd = 1044721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeMeshInfo(int size, bool isVolumetric)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVolumetric;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_ResizeMeshInfo_Public_Void_Int32_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00024CCC File Offset: 0x00022ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044722, XrefRangeEnd = 1044728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00024D04 File Offset: 0x00022F04
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1044742, RefRangeEnd = 1044746, XrefRangeStart = 1044728, XrefRangeEnd = 1044742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(bool uploadChanges)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uploadChanges;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_Clear_Public_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00024D48 File Offset: 0x00022F48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1044747, RefRangeEnd = 1044751, XrefRangeStart = 1044746, XrefRangeEnd = 1044747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearUnusedVertices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00024D80 File Offset: 0x00022F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044751, XrefRangeEnd = 1044752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearUnusedVertices(int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00024DC4 File Offset: 0x00022FC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1044758, RefRangeEnd = 1044759, XrefRangeStart = 1044752, XrefRangeEnd = 1044758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearUnusedVertices(int startIndex, bool updateMesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateMesh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Int32_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00024E18 File Offset: 0x00023018
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1044763, RefRangeEnd = 1044767, XrefRangeStart = 1044759, XrefRangeEnd = 1044763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortGeometry(VertexSortingOrder order)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref order;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_SortGeometry_Public_Void_VertexSortingOrder_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00024E5C File Offset: 0x0002305C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044767, XrefRangeEnd = 1044779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortGeometry(IList<int> sortingOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sortingOrder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_SortGeometry_Public_Void_IList_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00024EA4 File Offset: 0x000230A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1044779, RefRangeEnd = 1044781, XrefRangeStart = 1044779, XrefRangeEnd = 1044779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwapVertexData(int src, int dst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref src;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_MeshInfo.NativeMethodInfoPtr_SwapVertexData_Public_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00005A47 File Offset: 0x00003C47
		public TMP_MeshInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00005A50 File Offset: 0x00003C50
		public TMP_MeshInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_MeshInfo>.NativeClassPtr))
		{
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x00024EF8 File Offset: 0x000230F8
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x00005A62 File Offset: 0x00003C62
		public unsafe static Color32 s_DefaultColor
		{
			get
			{
				Color32 color;
				IL2CPP.il2cpp_field_static_get_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultColor, (void*)(&value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x00024F14 File Offset: 0x00023114
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00005A70 File Offset: 0x00003C70
		public unsafe static Vector3 s_DefaultNormal
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultNormal, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultNormal, (void*)(&value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x00024F30 File Offset: 0x00023130
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x00005A7E File Offset: 0x00003C7E
		public unsafe static Vector4 s_DefaultTangent
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultTangent, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultTangent, (void*)(&value));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x00024F4C File Offset: 0x0002314C
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x00005A8C File Offset: 0x00003C8C
		public unsafe static Bounds s_DefaultBounds
		{
			get
			{
				Bounds bounds;
				IL2CPP.il2cpp_field_static_get_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultBounds, (void*)(&bounds));
				return bounds;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_MeshInfo.NativeFieldInfoPtr_s_DefaultBounds, (void*)(&value));
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x00024F68 File Offset: 0x00023168
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x00005A9A File Offset: 0x00003C9A
		public unsafe Mesh mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x00024F98 File Offset: 0x00023198
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x00005AB9 File Offset: 0x00003CB9
		public unsafe int vertexCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_vertexCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_vertexCount)) = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x00024FC0 File Offset: 0x000231C0
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x00005AD4 File Offset: 0x00003CD4
		public unsafe Il2CppStructArray<Vector3> vertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_vertices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_vertices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x00024FF0 File Offset: 0x000231F0
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x00005AF3 File Offset: 0x00003CF3
		public unsafe Il2CppStructArray<Vector3> normals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_normals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_normals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00025020 File Offset: 0x00023220
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x00005B12 File Offset: 0x00003D12
		public unsafe Il2CppStructArray<Vector4> tangents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_tangents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_tangents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x00025050 File Offset: 0x00023250
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x00005B31 File Offset: 0x00003D31
		public unsafe Il2CppStructArray<Vector2> uvs0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_uvs0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_uvs0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x00025080 File Offset: 0x00023280
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x00005B50 File Offset: 0x00003D50
		public unsafe Il2CppStructArray<Vector2> uvs2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_uvs2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_uvs2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x000250B0 File Offset: 0x000232B0
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x00005B6F File Offset: 0x00003D6F
		public unsafe Il2CppStructArray<Color32> colors32
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_colors32);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_colors32), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x000250E0 File Offset: 0x000232E0
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x00005B8E File Offset: 0x00003D8E
		public unsafe Il2CppStructArray<int> triangles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_triangles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_triangles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00025110 File Offset: 0x00023310
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x00005BAD File Offset: 0x00003DAD
		public unsafe Material material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_MeshInfo.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultColor;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultNormal;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultTangent;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultBounds;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeFieldInfoPtr_mesh;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeFieldInfoPtr_vertexCount;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeFieldInfoPtr_vertices;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeFieldInfoPtr_normals;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeFieldInfoPtr_tangents;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeFieldInfoPtr_uvs0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeFieldInfoPtr_uvs2;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeFieldInfoPtr_colors32;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeFieldInfoPtr_triangles;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Mesh_Int32_0;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Mesh_Int32_Boolean_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_ResizeMeshInfo_Public_Void_Int32_0;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_ResizeMeshInfo_Public_Void_Int32_Boolean_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_Boolean_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_0;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Int32_0;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr_ClearUnusedVertices_Public_Void_Int32_Boolean_0;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr_SortGeometry_Public_Void_VertexSortingOrder_0;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeMethodInfoPtr_SortGeometry_Public_Void_IList_1_Int32_0;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeMethodInfoPtr_SwapVertexData_Public_Void_Int32_Int32_0;
	}
}
