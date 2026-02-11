using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Collections.ObjectModel
{
	// Token: 0x020004DA RID: 1242
	[Serializable]
	public class ReadOnlyDictionary<TKey, TValue> : Object
	{
		// Token: 0x06004CED RID: 19693 RVA: 0x00164320 File Offset: 0x00162520
		// Note: this type is marked as 'beforefieldinit'.
		static ReadOnlyDictionary()
		{
			Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.ObjectModel", "ReadOnlyDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr);
			ReadOnlyDictionary<TKey, TValue>.NativeFieldInfoPtr_m_dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, "m_dictionary");
			ReadOnlyDictionary<TKey, TValue>.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, "_syncRoot");
			ReadOnlyDictionary<TKey, TValue>.NativeFieldInfoPtr__keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, "_keys");
			ReadOnlyDictionary<TKey, TValue>.NativeFieldInfoPtr__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, "_values");
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674759);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_get_KeyCollection_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674760);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_get_ValueCollection_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674761);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674762);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674763);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674764);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674765);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674766);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674767);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674768);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674769);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_set_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674770);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674771);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674772);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674773);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674774);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674775);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674776);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674777);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674778);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674779);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_IsCompatibleKey_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674780);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674781);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Clear_Private_Virtual_Final_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674782);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674783);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674784);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674785);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674786);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674787);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674788);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674789);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674790);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674791);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674792);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674793);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674794);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674795);
			ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, 100674796);
		}

		// Token: 0x06004CEE RID: 19694 RVA: 0x001646E8 File Offset: 0x001628E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 468062, RefRangeEnd = 468067, XrefRangeStart = 468062, XrefRangeEnd = 468067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyDictionary(IDictionary<TKey, TValue> dictionary)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x06004CEF RID: 19695 RVA: 0x00164734 File Offset: 0x00162934
		public unsafe ReadOnlyDictionary<TKey, TValue>.KeyCollection Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419211, XrefRangeEnd = 1419217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_get_KeyCollection_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyDictionary<TKey, TValue>.KeyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x06004CF0 RID: 19696 RVA: 0x00164774 File Offset: 0x00162974
		public unsafe ReadOnlyDictionary<TKey, TValue>.ValueCollection Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419217, XrefRangeEnd = 1419223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_get_ValueCollection_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyDictionary<TKey, TValue>.ValueCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06004CF1 RID: 19697 RVA: 0x001647B4 File Offset: 0x001629B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1419226, RefRangeEnd = 1419228, XrefRangeStart = 1419223, XrefRangeEnd = 1419226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x06004CF2 RID: 19698 RVA: 0x00164838 File Offset: 0x00162A38
		public unsafe virtual ICollection<TKey> prop_ICollection_1_TKey_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419228, XrefRangeEnd = 1419229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<TKey>>(intPtr3) : null;
			}
		}

		// Token: 0x06004CF3 RID: 19699 RVA: 0x00164878 File Offset: 0x00162A78
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1419233, RefRangeEnd = 1419239, XrefRangeStart = 1419229, XrefRangeEnd = 1419233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x06004CF4 RID: 19700 RVA: 0x0016494C File Offset: 0x00162B4C
		public unsafe virtual ICollection<TValue> prop_ICollection_1_TValue_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419239, XrefRangeEnd = 1419242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<TValue>>(intPtr3) : null;
			}
		}

		// Token: 0x170013D1 RID: 5073
		public unsafe virtual TValue this[TKey key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419242, XrefRangeEnd = 1419251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
				}
			}
		}

		// Token: 0x06004CF6 RID: 19702 RVA: 0x00164A0C File Offset: 0x00162C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419251, XrefRangeEnd = 1419256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x06004CF7 RID: 19703 RVA: 0x00164ACC File Offset: 0x00162CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x06004CF8 RID: 19704 RVA: 0x00164B50 File Offset: 0x00162D50
		// (set) Token: 0x06004CF9 RID: 19705 RVA: 0x00164BD0 File Offset: 0x00162DD0
		public unsafe virtual TValue prop_TValue_0
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_set_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			}
		}

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x06004CFA RID: 19706 RVA: 0x00164C90 File Offset: 0x00162E90
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419256, XrefRangeEnd = 1419265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004CFB RID: 19707 RVA: 0x00164CCC File Offset: 0x00162ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419265, XrefRangeEnd = 1419267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004CFC RID: 19708 RVA: 0x00164D20 File Offset: 0x00162F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419267, XrefRangeEnd = 1419269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0(Il2CppReferenceArray<KeyValuePair<TKey, TValue>> array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x06004CFD RID: 19709 RVA: 0x00164D70 File Offset: 0x00162F70
		public unsafe virtual bool prop_Boolean_0
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004CFE RID: 19710 RVA: 0x00164DAC File Offset: 0x00162FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004CFF RID: 19711 RVA: 0x00164DF4 File Offset: 0x00162FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D00 RID: 19712 RVA: 0x00164E28 File Offset: 0x00163028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1(KeyValuePair<TKey, TValue> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004D01 RID: 19713 RVA: 0x00164E7C File Offset: 0x0016307C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419269, XrefRangeEnd = 1419272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x06004D02 RID: 19714 RVA: 0x00164EBC File Offset: 0x001630BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419272, XrefRangeEnd = 1419284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004D03 RID: 19715 RVA: 0x00164EFC File Offset: 0x001630FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419284, XrefRangeEnd = 1419287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCompatibleKey(Object key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_IsCompatibleKey_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004D04 RID: 19716 RVA: 0x00164F40 File Offset: 0x00163140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D05 RID: 19717 RVA: 0x00164F94 File Offset: 0x00163194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IDictionary_Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Clear_Private_Virtual_Final_New_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D06 RID: 19718 RVA: 0x00164FC8 File Offset: 0x001631C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419287, XrefRangeEnd = 1419295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IDictionary_Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004D07 RID: 19719 RVA: 0x00165018 File Offset: 0x00163218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419295, XrefRangeEnd = 1419300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator System_Collections_IDictionary_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x06004D08 RID: 19720 RVA: 0x00165058 File Offset: 0x00163258
		public unsafe virtual bool System.Collections.IDictionary.IsFixedSize
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x06004D09 RID: 19721 RVA: 0x00165094 File Offset: 0x00163294
		public unsafe virtual bool System.Collections.IDictionary.IsReadOnly
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x06004D0A RID: 19722 RVA: 0x001650D0 File Offset: 0x001632D0
		public unsafe virtual ICollection System.Collections.IDictionary.Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x06004D0B RID: 19723 RVA: 0x00165110 File Offset: 0x00163310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IDictionary_Remove(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x06004D0C RID: 19724 RVA: 0x00165154 File Offset: 0x00163354
		public unsafe virtual ICollection System.Collections.IDictionary.Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x06004D0D RID: 19725 RVA: 0x00165194 File Offset: 0x00163394
		// (set) Token: 0x06004D0E RID: 19726 RVA: 0x001651E4 File Offset: 0x001633E4
		public unsafe virtual Object System.Collections.IDictionary.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419300, XrefRangeEnd = 1419308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
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
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004D0F RID: 19727 RVA: 0x00165238 File Offset: 0x00163438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419308, XrefRangeEnd = 1419361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x06004D10 RID: 19728 RVA: 0x00165288 File Offset: 0x00163488
		public unsafe virtual bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x06004D11 RID: 19729 RVA: 0x001652C4 File Offset: 0x001634C4
		public unsafe virtual Object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419361, XrefRangeEnd = 1419369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x06004D12 RID: 19730 RVA: 0x00165304 File Offset: 0x00163504
		public unsafe virtual IEnumerable<TKey> prop_IEnumerable_1_TKey_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TKey>>(intPtr3) : null;
			}
		}

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x06004D13 RID: 19731 RVA: 0x00165344 File Offset: 0x00163544
		public unsafe virtual IEnumerable<TValue> prop_IEnumerable_1_TValue_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TValue>>(intPtr3) : null;
			}
		}

		// Token: 0x06004D14 RID: 19732 RVA: 0x0001BEFF File Offset: 0x0001A0FF
		public ReadOnlyDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x06004D15 RID: 19733 RVA: 0x00165384 File Offset: 0x00163584
		// (set) Token: 0x06004D16 RID: 19734 RVA: 0x0001BF08 File Offset: 0x0001A108
		public unsafe IDictionary<TKey, TValue> m_dictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<TKey, TValue>.NativeFieldInfoPtr_m_dictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<TKey, TValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<TKey, TValue>.NativeFieldInfoPtr_m_dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x06004D17 RID: 19735 RVA: 0x001653B4 File Offset: 0x001635B4
		// (set) Token: 0x06004D18 RID: 19736 RVA: 0x0001BF27 File Offset: 0x0001A127
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<TKey, TValue>.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<TKey, TValue>.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x06004D19 RID: 19737 RVA: 0x001653E4 File Offset: 0x001635E4
		// (set) Token: 0x06004D1A RID: 19738 RVA: 0x0001BF46 File Offset: 0x0001A146
		public unsafe ReadOnlyDictionary<TKey, TValue>.KeyCollection _keys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<TKey, TValue>.NativeFieldInfoPtr__keys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyDictionary<TKey, TValue>.KeyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<TKey, TValue>.NativeFieldInfoPtr__keys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x06004D1B RID: 19739 RVA: 0x00165414 File Offset: 0x00163614
		// (set) Token: 0x06004D1C RID: 19740 RVA: 0x0001BF65 File Offset: 0x0001A165
		public unsafe ReadOnlyDictionary<TKey, TValue>.ValueCollection _values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<TKey, TValue>.NativeFieldInfoPtr__values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyDictionary<TKey, TValue>.ValueCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<TKey, TValue>.NativeFieldInfoPtr__values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003EF3 RID: 16115
		private static readonly IntPtr NativeFieldInfoPtr_m_dictionary;

		// Token: 0x04003EF4 RID: 16116
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x04003EF5 RID: 16117
		private static readonly IntPtr NativeFieldInfoPtr__keys;

		// Token: 0x04003EF6 RID: 16118
		private static readonly IntPtr NativeFieldInfoPtr__values;

		// Token: 0x04003EF7 RID: 16119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0;

		// Token: 0x04003EF8 RID: 16120
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_get_KeyCollection_TKey_TValue_0;

		// Token: 0x04003EF9 RID: 16121
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_get_ValueCollection_TKey_TValue_0;

		// Token: 0x04003EFA RID: 16122
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x04003EFB RID: 16123
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TKey_0;

		// Token: 0x04003EFC RID: 16124
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0;

		// Token: 0x04003EFD RID: 16125
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TValue_0;

		// Token: 0x04003EFE RID: 16126
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0;

		// Token: 0x04003EFF RID: 16127
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_TKey_TValue_0;

		// Token: 0x04003F00 RID: 16128
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x04003F01 RID: 16129
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_TValue_TKey_0;

		// Token: 0x04003F02 RID: 16130
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_set_Void_TKey_TValue_0;

		// Token: 0x04003F03 RID: 16131
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04003F04 RID: 16132
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04003F05 RID: 16133
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x04003F06 RID: 16134
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003F07 RID: 16135
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04003F08 RID: 16136
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003F09 RID: 16137
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1;

		// Token: 0x04003F0A RID: 16138
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04003F0B RID: 16139
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04003F0C RID: 16140
		private static readonly IntPtr NativeMethodInfoPtr_IsCompatibleKey_Private_Static_Boolean_Object_0;

		// Token: 0x04003F0D RID: 16141
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0;

		// Token: 0x04003F0E RID: 16142
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Clear_Private_Virtual_Final_New_Void_1;

		// Token: 0x04003F0F RID: 16143
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x04003F10 RID: 16144
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x04003F11 RID: 16145
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x04003F12 RID: 16146
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x04003F13 RID: 16147
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04003F14 RID: 16148
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04003F15 RID: 16149
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04003F16 RID: 16150
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0;

		// Token: 0x04003F17 RID: 16151
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0;

		// Token: 0x04003F18 RID: 16152
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04003F19 RID: 16153
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x04003F1A RID: 16154
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04003F1B RID: 16155
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TKey_0;

		// Token: 0x04003F1C RID: 16156
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TValue_0;

		// Token: 0x020006FE RID: 1790
		[Serializable]
		public sealed class DictionaryEnumerator : ValueType
		{
			// Token: 0x06005F2D RID: 24365 RVA: 0x001ADBC4 File Offset: 0x001ABDC4
			// Note: this type is marked as 'beforefieldinit'.
			static DictionaryEnumerator()
			{
				Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, "DictionaryEnumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr);
				ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator.NativeFieldInfoPtr__dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, "_dictionary");
				ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator.NativeFieldInfoPtr__enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, "_enumerator");
				ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100674797);
				ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100674798);
				ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100674799);
				ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100674800);
				ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100674801);
				ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100674802);
				ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100674803);
			}

			// Token: 0x06005F2E RID: 24366 RVA: 0x001ADCF0 File Offset: 0x001ABEF0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1419019, RefRangeEnd = 1419020, XrefRangeStart = 1419010, XrefRangeEnd = 1419019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictionaryEnumerator(IDictionary<TKey, TValue> dictionary)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001891 RID: 6289
			// (get) Token: 0x06005F2F RID: 24367 RVA: 0x001ADD40 File Offset: 0x001ABF40
			public unsafe DictionaryEntry Entry
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1419029, RefRangeEnd = 1419030, XrefRangeStart = 1419020, XrefRangeEnd = 1419029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x17001892 RID: 6290
			// (get) Token: 0x06005F30 RID: 24368 RVA: 0x001ADD7C File Offset: 0x001ABF7C
			public unsafe Object Key
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419030, XrefRangeEnd = 1419034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001893 RID: 6291
			// (get) Token: 0x06005F31 RID: 24369 RVA: 0x001ADDC0 File Offset: 0x001ABFC0
			public unsafe Object Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419034, XrefRangeEnd = 1419038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001894 RID: 6292
			// (get) Token: 0x06005F32 RID: 24370 RVA: 0x001ADE04 File Offset: 0x001AC004
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419038, XrefRangeEnd = 1419043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005F33 RID: 24371 RVA: 0x001ADE48 File Offset: 0x001AC048
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419043, XrefRangeEnd = 1419067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005F34 RID: 24372 RVA: 0x001ADE8C File Offset: 0x001AC08C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419067, XrefRangeEnd = 1419095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005F35 RID: 24373 RVA: 0x00022D27 File Offset: 0x00020F27
			public DictionaryEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005F36 RID: 24374 RVA: 0x00022D30 File Offset: 0x00020F30
			public DictionaryEnumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr))
			{
			}

			// Token: 0x1700188F RID: 6287
			// (get) Token: 0x06005F37 RID: 24375 RVA: 0x001ADEC4 File Offset: 0x001AC0C4
			// (set) Token: 0x06005F38 RID: 24376 RVA: 0x00022D42 File Offset: 0x00020F42
			public unsafe IDictionary<TKey, TValue> _dictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator.NativeFieldInfoPtr__dictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator.NativeFieldInfoPtr__dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001890 RID: 6288
			// (get) Token: 0x06005F39 RID: 24377 RVA: 0x001ADEF4 File Offset: 0x001AC0F4
			// (set) Token: 0x06005F3A RID: 24378 RVA: 0x00022D61 File Offset: 0x00020F61
			public unsafe IEnumerator<KeyValuePair<TKey, TValue>> _enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator.NativeFieldInfoPtr__enumerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TKey, TValue>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<TKey, TValue>.DictionaryEnumerator.NativeFieldInfoPtr__enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004D6B RID: 19819
			private static readonly IntPtr NativeFieldInfoPtr__dictionary;

			// Token: 0x04004D6C RID: 19820
			private static readonly IntPtr NativeFieldInfoPtr__enumerator;

			// Token: 0x04004D6D RID: 19821
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0;

			// Token: 0x04004D6E RID: 19822
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x04004D6F RID: 19823
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004D70 RID: 19824
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004D71 RID: 19825
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004D72 RID: 19826
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004D73 RID: 19827
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x020006FF RID: 1791
		[Serializable]
		public sealed class KeyCollection : Object
		{
			// Token: 0x06005F3B RID: 24379 RVA: 0x001ADF24 File Offset: 0x001AC124
			// Note: this type is marked as 'beforefieldinit'.
			static KeyCollection()
			{
				Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, "KeyCollection"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr);
				ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr__collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, "_collection");
				ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, "_syncRoot");
				ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr__ctor_Internal_Void_ICollection_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674804);
				ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674805);
				ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674806);
				ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674807);
				ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674808);
				ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674809);
				ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674810);
				ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674811);
				ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674812);
				ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674813);
				ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674814);
				ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674815);
				ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674816);
				ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100674817);
			}

			// Token: 0x06005F3C RID: 24380 RVA: 0x001AE0DC File Offset: 0x001AC2DC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1419102, RefRangeEnd = 1419104, XrefRangeStart = 1419095, XrefRangeEnd = 1419102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyCollection(ICollection<TKey> collection)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr__ctor_Internal_Void_ICollection_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005F3D RID: 24381 RVA: 0x001AE128 File Offset: 0x001AC328
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419104, XrefRangeEnd = 1419109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x06005F3E RID: 24382 RVA: 0x001AE1A0 File Offset: 0x001AC3A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419109, XrefRangeEnd = 1419114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_Generic_ICollection_TKey__Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005F3F RID: 24383 RVA: 0x001AE1D4 File Offset: 0x001AC3D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419114, XrefRangeEnd = 1419119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06005F40 RID: 24384 RVA: 0x001AE258 File Offset: 0x001AC458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419119, XrefRangeEnd = 1419129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CopyTo(Il2CppArrayBase<TKey> array, int arrayIndex)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001897 RID: 6295
			// (get) Token: 0x06005F41 RID: 24385 RVA: 0x001AE2A8 File Offset: 0x001AC4A8
			public unsafe int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419129, XrefRangeEnd = 1419158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001898 RID: 6296
			// (get) Token: 0x06005F42 RID: 24386 RVA: 0x001AE2E4 File Offset: 0x001AC4E4
			public unsafe bool System.Collections.Generic.ICollection<TKey>.IsReadOnly
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005F43 RID: 24387 RVA: 0x001AE320 File Offset: 0x001AC520
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06005F44 RID: 24388 RVA: 0x001AE3A4 File Offset: 0x001AC5A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419158, XrefRangeEnd = 1419162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TKey> GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TKey>>(intPtr3) : null;
			}

			// Token: 0x06005F45 RID: 24389 RVA: 0x001AE3E4 File Offset: 0x001AC5E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419162, XrefRangeEnd = 1419168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005F46 RID: 24390 RVA: 0x001AE424 File Offset: 0x001AC624
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419168, XrefRangeEnd = 1419190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001899 RID: 6297
			// (get) Token: 0x06005F47 RID: 24391 RVA: 0x001AE474 File Offset: 0x001AC674
			public unsafe bool System.Collections.ICollection.IsSynchronized
			{
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700189A RID: 6298
			// (get) Token: 0x06005F48 RID: 24392 RVA: 0x001AE4B0 File Offset: 0x001AC6B0
			public unsafe Object System.Collections.ICollection.SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419190, XrefRangeEnd = 1419198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005F49 RID: 24393 RVA: 0x001AE4F0 File Offset: 0x001AC6F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419198, XrefRangeEnd = 1419199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyCollection()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005F4A RID: 24394 RVA: 0x00022D80 File Offset: 0x00020F80
			public KeyCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001895 RID: 6293
			// (get) Token: 0x06005F4B RID: 24395 RVA: 0x001AE52C File Offset: 0x001AC72C
			// (set) Token: 0x06005F4C RID: 24396 RVA: 0x00022D89 File Offset: 0x00020F89
			public unsafe ICollection<TKey> _collection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr__collection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICollection<TKey>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr__collection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001896 RID: 6294
			// (get) Token: 0x06005F4D RID: 24397 RVA: 0x001AE55C File Offset: 0x001AC75C
			// (set) Token: 0x06005F4E RID: 24398 RVA: 0x00022DA8 File Offset: 0x00020FA8
			public unsafe Object _syncRoot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr__syncRoot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004D74 RID: 19828
			private static readonly IntPtr NativeFieldInfoPtr__collection;

			// Token: 0x04004D75 RID: 19829
			private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

			// Token: 0x04004D76 RID: 19830
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ICollection_1_TKey_0;

			// Token: 0x04004D77 RID: 19831
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0;

			// Token: 0x04004D78 RID: 19832
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004D79 RID: 19833
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0;

			// Token: 0x04004D7A RID: 19834
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0;

			// Token: 0x04004D7B RID: 19835
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04004D7C RID: 19836
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04004D7D RID: 19837
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0;

			// Token: 0x04004D7E RID: 19838
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TKey_0;

			// Token: 0x04004D7F RID: 19839
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04004D80 RID: 19840
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x04004D81 RID: 19841
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04004D82 RID: 19842
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004D83 RID: 19843
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
		}

		// Token: 0x02000700 RID: 1792
		[Serializable]
		public sealed class ValueCollection : Object
		{
			// Token: 0x06005F4F RID: 24399 RVA: 0x001AE58C File Offset: 0x001AC78C
			// Note: this type is marked as 'beforefieldinit'.
			static ValueCollection()
			{
				Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>>.NativeClassPtr, "ValueCollection"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr);
				ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr__collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, "_collection");
				ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, "_syncRoot");
				ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr__ctor_Internal_Void_ICollection_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674818);
				ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Add_Private_Virtual_Final_New_Void_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674819);
				ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674820);
				ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Contains_Private_Virtual_Final_New_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674821);
				ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674822);
				ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674823);
				ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674824);
				ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Remove_Private_Virtual_Final_New_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674825);
				ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674826);
				ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674827);
				ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674828);
				ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674829);
				ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674830);
				ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100674831);
			}

			// Token: 0x06005F50 RID: 24400 RVA: 0x001AE744 File Offset: 0x001AC944
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1419102, RefRangeEnd = 1419104, XrefRangeStart = 1419102, XrefRangeEnd = 1419104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueCollection(ICollection<TValue> collection)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr__ctor_Internal_Void_ICollection_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005F51 RID: 24401 RVA: 0x001AE790 File Offset: 0x001AC990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Add_Private_Virtual_Final_New_Void_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x06005F52 RID: 24402 RVA: 0x001AE808 File Offset: 0x001ACA08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_Generic_ICollection_TValue__Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005F53 RID: 24403 RVA: 0x001AE83C File Offset: 0x001ACA3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Contains_Private_Virtual_Final_New_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06005F54 RID: 24404 RVA: 0x001AE8C0 File Offset: 0x001ACAC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CopyTo(Il2CppArrayBase<TValue> array, int arrayIndex)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700189D RID: 6301
			// (get) Token: 0x06005F55 RID: 24405 RVA: 0x001AE910 File Offset: 0x001ACB10
			public unsafe int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700189E RID: 6302
			// (get) Token: 0x06005F56 RID: 24406 RVA: 0x001AE94C File Offset: 0x001ACB4C
			public unsafe bool System.Collections.Generic.ICollection<TValue>.IsReadOnly
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005F57 RID: 24407 RVA: 0x001AE988 File Offset: 0x001ACB88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Remove_Private_Virtual_Final_New_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06005F58 RID: 24408 RVA: 0x001AEA0C File Offset: 0x001ACC0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TValue> GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TValue>>(intPtr3) : null;
			}

			// Token: 0x06005F59 RID: 24409 RVA: 0x001AEA4C File Offset: 0x001ACC4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419199, XrefRangeEnd = 1419203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005F5A RID: 24410 RVA: 0x001AEA8C File Offset: 0x001ACC8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700189F RID: 6303
			// (get) Token: 0x06005F5B RID: 24411 RVA: 0x001AEADC File Offset: 0x001ACCDC
			public unsafe bool System.Collections.ICollection.IsSynchronized
			{
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170018A0 RID: 6304
			// (get) Token: 0x06005F5C RID: 24412 RVA: 0x001AEB18 File Offset: 0x001ACD18
			public unsafe Object System.Collections.ICollection.SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419203, XrefRangeEnd = 1419211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005F5D RID: 24413 RVA: 0x001AEB58 File Offset: 0x001ACD58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueCollection()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005F5E RID: 24414 RVA: 0x00022DC7 File Offset: 0x00020FC7
			public ValueCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700189B RID: 6299
			// (get) Token: 0x06005F5F RID: 24415 RVA: 0x001AEB94 File Offset: 0x001ACD94
			// (set) Token: 0x06005F60 RID: 24416 RVA: 0x00022DD0 File Offset: 0x00020FD0
			public unsafe ICollection<TValue> _collection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr__collection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICollection<TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr__collection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700189C RID: 6300
			// (get) Token: 0x06005F61 RID: 24417 RVA: 0x001AEBC4 File Offset: 0x001ACDC4
			// (set) Token: 0x06005F62 RID: 24418 RVA: 0x00022DEF File Offset: 0x00020FEF
			public unsafe Object _syncRoot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr__syncRoot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyDictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004D84 RID: 19844
			private static readonly IntPtr NativeFieldInfoPtr__collection;

			// Token: 0x04004D85 RID: 19845
			private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

			// Token: 0x04004D86 RID: 19846
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ICollection_1_TValue_0;

			// Token: 0x04004D87 RID: 19847
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Add_Private_Virtual_Final_New_Void_TValue_0;

			// Token: 0x04004D88 RID: 19848
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Clear_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004D89 RID: 19849
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Contains_Private_Virtual_Final_New_Boolean_TValue_0;

			// Token: 0x04004D8A RID: 19850
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TValue_Int32_0;

			// Token: 0x04004D8B RID: 19851
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04004D8C RID: 19852
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04004D8D RID: 19853
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Remove_Private_Virtual_Final_New_Boolean_TValue_0;

			// Token: 0x04004D8E RID: 19854
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TValue_0;

			// Token: 0x04004D8F RID: 19855
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04004D90 RID: 19856
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x04004D91 RID: 19857
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04004D92 RID: 19858
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004D93 RID: 19859
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
		}
	}
}
