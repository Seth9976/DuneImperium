using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.outgoing
{
	// Token: 0x02000026 RID: 38
	public class GetBlockedAccounts : OutgoingWebSocketMessage
	{
		// Token: 0x0600018E RID: 398 RVA: 0x00002A7E File Offset: 0x00000C7E
		// Note: this type is marked as 'beforefieldinit'.
		static GetBlockedAccounts()
		{
			Il2CppClassPointerStore<GetBlockedAccounts>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.outgoing", "GetBlockedAccounts");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetBlockedAccounts>.NativeClassPtr);
			GetBlockedAccounts.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetBlockedAccounts>.NativeClassPtr, 100663591);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000AAFC File Offset: 0x00008CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167832, XrefRangeEnd = 1167835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetBlockedAccounts()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetBlockedAccounts>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetBlockedAccounts.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002AB7 File Offset: 0x00000CB7
		public GetBlockedAccounts(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
