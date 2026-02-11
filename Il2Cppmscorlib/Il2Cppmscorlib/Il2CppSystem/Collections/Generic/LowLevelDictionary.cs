using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004F4 RID: 1268
	public class LowLevelDictionary<TKey, TValue> : Object
	{
		// Token: 0x06004E4A RID: 20042 RVA: 0x0016B83C File Offset: 0x00169A3C
		// Note: this type is marked as 'beforefieldinit'.
		static LowLevelDictionary()
		{
			Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "LowLevelDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>>.NativeClassPtr);
			LowLevelDictionary<TKey, TValue>.NativeFieldInfoPtr__buckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>>.NativeClassPtr, "_buckets");
			LowLevelDictionary<TKey, TValue>.NativeFieldInfoPtr__numEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>>.NativeClassPtr, "_numEntries");
			LowLevelDictionary<TKey, TValue>.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>>.NativeClassPtr, "_version");
			LowLevelDictionary<TKey, TValue>.NativeFieldInfoPtr__comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>>.NativeClassPtr, "_comparer");
			LowLevelDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>>.NativeClassPtr, 100675072);
			LowLevelDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>>.NativeClassPtr, 100675073);
			LowLevelDictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_set_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>>.NativeClassPtr, 100675074);
			LowLevelDictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>>.NativeClassPtr, 100675075);
			LowLevelDictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>>.NativeClassPtr, 100675076);
			LowLevelDictionary<TKey, TValue>.NativeMethodInfoPtr_Find_Private_Entry_TKey_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>>.NativeClassPtr, 100675077);
			LowLevelDictionary<TKey, TValue>.NativeMethodInfoPtr_UncheckedAdd_Private_Entry_TKey_TValue_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>>.NativeClassPtr, 100675078);
			LowLevelDictionary<TKey, TValue>.NativeMethodInfoPtr_ExpandBuckets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>>.NativeClassPtr, 100675079);
			LowLevelDictionary<TKey, TValue>.NativeMethodInfoPtr_GetBucket_Private_Int32_TKey_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>>.NativeClassPtr, 100675080);
		}

		// Token: 0x06004E4B RID: 20043 RVA: 0x0016B9C0 File Offset: 0x00169BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425381, XrefRangeEnd = 1425389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LowLevelDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E4C RID: 20044 RVA: 0x0016B9FC File Offset: 0x00169BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425389, XrefRangeEnd = 1425394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LowLevelDictionary(int capacity, IEqualityComparer<TKey> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700142E RID: 5166
		public unsafe TKey this[TKey key]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1425399, RefRangeEnd = 1425400, XrefRangeStart = 1425394, XrefRangeEnd = 1425399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LowLevelDictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_set_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			}
		}

		// Token: 0x06004E4E RID: 20046 RVA: 0x0016BB18 File Offset: 0x00169D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425400, XrefRangeEnd = 1425403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(int capacity = 17)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelDictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004E4F RID: 20047 RVA: 0x0016BB58 File Offset: 0x00169D58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425407, RefRangeEnd = 1425408, XrefRangeStart = 1425403, XrefRangeEnd = 1425407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(TKey key)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LowLevelDictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004E50 RID: 20048 RVA: 0x0016BBDC File Offset: 0x00169DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425408, XrefRangeEnd = 1425412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LowLevelDictionary<TKey, TValue>.Entry Find(TKey key)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LowLevelDictionary<TKey, TValue>.NativeMethodInfoPtr_Find_Private_Entry_TKey_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<LowLevelDictionary<TKey, TValue>.Entry>(intPtr4) : null;
			}
		}

		// Token: 0x06004E51 RID: 20049 RVA: 0x0016BC64 File Offset: 0x00169E64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425421, RefRangeEnd = 1425422, XrefRangeStart = 1425412, XrefRangeEnd = 1425421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LowLevelDictionary<TKey, TValue>.Entry UncheckedAdd(TKey key, TValue value)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LowLevelDictionary<TKey, TValue>.NativeMethodInfoPtr_UncheckedAdd_Private_Entry_TKey_TValue_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<LowLevelDictionary<TKey, TValue>.Entry>(intPtr5) : null;
		}

		// Token: 0x06004E52 RID: 20050 RVA: 0x0016BD34 File Offset: 0x00169F34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425431, RefRangeEnd = 1425432, XrefRangeStart = 1425422, XrefRangeEnd = 1425431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandBuckets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelDictionary<TKey, TValue>.NativeMethodInfoPtr_ExpandBuckets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E53 RID: 20051 RVA: 0x0016BD68 File Offset: 0x00169F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425432, XrefRangeEnd = 1425434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetBucket(TKey key, int numBuckets = 0)
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBuckets;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LowLevelDictionary<TKey, TValue>.NativeMethodInfoPtr_GetBucket_Private_Int32_TKey_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004E54 RID: 20052 RVA: 0x0001C477 File Offset: 0x0001A677
		public LowLevelDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x06004E55 RID: 20053 RVA: 0x0016BDFC File Offset: 0x00169FFC
		// (set) Token: 0x06004E56 RID: 20054 RVA: 0x0001C480 File Offset: 0x0001A680
		public unsafe Il2CppReferenceArray<LowLevelDictionary<TKey, TValue>.Entry> _buckets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelDictionary<TKey, TValue>.NativeFieldInfoPtr__buckets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LowLevelDictionary<TKey, TValue>.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelDictionary<TKey, TValue>.NativeFieldInfoPtr__buckets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x06004E57 RID: 20055 RVA: 0x0016BE2C File Offset: 0x0016A02C
		// (set) Token: 0x06004E58 RID: 20056 RVA: 0x0001C49F File Offset: 0x0001A69F
		public unsafe int _numEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelDictionary<TKey, TValue>.NativeFieldInfoPtr__numEntries);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelDictionary<TKey, TValue>.NativeFieldInfoPtr__numEntries)) = value;
			}
		}

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x06004E59 RID: 20057 RVA: 0x0016BE54 File Offset: 0x0016A054
		// (set) Token: 0x06004E5A RID: 20058 RVA: 0x0001C4BA File Offset: 0x0001A6BA
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelDictionary<TKey, TValue>.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelDictionary<TKey, TValue>.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x06004E5B RID: 20059 RVA: 0x0016BE7C File Offset: 0x0016A07C
		// (set) Token: 0x06004E5C RID: 20060 RVA: 0x0001C4D5 File Offset: 0x0001A6D5
		public unsafe IEqualityComparer<TKey> _comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelDictionary<TKey, TValue>.NativeFieldInfoPtr__comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelDictionary<TKey, TValue>.NativeFieldInfoPtr__comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003FF9 RID: 16377
		private static readonly IntPtr NativeFieldInfoPtr__buckets;

		// Token: 0x04003FFA RID: 16378
		private static readonly IntPtr NativeFieldInfoPtr__numEntries;

		// Token: 0x04003FFB RID: 16379
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x04003FFC RID: 16380
		private static readonly IntPtr NativeFieldInfoPtr__comparer;

		// Token: 0x04003FFD RID: 16381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003FFE RID: 16382
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_1_TKey_0;

		// Token: 0x04003FFF RID: 16383
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_TKey_TValue_0;

		// Token: 0x04004000 RID: 16384
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_Int32_0;

		// Token: 0x04004001 RID: 16385
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_TKey_0;

		// Token: 0x04004002 RID: 16386
		private static readonly IntPtr NativeMethodInfoPtr_Find_Private_Entry_TKey_TValue_TKey_0;

		// Token: 0x04004003 RID: 16387
		private static readonly IntPtr NativeMethodInfoPtr_UncheckedAdd_Private_Entry_TKey_TValue_TKey_TValue_0;

		// Token: 0x04004004 RID: 16388
		private static readonly IntPtr NativeMethodInfoPtr_ExpandBuckets_Private_Void_0;

		// Token: 0x04004005 RID: 16389
		private static readonly IntPtr NativeMethodInfoPtr_GetBucket_Private_Int32_TKey_Int32_0;

		// Token: 0x02000709 RID: 1801
		public sealed class Entry : Object
		{
			// Token: 0x06005FC1 RID: 24513 RVA: 0x001B0568 File Offset: 0x001AE768
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>.Entry>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>>.NativeClassPtr, "Entry"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>.Entry>.NativeClassPtr);
				LowLevelDictionary<TKey, TValue>.Entry.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>.Entry>.NativeClassPtr, "_key");
				LowLevelDictionary<TKey, TValue>.Entry.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>.Entry>.NativeClassPtr, "_value");
				LowLevelDictionary<TKey, TValue>.Entry.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>.Entry>.NativeClassPtr, "_next");
				LowLevelDictionary<TKey, TValue>.Entry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>.Entry>.NativeClassPtr, 100675081);
			}

			// Token: 0x06005FC2 RID: 24514 RVA: 0x001B0630 File Offset: 0x001AE830
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>.Entry>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelDictionary<TKey, TValue>.Entry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005FC3 RID: 24515 RVA: 0x00022FF4 File Offset: 0x000211F4
			public Entry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018C1 RID: 6337
			// (get) Token: 0x06005FC4 RID: 24516 RVA: 0x001B066C File Offset: 0x001AE86C
			// (set) Token: 0x06005FC5 RID: 24517 RVA: 0x001B0694 File Offset: 0x001AE894
			public unsafe TKey _key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelDictionary<TKey, TValue>.Entry.NativeFieldInfoPtr__key);
					return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelDictionary<TKey, TValue>.Entry.NativeFieldInfoPtr__key);
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

			// Token: 0x170018C2 RID: 6338
			// (get) Token: 0x06005FC6 RID: 24518 RVA: 0x001B073C File Offset: 0x001AE93C
			// (set) Token: 0x06005FC7 RID: 24519 RVA: 0x001B0764 File Offset: 0x001AE964
			public unsafe TValue _value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelDictionary<TKey, TValue>.Entry.NativeFieldInfoPtr__value);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelDictionary<TKey, TValue>.Entry.NativeFieldInfoPtr__value);
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

			// Token: 0x170018C3 RID: 6339
			// (get) Token: 0x06005FC8 RID: 24520 RVA: 0x001B080C File Offset: 0x001AEA0C
			// (set) Token: 0x06005FC9 RID: 24521 RVA: 0x00022FFD File Offset: 0x000211FD
			public unsafe LowLevelDictionary<TKey, TValue>.Entry _next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelDictionary<TKey, TValue>.Entry.NativeFieldInfoPtr__next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LowLevelDictionary<TKey, TValue>.Entry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelDictionary<TKey, TValue>.Entry.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004DD4 RID: 19924
			private static readonly IntPtr NativeFieldInfoPtr__key;

			// Token: 0x04004DD5 RID: 19925
			private static readonly IntPtr NativeFieldInfoPtr__value;

			// Token: 0x04004DD6 RID: 19926
			private static readonly IntPtr NativeFieldInfoPtr__next;

			// Token: 0x04004DD7 RID: 19927
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200070A RID: 1802
		public sealed class DefaultComparer<T> : Object
		{
			// Token: 0x06005FCA RID: 24522 RVA: 0x001B083C File Offset: 0x001AEA3C
			// Note: this type is marked as 'beforefieldinit'.
			static DefaultComparer()
			{
				Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>.DefaultComparer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>>.NativeClassPtr, "DefaultComparer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>.DefaultComparer<T>>.NativeClassPtr);
				LowLevelDictionary<TKey, TValue>.DefaultComparer<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>.DefaultComparer<T>>.NativeClassPtr, 100675082);
				LowLevelDictionary<TKey, TValue>.DefaultComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>.DefaultComparer<T>>.NativeClassPtr, 100675083);
				LowLevelDictionary<TKey, TValue>.DefaultComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>.DefaultComparer<T>>.NativeClassPtr, 100675084);
			}

			// Token: 0x06005FCB RID: 24523 RVA: 0x001B0904 File Offset: 0x001AEB04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425377, XrefRangeEnd = 1425380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Equals(T x, T y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = x;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref x;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					T t2 = y;
					intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref y;
				}
				ptr3 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LowLevelDictionary<TKey, TValue>.DefaultComparer<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x06005FCC RID: 24524 RVA: 0x001B09D0 File Offset: 0x001AEBD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425380, XrefRangeEnd = 1425381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetHashCode(T obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = obj;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref obj;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LowLevelDictionary<TKey, TValue>.DefaultComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06005FCD RID: 24525 RVA: 0x001B0A54 File Offset: 0x001AEC54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DefaultComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LowLevelDictionary<TKey, TValue>.DefaultComparer<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelDictionary<TKey, TValue>.DefaultComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005FCE RID: 24526 RVA: 0x0002301C File Offset: 0x0002121C
			public DefaultComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04004DD8 RID: 19928
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_T_T_0;

			// Token: 0x04004DD9 RID: 19929
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_T_0;

			// Token: 0x04004DDA RID: 19930
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
