using System;
using boardgames.data;
using Canis.utils.ids;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Networking.lobby;

namespace boardgames.menus.prompts
{
	// Token: 0x020001E3 RID: 483
	public class ConfigureGamePrompt : DBGTopLevelMenuPrompt
	{
		// Token: 0x06001696 RID: 5782 RVA: 0x0006684C File Offset: 0x00064A4C
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigureGamePrompt()
		{
			Il2CppClassPointerStore<ConfigureGamePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "ConfigureGamePrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureGamePrompt>.NativeClassPtr);
			ConfigureGamePrompt.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGamePrompt>.NativeClassPtr, "<Result>k__BackingField");
			ConfigureGamePrompt.NativeFieldInfoPtr__PlayerSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGamePrompt>.NativeClassPtr, "<PlayerSlots>k__BackingField");
			ConfigureGamePrompt.NativeFieldInfoPtr_RequiredFriend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGamePrompt>.NativeClassPtr, "RequiredFriend");
			ConfigureGamePrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureGamePrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			ConfigureGamePrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_CreateLobbyGame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePrompt>.NativeClassPtr, 100666606);
			ConfigureGamePrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_CreateLobbyGame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePrompt>.NativeClassPtr, 100666607);
			ConfigureGamePrompt.NativeMethodInfoPtr_get_PlayerSlots_Public_Virtual_Final_New_get_IReadOnlyList_1_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePrompt>.NativeClassPtr, 100666608);
			ConfigureGamePrompt.NativeMethodInfoPtr_set_PlayerSlots_Protected_set_Void_IReadOnlyList_1_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePrompt>.NativeClassPtr, 100666609);
			ConfigureGamePrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePrompt>.NativeClassPtr, 100666610);
			ConfigureGamePrompt.NativeMethodInfoPtr__ctor_Public_Void_IReturnablePrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePrompt>.NativeClassPtr, 100666611);
			ConfigureGamePrompt.NativeMethodInfoPtr_GetAvailablePlayerTypes_Public_Virtual_New_List_1_PlayerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePrompt>.NativeClassPtr, 100666612);
			ConfigureGamePrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePrompt>.NativeClassPtr, 100666613);
			ConfigureGamePrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_CreateLobbyGame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePrompt>.NativeClassPtr, 100666614);
			ConfigureGamePrompt.NativeMethodInfoPtr_WithFlavor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePrompt>.NativeClassPtr, 100666615);
			ConfigureGamePrompt.NativeMethodInfoPtr_WithFlavors_Public_Void_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePrompt>.NativeClassPtr, 100666616);
			ConfigureGamePrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureGamePrompt>.NativeClassPtr, 100666617);
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001697 RID: 5783 RVA: 0x000669BC File Offset: 0x00064BBC
		// (set) Token: 0x06001698 RID: 5784 RVA: 0x000669FC File Offset: 0x00064BFC
		public unsafe virtual CreateLobbyGame Result
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_CreateLobbyGame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CreateLobbyGame>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_CreateLobbyGame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001699 RID: 5785 RVA: 0x00066A40 File Offset: 0x00064C40
		// (set) Token: 0x0600169A RID: 5786 RVA: 0x00066A80 File Offset: 0x00064C80
		public unsafe virtual IReadOnlyList<DataComposition> PlayerSlots
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePrompt.NativeMethodInfoPtr_get_PlayerSlots_Public_Virtual_Final_New_get_IReadOnlyList_1_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DataComposition>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePrompt.NativeMethodInfoPtr_set_PlayerSlots_Protected_set_Void_IReadOnlyList_1_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x00066AC4 File Offset: 0x00064CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524584, XrefRangeEnd = 524585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigureGamePrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureGamePrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x00066B00 File Offset: 0x00064D00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 524665, RefRangeEnd = 524667, XrefRangeStart = 524585, XrefRangeEnd = 524665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigureGamePrompt(IReturnablePrompt backToPrompt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureGamePrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(backToPrompt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePrompt.NativeMethodInfoPtr__ctor_Public_Void_IReturnablePrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x00066B4C File Offset: 0x00064D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524667, XrefRangeEnd = 524689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<PlayerTypeData.PlayerType> GetAvailablePlayerTypes(int slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref slot;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGamePrompt.NativeMethodInfoPtr_GetAvailablePlayerTypes_Public_Virtual_New_List_1_PlayerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PlayerTypeData.PlayerType>>(intPtr3) : null;
			}
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00066BA4 File Offset: 0x00064DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureGamePrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00066BE0 File Offset: 0x00064DE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 524568, RefRangeEnd = 524569, XrefRangeStart = 524568, XrefRangeEnd = 524569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resolve(CreateLobbyGame result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_CreateLobbyGame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00066C24 File Offset: 0x00064E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524689, XrefRangeEnd = 524696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WithFlavor(string flavor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(flavor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePrompt.NativeMethodInfoPtr_WithFlavor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00066C68 File Offset: 0x00064E68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 524719, RefRangeEnd = 524720, XrefRangeStart = 524696, XrefRangeEnd = 524719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WithFlavors(IEnumerable<string> flavors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(flavors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePrompt.NativeMethodInfoPtr_WithFlavors_Public_Void_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x060016A2 RID: 5794 RVA: 0x00066CAC File Offset: 0x00064EAC
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureGamePrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x0000CBFA File Offset: 0x0000ADFA
		public ConfigureGamePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x060016A4 RID: 5796 RVA: 0x00066CEC File Offset: 0x00064EEC
		// (set) Token: 0x060016A5 RID: 5797 RVA: 0x0000CC03 File Offset: 0x0000AE03
		public unsafe CreateLobbyGame _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePrompt.NativeFieldInfoPtr__Result_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreateLobbyGame>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePrompt.NativeFieldInfoPtr__Result_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x060016A6 RID: 5798 RVA: 0x00066D1C File Offset: 0x00064F1C
		// (set) Token: 0x060016A7 RID: 5799 RVA: 0x0000CC22 File Offset: 0x0000AE22
		public unsafe IReadOnlyList<DataComposition> _PlayerSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePrompt.NativeFieldInfoPtr__PlayerSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePrompt.NativeFieldInfoPtr__PlayerSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x00066D4C File Offset: 0x00064F4C
		// (set) Token: 0x060016A9 RID: 5801 RVA: 0x0000CC41 File Offset: 0x0000AE41
		public unsafe AccountID RequiredFriend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePrompt.NativeFieldInfoPtr_RequiredFriend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePrompt.NativeFieldInfoPtr_RequiredFriend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x060016AA RID: 5802 RVA: 0x00066D7C File Offset: 0x00064F7C
		// (set) Token: 0x060016AB RID: 5803 RVA: 0x0000CC60 File Offset: 0x0000AE60
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureGamePrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E03 RID: 3587
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x04000E04 RID: 3588
		private static readonly IntPtr NativeFieldInfoPtr__PlayerSlots_k__BackingField;

		// Token: 0x04000E05 RID: 3589
		private static readonly IntPtr NativeFieldInfoPtr_RequiredFriend;

		// Token: 0x04000E06 RID: 3590
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_CreateLobbyGame_0;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_CreateLobbyGame_0;

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerSlots_Public_Virtual_Final_New_get_IReadOnlyList_1_DataComposition_0;

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerSlots_Protected_set_Void_IReadOnlyList_1_DataComposition_0;

		// Token: 0x04000E0B RID: 3595
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E0C RID: 3596
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IReturnablePrompt_0;

		// Token: 0x04000E0D RID: 3597
		private static readonly IntPtr NativeMethodInfoPtr_GetAvailablePlayerTypes_Public_Virtual_New_List_1_PlayerType_Int32_0;

		// Token: 0x04000E0E RID: 3598
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Virtual_Void_0;

		// Token: 0x04000E0F RID: 3599
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_CreateLobbyGame_0;

		// Token: 0x04000E10 RID: 3600
		private static readonly IntPtr NativeMethodInfoPtr_WithFlavor_Public_Void_String_0;

		// Token: 0x04000E11 RID: 3601
		private static readonly IntPtr NativeMethodInfoPtr_WithFlavors_Public_Void_IEnumerable_1_String_0;

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;
	}
}
