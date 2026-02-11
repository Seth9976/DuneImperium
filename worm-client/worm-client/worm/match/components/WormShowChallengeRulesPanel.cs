using System;
using boardgames.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using worm.match.dataRenderers;

namespace worm.match.components
{
	// Token: 0x02000211 RID: 529
	public class WormShowChallengeRulesPanel : WormShowRulesPanel
	{
		// Token: 0x06001763 RID: 5987 RVA: 0x0005F02C File Offset: 0x0005D22C
		// Note: this type is marked as 'beforefieldinit'.
		static WormShowChallengeRulesPanel()
		{
			Il2CppClassPointerStore<WormShowChallengeRulesPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormShowChallengeRulesPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowChallengeRulesPanel>.NativeClassPtr);
			WormShowChallengeRulesPanel.NativeFieldInfoPtr_headerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowChallengeRulesPanel>.NativeClassPtr, "headerText");
			WormShowChallengeRulesPanel.NativeFieldInfoPtr_subheaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowChallengeRulesPanel>.NativeClassPtr, "subheaderText");
			WormShowChallengeRulesPanel.NativeFieldInfoPtr_descriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowChallengeRulesPanel>.NativeClassPtr, "descriptionText");
			WormShowChallengeRulesPanel.NativeFieldInfoPtr_progressRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowChallengeRulesPanel>.NativeClassPtr, "progressRenderer");
			WormShowChallengeRulesPanel.NativeMethodInfoPtr_InitMatchData_Protected_Virtual_Boolean_GameOptionsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowChallengeRulesPanel>.NativeClassPtr, 100666554);
			WormShowChallengeRulesPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowChallengeRulesPanel>.NativeClassPtr, 100666555);
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x0005F0D4 File Offset: 0x0005D2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717406, XrefRangeEnd = 717414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InitMatchData(GameOptionsData matchData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormShowChallengeRulesPanel.NativeMethodInfoPtr_InitMatchData_Protected_Virtual_Boolean_GameOptionsData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x0005F12C File Offset: 0x0005D32C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormShowChallengeRulesPanel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowChallengeRulesPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowChallengeRulesPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x0000DFF0 File Offset: 0x0000C1F0
		public WormShowChallengeRulesPanel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x0005F168 File Offset: 0x0005D368
		// (set) Token: 0x06001768 RID: 5992 RVA: 0x0000DFF9 File Offset: 0x0000C1F9
		public unsafe TMP_Text headerText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowChallengeRulesPanel.NativeFieldInfoPtr_headerText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowChallengeRulesPanel.NativeFieldInfoPtr_headerText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x0005F198 File Offset: 0x0005D398
		// (set) Token: 0x0600176A RID: 5994 RVA: 0x0000E018 File Offset: 0x0000C218
		public unsafe TMP_Text subheaderText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowChallengeRulesPanel.NativeFieldInfoPtr_subheaderText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowChallengeRulesPanel.NativeFieldInfoPtr_subheaderText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x0600176B RID: 5995 RVA: 0x0005F1C8 File Offset: 0x0005D3C8
		// (set) Token: 0x0600176C RID: 5996 RVA: 0x0000E037 File Offset: 0x0000C237
		public unsafe TMP_Text descriptionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowChallengeRulesPanel.NativeFieldInfoPtr_descriptionText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowChallengeRulesPanel.NativeFieldInfoPtr_descriptionText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x0005F1F8 File Offset: 0x0005D3F8
		// (set) Token: 0x0600176E RID: 5998 RVA: 0x0000E056 File Offset: 0x0000C256
		public unsafe WormChallengeProgressRenderer progressRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowChallengeRulesPanel.NativeFieldInfoPtr_progressRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormChallengeProgressRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowChallengeRulesPanel.NativeFieldInfoPtr_progressRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeFieldInfoPtr_headerText;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeFieldInfoPtr_subheaderText;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeFieldInfoPtr_descriptionText;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeFieldInfoPtr_progressRenderer;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeMethodInfoPtr_InitMatchData_Protected_Virtual_Boolean_GameOptionsData_0;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
