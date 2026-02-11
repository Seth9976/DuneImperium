using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text.RegularExpressions;

namespace UnityEngine.Localization
{
	// Token: 0x0200001E RID: 30
	public static class StringExtensionMethods : Object
	{
		// Token: 0x06000195 RID: 405 RVA: 0x0000F0AC File Offset: 0x0000D2AC
		// Note: this type is marked as 'beforefieldinit'.
		static StringExtensionMethods()
		{
			Il2CppClassPointerStore<StringExtensionMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "StringExtensionMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringExtensionMethods>.NativeClassPtr);
			StringExtensionMethods.NativeFieldInfoPtr_s_WhitespaceRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringExtensionMethods>.NativeClassPtr, "s_WhitespaceRegex");
			StringExtensionMethods.NativeMethodInfoPtr_ReplaceWhiteSpaces_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringExtensionMethods>.NativeClassPtr, 100663592);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000F104 File Offset: 0x0000D304
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1066603, RefRangeEnd = 1066605, XrefRangeStart = 1066587, XrefRangeEnd = 1066603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReplaceWhiteSpaces(this string str, string replacement = "")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(replacement);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringExtensionMethods.NativeMethodInfoPtr_ReplaceWhiteSpaces_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002A46 File Offset: 0x00000C46
		public StringExtensionMethods(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0000F154 File Offset: 0x0000D354
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00002A4F File Offset: 0x00000C4F
		public unsafe static Regex s_WhitespaceRegex
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringExtensionMethods.NativeFieldInfoPtr_s_WhitespaceRegex, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringExtensionMethods.NativeFieldInfoPtr_s_WhitespaceRegex, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeFieldInfoPtr_s_WhitespaceRegex;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceWhiteSpaces_Public_Static_String_String_String_0;
	}
}
