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
	// Token: 0x0200002B RID: 43
	public class RankedSeasonEndedPromptBehaviour : PromptBehaviour<FlavoredDismissablePrompt>
	{
		// Token: 0x0600018A RID: 394 RVA: 0x00007BBC File Offset: 0x00005DBC
		// Note: this type is marked as 'beforefieldinit'.
		static RankedSeasonEndedPromptBehaviour()
		{
			Il2CppClassPointerStore<RankedSeasonEndedPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.menus", "RankedSeasonEndedPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedSeasonEndedPromptBehaviour>.NativeClassPtr);
			RankedSeasonEndedPromptBehaviour.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedSeasonEndedPromptBehaviour>.NativeClassPtr, "title");
			RankedSeasonEndedPromptBehaviour.NativeFieldInfoPtr_subtitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedSeasonEndedPromptBehaviour>.NativeClassPtr, "subtitle");
			RankedSeasonEndedPromptBehaviour.NativeFieldInfoPtr_onShowNewRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedSeasonEndedPromptBehaviour>.NativeClassPtr, "onShowNewRank");
			RankedSeasonEndedPromptBehaviour.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedSeasonEndedPromptBehaviour>.NativeClassPtr, "data");
			RankedSeasonEndedPromptBehaviour.NativeFieldInfoPtr_needsShowNewRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedSeasonEndedPromptBehaviour>.NativeClassPtr, "needsShowNewRank");
			RankedSeasonEndedPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedSeasonEndedPromptBehaviour>.NativeClassPtr, 100663433);
			RankedSeasonEndedPromptBehaviour.NativeMethodInfoPtr_Event_Continue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedSeasonEndedPromptBehaviour>.NativeClassPtr, 100663434);
			RankedSeasonEndedPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedSeasonEndedPromptBehaviour>.NativeClassPtr, 100663435);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00007C8C File Offset: 0x00005E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225729, XrefRangeEnd = 1225757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedSeasonEndedPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00007CC8 File Offset: 0x00005EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225757, XrefRangeEnd = 1225780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Continue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedSeasonEndedPromptBehaviour.NativeMethodInfoPtr_Event_Continue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00007CFC File Offset: 0x00005EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225780, XrefRangeEnd = 1225788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedSeasonEndedPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedSeasonEndedPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedSeasonEndedPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002EAA File Offset: 0x000010AA
		public RankedSeasonEndedPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00007D38 File Offset: 0x00005F38
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00002EB3 File Offset: 0x000010B3
		public unsafe TMP_Text title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonEndedPromptBehaviour.NativeFieldInfoPtr_title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonEndedPromptBehaviour.NativeFieldInfoPtr_title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00007D68 File Offset: 0x00005F68
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00002ED2 File Offset: 0x000010D2
		public unsafe TMP_Text subtitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonEndedPromptBehaviour.NativeFieldInfoPtr_subtitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonEndedPromptBehaviour.NativeFieldInfoPtr_subtitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00007D98 File Offset: 0x00005F98
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00002EF1 File Offset: 0x000010F1
		public unsafe UnityEvent onShowNewRank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonEndedPromptBehaviour.NativeFieldInfoPtr_onShowNewRank);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonEndedPromptBehaviour.NativeFieldInfoPtr_onShowNewRank), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00007DC8 File Offset: 0x00005FC8
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00002F10 File Offset: 0x00001110
		public unsafe RankedDataUpdatedRankData data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonEndedPromptBehaviour.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankedDataUpdatedRankData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonEndedPromptBehaviour.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00007DF8 File Offset: 0x00005FF8
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00002F2F File Offset: 0x0000112F
		public unsafe bool needsShowNewRank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonEndedPromptBehaviour.NativeFieldInfoPtr_needsShowNewRank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedSeasonEndedPromptBehaviour.NativeFieldInfoPtr_needsShowNewRank)) = value;
			}
		}

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_subtitle;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_onShowNewRank;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_needsShowNewRank;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_Event_Continue_Public_Void_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
