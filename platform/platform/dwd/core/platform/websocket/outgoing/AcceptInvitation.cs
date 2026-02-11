using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.outgoing
{
	// Token: 0x0200001E RID: 30
	public class AcceptInvitation : OutgoingWebSocketMessage
	{
		// Token: 0x06000175 RID: 373 RVA: 0x000028A7 File Offset: 0x00000AA7
		// Note: this type is marked as 'beforefieldinit'.
		static AcceptInvitation()
		{
			Il2CppClassPointerStore<AcceptInvitation>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.outgoing", "AcceptInvitation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AcceptInvitation>.NativeClassPtr);
			AcceptInvitation.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcceptInvitation>.NativeClassPtr, 100663582);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000A7C0 File Offset: 0x000089C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167748, XrefRangeEnd = 1167757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AcceptInvitation(string accountId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AcceptInvitation>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcceptInvitation.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000028E0 File Offset: 0x00000AE0
		public AcceptInvitation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
