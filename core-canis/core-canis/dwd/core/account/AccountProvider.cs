using System;
using Canis.utils.ids;
using dwd.core.data.providers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.account
{
	// Token: 0x0200021E RID: 542
	public sealed class AccountProvider : DataProvider
	{
		// Token: 0x06001DA0 RID: 7584 RVA: 0x00088ED0 File Offset: 0x000870D0
		// Note: this type is marked as 'beforefieldinit'.
		static AccountProvider()
		{
			Il2CppClassPointerStore<AccountProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.account", "AccountProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountProvider>.NativeClassPtr);
			AccountProvider.NativeFieldInfoPtr_factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountProvider>.NativeClassPtr, "factory");
			AccountProvider.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountProvider>.NativeClassPtr, "source");
			AccountProvider.NativeFieldInfoPtr__Account = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountProvider>.NativeClassPtr, "_Account");
			AccountProvider.NativeMethodInfoPtr_SetFactory_Public_Void_IAccountFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountProvider>.NativeClassPtr, 100668065);
			AccountProvider.NativeMethodInfoPtr_SetSource_Public_Void_IAccountSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountProvider>.NativeClassPtr, 100668066);
			AccountProvider.NativeMethodInfoPtr_Initialize_Public_Void_SerializableAccount_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountProvider>.NativeClassPtr, 100668067);
			AccountProvider.NativeMethodInfoPtr_InitializeWithOfflineID_Public_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountProvider>.NativeClassPtr, 100668068);
			AccountProvider.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountProvider>.NativeClassPtr, 100668069);
			AccountProvider.NativeMethodInfoPtr_get_Account_Public_get_AccountComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountProvider>.NativeClassPtr, 100668070);
			AccountProvider.NativeMethodInfoPtr_set_Account_Private_set_Void_AccountComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountProvider>.NativeClassPtr, 100668071);
			AccountProvider.NativeMethodInfoPtr_dwd_core_data_async_IAsyncData_dwd_core_account_AccountComponent__get_Data_Private_Virtual_Final_New_get_AccountComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountProvider>.NativeClassPtr, 100668072);
			AccountProvider.NativeMethodInfoPtr_dwd_core_data_async_IAsyncData_Request_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountProvider>.NativeClassPtr, 100668073);
			AccountProvider.NativeMethodInfoPtr_Find_Public_Static_AccountProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountProvider>.NativeClassPtr, 100668074);
			AccountProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountProvider>.NativeClassPtr, 100668075);
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00089018 File Offset: 0x00087218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFactory(IAccountFactory factory)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountProvider.NativeMethodInfoPtr_SetFactory_Public_Void_IAccountFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x0008905C File Offset: 0x0008725C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSource(IAccountSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountProvider.NativeMethodInfoPtr_SetSource_Public_Void_IAccountSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x000890A0 File Offset: 0x000872A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 886492, RefRangeEnd = 886495, XrefRangeStart = 886484, XrefRangeEnd = 886492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(SerializableAccount account)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(account);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountProvider.NativeMethodInfoPtr_Initialize_Public_Void_SerializableAccount_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x000890E4 File Offset: 0x000872E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 886530, RefRangeEnd = 886532, XrefRangeStart = 886495, XrefRangeEnd = 886530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeWithOfflineID(AccountID offlineID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(offlineID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountProvider.NativeMethodInfoPtr_InitializeWithOfflineID_Public_Void_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x00089128 File Offset: 0x00087328
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 886534, RefRangeEnd = 886536, XrefRangeStart = 886532, XrefRangeEnd = 886534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountProvider.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x0008915C File Offset: 0x0008735C
		// (set) Token: 0x06001DA7 RID: 7591 RVA: 0x0008919C File Offset: 0x0008739C
		public unsafe AccountComponent Account
		{
			[CallerCount(71)]
			[CachedScanResults(RefRangeStart = 886536, RefRangeEnd = 886607, XrefRangeStart = 886536, XrefRangeEnd = 886536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountProvider.NativeMethodInfoPtr_get_Account_Public_get_AccountComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountComponent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886607, XrefRangeEnd = 886609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountProvider.NativeMethodInfoPtr_set_Account_Private_set_Void_AccountComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x000891E0 File Offset: 0x000873E0
		public unsafe AccountComponent dwd.core.data.async.IAsyncData<dwd.core.account.AccountComponent>.Data
		{
			[CallerCount(71)]
			[CachedScanResults(RefRangeStart = 886536, RefRangeEnd = 886607, XrefRangeStart = 886536, XrefRangeEnd = 886607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountProvider.NativeMethodInfoPtr_dwd_core_data_async_IAsyncData_dwd_core_account_AccountComponent__get_Data_Private_Virtual_Final_New_get_AccountComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountComponent>(intPtr3) : null;
			}
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00089220 File Offset: 0x00087420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886609, XrefRangeEnd = 886613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void dwd_core_data_async_IAsyncData_Request()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountProvider.NativeMethodInfoPtr_dwd_core_data_async_IAsyncData_Request_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x00089254 File Offset: 0x00087454
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 886616, RefRangeEnd = 886627, XrefRangeStart = 886613, XrefRangeEnd = 886616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AccountProvider Find()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountProvider.NativeMethodInfoPtr_Find_Public_Static_AccountProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountProvider>(intPtr3) : null;
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x00089288 File Offset: 0x00087488
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 875404, RefRangeEnd = 875407, XrefRangeStart = 875404, XrefRangeEnd = 875407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccountProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x0000C9B8 File Offset: 0x0000ABB8
		public AccountProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x000892C4 File Offset: 0x000874C4
		// (set) Token: 0x06001DAE RID: 7598 RVA: 0x0000C9C1 File Offset: 0x0000ABC1
		public unsafe IAccountFactory factory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountProvider.NativeFieldInfoPtr_factory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAccountFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountProvider.NativeFieldInfoPtr_factory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x000892F4 File Offset: 0x000874F4
		// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x0000C9E0 File Offset: 0x0000ABE0
		public unsafe IAccountSource source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountProvider.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAccountSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountProvider.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x00089324 File Offset: 0x00087524
		// (set) Token: 0x06001DB2 RID: 7602 RVA: 0x0000C9FF File Offset: 0x0000ABFF
		public unsafe AccountComponent _Account
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountProvider.NativeFieldInfoPtr__Account);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountProvider.NativeFieldInfoPtr__Account), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014BD RID: 5309
		private static readonly IntPtr NativeFieldInfoPtr_factory;

		// Token: 0x040014BE RID: 5310
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x040014BF RID: 5311
		private static readonly IntPtr NativeFieldInfoPtr__Account;

		// Token: 0x040014C0 RID: 5312
		private static readonly IntPtr NativeMethodInfoPtr_SetFactory_Public_Void_IAccountFactory_0;

		// Token: 0x040014C1 RID: 5313
		private static readonly IntPtr NativeMethodInfoPtr_SetSource_Public_Void_IAccountSource_0;

		// Token: 0x040014C2 RID: 5314
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_SerializableAccount_0;

		// Token: 0x040014C3 RID: 5315
		private static readonly IntPtr NativeMethodInfoPtr_InitializeWithOfflineID_Public_Void_AccountID_0;

		// Token: 0x040014C4 RID: 5316
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040014C5 RID: 5317
		private static readonly IntPtr NativeMethodInfoPtr_get_Account_Public_get_AccountComponent_0;

		// Token: 0x040014C6 RID: 5318
		private static readonly IntPtr NativeMethodInfoPtr_set_Account_Private_set_Void_AccountComponent_0;

		// Token: 0x040014C7 RID: 5319
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_data_async_IAsyncData_dwd_core_account_AccountComponent__get_Data_Private_Virtual_Final_New_get_AccountComponent_0;

		// Token: 0x040014C8 RID: 5320
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_data_async_IAsyncData_Request_Private_Virtual_Final_New_Void_0;

		// Token: 0x040014C9 RID: 5321
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_AccountProvider_0;

		// Token: 0x040014CA RID: 5322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
