using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000027 RID: 39
public sealed class ReadOnlyVersionedMap<K, V> : Object
{
	// Token: 0x0600037A RID: 890 RVA: 0x0002085C File Offset: 0x0001EA5C
	// Note: this type is marked as 'beforefieldinit'.
	static ReadOnlyVersionedMap()
	{
		Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "", "ReadOnlyVersionedMap`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
		})).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr);
		ReadOnlyVersionedMap<K, V>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, "source");
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663776);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663777);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663778);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_K_V_IEqualityComparer_1_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663779);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlyVersionedMap_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663780);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_VersionedMap_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663781);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663782);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_V_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663783);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663784);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663785);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663786);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_ContainsValue_Public_Boolean_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663787);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_K_byref_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663788);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_get_Keys_Public_get_ReadOnlyVersionedList_1_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663789);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_get_Values_Public_get_ReadOnlyVersionedList_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663790);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_get_AsList_Public_get_ReadOnlyVersionedList_1_KeyValuePair_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663791);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_get_InvalidType_Private_get_ArgumentException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663792);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_get_ReadOnlyException_Private_get_NotSupportedException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663793);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_V_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663794);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_set_Void_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663795);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663796);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663797);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663798);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663799);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663800);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663801);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663802);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_K_V_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663803);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663804);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663805);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663806);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663807);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663808);
		ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr, 100663809);
	}

	// Token: 0x0600037B RID: 891 RVA: 0x00020B98 File Offset: 0x0001ED98
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854935, XrefRangeEnd = 854944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReadOnlyVersionedMap()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600037C RID: 892 RVA: 0x00020BD4 File Offset: 0x0001EDD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854944, XrefRangeEnd = 854962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReadOnlyVersionedMap(IEqualityComparer<K> comparer)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600037D RID: 893 RVA: 0x00020C20 File Offset: 0x0001EE20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854962, XrefRangeEnd = 854973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReadOnlyVersionedMap(IDictionary<K, V> source)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600037E RID: 894 RVA: 0x00020C6C File Offset: 0x0001EE6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854973, XrefRangeEnd = 854991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReadOnlyVersionedMap(IDictionary<K, V> source, IEqualityComparer<K> comparer)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_K_V_IEqualityComparer_1_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600037F RID: 895 RVA: 0x00020CCC File Offset: 0x0001EECC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854991, XrefRangeEnd = 855007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReadOnlyVersionedMap(ReadOnlyVersionedMap<K, V> source)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlyVersionedMap_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000380 RID: 896 RVA: 0x00020D18 File Offset: 0x0001EF18
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 855042, RefRangeEnd = 855043, XrefRangeStart = 855007, XrefRangeEnd = 855042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReadOnlyVersionedMap(VersionedMap<K, V> source)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyVersionedMap<K, V>>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_VersionedMap_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x17000115 RID: 277
	// (get) Token: 0x06000381 RID: 897 RVA: 0x00020D64 File Offset: 0x0001EF64
	public unsafe ulong Version
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855043, XrefRangeEnd = 855045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000116 RID: 278
	public unsafe V this[K key]
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855045, XrefRangeEnd = 855053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(K).IsValueType)
				{
					K k = key;
					intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_V_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<V>(intPtr2, false, true);
			}
		}
	}

	// Token: 0x17000117 RID: 279
	// (get) Token: 0x06000383 RID: 899 RVA: 0x00020E20 File Offset: 0x0001F020
	public unsafe int Count
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 855073, RefRangeEnd = 855074, XrefRangeStart = 855053, XrefRangeEnd = 855073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000384 RID: 900 RVA: 0x00020E5C File Offset: 0x0001F05C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855074, XrefRangeEnd = 855075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<K, V>.Enumerator GetEnumerator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return new Dictionary<K, V>.Enumerator(intPtr);
	}

	// Token: 0x06000385 RID: 901 RVA: 0x00020E94 File Offset: 0x0001F094
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855075, XrefRangeEnd = 855081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ContainsKey(K key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(K).IsValueType)
			{
				K k = key;
				intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref key;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	// Token: 0x06000386 RID: 902 RVA: 0x00020F18 File Offset: 0x0001F118
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855081, XrefRangeEnd = 855084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ContainsValue(V value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(V).IsValueType)
			{
				V v = value;
				intPtr = ((v is string) ? IL2CPP.ManagedStringToIl2Cpp(v as string) : IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_ContainsValue_Public_Boolean_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	// Token: 0x06000387 RID: 903 RVA: 0x00020F9C File Offset: 0x0001F19C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855084, XrefRangeEnd = 855098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetValue(K key, out V value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(K).IsValueType)
			{
				K k = key;
				intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref key;
			}
			ptr2 = intPtr;
		}
		ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr2;
		IntPtr intPtr3;
		if (!typeof(V).IsValueType)
		{
			intPtr2 = 0;
			intPtr3 = &intPtr2;
		}
		else
		{
			intPtr3 = ref value;
		}
		ptr3 = intPtr3;
		IntPtr intPtr5;
		IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_K_byref_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
		Il2CppException.RaiseExceptionIfNecessary(intPtr5);
		if (!typeof(V).IsValueType)
		{
			IntPtr intPtr6 = intPtr2;
			value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<V>(intPtr6, false, false));
		}
		return *IL2CPP.il2cpp_object_unbox(intPtr4);
	}

	// Token: 0x17000118 RID: 280
	// (get) Token: 0x06000388 RID: 904 RVA: 0x00021070 File Offset: 0x0001F270
	public unsafe ReadOnlyVersionedList<K> Keys
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855098, XrefRangeEnd = 855104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_get_Keys_Public_get_ReadOnlyVersionedList_1_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<K>>(intPtr3) : null;
		}
	}

	// Token: 0x17000119 RID: 281
	// (get) Token: 0x06000389 RID: 905 RVA: 0x000210B0 File Offset: 0x0001F2B0
	public unsafe ReadOnlyVersionedList<V> Values
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855104, XrefRangeEnd = 855112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_get_Values_Public_get_ReadOnlyVersionedList_1_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<V>>(intPtr3) : null;
		}
	}

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x0600038A RID: 906 RVA: 0x000210F0 File Offset: 0x0001F2F0
	public unsafe ReadOnlyVersionedList<KeyValuePair<K, V>> AsList
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855112, XrefRangeEnd = 855121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_get_AsList_Public_get_ReadOnlyVersionedList_1_KeyValuePair_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<KeyValuePair<K, V>>>(intPtr3) : null;
		}
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x0600038B RID: 907 RVA: 0x00021130 File Offset: 0x0001F330
	public unsafe ArgumentException InvalidType
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855121, XrefRangeEnd = 855138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_get_InvalidType_Private_get_ArgumentException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentException>(intPtr3) : null;
		}
	}

	// Token: 0x1700011C RID: 284
	// (get) Token: 0x0600038C RID: 908 RVA: 0x00021170 File Offset: 0x0001F370
	public unsafe NotSupportedException ReadOnlyException
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855138, XrefRangeEnd = 855144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_get_ReadOnlyException_Private_get_NotSupportedException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NotSupportedException>(intPtr3) : null;
		}
	}

	// Token: 0x1700011D RID: 285
	// (get) Token: 0x0600038D RID: 909 RVA: 0x000211B0 File Offset: 0x0001F3B0
	// (set) Token: 0x0600038E RID: 910 RVA: 0x00021230 File Offset: 0x0001F430
	public unsafe V prop_V_0
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(K).IsValueType)
				{
					K k = key;
					intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_V_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<V>(intPtr2, false, true);
			}
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855144, XrefRangeEnd = 855164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(K).IsValueType)
				{
					K k = key;
					intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(V).IsValueType)
			{
				V v = value;
				intPtr2 = ((v is string) ? IL2CPP.ManagedStringToIl2Cpp(v as string) : IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_set_Void_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}
	}

	// Token: 0x0600038F RID: 911 RVA: 0x000212F0 File Offset: 0x0001F4F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Method_Private_Virtual_Final_New_Void_K_V_0(K key, V value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(K).IsValueType)
			{
				K k = key;
				intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref key;
			}
			ptr2 = intPtr;
		}
		ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr2;
		if (!typeof(V).IsValueType)
		{
			V v = value;
			intPtr2 = ((v is string) ? IL2CPP.ManagedStringToIl2Cpp(v as string) : IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase));
		}
		else
		{
			intPtr2 = ref value;
		}
		ptr3 = intPtr2;
		IntPtr intPtr4;
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
	}

	// Token: 0x06000390 RID: 912 RVA: 0x000213B0 File Offset: 0x0001F5B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855164, XrefRangeEnd = 855180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Method_Private_Virtual_Final_New_Boolean_K_0(K key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(K).IsValueType)
			{
				K k = key;
				intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref key;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x06000391 RID: 913 RVA: 0x00021434 File Offset: 0x0001F634
	public unsafe ICollection<K> prop_ICollection_1_K_0
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855180, XrefRangeEnd = 855183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<K>>(intPtr3) : null;
		}
	}

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x06000392 RID: 914 RVA: 0x00021474 File Offset: 0x0001F674
	public unsafe ICollection<V> prop_ICollection_1_V_0
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855183, XrefRangeEnd = 855186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<V>>(intPtr3) : null;
		}
	}

	// Token: 0x06000393 RID: 915 RVA: 0x000214B4 File Offset: 0x0001F6B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855186, XrefRangeEnd = 855205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Method_Private_Virtual_Final_New_Void_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000394 RID: 916 RVA: 0x000214E8 File Offset: 0x0001F6E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_K_V_0(KeyValuePair<K, V> item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000395 RID: 917 RVA: 0x00021530 File Offset: 0x0001F730
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855205, XrefRangeEnd = 855211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_0(KeyValuePair<K, V> item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000396 RID: 918 RVA: 0x00021584 File Offset: 0x0001F784
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855211, XrefRangeEnd = 855217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_K_V_Int32_0(Il2CppReferenceArray<KeyValuePair<K, V>> array, int arrayIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_K_V_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000397 RID: 919 RVA: 0x000215D4 File Offset: 0x0001F7D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_1(KeyValuePair<K, V> item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000120 RID: 288
	// (get) Token: 0x06000398 RID: 920 RVA: 0x00021628 File Offset: 0x0001F828
	public unsafe bool prop_Boolean_0
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000399 RID: 921 RVA: 0x00021664 File Offset: 0x0001F864
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855217, XrefRangeEnd = 855219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600039A RID: 922 RVA: 0x000216A4 File Offset: 0x0001F8A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator<KeyValuePair<K, V>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_K_V_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<K, V>>>(intPtr3) : null;
	}

	// Token: 0x17000121 RID: 289
	// (get) Token: 0x0600039B RID: 923 RVA: 0x000216E4 File Offset: 0x0001F8E4
	public unsafe IEnumerable<K> prop_IEnumerable_1_K_0
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855219, XrefRangeEnd = 855225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<K>>(intPtr3) : null;
		}
	}

	// Token: 0x17000122 RID: 290
	// (get) Token: 0x0600039C RID: 924 RVA: 0x00021724 File Offset: 0x0001F924
	public unsafe IEnumerable<V> prop_IEnumerable_1_V_0
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855225, XrefRangeEnd = 855241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<V>>(intPtr3) : null;
		}
	}

	// Token: 0x0600039D RID: 925 RVA: 0x0000367B File Offset: 0x0000187B
	public ReadOnlyVersionedMap(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000114 RID: 276
	// (get) Token: 0x0600039E RID: 926 RVA: 0x00021764 File Offset: 0x0001F964
	// (set) Token: 0x0600039F RID: 927 RVA: 0x00003684 File Offset: 0x00001884
	public unsafe VersionedMap<K, V> source
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyVersionedMap<K, V>.NativeFieldInfoPtr_source);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedMap<K, V>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyVersionedMap<K, V>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000285 RID: 645
	private static readonly IntPtr NativeFieldInfoPtr_source;

	// Token: 0x04000286 RID: 646
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000287 RID: 647
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_K_0;

	// Token: 0x04000288 RID: 648
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_K_V_0;

	// Token: 0x04000289 RID: 649
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_K_V_IEqualityComparer_1_K_0;

	// Token: 0x0400028A RID: 650
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ReadOnlyVersionedMap_2_K_V_0;

	// Token: 0x0400028B RID: 651
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_VersionedMap_2_K_V_0;

	// Token: 0x0400028C RID: 652
	private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

	// Token: 0x0400028D RID: 653
	private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_V_K_0;

	// Token: 0x0400028E RID: 654
	private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

	// Token: 0x0400028F RID: 655
	private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_K_V_0;

	// Token: 0x04000290 RID: 656
	private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_K_0;

	// Token: 0x04000291 RID: 657
	private static readonly IntPtr NativeMethodInfoPtr_ContainsValue_Public_Boolean_V_0;

	// Token: 0x04000292 RID: 658
	private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_K_byref_V_0;

	// Token: 0x04000293 RID: 659
	private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_get_ReadOnlyVersionedList_1_K_0;

	// Token: 0x04000294 RID: 660
	private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_get_ReadOnlyVersionedList_1_V_0;

	// Token: 0x04000295 RID: 661
	private static readonly IntPtr NativeMethodInfoPtr_get_AsList_Public_get_ReadOnlyVersionedList_1_KeyValuePair_2_K_V_0;

	// Token: 0x04000296 RID: 662
	private static readonly IntPtr NativeMethodInfoPtr_get_InvalidType_Private_get_ArgumentException_0;

	// Token: 0x04000297 RID: 663
	private static readonly IntPtr NativeMethodInfoPtr_get_ReadOnlyException_Private_get_NotSupportedException_0;

	// Token: 0x04000298 RID: 664
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_V_K_0;

	// Token: 0x04000299 RID: 665
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_set_Void_K_V_0;

	// Token: 0x0400029A RID: 666
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_K_V_0;

	// Token: 0x0400029B RID: 667
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_K_0;

	// Token: 0x0400029C RID: 668
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_K_0;

	// Token: 0x0400029D RID: 669
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_V_0;

	// Token: 0x0400029E RID: 670
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_0;

	// Token: 0x0400029F RID: 671
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_K_V_0;

	// Token: 0x040002A0 RID: 672
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_0;

	// Token: 0x040002A1 RID: 673
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_K_V_Int32_0;

	// Token: 0x040002A2 RID: 674
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_1;

	// Token: 0x040002A3 RID: 675
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0;

	// Token: 0x040002A4 RID: 676
	private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

	// Token: 0x040002A5 RID: 677
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_K_V_0;

	// Token: 0x040002A6 RID: 678
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_K_0;

	// Token: 0x040002A7 RID: 679
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_V_0;
}
