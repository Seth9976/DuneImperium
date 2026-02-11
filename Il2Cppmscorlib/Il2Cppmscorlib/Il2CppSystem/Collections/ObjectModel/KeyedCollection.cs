using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Collections.ObjectModel
{
	// Token: 0x020004D9 RID: 1241
	[Serializable]
	public class KeyedCollection<TKey, TItem> : Collection<TItem>
	{
		// Token: 0x06004CD3 RID: 19667 RVA: 0x0016397C File Offset: 0x00161B7C
		// Note: this type is marked as 'beforefieldinit'.
		static KeyedCollection()
		{
			Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.ObjectModel", "KeyedCollection`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TItem>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr);
			KeyedCollection<TKey, TItem>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr, "comparer");
			KeyedCollection<TKey, TItem>.NativeFieldInfoPtr_dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr, "dict");
			KeyedCollection<TKey, TItem>.NativeFieldInfoPtr_keyCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr, "keyCount");
			KeyedCollection<TKey, TItem>.NativeFieldInfoPtr_threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr, "threshold");
			KeyedCollection<TKey, TItem>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr, 100674743);
			KeyedCollection<TKey, TItem>.NativeMethodInfoPtr__ctor_Protected_Void_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr, 100674744);
			KeyedCollection<TKey, TItem>.NativeMethodInfoPtr__ctor_Protected_Void_IEqualityComparer_1_TKey_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr, 100674745);
			KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_get_Items_Private_get_List_1_TItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr, 100674746);
			KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_get_Item_Public_get_TItem_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr, 100674747);
			KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_Contains_Public_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr, 100674748);
			KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_TKey_byref_TItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr, 100674749);
			KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_get_Dictionary_Protected_get_IDictionary_2_TKey_TItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr, 100674750);
			KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_ClearItems_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr, 100674751);
			KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_GetKeyForItem_Protected_Abstract_Virtual_New_TKey_TItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr, 100674752);
			KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_InsertItem_Protected_Virtual_Void_Int32_TItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr, 100674753);
			KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_RemoveItem_Protected_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr, 100674754);
			KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_SetItem_Protected_Virtual_Void_Int32_TItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr, 100674755);
			KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_AddKey_Private_Void_TKey_TItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr, 100674756);
			KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_CreateDictionary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr, 100674757);
			KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_RemoveKey_Private_Void_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr, 100674758);
		}

		// Token: 0x06004CD4 RID: 19668 RVA: 0x00163B8C File Offset: 0x00161D8C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1418845, RefRangeEnd = 1418850, XrefRangeStart = 1418841, XrefRangeEnd = 1418845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyedCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedCollection<TKey, TItem>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CD5 RID: 19669 RVA: 0x00163BC8 File Offset: 0x00161DC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1418866, RefRangeEnd = 1418867, XrefRangeStart = 1418850, XrefRangeEnd = 1418866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyedCollection(IEqualityComparer<TKey> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedCollection<TKey, TItem>.NativeMethodInfoPtr__ctor_Protected_Void_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004CD6 RID: 19670 RVA: 0x00163C14 File Offset: 0x00161E14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1418883, RefRangeEnd = 1418884, XrefRangeStart = 1418867, XrefRangeEnd = 1418883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyedCollection(IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyedCollection<TKey, TItem>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dictionaryCreationThreshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedCollection<TKey, TItem>.NativeMethodInfoPtr__ctor_Protected_Void_IEqualityComparer_1_TKey_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x06004CD7 RID: 19671 RVA: 0x00163C70 File Offset: 0x00161E70
		public new unsafe List<TItem> Items
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418884, XrefRangeEnd = 1418885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_get_Items_Private_get_List_1_TItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TItem>>(intPtr3) : null;
			}
		}

		// Token: 0x170013C7 RID: 5063
		public unsafe TItem this[TKey key]
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1418886, RefRangeEnd = 1418893, XrefRangeStart = 1418885, XrefRangeEnd = 1418886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_get_Item_Public_get_TItem_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<TItem>(intPtr2, false, true);
				}
			}
		}

		// Token: 0x06004CD9 RID: 19673 RVA: 0x00163D30 File Offset: 0x00161F30
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1418899, RefRangeEnd = 1418908, XrefRangeStart = 1418893, XrefRangeEnd = 1418899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(TKey key)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_Contains_Public_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004CDA RID: 19674 RVA: 0x00163DB4 File Offset: 0x00161FB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1418915, RefRangeEnd = 1418916, XrefRangeStart = 1418908, XrefRangeEnd = 1418915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(TKey key, out TItem item)
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
			if (!typeof(TItem).IsValueType)
			{
				intPtr2 = 0;
				intPtr3 = &intPtr2;
			}
			else
			{
				intPtr3 = ref item;
			}
			ptr3 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_TKey_byref_TItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TItem).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				item = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TItem>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x06004CDB RID: 19675 RVA: 0x00163E88 File Offset: 0x00162088
		public unsafe IDictionary<TKey, TItem> Dictionary
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_get_Dictionary_Protected_get_IDictionary_2_TKey_TItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<TKey, TItem>>(intPtr3) : null;
			}
		}

		// Token: 0x06004CDC RID: 19676 RVA: 0x00163EC8 File Offset: 0x001620C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418916, XrefRangeEnd = 1418918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_ClearItems_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CDD RID: 19677 RVA: 0x00163F04 File Offset: 0x00162104
		[CallerCount(0)]
		public unsafe virtual TKey GetKeyForItem(TItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TItem).IsValueType)
				{
					TItem titem = item;
					intPtr = ((titem is string) ? IL2CPP.ManagedStringToIl2Cpp(titem as string) : IL2CPP.Il2CppObjectBaseToPtr(titem as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_GetKeyForItem_Protected_Abstract_Virtual_New_TKey_TItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<TKey>(intPtr2, false, true);
			}
		}

		// Token: 0x06004CDE RID: 19678 RVA: 0x00163F90 File Offset: 0x00162190
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1418932, RefRangeEnd = 1418933, XrefRangeStart = 1418918, XrefRangeEnd = 1418932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InsertItem(int index, TItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TItem).IsValueType)
			{
				TItem titem = item;
				intPtr = ((titem is string) ? IL2CPP.ManagedStringToIl2Cpp(titem as string) : IL2CPP.Il2CppObjectBaseToPtr(titem as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref item;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_InsertItem_Protected_Virtual_Void_Int32_TItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06004CDF RID: 19679 RVA: 0x00164024 File Offset: 0x00162224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1418949, RefRangeEnd = 1418950, XrefRangeStart = 1418933, XrefRangeEnd = 1418949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RemoveItem(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_RemoveItem_Protected_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004CE0 RID: 19680 RVA: 0x00164070 File Offset: 0x00162270
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1418992, RefRangeEnd = 1418993, XrefRangeStart = 1418950, XrefRangeEnd = 1418992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetItem(int index, TItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TItem).IsValueType)
			{
				TItem titem = item;
				intPtr = ((titem is string) ? IL2CPP.ManagedStringToIl2Cpp(titem as string) : IL2CPP.Il2CppObjectBaseToPtr(titem as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref item;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_SetItem_Protected_Virtual_Void_Int32_TItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06004CE1 RID: 19681 RVA: 0x00164104 File Offset: 0x00162304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418993, XrefRangeEnd = 1418997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKey(TKey key, TItem item)
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
			if (!typeof(TItem).IsValueType)
			{
				TItem titem = item;
				intPtr2 = ((titem is string) ? IL2CPP.ManagedStringToIl2Cpp(titem as string) : IL2CPP.Il2CppObjectBaseToPtr(titem as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref item;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_AddKey_Private_Void_TKey_TItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x06004CE2 RID: 19682 RVA: 0x001641C4 File Offset: 0x001623C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1419009, RefRangeEnd = 1419010, XrefRangeStart = 1418997, XrefRangeEnd = 1419009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_CreateDictionary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CE3 RID: 19683 RVA: 0x001641F8 File Offset: 0x001623F8
		[CallerCount(0)]
		public unsafe void RemoveKey(TKey key)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(KeyedCollection<TKey, TItem>.NativeMethodInfoPtr_RemoveKey_Private_Void_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06004CE4 RID: 19684 RVA: 0x0001BE82 File Offset: 0x0001A082
		public KeyedCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x06004CE5 RID: 19685 RVA: 0x00164270 File Offset: 0x00162470
		// (set) Token: 0x06004CE6 RID: 19686 RVA: 0x0001BE8B File Offset: 0x0001A08B
		public unsafe IEqualityComparer<TKey> comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyedCollection<TKey, TItem>.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyedCollection<TKey, TItem>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x06004CE7 RID: 19687 RVA: 0x001642A0 File Offset: 0x001624A0
		// (set) Token: 0x06004CE8 RID: 19688 RVA: 0x0001BEAA File Offset: 0x0001A0AA
		public unsafe Dictionary<TKey, TItem> dict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyedCollection<TKey, TItem>.NativeFieldInfoPtr_dict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyedCollection<TKey, TItem>.NativeFieldInfoPtr_dict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x06004CE9 RID: 19689 RVA: 0x001642D0 File Offset: 0x001624D0
		// (set) Token: 0x06004CEA RID: 19690 RVA: 0x0001BEC9 File Offset: 0x0001A0C9
		public unsafe int keyCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyedCollection<TKey, TItem>.NativeFieldInfoPtr_keyCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyedCollection<TKey, TItem>.NativeFieldInfoPtr_keyCount)) = value;
			}
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x06004CEB RID: 19691 RVA: 0x001642F8 File Offset: 0x001624F8
		// (set) Token: 0x06004CEC RID: 19692 RVA: 0x0001BEE4 File Offset: 0x0001A0E4
		public unsafe int threshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyedCollection<TKey, TItem>.NativeFieldInfoPtr_threshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyedCollection<TKey, TItem>.NativeFieldInfoPtr_threshold)) = value;
			}
		}

		// Token: 0x04003EDF RID: 16095
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x04003EE0 RID: 16096
		private static readonly IntPtr NativeFieldInfoPtr_dict;

		// Token: 0x04003EE1 RID: 16097
		private static readonly IntPtr NativeFieldInfoPtr_keyCount;

		// Token: 0x04003EE2 RID: 16098
		private static readonly IntPtr NativeFieldInfoPtr_threshold;

		// Token: 0x04003EE3 RID: 16099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04003EE4 RID: 16100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IEqualityComparer_1_TKey_0;

		// Token: 0x04003EE5 RID: 16101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IEqualityComparer_1_TKey_Int32_0;

		// Token: 0x04003EE6 RID: 16102
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Private_get_List_1_TItem_0;

		// Token: 0x04003EE7 RID: 16103
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_TItem_TKey_0;

		// Token: 0x04003EE8 RID: 16104
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_TKey_0;

		// Token: 0x04003EE9 RID: 16105
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_TKey_byref_TItem_0;

		// Token: 0x04003EEA RID: 16106
		private static readonly IntPtr NativeMethodInfoPtr_get_Dictionary_Protected_get_IDictionary_2_TKey_TItem_0;

		// Token: 0x04003EEB RID: 16107
		private static readonly IntPtr NativeMethodInfoPtr_ClearItems_Protected_Virtual_Void_0;

		// Token: 0x04003EEC RID: 16108
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyForItem_Protected_Abstract_Virtual_New_TKey_TItem_0;

		// Token: 0x04003EED RID: 16109
		private static readonly IntPtr NativeMethodInfoPtr_InsertItem_Protected_Virtual_Void_Int32_TItem_0;

		// Token: 0x04003EEE RID: 16110
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Protected_Virtual_Void_Int32_0;

		// Token: 0x04003EEF RID: 16111
		private static readonly IntPtr NativeMethodInfoPtr_SetItem_Protected_Virtual_Void_Int32_TItem_0;

		// Token: 0x04003EF0 RID: 16112
		private static readonly IntPtr NativeMethodInfoPtr_AddKey_Private_Void_TKey_TItem_0;

		// Token: 0x04003EF1 RID: 16113
		private static readonly IntPtr NativeMethodInfoPtr_CreateDictionary_Private_Void_0;

		// Token: 0x04003EF2 RID: 16114
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKey_Private_Void_TKey_0;
	}
}
