using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.settings.platform
{
	// Token: 0x020000DE RID: 222
	public class AccountSettingNamespace : Object
	{
		// Token: 0x06000D65 RID: 3429 RVA: 0x00047FB4 File Offset: 0x000461B4
		// Note: this type is marked as 'beforefieldinit'.
		static AccountSettingNamespace()
		{
			Il2CppClassPointerStore<AccountSettingNamespace>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.platform", "AccountSettingNamespace");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountSettingNamespace>.NativeClassPtr);
			AccountSettingNamespace.NativeFieldInfoPtr_AccountIDPrefKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountSettingNamespace>.NativeClassPtr, "AccountIDPrefKey");
			AccountSettingNamespace.NativeFieldInfoPtr_SeenAccountIDsPrefKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountSettingNamespace>.NativeClassPtr, "SeenAccountIDsPrefKey");
			AccountSettingNamespace.NativeFieldInfoPtr_accountIDSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountSettingNamespace>.NativeClassPtr, "accountIDSetting");
			AccountSettingNamespace.NativeFieldInfoPtr_seenAccountIDsSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountSettingNamespace>.NativeClassPtr, "seenAccountIDsSetting");
			AccountSettingNamespace.NativeFieldInfoPtr_cachedAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountSettingNamespace>.NativeClassPtr, "cachedAccountID");
			AccountSettingNamespace.NativeFieldInfoPtr_cachedSeenAccountIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountSettingNamespace>.NativeClassPtr, "cachedSeenAccountIDs");
			AccountSettingNamespace.NativeFieldInfoPtr_cachedSeenAccountIDsVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountSettingNamespace>.NativeClassPtr, "cachedSeenAccountIDsVersion");
			AccountSettingNamespace.NativeFieldInfoPtr_keepForNewAccount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountSettingNamespace>.NativeClassPtr, "keepForNewAccount");
			AccountSettingNamespace.NativeMethodInfoPtr_get_AccountIDSetting_Private_Static_get_IWritableSetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountSettingNamespace>.NativeClassPtr, 100665212);
			AccountSettingNamespace.NativeMethodInfoPtr_get_SeenAccountIDsSetting_Private_Static_get_IWritableSetting_1_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountSettingNamespace>.NativeClassPtr, 100665213);
			AccountSettingNamespace.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountSettingNamespace>.NativeClassPtr, 100665214);
			AccountSettingNamespace.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountSettingNamespace>.NativeClassPtr, 100665215);
			AccountSettingNamespace.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountSettingNamespace>.NativeClassPtr, 100665216);
			AccountSettingNamespace.NativeMethodInfoPtr_HasChanged_Public_Virtual_Final_New_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountSettingNamespace>.NativeClassPtr, 100665217);
			AccountSettingNamespace.NativeMethodInfoPtr_SetAccountIDForPrefs_Public_Static_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountSettingNamespace>.NativeClassPtr, 100665218);
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x00048110 File Offset: 0x00046310
		public unsafe static IWritableSetting<string> AccountIDSetting
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 866084, RefRangeEnd = 866088, XrefRangeStart = 866067, XrefRangeEnd = 866084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountSettingNamespace.NativeMethodInfoPtr_get_AccountIDSetting_Private_Static_get_IWritableSetting_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWritableSetting<string>>(intPtr3) : null;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x00048144 File Offset: 0x00046344
		public unsafe static IWritableSetting<List<string>> SeenAccountIDsSetting
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 866105, RefRangeEnd = 866110, XrefRangeStart = 866088, XrefRangeEnd = 866105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountSettingNamespace.NativeMethodInfoPtr_get_SeenAccountIDsSetting_Private_Static_get_IWritableSetting_1_List_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWritableSetting<List<string>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00048178 File Offset: 0x00046378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 866111, RefRangeEnd = 866112, XrefRangeStart = 866110, XrefRangeEnd = 866111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountSettingNamespace(bool keepForNewAccount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccountSettingNamespace>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keepForNewAccount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountSettingNamespace.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x000481C0 File Offset: 0x000463C0
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866112, XrefRangeEnd = 866117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountSettingNamespace.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x000481FC File Offset: 0x000463FC
		public unsafe virtual string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866117, XrefRangeEnd = 866122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountSettingNamespace.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00048234 File Offset: 0x00046434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866122, XrefRangeEnd = 866148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasChanged(out bool shouldReSave)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &shouldReSave;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountSettingNamespace.NativeMethodInfoPtr_HasChanged_Public_Virtual_Final_New_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00048280 File Offset: 0x00046480
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 866208, RefRangeEnd = 866211, XrefRangeStart = 866148, XrefRangeEnd = 866208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetAccountIDForPrefs(AccountID accountID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountSettingNamespace.NativeMethodInfoPtr_SetAccountIDForPrefs_Public_Static_Void_AccountID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x000069DC File Offset: 0x00004BDC
		public AccountSettingNamespace(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x000482B8 File Offset: 0x000464B8
		// (set) Token: 0x06000D6F RID: 3439 RVA: 0x000069E5 File Offset: 0x00004BE5
		public unsafe static string AccountIDPrefKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AccountSettingNamespace.NativeFieldInfoPtr_AccountIDPrefKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AccountSettingNamespace.NativeFieldInfoPtr_AccountIDPrefKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x000482D8 File Offset: 0x000464D8
		// (set) Token: 0x06000D71 RID: 3441 RVA: 0x000069F7 File Offset: 0x00004BF7
		public unsafe static string SeenAccountIDsPrefKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AccountSettingNamespace.NativeFieldInfoPtr_SeenAccountIDsPrefKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AccountSettingNamespace.NativeFieldInfoPtr_SeenAccountIDsPrefKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x000482F8 File Offset: 0x000464F8
		// (set) Token: 0x06000D73 RID: 3443 RVA: 0x00006A09 File Offset: 0x00004C09
		public unsafe static IWritableSetting<string> accountIDSetting
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AccountSettingNamespace.NativeFieldInfoPtr_accountIDSetting, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWritableSetting<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AccountSettingNamespace.NativeFieldInfoPtr_accountIDSetting, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000D74 RID: 3444 RVA: 0x00048320 File Offset: 0x00046520
		// (set) Token: 0x06000D75 RID: 3445 RVA: 0x00006A1B File Offset: 0x00004C1B
		public unsafe static IWritableSetting<List<string>> seenAccountIDsSetting
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AccountSettingNamespace.NativeFieldInfoPtr_seenAccountIDsSetting, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWritableSetting<List<string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AccountSettingNamespace.NativeFieldInfoPtr_seenAccountIDsSetting, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x00048348 File Offset: 0x00046548
		// (set) Token: 0x06000D77 RID: 3447 RVA: 0x00006A2D File Offset: 0x00004C2D
		public unsafe string cachedAccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountSettingNamespace.NativeFieldInfoPtr_cachedAccountID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountSettingNamespace.NativeFieldInfoPtr_cachedAccountID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x00048370 File Offset: 0x00046570
		// (set) Token: 0x06000D79 RID: 3449 RVA: 0x00006A4C File Offset: 0x00004C4C
		public unsafe IReadOnlyList<string> cachedSeenAccountIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountSettingNamespace.NativeFieldInfoPtr_cachedSeenAccountIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountSettingNamespace.NativeFieldInfoPtr_cachedSeenAccountIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x000483A0 File Offset: 0x000465A0
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x00006A6B File Offset: 0x00004C6B
		public unsafe ulong cachedSeenAccountIDsVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountSettingNamespace.NativeFieldInfoPtr_cachedSeenAccountIDsVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountSettingNamespace.NativeFieldInfoPtr_cachedSeenAccountIDsVersion)) = value;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x000483C8 File Offset: 0x000465C8
		// (set) Token: 0x06000D7D RID: 3453 RVA: 0x00006A86 File Offset: 0x00004C86
		public unsafe bool keepForNewAccount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountSettingNamespace.NativeFieldInfoPtr_keepForNewAccount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountSettingNamespace.NativeFieldInfoPtr_keepForNewAccount)) = value;
			}
		}

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeFieldInfoPtr_AccountIDPrefKey;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeFieldInfoPtr_SeenAccountIDsPrefKey;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeFieldInfoPtr_accountIDSetting;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeFieldInfoPtr_seenAccountIDsSetting;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeFieldInfoPtr_cachedAccountID;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeFieldInfoPtr_cachedSeenAccountIDs;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeFieldInfoPtr_cachedSeenAccountIDsVersion;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeFieldInfoPtr_keepForNewAccount;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr_get_AccountIDSetting_Private_Static_get_IWritableSetting_1_String_0;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeMethodInfoPtr_get_SeenAccountIDsSetting_Private_Static_get_IWritableSetting_1_List_1_String_0;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeMethodInfoPtr_HasChanged_Public_Virtual_Final_New_Boolean_byref_Boolean_0;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeMethodInfoPtr_SetAccountIDForPrefs_Public_Static_Void_AccountID_0;
	}
}
