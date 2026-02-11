using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000050 RID: 80
	public class DictionaryWrapper<TKey, TValue> : Object
	{
		// Token: 0x0600076A RID: 1898 RVA: 0x000348F8 File Offset: 0x00032AF8
		// Note: this type is marked as 'beforefieldinit'.
		static DictionaryWrapper()
		{
			Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "DictionaryWrapper`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr);
			DictionaryWrapper<TKey, TValue>.NativeFieldInfoPtr__dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, "_dictionary");
			DictionaryWrapper<TKey, TValue>.NativeFieldInfoPtr__genericDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, "_genericDictionary");
			DictionaryWrapper<TKey, TValue>.NativeFieldInfoPtr__readOnlyDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, "_readOnlyDictionary");
			DictionaryWrapper<TKey, TValue>.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, "_syncRoot");
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664696);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664697);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664698);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_get_GenericDictionary_Internal_get_IDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664699);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664700);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664701);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664702);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664703);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664704);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664705);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664706);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664707);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664708);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664709);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664710);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664711);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664712);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664713);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664714);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664715);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664716);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664717);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664718);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664719);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664720);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664721);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664722);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664723);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664724);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664725);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664726);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664727);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664728);
			DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_get_UnderlyingDictionary_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, 100664729);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00034C70 File Offset: 0x00032E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 741998, XrefRangeEnd = 742003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DictionaryWrapper(IDictionary dictionary)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00034CBC File Offset: 0x00032EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742003, XrefRangeEnd = 742008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DictionaryWrapper(IDictionary<TKey, TValue> dictionary)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00034D08 File Offset: 0x00032F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742008, XrefRangeEnd = 742013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DictionaryWrapper(IReadOnlyDictionary<TKey, TValue> dictionary)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyDictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x00034D54 File Offset: 0x00032F54
		public unsafe IDictionary<TKey, TValue> GenericDictionary
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_get_GenericDictionary_Internal_get_IDictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<TKey, TValue>>(intPtr3) : null;
			}
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00034D94 File Offset: 0x00032F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742013, XrefRangeEnd = 742020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00034E54 File Offset: 0x00033054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742020, XrefRangeEnd = 742025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x00034ED8 File Offset: 0x000330D8
		public unsafe virtual ICollection<TKey> Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742025, XrefRangeEnd = 742034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<TKey>>(intPtr3) : null;
			}
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00034F18 File Offset: 0x00033118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742034, XrefRangeEnd = 742039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00034F9C File Offset: 0x0003319C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742039, XrefRangeEnd = 742045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x00035070 File Offset: 0x00033270
		public unsafe virtual ICollection<TValue> Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742045, XrefRangeEnd = 742054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<TValue>>(intPtr3) : null;
			}
		}

		// Token: 0x170001DF RID: 479
		public unsafe virtual TValue this[TKey key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742054, XrefRangeEnd = 742064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742064, XrefRangeEnd = 742071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			}
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x000351F0 File Offset: 0x000333F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742071, XrefRangeEnd = 742076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(KeyValuePair<TKey, TValue> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00035238 File Offset: 0x00033438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742076, XrefRangeEnd = 742086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0003526C File Offset: 0x0003346C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742086, XrefRangeEnd = 742091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(KeyValuePair<TKey, TValue> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x000352C0 File Offset: 0x000334C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742091, XrefRangeEnd = 742126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppReferenceArray<KeyValuePair<TKey, TValue>> array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x00035310 File Offset: 0x00033510
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742126, XrefRangeEnd = 742133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x0003534C File Offset: 0x0003354C
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742133, XrefRangeEnd = 742136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00035388 File Offset: 0x00033588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742136, XrefRangeEnd = 742143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(KeyValuePair<TKey, TValue> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x000353DC File Offset: 0x000335DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742143, XrefRangeEnd = 742162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0003541C File Offset: 0x0003361C
		[CallerCount(0)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0003545C File Offset: 0x0003365C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742162, XrefRangeEnd = 742171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x000354B0 File Offset: 0x000336B0
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x00035500 File Offset: 0x00033700
		public unsafe virtual Object System.Collections.IDictionary.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742171, XrefRangeEnd = 742183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742183, XrefRangeEnd = 742192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00035554 File Offset: 0x00033754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742192, XrefRangeEnd = 742201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator System_Collections_IDictionary_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00035594 File Offset: 0x00033794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742201, XrefRangeEnd = 742210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IDictionary_Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x000355E4 File Offset: 0x000337E4
		public unsafe virtual bool System.Collections.IDictionary.IsFixedSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742210, XrefRangeEnd = 742213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x00035620 File Offset: 0x00033820
		public unsafe virtual ICollection System.Collections.IDictionary.Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742213, XrefRangeEnd = 742221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00035660 File Offset: 0x00033860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742221, XrefRangeEnd = 742227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Remove(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x000356A4 File Offset: 0x000338A4
		public unsafe virtual ICollection System.Collections.IDictionary.Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742227, XrefRangeEnd = 742235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x000356E4 File Offset: 0x000338E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742235, XrefRangeEnd = 742241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x00035734 File Offset: 0x00033934
		public unsafe virtual bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742241, XrefRangeEnd = 742242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x00035770 File Offset: 0x00033970
		public unsafe virtual Object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742242, XrefRangeEnd = 742247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x000357B0 File Offset: 0x000339B0
		public unsafe virtual Object UnderlyingDictionary
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.NativeMethodInfoPtr_get_UnderlyingDictionary_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00004528 File Offset: 0x00002728
		public DictionaryWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x000357F0 File Offset: 0x000339F0
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x00004531 File Offset: 0x00002731
		public unsafe IDictionary _dictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryWrapper<TKey, TValue>.NativeFieldInfoPtr__dictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryWrapper<TKey, TValue>.NativeFieldInfoPtr__dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00035820 File Offset: 0x00033A20
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x00004550 File Offset: 0x00002750
		public unsafe IDictionary<TKey, TValue> _genericDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryWrapper<TKey, TValue>.NativeFieldInfoPtr__genericDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<TKey, TValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryWrapper<TKey, TValue>.NativeFieldInfoPtr__genericDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x00035850 File Offset: 0x00033A50
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x0000456F File Offset: 0x0000276F
		public unsafe IReadOnlyDictionary<TKey, TValue> _readOnlyDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryWrapper<TKey, TValue>.NativeFieldInfoPtr__readOnlyDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<TKey, TValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryWrapper<TKey, TValue>.NativeFieldInfoPtr__readOnlyDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x00035880 File Offset: 0x00033A80
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x0000458E File Offset: 0x0000278E
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryWrapper<TKey, TValue>.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryWrapper<TKey, TValue>.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeFieldInfoPtr__dictionary;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeFieldInfoPtr__genericDictionary;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeFieldInfoPtr__readOnlyDictionary;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyDictionary_2_TKey_TValue_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericDictionary_Internal_get_IDictionary_2_TKey_TValue_0;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_TKey_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_TValue_0;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Add_Private_Virtual_Final_New_Void_Object_Object_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Values_Private_Virtual_Final_New_get_ICollection_0;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_get_UnderlyingDictionary_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x0200017F RID: 383
		public sealed class DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue> : ValueType
		{
			// Token: 0x06001C4A RID: 7242 RVA: 0x00085C04 File Offset: 0x00083E04
			// Note: this type is marked as 'beforefieldinit'.
			static DictionaryEnumerator()
			{
				Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, "DictionaryEnumerator`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnumeratorKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnumeratorValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>>.NativeClassPtr);
				DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>.NativeFieldInfoPtr__e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>>.NativeClassPtr, "_e");
				DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_1_KeyValuePair_2_TEnumeratorKey_TEnumeratorValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>>.NativeClassPtr, 100664730);
				DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>>.NativeClassPtr, 100664731);
				DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>>.NativeClassPtr, 100664732);
				DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>>.NativeClassPtr, 100664733);
				DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>>.NativeClassPtr, 100664734);
				DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>>.NativeClassPtr, 100664735);
				DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>>.NativeClassPtr, 100664736);
			}

			// Token: 0x06001C4B RID: 7243 RVA: 0x00085D40 File Offset: 0x00083F40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 741932, XrefRangeEnd = 741936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictionaryEnumerator(IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_1_KeyValuePair_2_TEnumeratorKey_TEnumeratorValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170007FB RID: 2043
			// (get) Token: 0x06001C4C RID: 7244 RVA: 0x00085D90 File Offset: 0x00083F90
			public unsafe DictionaryEntry Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 741936, XrefRangeEnd = 741941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x170007FC RID: 2044
			// (get) Token: 0x06001C4D RID: 7245 RVA: 0x00085DCC File Offset: 0x00083FCC
			public unsafe Object Key
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 741941, XrefRangeEnd = 741943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170007FD RID: 2045
			// (get) Token: 0x06001C4E RID: 7246 RVA: 0x00085E10 File Offset: 0x00084010
			public unsafe Object Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 741943, XrefRangeEnd = 741945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170007FE RID: 2046
			// (get) Token: 0x06001C4F RID: 7247 RVA: 0x00085E54 File Offset: 0x00084054
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 741945, XrefRangeEnd = 741974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C50 RID: 7248 RVA: 0x00085E98 File Offset: 0x00084098
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 741974, XrefRangeEnd = 741978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001C51 RID: 7249 RVA: 0x00085EDC File Offset: 0x000840DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 741978, XrefRangeEnd = 741982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C52 RID: 7250 RVA: 0x0000DEC8 File Offset: 0x0000C0C8
			public DictionaryEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C53 RID: 7251 RVA: 0x0000DED1 File Offset: 0x0000C0D1
			public DictionaryEnumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>>.NativeClassPtr))
			{
			}

			// Token: 0x170007FA RID: 2042
			// (get) Token: 0x06001C54 RID: 7252 RVA: 0x00085F14 File Offset: 0x00084114
			// (set) Token: 0x06001C55 RID: 7253 RVA: 0x0000DEE3 File Offset: 0x0000C0E3
			public unsafe IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>.NativeFieldInfoPtr__e);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictionaryWrapper<TKey, TValue>.DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue>.NativeFieldInfoPtr__e), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001510 RID: 5392
			private static readonly IntPtr NativeFieldInfoPtr__e;

			// Token: 0x04001511 RID: 5393
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_1_KeyValuePair_2_TEnumeratorKey_TEnumeratorValue_0;

			// Token: 0x04001512 RID: 5394
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x04001513 RID: 5395
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04001514 RID: 5396
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04001515 RID: 5397
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04001516 RID: 5398
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04001517 RID: 5399
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000180 RID: 384
		[ObfuscatedName("Newtonsoft.Json.Utilities.DictionaryWrapper`2+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001C56 RID: 7254 RVA: 0x00085F44 File Offset: 0x00084144
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>.__c>.NativeClassPtr);
				DictionaryWrapper<TKey, TValue>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>.__c>.NativeClassPtr, "<>9");
				DictionaryWrapper<TKey, TValue>.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>.__c>.NativeClassPtr, "<>9__29_0");
				DictionaryWrapper<TKey, TValue>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>.__c>.NativeClassPtr, 100664738);
				DictionaryWrapper<TKey, TValue>.__c.NativeMethodInfoPtr__GetEnumerator_b__29_0_Internal_KeyValuePair_2_TKey_TValue_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>.__c>.NativeClassPtr, 100664739);
			}

			// Token: 0x06001C57 RID: 7255 RVA: 0x0008600C File Offset: 0x0008420C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictionaryWrapper<TKey, TValue>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C58 RID: 7256 RVA: 0x00086048 File Offset: 0x00084248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 741982, XrefRangeEnd = 741998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<TKey, TValue> _GetEnumerator_b__29_0(DictionaryEntry de)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(de));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryWrapper<TKey, TValue>.__c.NativeMethodInfoPtr__GetEnumerator_b__29_0_Internal_KeyValuePair_2_TKey_TValue_DictionaryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<TKey, TValue>(intPtr);
				}
			}

			// Token: 0x06001C59 RID: 7257 RVA: 0x0000DF02 File Offset: 0x0000C102
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007FF RID: 2047
			// (get) Token: 0x06001C5A RID: 7258 RVA: 0x00086098 File Offset: 0x00084298
			// (set) Token: 0x06001C5B RID: 7259 RVA: 0x0000DF0B File Offset: 0x0000C10B
			public unsafe static DictionaryWrapper<TKey, TValue>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DictionaryWrapper<TKey, TValue>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DictionaryWrapper<TKey, TValue>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DictionaryWrapper<TKey, TValue>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000800 RID: 2048
			// (get) Token: 0x06001C5C RID: 7260 RVA: 0x000860C0 File Offset: 0x000842C0
			// (set) Token: 0x06001C5D RID: 7261 RVA: 0x0000DF1D File Offset: 0x0000C11D
			public unsafe static Func<DictionaryEntry, KeyValuePair<TKey, TValue>> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DictionaryWrapper<TKey, TValue>.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DictionaryEntry, KeyValuePair<TKey, TValue>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DictionaryWrapper<TKey, TValue>.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001518 RID: 5400
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001519 RID: 5401
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x0400151A RID: 5402
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400151B RID: 5403
			private static readonly IntPtr NativeMethodInfoPtr__GetEnumerator_b__29_0_Internal_KeyValuePair_2_TKey_TValue_DictionaryEntry_0;
		}
	}
}
