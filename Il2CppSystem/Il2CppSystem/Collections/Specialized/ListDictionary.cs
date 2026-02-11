using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Specialized
{
	// Token: 0x02000159 RID: 345
	[Serializable]
	public class ListDictionary : Object
	{
		// Token: 0x060014B3 RID: 5299 RVA: 0x0006C544 File Offset: 0x0006A744
		// Note: this type is marked as 'beforefieldinit'.
		static ListDictionary()
		{
			Il2CppClassPointerStore<ListDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Specialized", "ListDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr);
			ListDictionary.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "head");
			ListDictionary.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "version");
			ListDictionary.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "count");
			ListDictionary.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "comparer");
			ListDictionary.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "_syncRoot");
			ListDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100666409);
			ListDictionary.NativeMethodInfoPtr__ctor_Public_Void_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100666410);
			ListDictionary.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100666411);
			ListDictionary.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100666412);
			ListDictionary.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100666413);
			ListDictionary.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100666414);
			ListDictionary.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100666415);
			ListDictionary.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100666416);
			ListDictionary.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100666417);
			ListDictionary.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100666418);
			ListDictionary.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100666419);
			ListDictionary.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100666420);
			ListDictionary.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100666421);
			ListDictionary.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100666422);
			ListDictionary.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100666423);
			ListDictionary.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100666424);
			ListDictionary.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100666425);
			ListDictionary.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100666426);
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x0006C740 File Offset: 0x0006A940
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x0006C77C File Offset: 0x0006A97C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 458838, RefRangeEnd = 458841, XrefRangeStart = 458838, XrefRangeEnd = 458841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListDictionary(IComparer comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr__ctor_Public_Void_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000610 RID: 1552
		public unsafe virtual Object this[Object key]
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 466352, RefRangeEnd = 466355, XrefRangeStart = 466349, XrefRangeEnd = 466352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466355, XrefRangeEnd = 466368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x0006C86C File Offset: 0x0006AA6C
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x060014B9 RID: 5305 RVA: 0x0006C8A8 File Offset: 0x0006AAA8
		public unsafe virtual ICollection Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466368, XrefRangeEnd = 466373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x0006C8E8 File Offset: 0x0006AAE8
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x0006C924 File Offset: 0x0006AB24
		public unsafe virtual bool IsFixedSize
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x0006C960 File Offset: 0x0006AB60
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x060014BD RID: 5309 RVA: 0x0006C99C File Offset: 0x0006AB9C
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466373, XrefRangeEnd = 466378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x0006C9DC File Offset: 0x0006ABDC
		public unsafe virtual ICollection Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466378, XrefRangeEnd = 466383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0006CA1C File Offset: 0x0006AC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466383, XrefRangeEnd = 466395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x0006CA70 File Offset: 0x0006AC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466395, XrefRangeEnd = 466396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x0006CAA4 File Offset: 0x0006ACA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466396, XrefRangeEnd = 466400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0006CAF4 File Offset: 0x0006ACF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466400, XrefRangeEnd = 466406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x0006CB44 File Offset: 0x0006AD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466406, XrefRangeEnd = 466412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x0006CB84 File Offset: 0x0006AD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466412, XrefRangeEnd = 466418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x0006CBC4 File Offset: 0x0006ADC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466418, XrefRangeEnd = 466422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Remove(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x00009359 File Offset: 0x00007559
		public ListDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x060014C7 RID: 5319 RVA: 0x0006CC08 File Offset: 0x0006AE08
		// (set) Token: 0x060014C8 RID: 5320 RVA: 0x00009362 File Offset: 0x00007562
		public unsafe ListDictionary.DictionaryNode head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary.DictionaryNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x0006CC38 File Offset: 0x0006AE38
		// (set) Token: 0x060014CA RID: 5322 RVA: 0x00009381 File Offset: 0x00007581
		public unsafe int version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x060014CB RID: 5323 RVA: 0x0006CC60 File Offset: 0x0006AE60
		// (set) Token: 0x060014CC RID: 5324 RVA: 0x0000939C File Offset: 0x0000759C
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x0006CC88 File Offset: 0x0006AE88
		// (set) Token: 0x060014CE RID: 5326 RVA: 0x000093B7 File Offset: 0x000075B7
		public unsafe IComparer comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x0006CCB8 File Offset: 0x0006AEB8
		// (set) Token: 0x060014D0 RID: 5328 RVA: 0x000093D6 File Offset: 0x000075D6
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IComparer_0;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001045 RID: 4165
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001047 RID: 4167
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001048 RID: 4168
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001049 RID: 4169
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_0;

		// Token: 0x0400104B RID: 4171
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0;

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x0400104F RID: 4175
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x04001050 RID: 4176
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001051 RID: 4177
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0;

		// Token: 0x020002EE RID: 750
		public class NodeEnumerator : Object
		{
			// Token: 0x06002CD5 RID: 11477 RVA: 0x000C5290 File Offset: 0x000C3490
			// Note: this type is marked as 'beforefieldinit'.
			static NodeEnumerator()
			{
				Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "NodeEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr);
				ListDictionary.NodeEnumerator.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, "_list");
				ListDictionary.NodeEnumerator.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, "_current");
				ListDictionary.NodeEnumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, "_version");
				ListDictionary.NodeEnumerator.NativeFieldInfoPtr__start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, "_start");
				ListDictionary.NodeEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, 100666427);
				ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, 100666428);
				ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, 100666429);
				ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, 100666430);
				ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, 100666431);
				ListDictionary.NodeEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, 100666432);
				ListDictionary.NodeEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, 100666433);
			}

			// Token: 0x06002CD6 RID: 11478 RVA: 0x000C5398 File Offset: 0x000C3598
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466303, XrefRangeEnd = 466307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NodeEnumerator(ListDictionary list)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000E0D RID: 3597
			// (get) Token: 0x06002CD7 RID: 11479 RVA: 0x000C53E4 File Offset: 0x000C35E4
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466307, XrefRangeEnd = 466311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17000E0E RID: 3598
			// (get) Token: 0x06002CD8 RID: 11480 RVA: 0x000C5424 File Offset: 0x000C3624
			public unsafe virtual DictionaryEntry Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466311, XrefRangeEnd = 466312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x17000E0F RID: 3599
			// (get) Token: 0x06002CD9 RID: 11481 RVA: 0x000C545C File Offset: 0x000C365C
			public unsafe virtual Object Key
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17000E10 RID: 3600
			// (get) Token: 0x06002CDA RID: 11482 RVA: 0x000C549C File Offset: 0x000C369C
			public unsafe virtual Object Value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002CDB RID: 11483 RVA: 0x000C54DC File Offset: 0x000C36DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466312, XrefRangeEnd = 466313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002CDC RID: 11484 RVA: 0x000C5518 File Offset: 0x000C3718
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466313, XrefRangeEnd = 466321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CDD RID: 11485 RVA: 0x000142E0 File Offset: 0x000124E0
			public NodeEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E09 RID: 3593
			// (get) Token: 0x06002CDE RID: 11486 RVA: 0x000C554C File Offset: 0x000C374C
			// (set) Token: 0x06002CDF RID: 11487 RVA: 0x000142E9 File Offset: 0x000124E9
			public unsafe ListDictionary _list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr__list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E0A RID: 3594
			// (get) Token: 0x06002CE0 RID: 11488 RVA: 0x000C557C File Offset: 0x000C377C
			// (set) Token: 0x06002CE1 RID: 11489 RVA: 0x00014308 File Offset: 0x00012508
			public unsafe ListDictionary.DictionaryNode _current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary.DictionaryNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E0B RID: 3595
			// (get) Token: 0x06002CE2 RID: 11490 RVA: 0x000C55AC File Offset: 0x000C37AC
			// (set) Token: 0x06002CE3 RID: 11491 RVA: 0x00014327 File Offset: 0x00012527
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x17000E0C RID: 3596
			// (get) Token: 0x06002CE4 RID: 11492 RVA: 0x000C55D4 File Offset: 0x000C37D4
			// (set) Token: 0x06002CE5 RID: 11493 RVA: 0x00014342 File Offset: 0x00012542
			public unsafe bool _start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr__start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr__start)) = value;
				}
			}

			// Token: 0x04002353 RID: 9043
			private static readonly IntPtr NativeFieldInfoPtr__list;

			// Token: 0x04002354 RID: 9044
			private static readonly IntPtr NativeFieldInfoPtr__current;

			// Token: 0x04002355 RID: 9045
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x04002356 RID: 9046
			private static readonly IntPtr NativeFieldInfoPtr__start;

			// Token: 0x04002357 RID: 9047
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_0;

			// Token: 0x04002358 RID: 9048
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04002359 RID: 9049
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x0400235A RID: 9050
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x0400235B RID: 9051
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x0400235C RID: 9052
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x0400235D RID: 9053
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x020002EF RID: 751
		public class NodeKeyValueCollection : Object
		{
			// Token: 0x06002CE6 RID: 11494 RVA: 0x000C55FC File Offset: 0x000C37FC
			// Note: this type is marked as 'beforefieldinit'.
			static NodeKeyValueCollection()
			{
				Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "NodeKeyValueCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr);
				ListDictionary.NodeKeyValueCollection.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, "_list");
				ListDictionary.NodeKeyValueCollection.NativeFieldInfoPtr__isKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, "_isKeys");
				ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, 100666434);
				ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, 100666435);
				ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, 100666436);
				ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, 100666437);
				ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, 100666438);
				ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, 100666439);
			}

			// Token: 0x06002CE7 RID: 11495 RVA: 0x000C56C8 File Offset: 0x000C38C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466334, XrefRangeEnd = 466336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NodeKeyValueCollection(ListDictionary list, bool isKeys)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isKeys;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CE8 RID: 11496 RVA: 0x000C5724 File Offset: 0x000C3924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466336, XrefRangeEnd = 466338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E13 RID: 3603
			// (get) Token: 0x06002CE9 RID: 11497 RVA: 0x000C5774 File Offset: 0x000C3974
			public unsafe virtual int System.Collections.ICollection.Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E14 RID: 3604
			// (get) Token: 0x06002CEA RID: 11498 RVA: 0x000C57B0 File Offset: 0x000C39B0
			public unsafe virtual bool System.Collections.ICollection.IsSynchronized
			{
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E15 RID: 3605
			// (get) Token: 0x06002CEB RID: 11499 RVA: 0x000C57EC File Offset: 0x000C39EC
			public unsafe virtual Object System.Collections.ICollection.SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466338, XrefRangeEnd = 466343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002CEC RID: 11500 RVA: 0x000C582C File Offset: 0x000C3A2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466343, XrefRangeEnd = 466349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002CED RID: 11501 RVA: 0x0001435D File Offset: 0x0001255D
			public NodeKeyValueCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E11 RID: 3601
			// (get) Token: 0x06002CEE RID: 11502 RVA: 0x000C586C File Offset: 0x000C3A6C
			// (set) Token: 0x06002CEF RID: 11503 RVA: 0x00014366 File Offset: 0x00012566
			public unsafe ListDictionary _list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NativeFieldInfoPtr__list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E12 RID: 3602
			// (get) Token: 0x06002CF0 RID: 11504 RVA: 0x000C589C File Offset: 0x000C3A9C
			// (set) Token: 0x06002CF1 RID: 11505 RVA: 0x00014385 File Offset: 0x00012585
			public unsafe bool _isKeys
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NativeFieldInfoPtr__isKeys);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NativeFieldInfoPtr__isKeys)) = value;
				}
			}

			// Token: 0x0400235E RID: 9054
			private static readonly IntPtr NativeFieldInfoPtr__list;

			// Token: 0x0400235F RID: 9055
			private static readonly IntPtr NativeFieldInfoPtr__isKeys;

			// Token: 0x04002360 RID: 9056
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_Boolean_0;

			// Token: 0x04002361 RID: 9057
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x04002362 RID: 9058
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x04002363 RID: 9059
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04002364 RID: 9060
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002365 RID: 9061
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x020003BC RID: 956
			public class NodeKeyValueEnumerator : Object
			{
				// Token: 0x0600359A RID: 13722 RVA: 0x000DE910 File Offset: 0x000DCB10
				// Note: this type is marked as 'beforefieldinit'.
				static NodeKeyValueEnumerator()
				{
					Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, "NodeKeyValueEnumerator");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr);
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "_list");
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "_current");
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "_version");
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr__isKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "_isKeys");
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr__start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "_start");
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, 100666440);
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, 100666441);
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, 100666442);
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, 100666443);
				}

				// Token: 0x0600359B RID: 13723 RVA: 0x000DE9F0 File Offset: 0x000DCBF0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466321, XrefRangeEnd = 466325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe NodeKeyValueEnumerator(ListDictionary list, bool isKeys)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isKeys;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170010C4 RID: 4292
				// (get) Token: 0x0600359C RID: 13724 RVA: 0x000DEA4C File Offset: 0x000DCC4C
				public unsafe virtual Object Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600359D RID: 13725 RVA: 0x000DEA8C File Offset: 0x000DCC8C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466325, XrefRangeEnd = 466326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe virtual bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600359E RID: 13726 RVA: 0x000DEAC8 File Offset: 0x000DCCC8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466326, XrefRangeEnd = 466334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe virtual void Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600359F RID: 13727 RVA: 0x0001A4CE File Offset: 0x000186CE
				public NodeKeyValueEnumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170010BF RID: 4287
				// (get) Token: 0x060035A0 RID: 13728 RVA: 0x000DEAFC File Offset: 0x000DCCFC
				// (set) Token: 0x060035A1 RID: 13729 RVA: 0x0001A4D7 File Offset: 0x000186D7
				public unsafe ListDictionary _list
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr__list);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170010C0 RID: 4288
				// (get) Token: 0x060035A2 RID: 13730 RVA: 0x000DEB2C File Offset: 0x000DCD2C
				// (set) Token: 0x060035A3 RID: 13731 RVA: 0x0001A4F6 File Offset: 0x000186F6
				public unsafe ListDictionary.DictionaryNode _current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary.DictionaryNode>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170010C1 RID: 4289
				// (get) Token: 0x060035A4 RID: 13732 RVA: 0x000DEB5C File Offset: 0x000DCD5C
				// (set) Token: 0x060035A5 RID: 13733 RVA: 0x0001A515 File Offset: 0x00018715
				public unsafe int _version
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr__version);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr__version)) = value;
					}
				}

				// Token: 0x170010C2 RID: 4290
				// (get) Token: 0x060035A6 RID: 13734 RVA: 0x000DEB84 File Offset: 0x000DCD84
				// (set) Token: 0x060035A7 RID: 13735 RVA: 0x0001A530 File Offset: 0x00018730
				public unsafe bool _isKeys
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr__isKeys);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr__isKeys)) = value;
					}
				}

				// Token: 0x170010C3 RID: 4291
				// (get) Token: 0x060035A8 RID: 13736 RVA: 0x000DEBAC File Offset: 0x000DCDAC
				// (set) Token: 0x060035A9 RID: 13737 RVA: 0x0001A54B File Offset: 0x0001874B
				public unsafe bool _start
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr__start);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr__start)) = value;
					}
				}

				// Token: 0x04002883 RID: 10371
				private static readonly IntPtr NativeFieldInfoPtr__list;

				// Token: 0x04002884 RID: 10372
				private static readonly IntPtr NativeFieldInfoPtr__current;

				// Token: 0x04002885 RID: 10373
				private static readonly IntPtr NativeFieldInfoPtr__version;

				// Token: 0x04002886 RID: 10374
				private static readonly IntPtr NativeFieldInfoPtr__isKeys;

				// Token: 0x04002887 RID: 10375
				private static readonly IntPtr NativeFieldInfoPtr__start;

				// Token: 0x04002888 RID: 10376
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_Boolean_0;

				// Token: 0x04002889 RID: 10377
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

				// Token: 0x0400288A RID: 10378
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x0400288B RID: 10379
				private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
			}
		}

		// Token: 0x020002F0 RID: 752
		[Serializable]
		public class DictionaryNode : Object
		{
			// Token: 0x06002CF2 RID: 11506 RVA: 0x000C58C4 File Offset: 0x000C3AC4
			// Note: this type is marked as 'beforefieldinit'.
			static DictionaryNode()
			{
				Il2CppClassPointerStore<ListDictionary.DictionaryNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "DictionaryNode");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionary.DictionaryNode>.NativeClassPtr);
				ListDictionary.DictionaryNode.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.DictionaryNode>.NativeClassPtr, "key");
				ListDictionary.DictionaryNode.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.DictionaryNode>.NativeClassPtr, "value");
				ListDictionary.DictionaryNode.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.DictionaryNode>.NativeClassPtr, "next");
				ListDictionary.DictionaryNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.DictionaryNode>.NativeClassPtr, 100666444);
			}

			// Token: 0x06002CF3 RID: 11507 RVA: 0x000C5940 File Offset: 0x000C3B40
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictionaryNode()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionary.DictionaryNode>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.DictionaryNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CF4 RID: 11508 RVA: 0x000143A0 File Offset: 0x000125A0
			public DictionaryNode(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E16 RID: 3606
			// (get) Token: 0x06002CF5 RID: 11509 RVA: 0x000C597C File Offset: 0x000C3B7C
			// (set) Token: 0x06002CF6 RID: 11510 RVA: 0x000143A9 File Offset: 0x000125A9
			public unsafe Object key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.DictionaryNode.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.DictionaryNode.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E17 RID: 3607
			// (get) Token: 0x06002CF7 RID: 11511 RVA: 0x000C59AC File Offset: 0x000C3BAC
			// (set) Token: 0x06002CF8 RID: 11512 RVA: 0x000143C8 File Offset: 0x000125C8
			public unsafe Object value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.DictionaryNode.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.DictionaryNode.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E18 RID: 3608
			// (get) Token: 0x06002CF9 RID: 11513 RVA: 0x000C59DC File Offset: 0x000C3BDC
			// (set) Token: 0x06002CFA RID: 11514 RVA: 0x000143E7 File Offset: 0x000125E7
			public unsafe ListDictionary.DictionaryNode next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.DictionaryNode.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary.DictionaryNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.DictionaryNode.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002366 RID: 9062
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04002367 RID: 9063
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04002368 RID: 9064
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x04002369 RID: 9065
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
