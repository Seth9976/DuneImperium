using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.outgoing
{
	// Token: 0x02000023 RID: 35
	public class CreateInvitationByAccountID : OutgoingWebSocketMessage
	{
		// Token: 0x06000185 RID: 389 RVA: 0x000029B8 File Offset: 0x00000BB8
		// Note: this type is marked as 'beforefieldinit'.
		static CreateInvitationByAccountID()
		{
			Il2CppClassPointerStore<CreateInvitationByAccountID>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.outgoing", "CreateInvitationByAccountID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateInvitationByAccountID>.NativeClassPtr);
			CreateInvitationByAccountID.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInvitationByAccountID>.NativeClassPtr, 100663588);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000AA04 File Offset: 0x00008C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167801, XrefRangeEnd = 1167810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateInvitationByAccountID(string accountID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateInvitationByAccountID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInvitationByAccountID.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000029F1 File Offset: 0x00000BF1
		public CreateInvitationByAccountID(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
