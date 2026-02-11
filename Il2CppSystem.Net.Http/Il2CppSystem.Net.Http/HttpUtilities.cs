using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.Http
{
	// Token: 0x02000002 RID: 2
	public static class HttpUtilities : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00004324 File Offset: 0x00002524
		// Note: this type is marked as 'beforefieldinit'.
		static HttpUtilities()
		{
			Il2CppClassPointerStore<HttpUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http", "HttpUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpUtilities>.NativeClassPtr);
			HttpUtilities.NativeMethodInfoPtr_IsSupportedSecureScheme_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpUtilities>.NativeClassPtr, 100663297);
			HttpUtilities.NativeMethodInfoPtr_IsSecureWebSocketScheme_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpUtilities>.NativeClassPtr, 100663298);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000437C File Offset: 0x0000257C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170118, XrefRangeEnd = 1170121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSupportedSecureScheme(string scheme)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scheme);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpUtilities.NativeMethodInfoPtr_IsSupportedSecureScheme_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000043C0 File Offset: 0x000025C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170121, XrefRangeEnd = 1170124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSecureWebSocketScheme(string scheme)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scheme);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpUtilities.NativeMethodInfoPtr_IsSecureWebSocketScheme_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		public HttpUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_IsSupportedSecureScheme_Internal_Static_Boolean_String_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_IsSecureWebSocketScheme_Internal_Static_Boolean_String_0;
	}
}
