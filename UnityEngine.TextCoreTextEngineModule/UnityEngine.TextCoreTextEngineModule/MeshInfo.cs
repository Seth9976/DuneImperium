using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000012 RID: 18
	public sealed class MeshInfo : ValueType
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		// Note: this type is marked as 'beforefieldinit'.
		static MeshInfo()
		{
			Il2CppClassPointerStore<MeshInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "MeshInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr);
			MeshInfo.NativeFieldInfoPtr_k_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr, "k_DefaultColor");
			MeshInfo.NativeFieldInfoPtr_k_DefaultNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr, "k_DefaultNormal");
			MeshInfo.NativeFieldInfoPtr_k_DefaultTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr, "k_DefaultTangent");
			MeshInfo.NativeFieldInfoPtr_vertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr, "vertexCount");
			MeshInfo.NativeFieldInfoPtr_vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr, "vertices");
			MeshInfo.NativeFieldInfoPtr_normals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr, "normals");
			MeshInfo.NativeFieldInfoPtr_tangents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr, "tangents");
			MeshInfo.NativeFieldInfoPtr_uvs0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr, "uvs0");
			MeshInfo.NativeFieldInfoPtr_uvs2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr, "uvs2");
			MeshInfo.NativeFieldInfoPtr_colors32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr, "colors32");
			MeshInfo.NativeFieldInfoPtr_triangles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr, "triangles");
			MeshInfo.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr, "material");
			MeshInfo.NativeFieldInfoPtr_glyphRenderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr, "glyphRenderMode");
			MeshInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr, 100663472);
			MeshInfo.NativeMethodInfoPtr_ResizeMeshInfo_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr, 100663473);
			MeshInfo.NativeMethodInfoPtr_Clear_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr, 100663474);
			MeshInfo.NativeMethodInfoPtr_ClearUnusedVertices_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr, 100663475);
			MeshInfo.NativeMethodInfoPtr_SortGeometry_Internal_Void_VertexSortingOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr, 100663476);
			MeshInfo.NativeMethodInfoPtr_SwapVertexData_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr, 100663477);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000C580 File Offset: 0x0000A780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1100616, RefRangeEnd = 1100617, XrefRangeStart = 1100578, XrefRangeEnd = 1100616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshInfo(int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000C5CC File Offset: 0x0000A7CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1100632, RefRangeEnd = 1100637, XrefRangeStart = 1100617, XrefRangeEnd = 1100632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeMeshInfo(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshInfo.NativeMethodInfoPtr_ResizeMeshInfo_Internal_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000C610 File Offset: 0x0000A810
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1100638, RefRangeEnd = 1100640, XrefRangeStart = 1100637, XrefRangeEnd = 1100638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(bool uploadChanges)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uploadChanges;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshInfo.NativeMethodInfoPtr_Clear_Internal_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000C654 File Offset: 0x0000A854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1100641, RefRangeEnd = 1100642, XrefRangeStart = 1100640, XrefRangeEnd = 1100641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearUnusedVertices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshInfo.NativeMethodInfoPtr_ClearUnusedVertices_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000C68C File Offset: 0x0000A88C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1100646, RefRangeEnd = 1100647, XrefRangeStart = 1100642, XrefRangeEnd = 1100646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortGeometry(VertexSortingOrder order)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref order;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshInfo.NativeMethodInfoPtr_SortGeometry_Internal_Void_VertexSortingOrder_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000C6D0 File Offset: 0x0000A8D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1100647, RefRangeEnd = 1100648, XrefRangeStart = 1100647, XrefRangeEnd = 1100647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshInfo.NativeMethodInfoPtr_SwapVertexData_Internal_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002D5C File Offset: 0x00000F5C
		public MeshInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002D65 File Offset: 0x00000F65
		public MeshInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000C724 File Offset: 0x0000A924
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00002D77 File Offset: 0x00000F77
		public unsafe static Color32 k_DefaultColor
		{
			get
			{
				Color32 color;
				IL2CPP.il2cpp_field_static_get_value(MeshInfo.NativeFieldInfoPtr_k_DefaultColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshInfo.NativeFieldInfoPtr_k_DefaultColor, (void*)(&value));
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000C740 File Offset: 0x0000A940
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00002D85 File Offset: 0x00000F85
		public unsafe static Vector3 k_DefaultNormal
		{
			get
			{
				Vector3 vector;
				IL2CPP.il2cpp_field_static_get_value(MeshInfo.NativeFieldInfoPtr_k_DefaultNormal, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshInfo.NativeFieldInfoPtr_k_DefaultNormal, (void*)(&value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0000C75C File Offset: 0x0000A95C
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002D93 File Offset: 0x00000F93
		public unsafe static Vector4 k_DefaultTangent
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(MeshInfo.NativeFieldInfoPtr_k_DefaultTangent, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshInfo.NativeFieldInfoPtr_k_DefaultTangent, (void*)(&value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0000C778 File Offset: 0x0000A978
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002DA1 File Offset: 0x00000FA1
		public unsafe int vertexCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshInfo.NativeFieldInfoPtr_vertexCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshInfo.NativeFieldInfoPtr_vertexCount)) = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0000C7A0 File Offset: 0x0000A9A0
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00002DBC File Offset: 0x00000FBC
		public unsafe Il2CppStructArray<Vector3> vertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshInfo.NativeFieldInfoPtr_vertices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshInfo.NativeFieldInfoPtr_vertices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x0000C7D0 File Offset: 0x0000A9D0
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00002DDB File Offset: 0x00000FDB
		public unsafe Il2CppStructArray<Vector3> normals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshInfo.NativeFieldInfoPtr_normals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshInfo.NativeFieldInfoPtr_normals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x0000C800 File Offset: 0x0000AA00
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00002DFA File Offset: 0x00000FFA
		public unsafe Il2CppStructArray<Vector4> tangents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshInfo.NativeFieldInfoPtr_tangents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshInfo.NativeFieldInfoPtr_tangents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000C830 File Offset: 0x0000AA30
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00002E19 File Offset: 0x00001019
		public unsafe Il2CppStructArray<Vector4> uvs0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshInfo.NativeFieldInfoPtr_uvs0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshInfo.NativeFieldInfoPtr_uvs0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001CB RID: 459 RVA: 0x0000C860 File Offset: 0x0000AA60
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00002E38 File Offset: 0x00001038
		public unsafe Il2CppStructArray<Vector2> uvs2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshInfo.NativeFieldInfoPtr_uvs2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshInfo.NativeFieldInfoPtr_uvs2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0000C890 File Offset: 0x0000AA90
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00002E57 File Offset: 0x00001057
		public unsafe Il2CppStructArray<Color32> colors32
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshInfo.NativeFieldInfoPtr_colors32);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshInfo.NativeFieldInfoPtr_colors32), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000C8C0 File Offset: 0x0000AAC0
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00002E76 File Offset: 0x00001076
		public unsafe Il2CppStructArray<int> triangles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshInfo.NativeFieldInfoPtr_triangles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshInfo.NativeFieldInfoPtr_triangles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000C8F0 File Offset: 0x0000AAF0
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002E95 File Offset: 0x00001095
		public unsafe Material material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshInfo.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshInfo.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000C920 File Offset: 0x0000AB20
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002EB4 File Offset: 0x000010B4
		public unsafe GlyphRenderMode glyphRenderMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshInfo.NativeFieldInfoPtr_glyphRenderMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshInfo.NativeFieldInfoPtr_glyphRenderMode)) = value;
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000C948 File Offset: 0x0000AB48
		public void ClearUnusedVertices(int startIndex, bool updateMesh)
		{
			int num = this.vertices.Length - startIndex;
			bool flag = num > 0;
			if (flag)
			{
				Array.Clear(this.vertices, startIndex, num);
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000C97C File Offset: 0x0000AB7C
		public void ClearUnusedVertices(int startIndex)
		{
			int num = this.vertices.Length - startIndex;
			bool flag = num > 0;
			if (flag)
			{
				Array.Clear(this.vertices, startIndex, num);
			}
		}

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultColor;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultNormal;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultTangent;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_vertexCount;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr_vertices;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeFieldInfoPtr_normals;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeFieldInfoPtr_tangents;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeFieldInfoPtr_uvs0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeFieldInfoPtr_uvs2;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr_colors32;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeFieldInfoPtr_triangles;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_glyphRenderMode;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_ResizeMeshInfo_Internal_Void_Int32_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_Boolean_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_ClearUnusedVertices_Internal_Void_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_SortGeometry_Internal_Void_VertexSortingOrder_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_SwapVertexData_Internal_Void_Int32_Int32_0;
	}
}
