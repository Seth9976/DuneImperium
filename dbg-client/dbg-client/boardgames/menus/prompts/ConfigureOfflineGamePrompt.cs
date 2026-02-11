using System;
using boardgames.data;
using Canis;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.menus.prompts
{
	// Token: 0x020001E4 RID: 484
	public class ConfigureOfflineGamePrompt : ConfigureGamePrompt
	{
		// Token: 0x060016AC RID: 5804 RVA: 0x00066DAC File Offset: 0x00064FAC
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigureOfflineGamePrompt()
		{
			Il2CppClassPointerStore<ConfigureOfflineGamePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "ConfigureOfflineGamePrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureOfflineGamePrompt>.NativeClassPtr);
			ConfigureOfflineGamePrompt.NativeFieldInfoPtr_MatchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureOfflineGamePrompt>.NativeClassPtr, "MatchData");
			ConfigureOfflineGamePrompt.NativeFieldInfoPtr_matchInitOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureOfflineGamePrompt>.NativeClassPtr, "matchInitOverride");
			ConfigureOfflineGamePrompt.NativeFieldInfoPtr__ConfigureOfflineResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureOfflineGamePrompt>.NativeClassPtr, "<ConfigureOfflineResult>k__BackingField");
			ConfigureOfflineGamePrompt.NativeMethodInfoPtr_get_Match_Public_get_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureOfflineGamePrompt>.NativeClassPtr, 100666618);
			ConfigureOfflineGamePrompt.NativeMethodInfoPtr__ctor_Public_Void_SerializedMatchComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureOfflineGamePrompt>.NativeClassPtr, 100666619);
			ConfigureOfflineGamePrompt.NativeMethodInfoPtr__ctor_Public_Void_SerializedMatchComponent_IReturnablePrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureOfflineGamePrompt>.NativeClassPtr, 100666620);
			ConfigureOfflineGamePrompt.NativeMethodInfoPtr_GetAvailablePlayerTypes_Public_Virtual_List_1_PlayerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureOfflineGamePrompt>.NativeClassPtr, 100666621);
			ConfigureOfflineGamePrompt.NativeMethodInfoPtr_get_ConfigureOfflineResult_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureOfflineGamePrompt>.NativeClassPtr, 100666622);
			ConfigureOfflineGamePrompt.NativeMethodInfoPtr_set_ConfigureOfflineResult_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureOfflineGamePrompt>.NativeClassPtr, 100666623);
			ConfigureOfflineGamePrompt.NativeMethodInfoPtr_Resolve_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureOfflineGamePrompt>.NativeClassPtr, 100666624);
			ConfigureOfflineGamePrompt.NativeMethodInfoPtr_OverrideMatch_Public_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureOfflineGamePrompt>.NativeClassPtr, 100666625);
			ConfigureOfflineGamePrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureOfflineGamePrompt>.NativeClassPtr, 100666626);
			ConfigureOfflineGamePrompt.NativeMethodInfoPtr_AILevelForPlayerType_Private_Int32_DBGMatchConfigData_PlayerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureOfflineGamePrompt>.NativeClassPtr, 100666627);
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x060016AD RID: 5805 RVA: 0x00066EE0 File Offset: 0x000650E0
		public unsafe MatchInitData Match
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 524720, RefRangeEnd = 524721, XrefRangeStart = 524720, XrefRangeEnd = 524720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureOfflineGamePrompt.NativeMethodInfoPtr_get_Match_Public_get_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
			}
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00066F20 File Offset: 0x00065120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524721, XrefRangeEnd = 524722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigureOfflineGamePrompt(SerializedMatchComponent matchData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureOfflineGamePrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureOfflineGamePrompt.NativeMethodInfoPtr__ctor_Public_Void_SerializedMatchComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00066F6C File Offset: 0x0006516C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 524817, RefRangeEnd = 524819, XrefRangeStart = 524722, XrefRangeEnd = 524817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigureOfflineGamePrompt(SerializedMatchComponent matchData, IReturnablePrompt backToPrompt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureOfflineGamePrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(backToPrompt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureOfflineGamePrompt.NativeMethodInfoPtr__ctor_Public_Void_SerializedMatchComponent_IReturnablePrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00066FCC File Offset: 0x000651CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524819, XrefRangeEnd = 524834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<PlayerTypeData.PlayerType> GetAvailablePlayerTypes(int slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref slot;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureOfflineGamePrompt.NativeMethodInfoPtr_GetAvailablePlayerTypes_Public_Virtual_List_1_PlayerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PlayerTypeData.PlayerType>>(intPtr3) : null;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x060016B1 RID: 5809 RVA: 0x00067024 File Offset: 0x00065224
		// (set) Token: 0x060016B2 RID: 5810 RVA: 0x00067060 File Offset: 0x00065260
		public unsafe bool ConfigureOfflineResult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureOfflineGamePrompt.NativeMethodInfoPtr_get_ConfigureOfflineResult_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureOfflineGamePrompt.NativeMethodInfoPtr_set_ConfigureOfflineResult_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x000670A0 File Offset: 0x000652A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 524874, RefRangeEnd = 524878, XrefRangeStart = 524834, XrefRangeEnd = 524874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resolve(bool result, bool alreadyConfigured = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref result;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alreadyConfigured;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureOfflineGamePrompt.NativeMethodInfoPtr_Resolve_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x000670EC File Offset: 0x000652EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideMatch(MatchInitData newMatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newMatch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureOfflineGamePrompt.NativeMethodInfoPtr_OverrideMatch_Public_Void_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x00067130 File Offset: 0x00065330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 524878, XrefRangeEnd = 524879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureOfflineGamePrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x0006716C File Offset: 0x0006536C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 524883, RefRangeEnd = 524884, XrefRangeStart = 524879, XrefRangeEnd = 524883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AILevelForPlayerType(DBGMatchConfigData matchConfigData, PlayerTypeData.PlayerType playerType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchConfigData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureOfflineGamePrompt.NativeMethodInfoPtr_AILevelForPlayerType_Private_Int32_DBGMatchConfigData_PlayerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x0000CC7F File Offset: 0x0000AE7F
		public ConfigureOfflineGamePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060016B8 RID: 5816 RVA: 0x000671C8 File Offset: 0x000653C8
		// (set) Token: 0x060016B9 RID: 5817 RVA: 0x0000CC88 File Offset: 0x0000AE88
		public unsafe SerializedMatchComponent MatchData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureOfflineGamePrompt.NativeFieldInfoPtr_MatchData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedMatchComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureOfflineGamePrompt.NativeFieldInfoPtr_MatchData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x000671F8 File Offset: 0x000653F8
		// (set) Token: 0x060016BB RID: 5819 RVA: 0x0000CCA7 File Offset: 0x0000AEA7
		public unsafe MatchInitData matchInitOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureOfflineGamePrompt.NativeFieldInfoPtr_matchInitOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureOfflineGamePrompt.NativeFieldInfoPtr_matchInitOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x060016BC RID: 5820 RVA: 0x00067228 File Offset: 0x00065428
		// (set) Token: 0x060016BD RID: 5821 RVA: 0x0000CCC6 File Offset: 0x0000AEC6
		public unsafe bool _ConfigureOfflineResult_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureOfflineGamePrompt.NativeFieldInfoPtr__ConfigureOfflineResult_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureOfflineGamePrompt.NativeFieldInfoPtr__ConfigureOfflineResult_k__BackingField)) = value;
			}
		}

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeFieldInfoPtr_MatchData;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeFieldInfoPtr_matchInitOverride;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeFieldInfoPtr__ConfigureOfflineResult_k__BackingField;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeMethodInfoPtr_get_Match_Public_get_MatchInitData_0;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedMatchComponent_0;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedMatchComponent_IReturnablePrompt_0;

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeMethodInfoPtr_GetAvailablePlayerTypes_Public_Virtual_List_1_PlayerType_Int32_0;

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigureOfflineResult_Public_get_Boolean_0;

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeMethodInfoPtr_set_ConfigureOfflineResult_Private_set_Void_Boolean_0;

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeMethodInfoPtr_OverrideMatch_Public_Void_MatchInitData_0;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Virtual_Void_0;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeMethodInfoPtr_AILevelForPlayerType_Private_Int32_DBGMatchConfigData_PlayerType_0;
	}
}
