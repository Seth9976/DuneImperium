using System;
using System.Runtime.InteropServices;
using dbgclient.prompts;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.menus.prompts
{
	// Token: 0x02000201 RID: 513
	public class WaitingForPlayersPrompt : DBGTopLevelMenuPrompt
	{
		// Token: 0x0600178E RID: 6030 RVA: 0x0006A0E0 File Offset: 0x000682E0
		// Note: this type is marked as 'beforefieldinit'.
		static WaitingForPlayersPrompt()
		{
			Il2CppClassPointerStore<WaitingForPlayersPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "WaitingForPlayersPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitingForPlayersPrompt>.NativeClassPtr);
			WaitingForPlayersPrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			WaitingForPlayersPrompt.NativeFieldInfoPtr__DestinationShopTab_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPrompt>.NativeClassPtr, "<DestinationShopTab>k__BackingField");
			WaitingForPlayersPrompt.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitingForPlayersPrompt>.NativeClassPtr, "<Result>k__BackingField");
			WaitingForPlayersPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPrompt>.NativeClassPtr, 100666739);
			WaitingForPlayersPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPrompt>.NativeClassPtr, 100666740);
			WaitingForPlayersPrompt.NativeMethodInfoPtr_get_DestinationShopTab_Public_get_ShopPromptTab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPrompt>.NativeClassPtr, 100666741);
			WaitingForPlayersPrompt.NativeMethodInfoPtr_set_DestinationShopTab_Private_set_Void_ShopPromptTab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPrompt>.NativeClassPtr, 100666742);
			WaitingForPlayersPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_WaitingForPlayersResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPrompt>.NativeClassPtr, 100666743);
			WaitingForPlayersPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_WaitingForPlayersResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPrompt>.NativeClassPtr, 100666744);
			WaitingForPlayersPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPrompt>.NativeClassPtr, 100666745);
			WaitingForPlayersPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_WaitingForPlayersResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPrompt>.NativeClassPtr, 100666746);
			WaitingForPlayersPrompt.NativeMethodInfoPtr_Resolve_Public_Void_WaitingForPlayersResult_ShopPromptTab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPrompt>.NativeClassPtr, 100666747);
			WaitingForPlayersPrompt.NativeMethodInfoPtr_get_PlayerSlots_Public_Virtual_Final_New_get_IReadOnlyList_1_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitingForPlayersPrompt>.NativeClassPtr, 100666748);
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x0006A214 File Offset: 0x00068414
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 525294, RefRangeEnd = 525295, XrefRangeStart = 525284, XrefRangeEnd = 525294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitingForPlayersPrompt(DataComposition promptData, [Optional] Il2CppStringArray additionalFlavors)
		{
			if (additionalFlavors == null)
			{
				additionalFlavors = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitingForPlayersPrompt>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalFlavors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001790 RID: 6032 RVA: 0x0006A280 File Offset: 0x00068480
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001791 RID: 6033 RVA: 0x0006A2C0 File Offset: 0x000684C0
		// (set) Token: 0x06001792 RID: 6034 RVA: 0x0006A2FC File Offset: 0x000684FC
		public unsafe ShopPromptTab DestinationShopTab
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPrompt.NativeMethodInfoPtr_get_DestinationShopTab_Public_get_ShopPromptTab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPrompt.NativeMethodInfoPtr_set_DestinationShopTab_Private_set_Void_ShopPromptTab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001793 RID: 6035 RVA: 0x0006A33C File Offset: 0x0006853C
		// (set) Token: 0x06001794 RID: 6036 RVA: 0x0006A378 File Offset: 0x00068578
		public unsafe virtual WaitingForPlayersResult Result
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 134006, RefRangeEnd = 134007, XrefRangeStart = 134006, XrefRangeEnd = 134007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_WaitingForPlayersResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_WaitingForPlayersResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x0006A3B8 File Offset: 0x000685B8
		[CallerCount(0)]
		public unsafe override void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitingForPlayersPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x0006A3F4 File Offset: 0x000685F4
		[CallerCount(0)]
		public unsafe virtual void Resolve(WaitingForPlayersResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_WaitingForPlayersResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x0006A434 File Offset: 0x00068634
		[CallerCount(0)]
		public unsafe void Resolve(WaitingForPlayersResult result, ShopPromptTab destinationTab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref result;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationTab;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPrompt.NativeMethodInfoPtr_Resolve_Public_Void_WaitingForPlayersResult_ShopPromptTab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x0006A480 File Offset: 0x00068680
		public unsafe virtual IReadOnlyList<DataComposition> PlayerSlots
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525295, XrefRangeEnd = 525298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitingForPlayersPrompt.NativeMethodInfoPtr_get_PlayerSlots_Public_Virtual_Final_New_get_IReadOnlyList_1_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DataComposition>>(intPtr3) : null;
			}
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x0000D206 File Offset: 0x0000B406
		public WaitingForPlayersPrompt(DataComposition promptData, params string[] additionalFlavors)
			: this(promptData, new Il2CppStringArray(additionalFlavors))
		{
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x0000D215 File Offset: 0x0000B415
		public WaitingForPlayersPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x0600179B RID: 6043 RVA: 0x0006A4C0 File Offset: 0x000686C0
		// (set) Token: 0x0600179C RID: 6044 RVA: 0x0000D21E File Offset: 0x0000B41E
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x0600179D RID: 6045 RVA: 0x0006A4F0 File Offset: 0x000686F0
		// (set) Token: 0x0600179E RID: 6046 RVA: 0x0000D23D File Offset: 0x0000B43D
		public unsafe ShopPromptTab _DestinationShopTab_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPrompt.NativeFieldInfoPtr__DestinationShopTab_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPrompt.NativeFieldInfoPtr__DestinationShopTab_k__BackingField)) = value;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x0006A518 File Offset: 0x00068718
		// (set) Token: 0x060017A0 RID: 6048 RVA: 0x0000D258 File Offset: 0x0000B458
		public unsafe WaitingForPlayersResult _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPrompt.NativeFieldInfoPtr__Result_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitingForPlayersPrompt.NativeFieldInfoPtr__Result_k__BackingField)) = value;
			}
		}

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeFieldInfoPtr__DestinationShopTab_k__BackingField;

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_Il2CppStringArray_0;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeMethodInfoPtr_get_DestinationShopTab_Public_get_ShopPromptTab_0;

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeMethodInfoPtr_set_DestinationShopTab_Private_set_Void_ShopPromptTab_0;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_WaitingForPlayersResult_0;

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_WaitingForPlayersResult_0;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Virtual_Void_0;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_WaitingForPlayersResult_0;

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Void_WaitingForPlayersResult_ShopPromptTab_0;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerSlots_Public_Virtual_Final_New_get_IReadOnlyList_1_DataComposition_0;
	}
}
