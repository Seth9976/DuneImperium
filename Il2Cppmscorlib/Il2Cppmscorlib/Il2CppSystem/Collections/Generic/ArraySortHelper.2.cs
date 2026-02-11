using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000500 RID: 1280
	public class ArraySortHelper<TKey, TValue> : Object
	{
		// Token: 0x06004EE9 RID: 20201 RVA: 0x0016E82C File Offset: 0x0016CA2C
		// Note: this type is marked as 'beforefieldinit'.
		static ArraySortHelper()
		{
			Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "ArraySortHelper`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr);
			ArraySortHelper<TKey, TValue>.NativeFieldInfoPtr_s_defaultArraySortHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, "s_defaultArraySortHelper");
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_Sort_Public_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100675188);
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_SwapIfGreaterWithItems_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_IComparer_1_TKey_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100675189);
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_Swap_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100675190);
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_IntrospectiveSort_Internal_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100675191);
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_IntroSort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100675192);
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_PickPivotAndPartition_Private_Static_Int32_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100675193);
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_Heapsort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100675194);
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_DownHeap_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100675195);
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_InsertionSort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100675196);
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_get_Default_Public_Static_get_ArraySortHelper_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100675197);
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100675198);
		}

		// Token: 0x06004EEA RID: 20202 RVA: 0x0016E99C File Offset: 0x0016CB9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1426042, RefRangeEnd = 1426043, XrefRangeStart = 1426030, XrefRangeEnd = 1426042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sort(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int index, int length, IComparer<TKey> comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_Sort_Public_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EEB RID: 20203 RVA: 0x0016EA20 File Offset: 0x0016CC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426043, XrefRangeEnd = 1426046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SwapIfGreaterWithItems(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, IComparer<TKey> comparer, int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_SwapIfGreaterWithItems_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_IComparer_1_TKey_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EEC RID: 20204 RVA: 0x0016EA98 File Offset: 0x0016CC98
		[CallerCount(0)]
		public unsafe static void Swap(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int i, int j)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref j;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_Swap_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EED RID: 20205 RVA: 0x0016EAFC File Offset: 0x0016CCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426046, XrefRangeEnd = 1426052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IntrospectiveSort(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int left, int length, IComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref left;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_IntrospectiveSort_Internal_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EEE RID: 20206 RVA: 0x0016EB74 File Offset: 0x0016CD74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1426086, RefRangeEnd = 1426089, XrefRangeStart = 1426052, XrefRangeEnd = 1426086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IntroSort(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int lo, int hi, int depthLimit, IComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLimit;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_IntroSort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_IComparer_1_TKey_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EEF RID: 20207 RVA: 0x0016EBFC File Offset: 0x0016CDFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1426114, RefRangeEnd = 1426115, XrefRangeStart = 1426089, XrefRangeEnd = 1426114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PickPivotAndPartition(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int lo, int hi, IComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_PickPivotAndPartition_Private_Static_Int32_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004EF0 RID: 20208 RVA: 0x0016EC80 File Offset: 0x0016CE80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1426126, RefRangeEnd = 1426127, XrefRangeStart = 1426115, XrefRangeEnd = 1426126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Heapsort(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int lo, int hi, IComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_Heapsort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EF1 RID: 20209 RVA: 0x0016ECF8 File Offset: 0x0016CEF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1426133, RefRangeEnd = 1426135, XrefRangeStart = 1426127, XrefRangeEnd = 1426133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DownHeap(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int i, int n, int lo, IComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_DownHeap_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_IComparer_1_TKey_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EF2 RID: 20210 RVA: 0x0016ED80 File Offset: 0x0016CF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426135, XrefRangeEnd = 1426138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InsertionSort(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int lo, int hi, IComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_InsertionSort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x06004EF3 RID: 20211 RVA: 0x0016EDF8 File Offset: 0x0016CFF8
		public unsafe static ArraySortHelper<TKey, TValue> Default
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426138, XrefRangeEnd = 1426142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_get_Default_Public_Static_get_ArraySortHelper_2_TKey_TValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArraySortHelper<TKey, TValue>>(intPtr3) : null;
			}
		}

		// Token: 0x06004EF4 RID: 20212 RVA: 0x0016EE2C File Offset: 0x0016D02C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArraySortHelper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004EF5 RID: 20213 RVA: 0x0001C726 File Offset: 0x0001A926
		public ArraySortHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x06004EF6 RID: 20214 RVA: 0x0016EE68 File Offset: 0x0016D068
		// (set) Token: 0x06004EF7 RID: 20215 RVA: 0x0001C72F File Offset: 0x0001A92F
		public unsafe static ArraySortHelper<TKey, TValue> s_defaultArraySortHelper
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ArraySortHelper<TKey, TValue>.NativeFieldInfoPtr_s_defaultArraySortHelper, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArraySortHelper<TKey, TValue>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArraySortHelper<TKey, TValue>.NativeFieldInfoPtr_s_defaultArraySortHelper, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004069 RID: 16489
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultArraySortHelper;

		// Token: 0x0400406A RID: 16490
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0;

		// Token: 0x0400406B RID: 16491
		private static readonly IntPtr NativeMethodInfoPtr_SwapIfGreaterWithItems_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_IComparer_1_TKey_Int32_Int32_0;

		// Token: 0x0400406C RID: 16492
		private static readonly IntPtr NativeMethodInfoPtr_Swap_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_0;

		// Token: 0x0400406D RID: 16493
		private static readonly IntPtr NativeMethodInfoPtr_IntrospectiveSort_Internal_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0;

		// Token: 0x0400406E RID: 16494
		private static readonly IntPtr NativeMethodInfoPtr_IntroSort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_IComparer_1_TKey_0;

		// Token: 0x0400406F RID: 16495
		private static readonly IntPtr NativeMethodInfoPtr_PickPivotAndPartition_Private_Static_Int32_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0;

		// Token: 0x04004070 RID: 16496
		private static readonly IntPtr NativeMethodInfoPtr_Heapsort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0;

		// Token: 0x04004071 RID: 16497
		private static readonly IntPtr NativeMethodInfoPtr_DownHeap_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_IComparer_1_TKey_0;

		// Token: 0x04004072 RID: 16498
		private static readonly IntPtr NativeMethodInfoPtr_InsertionSort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0;

		// Token: 0x04004073 RID: 16499
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_ArraySortHelper_2_TKey_TValue_0;

		// Token: 0x04004074 RID: 16500
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
