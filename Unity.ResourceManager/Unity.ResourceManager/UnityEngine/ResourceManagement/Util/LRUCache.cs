using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x02000014 RID: 20
	public sealed class LRUCache<TKey, TValue> : ValueType
	{
		// Token: 0x06000156 RID: 342 RVA: 0x0000A468 File Offset: 0x00008668
		// Note: this type is marked as 'beforefieldinit'.
		static LRUCache()
		{
			Il2CppClassPointerStore<LRUCache<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "LRUCache`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LRUCache<TKey, TValue>>.NativeClassPtr);
			LRUCache<TKey, TValue>.NativeFieldInfoPtr_entryLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LRUCache<TKey, TValue>>.NativeClassPtr, "entryLimit");
			LRUCache<TKey, TValue>.NativeFieldInfoPtr_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LRUCache<TKey, TValue>>.NativeClassPtr, "cache");
			LRUCache<TKey, TValue>.NativeFieldInfoPtr_lru = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LRUCache<TKey, TValue>>.NativeClassPtr, "lru");
			LRUCache<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LRUCache<TKey, TValue>>.NativeClassPtr, 100663561);
			LRUCache<TKey, TValue>.NativeMethodInfoPtr_TryAdd_Public_Boolean_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LRUCache<TKey, TValue>>.NativeClassPtr, 100663562);
			LRUCache<TKey, TValue>.NativeMethodInfoPtr_TryGet_Public_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LRUCache<TKey, TValue>>.NativeClassPtr, 100663563);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000A560 File Offset: 0x00008760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1138198, RefRangeEnd = 1138199, XrefRangeStart = 1138186, XrefRangeEnd = 1138198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LRUCache(int limit)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LRUCache<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref limit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LRUCache<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000A5AC File Offset: 0x000087AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1138214, RefRangeEnd = 1138218, XrefRangeStart = 1138199, XrefRangeEnd = 1138214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAdd(TKey id, TValue obj)
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
					TKey tkey = id;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref id;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = obj;
				intPtr2 = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref obj;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LRUCache<TKey, TValue>.NativeMethodInfoPtr_TryAdd_Public_Boolean_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000A67C File Offset: 0x0000887C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1138220, RefRangeEnd = 1138222, XrefRangeStart = 1138218, XrefRangeEnd = 1138220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGet(TKey offset, out TValue val)
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
					TKey tkey = offset;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref offset;
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
				intPtr3 = ref val;
			}
			ptr3 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(LRUCache<TKey, TValue>.NativeMethodInfoPtr_TryGet_Public_Boolean_TKey_byref_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				val = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000028CA File Offset: 0x00000ACA
		public LRUCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000028D3 File Offset: 0x00000AD3
		public LRUCache()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LRUCache<TKey, TValue>>.NativeClassPtr))
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0000A754 File Offset: 0x00008954
		// (set) Token: 0x0600015D RID: 349 RVA: 0x000028E5 File Offset: 0x00000AE5
		public unsafe int entryLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LRUCache<TKey, TValue>.NativeFieldInfoPtr_entryLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LRUCache<TKey, TValue>.NativeFieldInfoPtr_entryLimit)) = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600015E RID: 350 RVA: 0x0000A77C File Offset: 0x0000897C
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00002900 File Offset: 0x00000B00
		public unsafe Dictionary<TKey, LRUCache<TKey, TValue>.Entry> cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LRUCache<TKey, TValue>.NativeFieldInfoPtr_cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, LRUCache<TKey, TValue>.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LRUCache<TKey, TValue>.NativeFieldInfoPtr_cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0000A7AC File Offset: 0x000089AC
		// (set) Token: 0x06000161 RID: 353 RVA: 0x0000291F File Offset: 0x00000B1F
		public unsafe LinkedList<TKey> lru
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LRUCache<TKey, TValue>.NativeFieldInfoPtr_lru);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LRUCache<TKey, TValue>.NativeFieldInfoPtr_lru), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeFieldInfoPtr_entryLimit;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeFieldInfoPtr_cache;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr_lru;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_TryAdd_Public_Boolean_TKey_TValue_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_TryGet_Public_Boolean_TKey_byref_TValue_0;

		// Token: 0x02000079 RID: 121
		public sealed class Entry : ValueType
		{
			// Token: 0x0600061C RID: 1564 RVA: 0x0001D658 File Offset: 0x0001B858
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<LRUCache<TKey, TValue>.Entry>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LRUCache<TKey, TValue>>.NativeClassPtr, "Entry"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LRUCache<TKey, TValue>.Entry>.NativeClassPtr);
				LRUCache<TKey, TValue>.Entry.NativeFieldInfoPtr_lruNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LRUCache<TKey, TValue>.Entry>.NativeClassPtr, "lruNode");
				LRUCache<TKey, TValue>.Entry.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LRUCache<TKey, TValue>.Entry>.NativeClassPtr, "Value");
				LRUCache<TKey, TValue>.Entry.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Entry_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LRUCache<TKey, TValue>.Entry>.NativeClassPtr, 100663564);
				LRUCache<TKey, TValue>.Entry.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LRUCache<TKey, TValue>.Entry>.NativeClassPtr, 100663565);
			}

			// Token: 0x0600061D RID: 1565 RVA: 0x0001D720 File Offset: 0x0001B920
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138173, XrefRangeEnd = 1138175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Equals(LRUCache<TKey, TValue>.Entry other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LRUCache<TKey, TValue>.Entry.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Entry_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600061E RID: 1566 RVA: 0x0001D778 File Offset: 0x0001B978
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138175, XrefRangeEnd = 1138186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LRUCache<TKey, TValue>.Entry.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600061F RID: 1567 RVA: 0x000044A7 File Offset: 0x000026A7
			public Entry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000620 RID: 1568 RVA: 0x000044B0 File Offset: 0x000026B0
			public Entry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LRUCache<TKey, TValue>.Entry>.NativeClassPtr))
			{
			}

			// Token: 0x170001D8 RID: 472
			// (get) Token: 0x06000621 RID: 1569 RVA: 0x0001D7BC File Offset: 0x0001B9BC
			// (set) Token: 0x06000622 RID: 1570 RVA: 0x000044C2 File Offset: 0x000026C2
			public unsafe LinkedListNode<TKey> lruNode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LRUCache<TKey, TValue>.Entry.NativeFieldInfoPtr_lruNode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedListNode<TKey>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LRUCache<TKey, TValue>.Entry.NativeFieldInfoPtr_lruNode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D9 RID: 473
			// (get) Token: 0x06000623 RID: 1571 RVA: 0x0001D7EC File Offset: 0x0001B9EC
			// (set) Token: 0x06000624 RID: 1572 RVA: 0x0001D814 File Offset: 0x0001BA14
			public unsafe TValue Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LRUCache<TKey, TValue>.Entry.NativeFieldInfoPtr_Value);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LRUCache<TKey, TValue>.Entry.NativeFieldInfoPtr_Value);
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

			// Token: 0x0400045E RID: 1118
			private static readonly IntPtr NativeFieldInfoPtr_lruNode;

			// Token: 0x0400045F RID: 1119
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x04000460 RID: 1120
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Entry_TKey_TValue_0;

			// Token: 0x04000461 RID: 1121
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
		}
	}
}
