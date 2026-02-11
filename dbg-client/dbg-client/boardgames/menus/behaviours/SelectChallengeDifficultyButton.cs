using System;
using boardgames.challenges;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.EventSystems;

namespace boardgames.menus.behaviours
{
	// Token: 0x020001BB RID: 443
	public class SelectChallengeDifficultyButton : Subscriber<ChallengeDifficultyData>
	{
		// Token: 0x060013F9 RID: 5113 RVA: 0x0005E238 File Offset: 0x0005C438
		// Note: this type is marked as 'beforefieldinit'.
		static SelectChallengeDifficultyButton()
		{
			Il2CppClassPointerStore<SelectChallengeDifficultyButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.behaviours", "SelectChallengeDifficultyButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectChallengeDifficultyButton>.NativeClassPtr);
			SelectChallengeDifficultyButton.NativeFieldInfoPtr_challengeBranchRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectChallengeDifficultyButton>.NativeClassPtr, "challengeBranchRenderer");
			SelectChallengeDifficultyButton.NativeMethodInfoPtr_Event_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectChallengeDifficultyButton>.NativeClassPtr, 100666232);
			SelectChallengeDifficultyButton.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectChallengeDifficultyButton>.NativeClassPtr, 100666233);
			SelectChallengeDifficultyButton.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectChallengeDifficultyButton>.NativeClassPtr, 100666234);
			SelectChallengeDifficultyButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectChallengeDifficultyButton>.NativeClassPtr, 100666235);
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x0005E2CC File Offset: 0x0005C4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519883, XrefRangeEnd = 519888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectChallengeDifficultyButton.NativeMethodInfoPtr_Event_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x0005E300 File Offset: 0x0005C500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519888, XrefRangeEnd = 519891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectChallengeDifficultyButton.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x0005E344 File Offset: 0x0005C544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519891, XrefRangeEnd = 519896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectChallengeDifficultyButton.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x0005E388 File Offset: 0x0005C588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519896, XrefRangeEnd = 519899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectChallengeDifficultyButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectChallengeDifficultyButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectChallengeDifficultyButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x0000B635 File Offset: 0x00009835
		public SelectChallengeDifficultyButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x0005E3C4 File Offset: 0x0005C5C4
		// (set) Token: 0x06001400 RID: 5120 RVA: 0x0000B63E File Offset: 0x0000983E
		public unsafe ChallengeBranchRenderer challengeBranchRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectChallengeDifficultyButton.NativeFieldInfoPtr_challengeBranchRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChallengeBranchRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectChallengeDifficultyButton.NativeFieldInfoPtr_challengeBranchRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeFieldInfoPtr_challengeBranchRenderer;

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnClick_Public_Void_0;

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
