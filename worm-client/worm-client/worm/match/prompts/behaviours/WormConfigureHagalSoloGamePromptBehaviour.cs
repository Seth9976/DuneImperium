using System;
using boardgames.menus;
using boardgames.menus.prompts;
using Canis;
using dwd.core.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using worm.canis.data.enums;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000C7 RID: 199
	public class WormConfigureHagalSoloGamePromptBehaviour : ConfigureGameOptionsPromptBehaviour<ConfigureOfflineGamePrompt>
	{
		// Token: 0x06000845 RID: 2117 RVA: 0x00031948 File Offset: 0x0002FB48
		// Note: this type is marked as 'beforefieldinit'.
		static WormConfigureHagalSoloGamePromptBehaviour()
		{
			Il2CppClassPointerStore<WormConfigureHagalSoloGamePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormConfigureHagalSoloGamePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConfigureHagalSoloGamePromptBehaviour>.NativeClassPtr);
			WormConfigureHagalSoloGamePromptBehaviour.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureHagalSoloGamePromptBehaviour>.NativeClassPtr, "provider");
			WormConfigureHagalSoloGamePromptBehaviour.NativeFieldInfoPtr_difficultyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureHagalSoloGamePromptBehaviour>.NativeClassPtr, "difficultyText");
			WormConfigureHagalSoloGamePromptBehaviour.NativeFieldInfoPtr_difficultyPips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureHagalSoloGamePromptBehaviour>.NativeClassPtr, "difficultyPips");
			WormConfigureHagalSoloGamePromptBehaviour.NativeFieldInfoPtr_matchesManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureHagalSoloGamePromptBehaviour>.NativeClassPtr, "matchesManager");
			WormConfigureHagalSoloGamePromptBehaviour.NativeFieldInfoPtr_matchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureHagalSoloGamePromptBehaviour>.NativeClassPtr, "matchData");
			WormConfigureHagalSoloGamePromptBehaviour.NativeFieldInfoPtr_difficultyLocData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureHagalSoloGamePromptBehaviour>.NativeClassPtr, "difficultyLocData");
			WormConfigureHagalSoloGamePromptBehaviour.NativeFieldInfoPtr_DifficultyOptionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureHagalSoloGamePromptBehaviour>.NativeClassPtr, "DifficultyOptionName");
			WormConfigureHagalSoloGamePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureHagalSoloGamePromptBehaviour>.NativeClassPtr, 100664422);
			WormConfigureHagalSoloGamePromptBehaviour.NativeMethodInfoPtr_Event_IncrementDifficulty_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureHagalSoloGamePromptBehaviour>.NativeClassPtr, 100664423);
			WormConfigureHagalSoloGamePromptBehaviour.NativeMethodInfoPtr_PlaySoloHagalGame_Public_Void_LeaderAssignmentMode_IReadOnlyList_1_SubscriptionProvider_IEnumerable_1_Set_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureHagalSoloGamePromptBehaviour>.NativeClassPtr, 100664424);
			WormConfigureHagalSoloGamePromptBehaviour.NativeMethodInfoPtr_UpdateSelectedData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureHagalSoloGamePromptBehaviour>.NativeClassPtr, 100664425);
			WormConfigureHagalSoloGamePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureHagalSoloGamePromptBehaviour>.NativeClassPtr, 100664426);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00031A68 File Offset: 0x0002FC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698256, XrefRangeEnd = 698295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConfigureHagalSoloGamePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00031AA4 File Offset: 0x0002FCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698295, XrefRangeEnd = 698301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_IncrementDifficulty(int direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureHagalSoloGamePromptBehaviour.NativeMethodInfoPtr_Event_IncrementDifficulty_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00031AE4 File Offset: 0x0002FCE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 698334, RefRangeEnd = 698335, XrefRangeStart = 698301, XrefRangeEnd = 698334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaySoloHagalGame(LeaderAssignmentMode leaderMode, IReadOnlyList<SubscriptionProvider> playerSlots, IEnumerable<Set> sets, bool goTo11)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref leaderMode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerSlots);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sets);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref goTo11;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureHagalSoloGamePromptBehaviour.NativeMethodInfoPtr_PlaySoloHagalGame_Public_Void_LeaderAssignmentMode_IReadOnlyList_1_SubscriptionProvider_IEnumerable_1_Set_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00031B54 File Offset: 0x0002FD54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 698353, RefRangeEnd = 698355, XrefRangeStart = 698335, XrefRangeEnd = 698353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSelectedData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureHagalSoloGamePromptBehaviour.NativeMethodInfoPtr_UpdateSelectedData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00031B88 File Offset: 0x0002FD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698355, XrefRangeEnd = 698362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormConfigureHagalSoloGamePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConfigureHagalSoloGamePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureHagalSoloGamePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00006362 File Offset: 0x00004562
		public WormConfigureHagalSoloGamePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x00031BC4 File Offset: 0x0002FDC4
		// (set) Token: 0x0600084D RID: 2125 RVA: 0x0000636B File Offset: 0x0000456B
		public unsafe SubscriptionProvider provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureHagalSoloGamePromptBehaviour.NativeFieldInfoPtr_provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureHagalSoloGamePromptBehaviour.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x00031BF4 File Offset: 0x0002FDF4
		// (set) Token: 0x0600084F RID: 2127 RVA: 0x0000638A File Offset: 0x0000458A
		public unsafe TMP_Text difficultyText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureHagalSoloGamePromptBehaviour.NativeFieldInfoPtr_difficultyText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureHagalSoloGamePromptBehaviour.NativeFieldInfoPtr_difficultyText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x00031C24 File Offset: 0x0002FE24
		// (set) Token: 0x06000851 RID: 2129 RVA: 0x000063A9 File Offset: 0x000045A9
		public unsafe Il2CppReferenceArray<GameObject> difficultyPips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureHagalSoloGamePromptBehaviour.NativeFieldInfoPtr_difficultyPips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureHagalSoloGamePromptBehaviour.NativeFieldInfoPtr_difficultyPips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x00031C54 File Offset: 0x0002FE54
		// (set) Token: 0x06000853 RID: 2131 RVA: 0x000063C8 File Offset: 0x000045C8
		public unsafe OfflineMatchesManager matchesManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureHagalSoloGamePromptBehaviour.NativeFieldInfoPtr_matchesManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OfflineMatchesManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureHagalSoloGamePromptBehaviour.NativeFieldInfoPtr_matchesManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x00031C84 File Offset: 0x0002FE84
		// (set) Token: 0x06000855 RID: 2133 RVA: 0x000063E7 File Offset: 0x000045E7
		public unsafe SelectedData<MatchInitData> matchData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureHagalSoloGamePromptBehaviour.NativeFieldInfoPtr_matchData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectedData<MatchInitData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureHagalSoloGamePromptBehaviour.NativeFieldInfoPtr_matchData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x00031CB4 File Offset: 0x0002FEB4
		// (set) Token: 0x06000857 RID: 2135 RVA: 0x00006406 File Offset: 0x00004606
		public unsafe SelectedData<string> difficultyLocData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureHagalSoloGamePromptBehaviour.NativeFieldInfoPtr_difficultyLocData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectedData<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureHagalSoloGamePromptBehaviour.NativeFieldInfoPtr_difficultyLocData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00031CE4 File Offset: 0x0002FEE4
		// (set) Token: 0x06000859 RID: 2137 RVA: 0x00006425 File Offset: 0x00004625
		public unsafe static string DifficultyOptionName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormConfigureHagalSoloGamePromptBehaviour.NativeFieldInfoPtr_DifficultyOptionName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormConfigureHagalSoloGamePromptBehaviour.NativeFieldInfoPtr_DifficultyOptionName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeFieldInfoPtr_provider;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeFieldInfoPtr_difficultyText;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeFieldInfoPtr_difficultyPips;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeFieldInfoPtr_matchesManager;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeFieldInfoPtr_matchData;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeFieldInfoPtr_difficultyLocData;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeFieldInfoPtr_DifficultyOptionName;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_Event_IncrementDifficulty_Public_Void_Int32_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_PlaySoloHagalGame_Public_Void_LeaderAssignmentMode_IReadOnlyList_1_SubscriptionProvider_IEnumerable_1_Set_Boolean_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSelectedData_Private_Void_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
