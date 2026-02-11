using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.data
{
	// Token: 0x02000187 RID: 391
	public class OfflineMatchSlotNameData : NameLookup
	{
		// Token: 0x06001115 RID: 4373 RVA: 0x00053848 File Offset: 0x00051A48
		// Note: this type is marked as 'beforefieldinit'.
		static OfflineMatchSlotNameData()
		{
			Il2CppClassPointerStore<OfflineMatchSlotNameData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "OfflineMatchSlotNameData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfflineMatchSlotNameData>.NativeClassPtr);
			OfflineMatchSlotNameData.NativeFieldInfoPtr_lockData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMatchSlotNameData>.NativeClassPtr, "lockData");
			OfflineMatchSlotNameData.NativeFieldInfoPtr_typeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMatchSlotNameData>.NativeClassPtr, "typeData");
			OfflineMatchSlotNameData.NativeFieldInfoPtr_humanName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMatchSlotNameData>.NativeClassPtr, "humanName");
			OfflineMatchSlotNameData.NativeMethodInfoPtr_get_HumanName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatchSlotNameData>.NativeClassPtr, 100665678);
			OfflineMatchSlotNameData.NativeMethodInfoPtr_set_HumanName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatchSlotNameData>.NativeClassPtr, 100665679);
			OfflineMatchSlotNameData.NativeMethodInfoPtr__ctor_Public_Void_String_PlayerSlotLockData_PlayerTypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatchSlotNameData>.NativeClassPtr, 100665680);
			OfflineMatchSlotNameData.NativeMethodInfoPtr_name_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatchSlotNameData>.NativeClassPtr, 100665681);
			OfflineMatchSlotNameData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatchSlotNameData>.NativeClassPtr, 100665682);
			OfflineMatchSlotNameData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatchSlotNameData>.NativeClassPtr, 100665683);
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x0005392C File Offset: 0x00051B2C
		// (set) Token: 0x06001117 RID: 4375 RVA: 0x00053964 File Offset: 0x00051B64
		public unsafe string HumanName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMatchSlotNameData.NativeMethodInfoPtr_get_HumanName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 514415, RefRangeEnd = 514417, XrefRangeStart = 514413, XrefRangeEnd = 514415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMatchSlotNameData.NativeMethodInfoPtr_set_HumanName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x000539A8 File Offset: 0x00051BA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 514421, RefRangeEnd = 514422, XrefRangeStart = 514417, XrefRangeEnd = 514421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OfflineMatchSlotNameData(string humanName, PlayerSlotLockData lockData, PlayerTypeData typeData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfflineMatchSlotNameData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(humanName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMatchSlotNameData.NativeMethodInfoPtr__ctor_Public_Void_String_PlayerSlotLockData_PlayerTypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00053A18 File Offset: 0x00051C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514422, XrefRangeEnd = 514424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string name()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineMatchSlotNameData.NativeMethodInfoPtr_name_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x00053A5C File Offset: 0x00051C5C
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineMatchSlotNameData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00053AA4 File Offset: 0x00051CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514424, XrefRangeEnd = 514444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineMatchSlotNameData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0000A3A5 File Offset: 0x000085A5
		public OfflineMatchSlotNameData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x0600111D RID: 4381 RVA: 0x00053AE8 File Offset: 0x00051CE8
		// (set) Token: 0x0600111E RID: 4382 RVA: 0x0000A3AE File Offset: 0x000085AE
		public unsafe PlayerSlotLockData lockData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMatchSlotNameData.NativeFieldInfoPtr_lockData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerSlotLockData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMatchSlotNameData.NativeFieldInfoPtr_lockData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600111F RID: 4383 RVA: 0x00053B18 File Offset: 0x00051D18
		// (set) Token: 0x06001120 RID: 4384 RVA: 0x0000A3CD File Offset: 0x000085CD
		public unsafe PlayerTypeData typeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMatchSlotNameData.NativeFieldInfoPtr_typeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerTypeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMatchSlotNameData.NativeFieldInfoPtr_typeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001121 RID: 4385 RVA: 0x00053B48 File Offset: 0x00051D48
		// (set) Token: 0x06001122 RID: 4386 RVA: 0x0000A3EC File Offset: 0x000085EC
		public unsafe string humanName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMatchSlotNameData.NativeFieldInfoPtr_humanName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMatchSlotNameData.NativeFieldInfoPtr_humanName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeFieldInfoPtr_lockData;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeFieldInfoPtr_typeData;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeFieldInfoPtr_humanName;

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeMethodInfoPtr_get_HumanName_Public_get_String_0;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeMethodInfoPtr_set_HumanName_Public_set_Void_String_0;

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_PlayerSlotLockData_PlayerTypeData_0;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeMethodInfoPtr_name_Protected_Virtual_String_0;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
