using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections.Concurrent
{
	// Token: 0x020004D4 RID: 1236
	[Serializable]
	public class ConcurrentDictionary<TKey, TValue> : Object
	{
		// Token: 0x06004C2C RID: 19500 RVA: 0x0015FB74 File Offset: 0x0015DD74
		// Note: this type is marked as 'beforefieldinit'.
		static ConcurrentDictionary()
		{
			Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Concurrent", "ConcurrentDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr);
			ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__tables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "_tables");
			ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "_comparer");
			ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__growLockArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "_growLockArray");
			ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__budget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "_budget");
			ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__serializationArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "_serializationArray");
			ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__serializationConcurrencyLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "_serializationConcurrencyLevel");
			ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__serializationCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "_serializationCapacity");
			ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr_DefaultCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "DefaultCapacity");
			ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr_MaxLockNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "MaxLockNumber");
			ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr_s_isValueWriteAtomic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "s_isValueWriteAtomic");
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_IsValueWriteAtomic_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674596);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674597);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674598);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674599);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_InitializeFromCollection_Private_Void_IEnumerable_1_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674600);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674601);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Boolean_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674602);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryAdd_Public_Boolean_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674603);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674604);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryRemove_Public_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674605);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryRemoveInternal_Private_Boolean_TKey_byref_TValue_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674606);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674607);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValueInternal_Private_Boolean_TKey_Int32_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674608);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674609);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674610);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ToArray_Public_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674611);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyToPairs_Private_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674612);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyToEntries_Private_Void_Il2CppReferenceArray_1_DictionaryEntry_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674613);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyToObjects_Private_Void_Il2CppReferenceArray_1_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674614);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674615);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryAddInternal_Private_Boolean_TKey_Int32_TValue_Boolean_Boolean_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674616);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674617);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674618);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ThrowKeyNotFoundException_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674619);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ThrowKeyNullException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674620);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674621);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetCountInternal_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674622);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetOrAdd_Public_TValue_TKey_Func_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674623);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetOrAdd_Public_TValue_TKey_Func_3_TKey_TArg_TValue_TArg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674624);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetOrAdd_Public_TValue_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674625);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674626);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674627);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674628);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674629);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674630);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674631);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674632);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674633);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674634);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674635);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674636);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674637);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674638);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674639);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674640);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674641);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674642);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674643);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674644);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674645);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674646);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674647);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674648);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674649);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GrowTable_Private_Void_Tables_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674650);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetBucket_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674651);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetBucketAndLockNo_Private_Static_Void_Int32_byref_Int32_byref_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674652);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_DefaultConcurrencyLevel_Private_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674653);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_AcquireAllLocks_Private_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674654);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_AcquireLocks_Private_Void_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674655);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ReleaseLocks_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674656);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetKeys_Private_ReadOnlyCollection_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674657);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetValues_Private_ReadOnlyCollection_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674658);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674659);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_OnSerialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674660);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100674661);
		}

		// Token: 0x06004C2D RID: 19501 RVA: 0x001601E4 File Offset: 0x0015E3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417773, XrefRangeEnd = 1417783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValueWriteAtomic()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_IsValueWriteAtomic_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004C2E RID: 19502 RVA: 0x00160214 File Offset: 0x0015E414
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1417790, RefRangeEnd = 1417791, XrefRangeStart = 1417783, XrefRangeEnd = 1417790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConcurrentDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C2F RID: 19503 RVA: 0x00160250 File Offset: 0x0015E450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417791, XrefRangeEnd = 1417792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConcurrentDictionary(int concurrencyLevel, int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref concurrencyLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C30 RID: 19504 RVA: 0x001602A8 File Offset: 0x0015E4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417792, XrefRangeEnd = 1417799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConcurrentDictionary(IEqualityComparer<TKey> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C31 RID: 19505 RVA: 0x001602F4 File Offset: 0x0015E4F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1417819, RefRangeEnd = 1417820, XrefRangeStart = 1417799, XrefRangeEnd = 1417819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeFromCollection(IEnumerable<KeyValuePair<TKey, TValue>> collection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_InitializeFromCollection_Private_Void_IEnumerable_1_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C32 RID: 19506 RVA: 0x00160338 File Offset: 0x0015E538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417820, XrefRangeEnd = 1417821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConcurrentDictionary(int concurrencyLevel, int capacity, IEqualityComparer<TKey> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref concurrencyLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C33 RID: 19507 RVA: 0x001603A0 File Offset: 0x0015E5A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1417854, RefRangeEnd = 1417858, XrefRangeStart = 1417821, XrefRangeEnd = 1417854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConcurrentDictionary(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<TKey> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref concurrencyLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref growLockArray;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Boolean_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C34 RID: 19508 RVA: 0x00160418 File Offset: 0x0015E618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417858, XrefRangeEnd = 1417861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryAdd_Public_Boolean_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06004C35 RID: 19509 RVA: 0x001604E4 File Offset: 0x0015E6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417861, XrefRangeEnd = 1417862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004C36 RID: 19510 RVA: 0x00160568 File Offset: 0x0015E768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417862, XrefRangeEnd = 1417863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryRemove(TKey key, out TValue value)
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
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryRemove_Public_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06004C37 RID: 19511 RVA: 0x0016063C File Offset: 0x0015E83C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1417888, RefRangeEnd = 1417892, XrefRangeStart = 1417863, XrefRangeEnd = 1417888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchValue;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = oldValue;
				intPtr4 = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref oldValue;
			}
			ptr4 = intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryRemoveInternal_Private_Boolean_TKey_byref_TValue_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr7 = intPtr2;
				value = ((intPtr7 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr7, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr5);
		}

		// Token: 0x06004C38 RID: 19512 RVA: 0x00160768 File Offset: 0x0015E968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1417895, RefRangeEnd = 1417896, XrefRangeStart = 1417892, XrefRangeEnd = 1417895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06004C39 RID: 19513 RVA: 0x0016083C File Offset: 0x0015EA3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1417903, RefRangeEnd = 1417906, XrefRangeStart = 1417896, XrefRangeEnd = 1417903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValueInternal(TKey key, int hashcode, out TValue value)
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashcode;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValueInternal_Private_Boolean_TKey_Int32_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06004C3A RID: 19514 RVA: 0x0016091C File Offset: 0x0015EB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417906, XrefRangeEnd = 1417927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C3B RID: 19515 RVA: 0x00160950 File Offset: 0x0015EB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417927, XrefRangeEnd = 1417936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C3C RID: 19516 RVA: 0x001609A0 File Offset: 0x0015EBA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1417953, RefRangeEnd = 1417954, XrefRangeStart = 1417936, XrefRangeEnd = 1417953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<KeyValuePair<TKey, TValue>> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ToArray_Public_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x06004C3D RID: 19517 RVA: 0x001609E0 File Offset: 0x0015EBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417954, XrefRangeEnd = 1417959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyToPairs(Il2CppReferenceArray<KeyValuePair<TKey, TValue>> array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyToPairs_Private_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C3E RID: 19518 RVA: 0x00160A30 File Offset: 0x0015EC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417959, XrefRangeEnd = 1417965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyToEntries(Il2CppReferenceArray<DictionaryEntry> array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyToEntries_Private_Void_Il2CppReferenceArray_1_DictionaryEntry_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C3F RID: 19519 RVA: 0x00160A80 File Offset: 0x0015EC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417965, XrefRangeEnd = 1417972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyToObjects(Il2CppReferenceArray<Object> array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyToObjects_Private_Void_Il2CppReferenceArray_1_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C40 RID: 19520 RVA: 0x00160AD0 File Offset: 0x0015ECD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1417976, RefRangeEnd = 1417977, XrefRangeStart = 1417972, XrefRangeEnd = 1417976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x06004C41 RID: 19521 RVA: 0x00160B10 File Offset: 0x0015ED10
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1418003, RefRangeEnd = 1418010, XrefRangeStart = 1417977, XrefRangeEnd = 1418003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashcode;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateIfExists;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acquireLock;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			IntPtr intPtr4;
			if (!typeof(TValue).IsValueType)
			{
				intPtr3 = 0;
				intPtr4 = &intPtr3;
			}
			else
			{
				intPtr4 = ref resultingValue;
			}
			ptr4 = intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryAddInternal_Private_Boolean_TKey_Int32_TValue_Boolean_Boolean_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr7 = intPtr3;
				resultingValue = ((intPtr7 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr7, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr5);
		}

		// Token: 0x1700139E RID: 5022
		public unsafe virtual TValue this[TKey key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418010, XrefRangeEnd = 1418011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418011, XrefRangeEnd = 1418014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			}
		}

		// Token: 0x06004C44 RID: 19524 RVA: 0x00160D98 File Offset: 0x0015EF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418014, XrefRangeEnd = 1418022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowKeyNotFoundException(Object key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ThrowKeyNotFoundException_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C45 RID: 19525 RVA: 0x00160DD0 File Offset: 0x0015EFD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1418044, RefRangeEnd = 1418046, XrefRangeStart = 1418022, XrefRangeEnd = 1418044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowKeyNullException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ThrowKeyNullException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x06004C46 RID: 19526 RVA: 0x00160DF8 File Offset: 0x0015EFF8
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418046, XrefRangeEnd = 1418051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004C47 RID: 19527 RVA: 0x00160E34 File Offset: 0x0015F034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418051, XrefRangeEnd = 1418057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCountInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetCountInternal_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004C48 RID: 19528 RVA: 0x00160E70 File Offset: 0x0015F070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1418061, RefRangeEnd = 1418062, XrefRangeStart = 1418057, XrefRangeEnd = 1418061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueFactory);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetOrAdd_Public_TValue_TKey_Func_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
		}

		// Token: 0x06004C49 RID: 19529 RVA: 0x00160F04 File Offset: 0x0015F104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418062, XrefRangeEnd = 1418070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public TValue GetOrAdd<TArg>(TKey key, Func<TKey, TArg, TValue> valueFactory, TArg factoryArgument)
		{
			/*
An exception occurred when decompiling this method (06004C49)

ICSharpCode.Decompiler.DecompilerException: Error decompiling TValue Il2CppSystem.Collections.Concurrent.ConcurrentDictionary`2::GetOrAdd<TArg>(TKey,Il2CppSystem.Func`3<TKey,TArg,TValue>,TArg)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 874
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
		}

		// Token: 0x06004C4A RID: 19530 RVA: 0x00160FE0 File Offset: 0x0015F1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418070, XrefRangeEnd = 1418074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TValue GetOrAdd(TKey key, TValue value)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetOrAdd_Public_TValue_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return IL2CPP.PointerToValueGeneric<TValue>(intPtr3, false, true);
		}

		// Token: 0x06004C4B RID: 19531 RVA: 0x001610A8 File Offset: 0x0015F2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418074, XrefRangeEnd = 1418079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_TKey_TValue_0(TKey key, TValue value)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x06004C4C RID: 19532 RVA: 0x00161168 File Offset: 0x0015F368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418079, XrefRangeEnd = 1418080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_TKey_0(TKey key)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x06004C4D RID: 19533 RVA: 0x001611EC File Offset: 0x0015F3EC
		public unsafe virtual ICollection<TKey> Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418080, XrefRangeEnd = 1418081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<TKey>>(intPtr3) : null;
			}
		}

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x06004C4E RID: 19534 RVA: 0x0016122C File Offset: 0x0015F42C
		public unsafe virtual IEnumerable<TKey> prop_IEnumerable_1_TKey_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TKey>>(intPtr3) : null;
			}
		}

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x06004C4F RID: 19535 RVA: 0x0016126C File Offset: 0x0015F46C
		public unsafe virtual ICollection<TValue> Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418081, XrefRangeEnd = 1418121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<TValue>>(intPtr3) : null;
			}
		}

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x06004C50 RID: 19536 RVA: 0x001612AC File Offset: 0x0015F4AC
		public unsafe virtual IEnumerable<TValue> prop_IEnumerable_1_TValue_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TValue>>(intPtr3) : null;
			}
		}

		// Token: 0x06004C51 RID: 19537 RVA: 0x001612EC File Offset: 0x0015F4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418121, XrefRangeEnd = 1418123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C52 RID: 19538 RVA: 0x00161334 File Offset: 0x0015F534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418123, XrefRangeEnd = 1418125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x06004C53 RID: 19539 RVA: 0x00161388 File Offset: 0x0015F588
		public unsafe virtual bool prop_Boolean_0
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004C54 RID: 19540 RVA: 0x001613C4 File Offset: 0x0015F5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418125, XrefRangeEnd = 1418126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004C55 RID: 19541 RVA: 0x00161418 File Offset: 0x0015F618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418126, XrefRangeEnd = 1418130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004C56 RID: 19542 RVA: 0x00161458 File Offset: 0x0015F658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418130, XrefRangeEnd = 1418139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C57 RID: 19543 RVA: 0x001614AC File Offset: 0x0015F6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418139, XrefRangeEnd = 1418141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IDictionary_Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004C58 RID: 19544 RVA: 0x001614FC File Offset: 0x0015F6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418141, XrefRangeEnd = 1418144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator System_Collections_IDictionary_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x06004C59 RID: 19545 RVA: 0x0016153C File Offset: 0x0015F73C
		public unsafe virtual bool System.Collections.IDictionary.IsFixedSize
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x06004C5A RID: 19546 RVA: 0x00161578 File Offset: 0x0015F778
		public unsafe virtual bool System.Collections.IDictionary.IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x06004C5B RID: 19547 RVA: 0x001615B4 File Offset: 0x0015F7B4
		public unsafe virtual ICollection System.Collections.IDictionary.Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x06004C5C RID: 19548 RVA: 0x001615F4 File Offset: 0x0015F7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418144, XrefRangeEnd = 1418149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IDictionary_Remove(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x06004C5D RID: 19549 RVA: 0x00161638 File Offset: 0x0015F838
		public unsafe virtual ICollection System.Collections.IDictionary.Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x06004C5E RID: 19550 RVA: 0x00161678 File Offset: 0x0015F878
		// (set) Token: 0x06004C5F RID: 19551 RVA: 0x001616C8 File Offset: 0x0015F8C8
		public unsafe virtual Object System.Collections.IDictionary.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418149, XrefRangeEnd = 1418154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418154, XrefRangeEnd = 1418166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C60 RID: 19552 RVA: 0x0016171C File Offset: 0x0015F91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418166, XrefRangeEnd = 1418202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x06004C61 RID: 19553 RVA: 0x0016176C File Offset: 0x0015F96C
		public unsafe virtual bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x06004C62 RID: 19554 RVA: 0x001617A8 File Offset: 0x0015F9A8
		public unsafe virtual Object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004C63 RID: 19555 RVA: 0x001617E8 File Offset: 0x0015F9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418202, XrefRangeEnd = 1418251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrowTable(ConcurrentDictionary<TKey, TValue>.Tables tables)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tables);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GrowTable_Private_Void_Tables_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C64 RID: 19556 RVA: 0x0016182C File Offset: 0x0015FA2C
		[CallerCount(0)]
		public unsafe static int GetBucket(int hashcode, int bucketCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bucketCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetBucket_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004C65 RID: 19557 RVA: 0x00161878 File Offset: 0x0015FA78
		[CallerCount(0)]
		public unsafe static void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bucketNo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockNo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bucketCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetBucketAndLockNo_Private_Static_Void_Int32_byref_Int32_byref_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x06004C66 RID: 19558 RVA: 0x001618E4 File Offset: 0x0015FAE4
		public unsafe static int DefaultConcurrencyLevel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418251, XrefRangeEnd = 1418267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_DefaultConcurrencyLevel_Private_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004C67 RID: 19559 RVA: 0x00161914 File Offset: 0x0015FB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418267, XrefRangeEnd = 1418280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcquireAllLocks(ref int locksAcquired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &locksAcquired;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_AcquireAllLocks_Private_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C68 RID: 19560 RVA: 0x00161954 File Offset: 0x0015FB54
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1418284, RefRangeEnd = 1418288, XrefRangeStart = 1418280, XrefRangeEnd = 1418284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromInclusive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toExclusive;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &locksAcquired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_AcquireLocks_Private_Void_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C69 RID: 19561 RVA: 0x001619B0 File Offset: 0x0015FBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418288, XrefRangeEnd = 1418290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseLocks(int fromInclusive, int toExclusive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromInclusive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toExclusive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ReleaseLocks_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x001619FC File Offset: 0x0015FBFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1418307, RefRangeEnd = 1418310, XrefRangeStart = 1418290, XrefRangeEnd = 1418307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyCollection<TKey> GetKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetKeys_Private_ReadOnlyCollection_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<TKey>>(intPtr3) : null;
		}

		// Token: 0x06004C6B RID: 19563 RVA: 0x00161A3C File Offset: 0x0015FC3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1418327, RefRangeEnd = 1418330, XrefRangeStart = 1418310, XrefRangeEnd = 1418327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyCollection<TValue> GetValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetValues_Private_ReadOnlyCollection_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<TValue>>(intPtr3) : null;
		}

		// Token: 0x06004C6C RID: 19564 RVA: 0x00161A7C File Offset: 0x0015FC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418330, XrefRangeEnd = 1418333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerializing(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C6D RID: 19565 RVA: 0x00161AC4 File Offset: 0x0015FCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418333, XrefRangeEnd = 1418337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerialized(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_OnSerialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C6E RID: 19566 RVA: 0x00161B0C File Offset: 0x0015FD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418337, XrefRangeEnd = 1418363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C6F RID: 19567 RVA: 0x0001BD05 File Offset: 0x00019F05
		public ConcurrentDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x06004C70 RID: 19568 RVA: 0x00161B54 File Offset: 0x0015FD54
		// (set) Token: 0x06004C71 RID: 19569 RVA: 0x0001BD0E File Offset: 0x00019F0E
		public unsafe ConcurrentDictionary<TKey, TValue>.Tables _tables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__tables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<TKey, TValue>.Tables>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__tables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x06004C72 RID: 19570 RVA: 0x00161B84 File Offset: 0x0015FD84
		// (set) Token: 0x06004C73 RID: 19571 RVA: 0x0001BD2D File Offset: 0x00019F2D
		public unsafe IEqualityComparer<TKey> _comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x06004C74 RID: 19572 RVA: 0x00161BB4 File Offset: 0x0015FDB4
		// (set) Token: 0x06004C75 RID: 19573 RVA: 0x0001BD4C File Offset: 0x00019F4C
		public unsafe bool _growLockArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__growLockArray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__growLockArray)) = value;
			}
		}

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x06004C76 RID: 19574 RVA: 0x00161BDC File Offset: 0x0015FDDC
		// (set) Token: 0x06004C77 RID: 19575 RVA: 0x0001BD67 File Offset: 0x00019F67
		public unsafe int _budget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__budget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__budget)) = value;
			}
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x06004C78 RID: 19576 RVA: 0x00161C04 File Offset: 0x0015FE04
		// (set) Token: 0x06004C79 RID: 19577 RVA: 0x0001BD82 File Offset: 0x00019F82
		public unsafe Il2CppReferenceArray<KeyValuePair<TKey, TValue>> _serializationArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__serializationArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<TKey, TValue>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__serializationArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x06004C7A RID: 19578 RVA: 0x00161C34 File Offset: 0x0015FE34
		// (set) Token: 0x06004C7B RID: 19579 RVA: 0x0001BDA1 File Offset: 0x00019FA1
		public unsafe int _serializationConcurrencyLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__serializationConcurrencyLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__serializationConcurrencyLevel)) = value;
			}
		}

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x06004C7C RID: 19580 RVA: 0x00161C5C File Offset: 0x0015FE5C
		// (set) Token: 0x06004C7D RID: 19581 RVA: 0x0001BDBC File Offset: 0x00019FBC
		public unsafe int _serializationCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__serializationCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__serializationCapacity)) = value;
			}
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x06004C7E RID: 19582 RVA: 0x00161C84 File Offset: 0x0015FE84
		// (set) Token: 0x06004C7F RID: 19583 RVA: 0x0001BDD7 File Offset: 0x00019FD7
		public unsafe static int DefaultCapacity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr_DefaultCapacity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr_DefaultCapacity, (void*)(&value));
			}
		}

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x06004C80 RID: 19584 RVA: 0x00161CA0 File Offset: 0x0015FEA0
		// (set) Token: 0x06004C81 RID: 19585 RVA: 0x0001BDE5 File Offset: 0x00019FE5
		public unsafe static int MaxLockNumber
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr_MaxLockNumber, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr_MaxLockNumber, (void*)(&value));
			}
		}

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x06004C82 RID: 19586 RVA: 0x00161CBC File Offset: 0x0015FEBC
		// (set) Token: 0x06004C83 RID: 19587 RVA: 0x0001BDF3 File Offset: 0x00019FF3
		public unsafe static bool s_isValueWriteAtomic
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr_s_isValueWriteAtomic, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr_s_isValueWriteAtomic, (void*)(&value));
			}
		}

		// Token: 0x04003E4F RID: 15951
		private static readonly IntPtr NativeFieldInfoPtr__tables;

		// Token: 0x04003E50 RID: 15952
		private static readonly IntPtr NativeFieldInfoPtr__comparer;

		// Token: 0x04003E51 RID: 15953
		private static readonly IntPtr NativeFieldInfoPtr__growLockArray;

		// Token: 0x04003E52 RID: 15954
		private static readonly IntPtr NativeFieldInfoPtr__budget;

		// Token: 0x04003E53 RID: 15955
		private static readonly IntPtr NativeFieldInfoPtr__serializationArray;

		// Token: 0x04003E54 RID: 15956
		private static readonly IntPtr NativeFieldInfoPtr__serializationConcurrencyLevel;

		// Token: 0x04003E55 RID: 15957
		private static readonly IntPtr NativeFieldInfoPtr__serializationCapacity;

		// Token: 0x04003E56 RID: 15958
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCapacity;

		// Token: 0x04003E57 RID: 15959
		private static readonly IntPtr NativeFieldInfoPtr_MaxLockNumber;

		// Token: 0x04003E58 RID: 15960
		private static readonly IntPtr NativeFieldInfoPtr_s_isValueWriteAtomic;

		// Token: 0x04003E59 RID: 15961
		private static readonly IntPtr NativeMethodInfoPtr_IsValueWriteAtomic_Private_Static_Boolean_0;

		// Token: 0x04003E5A RID: 15962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003E5B RID: 15963
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04003E5C RID: 15964
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TKey_0;

		// Token: 0x04003E5D RID: 15965
		private static readonly IntPtr NativeMethodInfoPtr_InitializeFromCollection_Private_Void_IEnumerable_1_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04003E5E RID: 15966
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_IEqualityComparer_1_TKey_0;

		// Token: 0x04003E5F RID: 15967
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Boolean_IEqualityComparer_1_TKey_0;

		// Token: 0x04003E60 RID: 15968
		private static readonly IntPtr NativeMethodInfoPtr_TryAdd_Public_Boolean_TKey_TValue_0;

		// Token: 0x04003E61 RID: 15969
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x04003E62 RID: 15970
		private static readonly IntPtr NativeMethodInfoPtr_TryRemove_Public_Boolean_TKey_byref_TValue_0;

		// Token: 0x04003E63 RID: 15971
		private static readonly IntPtr NativeMethodInfoPtr_TryRemoveInternal_Private_Boolean_TKey_byref_TValue_Boolean_TValue_0;

		// Token: 0x04003E64 RID: 15972
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0;

		// Token: 0x04003E65 RID: 15973
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValueInternal_Private_Boolean_TKey_Int32_byref_TValue_0;

		// Token: 0x04003E66 RID: 15974
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003E67 RID: 15975
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x04003E68 RID: 15976
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04003E69 RID: 15977
		private static readonly IntPtr NativeMethodInfoPtr_CopyToPairs_Private_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x04003E6A RID: 15978
		private static readonly IntPtr NativeMethodInfoPtr_CopyToEntries_Private_Void_Il2CppReferenceArray_1_DictionaryEntry_Int32_0;

		// Token: 0x04003E6B RID: 15979
		private static readonly IntPtr NativeMethodInfoPtr_CopyToObjects_Private_Void_Il2CppReferenceArray_1_Object_Int32_0;

		// Token: 0x04003E6C RID: 15980
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04003E6D RID: 15981
		private static readonly IntPtr NativeMethodInfoPtr_TryAddInternal_Private_Boolean_TKey_Int32_TValue_Boolean_Boolean_byref_TValue_0;

		// Token: 0x04003E6E RID: 15982
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0;

		// Token: 0x04003E6F RID: 15983
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0;

		// Token: 0x04003E70 RID: 15984
		private static readonly IntPtr NativeMethodInfoPtr_ThrowKeyNotFoundException_Private_Static_Void_Object_0;

		// Token: 0x04003E71 RID: 15985
		private static readonly IntPtr NativeMethodInfoPtr_ThrowKeyNullException_Private_Static_Void_0;

		// Token: 0x04003E72 RID: 15986
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04003E73 RID: 15987
		private static readonly IntPtr NativeMethodInfoPtr_GetCountInternal_Private_Int32_0;

		// Token: 0x04003E74 RID: 15988
		private static readonly IntPtr NativeMethodInfoPtr_GetOrAdd_Public_TValue_TKey_Func_2_TKey_TValue_0;

		// Token: 0x04003E75 RID: 15989
		private static readonly IntPtr NativeMethodInfoPtr_GetOrAdd_Public_TValue_TKey_Func_3_TKey_TArg_TValue_TArg_0;

		// Token: 0x04003E76 RID: 15990
		private static readonly IntPtr NativeMethodInfoPtr_GetOrAdd_Public_TValue_TKey_TValue_0;

		// Token: 0x04003E77 RID: 15991
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_TKey_TValue_0;

		// Token: 0x04003E78 RID: 15992
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x04003E79 RID: 15993
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_TKey_0;

		// Token: 0x04003E7A RID: 15994
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TKey_0;

		// Token: 0x04003E7B RID: 15995
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_TValue_0;

		// Token: 0x04003E7C RID: 15996
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TValue_0;

		// Token: 0x04003E7D RID: 15997
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04003E7E RID: 15998
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04003E7F RID: 15999
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003E80 RID: 16000
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1;

		// Token: 0x04003E81 RID: 16001
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04003E82 RID: 16002
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0;

		// Token: 0x04003E83 RID: 16003
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x04003E84 RID: 16004
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x04003E85 RID: 16005
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x04003E86 RID: 16006
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x04003E87 RID: 16007
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04003E88 RID: 16008
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04003E89 RID: 16009
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04003E8A RID: 16010
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0;

		// Token: 0x04003E8B RID: 16011
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0;

		// Token: 0x04003E8C RID: 16012
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04003E8D RID: 16013
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x04003E8E RID: 16014
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04003E8F RID: 16015
		private static readonly IntPtr NativeMethodInfoPtr_GrowTable_Private_Void_Tables_TKey_TValue_0;

		// Token: 0x04003E90 RID: 16016
		private static readonly IntPtr NativeMethodInfoPtr_GetBucket_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x04003E91 RID: 16017
		private static readonly IntPtr NativeMethodInfoPtr_GetBucketAndLockNo_Private_Static_Void_Int32_byref_Int32_byref_Int32_Int32_Int32_0;

		// Token: 0x04003E92 RID: 16018
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultConcurrencyLevel_Private_Static_get_Int32_0;

		// Token: 0x04003E93 RID: 16019
		private static readonly IntPtr NativeMethodInfoPtr_AcquireAllLocks_Private_Void_byref_Int32_0;

		// Token: 0x04003E94 RID: 16020
		private static readonly IntPtr NativeMethodInfoPtr_AcquireLocks_Private_Void_Int32_Int32_byref_Int32_0;

		// Token: 0x04003E95 RID: 16021
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseLocks_Private_Void_Int32_Int32_0;

		// Token: 0x04003E96 RID: 16022
		private static readonly IntPtr NativeMethodInfoPtr_GetKeys_Private_ReadOnlyCollection_1_TKey_0;

		// Token: 0x04003E97 RID: 16023
		private static readonly IntPtr NativeMethodInfoPtr_GetValues_Private_ReadOnlyCollection_1_TValue_0;

		// Token: 0x04003E98 RID: 16024
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0;

		// Token: 0x04003E99 RID: 16025
		private static readonly IntPtr NativeMethodInfoPtr_OnSerialized_Private_Void_StreamingContext_0;

		// Token: 0x04003E9A RID: 16026
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x020006F9 RID: 1785
		public sealed class Tables : Object
		{
			// Token: 0x06005EF9 RID: 24313 RVA: 0x001ACF10 File Offset: 0x001AB110
			// Note: this type is marked as 'beforefieldinit'.
			static Tables()
			{
				Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Tables>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "Tables"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Tables>.NativeClassPtr);
				ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__buckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Tables>.NativeClassPtr, "_buckets");
				ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__locks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Tables>.NativeClassPtr, "_locks");
				ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__countPerLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Tables>.NativeClassPtr, "_countPerLock");
				ConcurrentDictionary<TKey, TValue>.Tables.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Node_TKey_TValue_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Tables>.NativeClassPtr, 100674663);
			}

			// Token: 0x06005EFA RID: 24314 RVA: 0x001ACFD8 File Offset: 0x001AB1D8
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1417702, RefRangeEnd = 1417706, XrefRangeStart = 1417697, XrefRangeEnd = 1417702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Tables(Il2CppReferenceArray<ConcurrentDictionary<TKey, TValue>.Node> buckets, Il2CppReferenceArray<Object> locks, Il2CppStructArray<int> countPerLock)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Tables>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buckets);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locks);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(countPerLock);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.Tables.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Node_TKey_TValue_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005EFB RID: 24315 RVA: 0x00022B8C File Offset: 0x00020D8C
			public Tables(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700187B RID: 6267
			// (get) Token: 0x06005EFC RID: 24316 RVA: 0x001AD048 File Offset: 0x001AB248
			// (set) Token: 0x06005EFD RID: 24317 RVA: 0x00022B95 File Offset: 0x00020D95
			public unsafe Il2CppReferenceArray<ConcurrentDictionary<TKey, TValue>.Node> _buckets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__buckets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ConcurrentDictionary<TKey, TValue>.Node>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__buckets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700187C RID: 6268
			// (get) Token: 0x06005EFE RID: 24318 RVA: 0x001AD078 File Offset: 0x001AB278
			// (set) Token: 0x06005EFF RID: 24319 RVA: 0x00022BB4 File Offset: 0x00020DB4
			public unsafe Il2CppReferenceArray<Object> _locks
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__locks);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__locks), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700187D RID: 6269
			// (get) Token: 0x06005F00 RID: 24320 RVA: 0x001AD0A8 File Offset: 0x001AB2A8
			// (set) Token: 0x06005F01 RID: 24321 RVA: 0x00022BD3 File Offset: 0x00020DD3
			public unsafe Il2CppStructArray<int> _countPerLock
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__countPerLock);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__countPerLock), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004D4D RID: 19789
			private static readonly IntPtr NativeFieldInfoPtr__buckets;

			// Token: 0x04004D4E RID: 19790
			private static readonly IntPtr NativeFieldInfoPtr__locks;

			// Token: 0x04004D4F RID: 19791
			private static readonly IntPtr NativeFieldInfoPtr__countPerLock;

			// Token: 0x04004D50 RID: 19792
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Node_TKey_TValue_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_0;
		}

		// Token: 0x020006FA RID: 1786
		[Serializable]
		public sealed class Node : Object
		{
			// Token: 0x06005F02 RID: 24322 RVA: 0x001AD0D8 File Offset: 0x001AB2D8
			// Note: this type is marked as 'beforefieldinit'.
			static Node()
			{
				Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "Node"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr);
				ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr, "_key");
				ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr, "_value");
				ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr, "_next");
				ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__hashcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr, "_hashcode");
				ConcurrentDictionary<TKey, TValue>.Node.NativeMethodInfoPtr__ctor_Internal_Void_TKey_TValue_Int32_Node_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr, 100674664);
			}

			// Token: 0x06005F03 RID: 24323 RVA: 0x001AD1B4 File Offset: 0x001AB3B4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1417711, RefRangeEnd = 1417713, XrefRangeStart = 1417706, XrefRangeEnd = 1417711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Node(TKey key, TValue value, int hashcode, ConcurrentDictionary<TKey, TValue>.Node next)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
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
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashcode;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.Node.NativeMethodInfoPtr__ctor_Internal_Void_TKey_TValue_Int32_Node_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			}

			// Token: 0x06005F04 RID: 24324 RVA: 0x00022BF2 File Offset: 0x00020DF2
			public Node(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700187E RID: 6270
			// (get) Token: 0x06005F05 RID: 24325 RVA: 0x001AD2A0 File Offset: 0x001AB4A0
			// (set) Token: 0x06005F06 RID: 24326 RVA: 0x001AD2C8 File Offset: 0x001AB4C8
			public unsafe TKey _key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__key);
					return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__key);
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

			// Token: 0x1700187F RID: 6271
			// (get) Token: 0x06005F07 RID: 24327 RVA: 0x001AD370 File Offset: 0x001AB570
			// (set) Token: 0x06005F08 RID: 24328 RVA: 0x001AD398 File Offset: 0x001AB598
			public unsafe TValue _value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__value);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__value);
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

			// Token: 0x17001880 RID: 6272
			// (get) Token: 0x06005F09 RID: 24329 RVA: 0x001AD440 File Offset: 0x001AB640
			// (set) Token: 0x06005F0A RID: 24330 RVA: 0x00022BFB File Offset: 0x00020DFB
			public unsafe ConcurrentDictionary<TKey, TValue>.Node _next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<TKey, TValue>.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001881 RID: 6273
			// (get) Token: 0x06005F0B RID: 24331 RVA: 0x001AD470 File Offset: 0x001AB670
			// (set) Token: 0x06005F0C RID: 24332 RVA: 0x00022C1A File Offset: 0x00020E1A
			public unsafe int _hashcode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__hashcode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__hashcode)) = value;
				}
			}

			// Token: 0x04004D51 RID: 19793
			private static readonly IntPtr NativeFieldInfoPtr__key;

			// Token: 0x04004D52 RID: 19794
			private static readonly IntPtr NativeFieldInfoPtr__value;

			// Token: 0x04004D53 RID: 19795
			private static readonly IntPtr NativeFieldInfoPtr__next;

			// Token: 0x04004D54 RID: 19796
			private static readonly IntPtr NativeFieldInfoPtr__hashcode;

			// Token: 0x04004D55 RID: 19797
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TKey_TValue_Int32_Node_TKey_TValue_0;
		}

		// Token: 0x020006FB RID: 1787
		[Serializable]
		public sealed class DictionaryEnumerator : Object
		{
			// Token: 0x06005F0D RID: 24333 RVA: 0x001AD498 File Offset: 0x001AB698
			// Note: this type is marked as 'beforefieldinit'.
			static DictionaryEnumerator()
			{
				Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "DictionaryEnumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr);
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeFieldInfoPtr__enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, "_enumerator");
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ConcurrentDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100674665);
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100674666);
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100674667);
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100674668);
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100674669);
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100674670);
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100674671);
			}

			// Token: 0x06005F0E RID: 24334 RVA: 0x001AD5B0 File Offset: 0x001AB7B0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1417725, RefRangeEnd = 1417726, XrefRangeStart = 1417713, XrefRangeEnd = 1417725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictionaryEnumerator(ConcurrentDictionary<TKey, TValue> dictionary)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ConcurrentDictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001883 RID: 6275
			// (get) Token: 0x06005F0F RID: 24335 RVA: 0x001AD5FC File Offset: 0x001AB7FC
			public unsafe DictionaryEntry Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417726, XrefRangeEnd = 1417732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x17001884 RID: 6276
			// (get) Token: 0x06005F10 RID: 24336 RVA: 0x001AD634 File Offset: 0x001AB834
			public unsafe Object Key
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417732, XrefRangeEnd = 1417735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001885 RID: 6277
			// (get) Token: 0x06005F11 RID: 24337 RVA: 0x001AD674 File Offset: 0x001AB874
			public unsafe Object Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417735, XrefRangeEnd = 1417737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001886 RID: 6278
			// (get) Token: 0x06005F12 RID: 24338 RVA: 0x001AD6B4 File Offset: 0x001AB8B4
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417737, XrefRangeEnd = 1417746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005F13 RID: 24339 RVA: 0x001AD6F4 File Offset: 0x001AB8F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417746, XrefRangeEnd = 1417754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005F14 RID: 24340 RVA: 0x001AD730 File Offset: 0x001AB930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417754, XrefRangeEnd = 1417762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005F15 RID: 24341 RVA: 0x00022C35 File Offset: 0x00020E35
			public DictionaryEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001882 RID: 6274
			// (get) Token: 0x06005F16 RID: 24342 RVA: 0x001AD764 File Offset: 0x001AB964
			// (set) Token: 0x06005F17 RID: 24343 RVA: 0x00022C3E File Offset: 0x00020E3E
			public unsafe IEnumerator<KeyValuePair<TKey, TValue>> _enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeFieldInfoPtr__enumerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TKey, TValue>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeFieldInfoPtr__enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004D56 RID: 19798
			private static readonly IntPtr NativeFieldInfoPtr__enumerator;

			// Token: 0x04004D57 RID: 19799
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ConcurrentDictionary_2_TKey_TValue_0;

			// Token: 0x04004D58 RID: 19800
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x04004D59 RID: 19801
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004D5A RID: 19802
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004D5B RID: 19803
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004D5C RID: 19804
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004D5D RID: 19805
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x020006FC RID: 1788
		[ObfuscatedName("System.Collections.Concurrent.ConcurrentDictionary`2+<GetEnumerator>d__35")]
		public sealed class _GetEnumerator_d__35 : Object
		{
			// Token: 0x06005F18 RID: 24344 RVA: 0x001AD794 File Offset: 0x001AB994
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__35()
			{
				Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "<GetEnumerator>d__35"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35>.NativeClassPtr);
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35>.NativeClassPtr, "<>1__state");
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35>.NativeClassPtr, "<>2__current");
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35>.NativeClassPtr, "<>4__this");
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeFieldInfoPtr__buckets_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35>.NativeClassPtr, "<buckets>5__2");
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35>.NativeClassPtr, "<i>5__3");
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeFieldInfoPtr__current_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35>.NativeClassPtr, "<current>5__4");
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35>.NativeClassPtr, 100674672);
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35>.NativeClassPtr, 100674673);
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35>.NativeClassPtr, 100674674);
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35>.NativeClassPtr, 100674675);
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35>.NativeClassPtr, 100674676);
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35>.NativeClassPtr, 100674677);
			}

			// Token: 0x06005F19 RID: 24345 RVA: 0x001AD8FC File Offset: 0x001ABAFC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumerator_d__35(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005F1A RID: 24346 RVA: 0x001AD944 File Offset: 0x001ABB44
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005F1B RID: 24347 RVA: 0x001AD978 File Offset: 0x001ABB78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417762, XrefRangeEnd = 1417772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700188D RID: 6285
			// (get) Token: 0x06005F1C RID: 24348 RVA: 0x001AD9B4 File Offset: 0x001ABBB4
			public unsafe KeyValuePair<TKey, TValue> prop_KeyValuePair_2_TKey_TValue_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<TKey, TValue>(intPtr);
				}
			}

			// Token: 0x06005F1D RID: 24349 RVA: 0x001AD9EC File Offset: 0x001ABBEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700188E RID: 6286
			// (get) Token: 0x06005F1E RID: 24350 RVA: 0x001ADA20 File Offset: 0x001ABC20
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417772, XrefRangeEnd = 1417773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005F1F RID: 24351 RVA: 0x00022C5D File Offset: 0x00020E5D
			public _GetEnumerator_d__35(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001887 RID: 6279
			// (get) Token: 0x06005F20 RID: 24352 RVA: 0x001ADA60 File Offset: 0x001ABC60
			// (set) Token: 0x06005F21 RID: 24353 RVA: 0x00022C66 File Offset: 0x00020E66
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001888 RID: 6280
			// (get) Token: 0x06005F22 RID: 24354 RVA: 0x001ADA88 File Offset: 0x001ABC88
			// (set) Token: 0x06005F23 RID: 24355 RVA: 0x00022C81 File Offset: 0x00020E81
			public KeyValuePair<TKey, TValue> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<TKey, TValue>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001889 RID: 6281
			// (get) Token: 0x06005F24 RID: 24356 RVA: 0x001ADAB8 File Offset: 0x001ABCB8
			// (set) Token: 0x06005F25 RID: 24357 RVA: 0x00022CAF File Offset: 0x00020EAF
			public unsafe ConcurrentDictionary<TKey, TValue> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700188A RID: 6282
			// (get) Token: 0x06005F26 RID: 24358 RVA: 0x001ADAE8 File Offset: 0x001ABCE8
			// (set) Token: 0x06005F27 RID: 24359 RVA: 0x00022CCE File Offset: 0x00020ECE
			public unsafe Il2CppReferenceArray<ConcurrentDictionary<TKey, TValue>.Node> _buckets_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeFieldInfoPtr__buckets_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ConcurrentDictionary<TKey, TValue>.Node>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeFieldInfoPtr__buckets_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700188B RID: 6283
			// (get) Token: 0x06005F28 RID: 24360 RVA: 0x001ADB18 File Offset: 0x001ABD18
			// (set) Token: 0x06005F29 RID: 24361 RVA: 0x00022CED File Offset: 0x00020EED
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x1700188C RID: 6284
			// (get) Token: 0x06005F2A RID: 24362 RVA: 0x001ADB40 File Offset: 0x001ABD40
			// (set) Token: 0x06005F2B RID: 24363 RVA: 0x00022D08 File Offset: 0x00020F08
			public unsafe ConcurrentDictionary<TKey, TValue>.Node _current_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeFieldInfoPtr__current_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<TKey, TValue>.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__35.NativeFieldInfoPtr__current_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004D5E RID: 19806
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004D5F RID: 19807
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004D60 RID: 19808
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004D61 RID: 19809
			private static readonly IntPtr NativeFieldInfoPtr__buckets_5__2;

			// Token: 0x04004D62 RID: 19810
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04004D63 RID: 19811
			private static readonly IntPtr NativeFieldInfoPtr__current_5__4;

			// Token: 0x04004D64 RID: 19812
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004D65 RID: 19813
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004D66 RID: 19814
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004D67 RID: 19815
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0;

			// Token: 0x04004D68 RID: 19816
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004D69 RID: 19817
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020006FD RID: 1789
		private sealed class MethodInfoStoreGeneric_GetOrAdd_Public_TValue_TKey_Func_3_TKey_TArg_TValue_TArg_0
		{
			// Token: 0x06005F2C RID: 24364 RVA: 0x001ADB70 File Offset: 0x001ABD70
			// Note: this type is marked as 'beforefieldinit'.
			static MethodInfoStoreGeneric_GetOrAdd_Public_TValue_TKey_Func_3_TKey_TArg_TValue_TArg_0()
			{
				/*
An exception occurred when decompiling this method (06005F2C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Il2CppSystem.Collections.Concurrent.ConcurrentDictionary`2/MethodInfoStoreGeneric_GetOrAdd_Public_TValue_TKey_Func_3_TKey_TArg_TValue_TArg_0`1::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 881
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
			}

			// Token: 0x04004D6A RID: 19818
			internal static IntPtr Pointer;
		}
	}
}
