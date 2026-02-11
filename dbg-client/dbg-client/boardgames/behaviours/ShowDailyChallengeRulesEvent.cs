using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.behaviours
{
	// Token: 0x020002B1 RID: 689
	public class ShowDailyChallengeRulesEvent : MonoBehaviour
	{
		// Token: 0x0600209F RID: 8351 RVA: 0x0008A380 File Offset: 0x00088580
		// Note: this type is marked as 'beforefieldinit'.
		static ShowDailyChallengeRulesEvent()
		{
			Il2CppClassPointerStore<ShowDailyChallengeRulesEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.behaviours", "ShowDailyChallengeRulesEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowDailyChallengeRulesEvent>.NativeClassPtr);
			ShowDailyChallengeRulesEvent.NativeFieldInfoPtr_showRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowDailyChallengeRulesEvent>.NativeClassPtr, "showRules");
			ShowDailyChallengeRulesEvent.NativeMethodInfoPtr_Event_ShowRules_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowDailyChallengeRulesEvent>.NativeClassPtr, 100668717);
			ShowDailyChallengeRulesEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowDailyChallengeRulesEvent>.NativeClassPtr, 100668718);
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x0008A3EC File Offset: 0x000885EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542630, XrefRangeEnd = 542636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowRules()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowDailyChallengeRulesEvent.NativeMethodInfoPtr_Event_ShowRules_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x0008A420 File Offset: 0x00088620
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShowDailyChallengeRulesEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowDailyChallengeRulesEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowDailyChallengeRulesEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x00011154 File Offset: 0x0000F354
		public ShowDailyChallengeRulesEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x0008A45C File Offset: 0x0008865C
		// (set) Token: 0x060020A4 RID: 8356 RVA: 0x0001115D File Offset: 0x0000F35D
		public unsafe Command showRules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowDailyChallengeRulesEvent.NativeFieldInfoPtr_showRules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowDailyChallengeRulesEvent.NativeFieldInfoPtr_showRules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001498 RID: 5272
		private static readonly IntPtr NativeFieldInfoPtr_showRules;

		// Token: 0x04001499 RID: 5273
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowRules_Public_Void_0;

		// Token: 0x0400149A RID: 5274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
