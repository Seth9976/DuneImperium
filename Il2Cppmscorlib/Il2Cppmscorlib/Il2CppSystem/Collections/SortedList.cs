using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004CB RID: 1227
	[Serializable]
	public class SortedList : Object
	{
		// Token: 0x06004B0F RID: 19215 RVA: 0x0015ACCC File Offset: 0x00158ECC
		// Note: this type is marked as 'beforefieldinit'.
		static SortedList()
		{
			Il2CppClassPointerStore<SortedList>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "SortedList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedList>.NativeClassPtr);
			SortedList.NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "keys");
			SortedList.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "values");
			SortedList.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "_size");
			SortedList.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "version");
			SortedList.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "comparer");
			SortedList.NativeFieldInfoPtr_keyList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "keyList");
			SortedList.NativeFieldInfoPtr_valueList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "valueList");
			SortedList.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "_syncRoot");
			SortedList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674241);
			SortedList.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674242);
			SortedList.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674243);
			SortedList.NativeMethodInfoPtr__ctor_Public_Void_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674244);
			SortedList.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674245);
			SortedList.NativeMethodInfoPtr_set_Capacity_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674246);
			SortedList.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674247);
			SortedList.NativeMethodInfoPtr_get_Keys_Public_Virtual_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674248);
			SortedList.NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674249);
			SortedList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674250);
			SortedList.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674251);
			SortedList.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674252);
			SortedList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674253);
			SortedList.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674254);
			SortedList.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674255);
			SortedList.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674256);
			SortedList.NativeMethodInfoPtr_ContainsKey_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674257);
			SortedList.NativeMethodInfoPtr_ContainsValue_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674258);
			SortedList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674259);
			SortedList.NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674260);
			SortedList.NativeMethodInfoPtr_GetByIndex_Public_Virtual_New_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674261);
			SortedList.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674262);
			SortedList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674263);
			SortedList.NativeMethodInfoPtr_GetKey_Public_Virtual_New_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674264);
			SortedList.NativeMethodInfoPtr_GetKeyList_Public_Virtual_New_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674265);
			SortedList.NativeMethodInfoPtr_GetValueList_Public_Virtual_New_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674266);
			SortedList.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674267);
			SortedList.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674268);
			SortedList.NativeMethodInfoPtr_IndexOfKey_Public_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674269);
			SortedList.NativeMethodInfoPtr_IndexOfValue_Public_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674270);
			SortedList.NativeMethodInfoPtr_Insert_Private_Void_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674271);
			SortedList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674272);
			SortedList.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674273);
			SortedList.NativeMethodInfoPtr_Synchronized_Public_Static_SortedList_SortedList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList>.NativeClassPtr, 100674274);
		}

		// Token: 0x06004B10 RID: 19216 RVA: 0x0015B044 File Offset: 0x00159244
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1415503, RefRangeEnd = 1415508, XrefRangeStart = 1415477, XrefRangeEnd = 1415503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortedList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B11 RID: 19217 RVA: 0x0015B080 File Offset: 0x00159280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415508, XrefRangeEnd = 1415533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B12 RID: 19218 RVA: 0x0015B0B4 File Offset: 0x001592B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1415566, RefRangeEnd = 1415567, XrefRangeStart = 1415533, XrefRangeEnd = 1415566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortedList(int initialCapacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialCapacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B13 RID: 19219 RVA: 0x0015B0FC File Offset: 0x001592FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1415569, RefRangeEnd = 1415571, XrefRangeStart = 1415567, XrefRangeEnd = 1415569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortedList(IComparer comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.NativeMethodInfoPtr__ctor_Public_Void_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B14 RID: 19220 RVA: 0x0015B148 File Offset: 0x00159348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415571, XrefRangeEnd = 1415573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001344 RID: 4932
		// (set) Token: 0x06004B15 RID: 19221 RVA: 0x0015B1A8 File Offset: 0x001593A8
		public unsafe virtual int Capacity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415573, XrefRangeEnd = 1415581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_set_Capacity_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x06004B16 RID: 19222 RVA: 0x0015B1F4 File Offset: 0x001593F4
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x06004B17 RID: 19223 RVA: 0x0015B23C File Offset: 0x0015943C
		public unsafe virtual ICollection Keys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_get_Keys_Public_Virtual_New_get_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x06004B18 RID: 19224 RVA: 0x0015B288 File Offset: 0x00159488
		public unsafe virtual ICollection Values
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x06004B19 RID: 19225 RVA: 0x0015B2D4 File Offset: 0x001594D4
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x06004B1A RID: 19226 RVA: 0x0015B31C File Offset: 0x0015951C
		public unsafe virtual bool IsFixedSize
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x06004B1B RID: 19227 RVA: 0x0015B364 File Offset: 0x00159564
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x06004B1C RID: 19228 RVA: 0x0015B3AC File Offset: 0x001595AC
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415581, XrefRangeEnd = 1415586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x0015B3F8 File Offset: 0x001595F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415586, XrefRangeEnd = 1415588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x0015B434 File Offset: 0x00159634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415588, XrefRangeEnd = 1415595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x0015B480 File Offset: 0x00159680
		[CallerCount(0)]
		public unsafe virtual bool Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004B20 RID: 19232 RVA: 0x0015B4D8 File Offset: 0x001596D8
		[CallerCount(0)]
		public unsafe virtual bool ContainsKey(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_ContainsKey_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004B21 RID: 19233 RVA: 0x0015B530 File Offset: 0x00159730
		[CallerCount(0)]
		public unsafe virtual bool ContainsValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_ContainsValue_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x0015B588 File Offset: 0x00159788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415595, XrefRangeEnd = 1415603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x0015B5E4 File Offset: 0x001597E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415603, XrefRangeEnd = 1415605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureCapacity(int min)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B24 RID: 19236 RVA: 0x0015B624 File Offset: 0x00159824
		[CallerCount(0)]
		public unsafe virtual Object GetByIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_GetByIndex_Public_Virtual_New_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004B25 RID: 19237 RVA: 0x0015B67C File Offset: 0x0015987C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415605, XrefRangeEnd = 1415610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004B26 RID: 19238 RVA: 0x0015B6BC File Offset: 0x001598BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415610, XrefRangeEnd = 1415615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IDictionaryEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004B27 RID: 19239 RVA: 0x0015B708 File Offset: 0x00159908
		[CallerCount(0)]
		public unsafe virtual Object GetKey(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_GetKey_Public_Virtual_New_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004B28 RID: 19240 RVA: 0x0015B760 File Offset: 0x00159960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415615, XrefRangeEnd = 1415621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IList GetKeyList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_GetKeyList_Public_Virtual_New_IList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x0015B7AC File Offset: 0x001599AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415621, XrefRangeEnd = 1415627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IList GetValueList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_GetValueList_Public_Virtual_New_IList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
		}

		// Token: 0x1700134C RID: 4940
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415627, XrefRangeEnd = 1415629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x0015B8B4 File Offset: 0x00159AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415629, XrefRangeEnd = 1415630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int IndexOfKey(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_IndexOfKey_Public_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004B2D RID: 19245 RVA: 0x0015B90C File Offset: 0x00159B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415630, XrefRangeEnd = 1415633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int IndexOfValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_IndexOfValue_Public_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004B2E RID: 19246 RVA: 0x0015B964 File Offset: 0x00159B64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1415640, RefRangeEnd = 1415642, XrefRangeStart = 1415633, XrefRangeEnd = 1415640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(int index, Object key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.NativeMethodInfoPtr_Insert_Private_Void_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B2F RID: 19247 RVA: 0x0015B9C8 File Offset: 0x00159BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415642, XrefRangeEnd = 1415646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B30 RID: 19248 RVA: 0x0015BA14 File Offset: 0x00159C14
		[CallerCount(0)]
		public unsafe virtual void Remove(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B31 RID: 19249 RVA: 0x0015BA64 File Offset: 0x00159C64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1415652, RefRangeEnd = 1415654, XrefRangeStart = 1415646, XrefRangeEnd = 1415652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SortedList Synchronized(SortedList list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.NativeMethodInfoPtr_Synchronized_Public_Static_SortedList_SortedList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedList>(intPtr3) : null;
			}
		}

		// Token: 0x06004B32 RID: 19250 RVA: 0x0001B780 File Offset: 0x00019980
		public SortedList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x06004B33 RID: 19251 RVA: 0x0015BAA8 File Offset: 0x00159CA8
		// (set) Token: 0x06004B34 RID: 19252 RVA: 0x0001B789 File Offset: 0x00019989
		public unsafe Il2CppReferenceArray<Object> keys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_keys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_keys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x06004B35 RID: 19253 RVA: 0x0015BAD8 File Offset: 0x00159CD8
		// (set) Token: 0x06004B36 RID: 19254 RVA: 0x0001B7A8 File Offset: 0x000199A8
		public unsafe Il2CppReferenceArray<Object> values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x06004B37 RID: 19255 RVA: 0x0015BB08 File Offset: 0x00159D08
		// (set) Token: 0x06004B38 RID: 19256 RVA: 0x0001B7C7 File Offset: 0x000199C7
		public unsafe int _size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr__size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr__size)) = value;
			}
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x06004B39 RID: 19257 RVA: 0x0015BB30 File Offset: 0x00159D30
		// (set) Token: 0x06004B3A RID: 19258 RVA: 0x0001B7E2 File Offset: 0x000199E2
		public unsafe int version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x06004B3B RID: 19259 RVA: 0x0015BB58 File Offset: 0x00159D58
		// (set) Token: 0x06004B3C RID: 19260 RVA: 0x0001B7FD File Offset: 0x000199FD
		public unsafe IComparer comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x06004B3D RID: 19261 RVA: 0x0015BB88 File Offset: 0x00159D88
		// (set) Token: 0x06004B3E RID: 19262 RVA: 0x0001B81C File Offset: 0x00019A1C
		public unsafe SortedList.KeyList keyList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_keyList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList.KeyList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_keyList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x06004B3F RID: 19263 RVA: 0x0015BBB8 File Offset: 0x00159DB8
		// (set) Token: 0x06004B40 RID: 19264 RVA: 0x0001B83B File Offset: 0x00019A3B
		public unsafe SortedList.ValueList valueList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_valueList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList.ValueList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr_valueList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x06004B41 RID: 19265 RVA: 0x0015BBE8 File Offset: 0x00159DE8
		// (set) Token: 0x06004B42 RID: 19266 RVA: 0x0001B85A File Offset: 0x00019A5A
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D73 RID: 15731
		private static readonly IntPtr NativeFieldInfoPtr_keys;

		// Token: 0x04003D74 RID: 15732
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x04003D75 RID: 15733
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x04003D76 RID: 15734
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04003D77 RID: 15735
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x04003D78 RID: 15736
		private static readonly IntPtr NativeFieldInfoPtr_keyList;

		// Token: 0x04003D79 RID: 15737
		private static readonly IntPtr NativeFieldInfoPtr_valueList;

		// Token: 0x04003D7A RID: 15738
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x04003D7B RID: 15739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003D7C RID: 15740
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04003D7D RID: 15741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003D7E RID: 15742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IComparer_0;

		// Token: 0x04003D7F RID: 15743
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Void_Object_Object_0;

		// Token: 0x04003D80 RID: 15744
		private static readonly IntPtr NativeMethodInfoPtr_set_Capacity_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04003D81 RID: 15745
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x04003D82 RID: 15746
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_New_get_ICollection_0;

		// Token: 0x04003D83 RID: 15747
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_ICollection_0;

		// Token: 0x04003D84 RID: 15748
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003D85 RID: 15749
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003D86 RID: 15750
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003D87 RID: 15751
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0;

		// Token: 0x04003D88 RID: 15752
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

		// Token: 0x04003D89 RID: 15753
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x04003D8A RID: 15754
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x04003D8B RID: 15755
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x04003D8C RID: 15756
		private static readonly IntPtr NativeMethodInfoPtr_ContainsValue_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x04003D8D RID: 15757
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

		// Token: 0x04003D8E RID: 15758
		private static readonly IntPtr NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0;

		// Token: 0x04003D8F RID: 15759
		private static readonly IntPtr NativeMethodInfoPtr_GetByIndex_Public_Virtual_New_Object_Int32_0;

		// Token: 0x04003D90 RID: 15760
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04003D91 RID: 15761
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IDictionaryEnumerator_0;

		// Token: 0x04003D92 RID: 15762
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_Virtual_New_Object_Int32_0;

		// Token: 0x04003D93 RID: 15763
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyList_Public_Virtual_New_IList_0;

		// Token: 0x04003D94 RID: 15764
		private static readonly IntPtr NativeMethodInfoPtr_GetValueList_Public_Virtual_New_IList_0;

		// Token: 0x04003D95 RID: 15765
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Object_0;

		// Token: 0x04003D96 RID: 15766
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Object_Object_0;

		// Token: 0x04003D97 RID: 15767
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfKey_Public_Virtual_New_Int32_Object_0;

		// Token: 0x04003D98 RID: 15768
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfValue_Public_Virtual_New_Int32_Object_0;

		// Token: 0x04003D99 RID: 15769
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Private_Void_Int32_Object_Object_0;

		// Token: 0x04003D9A RID: 15770
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04003D9B RID: 15771
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0;

		// Token: 0x04003D9C RID: 15772
		private static readonly IntPtr NativeMethodInfoPtr_Synchronized_Public_Static_SortedList_SortedList_0;

		// Token: 0x020006E5 RID: 1765
		[Serializable]
		public class SyncSortedList : SortedList
		{
			// Token: 0x06005D9E RID: 23966 RVA: 0x001A736C File Offset: 0x001A556C
			// Note: this type is marked as 'beforefieldinit'.
			static SyncSortedList()
			{
				Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "SyncSortedList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr);
				SortedList.SyncSortedList.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, "_list");
				SortedList.SyncSortedList.NativeFieldInfoPtr__root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, "_root");
				SortedList.SyncSortedList.NativeMethodInfoPtr__ctor_Internal_Void_SortedList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674275);
				SortedList.SyncSortedList.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674276);
				SortedList.SyncSortedList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674277);
				SortedList.SyncSortedList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674278);
				SortedList.SyncSortedList.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674279);
				SortedList.SyncSortedList.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674280);
				SortedList.SyncSortedList.NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674281);
				SortedList.SyncSortedList.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674282);
				SortedList.SyncSortedList.NativeMethodInfoPtr_Add_Public_Virtual_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674283);
				SortedList.SyncSortedList.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674284);
				SortedList.SyncSortedList.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674285);
				SortedList.SyncSortedList.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674286);
				SortedList.SyncSortedList.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674287);
				SortedList.SyncSortedList.NativeMethodInfoPtr_ContainsValue_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674288);
				SortedList.SyncSortedList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674289);
				SortedList.SyncSortedList.NativeMethodInfoPtr_GetByIndex_Public_Virtual_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674290);
				SortedList.SyncSortedList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674291);
				SortedList.SyncSortedList.NativeMethodInfoPtr_GetKey_Public_Virtual_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674292);
				SortedList.SyncSortedList.NativeMethodInfoPtr_GetKeyList_Public_Virtual_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674293);
				SortedList.SyncSortedList.NativeMethodInfoPtr_GetValueList_Public_Virtual_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674294);
				SortedList.SyncSortedList.NativeMethodInfoPtr_IndexOfKey_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674295);
				SortedList.SyncSortedList.NativeMethodInfoPtr_IndexOfValue_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674296);
				SortedList.SyncSortedList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674297);
				SortedList.SyncSortedList.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr, 100674298);
			}

			// Token: 0x06005D9F RID: 23967 RVA: 0x001A75A0 File Offset: 0x001A57A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415276, XrefRangeEnd = 1415280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SyncSortedList(SortedList list)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedList.SyncSortedList>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.SyncSortedList.NativeMethodInfoPtr__ctor_Internal_Void_SortedList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001805 RID: 6149
			// (get) Token: 0x06005DA0 RID: 23968 RVA: 0x001A75EC File Offset: 0x001A57EC
			public unsafe override int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415280, XrefRangeEnd = 1415284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001806 RID: 6150
			// (get) Token: 0x06005DA1 RID: 23969 RVA: 0x001A7634 File Offset: 0x001A5834
			public unsafe override Object SyncRoot
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001807 RID: 6151
			// (get) Token: 0x06005DA2 RID: 23970 RVA: 0x001A7680 File Offset: 0x001A5880
			public unsafe override bool IsReadOnly
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415284, XrefRangeEnd = 1415285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001808 RID: 6152
			// (get) Token: 0x06005DA3 RID: 23971 RVA: 0x001A76C8 File Offset: 0x001A58C8
			public unsafe override bool IsFixedSize
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415285, XrefRangeEnd = 1415286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001809 RID: 6153
			// (get) Token: 0x06005DA4 RID: 23972 RVA: 0x001A7710 File Offset: 0x001A5910
			public unsafe override bool IsSynchronized
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700180A RID: 6154
			public unsafe override Object this[Object key]
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415286, XrefRangeEnd = 1415290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415290, XrefRangeEnd = 1415294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005DA7 RID: 23975 RVA: 0x001A7814 File Offset: 0x001A5A14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415294, XrefRangeEnd = 1415298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Add(Object key, Object value)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_Add_Public_Virtual_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005DA8 RID: 23976 RVA: 0x001A7874 File Offset: 0x001A5A74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415298, XrefRangeEnd = 1415302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005DA9 RID: 23977 RVA: 0x001A78B0 File Offset: 0x001A5AB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415302, XrefRangeEnd = 1415306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06005DAA RID: 23978 RVA: 0x001A78FC File Offset: 0x001A5AFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415306, XrefRangeEnd = 1415310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Contains(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005DAB RID: 23979 RVA: 0x001A7954 File Offset: 0x001A5B54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415310, XrefRangeEnd = 1415314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ContainsKey(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005DAC RID: 23980 RVA: 0x001A79AC File Offset: 0x001A5BAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415314, XrefRangeEnd = 1415318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ContainsValue(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_ContainsValue_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005DAD RID: 23981 RVA: 0x001A7A04 File Offset: 0x001A5C04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415318, XrefRangeEnd = 1415322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void CopyTo(Array array, int index)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005DAE RID: 23982 RVA: 0x001A7A60 File Offset: 0x001A5C60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415322, XrefRangeEnd = 1415326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object GetByIndex(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_GetByIndex_Public_Virtual_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005DAF RID: 23983 RVA: 0x001A7AB8 File Offset: 0x001A5CB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415326, XrefRangeEnd = 1415330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IDictionaryEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005DB0 RID: 23984 RVA: 0x001A7B04 File Offset: 0x001A5D04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415330, XrefRangeEnd = 1415334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object GetKey(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_GetKey_Public_Virtual_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005DB1 RID: 23985 RVA: 0x001A7B5C File Offset: 0x001A5D5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415334, XrefRangeEnd = 1415338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IList GetKeyList()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_GetKeyList_Public_Virtual_IList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
			}

			// Token: 0x06005DB2 RID: 23986 RVA: 0x001A7BA8 File Offset: 0x001A5DA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415338, XrefRangeEnd = 1415342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IList GetValueList()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_GetValueList_Public_Virtual_IList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
			}

			// Token: 0x06005DB3 RID: 23987 RVA: 0x001A7BF4 File Offset: 0x001A5DF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415342, XrefRangeEnd = 1415346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int IndexOfKey(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_IndexOfKey_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005DB4 RID: 23988 RVA: 0x001A7C4C File Offset: 0x001A5E4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415346, XrefRangeEnd = 1415350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int IndexOfValue(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_IndexOfValue_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005DB5 RID: 23989 RVA: 0x001A7CA4 File Offset: 0x001A5EA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415350, XrefRangeEnd = 1415354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void RemoveAt(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005DB6 RID: 23990 RVA: 0x001A7CF0 File Offset: 0x001A5EF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415354, XrefRangeEnd = 1415358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Remove(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SyncSortedList.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005DB7 RID: 23991 RVA: 0x000223C1 File Offset: 0x000205C1
			public SyncSortedList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001803 RID: 6147
			// (get) Token: 0x06005DB8 RID: 23992 RVA: 0x001A7D40 File Offset: 0x001A5F40
			// (set) Token: 0x06005DB9 RID: 23993 RVA: 0x000223CA File Offset: 0x000205CA
			public unsafe SortedList _list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SyncSortedList.NativeFieldInfoPtr__list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SyncSortedList.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001804 RID: 6148
			// (get) Token: 0x06005DBA RID: 23994 RVA: 0x001A7D70 File Offset: 0x001A5F70
			// (set) Token: 0x06005DBB RID: 23995 RVA: 0x000223E9 File Offset: 0x000205E9
			public unsafe Object _root
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SyncSortedList.NativeFieldInfoPtr__root);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SyncSortedList.NativeFieldInfoPtr__root), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004C56 RID: 19542
			private static readonly IntPtr NativeFieldInfoPtr__list;

			// Token: 0x04004C57 RID: 19543
			private static readonly IntPtr NativeFieldInfoPtr__root;

			// Token: 0x04004C58 RID: 19544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SortedList_0;

			// Token: 0x04004C59 RID: 19545
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;

			// Token: 0x04004C5A RID: 19546
			private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0;

			// Token: 0x04004C5B RID: 19547
			private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;

			// Token: 0x04004C5C RID: 19548
			private static readonly IntPtr NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_get_Boolean_0;

			// Token: 0x04004C5D RID: 19549
			private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0;

			// Token: 0x04004C5E RID: 19550
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Object_0;

			// Token: 0x04004C5F RID: 19551
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_Object_0;

			// Token: 0x04004C60 RID: 19552
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Void_Object_Object_0;

			// Token: 0x04004C61 RID: 19553
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Void_0;

			// Token: 0x04004C62 RID: 19554
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

			// Token: 0x04004C63 RID: 19555
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0;

			// Token: 0x04004C64 RID: 19556
			private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Boolean_Object_0;

			// Token: 0x04004C65 RID: 19557
			private static readonly IntPtr NativeMethodInfoPtr_ContainsValue_Public_Virtual_Boolean_Object_0;

			// Token: 0x04004C66 RID: 19558
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0;

			// Token: 0x04004C67 RID: 19559
			private static readonly IntPtr NativeMethodInfoPtr_GetByIndex_Public_Virtual_Object_Int32_0;

			// Token: 0x04004C68 RID: 19560
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0;

			// Token: 0x04004C69 RID: 19561
			private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_Virtual_Object_Int32_0;

			// Token: 0x04004C6A RID: 19562
			private static readonly IntPtr NativeMethodInfoPtr_GetKeyList_Public_Virtual_IList_0;

			// Token: 0x04004C6B RID: 19563
			private static readonly IntPtr NativeMethodInfoPtr_GetValueList_Public_Virtual_IList_0;

			// Token: 0x04004C6C RID: 19564
			private static readonly IntPtr NativeMethodInfoPtr_IndexOfKey_Public_Virtual_Int32_Object_0;

			// Token: 0x04004C6D RID: 19565
			private static readonly IntPtr NativeMethodInfoPtr_IndexOfValue_Public_Virtual_Int32_Object_0;

			// Token: 0x04004C6E RID: 19566
			private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_Void_Int32_0;

			// Token: 0x04004C6F RID: 19567
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0;
		}

		// Token: 0x020006E6 RID: 1766
		[Serializable]
		public class SortedListEnumerator : Object
		{
			// Token: 0x06005DBC RID: 23996 RVA: 0x001A7DA0 File Offset: 0x001A5FA0
			// Note: this type is marked as 'beforefieldinit'.
			static SortedListEnumerator()
			{
				Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "SortedListEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr);
				SortedList.SortedListEnumerator.NativeFieldInfoPtr__sortedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, "_sortedList");
				SortedList.SortedListEnumerator.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, "_key");
				SortedList.SortedListEnumerator.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, "_value");
				SortedList.SortedListEnumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, "_index");
				SortedList.SortedListEnumerator.NativeFieldInfoPtr__startIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, "_startIndex");
				SortedList.SortedListEnumerator.NativeFieldInfoPtr__endIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, "_endIndex");
				SortedList.SortedListEnumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, "_version");
				SortedList.SortedListEnumerator.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, "_current");
				SortedList.SortedListEnumerator.NativeFieldInfoPtr__getObjectRetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, "_getObjectRetType");
				SortedList.SortedListEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedList_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, 100674299);
				SortedList.SortedListEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, 100674300);
				SortedList.SortedListEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, 100674301);
				SortedList.SortedListEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, 100674302);
				SortedList.SortedListEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, 100674303);
				SortedList.SortedListEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, 100674304);
				SortedList.SortedListEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, 100674305);
				SortedList.SortedListEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr, 100674306);
			}

			// Token: 0x06005DBD RID: 23997 RVA: 0x001A7F20 File Offset: 0x001A6120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415358, XrefRangeEnd = 1415360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SortedListEnumerator(SortedList sortedList, int index, int count, int getObjRetType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedList.SortedListEnumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sortedList);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref getObjRetType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.SortedListEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedList_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005DBE RID: 23998 RVA: 0x001A7F98 File Offset: 0x001A6198
			[CallerCount(105)]
			[CachedScanResults(RefRangeStart = 1172447, RefRangeEnd = 1172552, XrefRangeStart = 1172447, XrefRangeEnd = 1172552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.SortedListEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x17001814 RID: 6164
			// (get) Token: 0x06005DBF RID: 23999 RVA: 0x001A7FD8 File Offset: 0x001A61D8
			public unsafe virtual Object Key
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SortedListEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005DC0 RID: 24000 RVA: 0x001A8024 File Offset: 0x001A6224
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415360, XrefRangeEnd = 1415362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SortedListEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001815 RID: 6165
			// (get) Token: 0x06005DC1 RID: 24001 RVA: 0x001A806C File Offset: 0x001A626C
			public unsafe virtual DictionaryEntry Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415362, XrefRangeEnd = 1415364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SortedListEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_New_get_DictionaryEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x17001816 RID: 6166
			// (get) Token: 0x06005DC2 RID: 24002 RVA: 0x001A80B0 File Offset: 0x001A62B0
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415364, XrefRangeEnd = 1415369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SortedListEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001817 RID: 6167
			// (get) Token: 0x06005DC3 RID: 24003 RVA: 0x001A80FC File Offset: 0x001A62FC
			public unsafe virtual Object Value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SortedListEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005DC4 RID: 24004 RVA: 0x001A8148 File Offset: 0x001A6348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415369, XrefRangeEnd = 1415378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.SortedListEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005DC5 RID: 24005 RVA: 0x00022408 File Offset: 0x00020608
			public SortedListEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700180B RID: 6155
			// (get) Token: 0x06005DC6 RID: 24006 RVA: 0x001A8184 File Offset: 0x001A6384
			// (set) Token: 0x06005DC7 RID: 24007 RVA: 0x00022411 File Offset: 0x00020611
			public unsafe SortedList _sortedList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr__sortedList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr__sortedList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700180C RID: 6156
			// (get) Token: 0x06005DC8 RID: 24008 RVA: 0x001A81B4 File Offset: 0x001A63B4
			// (set) Token: 0x06005DC9 RID: 24009 RVA: 0x00022430 File Offset: 0x00020630
			public unsafe Object _key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr__key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr__key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700180D RID: 6157
			// (get) Token: 0x06005DCA RID: 24010 RVA: 0x001A81E4 File Offset: 0x001A63E4
			// (set) Token: 0x06005DCB RID: 24011 RVA: 0x0002244F File Offset: 0x0002064F
			public unsafe Object _value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr__value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr__value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700180E RID: 6158
			// (get) Token: 0x06005DCC RID: 24012 RVA: 0x001A8214 File Offset: 0x001A6414
			// (set) Token: 0x06005DCD RID: 24013 RVA: 0x0002246E File Offset: 0x0002066E
			public unsafe int _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr__index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr__index)) = value;
				}
			}

			// Token: 0x1700180F RID: 6159
			// (get) Token: 0x06005DCE RID: 24014 RVA: 0x001A823C File Offset: 0x001A643C
			// (set) Token: 0x06005DCF RID: 24015 RVA: 0x00022489 File Offset: 0x00020689
			public unsafe int _startIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr__startIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr__startIndex)) = value;
				}
			}

			// Token: 0x17001810 RID: 6160
			// (get) Token: 0x06005DD0 RID: 24016 RVA: 0x001A8264 File Offset: 0x001A6464
			// (set) Token: 0x06005DD1 RID: 24017 RVA: 0x000224A4 File Offset: 0x000206A4
			public unsafe int _endIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr__endIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr__endIndex)) = value;
				}
			}

			// Token: 0x17001811 RID: 6161
			// (get) Token: 0x06005DD2 RID: 24018 RVA: 0x001A828C File Offset: 0x001A648C
			// (set) Token: 0x06005DD3 RID: 24019 RVA: 0x000224BF File Offset: 0x000206BF
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x17001812 RID: 6162
			// (get) Token: 0x06005DD4 RID: 24020 RVA: 0x001A82B4 File Offset: 0x001A64B4
			// (set) Token: 0x06005DD5 RID: 24021 RVA: 0x000224DA File Offset: 0x000206DA
			public unsafe bool _current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr__current)) = value;
				}
			}

			// Token: 0x17001813 RID: 6163
			// (get) Token: 0x06005DD6 RID: 24022 RVA: 0x001A82DC File Offset: 0x001A64DC
			// (set) Token: 0x06005DD7 RID: 24023 RVA: 0x000224F5 File Offset: 0x000206F5
			public unsafe int _getObjectRetType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr__getObjectRetType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.SortedListEnumerator.NativeFieldInfoPtr__getObjectRetType)) = value;
				}
			}

			// Token: 0x04004C70 RID: 19568
			private static readonly IntPtr NativeFieldInfoPtr__sortedList;

			// Token: 0x04004C71 RID: 19569
			private static readonly IntPtr NativeFieldInfoPtr__key;

			// Token: 0x04004C72 RID: 19570
			private static readonly IntPtr NativeFieldInfoPtr__value;

			// Token: 0x04004C73 RID: 19571
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x04004C74 RID: 19572
			private static readonly IntPtr NativeFieldInfoPtr__startIndex;

			// Token: 0x04004C75 RID: 19573
			private static readonly IntPtr NativeFieldInfoPtr__endIndex;

			// Token: 0x04004C76 RID: 19574
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x04004C77 RID: 19575
			private static readonly IntPtr NativeFieldInfoPtr__current;

			// Token: 0x04004C78 RID: 19576
			private static readonly IntPtr NativeFieldInfoPtr__getObjectRetType;

			// Token: 0x04004C79 RID: 19577
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SortedList_Int32_Int32_Int32_0;

			// Token: 0x04004C7A RID: 19578
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

			// Token: 0x04004C7B RID: 19579
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Object_0;

			// Token: 0x04004C7C RID: 19580
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0;

			// Token: 0x04004C7D RID: 19581
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_New_get_DictionaryEntry_0;

			// Token: 0x04004C7E RID: 19582
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0;

			// Token: 0x04004C7F RID: 19583
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_Object_0;

			// Token: 0x04004C80 RID: 19584
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;
		}

		// Token: 0x020006E7 RID: 1767
		[Serializable]
		public class KeyList : Object
		{
			// Token: 0x06005DD8 RID: 24024 RVA: 0x001A8304 File Offset: 0x001A6504
			// Note: this type is marked as 'beforefieldinit'.
			static KeyList()
			{
				Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "KeyList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr);
				SortedList.KeyList.NativeFieldInfoPtr_sortedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, "sortedList");
				SortedList.KeyList.NativeMethodInfoPtr__ctor_Internal_Void_SortedList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100674307);
				SortedList.KeyList.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100674308);
				SortedList.KeyList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100674309);
				SortedList.KeyList.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100674310);
				SortedList.KeyList.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100674311);
				SortedList.KeyList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100674312);
				SortedList.KeyList.NativeMethodInfoPtr_Add_Public_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100674313);
				SortedList.KeyList.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100674314);
				SortedList.KeyList.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100674315);
				SortedList.KeyList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100674316);
				SortedList.KeyList.NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100674317);
				SortedList.KeyList.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100674318);
				SortedList.KeyList.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100674319);
				SortedList.KeyList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100674320);
				SortedList.KeyList.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100674321);
				SortedList.KeyList.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100674322);
				SortedList.KeyList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr, 100674323);
			}

			// Token: 0x06005DD9 RID: 24025 RVA: 0x001A8498 File Offset: 0x001A6698
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyList(SortedList sortedList)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedList.KeyList>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sortedList);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.KeyList.NativeMethodInfoPtr__ctor_Internal_Void_SortedList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001819 RID: 6169
			// (get) Token: 0x06005DDA RID: 24026 RVA: 0x001A84E4 File Offset: 0x001A66E4
			public unsafe virtual int Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700181A RID: 6170
			// (get) Token: 0x06005DDB RID: 24027 RVA: 0x001A852C File Offset: 0x001A672C
			public unsafe virtual bool IsReadOnly
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700181B RID: 6171
			// (get) Token: 0x06005DDC RID: 24028 RVA: 0x001A8574 File Offset: 0x001A6774
			public unsafe virtual bool IsFixedSize
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700181C RID: 6172
			// (get) Token: 0x06005DDD RID: 24029 RVA: 0x001A85BC File Offset: 0x001A67BC
			public unsafe virtual bool IsSynchronized
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700181D RID: 6173
			// (get) Token: 0x06005DDE RID: 24030 RVA: 0x001A8604 File Offset: 0x001A6804
			public unsafe virtual Object SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005DDF RID: 24031 RVA: 0x001A8650 File Offset: 0x001A6850
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415378, XrefRangeEnd = 1415384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int Add(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_Add_Public_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005DE0 RID: 24032 RVA: 0x001A86A8 File Offset: 0x001A68A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415384, XrefRangeEnd = 1415390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005DE1 RID: 24033 RVA: 0x001A86E4 File Offset: 0x001A68E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415390, XrefRangeEnd = 1415391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool Contains(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005DE2 RID: 24034 RVA: 0x001A873C File Offset: 0x001A693C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415391, XrefRangeEnd = 1415393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void CopyTo(Array array, int arrayIndex)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005DE3 RID: 24035 RVA: 0x001A8798 File Offset: 0x001A6998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415393, XrefRangeEnd = 1415399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Insert(int index, Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700181E RID: 6174
			public unsafe virtual Object this[int index]
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415399, XrefRangeEnd = 1415405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005DE6 RID: 24038 RVA: 0x001A88A8 File Offset: 0x001A6AA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415405, XrefRangeEnd = 1415410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005DE7 RID: 24039 RVA: 0x001A88F4 File Offset: 0x001A6AF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415410, XrefRangeEnd = 1415411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int IndexOf(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005DE8 RID: 24040 RVA: 0x001A894C File Offset: 0x001A6B4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415411, XrefRangeEnd = 1415417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Remove(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005DE9 RID: 24041 RVA: 0x001A899C File Offset: 0x001A6B9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415417, XrefRangeEnd = 1415423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void RemoveAt(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.KeyList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005DEA RID: 24042 RVA: 0x00022510 File Offset: 0x00020710
			public KeyList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001818 RID: 6168
			// (get) Token: 0x06005DEB RID: 24043 RVA: 0x001A89E8 File Offset: 0x001A6BE8
			// (set) Token: 0x06005DEC RID: 24044 RVA: 0x00022519 File Offset: 0x00020719
			public unsafe SortedList sortedList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.KeyList.NativeFieldInfoPtr_sortedList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.KeyList.NativeFieldInfoPtr_sortedList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004C81 RID: 19585
			private static readonly IntPtr NativeFieldInfoPtr_sortedList;

			// Token: 0x04004C82 RID: 19586
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SortedList_0;

			// Token: 0x04004C83 RID: 19587
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

			// Token: 0x04004C84 RID: 19588
			private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0;

			// Token: 0x04004C85 RID: 19589
			private static readonly IntPtr NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_New_get_Boolean_0;

			// Token: 0x04004C86 RID: 19590
			private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0;

			// Token: 0x04004C87 RID: 19591
			private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0;

			// Token: 0x04004C88 RID: 19592
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Int32_Object_0;

			// Token: 0x04004C89 RID: 19593
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

			// Token: 0x04004C8A RID: 19594
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0;

			// Token: 0x04004C8B RID: 19595
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

			// Token: 0x04004C8C RID: 19596
			private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_Object_0;

			// Token: 0x04004C8D RID: 19597
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Int32_0;

			// Token: 0x04004C8E RID: 19598
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_Object_0;

			// Token: 0x04004C8F RID: 19599
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

			// Token: 0x04004C90 RID: 19600
			private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_Object_0;

			// Token: 0x04004C91 RID: 19601
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0;

			// Token: 0x04004C92 RID: 19602
			private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0;
		}

		// Token: 0x020006E8 RID: 1768
		[Serializable]
		public class ValueList : Object
		{
			// Token: 0x06005DED RID: 24045 RVA: 0x001A8A18 File Offset: 0x001A6C18
			// Note: this type is marked as 'beforefieldinit'.
			static ValueList()
			{
				Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "ValueList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr);
				SortedList.ValueList.NativeFieldInfoPtr_sortedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, "sortedList");
				SortedList.ValueList.NativeMethodInfoPtr__ctor_Internal_Void_SortedList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100674324);
				SortedList.ValueList.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100674325);
				SortedList.ValueList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100674326);
				SortedList.ValueList.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100674327);
				SortedList.ValueList.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100674328);
				SortedList.ValueList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100674329);
				SortedList.ValueList.NativeMethodInfoPtr_Add_Public_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100674330);
				SortedList.ValueList.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100674331);
				SortedList.ValueList.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100674332);
				SortedList.ValueList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100674333);
				SortedList.ValueList.NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100674334);
				SortedList.ValueList.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100674335);
				SortedList.ValueList.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100674336);
				SortedList.ValueList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100674337);
				SortedList.ValueList.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100674338);
				SortedList.ValueList.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100674339);
				SortedList.ValueList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr, 100674340);
			}

			// Token: 0x06005DEE RID: 24046 RVA: 0x001A8BAC File Offset: 0x001A6DAC
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueList(SortedList sortedList)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedList.ValueList>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sortedList);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedList.ValueList.NativeMethodInfoPtr__ctor_Internal_Void_SortedList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001820 RID: 6176
			// (get) Token: 0x06005DEF RID: 24047 RVA: 0x001A8BF8 File Offset: 0x001A6DF8
			public unsafe virtual int Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001821 RID: 6177
			// (get) Token: 0x06005DF0 RID: 24048 RVA: 0x001A8C40 File Offset: 0x001A6E40
			public unsafe virtual bool IsReadOnly
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001822 RID: 6178
			// (get) Token: 0x06005DF1 RID: 24049 RVA: 0x001A8C88 File Offset: 0x001A6E88
			public unsafe virtual bool IsFixedSize
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001823 RID: 6179
			// (get) Token: 0x06005DF2 RID: 24050 RVA: 0x001A8CD0 File Offset: 0x001A6ED0
			public unsafe virtual bool IsSynchronized
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001824 RID: 6180
			// (get) Token: 0x06005DF3 RID: 24051 RVA: 0x001A8D18 File Offset: 0x001A6F18
			public unsafe virtual Object SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005DF4 RID: 24052 RVA: 0x001A8D64 File Offset: 0x001A6F64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415423, XrefRangeEnd = 1415429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int Add(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_Add_Public_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005DF5 RID: 24053 RVA: 0x001A8DBC File Offset: 0x001A6FBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415429, XrefRangeEnd = 1415435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005DF6 RID: 24054 RVA: 0x001A8DF8 File Offset: 0x001A6FF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415435, XrefRangeEnd = 1415436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool Contains(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005DF7 RID: 24055 RVA: 0x001A8E50 File Offset: 0x001A7050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415436, XrefRangeEnd = 1415438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void CopyTo(Array array, int arrayIndex)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005DF8 RID: 24056 RVA: 0x001A8EAC File Offset: 0x001A70AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415438, XrefRangeEnd = 1415444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Insert(int index, Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001825 RID: 6181
			public unsafe virtual Object this[int index]
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415444, XrefRangeEnd = 1415445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415445, XrefRangeEnd = 1415457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005DFB RID: 24059 RVA: 0x001A8FBC File Offset: 0x001A71BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415457, XrefRangeEnd = 1415462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005DFC RID: 24060 RVA: 0x001A9008 File Offset: 0x001A7208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415462, XrefRangeEnd = 1415465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int IndexOf(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005DFD RID: 24061 RVA: 0x001A9060 File Offset: 0x001A7260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415465, XrefRangeEnd = 1415471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Remove(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005DFE RID: 24062 RVA: 0x001A90B0 File Offset: 0x001A72B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415471, XrefRangeEnd = 1415477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void RemoveAt(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortedList.ValueList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005DFF RID: 24063 RVA: 0x00022538 File Offset: 0x00020738
			public ValueList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700181F RID: 6175
			// (get) Token: 0x06005E00 RID: 24064 RVA: 0x001A90FC File Offset: 0x001A72FC
			// (set) Token: 0x06005E01 RID: 24065 RVA: 0x00022541 File Offset: 0x00020741
			public unsafe SortedList sortedList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.ValueList.NativeFieldInfoPtr_sortedList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedList.ValueList.NativeFieldInfoPtr_sortedList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004C93 RID: 19603
			private static readonly IntPtr NativeFieldInfoPtr_sortedList;

			// Token: 0x04004C94 RID: 19604
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SortedList_0;

			// Token: 0x04004C95 RID: 19605
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

			// Token: 0x04004C96 RID: 19606
			private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0;

			// Token: 0x04004C97 RID: 19607
			private static readonly IntPtr NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_New_get_Boolean_0;

			// Token: 0x04004C98 RID: 19608
			private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0;

			// Token: 0x04004C99 RID: 19609
			private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0;

			// Token: 0x04004C9A RID: 19610
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Int32_Object_0;

			// Token: 0x04004C9B RID: 19611
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

			// Token: 0x04004C9C RID: 19612
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0;

			// Token: 0x04004C9D RID: 19613
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

			// Token: 0x04004C9E RID: 19614
			private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_Object_0;

			// Token: 0x04004C9F RID: 19615
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Int32_0;

			// Token: 0x04004CA0 RID: 19616
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_Object_0;

			// Token: 0x04004CA1 RID: 19617
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

			// Token: 0x04004CA2 RID: 19618
			private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_Object_0;

			// Token: 0x04004CA3 RID: 19619
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0;

			// Token: 0x04004CA4 RID: 19620
			private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0;
		}

		// Token: 0x020006E9 RID: 1769
		public class SortedListDebugView : Object
		{
			// Token: 0x06005E02 RID: 24066 RVA: 0x00022560 File Offset: 0x00020760
			// Note: this type is marked as 'beforefieldinit'.
			static SortedListDebugView()
			{
				Il2CppClassPointerStore<SortedList.SortedListDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedList>.NativeClassPtr, "SortedListDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedList.SortedListDebugView>.NativeClassPtr);
			}

			// Token: 0x06005E03 RID: 24067 RVA: 0x00022580 File Offset: 0x00020780
			public SortedListDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
