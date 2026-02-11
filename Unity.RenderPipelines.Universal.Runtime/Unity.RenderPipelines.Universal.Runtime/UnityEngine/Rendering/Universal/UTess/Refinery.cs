using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x0200012C RID: 300
	[StructLayout(2)]
	public struct Refinery
	{
		// Token: 0x06001A19 RID: 6681 RVA: 0x0006D730 File Offset: 0x0006B930
		// Note: this type is marked as 'beforefieldinit'.
		static Refinery()
		{
			Il2CppClassPointerStore<Refinery>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "Refinery");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Refinery>.NativeClassPtr);
			Refinery.NativeFieldInfoPtr_kMinAreaFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Refinery>.NativeClassPtr, "kMinAreaFactor");
			Refinery.NativeFieldInfoPtr_kMaxAreaFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Refinery>.NativeClassPtr, "kMaxAreaFactor");
			Refinery.NativeFieldInfoPtr_kMaxSteinerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Refinery>.NativeClassPtr, "kMaxSteinerCount");
			Refinery.NativeMethodInfoPtr_RequiresRefining_Private_Static_Boolean_UTriangle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Refinery>.NativeClassPtr, 100666368);
			Refinery.NativeMethodInfoPtr_FetchEncroachedSegments_Private_Static_Void_NativeArray_1_float2_Int32_NativeArray_1_int2_Int32_byref_NativeArray_1_UEncroachingSegment_byref_Int32_UCircle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Refinery>.NativeClassPtr, 100666369);
			Refinery.NativeMethodInfoPtr_InsertVertex_Private_Static_Void_byref_NativeArray_1_float2_byref_Int32_float2_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Refinery>.NativeClassPtr, 100666370);
			Refinery.NativeMethodInfoPtr_FindSegment_Private_Static_Int32_NativeArray_1_float2_Int32_NativeArray_1_int2_Int32_UEncroachingSegment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Refinery>.NativeClassPtr, 100666371);
			Refinery.NativeMethodInfoPtr_SplitSegments_Private_Static_Void_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_int2_byref_Int32_UEncroachingSegment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Refinery>.NativeClassPtr, 100666372);
			Refinery.NativeMethodInfoPtr_Condition_Internal_Static_Boolean_Allocator_Single_Single_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_int2_byref_Int32_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_Int32_byref_Int32_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Refinery>.NativeClassPtr, 100666373);
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x0006D814 File Offset: 0x0006BA14
		[CallerCount(0)]
		public unsafe static bool RequiresRefining(UTriangle tri, float maxArea)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tri;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxArea;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Refinery.NativeMethodInfoPtr_RequiresRefining_Private_Static_Boolean_UTriangle_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x0006D860 File Offset: 0x0006BA60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629284, RefRangeEnd = 629285, XrefRangeStart = 629282, XrefRangeEnd = 629284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FetchEncroachedSegments(NativeArray<float2> pgPoints, int pgPointCount, NativeArray<int2> pgEdges, int pgEdgeCount, ref NativeArray<UEncroachingSegment> encroach, ref int encroachCount, UCircle c)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pgPoints));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pgPointCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pgEdges));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pgEdgeCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(encroach);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &encroachCount;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Refinery.NativeMethodInfoPtr_FetchEncroachedSegments_Private_Static_Void_NativeArray_1_float2_Int32_NativeArray_1_int2_Int32_byref_NativeArray_1_UEncroachingSegment_byref_Int32_UCircle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x0006D900 File Offset: 0x0006BB00
		[CallerCount(0)]
		public unsafe static void InsertVertex(ref NativeArray<float2> pgPoints, ref int pgPointCount, float2 newVertex, ref int nid)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(pgPoints);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pgPointCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newVertex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Refinery.NativeMethodInfoPtr_InsertVertex_Private_Static_Void_byref_NativeArray_1_float2_byref_Int32_float2_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x0006D964 File Offset: 0x0006BB64
		[CallerCount(0)]
		public unsafe static int FindSegment(NativeArray<float2> pgPoints, int pgPointCount, NativeArray<int2> pgEdges, int pgEdgeCount, UEncroachingSegment es)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pgPoints));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pgPointCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pgEdges));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pgEdgeCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref es;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Refinery.NativeMethodInfoPtr_FindSegment_Private_Static_Int32_NativeArray_1_float2_Int32_NativeArray_1_int2_Int32_UEncroachingSegment_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x0006D9EC File Offset: 0x0006BBEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629292, RefRangeEnd = 629293, XrefRangeStart = 629285, XrefRangeEnd = 629292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SplitSegments(ref NativeArray<float2> pgPoints, ref int pgPointCount, ref NativeArray<int2> pgEdges, ref int pgEdgeCount, UEncroachingSegment es)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(pgPoints);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pgPointCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pgEdges);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pgEdgeCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref es;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Refinery.NativeMethodInfoPtr_SplitSegments_Private_Static_Void_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_int2_byref_Int32_UEncroachingSegment_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x0006DA60 File Offset: 0x0006BC60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629333, RefRangeEnd = 629334, XrefRangeStart = 629293, XrefRangeEnd = 629333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Condition(Allocator allocator, float factorArea, float targetArea, ref NativeArray<float2> pgPoints, ref int pgPointCount, ref NativeArray<int2> pgEdges, ref int pgEdgeCount, ref NativeArray<float2> vertices, ref int vertexCount, ref NativeArray<int> indices, ref int indexCount, ref float maxArea)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allocator;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref factorArea;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetArea;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pgPoints);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pgPointCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pgEdges);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pgEdgeCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(vertices);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vertexCount;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(indices);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexCount;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxArea;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Refinery.NativeMethodInfoPtr_Condition_Internal_Static_Boolean_Allocator_Single_Single_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_int2_byref_Int32_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_Int32_byref_Int32_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x0000EB8B File Offset: 0x0000CD8B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Refinery>.NativeClassPtr, ref this));
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06001A21 RID: 6689 RVA: 0x0006DB58 File Offset: 0x0006BD58
		// (set) Token: 0x06001A22 RID: 6690 RVA: 0x0000EB9D File Offset: 0x0000CD9D
		public unsafe static float kMinAreaFactor
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Refinery.NativeFieldInfoPtr_kMinAreaFactor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Refinery.NativeFieldInfoPtr_kMinAreaFactor, (void*)(&value));
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06001A23 RID: 6691 RVA: 0x0006DB74 File Offset: 0x0006BD74
		// (set) Token: 0x06001A24 RID: 6692 RVA: 0x0000EBAB File Offset: 0x0000CDAB
		public unsafe static float kMaxAreaFactor
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Refinery.NativeFieldInfoPtr_kMaxAreaFactor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Refinery.NativeFieldInfoPtr_kMaxAreaFactor, (void*)(&value));
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x0006DB90 File Offset: 0x0006BD90
		// (set) Token: 0x06001A26 RID: 6694 RVA: 0x0000EBB9 File Offset: 0x0000CDB9
		public unsafe static int kMaxSteinerCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Refinery.NativeFieldInfoPtr_kMaxSteinerCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Refinery.NativeFieldInfoPtr_kMaxSteinerCount, (void*)(&value));
			}
		}

		// Token: 0x040012D7 RID: 4823
		private static readonly IntPtr NativeFieldInfoPtr_kMinAreaFactor;

		// Token: 0x040012D8 RID: 4824
		private static readonly IntPtr NativeFieldInfoPtr_kMaxAreaFactor;

		// Token: 0x040012D9 RID: 4825
		private static readonly IntPtr NativeFieldInfoPtr_kMaxSteinerCount;

		// Token: 0x040012DA RID: 4826
		private static readonly IntPtr NativeMethodInfoPtr_RequiresRefining_Private_Static_Boolean_UTriangle_Single_0;

		// Token: 0x040012DB RID: 4827
		private static readonly IntPtr NativeMethodInfoPtr_FetchEncroachedSegments_Private_Static_Void_NativeArray_1_float2_Int32_NativeArray_1_int2_Int32_byref_NativeArray_1_UEncroachingSegment_byref_Int32_UCircle_0;

		// Token: 0x040012DC RID: 4828
		private static readonly IntPtr NativeMethodInfoPtr_InsertVertex_Private_Static_Void_byref_NativeArray_1_float2_byref_Int32_float2_byref_Int32_0;

		// Token: 0x040012DD RID: 4829
		private static readonly IntPtr NativeMethodInfoPtr_FindSegment_Private_Static_Int32_NativeArray_1_float2_Int32_NativeArray_1_int2_Int32_UEncroachingSegment_0;

		// Token: 0x040012DE RID: 4830
		private static readonly IntPtr NativeMethodInfoPtr_SplitSegments_Private_Static_Void_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_int2_byref_Int32_UEncroachingSegment_0;

		// Token: 0x040012DF RID: 4831
		private static readonly IntPtr NativeMethodInfoPtr_Condition_Internal_Static_Boolean_Allocator_Single_Single_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_int2_byref_Int32_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_Int32_byref_Int32_byref_Single_0;
	}
}
