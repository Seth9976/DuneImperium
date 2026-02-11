using System;
using Canis.utils.ids;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.data
{
	// Token: 0x0200018A RID: 394
	public class PendingGamePlayerAccountData : VersionedDataComponent
	{
		// Token: 0x06001170 RID: 4464 RVA: 0x00054E70 File Offset: 0x00053070
		// Note: this type is marked as 'beforefieldinit'.
		static PendingGamePlayerAccountData()
		{
			Il2CppClassPointerStore<PendingGamePlayerAccountData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "PendingGamePlayerAccountData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PendingGamePlayerAccountData>.NativeClassPtr);
			PendingGamePlayerAccountData.NativeFieldInfoPtr_playerAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGamePlayerAccountData>.NativeClassPtr, "playerAccountID");
			PendingGamePlayerAccountData.NativeFieldInfoPtr_playerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PendingGamePlayerAccountData>.NativeClassPtr, "playerName");
			PendingGamePlayerAccountData.NativeMethodInfoPtr_get_PlayerAccountID_Public_get_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGamePlayerAccountData>.NativeClassPtr, 100665746);
			PendingGamePlayerAccountData.NativeMethodInfoPtr_set_PlayerAccountID_Public_set_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGamePlayerAccountData>.NativeClassPtr, 100665747);
			PendingGamePlayerAccountData.NativeMethodInfoPtr_get_PlayerName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGamePlayerAccountData>.NativeClassPtr, 100665748);
			PendingGamePlayerAccountData.NativeMethodInfoPtr_set_PlayerName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGamePlayerAccountData>.NativeClassPtr, 100665749);
			PendingGamePlayerAccountData.NativeMethodInfoPtr__ctor_Public_Void_AccountID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGamePlayerAccountData>.NativeClassPtr, 100665750);
			PendingGamePlayerAccountData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PendingGamePlayerAccountData>.NativeClassPtr, 100665751);
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x00054F40 File Offset: 0x00053140
		// (set) Token: 0x06001172 RID: 4466 RVA: 0x00054F80 File Offset: 0x00053180
		public unsafe AccountID PlayerAccountID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGamePlayerAccountData.NativeMethodInfoPtr_get_PlayerAccountID_Public_get_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 515069, RefRangeEnd = 515076, XrefRangeStart = 515063, XrefRangeEnd = 515069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGamePlayerAccountData.NativeMethodInfoPtr_set_PlayerAccountID_Public_set_Void_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x00054FC4 File Offset: 0x000531C4
		// (set) Token: 0x06001174 RID: 4468 RVA: 0x00054FFC File Offset: 0x000531FC
		public unsafe string PlayerName
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGamePlayerAccountData.NativeMethodInfoPtr_get_PlayerName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 515079, RefRangeEnd = 515086, XrefRangeStart = 515076, XrefRangeEnd = 515079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGamePlayerAccountData.NativeMethodInfoPtr_set_PlayerName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00055040 File Offset: 0x00053240
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 514302, RefRangeEnd = 514309, XrefRangeStart = 514302, XrefRangeEnd = 514309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PendingGamePlayerAccountData(AccountID accountID, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PendingGamePlayerAccountData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PendingGamePlayerAccountData.NativeMethodInfoPtr__ctor_Public_Void_AccountID_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x000550A0 File Offset: 0x000532A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515086, XrefRangeEnd = 515098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PendingGamePlayerAccountData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x0000A5D6 File Offset: 0x000087D6
		public PendingGamePlayerAccountData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001178 RID: 4472 RVA: 0x000550E4 File Offset: 0x000532E4
		// (set) Token: 0x06001179 RID: 4473 RVA: 0x0000A5DF File Offset: 0x000087DF
		public unsafe AccountID playerAccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGamePlayerAccountData.NativeFieldInfoPtr_playerAccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGamePlayerAccountData.NativeFieldInfoPtr_playerAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x00055114 File Offset: 0x00053314
		// (set) Token: 0x0600117B RID: 4475 RVA: 0x0000A5FE File Offset: 0x000087FE
		public unsafe string playerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGamePlayerAccountData.NativeFieldInfoPtr_playerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PendingGamePlayerAccountData.NativeFieldInfoPtr_playerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeFieldInfoPtr_playerAccountID;

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeFieldInfoPtr_playerName;

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerAccountID_Public_get_AccountID_0;

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerAccountID_Public_set_Void_AccountID_0;

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerName_Public_get_String_0;

		// Token: 0x04000AAC RID: 2732
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerName_Public_set_Void_String_0;

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AccountID_String_0;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
