using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.UIElements
{
	// Token: 0x0200016C RID: 364
	public class MeshWriteData : Object
	{
		// Token: 0x06001AE7 RID: 6887 RVA: 0x0007C188 File Offset: 0x0007A388
		// Note: this type is marked as 'beforefieldinit'.
		static MeshWriteData()
		{
			Il2CppClassPointerStore<MeshWriteData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MeshWriteData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshWriteData>.NativeClassPtr);
			MeshWriteData.NativeFieldInfoPtr_m_Vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshWriteData>.NativeClassPtr, "m_Vertices");
			MeshWriteData.NativeFieldInfoPtr_m_Indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshWriteData>.NativeClassPtr, "m_Indices");
			MeshWriteData.NativeFieldInfoPtr_m_UVRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshWriteData>.NativeClassPtr, "m_UVRegion");
			MeshWriteData.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshWriteData>.NativeClassPtr, "currentIndex");
			MeshWriteData.NativeFieldInfoPtr_currentVertex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshWriteData>.NativeClassPtr, "currentVertex");
			MeshWriteData.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshWriteData>.NativeClassPtr, 100667229);
			MeshWriteData.NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshWriteData>.NativeClassPtr, 100667230);
			MeshWriteData.NativeMethodInfoPtr_get_indexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshWriteData>.NativeClassPtr, 100667231);
			MeshWriteData.NativeMethodInfoPtr_get_uvRegion_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshWriteData>.NativeClassPtr, 100667232);
			MeshWriteData.NativeMethodInfoPtr_SetNextVertex_Public_Void_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshWriteData>.NativeClassPtr, 100667233);
			MeshWriteData.NativeMethodInfoPtr_SetNextIndex_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshWriteData>.NativeClassPtr, 100667234);
			MeshWriteData.NativeMethodInfoPtr_SetAllVertices_Public_Void_Il2CppStructArray_1_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshWriteData>.NativeClassPtr, 100667235);
			MeshWriteData.NativeMethodInfoPtr_SetAllIndices_Public_Void_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshWriteData>.NativeClassPtr, 100667236);
			MeshWriteData.NativeMethodInfoPtr_Reset_Internal_Void_NativeSlice_1_Vertex_NativeSlice_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshWriteData>.NativeClassPtr, 100667237);
			MeshWriteData.NativeMethodInfoPtr_Reset_Internal_Void_NativeSlice_1_Vertex_NativeSlice_1_UInt16_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshWriteData>.NativeClassPtr, 100667238);
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x0007C2E4 File Offset: 0x0007A4E4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshWriteData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshWriteData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshWriteData.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001AE9 RID: 6889 RVA: 0x0007C320 File Offset: 0x0007A520
		public unsafe int vertexCount
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 322588, RefRangeEnd = 322592, XrefRangeStart = 322585, XrefRangeEnd = 322588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshWriteData.NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001AEA RID: 6890 RVA: 0x0007C35C File Offset: 0x0007A55C
		public unsafe int indexCount
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 322595, RefRangeEnd = 322599, XrefRangeStart = 322592, XrefRangeEnd = 322595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshWriteData.NativeMethodInfoPtr_get_indexCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x0007C398 File Offset: 0x0007A598
		public unsafe Rect uvRegion
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 322599, RefRangeEnd = 322600, XrefRangeStart = 322599, XrefRangeEnd = 322599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshWriteData.NativeMethodInfoPtr_get_uvRegion_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x0007C3D4 File Offset: 0x0007A5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322600, XrefRangeEnd = 322603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNextVertex(Vertex vertex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vertex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshWriteData.NativeMethodInfoPtr_SetNextVertex_Public_Void_Vertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x0007C414 File Offset: 0x0007A614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322603, XrefRangeEnd = 322606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNextIndex(ushort index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshWriteData.NativeMethodInfoPtr_SetNextIndex_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x0007C454 File Offset: 0x0007A654
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322612, RefRangeEnd = 322613, XrefRangeStart = 322606, XrefRangeEnd = 322612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAllVertices(Il2CppStructArray<Vertex> vertices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshWriteData.NativeMethodInfoPtr_SetAllVertices_Public_Void_Il2CppStructArray_1_Vertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x0007C498 File Offset: 0x0007A698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322619, RefRangeEnd = 322620, XrefRangeStart = 322613, XrefRangeEnd = 322619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAllIndices(Il2CppStructArray<ushort> indices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshWriteData.NativeMethodInfoPtr_SetAllIndices_Public_Void_Il2CppStructArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x0007C4DC File Offset: 0x0007A6DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 322620, RefRangeEnd = 322622, XrefRangeStart = 322620, XrefRangeEnd = 322620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(vertices));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(indices));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshWriteData.NativeMethodInfoPtr_Reset_Internal_Void_NativeSlice_1_Vertex_NativeSlice_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x0007C53C File Offset: 0x0007A73C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322622, RefRangeEnd = 322623, XrefRangeStart = 322622, XrefRangeEnd = 322622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, Rect uvRegion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(vertices));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(indices));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uvRegion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshWriteData.NativeMethodInfoPtr_Reset_Internal_Void_NativeSlice_1_Vertex_NativeSlice_1_UInt16_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x0000C399 File Offset: 0x0000A599
		public MeshWriteData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x0007C5A8 File Offset: 0x0007A7A8
		// (set) Token: 0x06001AF4 RID: 6900 RVA: 0x0000C3A2 File Offset: 0x0000A5A2
		public NativeSlice<Vertex> m_Vertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshWriteData.NativeFieldInfoPtr_m_Vertices);
				return new NativeSlice<Vertex>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeSlice<Vertex>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshWriteData.NativeFieldInfoPtr_m_Vertices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeSlice<Vertex>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x0007C5D8 File Offset: 0x0007A7D8
		// (set) Token: 0x06001AF6 RID: 6902 RVA: 0x0000C3D0 File Offset: 0x0000A5D0
		public NativeSlice<ushort> m_Indices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshWriteData.NativeFieldInfoPtr_m_Indices);
				return new NativeSlice<ushort>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeSlice<ushort>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshWriteData.NativeFieldInfoPtr_m_Indices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeSlice<ushort>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x0007C608 File Offset: 0x0007A808
		// (set) Token: 0x06001AF8 RID: 6904 RVA: 0x0000C3FE File Offset: 0x0000A5FE
		public unsafe Rect m_UVRegion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshWriteData.NativeFieldInfoPtr_m_UVRegion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshWriteData.NativeFieldInfoPtr_m_UVRegion)) = value;
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x0007C630 File Offset: 0x0007A830
		// (set) Token: 0x06001AFA RID: 6906 RVA: 0x0000C419 File Offset: 0x0000A619
		public unsafe int currentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshWriteData.NativeFieldInfoPtr_currentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshWriteData.NativeFieldInfoPtr_currentIndex)) = value;
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001AFB RID: 6907 RVA: 0x0007C658 File Offset: 0x0007A858
		// (set) Token: 0x06001AFC RID: 6908 RVA: 0x0000C434 File Offset: 0x0000A634
		public unsafe int currentVertex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshWriteData.NativeFieldInfoPtr_currentVertex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshWriteData.NativeFieldInfoPtr_currentVertex)) = value;
			}
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x0000C44F File Offset: 0x0000A64F
		public void SetAllVertices(NativeSlice<Vertex> vertices)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x0000C45C File Offset: 0x0000A65C
		public void SetAllIndices(NativeSlice<ushort> indices)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040012AC RID: 4780
		private static readonly IntPtr NativeFieldInfoPtr_m_Vertices;

		// Token: 0x040012AD RID: 4781
		private static readonly IntPtr NativeFieldInfoPtr_m_Indices;

		// Token: 0x040012AE RID: 4782
		private static readonly IntPtr NativeFieldInfoPtr_m_UVRegion;

		// Token: 0x040012AF RID: 4783
		private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

		// Token: 0x040012B0 RID: 4784
		private static readonly IntPtr NativeFieldInfoPtr_currentVertex;

		// Token: 0x040012B1 RID: 4785
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040012B2 RID: 4786
		private static readonly IntPtr NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0;

		// Token: 0x040012B3 RID: 4787
		private static readonly IntPtr NativeMethodInfoPtr_get_indexCount_Public_get_Int32_0;

		// Token: 0x040012B4 RID: 4788
		private static readonly IntPtr NativeMethodInfoPtr_get_uvRegion_Public_get_Rect_0;

		// Token: 0x040012B5 RID: 4789
		private static readonly IntPtr NativeMethodInfoPtr_SetNextVertex_Public_Void_Vertex_0;

		// Token: 0x040012B6 RID: 4790
		private static readonly IntPtr NativeMethodInfoPtr_SetNextIndex_Public_Void_UInt16_0;

		// Token: 0x040012B7 RID: 4791
		private static readonly IntPtr NativeMethodInfoPtr_SetAllVertices_Public_Void_Il2CppStructArray_1_Vertex_0;

		// Token: 0x040012B8 RID: 4792
		private static readonly IntPtr NativeMethodInfoPtr_SetAllIndices_Public_Void_Il2CppStructArray_1_UInt16_0;

		// Token: 0x040012B9 RID: 4793
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_NativeSlice_1_Vertex_NativeSlice_1_UInt16_0;

		// Token: 0x040012BA RID: 4794
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_NativeSlice_1_Vertex_NativeSlice_1_UInt16_Rect_0;
	}
}
