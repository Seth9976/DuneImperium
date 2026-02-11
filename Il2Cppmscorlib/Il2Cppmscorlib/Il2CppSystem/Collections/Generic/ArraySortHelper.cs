using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004FF RID: 1279
	public class ArraySortHelper<T> : Object
	{
		// Token: 0x06004ED7 RID: 20183 RVA: 0x0016E068 File Offset: 0x0016C268
		// Note: this type is marked as 'beforefieldinit'.
		static ArraySortHelper()
		{
			Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "ArraySortHelper`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr);
			ArraySortHelper<T>.NativeFieldInfoPtr_s_defaultArraySortHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, "s_defaultArraySortHelper");
			ArraySortHelper<T>.NativeMethodInfoPtr_Sort_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100675173);
			ArraySortHelper<T>.NativeMethodInfoPtr_BinarySearch_Public_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100675174);
			ArraySortHelper<T>.NativeMethodInfoPtr_Sort_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100675175);
			ArraySortHelper<T>.NativeMethodInfoPtr_InternalBinarySearch_Internal_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100675176);
			ArraySortHelper<T>.NativeMethodInfoPtr_SwapIfGreater_Private_Static_Void_Il2CppArrayBase_1_T_Comparison_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100675177);
			ArraySortHelper<T>.NativeMethodInfoPtr_Swap_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100675178);
			ArraySortHelper<T>.NativeMethodInfoPtr_IntrospectiveSort_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100675179);
			ArraySortHelper<T>.NativeMethodInfoPtr_IntroSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100675180);
			ArraySortHelper<T>.NativeMethodInfoPtr_PickPivotAndPartition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100675181);
			ArraySortHelper<T>.NativeMethodInfoPtr_Heapsort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100675182);
			ArraySortHelper<T>.NativeMethodInfoPtr_DownHeap_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100675183);
			ArraySortHelper<T>.NativeMethodInfoPtr_InsertionSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100675184);
			ArraySortHelper<T>.NativeMethodInfoPtr_get_Default_Public_Static_get_ArraySortHelper_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100675185);
			ArraySortHelper<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100675186);
		}

		// Token: 0x06004ED8 RID: 20184 RVA: 0x0016E200 File Offset: 0x0016C400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425907, RefRangeEnd = 1425908, XrefRangeStart = 1425896, XrefRangeEnd = 1425907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sort(Il2CppArrayBase<T> keys, int index, int length, IComparer<T> comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_Sort_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_IComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ED9 RID: 20185 RVA: 0x0016E274 File Offset: 0x0016C474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425912, RefRangeEnd = 1425913, XrefRangeStart = 1425908, XrefRangeEnd = 1425912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int BinarySearch(Il2CppArrayBase<T> array, int index, int length, T value, IComparer<T> comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_BinarySearch_Public_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004EDA RID: 20186 RVA: 0x0016E33C File Offset: 0x0016C53C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425920, RefRangeEnd = 1425921, XrefRangeStart = 1425913, XrefRangeEnd = 1425920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort(Il2CppArrayBase<T> keys, int index, int length, Comparison<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_Sort_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EDB RID: 20187 RVA: 0x0016E3A0 File Offset: 0x0016C5A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1425924, RefRangeEnd = 1425926, XrefRangeStart = 1425921, XrefRangeEnd = 1425924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InternalBinarySearch(Il2CppArrayBase<T> array, int index, int length, T value, IComparer<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_InternalBinarySearch_Internal_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004EDC RID: 20188 RVA: 0x0016E458 File Offset: 0x0016C658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425926, XrefRangeEnd = 1425929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SwapIfGreater(Il2CppArrayBase<T> keys, Comparison<T> comparer, int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_SwapIfGreater_Private_Static_Void_Il2CppArrayBase_1_T_Comparison_1_T_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EDD RID: 20189 RVA: 0x0016E4BC File Offset: 0x0016C6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425929, XrefRangeEnd = 1425931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Swap(Il2CppArrayBase<T> a, int i, int j)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref j;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_Swap_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EDE RID: 20190 RVA: 0x0016E510 File Offset: 0x0016C710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425931, XrefRangeEnd = 1425937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IntrospectiveSort(Il2CppArrayBase<T> keys, int left, int length, Comparison<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref left;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_IntrospectiveSort_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EDF RID: 20191 RVA: 0x0016E574 File Offset: 0x0016C774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1425971, RefRangeEnd = 1425973, XrefRangeStart = 1425937, XrefRangeEnd = 1425971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IntroSort(Il2CppArrayBase<T> keys, int lo, int hi, int depthLimit, Comparison<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLimit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_IntroSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Comparison_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EE0 RID: 20192 RVA: 0x0016E5E8 File Offset: 0x0016C7E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425998, RefRangeEnd = 1425999, XrefRangeStart = 1425973, XrefRangeEnd = 1425998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PickPivotAndPartition(Il2CppArrayBase<T> keys, int lo, int hi, Comparison<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_PickPivotAndPartition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004EE1 RID: 20193 RVA: 0x0016E658 File Offset: 0x0016C858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1426012, RefRangeEnd = 1426013, XrefRangeStart = 1425999, XrefRangeEnd = 1426012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Heapsort(Il2CppArrayBase<T> keys, int lo, int hi, Comparison<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_Heapsort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EE2 RID: 20194 RVA: 0x0016E6BC File Offset: 0x0016C8BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1426021, RefRangeEnd = 1426023, XrefRangeStart = 1426013, XrefRangeEnd = 1426021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DownHeap(Il2CppArrayBase<T> keys, int i, int n, int lo, Comparison<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_DownHeap_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Comparison_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EE3 RID: 20195 RVA: 0x0016E730 File Offset: 0x0016C930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426023, XrefRangeEnd = 1426026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InsertionSort(Il2CppArrayBase<T> keys, int lo, int hi, Comparison<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_InsertionSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x06004EE4 RID: 20196 RVA: 0x0016E794 File Offset: 0x0016C994
		public unsafe static ArraySortHelper<T> Default
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426026, XrefRangeEnd = 1426030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_get_Default_Public_Static_get_ArraySortHelper_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArraySortHelper<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06004EE5 RID: 20197 RVA: 0x0016E7C8 File Offset: 0x0016C9C8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArraySortHelper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EE6 RID: 20198 RVA: 0x0001C70B File Offset: 0x0001A90B
		public ArraySortHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x06004EE7 RID: 20199 RVA: 0x0016E804 File Offset: 0x0016CA04
		// (set) Token: 0x06004EE8 RID: 20200 RVA: 0x0001C714 File Offset: 0x0001A914
		public unsafe static ArraySortHelper<T> s_defaultArraySortHelper
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ArraySortHelper<T>.NativeFieldInfoPtr_s_defaultArraySortHelper, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArraySortHelper<T>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArraySortHelper<T>.NativeFieldInfoPtr_s_defaultArraySortHelper, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400405A RID: 16474
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultArraySortHelper;

		// Token: 0x0400405B RID: 16475
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_IComparer_1_T_0;

		// Token: 0x0400405C RID: 16476
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Public_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0;

		// Token: 0x0400405D RID: 16477
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0;

		// Token: 0x0400405E RID: 16478
		private static readonly IntPtr NativeMethodInfoPtr_InternalBinarySearch_Internal_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0;

		// Token: 0x0400405F RID: 16479
		private static readonly IntPtr NativeMethodInfoPtr_SwapIfGreater_Private_Static_Void_Il2CppArrayBase_1_T_Comparison_1_T_Int32_Int32_0;

		// Token: 0x04004060 RID: 16480
		private static readonly IntPtr NativeMethodInfoPtr_Swap_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x04004061 RID: 16481
		private static readonly IntPtr NativeMethodInfoPtr_IntrospectiveSort_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0;

		// Token: 0x04004062 RID: 16482
		private static readonly IntPtr NativeMethodInfoPtr_IntroSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Comparison_1_T_0;

		// Token: 0x04004063 RID: 16483
		private static readonly IntPtr NativeMethodInfoPtr_PickPivotAndPartition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0;

		// Token: 0x04004064 RID: 16484
		private static readonly IntPtr NativeMethodInfoPtr_Heapsort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0;

		// Token: 0x04004065 RID: 16485
		private static readonly IntPtr NativeMethodInfoPtr_DownHeap_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Comparison_1_T_0;

		// Token: 0x04004066 RID: 16486
		private static readonly IntPtr NativeMethodInfoPtr_InsertionSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0;

		// Token: 0x04004067 RID: 16487
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_ArraySortHelper_1_T_0;

		// Token: 0x04004068 RID: 16488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
