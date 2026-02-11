using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.prompts
{
	// Token: 0x020000FB RID: 251
	public class SettingsPrompt : BasePrompt
	{
		// Token: 0x06000AA6 RID: 2726 RVA: 0x0003F4C4 File Offset: 0x0003D6C4
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsPrompt()
		{
			Il2CppClassPointerStore<SettingsPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.prompts", "SettingsPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsPrompt>.NativeClassPtr);
			SettingsPrompt.NativeFieldInfoPtr__StartingTab_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPrompt>.NativeClassPtr, "<StartingTab>k__BackingField");
			SettingsPrompt.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPrompt>.NativeClassPtr, "<Result>k__BackingField");
			SettingsPrompt.NativeMethodInfoPtr_get_StartingTab_Public_get_SettingsPromptTab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPrompt>.NativeClassPtr, 100664864);
			SettingsPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_SettingsPromptResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPrompt>.NativeClassPtr, 100664865);
			SettingsPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_SettingsPromptResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPrompt>.NativeClassPtr, 100664866);
			SettingsPrompt.NativeMethodInfoPtr__ctor_Public_Void_SettingsPromptTab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPrompt>.NativeClassPtr, 100664867);
			SettingsPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_SettingsPromptResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPrompt>.NativeClassPtr, 100664868);
			SettingsPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPrompt>.NativeClassPtr, 100664869);
			SettingsPrompt.NativeMethodInfoPtr_YieldsTo_Public_Virtual_Final_New_Boolean_IPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPrompt>.NativeClassPtr, 100664870);
			SettingsPrompt.NativeMethodInfoPtr_get_DismissOnYield_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPrompt>.NativeClassPtr, 100664871);
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x0003F5BC File Offset: 0x0003D7BC
		public unsafe SettingsPromptTab StartingTab
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPrompt.NativeMethodInfoPtr_get_StartingTab_Public_get_SettingsPromptTab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x0003F5F8 File Offset: 0x0003D7F8
		// (set) Token: 0x06000AA9 RID: 2729 RVA: 0x0003F634 File Offset: 0x0003D834
		public unsafe virtual SettingsPromptResult Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_SettingsPromptResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_SettingsPromptResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0003F674 File Offset: 0x0003D874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 507231, RefRangeEnd = 507232, XrefRangeStart = 507212, XrefRangeEnd = 507231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsPrompt(SettingsPromptTab startingTab)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsPrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startingTab;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPrompt.NativeMethodInfoPtr__ctor_Public_Void_SettingsPromptTab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0003F6BC File Offset: 0x0003D8BC
		[CallerCount(0)]
		public unsafe virtual void Resolve(SettingsPromptResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_SettingsPromptResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0003F6FC File Offset: 0x0003D8FC
		[CallerCount(0)]
		public unsafe virtual void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0003F730 File Offset: 0x0003D930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507232, XrefRangeEnd = 507233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool YieldsTo(IPrompt otherPrompt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherPrompt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPrompt.NativeMethodInfoPtr_YieldsTo_Public_Virtual_Final_New_Boolean_IPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x0003F780 File Offset: 0x0003D980
		public unsafe virtual bool DismissOnYield
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPrompt.NativeMethodInfoPtr_get_DismissOnYield_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x000070D8 File Offset: 0x000052D8
		public SettingsPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x0003F7BC File Offset: 0x0003D9BC
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x000070E1 File Offset: 0x000052E1
		public unsafe SettingsPromptTab _StartingTab_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPrompt.NativeFieldInfoPtr__StartingTab_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPrompt.NativeFieldInfoPtr__StartingTab_k__BackingField)) = value;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x0003F7E4 File Offset: 0x0003D9E4
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x000070FC File Offset: 0x000052FC
		public unsafe SettingsPromptResult _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPrompt.NativeFieldInfoPtr__Result_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPrompt.NativeFieldInfoPtr__Result_k__BackingField)) = value;
			}
		}

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeFieldInfoPtr__StartingTab_k__BackingField;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr_get_StartingTab_Public_get_SettingsPromptTab_0;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_SettingsPromptResult_0;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_SettingsPromptResult_0;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SettingsPromptTab_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_SettingsPromptResult_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_YieldsTo_Public_Virtual_Final_New_Boolean_IPrompt_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr_get_DismissOnYield_Public_Virtual_Final_New_get_Boolean_0;
	}
}
