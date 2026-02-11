using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Btls
{
	// Token: 0x02000048 RID: 72
	public static class MonoBtlsX509StoreManager : Object
	{
		// Token: 0x06000439 RID: 1081 RVA: 0x0002C4B0 File Offset: 0x0002A6B0
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsX509StoreManager()
		{
			Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsX509StoreManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr);
			MonoBtlsX509StoreManager.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr, "initialized");
			MonoBtlsX509StoreManager.NativeFieldInfoPtr_machineTrustedRootPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr, "machineTrustedRootPath");
			MonoBtlsX509StoreManager.NativeFieldInfoPtr_machineIntermediateCAPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr, "machineIntermediateCAPath");
			MonoBtlsX509StoreManager.NativeFieldInfoPtr_machineUntrustedPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr, "machineUntrustedPath");
			MonoBtlsX509StoreManager.NativeFieldInfoPtr_userTrustedRootPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr, "userTrustedRootPath");
			MonoBtlsX509StoreManager.NativeFieldInfoPtr_userIntermediateCAPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr, "userIntermediateCAPath");
			MonoBtlsX509StoreManager.NativeFieldInfoPtr_userUntrustedPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr, "userUntrustedPath");
			MonoBtlsX509StoreManager.NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr, 100664072);
			MonoBtlsX509StoreManager.NativeMethodInfoPtr_DoInitialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr, 100664073);
			MonoBtlsX509StoreManager.NativeMethodInfoPtr_GetStorePath_Public_Static_String_MonoBtlsX509StoreType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreManager>.NativeClassPtr, 100664074);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0002C5A8 File Offset: 0x0002A7A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 432456, RefRangeEnd = 432457, XrefRangeStart = 432406, XrefRangeEnd = 432456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreManager.NativeMethodInfoPtr_Initialize_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0002C5D0 File Offset: 0x0002A7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 432457, XrefRangeEnd = 432496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoInitialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreManager.NativeMethodInfoPtr_DoInitialize_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0002C5F8 File Offset: 0x0002A7F8
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 432499, RefRangeEnd = 432521, XrefRangeStart = 432496, XrefRangeEnd = 432499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStorePath(MonoBtlsX509StoreType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509StoreManager.NativeMethodInfoPtr_GetStorePath_Public_Static_String_MonoBtlsX509StoreType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00003531 File Offset: 0x00001731
		public MonoBtlsX509StoreManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x0002C630 File Offset: 0x0002A830
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x0000353A File Offset: 0x0000173A
		public unsafe static bool initialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(MonoBtlsX509StoreManager.NativeFieldInfoPtr_initialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoBtlsX509StoreManager.NativeFieldInfoPtr_initialized, (void*)(&value));
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x0002C64C File Offset: 0x0002A84C
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x00003548 File Offset: 0x00001748
		public unsafe static string machineTrustedRootPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoBtlsX509StoreManager.NativeFieldInfoPtr_machineTrustedRootPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoBtlsX509StoreManager.NativeFieldInfoPtr_machineTrustedRootPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0002C66C File Offset: 0x0002A86C
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x0000355A File Offset: 0x0000175A
		public unsafe static string machineIntermediateCAPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoBtlsX509StoreManager.NativeFieldInfoPtr_machineIntermediateCAPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoBtlsX509StoreManager.NativeFieldInfoPtr_machineIntermediateCAPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x0002C68C File Offset: 0x0002A88C
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x0000356C File Offset: 0x0000176C
		public unsafe static string machineUntrustedPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoBtlsX509StoreManager.NativeFieldInfoPtr_machineUntrustedPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoBtlsX509StoreManager.NativeFieldInfoPtr_machineUntrustedPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x0002C6AC File Offset: 0x0002A8AC
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x0000357E File Offset: 0x0000177E
		public unsafe static string userTrustedRootPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoBtlsX509StoreManager.NativeFieldInfoPtr_userTrustedRootPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoBtlsX509StoreManager.NativeFieldInfoPtr_userTrustedRootPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x0002C6CC File Offset: 0x0002A8CC
		// (set) Token: 0x06000449 RID: 1097 RVA: 0x00003590 File Offset: 0x00001790
		public unsafe static string userIntermediateCAPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoBtlsX509StoreManager.NativeFieldInfoPtr_userIntermediateCAPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoBtlsX509StoreManager.NativeFieldInfoPtr_userIntermediateCAPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x0002C6EC File Offset: 0x0002A8EC
		// (set) Token: 0x0600044B RID: 1099 RVA: 0x000035A2 File Offset: 0x000017A2
		public unsafe static string userUntrustedPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoBtlsX509StoreManager.NativeFieldInfoPtr_userUntrustedPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoBtlsX509StoreManager.NativeFieldInfoPtr_userUntrustedPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeFieldInfoPtr_machineTrustedRootPath;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeFieldInfoPtr_machineIntermediateCAPath;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeFieldInfoPtr_machineUntrustedPath;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeFieldInfoPtr_userTrustedRootPath;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeFieldInfoPtr_userIntermediateCAPath;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeFieldInfoPtr_userUntrustedPath;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_DoInitialize_Private_Static_Void_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_GetStorePath_Public_Static_String_MonoBtlsX509StoreType_0;
	}
}
