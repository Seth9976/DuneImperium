using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.data.decks
{
	// Token: 0x020000DF RID: 223
	public static class Decks : Object
	{
		// Token: 0x06000F78 RID: 3960 RVA: 0x0009A1C0 File Offset: 0x000983C0
		// Note: this type is marked as 'beforefieldinit'.
		static Decks()
		{
			Il2CppClassPointerStore<Decks>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.decks", "Decks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Decks>.NativeClassPtr);
			Decks.NativeMethodInfoPtr_EpicStarterDeck_Public_Static_IEnumerable_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decks>.NativeClassPtr, 100666011);
			Decks.NativeMethodInfoPtr_ImmortalityStarterDeck_Public_Static_IEnumerable_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decks>.NativeClassPtr, 100666012);
			Decks.NativeMethodInfoPtr_LeaderBaseSetDeck_Public_Static_IEnumerable_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decks>.NativeClassPtr, 100666013);
			Decks.NativeMethodInfoPtr_StandardReserveDeck_Public_Static_IEnumerable_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decks>.NativeClassPtr, 100666014);
			Decks.NativeMethodInfoPtr_StandardStarterDeck_Public_Static_IEnumerable_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decks>.NativeClassPtr, 100666015);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x0009A254 File Offset: 0x00098454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76973, RefRangeEnd = 76974, XrefRangeStart = 76909, XrefRangeEnd = 76973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<ArchetypeID> EpicStarterDeck()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decks.NativeMethodInfoPtr_EpicStarterDeck_Public_Static_IEnumerable_1_ArchetypeID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ArchetypeID>>(intPtr3) : null;
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x0009A288 File Offset: 0x00098488
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 77030, RefRangeEnd = 77039, XrefRangeStart = 76974, XrefRangeEnd = 77030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<ArchetypeID> ImmortalityStarterDeck()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decks.NativeMethodInfoPtr_ImmortalityStarterDeck_Public_Static_IEnumerable_1_ArchetypeID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ArchetypeID>>(intPtr3) : null;
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x0009A2BC File Offset: 0x000984BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77108, RefRangeEnd = 77109, XrefRangeStart = 77039, XrefRangeEnd = 77108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<ArchetypeID> LeaderBaseSetDeck()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decks.NativeMethodInfoPtr_LeaderBaseSetDeck_Public_Static_IEnumerable_1_ArchetypeID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ArchetypeID>>(intPtr3) : null;
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x0009A2F0 File Offset: 0x000984F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77133, RefRangeEnd = 77134, XrefRangeStart = 77109, XrefRangeEnd = 77133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<ArchetypeID> StandardReserveDeck()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decks.NativeMethodInfoPtr_StandardReserveDeck_Public_Static_IEnumerable_1_ArchetypeID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ArchetypeID>>(intPtr3) : null;
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x0009A324 File Offset: 0x00098524
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 77190, RefRangeEnd = 77199, XrefRangeStart = 77134, XrefRangeEnd = 77190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<ArchetypeID> StandardStarterDeck()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decks.NativeMethodInfoPtr_StandardStarterDeck_Public_Static_IEnumerable_1_ArchetypeID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ArchetypeID>>(intPtr3) : null;
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00008356 File Offset: 0x00006556
		public Decks(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeMethodInfoPtr_EpicStarterDeck_Public_Static_IEnumerable_1_ArchetypeID_0;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeMethodInfoPtr_ImmortalityStarterDeck_Public_Static_IEnumerable_1_ArchetypeID_0;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeMethodInfoPtr_LeaderBaseSetDeck_Public_Static_IEnumerable_1_ArchetypeID_0;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeMethodInfoPtr_StandardReserveDeck_Public_Static_IEnumerable_1_ArchetypeID_0;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeMethodInfoPtr_StandardStarterDeck_Public_Static_IEnumerable_1_ArchetypeID_0;
	}
}
