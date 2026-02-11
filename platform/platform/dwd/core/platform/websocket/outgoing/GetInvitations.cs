using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.outgoing
{
	// Token: 0x02000028 RID: 40
	public class GetInvitations : OutgoingWebSocketMessage
	{
		// Token: 0x06000194 RID: 404 RVA: 0x00002B02 File Offset: 0x00000D02
		// Note: this type is marked as 'beforefieldinit'.
		static GetInvitations()
		{
			Il2CppClassPointerStore<GetInvitations>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.outgoing", "GetInvitations");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetInvitations>.NativeClassPtr);
			GetInvitations.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetInvitations>.NativeClassPtr, 100663593);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000AB74 File Offset: 0x00008D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167838, XrefRangeEnd = 1167841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetInvitations()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetInvitations>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetInvitations.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002B3B File Offset: 0x00000D3B
		public GetInvitations(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
