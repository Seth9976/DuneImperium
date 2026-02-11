using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000128 RID: 296
	public sealed class LocalDataStore : Object
	{
		// Token: 0x060013A7 RID: 5031 RVA: 0x00084E48 File Offset: 0x00083048
		// Note: this type is marked as 'beforefieldinit'.
		static LocalDataStore()
		{
			Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "LocalDataStore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr);
			LocalDataStore.NativeFieldInfoPtr_m_DataTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, "m_DataTable");
			LocalDataStore.NativeFieldInfoPtr_m_Manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, "m_Manager");
			LocalDataStore.NativeMethodInfoPtr__ctor_Public_Void_LocalDataStoreMgr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, 100666784);
			LocalDataStore.NativeMethodInfoPtr_Dispose_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, 100666785);
			LocalDataStore.NativeMethodInfoPtr_GetData_Public_Object_LocalDataStoreSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, 100666786);
			LocalDataStore.NativeMethodInfoPtr_SetData_Public_Void_LocalDataStoreSlot_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, 100666787);
			LocalDataStore.NativeMethodInfoPtr_FreeData_Internal_Void_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, 100666788);
			LocalDataStore.NativeMethodInfoPtr_PopulateElement_Private_LocalDataStoreElement_LocalDataStoreSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr, 100666789);
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00084F18 File Offset: 0x00083118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338070, XrefRangeEnd = 1338076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStore(LocalDataStoreMgr mgr, int InitialCapacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalDataStore>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref InitialCapacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStore.NativeMethodInfoPtr__ctor_Public_Void_LocalDataStoreMgr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00084F74 File Offset: 0x00083174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338076, XrefRangeEnd = 1338078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStore.NativeMethodInfoPtr_Dispose_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00084FA8 File Offset: 0x000831A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1338078, RefRangeEnd = 1338079, XrefRangeStart = 1338078, XrefRangeEnd = 1338078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetData(LocalDataStoreSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStore.NativeMethodInfoPtr_GetData_Public_Object_LocalDataStoreSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x00084FF8 File Offset: 0x000831F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1338097, RefRangeEnd = 1338098, XrefRangeStart = 1338079, XrefRangeEnd = 1338097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(LocalDataStoreSlot slot, Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStore.NativeMethodInfoPtr_SetData_Public_Void_LocalDataStoreSlot_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0008504C File Offset: 0x0008324C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338098, XrefRangeEnd = 1338099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeData(int slot, long cookie)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref slot;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStore.NativeMethodInfoPtr_FreeData_Internal_Void_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00085098 File Offset: 0x00083298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1338114, RefRangeEnd = 1338115, XrefRangeStart = 1338099, XrefRangeEnd = 1338114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreElement PopulateElement(LocalDataStoreSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStore.NativeMethodInfoPtr_PopulateElement_Private_LocalDataStoreElement_LocalDataStoreSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreElement>(intPtr3) : null;
			}
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0000646A File Offset: 0x0000466A
		public LocalDataStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060013AF RID: 5039 RVA: 0x000850E8 File Offset: 0x000832E8
		// (set) Token: 0x060013B0 RID: 5040 RVA: 0x00006473 File Offset: 0x00004673
		public unsafe Il2CppReferenceArray<LocalDataStoreElement> m_DataTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStore.NativeFieldInfoPtr_m_DataTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocalDataStoreElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStore.NativeFieldInfoPtr_m_DataTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060013B1 RID: 5041 RVA: 0x00085118 File Offset: 0x00083318
		// (set) Token: 0x060013B2 RID: 5042 RVA: 0x00006492 File Offset: 0x00004692
		public unsafe LocalDataStoreMgr m_Manager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStore.NativeFieldInfoPtr_m_Manager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataStoreMgr>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStore.NativeFieldInfoPtr_m_Manager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeFieldInfoPtr_m_DataTable;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeFieldInfoPtr_m_Manager;

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LocalDataStoreMgr_Int32_0;

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Internal_Void_0;

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Object_LocalDataStoreSlot_0;

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_LocalDataStoreSlot_Object_0;

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeMethodInfoPtr_FreeData_Internal_Void_Int32_Int64_0;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeMethodInfoPtr_PopulateElement_Private_LocalDataStoreElement_LocalDataStoreSlot_0;
	}
}
