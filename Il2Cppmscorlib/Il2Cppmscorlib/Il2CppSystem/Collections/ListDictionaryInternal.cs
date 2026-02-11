using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004C4 RID: 1220
	[Serializable]
	public class ListDictionaryInternal : Object
	{
		// Token: 0x06004A8E RID: 19086 RVA: 0x001589D8 File Offset: 0x00156BD8
		// Note: this type is marked as 'beforefieldinit'.
		static ListDictionaryInternal()
		{
			Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "ListDictionaryInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr);
			ListDictionaryInternal.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, "head");
			ListDictionaryInternal.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, "version");
			ListDictionaryInternal.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, "count");
			ListDictionaryInternal.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, "_syncRoot");
			ListDictionaryInternal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100674137);
			ListDictionaryInternal.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100674138);
			ListDictionaryInternal.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100674139);
			ListDictionaryInternal.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100674140);
			ListDictionaryInternal.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100674141);
			ListDictionaryInternal.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100674142);
			ListDictionaryInternal.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100674143);
			ListDictionaryInternal.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100674144);
			ListDictionaryInternal.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100674145);
			ListDictionaryInternal.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100674146);
			ListDictionaryInternal.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100674147);
			ListDictionaryInternal.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100674148);
			ListDictionaryInternal.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100674149);
			ListDictionaryInternal.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100674150);
			ListDictionaryInternal.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100674151);
			ListDictionaryInternal.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100674152);
			ListDictionaryInternal.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100674153);
		}

		// Token: 0x06004A8F RID: 19087 RVA: 0x00158BAC File Offset: 0x00156DAC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListDictionaryInternal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001314 RID: 4884
		public unsafe virtual Object this[Object key]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414928, XrefRangeEnd = 1414937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x06004A92 RID: 19090 RVA: 0x00158C8C File Offset: 0x00156E8C
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x06004A93 RID: 19091 RVA: 0x00158CC8 File Offset: 0x00156EC8
		public unsafe virtual ICollection Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414937, XrefRangeEnd = 1414942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x06004A94 RID: 19092 RVA: 0x00158D08 File Offset: 0x00156F08
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x06004A95 RID: 19093 RVA: 0x00158D44 File Offset: 0x00156F44
		public unsafe virtual bool IsFixedSize
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x06004A96 RID: 19094 RVA: 0x00158D80 File Offset: 0x00156F80
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x06004A97 RID: 19095 RVA: 0x00158DBC File Offset: 0x00156FBC
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414942, XrefRangeEnd = 1414947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x06004A98 RID: 19096 RVA: 0x00158DFC File Offset: 0x00156FFC
		public unsafe virtual ICollection Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414947, XrefRangeEnd = 1414952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x06004A99 RID: 19097 RVA: 0x00158E3C File Offset: 0x0015703C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414952, XrefRangeEnd = 1414960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(Object key, Object value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A9A RID: 19098 RVA: 0x00158E90 File Offset: 0x00157090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A9B RID: 19099 RVA: 0x00158EC4 File Offset: 0x001570C4
		[CallerCount(0)]
		public unsafe virtual bool Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004A9C RID: 19100 RVA: 0x00158F14 File Offset: 0x00157114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414960, XrefRangeEnd = 1414968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A9D RID: 19101 RVA: 0x00158F64 File Offset: 0x00157164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414968, XrefRangeEnd = 1414974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004A9E RID: 19102 RVA: 0x00158FA4 File Offset: 0x001571A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414974, XrefRangeEnd = 1414980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004A9F RID: 19103 RVA: 0x00158FE4 File Offset: 0x001571E4
		[CallerCount(0)]
		public unsafe virtual void Remove(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004AA0 RID: 19104 RVA: 0x0001B54E File Offset: 0x0001974E
		public ListDictionaryInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x06004AA1 RID: 19105 RVA: 0x00159028 File Offset: 0x00157228
		// (set) Token: 0x06004AA2 RID: 19106 RVA: 0x0001B557 File Offset: 0x00019757
		public unsafe ListDictionaryInternal.DictionaryNode head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionaryInternal.DictionaryNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x06004AA3 RID: 19107 RVA: 0x00159058 File Offset: 0x00157258
		// (set) Token: 0x06004AA4 RID: 19108 RVA: 0x0001B576 File Offset: 0x00019776
		public unsafe int version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x06004AA5 RID: 19109 RVA: 0x00159080 File Offset: 0x00157280
		// (set) Token: 0x06004AA6 RID: 19110 RVA: 0x0001B591 File Offset: 0x00019791
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x06004AA7 RID: 19111 RVA: 0x001590A8 File Offset: 0x001572A8
		// (set) Token: 0x06004AA8 RID: 19112 RVA: 0x0001B5AC File Offset: 0x000197AC
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D11 RID: 15633
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x04003D12 RID: 15634
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04003D13 RID: 15635
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04003D14 RID: 15636
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x04003D15 RID: 15637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003D16 RID: 15638
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0;

		// Token: 0x04003D17 RID: 15639
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0;

		// Token: 0x04003D18 RID: 15640
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04003D19 RID: 15641
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04003D1A RID: 15642
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003D1B RID: 15643
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003D1C RID: 15644
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003D1D RID: 15645
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04003D1E RID: 15646
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04003D1F RID: 15647
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0;

		// Token: 0x04003D20 RID: 15648
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003D21 RID: 15649
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x04003D22 RID: 15650
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04003D23 RID: 15651
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x04003D24 RID: 15652
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04003D25 RID: 15653
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0;

		// Token: 0x020006E0 RID: 1760
		public class NodeEnumerator : Object
		{
			// Token: 0x06005D67 RID: 23911 RVA: 0x001A6904 File Offset: 0x001A4B04
			// Note: this type is marked as 'beforefieldinit'.
			static NodeEnumerator()
			{
				Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, "NodeEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr);
				ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, "list");
				ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, "current");
				ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, "version");
				ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, "start");
				ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ListDictionaryInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, 100674154);
				ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, 100674155);
				ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, 100674156);
				ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, 100674157);
				ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, 100674158);
				ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, 100674159);
				ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, 100674160);
			}

			// Token: 0x06005D68 RID: 23912 RVA: 0x001A6A0C File Offset: 0x001A4C0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NodeEnumerator(ListDictionaryInternal list)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ListDictionaryInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170017F2 RID: 6130
			// (get) Token: 0x06005D69 RID: 23913 RVA: 0x001A6A58 File Offset: 0x001A4C58
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414888, XrefRangeEnd = 1414893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170017F3 RID: 6131
			// (get) Token: 0x06005D6A RID: 23914 RVA: 0x001A6A98 File Offset: 0x001A4C98
			public unsafe virtual DictionaryEntry Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414893, XrefRangeEnd = 1414895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x170017F4 RID: 6132
			// (get) Token: 0x06005D6B RID: 23915 RVA: 0x001A6AD0 File Offset: 0x001A4CD0
			public unsafe virtual Object Key
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170017F5 RID: 6133
			// (get) Token: 0x06005D6C RID: 23916 RVA: 0x001A6B10 File Offset: 0x001A4D10
			public unsafe virtual Object Value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005D6D RID: 23917 RVA: 0x001A6B50 File Offset: 0x001A4D50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414895, XrefRangeEnd = 1414896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005D6E RID: 23918 RVA: 0x001A6B8C File Offset: 0x001A4D8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414896, XrefRangeEnd = 1414904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005D6F RID: 23919 RVA: 0x000221F5 File Offset: 0x000203F5
			public NodeEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017EE RID: 6126
			// (get) Token: 0x06005D70 RID: 23920 RVA: 0x001A6BC0 File Offset: 0x001A4DC0
			// (set) Token: 0x06005D71 RID: 23921 RVA: 0x000221FE File Offset: 0x000203FE
			public unsafe ListDictionaryInternal list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionaryInternal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017EF RID: 6127
			// (get) Token: 0x06005D72 RID: 23922 RVA: 0x001A6BF0 File Offset: 0x001A4DF0
			// (set) Token: 0x06005D73 RID: 23923 RVA: 0x0002221D File Offset: 0x0002041D
			public unsafe ListDictionaryInternal.DictionaryNode current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionaryInternal.DictionaryNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017F0 RID: 6128
			// (get) Token: 0x06005D74 RID: 23924 RVA: 0x001A6C20 File Offset: 0x001A4E20
			// (set) Token: 0x06005D75 RID: 23925 RVA: 0x0002223C File Offset: 0x0002043C
			public unsafe int version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_version)) = value;
				}
			}

			// Token: 0x170017F1 RID: 6129
			// (get) Token: 0x06005D76 RID: 23926 RVA: 0x001A6C48 File Offset: 0x001A4E48
			// (set) Token: 0x06005D77 RID: 23927 RVA: 0x00022257 File Offset: 0x00020457
			public unsafe bool start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x04004C36 RID: 19510
			private static readonly IntPtr NativeFieldInfoPtr_list;

			// Token: 0x04004C37 RID: 19511
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x04004C38 RID: 19512
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x04004C39 RID: 19513
			private static readonly IntPtr NativeFieldInfoPtr_start;

			// Token: 0x04004C3A RID: 19514
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ListDictionaryInternal_0;

			// Token: 0x04004C3B RID: 19515
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004C3C RID: 19516
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x04004C3D RID: 19517
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004C3E RID: 19518
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004C3F RID: 19519
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004C40 RID: 19520
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x020006E1 RID: 1761
		public class NodeKeyValueCollection : Object
		{
			// Token: 0x06005D78 RID: 23928 RVA: 0x001A6C70 File Offset: 0x001A4E70
			// Note: this type is marked as 'beforefieldinit'.
			static NodeKeyValueCollection()
			{
				Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, "NodeKeyValueCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr);
				ListDictionaryInternal.NodeKeyValueCollection.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr, "list");
				ListDictionaryInternal.NodeKeyValueCollection.NativeFieldInfoPtr_isKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr, "isKeys");
				ListDictionaryInternal.NodeKeyValueCollection.NativeMethodInfoPtr__ctor_Public_Void_ListDictionaryInternal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr, 100674161);
				ListDictionaryInternal.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr, 100674162);
				ListDictionaryInternal.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr, 100674163);
				ListDictionaryInternal.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr, 100674164);
				ListDictionaryInternal.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr, 100674165);
				ListDictionaryInternal.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr, 100674166);
			}

			// Token: 0x06005D79 RID: 23929 RVA: 0x001A6D3C File Offset: 0x001A4F3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NodeKeyValueCollection(ListDictionaryInternal list, bool isKeys)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isKeys;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeKeyValueCollection.NativeMethodInfoPtr__ctor_Public_Void_ListDictionaryInternal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005D7A RID: 23930 RVA: 0x001A6D98 File Offset: 0x001A4F98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414913, XrefRangeEnd = 1414917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170017F8 RID: 6136
			// (get) Token: 0x06005D7B RID: 23931 RVA: 0x001A6DE8 File Offset: 0x001A4FE8
			public unsafe virtual int System.Collections.ICollection.Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170017F9 RID: 6137
			// (get) Token: 0x06005D7C RID: 23932 RVA: 0x001A6E24 File Offset: 0x001A5024
			public unsafe virtual bool System.Collections.ICollection.IsSynchronized
			{
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170017FA RID: 6138
			// (get) Token: 0x06005D7D RID: 23933 RVA: 0x001A6E60 File Offset: 0x001A5060
			public unsafe virtual Object System.Collections.ICollection.SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414917, XrefRangeEnd = 1414922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005D7E RID: 23934 RVA: 0x001A6EA0 File Offset: 0x001A50A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414922, XrefRangeEnd = 1414928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005D7F RID: 23935 RVA: 0x00022272 File Offset: 0x00020472
			public NodeKeyValueCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017F6 RID: 6134
			// (get) Token: 0x06005D80 RID: 23936 RVA: 0x001A6EE0 File Offset: 0x001A50E0
			// (set) Token: 0x06005D81 RID: 23937 RVA: 0x0002227B File Offset: 0x0002047B
			public unsafe ListDictionaryInternal list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NativeFieldInfoPtr_list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionaryInternal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017F7 RID: 6135
			// (get) Token: 0x06005D82 RID: 23938 RVA: 0x001A6F10 File Offset: 0x001A5110
			// (set) Token: 0x06005D83 RID: 23939 RVA: 0x0002229A File Offset: 0x0002049A
			public unsafe bool isKeys
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NativeFieldInfoPtr_isKeys);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NativeFieldInfoPtr_isKeys)) = value;
				}
			}

			// Token: 0x04004C41 RID: 19521
			private static readonly IntPtr NativeFieldInfoPtr_list;

			// Token: 0x04004C42 RID: 19522
			private static readonly IntPtr NativeFieldInfoPtr_isKeys;

			// Token: 0x04004C43 RID: 19523
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ListDictionaryInternal_Boolean_0;

			// Token: 0x04004C44 RID: 19524
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x04004C45 RID: 19525
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x04004C46 RID: 19526
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04004C47 RID: 19527
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004C48 RID: 19528
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x02000791 RID: 1937
			public class NodeKeyValueEnumerator : Object
			{
				// Token: 0x06006325 RID: 25381 RVA: 0x001BA2D4 File Offset: 0x001B84D4
				// Note: this type is marked as 'beforefieldinit'.
				static NodeKeyValueEnumerator()
				{
					Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr, "NodeKeyValueEnumerator");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr);
					ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "list");
					ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "current");
					ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "version");
					ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_isKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "isKeys");
					ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "start");
					ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ListDictionaryInternal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, 100674167);
					ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, 100674168);
					ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, 100674169);
					ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, 100674170);
				}

				// Token: 0x06006326 RID: 25382 RVA: 0x001BA3B4 File Offset: 0x001B85B4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe NodeKeyValueEnumerator(ListDictionaryInternal list, bool isKeys)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isKeys;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ListDictionaryInternal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700199D RID: 6557
				// (get) Token: 0x06006327 RID: 25383 RVA: 0x001BA410 File Offset: 0x001B8610
				public unsafe virtual Object Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06006328 RID: 25384 RVA: 0x001BA450 File Offset: 0x001B8650
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414904, XrefRangeEnd = 1414905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe virtual bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06006329 RID: 25385 RVA: 0x001BA48C File Offset: 0x001B868C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414905, XrefRangeEnd = 1414913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe virtual void Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600632A RID: 25386 RVA: 0x000251F7 File Offset: 0x000233F7
				public NodeKeyValueEnumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17001998 RID: 6552
				// (get) Token: 0x0600632B RID: 25387 RVA: 0x001BA4C0 File Offset: 0x001B86C0
				// (set) Token: 0x0600632C RID: 25388 RVA: 0x00025200 File Offset: 0x00023400
				public unsafe ListDictionaryInternal list
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_list);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionaryInternal>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001999 RID: 6553
				// (get) Token: 0x0600632D RID: 25389 RVA: 0x001BA4F0 File Offset: 0x001B86F0
				// (set) Token: 0x0600632E RID: 25390 RVA: 0x0002521F File Offset: 0x0002341F
				public unsafe ListDictionaryInternal.DictionaryNode current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionaryInternal.DictionaryNode>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700199A RID: 6554
				// (get) Token: 0x0600632F RID: 25391 RVA: 0x001BA520 File Offset: 0x001B8720
				// (set) Token: 0x06006330 RID: 25392 RVA: 0x0002523E File Offset: 0x0002343E
				public unsafe int version
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_version);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_version)) = value;
					}
				}

				// Token: 0x1700199B RID: 6555
				// (get) Token: 0x06006331 RID: 25393 RVA: 0x001BA548 File Offset: 0x001B8748
				// (set) Token: 0x06006332 RID: 25394 RVA: 0x00025259 File Offset: 0x00023459
				public unsafe bool isKeys
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_isKeys);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_isKeys)) = value;
					}
				}

				// Token: 0x1700199C RID: 6556
				// (get) Token: 0x06006333 RID: 25395 RVA: 0x001BA570 File Offset: 0x001B8770
				// (set) Token: 0x06006334 RID: 25396 RVA: 0x00025274 File Offset: 0x00023474
				public unsafe bool start
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_start);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_start)) = value;
					}
				}

				// Token: 0x040050F5 RID: 20725
				private static readonly IntPtr NativeFieldInfoPtr_list;

				// Token: 0x040050F6 RID: 20726
				private static readonly IntPtr NativeFieldInfoPtr_current;

				// Token: 0x040050F7 RID: 20727
				private static readonly IntPtr NativeFieldInfoPtr_version;

				// Token: 0x040050F8 RID: 20728
				private static readonly IntPtr NativeFieldInfoPtr_isKeys;

				// Token: 0x040050F9 RID: 20729
				private static readonly IntPtr NativeFieldInfoPtr_start;

				// Token: 0x040050FA RID: 20730
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ListDictionaryInternal_Boolean_0;

				// Token: 0x040050FB RID: 20731
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

				// Token: 0x040050FC RID: 20732
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x040050FD RID: 20733
				private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
			}
		}

		// Token: 0x020006E2 RID: 1762
		[Serializable]
		public class DictionaryNode : Object
		{
			// Token: 0x06005D84 RID: 23940 RVA: 0x001A6F38 File Offset: 0x001A5138
			// Note: this type is marked as 'beforefieldinit'.
			static DictionaryNode()
			{
				Il2CppClassPointerStore<ListDictionaryInternal.DictionaryNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, "DictionaryNode");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionaryInternal.DictionaryNode>.NativeClassPtr);
				ListDictionaryInternal.DictionaryNode.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.DictionaryNode>.NativeClassPtr, "key");
				ListDictionaryInternal.DictionaryNode.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.DictionaryNode>.NativeClassPtr, "value");
				ListDictionaryInternal.DictionaryNode.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.DictionaryNode>.NativeClassPtr, "next");
				ListDictionaryInternal.DictionaryNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.DictionaryNode>.NativeClassPtr, 100674171);
			}

			// Token: 0x06005D85 RID: 23941 RVA: 0x001A6FB4 File Offset: 0x001A51B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictionaryNode()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionaryInternal.DictionaryNode>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.DictionaryNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005D86 RID: 23942 RVA: 0x000222B5 File Offset: 0x000204B5
			public DictionaryNode(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017FB RID: 6139
			// (get) Token: 0x06005D87 RID: 23943 RVA: 0x001A6FF0 File Offset: 0x001A51F0
			// (set) Token: 0x06005D88 RID: 23944 RVA: 0x000222BE File Offset: 0x000204BE
			public unsafe Object key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.DictionaryNode.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.DictionaryNode.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017FC RID: 6140
			// (get) Token: 0x06005D89 RID: 23945 RVA: 0x001A7020 File Offset: 0x001A5220
			// (set) Token: 0x06005D8A RID: 23946 RVA: 0x000222DD File Offset: 0x000204DD
			public unsafe Object value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.DictionaryNode.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.DictionaryNode.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017FD RID: 6141
			// (get) Token: 0x06005D8B RID: 23947 RVA: 0x001A7050 File Offset: 0x001A5250
			// (set) Token: 0x06005D8C RID: 23948 RVA: 0x000222FC File Offset: 0x000204FC
			public unsafe ListDictionaryInternal.DictionaryNode next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.DictionaryNode.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionaryInternal.DictionaryNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.DictionaryNode.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004C49 RID: 19529
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04004C4A RID: 19530
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04004C4B RID: 19531
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x04004C4C RID: 19532
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
