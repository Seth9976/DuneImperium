using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004CE RID: 1230
	[Serializable]
	public class ArrayList : Object
	{
		// Token: 0x06004B76 RID: 19318 RVA: 0x0015C910 File Offset: 0x0015AB10
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayList()
		{
			Il2CppClassPointerStore<ArrayList>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "ArrayList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayList>.NativeClassPtr);
			ArrayList.NativeFieldInfoPtr__items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "_items");
			ArrayList.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "_size");
			ArrayList.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "_version");
			ArrayList.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "_syncRoot");
			ArrayList.NativeFieldInfoPtr__defaultCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "_defaultCapacity");
			ArrayList.NativeFieldInfoPtr_MaxArrayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "MaxArrayLength");
			ArrayList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674380);
			ArrayList.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674381);
			ArrayList.NativeMethodInfoPtr__ctor_Public_Void_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674382);
			ArrayList.NativeMethodInfoPtr_set_Capacity_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674383);
			ArrayList.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674384);
			ArrayList.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674385);
			ArrayList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674386);
			ArrayList.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674387);
			ArrayList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674388);
			ArrayList.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674389);
			ArrayList.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674390);
			ArrayList.NativeMethodInfoPtr_Adapter_Public_Static_ArrayList_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674391);
			ArrayList.NativeMethodInfoPtr_Add_Public_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674392);
			ArrayList.NativeMethodInfoPtr_AddRange_Public_Virtual_New_Void_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674393);
			ArrayList.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674394);
			ArrayList.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674395);
			ArrayList.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674396);
			ArrayList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674397);
			ArrayList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674398);
			ArrayList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Int32_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674399);
			ArrayList.NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674400);
			ArrayList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674401);
			ArrayList.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674402);
			ArrayList.NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674403);
			ArrayList.NativeMethodInfoPtr_InsertRange_Public_Virtual_New_Void_Int32_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674404);
			ArrayList.NativeMethodInfoPtr_ReadOnly_Public_Static_ArrayList_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674405);
			ArrayList.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674406);
			ArrayList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674407);
			ArrayList.NativeMethodInfoPtr_RemoveRange_Public_Virtual_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674408);
			ArrayList.NativeMethodInfoPtr_Sort_Public_Virtual_New_Void_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674409);
			ArrayList.NativeMethodInfoPtr_Sort_Public_Virtual_New_Void_Int32_Int32_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674410);
			ArrayList.NativeMethodInfoPtr_ToArray_Public_Virtual_New_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674411);
			ArrayList.NativeMethodInfoPtr_ToArray_Public_Virtual_New_Array_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100674412);
		}

		// Token: 0x06004B77 RID: 19319 RVA: 0x0015CC4C File Offset: 0x0015AE4C
		[CallerCount(226)]
		[CachedScanResults(RefRangeStart = 1416223, RefRangeEnd = 1416449, XrefRangeStart = 1416218, XrefRangeEnd = 1416223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B78 RID: 19320 RVA: 0x0015CC88 File Offset: 0x0015AE88
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1416467, RefRangeEnd = 1416483, XrefRangeStart = 1416449, XrefRangeEnd = 1416467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B79 RID: 19321 RVA: 0x0015CCD0 File Offset: 0x0015AED0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1416502, RefRangeEnd = 1416511, XrefRangeStart = 1416483, XrefRangeEnd = 1416502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList(ICollection c)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr__ctor_Public_Void_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001364 RID: 4964
		// (set) Token: 0x06004B7A RID: 19322 RVA: 0x0015CD1C File Offset: 0x0015AF1C
		public unsafe virtual int Capacity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416511, XrefRangeEnd = 1416515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_set_Capacity_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x06004B7B RID: 19323 RVA: 0x0015CD68 File Offset: 0x0015AF68
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x06004B7C RID: 19324 RVA: 0x0015CDB0 File Offset: 0x0015AFB0
		public unsafe virtual bool IsFixedSize
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x06004B7D RID: 19325 RVA: 0x0015CDF8 File Offset: 0x0015AFF8
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x06004B7E RID: 19326 RVA: 0x0015CE40 File Offset: 0x0015B040
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x06004B7F RID: 19327 RVA: 0x0015CE88 File Offset: 0x0015B088
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416515, XrefRangeEnd = 1416520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700136A RID: 4970
		public unsafe virtual Object this[int index]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416520, XrefRangeEnd = 1416522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B82 RID: 19330 RVA: 0x0015CF88 File Offset: 0x0015B188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1416526, RefRangeEnd = 1416527, XrefRangeStart = 1416522, XrefRangeEnd = 1416526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArrayList Adapter(IList list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_Adapter_Public_Static_ArrayList_IList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x06004B83 RID: 19331 RVA: 0x0015CFCC File Offset: 0x0015B1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416527, XrefRangeEnd = 1416530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Add(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_Add_Public_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004B84 RID: 19332 RVA: 0x0015D024 File Offset: 0x0015B224
		[CallerCount(0)]
		public unsafe virtual void AddRange(ICollection c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_AddRange_Public_Virtual_New_Void_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B85 RID: 19333 RVA: 0x0015D074 File Offset: 0x0015B274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B86 RID: 19334 RVA: 0x0015D0B0 File Offset: 0x0015B2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416530, XrefRangeEnd = 1416543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004B87 RID: 19335 RVA: 0x0015D0FC File Offset: 0x0015B2FC
		[CallerCount(0)]
		public unsafe virtual bool Contains(Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004B88 RID: 19336 RVA: 0x0015D154 File Offset: 0x0015B354
		[CallerCount(0)]
		public unsafe virtual void CopyTo(Array array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B89 RID: 19337 RVA: 0x0015D1A4 File Offset: 0x0015B3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416543, XrefRangeEnd = 1416545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B8A RID: 19338 RVA: 0x0015D200 File Offset: 0x0015B400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416545, XrefRangeEnd = 1416560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(int index, Array array, int arrayIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Int32_Array_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B8B RID: 19339 RVA: 0x0015D278 File Offset: 0x0015B478
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1416561, RefRangeEnd = 1416563, XrefRangeStart = 1416560, XrefRangeEnd = 1416561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureCapacity(int min)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B8C RID: 19340 RVA: 0x0015D2B8 File Offset: 0x0015B4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416563, XrefRangeEnd = 1416581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004B8D RID: 19341 RVA: 0x0015D304 File Offset: 0x0015B504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416581, XrefRangeEnd = 1416582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int IndexOf(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004B8E RID: 19342 RVA: 0x0015D35C File Offset: 0x0015B55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416582, XrefRangeEnd = 1416586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B8F RID: 19343 RVA: 0x0015D3B8 File Offset: 0x0015B5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416586, XrefRangeEnd = 1416597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InsertRange(int index, ICollection c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_InsertRange_Public_Virtual_New_Void_Int32_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B90 RID: 19344 RVA: 0x0015D414 File Offset: 0x0015B614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1416601, RefRangeEnd = 1416602, XrefRangeStart = 1416597, XrefRangeEnd = 1416601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArrayList ReadOnly(ArrayList list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_ReadOnly_Public_Static_ArrayList_ArrayList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x06004B91 RID: 19345 RVA: 0x0015D458 File Offset: 0x0015B658
		[CallerCount(0)]
		public unsafe virtual void Remove(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B92 RID: 19346 RVA: 0x0015D4A8 File Offset: 0x0015B6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416602, XrefRangeEnd = 1416604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B93 RID: 19347 RVA: 0x0015D4F4 File Offset: 0x0015B6F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416604, XrefRangeEnd = 1416606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveRange(int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_RemoveRange_Public_Virtual_New_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B94 RID: 19348 RVA: 0x0015D54C File Offset: 0x0015B74C
		[CallerCount(0)]
		public unsafe virtual void Sort(IComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_Sort_Public_Virtual_New_Void_IComparer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B95 RID: 19349 RVA: 0x0015D59C File Offset: 0x0015B79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416606, XrefRangeEnd = 1416607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Sort(int index, int count, IComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_Sort_Public_Virtual_New_Void_Int32_Int32_IComparer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B96 RID: 19350 RVA: 0x0015D608 File Offset: 0x0015B808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416607, XrefRangeEnd = 1416612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Object> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_ToArray_Public_Virtual_New_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06004B97 RID: 19351 RVA: 0x0015D654 File Offset: 0x0015B854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416612, XrefRangeEnd = 1416618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Array ToArray(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.NativeMethodInfoPtr_ToArray_Public_Virtual_New_Array_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
			}
		}

		// Token: 0x06004B98 RID: 19352 RVA: 0x0001B981 File Offset: 0x00019B81
		public ArrayList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x06004B99 RID: 19353 RVA: 0x0015D6B0 File Offset: 0x0015B8B0
		// (set) Token: 0x06004B9A RID: 19354 RVA: 0x0001B98A File Offset: 0x00019B8A
		public unsafe Il2CppReferenceArray<Object> _items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.NativeFieldInfoPtr__items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.NativeFieldInfoPtr__items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x06004B9B RID: 19355 RVA: 0x0015D6E0 File Offset: 0x0015B8E0
		// (set) Token: 0x06004B9C RID: 19356 RVA: 0x0001B9A9 File Offset: 0x00019BA9
		public unsafe int _size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.NativeFieldInfoPtr__size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.NativeFieldInfoPtr__size)) = value;
			}
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x06004B9D RID: 19357 RVA: 0x0015D708 File Offset: 0x0015B908
		// (set) Token: 0x06004B9E RID: 19358 RVA: 0x0001B9C4 File Offset: 0x00019BC4
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x06004B9F RID: 19359 RVA: 0x0015D730 File Offset: 0x0015B930
		// (set) Token: 0x06004BA0 RID: 19360 RVA: 0x0001B9DF File Offset: 0x00019BDF
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x06004BA1 RID: 19361 RVA: 0x0015D760 File Offset: 0x0015B960
		// (set) Token: 0x06004BA2 RID: 19362 RVA: 0x0001B9FE File Offset: 0x00019BFE
		public unsafe static int _defaultCapacity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ArrayList.NativeFieldInfoPtr__defaultCapacity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArrayList.NativeFieldInfoPtr__defaultCapacity, (void*)(&value));
			}
		}

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x06004BA3 RID: 19363 RVA: 0x0015D77C File Offset: 0x0015B97C
		// (set) Token: 0x06004BA4 RID: 19364 RVA: 0x0001BA0C File Offset: 0x00019C0C
		public unsafe static int MaxArrayLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ArrayList.NativeFieldInfoPtr_MaxArrayLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArrayList.NativeFieldInfoPtr_MaxArrayLength, (void*)(&value));
			}
		}

		// Token: 0x04003DC3 RID: 15811
		private static readonly IntPtr NativeFieldInfoPtr__items;

		// Token: 0x04003DC4 RID: 15812
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x04003DC5 RID: 15813
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x04003DC6 RID: 15814
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x04003DC7 RID: 15815
		private static readonly IntPtr NativeFieldInfoPtr__defaultCapacity;

		// Token: 0x04003DC8 RID: 15816
		private static readonly IntPtr NativeFieldInfoPtr_MaxArrayLength;

		// Token: 0x04003DC9 RID: 15817
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003DCA RID: 15818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003DCB RID: 15819
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ICollection_0;

		// Token: 0x04003DCC RID: 15820
		private static readonly IntPtr NativeMethodInfoPtr_set_Capacity_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04003DCD RID: 15821
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x04003DCE RID: 15822
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003DCF RID: 15823
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003DD0 RID: 15824
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003DD1 RID: 15825
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0;

		// Token: 0x04003DD2 RID: 15826
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Int32_0;

		// Token: 0x04003DD3 RID: 15827
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_Object_0;

		// Token: 0x04003DD4 RID: 15828
		private static readonly IntPtr NativeMethodInfoPtr_Adapter_Public_Static_ArrayList_IList_0;

		// Token: 0x04003DD5 RID: 15829
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Int32_Object_0;

		// Token: 0x04003DD6 RID: 15830
		private static readonly IntPtr NativeMethodInfoPtr_AddRange_Public_Virtual_New_Void_ICollection_0;

		// Token: 0x04003DD7 RID: 15831
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

		// Token: 0x04003DD8 RID: 15832
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x04003DD9 RID: 15833
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x04003DDA RID: 15834
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_0;

		// Token: 0x04003DDB RID: 15835
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

		// Token: 0x04003DDC RID: 15836
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Int32_Array_Int32_Int32_0;

		// Token: 0x04003DDD RID: 15837
		private static readonly IntPtr NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0;

		// Token: 0x04003DDE RID: 15838
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

		// Token: 0x04003DDF RID: 15839
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_Object_0;

		// Token: 0x04003DE0 RID: 15840
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_Object_0;

		// Token: 0x04003DE1 RID: 15841
		private static readonly IntPtr NativeMethodInfoPtr_InsertRange_Public_Virtual_New_Void_Int32_ICollection_0;

		// Token: 0x04003DE2 RID: 15842
		private static readonly IntPtr NativeMethodInfoPtr_ReadOnly_Public_Static_ArrayList_ArrayList_0;

		// Token: 0x04003DE3 RID: 15843
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0;

		// Token: 0x04003DE4 RID: 15844
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04003DE5 RID: 15845
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRange_Public_Virtual_New_Void_Int32_Int32_0;

		// Token: 0x04003DE6 RID: 15846
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Virtual_New_Void_IComparer_0;

		// Token: 0x04003DE7 RID: 15847
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Virtual_New_Void_Int32_Int32_IComparer_0;

		// Token: 0x04003DE8 RID: 15848
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Virtual_New_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003DE9 RID: 15849
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Virtual_New_Array_Type_0;

		// Token: 0x020006ED RID: 1773
		[Serializable]
		public class IListWrapper : ArrayList
		{
			// Token: 0x06005E24 RID: 24100 RVA: 0x001A96F4 File Offset: 0x001A78F4
			// Note: this type is marked as 'beforefieldinit'.
			static IListWrapper()
			{
				Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "IListWrapper");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr);
				ArrayList.IListWrapper.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, "_list");
				ArrayList.IListWrapper.NativeMethodInfoPtr__ctor_Internal_Void_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674413);
				ArrayList.IListWrapper.NativeMethodInfoPtr_set_Capacity_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674414);
				ArrayList.IListWrapper.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674415);
				ArrayList.IListWrapper.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674416);
				ArrayList.IListWrapper.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674417);
				ArrayList.IListWrapper.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674418);
				ArrayList.IListWrapper.NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674419);
				ArrayList.IListWrapper.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674420);
				ArrayList.IListWrapper.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674421);
				ArrayList.IListWrapper.NativeMethodInfoPtr_Add_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674422);
				ArrayList.IListWrapper.NativeMethodInfoPtr_AddRange_Public_Virtual_Void_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674423);
				ArrayList.IListWrapper.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674424);
				ArrayList.IListWrapper.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674425);
				ArrayList.IListWrapper.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674426);
				ArrayList.IListWrapper.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674427);
				ArrayList.IListWrapper.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Int32_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674428);
				ArrayList.IListWrapper.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674429);
				ArrayList.IListWrapper.NativeMethodInfoPtr_IndexOf_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674430);
				ArrayList.IListWrapper.NativeMethodInfoPtr_Insert_Public_Virtual_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674431);
				ArrayList.IListWrapper.NativeMethodInfoPtr_InsertRange_Public_Virtual_Void_Int32_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674432);
				ArrayList.IListWrapper.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674433);
				ArrayList.IListWrapper.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674434);
				ArrayList.IListWrapper.NativeMethodInfoPtr_RemoveRange_Public_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674435);
				ArrayList.IListWrapper.NativeMethodInfoPtr_Sort_Public_Virtual_Void_Int32_Int32_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674436);
				ArrayList.IListWrapper.NativeMethodInfoPtr_ToArray_Public_Virtual_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674437);
				ArrayList.IListWrapper.NativeMethodInfoPtr_ToArray_Public_Virtual_Array_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr, 100674438);
			}

			// Token: 0x06005E25 RID: 24101 RVA: 0x001A993C File Offset: 0x001A7B3C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1415977, RefRangeEnd = 1415979, XrefRangeStart = 1415971, XrefRangeEnd = 1415977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IListWrapper(IList list)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayList.IListWrapper>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.IListWrapper.NativeMethodInfoPtr__ctor_Internal_Void_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001831 RID: 6193
			// (set) Token: 0x06005E26 RID: 24102 RVA: 0x001A9988 File Offset: 0x001A7B88
			public unsafe override int Capacity
			{
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_set_Capacity_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001832 RID: 6194
			// (get) Token: 0x06005E27 RID: 24103 RVA: 0x001A99D4 File Offset: 0x001A7BD4
			public unsafe override int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415979, XrefRangeEnd = 1415983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001833 RID: 6195
			// (get) Token: 0x06005E28 RID: 24104 RVA: 0x001A9A1C File Offset: 0x001A7C1C
			public unsafe override bool IsReadOnly
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415983, XrefRangeEnd = 1415987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001834 RID: 6196
			// (get) Token: 0x06005E29 RID: 24105 RVA: 0x001A9A64 File Offset: 0x001A7C64
			public unsafe override bool IsFixedSize
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415987, XrefRangeEnd = 1415991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001835 RID: 6197
			// (get) Token: 0x06005E2A RID: 24106 RVA: 0x001A9AAC File Offset: 0x001A7CAC
			public unsafe override bool IsSynchronized
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415991, XrefRangeEnd = 1415995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001836 RID: 6198
			public unsafe override Object this[int index]
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415995, XrefRangeEnd = 1415999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1415999, XrefRangeEnd = 1416002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001837 RID: 6199
			// (get) Token: 0x06005E2D RID: 24109 RVA: 0x001A9BA8 File Offset: 0x001A7DA8
			public unsafe override Object SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416002, XrefRangeEnd = 1416006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005E2E RID: 24110 RVA: 0x001A9BF4 File Offset: 0x001A7DF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416006, XrefRangeEnd = 1416009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Add(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_Add_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005E2F RID: 24111 RVA: 0x001A9C4C File Offset: 0x001A7E4C
			[CallerCount(0)]
			public unsafe override void AddRange(ICollection c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_AddRange_Public_Virtual_Void_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005E30 RID: 24112 RVA: 0x001A9C9C File Offset: 0x001A7E9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416009, XrefRangeEnd = 1416014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E31 RID: 24113 RVA: 0x001A9CD8 File Offset: 0x001A7ED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416014, XrefRangeEnd = 1416018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06005E32 RID: 24114 RVA: 0x001A9D24 File Offset: 0x001A7F24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416018, XrefRangeEnd = 1416023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Contains(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005E33 RID: 24115 RVA: 0x001A9D7C File Offset: 0x001A7F7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416023, XrefRangeEnd = 1416026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E34 RID: 24116 RVA: 0x001A9DD8 File Offset: 0x001A7FD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416026, XrefRangeEnd = 1416035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void CopyTo(int index, Array array, int arrayIndex, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Int32_Array_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E35 RID: 24117 RVA: 0x001A9E50 File Offset: 0x001A8050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416035, XrefRangeEnd = 1416039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005E36 RID: 24118 RVA: 0x001A9E9C File Offset: 0x001A809C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416039, XrefRangeEnd = 1416043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int IndexOf(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_IndexOf_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005E37 RID: 24119 RVA: 0x001A9EF4 File Offset: 0x001A80F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416043, XrefRangeEnd = 1416046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Insert(int index, Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_Insert_Public_Virtual_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E38 RID: 24120 RVA: 0x001A9F50 File Offset: 0x001A8150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416046, XrefRangeEnd = 1416055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void InsertRange(int index, ICollection c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_InsertRange_Public_Virtual_Void_Int32_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E39 RID: 24121 RVA: 0x001A9FAC File Offset: 0x001A81AC
			[CallerCount(0)]
			public unsafe override void Remove(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005E3A RID: 24122 RVA: 0x001A9FFC File Offset: 0x001A81FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416055, XrefRangeEnd = 1416058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void RemoveAt(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005E3B RID: 24123 RVA: 0x001AA048 File Offset: 0x001A8248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416058, XrefRangeEnd = 1416064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void RemoveRange(int index, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_RemoveRange_Public_Virtual_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E3C RID: 24124 RVA: 0x001AA0A0 File Offset: 0x001A82A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416064, XrefRangeEnd = 1416074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Sort(int index, int count, IComparer comparer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_Sort_Public_Virtual_Void_Int32_Int32_IComparer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E3D RID: 24125 RVA: 0x001AA10C File Offset: 0x001A830C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416074, XrefRangeEnd = 1416081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Il2CppReferenceArray<Object> ToArray()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_ToArray_Public_Virtual_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}

			// Token: 0x06005E3E RID: 24126 RVA: 0x001AA158 File Offset: 0x001A8358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416081, XrefRangeEnd = 1416091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Array ToArray(Type type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.IListWrapper.NativeMethodInfoPtr_ToArray_Public_Virtual_Array_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
				}
			}

			// Token: 0x06005E3F RID: 24127 RVA: 0x000226A8 File Offset: 0x000208A8
			public IListWrapper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001830 RID: 6192
			// (get) Token: 0x06005E40 RID: 24128 RVA: 0x001AA1B4 File Offset: 0x001A83B4
			// (set) Token: 0x06005E41 RID: 24129 RVA: 0x000226B1 File Offset: 0x000208B1
			public unsafe IList _list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.IListWrapper.NativeFieldInfoPtr__list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.IListWrapper.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004CB7 RID: 19639
			private static readonly IntPtr NativeFieldInfoPtr__list;

			// Token: 0x04004CB8 RID: 19640
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IList_0;

			// Token: 0x04004CB9 RID: 19641
			private static readonly IntPtr NativeMethodInfoPtr_set_Capacity_Public_Virtual_set_Void_Int32_0;

			// Token: 0x04004CBA RID: 19642
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;

			// Token: 0x04004CBB RID: 19643
			private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;

			// Token: 0x04004CBC RID: 19644
			private static readonly IntPtr NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_get_Boolean_0;

			// Token: 0x04004CBD RID: 19645
			private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0;

			// Token: 0x04004CBE RID: 19646
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Int32_0;

			// Token: 0x04004CBF RID: 19647
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Int32_Object_0;

			// Token: 0x04004CC0 RID: 19648
			private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0;

			// Token: 0x04004CC1 RID: 19649
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Int32_Object_0;

			// Token: 0x04004CC2 RID: 19650
			private static readonly IntPtr NativeMethodInfoPtr_AddRange_Public_Virtual_Void_ICollection_0;

			// Token: 0x04004CC3 RID: 19651
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Void_0;

			// Token: 0x04004CC4 RID: 19652
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

			// Token: 0x04004CC5 RID: 19653
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0;

			// Token: 0x04004CC6 RID: 19654
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0;

			// Token: 0x04004CC7 RID: 19655
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Int32_Array_Int32_Int32_0;

			// Token: 0x04004CC8 RID: 19656
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0;

			// Token: 0x04004CC9 RID: 19657
			private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_Int32_Object_0;

			// Token: 0x04004CCA RID: 19658
			private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_Void_Int32_Object_0;

			// Token: 0x04004CCB RID: 19659
			private static readonly IntPtr NativeMethodInfoPtr_InsertRange_Public_Virtual_Void_Int32_ICollection_0;

			// Token: 0x04004CCC RID: 19660
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0;

			// Token: 0x04004CCD RID: 19661
			private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_Void_Int32_0;

			// Token: 0x04004CCE RID: 19662
			private static readonly IntPtr NativeMethodInfoPtr_RemoveRange_Public_Virtual_Void_Int32_Int32_0;

			// Token: 0x04004CCF RID: 19663
			private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Virtual_Void_Int32_Int32_IComparer_0;

			// Token: 0x04004CD0 RID: 19664
			private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Virtual_Il2CppReferenceArray_1_Object_0;

			// Token: 0x04004CD1 RID: 19665
			private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Virtual_Array_Type_0;
		}

		// Token: 0x020006EE RID: 1774
		[Serializable]
		public class ReadOnlyArrayList : ArrayList
		{
			// Token: 0x06005E42 RID: 24130 RVA: 0x001AA1E4 File Offset: 0x001A83E4
			// Note: this type is marked as 'beforefieldinit'.
			static ReadOnlyArrayList()
			{
				Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "ReadOnlyArrayList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr);
				ArrayList.ReadOnlyArrayList.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, "_list");
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr__ctor_Internal_Void_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674439);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674440);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674441);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674442);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674443);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674444);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674445);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674446);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Add_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674447);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_AddRange_Public_Virtual_Void_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674448);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_set_Capacity_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674449);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674450);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674451);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674452);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674453);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Int32_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674454);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674455);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_IndexOf_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674456);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Insert_Public_Virtual_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674457);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_InsertRange_Public_Virtual_Void_Int32_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674458);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674459);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674460);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_RemoveRange_Public_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674461);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Sort_Public_Virtual_Void_Int32_Int32_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674462);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_ToArray_Public_Virtual_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674463);
				ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_ToArray_Public_Virtual_Array_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr, 100674464);
			}

			// Token: 0x06005E43 RID: 24131 RVA: 0x001AA42C File Offset: 0x001A862C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1416097, RefRangeEnd = 1416098, XrefRangeStart = 1416091, XrefRangeEnd = 1416097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnlyArrayList(ArrayList l)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayList.ReadOnlyArrayList>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr__ctor_Internal_Void_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001839 RID: 6201
			// (get) Token: 0x06005E44 RID: 24132 RVA: 0x001AA478 File Offset: 0x001A8678
			public unsafe override int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416098, XrefRangeEnd = 1416099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700183A RID: 6202
			// (get) Token: 0x06005E45 RID: 24133 RVA: 0x001AA4C0 File Offset: 0x001A86C0
			public unsafe override bool IsReadOnly
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700183B RID: 6203
			// (get) Token: 0x06005E46 RID: 24134 RVA: 0x001AA508 File Offset: 0x001A8708
			public unsafe override bool IsFixedSize
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700183C RID: 6204
			// (get) Token: 0x06005E47 RID: 24135 RVA: 0x001AA550 File Offset: 0x001A8750
			public unsafe override bool IsSynchronized
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416099, XrefRangeEnd = 1416100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700183D RID: 6205
			public unsafe override Object this[int index]
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416100, XrefRangeEnd = 1416101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416101, XrefRangeEnd = 1416107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700183E RID: 6206
			// (get) Token: 0x06005E4A RID: 24138 RVA: 0x001AA64C File Offset: 0x001A884C
			public unsafe override Object SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416107, XrefRangeEnd = 1416108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005E4B RID: 24139 RVA: 0x001AA698 File Offset: 0x001A8898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416108, XrefRangeEnd = 1416114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Add(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Add_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005E4C RID: 24140 RVA: 0x001AA6F0 File Offset: 0x001A88F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416114, XrefRangeEnd = 1416120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void AddRange(ICollection c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_AddRange_Public_Virtual_Void_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700183F RID: 6207
			// (set) Token: 0x06005E4D RID: 24141 RVA: 0x001AA740 File Offset: 0x001A8940
			public unsafe override int Capacity
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416120, XrefRangeEnd = 1416126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_set_Capacity_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06005E4E RID: 24142 RVA: 0x001AA78C File Offset: 0x001A898C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416126, XrefRangeEnd = 1416132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E4F RID: 24143 RVA: 0x001AA7C8 File Offset: 0x001A89C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416132, XrefRangeEnd = 1416146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06005E50 RID: 24144 RVA: 0x001AA814 File Offset: 0x001A8A14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416146, XrefRangeEnd = 1416147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Contains(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005E51 RID: 24145 RVA: 0x001AA86C File Offset: 0x001A8A6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416147, XrefRangeEnd = 1416148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E52 RID: 24146 RVA: 0x001AA8C8 File Offset: 0x001A8AC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416148, XrefRangeEnd = 1416149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void CopyTo(int index, Array array, int arrayIndex, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Int32_Array_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E53 RID: 24147 RVA: 0x001AA940 File Offset: 0x001A8B40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005E54 RID: 24148 RVA: 0x001AA98C File Offset: 0x001A8B8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416149, XrefRangeEnd = 1416150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int IndexOf(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_IndexOf_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005E55 RID: 24149 RVA: 0x001AA9E4 File Offset: 0x001A8BE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416150, XrefRangeEnd = 1416156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Insert(int index, Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Insert_Public_Virtual_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E56 RID: 24150 RVA: 0x001AAA40 File Offset: 0x001A8C40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416156, XrefRangeEnd = 1416162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void InsertRange(int index, ICollection c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_InsertRange_Public_Virtual_Void_Int32_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E57 RID: 24151 RVA: 0x001AAA9C File Offset: 0x001A8C9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416162, XrefRangeEnd = 1416168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Remove(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005E58 RID: 24152 RVA: 0x001AAAEC File Offset: 0x001A8CEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416168, XrefRangeEnd = 1416174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void RemoveAt(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005E59 RID: 24153 RVA: 0x001AAB38 File Offset: 0x001A8D38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416174, XrefRangeEnd = 1416180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void RemoveRange(int index, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_RemoveRange_Public_Virtual_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E5A RID: 24154 RVA: 0x001AAB90 File Offset: 0x001A8D90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416180, XrefRangeEnd = 1416186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Sort(int index, int count, IComparer comparer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_Sort_Public_Virtual_Void_Int32_Int32_IComparer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E5B RID: 24155 RVA: 0x001AABFC File Offset: 0x001A8DFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416186, XrefRangeEnd = 1416187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Il2CppReferenceArray<Object> ToArray()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_ToArray_Public_Virtual_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}

			// Token: 0x06005E5C RID: 24156 RVA: 0x001AAC48 File Offset: 0x001A8E48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416187, XrefRangeEnd = 1416188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Array ToArray(Type type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArrayList.ReadOnlyArrayList.NativeMethodInfoPtr_ToArray_Public_Virtual_Array_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
				}
			}

			// Token: 0x06005E5D RID: 24157 RVA: 0x000226D0 File Offset: 0x000208D0
			public ReadOnlyArrayList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001838 RID: 6200
			// (get) Token: 0x06005E5E RID: 24158 RVA: 0x001AACA4 File Offset: 0x001A8EA4
			// (set) Token: 0x06005E5F RID: 24159 RVA: 0x000226D9 File Offset: 0x000208D9
			public unsafe ArrayList _list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ReadOnlyArrayList.NativeFieldInfoPtr__list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ReadOnlyArrayList.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004CD2 RID: 19666
			private static readonly IntPtr NativeFieldInfoPtr__list;

			// Token: 0x04004CD3 RID: 19667
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ArrayList_0;

			// Token: 0x04004CD4 RID: 19668
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;

			// Token: 0x04004CD5 RID: 19669
			private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;

			// Token: 0x04004CD6 RID: 19670
			private static readonly IntPtr NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_get_Boolean_0;

			// Token: 0x04004CD7 RID: 19671
			private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0;

			// Token: 0x04004CD8 RID: 19672
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Int32_0;

			// Token: 0x04004CD9 RID: 19673
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Int32_Object_0;

			// Token: 0x04004CDA RID: 19674
			private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0;

			// Token: 0x04004CDB RID: 19675
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Int32_Object_0;

			// Token: 0x04004CDC RID: 19676
			private static readonly IntPtr NativeMethodInfoPtr_AddRange_Public_Virtual_Void_ICollection_0;

			// Token: 0x04004CDD RID: 19677
			private static readonly IntPtr NativeMethodInfoPtr_set_Capacity_Public_Virtual_set_Void_Int32_0;

			// Token: 0x04004CDE RID: 19678
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Void_0;

			// Token: 0x04004CDF RID: 19679
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

			// Token: 0x04004CE0 RID: 19680
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0;

			// Token: 0x04004CE1 RID: 19681
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0;

			// Token: 0x04004CE2 RID: 19682
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Int32_Array_Int32_Int32_0;

			// Token: 0x04004CE3 RID: 19683
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0;

			// Token: 0x04004CE4 RID: 19684
			private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_Int32_Object_0;

			// Token: 0x04004CE5 RID: 19685
			private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_Void_Int32_Object_0;

			// Token: 0x04004CE6 RID: 19686
			private static readonly IntPtr NativeMethodInfoPtr_InsertRange_Public_Virtual_Void_Int32_ICollection_0;

			// Token: 0x04004CE7 RID: 19687
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0;

			// Token: 0x04004CE8 RID: 19688
			private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_Void_Int32_0;

			// Token: 0x04004CE9 RID: 19689
			private static readonly IntPtr NativeMethodInfoPtr_RemoveRange_Public_Virtual_Void_Int32_Int32_0;

			// Token: 0x04004CEA RID: 19690
			private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Virtual_Void_Int32_Int32_IComparer_0;

			// Token: 0x04004CEB RID: 19691
			private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Virtual_Il2CppReferenceArray_1_Object_0;

			// Token: 0x04004CEC RID: 19692
			private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Virtual_Array_Type_0;
		}

		// Token: 0x020006EF RID: 1775
		[Serializable]
		public sealed class ArrayListEnumeratorSimple : Object
		{
			// Token: 0x06005E60 RID: 24160 RVA: 0x001AACD4 File Offset: 0x001A8ED4
			// Note: this type is marked as 'beforefieldinit'.
			static ArrayListEnumeratorSimple()
			{
				Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "ArrayListEnumeratorSimple");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr);
				ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, "_list");
				ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, "_index");
				ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, "_version");
				ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr__currentElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, "_currentElement");
				ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr__isArrayList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, "_isArrayList");
				ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr_s_dummyObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, "s_dummyObject");
				ArrayList.ArrayListEnumeratorSimple.NativeMethodInfoPtr__ctor_Internal_Void_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, 100674465);
				ArrayList.ArrayListEnumeratorSimple.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, 100674466);
				ArrayList.ArrayListEnumeratorSimple.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, 100674467);
				ArrayList.ArrayListEnumeratorSimple.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, 100674468);
				ArrayList.ArrayListEnumeratorSimple.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr, 100674469);
			}

			// Token: 0x06005E61 RID: 24161 RVA: 0x001AADDC File Offset: 0x001A8FDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416188, XrefRangeEnd = 1416204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArrayListEnumeratorSimple(ArrayList list)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayList.ArrayListEnumeratorSimple>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.ArrayListEnumeratorSimple.NativeMethodInfoPtr__ctor_Internal_Void_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005E62 RID: 24162 RVA: 0x001AAE28 File Offset: 0x001A9028
			[CallerCount(105)]
			[CachedScanResults(RefRangeStart = 1172447, RefRangeEnd = 1172552, XrefRangeStart = 1172447, XrefRangeEnd = 1172552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.ArrayListEnumeratorSimple.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06005E63 RID: 24163 RVA: 0x001AAE68 File Offset: 0x001A9068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416204, XrefRangeEnd = 1416209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.ArrayListEnumeratorSimple.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001846 RID: 6214
			// (get) Token: 0x06005E64 RID: 24164 RVA: 0x001AAEA4 File Offset: 0x001A90A4
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416209, XrefRangeEnd = 1416213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.ArrayListEnumeratorSimple.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005E65 RID: 24165 RVA: 0x001AAEE4 File Offset: 0x001A90E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416213, XrefRangeEnd = 1416218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.ArrayListEnumeratorSimple.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E66 RID: 24166 RVA: 0x000226F8 File Offset: 0x000208F8
			public ArrayListEnumeratorSimple(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001840 RID: 6208
			// (get) Token: 0x06005E67 RID: 24167 RVA: 0x001AAF18 File Offset: 0x001A9118
			// (set) Token: 0x06005E68 RID: 24168 RVA: 0x00022701 File Offset: 0x00020901
			public unsafe ArrayList _list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr__list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001841 RID: 6209
			// (get) Token: 0x06005E69 RID: 24169 RVA: 0x001AAF48 File Offset: 0x001A9148
			// (set) Token: 0x06005E6A RID: 24170 RVA: 0x00022720 File Offset: 0x00020920
			public unsafe int _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr__index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr__index)) = value;
				}
			}

			// Token: 0x17001842 RID: 6210
			// (get) Token: 0x06005E6B RID: 24171 RVA: 0x001AAF70 File Offset: 0x001A9170
			// (set) Token: 0x06005E6C RID: 24172 RVA: 0x0002273B File Offset: 0x0002093B
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x17001843 RID: 6211
			// (get) Token: 0x06005E6D RID: 24173 RVA: 0x001AAF98 File Offset: 0x001A9198
			// (set) Token: 0x06005E6E RID: 24174 RVA: 0x00022756 File Offset: 0x00020956
			public unsafe Object _currentElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr__currentElement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr__currentElement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001844 RID: 6212
			// (get) Token: 0x06005E6F RID: 24175 RVA: 0x001AAFC8 File Offset: 0x001A91C8
			// (set) Token: 0x06005E70 RID: 24176 RVA: 0x00022775 File Offset: 0x00020975
			public unsafe bool _isArrayList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr__isArrayList);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr__isArrayList)) = value;
				}
			}

			// Token: 0x17001845 RID: 6213
			// (get) Token: 0x06005E71 RID: 24177 RVA: 0x001AAFF0 File Offset: 0x001A91F0
			// (set) Token: 0x06005E72 RID: 24178 RVA: 0x00022790 File Offset: 0x00020990
			public unsafe static Object s_dummyObject
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr_s_dummyObject, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ArrayList.ArrayListEnumeratorSimple.NativeFieldInfoPtr_s_dummyObject, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004CED RID: 19693
			private static readonly IntPtr NativeFieldInfoPtr__list;

			// Token: 0x04004CEE RID: 19694
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x04004CEF RID: 19695
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x04004CF0 RID: 19696
			private static readonly IntPtr NativeFieldInfoPtr__currentElement;

			// Token: 0x04004CF1 RID: 19697
			private static readonly IntPtr NativeFieldInfoPtr__isArrayList;

			// Token: 0x04004CF2 RID: 19698
			private static readonly IntPtr NativeFieldInfoPtr_s_dummyObject;

			// Token: 0x04004CF3 RID: 19699
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ArrayList_0;

			// Token: 0x04004CF4 RID: 19700
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

			// Token: 0x04004CF5 RID: 19701
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004CF6 RID: 19702
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004CF7 RID: 19703
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x020006F0 RID: 1776
		public class ArrayListDebugView : Object
		{
			// Token: 0x06005E73 RID: 24179 RVA: 0x000227A2 File Offset: 0x000209A2
			// Note: this type is marked as 'beforefieldinit'.
			static ArrayListDebugView()
			{
				Il2CppClassPointerStore<ArrayList.ArrayListDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "ArrayListDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayList.ArrayListDebugView>.NativeClassPtr);
			}

			// Token: 0x06005E74 RID: 24180 RVA: 0x000227C2 File Offset: 0x000209C2
			public ArrayListDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
