using System;
using Canis.utils.ids;
using dwd.core.account;
using dwd.core.data.providers;
using dwd.core.settings.serverSettings.save;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.settings.serverSettings
{
	// Token: 0x020000BA RID: 186
	public class ServerSettingStorage : DataProvider
	{
		// Token: 0x06000BD4 RID: 3028 RVA: 0x00040D3C File Offset: 0x0003EF3C
		// Note: this type is marked as 'beforefieldinit'.
		static ServerSettingStorage()
		{
			Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.serverSettings", "ServerSettingStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr);
			ServerSettingStorage.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr, "instance");
			ServerSettingStorage.NativeFieldInfoPtr__accountProvider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr, "<accountProvider>k__BackingField");
			ServerSettingStorage.NativeFieldInfoPtr_pendingSaves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr, "pendingSaves");
			ServerSettingStorage.NativeFieldInfoPtr_storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr, "storage");
			ServerSettingStorage.NativeFieldInfoPtr_cachedProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr, "cachedProvider");
			ServerSettingStorage.NativeMethodInfoPtr_Find_Public_Static_ServerSettingStorage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr, 100664955);
			ServerSettingStorage.NativeMethodInfoPtr_get_accountProvider_Protected_get_AccountProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr, 100664956);
			ServerSettingStorage.NativeMethodInfoPtr_set_accountProvider_Private_set_Void_AccountProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr, 100664957);
			ServerSettingStorage.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr, 100664958);
			ServerSettingStorage.NativeMethodInfoPtr_start_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr, 100664959);
			ServerSettingStorage.NativeMethodInfoPtr_Get_Public_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr, 100664960);
			ServerSettingStorage.NativeMethodInfoPtr_get_PendingSaves_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr, 100664961);
			ServerSettingStorage.NativeMethodInfoPtr_drainQueue_Protected_Void_IList_1_SaveRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr, 100664962);
			ServerSettingStorage.NativeMethodInfoPtr_Save_Public_Void_SaveRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr, 100664963);
			ServerSettingStorage.NativeMethodInfoPtr_Save_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr, 100664964);
			ServerSettingStorage.NativeMethodInfoPtr_GetAll_Public_Void_IDictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr, 100664965);
			ServerSettingStorage.NativeMethodInfoPtr_assertSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr, 100664966);
			ServerSettingStorage.NativeMethodInfoPtr_updateStorage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr, 100664967);
			ServerSettingStorage.NativeMethodInfoPtr_GetAccountID_Public_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr, 100664968);
			ServerSettingStorage.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr, 100664969);
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00040EFC File Offset: 0x0003F0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863967, XrefRangeEnd = 863978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServerSettingStorage Find()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingStorage.NativeMethodInfoPtr_Find_Public_Static_ServerSettingStorage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerSettingStorage>(intPtr3) : null;
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x00040F30 File Offset: 0x0003F130
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x00040F70 File Offset: 0x0003F170
		public unsafe AccountProvider accountProvider
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingStorage.NativeMethodInfoPtr_get_accountProvider_Protected_get_AccountProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountProvider>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingStorage.NativeMethodInfoPtr_set_accountProvider_Private_set_Void_AccountProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00040FB4 File Offset: 0x0003F1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863978, XrefRangeEnd = 863982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingStorage.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00040FE8 File Offset: 0x0003F1E8
		[CallerCount(0)]
		public unsafe virtual void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServerSettingStorage.NativeMethodInfoPtr_start_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00041024 File Offset: 0x0003F224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 863991, RefRangeEnd = 863992, XrefRangeStart = 863982, XrefRangeEnd = 863991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Get(int key, out int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingStorage.NativeMethodInfoPtr_Get_Public_Boolean_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x0004107C File Offset: 0x0003F27C
		public unsafe int PendingSaves
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863992, XrefRangeEnd = 863993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingStorage.NativeMethodInfoPtr_get_PendingSaves_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x000410B8 File Offset: 0x0003F2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863993, XrefRangeEnd = 864006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void drainQueue(IList<SaveRequest> saves)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(saves);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingStorage.NativeMethodInfoPtr_drainQueue_Protected_Void_IList_1_SaveRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x000410FC File Offset: 0x0003F2FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 864013, RefRangeEnd = 864017, XrefRangeStart = 864006, XrefRangeEnd = 864013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Save(SaveRequest save)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(save);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingStorage.NativeMethodInfoPtr_Save_Public_Void_SaveRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00041140 File Offset: 0x0003F340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864017, XrefRangeEnd = 864022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Save(int key, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingStorage.NativeMethodInfoPtr_Save_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x0004118C File Offset: 0x0003F38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864022, XrefRangeEnd = 864025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetAll(IDictionary<int, int> map)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingStorage.NativeMethodInfoPtr_GetAll_Public_Void_IDictionary_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x000411D0 File Offset: 0x0003F3D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 864031, RefRangeEnd = 864033, XrefRangeStart = 864025, XrefRangeEnd = 864031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void assertSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingStorage.NativeMethodInfoPtr_assertSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00041204 File Offset: 0x0003F404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864033, XrefRangeEnd = 864035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateStorage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingStorage.NativeMethodInfoPtr_updateStorage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x00041238 File Offset: 0x0003F438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864035, XrefRangeEnd = 864036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountID GetAccountID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingStorage.NativeMethodInfoPtr_GetAccountID_Public_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00041278 File Offset: 0x0003F478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864036, XrefRangeEnd = 864044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerSettingStorage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerSettingStorage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingStorage.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x000062DB File Offset: 0x000044DB
		public ServerSettingStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x000412B4 File Offset: 0x0003F4B4
		// (set) Token: 0x06000BE6 RID: 3046 RVA: 0x000062E4 File Offset: 0x000044E4
		public unsafe static ServerSettingStorage instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServerSettingStorage.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerSettingStorage>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServerSettingStorage.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x000412DC File Offset: 0x0003F4DC
		// (set) Token: 0x06000BE8 RID: 3048 RVA: 0x000062F6 File Offset: 0x000044F6
		public unsafe AccountProvider _accountProvider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingStorage.NativeFieldInfoPtr__accountProvider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingStorage.NativeFieldInfoPtr__accountProvider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x0004130C File Offset: 0x0003F50C
		// (set) Token: 0x06000BEA RID: 3050 RVA: 0x00006315 File Offset: 0x00004515
		public unsafe Queue<SaveRequest> pendingSaves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingStorage.NativeFieldInfoPtr_pendingSaves);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<SaveRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingStorage.NativeFieldInfoPtr_pendingSaves), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x0004133C File Offset: 0x0003F53C
		// (set) Token: 0x06000BEC RID: 3052 RVA: 0x00006334 File Offset: 0x00004534
		public unsafe ServerSettingsData storage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingStorage.NativeFieldInfoPtr_storage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerSettingsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingStorage.NativeFieldInfoPtr_storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x0004136C File Offset: 0x0003F56C
		// (set) Token: 0x06000BEE RID: 3054 RVA: 0x00006353 File Offset: 0x00004553
		public unsafe ulong cachedProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingStorage.NativeFieldInfoPtr_cachedProvider);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingStorage.NativeFieldInfoPtr_cachedProvider)) = value;
			}
		}

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeFieldInfoPtr__accountProvider_k__BackingField;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeFieldInfoPtr_pendingSaves;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeFieldInfoPtr_storage;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeFieldInfoPtr_cachedProvider;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_ServerSettingStorage_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr_get_accountProvider_Protected_get_AccountProvider_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_set_accountProvider_Private_set_Void_AccountProvider_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Boolean_Int32_byref_Int32_0;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr_get_PendingSaves_Public_get_Int32_0;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr_drainQueue_Protected_Void_IList_1_SaveRequest_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Void_SaveRequest_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Void_Int32_Int32_0;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr_GetAll_Public_Void_IDictionary_2_Int32_Int32_0;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeMethodInfoPtr_assertSettings_Private_Void_0;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeMethodInfoPtr_updateStorage_Private_Void_0;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr_GetAccountID_Public_AccountID_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
