using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004DD RID: 1245
	[Serializable]
	public class Dictionary<TKey, TValue> : Object
	{
		// Token: 0x06004D20 RID: 19744 RVA: 0x0016549C File Offset: 0x0016369C
		// Note: this type is marked as 'beforefieldinit'.
		static Dictionary()
		{
			Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "Dictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr);
			Dictionary<TKey, TValue>.NativeFieldInfoPtr__buckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "_buckets");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr__entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "_entries");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "_count");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr__freeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "_freeList");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr__freeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "_freeCount");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "_version");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr__comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "_comparer");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr__keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "_keys");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "_values");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "_syncRoot");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_VersionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "VersionName");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_HashSizeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "HashSizeName");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_KeyValuePairsName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "KeyValuePairsName");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_ComparerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "ComparerName");
			Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674833);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674834);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674835);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674836);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674837);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674838);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674839);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674840);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_get_KeyCollection_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674841);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674842);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674843);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_get_ValueCollection_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674844);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674845);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674846);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674847);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674848);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674849);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674850);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674851);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674852);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674853);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674854);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsValue_Public_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674855);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_CopyTo_Private_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674856);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674857);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674858);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674859);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_FindEntry_Private_Int32_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674860);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Initialize_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674861);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_TryInsert_Private_Boolean_TKey_TValue_InsertionBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674862);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674863);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Resize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674864);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Resize_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674865);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674866);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674867);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674868);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_TryAdd_Public_Boolean_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674869);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674870);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674871);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674872);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674873);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674874);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674875);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674876);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674877);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674878);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674879);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674880);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674881);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_IsCompatibleKey_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674882);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674883);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674884);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674885);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100674886);
		}

		// Token: 0x06004D21 RID: 19745 RVA: 0x00165A6C File Offset: 0x00163C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419727, XrefRangeEnd = 1419730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D22 RID: 19746 RVA: 0x00165AA8 File Offset: 0x00163CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419730, XrefRangeEnd = 1419731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004D23 RID: 19747 RVA: 0x00165AF0 File Offset: 0x00163CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1419734, RefRangeEnd = 1419735, XrefRangeStart = 1419731, XrefRangeEnd = 1419734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary(IEqualityComparer<TKey> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004D24 RID: 19748 RVA: 0x00165B3C File Offset: 0x00163D3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1419741, RefRangeEnd = 1419742, XrefRangeStart = 1419735, XrefRangeEnd = 1419741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary(int capacity, IEqualityComparer<TKey> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D25 RID: 19749 RVA: 0x00165B98 File Offset: 0x00163D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419742, XrefRangeEnd = 1419743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary(IDictionary<TKey, TValue> dictionary)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004D26 RID: 19750 RVA: 0x00165BE4 File Offset: 0x00163DE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1419772, RefRangeEnd = 1419773, XrefRangeStart = 1419743, XrefRangeEnd = 1419772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D27 RID: 19751 RVA: 0x00165C44 File Offset: 0x00163E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419773, XrefRangeEnd = 1419782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x06004D28 RID: 19752 RVA: 0x00165CA8 File Offset: 0x00163EA8
		public unsafe virtual int Count
		{
			[CallerCount(137)]
			[CachedScanResults(RefRangeStart = 1419782, RefRangeEnd = 1419919, XrefRangeStart = 1419782, XrefRangeEnd = 1419782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x06004D29 RID: 19753 RVA: 0x00165CE4 File Offset: 0x00163EE4
		public unsafe Dictionary<TKey, TValue>.KeyCollection Keys
		{
			[CallerCount(89)]
			[CachedScanResults(RefRangeStart = 1419923, RefRangeEnd = 1420012, XrefRangeStart = 1419919, XrefRangeEnd = 1419923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_get_KeyCollection_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>.KeyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x06004D2A RID: 19754 RVA: 0x00165D24 File Offset: 0x00163F24
		public unsafe virtual ICollection<TKey> prop_ICollection_1_TKey_0
		{
			[CallerCount(89)]
			[CachedScanResults(RefRangeStart = 1419923, RefRangeEnd = 1420012, XrefRangeStart = 1419923, XrefRangeEnd = 1420012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<TKey>>(intPtr3) : null;
			}
		}

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x06004D2B RID: 19755 RVA: 0x00165D64 File Offset: 0x00163F64
		public unsafe virtual IEnumerable<TKey> prop_IEnumerable_1_TKey_0
		{
			[CallerCount(89)]
			[CachedScanResults(RefRangeStart = 1419923, RefRangeEnd = 1420012, XrefRangeStart = 1419923, XrefRangeEnd = 1420012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TKey>>(intPtr3) : null;
			}
		}

		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x06004D2C RID: 19756 RVA: 0x00165DA4 File Offset: 0x00163FA4
		public unsafe Dictionary<TKey, TValue>.ValueCollection Values
		{
			[CallerCount(86)]
			[CachedScanResults(RefRangeStart = 1420016, RefRangeEnd = 1420102, XrefRangeStart = 1420012, XrefRangeEnd = 1420016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_get_ValueCollection_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>.ValueCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x06004D2D RID: 19757 RVA: 0x00165DE4 File Offset: 0x00163FE4
		public unsafe virtual ICollection<TValue> prop_ICollection_1_TValue_0
		{
			[CallerCount(86)]
			[CachedScanResults(RefRangeStart = 1420016, RefRangeEnd = 1420102, XrefRangeStart = 1420016, XrefRangeEnd = 1420102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<TValue>>(intPtr3) : null;
			}
		}

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x06004D2E RID: 19758 RVA: 0x00165E24 File Offset: 0x00164024
		public unsafe virtual IEnumerable<TValue> prop_IEnumerable_1_TValue_0
		{
			[CallerCount(86)]
			[CachedScanResults(RefRangeStart = 1420016, RefRangeEnd = 1420102, XrefRangeStart = 1420016, XrefRangeEnd = 1420102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TValue>>(intPtr3) : null;
			}
		}

		// Token: 0x170013F3 RID: 5107
		public unsafe virtual TValue this[TKey key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420102, XrefRangeEnd = 1420105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TKey).IsValueType)
					{
						TKey tkey = key;
						intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref key;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420105, XrefRangeEnd = 1420106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TKey).IsValueType)
					{
						TKey tkey = key;
						intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref key;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue = value;
					intPtr2 = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref value;
				}
				ptr3 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			}
		}

		// Token: 0x06004D31 RID: 19761 RVA: 0x00165FA4 File Offset: 0x001641A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1420107, RefRangeEnd = 1420109, XrefRangeStart = 1420106, XrefRangeEnd = 1420107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(TKey key, TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = value;
				intPtr2 = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x06004D32 RID: 19762 RVA: 0x00166064 File Offset: 0x00164264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420109, XrefRangeEnd = 1420110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004D33 RID: 19763 RVA: 0x001660AC File Offset: 0x001642AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420110, XrefRangeEnd = 1420113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004D34 RID: 19764 RVA: 0x00166100 File Offset: 0x00164300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420113, XrefRangeEnd = 1420117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004D35 RID: 19765 RVA: 0x00166154 File Offset: 0x00164354
		[CallerCount(179)]
		[CachedScanResults(RefRangeStart = 1420119, RefRangeEnd = 1420298, XrefRangeStart = 1420117, XrefRangeEnd = 1420119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D36 RID: 19766 RVA: 0x00166188 File Offset: 0x00164388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1420299, RefRangeEnd = 1420300, XrefRangeStart = 1420298, XrefRangeEnd = 1420299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ContainsKey(TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004D37 RID: 19767 RVA: 0x0016620C File Offset: 0x0016440C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1420301, RefRangeEnd = 1420302, XrefRangeStart = 1420300, XrefRangeEnd = 1420301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsValue(TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue = value;
					intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsValue_Public_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004D38 RID: 19768 RVA: 0x00166290 File Offset: 0x00164490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420302, XrefRangeEnd = 1420307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Il2CppReferenceArray<KeyValuePair<TKey, TValue>> array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_CopyTo_Private_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D39 RID: 19769 RVA: 0x001662E0 File Offset: 0x001644E0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1420308, RefRangeEnd = 1420320, XrefRangeStart = 1420307, XrefRangeEnd = 1420308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Dictionary<TKey, TValue>.Enumerator(intPtr);
		}

		// Token: 0x06004D3A RID: 19770 RVA: 0x00166318 File Offset: 0x00164518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420320, XrefRangeEnd = 1420322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<TKey, TValue>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x06004D3B RID: 19771 RVA: 0x00166358 File Offset: 0x00164558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420322, XrefRangeEnd = 1420346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dictionary<TKey, TValue>.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D3C RID: 19772 RVA: 0x001663BC File Offset: 0x001645BC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1420369, RefRangeEnd = 1420375, XrefRangeStart = 1420346, XrefRangeEnd = 1420369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindEntry(TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_FindEntry_Private_Int32_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004D3D RID: 19773 RVA: 0x00166440 File Offset: 0x00164640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420375, XrefRangeEnd = 1420386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Initialize(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Initialize_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004D3E RID: 19774 RVA: 0x0016648C File Offset: 0x0016468C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1420399, RefRangeEnd = 1420407, XrefRangeStart = 1420386, XrefRangeEnd = 1420399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryInsert(TKey key, TValue value, InsertionBehavior behavior)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = value;
				intPtr2 = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behavior;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_TryInsert_Private_Boolean_TKey_TValue_InsertionBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06004D3F RID: 19775 RVA: 0x00166568 File Offset: 0x00164768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420407, XrefRangeEnd = 1420442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dictionary<TKey, TValue>.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004D40 RID: 19776 RVA: 0x001665B8 File Offset: 0x001647B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420442, XrefRangeEnd = 1420456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Resize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D41 RID: 19777 RVA: 0x001665EC File Offset: 0x001647EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420456, XrefRangeEnd = 1420466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resize(int newSize, bool forceNewHashCodes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceNewHashCodes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Resize_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D42 RID: 19778 RVA: 0x00166638 File Offset: 0x00164838
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1420477, RefRangeEnd = 1420479, XrefRangeStart = 1420466, XrefRangeEnd = 1420477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004D43 RID: 19779 RVA: 0x001666BC File Offset: 0x001648BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420479, XrefRangeEnd = 1420490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(TKey key, out TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
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
			if (!typeof(TValue).IsValueType)
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
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06004D44 RID: 19780 RVA: 0x00166790 File Offset: 0x00164990
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1420491, RefRangeEnd = 1420493, XrefRangeStart = 1420490, XrefRangeEnd = 1420491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetValue(TKey key, out TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
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
			if (!typeof(TValue).IsValueType)
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
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06004D45 RID: 19781 RVA: 0x00166864 File Offset: 0x00164A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420493, XrefRangeEnd = 1420494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAdd(TKey key, TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = value;
				intPtr2 = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_TryAdd_Public_Boolean_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x06004D46 RID: 19782 RVA: 0x00166930 File Offset: 0x00164B30
		public unsafe virtual bool prop_Boolean_0
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004D47 RID: 19783 RVA: 0x0016696C File Offset: 0x00164B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420494, XrefRangeEnd = 1420495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0(Il2CppReferenceArray<KeyValuePair<TKey, TValue>> array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D48 RID: 19784 RVA: 0x001669BC File Offset: 0x00164BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420495, XrefRangeEnd = 1420525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_ICollection_CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D49 RID: 19785 RVA: 0x00166A0C File Offset: 0x00164C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x06004D4A RID: 19786 RVA: 0x00166A4C File Offset: 0x00164C4C
		public unsafe virtual bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x06004D4B RID: 19787 RVA: 0x00166A88 File Offset: 0x00164C88
		public unsafe virtual Object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420525, XrefRangeEnd = 1420530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x06004D4C RID: 19788 RVA: 0x00166AC8 File Offset: 0x00164CC8
		public unsafe virtual bool System.Collections.IDictionary.IsFixedSize
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x06004D4D RID: 19789 RVA: 0x00166B04 File Offset: 0x00164D04
		public unsafe virtual bool System.Collections.IDictionary.IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x06004D4E RID: 19790 RVA: 0x00166B40 File Offset: 0x00164D40
		public unsafe virtual ICollection System.Collections.IDictionary.Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420530, XrefRangeEnd = 1420534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x06004D4F RID: 19791 RVA: 0x00166B80 File Offset: 0x00164D80
		public unsafe virtual ICollection System.Collections.IDictionary.Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420534, XrefRangeEnd = 1420538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x06004D50 RID: 19792 RVA: 0x00166BC0 File Offset: 0x00164DC0
		// (set) Token: 0x06004D51 RID: 19793 RVA: 0x00166C10 File Offset: 0x00164E10
		public unsafe virtual Object System.Collections.IDictionary.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420538, XrefRangeEnd = 1420546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420546, XrefRangeEnd = 1420564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004D52 RID: 19794 RVA: 0x00166C64 File Offset: 0x00164E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420564, XrefRangeEnd = 1420568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCompatibleKey(Object key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_IsCompatibleKey_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004D53 RID: 19795 RVA: 0x00166CA8 File Offset: 0x00164EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420568, XrefRangeEnd = 1420586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IDictionary_Add(Object key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D54 RID: 19796 RVA: 0x00166CFC File Offset: 0x00164EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420586, XrefRangeEnd = 1420590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IDictionary_Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004D55 RID: 19797 RVA: 0x00166D4C File Offset: 0x00164F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420590, XrefRangeEnd = 1420592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator System_Collections_IDictionary_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004D56 RID: 19798 RVA: 0x00166D8C File Offset: 0x00164F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420592, XrefRangeEnd = 1420599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IDictionary_Remove(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004D57 RID: 19799 RVA: 0x0001BFC6 File Offset: 0x0001A1C6
		public Dictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x06004D58 RID: 19800 RVA: 0x00166DD0 File Offset: 0x00164FD0
		// (set) Token: 0x06004D59 RID: 19801 RVA: 0x0001BFCF File Offset: 0x0001A1CF
		public unsafe Il2CppStructArray<int> _buckets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__buckets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__buckets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x06004D5A RID: 19802 RVA: 0x00166E00 File Offset: 0x00165000
		// (set) Token: 0x06004D5B RID: 19803 RVA: 0x0001BFEE File Offset: 0x0001A1EE
		public unsafe Il2CppReferenceArray<Dictionary<TKey, TValue>.Entry> _entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Dictionary<TKey, TValue>.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x06004D5C RID: 19804 RVA: 0x00166E30 File Offset: 0x00165030
		// (set) Token: 0x06004D5D RID: 19805 RVA: 0x0001C00D File Offset: 0x0001A20D
		public unsafe int _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x06004D5E RID: 19806 RVA: 0x00166E58 File Offset: 0x00165058
		// (set) Token: 0x06004D5F RID: 19807 RVA: 0x0001C028 File Offset: 0x0001A228
		public unsafe int _freeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__freeList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__freeList)) = value;
			}
		}

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x06004D60 RID: 19808 RVA: 0x00166E80 File Offset: 0x00165080
		// (set) Token: 0x06004D61 RID: 19809 RVA: 0x0001C043 File Offset: 0x0001A243
		public unsafe int _freeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__freeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__freeCount)) = value;
			}
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x06004D62 RID: 19810 RVA: 0x00166EA8 File Offset: 0x001650A8
		// (set) Token: 0x06004D63 RID: 19811 RVA: 0x0001C05E File Offset: 0x0001A25E
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x06004D64 RID: 19812 RVA: 0x00166ED0 File Offset: 0x001650D0
		// (set) Token: 0x06004D65 RID: 19813 RVA: 0x0001C079 File Offset: 0x0001A279
		public unsafe IEqualityComparer<TKey> _comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x06004D66 RID: 19814 RVA: 0x00166F00 File Offset: 0x00165100
		// (set) Token: 0x06004D67 RID: 19815 RVA: 0x0001C098 File Offset: 0x0001A298
		public unsafe Dictionary<TKey, TValue>.KeyCollection _keys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__keys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>.KeyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__keys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x06004D68 RID: 19816 RVA: 0x00166F30 File Offset: 0x00165130
		// (set) Token: 0x06004D69 RID: 19817 RVA: 0x0001C0B7 File Offset: 0x0001A2B7
		public unsafe Dictionary<TKey, TValue>.ValueCollection _values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>.ValueCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x06004D6A RID: 19818 RVA: 0x00166F60 File Offset: 0x00165160
		// (set) Token: 0x06004D6B RID: 19819 RVA: 0x0001C0D6 File Offset: 0x0001A2D6
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x06004D6C RID: 19820 RVA: 0x00166F90 File Offset: 0x00165190
		// (set) Token: 0x06004D6D RID: 19821 RVA: 0x0001C0F5 File Offset: 0x0001A2F5
		public unsafe static string VersionName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_VersionName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_VersionName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x06004D6E RID: 19822 RVA: 0x00166FB0 File Offset: 0x001651B0
		// (set) Token: 0x06004D6F RID: 19823 RVA: 0x0001C107 File Offset: 0x0001A307
		public unsafe static string HashSizeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_HashSizeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_HashSizeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x06004D70 RID: 19824 RVA: 0x00166FD0 File Offset: 0x001651D0
		// (set) Token: 0x06004D71 RID: 19825 RVA: 0x0001C119 File Offset: 0x0001A319
		public unsafe static string KeyValuePairsName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_KeyValuePairsName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_KeyValuePairsName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x06004D72 RID: 19826 RVA: 0x00166FF0 File Offset: 0x001651F0
		// (set) Token: 0x06004D73 RID: 19827 RVA: 0x0001C12B File Offset: 0x0001A32B
		public unsafe static string ComparerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_ComparerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_ComparerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003F22 RID: 16162
		private static readonly IntPtr NativeFieldInfoPtr__buckets;

		// Token: 0x04003F23 RID: 16163
		private static readonly IntPtr NativeFieldInfoPtr__entries;

		// Token: 0x04003F24 RID: 16164
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x04003F25 RID: 16165
		private static readonly IntPtr NativeFieldInfoPtr__freeList;

		// Token: 0x04003F26 RID: 16166
		private static readonly IntPtr NativeFieldInfoPtr__freeCount;

		// Token: 0x04003F27 RID: 16167
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x04003F28 RID: 16168
		private static readonly IntPtr NativeFieldInfoPtr__comparer;

		// Token: 0x04003F29 RID: 16169
		private static readonly IntPtr NativeFieldInfoPtr__keys;

		// Token: 0x04003F2A RID: 16170
		private static readonly IntPtr NativeFieldInfoPtr__values;

		// Token: 0x04003F2B RID: 16171
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x04003F2C RID: 16172
		private static readonly IntPtr NativeFieldInfoPtr_VersionName;

		// Token: 0x04003F2D RID: 16173
		private static readonly IntPtr NativeFieldInfoPtr_HashSizeName;

		// Token: 0x04003F2E RID: 16174
		private static readonly IntPtr NativeFieldInfoPtr_KeyValuePairsName;

		// Token: 0x04003F2F RID: 16175
		private static readonly IntPtr NativeFieldInfoPtr_ComparerName;

		// Token: 0x04003F30 RID: 16176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003F31 RID: 16177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003F32 RID: 16178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TKey_0;

		// Token: 0x04003F33 RID: 16179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_1_TKey_0;

		// Token: 0x04003F34 RID: 16180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0;

		// Token: 0x04003F35 RID: 16181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_IEqualityComparer_1_TKey_0;

		// Token: 0x04003F36 RID: 16182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003F37 RID: 16183
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04003F38 RID: 16184
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_get_KeyCollection_TKey_TValue_0;

		// Token: 0x04003F39 RID: 16185
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TKey_0;

		// Token: 0x04003F3A RID: 16186
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TKey_0;

		// Token: 0x04003F3B RID: 16187
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_get_ValueCollection_TKey_TValue_0;

		// Token: 0x04003F3C RID: 16188
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TValue_0;

		// Token: 0x04003F3D RID: 16189
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TValue_0;

		// Token: 0x04003F3E RID: 16190
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0;

		// Token: 0x04003F3F RID: 16191
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0;

		// Token: 0x04003F40 RID: 16192
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0;

		// Token: 0x04003F41 RID: 16193
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04003F42 RID: 16194
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04003F43 RID: 16195
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1;

		// Token: 0x04003F44 RID: 16196
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003F45 RID: 16197
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x04003F46 RID: 16198
		private static readonly IntPtr NativeMethodInfoPtr_ContainsValue_Public_Boolean_TValue_0;

		// Token: 0x04003F47 RID: 16199
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Private_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x04003F48 RID: 16200
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0;

		// Token: 0x04003F49 RID: 16201
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04003F4A RID: 16202
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003F4B RID: 16203
		private static readonly IntPtr NativeMethodInfoPtr_FindEntry_Private_Int32_TKey_0;

		// Token: 0x04003F4C RID: 16204
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Int32_Int32_0;

		// Token: 0x04003F4D RID: 16205
		private static readonly IntPtr NativeMethodInfoPtr_TryInsert_Private_Boolean_TKey_TValue_InsertionBehavior_0;

		// Token: 0x04003F4E RID: 16206
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0;

		// Token: 0x04003F4F RID: 16207
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Private_Void_0;

		// Token: 0x04003F50 RID: 16208
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Private_Void_Int32_Boolean_0;

		// Token: 0x04003F51 RID: 16209
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x04003F52 RID: 16210
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_TKey_byref_TValue_0;

		// Token: 0x04003F53 RID: 16211
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0;

		// Token: 0x04003F54 RID: 16212
		private static readonly IntPtr NativeMethodInfoPtr_TryAdd_Public_Boolean_TKey_TValue_0;

		// Token: 0x04003F55 RID: 16213
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003F56 RID: 16214
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x04003F57 RID: 16215
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04003F58 RID: 16216
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04003F59 RID: 16217
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x04003F5A RID: 16218
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04003F5B RID: 16219
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x04003F5C RID: 16220
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x04003F5D RID: 16221
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04003F5E RID: 16222
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04003F5F RID: 16223
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0;

		// Token: 0x04003F60 RID: 16224
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0;

		// Token: 0x04003F61 RID: 16225
		private static readonly IntPtr NativeMethodInfoPtr_IsCompatibleKey_Private_Static_Boolean_Object_0;

		// Token: 0x04003F62 RID: 16226
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0;

		// Token: 0x04003F63 RID: 16227
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x04003F64 RID: 16228
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x04003F65 RID: 16229
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x02000702 RID: 1794
		public sealed class Entry : ValueType
		{
			// Token: 0x06005F64 RID: 24420 RVA: 0x001AEC48 File Offset: 0x001ACE48
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<Dictionary<TKey, TValue>.Entry>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "Entry"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Entry>.NativeClassPtr);
				Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Entry>.NativeClassPtr, "hashCode");
				Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Entry>.NativeClassPtr, "next");
				Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Entry>.NativeClassPtr, "key");
				Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Entry>.NativeClassPtr, "value");
			}

			// Token: 0x06005F65 RID: 24421 RVA: 0x00022E0E File Offset: 0x0002100E
			public Entry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005F66 RID: 24422 RVA: 0x00022E17 File Offset: 0x00021017
			public Entry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Entry>.NativeClassPtr))
			{
			}

			// Token: 0x170018A1 RID: 6305
			// (get) Token: 0x06005F67 RID: 24423 RVA: 0x001AED10 File Offset: 0x001ACF10
			// (set) Token: 0x06005F68 RID: 24424 RVA: 0x00022E29 File Offset: 0x00021029
			public unsafe int hashCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_hashCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_hashCode)) = value;
				}
			}

			// Token: 0x170018A2 RID: 6306
			// (get) Token: 0x06005F69 RID: 24425 RVA: 0x001AED38 File Offset: 0x001ACF38
			// (set) Token: 0x06005F6A RID: 24426 RVA: 0x00022E44 File Offset: 0x00021044
			public unsafe int next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_next);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_next)) = value;
				}
			}

			// Token: 0x170018A3 RID: 6307
			// (get) Token: 0x06005F6B RID: 24427 RVA: 0x001AED60 File Offset: 0x001ACF60
			// (set) Token: 0x06005F6C RID: 24428 RVA: 0x001AED88 File Offset: 0x001ACF88
			public unsafe TKey key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_key);
					return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_key);
					Type typeFromHandle = typeof(TKey);
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

			// Token: 0x170018A4 RID: 6308
			// (get) Token: 0x06005F6D RID: 24429 RVA: 0x001AEE30 File Offset: 0x001AD030
			// (set) Token: 0x06005F6E RID: 24430 RVA: 0x001AEE58 File Offset: 0x001AD058
			public unsafe TValue value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_value);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_value);
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

			// Token: 0x04004D95 RID: 19861
			private static readonly IntPtr NativeFieldInfoPtr_hashCode;

			// Token: 0x04004D96 RID: 19862
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x04004D97 RID: 19863
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04004D98 RID: 19864
			private static readonly IntPtr NativeFieldInfoPtr_value;
		}

		// Token: 0x02000703 RID: 1795
		[Serializable]
		public sealed class Enumerator : ValueType
		{
			// Token: 0x06005F6F RID: 24431 RVA: 0x001AEF00 File Offset: 0x001AD100
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr);
				Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "_dictionary");
				Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "_version");
				Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "_index");
				Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "_current");
				Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__getEnumeratorRetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "_getEnumeratorRetType");
				Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_DictEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "DictEntry");
				Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_KeyValuePair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "KeyValuePair");
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100674887);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100674888);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100674889);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100674890);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100674891);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100674892);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Entry_Private_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100674893);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Key_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100674894);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Value_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100674895);
			}

			// Token: 0x06005F70 RID: 24432 RVA: 0x001AF0B8 File Offset: 0x001AD2B8
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1419405, RefRangeEnd = 1419409, XrefRangeStart = 1419404, XrefRangeEnd = 1419405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref getEnumeratorRetType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005F71 RID: 24433 RVA: 0x001AF118 File Offset: 0x001AD318
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1419413, RefRangeEnd = 1419418, XrefRangeStart = 1419409, XrefRangeEnd = 1419413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170018AC RID: 6316
			// (get) Token: 0x06005F72 RID: 24434 RVA: 0x001AF15C File Offset: 0x001AD35C
			public unsafe KeyValuePair<TKey, TValue> Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<TKey, TValue>(intPtr);
				}
			}

			// Token: 0x06005F73 RID: 24435 RVA: 0x001AF198 File Offset: 0x001AD398
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018AD RID: 6317
			// (get) Token: 0x06005F74 RID: 24436 RVA: 0x001AF1D0 File Offset: 0x001AD3D0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419418, XrefRangeEnd = 1419426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005F75 RID: 24437 RVA: 0x001AF214 File Offset: 0x001AD414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419426, XrefRangeEnd = 1419427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018AE RID: 6318
			// (get) Token: 0x06005F76 RID: 24438 RVA: 0x001AF24C File Offset: 0x001AD44C
			public unsafe DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419427, XrefRangeEnd = 1419433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Entry_Private_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x170018AF RID: 6319
			// (get) Token: 0x06005F77 RID: 24439 RVA: 0x001AF288 File Offset: 0x001AD488
			public unsafe Object System.Collections.IDictionaryEnumerator.Key
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419433, XrefRangeEnd = 1419437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Key_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170018B0 RID: 6320
			// (get) Token: 0x06005F78 RID: 24440 RVA: 0x001AF2CC File Offset: 0x001AD4CC
			public unsafe Object System.Collections.IDictionaryEnumerator.Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419437, XrefRangeEnd = 1419439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Value_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005F79 RID: 24441 RVA: 0x00022E5F File Offset: 0x0002105F
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005F7A RID: 24442 RVA: 0x00022E68 File Offset: 0x00021068
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x170018A5 RID: 6309
			// (get) Token: 0x06005F7B RID: 24443 RVA: 0x001AF310 File Offset: 0x001AD510
			// (set) Token: 0x06005F7C RID: 24444 RVA: 0x00022E7A File Offset: 0x0002107A
			public unsafe Dictionary<TKey, TValue> _dictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__dictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018A6 RID: 6310
			// (get) Token: 0x06005F7D RID: 24445 RVA: 0x001AF340 File Offset: 0x001AD540
			// (set) Token: 0x06005F7E RID: 24446 RVA: 0x00022E99 File Offset: 0x00021099
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x170018A7 RID: 6311
			// (get) Token: 0x06005F7F RID: 24447 RVA: 0x001AF368 File Offset: 0x001AD568
			// (set) Token: 0x06005F80 RID: 24448 RVA: 0x00022EB4 File Offset: 0x000210B4
			public unsafe int _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__index)) = value;
				}
			}

			// Token: 0x170018A8 RID: 6312
			// (get) Token: 0x06005F81 RID: 24449 RVA: 0x001AF390 File Offset: 0x001AD590
			// (set) Token: 0x06005F82 RID: 24450 RVA: 0x00022ECF File Offset: 0x000210CF
			public KeyValuePair<TKey, TValue> _current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__current);
					return new KeyValuePair<TKey, TValue>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170018A9 RID: 6313
			// (get) Token: 0x06005F83 RID: 24451 RVA: 0x001AF3C0 File Offset: 0x001AD5C0
			// (set) Token: 0x06005F84 RID: 24452 RVA: 0x00022EFD File Offset: 0x000210FD
			public unsafe int _getEnumeratorRetType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__getEnumeratorRetType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__getEnumeratorRetType)) = value;
				}
			}

			// Token: 0x170018AA RID: 6314
			// (get) Token: 0x06005F85 RID: 24453 RVA: 0x001AF3E8 File Offset: 0x001AD5E8
			// (set) Token: 0x06005F86 RID: 24454 RVA: 0x00022F18 File Offset: 0x00021118
			public unsafe static int DictEntry
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_DictEntry, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_DictEntry, (void*)(&value));
				}
			}

			// Token: 0x170018AB RID: 6315
			// (get) Token: 0x06005F87 RID: 24455 RVA: 0x001AF404 File Offset: 0x001AD604
			// (set) Token: 0x06005F88 RID: 24456 RVA: 0x00022F26 File Offset: 0x00021126
			public unsafe static int KeyValuePair
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_KeyValuePair, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_KeyValuePair, (void*)(&value));
				}
			}

			// Token: 0x04004D99 RID: 19865
			private static readonly IntPtr NativeFieldInfoPtr__dictionary;

			// Token: 0x04004D9A RID: 19866
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x04004D9B RID: 19867
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x04004D9C RID: 19868
			private static readonly IntPtr NativeFieldInfoPtr__current;

			// Token: 0x04004D9D RID: 19869
			private static readonly IntPtr NativeFieldInfoPtr__getEnumeratorRetType;

			// Token: 0x04004D9E RID: 19870
			private static readonly IntPtr NativeFieldInfoPtr_DictEntry;

			// Token: 0x04004D9F RID: 19871
			private static readonly IntPtr NativeFieldInfoPtr_KeyValuePair;

			// Token: 0x04004DA0 RID: 19872
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_Int32_0;

			// Token: 0x04004DA1 RID: 19873
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004DA2 RID: 19874
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0;

			// Token: 0x04004DA3 RID: 19875
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04004DA4 RID: 19876
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004DA5 RID: 19877
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004DA6 RID: 19878
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Entry_Private_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x04004DA7 RID: 19879
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Key_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004DA8 RID: 19880
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Value_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000704 RID: 1796
		[Serializable]
		public sealed class KeyCollection : Object
		{
			// Token: 0x06005F89 RID: 24457 RVA: 0x001AF420 File Offset: 0x001AD620
			// Note: this type is marked as 'beforefieldinit'.
			static KeyCollection()
			{
				Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "KeyCollection"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr);
				Dictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr__dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, "_dictionary");
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674896);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674897);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674898);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674899);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674900);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674901);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674902);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674903);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674904);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TKey__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674905);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674906);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674907);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674908);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674909);
			}

			// Token: 0x06005F8A RID: 24458 RVA: 0x001AF5C4 File Offset: 0x001AD7C4
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1419452, RefRangeEnd = 1419460, XrefRangeStart = 1419449, XrefRangeEnd = 1419452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyCollection(Dictionary<TKey, TValue> dictionary)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005F8B RID: 24459 RVA: 0x001AF610 File Offset: 0x001AD810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419460, XrefRangeEnd = 1419461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<TKey, TValue>.KeyCollection.Enumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Dictionary<TKey, TValue>.KeyCollection.Enumerator(intPtr);
			}

			// Token: 0x06005F8C RID: 24460 RVA: 0x001AF648 File Offset: 0x001AD848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419461, XrefRangeEnd = 1419467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CopyTo(Il2CppArrayBase<TKey> array, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018B2 RID: 6322
			// (get) Token: 0x06005F8D RID: 24461 RVA: 0x001AF698 File Offset: 0x001AD898
			public unsafe int Count
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1419469, RefRangeEnd = 1419470, XrefRangeStart = 1419467, XrefRangeEnd = 1419469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170018B3 RID: 6323
			// (get) Token: 0x06005F8E RID: 24462 RVA: 0x001AF6D4 File Offset: 0x001AD8D4
			public unsafe bool System.Collections.Generic.ICollection<TKey>.IsReadOnly
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005F8F RID: 24463 RVA: 0x001AF710 File Offset: 0x001AD910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419470, XrefRangeEnd = 1419471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_Generic_ICollection_TKey__Add(TKey item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TKey).IsValueType)
					{
						TKey tkey = item;
						intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref item;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x06005F90 RID: 24464 RVA: 0x001AF788 File Offset: 0x001AD988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_Generic_ICollection_TKey__Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005F91 RID: 24465 RVA: 0x001AF7BC File Offset: 0x001AD9BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419471, XrefRangeEnd = 1419472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool System_Collections_Generic_ICollection_TKey__Contains(TKey item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TKey).IsValueType)
					{
						TKey tkey = item;
						intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref item;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06005F92 RID: 24466 RVA: 0x001AF840 File Offset: 0x001ADA40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419472, XrefRangeEnd = 1419473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool System_Collections_Generic_ICollection_TKey__Remove(TKey item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TKey).IsValueType)
					{
						TKey tkey = item;
						intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref item;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06005F93 RID: 24467 RVA: 0x001AF8C4 File Offset: 0x001ADAC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419473, XrefRangeEnd = 1419475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TKey> System_Collections_Generic_IEnumerable_TKey__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TKey__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TKey>>(intPtr3) : null;
			}

			// Token: 0x06005F94 RID: 24468 RVA: 0x001AF904 File Offset: 0x001ADB04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005F95 RID: 24469 RVA: 0x001AF944 File Offset: 0x001ADB44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419475, XrefRangeEnd = 1419496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_ICollection_CopyTo(Array array, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018B4 RID: 6324
			// (get) Token: 0x06005F96 RID: 24470 RVA: 0x001AF994 File Offset: 0x001ADB94
			public unsafe bool System.Collections.ICollection.IsSynchronized
			{
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170018B5 RID: 6325
			// (get) Token: 0x06005F97 RID: 24471 RVA: 0x001AF9D0 File Offset: 0x001ADBD0
			public unsafe Object System.Collections.ICollection.SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419496, XrefRangeEnd = 1419536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005F98 RID: 24472 RVA: 0x00022F34 File Offset: 0x00021134
			public KeyCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018B1 RID: 6321
			// (get) Token: 0x06005F99 RID: 24473 RVA: 0x001AFA10 File Offset: 0x001ADC10
			// (set) Token: 0x06005F9A RID: 24474 RVA: 0x00022F3D File Offset: 0x0002113D
			public unsafe Dictionary<TKey, TValue> _dictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr__dictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr__dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004DA9 RID: 19881
			private static readonly IntPtr NativeFieldInfoPtr__dictionary;

			// Token: 0x04004DAA RID: 19882
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_TKey_TValue_0;

			// Token: 0x04004DAB RID: 19883
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0;

			// Token: 0x04004DAC RID: 19884
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0;

			// Token: 0x04004DAD RID: 19885
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04004DAE RID: 19886
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04004DAF RID: 19887
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0;

			// Token: 0x04004DB0 RID: 19888
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004DB1 RID: 19889
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0;

			// Token: 0x04004DB2 RID: 19890
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0;

			// Token: 0x04004DB3 RID: 19891
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TKey__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TKey_0;

			// Token: 0x04004DB4 RID: 19892
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04004DB5 RID: 19893
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x04004DB6 RID: 19894
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04004DB7 RID: 19895
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x02000793 RID: 1939
			[Serializable]
			public sealed class Enumerator : ValueType
			{
				// Token: 0x0600633C RID: 25404 RVA: 0x001BA720 File Offset: 0x001B8920
				// Note: this type is marked as 'beforefieldinit'.
				static Enumerator()
				{
					Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr);
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr__dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "_dictionary");
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "_index");
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "_version");
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr__currentKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "_currentKey");
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100674910);
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100674911);
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100674912);
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100674913);
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100674914);
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100674915);
				}

				// Token: 0x0600633D RID: 25405 RVA: 0x001BA860 File Offset: 0x001B8A60
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 1419440, RefRangeEnd = 1419443, XrefRangeStart = 1419439, XrefRangeEnd = 1419440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Enumerator(Dictionary<TKey, TValue> dictionary)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600633E RID: 25406 RVA: 0x001BA8B0 File Offset: 0x001B8AB0
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600633F RID: 25407 RVA: 0x001BA8E8 File Offset: 0x001B8AE8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419443, XrefRangeEnd = 1419445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170019A4 RID: 6564
				// (get) Token: 0x06006340 RID: 25408 RVA: 0x001BA92C File Offset: 0x001B8B2C
				public unsafe TKey Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
					}
				}

				// Token: 0x170019A5 RID: 6565
				// (get) Token: 0x06006341 RID: 25409 RVA: 0x001BA96C File Offset: 0x001B8B6C
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419445, XrefRangeEnd = 1419448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06006342 RID: 25410 RVA: 0x001BA9B0 File Offset: 0x001B8BB0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419448, XrefRangeEnd = 1419449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06006343 RID: 25411 RVA: 0x000252C5 File Offset: 0x000234C5
				public Enumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06006344 RID: 25412 RVA: 0x000252CE File Offset: 0x000234CE
				public Enumerator()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr))
				{
				}

				// Token: 0x170019A0 RID: 6560
				// (get) Token: 0x06006345 RID: 25413 RVA: 0x001BA9E8 File Offset: 0x001B8BE8
				// (set) Token: 0x06006346 RID: 25414 RVA: 0x000252E0 File Offset: 0x000234E0
				public unsafe Dictionary<TKey, TValue> _dictionary
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr__dictionary);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr__dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170019A1 RID: 6561
				// (get) Token: 0x06006347 RID: 25415 RVA: 0x001BAA18 File Offset: 0x001B8C18
				// (set) Token: 0x06006348 RID: 25416 RVA: 0x000252FF File Offset: 0x000234FF
				public unsafe int _index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr__index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr__index)) = value;
					}
				}

				// Token: 0x170019A2 RID: 6562
				// (get) Token: 0x06006349 RID: 25417 RVA: 0x001BAA40 File Offset: 0x001B8C40
				// (set) Token: 0x0600634A RID: 25418 RVA: 0x0002531A File Offset: 0x0002351A
				public unsafe int _version
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr__version);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr__version)) = value;
					}
				}

				// Token: 0x170019A3 RID: 6563
				// (get) Token: 0x0600634B RID: 25419 RVA: 0x001BAA68 File Offset: 0x001B8C68
				// (set) Token: 0x0600634C RID: 25420 RVA: 0x001BAA90 File Offset: 0x001B8C90
				public unsafe TKey _currentKey
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr__currentKey);
						return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr__currentKey);
						Type typeFromHandle = typeof(TKey);
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

				// Token: 0x04005100 RID: 20736
				private static readonly IntPtr NativeFieldInfoPtr__dictionary;

				// Token: 0x04005101 RID: 20737
				private static readonly IntPtr NativeFieldInfoPtr__index;

				// Token: 0x04005102 RID: 20738
				private static readonly IntPtr NativeFieldInfoPtr__version;

				// Token: 0x04005103 RID: 20739
				private static readonly IntPtr NativeFieldInfoPtr__currentKey;

				// Token: 0x04005104 RID: 20740
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_0;

				// Token: 0x04005105 RID: 20741
				private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

				// Token: 0x04005106 RID: 20742
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x04005107 RID: 20743
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TKey_0;

				// Token: 0x04005108 RID: 20744
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04005109 RID: 20745
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
			}
		}

		// Token: 0x02000705 RID: 1797
		[Serializable]
		public sealed class ValueCollection : Object
		{
			// Token: 0x06005F9B RID: 24475 RVA: 0x001AFA40 File Offset: 0x001ADC40
			// Note: this type is marked as 'beforefieldinit'.
			static ValueCollection()
			{
				Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "ValueCollection"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr);
				Dictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr__dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, "_dictionary");
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674916);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674917);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674918);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674919);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674920);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Add_Private_Virtual_Final_New_Void_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674921);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Remove_Private_Virtual_Final_New_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674922);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674923);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Contains_Private_Virtual_Final_New_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674924);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674925);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674926);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674927);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674928);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674929);
			}

			// Token: 0x06005F9C RID: 24476 RVA: 0x001AFBE4 File Offset: 0x001ADDE4
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1419452, RefRangeEnd = 1419460, XrefRangeStart = 1419452, XrefRangeEnd = 1419460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueCollection(Dictionary<TKey, TValue> dictionary)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005F9D RID: 24477 RVA: 0x001AFC30 File Offset: 0x001ADE30
			[CallerCount(67)]
			[CachedScanResults(RefRangeStart = 1419548, RefRangeEnd = 1419615, XrefRangeStart = 1419547, XrefRangeEnd = 1419548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<TKey, TValue>.ValueCollection.Enumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Dictionary<TKey, TValue>.ValueCollection.Enumerator(intPtr);
			}

			// Token: 0x06005F9E RID: 24478 RVA: 0x001AFC68 File Offset: 0x001ADE68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419615, XrefRangeEnd = 1419621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CopyTo(Il2CppArrayBase<TValue> array, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018B7 RID: 6327
			// (get) Token: 0x06005F9F RID: 24479 RVA: 0x001AFCB8 File Offset: 0x001ADEB8
			public unsafe int Count
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1419469, RefRangeEnd = 1419470, XrefRangeStart = 1419469, XrefRangeEnd = 1419470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170018B8 RID: 6328
			// (get) Token: 0x06005FA0 RID: 24480 RVA: 0x001AFCF4 File Offset: 0x001ADEF4
			public unsafe bool System.Collections.Generic.ICollection<TValue>.IsReadOnly
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005FA1 RID: 24481 RVA: 0x001AFD30 File Offset: 0x001ADF30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419621, XrefRangeEnd = 1419622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_Generic_ICollection_TValue__Add(TValue item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TValue).IsValueType)
					{
						TValue tvalue = item;
						intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref item;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Add_Private_Virtual_Final_New_Void_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x06005FA2 RID: 24482 RVA: 0x001AFDA8 File Offset: 0x001ADFA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419622, XrefRangeEnd = 1419623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool System_Collections_Generic_ICollection_TValue__Remove(TValue item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TValue).IsValueType)
					{
						TValue tvalue = item;
						intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref item;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Remove_Private_Virtual_Final_New_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06005FA3 RID: 24483 RVA: 0x001AFE2C File Offset: 0x001AE02C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_Generic_ICollection_TValue__Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005FA4 RID: 24484 RVA: 0x001AFE60 File Offset: 0x001AE060
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419623, XrefRangeEnd = 1419625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool System_Collections_Generic_ICollection_TValue__Contains(TValue item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TValue).IsValueType)
					{
						TValue tvalue = item;
						intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref item;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Contains_Private_Virtual_Final_New_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06005FA5 RID: 24485 RVA: 0x001AFEE4 File Offset: 0x001AE0E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419625, XrefRangeEnd = 1419627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TValue> System_Collections_Generic_IEnumerable_TValue__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TValue>>(intPtr3) : null;
			}

			// Token: 0x06005FA6 RID: 24486 RVA: 0x001AFF24 File Offset: 0x001AE124
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005FA7 RID: 24487 RVA: 0x001AFF64 File Offset: 0x001AE164
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419627, XrefRangeEnd = 1419647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_ICollection_CopyTo(Array array, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018B9 RID: 6329
			// (get) Token: 0x06005FA8 RID: 24488 RVA: 0x001AFFB4 File Offset: 0x001AE1B4
			public unsafe bool System.Collections.ICollection.IsSynchronized
			{
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170018BA RID: 6330
			// (get) Token: 0x06005FA9 RID: 24489 RVA: 0x001AFFF0 File Offset: 0x001AE1F0
			public unsafe Object System.Collections.ICollection.SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419647, XrefRangeEnd = 1419727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005FAA RID: 24490 RVA: 0x00022F5C File Offset: 0x0002115C
			public ValueCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018B6 RID: 6326
			// (get) Token: 0x06005FAB RID: 24491 RVA: 0x001B0030 File Offset: 0x001AE230
			// (set) Token: 0x06005FAC RID: 24492 RVA: 0x00022F65 File Offset: 0x00021165
			public unsafe Dictionary<TKey, TValue> _dictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr__dictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr__dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004DB8 RID: 19896
			private static readonly IntPtr NativeFieldInfoPtr__dictionary;

			// Token: 0x04004DB9 RID: 19897
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_TKey_TValue_0;

			// Token: 0x04004DBA RID: 19898
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0;

			// Token: 0x04004DBB RID: 19899
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TValue_Int32_0;

			// Token: 0x04004DBC RID: 19900
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04004DBD RID: 19901
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04004DBE RID: 19902
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Add_Private_Virtual_Final_New_Void_TValue_0;

			// Token: 0x04004DBF RID: 19903
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Remove_Private_Virtual_Final_New_Boolean_TValue_0;

			// Token: 0x04004DC0 RID: 19904
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Clear_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004DC1 RID: 19905
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Contains_Private_Virtual_Final_New_Boolean_TValue_0;

			// Token: 0x04004DC2 RID: 19906
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TValue_0;

			// Token: 0x04004DC3 RID: 19907
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04004DC4 RID: 19908
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x04004DC5 RID: 19909
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04004DC6 RID: 19910
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x02000794 RID: 1940
			[Serializable]
			public sealed class Enumerator : ValueType
			{
				// Token: 0x0600634D RID: 25421 RVA: 0x001BAB38 File Offset: 0x001B8D38
				// Note: this type is marked as 'beforefieldinit'.
				static Enumerator()
				{
					Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr);
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr__dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, "_dictionary");
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, "_index");
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, "_version");
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr__currentValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, "_currentValue");
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100674930);
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100674931);
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100674932);
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100674933);
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100674934);
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100674935);
				}

				// Token: 0x0600634E RID: 25422 RVA: 0x001BAC78 File Offset: 0x001B8E78
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 1419537, RefRangeEnd = 1419540, XrefRangeStart = 1419536, XrefRangeEnd = 1419537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Enumerator(Dictionary<TKey, TValue> dictionary)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600634F RID: 25423 RVA: 0x001BACC8 File Offset: 0x001B8EC8
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06006350 RID: 25424 RVA: 0x001BAD00 File Offset: 0x001B8F00
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 1419542, RefRangeEnd = 1419545, XrefRangeStart = 1419540, XrefRangeEnd = 1419542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170019AA RID: 6570
				// (get) Token: 0x06006351 RID: 25425 RVA: 0x001BAD44 File Offset: 0x001B8F44
				public unsafe TValue Current
				{
					[CallerCount(10)]
					[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
					}
				}

				// Token: 0x170019AB RID: 6571
				// (get) Token: 0x06006352 RID: 25426 RVA: 0x001BAD84 File Offset: 0x001B8F84
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419545, XrefRangeEnd = 1419546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06006353 RID: 25427 RVA: 0x001BADC8 File Offset: 0x001B8FC8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419546, XrefRangeEnd = 1419547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06006354 RID: 25428 RVA: 0x00025335 File Offset: 0x00023535
				public Enumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06006355 RID: 25429 RVA: 0x0002533E File Offset: 0x0002353E
				public Enumerator()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr))
				{
				}

				// Token: 0x170019A6 RID: 6566
				// (get) Token: 0x06006356 RID: 25430 RVA: 0x001BAE00 File Offset: 0x001B9000
				// (set) Token: 0x06006357 RID: 25431 RVA: 0x00025350 File Offset: 0x00023550
				public unsafe Dictionary<TKey, TValue> _dictionary
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr__dictionary);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr__dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170019A7 RID: 6567
				// (get) Token: 0x06006358 RID: 25432 RVA: 0x001BAE30 File Offset: 0x001B9030
				// (set) Token: 0x06006359 RID: 25433 RVA: 0x0002536F File Offset: 0x0002356F
				public unsafe int _index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr__index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr__index)) = value;
					}
				}

				// Token: 0x170019A8 RID: 6568
				// (get) Token: 0x0600635A RID: 25434 RVA: 0x001BAE58 File Offset: 0x001B9058
				// (set) Token: 0x0600635B RID: 25435 RVA: 0x0002538A File Offset: 0x0002358A
				public unsafe int _version
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr__version);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr__version)) = value;
					}
				}

				// Token: 0x170019A9 RID: 6569
				// (get) Token: 0x0600635C RID: 25436 RVA: 0x001BAE80 File Offset: 0x001B9080
				// (set) Token: 0x0600635D RID: 25437 RVA: 0x001BAEA8 File Offset: 0x001B90A8
				public unsafe TValue _currentValue
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr__currentValue);
						return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr__currentValue);
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

				// Token: 0x0400510A RID: 20746
				private static readonly IntPtr NativeFieldInfoPtr__dictionary;

				// Token: 0x0400510B RID: 20747
				private static readonly IntPtr NativeFieldInfoPtr__index;

				// Token: 0x0400510C RID: 20748
				private static readonly IntPtr NativeFieldInfoPtr__version;

				// Token: 0x0400510D RID: 20749
				private static readonly IntPtr NativeFieldInfoPtr__currentValue;

				// Token: 0x0400510E RID: 20750
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_0;

				// Token: 0x0400510F RID: 20751
				private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

				// Token: 0x04005110 RID: 20752
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x04005111 RID: 20753
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TValue_0;

				// Token: 0x04005112 RID: 20754
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04005113 RID: 20755
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
			}
		}
	}
}
