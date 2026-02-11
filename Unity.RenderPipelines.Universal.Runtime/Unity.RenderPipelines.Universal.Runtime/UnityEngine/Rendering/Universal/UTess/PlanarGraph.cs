using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x0200012B RID: 299
	[StructLayout(2)]
	public struct PlanarGraph
	{
		// Token: 0x06001A0A RID: 6666 RVA: 0x0006D0D0 File Offset: 0x0006B2D0
		// Note: this type is marked as 'beforefieldinit'.
		static PlanarGraph()
		{
			Il2CppClassPointerStore<PlanarGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "PlanarGraph");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlanarGraph>.NativeClassPtr);
			PlanarGraph.NativeFieldInfoPtr_kEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlanarGraph>.NativeClassPtr, "kEpsilon");
			PlanarGraph.NativeFieldInfoPtr_kMaxIntersectionTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlanarGraph>.NativeClassPtr, "kMaxIntersectionTolerance");
			PlanarGraph.NativeMethodInfoPtr_RemoveDuplicateEdges_Internal_Static_Void_byref_NativeArray_1_int2_byref_Int32_NativeArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlanarGraph>.NativeClassPtr, 100666358);
			PlanarGraph.NativeMethodInfoPtr_CheckCollinear_Internal_Static_Boolean_double2_double2_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlanarGraph>.NativeClassPtr, 100666359);
			PlanarGraph.NativeMethodInfoPtr_LineLineIntersection_Internal_Static_Boolean_double2_double2_double2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlanarGraph>.NativeClassPtr, 100666360);
			PlanarGraph.NativeMethodInfoPtr_LineLineIntersection_Internal_Static_Boolean_double2_double2_double2_double2_byref_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlanarGraph>.NativeClassPtr, 100666361);
			PlanarGraph.NativeMethodInfoPtr_CalculateEdgeIntersections_Internal_Static_Boolean_NativeArray_1_int2_Int32_NativeArray_1_double2_Int32_byref_NativeArray_1_int2_byref_NativeArray_1_double2_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlanarGraph>.NativeClassPtr, 100666362);
			PlanarGraph.NativeMethodInfoPtr_CalculateTJunctions_Internal_Static_Boolean_NativeArray_1_int2_Int32_NativeArray_1_double2_Int32_NativeArray_1_int2_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlanarGraph>.NativeClassPtr, 100666363);
			PlanarGraph.NativeMethodInfoPtr_CutEdges_Internal_Static_Boolean_byref_NativeArray_1_double2_byref_Int32_byref_NativeArray_1_int2_byref_Int32_byref_NativeArray_1_int2_byref_Int32_NativeArray_1_int2_NativeArray_1_double2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlanarGraph>.NativeClassPtr, 100666364);
			PlanarGraph.NativeMethodInfoPtr_RemoveDuplicatePoints_Internal_Static_Void_byref_NativeArray_1_double2_byref_Int32_byref_NativeArray_1_Int32_byref_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlanarGraph>.NativeClassPtr, 100666365);
			PlanarGraph.NativeMethodInfoPtr_Validate_Internal_Static_Boolean_Allocator_NativeArray_1_float2_Int32_NativeArray_1_int2_Int32_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_int2_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlanarGraph>.NativeClassPtr, 100666366);
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x0006D1DC File Offset: 0x0006B3DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629088, RefRangeEnd = 629089, XrefRangeStart = 629078, XrefRangeEnd = 629088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveDuplicateEdges(ref NativeArray<int2> edges, ref int edgeCount, NativeArray<int> duplicates, int duplicateCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(edges);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &edgeCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(duplicates));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duplicateCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlanarGraph.NativeMethodInfoPtr_RemoveDuplicateEdges_Internal_Static_Void_byref_NativeArray_1_int2_byref_Int32_NativeArray_1_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x0006D248 File Offset: 0x0006B448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 629089, XrefRangeEnd = 629096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckCollinear(double2 a0, double2 a1, double2 b0, double2 b1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b0;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlanarGraph.NativeMethodInfoPtr_CheckCollinear_Internal_Static_Boolean_double2_double2_double2_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x0006D2B0 File Offset: 0x0006B4B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 629143, RefRangeEnd = 629145, XrefRangeStart = 629096, XrefRangeEnd = 629143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LineLineIntersection(double2 a0, double2 a1, double2 b0, double2 b1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b0;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlanarGraph.NativeMethodInfoPtr_LineLineIntersection_Internal_Static_Boolean_double2_double2_double2_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x0006D318 File Offset: 0x0006B518
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629154, RefRangeEnd = 629155, XrefRangeStart = 629145, XrefRangeEnd = 629154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LineLineIntersection(double2 p1, double2 p2, double2 p3, double2 p4, ref double2 result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p4;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlanarGraph.NativeMethodInfoPtr_LineLineIntersection_Internal_Static_Boolean_double2_double2_double2_double2_byref_double2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x0006D390 File Offset: 0x0006B590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629177, RefRangeEnd = 629178, XrefRangeStart = 629155, XrefRangeEnd = 629177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CalculateEdgeIntersections(NativeArray<int2> edges, int edgeCount, NativeArray<double2> points, int pointCount, ref NativeArray<int2> results, ref NativeArray<double2> intersects, ref int resultCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(edges));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref edgeCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(points));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(results);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(intersects);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &resultCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlanarGraph.NativeMethodInfoPtr_CalculateEdgeIntersections_Internal_Static_Boolean_NativeArray_1_int2_Int32_NativeArray_1_double2_Int32_byref_NativeArray_1_int2_byref_NativeArray_1_double2_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x0006D440 File Offset: 0x0006B640
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629184, RefRangeEnd = 629185, XrefRangeStart = 629178, XrefRangeEnd = 629184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CalculateTJunctions(NativeArray<int2> edges, int edgeCount, NativeArray<double2> points, int pointCount, NativeArray<int2> results, ref int resultCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(edges));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref edgeCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(points));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(results));
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &resultCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlanarGraph.NativeMethodInfoPtr_CalculateTJunctions_Internal_Static_Boolean_NativeArray_1_int2_Int32_NativeArray_1_double2_Int32_NativeArray_1_int2_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x0006D4E0 File Offset: 0x0006B6E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629195, RefRangeEnd = 629196, XrefRangeStart = 629185, XrefRangeEnd = 629195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CutEdges(ref NativeArray<double2> points, ref int pointCount, ref NativeArray<int2> edges, ref int edgeCount, ref NativeArray<int2> tJunctions, ref int tJunctionCount, NativeArray<int2> intersections, NativeArray<double2> intersects, int intersectionCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(points);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pointCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(edges);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &edgeCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(tJunctions);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tJunctionCount;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(intersections));
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(intersects));
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intersectionCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlanarGraph.NativeMethodInfoPtr_CutEdges_Internal_Static_Boolean_byref_NativeArray_1_double2_byref_Int32_byref_NativeArray_1_int2_byref_Int32_byref_NativeArray_1_int2_byref_Int32_NativeArray_1_int2_NativeArray_1_double2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x0006D5B4 File Offset: 0x0006B7B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629208, RefRangeEnd = 629209, XrefRangeStart = 629196, XrefRangeEnd = 629208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveDuplicatePoints(ref NativeArray<double2> points, ref int pointCount, ref NativeArray<int> duplicates, ref int duplicateCount, Allocator allocator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(points);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pointCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(duplicates);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &duplicateCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlanarGraph.NativeMethodInfoPtr_RemoveDuplicatePoints_Internal_Static_Void_byref_NativeArray_1_double2_byref_Int32_byref_NativeArray_1_Int32_byref_Int32_Allocator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x0006D628 File Offset: 0x0006B828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629281, RefRangeEnd = 629282, XrefRangeStart = 629209, XrefRangeEnd = 629281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Validate(Allocator allocator, NativeArray<float2> inputPoints, int pointCount, NativeArray<int2> inputEdges, int edgeCount, ref NativeArray<float2> outputPoints, ref int outputPointCount, ref NativeArray<int2> outputEdges, ref int outputEdgeCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allocator;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inputPoints));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inputEdges));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref edgeCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(outputPoints);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outputPointCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(outputEdges);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outputEdgeCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlanarGraph.NativeMethodInfoPtr_Validate_Internal_Static_Boolean_Allocator_NativeArray_1_float2_Int32_NativeArray_1_int2_Int32_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_int2_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0000EB5D File Offset: 0x0000CD5D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlanarGraph>.NativeClassPtr, ref this));
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06001A15 RID: 6677 RVA: 0x0006D6F8 File Offset: 0x0006B8F8
		// (set) Token: 0x06001A16 RID: 6678 RVA: 0x0000EB6F File Offset: 0x0000CD6F
		public unsafe static double kEpsilon
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(PlanarGraph.NativeFieldInfoPtr_kEpsilon, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlanarGraph.NativeFieldInfoPtr_kEpsilon, (void*)(&value));
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x0006D714 File Offset: 0x0006B914
		// (set) Token: 0x06001A18 RID: 6680 RVA: 0x0000EB7D File Offset: 0x0000CD7D
		public unsafe static int kMaxIntersectionTolerance
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PlanarGraph.NativeFieldInfoPtr_kMaxIntersectionTolerance, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlanarGraph.NativeFieldInfoPtr_kMaxIntersectionTolerance, (void*)(&value));
			}
		}

		// Token: 0x040012CC RID: 4812
		private static readonly IntPtr NativeFieldInfoPtr_kEpsilon;

		// Token: 0x040012CD RID: 4813
		private static readonly IntPtr NativeFieldInfoPtr_kMaxIntersectionTolerance;

		// Token: 0x040012CE RID: 4814
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDuplicateEdges_Internal_Static_Void_byref_NativeArray_1_int2_byref_Int32_NativeArray_1_Int32_Int32_0;

		// Token: 0x040012CF RID: 4815
		private static readonly IntPtr NativeMethodInfoPtr_CheckCollinear_Internal_Static_Boolean_double2_double2_double2_double2_0;

		// Token: 0x040012D0 RID: 4816
		private static readonly IntPtr NativeMethodInfoPtr_LineLineIntersection_Internal_Static_Boolean_double2_double2_double2_double2_0;

		// Token: 0x040012D1 RID: 4817
		private static readonly IntPtr NativeMethodInfoPtr_LineLineIntersection_Internal_Static_Boolean_double2_double2_double2_double2_byref_double2_0;

		// Token: 0x040012D2 RID: 4818
		private static readonly IntPtr NativeMethodInfoPtr_CalculateEdgeIntersections_Internal_Static_Boolean_NativeArray_1_int2_Int32_NativeArray_1_double2_Int32_byref_NativeArray_1_int2_byref_NativeArray_1_double2_byref_Int32_0;

		// Token: 0x040012D3 RID: 4819
		private static readonly IntPtr NativeMethodInfoPtr_CalculateTJunctions_Internal_Static_Boolean_NativeArray_1_int2_Int32_NativeArray_1_double2_Int32_NativeArray_1_int2_byref_Int32_0;

		// Token: 0x040012D4 RID: 4820
		private static readonly IntPtr NativeMethodInfoPtr_CutEdges_Internal_Static_Boolean_byref_NativeArray_1_double2_byref_Int32_byref_NativeArray_1_int2_byref_Int32_byref_NativeArray_1_int2_byref_Int32_NativeArray_1_int2_NativeArray_1_double2_Int32_0;

		// Token: 0x040012D5 RID: 4821
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDuplicatePoints_Internal_Static_Void_byref_NativeArray_1_double2_byref_Int32_byref_NativeArray_1_Int32_byref_Int32_Allocator_0;

		// Token: 0x040012D6 RID: 4822
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Internal_Static_Boolean_Allocator_NativeArray_1_float2_Int32_NativeArray_1_int2_Int32_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_int2_byref_Int32_0;
	}
}
