using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace worm.menus.components
{
	// Token: 0x020000A1 RID: 161
	public class WormRankedBackButton : MonoBehaviour
	{
		// Token: 0x06000651 RID: 1617 RVA: 0x0002BE40 File Offset: 0x0002A040
		// Note: this type is marked as 'beforefieldinit'.
		static WormRankedBackButton()
		{
			Il2CppClassPointerStore<WormRankedBackButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.components", "WormRankedBackButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRankedBackButton>.NativeClassPtr);
			WormRankedBackButton.NativeMethodInfoPtr_Event_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRankedBackButton>.NativeClassPtr, 100664186);
			WormRankedBackButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRankedBackButton>.NativeClassPtr, 100664187);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0002BE98 File Offset: 0x0002A098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696226, XrefRangeEnd = 696231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRankedBackButton.NativeMethodInfoPtr_Event_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0002BECC File Offset: 0x0002A0CC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormRankedBackButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRankedBackButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRankedBackButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x000052B2 File Offset: 0x000034B2
		public WormRankedBackButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeMethodInfoPtr_Event_Back_Public_Void_0;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
