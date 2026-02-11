using System;
using dbgclient.prompts.prompts;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using TMPro;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000E6 RID: 230
	public class WormSkirmishScorePromptBehavior : PromptBehaviour<DailyChallengeScorePrompt>
	{
		// Token: 0x06000A41 RID: 2625 RVA: 0x000374E8 File Offset: 0x000356E8
		// Note: this type is marked as 'beforefieldinit'.
		static WormSkirmishScorePromptBehavior()
		{
			Il2CppClassPointerStore<WormSkirmishScorePromptBehavior>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormSkirmishScorePromptBehavior");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSkirmishScorePromptBehavior>.NativeClassPtr);
			WormSkirmishScorePromptBehavior.NativeFieldInfoPtr_scoreText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishScorePromptBehavior>.NativeClassPtr, "scoreText");
			WormSkirmishScorePromptBehavior.NativeFieldInfoPtr_scoreTotalsFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishScorePromptBehavior>.NativeClassPtr, "scoreTotalsFields");
			WormSkirmishScorePromptBehavior.NativeFieldInfoPtr_scoreDetailsFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSkirmishScorePromptBehavior>.NativeClassPtr, "scoreDetailsFields");
			WormSkirmishScorePromptBehavior.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishScorePromptBehavior>.NativeClassPtr, 100664711);
			WormSkirmishScorePromptBehavior.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSkirmishScorePromptBehavior>.NativeClassPtr, 100664712);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0003757C File Offset: 0x0003577C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701347, XrefRangeEnd = 701405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSkirmishScorePromptBehavior.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x000375B8 File Offset: 0x000357B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701405, XrefRangeEnd = 701420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSkirmishScorePromptBehavior()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSkirmishScorePromptBehavior>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSkirmishScorePromptBehavior.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x000075C4 File Offset: 0x000057C4
		public WormSkirmishScorePromptBehavior(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x000375F4 File Offset: 0x000357F4
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x000075CD File Offset: 0x000057CD
		public unsafe TMP_Text scoreText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishScorePromptBehavior.NativeFieldInfoPtr_scoreText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishScorePromptBehavior.NativeFieldInfoPtr_scoreText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x00037624 File Offset: 0x00035824
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x000075EC File Offset: 0x000057EC
		public unsafe List<TMP_Text> scoreTotalsFields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishScorePromptBehavior.NativeFieldInfoPtr_scoreTotalsFields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishScorePromptBehavior.NativeFieldInfoPtr_scoreTotalsFields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x00037654 File Offset: 0x00035854
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x0000760B File Offset: 0x0000580B
		public unsafe List<TMP_Text> scoreDetailsFields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishScorePromptBehavior.NativeFieldInfoPtr_scoreDetailsFields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSkirmishScorePromptBehavior.NativeFieldInfoPtr_scoreDetailsFields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeFieldInfoPtr_scoreText;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeFieldInfoPtr_scoreTotalsFields;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeFieldInfoPtr_scoreDetailsFields;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
