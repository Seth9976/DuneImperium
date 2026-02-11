using System;
using Canis.entities.ai;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.canis.entities
{
	// Token: 0x0200002B RID: 43
	public static class WormImperiumExtensions : Object
	{
		// Token: 0x06000386 RID: 902 RVA: 0x000036F1 File Offset: 0x000018F1
		// Note: this type is marked as 'beforefieldinit'.
		static WormImperiumExtensions()
		{
			Il2CppClassPointerStore<WormImperiumExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormImperiumExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormImperiumExtensions>.NativeClassPtr);
			WormImperiumExtensions.NativeMethodInfoPtr_GetValueForRevealAbilities_Public_Static_AIValueSummer_1_Double_WormImperiumPlayable_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumExtensions>.NativeClassPtr, 100664090);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00077364 File Offset: 0x00075564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38328, RefRangeEnd = 38329, XrefRangeStart = 38292, XrefRangeEnd = 38328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AIValueSummer<double> GetValueForRevealAbilities(this WormImperiumPlayable card, WormPlayer player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumExtensions.NativeMethodInfoPtr_GetValueForRevealAbilities_Public_Static_AIValueSummer_1_Double_WormImperiumPlayable_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000372A File Offset: 0x0000192A
		public WormImperiumExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_GetValueForRevealAbilities_Public_Static_AIValueSummer_1_Double_WormImperiumPlayable_WormPlayer_0;
	}
}
