using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x0200001C RID: 28
	public static class ProviderAliasUtilities : Object
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x00002781 File Offset: 0x00000981
		// Note: this type is marked as 'beforefieldinit'.
		static ProviderAliasUtilities()
		{
			Il2CppClassPointerStore<ProviderAliasUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.dll", "Microsoft.Extensions.Logging", "ProviderAliasUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProviderAliasUtilities>.NativeClassPtr);
			ProviderAliasUtilities.NativeMethodInfoPtr_GetAlias_Internal_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderAliasUtilities>.NativeClassPtr, 100663379);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000538C File Offset: 0x0000358C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1264440, RefRangeEnd = 1264441, XrefRangeStart = 1264421, XrefRangeEnd = 1264440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAlias(Type providerType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(providerType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderAliasUtilities.NativeMethodInfoPtr_GetAlias_Internal_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000027BA File Offset: 0x000009BA
		public ProviderAliasUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_GetAlias_Internal_Static_String_Type_0;
	}
}
