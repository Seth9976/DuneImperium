using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.outgoing
{
	// Token: 0x02000024 RID: 36
	public class DeclineInvitation : OutgoingWebSocketMessage
	{
		// Token: 0x06000188 RID: 392 RVA: 0x000029FA File Offset: 0x00000BFA
		// Note: this type is marked as 'beforefieldinit'.
		static DeclineInvitation()
		{
			Il2CppClassPointerStore<DeclineInvitation>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.outgoing", "DeclineInvitation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeclineInvitation>.NativeClassPtr);
			DeclineInvitation.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeclineInvitation>.NativeClassPtr, 100663589);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000AA50 File Offset: 0x00008C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167810, XrefRangeEnd = 1167819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeclineInvitation(string accountID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeclineInvitation>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeclineInvitation.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002A33 File Offset: 0x00000C33
		public DeclineInvitation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
