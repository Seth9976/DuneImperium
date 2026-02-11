using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001D2 RID: 466
	public class NetRes : Object
	{
		// Token: 0x06001CBC RID: 7356 RVA: 0x0008C240 File Offset: 0x0008A440
		// Note: this type is marked as 'beforefieldinit'.
		static NetRes()
		{
			Il2CppClassPointerStore<NetRes>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "NetRes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetRes>.NativeClassPtr);
			NetRes.NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_String_WebExceptionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRes>.NativeClassPtr, 100667696);
			NetRes.NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_WebExceptionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRes>.NativeClassPtr, 100667697);
			NetRes.NativeMethodInfoPtr_GetWebStatusCodeString_Public_Static_String_FtpStatusCode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetRes>.NativeClassPtr, 100667698);
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x0008C2AC File Offset: 0x0008A4AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 476257, RefRangeEnd = 476259, XrefRangeStart = 476246, XrefRangeEnd = 476257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetWebStatusString(string Res, WebExceptionStatus Status)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRes.NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_String_WebExceptionStatus_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x0008C2F8 File Offset: 0x0008A4F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 476264, RefRangeEnd = 476265, XrefRangeStart = 476259, XrefRangeEnd = 476264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetWebStatusString(WebExceptionStatus Status)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRes.NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_WebExceptionStatus_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x0008C330 File Offset: 0x0008A530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 476284, RefRangeEnd = 476285, XrefRangeStart = 476265, XrefRangeEnd = 476284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetWebStatusCodeString(FtpStatusCode statusCode, string statusDescription)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref statusCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(statusDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetRes.NativeMethodInfoPtr_GetWebStatusCodeString_Public_Static_String_FtpStatusCode_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x0000C393 File Offset: 0x0000A593
		public NetRes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040016D7 RID: 5847
		private static readonly IntPtr NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_String_WebExceptionStatus_0;

		// Token: 0x040016D8 RID: 5848
		private static readonly IntPtr NativeMethodInfoPtr_GetWebStatusString_Public_Static_String_WebExceptionStatus_0;

		// Token: 0x040016D9 RID: 5849
		private static readonly IntPtr NativeMethodInfoPtr_GetWebStatusCodeString_Public_Static_String_FtpStatusCode_String_0;
	}
}
