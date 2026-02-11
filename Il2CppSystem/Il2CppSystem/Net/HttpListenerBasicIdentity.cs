using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Security.Principal;

namespace Il2CppSystem.Net
{
	// Token: 0x020001FB RID: 507
	public class HttpListenerBasicIdentity : GenericIdentity
	{
		// Token: 0x06001FCE RID: 8142 RVA: 0x0009770C File Offset: 0x0009590C
		// Note: this type is marked as 'beforefieldinit'.
		static HttpListenerBasicIdentity()
		{
			Il2CppClassPointerStore<HttpListenerBasicIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpListenerBasicIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpListenerBasicIdentity>.NativeClassPtr);
			HttpListenerBasicIdentity.NativeFieldInfoPtr_password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpListenerBasicIdentity>.NativeClassPtr, "password");
			HttpListenerBasicIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpListenerBasicIdentity>.NativeClassPtr, 100668102);
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x00097764 File Offset: 0x00095964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480580, XrefRangeEnd = 480584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpListenerBasicIdentity(string username, string password)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpListenerBasicIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpListenerBasicIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x0000D92F File Offset: 0x0000BB2F
		public HttpListenerBasicIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x000977C4 File Offset: 0x000959C4
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x0000D938 File Offset: 0x0000BB38
		public unsafe string password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerBasicIdentity.NativeFieldInfoPtr_password);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpListenerBasicIdentity.NativeFieldInfoPtr_password), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001902 RID: 6402
		private static readonly IntPtr NativeFieldInfoPtr_password;

		// Token: 0x04001903 RID: 6403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
	}
}
