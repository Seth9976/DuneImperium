using System;
using System.Runtime.InteropServices;
using Canis.utils;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Utils.enums;

namespace Utils
{
	// Token: 0x02000032 RID: 50
	public static class ListUtil : Object
	{
		// Token: 0x060001EC RID: 492 RVA: 0x0000BF4C File Offset: 0x0000A14C
		// Note: this type is marked as 'beforefieldinit'.
		static ListUtil()
		{
			Il2CppClassPointerStore<ListUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Utils", "ListUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil>.NativeClassPtr);
			ListUtil.NativeFieldInfoPtr__random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "_random");
			ListUtil.NativeMethodInfoPtr_Shuffle_Public_Static_Void_IList_1_T_Int32_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663581);
			ListUtil.NativeMethodInfoPtr_NonAllocatingUnionWith_Public_Static_Void_ICollection_1_T_IReadOnlyList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663582);
			ListUtil.NativeMethodInfoPtr_NonAllocatingUnionWith_Public_Static_Void_ICollection_1_T_HashSet_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663583);
			ListUtil.NativeMethodInfoPtr_NonAllocatingUnionWith_Public_Static_Void_ICollection_1_T_VersionedSet_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663584);
			ListUtil.NativeMethodInfoPtr_NonAllocatingExceptWith_Public_Static_Void_ICollection_1_T_IReadOnlyList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663585);
			ListUtil.NativeMethodInfoPtr_NonAllocatingExceptWith_Public_Static_Void_ICollection_1_T_HashSet_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663586);
			ListUtil.NativeMethodInfoPtr_NonAllocatingExceptWith_Public_Static_Void_ICollection_1_T_VersionedSet_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663587);
			ListUtil.NativeMethodInfoPtr_Without_Public_Static_IEnumerable_1_T_ICollection_1_T_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663588);
			ListUtil.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_IReadOnlyList_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663589);
			ListUtil.NativeMethodInfoPtr_Only_Public_Static_IEnumerable_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663590);
			ListUtil.NativeMethodInfoPtr_Only_Public_Static_IEnumerable_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663591);
			ListUtil.NativeMethodInfoPtr_As_Public_Static_Boolean_Object_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663592);
			ListUtil.NativeMethodInfoPtr_AsOption_Public_Static_IEnumerable_1_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663593);
			ListUtil.NativeMethodInfoPtr_PostOrderTraversal_Public_Static_IEnumerable_1_TValue_TValue_Func_2_TValue_IEnumerable_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663594);
			ListUtil.NativeMethodInfoPtr_SelectWhere_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663595);
			ListUtil.NativeMethodInfoPtr_SelectWhere_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_ValueTuple_2_Boolean_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663596);
			ListUtil.NativeMethodInfoPtr_TakeWhere_Public_Static_IEnumerable_1_T_IEnumerable_1_T_Func_2_T_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663597);
			ListUtil.NativeMethodInfoPtr_IsEmpty_Public_Static_Boolean_IEnumerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663598);
			ListUtil.NativeMethodInfoPtr_FirstIndexOf_Public_Static_Int32_IEnumerable_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663599);
			ListUtil.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_IReadOnlyList_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663600);
			ListUtil.NativeMethodInfoPtr_HasSameContents_Public_Static_Boolean_ICollection_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663601);
			ListUtil.NativeMethodInfoPtr_Combinations_Public_Static_IEnumerable_1_Il2CppArrayBase_1_T_IReadOnlyList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663602);
			ListUtil.NativeMethodInfoPtr_Combinations_Public_Static_IEnumerable_1_Il2CppArrayBase_1_T_IReadOnlyList_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663603);
			ListUtil.NativeMethodInfoPtr_CombinationsInRange_Public_Static_IEnumerable_1_Il2CppArrayBase_1_T_IReadOnlyList_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663604);
			ListUtil.NativeMethodInfoPtr_CombinationsWithRepetition_Public_Static_IEnumerable_1_IEnumerable_1_T_IReadOnlyList_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663605);
			ListUtil.NativeMethodInfoPtr_Permutations_Public_Static_IEnumerable_1_Il2CppArrayBase_1_T_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663606);
			ListUtil.NativeMethodInfoPtr_CartesianProduct_Public_Static_IEnumerable_1_IEnumerable_1_T_IEnumerable_1_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663607);
			ListUtil.NativeMethodInfoPtr_MinOrElse_Public_Static_T_IEnumerable_1_T_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663608);
			ListUtil.NativeMethodInfoPtr_MaxOrElse_Public_Static_T_IEnumerable_1_T_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663609);
			ListUtil.NativeMethodInfoPtr_MinBy_Public_Static_T_IEnumerable_1_T_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663610);
			ListUtil.NativeMethodInfoPtr_MinBy_Public_Static_T_IEnumerable_1_T_Func_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663611);
			ListUtil.NativeMethodInfoPtr_MaxBy_Public_Static_T_IEnumerable_1_T_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663612);
			ListUtil.NativeMethodInfoPtr_MaxBy_Public_Static_T_IEnumerable_1_T_Func_2_T_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663613);
			ListUtil.NativeMethodInfoPtr_MinByOrElse_Public_Static_T_IEnumerable_1_T_IComparer_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663614);
			ListUtil.NativeMethodInfoPtr_MaxByOrElse_Public_Static_T_IEnumerable_1_T_IComparer_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663615);
			ListUtil.NativeMethodInfoPtr_MaxByOrElse_Public_Static_T_IEnumerable_1_T_Func_2_T_Double_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663616);
			ListUtil.NativeMethodInfoPtr_MinByOrElse_Public_Static_T_IEnumerable_1_T_Func_2_T_Double_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663617);
			ListUtil.NativeMethodInfoPtr_AllMinBy_Public_Static_List_1_T_IEnumerable_1_T_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663618);
			ListUtil.NativeMethodInfoPtr_AllMaxBy_Public_Static_List_1_T_IEnumerable_1_T_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663619);
			ListUtil.NativeMethodInfoPtr_DistinctBy_Public_Static_IEnumerable_1_T_IEnumerable_1_T_Func_2_T_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663620);
			ListUtil.NativeMethodInfoPtr_Interleave_Public_Static_IEnumerable_1_T_IEnumerable_1_T_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663621);
			ListUtil.NativeMethodInfoPtr_Windows_Public_Static_IEnumerable_1_ArraySegment_1_T_IEnumerable_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663622);
			ListUtil.NativeMethodInfoPtr_RefGaps_Public_Static_IEnumerable_1_ValueTuple_3_Int32_T_T_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663623);
			ListUtil.NativeMethodInfoPtr_Gaps_Public_Static_IEnumerable_1_ValueTuple_3_Int32_Nullable_1_T_Nullable_1_T_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663624);
			ListUtil.NativeMethodInfoPtr_Batches_Public_Static_IEnumerable_1_IEnumerable_1_T_IEnumerable_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663625);
			ListUtil.NativeMethodInfoPtr_Repeated_Public_Static_IEnumerable_1_T_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663626);
			ListUtil.NativeMethodInfoPtr_Partition_Public_Static_ValueTuple_2_List_1_T_List_1_T_IEnumerable_1_T_Func_2_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663627);
			ListUtil.NativeMethodInfoPtr_Shift_Public_Static_IEnumerable_1_T_IReadOnlyList_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663628);
			ListUtil.NativeMethodInfoPtr_HeadTail_Public_Static_Either_2_ValueTuple_2_T_IEnumerable_1_T_ValueTuple_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663629);
			ListUtil.NativeMethodInfoPtr_HeadTailUnsafe_Public_Static_ValueTuple_2_T_IEnumerable_1_T_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663630);
			ListUtil.NativeMethodInfoPtr_EnumerateRest_Private_Static_IEnumerable_1_T_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663631);
			ListUtil.NativeMethodInfoPtr_Pivot_Public_Static_IEnumerable_1_IEnumerable_1_T_IEnumerable_1_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663632);
			ListUtil.NativeMethodInfoPtr_Sum_Public_Static_UInt64_IEnumerable_1_T_Func_2_T_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663633);
			ListUtil.NativeMethodInfoPtr_SumVersions_Public_Static_UInt64_IEnumerable_1_IVersionedModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663634);
			ListUtil.NativeMethodInfoPtr_SumVersions_Public_Static_UInt64_Dictionary_2_TK_TV_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663635);
			ListUtil.NativeMethodInfoPtr_RemoveAll_Public_Static_Void_Dictionary_2_TK_TV_Predicate_1_TV_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663636);
			ListUtil.NativeMethodInfoPtr_Method_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, 100663638);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000C404 File Offset: 0x0000A604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1182668, RefRangeEnd = 1182669, XrefRangeStart = 1182653, XrefRangeEnd = 1182668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Shuffle<T>(this IList<T> list, int startingIndex = 0, Random randomGenerator = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startingIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(randomGenerator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_Shuffle_Public_Static_Void_IList_1_T_Int32_Random_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000C45C File Offset: 0x0000A65C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1182682, RefRangeEnd = 1182684, XrefRangeStart = 1182669, XrefRangeEnd = 1182682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NonAllocatingUnionWith<T>(this ICollection<T> collection, IReadOnlyList<T> other)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_NonAllocatingUnionWith_Public_Static_Void_ICollection_1_T_IReadOnlyList_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000C4A4 File Offset: 0x0000A6A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1182696, RefRangeEnd = 1182698, XrefRangeStart = 1182684, XrefRangeEnd = 1182696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NonAllocatingUnionWith<T>(this ICollection<T> collection, HashSet<T> other)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_NonAllocatingUnionWith_Public_Static_Void_ICollection_1_T_HashSet_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000C4EC File Offset: 0x0000A6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182698, XrefRangeEnd = 1182720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NonAllocatingUnionWith<T>(this ICollection<T> collection, VersionedSet<T> other)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_NonAllocatingUnionWith_Public_Static_Void_ICollection_1_T_VersionedSet_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000C534 File Offset: 0x0000A734
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1182731, RefRangeEnd = 1182733, XrefRangeStart = 1182720, XrefRangeEnd = 1182731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NonAllocatingExceptWith<T>(this ICollection<T> collection, IReadOnlyList<T> other)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_NonAllocatingExceptWith_Public_Static_Void_ICollection_1_T_IReadOnlyList_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000C57C File Offset: 0x0000A77C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1182743, RefRangeEnd = 1182744, XrefRangeStart = 1182733, XrefRangeEnd = 1182743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NonAllocatingExceptWith<T>(this ICollection<T> collection, HashSet<T> other)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_NonAllocatingExceptWith_Public_Static_Void_ICollection_1_T_HashSet_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000C5C4 File Offset: 0x0000A7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182744, XrefRangeEnd = 1182763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NonAllocatingExceptWith<T>(this ICollection<T> collection, VersionedSet<T> other)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_NonAllocatingExceptWith_Public_Static_Void_ICollection_1_T_VersionedSet_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000C60C File Offset: 0x0000A80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182763, XrefRangeEnd = 1182785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<T> Without<T>(this ICollection<T> collection, IEnumerable<T> toRemoves)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toRemoves);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_Without_Public_Static_IEnumerable_1_T_ICollection_1_T_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000C664 File Offset: 0x0000A864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1182802, RefRangeEnd = 1182803, XrefRangeStart = 1182785, XrefRangeEnd = 1182802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf<T>(this IReadOnlyList<T> list, T item)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref item;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_IReadOnlyList_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1182807, RefRangeEnd = 1182809, XrefRangeStart = 1182803, XrefRangeEnd = 1182807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<T> Only<T>(this T element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = element;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref element;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_Only_Public_Static_IEnumerable_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr4) : null;
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000C76C File Offset: 0x0000A96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182809, XrefRangeEnd = 1182832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<T> Only<T>([Optional] Il2CppArrayBase<T> elements)
		{
			if (elements == null)
			{
				elements = new Il2CppReferenceArray<T>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_Only_Public_Static_IEnumerable_1_T_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000C7C0 File Offset: 0x0000A9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182832, XrefRangeEnd = 1182838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool As<T>(this Object obj, Action<T> action)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_As_Public_Static_Boolean_Object_Action_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000C814 File Offset: 0x0000AA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182838, XrefRangeEnd = 1182844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<T> AsOption<T>(this Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_AsOption_Public_Static_IEnumerable_1_T_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000C858 File Offset: 0x0000AA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182844, XrefRangeEnd = 1182853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TValue> PostOrderTraversal<TValue>(this TValue root, Func<TValue, IEnumerable<TValue>> descendantsSelector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue = root;
					intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref root;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(descendantsSelector);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_PostOrderTraversal_Public_Static_IEnumerable_1_TValue_TValue_Func_2_TValue_IEnumerable_1_TValue_0<TValue>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<TValue>>(intPtr4) : null;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000C8E4 File Offset: 0x0000AAE4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1182860, RefRangeEnd = 1182865, XrefRangeStart = 1182853, XrefRangeEnd = 1182860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> SelectWhere<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, bool> condition, Func<TSource, TResult> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(condition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_SelectWhere_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0<TSource, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000C94C File Offset: 0x0000AB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> SelectWhere<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, ValueTuple<bool, TResult>> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_SelectWhere_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_ValueTuple_2_Boolean_TResult_0<TSource, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000C9A4 File Offset: 0x0000ABA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182865, XrefRangeEnd = 1182877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<T> TakeWhere<T>(this IEnumerable<T> source, Func<T, bool> condition, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(condition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_TakeWhere_Public_Static_IEnumerable_1_T_IEnumerable_1_T_Func_2_T_Boolean_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000CA08 File Offset: 0x0000AC08
		[CallerCount(193)]
		[CachedScanResults(RefRangeStart = 1182881, RefRangeEnd = 1183074, XrefRangeStart = 1182877, XrefRangeEnd = 1182881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsEmpty(this IEnumerable list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.NativeMethodInfoPtr_IsEmpty_Public_Static_Boolean_IEnumerable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000CA4C File Offset: 0x0000AC4C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1183092, RefRangeEnd = 1183097, XrefRangeStart = 1183074, XrefRangeEnd = 1183092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FirstIndexOf<T>(this IEnumerable<T> list, Predicate<T> condition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(condition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_FirstIndexOf_Public_Static_Int32_IEnumerable_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000CAA0 File Offset: 0x0000ACA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183097, XrefRangeEnd = 1183103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LastIndexOf<T>(this IReadOnlyList<T> list, Predicate<T> condition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(condition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_LastIndexOf_Public_Static_Int32_IReadOnlyList_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000CAF4 File Offset: 0x0000ACF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1183168, RefRangeEnd = 1183169, XrefRangeStart = 1183103, XrefRangeEnd = 1183168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasSameContents(this ICollection a, ICollection b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.NativeMethodInfoPtr_HasSameContents_Public_Static_Boolean_ICollection_ICollection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000CB48 File Offset: 0x0000AD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183169, XrefRangeEnd = 1183173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Il2CppArrayBase<T>> Combinations<T>(this IReadOnlyList<T> elements)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_Combinations_Public_Static_IEnumerable_1_Il2CppArrayBase_1_T_IReadOnlyList_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Il2CppArrayBase<T>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000CB8C File Offset: 0x0000AD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183173, XrefRangeEnd = 1183182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Il2CppArrayBase<T>> Combinations<T>(this IReadOnlyList<T> elements, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_Combinations_Public_Static_IEnumerable_1_Il2CppArrayBase_1_T_IReadOnlyList_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Il2CppArrayBase<T>>>(intPtr3) : null;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000CBE0 File Offset: 0x0000ADE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183182, XrefRangeEnd = 1183186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Il2CppArrayBase<T>> CombinationsInRange<T>(this IReadOnlyList<T> elements, int minLength = 0, int maxLength = 1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_CombinationsInRange_Public_Static_IEnumerable_1_Il2CppArrayBase_1_T_IReadOnlyList_1_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Il2CppArrayBase<T>>>(intPtr3) : null;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000CC40 File Offset: 0x0000AE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183186, XrefRangeEnd = 1183202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IEnumerable<T>> CombinationsWithRepetition<T>(this IReadOnlyList<T> list, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_CombinationsWithRepetition_Public_Static_IEnumerable_1_IEnumerable_1_T_IReadOnlyList_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<T>>>(intPtr3) : null;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000CC94 File Offset: 0x0000AE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Il2CppArrayBase<T>> Permutations<T>(this IEnumerable<T> sequence)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_Permutations_Public_Static_IEnumerable_1_Il2CppArrayBase_1_T_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Il2CppArrayBase<T>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183202, XrefRangeEnd = 1183227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IEnumerable<T>> CartesianProduct<T>(this IEnumerable<IEnumerable<T>> sequences)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequences);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_CartesianProduct_Public_Static_IEnumerable_1_IEnumerable_1_T_IEnumerable_1_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<T>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000CD1C File Offset: 0x0000AF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183227, XrefRangeEnd = 1183241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T MinOrElse<T>(this IEnumerable<T> sequence, Func<T> def)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_MinOrElse_Public_Static_T_IEnumerable_1_T_Func_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000CD6C File Offset: 0x0000AF6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1183248, RefRangeEnd = 1183250, XrefRangeStart = 1183241, XrefRangeEnd = 1183248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T MaxOrElse<T>(this IEnumerable<T> sequence, Func<T> def)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_MaxOrElse_Public_Static_T_IEnumerable_1_T_Func_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000CDBC File Offset: 0x0000AFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183250, XrefRangeEnd = 1183282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T MinBy<T>(this IEnumerable<T> sequence, IComparer<T> cmp) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_MinBy_Public_Static_T_IEnumerable_1_T_IComparer_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000CE0C File Offset: 0x0000B00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183282, XrefRangeEnd = 1183311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T MinBy<T>(this IEnumerable<T> sequence, Func<T, double> cFunc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cFunc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_MinBy_Public_Static_T_IEnumerable_1_T_Func_2_T_Double_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000CE5C File Offset: 0x0000B05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183311, XrefRangeEnd = 1183343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T MaxBy<T>(this IEnumerable<T> sequence, IComparer<T> cmp) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_MaxBy_Public_Static_T_IEnumerable_1_T_IComparer_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000CEAC File Offset: 0x0000B0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183343, XrefRangeEnd = 1183372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T MaxBy<T>(this IEnumerable<T> sequence, Func<T, double> cFunc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cFunc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_MaxBy_Public_Static_T_IEnumerable_1_T_Func_2_T_Double_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000CEFC File Offset: 0x0000B0FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1183390, RefRangeEnd = 1183391, XrefRangeStart = 1183372, XrefRangeEnd = 1183390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T MinByOrElse<T>(this IEnumerable<T> sequence, IComparer<T> cmp, T defaultT = default(T)) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmp);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = defaultT;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref defaultT;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_MinByOrElse_Public_Static_T_IEnumerable_1_T_IComparer_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000CF94 File Offset: 0x0000B194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183391, XrefRangeEnd = 1183424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T MaxByOrElse<T>(this IEnumerable<T> sequence, IComparer<T> cmp, T defaultT = default(T)) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmp);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = defaultT;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref defaultT;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_MaxByOrElse_Public_Static_T_IEnumerable_1_T_IComparer_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000D02C File Offset: 0x0000B22C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1183440, RefRangeEnd = 1183442, XrefRangeStart = 1183424, XrefRangeEnd = 1183440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T MaxByOrElse<T>(this IEnumerable<T> sequence, Func<T, double> cFunc, T defaultT = default(T))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cFunc);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = defaultT;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref defaultT;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_MaxByOrElse_Public_Static_T_IEnumerable_1_T_Func_2_T_Double_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000D0C4 File Offset: 0x0000B2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183442, XrefRangeEnd = 1183472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T MinByOrElse<T>(this IEnumerable<T> sequence, Func<T, double> cFunc, T defaultT = default(T))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cFunc);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = defaultT;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref defaultT;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_MinByOrElse_Public_Static_T_IEnumerable_1_T_Func_2_T_Double_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000D15C File Offset: 0x0000B35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183472, XrefRangeEnd = 1183509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> AllMinBy<T>(this IEnumerable<T> sequence, IComparer<T> cmp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_AllMinBy_Public_Static_List_1_T_IEnumerable_1_T_IComparer_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000D1B4 File Offset: 0x0000B3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183509, XrefRangeEnd = 1183546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> AllMaxBy<T>(this IEnumerable<T> sequence, IComparer<T> cmp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_AllMaxBy_Public_Static_List_1_T_IEnumerable_1_T_IComparer_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000D20C File Offset: 0x0000B40C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 756206, RefRangeEnd = 756213, XrefRangeStart = 756206, XrefRangeEnd = 756213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<T> DistinctBy<T, U>(this IEnumerable<T> sequence, Func<T, U> keyGen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyGen);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_DistinctBy_Public_Static_IEnumerable_1_T_IEnumerable_1_T_Func_2_T_U_0<T, U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000D264 File Offset: 0x0000B464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183546, XrefRangeEnd = 1183555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<T> Interleave<T>(this IEnumerable<T> sequence, IEnumerable<T> otherSequence)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(otherSequence);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_Interleave_Public_Static_IEnumerable_1_T_IEnumerable_1_T_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000D2BC File Offset: 0x0000B4BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1004455, RefRangeEnd = 1004457, XrefRangeStart = 1004455, XrefRangeEnd = 1004457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<ArraySegment<T>> Windows<T>(this IEnumerable<T> sequence, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_Windows_Public_Static_IEnumerable_1_ArraySegment_1_T_IEnumerable_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ArraySegment<T>>>(intPtr3) : null;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000D310 File Offset: 0x0000B510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183555, XrefRangeEnd = 1183560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<ValueTuple<int, T, T>> RefGaps<T>(this IEnumerable<T> sequence) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_RefGaps_Public_Static_IEnumerable_1_ValueTuple_3_Int32_T_T_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<int, T, T>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000D354 File Offset: 0x0000B554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<ValueTuple<int, Nullable<T>, Nullable<T>>> Gaps<T>(this IEnumerable<T> sequence) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_Gaps_Public_Static_IEnumerable_1_ValueTuple_3_Int32_Nullable_1_T_Nullable_1_T_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<int, Nullable<T>, Nullable<T>>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000D398 File Offset: 0x0000B598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183560, XrefRangeEnd = 1183564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IEnumerable<T>> Batches<T>(this IEnumerable<T> input, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_Batches_Public_Static_IEnumerable_1_IEnumerable_1_T_IEnumerable_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<T>>>(intPtr3) : null;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000D3EC File Offset: 0x0000B5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<T> Repeated<T>(this IEnumerable<T> sequence)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_Repeated_Public_Static_IEnumerable_1_T_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000D430 File Offset: 0x0000B630
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1183590, RefRangeEnd = 1183593, XrefRangeStart = 1183564, XrefRangeEnd = 1183590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<List<T>, List<T>> Partition<T>(this IEnumerable<T> sequence, Func<T, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_Partition_Public_Static_ValueTuple_2_List_1_T_List_1_T_IEnumerable_1_T_Func_2_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<List<T>, List<T>>(intPtr);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000D480 File Offset: 0x0000B680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183593, XrefRangeEnd = 1183625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<T> Shift<T>(this IReadOnlyList<T> sequence, int initAmt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initAmt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_Shift_Public_Static_IEnumerable_1_T_IReadOnlyList_1_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000D4D4 File Offset: 0x0000B6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183625, XrefRangeEnd = 1183638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Either<ValueTuple<T, IEnumerable<T>>, ValueTuple> HeadTail<T>(this IEnumerable<T> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_HeadTail_Public_Static_Either_2_ValueTuple_2_T_IEnumerable_1_T_ValueTuple_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Either<ValueTuple<T, IEnumerable<T>>, ValueTuple>>(intPtr3) : null;
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000D518 File Offset: 0x0000B718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183638, XrefRangeEnd = 1183657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<T, IEnumerable<T>> HeadTailUnsafe<T>(this IEnumerable<T> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_HeadTailUnsafe_Public_Static_ValueTuple_2_T_IEnumerable_1_T_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<T, IEnumerable<T>>(intPtr);
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000D554 File Offset: 0x0000B754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<T> EnumerateRest<T>(IEnumerator<T> enumerator)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_EnumerateRest_Private_Static_IEnumerable_1_T_IEnumerator_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000D598 File Offset: 0x0000B798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<IEnumerable<T>> Pivot<T>(this IEnumerable<IEnumerable<T>> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_Pivot_Public_Static_IEnumerable_1_IEnumerable_1_T_IEnumerable_1_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<T>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000D5DC File Offset: 0x0000B7DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1183673, RefRangeEnd = 1183674, XrefRangeStart = 1183657, XrefRangeEnd = 1183673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Sum<T>(this IEnumerable<T> source, Func<T, ulong> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_Sum_Public_Static_UInt64_IEnumerable_1_T_Func_2_T_UInt64_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000D630 File Offset: 0x0000B830
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1183708, RefRangeEnd = 1183712, XrefRangeStart = 1183674, XrefRangeEnd = 1183708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong SumVersions(this IEnumerable<IVersionedModel> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.NativeMethodInfoPtr_SumVersions_Public_Static_UInt64_IEnumerable_1_IVersionedModel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000D674 File Offset: 0x0000B874
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1183723, RefRangeEnd = 1183725, XrefRangeStart = 1183712, XrefRangeEnd = 1183723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong SumVersions<TK, TV>(this Dictionary<TK, TV> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_SumVersions_Public_Static_UInt64_Dictionary_2_TK_TV_0<TK, TV>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000D6B8 File Offset: 0x0000B8B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1183743, RefRangeEnd = 1183744, XrefRangeStart = 1183725, XrefRangeEnd = 1183743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveAll<TK, TV>(this Dictionary<TK, TV> source, Predicate<TV> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_RemoveAll_Public_Static_Void_Dictionary_2_TK_TV_Predicate_1_TV_0<TK, TV>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000D700 File Offset: 0x0000B900
		[CallerCount(0)]
		public unsafe static int Method_Internal_Static_Int32_Int32_Int32_0<T>(int k, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref k;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.MethodInfoStoreGeneric_Method_Internal_Static_Int32_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002976 File Offset: 0x00000B76
		public ListUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0000D74C File Offset: 0x0000B94C
		// (set) Token: 0x06000228 RID: 552 RVA: 0x0000297F File Offset: 0x00000B7F
		public unsafe static Random _random
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ListUtil.NativeFieldInfoPtr__random, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Random>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ListUtil.NativeFieldInfoPtr__random, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeFieldInfoPtr__random;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_Shuffle_Public_Static_Void_IList_1_T_Int32_Random_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_NonAllocatingUnionWith_Public_Static_Void_ICollection_1_T_IReadOnlyList_1_T_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_NonAllocatingUnionWith_Public_Static_Void_ICollection_1_T_HashSet_1_T_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_NonAllocatingUnionWith_Public_Static_Void_ICollection_1_T_VersionedSet_1_T_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_NonAllocatingExceptWith_Public_Static_Void_ICollection_1_T_IReadOnlyList_1_T_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_NonAllocatingExceptWith_Public_Static_Void_ICollection_1_T_HashSet_1_T_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_NonAllocatingExceptWith_Public_Static_Void_ICollection_1_T_VersionedSet_1_T_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_Without_Public_Static_IEnumerable_1_T_ICollection_1_T_IEnumerable_1_T_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_IReadOnlyList_1_T_T_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_Only_Public_Static_IEnumerable_1_T_T_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_Only_Public_Static_IEnumerable_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_As_Public_Static_Boolean_Object_Action_1_T_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_AsOption_Public_Static_IEnumerable_1_T_Object_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_PostOrderTraversal_Public_Static_IEnumerable_1_TValue_TValue_Func_2_TValue_IEnumerable_1_TValue_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_SelectWhere_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_SelectWhere_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_ValueTuple_2_Boolean_TResult_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_TakeWhere_Public_Static_IEnumerable_1_T_IEnumerable_1_T_Func_2_T_Boolean_Int32_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_IsEmpty_Public_Static_Boolean_IEnumerable_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_FirstIndexOf_Public_Static_Int32_IEnumerable_1_T_Predicate_1_T_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_IReadOnlyList_1_T_Predicate_1_T_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_HasSameContents_Public_Static_Boolean_ICollection_ICollection_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_Combinations_Public_Static_IEnumerable_1_Il2CppArrayBase_1_T_IReadOnlyList_1_T_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_Combinations_Public_Static_IEnumerable_1_Il2CppArrayBase_1_T_IReadOnlyList_1_T_Int32_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_CombinationsInRange_Public_Static_IEnumerable_1_Il2CppArrayBase_1_T_IReadOnlyList_1_T_Int32_Int32_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_CombinationsWithRepetition_Public_Static_IEnumerable_1_IEnumerable_1_T_IReadOnlyList_1_T_Int32_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_Permutations_Public_Static_IEnumerable_1_Il2CppArrayBase_1_T_IEnumerable_1_T_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_CartesianProduct_Public_Static_IEnumerable_1_IEnumerable_1_T_IEnumerable_1_IEnumerable_1_T_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_MinOrElse_Public_Static_T_IEnumerable_1_T_Func_1_T_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_MaxOrElse_Public_Static_T_IEnumerable_1_T_Func_1_T_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_MinBy_Public_Static_T_IEnumerable_1_T_IComparer_1_T_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_MinBy_Public_Static_T_IEnumerable_1_T_Func_2_T_Double_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_MaxBy_Public_Static_T_IEnumerable_1_T_IComparer_1_T_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_MaxBy_Public_Static_T_IEnumerable_1_T_Func_2_T_Double_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_MinByOrElse_Public_Static_T_IEnumerable_1_T_IComparer_1_T_T_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_MaxByOrElse_Public_Static_T_IEnumerable_1_T_IComparer_1_T_T_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_MaxByOrElse_Public_Static_T_IEnumerable_1_T_Func_2_T_Double_T_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_MinByOrElse_Public_Static_T_IEnumerable_1_T_Func_2_T_Double_T_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_AllMinBy_Public_Static_List_1_T_IEnumerable_1_T_IComparer_1_T_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_AllMaxBy_Public_Static_List_1_T_IEnumerable_1_T_IComparer_1_T_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_DistinctBy_Public_Static_IEnumerable_1_T_IEnumerable_1_T_Func_2_T_U_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_Interleave_Public_Static_IEnumerable_1_T_IEnumerable_1_T_IEnumerable_1_T_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_Windows_Public_Static_IEnumerable_1_ArraySegment_1_T_IEnumerable_1_T_Int32_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_RefGaps_Public_Static_IEnumerable_1_ValueTuple_3_Int32_T_T_IEnumerable_1_T_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_Gaps_Public_Static_IEnumerable_1_ValueTuple_3_Int32_Nullable_1_T_Nullable_1_T_IEnumerable_1_T_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_Batches_Public_Static_IEnumerable_1_IEnumerable_1_T_IEnumerable_1_T_Int32_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_Repeated_Public_Static_IEnumerable_1_T_IEnumerable_1_T_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_Partition_Public_Static_ValueTuple_2_List_1_T_List_1_T_IEnumerable_1_T_Func_2_T_Boolean_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_Shift_Public_Static_IEnumerable_1_T_IReadOnlyList_1_T_Int32_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_HeadTail_Public_Static_Either_2_ValueTuple_2_T_IEnumerable_1_T_ValueTuple_IEnumerable_1_T_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_HeadTailUnsafe_Public_Static_ValueTuple_2_T_IEnumerable_1_T_IEnumerable_1_T_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_EnumerateRest_Private_Static_IEnumerable_1_T_IEnumerator_1_T_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_Pivot_Public_Static_IEnumerable_1_IEnumerable_1_T_IEnumerable_1_IEnumerable_1_T_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_Sum_Public_Static_UInt64_IEnumerable_1_T_Func_2_T_UInt64_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_SumVersions_Public_Static_UInt64_IEnumerable_1_IVersionedModel_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_SumVersions_Public_Static_UInt64_Dictionary_2_TK_TV_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAll_Public_Static_Void_Dictionary_2_TK_TV_Predicate_1_TV_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Int32_Int32_Int32_0;

		// Token: 0x0200005D RID: 93
		[ObfuscatedName("Utils.ListUtil+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060002E5 RID: 741 RVA: 0x000102F8 File Offset: 0x0000E4F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ListUtil.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil.__c>.NativeClassPtr);
				ListUtil.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil.__c>.NativeClassPtr, "<>9");
				ListUtil.__c.NativeFieldInfoPtr___9__54_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil.__c>.NativeClassPtr, "<>9__54_0");
				ListUtil.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c>.NativeClassPtr, 100663640);
				ListUtil.__c.NativeMethodInfoPtr__SumVersions_b__54_0_Internal_UInt64_IVersionedModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c>.NativeClassPtr, 100663641);
			}

			// Token: 0x060002E6 RID: 742 RVA: 0x00010374 File Offset: 0x0000E574
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002E7 RID: 743 RVA: 0x000103B0 File Offset: 0x0000E5B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181622, XrefRangeEnd = 1181626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ulong _SumVersions_b__54_0(IVersionedModel i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c.NativeMethodInfoPtr__SumVersions_b__54_0_Internal_UInt64_IVersionedModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060002E8 RID: 744 RVA: 0x00002E8B File Offset: 0x0000108B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x060002E9 RID: 745 RVA: 0x00010400 File Offset: 0x0000E600
			// (set) Token: 0x060002EA RID: 746 RVA: 0x00002E94 File Offset: 0x00001094
			public unsafe static ListUtil.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ListUtil.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListUtil.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ListUtil.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x060002EB RID: 747 RVA: 0x00010428 File Offset: 0x0000E628
			// (set) Token: 0x060002EC RID: 748 RVA: 0x00002EA6 File Offset: 0x000010A6
			public unsafe static Func<IVersionedModel, ulong> __9__54_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ListUtil.__c.NativeFieldInfoPtr___9__54_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IVersionedModel, ulong>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ListUtil.__c.NativeFieldInfoPtr___9__54_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001F1 RID: 497
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040001F2 RID: 498
			private static readonly IntPtr NativeFieldInfoPtr___9__54_0;

			// Token: 0x040001F3 RID: 499
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001F4 RID: 500
			private static readonly IntPtr NativeMethodInfoPtr__SumVersions_b__54_0_Internal_UInt64_IVersionedModel_0;
		}

		// Token: 0x0200005E RID: 94
		[ObfuscatedName("Utils.ListUtil+<>c__11`1")]
		[Serializable]
		public sealed class __c__11<T> : Object
		{
			// Token: 0x060002ED RID: 749 RVA: 0x00010450 File Offset: 0x0000E650
			// Note: this type is marked as 'beforefieldinit'.
			static __c__11()
			{
				Il2CppClassPointerStore<ListUtil.__c__11<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<>c__11`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil.__c__11<T>>.NativeClassPtr);
				ListUtil.__c__11<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil.__c__11<T>>.NativeClassPtr, "<>9");
				ListUtil.__c__11<T>.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil.__c__11<T>>.NativeClassPtr, "<>9__11_0");
				ListUtil.__c__11<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c__11<T>>.NativeClassPtr, 100663643);
				ListUtil.__c__11<T>.NativeMethodInfoPtr__Only_b__11_0_Internal_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c__11<T>>.NativeClassPtr, 100663644);
			}

			// Token: 0x060002EE RID: 750 RVA: 0x00010508 File Offset: 0x0000E708
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__11()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil.__c__11<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c__11<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002EF RID: 751 RVA: 0x00010544 File Offset: 0x0000E744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181626, XrefRangeEnd = 1181629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Only_b__11_0(T x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = x;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref x;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c__11<T>.NativeMethodInfoPtr__Only_b__11_0_Internal_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x060002F0 RID: 752 RVA: 0x00002EB8 File Offset: 0x000010B8
			public __c__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x060002F1 RID: 753 RVA: 0x000105C8 File Offset: 0x0000E7C8
			// (set) Token: 0x060002F2 RID: 754 RVA: 0x00002EC1 File Offset: 0x000010C1
			public unsafe static ListUtil.__c__11<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ListUtil.__c__11<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListUtil.__c__11<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ListUtil.__c__11<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x060002F3 RID: 755 RVA: 0x000105F0 File Offset: 0x0000E7F0
			// (set) Token: 0x060002F4 RID: 756 RVA: 0x00002ED3 File Offset: 0x000010D3
			public unsafe static Func<T, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ListUtil.__c__11<T>.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ListUtil.__c__11<T>.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001F5 RID: 501
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040001F6 RID: 502
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x040001F7 RID: 503
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001F8 RID: 504
			private static readonly IntPtr NativeMethodInfoPtr__Only_b__11_0_Internal_Boolean_T_0;
		}

		// Token: 0x0200005F RID: 95
		[ObfuscatedName("Utils.ListUtil+<>c__25`1")]
		[Serializable]
		public sealed class __c__25<T> : Object
		{
			// Token: 0x060002F5 RID: 757 RVA: 0x00010618 File Offset: 0x0000E818
			// Note: this type is marked as 'beforefieldinit'.
			static __c__25()
			{
				Il2CppClassPointerStore<ListUtil.__c__25<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<>c__25`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil.__c__25<T>>.NativeClassPtr);
				ListUtil.__c__25<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil.__c__25<T>>.NativeClassPtr, "<>9");
				ListUtil.__c__25<T>.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil.__c__25<T>>.NativeClassPtr, "<>9__25_0");
				ListUtil.__c__25<T>.NativeFieldInfoPtr___9__25_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil.__c__25<T>>.NativeClassPtr, "<>9__25_2");
				ListUtil.__c__25<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c__25<T>>.NativeClassPtr, 100663646);
				ListUtil.__c__25<T>.NativeMethodInfoPtr__CombinationsWithRepetition_b__25_0_Internal_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c__25<T>>.NativeClassPtr, 100663647);
				ListUtil.__c__25<T>.NativeMethodInfoPtr__CombinationsWithRepetition_b__25_2_Internal_IEnumerable_1_T_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c__25<T>>.NativeClassPtr, 100663648);
			}

			// Token: 0x060002F6 RID: 758 RVA: 0x000106F8 File Offset: 0x0000E8F8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__25()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil.__c__25<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c__25<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002F7 RID: 759 RVA: 0x00010734 File Offset: 0x0000E934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181629, XrefRangeEnd = 1181636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppArrayBase<T> _CombinationsWithRepetition_b__25_0(T _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = _;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref _;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c__25<T>.NativeMethodInfoPtr__CombinationsWithRepetition_b__25_0_Internal_Il2CppArrayBase_1_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr2);
				}
			}

			// Token: 0x060002F8 RID: 760 RVA: 0x000107B4 File Offset: 0x0000E9B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181636, XrefRangeEnd = 1181643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<T> _CombinationsWithRepetition_b__25_2(Il2CppArrayBase<T> t1, T t2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t1);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t3 = t2;
					intPtr = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t2;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c__25<T>.NativeMethodInfoPtr__CombinationsWithRepetition_b__25_2_Internal_IEnumerable_1_T_Il2CppArrayBase_1_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr4) : null;
			}

			// Token: 0x060002F9 RID: 761 RVA: 0x00002EE5 File Offset: 0x000010E5
			public __c__25(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x060002FA RID: 762 RVA: 0x0001084C File Offset: 0x0000EA4C
			// (set) Token: 0x060002FB RID: 763 RVA: 0x00002EEE File Offset: 0x000010EE
			public unsafe static ListUtil.__c__25<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ListUtil.__c__25<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListUtil.__c__25<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ListUtil.__c__25<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x060002FC RID: 764 RVA: 0x00010874 File Offset: 0x0000EA74
			// (set) Token: 0x060002FD RID: 765 RVA: 0x00002F00 File Offset: 0x00001100
			public unsafe static Func<T, Il2CppArrayBase<T>> __9__25_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ListUtil.__c__25<T>.NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, Il2CppArrayBase<T>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ListUtil.__c__25<T>.NativeFieldInfoPtr___9__25_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x060002FE RID: 766 RVA: 0x0001089C File Offset: 0x0000EA9C
			// (set) Token: 0x060002FF RID: 767 RVA: 0x00002F12 File Offset: 0x00001112
			public unsafe static Func<Il2CppArrayBase<T>, T, IEnumerable<T>> __9__25_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ListUtil.__c__25<T>.NativeFieldInfoPtr___9__25_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppArrayBase<T>, T, IEnumerable<T>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ListUtil.__c__25<T>.NativeFieldInfoPtr___9__25_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001F9 RID: 505
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040001FA RID: 506
			private static readonly IntPtr NativeFieldInfoPtr___9__25_0;

			// Token: 0x040001FB RID: 507
			private static readonly IntPtr NativeFieldInfoPtr___9__25_2;

			// Token: 0x040001FC RID: 508
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001FD RID: 509
			private static readonly IntPtr NativeMethodInfoPtr__CombinationsWithRepetition_b__25_0_Internal_Il2CppArrayBase_1_T_T_0;

			// Token: 0x040001FE RID: 510
			private static readonly IntPtr NativeMethodInfoPtr__CombinationsWithRepetition_b__25_2_Internal_IEnumerable_1_T_Il2CppArrayBase_1_T_T_0;
		}

		// Token: 0x02000060 RID: 96
		[ObfuscatedName("Utils.ListUtil+<>c__52`1")]
		[Serializable]
		public sealed class __c__52<T> : Object
		{
			// Token: 0x06000300 RID: 768 RVA: 0x000108C4 File Offset: 0x0000EAC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__52()
			{
				Il2CppClassPointerStore<ListUtil.__c__52<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<>c__52`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil.__c__52<T>>.NativeClassPtr);
				ListUtil.__c__52<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil.__c__52<T>>.NativeClassPtr, "<>9");
				ListUtil.__c__52<T>.NativeFieldInfoPtr___9__52_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil.__c__52<T>>.NativeClassPtr, "<>9__52_0");
				ListUtil.__c__52<T>.NativeFieldInfoPtr___9__52_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil.__c__52<T>>.NativeClassPtr, "<>9__52_1");
				ListUtil.__c__52<T>.NativeFieldInfoPtr___9__52_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil.__c__52<T>>.NativeClassPtr, "<>9__52_2");
				ListUtil.__c__52<T>.NativeFieldInfoPtr___9__52_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil.__c__52<T>>.NativeClassPtr, "<>9__52_3");
				ListUtil.__c__52<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c__52<T>>.NativeClassPtr, 100663650);
				ListUtil.__c__52<T>.NativeMethodInfoPtr__Pivot_b__52_0_Internal_IEnumerator_1_T_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c__52<T>>.NativeClassPtr, 100663651);
				ListUtil.__c__52<T>.NativeMethodInfoPtr__Pivot_b__52_1_Internal_T_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c__52<T>>.NativeClassPtr, 100663652);
				ListUtil.__c__52<T>.NativeMethodInfoPtr__Pivot_b__52_2_Internal_Boolean_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c__52<T>>.NativeClassPtr, 100663653);
				ListUtil.__c__52<T>.NativeMethodInfoPtr__Pivot_b__52_3_Internal_Void_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c__52<T>>.NativeClassPtr, 100663654);
			}

			// Token: 0x06000301 RID: 769 RVA: 0x000109F4 File Offset: 0x0000EBF4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__52()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil.__c__52<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c__52<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000302 RID: 770 RVA: 0x00010A30 File Offset: 0x0000EC30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181643, XrefRangeEnd = 1181646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> _Pivot_b__52_0(IEnumerable<T> e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c__52<T>.NativeMethodInfoPtr__Pivot_b__52_0_Internal_IEnumerator_1_T_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
				}
			}

			// Token: 0x06000303 RID: 771 RVA: 0x00010A80 File Offset: 0x0000EC80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181646, XrefRangeEnd = 1181650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _Pivot_b__52_1(IEnumerator<T> e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c__52<T>.NativeMethodInfoPtr__Pivot_b__52_1_Internal_T_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06000304 RID: 772 RVA: 0x00010ACC File Offset: 0x0000ECCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181650, XrefRangeEnd = 1181654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Pivot_b__52_2(IEnumerator<T> e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c__52<T>.NativeMethodInfoPtr__Pivot_b__52_2_Internal_Boolean_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000305 RID: 773 RVA: 0x00010B1C File Offset: 0x0000ED1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181654, XrefRangeEnd = 1181658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Pivot_b__52_3(IEnumerator<T> e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c__52<T>.NativeMethodInfoPtr__Pivot_b__52_3_Internal_Void_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000306 RID: 774 RVA: 0x00002F24 File Offset: 0x00001124
			public __c__52(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000086 RID: 134
			// (get) Token: 0x06000307 RID: 775 RVA: 0x00010B60 File Offset: 0x0000ED60
			// (set) Token: 0x06000308 RID: 776 RVA: 0x00002F2D File Offset: 0x0000112D
			public unsafe static ListUtil.__c__52<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ListUtil.__c__52<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListUtil.__c__52<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ListUtil.__c__52<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x06000309 RID: 777 RVA: 0x00010B88 File Offset: 0x0000ED88
			// (set) Token: 0x0600030A RID: 778 RVA: 0x00002F3F File Offset: 0x0000113F
			public unsafe static Func<IEnumerable<T>, IEnumerator<T>> __9__52_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ListUtil.__c__52<T>.NativeFieldInfoPtr___9__52_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<T>, IEnumerator<T>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ListUtil.__c__52<T>.NativeFieldInfoPtr___9__52_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000088 RID: 136
			// (get) Token: 0x0600030B RID: 779 RVA: 0x00010BB0 File Offset: 0x0000EDB0
			// (set) Token: 0x0600030C RID: 780 RVA: 0x00002F51 File Offset: 0x00001151
			public unsafe static Func<IEnumerator<T>, T> __9__52_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ListUtil.__c__52<T>.NativeFieldInfoPtr___9__52_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator<T>, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ListUtil.__c__52<T>.NativeFieldInfoPtr___9__52_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x0600030D RID: 781 RVA: 0x00010BD8 File Offset: 0x0000EDD8
			// (set) Token: 0x0600030E RID: 782 RVA: 0x00002F63 File Offset: 0x00001163
			public unsafe static Func<IEnumerator<T>, bool> __9__52_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ListUtil.__c__52<T>.NativeFieldInfoPtr___9__52_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator<T>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ListUtil.__c__52<T>.NativeFieldInfoPtr___9__52_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x0600030F RID: 783 RVA: 0x00010C00 File Offset: 0x0000EE00
			// (set) Token: 0x06000310 RID: 784 RVA: 0x00002F75 File Offset: 0x00001175
			public unsafe static Action<IEnumerator<T>> __9__52_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ListUtil.__c__52<T>.NativeFieldInfoPtr___9__52_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IEnumerator<T>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ListUtil.__c__52<T>.NativeFieldInfoPtr___9__52_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001FF RID: 511
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000200 RID: 512
			private static readonly IntPtr NativeFieldInfoPtr___9__52_0;

			// Token: 0x04000201 RID: 513
			private static readonly IntPtr NativeFieldInfoPtr___9__52_1;

			// Token: 0x04000202 RID: 514
			private static readonly IntPtr NativeFieldInfoPtr___9__52_2;

			// Token: 0x04000203 RID: 515
			private static readonly IntPtr NativeFieldInfoPtr___9__52_3;

			// Token: 0x04000204 RID: 516
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000205 RID: 517
			private static readonly IntPtr NativeMethodInfoPtr__Pivot_b__52_0_Internal_IEnumerator_1_T_IEnumerable_1_T_0;

			// Token: 0x04000206 RID: 518
			private static readonly IntPtr NativeMethodInfoPtr__Pivot_b__52_1_Internal_T_IEnumerator_1_T_0;

			// Token: 0x04000207 RID: 519
			private static readonly IntPtr NativeMethodInfoPtr__Pivot_b__52_2_Internal_Boolean_IEnumerator_1_T_0;

			// Token: 0x04000208 RID: 520
			private static readonly IntPtr NativeMethodInfoPtr__Pivot_b__52_3_Internal_Void_IEnumerator_1_T_0;
		}

		// Token: 0x02000061 RID: 97
		[ObfuscatedName("Utils.ListUtil+<>c__DisplayClass14_0`1")]
		public sealed class __c__DisplayClass14_0<TValue> : Object
		{
			// Token: 0x06000311 RID: 785 RVA: 0x00010C28 File Offset: 0x0000EE28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<ListUtil.__c__DisplayClass14_0<TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<>c__DisplayClass14_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil.__c__DisplayClass14_0<TValue>>.NativeClassPtr);
				ListUtil.__c__DisplayClass14_0<TValue>.NativeFieldInfoPtr_descendantsSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil.__c__DisplayClass14_0<TValue>>.NativeClassPtr, "descendantsSelector");
				ListUtil.__c__DisplayClass14_0<TValue>.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil.__c__DisplayClass14_0<TValue>>.NativeClassPtr, "<>9__0");
				ListUtil.__c__DisplayClass14_0<TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c__DisplayClass14_0<TValue>>.NativeClassPtr, 100663655);
				ListUtil.__c__DisplayClass14_0<TValue>.NativeMethodInfoPtr__PostOrderTraversal_b__0_Internal_IEnumerable_1_TValue_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c__DisplayClass14_0<TValue>>.NativeClassPtr, 100663656);
			}

			// Token: 0x06000312 RID: 786 RVA: 0x00010CE0 File Offset: 0x0000EEE0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil.__c__DisplayClass14_0<TValue>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c__DisplayClass14_0<TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000313 RID: 787 RVA: 0x00010D1C File Offset: 0x0000EF1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181658, XrefRangeEnd = 1181663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<TValue> _PostOrderTraversal_b__0(TValue descendant)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TValue).IsValueType)
					{
						TValue tvalue = descendant;
						intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref descendant;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c__DisplayClass14_0<TValue>.NativeMethodInfoPtr__PostOrderTraversal_b__0_Internal_IEnumerable_1_TValue_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<TValue>>(intPtr4) : null;
				}
			}

			// Token: 0x06000314 RID: 788 RVA: 0x00002F87 File Offset: 0x00001187
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x06000315 RID: 789 RVA: 0x00010DA4 File Offset: 0x0000EFA4
			// (set) Token: 0x06000316 RID: 790 RVA: 0x00002F90 File Offset: 0x00001190
			public unsafe Func<TValue, IEnumerable<TValue>> descendantsSelector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil.__c__DisplayClass14_0<TValue>.NativeFieldInfoPtr_descendantsSelector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TValue, IEnumerable<TValue>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil.__c__DisplayClass14_0<TValue>.NativeFieldInfoPtr_descendantsSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x06000317 RID: 791 RVA: 0x00010DD4 File Offset: 0x0000EFD4
			// (set) Token: 0x06000318 RID: 792 RVA: 0x00002FAF File Offset: 0x000011AF
			public unsafe Func<TValue, IEnumerable<TValue>> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil.__c__DisplayClass14_0<TValue>.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TValue, IEnumerable<TValue>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil.__c__DisplayClass14_0<TValue>.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000209 RID: 521
			private static readonly IntPtr NativeFieldInfoPtr_descendantsSelector;

			// Token: 0x0400020A RID: 522
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x0400020B RID: 523
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400020C RID: 524
			private static readonly IntPtr NativeMethodInfoPtr__PostOrderTraversal_b__0_Internal_IEnumerable_1_TValue_TValue_0;
		}

		// Token: 0x02000062 RID: 98
		[ObfuscatedName("Utils.ListUtil+<>c__DisplayClass25_0`1")]
		public sealed class __c__DisplayClass25_0<T> : Object
		{
			// Token: 0x06000319 RID: 793 RVA: 0x00010E04 File Offset: 0x0000F004
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<ListUtil.__c__DisplayClass25_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<>c__DisplayClass25_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil.__c__DisplayClass25_0<T>>.NativeClassPtr);
				ListUtil.__c__DisplayClass25_0<T>.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil.__c__DisplayClass25_0<T>>.NativeClassPtr, "list");
				ListUtil.__c__DisplayClass25_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c__DisplayClass25_0<T>>.NativeClassPtr, 100663657);
				ListUtil.__c__DisplayClass25_0<T>.NativeMethodInfoPtr__CombinationsWithRepetition_b__1_Internal_IEnumerable_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c__DisplayClass25_0<T>>.NativeClassPtr, 100663658);
			}

			// Token: 0x0600031A RID: 794 RVA: 0x00010EA8 File Offset: 0x0000F0A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil.__c__DisplayClass25_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c__DisplayClass25_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600031B RID: 795 RVA: 0x00010EE4 File Offset: 0x0000F0E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181663, XrefRangeEnd = 1181669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<T> _CombinationsWithRepetition_b__1(Il2CppArrayBase<T> t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c__DisplayClass25_0<T>.NativeMethodInfoPtr__CombinationsWithRepetition_b__1_Internal_IEnumerable_1_T_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
				}
			}

			// Token: 0x0600031C RID: 796 RVA: 0x00002FCE File Offset: 0x000011CE
			public __c__DisplayClass25_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x0600031D RID: 797 RVA: 0x00010F34 File Offset: 0x0000F134
			// (set) Token: 0x0600031E RID: 798 RVA: 0x00002FD7 File Offset: 0x000011D7
			public unsafe IReadOnlyList<T> list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil.__c__DisplayClass25_0<T>.NativeFieldInfoPtr_list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil.__c__DisplayClass25_0<T>.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400020D RID: 525
			private static readonly IntPtr NativeFieldInfoPtr_list;

			// Token: 0x0400020E RID: 526
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400020F RID: 527
			private static readonly IntPtr NativeMethodInfoPtr__CombinationsWithRepetition_b__1_Internal_IEnumerable_1_T_Il2CppArrayBase_1_T_0;
		}

		// Token: 0x02000063 RID: 99
		[ObfuscatedName("Utils.ListUtil+<>c__DisplayClass25_1`1")]
		public sealed class __c__DisplayClass25_1<T> : Object
		{
			// Token: 0x0600031F RID: 799 RVA: 0x00010F64 File Offset: 0x0000F164
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_1()
			{
				Il2CppClassPointerStore<ListUtil.__c__DisplayClass25_1<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<>c__DisplayClass25_1`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil.__c__DisplayClass25_1<T>>.NativeClassPtr);
				ListUtil.__c__DisplayClass25_1<T>.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil.__c__DisplayClass25_1<T>>.NativeClassPtr, "t");
				ListUtil.__c__DisplayClass25_1<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c__DisplayClass25_1<T>>.NativeClassPtr, 100663659);
				ListUtil.__c__DisplayClass25_1<T>.NativeMethodInfoPtr__CombinationsWithRepetition_b__3_Internal_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c__DisplayClass25_1<T>>.NativeClassPtr, 100663660);
			}

			// Token: 0x06000320 RID: 800 RVA: 0x00011008 File Offset: 0x0000F208
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil.__c__DisplayClass25_1<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c__DisplayClass25_1<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000321 RID: 801 RVA: 0x00011044 File Offset: 0x0000F244
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181669, XrefRangeEnd = 1181674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CombinationsWithRepetition_b__3(T o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = o;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref o;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c__DisplayClass25_1<T>.NativeMethodInfoPtr__CombinationsWithRepetition_b__3_Internal_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06000322 RID: 802 RVA: 0x00002FF6 File Offset: 0x000011F6
			public __c__DisplayClass25_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x06000323 RID: 803 RVA: 0x000110C8 File Offset: 0x0000F2C8
			// (set) Token: 0x06000324 RID: 804 RVA: 0x00002FFF File Offset: 0x000011FF
			public unsafe Il2CppArrayBase<T> t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil.__c__DisplayClass25_1<T>.NativeFieldInfoPtr_t);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil.__c__DisplayClass25_1<T>.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000210 RID: 528
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x04000211 RID: 529
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000212 RID: 530
			private static readonly IntPtr NativeMethodInfoPtr__CombinationsWithRepetition_b__3_Internal_Boolean_T_0;
		}

		// Token: 0x02000064 RID: 100
		[ObfuscatedName("Utils.ListUtil+<>c__DisplayClass27_0`1")]
		public sealed class __c__DisplayClass27_0<T> : Object
		{
			// Token: 0x06000325 RID: 805 RVA: 0x000110F0 File Offset: 0x0000F2F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<ListUtil.__c__DisplayClass27_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<>c__DisplayClass27_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil.__c__DisplayClass27_0<T>>.NativeClassPtr);
				ListUtil.__c__DisplayClass27_0<T>.NativeFieldInfoPtr_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil.__c__DisplayClass27_0<T>>.NativeClassPtr, "sequence");
				ListUtil.__c__DisplayClass27_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c__DisplayClass27_0<T>>.NativeClassPtr, 100663661);
				ListUtil.__c__DisplayClass27_0<T>.NativeMethodInfoPtr__CartesianProduct_b__0_Internal_IEnumerable_1_IEnumerable_1_T_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c__DisplayClass27_0<T>>.NativeClassPtr, 100663662);
			}

			// Token: 0x06000326 RID: 806 RVA: 0x00011194 File Offset: 0x0000F394
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil.__c__DisplayClass27_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c__DisplayClass27_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000327 RID: 807 RVA: 0x000111D0 File Offset: 0x0000F3D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181674, XrefRangeEnd = 1181680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IEnumerable<T>> _CartesianProduct_b__0(IEnumerable<T> seq)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(seq);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c__DisplayClass27_0<T>.NativeMethodInfoPtr__CartesianProduct_b__0_Internal_IEnumerable_1_IEnumerable_1_T_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<T>>>(intPtr3) : null;
				}
			}

			// Token: 0x06000328 RID: 808 RVA: 0x0000301E File Offset: 0x0000121E
			public __c__DisplayClass27_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x06000329 RID: 809 RVA: 0x00011220 File Offset: 0x0000F420
			// (set) Token: 0x0600032A RID: 810 RVA: 0x00003027 File Offset: 0x00001227
			public unsafe IEnumerable<T> sequence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil.__c__DisplayClass27_0<T>.NativeFieldInfoPtr_sequence);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil.__c__DisplayClass27_0<T>.NativeFieldInfoPtr_sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000213 RID: 531
			private static readonly IntPtr NativeFieldInfoPtr_sequence;

			// Token: 0x04000214 RID: 532
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000215 RID: 533
			private static readonly IntPtr NativeMethodInfoPtr__CartesianProduct_b__0_Internal_IEnumerable_1_IEnumerable_1_T_IEnumerable_1_T_0;
		}

		// Token: 0x02000065 RID: 101
		[ObfuscatedName("Utils.ListUtil+<>c__DisplayClass27_1`1")]
		public sealed class __c__DisplayClass27_1<T> : Object
		{
			// Token: 0x0600032B RID: 811 RVA: 0x00011250 File Offset: 0x0000F450
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_1()
			{
				Il2CppClassPointerStore<ListUtil.__c__DisplayClass27_1<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<>c__DisplayClass27_1`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil.__c__DisplayClass27_1<T>>.NativeClassPtr);
				ListUtil.__c__DisplayClass27_1<T>.NativeFieldInfoPtr_seq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil.__c__DisplayClass27_1<T>>.NativeClassPtr, "seq");
				ListUtil.__c__DisplayClass27_1<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c__DisplayClass27_1<T>>.NativeClassPtr, 100663663);
				ListUtil.__c__DisplayClass27_1<T>.NativeMethodInfoPtr__CartesianProduct_b__1_Internal_IEnumerable_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil.__c__DisplayClass27_1<T>>.NativeClassPtr, 100663664);
			}

			// Token: 0x0600032C RID: 812 RVA: 0x000112F4 File Offset: 0x0000F4F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil.__c__DisplayClass27_1<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c__DisplayClass27_1<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600032D RID: 813 RVA: 0x00011330 File Offset: 0x0000F530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181680, XrefRangeEnd = 1181687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<T> _CartesianProduct_b__1(T item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = item;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref item;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ListUtil.__c__DisplayClass27_1<T>.NativeMethodInfoPtr__CartesianProduct_b__1_Internal_IEnumerable_1_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr4) : null;
				}
			}

			// Token: 0x0600032E RID: 814 RVA: 0x00003046 File Offset: 0x00001246
			public __c__DisplayClass27_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x0600032F RID: 815 RVA: 0x000113B8 File Offset: 0x0000F5B8
			// (set) Token: 0x06000330 RID: 816 RVA: 0x0000304F File Offset: 0x0000124F
			public unsafe IEnumerable<T> seq
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil.__c__DisplayClass27_1<T>.NativeFieldInfoPtr_seq);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil.__c__DisplayClass27_1<T>.NativeFieldInfoPtr_seq), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000216 RID: 534
			private static readonly IntPtr NativeFieldInfoPtr_seq;

			// Token: 0x04000217 RID: 535
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000218 RID: 536
			private static readonly IntPtr NativeMethodInfoPtr__CartesianProduct_b__1_Internal_IEnumerable_1_T_T_0;
		}

		// Token: 0x02000066 RID: 102
		[ObfuscatedName("Utils.ListUtil+<AsOption>d__13`1")]
		public sealed class _AsOption_d__13<T> : Object
		{
			// Token: 0x06000331 RID: 817 RVA: 0x000113E8 File Offset: 0x0000F5E8
			// Note: this type is marked as 'beforefieldinit'.
			static _AsOption_d__13()
			{
				Il2CppClassPointerStore<ListUtil._AsOption_d__13<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<AsOption>d__13`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil._AsOption_d__13<T>>.NativeClassPtr);
				ListUtil._AsOption_d__13<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._AsOption_d__13<T>>.NativeClassPtr, "<>1__state");
				ListUtil._AsOption_d__13<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._AsOption_d__13<T>>.NativeClassPtr, "<>2__current");
				ListUtil._AsOption_d__13<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._AsOption_d__13<T>>.NativeClassPtr, "<>l__initialThreadId");
				ListUtil._AsOption_d__13<T>.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._AsOption_d__13<T>>.NativeClassPtr, "obj");
				ListUtil._AsOption_d__13<T>.NativeFieldInfoPtr___3__obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._AsOption_d__13<T>>.NativeClassPtr, "<>3__obj");
				ListUtil._AsOption_d__13<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._AsOption_d__13<T>>.NativeClassPtr, 100663665);
				ListUtil._AsOption_d__13<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._AsOption_d__13<T>>.NativeClassPtr, 100663666);
				ListUtil._AsOption_d__13<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._AsOption_d__13<T>>.NativeClassPtr, 100663667);
				ListUtil._AsOption_d__13<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._AsOption_d__13<T>>.NativeClassPtr, 100663668);
				ListUtil._AsOption_d__13<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._AsOption_d__13<T>>.NativeClassPtr, 100663669);
				ListUtil._AsOption_d__13<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._AsOption_d__13<T>>.NativeClassPtr, 100663670);
				ListUtil._AsOption_d__13<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._AsOption_d__13<T>>.NativeClassPtr, 100663671);
				ListUtil._AsOption_d__13<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._AsOption_d__13<T>>.NativeClassPtr, 100663672);
			}

			// Token: 0x06000332 RID: 818 RVA: 0x00011554 File Offset: 0x0000F754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AsOption_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil._AsOption_d__13<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._AsOption_d__13<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000333 RID: 819 RVA: 0x0001159C File Offset: 0x0000F79C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._AsOption_d__13<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000334 RID: 820 RVA: 0x000115D0 File Offset: 0x0000F7D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181687, XrefRangeEnd = 1181711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._AsOption_d__13<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x06000335 RID: 821 RVA: 0x0001160C File Offset: 0x0000F80C
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181711, XrefRangeEnd = 1181715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._AsOption_d__13<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06000336 RID: 822 RVA: 0x00011648 File Offset: 0x0000F848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._AsOption_d__13<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x06000337 RID: 823 RVA: 0x0001167C File Offset: 0x0000F87C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181715, XrefRangeEnd = 1181719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._AsOption_d__13<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000338 RID: 824 RVA: 0x000116BC File Offset: 0x0000F8BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181719, XrefRangeEnd = 1181732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._AsOption_d__13<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x06000339 RID: 825 RVA: 0x000116FC File Offset: 0x0000F8FC
			[CallerCount(0)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._AsOption_d__13<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600033A RID: 826 RVA: 0x0000306E File Offset: 0x0000126E
			public _AsOption_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x0600033B RID: 827 RVA: 0x0001173C File Offset: 0x0000F93C
			// (set) Token: 0x0600033C RID: 828 RVA: 0x00003077 File Offset: 0x00001277
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._AsOption_d__13<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._AsOption_d__13<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x0600033D RID: 829 RVA: 0x00011764 File Offset: 0x0000F964
			// (set) Token: 0x0600033E RID: 830 RVA: 0x0001178C File Offset: 0x0000F98C
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._AsOption_d__13<T>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._AsOption_d__13<T>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x0600033F RID: 831 RVA: 0x00011834 File Offset: 0x0000FA34
			// (set) Token: 0x06000340 RID: 832 RVA: 0x00003092 File Offset: 0x00001292
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._AsOption_d__13<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._AsOption_d__13<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x06000341 RID: 833 RVA: 0x0001185C File Offset: 0x0000FA5C
			// (set) Token: 0x06000342 RID: 834 RVA: 0x000030AD File Offset: 0x000012AD
			public unsafe Object obj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._AsOption_d__13<T>.NativeFieldInfoPtr_obj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._AsOption_d__13<T>.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x06000343 RID: 835 RVA: 0x0001188C File Offset: 0x0000FA8C
			// (set) Token: 0x06000344 RID: 836 RVA: 0x000030CC File Offset: 0x000012CC
			public unsafe Object __3__obj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._AsOption_d__13<T>.NativeFieldInfoPtr___3__obj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._AsOption_d__13<T>.NativeFieldInfoPtr___3__obj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000219 RID: 537
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400021A RID: 538
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400021B RID: 539
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400021C RID: 540
			private static readonly IntPtr NativeFieldInfoPtr_obj;

			// Token: 0x0400021D RID: 541
			private static readonly IntPtr NativeFieldInfoPtr___3__obj;

			// Token: 0x0400021E RID: 542
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400021F RID: 543
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000220 RID: 544
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000221 RID: 545
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x04000222 RID: 546
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000223 RID: 547
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000224 RID: 548
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x04000225 RID: 549
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000067 RID: 103
		[ObfuscatedName("Utils.ListUtil+<Batches>d__45`1")]
		public sealed class _Batches_d__45<T> : Object
		{
			// Token: 0x06000345 RID: 837 RVA: 0x000118BC File Offset: 0x0000FABC
			// Note: this type is marked as 'beforefieldinit'.
			static _Batches_d__45()
			{
				Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<Batches>d__45`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr);
				ListUtil._Batches_d__45<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr, "<>1__state");
				ListUtil._Batches_d__45<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr, "<>2__current");
				ListUtil._Batches_d__45<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr, "<>l__initialThreadId");
				ListUtil._Batches_d__45<T>.NativeFieldInfoPtr_n = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr, "n");
				ListUtil._Batches_d__45<T>.NativeFieldInfoPtr___3__n = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr, "<>3__n");
				ListUtil._Batches_d__45<T>.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr, "input");
				ListUtil._Batches_d__45<T>.NativeFieldInfoPtr___3__input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr, "<>3__input");
				ListUtil._Batches_d__45<T>.NativeFieldInfoPtr__array_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr, "<array>5__2");
				ListUtil._Batches_d__45<T>.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr, "<i>5__3");
				ListUtil._Batches_d__45<T>.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr, "<>7__wrap3");
				ListUtil._Batches_d__45<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr, 100663673);
				ListUtil._Batches_d__45<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr, 100663674);
				ListUtil._Batches_d__45<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr, 100663675);
				ListUtil._Batches_d__45<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr, 100663676);
				ListUtil._Batches_d__45<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_T___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr, 100663677);
				ListUtil._Batches_d__45<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr, 100663678);
				ListUtil._Batches_d__45<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr, 100663679);
				ListUtil._Batches_d__45<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_T___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr, 100663680);
				ListUtil._Batches_d__45<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr, 100663681);
			}

			// Token: 0x06000346 RID: 838 RVA: 0x00011AA0 File Offset: 0x0000FCA0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Batches_d__45(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil._Batches_d__45<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Batches_d__45<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000347 RID: 839 RVA: 0x00011AE8 File Offset: 0x0000FCE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Batches_d__45<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000348 RID: 840 RVA: 0x00011B1C File Offset: 0x0000FD1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181732, XrefRangeEnd = 1181761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Batches_d__45<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000349 RID: 841 RVA: 0x00011B58 File Offset: 0x0000FD58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181761, XrefRangeEnd = 1181764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Batches_d__45<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x0600034A RID: 842 RVA: 0x00011B8C File Offset: 0x0000FD8C
			public unsafe IEnumerable<T> System.Collections.Generic.IEnumerator<System.Collections.Generic.IEnumerable<T>>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Batches_d__45<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_T___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
				}
			}

			// Token: 0x0600034B RID: 843 RVA: 0x00011BCC File Offset: 0x0000FDCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Batches_d__45<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x0600034C RID: 844 RVA: 0x00011C00 File Offset: 0x0000FE00
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Batches_d__45<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600034D RID: 845 RVA: 0x00011C40 File Offset: 0x0000FE40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181764, XrefRangeEnd = 1181769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<IEnumerable<T>> System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_T___GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Batches_d__45<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_T___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IEnumerable<T>>>(intPtr3) : null;
			}

			// Token: 0x0600034E RID: 846 RVA: 0x00011C80 File Offset: 0x0000FE80
			[CallerCount(0)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Batches_d__45<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600034F RID: 847 RVA: 0x000030EB File Offset: 0x000012EB
			public _Batches_d__45(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x06000350 RID: 848 RVA: 0x00011CC0 File Offset: 0x0000FEC0
			// (set) Token: 0x06000351 RID: 849 RVA: 0x000030F4 File Offset: 0x000012F4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Batches_d__45<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Batches_d__45<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x06000352 RID: 850 RVA: 0x00011CE8 File Offset: 0x0000FEE8
			// (set) Token: 0x06000353 RID: 851 RVA: 0x0000310F File Offset: 0x0000130F
			public unsafe IEnumerable<T> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Batches_d__45<T>.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Batches_d__45<T>.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x06000354 RID: 852 RVA: 0x00011D18 File Offset: 0x0000FF18
			// (set) Token: 0x06000355 RID: 853 RVA: 0x0000312E File Offset: 0x0000132E
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Batches_d__45<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Batches_d__45<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x06000356 RID: 854 RVA: 0x00011D40 File Offset: 0x0000FF40
			// (set) Token: 0x06000357 RID: 855 RVA: 0x00003149 File Offset: 0x00001349
			public unsafe int n
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Batches_d__45<T>.NativeFieldInfoPtr_n);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Batches_d__45<T>.NativeFieldInfoPtr_n)) = value;
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x06000358 RID: 856 RVA: 0x00011D68 File Offset: 0x0000FF68
			// (set) Token: 0x06000359 RID: 857 RVA: 0x00003164 File Offset: 0x00001364
			public unsafe int __3__n
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Batches_d__45<T>.NativeFieldInfoPtr___3__n);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Batches_d__45<T>.NativeFieldInfoPtr___3__n)) = value;
				}
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x0600035A RID: 858 RVA: 0x00011D90 File Offset: 0x0000FF90
			// (set) Token: 0x0600035B RID: 859 RVA: 0x0000317F File Offset: 0x0000137F
			public unsafe IEnumerable<T> input
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Batches_d__45<T>.NativeFieldInfoPtr_input);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Batches_d__45<T>.NativeFieldInfoPtr_input), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x0600035C RID: 860 RVA: 0x00011DC0 File Offset: 0x0000FFC0
			// (set) Token: 0x0600035D RID: 861 RVA: 0x0000319E File Offset: 0x0000139E
			public unsafe IEnumerable<T> __3__input
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Batches_d__45<T>.NativeFieldInfoPtr___3__input);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Batches_d__45<T>.NativeFieldInfoPtr___3__input), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x0600035E RID: 862 RVA: 0x00011DF0 File Offset: 0x0000FFF0
			// (set) Token: 0x0600035F RID: 863 RVA: 0x000031BD File Offset: 0x000013BD
			public unsafe Il2CppArrayBase<T> _array_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Batches_d__45<T>.NativeFieldInfoPtr__array_5__2);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Batches_d__45<T>.NativeFieldInfoPtr__array_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x06000360 RID: 864 RVA: 0x00011E18 File Offset: 0x00010018
			// (set) Token: 0x06000361 RID: 865 RVA: 0x000031DC File Offset: 0x000013DC
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Batches_d__45<T>.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Batches_d__45<T>.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x06000362 RID: 866 RVA: 0x00011E40 File Offset: 0x00010040
			// (set) Token: 0x06000363 RID: 867 RVA: 0x000031F7 File Offset: 0x000013F7
			public unsafe IEnumerator<T> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Batches_d__45<T>.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Batches_d__45<T>.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000226 RID: 550
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000227 RID: 551
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000228 RID: 552
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000229 RID: 553
			private static readonly IntPtr NativeFieldInfoPtr_n;

			// Token: 0x0400022A RID: 554
			private static readonly IntPtr NativeFieldInfoPtr___3__n;

			// Token: 0x0400022B RID: 555
			private static readonly IntPtr NativeFieldInfoPtr_input;

			// Token: 0x0400022C RID: 556
			private static readonly IntPtr NativeFieldInfoPtr___3__input;

			// Token: 0x0400022D RID: 557
			private static readonly IntPtr NativeFieldInfoPtr__array_5__2;

			// Token: 0x0400022E RID: 558
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400022F RID: 559
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04000230 RID: 560
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000231 RID: 561
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000232 RID: 562
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000233 RID: 563
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000234 RID: 564
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_T___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_T_0;

			// Token: 0x04000235 RID: 565
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000236 RID: 566
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000237 RID: 567
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_T___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_T_0;

			// Token: 0x04000238 RID: 568
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000068 RID: 104
		[ObfuscatedName("Utils.ListUtil+<Combinations>d__22`1")]
		public sealed class _Combinations_d__22<T> : Object
		{
			// Token: 0x06000364 RID: 868 RVA: 0x00011E70 File Offset: 0x00010070
			// Note: this type is marked as 'beforefieldinit'.
			static _Combinations_d__22()
			{
				Il2CppClassPointerStore<ListUtil._Combinations_d__22<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<Combinations>d__22`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil._Combinations_d__22<T>>.NativeClassPtr);
				ListUtil._Combinations_d__22<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Combinations_d__22<T>>.NativeClassPtr, "<>1__state");
				ListUtil._Combinations_d__22<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Combinations_d__22<T>>.NativeClassPtr, "<>2__current");
				ListUtil._Combinations_d__22<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Combinations_d__22<T>>.NativeClassPtr, "<>l__initialThreadId");
				ListUtil._Combinations_d__22<T>.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Combinations_d__22<T>>.NativeClassPtr, "elements");
				ListUtil._Combinations_d__22<T>.NativeFieldInfoPtr___3__elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Combinations_d__22<T>>.NativeClassPtr, "<>3__elements");
				ListUtil._Combinations_d__22<T>.NativeFieldInfoPtr__length_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Combinations_d__22<T>>.NativeClassPtr, "<length>5__2");
				ListUtil._Combinations_d__22<T>.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Combinations_d__22<T>>.NativeClassPtr, "<>7__wrap2");
				ListUtil._Combinations_d__22<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Combinations_d__22<T>>.NativeClassPtr, 100663682);
				ListUtil._Combinations_d__22<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Combinations_d__22<T>>.NativeClassPtr, 100663683);
				ListUtil._Combinations_d__22<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Combinations_d__22<T>>.NativeClassPtr, 100663684);
				ListUtil._Combinations_d__22<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Combinations_d__22<T>>.NativeClassPtr, 100663685);
				ListUtil._Combinations_d__22<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Combinations_d__22<T>>.NativeClassPtr, 100663686);
				ListUtil._Combinations_d__22<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Combinations_d__22<T>>.NativeClassPtr, 100663687);
				ListUtil._Combinations_d__22<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Combinations_d__22<T>>.NativeClassPtr, 100663688);
				ListUtil._Combinations_d__22<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Combinations_d__22<T>>.NativeClassPtr, 100663689);
				ListUtil._Combinations_d__22<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Combinations_d__22<T>>.NativeClassPtr, 100663690);
			}

			// Token: 0x06000365 RID: 869 RVA: 0x00012018 File Offset: 0x00010218
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Combinations_d__22(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil._Combinations_d__22<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Combinations_d__22<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000366 RID: 870 RVA: 0x00012060 File Offset: 0x00010260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Combinations_d__22<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000367 RID: 871 RVA: 0x00012094 File Offset: 0x00010294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181769, XrefRangeEnd = 1181789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Combinations_d__22<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000368 RID: 872 RVA: 0x000120D0 File Offset: 0x000102D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181789, XrefRangeEnd = 1181792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Combinations_d__22<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x06000369 RID: 873 RVA: 0x00012104 File Offset: 0x00010304
			public unsafe Il2CppArrayBase<T> prop_Il2CppArrayBase_1_T_0
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Combinations_d__22<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
				}
			}

			// Token: 0x0600036A RID: 874 RVA: 0x0001213C File Offset: 0x0001033C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Combinations_d__22<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x0600036B RID: 875 RVA: 0x00012170 File Offset: 0x00010370
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Combinations_d__22<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600036C RID: 876 RVA: 0x000121B0 File Offset: 0x000103B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181792, XrefRangeEnd = 1181797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Il2CppArrayBase<T>> Method_Private_Virtual_Final_New_IEnumerator_1_Il2CppArrayBase_1_T_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Combinations_d__22<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Il2CppArrayBase<T>>>(intPtr3) : null;
			}

			// Token: 0x0600036D RID: 877 RVA: 0x000121F0 File Offset: 0x000103F0
			[CallerCount(0)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Combinations_d__22<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600036E RID: 878 RVA: 0x00003216 File Offset: 0x00001416
			public _Combinations_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x0600036F RID: 879 RVA: 0x00012230 File Offset: 0x00010430
			// (set) Token: 0x06000370 RID: 880 RVA: 0x0000321F File Offset: 0x0000141F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__22<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__22<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x06000371 RID: 881 RVA: 0x00012258 File Offset: 0x00010458
			// (set) Token: 0x06000372 RID: 882 RVA: 0x0000323A File Offset: 0x0000143A
			public unsafe Il2CppArrayBase<T> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__22<T>.NativeFieldInfoPtr___2__current);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__22<T>.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x06000373 RID: 883 RVA: 0x00012280 File Offset: 0x00010480
			// (set) Token: 0x06000374 RID: 884 RVA: 0x00003259 File Offset: 0x00001459
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__22<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__22<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x06000375 RID: 885 RVA: 0x000122A8 File Offset: 0x000104A8
			// (set) Token: 0x06000376 RID: 886 RVA: 0x00003274 File Offset: 0x00001474
			public unsafe IReadOnlyList<T> elements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__22<T>.NativeFieldInfoPtr_elements);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__22<T>.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x06000377 RID: 887 RVA: 0x000122D8 File Offset: 0x000104D8
			// (set) Token: 0x06000378 RID: 888 RVA: 0x00003293 File Offset: 0x00001493
			public unsafe IReadOnlyList<T> __3__elements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__22<T>.NativeFieldInfoPtr___3__elements);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__22<T>.NativeFieldInfoPtr___3__elements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x06000379 RID: 889 RVA: 0x00012308 File Offset: 0x00010508
			// (set) Token: 0x0600037A RID: 890 RVA: 0x000032B2 File Offset: 0x000014B2
			public unsafe int _length_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__22<T>.NativeFieldInfoPtr__length_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__22<T>.NativeFieldInfoPtr__length_5__2)) = value;
				}
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x0600037B RID: 891 RVA: 0x00012330 File Offset: 0x00010530
			// (set) Token: 0x0600037C RID: 892 RVA: 0x000032CD File Offset: 0x000014CD
			public unsafe IEnumerator<Il2CppArrayBase<T>> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__22<T>.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Il2CppArrayBase<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__22<T>.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000239 RID: 569
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400023A RID: 570
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400023B RID: 571
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400023C RID: 572
			private static readonly IntPtr NativeFieldInfoPtr_elements;

			// Token: 0x0400023D RID: 573
			private static readonly IntPtr NativeFieldInfoPtr___3__elements;

			// Token: 0x0400023E RID: 574
			private static readonly IntPtr NativeFieldInfoPtr__length_5__2;

			// Token: 0x0400023F RID: 575
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04000240 RID: 576
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000241 RID: 577
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000242 RID: 578
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000243 RID: 579
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000244 RID: 580
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Il2CppArrayBase_1_T_0;

			// Token: 0x04000245 RID: 581
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000246 RID: 582
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000247 RID: 583
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_Il2CppArrayBase_1_T_0;

			// Token: 0x04000248 RID: 584
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000069 RID: 105
		[ObfuscatedName("Utils.ListUtil+<Combinations>d__23`1")]
		public sealed class _Combinations_d__23<T> : Object
		{
			// Token: 0x0600037D RID: 893 RVA: 0x00012360 File Offset: 0x00010560
			// Note: this type is marked as 'beforefieldinit'.
			static _Combinations_d__23()
			{
				Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<Combinations>d__23`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr);
				ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr, "<>1__state");
				ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr, "<>2__current");
				ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr, "<>l__initialThreadId");
				ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr, "length");
				ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr___3__length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr, "<>3__length");
				ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr, "elements");
				ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr___3__elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr, "<>3__elements");
				ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr, "<i>5__2");
				ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr__element_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr, "<element>5__3");
				ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr, "<>7__wrap3");
				ListUtil._Combinations_d__23<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr, 100663691);
				ListUtil._Combinations_d__23<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr, 100663692);
				ListUtil._Combinations_d__23<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr, 100663693);
				ListUtil._Combinations_d__23<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr, 100663694);
				ListUtil._Combinations_d__23<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr, 100663695);
				ListUtil._Combinations_d__23<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr, 100663696);
				ListUtil._Combinations_d__23<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr, 100663697);
				ListUtil._Combinations_d__23<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr, 100663698);
				ListUtil._Combinations_d__23<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr, 100663699);
			}

			// Token: 0x0600037E RID: 894 RVA: 0x00012544 File Offset: 0x00010744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Combinations_d__23(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil._Combinations_d__23<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Combinations_d__23<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600037F RID: 895 RVA: 0x0001258C File Offset: 0x0001078C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181797, XrefRangeEnd = 1181799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Combinations_d__23<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000380 RID: 896 RVA: 0x000125C0 File Offset: 0x000107C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181799, XrefRangeEnd = 1181881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Combinations_d__23<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000381 RID: 897 RVA: 0x000125FC File Offset: 0x000107FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181881, XrefRangeEnd = 1181889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Combinations_d__23<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x06000382 RID: 898 RVA: 0x00012630 File Offset: 0x00010830
			public unsafe Il2CppArrayBase<T> prop_Il2CppArrayBase_1_T_0
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181889, XrefRangeEnd = 1181890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Combinations_d__23<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
				}
			}

			// Token: 0x06000383 RID: 899 RVA: 0x00012668 File Offset: 0x00010868
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Combinations_d__23<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x06000384 RID: 900 RVA: 0x0001269C File Offset: 0x0001089C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Combinations_d__23<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000385 RID: 901 RVA: 0x000126DC File Offset: 0x000108DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181890, XrefRangeEnd = 1181907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Il2CppArrayBase<T>> Method_Private_Virtual_Final_New_IEnumerator_1_Il2CppArrayBase_1_T_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Combinations_d__23<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Il2CppArrayBase<T>>>(intPtr3) : null;
			}

			// Token: 0x06000386 RID: 902 RVA: 0x0001271C File Offset: 0x0001091C
			[CallerCount(0)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Combinations_d__23<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000387 RID: 903 RVA: 0x000032EC File Offset: 0x000014EC
			public _Combinations_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x06000388 RID: 904 RVA: 0x0001275C File Offset: 0x0001095C
			// (set) Token: 0x06000389 RID: 905 RVA: 0x000032F5 File Offset: 0x000014F5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x0600038A RID: 906 RVA: 0x00012784 File Offset: 0x00010984
			// (set) Token: 0x0600038B RID: 907 RVA: 0x00003310 File Offset: 0x00001510
			public unsafe Il2CppArrayBase<T> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr___2__current);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x0600038C RID: 908 RVA: 0x000127AC File Offset: 0x000109AC
			// (set) Token: 0x0600038D RID: 909 RVA: 0x0000332F File Offset: 0x0000152F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x0600038E RID: 910 RVA: 0x000127D4 File Offset: 0x000109D4
			// (set) Token: 0x0600038F RID: 911 RVA: 0x0000334A File Offset: 0x0000154A
			public unsafe int length
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr_length);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr_length)) = value;
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x06000390 RID: 912 RVA: 0x000127FC File Offset: 0x000109FC
			// (set) Token: 0x06000391 RID: 913 RVA: 0x00003365 File Offset: 0x00001565
			public unsafe int __3__length
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr___3__length);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr___3__length)) = value;
				}
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x06000392 RID: 914 RVA: 0x00012824 File Offset: 0x00010A24
			// (set) Token: 0x06000393 RID: 915 RVA: 0x00003380 File Offset: 0x00001580
			public unsafe IReadOnlyList<T> elements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr_elements);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x06000394 RID: 916 RVA: 0x00012854 File Offset: 0x00010A54
			// (set) Token: 0x06000395 RID: 917 RVA: 0x0000339F File Offset: 0x0000159F
			public unsafe IReadOnlyList<T> __3__elements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr___3__elements);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr___3__elements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x06000396 RID: 918 RVA: 0x00012884 File Offset: 0x00010A84
			// (set) Token: 0x06000397 RID: 919 RVA: 0x000033BE File Offset: 0x000015BE
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x06000398 RID: 920 RVA: 0x000128AC File Offset: 0x00010AAC
			// (set) Token: 0x06000399 RID: 921 RVA: 0x000128D4 File Offset: 0x00010AD4
			public unsafe T _element_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr__element_5__3);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr__element_5__3);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x0600039A RID: 922 RVA: 0x0001297C File Offset: 0x00010B7C
			// (set) Token: 0x0600039B RID: 923 RVA: 0x000033D9 File Offset: 0x000015D9
			public unsafe IEnumerator<Il2CppArrayBase<T>> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Il2CppArrayBase<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Combinations_d__23<T>.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000249 RID: 585
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400024A RID: 586
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400024B RID: 587
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400024C RID: 588
			private static readonly IntPtr NativeFieldInfoPtr_length;

			// Token: 0x0400024D RID: 589
			private static readonly IntPtr NativeFieldInfoPtr___3__length;

			// Token: 0x0400024E RID: 590
			private static readonly IntPtr NativeFieldInfoPtr_elements;

			// Token: 0x0400024F RID: 591
			private static readonly IntPtr NativeFieldInfoPtr___3__elements;

			// Token: 0x04000250 RID: 592
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04000251 RID: 593
			private static readonly IntPtr NativeFieldInfoPtr__element_5__3;

			// Token: 0x04000252 RID: 594
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04000253 RID: 595
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000254 RID: 596
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000255 RID: 597
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000256 RID: 598
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000257 RID: 599
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Il2CppArrayBase_1_T_0;

			// Token: 0x04000258 RID: 600
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000259 RID: 601
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400025A RID: 602
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_Il2CppArrayBase_1_T_0;

			// Token: 0x0400025B RID: 603
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200006A RID: 106
		[ObfuscatedName("Utils.ListUtil+<CombinationsInRange>d__24`1")]
		public sealed class _CombinationsInRange_d__24<T> : Object
		{
			// Token: 0x0600039C RID: 924 RVA: 0x000129AC File Offset: 0x00010BAC
			// Note: this type is marked as 'beforefieldinit'.
			static _CombinationsInRange_d__24()
			{
				Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<CombinationsInRange>d__24`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr);
				ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr, "<>1__state");
				ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr, "<>2__current");
				ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr, "<>l__initialThreadId");
				ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr_minLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr, "minLength");
				ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr___3__minLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr, "<>3__minLength");
				ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr, "elements");
				ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr___3__elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr, "<>3__elements");
				ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr_maxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr, "maxLength");
				ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr___3__maxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr, "<>3__maxLength");
				ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr__length_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr, "<length>5__2");
				ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr, "<>7__wrap2");
				ListUtil._CombinationsInRange_d__24<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr, 100663700);
				ListUtil._CombinationsInRange_d__24<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr, 100663701);
				ListUtil._CombinationsInRange_d__24<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr, 100663702);
				ListUtil._CombinationsInRange_d__24<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr, 100663703);
				ListUtil._CombinationsInRange_d__24<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr, 100663704);
				ListUtil._CombinationsInRange_d__24<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr, 100663705);
				ListUtil._CombinationsInRange_d__24<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr, 100663706);
				ListUtil._CombinationsInRange_d__24<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr, 100663707);
				ListUtil._CombinationsInRange_d__24<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr, 100663708);
			}

			// Token: 0x0600039D RID: 925 RVA: 0x00012BA4 File Offset: 0x00010DA4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CombinationsInRange_d__24(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil._CombinationsInRange_d__24<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._CombinationsInRange_d__24<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600039E RID: 926 RVA: 0x00012BEC File Offset: 0x00010DEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._CombinationsInRange_d__24<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600039F RID: 927 RVA: 0x00012C20 File Offset: 0x00010E20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181907, XrefRangeEnd = 1181931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._CombinationsInRange_d__24<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060003A0 RID: 928 RVA: 0x00012C5C File Offset: 0x00010E5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181931, XrefRangeEnd = 1181934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._CombinationsInRange_d__24<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x060003A1 RID: 929 RVA: 0x00012C90 File Offset: 0x00010E90
			public unsafe Il2CppArrayBase<T> prop_Il2CppArrayBase_1_T_0
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._CombinationsInRange_d__24<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
				}
			}

			// Token: 0x060003A2 RID: 930 RVA: 0x00012CC8 File Offset: 0x00010EC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._CombinationsInRange_d__24<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x060003A3 RID: 931 RVA: 0x00012CFC File Offset: 0x00010EFC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._CombinationsInRange_d__24<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003A4 RID: 932 RVA: 0x00012D3C File Offset: 0x00010F3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181934, XrefRangeEnd = 1181939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Il2CppArrayBase<T>> Method_Private_Virtual_Final_New_IEnumerator_1_Il2CppArrayBase_1_T_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._CombinationsInRange_d__24<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Il2CppArrayBase<T>>>(intPtr3) : null;
			}

			// Token: 0x060003A5 RID: 933 RVA: 0x00012D7C File Offset: 0x00010F7C
			[CallerCount(0)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._CombinationsInRange_d__24<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060003A6 RID: 934 RVA: 0x000033F8 File Offset: 0x000015F8
			public _CombinationsInRange_d__24(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x060003A7 RID: 935 RVA: 0x00012DBC File Offset: 0x00010FBC
			// (set) Token: 0x060003A8 RID: 936 RVA: 0x00003401 File Offset: 0x00001601
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x060003A9 RID: 937 RVA: 0x00012DE4 File Offset: 0x00010FE4
			// (set) Token: 0x060003AA RID: 938 RVA: 0x0000341C File Offset: 0x0000161C
			public unsafe Il2CppArrayBase<T> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr___2__current);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x060003AB RID: 939 RVA: 0x00012E0C File Offset: 0x0001100C
			// (set) Token: 0x060003AC RID: 940 RVA: 0x0000343B File Offset: 0x0000163B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x060003AD RID: 941 RVA: 0x00012E34 File Offset: 0x00011034
			// (set) Token: 0x060003AE RID: 942 RVA: 0x00003456 File Offset: 0x00001656
			public unsafe int minLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr_minLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr_minLength)) = value;
				}
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x060003AF RID: 943 RVA: 0x00012E5C File Offset: 0x0001105C
			// (set) Token: 0x060003B0 RID: 944 RVA: 0x00003471 File Offset: 0x00001671
			public unsafe int __3__minLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr___3__minLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr___3__minLength)) = value;
				}
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x060003B1 RID: 945 RVA: 0x00012E84 File Offset: 0x00011084
			// (set) Token: 0x060003B2 RID: 946 RVA: 0x0000348C File Offset: 0x0000168C
			public unsafe IReadOnlyList<T> elements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr_elements);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x060003B3 RID: 947 RVA: 0x00012EB4 File Offset: 0x000110B4
			// (set) Token: 0x060003B4 RID: 948 RVA: 0x000034AB File Offset: 0x000016AB
			public unsafe IReadOnlyList<T> __3__elements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr___3__elements);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr___3__elements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x060003B5 RID: 949 RVA: 0x00012EE4 File Offset: 0x000110E4
			// (set) Token: 0x060003B6 RID: 950 RVA: 0x000034CA File Offset: 0x000016CA
			public unsafe int maxLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr_maxLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr_maxLength)) = value;
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x060003B7 RID: 951 RVA: 0x00012F0C File Offset: 0x0001110C
			// (set) Token: 0x060003B8 RID: 952 RVA: 0x000034E5 File Offset: 0x000016E5
			public unsafe int __3__maxLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr___3__maxLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr___3__maxLength)) = value;
				}
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x060003B9 RID: 953 RVA: 0x00012F34 File Offset: 0x00011134
			// (set) Token: 0x060003BA RID: 954 RVA: 0x00003500 File Offset: 0x00001700
			public unsafe int _length_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr__length_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr__length_5__2)) = value;
				}
			}

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x060003BB RID: 955 RVA: 0x00012F5C File Offset: 0x0001115C
			// (set) Token: 0x060003BC RID: 956 RVA: 0x0000351B File Offset: 0x0000171B
			public unsafe IEnumerator<Il2CppArrayBase<T>> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Il2CppArrayBase<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._CombinationsInRange_d__24<T>.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400025C RID: 604
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400025D RID: 605
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400025E RID: 606
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400025F RID: 607
			private static readonly IntPtr NativeFieldInfoPtr_minLength;

			// Token: 0x04000260 RID: 608
			private static readonly IntPtr NativeFieldInfoPtr___3__minLength;

			// Token: 0x04000261 RID: 609
			private static readonly IntPtr NativeFieldInfoPtr_elements;

			// Token: 0x04000262 RID: 610
			private static readonly IntPtr NativeFieldInfoPtr___3__elements;

			// Token: 0x04000263 RID: 611
			private static readonly IntPtr NativeFieldInfoPtr_maxLength;

			// Token: 0x04000264 RID: 612
			private static readonly IntPtr NativeFieldInfoPtr___3__maxLength;

			// Token: 0x04000265 RID: 613
			private static readonly IntPtr NativeFieldInfoPtr__length_5__2;

			// Token: 0x04000266 RID: 614
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04000267 RID: 615
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000268 RID: 616
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000269 RID: 617
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400026A RID: 618
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400026B RID: 619
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Il2CppArrayBase_1_T_0;

			// Token: 0x0400026C RID: 620
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400026D RID: 621
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400026E RID: 622
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_Il2CppArrayBase_1_T_0;

			// Token: 0x0400026F RID: 623
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200006B RID: 107
		[ObfuscatedName("Utils.ListUtil+<DistinctBy>d__40`2")]
		public sealed class _DistinctBy_d__40<T, U> : Object
		{
			// Token: 0x060003BD RID: 957 RVA: 0x00012F8C File Offset: 0x0001118C
			// Note: this type is marked as 'beforefieldinit'.
			static _DistinctBy_d__40()
			{
				Il2CppClassPointerStore<ListUtil._DistinctBy_d__40<T, U>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<DistinctBy>d__40`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil._DistinctBy_d__40<T, U>>.NativeClassPtr);
				ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._DistinctBy_d__40<T, U>>.NativeClassPtr, "<>1__state");
				ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._DistinctBy_d__40<T, U>>.NativeClassPtr, "<>2__current");
				ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._DistinctBy_d__40<T, U>>.NativeClassPtr, "<>l__initialThreadId");
				ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._DistinctBy_d__40<T, U>>.NativeClassPtr, "sequence");
				ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr___3__sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._DistinctBy_d__40<T, U>>.NativeClassPtr, "<>3__sequence");
				ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr_keyGen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._DistinctBy_d__40<T, U>>.NativeClassPtr, "keyGen");
				ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr___3__keyGen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._DistinctBy_d__40<T, U>>.NativeClassPtr, "<>3__keyGen");
				ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr__set_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._DistinctBy_d__40<T, U>>.NativeClassPtr, "<set>5__2");
				ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._DistinctBy_d__40<T, U>>.NativeClassPtr, "<>7__wrap2");
				ListUtil._DistinctBy_d__40<T, U>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._DistinctBy_d__40<T, U>>.NativeClassPtr, 100663709);
				ListUtil._DistinctBy_d__40<T, U>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._DistinctBy_d__40<T, U>>.NativeClassPtr, 100663710);
				ListUtil._DistinctBy_d__40<T, U>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._DistinctBy_d__40<T, U>>.NativeClassPtr, 100663711);
				ListUtil._DistinctBy_d__40<T, U>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._DistinctBy_d__40<T, U>>.NativeClassPtr, 100663712);
				ListUtil._DistinctBy_d__40<T, U>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._DistinctBy_d__40<T, U>>.NativeClassPtr, 100663713);
				ListUtil._DistinctBy_d__40<T, U>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._DistinctBy_d__40<T, U>>.NativeClassPtr, 100663714);
				ListUtil._DistinctBy_d__40<T, U>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._DistinctBy_d__40<T, U>>.NativeClassPtr, 100663715);
				ListUtil._DistinctBy_d__40<T, U>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._DistinctBy_d__40<T, U>>.NativeClassPtr, 100663716);
				ListUtil._DistinctBy_d__40<T, U>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._DistinctBy_d__40<T, U>>.NativeClassPtr, 100663717);
			}

			// Token: 0x060003BE RID: 958 RVA: 0x0001316C File Offset: 0x0001136C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DistinctBy_d__40(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil._DistinctBy_d__40<T, U>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._DistinctBy_d__40<T, U>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003BF RID: 959 RVA: 0x000131B4 File Offset: 0x000113B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181939, XrefRangeEnd = 1181944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._DistinctBy_d__40<T, U>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003C0 RID: 960 RVA: 0x000131E8 File Offset: 0x000113E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181944, XrefRangeEnd = 1181966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._DistinctBy_d__40<T, U>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060003C1 RID: 961 RVA: 0x00013224 File Offset: 0x00011424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181966, XrefRangeEnd = 1181969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._DistinctBy_d__40<T, U>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000CF RID: 207
			// (get) Token: 0x060003C2 RID: 962 RVA: 0x00013258 File Offset: 0x00011458
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._DistinctBy_d__40<T, U>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x060003C3 RID: 963 RVA: 0x00013294 File Offset: 0x00011494
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._DistinctBy_d__40<T, U>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x060003C4 RID: 964 RVA: 0x000132C8 File Offset: 0x000114C8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._DistinctBy_d__40<T, U>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003C5 RID: 965 RVA: 0x00013308 File Offset: 0x00011508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._DistinctBy_d__40<T, U>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x060003C6 RID: 966 RVA: 0x00013348 File Offset: 0x00011548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._DistinctBy_d__40<T, U>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060003C7 RID: 967 RVA: 0x0000353A File Offset: 0x0000173A
			public _DistinctBy_d__40(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x060003C8 RID: 968 RVA: 0x00013388 File Offset: 0x00011588
			// (set) Token: 0x060003C9 RID: 969 RVA: 0x00003543 File Offset: 0x00001743
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x060003CA RID: 970 RVA: 0x000133B0 File Offset: 0x000115B0
			// (set) Token: 0x060003CB RID: 971 RVA: 0x000133D8 File Offset: 0x000115D8
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x060003CC RID: 972 RVA: 0x00013480 File Offset: 0x00011680
			// (set) Token: 0x060003CD RID: 973 RVA: 0x0000355E File Offset: 0x0000175E
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170000C9 RID: 201
			// (get) Token: 0x060003CE RID: 974 RVA: 0x000134A8 File Offset: 0x000116A8
			// (set) Token: 0x060003CF RID: 975 RVA: 0x00003579 File Offset: 0x00001779
			public unsafe IEnumerable<T> sequence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr_sequence);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr_sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000CA RID: 202
			// (get) Token: 0x060003D0 RID: 976 RVA: 0x000134D8 File Offset: 0x000116D8
			// (set) Token: 0x060003D1 RID: 977 RVA: 0x00003598 File Offset: 0x00001798
			public unsafe IEnumerable<T> __3__sequence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr___3__sequence);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr___3__sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000CB RID: 203
			// (get) Token: 0x060003D2 RID: 978 RVA: 0x00013508 File Offset: 0x00011708
			// (set) Token: 0x060003D3 RID: 979 RVA: 0x000035B7 File Offset: 0x000017B7
			public unsafe Func<T, U> keyGen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr_keyGen);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, U>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr_keyGen), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000CC RID: 204
			// (get) Token: 0x060003D4 RID: 980 RVA: 0x00013538 File Offset: 0x00011738
			// (set) Token: 0x060003D5 RID: 981 RVA: 0x000035D6 File Offset: 0x000017D6
			public unsafe Func<T, U> __3__keyGen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr___3__keyGen);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, U>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr___3__keyGen), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x060003D6 RID: 982 RVA: 0x00013568 File Offset: 0x00011768
			// (set) Token: 0x060003D7 RID: 983 RVA: 0x000035F5 File Offset: 0x000017F5
			public unsafe HashSet<U> _set_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr__set_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<U>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr__set_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000CE RID: 206
			// (get) Token: 0x060003D8 RID: 984 RVA: 0x00013598 File Offset: 0x00011798
			// (set) Token: 0x060003D9 RID: 985 RVA: 0x00003614 File Offset: 0x00001814
			public unsafe IEnumerator<T> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._DistinctBy_d__40<T, U>.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000270 RID: 624
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000271 RID: 625
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000272 RID: 626
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000273 RID: 627
			private static readonly IntPtr NativeFieldInfoPtr_sequence;

			// Token: 0x04000274 RID: 628
			private static readonly IntPtr NativeFieldInfoPtr___3__sequence;

			// Token: 0x04000275 RID: 629
			private static readonly IntPtr NativeFieldInfoPtr_keyGen;

			// Token: 0x04000276 RID: 630
			private static readonly IntPtr NativeFieldInfoPtr___3__keyGen;

			// Token: 0x04000277 RID: 631
			private static readonly IntPtr NativeFieldInfoPtr__set_5__2;

			// Token: 0x04000278 RID: 632
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04000279 RID: 633
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400027A RID: 634
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400027B RID: 635
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400027C RID: 636
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400027D RID: 637
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x0400027E RID: 638
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400027F RID: 639
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000280 RID: 640
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x04000281 RID: 641
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200006C RID: 108
		[ObfuscatedName("Utils.ListUtil+<EnumerateRest>d__51`1")]
		public sealed class _EnumerateRest_d__51<T> : Object
		{
			// Token: 0x060003DA RID: 986 RVA: 0x000135C8 File Offset: 0x000117C8
			// Note: this type is marked as 'beforefieldinit'.
			static _EnumerateRest_d__51()
			{
				Il2CppClassPointerStore<ListUtil._EnumerateRest_d__51<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<EnumerateRest>d__51`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil._EnumerateRest_d__51<T>>.NativeClassPtr);
				ListUtil._EnumerateRest_d__51<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._EnumerateRest_d__51<T>>.NativeClassPtr, "<>1__state");
				ListUtil._EnumerateRest_d__51<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._EnumerateRest_d__51<T>>.NativeClassPtr, "<>2__current");
				ListUtil._EnumerateRest_d__51<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._EnumerateRest_d__51<T>>.NativeClassPtr, "<>l__initialThreadId");
				ListUtil._EnumerateRest_d__51<T>.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._EnumerateRest_d__51<T>>.NativeClassPtr, "enumerator");
				ListUtil._EnumerateRest_d__51<T>.NativeFieldInfoPtr___3__enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._EnumerateRest_d__51<T>>.NativeClassPtr, "<>3__enumerator");
				ListUtil._EnumerateRest_d__51<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._EnumerateRest_d__51<T>>.NativeClassPtr, 100663718);
				ListUtil._EnumerateRest_d__51<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._EnumerateRest_d__51<T>>.NativeClassPtr, 100663719);
				ListUtil._EnumerateRest_d__51<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._EnumerateRest_d__51<T>>.NativeClassPtr, 100663720);
				ListUtil._EnumerateRest_d__51<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._EnumerateRest_d__51<T>>.NativeClassPtr, 100663721);
				ListUtil._EnumerateRest_d__51<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._EnumerateRest_d__51<T>>.NativeClassPtr, 100663722);
				ListUtil._EnumerateRest_d__51<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._EnumerateRest_d__51<T>>.NativeClassPtr, 100663723);
				ListUtil._EnumerateRest_d__51<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._EnumerateRest_d__51<T>>.NativeClassPtr, 100663724);
				ListUtil._EnumerateRest_d__51<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._EnumerateRest_d__51<T>>.NativeClassPtr, 100663725);
			}

			// Token: 0x060003DB RID: 987 RVA: 0x00013734 File Offset: 0x00011934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _EnumerateRest_d__51(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil._EnumerateRest_d__51<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._EnumerateRest_d__51<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003DC RID: 988 RVA: 0x0001377C File Offset: 0x0001197C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._EnumerateRest_d__51<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003DD RID: 989 RVA: 0x000137B0 File Offset: 0x000119B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181969, XrefRangeEnd = 1181986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._EnumerateRest_d__51<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x060003DE RID: 990 RVA: 0x000137EC File Offset: 0x000119EC
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181986, XrefRangeEnd = 1181990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._EnumerateRest_d__51<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x060003DF RID: 991 RVA: 0x00013828 File Offset: 0x00011A28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._EnumerateRest_d__51<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x060003E0 RID: 992 RVA: 0x0001385C File Offset: 0x00011A5C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181990, XrefRangeEnd = 1181994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._EnumerateRest_d__51<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003E1 RID: 993 RVA: 0x0001389C File Offset: 0x00011A9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181994, XrefRangeEnd = 1182007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._EnumerateRest_d__51<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x060003E2 RID: 994 RVA: 0x000138DC File Offset: 0x00011ADC
			[CallerCount(0)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._EnumerateRest_d__51<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060003E3 RID: 995 RVA: 0x00003633 File Offset: 0x00001833
			public _EnumerateRest_d__51(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000D1 RID: 209
			// (get) Token: 0x060003E4 RID: 996 RVA: 0x0001391C File Offset: 0x00011B1C
			// (set) Token: 0x060003E5 RID: 997 RVA: 0x0000363C File Offset: 0x0000183C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._EnumerateRest_d__51<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._EnumerateRest_d__51<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000D2 RID: 210
			// (get) Token: 0x060003E6 RID: 998 RVA: 0x00013944 File Offset: 0x00011B44
			// (set) Token: 0x060003E7 RID: 999 RVA: 0x0001396C File Offset: 0x00011B6C
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._EnumerateRest_d__51<T>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._EnumerateRest_d__51<T>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00013A14 File Offset: 0x00011C14
			// (set) Token: 0x060003E9 RID: 1001 RVA: 0x00003657 File Offset: 0x00001857
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._EnumerateRest_d__51<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._EnumerateRest_d__51<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x060003EA RID: 1002 RVA: 0x00013A3C File Offset: 0x00011C3C
			// (set) Token: 0x060003EB RID: 1003 RVA: 0x00003672 File Offset: 0x00001872
			public unsafe IEnumerator<T> enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._EnumerateRest_d__51<T>.NativeFieldInfoPtr_enumerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._EnumerateRest_d__51<T>.NativeFieldInfoPtr_enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x060003EC RID: 1004 RVA: 0x00013A6C File Offset: 0x00011C6C
			// (set) Token: 0x060003ED RID: 1005 RVA: 0x00003691 File Offset: 0x00001891
			public unsafe IEnumerator<T> __3__enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._EnumerateRest_d__51<T>.NativeFieldInfoPtr___3__enumerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._EnumerateRest_d__51<T>.NativeFieldInfoPtr___3__enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000282 RID: 642
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000283 RID: 643
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000284 RID: 644
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000285 RID: 645
			private static readonly IntPtr NativeFieldInfoPtr_enumerator;

			// Token: 0x04000286 RID: 646
			private static readonly IntPtr NativeFieldInfoPtr___3__enumerator;

			// Token: 0x04000287 RID: 647
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000288 RID: 648
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000289 RID: 649
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400028A RID: 650
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x0400028B RID: 651
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400028C RID: 652
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400028D RID: 653
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x0400028E RID: 654
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200006D RID: 109
		[ObfuscatedName("Utils.ListUtil+<Gaps>d__44`1")]
		public sealed class _Gaps_d__44<T> : Object where T : new()
		{
			// Token: 0x060003EE RID: 1006 RVA: 0x00013A9C File Offset: 0x00011C9C
			// Note: this type is marked as 'beforefieldinit'.
			static _Gaps_d__44()
			{
				Il2CppClassPointerStore<ListUtil._Gaps_d__44<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<Gaps>d__44`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil._Gaps_d__44<T>>.NativeClassPtr);
				ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Gaps_d__44<T>>.NativeClassPtr, "<>1__state");
				ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Gaps_d__44<T>>.NativeClassPtr, "<>2__current");
				ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Gaps_d__44<T>>.NativeClassPtr, "<>l__initialThreadId");
				ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Gaps_d__44<T>>.NativeClassPtr, "sequence");
				ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr___3__sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Gaps_d__44<T>>.NativeClassPtr, "<>3__sequence");
				ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr__arr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Gaps_d__44<T>>.NativeClassPtr, "<arr>5__2");
				ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr__arrLength_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Gaps_d__44<T>>.NativeClassPtr, "<arrLength>5__3");
				ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Gaps_d__44<T>>.NativeClassPtr, "<i>5__4");
				ListUtil._Gaps_d__44<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Gaps_d__44<T>>.NativeClassPtr, 100663726);
				ListUtil._Gaps_d__44<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Gaps_d__44<T>>.NativeClassPtr, 100663727);
				ListUtil._Gaps_d__44<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Gaps_d__44<T>>.NativeClassPtr, 100663728);
				ListUtil._Gaps_d__44<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_Int32_Nullable_1_T_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Gaps_d__44<T>>.NativeClassPtr, 100663729);
				ListUtil._Gaps_d__44<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Gaps_d__44<T>>.NativeClassPtr, 100663730);
				ListUtil._Gaps_d__44<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Gaps_d__44<T>>.NativeClassPtr, 100663731);
				ListUtil._Gaps_d__44<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_Int32_Nullable_1_T_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Gaps_d__44<T>>.NativeClassPtr, 100663732);
				ListUtil._Gaps_d__44<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Gaps_d__44<T>>.NativeClassPtr, 100663733);
			}

			// Token: 0x060003EF RID: 1007 RVA: 0x00013C44 File Offset: 0x00011E44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Gaps_d__44(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil._Gaps_d__44<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Gaps_d__44<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003F0 RID: 1008 RVA: 0x00013C8C File Offset: 0x00011E8C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Gaps_d__44<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003F1 RID: 1009 RVA: 0x00013CC0 File Offset: 0x00011EC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182007, XrefRangeEnd = 1182086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Gaps_d__44<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00013CFC File Offset: 0x00011EFC
			public unsafe ValueTuple<int, Nullable<T>, Nullable<T>> prop_ValueTuple_3_Int32_Nullable_1_T_Nullable_1_T_0
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182086, XrefRangeEnd = 1182090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Gaps_d__44<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_Int32_Nullable_1_T_Nullable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<int, Nullable<T>, Nullable<T>>(intPtr);
				}
			}

			// Token: 0x060003F3 RID: 1011 RVA: 0x00013D34 File Offset: 0x00011F34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Gaps_d__44<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00013D68 File Offset: 0x00011F68
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182090, XrefRangeEnd = 1182094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Gaps_d__44<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003F5 RID: 1013 RVA: 0x00013DA8 File Offset: 0x00011FA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182094, XrefRangeEnd = 1182107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<int, Nullable<T>, Nullable<T>>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_Int32_Nullable_1_T_Nullable_1_T_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Gaps_d__44<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_Int32_Nullable_1_T_Nullable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<int, Nullable<T>, Nullable<T>>>>(intPtr3) : null;
			}

			// Token: 0x060003F6 RID: 1014 RVA: 0x00013DE8 File Offset: 0x00011FE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182107, XrefRangeEnd = 1182131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Gaps_d__44<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060003F7 RID: 1015 RVA: 0x000036B0 File Offset: 0x000018B0
			public _Gaps_d__44(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00013E28 File Offset: 0x00012028
			// (set) Token: 0x060003F9 RID: 1017 RVA: 0x000036B9 File Offset: 0x000018B9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x060003FA RID: 1018 RVA: 0x00013E50 File Offset: 0x00012050
			// (set) Token: 0x060003FB RID: 1019 RVA: 0x000036D4 File Offset: 0x000018D4
			public ValueTuple<int, Nullable<T>, Nullable<T>> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr___2__current);
					return new ValueTuple<int, Nullable<T>, Nullable<T>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<int, Nullable<T>, Nullable<T>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<int, Nullable<T>, Nullable<T>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000DA RID: 218
			// (get) Token: 0x060003FC RID: 1020 RVA: 0x00013E80 File Offset: 0x00012080
			// (set) Token: 0x060003FD RID: 1021 RVA: 0x00003702 File Offset: 0x00001902
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170000DB RID: 219
			// (get) Token: 0x060003FE RID: 1022 RVA: 0x00013EA8 File Offset: 0x000120A8
			// (set) Token: 0x060003FF RID: 1023 RVA: 0x0000371D File Offset: 0x0000191D
			public unsafe IEnumerable<T> sequence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr_sequence);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr_sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x06000400 RID: 1024 RVA: 0x00013ED8 File Offset: 0x000120D8
			// (set) Token: 0x06000401 RID: 1025 RVA: 0x0000373C File Offset: 0x0000193C
			public unsafe IEnumerable<T> __3__sequence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr___3__sequence);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr___3__sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x06000402 RID: 1026 RVA: 0x00013F08 File Offset: 0x00012108
			// (set) Token: 0x06000403 RID: 1027 RVA: 0x0000375B File Offset: 0x0000195B
			public unsafe Il2CppArrayBase<T> _arr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr__arr_5__2);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr__arr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000DE RID: 222
			// (get) Token: 0x06000404 RID: 1028 RVA: 0x00013F30 File Offset: 0x00012130
			// (set) Token: 0x06000405 RID: 1029 RVA: 0x0000377A File Offset: 0x0000197A
			public unsafe int _arrLength_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr__arrLength_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr__arrLength_5__3)) = value;
				}
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x06000406 RID: 1030 RVA: 0x00013F58 File Offset: 0x00012158
			// (set) Token: 0x06000407 RID: 1031 RVA: 0x00003795 File Offset: 0x00001995
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Gaps_d__44<T>.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x0400028F RID: 655
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000290 RID: 656
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000291 RID: 657
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000292 RID: 658
			private static readonly IntPtr NativeFieldInfoPtr_sequence;

			// Token: 0x04000293 RID: 659
			private static readonly IntPtr NativeFieldInfoPtr___3__sequence;

			// Token: 0x04000294 RID: 660
			private static readonly IntPtr NativeFieldInfoPtr__arr_5__2;

			// Token: 0x04000295 RID: 661
			private static readonly IntPtr NativeFieldInfoPtr__arrLength_5__3;

			// Token: 0x04000296 RID: 662
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x04000297 RID: 663
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000298 RID: 664
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000299 RID: 665
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400029A RID: 666
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_Int32_Nullable_1_T_Nullable_1_T_0;

			// Token: 0x0400029B RID: 667
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400029C RID: 668
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400029D RID: 669
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_Int32_Nullable_1_T_Nullable_1_T_0;

			// Token: 0x0400029E RID: 670
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200006E RID: 110
		[ObfuscatedName("Utils.ListUtil+<Interleave>d__41`1")]
		public sealed class _Interleave_d__41<T> : Object
		{
			// Token: 0x06000408 RID: 1032 RVA: 0x00013F80 File Offset: 0x00012180
			// Note: this type is marked as 'beforefieldinit'.
			static _Interleave_d__41()
			{
				Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<Interleave>d__41`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr);
				ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr, "<>1__state");
				ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr, "<>2__current");
				ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr, "<>l__initialThreadId");
				ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr, "sequence");
				ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr___3__sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr, "<>3__sequence");
				ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr_otherSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr, "otherSequence");
				ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr___3__otherSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr, "<>3__otherSequence");
				ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr__seqEnumerator_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr, "<seqEnumerator>5__2");
				ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr__otherEnumerator_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr, "<otherEnumerator>5__3");
				ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr__seqHasNext_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr, "<seqHasNext>5__4");
				ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr__otherHasNext_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr, "<otherHasNext>5__5");
				ListUtil._Interleave_d__41<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr, 100663734);
				ListUtil._Interleave_d__41<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr, 100663735);
				ListUtil._Interleave_d__41<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr, 100663736);
				ListUtil._Interleave_d__41<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr, 100663737);
				ListUtil._Interleave_d__41<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr, 100663738);
				ListUtil._Interleave_d__41<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr, 100663739);
				ListUtil._Interleave_d__41<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr, 100663740);
				ListUtil._Interleave_d__41<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr, 100663741);
			}

			// Token: 0x06000409 RID: 1033 RVA: 0x00014164 File Offset: 0x00012364
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Interleave_d__41(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil._Interleave_d__41<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Interleave_d__41<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600040A RID: 1034 RVA: 0x000141AC File Offset: 0x000123AC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Interleave_d__41<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600040B RID: 1035 RVA: 0x000141E0 File Offset: 0x000123E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182131, XrefRangeEnd = 1182134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Interleave_d__41<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x0600040C RID: 1036 RVA: 0x0001421C File Offset: 0x0001241C
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182134, XrefRangeEnd = 1182138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Interleave_d__41<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x0600040D RID: 1037 RVA: 0x00014258 File Offset: 0x00012458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Interleave_d__41<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000EE RID: 238
			// (get) Token: 0x0600040E RID: 1038 RVA: 0x0001428C File Offset: 0x0001248C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182138, XrefRangeEnd = 1182142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Interleave_d__41<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600040F RID: 1039 RVA: 0x000142CC File Offset: 0x000124CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182142, XrefRangeEnd = 1182159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Interleave_d__41<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x06000410 RID: 1040 RVA: 0x0001430C File Offset: 0x0001250C
			[CallerCount(0)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Interleave_d__41<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000411 RID: 1041 RVA: 0x000037B0 File Offset: 0x000019B0
			public _Interleave_d__41(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x06000412 RID: 1042 RVA: 0x0001434C File Offset: 0x0001254C
			// (set) Token: 0x06000413 RID: 1043 RVA: 0x000037B9 File Offset: 0x000019B9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x06000414 RID: 1044 RVA: 0x00014374 File Offset: 0x00012574
			// (set) Token: 0x06000415 RID: 1045 RVA: 0x0001439C File Offset: 0x0001259C
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x06000416 RID: 1046 RVA: 0x00014444 File Offset: 0x00012644
			// (set) Token: 0x06000417 RID: 1047 RVA: 0x000037D4 File Offset: 0x000019D4
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x06000418 RID: 1048 RVA: 0x0001446C File Offset: 0x0001266C
			// (set) Token: 0x06000419 RID: 1049 RVA: 0x000037EF File Offset: 0x000019EF
			public unsafe IEnumerable<T> sequence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr_sequence);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr_sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x0600041A RID: 1050 RVA: 0x0001449C File Offset: 0x0001269C
			// (set) Token: 0x0600041B RID: 1051 RVA: 0x0000380E File Offset: 0x00001A0E
			public unsafe IEnumerable<T> __3__sequence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr___3__sequence);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr___3__sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x0600041C RID: 1052 RVA: 0x000144CC File Offset: 0x000126CC
			// (set) Token: 0x0600041D RID: 1053 RVA: 0x0000382D File Offset: 0x00001A2D
			public unsafe IEnumerable<T> otherSequence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr_otherSequence);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr_otherSequence), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x0600041E RID: 1054 RVA: 0x000144FC File Offset: 0x000126FC
			// (set) Token: 0x0600041F RID: 1055 RVA: 0x0000384C File Offset: 0x00001A4C
			public unsafe IEnumerable<T> __3__otherSequence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr___3__otherSequence);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr___3__otherSequence), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x06000420 RID: 1056 RVA: 0x0001452C File Offset: 0x0001272C
			// (set) Token: 0x06000421 RID: 1057 RVA: 0x0000386B File Offset: 0x00001A6B
			public unsafe IEnumerator<T> _seqEnumerator_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr__seqEnumerator_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr__seqEnumerator_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000EA RID: 234
			// (get) Token: 0x06000422 RID: 1058 RVA: 0x0001455C File Offset: 0x0001275C
			// (set) Token: 0x06000423 RID: 1059 RVA: 0x0000388A File Offset: 0x00001A8A
			public unsafe IEnumerator<T> _otherEnumerator_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr__otherEnumerator_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr__otherEnumerator_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x06000424 RID: 1060 RVA: 0x0001458C File Offset: 0x0001278C
			// (set) Token: 0x06000425 RID: 1061 RVA: 0x000038A9 File Offset: 0x00001AA9
			public unsafe bool _seqHasNext_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr__seqHasNext_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr__seqHasNext_5__4)) = value;
				}
			}

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x06000426 RID: 1062 RVA: 0x000145B4 File Offset: 0x000127B4
			// (set) Token: 0x06000427 RID: 1063 RVA: 0x000038C4 File Offset: 0x00001AC4
			public unsafe bool _otherHasNext_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr__otherHasNext_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Interleave_d__41<T>.NativeFieldInfoPtr__otherHasNext_5__5)) = value;
				}
			}

			// Token: 0x0400029F RID: 671
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002A0 RID: 672
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002A1 RID: 673
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040002A2 RID: 674
			private static readonly IntPtr NativeFieldInfoPtr_sequence;

			// Token: 0x040002A3 RID: 675
			private static readonly IntPtr NativeFieldInfoPtr___3__sequence;

			// Token: 0x040002A4 RID: 676
			private static readonly IntPtr NativeFieldInfoPtr_otherSequence;

			// Token: 0x040002A5 RID: 677
			private static readonly IntPtr NativeFieldInfoPtr___3__otherSequence;

			// Token: 0x040002A6 RID: 678
			private static readonly IntPtr NativeFieldInfoPtr__seqEnumerator_5__2;

			// Token: 0x040002A7 RID: 679
			private static readonly IntPtr NativeFieldInfoPtr__otherEnumerator_5__3;

			// Token: 0x040002A8 RID: 680
			private static readonly IntPtr NativeFieldInfoPtr__seqHasNext_5__4;

			// Token: 0x040002A9 RID: 681
			private static readonly IntPtr NativeFieldInfoPtr__otherHasNext_5__5;

			// Token: 0x040002AA RID: 682
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002AB RID: 683
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002AC RID: 684
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002AD RID: 685
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x040002AE RID: 686
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002AF RID: 687
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002B0 RID: 688
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x040002B1 RID: 689
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200006F RID: 111
		[ObfuscatedName("Utils.ListUtil+<Permutations>d__26`1")]
		public sealed class _Permutations_d__26<T> : Object
		{
			// Token: 0x06000428 RID: 1064 RVA: 0x000145DC File Offset: 0x000127DC
			// Note: this type is marked as 'beforefieldinit'.
			static _Permutations_d__26()
			{
				Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<Permutations>d__26`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr);
				ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr, "<>1__state");
				ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr, "<>2__current");
				ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr, "<>l__initialThreadId");
				ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr, "sequence");
				ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr___3__sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr, "<>3__sequence");
				ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr__len_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr, "<len>5__2");
				ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr__head_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr, "<head>5__3");
				ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr, "<>7__wrap3");
				ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr__subPermutation_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr, "<subPermutation>5__5");
				ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr, "<i>5__6");
				ListUtil._Permutations_d__26<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr, 100663742);
				ListUtil._Permutations_d__26<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr, 100663743);
				ListUtil._Permutations_d__26<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr, 100663744);
				ListUtil._Permutations_d__26<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr, 100663745);
				ListUtil._Permutations_d__26<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr, 100663746);
				ListUtil._Permutations_d__26<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr, 100663747);
				ListUtil._Permutations_d__26<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr, 100663748);
				ListUtil._Permutations_d__26<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr, 100663749);
				ListUtil._Permutations_d__26<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr, 100663750);
			}

			// Token: 0x06000429 RID: 1065 RVA: 0x000147C0 File Offset: 0x000129C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Permutations_d__26(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil._Permutations_d__26<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Permutations_d__26<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600042A RID: 1066 RVA: 0x00014808 File Offset: 0x00012A08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Permutations_d__26<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600042B RID: 1067 RVA: 0x0001483C File Offset: 0x00012A3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182159, XrefRangeEnd = 1182246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Permutations_d__26<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600042C RID: 1068 RVA: 0x00014878 File Offset: 0x00012A78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182246, XrefRangeEnd = 1182254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Permutations_d__26<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x0600042D RID: 1069 RVA: 0x000148AC File Offset: 0x00012AAC
			public unsafe Il2CppArrayBase<T> prop_Il2CppArrayBase_1_T_0
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Permutations_d__26<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
				}
			}

			// Token: 0x0600042E RID: 1070 RVA: 0x000148E4 File Offset: 0x00012AE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Permutations_d__26<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x0600042F RID: 1071 RVA: 0x00014918 File Offset: 0x00012B18
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Permutations_d__26<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000430 RID: 1072 RVA: 0x00014958 File Offset: 0x00012B58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182254, XrefRangeEnd = 1182267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Il2CppArrayBase<T>> Method_Private_Virtual_Final_New_IEnumerator_1_Il2CppArrayBase_1_T_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Permutations_d__26<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Il2CppArrayBase<T>>>(intPtr3) : null;
			}

			// Token: 0x06000431 RID: 1073 RVA: 0x00014998 File Offset: 0x00012B98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182267, XrefRangeEnd = 1182273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Permutations_d__26<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000432 RID: 1074 RVA: 0x000038DF File Offset: 0x00001ADF
			public _Permutations_d__26(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x06000433 RID: 1075 RVA: 0x000149D8 File Offset: 0x00012BD8
			// (set) Token: 0x06000434 RID: 1076 RVA: 0x000038E8 File Offset: 0x00001AE8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x06000435 RID: 1077 RVA: 0x00014A00 File Offset: 0x00012C00
			// (set) Token: 0x06000436 RID: 1078 RVA: 0x00003903 File Offset: 0x00001B03
			public unsafe Il2CppArrayBase<T> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr___2__current);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x06000437 RID: 1079 RVA: 0x00014A28 File Offset: 0x00012C28
			// (set) Token: 0x06000438 RID: 1080 RVA: 0x00003922 File Offset: 0x00001B22
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x06000439 RID: 1081 RVA: 0x00014A50 File Offset: 0x00012C50
			// (set) Token: 0x0600043A RID: 1082 RVA: 0x0000393D File Offset: 0x00001B3D
			public unsafe IEnumerable<T> sequence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr_sequence);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr_sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x0600043B RID: 1083 RVA: 0x00014A80 File Offset: 0x00012C80
			// (set) Token: 0x0600043C RID: 1084 RVA: 0x0000395C File Offset: 0x00001B5C
			public unsafe IEnumerable<T> __3__sequence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr___3__sequence);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr___3__sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x0600043D RID: 1085 RVA: 0x00014AB0 File Offset: 0x00012CB0
			// (set) Token: 0x0600043E RID: 1086 RVA: 0x0000397B File Offset: 0x00001B7B
			public unsafe int _len_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr__len_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr__len_5__2)) = value;
				}
			}

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x0600043F RID: 1087 RVA: 0x00014AD8 File Offset: 0x00012CD8
			// (set) Token: 0x06000440 RID: 1088 RVA: 0x00014B00 File Offset: 0x00012D00
			public unsafe T _head_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr__head_5__3);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr__head_5__3);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x06000441 RID: 1089 RVA: 0x00014BA8 File Offset: 0x00012DA8
			// (set) Token: 0x06000442 RID: 1090 RVA: 0x00003996 File Offset: 0x00001B96
			public unsafe IEnumerator<Il2CppArrayBase<T>> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Il2CppArrayBase<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x06000443 RID: 1091 RVA: 0x00014BD8 File Offset: 0x00012DD8
			// (set) Token: 0x06000444 RID: 1092 RVA: 0x000039B5 File Offset: 0x00001BB5
			public unsafe Il2CppArrayBase<T> _subPermutation_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr__subPermutation_5__5);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr__subPermutation_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x06000445 RID: 1093 RVA: 0x00014C00 File Offset: 0x00012E00
			// (set) Token: 0x06000446 RID: 1094 RVA: 0x000039D4 File Offset: 0x00001BD4
			public unsafe int _i_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr__i_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Permutations_d__26<T>.NativeFieldInfoPtr__i_5__6)) = value;
				}
			}

			// Token: 0x040002B2 RID: 690
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002B3 RID: 691
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002B4 RID: 692
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040002B5 RID: 693
			private static readonly IntPtr NativeFieldInfoPtr_sequence;

			// Token: 0x040002B6 RID: 694
			private static readonly IntPtr NativeFieldInfoPtr___3__sequence;

			// Token: 0x040002B7 RID: 695
			private static readonly IntPtr NativeFieldInfoPtr__len_5__2;

			// Token: 0x040002B8 RID: 696
			private static readonly IntPtr NativeFieldInfoPtr__head_5__3;

			// Token: 0x040002B9 RID: 697
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x040002BA RID: 698
			private static readonly IntPtr NativeFieldInfoPtr__subPermutation_5__5;

			// Token: 0x040002BB RID: 699
			private static readonly IntPtr NativeFieldInfoPtr__i_5__6;

			// Token: 0x040002BC RID: 700
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002BD RID: 701
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002BE RID: 702
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002BF RID: 703
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040002C0 RID: 704
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Il2CppArrayBase_1_T_0;

			// Token: 0x040002C1 RID: 705
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002C2 RID: 706
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002C3 RID: 707
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_Il2CppArrayBase_1_T_0;

			// Token: 0x040002C4 RID: 708
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000070 RID: 112
		[ObfuscatedName("Utils.ListUtil+<Pivot>d__52`1")]
		public sealed class _Pivot_d__52<T> : Object
		{
			// Token: 0x06000447 RID: 1095 RVA: 0x00014C28 File Offset: 0x00012E28
			// Note: this type is marked as 'beforefieldinit'.
			static _Pivot_d__52()
			{
				Il2CppClassPointerStore<ListUtil._Pivot_d__52<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<Pivot>d__52`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil._Pivot_d__52<T>>.NativeClassPtr);
				ListUtil._Pivot_d__52<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Pivot_d__52<T>>.NativeClassPtr, "<>1__state");
				ListUtil._Pivot_d__52<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Pivot_d__52<T>>.NativeClassPtr, "<>2__current");
				ListUtil._Pivot_d__52<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Pivot_d__52<T>>.NativeClassPtr, "<>l__initialThreadId");
				ListUtil._Pivot_d__52<T>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Pivot_d__52<T>>.NativeClassPtr, "source");
				ListUtil._Pivot_d__52<T>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Pivot_d__52<T>>.NativeClassPtr, "<>3__source");
				ListUtil._Pivot_d__52<T>.NativeFieldInfoPtr__enumerators_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Pivot_d__52<T>>.NativeClassPtr, "<enumerators>5__2");
				ListUtil._Pivot_d__52<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Pivot_d__52<T>>.NativeClassPtr, 100663751);
				ListUtil._Pivot_d__52<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Pivot_d__52<T>>.NativeClassPtr, 100663752);
				ListUtil._Pivot_d__52<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Pivot_d__52<T>>.NativeClassPtr, 100663753);
				ListUtil._Pivot_d__52<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Pivot_d__52<T>>.NativeClassPtr, 100663754);
				ListUtil._Pivot_d__52<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_T___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Pivot_d__52<T>>.NativeClassPtr, 100663755);
				ListUtil._Pivot_d__52<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Pivot_d__52<T>>.NativeClassPtr, 100663756);
				ListUtil._Pivot_d__52<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Pivot_d__52<T>>.NativeClassPtr, 100663757);
				ListUtil._Pivot_d__52<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_T___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Pivot_d__52<T>>.NativeClassPtr, 100663758);
				ListUtil._Pivot_d__52<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Pivot_d__52<T>>.NativeClassPtr, 100663759);
			}

			// Token: 0x06000448 RID: 1096 RVA: 0x00014DBC File Offset: 0x00012FBC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Pivot_d__52(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil._Pivot_d__52<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Pivot_d__52<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000449 RID: 1097 RVA: 0x00014E04 File Offset: 0x00013004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Pivot_d__52<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600044A RID: 1098 RVA: 0x00014E38 File Offset: 0x00013038
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182273, XrefRangeEnd = 1182312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Pivot_d__52<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600044B RID: 1099 RVA: 0x00014E74 File Offset: 0x00013074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182312, XrefRangeEnd = 1182323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Pivot_d__52<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x0600044C RID: 1100 RVA: 0x00014EA8 File Offset: 0x000130A8
			public unsafe IEnumerable<T> System.Collections.Generic.IEnumerator<System.Collections.Generic.IEnumerable<T>>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Pivot_d__52<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_T___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
				}
			}

			// Token: 0x0600044D RID: 1101 RVA: 0x00014EE8 File Offset: 0x000130E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Pivot_d__52<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000102 RID: 258
			// (get) Token: 0x0600044E RID: 1102 RVA: 0x00014F1C File Offset: 0x0001311C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Pivot_d__52<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600044F RID: 1103 RVA: 0x00014F5C File Offset: 0x0001315C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182323, XrefRangeEnd = 1182328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<IEnumerable<T>> System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_T___GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Pivot_d__52<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_T___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IEnumerable<T>>>(intPtr3) : null;
			}

			// Token: 0x06000450 RID: 1104 RVA: 0x00014F9C File Offset: 0x0001319C
			[CallerCount(0)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Pivot_d__52<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000451 RID: 1105 RVA: 0x000039EF File Offset: 0x00001BEF
			public _Pivot_d__52(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x06000452 RID: 1106 RVA: 0x00014FDC File Offset: 0x000131DC
			// (set) Token: 0x06000453 RID: 1107 RVA: 0x000039F8 File Offset: 0x00001BF8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Pivot_d__52<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Pivot_d__52<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x06000454 RID: 1108 RVA: 0x00015004 File Offset: 0x00013204
			// (set) Token: 0x06000455 RID: 1109 RVA: 0x00003A13 File Offset: 0x00001C13
			public unsafe IEnumerable<T> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Pivot_d__52<T>.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Pivot_d__52<T>.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x06000456 RID: 1110 RVA: 0x00015034 File Offset: 0x00013234
			// (set) Token: 0x06000457 RID: 1111 RVA: 0x00003A32 File Offset: 0x00001C32
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Pivot_d__52<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Pivot_d__52<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x06000458 RID: 1112 RVA: 0x0001505C File Offset: 0x0001325C
			// (set) Token: 0x06000459 RID: 1113 RVA: 0x00003A4D File Offset: 0x00001C4D
			public unsafe IEnumerable<IEnumerable<T>> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Pivot_d__52<T>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Pivot_d__52<T>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x0600045A RID: 1114 RVA: 0x0001508C File Offset: 0x0001328C
			// (set) Token: 0x0600045B RID: 1115 RVA: 0x00003A6C File Offset: 0x00001C6C
			public unsafe IEnumerable<IEnumerable<T>> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Pivot_d__52<T>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Pivot_d__52<T>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x0600045C RID: 1116 RVA: 0x000150BC File Offset: 0x000132BC
			// (set) Token: 0x0600045D RID: 1117 RVA: 0x00003A8B File Offset: 0x00001C8B
			public unsafe Il2CppReferenceArray<IEnumerator<T>> _enumerators_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Pivot_d__52<T>.NativeFieldInfoPtr__enumerators_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IEnumerator<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Pivot_d__52<T>.NativeFieldInfoPtr__enumerators_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002C5 RID: 709
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002C6 RID: 710
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002C7 RID: 711
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040002C8 RID: 712
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x040002C9 RID: 713
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x040002CA RID: 714
			private static readonly IntPtr NativeFieldInfoPtr__enumerators_5__2;

			// Token: 0x040002CB RID: 715
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002CC RID: 716
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002CD RID: 717
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002CE RID: 718
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040002CF RID: 719
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Collections_Generic_IEnumerable_T___get_Current_Private_Virtual_Final_New_get_IEnumerable_1_T_0;

			// Token: 0x040002D0 RID: 720
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002D1 RID: 721
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002D2 RID: 722
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Collections_Generic_IEnumerable_T___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IEnumerable_1_T_0;

			// Token: 0x040002D3 RID: 723
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000071 RID: 113
		[ObfuscatedName("Utils.ListUtil+<PostOrderTraversal>d__14`1")]
		public sealed class _PostOrderTraversal_d__14<TValue> : Object
		{
			// Token: 0x0600045E RID: 1118 RVA: 0x000150EC File Offset: 0x000132EC
			// Note: this type is marked as 'beforefieldinit'.
			static _PostOrderTraversal_d__14()
			{
				Il2CppClassPointerStore<ListUtil._PostOrderTraversal_d__14<TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<PostOrderTraversal>d__14`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil._PostOrderTraversal_d__14<TValue>>.NativeClassPtr);
				ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._PostOrderTraversal_d__14<TValue>>.NativeClassPtr, "<>1__state");
				ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._PostOrderTraversal_d__14<TValue>>.NativeClassPtr, "<>2__current");
				ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._PostOrderTraversal_d__14<TValue>>.NativeClassPtr, "<>l__initialThreadId");
				ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr_descendantsSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._PostOrderTraversal_d__14<TValue>>.NativeClassPtr, "descendantsSelector");
				ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr___3__descendantsSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._PostOrderTraversal_d__14<TValue>>.NativeClassPtr, "<>3__descendantsSelector");
				ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._PostOrderTraversal_d__14<TValue>>.NativeClassPtr, "root");
				ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr___3__root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._PostOrderTraversal_d__14<TValue>>.NativeClassPtr, "<>3__root");
				ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._PostOrderTraversal_d__14<TValue>>.NativeClassPtr, "<>7__wrap1");
				ListUtil._PostOrderTraversal_d__14<TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._PostOrderTraversal_d__14<TValue>>.NativeClassPtr, 100663760);
				ListUtil._PostOrderTraversal_d__14<TValue>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._PostOrderTraversal_d__14<TValue>>.NativeClassPtr, 100663761);
				ListUtil._PostOrderTraversal_d__14<TValue>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._PostOrderTraversal_d__14<TValue>>.NativeClassPtr, 100663762);
				ListUtil._PostOrderTraversal_d__14<TValue>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._PostOrderTraversal_d__14<TValue>>.NativeClassPtr, 100663763);
				ListUtil._PostOrderTraversal_d__14<TValue>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TValue__get_Current_Private_Virtual_Final_New_get_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._PostOrderTraversal_d__14<TValue>>.NativeClassPtr, 100663764);
				ListUtil._PostOrderTraversal_d__14<TValue>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._PostOrderTraversal_d__14<TValue>>.NativeClassPtr, 100663765);
				ListUtil._PostOrderTraversal_d__14<TValue>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._PostOrderTraversal_d__14<TValue>>.NativeClassPtr, 100663766);
				ListUtil._PostOrderTraversal_d__14<TValue>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._PostOrderTraversal_d__14<TValue>>.NativeClassPtr, 100663767);
				ListUtil._PostOrderTraversal_d__14<TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._PostOrderTraversal_d__14<TValue>>.NativeClassPtr, 100663768);
			}

			// Token: 0x0600045F RID: 1119 RVA: 0x000152A8 File Offset: 0x000134A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PostOrderTraversal_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil._PostOrderTraversal_d__14<TValue>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._PostOrderTraversal_d__14<TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000460 RID: 1120 RVA: 0x000152F0 File Offset: 0x000134F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._PostOrderTraversal_d__14<TValue>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000461 RID: 1121 RVA: 0x00015324 File Offset: 0x00013524
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182328, XrefRangeEnd = 1182386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._PostOrderTraversal_d__14<TValue>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000462 RID: 1122 RVA: 0x00015360 File Offset: 0x00013560
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182386, XrefRangeEnd = 1182394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._PostOrderTraversal_d__14<TValue>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x06000463 RID: 1123 RVA: 0x00015394 File Offset: 0x00013594
			public unsafe TValue System.Collections.Generic.IEnumerator<TValue>.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._PostOrderTraversal_d__14<TValue>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TValue__get_Current_Private_Virtual_Final_New_get_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
				}
			}

			// Token: 0x06000464 RID: 1124 RVA: 0x000153D0 File Offset: 0x000135D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._PostOrderTraversal_d__14<TValue>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x06000465 RID: 1125 RVA: 0x00015404 File Offset: 0x00013604
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._PostOrderTraversal_d__14<TValue>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000466 RID: 1126 RVA: 0x00015444 File Offset: 0x00013644
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182394, XrefRangeEnd = 1182411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TValue> System_Collections_Generic_IEnumerable_TValue__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._PostOrderTraversal_d__14<TValue>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TValue>>(intPtr3) : null;
			}

			// Token: 0x06000467 RID: 1127 RVA: 0x00015484 File Offset: 0x00013684
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._PostOrderTraversal_d__14<TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000468 RID: 1128 RVA: 0x00003AAA File Offset: 0x00001CAA
			public _PostOrderTraversal_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x06000469 RID: 1129 RVA: 0x000154C4 File Offset: 0x000136C4
			// (set) Token: 0x0600046A RID: 1130 RVA: 0x00003AB3 File Offset: 0x00001CB3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x0600046B RID: 1131 RVA: 0x000154EC File Offset: 0x000136EC
			// (set) Token: 0x0600046C RID: 1132 RVA: 0x00015514 File Offset: 0x00013714
			public unsafe TValue __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TValue);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x0600046D RID: 1133 RVA: 0x000155BC File Offset: 0x000137BC
			// (set) Token: 0x0600046E RID: 1134 RVA: 0x00003ACE File Offset: 0x00001CCE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x0600046F RID: 1135 RVA: 0x000155E4 File Offset: 0x000137E4
			// (set) Token: 0x06000470 RID: 1136 RVA: 0x00003AE9 File Offset: 0x00001CE9
			public unsafe Func<TValue, IEnumerable<TValue>> descendantsSelector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr_descendantsSelector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TValue, IEnumerable<TValue>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr_descendantsSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000107 RID: 263
			// (get) Token: 0x06000471 RID: 1137 RVA: 0x00015614 File Offset: 0x00013814
			// (set) Token: 0x06000472 RID: 1138 RVA: 0x00003B08 File Offset: 0x00001D08
			public unsafe Func<TValue, IEnumerable<TValue>> __3__descendantsSelector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr___3__descendantsSelector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TValue, IEnumerable<TValue>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr___3__descendantsSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x06000473 RID: 1139 RVA: 0x00015644 File Offset: 0x00013844
			// (set) Token: 0x06000474 RID: 1140 RVA: 0x0001566C File Offset: 0x0001386C
			public unsafe TValue root
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr_root);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr_root);
					Type typeFromHandle = typeof(TValue);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x06000475 RID: 1141 RVA: 0x00015714 File Offset: 0x00013914
			// (set) Token: 0x06000476 RID: 1142 RVA: 0x0001573C File Offset: 0x0001393C
			public unsafe TValue __3__root
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr___3__root);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr___3__root);
					Type typeFromHandle = typeof(TValue);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x06000477 RID: 1143 RVA: 0x000157E4 File Offset: 0x000139E4
			// (set) Token: 0x06000478 RID: 1144 RVA: 0x00003B27 File Offset: 0x00001D27
			public unsafe IEnumerator<TValue> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._PostOrderTraversal_d__14<TValue>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002D4 RID: 724
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002D5 RID: 725
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002D6 RID: 726
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040002D7 RID: 727
			private static readonly IntPtr NativeFieldInfoPtr_descendantsSelector;

			// Token: 0x040002D8 RID: 728
			private static readonly IntPtr NativeFieldInfoPtr___3__descendantsSelector;

			// Token: 0x040002D9 RID: 729
			private static readonly IntPtr NativeFieldInfoPtr_root;

			// Token: 0x040002DA RID: 730
			private static readonly IntPtr NativeFieldInfoPtr___3__root;

			// Token: 0x040002DB RID: 731
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040002DC RID: 732
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002DD RID: 733
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002DE RID: 734
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002DF RID: 735
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040002E0 RID: 736
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TValue__get_Current_Private_Virtual_Final_New_get_TValue_0;

			// Token: 0x040002E1 RID: 737
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002E2 RID: 738
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002E3 RID: 739
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TValue_0;

			// Token: 0x040002E4 RID: 740
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000072 RID: 114
		[ObfuscatedName("Utils.ListUtil+<RefGaps>d__43`1")]
		public sealed class _RefGaps_d__43<T> : Object where T : class
		{
			// Token: 0x06000479 RID: 1145 RVA: 0x00015814 File Offset: 0x00013A14
			// Note: this type is marked as 'beforefieldinit'.
			static _RefGaps_d__43()
			{
				Il2CppClassPointerStore<ListUtil._RefGaps_d__43<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<RefGaps>d__43`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil._RefGaps_d__43<T>>.NativeClassPtr);
				ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._RefGaps_d__43<T>>.NativeClassPtr, "<>1__state");
				ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._RefGaps_d__43<T>>.NativeClassPtr, "<>2__current");
				ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._RefGaps_d__43<T>>.NativeClassPtr, "<>l__initialThreadId");
				ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._RefGaps_d__43<T>>.NativeClassPtr, "sequence");
				ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr___3__sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._RefGaps_d__43<T>>.NativeClassPtr, "<>3__sequence");
				ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr__arr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._RefGaps_d__43<T>>.NativeClassPtr, "<arr>5__2");
				ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr__arrLength_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._RefGaps_d__43<T>>.NativeClassPtr, "<arrLength>5__3");
				ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._RefGaps_d__43<T>>.NativeClassPtr, "<i>5__4");
				ListUtil._RefGaps_d__43<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._RefGaps_d__43<T>>.NativeClassPtr, 100663769);
				ListUtil._RefGaps_d__43<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._RefGaps_d__43<T>>.NativeClassPtr, 100663770);
				ListUtil._RefGaps_d__43<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._RefGaps_d__43<T>>.NativeClassPtr, 100663771);
				ListUtil._RefGaps_d__43<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_Int32_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._RefGaps_d__43<T>>.NativeClassPtr, 100663772);
				ListUtil._RefGaps_d__43<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._RefGaps_d__43<T>>.NativeClassPtr, 100663773);
				ListUtil._RefGaps_d__43<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._RefGaps_d__43<T>>.NativeClassPtr, 100663774);
				ListUtil._RefGaps_d__43<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_Int32_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._RefGaps_d__43<T>>.NativeClassPtr, 100663775);
				ListUtil._RefGaps_d__43<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._RefGaps_d__43<T>>.NativeClassPtr, 100663776);
			}

			// Token: 0x0600047A RID: 1146 RVA: 0x000159BC File Offset: 0x00013BBC
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 937091, RefRangeEnd = 937095, XrefRangeStart = 937091, XrefRangeEnd = 937095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RefGaps_d__43(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil._RefGaps_d__43<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._RefGaps_d__43<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600047B RID: 1147 RVA: 0x00015A04 File Offset: 0x00013C04
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._RefGaps_d__43<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600047C RID: 1148 RVA: 0x00015A38 File Offset: 0x00013C38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182411, XrefRangeEnd = 1182417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._RefGaps_d__43<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x0600047D RID: 1149 RVA: 0x00015A74 File Offset: 0x00013C74
			public unsafe ValueTuple<int, T, T> prop_ValueTuple_3_Int32_T_T_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._RefGaps_d__43<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_Int32_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<int, T, T>(intPtr);
				}
			}

			// Token: 0x0600047E RID: 1150 RVA: 0x00015AAC File Offset: 0x00013CAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._RefGaps_d__43<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x0600047F RID: 1151 RVA: 0x00015AE0 File Offset: 0x00013CE0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182417, XrefRangeEnd = 1182418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._RefGaps_d__43<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000480 RID: 1152 RVA: 0x00015B20 File Offset: 0x00013D20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182418, XrefRangeEnd = 1182425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<int, T, T>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_Int32_T_T_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._RefGaps_d__43<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_Int32_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<int, T, T>>>(intPtr3) : null;
			}

			// Token: 0x06000481 RID: 1153 RVA: 0x00015B60 File Offset: 0x00013D60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182425, XrefRangeEnd = 1182432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._RefGaps_d__43<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000482 RID: 1154 RVA: 0x00003B46 File Offset: 0x00001D46
			public _RefGaps_d__43(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x06000483 RID: 1155 RVA: 0x00015BA0 File Offset: 0x00013DA0
			// (set) Token: 0x06000484 RID: 1156 RVA: 0x00003B4F File Offset: 0x00001D4F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x06000485 RID: 1157 RVA: 0x00015BC8 File Offset: 0x00013DC8
			// (set) Token: 0x06000486 RID: 1158 RVA: 0x00003B6A File Offset: 0x00001D6A
			public ValueTuple<int, T, T> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr___2__current);
					return new ValueTuple<int, T, T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<int, T, T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<int, T, T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x06000487 RID: 1159 RVA: 0x00015BF8 File Offset: 0x00013DF8
			// (set) Token: 0x06000488 RID: 1160 RVA: 0x00003B98 File Offset: 0x00001D98
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x06000489 RID: 1161 RVA: 0x00015C20 File Offset: 0x00013E20
			// (set) Token: 0x0600048A RID: 1162 RVA: 0x00003BB3 File Offset: 0x00001DB3
			public unsafe IEnumerable<T> sequence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr_sequence);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr_sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x0600048B RID: 1163 RVA: 0x00015C50 File Offset: 0x00013E50
			// (set) Token: 0x0600048C RID: 1164 RVA: 0x00003BD2 File Offset: 0x00001DD2
			public unsafe IEnumerable<T> __3__sequence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr___3__sequence);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr___3__sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x0600048D RID: 1165 RVA: 0x00015C80 File Offset: 0x00013E80
			// (set) Token: 0x0600048E RID: 1166 RVA: 0x00003BF1 File Offset: 0x00001DF1
			public unsafe Il2CppArrayBase<T> _arr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr__arr_5__2);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr__arr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x0600048F RID: 1167 RVA: 0x00015CA8 File Offset: 0x00013EA8
			// (set) Token: 0x06000490 RID: 1168 RVA: 0x00003C10 File Offset: 0x00001E10
			public unsafe int _arrLength_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr__arrLength_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr__arrLength_5__3)) = value;
				}
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x06000491 RID: 1169 RVA: 0x00015CD0 File Offset: 0x00013ED0
			// (set) Token: 0x06000492 RID: 1170 RVA: 0x00003C2B File Offset: 0x00001E2B
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._RefGaps_d__43<T>.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x040002E5 RID: 741
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002E6 RID: 742
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002E7 RID: 743
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040002E8 RID: 744
			private static readonly IntPtr NativeFieldInfoPtr_sequence;

			// Token: 0x040002E9 RID: 745
			private static readonly IntPtr NativeFieldInfoPtr___3__sequence;

			// Token: 0x040002EA RID: 746
			private static readonly IntPtr NativeFieldInfoPtr__arr_5__2;

			// Token: 0x040002EB RID: 747
			private static readonly IntPtr NativeFieldInfoPtr__arrLength_5__3;

			// Token: 0x040002EC RID: 748
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x040002ED RID: 749
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002EE RID: 750
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002EF RID: 751
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002F0 RID: 752
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_Int32_T_T_0;

			// Token: 0x040002F1 RID: 753
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002F2 RID: 754
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002F3 RID: 755
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_Int32_T_T_0;

			// Token: 0x040002F4 RID: 756
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000073 RID: 115
		[ObfuscatedName("Utils.ListUtil+<Repeated>d__46`1")]
		public sealed class _Repeated_d__46<T> : Object
		{
			// Token: 0x06000493 RID: 1171 RVA: 0x00015CF8 File Offset: 0x00013EF8
			// Note: this type is marked as 'beforefieldinit'.
			static _Repeated_d__46()
			{
				Il2CppClassPointerStore<ListUtil._Repeated_d__46<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<Repeated>d__46`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil._Repeated_d__46<T>>.NativeClassPtr);
				ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Repeated_d__46<T>>.NativeClassPtr, "<>1__state");
				ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Repeated_d__46<T>>.NativeClassPtr, "<>2__current");
				ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Repeated_d__46<T>>.NativeClassPtr, "<>l__initialThreadId");
				ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Repeated_d__46<T>>.NativeClassPtr, "sequence");
				ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr___3__sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Repeated_d__46<T>>.NativeClassPtr, "<>3__sequence");
				ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr__arr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Repeated_d__46<T>>.NativeClassPtr, "<arr>5__2");
				ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Repeated_d__46<T>>.NativeClassPtr, "<>7__wrap2");
				ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Repeated_d__46<T>>.NativeClassPtr, "<>7__wrap3");
				ListUtil._Repeated_d__46<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Repeated_d__46<T>>.NativeClassPtr, 100663777);
				ListUtil._Repeated_d__46<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Repeated_d__46<T>>.NativeClassPtr, 100663778);
				ListUtil._Repeated_d__46<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Repeated_d__46<T>>.NativeClassPtr, 100663779);
				ListUtil._Repeated_d__46<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Repeated_d__46<T>>.NativeClassPtr, 100663780);
				ListUtil._Repeated_d__46<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Repeated_d__46<T>>.NativeClassPtr, 100663781);
				ListUtil._Repeated_d__46<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Repeated_d__46<T>>.NativeClassPtr, 100663782);
				ListUtil._Repeated_d__46<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Repeated_d__46<T>>.NativeClassPtr, 100663783);
				ListUtil._Repeated_d__46<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Repeated_d__46<T>>.NativeClassPtr, 100663784);
			}

			// Token: 0x06000494 RID: 1172 RVA: 0x00015EA0 File Offset: 0x000140A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Repeated_d__46(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil._Repeated_d__46<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Repeated_d__46<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000495 RID: 1173 RVA: 0x00015EE8 File Offset: 0x000140E8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Repeated_d__46<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000496 RID: 1174 RVA: 0x00015F1C File Offset: 0x0001411C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182432, XrefRangeEnd = 1182473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Repeated_d__46<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x06000497 RID: 1175 RVA: 0x00015F58 File Offset: 0x00014158
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182473, XrefRangeEnd = 1182477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Repeated_d__46<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06000498 RID: 1176 RVA: 0x00015F94 File Offset: 0x00014194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Repeated_d__46<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x06000499 RID: 1177 RVA: 0x00015FC8 File Offset: 0x000141C8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182477, XrefRangeEnd = 1182481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Repeated_d__46<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600049A RID: 1178 RVA: 0x00016008 File Offset: 0x00014208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182481, XrefRangeEnd = 1182494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Repeated_d__46<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x0600049B RID: 1179 RVA: 0x00016048 File Offset: 0x00014248
			[CallerCount(0)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Repeated_d__46<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600049C RID: 1180 RVA: 0x00003C46 File Offset: 0x00001E46
			public _Repeated_d__46(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x0600049D RID: 1181 RVA: 0x00016088 File Offset: 0x00014288
			// (set) Token: 0x0600049E RID: 1182 RVA: 0x00003C4F File Offset: 0x00001E4F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x0600049F RID: 1183 RVA: 0x000160B0 File Offset: 0x000142B0
			// (set) Token: 0x060004A0 RID: 1184 RVA: 0x000160D8 File Offset: 0x000142D8
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00016180 File Offset: 0x00014380
			// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00003C6A File Offset: 0x00001E6A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x060004A3 RID: 1187 RVA: 0x000161A8 File Offset: 0x000143A8
			// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00003C85 File Offset: 0x00001E85
			public unsafe IEnumerable<T> sequence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr_sequence);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr_sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x060004A5 RID: 1189 RVA: 0x000161D8 File Offset: 0x000143D8
			// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00003CA4 File Offset: 0x00001EA4
			public unsafe IEnumerable<T> __3__sequence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr___3__sequence);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr___3__sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00016208 File Offset: 0x00014408
			// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00003CC3 File Offset: 0x00001EC3
			public unsafe Il2CppArrayBase<T> _arr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr__arr_5__2);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr__arr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00016230 File Offset: 0x00014430
			// (set) Token: 0x060004AA RID: 1194 RVA: 0x00003CE2 File Offset: 0x00001EE2
			public unsafe Il2CppArrayBase<T> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr___7__wrap2);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x060004AB RID: 1195 RVA: 0x00016258 File Offset: 0x00014458
			// (set) Token: 0x060004AC RID: 1196 RVA: 0x00003D01 File Offset: 0x00001F01
			public unsafe int __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr___7__wrap3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Repeated_d__46<T>.NativeFieldInfoPtr___7__wrap3)) = value;
				}
			}

			// Token: 0x040002F5 RID: 757
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002F6 RID: 758
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002F7 RID: 759
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040002F8 RID: 760
			private static readonly IntPtr NativeFieldInfoPtr_sequence;

			// Token: 0x040002F9 RID: 761
			private static readonly IntPtr NativeFieldInfoPtr___3__sequence;

			// Token: 0x040002FA RID: 762
			private static readonly IntPtr NativeFieldInfoPtr__arr_5__2;

			// Token: 0x040002FB RID: 763
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040002FC RID: 764
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x040002FD RID: 765
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002FE RID: 766
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002FF RID: 767
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000300 RID: 768
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x04000301 RID: 769
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000302 RID: 770
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000303 RID: 771
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x04000304 RID: 772
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000074 RID: 116
		[ObfuscatedName("Utils.ListUtil+<SelectWhere>d__15`2")]
		public sealed class _SelectWhere_d__15<TSource, TResult> : Object
		{
			// Token: 0x060004AD RID: 1197 RVA: 0x00016280 File Offset: 0x00014480
			// Note: this type is marked as 'beforefieldinit'.
			static _SelectWhere_d__15()
			{
				Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<SelectWhere>d__15`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr);
				ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr, "<>1__state");
				ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr, "<>2__current");
				ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr, "<>l__initialThreadId");
				ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr, "source");
				ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr, "<>3__source");
				ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr, "selector");
				ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr___3__selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr, "<>3__selector");
				ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr_condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr, "condition");
				ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr___3__condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr, "<>3__condition");
				ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr, "<>7__wrap1");
				ListUtil._SelectWhere_d__15<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr, 100663785);
				ListUtil._SelectWhere_d__15<TSource, TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr, 100663786);
				ListUtil._SelectWhere_d__15<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr, 100663787);
				ListUtil._SelectWhere_d__15<TSource, TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr, 100663788);
				ListUtil._SelectWhere_d__15<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr, 100663789);
				ListUtil._SelectWhere_d__15<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr, 100663790);
				ListUtil._SelectWhere_d__15<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr, 100663791);
				ListUtil._SelectWhere_d__15<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr, 100663792);
				ListUtil._SelectWhere_d__15<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr, 100663793);
			}

			// Token: 0x060004AE RID: 1198 RVA: 0x00016474 File Offset: 0x00014674
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SelectWhere_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil._SelectWhere_d__15<TSource, TResult>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060004AF RID: 1199 RVA: 0x000164BC File Offset: 0x000146BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182494, XrefRangeEnd = 1182499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004B0 RID: 1200 RVA: 0x000164F0 File Offset: 0x000146F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182499, XrefRangeEnd = 1182515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060004B1 RID: 1201 RVA: 0x0001652C File Offset: 0x0001472C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182515, XrefRangeEnd = 1182518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00016560 File Offset: 0x00014760
			public unsafe TResult System.Collections.Generic.IEnumerator<TResult>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
				}
			}

			// Token: 0x060004B3 RID: 1203 RVA: 0x0001659C File Offset: 0x0001479C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x060004B4 RID: 1204 RVA: 0x000165D0 File Offset: 0x000147D0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060004B5 RID: 1205 RVA: 0x00016610 File Offset: 0x00014810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182518, XrefRangeEnd = 1182527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TResult> System_Collections_Generic_IEnumerable_TResult__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TResult>>(intPtr3) : null;
			}

			// Token: 0x060004B6 RID: 1206 RVA: 0x00016650 File Offset: 0x00014850
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182527, XrefRangeEnd = 1182536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060004B7 RID: 1207 RVA: 0x00003D1C File Offset: 0x00001F1C
			public _SelectWhere_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00016690 File Offset: 0x00014890
			// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00003D25 File Offset: 0x00001F25
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x060004BA RID: 1210 RVA: 0x000166B8 File Offset: 0x000148B8
			// (set) Token: 0x060004BB RID: 1211 RVA: 0x000166E0 File Offset: 0x000148E0
			public unsafe TResult __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TResult);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x060004BC RID: 1212 RVA: 0x00016788 File Offset: 0x00014988
			// (set) Token: 0x060004BD RID: 1213 RVA: 0x00003D40 File Offset: 0x00001F40
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x060004BE RID: 1214 RVA: 0x000167B0 File Offset: 0x000149B0
			// (set) Token: 0x060004BF RID: 1215 RVA: 0x00003D5B File Offset: 0x00001F5B
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x060004C0 RID: 1216 RVA: 0x000167E0 File Offset: 0x000149E0
			// (set) Token: 0x060004C1 RID: 1217 RVA: 0x00003D7A File Offset: 0x00001F7A
			public unsafe IEnumerable<TSource> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00016810 File Offset: 0x00014A10
			// (set) Token: 0x060004C3 RID: 1219 RVA: 0x00003D99 File Offset: 0x00001F99
			public unsafe Func<TSource, TResult> selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr_selector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00016840 File Offset: 0x00014A40
			// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00003DB8 File Offset: 0x00001FB8
			public unsafe Func<TSource, TResult> __3__selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr___3__selector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr___3__selector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00016870 File Offset: 0x00014A70
			// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00003DD7 File Offset: 0x00001FD7
			public unsafe Func<TSource, bool> condition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr_condition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr_condition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x060004C8 RID: 1224 RVA: 0x000168A0 File Offset: 0x00014AA0
			// (set) Token: 0x060004C9 RID: 1225 RVA: 0x00003DF6 File Offset: 0x00001FF6
			public unsafe Func<TSource, bool> __3__condition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr___3__condition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr___3__condition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x060004CA RID: 1226 RVA: 0x000168D0 File Offset: 0x00014AD0
			// (set) Token: 0x060004CB RID: 1227 RVA: 0x00003E15 File Offset: 0x00002015
			public unsafe IEnumerator<TSource> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__15<TSource, TResult>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000305 RID: 773
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000306 RID: 774
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000307 RID: 775
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000308 RID: 776
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000309 RID: 777
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x0400030A RID: 778
			private static readonly IntPtr NativeFieldInfoPtr_selector;

			// Token: 0x0400030B RID: 779
			private static readonly IntPtr NativeFieldInfoPtr___3__selector;

			// Token: 0x0400030C RID: 780
			private static readonly IntPtr NativeFieldInfoPtr_condition;

			// Token: 0x0400030D RID: 781
			private static readonly IntPtr NativeFieldInfoPtr___3__condition;

			// Token: 0x0400030E RID: 782
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400030F RID: 783
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000310 RID: 784
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000311 RID: 785
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000312 RID: 786
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000313 RID: 787
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0;

			// Token: 0x04000314 RID: 788
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000315 RID: 789
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000316 RID: 790
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0;

			// Token: 0x04000317 RID: 791
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000075 RID: 117
		[ObfuscatedName("Utils.ListUtil+<SelectWhere>d__16`2")]
		public sealed class _SelectWhere_d__16<TSource, TResult> : Object
		{
			// Token: 0x060004CC RID: 1228 RVA: 0x00016900 File Offset: 0x00014B00
			// Note: this type is marked as 'beforefieldinit'.
			static _SelectWhere_d__16()
			{
				Il2CppClassPointerStore<ListUtil._SelectWhere_d__16<TSource, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<SelectWhere>d__16`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil._SelectWhere_d__16<TSource, TResult>>.NativeClassPtr);
				ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._SelectWhere_d__16<TSource, TResult>>.NativeClassPtr, "<>1__state");
				ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._SelectWhere_d__16<TSource, TResult>>.NativeClassPtr, "<>2__current");
				ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._SelectWhere_d__16<TSource, TResult>>.NativeClassPtr, "<>l__initialThreadId");
				ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._SelectWhere_d__16<TSource, TResult>>.NativeClassPtr, "source");
				ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._SelectWhere_d__16<TSource, TResult>>.NativeClassPtr, "<>3__source");
				ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._SelectWhere_d__16<TSource, TResult>>.NativeClassPtr, "selector");
				ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr___3__selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._SelectWhere_d__16<TSource, TResult>>.NativeClassPtr, "<>3__selector");
				ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._SelectWhere_d__16<TSource, TResult>>.NativeClassPtr, "<>7__wrap1");
				ListUtil._SelectWhere_d__16<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._SelectWhere_d__16<TSource, TResult>>.NativeClassPtr, 100663794);
				ListUtil._SelectWhere_d__16<TSource, TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._SelectWhere_d__16<TSource, TResult>>.NativeClassPtr, 100663795);
				ListUtil._SelectWhere_d__16<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._SelectWhere_d__16<TSource, TResult>>.NativeClassPtr, 100663796);
				ListUtil._SelectWhere_d__16<TSource, TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._SelectWhere_d__16<TSource, TResult>>.NativeClassPtr, 100663797);
				ListUtil._SelectWhere_d__16<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._SelectWhere_d__16<TSource, TResult>>.NativeClassPtr, 100663798);
				ListUtil._SelectWhere_d__16<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._SelectWhere_d__16<TSource, TResult>>.NativeClassPtr, 100663799);
				ListUtil._SelectWhere_d__16<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._SelectWhere_d__16<TSource, TResult>>.NativeClassPtr, 100663800);
				ListUtil._SelectWhere_d__16<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._SelectWhere_d__16<TSource, TResult>>.NativeClassPtr, 100663801);
				ListUtil._SelectWhere_d__16<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._SelectWhere_d__16<TSource, TResult>>.NativeClassPtr, 100663802);
			}

			// Token: 0x060004CD RID: 1229 RVA: 0x00016ACC File Offset: 0x00014CCC
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SelectWhere_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil._SelectWhere_d__16<TSource, TResult>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060004CE RID: 1230 RVA: 0x00016B14 File Offset: 0x00014D14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182536, XrefRangeEnd = 1182541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004CF RID: 1231 RVA: 0x00016B48 File Offset: 0x00014D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182541, XrefRangeEnd = 1182556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060004D0 RID: 1232 RVA: 0x00016B84 File Offset: 0x00014D84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182556, XrefRangeEnd = 1182559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00016BB8 File Offset: 0x00014DB8
			public unsafe TResult System.Collections.Generic.IEnumerator<TResult>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
				}
			}

			// Token: 0x060004D2 RID: 1234 RVA: 0x00016BF4 File Offset: 0x00014DF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00016C28 File Offset: 0x00014E28
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182559, XrefRangeEnd = 1182560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060004D4 RID: 1236 RVA: 0x00016C68 File Offset: 0x00014E68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TResult> System_Collections_Generic_IEnumerable_TResult__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TResult>>(intPtr3) : null;
			}

			// Token: 0x060004D5 RID: 1237 RVA: 0x00016CA8 File Offset: 0x00014EA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182560, XrefRangeEnd = 1182568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060004D6 RID: 1238 RVA: 0x00003E34 File Offset: 0x00002034
			public _SelectWhere_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00016CE8 File Offset: 0x00014EE8
			// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00003E3D File Offset: 0x0000203D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00016D10 File Offset: 0x00014F10
			// (set) Token: 0x060004DA RID: 1242 RVA: 0x00016D38 File Offset: 0x00014F38
			public unsafe TResult __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TResult);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x060004DB RID: 1243 RVA: 0x00016DE0 File Offset: 0x00014FE0
			// (set) Token: 0x060004DC RID: 1244 RVA: 0x00003E58 File Offset: 0x00002058
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x060004DD RID: 1245 RVA: 0x00016E08 File Offset: 0x00015008
			// (set) Token: 0x060004DE RID: 1246 RVA: 0x00003E73 File Offset: 0x00002073
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x060004DF RID: 1247 RVA: 0x00016E38 File Offset: 0x00015038
			// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00003E92 File Offset: 0x00002092
			public unsafe IEnumerable<TSource> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00016E68 File Offset: 0x00015068
			// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00003EB1 File Offset: 0x000020B1
			public unsafe Func<TSource, ValueTuple<bool, TResult>> selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr_selector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, ValueTuple<bool, TResult>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00016E98 File Offset: 0x00015098
			// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00003ED0 File Offset: 0x000020D0
			public unsafe Func<TSource, ValueTuple<bool, TResult>> __3__selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr___3__selector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, ValueTuple<bool, TResult>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr___3__selector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00016EC8 File Offset: 0x000150C8
			// (set) Token: 0x060004E6 RID: 1254 RVA: 0x00003EEF File Offset: 0x000020EF
			public unsafe IEnumerator<TSource> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._SelectWhere_d__16<TSource, TResult>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000318 RID: 792
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000319 RID: 793
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400031A RID: 794
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400031B RID: 795
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x0400031C RID: 796
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x0400031D RID: 797
			private static readonly IntPtr NativeFieldInfoPtr_selector;

			// Token: 0x0400031E RID: 798
			private static readonly IntPtr NativeFieldInfoPtr___3__selector;

			// Token: 0x0400031F RID: 799
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000320 RID: 800
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000321 RID: 801
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000322 RID: 802
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000323 RID: 803
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000324 RID: 804
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0;

			// Token: 0x04000325 RID: 805
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000326 RID: 806
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000327 RID: 807
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0;

			// Token: 0x04000328 RID: 808
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000076 RID: 118
		[ObfuscatedName("Utils.ListUtil+<TakeWhere>d__17`1")]
		public sealed class _TakeWhere_d__17<T> : Object
		{
			// Token: 0x060004E7 RID: 1255 RVA: 0x00016EF8 File Offset: 0x000150F8
			// Note: this type is marked as 'beforefieldinit'.
			static _TakeWhere_d__17()
			{
				Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<TakeWhere>d__17`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr);
				ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr, "<>1__state");
				ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr, "<>2__current");
				ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr, "<>l__initialThreadId");
				ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr, "source");
				ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr, "<>3__source");
				ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr_condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr, "condition");
				ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr___3__condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr, "<>3__condition");
				ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr, "count");
				ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr___3__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr, "<>3__count");
				ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr, "<>7__wrap1");
				ListUtil._TakeWhere_d__17<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr, 100663803);
				ListUtil._TakeWhere_d__17<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr, 100663804);
				ListUtil._TakeWhere_d__17<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr, 100663805);
				ListUtil._TakeWhere_d__17<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr, 100663806);
				ListUtil._TakeWhere_d__17<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr, 100663807);
				ListUtil._TakeWhere_d__17<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr, 100663808);
				ListUtil._TakeWhere_d__17<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr, 100663809);
				ListUtil._TakeWhere_d__17<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr, 100663810);
				ListUtil._TakeWhere_d__17<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr, 100663811);
			}

			// Token: 0x060004E8 RID: 1256 RVA: 0x000170DC File Offset: 0x000152DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TakeWhere_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil._TakeWhere_d__17<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._TakeWhere_d__17<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060004E9 RID: 1257 RVA: 0x00017124 File Offset: 0x00015324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._TakeWhere_d__17<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004EA RID: 1258 RVA: 0x00017158 File Offset: 0x00015358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182568, XrefRangeEnd = 1182611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._TakeWhere_d__17<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060004EB RID: 1259 RVA: 0x00017194 File Offset: 0x00015394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182611, XrefRangeEnd = 1182619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._TakeWhere_d__17<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000141 RID: 321
			// (get) Token: 0x060004EC RID: 1260 RVA: 0x000171C8 File Offset: 0x000153C8
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._TakeWhere_d__17<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x060004ED RID: 1261 RVA: 0x00017204 File Offset: 0x00015404
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._TakeWhere_d__17<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x060004EE RID: 1262 RVA: 0x00017238 File Offset: 0x00015438
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._TakeWhere_d__17<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060004EF RID: 1263 RVA: 0x00017278 File Offset: 0x00015478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182619, XrefRangeEnd = 1182640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._TakeWhere_d__17<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x060004F0 RID: 1264 RVA: 0x000172B8 File Offset: 0x000154B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._TakeWhere_d__17<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060004F1 RID: 1265 RVA: 0x00003F0E File Offset: 0x0000210E
			public _TakeWhere_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x060004F2 RID: 1266 RVA: 0x000172F8 File Offset: 0x000154F8
			// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00003F17 File Offset: 0x00002117
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00017320 File Offset: 0x00015520
			// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00017348 File Offset: 0x00015548
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x060004F6 RID: 1270 RVA: 0x000173F0 File Offset: 0x000155F0
			// (set) Token: 0x060004F7 RID: 1271 RVA: 0x00003F32 File Offset: 0x00002132
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00017418 File Offset: 0x00015618
			// (set) Token: 0x060004F9 RID: 1273 RVA: 0x00003F4D File Offset: 0x0000214D
			public unsafe IEnumerable<T> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x060004FA RID: 1274 RVA: 0x00017448 File Offset: 0x00015648
			// (set) Token: 0x060004FB RID: 1275 RVA: 0x00003F6C File Offset: 0x0000216C
			public unsafe IEnumerable<T> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x060004FC RID: 1276 RVA: 0x00017478 File Offset: 0x00015678
			// (set) Token: 0x060004FD RID: 1277 RVA: 0x00003F8B File Offset: 0x0000218B
			public unsafe Func<T, bool> condition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr_condition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr_condition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x060004FE RID: 1278 RVA: 0x000174A8 File Offset: 0x000156A8
			// (set) Token: 0x060004FF RID: 1279 RVA: 0x00003FAA File Offset: 0x000021AA
			public unsafe Func<T, bool> __3__condition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr___3__condition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr___3__condition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x06000500 RID: 1280 RVA: 0x000174D8 File Offset: 0x000156D8
			// (set) Token: 0x06000501 RID: 1281 RVA: 0x00003FC9 File Offset: 0x000021C9
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x06000502 RID: 1282 RVA: 0x00017500 File Offset: 0x00015700
			// (set) Token: 0x06000503 RID: 1283 RVA: 0x00003FE4 File Offset: 0x000021E4
			public unsafe int __3__count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr___3__count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr___3__count)) = value;
				}
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x06000504 RID: 1284 RVA: 0x00017528 File Offset: 0x00015728
			// (set) Token: 0x06000505 RID: 1285 RVA: 0x00003FFF File Offset: 0x000021FF
			public unsafe IEnumerator<T> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._TakeWhere_d__17<T>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000329 RID: 809
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400032A RID: 810
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400032B RID: 811
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400032C RID: 812
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x0400032D RID: 813
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x0400032E RID: 814
			private static readonly IntPtr NativeFieldInfoPtr_condition;

			// Token: 0x0400032F RID: 815
			private static readonly IntPtr NativeFieldInfoPtr___3__condition;

			// Token: 0x04000330 RID: 816
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04000331 RID: 817
			private static readonly IntPtr NativeFieldInfoPtr___3__count;

			// Token: 0x04000332 RID: 818
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000333 RID: 819
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000334 RID: 820
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000335 RID: 821
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000336 RID: 822
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000337 RID: 823
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x04000338 RID: 824
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000339 RID: 825
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400033A RID: 826
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x0400033B RID: 827
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000077 RID: 119
		[ObfuscatedName("Utils.ListUtil+<Windows>d__42`1")]
		public sealed class _Windows_d__42<T> : Object
		{
			// Token: 0x06000506 RID: 1286 RVA: 0x00017558 File Offset: 0x00015758
			// Note: this type is marked as 'beforefieldinit'.
			static _Windows_d__42()
			{
				Il2CppClassPointerStore<ListUtil._Windows_d__42<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListUtil>.NativeClassPtr, "<Windows>d__42`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListUtil._Windows_d__42<T>>.NativeClassPtr);
				ListUtil._Windows_d__42<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Windows_d__42<T>>.NativeClassPtr, "<>1__state");
				ListUtil._Windows_d__42<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Windows_d__42<T>>.NativeClassPtr, "<>2__current");
				ListUtil._Windows_d__42<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Windows_d__42<T>>.NativeClassPtr, "<>l__initialThreadId");
				ListUtil._Windows_d__42<T>.NativeFieldInfoPtr_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Windows_d__42<T>>.NativeClassPtr, "sequence");
				ListUtil._Windows_d__42<T>.NativeFieldInfoPtr___3__sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Windows_d__42<T>>.NativeClassPtr, "<>3__sequence");
				ListUtil._Windows_d__42<T>.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Windows_d__42<T>>.NativeClassPtr, "length");
				ListUtil._Windows_d__42<T>.NativeFieldInfoPtr___3__length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Windows_d__42<T>>.NativeClassPtr, "<>3__length");
				ListUtil._Windows_d__42<T>.NativeFieldInfoPtr__arr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Windows_d__42<T>>.NativeClassPtr, "<arr>5__2");
				ListUtil._Windows_d__42<T>.NativeFieldInfoPtr__maxWindowIndex_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Windows_d__42<T>>.NativeClassPtr, "<maxWindowIndex>5__3");
				ListUtil._Windows_d__42<T>.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListUtil._Windows_d__42<T>>.NativeClassPtr, "<i>5__4");
				ListUtil._Windows_d__42<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Windows_d__42<T>>.NativeClassPtr, 100663812);
				ListUtil._Windows_d__42<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Windows_d__42<T>>.NativeClassPtr, 100663813);
				ListUtil._Windows_d__42<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Windows_d__42<T>>.NativeClassPtr, 100663814);
				ListUtil._Windows_d__42<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_ArraySegment_T___get_Current_Private_Virtual_Final_New_get_ArraySegment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Windows_d__42<T>>.NativeClassPtr, 100663815);
				ListUtil._Windows_d__42<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Windows_d__42<T>>.NativeClassPtr, 100663816);
				ListUtil._Windows_d__42<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Windows_d__42<T>>.NativeClassPtr, 100663817);
				ListUtil._Windows_d__42<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_ArraySegment_T___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ArraySegment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Windows_d__42<T>>.NativeClassPtr, 100663818);
				ListUtil._Windows_d__42<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListUtil._Windows_d__42<T>>.NativeClassPtr, 100663819);
			}

			// Token: 0x06000507 RID: 1287 RVA: 0x00017728 File Offset: 0x00015928
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Windows_d__42(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListUtil._Windows_d__42<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Windows_d__42<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000508 RID: 1288 RVA: 0x00017770 File Offset: 0x00015970
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Windows_d__42<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000509 RID: 1289 RVA: 0x000177A4 File Offset: 0x000159A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182640, XrefRangeEnd = 1182645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Windows_d__42<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700014D RID: 333
			// (get) Token: 0x0600050A RID: 1290 RVA: 0x000177E0 File Offset: 0x000159E0
			public unsafe ArraySegment<T> System.Collections.Generic.IEnumerator<System.ArraySegment<T>>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Windows_d__42<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_ArraySegment_T___get_Current_Private_Virtual_Final_New_get_ArraySegment_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ArraySegment<T>(intPtr);
				}
			}

			// Token: 0x0600050B RID: 1291 RVA: 0x00017818 File Offset: 0x00015A18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Windows_d__42<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700014E RID: 334
			// (get) Token: 0x0600050C RID: 1292 RVA: 0x0001784C File Offset: 0x00015A4C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182645, XrefRangeEnd = 1182646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Windows_d__42<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600050D RID: 1293 RVA: 0x0001788C File Offset: 0x00015A8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ArraySegment<T>> System_Collections_Generic_IEnumerable_System_ArraySegment_T___GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Windows_d__42<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_ArraySegment_T___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ArraySegment_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ArraySegment<T>>>(intPtr3) : null;
			}

			// Token: 0x0600050E RID: 1294 RVA: 0x000178CC File Offset: 0x00015ACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182646, XrefRangeEnd = 1182653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListUtil._Windows_d__42<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600050F RID: 1295 RVA: 0x0000401E File Offset: 0x0000221E
			public _Windows_d__42(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000143 RID: 323
			// (get) Token: 0x06000510 RID: 1296 RVA: 0x0001790C File Offset: 0x00015B0C
			// (set) Token: 0x06000511 RID: 1297 RVA: 0x00004027 File Offset: 0x00002227
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Windows_d__42<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Windows_d__42<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x06000512 RID: 1298 RVA: 0x00017934 File Offset: 0x00015B34
			// (set) Token: 0x06000513 RID: 1299 RVA: 0x00004042 File Offset: 0x00002242
			public ArraySegment<T> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Windows_d__42<T>.NativeFieldInfoPtr___2__current);
					return new ArraySegment<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Windows_d__42<T>.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x06000514 RID: 1300 RVA: 0x00017964 File Offset: 0x00015B64
			// (set) Token: 0x06000515 RID: 1301 RVA: 0x00004070 File Offset: 0x00002270
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Windows_d__42<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Windows_d__42<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x06000516 RID: 1302 RVA: 0x0001798C File Offset: 0x00015B8C
			// (set) Token: 0x06000517 RID: 1303 RVA: 0x0000408B File Offset: 0x0000228B
			public unsafe IEnumerable<T> sequence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Windows_d__42<T>.NativeFieldInfoPtr_sequence);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Windows_d__42<T>.NativeFieldInfoPtr_sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x06000518 RID: 1304 RVA: 0x000179BC File Offset: 0x00015BBC
			// (set) Token: 0x06000519 RID: 1305 RVA: 0x000040AA File Offset: 0x000022AA
			public unsafe IEnumerable<T> __3__sequence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Windows_d__42<T>.NativeFieldInfoPtr___3__sequence);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Windows_d__42<T>.NativeFieldInfoPtr___3__sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x0600051A RID: 1306 RVA: 0x000179EC File Offset: 0x00015BEC
			// (set) Token: 0x0600051B RID: 1307 RVA: 0x000040C9 File Offset: 0x000022C9
			public unsafe int length
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Windows_d__42<T>.NativeFieldInfoPtr_length);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Windows_d__42<T>.NativeFieldInfoPtr_length)) = value;
				}
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x0600051C RID: 1308 RVA: 0x00017A14 File Offset: 0x00015C14
			// (set) Token: 0x0600051D RID: 1309 RVA: 0x000040E4 File Offset: 0x000022E4
			public unsafe int __3__length
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Windows_d__42<T>.NativeFieldInfoPtr___3__length);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Windows_d__42<T>.NativeFieldInfoPtr___3__length)) = value;
				}
			}

			// Token: 0x1700014A RID: 330
			// (get) Token: 0x0600051E RID: 1310 RVA: 0x00017A3C File Offset: 0x00015C3C
			// (set) Token: 0x0600051F RID: 1311 RVA: 0x000040FF File Offset: 0x000022FF
			public unsafe Il2CppArrayBase<T> _arr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Windows_d__42<T>.NativeFieldInfoPtr__arr_5__2);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Windows_d__42<T>.NativeFieldInfoPtr__arr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700014B RID: 331
			// (get) Token: 0x06000520 RID: 1312 RVA: 0x00017A64 File Offset: 0x00015C64
			// (set) Token: 0x06000521 RID: 1313 RVA: 0x0000411E File Offset: 0x0000231E
			public unsafe int _maxWindowIndex_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Windows_d__42<T>.NativeFieldInfoPtr__maxWindowIndex_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Windows_d__42<T>.NativeFieldInfoPtr__maxWindowIndex_5__3)) = value;
				}
			}

			// Token: 0x1700014C RID: 332
			// (get) Token: 0x06000522 RID: 1314 RVA: 0x00017A8C File Offset: 0x00015C8C
			// (set) Token: 0x06000523 RID: 1315 RVA: 0x00004139 File Offset: 0x00002339
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Windows_d__42<T>.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListUtil._Windows_d__42<T>.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x0400033C RID: 828
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400033D RID: 829
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400033E RID: 830
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400033F RID: 831
			private static readonly IntPtr NativeFieldInfoPtr_sequence;

			// Token: 0x04000340 RID: 832
			private static readonly IntPtr NativeFieldInfoPtr___3__sequence;

			// Token: 0x04000341 RID: 833
			private static readonly IntPtr NativeFieldInfoPtr_length;

			// Token: 0x04000342 RID: 834
			private static readonly IntPtr NativeFieldInfoPtr___3__length;

			// Token: 0x04000343 RID: 835
			private static readonly IntPtr NativeFieldInfoPtr__arr_5__2;

			// Token: 0x04000344 RID: 836
			private static readonly IntPtr NativeFieldInfoPtr__maxWindowIndex_5__3;

			// Token: 0x04000345 RID: 837
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x04000346 RID: 838
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000347 RID: 839
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000348 RID: 840
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000349 RID: 841
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_ArraySegment_T___get_Current_Private_Virtual_Final_New_get_ArraySegment_1_T_0;

			// Token: 0x0400034A RID: 842
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400034B RID: 843
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400034C RID: 844
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_ArraySegment_T___GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_ArraySegment_1_T_0;

			// Token: 0x0400034D RID: 845
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000078 RID: 120
		private sealed class MethodInfoStoreGeneric_Shuffle_Public_Static_Void_IList_1_T_Int32_Random_0<T>
		{
			// Token: 0x0400034E RID: 846
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_Shuffle_Public_Static_Void_IList_1_T_Int32_Random_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000079 RID: 121
		private sealed class MethodInfoStoreGeneric_NonAllocatingUnionWith_Public_Static_Void_ICollection_1_T_IReadOnlyList_1_T_0<T>
		{
			// Token: 0x0400034F RID: 847
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_NonAllocatingUnionWith_Public_Static_Void_ICollection_1_T_IReadOnlyList_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200007A RID: 122
		private sealed class MethodInfoStoreGeneric_NonAllocatingUnionWith_Public_Static_Void_ICollection_1_T_HashSet_1_T_0<T>
		{
			// Token: 0x04000350 RID: 848
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_NonAllocatingUnionWith_Public_Static_Void_ICollection_1_T_HashSet_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200007B RID: 123
		private sealed class MethodInfoStoreGeneric_NonAllocatingUnionWith_Public_Static_Void_ICollection_1_T_VersionedSet_1_T_0<T>
		{
			// Token: 0x04000351 RID: 849
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_NonAllocatingUnionWith_Public_Static_Void_ICollection_1_T_VersionedSet_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200007C RID: 124
		private sealed class MethodInfoStoreGeneric_NonAllocatingExceptWith_Public_Static_Void_ICollection_1_T_IReadOnlyList_1_T_0<T>
		{
			// Token: 0x04000352 RID: 850
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_NonAllocatingExceptWith_Public_Static_Void_ICollection_1_T_IReadOnlyList_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200007D RID: 125
		private sealed class MethodInfoStoreGeneric_NonAllocatingExceptWith_Public_Static_Void_ICollection_1_T_HashSet_1_T_0<T>
		{
			// Token: 0x04000353 RID: 851
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_NonAllocatingExceptWith_Public_Static_Void_ICollection_1_T_HashSet_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200007E RID: 126
		private sealed class MethodInfoStoreGeneric_NonAllocatingExceptWith_Public_Static_Void_ICollection_1_T_VersionedSet_1_T_0<T>
		{
			// Token: 0x04000354 RID: 852
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_NonAllocatingExceptWith_Public_Static_Void_ICollection_1_T_VersionedSet_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200007F RID: 127
		private sealed class MethodInfoStoreGeneric_Without_Public_Static_IEnumerable_1_T_ICollection_1_T_IEnumerable_1_T_0<T>
		{
			// Token: 0x04000355 RID: 853
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_Without_Public_Static_IEnumerable_1_T_ICollection_1_T_IEnumerable_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000080 RID: 128
		private sealed class MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_IReadOnlyList_1_T_T_0<T>
		{
			// Token: 0x04000356 RID: 854
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_IReadOnlyList_1_T_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000081 RID: 129
		private sealed class MethodInfoStoreGeneric_Only_Public_Static_IEnumerable_1_T_T_0<T>
		{
			// Token: 0x04000357 RID: 855
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_Only_Public_Static_IEnumerable_1_T_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000082 RID: 130
		private sealed class MethodInfoStoreGeneric_Only_Public_Static_IEnumerable_1_T_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04000358 RID: 856
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_Only_Public_Static_IEnumerable_1_T_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000083 RID: 131
		private sealed class MethodInfoStoreGeneric_As_Public_Static_Boolean_Object_Action_1_T_0<T>
		{
			// Token: 0x04000359 RID: 857
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_As_Public_Static_Boolean_Object_Action_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000084 RID: 132
		private sealed class MethodInfoStoreGeneric_AsOption_Public_Static_IEnumerable_1_T_Object_0<T>
		{
			// Token: 0x0400035A RID: 858
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_AsOption_Public_Static_IEnumerable_1_T_Object_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000085 RID: 133
		private sealed class MethodInfoStoreGeneric_PostOrderTraversal_Public_Static_IEnumerable_1_TValue_TValue_Func_2_TValue_IEnumerable_1_TValue_0<TValue>
		{
			// Token: 0x0400035B RID: 859
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_PostOrderTraversal_Public_Static_IEnumerable_1_TValue_TValue_Func_2_TValue_IEnumerable_1_TValue_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
		}

		// Token: 0x02000086 RID: 134
		private sealed class MethodInfoStoreGeneric_SelectWhere_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0<TSource, TResult>
		{
			// Token: 0x0400035C RID: 860
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_SelectWhere_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000087 RID: 135
		private sealed class MethodInfoStoreGeneric_SelectWhere_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_ValueTuple_2_Boolean_TResult_0<TSource, TResult>
		{
			// Token: 0x0400035D RID: 861
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_SelectWhere_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_ValueTuple_2_Boolean_TResult_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000088 RID: 136
		private sealed class MethodInfoStoreGeneric_TakeWhere_Public_Static_IEnumerable_1_T_IEnumerable_1_T_Func_2_T_Boolean_Int32_0<T>
		{
			// Token: 0x0400035E RID: 862
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_TakeWhere_Public_Static_IEnumerable_1_T_IEnumerable_1_T_Func_2_T_Boolean_Int32_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000089 RID: 137
		private sealed class MethodInfoStoreGeneric_FirstIndexOf_Public_Static_Int32_IEnumerable_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x0400035F RID: 863
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_FirstIndexOf_Public_Static_Int32_IEnumerable_1_T_Predicate_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200008A RID: 138
		private sealed class MethodInfoStoreGeneric_LastIndexOf_Public_Static_Int32_IReadOnlyList_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x04000360 RID: 864
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_LastIndexOf_Public_Static_Int32_IReadOnlyList_1_T_Predicate_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200008B RID: 139
		private sealed class MethodInfoStoreGeneric_Combinations_Public_Static_IEnumerable_1_Il2CppArrayBase_1_T_IReadOnlyList_1_T_0<T>
		{
			// Token: 0x04000361 RID: 865
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_Combinations_Public_Static_IEnumerable_1_Il2CppArrayBase_1_T_IReadOnlyList_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200008C RID: 140
		private sealed class MethodInfoStoreGeneric_Combinations_Public_Static_IEnumerable_1_Il2CppArrayBase_1_T_IReadOnlyList_1_T_Int32_0<T>
		{
			// Token: 0x04000362 RID: 866
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_Combinations_Public_Static_IEnumerable_1_Il2CppArrayBase_1_T_IReadOnlyList_1_T_Int32_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200008D RID: 141
		private sealed class MethodInfoStoreGeneric_CombinationsInRange_Public_Static_IEnumerable_1_Il2CppArrayBase_1_T_IReadOnlyList_1_T_Int32_Int32_0<T>
		{
			// Token: 0x04000363 RID: 867
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_CombinationsInRange_Public_Static_IEnumerable_1_Il2CppArrayBase_1_T_IReadOnlyList_1_T_Int32_Int32_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200008E RID: 142
		private sealed class MethodInfoStoreGeneric_CombinationsWithRepetition_Public_Static_IEnumerable_1_IEnumerable_1_T_IReadOnlyList_1_T_Int32_0<T>
		{
			// Token: 0x04000364 RID: 868
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_CombinationsWithRepetition_Public_Static_IEnumerable_1_IEnumerable_1_T_IReadOnlyList_1_T_Int32_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200008F RID: 143
		private sealed class MethodInfoStoreGeneric_Permutations_Public_Static_IEnumerable_1_Il2CppArrayBase_1_T_IEnumerable_1_T_0<T>
		{
			// Token: 0x04000365 RID: 869
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_Permutations_Public_Static_IEnumerable_1_Il2CppArrayBase_1_T_IEnumerable_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000090 RID: 144
		private sealed class MethodInfoStoreGeneric_CartesianProduct_Public_Static_IEnumerable_1_IEnumerable_1_T_IEnumerable_1_IEnumerable_1_T_0<T>
		{
			// Token: 0x04000366 RID: 870
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_CartesianProduct_Public_Static_IEnumerable_1_IEnumerable_1_T_IEnumerable_1_IEnumerable_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000091 RID: 145
		private sealed class MethodInfoStoreGeneric_MinOrElse_Public_Static_T_IEnumerable_1_T_Func_1_T_0<T>
		{
			// Token: 0x04000367 RID: 871
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_MinOrElse_Public_Static_T_IEnumerable_1_T_Func_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000092 RID: 146
		private sealed class MethodInfoStoreGeneric_MaxOrElse_Public_Static_T_IEnumerable_1_T_Func_1_T_0<T>
		{
			// Token: 0x04000368 RID: 872
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_MaxOrElse_Public_Static_T_IEnumerable_1_T_Func_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000093 RID: 147
		private sealed class MethodInfoStoreGeneric_MinBy_Public_Static_T_IEnumerable_1_T_IComparer_1_T_0<T>
		{
			// Token: 0x04000369 RID: 873
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_MinBy_Public_Static_T_IEnumerable_1_T_IComparer_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000094 RID: 148
		private sealed class MethodInfoStoreGeneric_MinBy_Public_Static_T_IEnumerable_1_T_Func_2_T_Double_0<T>
		{
			// Token: 0x0400036A RID: 874
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_MinBy_Public_Static_T_IEnumerable_1_T_Func_2_T_Double_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000095 RID: 149
		private sealed class MethodInfoStoreGeneric_MaxBy_Public_Static_T_IEnumerable_1_T_IComparer_1_T_0<T>
		{
			// Token: 0x0400036B RID: 875
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_MaxBy_Public_Static_T_IEnumerable_1_T_IComparer_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000096 RID: 150
		private sealed class MethodInfoStoreGeneric_MaxBy_Public_Static_T_IEnumerable_1_T_Func_2_T_Double_0<T>
		{
			// Token: 0x0400036C RID: 876
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_MaxBy_Public_Static_T_IEnumerable_1_T_Func_2_T_Double_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000097 RID: 151
		private sealed class MethodInfoStoreGeneric_MinByOrElse_Public_Static_T_IEnumerable_1_T_IComparer_1_T_T_0<T>
		{
			// Token: 0x0400036D RID: 877
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_MinByOrElse_Public_Static_T_IEnumerable_1_T_IComparer_1_T_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000098 RID: 152
		private sealed class MethodInfoStoreGeneric_MaxByOrElse_Public_Static_T_IEnumerable_1_T_IComparer_1_T_T_0<T>
		{
			// Token: 0x0400036E RID: 878
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_MaxByOrElse_Public_Static_T_IEnumerable_1_T_IComparer_1_T_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000099 RID: 153
		private sealed class MethodInfoStoreGeneric_MaxByOrElse_Public_Static_T_IEnumerable_1_T_Func_2_T_Double_T_0<T>
		{
			// Token: 0x0400036F RID: 879
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_MaxByOrElse_Public_Static_T_IEnumerable_1_T_Func_2_T_Double_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200009A RID: 154
		private sealed class MethodInfoStoreGeneric_MinByOrElse_Public_Static_T_IEnumerable_1_T_Func_2_T_Double_T_0<T>
		{
			// Token: 0x04000370 RID: 880
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_MinByOrElse_Public_Static_T_IEnumerable_1_T_Func_2_T_Double_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200009B RID: 155
		private sealed class MethodInfoStoreGeneric_AllMinBy_Public_Static_List_1_T_IEnumerable_1_T_IComparer_1_T_0<T>
		{
			// Token: 0x04000371 RID: 881
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_AllMinBy_Public_Static_List_1_T_IEnumerable_1_T_IComparer_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200009C RID: 156
		private sealed class MethodInfoStoreGeneric_AllMaxBy_Public_Static_List_1_T_IEnumerable_1_T_IComparer_1_T_0<T>
		{
			// Token: 0x04000372 RID: 882
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_AllMaxBy_Public_Static_List_1_T_IEnumerable_1_T_IComparer_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200009D RID: 157
		private sealed class MethodInfoStoreGeneric_DistinctBy_Public_Static_IEnumerable_1_T_IEnumerable_1_T_Func_2_T_U_0<T, U>
		{
			// Token: 0x04000373 RID: 883
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_DistinctBy_Public_Static_IEnumerable_1_T_IEnumerable_1_T_Func_2_T_U_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200009E RID: 158
		private sealed class MethodInfoStoreGeneric_Interleave_Public_Static_IEnumerable_1_T_IEnumerable_1_T_IEnumerable_1_T_0<T>
		{
			// Token: 0x04000374 RID: 884
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_Interleave_Public_Static_IEnumerable_1_T_IEnumerable_1_T_IEnumerable_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200009F RID: 159
		private sealed class MethodInfoStoreGeneric_Windows_Public_Static_IEnumerable_1_ArraySegment_1_T_IEnumerable_1_T_Int32_0<T>
		{
			// Token: 0x04000375 RID: 885
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_Windows_Public_Static_IEnumerable_1_ArraySegment_1_T_IEnumerable_1_T_Int32_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000A0 RID: 160
		private sealed class MethodInfoStoreGeneric_RefGaps_Public_Static_IEnumerable_1_ValueTuple_3_Int32_T_T_IEnumerable_1_T_0<T>
		{
			// Token: 0x04000376 RID: 886
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_RefGaps_Public_Static_IEnumerable_1_ValueTuple_3_Int32_T_T_IEnumerable_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000A1 RID: 161
		private sealed class MethodInfoStoreGeneric_Gaps_Public_Static_IEnumerable_1_ValueTuple_3_Int32_Nullable_1_T_Nullable_1_T_IEnumerable_1_T_0<T>
		{
			// Token: 0x04000377 RID: 887
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_Gaps_Public_Static_IEnumerable_1_ValueTuple_3_Int32_Nullable_1_T_Nullable_1_T_IEnumerable_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000A2 RID: 162
		private sealed class MethodInfoStoreGeneric_Batches_Public_Static_IEnumerable_1_IEnumerable_1_T_IEnumerable_1_T_Int32_0<T>
		{
			// Token: 0x04000378 RID: 888
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_Batches_Public_Static_IEnumerable_1_IEnumerable_1_T_IEnumerable_1_T_Int32_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000A3 RID: 163
		private sealed class MethodInfoStoreGeneric_Repeated_Public_Static_IEnumerable_1_T_IEnumerable_1_T_0<T>
		{
			// Token: 0x04000379 RID: 889
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_Repeated_Public_Static_IEnumerable_1_T_IEnumerable_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000A4 RID: 164
		private sealed class MethodInfoStoreGeneric_Partition_Public_Static_ValueTuple_2_List_1_T_List_1_T_IEnumerable_1_T_Func_2_T_Boolean_0<T>
		{
			// Token: 0x0400037A RID: 890
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_Partition_Public_Static_ValueTuple_2_List_1_T_List_1_T_IEnumerable_1_T_Func_2_T_Boolean_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000A5 RID: 165
		private sealed class MethodInfoStoreGeneric_Shift_Public_Static_IEnumerable_1_T_IReadOnlyList_1_T_Int32_0<T>
		{
			// Token: 0x0400037B RID: 891
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_Shift_Public_Static_IEnumerable_1_T_IReadOnlyList_1_T_Int32_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000A6 RID: 166
		private sealed class MethodInfoStoreGeneric_HeadTail_Public_Static_Either_2_ValueTuple_2_T_IEnumerable_1_T_ValueTuple_IEnumerable_1_T_0<T>
		{
			// Token: 0x0400037C RID: 892
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_HeadTail_Public_Static_Either_2_ValueTuple_2_T_IEnumerable_1_T_ValueTuple_IEnumerable_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000A7 RID: 167
		private sealed class MethodInfoStoreGeneric_HeadTailUnsafe_Public_Static_ValueTuple_2_T_IEnumerable_1_T_IEnumerable_1_T_0<T>
		{
			// Token: 0x0400037D RID: 893
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_HeadTailUnsafe_Public_Static_ValueTuple_2_T_IEnumerable_1_T_IEnumerable_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000A8 RID: 168
		private sealed class MethodInfoStoreGeneric_EnumerateRest_Private_Static_IEnumerable_1_T_IEnumerator_1_T_0<T>
		{
			// Token: 0x0400037E RID: 894
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_EnumerateRest_Private_Static_IEnumerable_1_T_IEnumerator_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000A9 RID: 169
		private sealed class MethodInfoStoreGeneric_Pivot_Public_Static_IEnumerable_1_IEnumerable_1_T_IEnumerable_1_IEnumerable_1_T_0<T>
		{
			// Token: 0x0400037F RID: 895
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_Pivot_Public_Static_IEnumerable_1_IEnumerable_1_T_IEnumerable_1_IEnumerable_1_T_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000AA RID: 170
		private sealed class MethodInfoStoreGeneric_Sum_Public_Static_UInt64_IEnumerable_1_T_Func_2_T_UInt64_0<T>
		{
			// Token: 0x04000380 RID: 896
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_Sum_Public_Static_UInt64_IEnumerable_1_T_Func_2_T_UInt64_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000AB RID: 171
		private sealed class MethodInfoStoreGeneric_SumVersions_Public_Static_UInt64_Dictionary_2_TK_TV_0<TK, TV>
		{
			// Token: 0x04000381 RID: 897
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_SumVersions_Public_Static_UInt64_Dictionary_2_TK_TV_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TK>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TV>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000AC RID: 172
		private sealed class MethodInfoStoreGeneric_RemoveAll_Public_Static_Void_Dictionary_2_TK_TV_Predicate_1_TV_0<TK, TV>
		{
			// Token: 0x04000382 RID: 898
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_RemoveAll_Public_Static_Void_Dictionary_2_TK_TV_Predicate_1_TV_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TK>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TV>.NativeClassPtr))
			}))));
		}

		// Token: 0x020000AD RID: 173
		private sealed class MethodInfoStoreGeneric_Method_Internal_Static_Int32_Int32_Int32_0<T>
		{
			// Token: 0x04000383 RID: 899
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListUtil.NativeMethodInfoPtr_Method_Internal_Static_Int32_Int32_Int32_0, Il2CppClassPointerStore<ListUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
