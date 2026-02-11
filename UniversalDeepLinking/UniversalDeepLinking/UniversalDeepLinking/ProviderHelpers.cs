using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace ImaginationOverflow.UniversalDeepLinking
{
	// Token: 0x02000011 RID: 17
	public static class ProviderHelpers : Object
	{
		// Token: 0x060000BE RID: 190 RVA: 0x000054DC File Offset: 0x000036DC
		// Note: this type is marked as 'beforefieldinit'.
		static ProviderHelpers()
		{
			Il2CppClassPointerStore<ProviderHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("UniversalDeepLinking.dll", "ImaginationOverflow.UniversalDeepLinking", "ProviderHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProviderHelpers>.NativeClassPtr);
			ProviderHelpers.NativeFieldInfoPtr_LauncherRelativeFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderHelpers>.NativeClassPtr, "LauncherRelativeFolder");
			ProviderHelpers.NativeFieldInfoPtr_LauncherName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderHelpers>.NativeClassPtr, "LauncherName");
			ProviderHelpers.NativeFieldInfoPtr_LauncherConfigFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderHelpers>.NativeClassPtr, "LauncherConfigFileName");
			ProviderHelpers.NativeFieldInfoPtr_LauncherSharedFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderHelpers>.NativeClassPtr, "LauncherSharedFileName");
			ProviderHelpers.NativeFieldInfoPtr_WindowsConfigFileFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderHelpers>.NativeClassPtr, "WindowsConfigFileFormat");
			ProviderHelpers.NativeFieldInfoPtr__editorLauncherFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderHelpers>.NativeClassPtr, "_editorLauncherFolder");
			ProviderHelpers.NativeMethodInfoPtr_SetWindowsMockLauncherLocation_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderHelpers>.NativeClassPtr, 100663432);
			ProviderHelpers.NativeMethodInfoPtr_GetLauncherFolder_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderHelpers>.NativeClassPtr, 100663433);
			ProviderHelpers.NativeMethodInfoPtr_LauncherFolder_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderHelpers>.NativeClassPtr, 100663434);
			ProviderHelpers.NativeMethodInfoPtr_GetLauncherFullFilename_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderHelpers>.NativeClassPtr, 100663435);
			ProviderHelpers.NativeMethodInfoPtr_GetLauncherConfigFileDirectory_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderHelpers>.NativeClassPtr, 100663436);
			ProviderHelpers.NativeMethodInfoPtr_GetLauncherConfigFullFilename_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderHelpers>.NativeClassPtr, 100663437);
			ProviderHelpers.NativeMethodInfoPtr_GetLauncherSharedFileFullFilename_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderHelpers>.NativeClassPtr, 100663438);
			ProviderHelpers.NativeMethodInfoPtr_GetExecutingPath_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderHelpers>.NativeClassPtr, 100663439);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00005624 File Offset: 0x00003824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240899, XrefRangeEnd = 1240909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetWindowsMockLauncherLocation(string launcherPluginFolder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(launcherPluginFolder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderHelpers.NativeMethodInfoPtr_SetWindowsMockLauncherLocation_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000565C File Offset: 0x0000385C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240909, XrefRangeEnd = 1240913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLauncherFolder()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderHelpers.NativeMethodInfoPtr_GetLauncherFolder_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00005688 File Offset: 0x00003888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240913, XrefRangeEnd = 1240926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string LauncherFolder()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderHelpers.NativeMethodInfoPtr_LauncherFolder_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000056B4 File Offset: 0x000038B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240926, XrefRangeEnd = 1240950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLauncherFullFilename()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderHelpers.NativeMethodInfoPtr_GetLauncherFullFilename_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000056E0 File Offset: 0x000038E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240950, XrefRangeEnd = 1240954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLauncherConfigFileDirectory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderHelpers.NativeMethodInfoPtr_GetLauncherConfigFileDirectory_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000570C File Offset: 0x0000390C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1240964, RefRangeEnd = 1240966, XrefRangeStart = 1240954, XrefRangeEnd = 1240964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLauncherConfigFullFilename()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderHelpers.NativeMethodInfoPtr_GetLauncherConfigFullFilename_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00005738 File Offset: 0x00003938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240966, XrefRangeEnd = 1240976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLauncherSharedFileFullFilename()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderHelpers.NativeMethodInfoPtr_GetLauncherSharedFileFullFilename_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00005764 File Offset: 0x00003964
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1240981, RefRangeEnd = 1240984, XrefRangeStart = 1240976, XrefRangeEnd = 1240981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetExecutingPath()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderHelpers.NativeMethodInfoPtr_GetExecutingPath_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002452 File Offset: 0x00000652
		public ProviderHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00005790 File Offset: 0x00003990
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000245B File Offset: 0x0000065B
		public unsafe static string LauncherRelativeFolder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProviderHelpers.NativeFieldInfoPtr_LauncherRelativeFolder, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProviderHelpers.NativeFieldInfoPtr_LauncherRelativeFolder, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000057B0 File Offset: 0x000039B0
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0000246D File Offset: 0x0000066D
		public unsafe static string LauncherName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProviderHelpers.NativeFieldInfoPtr_LauncherName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProviderHelpers.NativeFieldInfoPtr_LauncherName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000057D0 File Offset: 0x000039D0
		// (set) Token: 0x060000CD RID: 205 RVA: 0x0000247F File Offset: 0x0000067F
		public unsafe static string LauncherConfigFileName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProviderHelpers.NativeFieldInfoPtr_LauncherConfigFileName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProviderHelpers.NativeFieldInfoPtr_LauncherConfigFileName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000057F0 File Offset: 0x000039F0
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00002491 File Offset: 0x00000691
		public unsafe static string LauncherSharedFileName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProviderHelpers.NativeFieldInfoPtr_LauncherSharedFileName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProviderHelpers.NativeFieldInfoPtr_LauncherSharedFileName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00005810 File Offset: 0x00003A10
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x000024A3 File Offset: 0x000006A3
		public unsafe static string WindowsConfigFileFormat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProviderHelpers.NativeFieldInfoPtr_WindowsConfigFileFormat, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProviderHelpers.NativeFieldInfoPtr_WindowsConfigFileFormat, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00005830 File Offset: 0x00003A30
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x000024B5 File Offset: 0x000006B5
		public unsafe static string _editorLauncherFolder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProviderHelpers.NativeFieldInfoPtr__editorLauncherFolder, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProviderHelpers.NativeFieldInfoPtr__editorLauncherFolder, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_LauncherRelativeFolder;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_LauncherName;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_LauncherConfigFileName;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_LauncherSharedFileName;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_WindowsConfigFileFormat;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr__editorLauncherFolder;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_SetWindowsMockLauncherLocation_Public_Static_Void_String_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_GetLauncherFolder_Public_Static_String_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_LauncherFolder_Private_Static_String_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_GetLauncherFullFilename_Public_Static_String_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_GetLauncherConfigFileDirectory_Public_Static_String_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_GetLauncherConfigFullFilename_Public_Static_String_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_GetLauncherSharedFileFullFilename_Public_Static_String_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_GetExecutingPath_Public_Static_String_0;
	}
}
