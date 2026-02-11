using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Cache
{
	// Token: 0x02000229 RID: 553
	public sealed class RequestCacheManager : Object
	{
		// Token: 0x060024CE RID: 9422 RVA: 0x000A9664 File Offset: 0x000A7864
		// Note: this type is marked as 'beforefieldinit'.
		static RequestCacheManager()
		{
			Il2CppClassPointerStore<RequestCacheManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCacheManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCacheManager>.NativeClassPtr);
			RequestCacheManager.NativeFieldInfoPtr_s_CacheConfigSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCacheManager>.NativeClassPtr, "s_CacheConfigSettings");
			RequestCacheManager.NativeFieldInfoPtr_s_BypassCacheBinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCacheManager>.NativeClassPtr, "s_BypassCacheBinding");
			RequestCacheManager.NativeFieldInfoPtr_s_DefaultGlobalBinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCacheManager>.NativeClassPtr, "s_DefaultGlobalBinding");
			RequestCacheManager.NativeFieldInfoPtr_s_DefaultHttpBinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCacheManager>.NativeClassPtr, "s_DefaultHttpBinding");
			RequestCacheManager.NativeFieldInfoPtr_s_DefaultFtpBinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCacheManager>.NativeClassPtr, "s_DefaultFtpBinding");
			RequestCacheManager.NativeMethodInfoPtr_GetBinding_Internal_Static_RequestCacheBinding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCacheManager>.NativeClassPtr, 100668753);
			RequestCacheManager.NativeMethodInfoPtr_LoadConfigSettings_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCacheManager>.NativeClassPtr, 100668754);
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x000A9720 File Offset: 0x000A7920
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 487107, RefRangeEnd = 487108, XrefRangeStart = 487083, XrefRangeEnd = 487107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RequestCacheBinding GetBinding(string internedScheme)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(internedScheme);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestCacheManager.NativeMethodInfoPtr_GetBinding_Internal_Static_RequestCacheBinding_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RequestCacheBinding>(intPtr3) : null;
			}
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x000A9764 File Offset: 0x000A7964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 487130, RefRangeEnd = 487131, XrefRangeStart = 487108, XrefRangeEnd = 487130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadConfigSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestCacheManager.NativeMethodInfoPtr_LoadConfigSettings_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x00010055 File Offset: 0x0000E255
		public RequestCacheManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x060024D2 RID: 9426 RVA: 0x000A978C File Offset: 0x000A798C
		// (set) Token: 0x060024D3 RID: 9427 RVA: 0x0001005E File Offset: 0x0000E25E
		public unsafe static RequestCachingSectionInternal s_CacheConfigSettings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RequestCacheManager.NativeFieldInfoPtr_s_CacheConfigSettings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCachingSectionInternal>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestCacheManager.NativeFieldInfoPtr_s_CacheConfigSettings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x060024D4 RID: 9428 RVA: 0x000A97B4 File Offset: 0x000A79B4
		// (set) Token: 0x060024D5 RID: 9429 RVA: 0x00010070 File Offset: 0x0000E270
		public unsafe static RequestCacheBinding s_BypassCacheBinding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RequestCacheManager.NativeFieldInfoPtr_s_BypassCacheBinding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCacheBinding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestCacheManager.NativeFieldInfoPtr_s_BypassCacheBinding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x000A97DC File Offset: 0x000A79DC
		// (set) Token: 0x060024D7 RID: 9431 RVA: 0x00010082 File Offset: 0x0000E282
		public unsafe static RequestCacheBinding s_DefaultGlobalBinding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RequestCacheManager.NativeFieldInfoPtr_s_DefaultGlobalBinding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCacheBinding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestCacheManager.NativeFieldInfoPtr_s_DefaultGlobalBinding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x060024D8 RID: 9432 RVA: 0x000A9804 File Offset: 0x000A7A04
		// (set) Token: 0x060024D9 RID: 9433 RVA: 0x00010094 File Offset: 0x0000E294
		public unsafe static RequestCacheBinding s_DefaultHttpBinding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RequestCacheManager.NativeFieldInfoPtr_s_DefaultHttpBinding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCacheBinding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestCacheManager.NativeFieldInfoPtr_s_DefaultHttpBinding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x060024DA RID: 9434 RVA: 0x000A982C File Offset: 0x000A7A2C
		// (set) Token: 0x060024DB RID: 9435 RVA: 0x000100A6 File Offset: 0x0000E2A6
		public unsafe static RequestCacheBinding s_DefaultFtpBinding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RequestCacheManager.NativeFieldInfoPtr_s_DefaultFtpBinding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCacheBinding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestCacheManager.NativeFieldInfoPtr_s_DefaultFtpBinding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C7C RID: 7292
		private static readonly IntPtr NativeFieldInfoPtr_s_CacheConfigSettings;

		// Token: 0x04001C7D RID: 7293
		private static readonly IntPtr NativeFieldInfoPtr_s_BypassCacheBinding;

		// Token: 0x04001C7E RID: 7294
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultGlobalBinding;

		// Token: 0x04001C7F RID: 7295
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultHttpBinding;

		// Token: 0x04001C80 RID: 7296
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultFtpBinding;

		// Token: 0x04001C81 RID: 7297
		private static readonly IntPtr NativeMethodInfoPtr_GetBinding_Internal_Static_RequestCacheBinding_String_0;

		// Token: 0x04001C82 RID: 7298
		private static readonly IntPtr NativeMethodInfoPtr_LoadConfigSettings_Private_Static_Void_0;
	}
}
