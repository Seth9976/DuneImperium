using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.data
{
	// Token: 0x0200018B RID: 395
	public class PlayerJoinSlotNameData : NameLookup
	{
		// Token: 0x0600117C RID: 4476 RVA: 0x0005513C File Offset: 0x0005333C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerJoinSlotNameData()
		{
			Il2CppClassPointerStore<PlayerJoinSlotNameData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "PlayerJoinSlotNameData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerJoinSlotNameData>.NativeClassPtr);
			PlayerJoinSlotNameData.NativeFieldInfoPtr_lockData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerJoinSlotNameData>.NativeClassPtr, "lockData");
			PlayerJoinSlotNameData.NativeFieldInfoPtr_typeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerJoinSlotNameData>.NativeClassPtr, "typeData");
			PlayerJoinSlotNameData.NativeMethodInfoPtr__ctor_Public_Void_PlayerSlotLockData_PlayerTypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerJoinSlotNameData>.NativeClassPtr, 100665752);
			PlayerJoinSlotNameData.NativeMethodInfoPtr_name_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerJoinSlotNameData>.NativeClassPtr, 100665753);
			PlayerJoinSlotNameData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerJoinSlotNameData>.NativeClassPtr, 100665754);
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x000551D0 File Offset: 0x000533D0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 514302, RefRangeEnd = 514309, XrefRangeStart = 514302, XrefRangeEnd = 514309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerJoinSlotNameData(PlayerSlotLockData lockData, PlayerTypeData typeData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerJoinSlotNameData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lockData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerJoinSlotNameData.NativeMethodInfoPtr__ctor_Public_Void_PlayerSlotLockData_PlayerTypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x00055230 File Offset: 0x00053430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515098, XrefRangeEnd = 515108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string name()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerJoinSlotNameData.NativeMethodInfoPtr_name_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x00055274 File Offset: 0x00053474
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerJoinSlotNameData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x0000A61D File Offset: 0x0000881D
		public PlayerJoinSlotNameData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x000552BC File Offset: 0x000534BC
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x0000A626 File Offset: 0x00008826
		public unsafe PlayerSlotLockData lockData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerJoinSlotNameData.NativeFieldInfoPtr_lockData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerSlotLockData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerJoinSlotNameData.NativeFieldInfoPtr_lockData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x000552EC File Offset: 0x000534EC
		// (set) Token: 0x06001184 RID: 4484 RVA: 0x0000A645 File Offset: 0x00008845
		public unsafe PlayerTypeData typeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerJoinSlotNameData.NativeFieldInfoPtr_typeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerTypeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerJoinSlotNameData.NativeFieldInfoPtr_typeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeFieldInfoPtr_lockData;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeFieldInfoPtr_typeData;

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlayerSlotLockData_PlayerTypeData_0;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeMethodInfoPtr_name_Protected_Virtual_String_0;

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;
	}
}
