using System;
using boardgames.ranked.data;
using dwd.core.ui.match.prompt.prompts;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine.Events;

namespace boardgames.ranked.menus
{
	// Token: 0x02000019 RID: 25
	public class RankedDataUpdatedPromptBehaviour : PromptBehaviour<FlavoredDismissablePrompt>
	{
		// Token: 0x060000AF RID: 175 RVA: 0x000051F4 File Offset: 0x000033F4
		// Note: this type is marked as 'beforefieldinit'.
		static RankedDataUpdatedPromptBehaviour()
		{
			Il2CppClassPointerStore<RankedDataUpdatedPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.menus", "RankedDataUpdatedPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedDataUpdatedPromptBehaviour>.NativeClassPtr);
			RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedPromptBehaviour>.NativeClassPtr, "title");
			RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_subtitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedPromptBehaviour>.NativeClassPtr, "subtitle");
			RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedPromptBehaviour>.NativeClassPtr, "players");
			RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_startedAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedPromptBehaviour>.NativeClassPtr, "startedAt");
			RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_onShowNewRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedPromptBehaviour>.NativeClassPtr, "onShowNewRank");
			RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedPromptBehaviour>.NativeClassPtr, "data");
			RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_gameData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedPromptBehaviour>.NativeClassPtr, "gameData");
			RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_needsShowNewRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdatedPromptBehaviour>.NativeClassPtr, "needsShowNewRank");
			RankedDataUpdatedPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedPromptBehaviour>.NativeClassPtr, 100663330);
			RankedDataUpdatedPromptBehaviour.NativeMethodInfoPtr_Event_Continue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedPromptBehaviour>.NativeClassPtr, 100663331);
			RankedDataUpdatedPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdatedPromptBehaviour>.NativeClassPtr, 100663332);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005300 File Offset: 0x00003500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224700, XrefRangeEnd = 1224785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedDataUpdatedPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000533C File Offset: 0x0000353C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224785, XrefRangeEnd = 1224842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Continue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedDataUpdatedPromptBehaviour.NativeMethodInfoPtr_Event_Continue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00005370 File Offset: 0x00003570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224842, XrefRangeEnd = 1224850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedDataUpdatedPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedDataUpdatedPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedDataUpdatedPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002866 File Offset: 0x00000A66
		public RankedDataUpdatedPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000053AC File Offset: 0x000035AC
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x0000286F File Offset: 0x00000A6F
		public unsafe TMP_Text title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000053DC File Offset: 0x000035DC
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000288E File Offset: 0x00000A8E
		public unsafe TMP_Text subtitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_subtitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_subtitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000540C File Offset: 0x0000360C
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x000028AD File Offset: 0x00000AAD
		public unsafe TMP_Text players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000543C File Offset: 0x0000363C
		// (set) Token: 0x060000BB RID: 187 RVA: 0x000028CC File Offset: 0x00000ACC
		public unsafe TMP_Text startedAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_startedAt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_startedAt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000546C File Offset: 0x0000366C
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000028EB File Offset: 0x00000AEB
		public unsafe UnityEvent onShowNewRank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_onShowNewRank);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_onShowNewRank), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000549C File Offset: 0x0000369C
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0000290A File Offset: 0x00000B0A
		public unsafe RankedDataUpdatedRankData data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankedDataUpdatedRankData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x000054CC File Offset: 0x000036CC
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00002929 File Offset: 0x00000B29
		public unsafe RankedDataUpdatedGameData gameData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_gameData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankedDataUpdatedGameData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_gameData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000054FC File Offset: 0x000036FC
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002948 File Offset: 0x00000B48
		public unsafe bool needsShowNewRank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_needsShowNewRank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdatedPromptBehaviour.NativeFieldInfoPtr_needsShowNewRank)) = value;
			}
		}

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_subtitle;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr_players;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_startedAt;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr_onShowNewRank;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_gameData;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_needsShowNewRank;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_Event_Continue_Public_Void_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
