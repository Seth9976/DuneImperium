using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000028 RID: 40
public sealed class VersionedMap<K, V> : Object
{
	// Token: 0x060003A0 RID: 928 RVA: 0x00021794 File Offset: 0x0001F994
	// Note: this type is marked as 'beforefieldinit'.
	static VersionedMap()
	{
		Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "", "VersionedMap`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
		})).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr);
		VersionedMap<K, V>.NativeFieldInfoPtr__DefaultValueComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, "_DefaultValueComparer");
		VersionedMap<K, V>.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, "data");
		VersionedMap<K, V>.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, "version");
		VersionedMap<K, V>.NativeFieldInfoPtr_dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, "dirty");
		VersionedMap<K, V>.NativeFieldInfoPtr__readOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, "_readOnly");
		VersionedMap<K, V>.NativeFieldInfoPtr_keysVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, "keysVersion");
		VersionedMap<K, V>.NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, "keys");
		VersionedMap<K, V>.NativeFieldInfoPtr_valuesVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, "valuesVersion");
		VersionedMap<K, V>.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, "values");
		VersionedMap<K, V>.NativeFieldInfoPtr_listVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, "listVersion");
		VersionedMap<K, V>.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, "list");
		VersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663810);
		VersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663811);
		VersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_KeyValuePair_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663812);
		VersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663813);
		VersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_K_V_IEqualityComparer_1_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663814);
		VersionedMap<K, V>.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663815);
		VersionedMap<K, V>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663816);
		VersionedMap<K, V>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663817);
		VersionedMap<K, V>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663818);
		VersionedMap<K, V>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663819);
		VersionedMap<K, V>.NativeMethodInfoPtr_Set_Public_Void_IDictionary_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663820);
		VersionedMap<K, V>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663821);
		VersionedMap<K, V>.NativeMethodInfoPtr_ContainsValue_Public_Boolean_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663822);
		VersionedMap<K, V>.NativeMethodInfoPtr_ContainsPair_Public_Boolean_KeyValuePair_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663823);
		VersionedMap<K, V>.NativeMethodInfoPtr_ContainsPair_Public_Boolean_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663824);
		VersionedMap<K, V>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_V_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663825);
		VersionedMap<K, V>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663826);
		VersionedMap<K, V>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663827);
		VersionedMap<K, V>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_K_byref_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663828);
		VersionedMap<K, V>.NativeMethodInfoPtr_get_AsReadOnly_Public_get_ReadOnlyVersionedMap_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663829);
		VersionedMap<K, V>.NativeMethodInfoPtr_get_Keys_Public_get_ReadOnlyVersionedList_1_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663830);
		VersionedMap<K, V>.NativeMethodInfoPtr_get_Values_Public_get_ReadOnlyVersionedList_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663831);
		VersionedMap<K, V>.NativeMethodInfoPtr_get_AsList_Public_get_ReadOnlyVersionedList_1_KeyValuePair_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663832);
		VersionedMap<K, V>.NativeMethodInfoPtr_updateKeys_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663833);
		VersionedMap<K, V>.NativeMethodInfoPtr_updateValues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663834);
		VersionedMap<K, V>.NativeMethodInfoPtr_updateList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663835);
		VersionedMap<K, V>.NativeMethodInfoPtr_markDirty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663836);
		VersionedMap<K, V>.NativeMethodInfoPtr_get_InvalidType_Private_get_ArgumentException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663837);
		VersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663838);
		VersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663839);
		VersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663840);
		VersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663841);
		VersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_K_V_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663842);
		VersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663843);
		VersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663844);
		VersionedMap<K, V>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663845);
		VersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663846);
		VersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663847);
		VersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr, 100663848);
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x00021BFC File Offset: 0x0001FDFC
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 855265, RefRangeEnd = 855275, XrefRangeStart = 855241, XrefRangeEnd = 855265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VersionedMap()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x00021C38 File Offset: 0x0001FE38
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 855326, RefRangeEnd = 855327, XrefRangeStart = 855275, XrefRangeEnd = 855326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VersionedMap(IDictionary<K, V> source)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x00021C84 File Offset: 0x0001FE84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855327, XrefRangeEnd = 855349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VersionedMap(IEnumerable<KeyValuePair<K, V>> source)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_KeyValuePair_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00021CD0 File Offset: 0x0001FED0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 855385, RefRangeEnd = 855386, XrefRangeStart = 855349, XrefRangeEnd = 855385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VersionedMap(IEqualityComparer<K> comparer)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x00021D1C File Offset: 0x0001FF1C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 855405, RefRangeEnd = 855406, XrefRangeStart = 855386, XrefRangeEnd = 855405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VersionedMap(IDictionary<K, V> source, IEqualityComparer<K> comparer)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionedMap<K, V>>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_K_V_IEqualityComparer_1_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x1700012E RID: 302
	// (get) Token: 0x060003A6 RID: 934 RVA: 0x00021D7C File Offset: 0x0001FF7C
	public unsafe ulong Version
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 855406, RefRangeEnd = 855409, XrefRangeStart = 855406, XrefRangeEnd = 855406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x00021DB8 File Offset: 0x0001FFB8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855409, XrefRangeEnd = 855412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x1700012F RID: 303
	// (get) Token: 0x060003A8 RID: 936 RVA: 0x00021DEC File Offset: 0x0001FFEC
	public unsafe int Count
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 855431, RefRangeEnd = 855432, XrefRangeStart = 855412, XrefRangeEnd = 855431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x00021E28 File Offset: 0x00020028
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 855433, RefRangeEnd = 855436, XrefRangeStart = 855432, XrefRangeEnd = 855433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<K, V>.Enumerator GetEnumerator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return new Dictionary<K, V>.Enumerator(intPtr);
	}

	// Token: 0x060003AA RID: 938 RVA: 0x00021E60 File Offset: 0x00020060
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855436, XrefRangeEnd = 855455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Add(K key, V value)
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
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
	}

	// Token: 0x060003AB RID: 939 RVA: 0x00021F20 File Offset: 0x00020120
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855455, XrefRangeEnd = 855493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Set(IDictionary<K, V> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_Set_Public_Void_IDictionary_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003AC RID: 940 RVA: 0x00021F64 File Offset: 0x00020164
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 855500, RefRangeEnd = 855501, XrefRangeStart = 855493, XrefRangeEnd = 855500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	// Token: 0x060003AD RID: 941 RVA: 0x00021FE8 File Offset: 0x000201E8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 855508, RefRangeEnd = 855509, XrefRangeStart = 855501, XrefRangeEnd = 855508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_ContainsValue_Public_Boolean_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	// Token: 0x060003AE RID: 942 RVA: 0x0002206C File Offset: 0x0002026C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855509, XrefRangeEnd = 855511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ContainsPair(KeyValuePair<K, V> pair)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_ContainsPair_Public_Boolean_KeyValuePair_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060003AF RID: 943 RVA: 0x000220C0 File Offset: 0x000202C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855511, XrefRangeEnd = 855515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ContainsPair(K key, V value)
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
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_ContainsPair_Public_Boolean_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		return *IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	// Token: 0x17000130 RID: 304
	public unsafe V this[K key]
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 855527, RefRangeEnd = 855529, XrefRangeStart = 855515, XrefRangeEnd = 855527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_V_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<V>(intPtr2, false, true);
			}
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855529, XrefRangeEnd = 855532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x000222CC File Offset: 0x000204CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855532, XrefRangeEnd = 855533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Remove(K key)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x00022350 File Offset: 0x00020550
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 855545, RefRangeEnd = 855546, XrefRangeStart = 855533, XrefRangeEnd = 855545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_K_byref_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
		Il2CppException.RaiseExceptionIfNecessary(intPtr5);
		if (!typeof(V).IsValueType)
		{
			IntPtr intPtr6 = intPtr2;
			value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<V>(intPtr6, false, false));
		}
		return *IL2CPP.il2cpp_object_unbox(intPtr4);
	}

	// Token: 0x17000131 RID: 305
	// (get) Token: 0x060003B4 RID: 948 RVA: 0x00022424 File Offset: 0x00020624
	public unsafe ReadOnlyVersionedMap<K, V> AsReadOnly
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855546, XrefRangeEnd = 855550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_get_AsReadOnly_Public_get_ReadOnlyVersionedMap_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedMap<K, V>>(intPtr3) : null;
		}
	}

	// Token: 0x17000132 RID: 306
	// (get) Token: 0x060003B5 RID: 949 RVA: 0x00022464 File Offset: 0x00020664
	public unsafe ReadOnlyVersionedList<K> Keys
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 855585, RefRangeEnd = 855587, XrefRangeStart = 855550, XrefRangeEnd = 855585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_get_Keys_Public_get_ReadOnlyVersionedList_1_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<K>>(intPtr3) : null;
		}
	}

	// Token: 0x17000133 RID: 307
	// (get) Token: 0x060003B6 RID: 950 RVA: 0x000224A4 File Offset: 0x000206A4
	public unsafe ReadOnlyVersionedList<V> Values
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 855626, RefRangeEnd = 855628, XrefRangeStart = 855587, XrefRangeEnd = 855626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_get_Values_Public_get_ReadOnlyVersionedList_1_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<V>>(intPtr3) : null;
		}
	}

	// Token: 0x17000134 RID: 308
	// (get) Token: 0x060003B7 RID: 951 RVA: 0x000224E4 File Offset: 0x000206E4
	public unsafe ReadOnlyVersionedList<KeyValuePair<K, V>> AsList
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 855671, RefRangeEnd = 855672, XrefRangeStart = 855628, XrefRangeEnd = 855671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_get_AsList_Public_get_ReadOnlyVersionedList_1_KeyValuePair_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<KeyValuePair<K, V>>>(intPtr3) : null;
		}
	}

	// Token: 0x060003B8 RID: 952 RVA: 0x00022524 File Offset: 0x00020724
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855672, XrefRangeEnd = 855678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateKeys()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_updateKeys_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003B9 RID: 953 RVA: 0x00022558 File Offset: 0x00020758
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855678, XrefRangeEnd = 855684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateValues()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_updateValues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003BA RID: 954 RVA: 0x0002258C File Offset: 0x0002078C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855684, XrefRangeEnd = 855689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_updateList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003BB RID: 955 RVA: 0x000225C0 File Offset: 0x000207C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855689, XrefRangeEnd = 855698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void markDirty()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_markDirty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000135 RID: 309
	// (get) Token: 0x060003BC RID: 956 RVA: 0x000225F4 File Offset: 0x000207F4
	public unsafe ArgumentException InvalidType
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855698, XrefRangeEnd = 855715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_get_InvalidType_Private_get_ArgumentException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentException>(intPtr3) : null;
		}
	}

	// Token: 0x17000136 RID: 310
	// (get) Token: 0x060003BD RID: 957 RVA: 0x00022634 File Offset: 0x00020834
	public unsafe ICollection<K> prop_ICollection_1_K_0
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855715, XrefRangeEnd = 855719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<K>>(intPtr3) : null;
		}
	}

	// Token: 0x17000137 RID: 311
	// (get) Token: 0x060003BE RID: 958 RVA: 0x00022674 File Offset: 0x00020874
	public unsafe ICollection<V> prop_ICollection_1_V_0
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855719, XrefRangeEnd = 855723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<V>>(intPtr3) : null;
		}
	}

	// Token: 0x060003BF RID: 959 RVA: 0x000226B4 File Offset: 0x000208B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855723, XrefRangeEnd = 855731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_K_V_0(KeyValuePair<K, V> item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x000226FC File Offset: 0x000208FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855731, XrefRangeEnd = 855738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_0(KeyValuePair<K, V> item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x00022750 File Offset: 0x00020950
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855738, XrefRangeEnd = 855747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_K_V_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x000227A0 File Offset: 0x000209A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855747, XrefRangeEnd = 855750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_1(KeyValuePair<K, V> item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000138 RID: 312
	// (get) Token: 0x060003C3 RID: 963 RVA: 0x000227F4 File Offset: 0x000209F4
	public unsafe bool prop_Boolean_0
	{
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060003C4 RID: 964 RVA: 0x00022830 File Offset: 0x00020A30
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855750, XrefRangeEnd = 855752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x00022870 File Offset: 0x00020A70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator<KeyValuePair<K, V>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_K_V_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<K, V>>>(intPtr3) : null;
	}

	// Token: 0x17000139 RID: 313
	// (get) Token: 0x060003C6 RID: 966 RVA: 0x000228B0 File Offset: 0x00020AB0
	public unsafe IEnumerable<K> prop_IEnumerable_1_K_0
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855752, XrefRangeEnd = 855787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<K>>(intPtr3) : null;
		}
	}

	// Token: 0x1700013A RID: 314
	// (get) Token: 0x060003C7 RID: 967 RVA: 0x000228F0 File Offset: 0x00020AF0
	public unsafe IEnumerable<V> prop_IEnumerable_1_V_0
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855787, XrefRangeEnd = 855794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedMap<K, V>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<V>>(intPtr3) : null;
		}
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x000036A3 File Offset: 0x000018A3
	public VersionedMap(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000123 RID: 291
	// (get) Token: 0x060003C9 RID: 969 RVA: 0x00022930 File Offset: 0x00020B30
	// (set) Token: 0x060003CA RID: 970 RVA: 0x000036AC File Offset: 0x000018AC
	public unsafe static EqualityComparer<V> _DefaultValueComparer
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(VersionedMap<K, V>.NativeFieldInfoPtr__DefaultValueComparer, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EqualityComparer<V>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(VersionedMap<K, V>.NativeFieldInfoPtr__DefaultValueComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000124 RID: 292
	// (get) Token: 0x060003CB RID: 971 RVA: 0x00022958 File Offset: 0x00020B58
	// (set) Token: 0x060003CC RID: 972 RVA: 0x000036BE File Offset: 0x000018BE
	public unsafe Dictionary<K, V> data
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedMap<K, V>.NativeFieldInfoPtr_data);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<K, V>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedMap<K, V>.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000125 RID: 293
	// (get) Token: 0x060003CD RID: 973 RVA: 0x00022988 File Offset: 0x00020B88
	// (set) Token: 0x060003CE RID: 974 RVA: 0x000036DD File Offset: 0x000018DD
	public unsafe ulong version
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedMap<K, V>.NativeFieldInfoPtr_version);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedMap<K, V>.NativeFieldInfoPtr_version)) = value;
		}
	}

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x060003CF RID: 975 RVA: 0x000229B0 File Offset: 0x00020BB0
	// (set) Token: 0x060003D0 RID: 976 RVA: 0x000036F8 File Offset: 0x000018F8
	public unsafe bool dirty
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedMap<K, V>.NativeFieldInfoPtr_dirty);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedMap<K, V>.NativeFieldInfoPtr_dirty)) = value;
		}
	}

	// Token: 0x17000127 RID: 295
	// (get) Token: 0x060003D1 RID: 977 RVA: 0x000229D8 File Offset: 0x00020BD8
	// (set) Token: 0x060003D2 RID: 978 RVA: 0x00003713 File Offset: 0x00001913
	public unsafe ReadOnlyVersionedMap<K, V> _readOnly
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedMap<K, V>.NativeFieldInfoPtr__readOnly);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedMap<K, V>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedMap<K, V>.NativeFieldInfoPtr__readOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000128 RID: 296
	// (get) Token: 0x060003D3 RID: 979 RVA: 0x00022A08 File Offset: 0x00020C08
	// (set) Token: 0x060003D4 RID: 980 RVA: 0x00003732 File Offset: 0x00001932
	public Nullable<ulong> keysVersion
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedMap<K, V>.NativeFieldInfoPtr_keysVersion);
			return new Nullable<ulong>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<ulong>>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedMap<K, V>.NativeFieldInfoPtr_keysVersion), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<ulong>>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17000129 RID: 297
	// (get) Token: 0x060003D5 RID: 981 RVA: 0x00022A38 File Offset: 0x00020C38
	// (set) Token: 0x060003D6 RID: 982 RVA: 0x00003760 File Offset: 0x00001960
	public unsafe VersionedList<K> keys
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedMap<K, V>.NativeFieldInfoPtr_keys);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedList<K>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedMap<K, V>.NativeFieldInfoPtr_keys), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700012A RID: 298
	// (get) Token: 0x060003D7 RID: 983 RVA: 0x00022A68 File Offset: 0x00020C68
	// (set) Token: 0x060003D8 RID: 984 RVA: 0x0000377F File Offset: 0x0000197F
	public Nullable<ulong> valuesVersion
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedMap<K, V>.NativeFieldInfoPtr_valuesVersion);
			return new Nullable<ulong>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<ulong>>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedMap<K, V>.NativeFieldInfoPtr_valuesVersion), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<ulong>>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x1700012B RID: 299
	// (get) Token: 0x060003D9 RID: 985 RVA: 0x00022A98 File Offset: 0x00020C98
	// (set) Token: 0x060003DA RID: 986 RVA: 0x000037AD File Offset: 0x000019AD
	public unsafe VersionedList<V> values
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedMap<K, V>.NativeFieldInfoPtr_values);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedList<V>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedMap<K, V>.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700012C RID: 300
	// (get) Token: 0x060003DB RID: 987 RVA: 0x00022AC8 File Offset: 0x00020CC8
	// (set) Token: 0x060003DC RID: 988 RVA: 0x000037CC File Offset: 0x000019CC
	public Nullable<ulong> listVersion
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedMap<K, V>.NativeFieldInfoPtr_listVersion);
			return new Nullable<ulong>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<ulong>>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedMap<K, V>.NativeFieldInfoPtr_listVersion), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<ulong>>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x1700012D RID: 301
	// (get) Token: 0x060003DD RID: 989 RVA: 0x00022AF8 File Offset: 0x00020CF8
	// (set) Token: 0x060003DE RID: 990 RVA: 0x000037FA File Offset: 0x000019FA
	public unsafe VersionedList<KeyValuePair<K, V>> list
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedMap<K, V>.NativeFieldInfoPtr_list);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedList<KeyValuePair<K, V>>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedMap<K, V>.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040002A8 RID: 680
	private static readonly IntPtr NativeFieldInfoPtr__DefaultValueComparer;

	// Token: 0x040002A9 RID: 681
	private static readonly IntPtr NativeFieldInfoPtr_data;

	// Token: 0x040002AA RID: 682
	private static readonly IntPtr NativeFieldInfoPtr_version;

	// Token: 0x040002AB RID: 683
	private static readonly IntPtr NativeFieldInfoPtr_dirty;

	// Token: 0x040002AC RID: 684
	private static readonly IntPtr NativeFieldInfoPtr__readOnly;

	// Token: 0x040002AD RID: 685
	private static readonly IntPtr NativeFieldInfoPtr_keysVersion;

	// Token: 0x040002AE RID: 686
	private static readonly IntPtr NativeFieldInfoPtr_keys;

	// Token: 0x040002AF RID: 687
	private static readonly IntPtr NativeFieldInfoPtr_valuesVersion;

	// Token: 0x040002B0 RID: 688
	private static readonly IntPtr NativeFieldInfoPtr_values;

	// Token: 0x040002B1 RID: 689
	private static readonly IntPtr NativeFieldInfoPtr_listVersion;

	// Token: 0x040002B2 RID: 690
	private static readonly IntPtr NativeFieldInfoPtr_list;

	// Token: 0x040002B3 RID: 691
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x040002B4 RID: 692
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_K_V_0;

	// Token: 0x040002B5 RID: 693
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_KeyValuePair_2_K_V_0;

	// Token: 0x040002B6 RID: 694
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_K_0;

	// Token: 0x040002B7 RID: 695
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_K_V_IEqualityComparer_1_K_0;

	// Token: 0x040002B8 RID: 696
	private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

	// Token: 0x040002B9 RID: 697
	private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

	// Token: 0x040002BA RID: 698
	private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

	// Token: 0x040002BB RID: 699
	private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_K_V_0;

	// Token: 0x040002BC RID: 700
	private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_K_V_0;

	// Token: 0x040002BD RID: 701
	private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_IDictionary_2_K_V_0;

	// Token: 0x040002BE RID: 702
	private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_K_0;

	// Token: 0x040002BF RID: 703
	private static readonly IntPtr NativeMethodInfoPtr_ContainsValue_Public_Boolean_V_0;

	// Token: 0x040002C0 RID: 704
	private static readonly IntPtr NativeMethodInfoPtr_ContainsPair_Public_Boolean_KeyValuePair_2_K_V_0;

	// Token: 0x040002C1 RID: 705
	private static readonly IntPtr NativeMethodInfoPtr_ContainsPair_Public_Boolean_K_V_0;

	// Token: 0x040002C2 RID: 706
	private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_V_K_0;

	// Token: 0x040002C3 RID: 707
	private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_K_V_0;

	// Token: 0x040002C4 RID: 708
	private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_K_0;

	// Token: 0x040002C5 RID: 709
	private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_K_byref_V_0;

	// Token: 0x040002C6 RID: 710
	private static readonly IntPtr NativeMethodInfoPtr_get_AsReadOnly_Public_get_ReadOnlyVersionedMap_2_K_V_0;

	// Token: 0x040002C7 RID: 711
	private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_get_ReadOnlyVersionedList_1_K_0;

	// Token: 0x040002C8 RID: 712
	private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_get_ReadOnlyVersionedList_1_V_0;

	// Token: 0x040002C9 RID: 713
	private static readonly IntPtr NativeMethodInfoPtr_get_AsList_Public_get_ReadOnlyVersionedList_1_KeyValuePair_2_K_V_0;

	// Token: 0x040002CA RID: 714
	private static readonly IntPtr NativeMethodInfoPtr_updateKeys_Private_Void_0;

	// Token: 0x040002CB RID: 715
	private static readonly IntPtr NativeMethodInfoPtr_updateValues_Private_Void_0;

	// Token: 0x040002CC RID: 716
	private static readonly IntPtr NativeMethodInfoPtr_updateList_Private_Void_0;

	// Token: 0x040002CD RID: 717
	private static readonly IntPtr NativeMethodInfoPtr_markDirty_Private_Void_0;

	// Token: 0x040002CE RID: 718
	private static readonly IntPtr NativeMethodInfoPtr_get_InvalidType_Private_get_ArgumentException_0;

	// Token: 0x040002CF RID: 719
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_K_0;

	// Token: 0x040002D0 RID: 720
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_V_0;

	// Token: 0x040002D1 RID: 721
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_K_V_0;

	// Token: 0x040002D2 RID: 722
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_0;

	// Token: 0x040002D3 RID: 723
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_K_V_Int32_0;

	// Token: 0x040002D4 RID: 724
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_K_V_1;

	// Token: 0x040002D5 RID: 725
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0;

	// Token: 0x040002D6 RID: 726
	private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

	// Token: 0x040002D7 RID: 727
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_K_V_0;

	// Token: 0x040002D8 RID: 728
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_K_0;

	// Token: 0x040002D9 RID: 729
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_V_0;
}
