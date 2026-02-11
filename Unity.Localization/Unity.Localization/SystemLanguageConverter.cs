using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization
{
	// Token: 0x0200001F RID: 31
	public static class SystemLanguageConverter : Object
	{
		// Token: 0x0600019A RID: 410 RVA: 0x00002A61 File Offset: 0x00000C61
		// Note: this type is marked as 'beforefieldinit'.
		static SystemLanguageConverter()
		{
			Il2CppClassPointerStore<SystemLanguageConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "SystemLanguageConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemLanguageConverter>.NativeClassPtr);
			SystemLanguageConverter.NativeMethodInfoPtr_GetSystemLanguageCultureCode_Internal_Static_String_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemLanguageConverter>.NativeClassPtr, 100663594);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000F17C File Offset: 0x0000D37C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1066650, RefRangeEnd = 1066653, XrefRangeStart = 1066605, XrefRangeEnd = 1066650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSystemLanguageCultureCode(SystemLanguage lang)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lang;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemLanguageConverter.NativeMethodInfoPtr_GetSystemLanguageCultureCode_Internal_Static_String_SystemLanguage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002A9A File Offset: 0x00000C9A
		public SystemLanguageConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemLanguageCultureCode_Internal_Static_String_SystemLanguage_0;
	}
}
