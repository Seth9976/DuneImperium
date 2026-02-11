using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.menus.prompts
{
	// Token: 0x020001DA RID: 474
	public class PlayerStatsPromptBehaviour : MonoBehaviour
	{
		// Token: 0x060015E9 RID: 5609 RVA: 0x00064544 File Offset: 0x00062744
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerStatsPromptBehaviour()
		{
			Il2CppClassPointerStore<PlayerStatsPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "PlayerStatsPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerStatsPromptBehaviour>.NativeClassPtr);
			PlayerStatsPromptBehaviour.NativeFieldInfoPtr_matchStatsBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStatsPromptBehaviour>.NativeClassPtr, "matchStatsBehaviour");
			PlayerStatsPromptBehaviour.NativeFieldInfoPtr_matchHistoryBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStatsPromptBehaviour>.NativeClassPtr, "matchHistoryBehaviour");
			PlayerStatsPromptBehaviour.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatsPromptBehaviour>.NativeClassPtr, 100666506);
			PlayerStatsPromptBehaviour.NativeMethodInfoPtr_Event_DisplayMatchStats_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatsPromptBehaviour>.NativeClassPtr, 100666507);
			PlayerStatsPromptBehaviour.NativeMethodInfoPtr_Event_DisplayMatchHistory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatsPromptBehaviour>.NativeClassPtr, 100666508);
			PlayerStatsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatsPromptBehaviour>.NativeClassPtr, 100666509);
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x000645EC File Offset: 0x000627EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523276, XrefRangeEnd = 523282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerStatsPromptBehaviour.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00064620 File Offset: 0x00062820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_DisplayMatchStats()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerStatsPromptBehaviour.NativeMethodInfoPtr_Event_DisplayMatchStats_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00064654 File Offset: 0x00062854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 523282, XrefRangeEnd = 523288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_DisplayMatchHistory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerStatsPromptBehaviour.NativeMethodInfoPtr_Event_DisplayMatchHistory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00064688 File Offset: 0x00062888
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerStatsPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerStatsPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerStatsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x0000C661 File Offset: 0x0000A861
		public PlayerStatsPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x000646C4 File Offset: 0x000628C4
		// (set) Token: 0x060015F0 RID: 5616 RVA: 0x0000C66A File Offset: 0x0000A86A
		public unsafe MatchStatsBehaviour matchStatsBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerStatsPromptBehaviour.NativeFieldInfoPtr_matchStatsBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchStatsBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerStatsPromptBehaviour.NativeFieldInfoPtr_matchStatsBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x000646F4 File Offset: 0x000628F4
		// (set) Token: 0x060015F2 RID: 5618 RVA: 0x0000C689 File Offset: 0x0000A889
		public unsafe MatchHistoryBehaviour matchHistoryBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerStatsPromptBehaviour.NativeFieldInfoPtr_matchHistoryBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchHistoryBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerStatsPromptBehaviour.NativeFieldInfoPtr_matchHistoryBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeFieldInfoPtr_matchStatsBehaviour;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeFieldInfoPtr_matchHistoryBehaviour;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeMethodInfoPtr_Event_DisplayMatchStats_Public_Void_0;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeMethodInfoPtr_Event_DisplayMatchHistory_Public_Void_0;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
