using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x0200012E RID: 302
	public sealed class Tessellator : ValueType
	{
		// Token: 0x06001A33 RID: 6707 RVA: 0x0006E008 File Offset: 0x0006C208
		// Note: this type is marked as 'beforefieldinit'.
		static Tessellator()
		{
			Il2CppClassPointerStore<Tessellator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "Tessellator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tessellator>.NativeClassPtr);
			Tessellator.NativeFieldInfoPtr_m_Edges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, "m_Edges");
			Tessellator.NativeFieldInfoPtr_m_Stars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, "m_Stars");
			Tessellator.NativeFieldInfoPtr_m_Cells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, "m_Cells");
			Tessellator.NativeFieldInfoPtr_m_CellCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, "m_CellCount");
			Tessellator.NativeFieldInfoPtr_m_ILArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, "m_ILArray");
			Tessellator.NativeFieldInfoPtr_m_IUArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, "m_IUArray");
			Tessellator.NativeFieldInfoPtr_m_SPArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, "m_SPArray");
			Tessellator.NativeFieldInfoPtr_m_NumEdges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, "m_NumEdges");
			Tessellator.NativeFieldInfoPtr_m_NumHulls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, "m_NumHulls");
			Tessellator.NativeFieldInfoPtr_m_NumPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, "m_NumPoints");
			Tessellator.NativeFieldInfoPtr_m_StarCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, "m_StarCount");
			Tessellator.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, "m_Flags");
			Tessellator.NativeFieldInfoPtr_m_Neighbors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, "m_Neighbors");
			Tessellator.NativeFieldInfoPtr_m_Constraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, "m_Constraints");
			Tessellator.NativeFieldInfoPtr_m_Allocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, "m_Allocator");
			Tessellator.NativeMethodInfoPtr_FindSplit_Private_Static_Single_UHull_UEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666382);
			Tessellator.NativeMethodInfoPtr_SetAllocator_Private_Void_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666383);
			Tessellator.NativeMethodInfoPtr_AddPoint_Private_Boolean_NativeArray_1_UHull_Int32_NativeArray_1_float2_float2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666384);
			Tessellator.NativeMethodInfoPtr_InsertHull_Private_Static_Void_NativeArray_1_UHull_Int32_byref_Int32_UHull_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666385);
			Tessellator.NativeMethodInfoPtr_EraseHull_Private_Static_Void_NativeArray_1_UHull_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666386);
			Tessellator.NativeMethodInfoPtr_SplitHulls_Private_Boolean_NativeArray_1_UHull_byref_Int32_NativeArray_1_float2_UEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666387);
			Tessellator.NativeMethodInfoPtr_MergeHulls_Private_Boolean_NativeArray_1_UHull_byref_Int32_NativeArray_1_float2_UEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666388);
			Tessellator.NativeMethodInfoPtr_InsertUniqueEdge_Private_Static_Void_NativeArray_1_int2_int2_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666389);
			Tessellator.NativeMethodInfoPtr_PrepareDelaunay_Private_Void_NativeArray_1_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666390);
			Tessellator.NativeMethodInfoPtr_OppositeOf_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666391);
			Tessellator.NativeMethodInfoPtr_FindConstraint_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666392);
			Tessellator.NativeMethodInfoPtr_AddTriangle_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666393);
			Tessellator.NativeMethodInfoPtr_RemovePair_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666394);
			Tessellator.NativeMethodInfoPtr_RemoveTriangle_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666395);
			Tessellator.NativeMethodInfoPtr_EdgeFlip_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666396);
			Tessellator.NativeMethodInfoPtr_Flip_Private_Boolean_NativeArray_1_float2_byref_NativeArray_1_Int32_byref_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666397);
			Tessellator.NativeMethodInfoPtr_GetCells_Private_NativeArray_1_int3_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666398);
			Tessellator.NativeMethodInfoPtr_ApplyDelaunay_Internal_Boolean_NativeArray_1_float2_NativeArray_1_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666399);
			Tessellator.NativeMethodInfoPtr_FindNeighbor_Private_Int32_NativeArray_1_int3_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666400);
			Tessellator.NativeMethodInfoPtr_Constrain_Private_NativeArray_1_int3_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666401);
			Tessellator.NativeMethodInfoPtr_RemoveExterior_Internal_NativeArray_1_int3_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666402);
			Tessellator.NativeMethodInfoPtr_RemoveInterior_Internal_NativeArray_1_int3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666403);
			Tessellator.NativeMethodInfoPtr_Triangulate_Internal_Boolean_NativeArray_1_float2_Int32_NativeArray_1_int2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666404);
			Tessellator.NativeMethodInfoPtr_Tessellate_Internal_Static_Boolean_Allocator_NativeArray_1_float2_Int32_NativeArray_1_int2_Int32_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666405);
			Tessellator.NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, 100666406);
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x0006E358 File Offset: 0x0006C558
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 629450, RefRangeEnd = 629452, XrefRangeStart = 629439, XrefRangeEnd = 629450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float FindSplit(UHull hull, UEvent edge)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(hull));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref edge;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_FindSplit_Private_Static_Single_UHull_UEvent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x0006E3AC File Offset: 0x0006C5AC
		[CallerCount(0)]
		public unsafe void SetAllocator(Allocator allocator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allocator;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_SetAllocator_Private_Void_Allocator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x0006E3F0 File Offset: 0x0006C5F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629491, RefRangeEnd = 629492, XrefRangeStart = 629452, XrefRangeEnd = 629491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddPoint(NativeArray<UHull> hulls, int hullCount, NativeArray<float2> points, float2 p, int idx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(hulls));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hullCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(points));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_AddPoint_Private_Boolean_NativeArray_1_UHull_Int32_NativeArray_1_float2_float2_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x0006E488 File Offset: 0x0006C688
		[CallerCount(0)]
		public unsafe static void InsertHull(NativeArray<UHull> Hulls, int Pos, ref int Count, UHull Value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(Hulls));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &Count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(Value));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_InsertHull_Private_Static_Void_NativeArray_1_UHull_Int32_byref_Int32_UHull_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x0006E4F8 File Offset: 0x0006C6F8
		[CallerCount(0)]
		public unsafe static void EraseHull(NativeArray<UHull> Hulls, int Pos, ref int Count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(Hulls));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &Count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_EraseHull_Private_Static_Void_NativeArray_1_UHull_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x0006E550 File Offset: 0x0006C750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629516, RefRangeEnd = 629517, XrefRangeStart = 629492, XrefRangeEnd = 629516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SplitHulls(NativeArray<UHull> hulls, ref int hullCount, NativeArray<float2> points, UEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(hulls));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hullCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(points));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_SplitHulls_Private_Boolean_NativeArray_1_UHull_byref_Int32_NativeArray_1_float2_UEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x0006E5DC File Offset: 0x0006C7DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629530, RefRangeEnd = 629531, XrefRangeStart = 629517, XrefRangeEnd = 629530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MergeHulls(NativeArray<UHull> hulls, ref int hullCount, NativeArray<float2> points, UEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(hulls));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hullCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(points));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_MergeHulls_Private_Boolean_NativeArray_1_UHull_byref_Int32_NativeArray_1_float2_UEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x0006E668 File Offset: 0x0006C868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 629531, XrefRangeEnd = 629533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InsertUniqueEdge(NativeArray<int2> edges, int2 e, ref int edgeCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(edges));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref e;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &edgeCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_InsertUniqueEdge_Private_Static_Void_NativeArray_1_int2_int2_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x0006E6C0 File Offset: 0x0006C8C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629575, RefRangeEnd = 629576, XrefRangeStart = 629533, XrefRangeEnd = 629575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareDelaunay(NativeArray<int2> edges, int edgeCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(edges));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref edgeCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_PrepareDelaunay_Private_Void_NativeArray_1_int2_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x0006E71C File Offset: 0x0006C91C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 629579, RefRangeEnd = 629583, XrefRangeStart = 629576, XrefRangeEnd = 629579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int OppositeOf(int a, int b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_OppositeOf_Private_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x0006E778 File Offset: 0x0006C978
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 629589, RefRangeEnd = 629592, XrefRangeStart = 629583, XrefRangeEnd = 629589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindConstraint(int a, int b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_FindConstraint_Private_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x0006E7D4 File Offset: 0x0006C9D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 629605, RefRangeEnd = 629607, XrefRangeStart = 629592, XrefRangeEnd = 629605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTriangle(int i, int j, int k)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref j;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref k;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_AddTriangle_Private_Void_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x0006E834 File Offset: 0x0006CA34
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 629622, RefRangeEnd = 629631, XrefRangeStart = 629607, XrefRangeEnd = 629622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePair(int r, int j, int k)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref r;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref j;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref k;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_RemovePair_Private_Void_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x0006E894 File Offset: 0x0006CA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 629631, XrefRangeEnd = 629634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTriangle(int i, int j, int k)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref j;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref k;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_RemoveTriangle_Private_Void_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0006E8F4 File Offset: 0x0006CAF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629644, RefRangeEnd = 629645, XrefRangeStart = 629634, XrefRangeEnd = 629644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EdgeFlip(int i, int j)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref j;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_EdgeFlip_Private_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x0006E948 File Offset: 0x0006CB48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 629652, RefRangeEnd = 629656, XrefRangeStart = 629645, XrefRangeEnd = 629652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Flip(NativeArray<float2> points, ref NativeArray<int> stack, ref int stackCount, int a, int b, int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(points));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(stack);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_Flip_Private_Boolean_NativeArray_1_float2_byref_NativeArray_1_Int32_byref_Int32_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0006E9EC File Offset: 0x0006CBEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629664, RefRangeEnd = 629665, XrefRangeStart = 629656, XrefRangeEnd = 629664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray<int3> GetCells(ref int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_GetCells_Private_NativeArray_1_int3_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new NativeArray<int3>(intPtr);
			}
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0006EA38 File Offset: 0x0006CC38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629702, RefRangeEnd = 629703, XrefRangeStart = 629665, XrefRangeEnd = 629702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ApplyDelaunay(NativeArray<float2> points, NativeArray<int2> edges)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(points));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(edges));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_ApplyDelaunay_Internal_Boolean_NativeArray_1_float2_NativeArray_1_int2_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0006EAA8 File Offset: 0x0006CCA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629711, RefRangeEnd = 629712, XrefRangeStart = 629703, XrefRangeEnd = 629711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindNeighbor(NativeArray<int3> cells, int count, int a, int b, int c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cells));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_FindNeighbor_Private_Int32_NativeArray_1_int3_Int32_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0006EB38 File Offset: 0x0006CD38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 629746, RefRangeEnd = 629749, XrefRangeStart = 629712, XrefRangeEnd = 629746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray<int3> Constrain(ref int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_Constrain_Private_NativeArray_1_int3_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new NativeArray<int3>(intPtr);
			}
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x0006EB84 File Offset: 0x0006CD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 629749, XrefRangeEnd = 629756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray<int3> RemoveExterior(ref int cellCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &cellCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_RemoveExterior_Internal_NativeArray_1_int3_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new NativeArray<int3>(intPtr);
			}
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x0006EBD0 File Offset: 0x0006CDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 629756, XrefRangeEnd = 629763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeArray<int3> RemoveInterior(int cellCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cellCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_RemoveInterior_Internal_NativeArray_1_int3_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new NativeArray<int3>(intPtr);
			}
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x0006EC1C File Offset: 0x0006CE1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629810, RefRangeEnd = 629811, XrefRangeStart = 629763, XrefRangeEnd = 629810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Triangulate(NativeArray<float2> points, int pointCount, NativeArray<int2> edges, int edgeCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(points));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(edges));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref edgeCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_Triangulate_Internal_Boolean_NativeArray_1_float2_Int32_NativeArray_1_int2_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x0006ECA8 File Offset: 0x0006CEA8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 629826, RefRangeEnd = 629831, XrefRangeStart = 629811, XrefRangeEnd = 629826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Tessellate(Allocator allocator, NativeArray<float2> pgPoints, int pgPointCount, NativeArray<int2> pgEdges, int pgEdgeCount, ref NativeArray<float2> outputVertices, ref int vertexCount, ref NativeArray<int> outputIndices, ref int indexCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allocator;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pgPoints));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pgPointCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pgEdges));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pgEdgeCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(outputVertices);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vertexCount;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(outputIndices);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_Tessellate_Internal_Static_Boolean_Allocator_NativeArray_1_float2_Int32_NativeArray_1_int2_Int32_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x0006ED78 File Offset: 0x0006CF78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629857, RefRangeEnd = 629858, XrefRangeStart = 629831, XrefRangeEnd = 629857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x0000EBF5 File Offset: 0x0000CDF5
		public Tessellator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0000EBFE File Offset: 0x0000CDFE
		public Tessellator()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tessellator>.NativeClassPtr))
		{
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06001A4F RID: 6735 RVA: 0x0006EDB0 File Offset: 0x0006CFB0
		// (set) Token: 0x06001A50 RID: 6736 RVA: 0x0000EC10 File Offset: 0x0000CE10
		public NativeArray<int2> m_Edges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_Edges);
				return new NativeArray<int2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int2>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_Edges), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int2>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001A51 RID: 6737 RVA: 0x0006EDE0 File Offset: 0x0006CFE0
		// (set) Token: 0x06001A52 RID: 6738 RVA: 0x0000EC3E File Offset: 0x0000CE3E
		public NativeArray<UStar> m_Stars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_Stars);
				return new NativeArray<UStar>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<UStar>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_Stars), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<UStar>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06001A53 RID: 6739 RVA: 0x0006EE10 File Offset: 0x0006D010
		// (set) Token: 0x06001A54 RID: 6740 RVA: 0x0000EC6C File Offset: 0x0000CE6C
		public NativeArray<int3> m_Cells
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_Cells);
				return new NativeArray<int3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int3>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_Cells), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int3>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06001A55 RID: 6741 RVA: 0x0006EE40 File Offset: 0x0006D040
		// (set) Token: 0x06001A56 RID: 6742 RVA: 0x0000EC9A File Offset: 0x0000CE9A
		public unsafe int m_CellCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_CellCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_CellCount)) = value;
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06001A57 RID: 6743 RVA: 0x0006EE68 File Offset: 0x0006D068
		// (set) Token: 0x06001A58 RID: 6744 RVA: 0x0000ECB5 File Offset: 0x0000CEB5
		public NativeArray<int> m_ILArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_ILArray);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_ILArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001A59 RID: 6745 RVA: 0x0006EE98 File Offset: 0x0006D098
		// (set) Token: 0x06001A5A RID: 6746 RVA: 0x0000ECE3 File Offset: 0x0000CEE3
		public NativeArray<int> m_IUArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_IUArray);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_IUArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06001A5B RID: 6747 RVA: 0x0006EEC8 File Offset: 0x0006D0C8
		// (set) Token: 0x06001A5C RID: 6748 RVA: 0x0000ED11 File Offset: 0x0000CF11
		public NativeArray<int> m_SPArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_SPArray);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_SPArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06001A5D RID: 6749 RVA: 0x0006EEF8 File Offset: 0x0006D0F8
		// (set) Token: 0x06001A5E RID: 6750 RVA: 0x0000ED3F File Offset: 0x0000CF3F
		public unsafe int m_NumEdges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_NumEdges);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_NumEdges)) = value;
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001A5F RID: 6751 RVA: 0x0006EF20 File Offset: 0x0006D120
		// (set) Token: 0x06001A60 RID: 6752 RVA: 0x0000ED5A File Offset: 0x0000CF5A
		public unsafe int m_NumHulls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_NumHulls);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_NumHulls)) = value;
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001A61 RID: 6753 RVA: 0x0006EF48 File Offset: 0x0006D148
		// (set) Token: 0x06001A62 RID: 6754 RVA: 0x0000ED75 File Offset: 0x0000CF75
		public unsafe int m_NumPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_NumPoints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_NumPoints)) = value;
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001A63 RID: 6755 RVA: 0x0006EF70 File Offset: 0x0006D170
		// (set) Token: 0x06001A64 RID: 6756 RVA: 0x0000ED90 File Offset: 0x0000CF90
		public unsafe int m_StarCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_StarCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_StarCount)) = value;
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001A65 RID: 6757 RVA: 0x0006EF98 File Offset: 0x0006D198
		// (set) Token: 0x06001A66 RID: 6758 RVA: 0x0000EDAB File Offset: 0x0000CFAB
		public NativeArray<int> m_Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_Flags);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_Flags), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x0006EFC8 File Offset: 0x0006D1C8
		// (set) Token: 0x06001A68 RID: 6760 RVA: 0x0000EDD9 File Offset: 0x0000CFD9
		public NativeArray<int> m_Neighbors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_Neighbors);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_Neighbors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x0006EFF8 File Offset: 0x0006D1F8
		// (set) Token: 0x06001A6A RID: 6762 RVA: 0x0000EE07 File Offset: 0x0000D007
		public NativeArray<int> m_Constraints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_Constraints);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_Constraints), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06001A6B RID: 6763 RVA: 0x0006F028 File Offset: 0x0006D228
		// (set) Token: 0x06001A6C RID: 6764 RVA: 0x0000EE35 File Offset: 0x0000D035
		public unsafe Allocator m_Allocator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_Allocator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tessellator.NativeFieldInfoPtr_m_Allocator)) = value;
			}
		}

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeFieldInfoPtr_m_Edges;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeFieldInfoPtr_m_Stars;

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeFieldInfoPtr_m_Cells;

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeFieldInfoPtr_m_CellCount;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeFieldInfoPtr_m_ILArray;

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeFieldInfoPtr_m_IUArray;

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeFieldInfoPtr_m_SPArray;

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeFieldInfoPtr_m_NumEdges;

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeFieldInfoPtr_m_NumHulls;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeFieldInfoPtr_m_NumPoints;

		// Token: 0x040012F2 RID: 4850
		private static readonly IntPtr NativeFieldInfoPtr_m_StarCount;

		// Token: 0x040012F3 RID: 4851
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x040012F4 RID: 4852
		private static readonly IntPtr NativeFieldInfoPtr_m_Neighbors;

		// Token: 0x040012F5 RID: 4853
		private static readonly IntPtr NativeFieldInfoPtr_m_Constraints;

		// Token: 0x040012F6 RID: 4854
		private static readonly IntPtr NativeFieldInfoPtr_m_Allocator;

		// Token: 0x040012F7 RID: 4855
		private static readonly IntPtr NativeMethodInfoPtr_FindSplit_Private_Static_Single_UHull_UEvent_0;

		// Token: 0x040012F8 RID: 4856
		private static readonly IntPtr NativeMethodInfoPtr_SetAllocator_Private_Void_Allocator_0;

		// Token: 0x040012F9 RID: 4857
		private static readonly IntPtr NativeMethodInfoPtr_AddPoint_Private_Boolean_NativeArray_1_UHull_Int32_NativeArray_1_float2_float2_Int32_0;

		// Token: 0x040012FA RID: 4858
		private static readonly IntPtr NativeMethodInfoPtr_InsertHull_Private_Static_Void_NativeArray_1_UHull_Int32_byref_Int32_UHull_0;

		// Token: 0x040012FB RID: 4859
		private static readonly IntPtr NativeMethodInfoPtr_EraseHull_Private_Static_Void_NativeArray_1_UHull_Int32_byref_Int32_0;

		// Token: 0x040012FC RID: 4860
		private static readonly IntPtr NativeMethodInfoPtr_SplitHulls_Private_Boolean_NativeArray_1_UHull_byref_Int32_NativeArray_1_float2_UEvent_0;

		// Token: 0x040012FD RID: 4861
		private static readonly IntPtr NativeMethodInfoPtr_MergeHulls_Private_Boolean_NativeArray_1_UHull_byref_Int32_NativeArray_1_float2_UEvent_0;

		// Token: 0x040012FE RID: 4862
		private static readonly IntPtr NativeMethodInfoPtr_InsertUniqueEdge_Private_Static_Void_NativeArray_1_int2_int2_byref_Int32_0;

		// Token: 0x040012FF RID: 4863
		private static readonly IntPtr NativeMethodInfoPtr_PrepareDelaunay_Private_Void_NativeArray_1_int2_Int32_0;

		// Token: 0x04001300 RID: 4864
		private static readonly IntPtr NativeMethodInfoPtr_OppositeOf_Private_Int32_Int32_Int32_0;

		// Token: 0x04001301 RID: 4865
		private static readonly IntPtr NativeMethodInfoPtr_FindConstraint_Private_Int32_Int32_Int32_0;

		// Token: 0x04001302 RID: 4866
		private static readonly IntPtr NativeMethodInfoPtr_AddTriangle_Private_Void_Int32_Int32_Int32_0;

		// Token: 0x04001303 RID: 4867
		private static readonly IntPtr NativeMethodInfoPtr_RemovePair_Private_Void_Int32_Int32_Int32_0;

		// Token: 0x04001304 RID: 4868
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTriangle_Private_Void_Int32_Int32_Int32_0;

		// Token: 0x04001305 RID: 4869
		private static readonly IntPtr NativeMethodInfoPtr_EdgeFlip_Private_Void_Int32_Int32_0;

		// Token: 0x04001306 RID: 4870
		private static readonly IntPtr NativeMethodInfoPtr_Flip_Private_Boolean_NativeArray_1_float2_byref_NativeArray_1_Int32_byref_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001307 RID: 4871
		private static readonly IntPtr NativeMethodInfoPtr_GetCells_Private_NativeArray_1_int3_byref_Int32_0;

		// Token: 0x04001308 RID: 4872
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDelaunay_Internal_Boolean_NativeArray_1_float2_NativeArray_1_int2_0;

		// Token: 0x04001309 RID: 4873
		private static readonly IntPtr NativeMethodInfoPtr_FindNeighbor_Private_Int32_NativeArray_1_int3_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400130A RID: 4874
		private static readonly IntPtr NativeMethodInfoPtr_Constrain_Private_NativeArray_1_int3_byref_Int32_0;

		// Token: 0x0400130B RID: 4875
		private static readonly IntPtr NativeMethodInfoPtr_RemoveExterior_Internal_NativeArray_1_int3_byref_Int32_0;

		// Token: 0x0400130C RID: 4876
		private static readonly IntPtr NativeMethodInfoPtr_RemoveInterior_Internal_NativeArray_1_int3_Int32_0;

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeMethodInfoPtr_Triangulate_Internal_Boolean_NativeArray_1_float2_Int32_NativeArray_1_int2_Int32_0;

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeMethodInfoPtr_Tessellate_Internal_Static_Boolean_Allocator_NativeArray_1_float2_Int32_NativeArray_1_int2_Int32_byref_NativeArray_1_float2_byref_Int32_byref_NativeArray_1_Int32_byref_Int32_0;

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;

		// Token: 0x02000206 RID: 518
		[StructLayout(2)]
		public struct TestHullPointL
		{
			// Token: 0x0600239E RID: 9118 RVA: 0x00014695 File Offset: 0x00012895
			// Note: this type is marked as 'beforefieldinit'.
			static TestHullPointL()
			{
				Il2CppClassPointerStore<Tessellator.TestHullPointL>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, "TestHullPointL");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tessellator.TestHullPointL>.NativeClassPtr);
				Tessellator.TestHullPointL.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Boolean_UHull_float2_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator.TestHullPointL>.NativeClassPtr, 100666407);
			}

			// Token: 0x0600239F RID: 9119 RVA: 0x00086014 File Offset: 0x00084214
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 629424, XrefRangeEnd = 629428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Test(UHull h, float2 p, ref float t)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(h));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.TestHullPointL.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Boolean_UHull_float2_byref_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060023A0 RID: 9120 RVA: 0x000146C9 File Offset: 0x000128C9
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Tessellator.TestHullPointL>.NativeClassPtr, ref this));
			}

			// Token: 0x040018D7 RID: 6359
			private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Boolean_UHull_float2_byref_Single_0;
		}

		// Token: 0x02000207 RID: 519
		[StructLayout(2)]
		public struct TestHullPointU
		{
			// Token: 0x060023A1 RID: 9121 RVA: 0x000146DB File Offset: 0x000128DB
			// Note: this type is marked as 'beforefieldinit'.
			static TestHullPointU()
			{
				Il2CppClassPointerStore<Tessellator.TestHullPointU>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, "TestHullPointU");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tessellator.TestHullPointU>.NativeClassPtr);
				Tessellator.TestHullPointU.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Boolean_UHull_float2_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator.TestHullPointU>.NativeClassPtr, 100666408);
			}

			// Token: 0x060023A2 RID: 9122 RVA: 0x00086078 File Offset: 0x00084278
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 629432, RefRangeEnd = 629433, XrefRangeStart = 629428, XrefRangeEnd = 629432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Test(UHull h, float2 p, ref float t)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(h));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.TestHullPointU.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Boolean_UHull_float2_byref_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060023A3 RID: 9123 RVA: 0x0001470F File Offset: 0x0001290F
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Tessellator.TestHullPointU>.NativeClassPtr, ref this));
			}

			// Token: 0x040018D8 RID: 6360
			private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Boolean_UHull_float2_byref_Single_0;
		}

		// Token: 0x02000208 RID: 520
		[StructLayout(2)]
		public struct TestHullEventLe
		{
			// Token: 0x060023A4 RID: 9124 RVA: 0x00014721 File Offset: 0x00012921
			// Note: this type is marked as 'beforefieldinit'.
			static TestHullEventLe()
			{
				Il2CppClassPointerStore<Tessellator.TestHullEventLe>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, "TestHullEventLe");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tessellator.TestHullEventLe>.NativeClassPtr);
				Tessellator.TestHullEventLe.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Boolean_UHull_UEvent_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator.TestHullEventLe>.NativeClassPtr, 100666409);
			}

			// Token: 0x060023A5 RID: 9125 RVA: 0x000860DC File Offset: 0x000842DC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 629434, RefRangeEnd = 629435, XrefRangeStart = 629433, XrefRangeEnd = 629434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Test(UHull h, UEvent p, ref float t)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(h));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.TestHullEventLe.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Boolean_UHull_UEvent_byref_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060023A6 RID: 9126 RVA: 0x00014755 File Offset: 0x00012955
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Tessellator.TestHullEventLe>.NativeClassPtr, ref this));
			}

			// Token: 0x040018D9 RID: 6361
			private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Boolean_UHull_UEvent_byref_Single_0;
		}

		// Token: 0x02000209 RID: 521
		[StructLayout(2)]
		public struct TestHullEventE
		{
			// Token: 0x060023A7 RID: 9127 RVA: 0x00014767 File Offset: 0x00012967
			// Note: this type is marked as 'beforefieldinit'.
			static TestHullEventE()
			{
				Il2CppClassPointerStore<Tessellator.TestHullEventE>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, "TestHullEventE");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tessellator.TestHullEventE>.NativeClassPtr);
				Tessellator.TestHullEventE.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Boolean_UHull_UEvent_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator.TestHullEventE>.NativeClassPtr, 100666410);
			}

			// Token: 0x060023A8 RID: 9128 RVA: 0x00086140 File Offset: 0x00084340
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 629436, RefRangeEnd = 629437, XrefRangeStart = 629435, XrefRangeEnd = 629436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Test(UHull h, UEvent p, ref float t)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(h));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.TestHullEventE.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Boolean_UHull_UEvent_byref_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060023A9 RID: 9129 RVA: 0x0001479B File Offset: 0x0001299B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Tessellator.TestHullEventE>.NativeClassPtr, ref this));
			}

			// Token: 0x040018DA RID: 6362
			private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Boolean_UHull_UEvent_byref_Single_0;
		}

		// Token: 0x0200020A RID: 522
		[StructLayout(2)]
		public struct TestEdgePointE
		{
			// Token: 0x060023AA RID: 9130 RVA: 0x000147AD File Offset: 0x000129AD
			// Note: this type is marked as 'beforefieldinit'.
			static TestEdgePointE()
			{
				Il2CppClassPointerStore<Tessellator.TestEdgePointE>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, "TestEdgePointE");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tessellator.TestEdgePointE>.NativeClassPtr);
				Tessellator.TestEdgePointE.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Boolean_int2_int2_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator.TestEdgePointE>.NativeClassPtr, 100666411);
			}

			// Token: 0x060023AB RID: 9131 RVA: 0x000861A4 File Offset: 0x000843A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 629437, XrefRangeEnd = 629438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Test(int2 h, int2 p, ref float t)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref h;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.TestEdgePointE.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Boolean_int2_int2_byref_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060023AC RID: 9132 RVA: 0x000147E1 File Offset: 0x000129E1
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Tessellator.TestEdgePointE>.NativeClassPtr, ref this));
			}

			// Token: 0x040018DB RID: 6363
			private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Boolean_int2_int2_byref_Single_0;
		}

		// Token: 0x0200020B RID: 523
		[StructLayout(2)]
		public struct TestCellE
		{
			// Token: 0x060023AD RID: 9133 RVA: 0x000147F3 File Offset: 0x000129F3
			// Note: this type is marked as 'beforefieldinit'.
			static TestCellE()
			{
				Il2CppClassPointerStore<Tessellator.TestCellE>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tessellator>.NativeClassPtr, "TestCellE");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tessellator.TestCellE>.NativeClassPtr);
				Tessellator.TestCellE.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Boolean_int3_int3_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tessellator.TestCellE>.NativeClassPtr, 100666412);
			}

			// Token: 0x060023AE RID: 9134 RVA: 0x00086200 File Offset: 0x00084400
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 629438, XrefRangeEnd = 629439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Test(int3 h, int3 p, ref float t)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref h;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tessellator.TestCellE.NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Boolean_int3_int3_byref_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060023AF RID: 9135 RVA: 0x00014827 File Offset: 0x00012A27
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Tessellator.TestCellE>.NativeClassPtr, ref this));
			}

			// Token: 0x040018DC RID: 6364
			private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Virtual_Final_New_Boolean_int3_int3_byref_Single_0;
		}
	}
}
