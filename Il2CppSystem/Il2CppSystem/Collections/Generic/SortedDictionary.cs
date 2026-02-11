using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200016D RID: 365
	[Serializable]
	public class SortedDictionary<TKey, TValue> : Object
	{
		// Token: 0x0600161C RID: 5660 RVA: 0x00072508 File Offset: 0x00070708
		// Note: this type is marked as 'beforefieldinit'.
		static SortedDictionary()
		{
			Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "SortedDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr);
			SortedDictionary<TKey, TValue>.NativeFieldInfoPtr__keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, "_keys");
			SortedDictionary<TKey, TValue>.NativeFieldInfoPtr__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, "_values");
			SortedDictionary<TKey, TValue>.NativeFieldInfoPtr__set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, "_set");
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666662);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666663);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666664);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666665);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666666);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666667);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666668);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666669);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666670);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_get_KeyCollection_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666671);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666672);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666673);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_get_ValueCollection_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666674);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666675);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666676);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666677);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666678);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666679);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsValue_Public_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666680);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666681);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666682);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666683);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666684);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666685);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666686);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666687);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666688);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666689);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666690);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666691);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666692);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666693);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666694);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_IsCompatibleKey_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666695);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666696);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666697);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666698);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666699);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100666700);
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x000728D0 File Offset: 0x00070AD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 468367, RefRangeEnd = 468369, XrefRangeStart = 468353, XrefRangeEnd = 468367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortedDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x0007290C File Offset: 0x00070B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468369, XrefRangeEnd = 468377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortedDictionary(IComparer<TKey> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00072958 File Offset: 0x00070B58
		[CallerCount(0)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x000729A0 File Offset: 0x00070BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468377, XrefRangeEnd = 468378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x000729F4 File Offset: 0x00070BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468378, XrefRangeEnd = 468379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001622 RID: 5666 RVA: 0x00072A48 File Offset: 0x00070C48
		public unsafe virtual bool prop_Boolean_0
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700067F RID: 1663
		public unsafe virtual TValue this[TKey key]
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 468380, RefRangeEnd = 468382, XrefRangeStart = 468379, XrefRangeEnd = 468380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468382, XrefRangeEnd = 468385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x00072BC4 File Offset: 0x00070DC4
		public unsafe virtual int Count
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 468385, RefRangeEnd = 468396, XrefRangeStart = 468385, XrefRangeEnd = 468385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x00072C00 File Offset: 0x00070E00
		public unsafe SortedDictionary<TKey, TValue>.KeyCollection Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468396, XrefRangeEnd = 468400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_get_KeyCollection_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedDictionary<TKey, TValue>.KeyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001627 RID: 5671 RVA: 0x00072C40 File Offset: 0x00070E40
		public unsafe virtual ICollection<TKey> prop_ICollection_1_TKey_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468400, XrefRangeEnd = 468401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<TKey>>(intPtr3) : null;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001628 RID: 5672 RVA: 0x00072C80 File Offset: 0x00070E80
		public unsafe virtual IEnumerable<TKey> prop_IEnumerable_1_TKey_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TKey>>(intPtr3) : null;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001629 RID: 5673 RVA: 0x00072CC0 File Offset: 0x00070EC0
		public unsafe SortedDictionary<TKey, TValue>.ValueCollection Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468401, XrefRangeEnd = 468405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_get_ValueCollection_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedDictionary<TKey, TValue>.ValueCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x0600162A RID: 5674 RVA: 0x00072D00 File Offset: 0x00070F00
		public unsafe virtual ICollection<TValue> prop_ICollection_1_TValue_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468405, XrefRangeEnd = 468406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<TValue>>(intPtr3) : null;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x0600162B RID: 5675 RVA: 0x00072D40 File Offset: 0x00070F40
		public unsafe virtual IEnumerable<TValue> prop_IEnumerable_1_TValue_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TValue>>(intPtr3) : null;
			}
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00072D80 File Offset: 0x00070F80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 468407, RefRangeEnd = 468409, XrefRangeStart = 468406, XrefRangeEnd = 468407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00072E40 File Offset: 0x00071040
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 468428, RefRangeEnd = 468429, XrefRangeStart = 468409, XrefRangeEnd = 468428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00072E74 File Offset: 0x00071074
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 468430, RefRangeEnd = 468432, XrefRangeStart = 468429, XrefRangeEnd = 468430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00072EF8 File Offset: 0x000710F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 468449, RefRangeEnd = 468450, XrefRangeStart = 468432, XrefRangeEnd = 468449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsValue_Public_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00072F7C File Offset: 0x0007117C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468450, XrefRangeEnd = 468453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppReferenceArray<KeyValuePair<TKey, TValue>> array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00072FCC File Offset: 0x000711CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 468454, RefRangeEnd = 468457, XrefRangeStart = 468453, XrefRangeEnd = 468454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortedDictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new SortedDictionary<TKey, TValue>.Enumerator(intPtr);
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00073004 File Offset: 0x00071204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468457, XrefRangeEnd = 468459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<TKey, TValue>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00073044 File Offset: 0x00071244
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 468460, RefRangeEnd = 468461, XrefRangeStart = 468459, XrefRangeEnd = 468460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x000730C8 File Offset: 0x000712C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 468463, RefRangeEnd = 468464, XrefRangeStart = 468461, XrefRangeEnd = 468463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x0007319C File Offset: 0x0007139C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468464, XrefRangeEnd = 468467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001636 RID: 5686 RVA: 0x000731EC File Offset: 0x000713EC
		public unsafe virtual bool System.Collections.IDictionary.IsFixedSize
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001637 RID: 5687 RVA: 0x00073228 File Offset: 0x00071428
		public unsafe virtual bool System.Collections.IDictionary.IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x00073264 File Offset: 0x00071464
		public unsafe virtual ICollection System.Collections.IDictionary.Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x000732A4 File Offset: 0x000714A4
		public unsafe virtual ICollection System.Collections.IDictionary.Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x0600163A RID: 5690 RVA: 0x000732E4 File Offset: 0x000714E4
		// (set) Token: 0x0600163B RID: 5691 RVA: 0x00073334 File Offset: 0x00071534
		public unsafe virtual Object System.Collections.IDictionary.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468467, XrefRangeEnd = 468474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468474, XrefRangeEnd = 468483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00073388 File Offset: 0x00071588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468483, XrefRangeEnd = 468488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x000733DC File Offset: 0x000715DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468488, XrefRangeEnd = 468491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IDictionary_Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x0007342C File Offset: 0x0007162C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468491, XrefRangeEnd = 468494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCompatibleKey(Object key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_IsCompatibleKey_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00073470 File Offset: 0x00071670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468494, XrefRangeEnd = 468496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator System_Collections_IDictionary_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x000734B0 File Offset: 0x000716B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468496, XrefRangeEnd = 468502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IDictionary_Remove(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001641 RID: 5697 RVA: 0x000734F4 File Offset: 0x000716F4
		public unsafe virtual bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x00073530 File Offset: 0x00071730
		public unsafe virtual Object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468502, XrefRangeEnd = 468510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00073570 File Offset: 0x00071770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00009A87 File Offset: 0x00007C87
		public SortedDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001645 RID: 5701 RVA: 0x000735B0 File Offset: 0x000717B0
		// (set) Token: 0x06001646 RID: 5702 RVA: 0x00009A90 File Offset: 0x00007C90
		public unsafe SortedDictionary<TKey, TValue>.KeyCollection _keys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.NativeFieldInfoPtr__keys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedDictionary<TKey, TValue>.KeyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.NativeFieldInfoPtr__keys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001647 RID: 5703 RVA: 0x000735E0 File Offset: 0x000717E0
		// (set) Token: 0x06001648 RID: 5704 RVA: 0x00009AAF File Offset: 0x00007CAF
		public unsafe SortedDictionary<TKey, TValue>.ValueCollection _values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.NativeFieldInfoPtr__values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedDictionary<TKey, TValue>.ValueCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.NativeFieldInfoPtr__values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001649 RID: 5705 RVA: 0x00073610 File Offset: 0x00071810
		// (set) Token: 0x0600164A RID: 5706 RVA: 0x00009ACE File Offset: 0x00007CCE
		public unsafe TreeSet<KeyValuePair<TKey, TValue>> _set
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.NativeFieldInfoPtr__set);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TreeSet<KeyValuePair<TKey, TValue>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.NativeFieldInfoPtr__set), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeFieldInfoPtr__keys;

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeFieldInfoPtr__values;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeFieldInfoPtr__set;

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_TKey_0;

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x0400114B RID: 4427
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1;

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0;

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001151 RID: 4433
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_get_KeyCollection_TKey_TValue_0;

		// Token: 0x04001152 RID: 4434
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TKey_0;

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TKey_0;

		// Token: 0x04001154 RID: 4436
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_get_ValueCollection_TKey_TValue_0;

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_TValue_0;

		// Token: 0x04001156 RID: 4438
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IEnumerable_1_TValue_0;

		// Token: 0x04001157 RID: 4439
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0;

		// Token: 0x04001158 RID: 4440
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001159 RID: 4441
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x0400115A RID: 4442
		private static readonly IntPtr NativeMethodInfoPtr_ContainsValue_Public_Boolean_TValue_0;

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x0400115C RID: 4444
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0;

		// Token: 0x0400115D RID: 4445
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0;

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x04001162 RID: 4450
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x04001163 RID: 4451
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04001164 RID: 4452
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04001165 RID: 4453
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0;

		// Token: 0x04001166 RID: 4454
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0;

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0;

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeMethodInfoPtr_IsCompatibleKey_Private_Static_Boolean_Object_0;

		// Token: 0x0400116A RID: 4458
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Remove_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_1;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x020002F7 RID: 759
		public sealed class Enumerator : ValueType
		{
			// Token: 0x06002D47 RID: 11591 RVA: 0x000C6B28 File Offset: 0x000C4D28
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr);
				SortedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__treeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "_treeEnum");
				SortedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__getEnumeratorRetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "_getEnumeratorRetType");
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedDictionary_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100666701);
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100666702);
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100666703);
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100666704);
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_get_NotStartedOrEnded_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100666705);
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100666706);
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100666707);
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100666708);
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Key_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100666709);
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Value_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100666710);
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Entry_Private_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100666711);
			}

			// Token: 0x06002D48 RID: 11592 RVA: 0x000C6CA4 File Offset: 0x000C4EA4
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 467935, RefRangeEnd = 467939, XrefRangeStart = 467932, XrefRangeEnd = 467935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(SortedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref getEnumeratorRetType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedDictionary_2_TKey_TValue_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D49 RID: 11593 RVA: 0x000C6D04 File Offset: 0x000C4F04
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 467945, RefRangeEnd = 467946, XrefRangeStart = 467939, XrefRangeEnd = 467945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002D4A RID: 11594 RVA: 0x000C6D48 File Offset: 0x000C4F48
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 467951, RefRangeEnd = 467953, XrefRangeStart = 467946, XrefRangeEnd = 467951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E37 RID: 3639
			// (get) Token: 0x06002D4B RID: 11595 RVA: 0x000C6D80 File Offset: 0x000C4F80
			public unsafe KeyValuePair<TKey, TValue> Current
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 467958, RefRangeEnd = 467959, XrefRangeStart = 467953, XrefRangeEnd = 467958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<TKey, TValue>(intPtr);
				}
			}

			// Token: 0x17000E38 RID: 3640
			// (get) Token: 0x06002D4C RID: 11596 RVA: 0x000C6DBC File Offset: 0x000C4FBC
			public unsafe bool NotStartedOrEnded
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467959, XrefRangeEnd = 467968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_get_NotStartedOrEnded_Internal_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D4D RID: 11597 RVA: 0x000C6E00 File Offset: 0x000C5000
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467968, XrefRangeEnd = 467981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D4E RID: 11598 RVA: 0x000C6E38 File Offset: 0x000C5038
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E39 RID: 3641
			// (get) Token: 0x06002D4F RID: 11599 RVA: 0x000C6E70 File Offset: 0x000C5070
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467981, XrefRangeEnd = 467994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17000E3A RID: 3642
			// (get) Token: 0x06002D50 RID: 11600 RVA: 0x000C6EB4 File Offset: 0x000C50B4
			public unsafe Object System.Collections.IDictionaryEnumerator.Key
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467994, XrefRangeEnd = 468001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Key_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17000E3B RID: 3643
			// (get) Token: 0x06002D51 RID: 11601 RVA: 0x000C6EF8 File Offset: 0x000C50F8
			public unsafe Object System.Collections.IDictionaryEnumerator.Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468001, XrefRangeEnd = 468006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Value_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17000E3C RID: 3644
			// (get) Token: 0x06002D52 RID: 11602 RVA: 0x000C6F3C File Offset: 0x000C513C
			public unsafe DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468006, XrefRangeEnd = 468017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Entry_Private_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x06002D53 RID: 11603 RVA: 0x000145E8 File Offset: 0x000127E8
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002D54 RID: 11604 RVA: 0x000145F1 File Offset: 0x000127F1
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x17000E35 RID: 3637
			// (get) Token: 0x06002D55 RID: 11605 RVA: 0x000C6F78 File Offset: 0x000C5178
			// (set) Token: 0x06002D56 RID: 11606 RVA: 0x00014603 File Offset: 0x00012803
			public SortedSet<KeyValuePair<TKey, TValue>>.Enumerator _treeEnum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__treeEnum);
					return new SortedSet<KeyValuePair<TKey, TValue>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SortedSet<KeyValuePair<TKey, TValue>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__treeEnum), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SortedSet<KeyValuePair<TKey, TValue>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000E36 RID: 3638
			// (get) Token: 0x06002D57 RID: 11607 RVA: 0x000C6FA8 File Offset: 0x000C51A8
			// (set) Token: 0x06002D58 RID: 11608 RVA: 0x00014631 File Offset: 0x00012831
			public unsafe int _getEnumeratorRetType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__getEnumeratorRetType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__getEnumeratorRetType)) = value;
				}
			}

			// Token: 0x0400239A RID: 9114
			private static readonly IntPtr NativeFieldInfoPtr__treeEnum;

			// Token: 0x0400239B RID: 9115
			private static readonly IntPtr NativeFieldInfoPtr__getEnumeratorRetType;

			// Token: 0x0400239C RID: 9116
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SortedDictionary_2_TKey_TValue_Int32_0;

			// Token: 0x0400239D RID: 9117
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x0400239E RID: 9118
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400239F RID: 9119
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0;

			// Token: 0x040023A0 RID: 9120
			private static readonly IntPtr NativeMethodInfoPtr_get_NotStartedOrEnded_Internal_get_Boolean_0;

			// Token: 0x040023A1 RID: 9121
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

			// Token: 0x040023A2 RID: 9122
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040023A3 RID: 9123
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040023A4 RID: 9124
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Key_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040023A5 RID: 9125
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Value_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040023A6 RID: 9126
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Entry_Private_Virtual_Final_New_get_DictionaryEntry_0;
		}

		// Token: 0x020002F8 RID: 760
		[Serializable]
		public sealed class KeyCollection : Object
		{
			// Token: 0x06002D59 RID: 11609 RVA: 0x000C6FD0 File Offset: 0x000C51D0
			// Note: this type is marked as 'beforefieldinit'.
			static KeyCollection()
			{
				Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, "KeyCollection"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr__dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, "_dictionary");
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr__ctor_Public_Void_SortedDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100666712);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TKey__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100666713);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100666714);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100666715);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100666716);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100666717);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100666718);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100666719);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100666720);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100666721);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100666722);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100666723);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100666724);
			}

			// Token: 0x06002D5A RID: 11610 RVA: 0x000C7160 File Offset: 0x000C5360
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 468062, RefRangeEnd = 468067, XrefRangeStart = 468053, XrefRangeEnd = 468062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyCollection(SortedDictionary<TKey, TValue> dictionary)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr__ctor_Public_Void_SortedDictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D5B RID: 11611 RVA: 0x000C71AC File Offset: 0x000C53AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468067, XrefRangeEnd = 468069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TKey> System_Collections_Generic_IEnumerable_TKey__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TKey__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TKey>>(intPtr3) : null;
			}

			// Token: 0x06002D5C RID: 11612 RVA: 0x000C71EC File Offset: 0x000C53EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002D5D RID: 11613 RVA: 0x000C722C File Offset: 0x000C542C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 468102, RefRangeEnd = 468104, XrefRangeStart = 468069, XrefRangeEnd = 468102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D5E RID: 11614 RVA: 0x000C727C File Offset: 0x000C547C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468104, XrefRangeEnd = 468124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E3E RID: 3646
			// (get) Token: 0x06002D5F RID: 11615 RVA: 0x000C72CC File Offset: 0x000C54CC
			public unsafe int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468124, XrefRangeEnd = 468126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E3F RID: 3647
			// (get) Token: 0x06002D60 RID: 11616 RVA: 0x000C7308 File Offset: 0x000C5508
			public unsafe bool System.Collections.Generic.ICollection<TKey>.IsReadOnly
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D61 RID: 11617 RVA: 0x000C7344 File Offset: 0x000C5544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468126, XrefRangeEnd = 468131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x06002D62 RID: 11618 RVA: 0x000C73BC File Offset: 0x000C55BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468131, XrefRangeEnd = 468141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_Generic_ICollection_TKey__Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D63 RID: 11619 RVA: 0x000C73F0 File Offset: 0x000C55F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468141, XrefRangeEnd = 468144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06002D64 RID: 11620 RVA: 0x000C7474 File Offset: 0x000C5674
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x17000E40 RID: 3648
			// (get) Token: 0x06002D65 RID: 11621 RVA: 0x000C74F8 File Offset: 0x000C56F8
			public unsafe bool System.Collections.ICollection.IsSynchronized
			{
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E41 RID: 3649
			// (get) Token: 0x06002D66 RID: 11622 RVA: 0x000C7534 File Offset: 0x000C5734
			public unsafe Object System.Collections.ICollection.SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468144, XrefRangeEnd = 468174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D67 RID: 11623 RVA: 0x0001464C File Offset: 0x0001284C
			public KeyCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E3D RID: 3645
			// (get) Token: 0x06002D68 RID: 11624 RVA: 0x000C7574 File Offset: 0x000C5774
			// (set) Token: 0x06002D69 RID: 11625 RVA: 0x00014655 File Offset: 0x00012855
			public unsafe SortedDictionary<TKey, TValue> _dictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr__dictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedDictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr__dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040023A7 RID: 9127
			private static readonly IntPtr NativeFieldInfoPtr__dictionary;

			// Token: 0x040023A8 RID: 9128
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SortedDictionary_2_TKey_TValue_0;

			// Token: 0x040023A9 RID: 9129
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TKey__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TKey_0;

			// Token: 0x040023AA RID: 9130
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x040023AB RID: 9131
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0;

			// Token: 0x040023AC RID: 9132
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x040023AD RID: 9133
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x040023AE RID: 9134
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040023AF RID: 9135
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0;

			// Token: 0x040023B0 RID: 9136
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0;

			// Token: 0x040023B1 RID: 9137
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0;

			// Token: 0x040023B2 RID: 9138
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0;

			// Token: 0x040023B3 RID: 9139
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040023B4 RID: 9140
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x020003BD RID: 957
			public sealed class Enumerator : ValueType
			{
				// Token: 0x060035AA RID: 13738 RVA: 0x000DEBD4 File Offset: 0x000DCDD4
				// Note: this type is marked as 'beforefieldinit'.
				static Enumerator()
				{
					Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr);
					SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr__dictEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "_dictEnum");
					SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100666725);
					SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100666726);
					SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100666727);
					SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100666728);
					SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100666729);
					SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100666730);
				}

				// Token: 0x060035AB RID: 13739 RVA: 0x000DECD8 File Offset: 0x000DCED8
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 468022, RefRangeEnd = 468026, XrefRangeStart = 468017, XrefRangeEnd = 468022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Enumerator(SortedDictionary<TKey, TValue> dictionary)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedDictionary_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060035AC RID: 13740 RVA: 0x000DED28 File Offset: 0x000DCF28
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468026, XrefRangeEnd = 468029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060035AD RID: 13741 RVA: 0x000DED60 File Offset: 0x000DCF60
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468029, XrefRangeEnd = 468034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170010C6 RID: 4294
				// (get) Token: 0x060035AE RID: 13742 RVA: 0x000DEDA4 File Offset: 0x000DCFA4
				public unsafe TKey Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468034, XrefRangeEnd = 468041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
					}
				}

				// Token: 0x170010C7 RID: 4295
				// (get) Token: 0x060035AF RID: 13743 RVA: 0x000DEDE4 File Offset: 0x000DCFE4
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468041, XrefRangeEnd = 468047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x060035B0 RID: 13744 RVA: 0x000DEE28 File Offset: 0x000DD028
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468047, XrefRangeEnd = 468050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060035B1 RID: 13745 RVA: 0x0001A566 File Offset: 0x00018766
				public Enumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060035B2 RID: 13746 RVA: 0x0001A56F File Offset: 0x0001876F
				public Enumerator()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr))
				{
				}

				// Token: 0x170010C5 RID: 4293
				// (get) Token: 0x060035B3 RID: 13747 RVA: 0x000DEE60 File Offset: 0x000DD060
				// (set) Token: 0x060035B4 RID: 13748 RVA: 0x0001A581 File Offset: 0x00018781
				public SortedDictionary<TKey, TValue>.Enumerator _dictEnum
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr__dictEnum);
						return new SortedDictionary<TKey, TValue>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr__dictEnum), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400288C RID: 10380
				private static readonly IntPtr NativeFieldInfoPtr__dictEnum;

				// Token: 0x0400288D RID: 10381
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SortedDictionary_2_TKey_TValue_0;

				// Token: 0x0400288E RID: 10382
				private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

				// Token: 0x0400288F RID: 10383
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x04002890 RID: 10384
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TKey_0;

				// Token: 0x04002891 RID: 10385
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04002892 RID: 10386
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
			}

			// Token: 0x020003BE RID: 958
			[ObfuscatedName("System.Collections.Generic.SortedDictionary`2+KeyCollection+<>c__DisplayClass5_0")]
			public sealed class __c__DisplayClass5_0 : Object
			{
				// Token: 0x060035B5 RID: 13749 RVA: 0x000DEE90 File Offset: 0x000DD090
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass5_0()
				{
					Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, "<>c__DisplayClass5_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0>.NativeClassPtr);
					SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0.NativeFieldInfoPtr_array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0>.NativeClassPtr, "array");
					SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0>.NativeClassPtr, "index");
					SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0>.NativeClassPtr, 100666731);
					SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0.NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0>.NativeClassPtr, 100666732);
				}

				// Token: 0x060035B6 RID: 13750 RVA: 0x000DEF58 File Offset: 0x000DD158
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass5_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060035B7 RID: 13751 RVA: 0x000DEF94 File Offset: 0x000DD194
				[CallerCount(0)]
				public unsafe bool _CopyTo_b__0(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0.NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060035B8 RID: 13752 RVA: 0x0001A5AF File Offset: 0x000187AF
				public __c__DisplayClass5_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170010C8 RID: 4296
				// (get) Token: 0x060035B9 RID: 13753 RVA: 0x000DEFE4 File Offset: 0x000DD1E4
				// (set) Token: 0x060035BA RID: 13754 RVA: 0x0001A5B8 File Offset: 0x000187B8
				public unsafe Il2CppArrayBase<TKey> array
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0.NativeFieldInfoPtr_array);
						return Il2CppArrayBase<TKey>.WrapNativeGenericArrayPointer(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0.NativeFieldInfoPtr_array), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170010C9 RID: 4297
				// (get) Token: 0x060035BB RID: 13755 RVA: 0x000DF00C File Offset: 0x000DD20C
				// (set) Token: 0x060035BC RID: 13756 RVA: 0x0001A5D7 File Offset: 0x000187D7
				public unsafe int index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0.NativeFieldInfoPtr_index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0.NativeFieldInfoPtr_index)) = value;
					}
				}

				// Token: 0x04002893 RID: 10387
				private static readonly IntPtr NativeFieldInfoPtr_array;

				// Token: 0x04002894 RID: 10388
				private static readonly IntPtr NativeFieldInfoPtr_index;

				// Token: 0x04002895 RID: 10389
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04002896 RID: 10390
				private static readonly IntPtr NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0;
			}

			// Token: 0x020003BF RID: 959
			[ObfuscatedName("System.Collections.Generic.SortedDictionary`2+KeyCollection+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Object
			{
				// Token: 0x060035BD RID: 13757 RVA: 0x000DF034 File Offset: 0x000DD234
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, "<>c__DisplayClass6_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0>.NativeClassPtr);
					SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0>.NativeClassPtr, "index");
					SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0.NativeFieldInfoPtr_objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0>.NativeClassPtr, "objects");
					SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0>.NativeClassPtr, 100666733);
					SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0.NativeMethodInfoPtr__System_Collections_ICollection_CopyTo_b__0_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0>.NativeClassPtr, 100666734);
				}

				// Token: 0x060035BE RID: 13758 RVA: 0x000DF0FC File Offset: 0x000DD2FC
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060035BF RID: 13759 RVA: 0x000DF138 File Offset: 0x000DD338
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468050, XrefRangeEnd = 468053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _System_Collections_ICollection_CopyTo_b__0(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0.NativeMethodInfoPtr__System_Collections_ICollection_CopyTo_b__0_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060035C0 RID: 13760 RVA: 0x0001A5F2 File Offset: 0x000187F2
				public __c__DisplayClass6_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170010CA RID: 4298
				// (get) Token: 0x060035C1 RID: 13761 RVA: 0x000DF188 File Offset: 0x000DD388
				// (set) Token: 0x060035C2 RID: 13762 RVA: 0x0001A5FB File Offset: 0x000187FB
				public unsafe int index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0.NativeFieldInfoPtr_index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0.NativeFieldInfoPtr_index)) = value;
					}
				}

				// Token: 0x170010CB RID: 4299
				// (get) Token: 0x060035C3 RID: 13763 RVA: 0x000DF1B0 File Offset: 0x000DD3B0
				// (set) Token: 0x060035C4 RID: 13764 RVA: 0x0001A616 File Offset: 0x00018816
				public unsafe Il2CppReferenceArray<Object> objects
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0.NativeFieldInfoPtr_objects);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0.NativeFieldInfoPtr_objects), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04002897 RID: 10391
				private static readonly IntPtr NativeFieldInfoPtr_index;

				// Token: 0x04002898 RID: 10392
				private static readonly IntPtr NativeFieldInfoPtr_objects;

				// Token: 0x04002899 RID: 10393
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400289A RID: 10394
				private static readonly IntPtr NativeMethodInfoPtr__System_Collections_ICollection_CopyTo_b__0_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0;
			}
		}

		// Token: 0x020002F9 RID: 761
		[Serializable]
		public sealed class ValueCollection : Object
		{
			// Token: 0x06002D6A RID: 11626 RVA: 0x000C75A4 File Offset: 0x000C57A4
			// Note: this type is marked as 'beforefieldinit'.
			static ValueCollection()
			{
				Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, "ValueCollection"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr);
				SortedDictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr__dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, "_dictionary");
				SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr__ctor_Public_Void_SortedDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100666735);
				SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100666736);
				SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100666737);
				SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100666738);
				SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100666739);
				SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100666740);
				SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100666741);
				SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Add_Private_Virtual_Final_New_Void_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100666742);
				SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100666743);
				SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Contains_Private_Virtual_Final_New_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100666744);
				SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Remove_Private_Virtual_Final_New_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100666745);
				SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100666746);
				SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100666747);
			}

			// Token: 0x06002D6B RID: 11627 RVA: 0x000C7734 File Offset: 0x000C5934
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 468062, RefRangeEnd = 468067, XrefRangeStart = 468062, XrefRangeEnd = 468067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueCollection(SortedDictionary<TKey, TValue> dictionary)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr__ctor_Public_Void_SortedDictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D6C RID: 11628 RVA: 0x000C7780 File Offset: 0x000C5980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TValue> System_Collections_Generic_IEnumerable_TValue__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TValue>>(intPtr3) : null;
			}

			// Token: 0x06002D6D RID: 11629 RVA: 0x000C77C0 File Offset: 0x000C59C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002D6E RID: 11630 RVA: 0x000C7800 File Offset: 0x000C5A00
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 468102, RefRangeEnd = 468104, XrefRangeStart = 468102, XrefRangeEnd = 468104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D6F RID: 11631 RVA: 0x000C7850 File Offset: 0x000C5A50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468210, XrefRangeEnd = 468230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E43 RID: 3651
			// (get) Token: 0x06002D70 RID: 11632 RVA: 0x000C78A0 File Offset: 0x000C5AA0
			public unsafe int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E44 RID: 3652
			// (get) Token: 0x06002D71 RID: 11633 RVA: 0x000C78DC File Offset: 0x000C5ADC
			public unsafe bool System.Collections.Generic.ICollection<TValue>.IsReadOnly
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D72 RID: 11634 RVA: 0x000C7918 File Offset: 0x000C5B18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468230, XrefRangeEnd = 468235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Add_Private_Virtual_Final_New_Void_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x06002D73 RID: 11635 RVA: 0x000C7990 File Offset: 0x000C5B90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468235, XrefRangeEnd = 468243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_Generic_ICollection_TValue__Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D74 RID: 11636 RVA: 0x000C79C4 File Offset: 0x000C5BC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468243, XrefRangeEnd = 468254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Contains_Private_Virtual_Final_New_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06002D75 RID: 11637 RVA: 0x000C7A48 File Offset: 0x000C5C48
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Remove_Private_Virtual_Final_New_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x17000E45 RID: 3653
			// (get) Token: 0x06002D76 RID: 11638 RVA: 0x000C7ACC File Offset: 0x000C5CCC
			public unsafe bool System.Collections.ICollection.IsSynchronized
			{
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E46 RID: 3654
			// (get) Token: 0x06002D77 RID: 11639 RVA: 0x000C7B08 File Offset: 0x000C5D08
			public unsafe Object System.Collections.ICollection.SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468254, XrefRangeEnd = 468294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D78 RID: 11640 RVA: 0x00014674 File Offset: 0x00012874
			public ValueCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E42 RID: 3650
			// (get) Token: 0x06002D79 RID: 11641 RVA: 0x000C7B48 File Offset: 0x000C5D48
			// (set) Token: 0x06002D7A RID: 11642 RVA: 0x0001467D File Offset: 0x0001287D
			public unsafe SortedDictionary<TKey, TValue> _dictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr__dictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedDictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr__dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040023B5 RID: 9141
			private static readonly IntPtr NativeFieldInfoPtr__dictionary;

			// Token: 0x040023B6 RID: 9142
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SortedDictionary_2_TKey_TValue_0;

			// Token: 0x040023B7 RID: 9143
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TValue_0;

			// Token: 0x040023B8 RID: 9144
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x040023B9 RID: 9145
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TValue_Int32_0;

			// Token: 0x040023BA RID: 9146
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x040023BB RID: 9147
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x040023BC RID: 9148
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040023BD RID: 9149
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Add_Private_Virtual_Final_New_Void_TValue_0;

			// Token: 0x040023BE RID: 9150
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Clear_Private_Virtual_Final_New_Void_0;

			// Token: 0x040023BF RID: 9151
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Contains_Private_Virtual_Final_New_Boolean_TValue_0;

			// Token: 0x040023C0 RID: 9152
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Remove_Private_Virtual_Final_New_Boolean_TValue_0;

			// Token: 0x040023C1 RID: 9153
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040023C2 RID: 9154
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x020003C0 RID: 960
			public sealed class Enumerator : ValueType
			{
				// Token: 0x060035C5 RID: 13765 RVA: 0x000DF1E0 File Offset: 0x000DD3E0
				// Note: this type is marked as 'beforefieldinit'.
				static Enumerator()
				{
					Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr);
					SortedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr__dictEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, "_dictEnum");
					SortedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100666748);
					SortedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100666749);
					SortedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100666750);
					SortedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100666751);
					SortedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100666752);
					SortedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100666753);
				}

				// Token: 0x060035C6 RID: 13766 RVA: 0x000DF2E4 File Offset: 0x000DD4E4
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 468022, RefRangeEnd = 468026, XrefRangeStart = 468022, XrefRangeEnd = 468026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Enumerator(SortedDictionary<TKey, TValue> dictionary)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedDictionary_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060035C7 RID: 13767 RVA: 0x000DF334 File Offset: 0x000DD534
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060035C8 RID: 13768 RVA: 0x000DF36C File Offset: 0x000DD56C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170010CD RID: 4301
				// (get) Token: 0x060035C9 RID: 13769 RVA: 0x000DF3B0 File Offset: 0x000DD5B0
				public unsafe TValue Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468174, XrefRangeEnd = 468181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
					}
				}

				// Token: 0x170010CE RID: 4302
				// (get) Token: 0x060035CA RID: 13770 RVA: 0x000DF3F0 File Offset: 0x000DD5F0
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468181, XrefRangeEnd = 468207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x060035CB RID: 13771 RVA: 0x000DF434 File Offset: 0x000DD634
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060035CC RID: 13772 RVA: 0x0001A635 File Offset: 0x00018835
				public Enumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060035CD RID: 13773 RVA: 0x0001A63E File Offset: 0x0001883E
				public Enumerator()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr))
				{
				}

				// Token: 0x170010CC RID: 4300
				// (get) Token: 0x060035CE RID: 13774 RVA: 0x000DF46C File Offset: 0x000DD66C
				// (set) Token: 0x060035CF RID: 13775 RVA: 0x0001A650 File Offset: 0x00018850
				public SortedDictionary<TKey, TValue>.Enumerator _dictEnum
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr__dictEnum);
						return new SortedDictionary<TKey, TValue>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr__dictEnum), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400289B RID: 10395
				private static readonly IntPtr NativeFieldInfoPtr__dictEnum;

				// Token: 0x0400289C RID: 10396
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SortedDictionary_2_TKey_TValue_0;

				// Token: 0x0400289D RID: 10397
				private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

				// Token: 0x0400289E RID: 10398
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x0400289F RID: 10399
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TValue_0;

				// Token: 0x040028A0 RID: 10400
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040028A1 RID: 10401
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
			}

			// Token: 0x020003C1 RID: 961
			[ObfuscatedName("System.Collections.Generic.SortedDictionary`2+ValueCollection+<>c__DisplayClass5_0")]
			public sealed class __c__DisplayClass5_0 : Object
			{
				// Token: 0x060035D0 RID: 13776 RVA: 0x000DF49C File Offset: 0x000DD69C
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass5_0()
				{
					Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, "<>c__DisplayClass5_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass5_0>.NativeClassPtr);
					SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass5_0.NativeFieldInfoPtr_array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass5_0>.NativeClassPtr, "array");
					SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass5_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass5_0>.NativeClassPtr, "index");
					SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass5_0>.NativeClassPtr, 100666754);
					SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass5_0.NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass5_0>.NativeClassPtr, 100666755);
				}

				// Token: 0x060035D1 RID: 13777 RVA: 0x000DF564 File Offset: 0x000DD764
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass5_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass5_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060035D2 RID: 13778 RVA: 0x000DF5A0 File Offset: 0x000DD7A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468207, XrefRangeEnd = 468208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _CopyTo_b__0(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass5_0.NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060035D3 RID: 13779 RVA: 0x0001A67E File Offset: 0x0001887E
				public __c__DisplayClass5_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170010CF RID: 4303
				// (get) Token: 0x060035D4 RID: 13780 RVA: 0x000DF5F0 File Offset: 0x000DD7F0
				// (set) Token: 0x060035D5 RID: 13781 RVA: 0x0001A687 File Offset: 0x00018887
				public unsafe Il2CppArrayBase<TValue> array
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass5_0.NativeFieldInfoPtr_array);
						return Il2CppArrayBase<TValue>.WrapNativeGenericArrayPointer(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass5_0.NativeFieldInfoPtr_array), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170010D0 RID: 4304
				// (get) Token: 0x060035D6 RID: 13782 RVA: 0x000DF618 File Offset: 0x000DD818
				// (set) Token: 0x060035D7 RID: 13783 RVA: 0x0001A6A6 File Offset: 0x000188A6
				public unsafe int index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass5_0.NativeFieldInfoPtr_index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass5_0.NativeFieldInfoPtr_index)) = value;
					}
				}

				// Token: 0x040028A2 RID: 10402
				private static readonly IntPtr NativeFieldInfoPtr_array;

				// Token: 0x040028A3 RID: 10403
				private static readonly IntPtr NativeFieldInfoPtr_index;

				// Token: 0x040028A4 RID: 10404
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040028A5 RID: 10405
				private static readonly IntPtr NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0;
			}

			// Token: 0x020003C2 RID: 962
			[ObfuscatedName("System.Collections.Generic.SortedDictionary`2+ValueCollection+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Object
			{
				// Token: 0x060035D8 RID: 13784 RVA: 0x000DF640 File Offset: 0x000DD840
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, "<>c__DisplayClass6_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass6_0>.NativeClassPtr);
					SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass6_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass6_0>.NativeClassPtr, "index");
					SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass6_0.NativeFieldInfoPtr_objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass6_0>.NativeClassPtr, "objects");
					SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass6_0>.NativeClassPtr, 100666756);
					SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass6_0.NativeMethodInfoPtr__System_Collections_ICollection_CopyTo_b__0_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass6_0>.NativeClassPtr, 100666757);
				}

				// Token: 0x060035D9 RID: 13785 RVA: 0x000DF708 File Offset: 0x000DD908
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass6_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060035DA RID: 13786 RVA: 0x000DF744 File Offset: 0x000DD944
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468208, XrefRangeEnd = 468210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _System_Collections_ICollection_CopyTo_b__0(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass6_0.NativeMethodInfoPtr__System_Collections_ICollection_CopyTo_b__0_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060035DB RID: 13787 RVA: 0x0001A6C1 File Offset: 0x000188C1
				public __c__DisplayClass6_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170010D1 RID: 4305
				// (get) Token: 0x060035DC RID: 13788 RVA: 0x000DF794 File Offset: 0x000DD994
				// (set) Token: 0x060035DD RID: 13789 RVA: 0x0001A6CA File Offset: 0x000188CA
				public unsafe int index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass6_0.NativeFieldInfoPtr_index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass6_0.NativeFieldInfoPtr_index)) = value;
					}
				}

				// Token: 0x170010D2 RID: 4306
				// (get) Token: 0x060035DE RID: 13790 RVA: 0x000DF7BC File Offset: 0x000DD9BC
				// (set) Token: 0x060035DF RID: 13791 RVA: 0x0001A6E5 File Offset: 0x000188E5
				public unsafe Il2CppReferenceArray<Object> objects
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass6_0.NativeFieldInfoPtr_objects);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.ValueCollection.__c__DisplayClass6_0.NativeFieldInfoPtr_objects), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040028A6 RID: 10406
				private static readonly IntPtr NativeFieldInfoPtr_index;

				// Token: 0x040028A7 RID: 10407
				private static readonly IntPtr NativeFieldInfoPtr_objects;

				// Token: 0x040028A8 RID: 10408
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040028A9 RID: 10409
				private static readonly IntPtr NativeMethodInfoPtr__System_Collections_ICollection_CopyTo_b__0_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0;
			}
		}

		// Token: 0x020002FA RID: 762
		[Serializable]
		public sealed class KeyValuePairComparer : Comparer<KeyValuePair<TKey, TValue>>
		{
			// Token: 0x06002D7B RID: 11643 RVA: 0x000C7B78 File Offset: 0x000C5D78
			// Note: this type is marked as 'beforefieldinit'.
			static KeyValuePairComparer()
			{
				Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyValuePairComparer>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, "KeyValuePairComparer"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyValuePairComparer>.NativeClassPtr);
				SortedDictionary<TKey, TValue>.KeyValuePairComparer.NativeFieldInfoPtr_keyComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyValuePairComparer>.NativeClassPtr, "keyComparer");
				SortedDictionary<TKey, TValue>.KeyValuePairComparer.NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyValuePairComparer>.NativeClassPtr, 100666758);
				SortedDictionary<TKey, TValue>.KeyValuePairComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_KeyValuePair_2_TKey_TValue_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyValuePairComparer>.NativeClassPtr, 100666759);
			}

			// Token: 0x06002D7C RID: 11644 RVA: 0x000C7C2C File Offset: 0x000C5E2C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 468343, RefRangeEnd = 468345, XrefRangeStart = 468294, XrefRangeEnd = 468343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePairComparer(IComparer<TKey> keyComparer)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyValuePairComparer>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyComparer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyValuePairComparer.NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D7D RID: 11645 RVA: 0x000C7C78 File Offset: 0x000C5E78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 468345, XrefRangeEnd = 468353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Compare(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyValuePairComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_KeyValuePair_2_TKey_TValue_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002D7E RID: 11646 RVA: 0x0001469C File Offset: 0x0001289C
			public KeyValuePairComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E47 RID: 3655
			// (get) Token: 0x06002D7F RID: 11647 RVA: 0x000C7CE4 File Offset: 0x000C5EE4
			// (set) Token: 0x06002D80 RID: 11648 RVA: 0x000146A5 File Offset: 0x000128A5
			public unsafe IComparer<TKey> keyComparer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyValuePairComparer.NativeFieldInfoPtr_keyComparer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer<TKey>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyValuePairComparer.NativeFieldInfoPtr_keyComparer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040023C3 RID: 9155
			private static readonly IntPtr NativeFieldInfoPtr_keyComparer;

			// Token: 0x040023C4 RID: 9156
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_TKey_0;

			// Token: 0x040023C5 RID: 9157
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Int32_KeyValuePair_2_TKey_TValue_KeyValuePair_2_TKey_TValue_0;
		}

		// Token: 0x020002FB RID: 763
		[ObfuscatedName("System.Collections.Generic.SortedDictionary`2+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : Object
		{
			// Token: 0x06002D81 RID: 11649 RVA: 0x000C7D14 File Offset: 0x000C5F14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, "<>c__DisplayClass34_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.__c__DisplayClass34_0>.NativeClassPtr);
				SortedDictionary<TKey, TValue>.__c__DisplayClass34_0.NativeFieldInfoPtr_found = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.__c__DisplayClass34_0>.NativeClassPtr, "found");
				SortedDictionary<TKey, TValue>.__c__DisplayClass34_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.__c__DisplayClass34_0>.NativeClassPtr, "value");
				SortedDictionary<TKey, TValue>.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.__c__DisplayClass34_0>.NativeClassPtr, 100666760);
				SortedDictionary<TKey, TValue>.__c__DisplayClass34_0.NativeMethodInfoPtr__ContainsValue_b__0_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.__c__DisplayClass34_0>.NativeClassPtr, 100666761);
			}

			// Token: 0x06002D82 RID: 11650 RVA: 0x000C7DDC File Offset: 0x000C5FDC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D83 RID: 11651 RVA: 0x000C7E18 File Offset: 0x000C6018
			[CallerCount(0)]
			public unsafe bool _ContainsValue_b__0(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.__c__DisplayClass34_0.NativeMethodInfoPtr__ContainsValue_b__0_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D84 RID: 11652 RVA: 0x000146C4 File Offset: 0x000128C4
			public __c__DisplayClass34_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E48 RID: 3656
			// (get) Token: 0x06002D85 RID: 11653 RVA: 0x000C7E68 File Offset: 0x000C6068
			// (set) Token: 0x06002D86 RID: 11654 RVA: 0x000146CD File Offset: 0x000128CD
			public unsafe bool found
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.__c__DisplayClass34_0.NativeFieldInfoPtr_found);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.__c__DisplayClass34_0.NativeFieldInfoPtr_found)) = value;
				}
			}

			// Token: 0x17000E49 RID: 3657
			// (get) Token: 0x06002D87 RID: 11655 RVA: 0x000C7E90 File Offset: 0x000C6090
			// (set) Token: 0x06002D88 RID: 11656 RVA: 0x000C7EB8 File Offset: 0x000C60B8
			public unsafe TValue value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.__c__DisplayClass34_0.NativeFieldInfoPtr_value);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.__c__DisplayClass34_0.NativeFieldInfoPtr_value);
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

			// Token: 0x040023C6 RID: 9158
			private static readonly IntPtr NativeFieldInfoPtr_found;

			// Token: 0x040023C7 RID: 9159
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040023C8 RID: 9160
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040023C9 RID: 9161
			private static readonly IntPtr NativeMethodInfoPtr__ContainsValue_b__0_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0;
		}

		// Token: 0x020002FC RID: 764
		[ObfuscatedName("System.Collections.Generic.SortedDictionary`2+<>c__DisplayClass34_1")]
		public sealed class __c__DisplayClass34_1 : Object
		{
			// Token: 0x06002D89 RID: 11657 RVA: 0x000C7F60 File Offset: 0x000C6160
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_1()
			{
				Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.__c__DisplayClass34_1>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, "<>c__DisplayClass34_1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.__c__DisplayClass34_1>.NativeClassPtr);
				SortedDictionary<TKey, TValue>.__c__DisplayClass34_1.NativeFieldInfoPtr_valueComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.__c__DisplayClass34_1>.NativeClassPtr, "valueComparer");
				SortedDictionary<TKey, TValue>.__c__DisplayClass34_1.NativeFieldInfoPtr_field_Public___c__DisplayClass34_0_TKey_TValue_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.__c__DisplayClass34_1>.NativeClassPtr, "CS$<>8__locals1");
				SortedDictionary<TKey, TValue>.__c__DisplayClass34_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.__c__DisplayClass34_1>.NativeClassPtr, 100666762);
				SortedDictionary<TKey, TValue>.__c__DisplayClass34_1.NativeMethodInfoPtr__ContainsValue_b__1_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.__c__DisplayClass34_1>.NativeClassPtr, 100666763);
			}

			// Token: 0x06002D8A RID: 11658 RVA: 0x000C8028 File Offset: 0x000C6228
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.__c__DisplayClass34_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.__c__DisplayClass34_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D8B RID: 11659 RVA: 0x000C8064 File Offset: 0x000C6264
			[CallerCount(0)]
			public unsafe bool _ContainsValue_b__1(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.__c__DisplayClass34_1.NativeMethodInfoPtr__ContainsValue_b__1_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D8C RID: 11660 RVA: 0x000146E8 File Offset: 0x000128E8
			public __c__DisplayClass34_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E4A RID: 3658
			// (get) Token: 0x06002D8D RID: 11661 RVA: 0x000C80B4 File Offset: 0x000C62B4
			// (set) Token: 0x06002D8E RID: 11662 RVA: 0x000146F1 File Offset: 0x000128F1
			public unsafe EqualityComparer<TValue> valueComparer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.__c__DisplayClass34_1.NativeFieldInfoPtr_valueComparer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EqualityComparer<TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.__c__DisplayClass34_1.NativeFieldInfoPtr_valueComparer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E4B RID: 3659
			// (get) Token: 0x06002D8F RID: 11663 RVA: 0x000C80E4 File Offset: 0x000C62E4
			// (set) Token: 0x06002D90 RID: 11664 RVA: 0x00014710 File Offset: 0x00012910
			public unsafe SortedDictionary<TKey, TValue>.__c__DisplayClass34_0 field_Public___c__DisplayClass34_0_TKey_TValue_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.__c__DisplayClass34_1.NativeFieldInfoPtr_field_Public___c__DisplayClass34_0_TKey_TValue_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedDictionary<TKey, TValue>.__c__DisplayClass34_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.__c__DisplayClass34_1.NativeFieldInfoPtr_field_Public___c__DisplayClass34_0_TKey_TValue_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040023CA RID: 9162
			private static readonly IntPtr NativeFieldInfoPtr_valueComparer;

			// Token: 0x040023CB RID: 9163
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass34_0_TKey_TValue_0;

			// Token: 0x040023CC RID: 9164
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040023CD RID: 9165
			private static readonly IntPtr NativeMethodInfoPtr__ContainsValue_b__1_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0;
		}
	}
}
