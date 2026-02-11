using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace ImaginationOverflow.UniversalDeepLinking.Providers
{
	// Token: 0x02000017 RID: 23
	public class WindowsRegistryHelper : Object
	{
		// Token: 0x06000120 RID: 288 RVA: 0x00006948 File Offset: 0x00004B48
		// Note: this type is marked as 'beforefieldinit'.
		static WindowsRegistryHelper()
		{
			Il2CppClassPointerStore<WindowsRegistryHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UniversalDeepLinking.dll", "ImaginationOverflow.UniversalDeepLinking.Providers", "WindowsRegistryHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsRegistryHelper>.NativeClassPtr);
			WindowsRegistryHelper.NativeMethodInfoPtr_GetSteamPath_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRegistryHelper>.NativeClassPtr, 100663490);
			WindowsRegistryHelper.NativeMethodInfoPtr_SetProtocol_Public_Static_Boolean_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRegistryHelper>.NativeClassPtr, 100663491);
			WindowsRegistryHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRegistryHelper>.NativeClassPtr, 100663492);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000069B4 File Offset: 0x00004BB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1241537, RefRangeEnd = 1241539, XrefRangeStart = 1241498, XrefRangeEnd = 1241537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSteamPath()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsRegistryHelper.NativeMethodInfoPtr_GetSteamPath_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000069E0 File Offset: 0x00004BE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1241607, RefRangeEnd = 1241608, XrefRangeStart = 1241539, XrefRangeEnd = 1241607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetProtocol(string activationProtocol, string executingExe, string exeArgs, string launcherArgs = "")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(activationProtocol);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(executingExe);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(exeArgs);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(launcherArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsRegistryHelper.NativeMethodInfoPtr_SetProtocol_Public_Static_Boolean_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00006A58 File Offset: 0x00004C58
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowsRegistryHelper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowsRegistryHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsRegistryHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000263E File Offset: 0x0000083E
		public WindowsRegistryHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamPath_Public_Static_String_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_SetProtocol_Public_Static_Boolean_String_String_String_String_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
