using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.outgoing
{
	// Token: 0x02000029 RID: 41
	public class GetProfile : OutgoingWebSocketMessage
	{
		// Token: 0x06000197 RID: 407 RVA: 0x00002B44 File Offset: 0x00000D44
		// Note: this type is marked as 'beforefieldinit'.
		static GetProfile()
		{
			Il2CppClassPointerStore<GetProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.outgoing", "GetProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetProfile>.NativeClassPtr);
			GetProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetProfile>.NativeClassPtr, 100663594);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000ABB0 File Offset: 0x00008DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167841, XrefRangeEnd = 1167844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002B7D File Offset: 0x00000D7D
		public GetProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
