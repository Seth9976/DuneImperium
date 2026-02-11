using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x0200018E RID: 398
	public static class HttpStatusDescription : Object
	{
		// Token: 0x06001851 RID: 6225 RVA: 0x0007B988 File Offset: 0x00079B88
		// Note: this type is marked as 'beforefieldinit'.
		static HttpStatusDescription()
		{
			Il2CppClassPointerStore<HttpStatusDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpStatusDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpStatusDescription>.NativeClassPtr);
			HttpStatusDescription.NativeMethodInfoPtr_Get_Internal_Static_String_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpStatusDescription>.NativeClassPtr, 100667138);
			HttpStatusDescription.NativeMethodInfoPtr_Get_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpStatusDescription>.NativeClassPtr, 100667139);
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x0007B9E0 File Offset: 0x00079BE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 470775, RefRangeEnd = 470779, XrefRangeStart = 470774, XrefRangeEnd = 470775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Get(HttpStatusCode code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpStatusDescription.NativeMethodInfoPtr_Get_Internal_Static_String_HttpStatusCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x0007BA18 File Offset: 0x00079C18
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 470840, RefRangeEnd = 470844, XrefRangeStart = 470779, XrefRangeEnd = 470840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Get(int code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpStatusDescription.NativeMethodInfoPtr_Get_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x0000A778 File Offset: 0x00008978
		public HttpStatusDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeMethodInfoPtr_Get_Internal_Static_String_HttpStatusCode_0;

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeMethodInfoPtr_Get_Internal_Static_String_Int32_0;
	}
}
