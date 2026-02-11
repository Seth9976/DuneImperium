using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000022 RID: 34
public class ReadOnlyDictionary<K, V> : Object
{
	// Token: 0x06000304 RID: 772 RVA: 0x0001DF6C File Offset: 0x0001C16C
	// Note: this type is marked as 'beforefieldinit'.
	static ReadOnlyDictionary()
	{
		Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "", "ReadOnlyDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
		})).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr);
		ReadOnlyDictionary<K, V>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, "source");
		ReadOnlyDictionary<K, V>.NativeFieldInfoPtr_getEnumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, "getEnumerator");
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663684);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663685);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr__ctor_Public_Void_VersionedMap_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663686);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_K_V_Func_1_Enumerator_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663687);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663688);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_K_byref_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663689);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_V_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663690);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663691);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663692);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663693);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663694);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663695);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_V_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663696);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_set_Void_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663697);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663698);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663699);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663700);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_K_V_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663701);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663702);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663703);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663704);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663705);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663706);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663707);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663708);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Add_Public_Void_KeyValuePair_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663709);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Remove_Public_Boolean_KeyValuePair_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663710);
		ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_get_ReadOnlyException_Protected_get_NotSupportedException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr, 100663711);
	}

	// Token: 0x06000305 RID: 773 RVA: 0x0001E244 File Offset: 0x0001C444
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853885, XrefRangeEnd = 853898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReadOnlyDictionary(IDictionary<K, V> source)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000306 RID: 774 RVA: 0x0001E290 File Offset: 0x0001C490
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 853914, RefRangeEnd = 853915, XrefRangeStart = 853898, XrefRangeEnd = 853914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReadOnlyDictionary(Dictionary<K, V> source)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000307 RID: 775 RVA: 0x0001E2DC File Offset: 0x0001C4DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853915, XrefRangeEnd = 853931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReadOnlyDictionary(VersionedMap<K, V> source)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr__ctor_Public_Void_VersionedMap_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000308 RID: 776 RVA: 0x0001E328 File Offset: 0x0001C528
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853931, XrefRangeEnd = 853944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReadOnlyDictionary(IDictionary<K, V> source, Func<Dictionary<K, V>.Enumerator> getEnumerator)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyDictionary<K, V>>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getEnumerator);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_K_V_Func_1_Enumerator_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000309 RID: 777 RVA: 0x0001E388 File Offset: 0x0001C588
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853944, XrefRangeEnd = 853947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool ContainsKey(K key)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	// Token: 0x0600030A RID: 778 RVA: 0x0001E40C File Offset: 0x0001C60C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853947, XrefRangeEnd = 853996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool TryGetValue(K key, out V value)
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
		IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_K_byref_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
		Il2CppException.RaiseExceptionIfNecessary(intPtr5);
		if (!typeof(V).IsValueType)
		{
			IntPtr intPtr6 = intPtr2;
			value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<V>(intPtr6, false, false));
		}
		return *IL2CPP.il2cpp_object_unbox(intPtr4);
	}

	// Token: 0x170000F4 RID: 244
	public unsafe virtual V this[K key]
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 854004, RefRangeEnd = 854008, XrefRangeStart = 853996, XrefRangeEnd = 854004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_V_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<V>(intPtr2, false, true);
			}
		}
	}

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x0600030C RID: 780 RVA: 0x0001E560 File Offset: 0x0001C760
	public unsafe virtual ICollection<K> Keys
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854008, XrefRangeEnd = 854011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<K>>(intPtr3) : null;
		}
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x0600030D RID: 781 RVA: 0x0001E5A0 File Offset: 0x0001C7A0
	public unsafe virtual ICollection<V> Values
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 854030, RefRangeEnd = 854032, XrefRangeStart = 854011, XrefRangeEnd = 854030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<V>>(intPtr3) : null;
		}
	}

	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x0600030E RID: 782 RVA: 0x0001E5E0 File Offset: 0x0001C7E0
	public unsafe virtual int Count
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 854039, RefRangeEnd = 854041, XrefRangeStart = 854032, XrefRangeEnd = 854039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600030F RID: 783 RVA: 0x0001E61C File Offset: 0x0001C81C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854041, XrefRangeEnd = 854050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Method_Private_Virtual_Final_New_Void_K_V_0(K key, V value)
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
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
	}

	// Token: 0x06000310 RID: 784 RVA: 0x0001E6DC File Offset: 0x0001C8DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854050, XrefRangeEnd = 854059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_K_0(K key)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x06000311 RID: 785 RVA: 0x0001E760 File Offset: 0x0001C960
	// (set) Token: 0x06000312 RID: 786 RVA: 0x0001E7E0 File Offset: 0x0001C9E0
	public unsafe virtual V prop_V_0
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854059, XrefRangeEnd = 854072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_V_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<V>(intPtr2, false, true);
			}
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_set_Void_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}
	}

	// Token: 0x06000313 RID: 787 RVA: 0x0001E8A0 File Offset: 0x0001CAA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_K_V_0(KeyValuePair<K, V> item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000314 RID: 788 RVA: 0x0001E8E8 File Offset: 0x0001CAE8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854072, XrefRangeEnd = 854077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Method_Private_Virtual_Final_New_Void_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000315 RID: 789 RVA: 0x0001E91C File Offset: 0x0001CB1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854077, XrefRangeEnd = 854081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_0(KeyValuePair<K, V> item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000316 RID: 790 RVA: 0x0001E970 File Offset: 0x0001CB70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854081, XrefRangeEnd = 854088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_K_V_Int32_0(Il2CppReferenceArray<KeyValuePair<K, V>> array, int arrayIndex)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_K_V_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000317 RID: 791 RVA: 0x0001E9C0 File Offset: 0x0001CBC0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_1(KeyValuePair<K, V> item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x06000318 RID: 792 RVA: 0x0001EA14 File Offset: 0x0001CC14
	public unsafe virtual bool prop_Boolean_0
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000FA RID: 250
	// (get) Token: 0x06000319 RID: 793 RVA: 0x0001EA50 File Offset: 0x0001CC50
	public unsafe virtual IEnumerable<K> prop_IEnumerable_1_K_0
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854088, XrefRangeEnd = 854091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<K>>(intPtr3) : null;
		}
	}

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x0600031A RID: 794 RVA: 0x0001EA90 File Offset: 0x0001CC90
	public unsafe virtual IEnumerable<V> prop_IEnumerable_1_V_0
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854091, XrefRangeEnd = 854094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<V>>(intPtr3) : null;
		}
	}

	// Token: 0x0600031B RID: 795 RVA: 0x0001EAD0 File Offset: 0x0001CCD0
	[CallerCount(0)]
	public unsafe Dictionary<K, V>.Enumerator GetEnumerator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return new Dictionary<K, V>.Enumerator(intPtr);
	}

	// Token: 0x0600031C RID: 796 RVA: 0x0001EB08 File Offset: 0x0001CD08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854094, XrefRangeEnd = 854095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600031D RID: 797 RVA: 0x0001EB48 File Offset: 0x0001CD48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerator<KeyValuePair<K, V>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_K_V_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<K, V>>>(intPtr3) : null;
	}

	// Token: 0x0600031E RID: 798 RVA: 0x0001EB88 File Offset: 0x0001CD88
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Add(KeyValuePair<K, V> item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Add_Public_Void_KeyValuePair_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600031F RID: 799 RVA: 0x0001EBD0 File Offset: 0x0001CDD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Remove(KeyValuePair<K, V> item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_Remove_Public_Boolean_KeyValuePair_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x06000320 RID: 800 RVA: 0x0001EC24 File Offset: 0x0001CE24
	public unsafe NotSupportedException ReadOnlyException
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854095, XrefRangeEnd = 854101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<K, V>.NativeMethodInfoPtr_get_ReadOnlyException_Protected_get_NotSupportedException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NotSupportedException>(intPtr3) : null;
		}
	}

	// Token: 0x06000321 RID: 801 RVA: 0x0000355E File Offset: 0x0000175E
	public ReadOnlyDictionary(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x06000322 RID: 802 RVA: 0x0001EC64 File Offset: 0x0001CE64
	// (set) Token: 0x06000323 RID: 803 RVA: 0x00003567 File Offset: 0x00001767
	public unsafe IDictionary<K, V> source
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<K, V>.NativeFieldInfoPtr_source);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<K, V>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<K, V>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x06000324 RID: 804 RVA: 0x0001EC94 File Offset: 0x0001CE94
	// (set) Token: 0x06000325 RID: 805 RVA: 0x00003586 File Offset: 0x00001786
	public unsafe Func<Dictionary<K, V>.Enumerator> getEnumerator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<K, V>.NativeFieldInfoPtr_getEnumerator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Dictionary<K, V>.Enumerator>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<K, V>.NativeFieldInfoPtr_getEnumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000221 RID: 545
	private static readonly IntPtr NativeFieldInfoPtr_source;

	// Token: 0x04000222 RID: 546
	private static readonly IntPtr NativeFieldInfoPtr_getEnumerator;

	// Token: 0x04000223 RID: 547
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_K_V_0;

	// Token: 0x04000224 RID: 548
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_K_V_0;

	// Token: 0x04000225 RID: 549
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_VersionedMap_2_K_V_0;

	// Token: 0x04000226 RID: 550
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_K_V_Func_1_Enumerator_K_V_0;

	// Token: 0x04000227 RID: 551
	private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_K_0;

	// Token: 0x04000228 RID: 552
	private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_K_byref_V_0;

	// Token: 0x04000229 RID: 553
	private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_V_K_0;

	// Token: 0x0400022A RID: 554
	private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_K_0;

	// Token: 0x0400022B RID: 555
	private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_V_0;

	// Token: 0x0400022C RID: 556
	private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

	// Token: 0x0400022D RID: 557
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_K_V_0;

	// Token: 0x0400022E RID: 558
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_K_0;

	// Token: 0x0400022F RID: 559
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_V_K_0;

	// Token: 0x04000230 RID: 560
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_set_Void_K_V_0;

	// Token: 0x04000231 RID: 561
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_K_V_0;

	// Token: 0x04000232 RID: 562
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_0;

	// Token: 0x04000233 RID: 563
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_0;

	// Token: 0x04000234 RID: 564
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_K_V_Int32_0;

	// Token: 0x04000235 RID: 565
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_1;

	// Token: 0x04000236 RID: 566
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0;

	// Token: 0x04000237 RID: 567
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_K_0;

	// Token: 0x04000238 RID: 568
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_V_0;

	// Token: 0x04000239 RID: 569
	private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_K_V_0;

	// Token: 0x0400023A RID: 570
	private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

	// Token: 0x0400023B RID: 571
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_K_V_0;

	// Token: 0x0400023C RID: 572
	private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_KeyValuePair_2_K_V_0;

	// Token: 0x0400023D RID: 573
	private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_KeyValuePair_2_K_V_0;

	// Token: 0x0400023E RID: 574
	private static readonly IntPtr NativeMethodInfoPtr_get_ReadOnlyException_Protected_get_NotSupportedException_0;
}
