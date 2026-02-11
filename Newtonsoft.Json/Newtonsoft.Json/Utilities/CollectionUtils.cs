using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000045 RID: 69
	public static class CollectionUtils : Object
	{
		// Token: 0x06000694 RID: 1684 RVA: 0x00030F98 File Offset: 0x0002F198
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionUtils()
		{
			Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "CollectionUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr);
			CollectionUtils.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_ICollection_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr, 100664581);
			CollectionUtils.NativeMethodInfoPtr_AddRange_Public_Static_Void_IList_1_T_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr, 100664582);
			CollectionUtils.NativeMethodInfoPtr_IsDictionaryType_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr, 100664583);
			CollectionUtils.NativeMethodInfoPtr_ResolveEnumerableCollectionConstructor_Public_Static_ConstructorInfo_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr, 100664584);
			CollectionUtils.NativeMethodInfoPtr_ResolveEnumerableCollectionConstructor_Public_Static_ConstructorInfo_Type_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr, 100664585);
			CollectionUtils.NativeMethodInfoPtr_AddDistinct_Public_Static_Boolean_IList_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr, 100664586);
			CollectionUtils.NativeMethodInfoPtr_AddDistinct_Public_Static_Boolean_IList_1_T_T_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr, 100664587);
			CollectionUtils.NativeMethodInfoPtr_ContainsValue_Public_Static_Boolean_IEnumerable_1_TSource_TSource_IEqualityComparer_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr, 100664588);
			CollectionUtils.NativeMethodInfoPtr_AddRangeDistinct_Public_Static_Boolean_IList_1_T_IEnumerable_1_T_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr, 100664589);
			CollectionUtils.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_IEnumerable_1_T_Func_2_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr, 100664590);
			CollectionUtils.NativeMethodInfoPtr_Contains_Public_Static_Boolean_List_1_T_T_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr, 100664591);
			CollectionUtils.NativeMethodInfoPtr_IndexOfReference_Public_Static_Int32_List_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr, 100664592);
			CollectionUtils.NativeMethodInfoPtr_FastReverse_Public_Static_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr, 100664593);
			CollectionUtils.NativeMethodInfoPtr_GetDimensions_Private_Static_IList_1_Int32_IList_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr, 100664594);
			CollectionUtils.NativeMethodInfoPtr_CopyFromJaggedToMultidimensionalArray_Private_Static_Void_IList_Array_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr, 100664595);
			CollectionUtils.NativeMethodInfoPtr_JaggedArrayGetValue_Private_Static_Object_IList_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr, 100664596);
			CollectionUtils.NativeMethodInfoPtr_ToMultidimensionalArray_Public_Static_Array_IList_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr, 100664597);
			CollectionUtils.NativeMethodInfoPtr_ArrayEmpty_Public_Static_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr, 100664598);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00031130 File Offset: 0x0002F330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739384, RefRangeEnd = 739385, XrefRangeStart = 739383, XrefRangeEnd = 739384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNullOrEmpty<T>(ICollection<T> collection)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionUtils.MethodInfoStoreGeneric_IsNullOrEmpty_Public_Static_Boolean_ICollection_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00031174 File Offset: 0x0002F374
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 739404, RefRangeEnd = 739418, XrefRangeStart = 739385, XrefRangeEnd = 739404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddRange<T>(this IList<T> initial, IEnumerable<T> collection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initial);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionUtils.MethodInfoStoreGeneric_AddRange_Public_Static_Void_IList_1_T_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x000311BC File Offset: 0x0002F3BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739444, RefRangeEnd = 739445, XrefRangeStart = 739418, XrefRangeEnd = 739444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDictionaryType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionUtils.NativeMethodInfoPtr_IsDictionaryType_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00031200 File Offset: 0x0002F400
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 739461, RefRangeEnd = 739465, XrefRangeStart = 739445, XrefRangeEnd = 739461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collectionType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collectionItemType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionUtils.NativeMethodInfoPtr_ResolveEnumerableCollectionConstructor_Public_Static_ConstructorInfo_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00031258 File Offset: 0x0002F458
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 739490, RefRangeEnd = 739492, XrefRangeStart = 739465, XrefRangeEnd = 739490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collectionType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collectionItemType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(constructorArgumentType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionUtils.NativeMethodInfoPtr_ResolveEnumerableCollectionConstructor_Public_Static_ConstructorInfo_Type_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x000312C0 File Offset: 0x0002F4C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739499, RefRangeEnd = 739500, XrefRangeStart = 739492, XrefRangeEnd = 739499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AddDistinct<T>(this IList<T> list, T value)
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
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CollectionUtils.MethodInfoStoreGeneric_AddDistinct_Public_Static_Boolean_IList_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0003134C File Offset: 0x0002F54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 739500, XrefRangeEnd = 739505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AddDistinct<T>(this IList<T> list, T value, IEqualityComparer<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CollectionUtils.MethodInfoStoreGeneric_AddDistinct_Public_Static_Boolean_IList_1_T_T_IEqualityComparer_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x000313E8 File Offset: 0x0002F5E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 739519, RefRangeEnd = 739523, XrefRangeStart = 739505, XrefRangeEnd = 739519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ContainsValue<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TSource).IsValueType)
			{
				TSource tsource = value;
				intPtr = ((tsource is string) ? IL2CPP.ManagedStringToIl2Cpp(tsource as string) : IL2CPP.Il2CppObjectBaseToPtr(tsource as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CollectionUtils.MethodInfoStoreGeneric_ContainsValue_Public_Static_Boolean_IEnumerable_1_TSource_TSource_IEqualityComparer_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00031484 File Offset: 0x0002F684
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739544, RefRangeEnd = 739545, XrefRangeStart = 739523, XrefRangeEnd = 739544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AddRangeDistinct<T>(this IList<T> list, IEnumerable<T> values, IEqualityComparer<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionUtils.MethodInfoStoreGeneric_AddRangeDistinct_Public_Static_Boolean_IList_1_T_IEnumerable_1_T_IEqualityComparer_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x000314EC File Offset: 0x0002F6EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 739557, RefRangeEnd = 739560, XrefRangeStart = 739545, XrefRangeEnd = 739557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionUtils.MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_IEnumerable_1_T_Func_2_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00031540 File Offset: 0x0002F740
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 739566, RefRangeEnd = 739568, XrefRangeStart = 739560, XrefRangeEnd = 739566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains<T>(this List<T> list, T value, IEqualityComparer comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CollectionUtils.MethodInfoStoreGeneric_Contains_Public_Static_Boolean_List_1_T_T_IEqualityComparer_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000315DC File Offset: 0x0002F7DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 739571, RefRangeEnd = 739575, XrefRangeStart = 739568, XrefRangeEnd = 739571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOfReference<T>(this List<T> list, T item)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CollectionUtils.MethodInfoStoreGeneric_IndexOfReference_Public_Static_Int32_List_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00031668 File Offset: 0x0002F868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739580, RefRangeEnd = 739581, XrefRangeStart = 739575, XrefRangeEnd = 739580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FastReverse<T>(this List<T> list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionUtils.MethodInfoStoreGeneric_FastReverse_Public_Static_Void_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x000316A0 File Offset: 0x0002F8A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739608, RefRangeEnd = 739609, XrefRangeStart = 739581, XrefRangeEnd = 739608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<int> GetDimensions(IList values, int dimensionsCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimensionsCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionUtils.NativeMethodInfoPtr_GetDimensions_Private_Static_IList_1_Int32_IList_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<int>>(intPtr3) : null;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x000316F4 File Offset: 0x0002F8F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 739628, RefRangeEnd = 739630, XrefRangeStart = 739609, XrefRangeEnd = 739628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, Il2CppStructArray<int> indices)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(multidimensionalArray);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionUtils.NativeMethodInfoPtr_CopyFromJaggedToMultidimensionalArray_Private_Static_Void_IList_Array_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00031750 File Offset: 0x0002F950
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 739639, RefRangeEnd = 739641, XrefRangeStart = 739630, XrefRangeEnd = 739639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object JaggedArrayGetValue(IList values, Il2CppStructArray<int> indices)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionUtils.NativeMethodInfoPtr_JaggedArrayGetValue_Private_Static_Object_IList_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x000317A8 File Offset: 0x0002F9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 739641, XrefRangeEnd = 739661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array ToMultidimensionalArray(IList values, Type type, int rank)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionUtils.NativeMethodInfoPtr_ToMultidimensionalArray_Public_Static_Array_IList_Type_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0003180C File Offset: 0x0002FA0C
		[CallerCount(495)]
		[CachedScanResults(RefRangeStart = 739664, RefRangeEnd = 740159, XrefRangeStart = 739661, XrefRangeEnd = 739664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> ArrayEmpty<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionUtils.MethodInfoStoreGeneric_ArrayEmpty_Public_Static_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x000040FB File Offset: 0x000022FB
		public CollectionUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_ICollection_1_T_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_AddRange_Public_Static_Void_IList_1_T_IEnumerable_1_T_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_IsDictionaryType_Public_Static_Boolean_Type_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_ResolveEnumerableCollectionConstructor_Public_Static_ConstructorInfo_Type_Type_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr_ResolveEnumerableCollectionConstructor_Public_Static_ConstructorInfo_Type_Type_Type_0;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr_AddDistinct_Public_Static_Boolean_IList_1_T_T_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr_AddDistinct_Public_Static_Boolean_IList_1_T_T_IEqualityComparer_1_T_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_ContainsValue_Public_Static_Boolean_IEnumerable_1_TSource_TSource_IEqualityComparer_1_TSource_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr_AddRangeDistinct_Public_Static_Boolean_IList_1_T_IEnumerable_1_T_IEqualityComparer_1_T_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_IEnumerable_1_T_Func_2_T_Boolean_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Static_Boolean_List_1_T_T_IEqualityComparer_0;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfReference_Public_Static_Int32_List_1_T_T_0;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeMethodInfoPtr_FastReverse_Public_Static_Void_List_1_T_0;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeMethodInfoPtr_GetDimensions_Private_Static_IList_1_Int32_IList_Int32_0;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeMethodInfoPtr_CopyFromJaggedToMultidimensionalArray_Private_Static_Void_IList_Array_Il2CppStructArray_1_Int32_0;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeMethodInfoPtr_JaggedArrayGetValue_Private_Static_Object_IList_Il2CppStructArray_1_Int32_0;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeMethodInfoPtr_ToMultidimensionalArray_Public_Static_Array_IList_Type_Int32_0;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_ArrayEmpty_Public_Static_Il2CppArrayBase_1_T_0;

		// Token: 0x02000171 RID: 369
		public static class EmptyArrayContainer<T> : Object
		{
			// Token: 0x06001C35 RID: 7221 RVA: 0x000856A8 File Offset: 0x000838A8
			// Note: this type is marked as 'beforefieldinit'.
			static EmptyArrayContainer()
			{
				Il2CppClassPointerStore<CollectionUtils.EmptyArrayContainer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr, "EmptyArrayContainer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionUtils.EmptyArrayContainer<T>>.NativeClassPtr);
				CollectionUtils.EmptyArrayContainer<T>.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionUtils.EmptyArrayContainer<T>>.NativeClassPtr, "Empty");
			}

			// Token: 0x06001C36 RID: 7222 RVA: 0x0000DE85 File Offset: 0x0000C085
			public EmptyArrayContainer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007F8 RID: 2040
			// (get) Token: 0x06001C37 RID: 7223 RVA: 0x00085724 File Offset: 0x00083924
			// (set) Token: 0x06001C38 RID: 7224 RVA: 0x0000DE8E File Offset: 0x0000C08E
			public unsafe static Il2CppArrayBase<T> Empty
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CollectionUtils.EmptyArrayContainer<T>.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CollectionUtils.EmptyArrayContainer<T>.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014FC RID: 5372
			private static readonly IntPtr NativeFieldInfoPtr_Empty;
		}

		// Token: 0x02000172 RID: 370
		private sealed class MethodInfoStoreGeneric_IsNullOrEmpty_Public_Static_Boolean_ICollection_1_T_0<T>
		{
			// Token: 0x040014FD RID: 5373
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionUtils.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_ICollection_1_T_0, Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000173 RID: 371
		private sealed class MethodInfoStoreGeneric_AddRange_Public_Static_Void_IList_1_T_IEnumerable_1_T_0<T>
		{
			// Token: 0x040014FE RID: 5374
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionUtils.NativeMethodInfoPtr_AddRange_Public_Static_Void_IList_1_T_IEnumerable_1_T_0, Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000174 RID: 372
		private sealed class MethodInfoStoreGeneric_AddDistinct_Public_Static_Boolean_IList_1_T_T_0<T>
		{
			// Token: 0x040014FF RID: 5375
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionUtils.NativeMethodInfoPtr_AddDistinct_Public_Static_Boolean_IList_1_T_T_0, Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000175 RID: 373
		private sealed class MethodInfoStoreGeneric_AddDistinct_Public_Static_Boolean_IList_1_T_T_IEqualityComparer_1_T_0<T>
		{
			// Token: 0x04001500 RID: 5376
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionUtils.NativeMethodInfoPtr_AddDistinct_Public_Static_Boolean_IList_1_T_T_IEqualityComparer_1_T_0, Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000176 RID: 374
		private sealed class MethodInfoStoreGeneric_ContainsValue_Public_Static_Boolean_IEnumerable_1_TSource_TSource_IEqualityComparer_1_TSource_0<TSource>
		{
			// Token: 0x04001501 RID: 5377
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionUtils.NativeMethodInfoPtr_ContainsValue_Public_Static_Boolean_IEnumerable_1_TSource_TSource_IEqualityComparer_1_TSource_0, Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000177 RID: 375
		private sealed class MethodInfoStoreGeneric_AddRangeDistinct_Public_Static_Boolean_IList_1_T_IEnumerable_1_T_IEqualityComparer_1_T_0<T>
		{
			// Token: 0x04001502 RID: 5378
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionUtils.NativeMethodInfoPtr_AddRangeDistinct_Public_Static_Boolean_IList_1_T_IEnumerable_1_T_IEqualityComparer_1_T_0, Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000178 RID: 376
		private sealed class MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_IEnumerable_1_T_Func_2_T_Boolean_0<T>
		{
			// Token: 0x04001503 RID: 5379
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionUtils.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_IEnumerable_1_T_Func_2_T_Boolean_0, Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000179 RID: 377
		private sealed class MethodInfoStoreGeneric_Contains_Public_Static_Boolean_List_1_T_T_IEqualityComparer_0<T>
		{
			// Token: 0x04001504 RID: 5380
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionUtils.NativeMethodInfoPtr_Contains_Public_Static_Boolean_List_1_T_T_IEqualityComparer_0, Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200017A RID: 378
		private sealed class MethodInfoStoreGeneric_IndexOfReference_Public_Static_Int32_List_1_T_T_0<T>
		{
			// Token: 0x04001505 RID: 5381
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionUtils.NativeMethodInfoPtr_IndexOfReference_Public_Static_Int32_List_1_T_T_0, Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200017B RID: 379
		private sealed class MethodInfoStoreGeneric_FastReverse_Public_Static_Void_List_1_T_0<T>
		{
			// Token: 0x04001506 RID: 5382
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionUtils.NativeMethodInfoPtr_FastReverse_Public_Static_Void_List_1_T_0, Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200017C RID: 380
		private sealed class MethodInfoStoreGeneric_ArrayEmpty_Public_Static_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04001507 RID: 5383
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionUtils.NativeMethodInfoPtr_ArrayEmpty_Public_Static_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<CollectionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
