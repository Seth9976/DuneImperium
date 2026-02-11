using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x0200012D RID: 301
	[StructLayout(2)]
	public struct Smoothen
	{
		// Token: 0x06001A27 RID: 6695 RVA: 0x0006DBAC File Offset: 0x0006BDAC
		// Note: this type is marked as 'beforefieldinit'.
		static Smoothen()
		{
			Il2CppClassPointerStore<Smoothen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "Smoothen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Smoothen>.NativeClassPtr);
			Smoothen.NativeFieldInfoPtr_kMaxAreaTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Smoothen>.NativeClassPtr, "kMaxAreaTolerance");
			Smoothen.NativeFieldInfoPtr_kMaxEdgeTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Smoothen>.NativeClassPtr, "kMaxEdgeTolerance");
			Smoothen.NativeMethodInfoPtr_RefineEdges_Private_Static_Void_byref_NativeArray_1_int4_byref_NativeArray_1_int4_byref_Int32_byref_NativeArray_1_int4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Smoothen>.NativeClassPtr, 100666375);
			Smoothen.NativeMethodInfoPtr_GetAffectingEdges_Private_Static_Void_Int32_NativeArray_1_int4_Int32_byref_NativeArray_1_Int32_byref_NativeArray_1_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Smoothen>.NativeClassPtr, 100666376);
			Smoothen.NativeMethodInfoPtr_CentroidByPoints_Private_Static_Void_Int32_NativeArray_1_UTriangle_byref_NativeArray_1_Int32_byref_Int32_byref_float2_byref_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Smoothen>.NativeClassPtr, 100666377);
			Smoothen.NativeMethodInfoPtr_CentroidByPolygon_Private_Static_Void_int4_NativeArray_1_UTriangle_byref_float2_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Smoothen>.NativeClassPtr, 100666378);
			Smoothen.NativeMethodInfoPtr_ConnectTriangles_Private_Static_Boolean_byref_NativeArray_1_int4_byref_NativeArray_1_Int32_byref_NativeArray_1_Int32_NativeArray_1_int4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Smoothen>.NativeClassPtr, 100666379);
			Smoothen.NativeMethodInfoPtr_Condition_Internal_Static_Boolean_Allocator_byref_NativeArray_1_float2_Int32_NativeArray_1_int2_Int32_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Smoothen>.NativeClassPtr, 100666380);
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x0006DC7C File Offset: 0x0006BE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 629334, XrefRangeEnd = 629340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RefineEdges(ref NativeArray<int4> refinedEdges, ref NativeArray<int4> delaEdges, ref int delaEdgeCount, ref NativeArray<int4> voronoiEdges)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(refinedEdges);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(delaEdges);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &delaEdgeCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(voronoiEdges);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Smoothen.NativeMethodInfoPtr_RefineEdges_Private_Static_Void_byref_NativeArray_1_int4_byref_NativeArray_1_int4_byref_Int32_byref_NativeArray_1_int4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x0006DCE8 File Offset: 0x0006BEE8
		[CallerCount(0)]
		public unsafe static void GetAffectingEdges(int pointIndex, NativeArray<int4> edges, int edgeCount, ref NativeArray<int> resultSet, ref NativeArray<int> checkSet, ref int resultCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(edges));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref edgeCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(resultSet);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(checkSet);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &resultCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Smoothen.NativeMethodInfoPtr_GetAffectingEdges_Private_Static_Void_Int32_NativeArray_1_int4_Int32_byref_NativeArray_1_Int32_byref_NativeArray_1_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x0006DD78 File Offset: 0x0006BF78
		[CallerCount(0)]
		public unsafe static void CentroidByPoints(int triIndex, NativeArray<UTriangle> triangles, ref NativeArray<int> centroidTris, ref int centroidCount, ref float2 aggregate, ref float2 point)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref triIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(triangles));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(centroidTris);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &centroidCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &aggregate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Smoothen.NativeMethodInfoPtr_CentroidByPoints_Private_Static_Void_Int32_NativeArray_1_UTriangle_byref_NativeArray_1_Int32_byref_Int32_byref_float2_byref_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x0006DE00 File Offset: 0x0006C000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 629340, XrefRangeEnd = 629341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CentroidByPolygon(int4 e, NativeArray<UTriangle> triangles, ref float2 centroid, ref float area, ref float distance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref e;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(triangles));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &centroid;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &area;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Smoothen.NativeMethodInfoPtr_CentroidByPolygon_Private_Static_Void_int4_NativeArray_1_UTriangle_byref_float2_byref_Single_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x0006DE74 File Offset: 0x0006C074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 629341, XrefRangeEnd = 629345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ConnectTriangles(ref NativeArray<int4> connectedTri, ref NativeArray<int> affectEdges, ref NativeArray<int> checkSet, NativeArray<int4> voronoiEdges, int triangleCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(connectedTri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(affectEdges);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(checkSet);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(voronoiEdges));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref triangleCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Smoothen.NativeMethodInfoPtr_ConnectTriangles_Private_Static_Boolean_byref_NativeArray_1_int4_byref_NativeArray_1_Int32_byref_NativeArray_1_Int32_NativeArray_1_int4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x0006DF04 File Offset: 0x0006C104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 629345, XrefRangeEnd = 629424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Condition(Allocator allocator, ref NativeArray<float2> pgPoints, int pgPointCount, NativeArray<int2> pgEdges, int pgEdgeCount, ref NativeArray<float2> vertices, ref int vertexCount, ref NativeArray<int> indices, ref int indexCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allocator;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pgPoints);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pgPointCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pgEdges));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pgEdgeCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(vertices);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vertexCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(indices);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Smoothen.NativeMethodInfoPtr_Condition_Internal_Static_Boolean_Allocator_byref_NativeArray_1_float2_Int32_NativeArray_1_int2_Int32_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x0000EBC7 File Offset: 0x0000CDC7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Smoothen>.NativeClassPtr, ref this));
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001A2F RID: 6703 RVA: 0x0006DFD0 File Offset: 0x0006C1D0
		// (set) Token: 0x06001A30 RID: 6704 RVA: 0x0000EBD9 File Offset: 0x0000CDD9
		public unsafe static float kMaxAreaTolerance
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Smoothen.NativeFieldInfoPtr_kMaxAreaTolerance, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Smoothen.NativeFieldInfoPtr_kMaxAreaTolerance, (void*)(&value));
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06001A31 RID: 6705 RVA: 0x0006DFEC File Offset: 0x0006C1EC
		// (set) Token: 0x06001A32 RID: 6706 RVA: 0x0000EBE7 File Offset: 0x0000CDE7
		public unsafe static float kMaxEdgeTolerance
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Smoothen.NativeFieldInfoPtr_kMaxEdgeTolerance, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Smoothen.NativeFieldInfoPtr_kMaxEdgeTolerance, (void*)(&value));
			}
		}

		// Token: 0x040012E0 RID: 4832
		private static readonly IntPtr NativeFieldInfoPtr_kMaxAreaTolerance;

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeFieldInfoPtr_kMaxEdgeTolerance;

		// Token: 0x040012E2 RID: 4834
		private static readonly IntPtr NativeMethodInfoPtr_RefineEdges_Private_Static_Void_byref_NativeArray_1_int4_byref_NativeArray_1_int4_byref_Int32_byref_NativeArray_1_int4_0;

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeMethodInfoPtr_GetAffectingEdges_Private_Static_Void_Int32_NativeArray_1_int4_Int32_byref_NativeArray_1_Int32_byref_NativeArray_1_Int32_byref_Int32_0;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeMethodInfoPtr_CentroidByPoints_Private_Static_Void_Int32_NativeArray_1_UTriangle_byref_NativeArray_1_Int32_byref_Int32_byref_float2_byref_float2_0;

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeMethodInfoPtr_CentroidByPolygon_Private_Static_Void_int4_NativeArray_1_UTriangle_byref_float2_byref_Single_byref_Single_0;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeMethodInfoPtr_ConnectTriangles_Private_Static_Boolean_byref_NativeArray_1_int4_byref_NativeArray_1_Int32_byref_NativeArray_1_Int32_NativeArray_1_int4_Int32_0;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeMethodInfoPtr_Condition_Internal_Static_Boolean_Allocator_byref_NativeArray_1_float2_Int32_NativeArray_1_int2_Int32_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_Int32_byref_Int32_0;
	}
}
