using System;
using dwd.core.platform.authentication;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.outgoing
{
	// Token: 0x02000020 RID: 32
	public class Authenticate : OutgoingWebSocketMessage
	{
		// Token: 0x0600017B RID: 379 RVA: 0x0000A86C File Offset: 0x00008A6C
		// Note: this type is marked as 'beforefieldinit'.
		static Authenticate()
		{
			Il2CppClassPointerStore<Authenticate>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.outgoing", "Authenticate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Authenticate>.NativeClassPtr);
			Authenticate.NativeMethodInfoPtr__ctor_Public_Void_String_PlatformToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Authenticate>.NativeClassPtr, 100663584);
			Authenticate.NativeMethodInfoPtr_get_RequiresAuthentication_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Authenticate>.NativeClassPtr, 100663585);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000A8C4 File Offset: 0x00008AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167770, XrefRangeEnd = 1167783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Authenticate(string client, PlatformToken token)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Authenticate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(client);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(token);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Authenticate.NativeMethodInfoPtr__ctor_Public_Void_String_PlatformToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000A924 File Offset: 0x00008B24
		public unsafe override bool RequiresAuthentication
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Authenticate.NativeMethodInfoPtr_get_RequiresAuthentication_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000292B File Offset: 0x00000B2B
		public Authenticate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_PlatformToken_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_get_RequiresAuthentication_Public_Virtual_get_Boolean_0;
	}
}
