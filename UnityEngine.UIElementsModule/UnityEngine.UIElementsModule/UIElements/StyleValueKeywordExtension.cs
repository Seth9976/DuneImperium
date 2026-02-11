using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001CF RID: 463
	public static class StyleValueKeywordExtension : Object
	{
		// Token: 0x0600241F RID: 9247 RVA: 0x0000ED64 File Offset: 0x0000CF64
		// Note: this type is marked as 'beforefieldinit'.
		static StyleValueKeywordExtension()
		{
			Il2CppClassPointerStore<StyleValueKeywordExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleValueKeywordExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleValueKeywordExtension>.NativeClassPtr);
			StyleValueKeywordExtension.NativeMethodInfoPtr_ToUssString_Public_Static_String_StyleValueKeyword_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValueKeywordExtension>.NativeClassPtr, 100668780);
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x000A2524 File Offset: 0x000A0724
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 338057, RefRangeEnd = 338062, XrefRangeStart = 338049, XrefRangeEnd = 338057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToUssString(this StyleValueKeyword svk)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref svk;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValueKeywordExtension.NativeMethodInfoPtr_ToUssString_Public_Static_String_StyleValueKeyword_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x0000ED9D File Offset: 0x0000CF9D
		public StyleValueKeywordExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019F3 RID: 6643
		private static readonly IntPtr NativeMethodInfoPtr_ToUssString_Public_Static_String_StyleValueKeyword_0;
	}
}
