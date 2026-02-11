using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.X509
{
	// Token: 0x02000012 RID: 18
	public sealed class X509StoreManager : Object
	{
		// Token: 0x06000165 RID: 357 RVA: 0x00009C5C File Offset: 0x00007E5C
		// Note: this type is marked as 'beforefieldinit'.
		static X509StoreManager()
		{
			Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "X509StoreManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr);
			X509StoreManager.NativeFieldInfoPtr__userPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, "_userPath");
			X509StoreManager.NativeFieldInfoPtr__localMachinePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, "_localMachinePath");
			X509StoreManager.NativeFieldInfoPtr__newUserPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, "_newUserPath");
			X509StoreManager.NativeFieldInfoPtr__newLocalMachinePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, "_newLocalMachinePath");
			X509StoreManager.NativeFieldInfoPtr__userStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, "_userStore");
			X509StoreManager.NativeFieldInfoPtr__machineStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, "_machineStore");
			X509StoreManager.NativeMethodInfoPtr_get_CurrentUserPath_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, 100663518);
			X509StoreManager.NativeMethodInfoPtr_get_LocalMachinePath_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, 100663519);
			X509StoreManager.NativeMethodInfoPtr_get_NewCurrentUserPath_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, 100663520);
			X509StoreManager.NativeMethodInfoPtr_get_NewLocalMachinePath_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, 100663521);
			X509StoreManager.NativeMethodInfoPtr_get_CurrentUser_Public_Static_get_X509Stores_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, 100663522);
			X509StoreManager.NativeMethodInfoPtr_get_LocalMachine_Public_Static_get_X509Stores_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, 100663523);
			X509StoreManager.NativeMethodInfoPtr_get_TrustedRootCertificates_Public_Static_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509StoreManager>.NativeClassPtr, 100663524);
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00009D90 File Offset: 0x00007F90
		public unsafe static string CurrentUserPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148201, XrefRangeEnd = 1148221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509StoreManager.NativeMethodInfoPtr_get_CurrentUserPath_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00009DBC File Offset: 0x00007FBC
		public unsafe static string LocalMachinePath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148221, XrefRangeEnd = 1148241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509StoreManager.NativeMethodInfoPtr_get_LocalMachinePath_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00009DE8 File Offset: 0x00007FE8
		public unsafe static string NewCurrentUserPath
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1148261, RefRangeEnd = 1148263, XrefRangeStart = 1148241, XrefRangeEnd = 1148261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509StoreManager.NativeMethodInfoPtr_get_NewCurrentUserPath_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00009E14 File Offset: 0x00008014
		public unsafe static string NewLocalMachinePath
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1148283, RefRangeEnd = 1148285, XrefRangeStart = 1148263, XrefRangeEnd = 1148283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509StoreManager.NativeMethodInfoPtr_get_NewLocalMachinePath_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00009E40 File Offset: 0x00008040
		public unsafe static X509Stores CurrentUser
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1148316, RefRangeEnd = 1148318, XrefRangeStart = 1148285, XrefRangeEnd = 1148316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509StoreManager.NativeMethodInfoPtr_get_CurrentUser_Public_Static_get_X509Stores_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Stores>(intPtr3) : null;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00009E74 File Offset: 0x00008074
		public unsafe static X509Stores LocalMachine
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1148349, RefRangeEnd = 1148351, XrefRangeStart = 1148318, XrefRangeEnd = 1148349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509StoreManager.NativeMethodInfoPtr_get_LocalMachine_Public_Static_get_X509Stores_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Stores>(intPtr3) : null;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00009EA8 File Offset: 0x000080A8
		public unsafe static X509CertificateCollection TrustedRootCertificates
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148351, XrefRangeEnd = 1148425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509StoreManager.NativeMethodInfoPtr_get_TrustedRootCertificates_Public_Static_get_X509CertificateCollection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000296D File Offset: 0x00000B6D
		public X509StoreManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00009EDC File Offset: 0x000080DC
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00002976 File Offset: 0x00000B76
		public unsafe static string _userPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509StoreManager.NativeFieldInfoPtr__userPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509StoreManager.NativeFieldInfoPtr__userPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00009EFC File Offset: 0x000080FC
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00002988 File Offset: 0x00000B88
		public unsafe static string _localMachinePath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509StoreManager.NativeFieldInfoPtr__localMachinePath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509StoreManager.NativeFieldInfoPtr__localMachinePath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00009F1C File Offset: 0x0000811C
		// (set) Token: 0x06000173 RID: 371 RVA: 0x0000299A File Offset: 0x00000B9A
		public unsafe static string _newUserPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509StoreManager.NativeFieldInfoPtr__newUserPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509StoreManager.NativeFieldInfoPtr__newUserPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00009F3C File Offset: 0x0000813C
		// (set) Token: 0x06000175 RID: 373 RVA: 0x000029AC File Offset: 0x00000BAC
		public unsafe static string _newLocalMachinePath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509StoreManager.NativeFieldInfoPtr__newLocalMachinePath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509StoreManager.NativeFieldInfoPtr__newLocalMachinePath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00009F5C File Offset: 0x0000815C
		// (set) Token: 0x06000177 RID: 375 RVA: 0x000029BE File Offset: 0x00000BBE
		public unsafe static X509Stores _userStore
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509StoreManager.NativeFieldInfoPtr__userStore, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Stores>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509StoreManager.NativeFieldInfoPtr__userStore, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00009F84 File Offset: 0x00008184
		// (set) Token: 0x06000179 RID: 377 RVA: 0x000029D0 File Offset: 0x00000BD0
		public unsafe static X509Stores _machineStore
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509StoreManager.NativeFieldInfoPtr__machineStore, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Stores>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509StoreManager.NativeFieldInfoPtr__machineStore, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr__userPath;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr__localMachinePath;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr__newUserPath;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr__newLocalMachinePath;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr__userStore;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr__machineStore;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentUserPath_Internal_Static_get_String_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalMachinePath_Internal_Static_get_String_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_get_NewCurrentUserPath_Internal_Static_get_String_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_get_NewLocalMachinePath_Internal_Static_get_String_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentUser_Public_Static_get_X509Stores_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalMachine_Public_Static_get_X509Stores_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_get_TrustedRootCertificates_Public_Static_get_X509CertificateCollection_0;
	}
}
