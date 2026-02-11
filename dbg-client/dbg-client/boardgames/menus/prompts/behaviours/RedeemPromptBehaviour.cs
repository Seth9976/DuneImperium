using System;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.menus.prompts.behaviours
{
	// Token: 0x02000208 RID: 520
	public class RedeemPromptBehaviour : PromptBehaviour<RedeemPrompt>
	{
		// Token: 0x060017EF RID: 6127 RVA: 0x0006B50C File Offset: 0x0006970C
		// Note: this type is marked as 'beforefieldinit'.
		static RedeemPromptBehaviour()
		{
			Il2CppClassPointerStore<RedeemPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts.behaviours", "RedeemPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RedeemPromptBehaviour>.NativeClassPtr);
			RedeemPromptBehaviour.NativeFieldInfoPtr_codeField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedeemPromptBehaviour>.NativeClassPtr, "codeField");
			RedeemPromptBehaviour.NativeFieldInfoPtr_redeemButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedeemPromptBehaviour>.NativeClassPtr, "redeemButton");
			RedeemPromptBehaviour.NativeFieldInfoPtr_badInputIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedeemPromptBehaviour>.NativeClassPtr, "badInputIcon");
			RedeemPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedeemPromptBehaviour>.NativeClassPtr, 100666786);
			RedeemPromptBehaviour.NativeMethodInfoPtr_Event_Redeem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedeemPromptBehaviour>.NativeClassPtr, 100666787);
			RedeemPromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedeemPromptBehaviour>.NativeClassPtr, 100666788);
			RedeemPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedeemPromptBehaviour>.NativeClassPtr, 100666789);
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x0006B5C8 File Offset: 0x000697C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525708, XrefRangeEnd = 525720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedeemPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x0006B5FC File Offset: 0x000697FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525720, XrefRangeEnd = 525731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Redeem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedeemPromptBehaviour.NativeMethodInfoPtr_Event_Redeem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x0006B630 File Offset: 0x00069830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525731, XrefRangeEnd = 525738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedeemPromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x0006B664 File Offset: 0x00069864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525738, XrefRangeEnd = 525741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RedeemPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RedeemPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedeemPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x0000D4B4 File Offset: 0x0000B6B4
		public RedeemPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060017F5 RID: 6133 RVA: 0x0006B6A0 File Offset: 0x000698A0
		// (set) Token: 0x060017F6 RID: 6134 RVA: 0x0000D4BD File Offset: 0x0000B6BD
		public unsafe TMP_InputField codeField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedeemPromptBehaviour.NativeFieldInfoPtr_codeField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedeemPromptBehaviour.NativeFieldInfoPtr_codeField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060017F7 RID: 6135 RVA: 0x0006B6D0 File Offset: 0x000698D0
		// (set) Token: 0x060017F8 RID: 6136 RVA: 0x0000D4DC File Offset: 0x0000B6DC
		public unsafe Button redeemButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedeemPromptBehaviour.NativeFieldInfoPtr_redeemButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedeemPromptBehaviour.NativeFieldInfoPtr_redeemButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x0006B700 File Offset: 0x00069900
		// (set) Token: 0x060017FA RID: 6138 RVA: 0x0000D4FB File Offset: 0x0000B6FB
		public unsafe GameObject badInputIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedeemPromptBehaviour.NativeFieldInfoPtr_badInputIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedeemPromptBehaviour.NativeFieldInfoPtr_badInputIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeFieldInfoPtr_codeField;

		// Token: 0x04000F01 RID: 3841
		private static readonly IntPtr NativeFieldInfoPtr_redeemButton;

		// Token: 0x04000F02 RID: 3842
		private static readonly IntPtr NativeFieldInfoPtr_badInputIcon;

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeMethodInfoPtr_Event_Redeem_Public_Void_0;

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeMethodInfoPtr_Event_Cancel_Public_Void_0;

		// Token: 0x04000F06 RID: 3846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
