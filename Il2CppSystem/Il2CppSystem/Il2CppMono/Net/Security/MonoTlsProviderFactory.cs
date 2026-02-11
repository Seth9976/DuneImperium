using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000020 RID: 32
	public static class MonoTlsProviderFactory : Object
	{
		// Token: 0x060001F7 RID: 503 RVA: 0x00022D08 File Offset: 0x00020F08
		// Note: this type is marked as 'beforefieldinit'.
		static MonoTlsProviderFactory()
		{
			Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "MonoTlsProviderFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr);
			MonoTlsProviderFactory.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "locker");
			MonoTlsProviderFactory.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "initialized");
			MonoTlsProviderFactory.NativeFieldInfoPtr_defaultProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "defaultProvider");
			MonoTlsProviderFactory.NativeFieldInfoPtr_providerRegistration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "providerRegistration");
			MonoTlsProviderFactory.NativeFieldInfoPtr_providerCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "providerCache");
			MonoTlsProviderFactory.NativeFieldInfoPtr_UnityTlsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "UnityTlsId");
			MonoTlsProviderFactory.NativeFieldInfoPtr_AppleTlsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "AppleTlsId");
			MonoTlsProviderFactory.NativeFieldInfoPtr_BtlsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, "BtlsId");
			MonoTlsProviderFactory.NativeMethodInfoPtr_GetProviderInternal_Internal_Static_MobileTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663662);
			MonoTlsProviderFactory.NativeMethodInfoPtr_InitializeInternal_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663663);
			MonoTlsProviderFactory.NativeMethodInfoPtr_LookupProvider_Private_Static_MobileTlsProvider_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663664);
			MonoTlsProviderFactory.NativeMethodInfoPtr_InitializeProviderRegistration_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663665);
			MonoTlsProviderFactory.NativeMethodInfoPtr_PopulateUnityProviders_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663666);
			MonoTlsProviderFactory.NativeMethodInfoPtr_PopulateProviders_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663667);
			MonoTlsProviderFactory.NativeMethodInfoPtr_IsBtlsSupported_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663668);
			MonoTlsProviderFactory.NativeMethodInfoPtr_CreateDefaultProviderImpl_Private_Static_MobileTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663669);
			MonoTlsProviderFactory.NativeMethodInfoPtr_GetProvider_Internal_Static_MobileTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663670);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00022E8C File Offset: 0x0002108C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 428801, RefRangeEnd = 428806, XrefRangeStart = 428789, XrefRangeEnd = 428801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MobileTlsProvider GetProviderInternal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_GetProviderInternal_Internal_Static_MobileTlsProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MobileTlsProvider>(intPtr3) : null;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00022EC0 File Offset: 0x000210C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428847, RefRangeEnd = 428848, XrefRangeStart = 428806, XrefRangeEnd = 428847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeInternal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_InitializeInternal_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00022EE8 File Offset: 0x000210E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 428896, RefRangeEnd = 428897, XrefRangeStart = 428848, XrefRangeEnd = 428896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MobileTlsProvider LookupProvider(string name, bool throwOnError)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_LookupProvider_Private_Static_MobileTlsProvider_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MobileTlsProvider>(intPtr3) : null;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00022F3C File Offset: 0x0002113C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 428960, RefRangeEnd = 428962, XrefRangeStart = 428897, XrefRangeEnd = 428960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeProviderRegistration()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_InitializeProviderRegistration_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00022F64 File Offset: 0x00021164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428962, XrefRangeEnd = 429006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PopulateUnityProviders()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_PopulateUnityProviders_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00022F8C File Offset: 0x0002118C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429043, RefRangeEnd = 429044, XrefRangeStart = 429006, XrefRangeEnd = 429043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PopulateProviders()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_PopulateProviders_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00022FB4 File Offset: 0x000211B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429053, RefRangeEnd = 429054, XrefRangeStart = 429044, XrefRangeEnd = 429053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBtlsSupported()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_IsBtlsSupported_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00022FE4 File Offset: 0x000211E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429091, RefRangeEnd = 429092, XrefRangeStart = 429054, XrefRangeEnd = 429091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MobileTlsProvider CreateDefaultProviderImpl()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_CreateDefaultProviderImpl_Private_Static_MobileTlsProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MobileTlsProvider>(intPtr3) : null;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00023018 File Offset: 0x00021218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429092, XrefRangeEnd = 429096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MobileTlsProvider GetProvider()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProviderFactory.NativeMethodInfoPtr_GetProvider_Internal_Static_MobileTlsProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MobileTlsProvider>(intPtr3) : null;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002B4E File Offset: 0x00000D4E
		public MonoTlsProviderFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0002304C File Offset: 0x0002124C
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00002B57 File Offset: 0x00000D57
		public unsafe static Object locker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_locker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_locker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00023074 File Offset: 0x00021274
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00002B69 File Offset: 0x00000D69
		public unsafe static bool initialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_initialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_initialized, (void*)(&value));
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00023090 File Offset: 0x00021290
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00002B77 File Offset: 0x00000D77
		public unsafe static MobileTlsProvider defaultProvider
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_defaultProvider, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MobileTlsProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_defaultProvider, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000208 RID: 520 RVA: 0x000230B8 File Offset: 0x000212B8
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00002B89 File Offset: 0x00000D89
		public unsafe static Dictionary<string, Tuple<Guid, string>> providerRegistration
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_providerRegistration, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Tuple<Guid, string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_providerRegistration, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600020A RID: 522 RVA: 0x000230E0 File Offset: 0x000212E0
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00002B9B File Offset: 0x00000D9B
		public unsafe static Dictionary<Guid, MobileTlsProvider> providerCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_providerCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Guid, MobileTlsProvider>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_providerCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00023108 File Offset: 0x00021308
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00002BAD File Offset: 0x00000DAD
		public unsafe static Guid UnityTlsId
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_UnityTlsId, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_UnityTlsId, (void*)(&value));
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00023124 File Offset: 0x00021324
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00002BBB File Offset: 0x00000DBB
		public unsafe static Guid AppleTlsId
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_AppleTlsId, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_AppleTlsId, (void*)(&value));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00023140 File Offset: 0x00021340
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00002BC9 File Offset: 0x00000DC9
		public unsafe static Guid BtlsId
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(MonoTlsProviderFactory.NativeFieldInfoPtr_BtlsId, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoTlsProviderFactory.NativeFieldInfoPtr_BtlsId, (void*)(&value));
			}
		}

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr_defaultProvider;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr_providerRegistration;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeFieldInfoPtr_providerCache;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeFieldInfoPtr_UnityTlsId;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeFieldInfoPtr_AppleTlsId;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeFieldInfoPtr_BtlsId;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_GetProviderInternal_Internal_Static_MobileTlsProvider_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInternal_Internal_Static_Void_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_LookupProvider_Private_Static_MobileTlsProvider_String_Boolean_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_InitializeProviderRegistration_Private_Static_Void_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_PopulateUnityProviders_Private_Static_Void_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_PopulateProviders_Private_Static_Void_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_IsBtlsSupported_Internal_Static_Boolean_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultProviderImpl_Private_Static_MobileTlsProvider_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_GetProvider_Internal_Static_MobileTlsProvider_0;
	}
}
