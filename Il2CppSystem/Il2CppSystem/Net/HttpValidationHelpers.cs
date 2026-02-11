using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x0200018F RID: 399
	public static class HttpValidationHelpers : Object
	{
		// Token: 0x06001855 RID: 6229 RVA: 0x0007BA50 File Offset: 0x00079C50
		// Note: this type is marked as 'beforefieldinit'.
		static HttpValidationHelpers()
		{
			Il2CppClassPointerStore<HttpValidationHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpValidationHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpValidationHelpers>.NativeClassPtr);
			HttpValidationHelpers.NativeFieldInfoPtr_s_httpTrimCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpValidationHelpers>.NativeClassPtr, "s_httpTrimCharacters");
			HttpValidationHelpers.NativeMethodInfoPtr_IsInvalidMethodOrHeaderString_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpValidationHelpers>.NativeClassPtr, 100667140);
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x0007BAA8 File Offset: 0x00079CA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 470848, RefRangeEnd = 470849, XrefRangeStart = 470844, XrefRangeEnd = 470848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInvalidMethodOrHeaderString(string stringValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpValidationHelpers.NativeMethodInfoPtr_IsInvalidMethodOrHeaderString_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x0000A781 File Offset: 0x00008981
		public HttpValidationHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x0007BAEC File Offset: 0x00079CEC
		// (set) Token: 0x06001859 RID: 6233 RVA: 0x0000A78A File Offset: 0x0000898A
		public unsafe static Il2CppStructArray<char> s_httpTrimCharacters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpValidationHelpers.NativeFieldInfoPtr_s_httpTrimCharacters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpValidationHelpers.NativeFieldInfoPtr_s_httpTrimCharacters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeFieldInfoPtr_s_httpTrimCharacters;

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeMethodInfoPtr_IsInvalidMethodOrHeaderString_Public_Static_Boolean_String_0;
	}
}
