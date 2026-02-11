using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Specialized;

namespace Utils
{
	// Token: 0x0200003A RID: 58
	public static class HTTPUtils : Object
	{
		// Token: 0x0600026A RID: 618 RVA: 0x00002A86 File Offset: 0x00000C86
		// Note: this type is marked as 'beforefieldinit'.
		static HTTPUtils()
		{
			Il2CppClassPointerStore<HTTPUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Utils", "HTTPUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTTPUtils>.NativeClassPtr);
			HTTPUtils.NativeMethodInfoPtr_ParseQueryString_Public_Static_NameValueCollection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPUtils>.NativeClassPtr, 100663881);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000E994 File Offset: 0x0000CB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184445, XrefRangeEnd = 1184469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NameValueCollection ParseQueryString(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPUtils.NativeMethodInfoPtr_ParseQueryString_Public_Static_NameValueCollection_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameValueCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002ABF File Offset: 0x00000CBF
		public HTTPUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_ParseQueryString_Public_Static_NameValueCollection_String_0;
	}
}
