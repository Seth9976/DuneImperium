using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text.RegularExpressions;

namespace UnityEngineInternal
{
	// Token: 0x02000002 RID: 2
	public static class WebRequestUtils : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002738 File Offset: 0x00000938
		// Note: this type is marked as 'beforefieldinit'.
		static WebRequestUtils()
		{
			Il2CppClassPointerStore<WebRequestUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngineInternal", "WebRequestUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestUtils>.NativeClassPtr);
			WebRequestUtils.NativeFieldInfoPtr_domainRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestUtils>.NativeClassPtr, "domainRegex");
			WebRequestUtils.NativeMethodInfoPtr_RedirectTo_Internal_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestUtils>.NativeClassPtr, 100663297);
			WebRequestUtils.NativeMethodInfoPtr_MakeInitialUrl_Internal_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestUtils>.NativeClassPtr, 100663298);
			WebRequestUtils.NativeMethodInfoPtr_MakeUriString_Internal_Static_String_Uri_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestUtils>.NativeClassPtr, 100663299);
			WebRequestUtils.NativeMethodInfoPtr_URLDecode_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestUtils>.NativeClassPtr, 100663300);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000027CC File Offset: 0x000009CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246589, XrefRangeEnd = 1246606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RedirectTo(string baseUri, string redirectUri)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(redirectUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestUtils.NativeMethodInfoPtr_RedirectTo_Internal_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000281C File Offset: 0x00000A1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1246647, RefRangeEnd = 1246648, XrefRangeStart = 1246606, XrefRangeEnd = 1246647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MakeInitialUrl(string targetUrl, string localUrl)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetUrl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localUrl);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestUtils.NativeMethodInfoPtr_MakeInitialUrl_Internal_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000286C File Offset: 0x00000A6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1246716, RefRangeEnd = 1246719, XrefRangeStart = 1246648, XrefRangeEnd = 1246716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MakeUriString(Uri targetUri, string targetUrl, bool prependProtocol)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetUrl);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prependProtocol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestUtils.NativeMethodInfoPtr_MakeUriString_Internal_Static_String_Uri_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000028C8 File Offset: 0x00000AC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1246741, RefRangeEnd = 1246743, XrefRangeStart = 1246719, XrefRangeEnd = 1246741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string URLDecode(string encoded)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(encoded);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestUtils.NativeMethodInfoPtr_URLDecode_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		public WebRequestUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002904 File Offset: 0x00000B04
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static Regex domainRegex
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebRequestUtils.NativeFieldInfoPtr_domainRegex, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebRequestUtils.NativeFieldInfoPtr_domainRegex, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_domainRegex;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_RedirectTo_Internal_Static_String_String_String_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_MakeInitialUrl_Internal_Static_String_String_String_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_MakeUriString_Internal_Static_String_Uri_String_Boolean_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_URLDecode_Private_Static_String_String_0;
	}
}
