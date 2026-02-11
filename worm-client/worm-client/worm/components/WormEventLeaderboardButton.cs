using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.components
{
	// Token: 0x0200007A RID: 122
	public class WormEventLeaderboardButton : Subscriber
	{
		// Token: 0x060004AF RID: 1199 RVA: 0x00027054 File Offset: 0x00025254
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventLeaderboardButton()
		{
			Il2CppClassPointerStore<WormEventLeaderboardButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.components", "WormEventLeaderboardButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventLeaderboardButton>.NativeClassPtr);
			WormEventLeaderboardButton.NativeMethodInfoPtr_Event_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventLeaderboardButton>.NativeClassPtr, 100663967);
			WormEventLeaderboardButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventLeaderboardButton>.NativeClassPtr, 100663968);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000270AC File Offset: 0x000252AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693900, XrefRangeEnd = 693905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Show()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventLeaderboardButton.NativeMethodInfoPtr_Event_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x000270E0 File Offset: 0x000252E0
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventLeaderboardButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventLeaderboardButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventLeaderboardButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0000455A File Offset: 0x0000275A
		public WormEventLeaderboardButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_Event_Show_Public_Void_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
