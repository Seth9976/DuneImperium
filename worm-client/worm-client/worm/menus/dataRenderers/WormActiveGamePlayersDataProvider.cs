using System;
using boardgames.datarenderers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.menus.dataRenderers
{
	// Token: 0x02000080 RID: 128
	public class WormActiveGamePlayersDataProvider : ActiveGamePlayersDataProvider
	{
		// Token: 0x060004F5 RID: 1269 RVA: 0x0002805C File Offset: 0x0002625C
		// Note: this type is marked as 'beforefieldinit'.
		static WormActiveGamePlayersDataProvider()
		{
			Il2CppClassPointerStore<WormActiveGamePlayersDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormActiveGamePlayersDataProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormActiveGamePlayersDataProvider>.NativeClassPtr);
			WormActiveGamePlayersDataProvider.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActiveGamePlayersDataProvider>.NativeClassPtr, 100664022);
			WormActiveGamePlayersDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormActiveGamePlayersDataProvider>.NativeClassPtr, 100664023);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x000280B4 File Offset: 0x000262B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694536, XrefRangeEnd = 694631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormActiveGamePlayersDataProvider.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x000280F0 File Offset: 0x000262F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694631, XrefRangeEnd = 694632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormActiveGamePlayersDataProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormActiveGamePlayersDataProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormActiveGamePlayersDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x000046F0 File Offset: 0x000028F0
		public WormActiveGamePlayersDataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
