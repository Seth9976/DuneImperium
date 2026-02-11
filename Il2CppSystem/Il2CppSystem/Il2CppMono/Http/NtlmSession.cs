using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Protocol.Ntlm;
using Il2CppSystem;
using Il2CppSystem.Net;

namespace Il2CppMono.Http
{
	// Token: 0x02000025 RID: 37
	public class NtlmSession : Object
	{
		// Token: 0x0600023A RID: 570 RVA: 0x00023858 File Offset: 0x00021A58
		// Note: this type is marked as 'beforefieldinit'.
		static NtlmSession()
		{
			Il2CppClassPointerStore<NtlmSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Http", "NtlmSession");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NtlmSession>.NativeClassPtr);
			NtlmSession.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NtlmSession>.NativeClassPtr, "message");
			NtlmSession.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmSession>.NativeClassPtr, 100663691);
			NtlmSession.NativeMethodInfoPtr_Authenticate_Public_Authorization_String_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmSession>.NativeClassPtr, 100663692);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000238C4 File Offset: 0x00021AC4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NtlmSession()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NtlmSession>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NtlmSession.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00023900 File Offset: 0x00021B00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429293, RefRangeEnd = 429294, XrefRangeStart = 429240, XrefRangeEnd = 429293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(challenge);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(webRequest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NtlmSession.NativeMethodInfoPtr_Authenticate_Public_Authorization_String_WebRequest_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002D40 File Offset: 0x00000F40
		public NtlmSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00023974 File Offset: 0x00021B74
		// (set) Token: 0x0600023F RID: 575 RVA: 0x00002D49 File Offset: 0x00000F49
		public unsafe MessageBase message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NtlmSession.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NtlmSession.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_Authenticate_Public_Authorization_String_WebRequest_ICredentials_0;
	}
}
