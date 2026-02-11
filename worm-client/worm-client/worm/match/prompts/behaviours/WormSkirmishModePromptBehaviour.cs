using System;
using boardgames.menus.ui;
using dbgclient.prompts.prompts;
using dwd.core.commands;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;
using worm.dataProviders;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000E5 RID: 229
	public class WormSkirmishModePromptBehaviour : PromptBehaviour<DailyChallengePrompt>
	{
		// Token: 0x06000A20 RID: 2592 RVA: 0x00036F28 File Offset: 0x00035128
		// Note: this type is marked as 'beforefieldinit'.
		static WormSkirmishModePromptBehaviour()
		{
			Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormSkirmishModePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr);
			WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_activeContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, "activeContent");
			WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_inactiveContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, "inactiveContent");
			WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_inactiveTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, "inactiveTimer");
			WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_inactiveSavedGameMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, "inactiveSavedGameMessage");
			WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_playButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, "playButton");
			WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_rulesFTTHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, "rulesFTTHighlight");
			WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_leaderboardAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, "leaderboardAnimator");
			WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_showLeaderboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, "showLeaderboard");
			WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_showRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, "showRules");
			WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_playCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, "playCoroutine");
			WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_HintParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, "HintParam");
			WormSkirmishModePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, 100664697);
			WormSkirmishModePromptBehaviour.NativeMethodInfoPtr_Initialize_Private_Void_WormDailyChallengeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, 100664698);
			WormSkirmishModePromptBehaviour.NativeMethodInfoPtr_Event_OnTimeEnded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, 100664699);
			WormSkirmishModePromptBehaviour.NativeMethodInfoPtr_Event_ShowLeaderboard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, 100664700);
			WormSkirmishModePromptBehaviour.NativeMethodInfoPtr_Event_ShowRules_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, 100664701);
			WormSkirmishModePromptBehaviour.NativeMethodInfoPtr_Event_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, 100664702);
			WormSkirmishModePromptBehaviour.NativeMethodInfoPtr_Event_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, 100664703);
			WormSkirmishModePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, 100664704);
			WormSkirmishModePromptBehaviour.NativeMethodInfoPtr__Event_Play_b__16_0_Private_Void_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, 100664706);
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x000370E8 File Offset: 0x000352E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701226, XrefRangeEnd = 701251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSkirmishModePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00037124 File Offset: 0x00035324
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 701302, RefRangeEnd = 701304, XrefRangeStart = 701251, XrefRangeEnd = 701302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(WormDailyChallengeProvider dailyChallengeProvider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dailyChallengeProvider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishModePromptBehaviour.NativeMethodInfoPtr_Initialize_Private_Void_WormDailyChallengeProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00037168 File Offset: 0x00035368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701304, XrefRangeEnd = 701309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnTimeEnded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishModePromptBehaviour.NativeMethodInfoPtr_Event_OnTimeEnded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0003719C File Offset: 0x0003539C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701309, XrefRangeEnd = 701315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowLeaderboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishModePromptBehaviour.NativeMethodInfoPtr_Event_ShowLeaderboard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x000371D0 File Offset: 0x000353D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701315, XrefRangeEnd = 701322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowRules()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishModePromptBehaviour.NativeMethodInfoPtr_Event_ShowRules_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00037204 File Offset: 0x00035404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701322, XrefRangeEnd = 701338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishModePromptBehaviour.NativeMethodInfoPtr_Event_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00037238 File Offset: 0x00035438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701338, XrefRangeEnd = 701343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishModePromptBehaviour.NativeMethodInfoPtr_Event_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0003726C File Offset: 0x0003546C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701343, XrefRangeEnd = 701346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSkirmishModePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishModePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x000372A8 File Offset: 0x000354A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701346, XrefRangeEnd = 701347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Event_Play_b__16_0(IFailable _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishModePromptBehaviour.NativeMethodInfoPtr__Event_Play_b__16_0_Private_Void_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00007477 File Offset: 0x00005677
		public WormSkirmishModePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x000372EC File Offset: 0x000354EC
		// (set) Token: 0x06000A2C RID: 2604 RVA: 0x00007480 File Offset: 0x00005680
		public unsafe GameObject activeContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_activeContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_activeContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x0003731C File Offset: 0x0003551C
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x0000749F File Offset: 0x0000569F
		public unsafe GameObject inactiveContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_inactiveContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_inactiveContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0003734C File Offset: 0x0003554C
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x000074BE File Offset: 0x000056BE
		public unsafe TimerDisplay inactiveTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_inactiveTimer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_inactiveTimer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x0003737C File Offset: 0x0003557C
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x000074DD File Offset: 0x000056DD
		public unsafe GameObject inactiveSavedGameMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_inactiveSavedGameMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_inactiveSavedGameMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x000373AC File Offset: 0x000355AC
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x000074FC File Offset: 0x000056FC
		public unsafe Button playButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_playButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_playButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x000373DC File Offset: 0x000355DC
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x0000751B File Offset: 0x0000571B
		public unsafe GameObject rulesFTTHighlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_rulesFTTHighlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_rulesFTTHighlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x0003740C File Offset: 0x0003560C
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x0000753A File Offset: 0x0000573A
		public unsafe Animator leaderboardAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_leaderboardAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_leaderboardAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x0003743C File Offset: 0x0003563C
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x00007559 File Offset: 0x00005759
		public unsafe Command showLeaderboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_showLeaderboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_showLeaderboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x0003746C File Offset: 0x0003566C
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x00007578 File Offset: 0x00005778
		public unsafe Command showRules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_showRules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_showRules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x0003749C File Offset: 0x0003569C
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x00007597 File Offset: 0x00005797
		public unsafe Coroutine playCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_playCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_playCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x000374CC File Offset: 0x000356CC
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x000075B6 File Offset: 0x000057B6
		public unsafe static int HintParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_HintParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormSkirmishModePromptBehaviour.NativeFieldInfoPtr_HintParam, (void*)(&value));
			}
		}

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeFieldInfoPtr_activeContent;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeFieldInfoPtr_inactiveContent;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeFieldInfoPtr_inactiveTimer;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeFieldInfoPtr_inactiveSavedGameMessage;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeFieldInfoPtr_playButton;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeFieldInfoPtr_rulesFTTHighlight;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeFieldInfoPtr_leaderboardAnimator;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeFieldInfoPtr_showLeaderboard;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeFieldInfoPtr_showRules;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeFieldInfoPtr_playCoroutine;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeFieldInfoPtr_HintParam;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_WormDailyChallengeProvider_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnTimeEnded_Public_Void_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowLeaderboard_Public_Void_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowRules_Public_Void_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_Event_Play_Public_Void_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_Event_Back_Public_Void_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr__Event_Play_b__16_0_Private_Void_IFailable_0;

		// Token: 0x0200034B RID: 843
		[ObfuscatedName("worm.match.prompts.behaviours.WormSkirmishModePromptBehaviour+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002217 RID: 8727 RVA: 0x0007FD28 File Offset: 0x0007DF28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<WormSkirmishModePromptBehaviour.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour.__c__DisplayClass11_0>.NativeClassPtr);
				WormSkirmishModePromptBehaviour.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				WormSkirmishModePromptBehaviour.__c__DisplayClass11_0.NativeFieldInfoPtr_dailyChallengeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour.__c__DisplayClass11_0>.NativeClassPtr, "dailyChallengeProvider");
				WormSkirmishModePromptBehaviour.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour.__c__DisplayClass11_0>.NativeClassPtr, 100664707);
				WormSkirmishModePromptBehaviour.__c__DisplayClass11_0.NativeMethodInfoPtr__initialize_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour.__c__DisplayClass11_0>.NativeClassPtr, 100664708);
			}

			// Token: 0x06002218 RID: 8728 RVA: 0x0007FDA4 File Offset: 0x0007DFA4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishModePromptBehaviour.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002219 RID: 8729 RVA: 0x0007FDE0 File Offset: 0x0007DFE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701219, XrefRangeEnd = 701221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _initialize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishModePromptBehaviour.__c__DisplayClass11_0.NativeMethodInfoPtr__initialize_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600221A RID: 8730 RVA: 0x0001318A File Offset: 0x0001138A
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000967 RID: 2407
			// (get) Token: 0x0600221B RID: 8731 RVA: 0x0007FE14 File Offset: 0x0007E014
			// (set) Token: 0x0600221C RID: 8732 RVA: 0x00013193 File Offset: 0x00011393
			public unsafe WormSkirmishModePromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSkirmishModePromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000968 RID: 2408
			// (get) Token: 0x0600221D RID: 8733 RVA: 0x0007FE44 File Offset: 0x0007E044
			// (set) Token: 0x0600221E RID: 8734 RVA: 0x000131B2 File Offset: 0x000113B2
			public unsafe WormDailyChallengeProvider dailyChallengeProvider
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.__c__DisplayClass11_0.NativeFieldInfoPtr_dailyChallengeProvider);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormDailyChallengeProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.__c__DisplayClass11_0.NativeFieldInfoPtr_dailyChallengeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040013A3 RID: 5027
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040013A4 RID: 5028
			private static readonly IntPtr NativeFieldInfoPtr_dailyChallengeProvider;

			// Token: 0x040013A5 RID: 5029
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013A6 RID: 5030
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__0_Internal_Void_0;
		}

		// Token: 0x0200034C RID: 844
		[ObfuscatedName("worm.match.prompts.behaviours.WormSkirmishModePromptBehaviour+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600221F RID: 8735 RVA: 0x0007FE74 File Offset: 0x0007E074
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<WormSkirmishModePromptBehaviour.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour.__c__DisplayClass12_0>.NativeClassPtr);
				WormSkirmishModePromptBehaviour.__c__DisplayClass12_0.NativeFieldInfoPtr_timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour.__c__DisplayClass12_0>.NativeClassPtr, "timestamp");
				WormSkirmishModePromptBehaviour.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour.__c__DisplayClass12_0>.NativeClassPtr, 100664709);
				WormSkirmishModePromptBehaviour.__c__DisplayClass12_0.NativeMethodInfoPtr__Initialize_b__0_Internal_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour.__c__DisplayClass12_0>.NativeClassPtr, 100664710);
			}

			// Token: 0x06002220 RID: 8736 RVA: 0x0007FEDC File Offset: 0x0007E0DC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSkirmishModePromptBehaviour.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishModePromptBehaviour.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002221 RID: 8737 RVA: 0x0007FF18 File Offset: 0x0007E118
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701221, XrefRangeEnd = 701226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimeSpan _Initialize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishModePromptBehaviour.__c__DisplayClass12_0.NativeMethodInfoPtr__Initialize_b__0_Internal_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002222 RID: 8738 RVA: 0x000131D1 File Offset: 0x000113D1
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000969 RID: 2409
			// (get) Token: 0x06002223 RID: 8739 RVA: 0x0007FF54 File Offset: 0x0007E154
			// (set) Token: 0x06002224 RID: 8740 RVA: 0x000131DA File Offset: 0x000113DA
			public unsafe DateTime timestamp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.__c__DisplayClass12_0.NativeFieldInfoPtr_timestamp);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishModePromptBehaviour.__c__DisplayClass12_0.NativeFieldInfoPtr_timestamp)) = value;
				}
			}

			// Token: 0x040013A7 RID: 5031
			private static readonly IntPtr NativeFieldInfoPtr_timestamp;

			// Token: 0x040013A8 RID: 5032
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040013A9 RID: 5033
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__0_Internal_TimeSpan_0;
		}
	}
}
