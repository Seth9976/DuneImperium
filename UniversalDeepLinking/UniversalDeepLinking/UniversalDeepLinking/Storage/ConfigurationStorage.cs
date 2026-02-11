using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ImaginationOverflow.UniversalDeepLinking.Storage
{
	// Token: 0x02000013 RID: 19
	public class ConfigurationStorage : Object
	{
		// Token: 0x060000E4 RID: 228 RVA: 0x00005BB8 File Offset: 0x00003DB8
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurationStorage()
		{
			Il2CppClassPointerStore<ConfigurationStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("UniversalDeepLinking.dll", "ImaginationOverflow.UniversalDeepLinking.Storage", "ConfigurationStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationStorage>.NativeClassPtr);
			ConfigurationStorage.NativeFieldInfoPtr_SaveFolders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationStorage>.NativeClassPtr, "SaveFolders");
			ConfigurationStorage.NativeFieldInfoPtr_SaveFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationStorage>.NativeClassPtr, "SaveFile");
			ConfigurationStorage.NativeFieldInfoPtr__fileLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationStorage>.NativeClassPtr, "_fileLocation");
			ConfigurationStorage.NativeMethodInfoPtr_Save_Public_Static_Void_AppLinkingConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationStorage>.NativeClassPtr, 100663454);
			ConfigurationStorage.NativeMethodInfoPtr_Load_Public_Static_AppLinkingConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationStorage>.NativeClassPtr, 100663455);
			ConfigurationStorage.NativeMethodInfoPtr_EnsureDirectories_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationStorage>.NativeClassPtr, 100663456);
			ConfigurationStorage.NativeMethodInfoPtr_GetConfigurationLocation_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationStorage>.NativeClassPtr, 100663457);
			ConfigurationStorage.NativeMethodInfoPtr_CombinePaths_Public_Static_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationStorage>.NativeClassPtr, 100663458);
			ConfigurationStorage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationStorage>.NativeClassPtr, 100663459);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00005C9C File Offset: 0x00003E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241051, XrefRangeEnd = 1241100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Save(AppLinkingConfiguration config)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(config);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationStorage.NativeMethodInfoPtr_Save_Public_Static_Void_AppLinkingConfiguration_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00005CD4 File Offset: 0x00003ED4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1241130, RefRangeEnd = 1241132, XrefRangeStart = 1241100, XrefRangeEnd = 1241130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AppLinkingConfiguration Load()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationStorage.NativeMethodInfoPtr_Load_Public_Static_AppLinkingConfiguration_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AppLinkingConfiguration>(intPtr3) : null;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00005D08 File Offset: 0x00003F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241132, XrefRangeEnd = 1241149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureDirectories()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationStorage.NativeMethodInfoPtr_EnsureDirectories_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00005D30 File Offset: 0x00003F30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1241176, RefRangeEnd = 1241178, XrefRangeStart = 1241149, XrefRangeEnd = 1241176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetConfigurationLocation()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationStorage.NativeMethodInfoPtr_GetConfigurationLocation_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00005D5C File Offset: 0x00003F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241178, XrefRangeEnd = 1241198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CombinePaths([Optional] Il2CppStringArray paths)
		{
			if (paths == null)
			{
				paths = new Il2CppStringArray(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(paths);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationStorage.NativeMethodInfoPtr_CombinePaths_Public_Static_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00005DA8 File Offset: 0x00003FA8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigurationStorage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationStorage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationStorage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000251C File Offset: 0x0000071C
		public static string CombinePaths(params string[] paths)
		{
			return ConfigurationStorage.CombinePaths(new Il2CppStringArray(paths));
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002529 File Offset: 0x00000729
		public ConfigurationStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00005DE4 File Offset: 0x00003FE4
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00002532 File Offset: 0x00000732
		public unsafe static Il2CppStringArray SaveFolders
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConfigurationStorage.NativeFieldInfoPtr_SaveFolders, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfigurationStorage.NativeFieldInfoPtr_SaveFolders, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00005E0C File Offset: 0x0000400C
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00002544 File Offset: 0x00000744
		public unsafe static string SaveFile
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConfigurationStorage.NativeFieldInfoPtr_SaveFile, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfigurationStorage.NativeFieldInfoPtr_SaveFile, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00005E2C File Offset: 0x0000402C
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00002556 File Offset: 0x00000756
		public unsafe static string _fileLocation
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConfigurationStorage.NativeFieldInfoPtr__fileLocation, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfigurationStorage.NativeFieldInfoPtr__fileLocation, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_SaveFolders;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_SaveFile;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeFieldInfoPtr__fileLocation;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_AppLinkingConfiguration_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_AppLinkingConfiguration_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_EnsureDirectories_Private_Static_Void_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_GetConfigurationLocation_Private_Static_String_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_CombinePaths_Public_Static_String_Il2CppStringArray_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200001F RID: 31
		[ObfuscatedName("ImaginationOverflow.UniversalDeepLinking.Storage.ConfigurationStorage+<>O")]
		public static class __O : Object
		{
			// Token: 0x06000182 RID: 386 RVA: 0x00002872 File Offset: 0x00000A72
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<ConfigurationStorage.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigurationStorage>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationStorage.__O>.NativeClassPtr);
				ConfigurationStorage.__O.NativeFieldInfoPtr__0___Combine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationStorage.__O>.NativeClassPtr, "<0>__Combine");
			}

			// Token: 0x06000183 RID: 387 RVA: 0x000028A6 File Offset: 0x00000AA6
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x06000184 RID: 388 RVA: 0x00007D88 File Offset: 0x00005F88
			// (set) Token: 0x06000185 RID: 389 RVA: 0x000028AF File Offset: 0x00000AAF
			public unsafe static Func<string, string, string> _0___Combine
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigurationStorage.__O.NativeFieldInfoPtr__0___Combine, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigurationStorage.__O.NativeFieldInfoPtr__0___Combine, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000108 RID: 264
			private static readonly IntPtr NativeFieldInfoPtr__0___Combine;
		}
	}
}
