using System;
using Canis;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace lotus
{
	// Token: 0x020000BE RID: 190
	public class GameMetaData : Object
	{
		// Token: 0x060009A2 RID: 2466 RVA: 0x0002FDD0 File Offset: 0x0002DFD0
		// Note: this type is marked as 'beforefieldinit'.
		static GameMetaData()
		{
			Il2CppClassPointerStore<GameMetaData>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "GameMetaData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameMetaData>.NativeClassPtr);
			GameMetaData.NativeFieldInfoPtr_OfflineAccounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMetaData>.NativeClassPtr, "OfflineAccounts");
			GameMetaData.NativeFieldInfoPtr_MatchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMetaData>.NativeClassPtr, "MatchData");
			GameMetaData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMetaData>.NativeClassPtr, 100664870);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0002FE3C File Offset: 0x0002E03C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameMetaData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameMetaData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameMetaData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x000065EF File Offset: 0x000047EF
		public GameMetaData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x0002FE78 File Offset: 0x0002E078
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x000065F8 File Offset: 0x000047F8
		public unsafe Il2CppStructArray<Guid> OfflineAccounts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameMetaData.NativeFieldInfoPtr_OfflineAccounts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Guid>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameMetaData.NativeFieldInfoPtr_OfflineAccounts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x0002FEA8 File Offset: 0x0002E0A8
		// (set) Token: 0x060009A8 RID: 2472 RVA: 0x00006617 File Offset: 0x00004817
		public unsafe Dictionary<GameID, SaveMetaData> MatchData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameMetaData.NativeFieldInfoPtr_MatchData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GameID, SaveMetaData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameMetaData.NativeFieldInfoPtr_MatchData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeFieldInfoPtr_OfflineAccounts;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeFieldInfoPtr_MatchData;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
