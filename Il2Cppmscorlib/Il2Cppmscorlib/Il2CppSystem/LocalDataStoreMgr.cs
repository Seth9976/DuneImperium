using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem
{
	// Token: 0x0200012A RID: 298
	public sealed class LocalDataStoreMgr : Object
	{
		// Token: 0x060013C1 RID: 5057 RVA: 0x0008543C File Offset: 0x0008363C
		// Note: this type is marked as 'beforefieldinit'.
		static LocalDataStoreMgr()
		{
			Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "LocalDataStoreMgr");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr);
			LocalDataStoreMgr.NativeFieldInfoPtr_InitialSlotTableSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "InitialSlotTableSize");
			LocalDataStoreMgr.NativeFieldInfoPtr_SlotTableDoubleThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "SlotTableDoubleThreshold");
			LocalDataStoreMgr.NativeFieldInfoPtr_LargeSlotTableSizeIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "LargeSlotTableSizeIncrease");
			LocalDataStoreMgr.NativeFieldInfoPtr_m_SlotInfoTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "m_SlotInfoTable");
			LocalDataStoreMgr.NativeFieldInfoPtr_m_FirstAvailableSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "m_FirstAvailableSlot");
			LocalDataStoreMgr.NativeFieldInfoPtr_m_ManagedLocalDataStores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "m_ManagedLocalDataStores");
			LocalDataStoreMgr.NativeFieldInfoPtr_m_KeyToSlotMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "m_KeyToSlotMap");
			LocalDataStoreMgr.NativeFieldInfoPtr_m_CookieGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, "m_CookieGenerator");
			LocalDataStoreMgr.NativeMethodInfoPtr_CreateLocalDataStore_Public_LocalDataStoreHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100666796);
			LocalDataStoreMgr.NativeMethodInfoPtr_DeleteLocalDataStore_Public_Void_LocalDataStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100666797);
			LocalDataStoreMgr.NativeMethodInfoPtr_AllocateDataSlot_Public_LocalDataStoreSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100666798);
			LocalDataStoreMgr.NativeMethodInfoPtr_AllocateNamedDataSlot_Public_LocalDataStoreSlot_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100666799);
			LocalDataStoreMgr.NativeMethodInfoPtr_GetNamedDataSlot_Public_LocalDataStoreSlot_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100666800);
			LocalDataStoreMgr.NativeMethodInfoPtr_FreeNamedDataSlot_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100666801);
			LocalDataStoreMgr.NativeMethodInfoPtr_FreeDataSlot_Internal_Void_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100666802);
			LocalDataStoreMgr.NativeMethodInfoPtr_ValidateSlot_Public_Void_LocalDataStoreSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100666803);
			LocalDataStoreMgr.NativeMethodInfoPtr_GetSlotTableLength_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100666804);
			LocalDataStoreMgr.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr, 100666805);
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x000855D4 File Offset: 0x000837D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1338150, RefRangeEnd = 1338151, XrefRangeStart = 1338126, XrefRangeEnd = 1338150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreHolder CreateLocalDataStore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_CreateLocalDataStore_Public_LocalDataStoreHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreHolder>(intPtr3) : null;
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x00085614 File Offset: 0x00083814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1338159, RefRangeEnd = 1338161, XrefRangeStart = 1338151, XrefRangeEnd = 1338159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteLocalDataStore(LocalDataStore store)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_DeleteLocalDataStore_Public_Void_LocalDataStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x00085658 File Offset: 0x00083858
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1338178, RefRangeEnd = 1338180, XrefRangeStart = 1338161, XrefRangeEnd = 1338178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreSlot AllocateDataSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_AllocateDataSlot_Public_LocalDataStoreSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreSlot>(intPtr3) : null;
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x00085698 File Offset: 0x00083898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1338189, RefRangeEnd = 1338191, XrefRangeStart = 1338180, XrefRangeEnd = 1338189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreSlot AllocateNamedDataSlot(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_AllocateNamedDataSlot_Public_LocalDataStoreSlot_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreSlot>(intPtr3) : null;
			}
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x000856E8 File Offset: 0x000838E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1338202, RefRangeEnd = 1338203, XrefRangeStart = 1338191, XrefRangeEnd = 1338202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreSlot GetNamedDataSlot(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_GetNamedDataSlot_Public_LocalDataStoreSlot_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreSlot>(intPtr3) : null;
			}
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00085738 File Offset: 0x00083938
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1338211, RefRangeEnd = 1338212, XrefRangeStart = 1338203, XrefRangeEnd = 1338211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeNamedDataSlot(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_FreeNamedDataSlot_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0008577C File Offset: 0x0008397C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1338223, RefRangeEnd = 1338224, XrefRangeStart = 1338212, XrefRangeEnd = 1338223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeDataSlot(int slot, long cookie)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_FreeDataSlot_Internal_Void_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x000857C8 File Offset: 0x000839C8
		[CallerCount(0)]
		public unsafe void ValidateSlot(LocalDataStoreSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_ValidateSlot_Public_Void_LocalDataStoreSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x0008580C File Offset: 0x00083A0C
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 320461, RefRangeEnd = 320500, XrefRangeStart = 320461, XrefRangeEnd = 320500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSlotTableLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr_GetSlotTableLength_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00085848 File Offset: 0x00083A48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1338243, RefRangeEnd = 1338244, XrefRangeStart = 1338224, XrefRangeEnd = 1338243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreMgr()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalDataStoreMgr>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreMgr.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0000650F File Offset: 0x0000470F
		public LocalDataStoreMgr(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x00085884 File Offset: 0x00083A84
		// (set) Token: 0x060013CE RID: 5070 RVA: 0x00006518 File Offset: 0x00004718
		public unsafe static int InitialSlotTableSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LocalDataStoreMgr.NativeFieldInfoPtr_InitialSlotTableSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalDataStoreMgr.NativeFieldInfoPtr_InitialSlotTableSize, (void*)(&value));
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x000858A0 File Offset: 0x00083AA0
		// (set) Token: 0x060013D0 RID: 5072 RVA: 0x00006526 File Offset: 0x00004726
		public unsafe static int SlotTableDoubleThreshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LocalDataStoreMgr.NativeFieldInfoPtr_SlotTableDoubleThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalDataStoreMgr.NativeFieldInfoPtr_SlotTableDoubleThreshold, (void*)(&value));
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x000858BC File Offset: 0x00083ABC
		// (set) Token: 0x060013D2 RID: 5074 RVA: 0x00006534 File Offset: 0x00004734
		public unsafe static int LargeSlotTableSizeIncrease
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LocalDataStoreMgr.NativeFieldInfoPtr_LargeSlotTableSizeIncrease, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalDataStoreMgr.NativeFieldInfoPtr_LargeSlotTableSizeIncrease, (void*)(&value));
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x000858D8 File Offset: 0x00083AD8
		// (set) Token: 0x060013D4 RID: 5076 RVA: 0x00006542 File Offset: 0x00004742
		public unsafe Il2CppStructArray<bool> m_SlotInfoTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_SlotInfoTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_SlotInfoTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x00085908 File Offset: 0x00083B08
		// (set) Token: 0x060013D6 RID: 5078 RVA: 0x00006561 File Offset: 0x00004761
		public unsafe int m_FirstAvailableSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_FirstAvailableSlot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_FirstAvailableSlot)) = value;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x00085930 File Offset: 0x00083B30
		// (set) Token: 0x060013D8 RID: 5080 RVA: 0x0000657C File Offset: 0x0000477C
		public unsafe List<LocalDataStore> m_ManagedLocalDataStores
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_ManagedLocalDataStores);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LocalDataStore>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_ManagedLocalDataStores), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x00085960 File Offset: 0x00083B60
		// (set) Token: 0x060013DA RID: 5082 RVA: 0x0000659B File Offset: 0x0000479B
		public unsafe Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_KeyToSlotMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, LocalDataStoreSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_KeyToSlotMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x00085990 File Offset: 0x00083B90
		// (set) Token: 0x060013DC RID: 5084 RVA: 0x000065BA File Offset: 0x000047BA
		public unsafe long m_CookieGenerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_CookieGenerator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreMgr.NativeFieldInfoPtr_m_CookieGenerator)) = value;
			}
		}

		// Token: 0x040010CA RID: 4298
		private static readonly IntPtr NativeFieldInfoPtr_InitialSlotTableSize;

		// Token: 0x040010CB RID: 4299
		private static readonly IntPtr NativeFieldInfoPtr_SlotTableDoubleThreshold;

		// Token: 0x040010CC RID: 4300
		private static readonly IntPtr NativeFieldInfoPtr_LargeSlotTableSizeIncrease;

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeFieldInfoPtr_m_SlotInfoTable;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstAvailableSlot;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeFieldInfoPtr_m_ManagedLocalDataStores;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeFieldInfoPtr_m_KeyToSlotMap;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeFieldInfoPtr_m_CookieGenerator;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeMethodInfoPtr_CreateLocalDataStore_Public_LocalDataStoreHolder_0;

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeMethodInfoPtr_DeleteLocalDataStore_Public_Void_LocalDataStore_0;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeMethodInfoPtr_AllocateDataSlot_Public_LocalDataStoreSlot_0;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeMethodInfoPtr_AllocateNamedDataSlot_Public_LocalDataStoreSlot_String_0;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeMethodInfoPtr_GetNamedDataSlot_Public_LocalDataStoreSlot_String_0;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeMethodInfoPtr_FreeNamedDataSlot_Public_Void_String_0;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeMethodInfoPtr_FreeDataSlot_Internal_Void_Int32_Int64_0;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeMethodInfoPtr_ValidateSlot_Public_Void_LocalDataStoreSlot_0;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeMethodInfoPtr_GetSlotTableLength_Internal_Int32_0;

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
