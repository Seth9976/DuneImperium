using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering.Universal.LibTessDotNet;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200003D RID: 61
	public class ShadowUtility : Object
	{
		// Token: 0x060005B1 RID: 1457 RVA: 0x000293DC File Offset: 0x000275DC
		// Note: this type is marked as 'beforefieldinit'.
		static ShadowUtility()
		{
			Il2CppClassPointerStore<ShadowUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ShadowUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowUtility>.NativeClassPtr);
			ShadowUtility.NativeMethodInfoPtr_CreateEdge_Private_Static_Edge_Int32_Int32_List_1_Vector3_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtility>.NativeClassPtr, 100663946);
			ShadowUtility.NativeMethodInfoPtr_PopulateEdgeArray_Private_Static_Void_List_1_Vector3_List_1_Int32_List_1_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtility>.NativeClassPtr, 100663947);
			ShadowUtility.NativeMethodInfoPtr_IsOutsideEdge_Private_Static_Boolean_Int32_List_1_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtility>.NativeClassPtr, 100663948);
			ShadowUtility.NativeMethodInfoPtr_SortEdges_Private_Static_Void_List_1_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtility>.NativeClassPtr, 100663949);
			ShadowUtility.NativeMethodInfoPtr_CreateShadowTriangles_Private_Static_Void_List_1_Vector3_List_1_Color_List_1_Int32_List_1_Vector4_List_1_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtility>.NativeClassPtr, 100663950);
			ShadowUtility.NativeMethodInfoPtr_InterpCustomVertexData_Private_Static_Object_Vec3_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtility>.NativeClassPtr, 100663951);
			ShadowUtility.NativeMethodInfoPtr_InitializeTangents_Private_Static_Void_Int32_List_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtility>.NativeClassPtr, 100663952);
			ShadowUtility.NativeMethodInfoPtr_CalculateLocalBounds_Internal_Static_Bounds_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtility>.NativeClassPtr, 100663953);
			ShadowUtility.NativeMethodInfoPtr_GenerateShadowMesh_Public_Static_Bounds_Mesh_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtility>.NativeClassPtr, 100663954);
			ShadowUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtility>.NativeClassPtr, 100663955);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000294D4 File Offset: 0x000276D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 602950, RefRangeEnd = 602953, XrefRangeStart = 602930, XrefRangeEnd = 602950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ShadowUtility.Edge CreateEdge(int triangleIndexA, int triangleIndexB, List<Vector3> vertices, List<int> triangles)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref triangleIndexA;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref triangleIndexB;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vertices);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtility.NativeMethodInfoPtr_CreateEdge_Private_Static_Edge_Int32_Int32_List_1_Vector3_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00029544 File Offset: 0x00027744
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 602968, RefRangeEnd = 602969, XrefRangeStart = 602953, XrefRangeEnd = 602968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PopulateEdgeArray(List<Vector3> vertices, List<int> triangles, List<ShadowUtility.Edge> edges)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(edges);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtility.NativeMethodInfoPtr_PopulateEdgeArray_Private_Static_Void_List_1_Vector3_List_1_Int32_List_1_Edge_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x000295A0 File Offset: 0x000277A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 602978, RefRangeEnd = 602979, XrefRangeStart = 602969, XrefRangeEnd = 602978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsOutsideEdge(int edgeIndex, List<ShadowUtility.Edge> edgesToProcess)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref edgeIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(edgesToProcess);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtility.NativeMethodInfoPtr_IsOutsideEdge_Private_Static_Boolean_Int32_List_1_Edge_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x000295F0 File Offset: 0x000277F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602979, XrefRangeEnd = 602983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SortEdges(List<ShadowUtility.Edge> edgesToProcess)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(edgesToProcess);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtility.NativeMethodInfoPtr_SortEdges_Private_Static_Void_List_1_Edge_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00029628 File Offset: 0x00027828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 603017, RefRangeEnd = 603018, XrefRangeStart = 602983, XrefRangeEnd = 603017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateShadowTriangles(List<Vector3> vertices, List<Color> colors, List<int> triangles, List<Vector4> tangents, List<ShadowUtility.Edge> edges)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colors);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triangles);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tangents);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(edges);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtility.NativeMethodInfoPtr_CreateShadowTriangles_Private_Static_Void_List_1_Vector3_List_1_Color_List_1_Int32_List_1_Vector4_List_1_Edge_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x000296A8 File Offset: 0x000278A8
		[CallerCount(0)]
		public unsafe static Object InterpCustomVertexData(Vec3 position, Il2CppReferenceArray<Object> data, Il2CppStructArray<float> weights)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(weights);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtility.NativeMethodInfoPtr_InterpCustomVertexData_Private_Static_Object_Vec3_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0002970C File Offset: 0x0002790C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 603018, XrefRangeEnd = 603024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeTangents(int tangentsToAdd, List<Vector4> tangents)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tangentsToAdd;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tangents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtility.NativeMethodInfoPtr_InitializeTangents_Private_Static_Void_Int32_List_1_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00029750 File Offset: 0x00027950
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 603028, RefRangeEnd = 603030, XrefRangeStart = 603024, XrefRangeEnd = 603028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Bounds CalculateLocalBounds(Il2CppStructArray<Vector3> inVertices)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inVertices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtility.NativeMethodInfoPtr_CalculateLocalBounds_Internal_Static_Bounds_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00029794 File Offset: 0x00027994
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 603189, RefRangeEnd = 603191, XrefRangeStart = 603030, XrefRangeEnd = 603189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Bounds GenerateShadowMesh(Mesh mesh, Il2CppStructArray<Vector3> shapePath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shapePath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtility.NativeMethodInfoPtr_GenerateShadowMesh_Public_Static_Bounds_Mesh_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000297E8 File Offset: 0x000279E8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShadowUtility()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00004850 File Offset: 0x00002A50
		public ShadowUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr_CreateEdge_Private_Static_Edge_Int32_Int32_List_1_Vector3_List_1_Int32_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_PopulateEdgeArray_Private_Static_Void_List_1_Vector3_List_1_Int32_List_1_Edge_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_IsOutsideEdge_Private_Static_Boolean_Int32_List_1_Edge_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_SortEdges_Private_Static_Void_List_1_Edge_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_CreateShadowTriangles_Private_Static_Void_List_1_Vector3_List_1_Color_List_1_Int32_List_1_Vector4_List_1_Edge_0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_InterpCustomVertexData_Private_Static_Object_Vec3_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Single_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_InitializeTangents_Private_Static_Void_Int32_List_1_Vector4_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLocalBounds_Internal_Static_Bounds_Il2CppStructArray_1_Vector3_0;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr_GenerateShadowMesh_Public_Static_Bounds_Mesh_Il2CppStructArray_1_Vector3_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000163 RID: 355
		[StructLayout(2)]
		public struct Edge
		{
			// Token: 0x06001B98 RID: 7064 RVA: 0x00072ADC File Offset: 0x00070CDC
			// Note: this type is marked as 'beforefieldinit'.
			static Edge()
			{
				Il2CppClassPointerStore<ShadowUtility.Edge>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShadowUtility>.NativeClassPtr, "Edge");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowUtility.Edge>.NativeClassPtr);
				ShadowUtility.Edge.NativeFieldInfoPtr_vertexIndex0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowUtility.Edge>.NativeClassPtr, "vertexIndex0");
				ShadowUtility.Edge.NativeFieldInfoPtr_vertexIndex1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowUtility.Edge>.NativeClassPtr, "vertexIndex1");
				ShadowUtility.Edge.NativeFieldInfoPtr_tangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowUtility.Edge>.NativeClassPtr, "tangent");
				ShadowUtility.Edge.NativeFieldInfoPtr_compareReversed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowUtility.Edge>.NativeClassPtr, "compareReversed");
				ShadowUtility.Edge.NativeMethodInfoPtr_AssignVertexIndices_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtility.Edge>.NativeClassPtr, 100663956);
				ShadowUtility.Edge.NativeMethodInfoPtr_Compare_Public_Int32_Edge_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtility.Edge>.NativeClassPtr, 100663957);
				ShadowUtility.Edge.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtility.Edge>.NativeClassPtr, 100663958);
			}

			// Token: 0x06001B99 RID: 7065 RVA: 0x00072B94 File Offset: 0x00070D94
			[CallerCount(0)]
			public unsafe void AssignVertexIndices(int vi0, int vi1)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref vi0;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vi1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtility.Edge.NativeMethodInfoPtr_AssignVertexIndices_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B9A RID: 7066 RVA: 0x00072BD4 File Offset: 0x00070DD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602915, XrefRangeEnd = 602918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Compare(ShadowUtility.Edge a, ShadowUtility.Edge b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtility.Edge.NativeMethodInfoPtr_Compare_Public_Int32_Edge_Edge_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001B9B RID: 7067 RVA: 0x00072C20 File Offset: 0x00070E20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602918, XrefRangeEnd = 602921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int CompareTo(ShadowUtility.Edge edgeToCompare)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref edgeToCompare;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtility.Edge.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Edge_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B9C RID: 7068 RVA: 0x0000F9F7 File Offset: 0x0000DBF7
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadowUtility.Edge>.NativeClassPtr, ref this));
			}

			// Token: 0x04001429 RID: 5161
			private static readonly IntPtr NativeFieldInfoPtr_vertexIndex0;

			// Token: 0x0400142A RID: 5162
			private static readonly IntPtr NativeFieldInfoPtr_vertexIndex1;

			// Token: 0x0400142B RID: 5163
			private static readonly IntPtr NativeFieldInfoPtr_tangent;

			// Token: 0x0400142C RID: 5164
			private static readonly IntPtr NativeFieldInfoPtr_compareReversed;

			// Token: 0x0400142D RID: 5165
			private static readonly IntPtr NativeMethodInfoPtr_AssignVertexIndices_Public_Void_Int32_Int32_0;

			// Token: 0x0400142E RID: 5166
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Int32_Edge_Edge_0;

			// Token: 0x0400142F RID: 5167
			private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Edge_0;

			// Token: 0x04001430 RID: 5168
			[FieldOffset(0)]
			public int vertexIndex0;

			// Token: 0x04001431 RID: 5169
			[FieldOffset(4)]
			public int vertexIndex1;

			// Token: 0x04001432 RID: 5170
			[FieldOffset(8)]
			public Vector4 tangent;

			// Token: 0x04001433 RID: 5171
			[FieldOffset(24)]
			[MarshalAs(4)]
			public bool compareReversed;
		}

		// Token: 0x02000164 RID: 356
		[ObfuscatedName("UnityEngine.Rendering.Universal.ShadowUtility+<>O")]
		public static class __O : Object
		{
			// Token: 0x06001B9D RID: 7069 RVA: 0x0000FA09 File Offset: 0x0000DC09
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<ShadowUtility.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShadowUtility>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowUtility.__O>.NativeClassPtr);
				ShadowUtility.__O.NativeFieldInfoPtr__0___InterpCustomVertexData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowUtility.__O>.NativeClassPtr, "<0>__InterpCustomVertexData");
			}

			// Token: 0x06001B9E RID: 7070 RVA: 0x0000FA3D File Offset: 0x0000DC3D
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009E8 RID: 2536
			// (get) Token: 0x06001B9F RID: 7071 RVA: 0x00072C60 File Offset: 0x00070E60
			// (set) Token: 0x06001BA0 RID: 7072 RVA: 0x0000FA46 File Offset: 0x0000DC46
			public unsafe static CombineCallback _0___InterpCustomVertexData
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShadowUtility.__O.NativeFieldInfoPtr__0___InterpCustomVertexData, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombineCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShadowUtility.__O.NativeFieldInfoPtr__0___InterpCustomVertexData, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001434 RID: 5172
			private static readonly IntPtr NativeFieldInfoPtr__0___InterpCustomVertexData;
		}

		// Token: 0x02000165 RID: 357
		[ObfuscatedName("UnityEngine.Rendering.Universal.ShadowUtility+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001BA1 RID: 7073 RVA: 0x00072C88 File Offset: 0x00070E88
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ShadowUtility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShadowUtility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowUtility.__c>.NativeClassPtr);
				ShadowUtility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowUtility.__c>.NativeClassPtr, "<>9");
				ShadowUtility.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowUtility.__c>.NativeClassPtr, "<>9__9_0");
				ShadowUtility.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowUtility.__c>.NativeClassPtr, "<>9__9_1");
				ShadowUtility.__c.NativeFieldInfoPtr___9__9_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowUtility.__c>.NativeClassPtr, "<>9__9_2");
				ShadowUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtility.__c>.NativeClassPtr, 100663960);
				ShadowUtility.__c.NativeMethodInfoPtr__GenerateShadowMesh_b__9_0_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtility.__c>.NativeClassPtr, 100663961);
				ShadowUtility.__c.NativeMethodInfoPtr__GenerateShadowMesh_b__9_1_Internal_Vector3_ContourVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtility.__c>.NativeClassPtr, 100663962);
				ShadowUtility.__c.NativeMethodInfoPtr__GenerateShadowMesh_b__9_2_Internal_Color_ContourVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtility.__c>.NativeClassPtr, 100663963);
			}

			// Token: 0x06001BA2 RID: 7074 RVA: 0x00072D54 File Offset: 0x00070F54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowUtility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BA3 RID: 7075 RVA: 0x00072D90 File Offset: 0x00070F90
			[CallerCount(0)]
			public unsafe int _GenerateShadowMesh_b__9_0(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtility.__c.NativeMethodInfoPtr__GenerateShadowMesh_b__9_0_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BA4 RID: 7076 RVA: 0x00072DDC File Offset: 0x00070FDC
			[CallerCount(0)]
			public unsafe Vector3 _GenerateShadowMesh_b__9_1(ContourVertex v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(v));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtility.__c.NativeMethodInfoPtr__GenerateShadowMesh_b__9_1_Internal_Vector3_ContourVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BA5 RID: 7077 RVA: 0x00072E30 File Offset: 0x00071030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602921, XrefRangeEnd = 602930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Color _GenerateShadowMesh_b__9_2(ContourVertex v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(v));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtility.__c.NativeMethodInfoPtr__GenerateShadowMesh_b__9_2_Internal_Color_ContourVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001BA6 RID: 7078 RVA: 0x0000FA58 File Offset: 0x0000DC58
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009E9 RID: 2537
			// (get) Token: 0x06001BA7 RID: 7079 RVA: 0x00072E84 File Offset: 0x00071084
			// (set) Token: 0x06001BA8 RID: 7080 RVA: 0x0000FA61 File Offset: 0x0000DC61
			public unsafe static ShadowUtility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShadowUtility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShadowUtility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShadowUtility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009EA RID: 2538
			// (get) Token: 0x06001BA9 RID: 7081 RVA: 0x00072EAC File Offset: 0x000710AC
			// (set) Token: 0x06001BAA RID: 7082 RVA: 0x0000FA73 File Offset: 0x0000DC73
			public unsafe static Func<int, int> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShadowUtility.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShadowUtility.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009EB RID: 2539
			// (get) Token: 0x06001BAB RID: 7083 RVA: 0x00072ED4 File Offset: 0x000710D4
			// (set) Token: 0x06001BAC RID: 7084 RVA: 0x0000FA85 File Offset: 0x0000DC85
			public unsafe static Func<ContourVertex, Vector3> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShadowUtility.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ContourVertex, Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShadowUtility.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009EC RID: 2540
			// (get) Token: 0x06001BAD RID: 7085 RVA: 0x00072EFC File Offset: 0x000710FC
			// (set) Token: 0x06001BAE RID: 7086 RVA: 0x0000FA97 File Offset: 0x0000DC97
			public unsafe static Func<ContourVertex, Color> __9__9_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShadowUtility.__c.NativeFieldInfoPtr___9__9_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ContourVertex, Color>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShadowUtility.__c.NativeFieldInfoPtr___9__9_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001435 RID: 5173
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001436 RID: 5174
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04001437 RID: 5175
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x04001438 RID: 5176
			private static readonly IntPtr NativeFieldInfoPtr___9__9_2;

			// Token: 0x04001439 RID: 5177
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400143A RID: 5178
			private static readonly IntPtr NativeMethodInfoPtr__GenerateShadowMesh_b__9_0_Internal_Int32_Int32_0;

			// Token: 0x0400143B RID: 5179
			private static readonly IntPtr NativeMethodInfoPtr__GenerateShadowMesh_b__9_1_Internal_Vector3_ContourVertex_0;

			// Token: 0x0400143C RID: 5180
			private static readonly IntPtr NativeMethodInfoPtr__GenerateShadowMesh_b__9_2_Internal_Color_ContourVertex_0;
		}
	}
}
