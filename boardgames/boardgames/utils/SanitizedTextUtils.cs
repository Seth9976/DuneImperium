using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace boardgames.utils
{
	// Token: 0x0200010E RID: 270
	public static class SanitizedTextUtils : Object
	{
		// Token: 0x06000E44 RID: 3652 RVA: 0x00008A57 File Offset: 0x00006C57
		// Note: this type is marked as 'beforefieldinit'.
		static SanitizedTextUtils()
		{
			Il2CppClassPointerStore<SanitizedTextUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.utils", "SanitizedTextUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SanitizedTextUtils>.NativeClassPtr);
			SanitizedTextUtils.NativeMethodInfoPtr_SanitizedUsername_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SanitizedTextUtils>.NativeClassPtr, 100665328);
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x0003C59C File Offset: 0x0003A79C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 996255, RefRangeEnd = 996260, XrefRangeStart = 996252, XrefRangeEnd = 996255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SanitizedUsername(string accountName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SanitizedTextUtils.NativeMethodInfoPtr_SanitizedUsername_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x00008A90 File Offset: 0x00006C90
		public SanitizedTextUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeMethodInfoPtr_SanitizedUsername_Public_Static_String_String_0;
	}
}
