using System;
using Canis;
using Canis.attributes;
using Canis.entities;
using Canis.json.events;
using Canis.selectionfilters;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages;
using Networking.selection.targetinformation;

namespace worm.canis.selectionfilters
{
	// Token: 0x0200000F RID: 15
	public class WormPlayerSelectionFiltering : PlayerSelectionFiltering
	{
		// Token: 0x060000CE RID: 206 RVA: 0x0006CC70 File Offset: 0x0006AE70
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayerSelectionFiltering()
		{
			Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.selectionfilters", "WormPlayerSelectionFiltering");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663621);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_SelectArchetype_Protected_Func_2_Entity_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663622);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_SelectAbility_Private_Func_2_Entity_Boolean_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663623);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_SelectEntity_Private_Func_2_Entity_Boolean_Func_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663624);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_SelectTroops_Protected_Func_2_TargetInformation_SelectionNodeFilterData_Func_1_IEnumerable_1_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663625);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseTroops_Public_WormSelectionFilter_Int32_Int32_Int32_Func_1_IEnumerable_1_Entity_AbilityID_String_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663626);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseAbility_Public_WormSelectionFilter_Int32_Int32_AbilityID_String_Func_1_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663627);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseAbilityTarget_Public_WormSelectionFilter_Int32_Int32_AbilityID_String_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663628);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseAbilityWithString_Public_WormSelectionFilter_Int32_Int32_AbilityID_String_String_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663629);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseAbilityWithArchetypeTarget_Public_WormSelectionFilter_Int32_Int32_AbilityID_ArchetypeID_String_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663630);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseAbilityWithEntityTarget_Public_WormSelectionFilter_Int32_Int32_AbilityID_Func_1_Entity_String_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663631);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseArchetype_Public_WormSelectionFilter_Int32_Int32_ArchetypeID_String_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663632);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseArchetypeWithString_Public_WormSelectionFilter_Int32_Int32_ArchetypeID_String_String_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663633);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseArchetypeTarget_Public_WormSelectionFilter_Int32_Int32_ArchetypeID_String_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663634);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseArchetypeTargetWithArchetype_Public_WormSelectionFilter_Int32_Int32_ArchetypeID_ArchetypeID_String_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663635);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseArchetypeTargetWithArchetype_Public_WormSelectionFilter_Int32_Int32_ArchetypeID_ArchetypeID_List_1_String_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663636);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseCustomWithArchetype_Public_WormSelectionFilter_Int32_Int32_Func_2_Entity_Boolean_ArchetypeID_String_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663637);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseAmount_Public_WormSelectionFilter_Int32_Int32_Int32_String_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663638);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseEntityTarget_Public_WormSelectionFilter_Int32_Int32_Func_1_Entity_String_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663639);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseStringValue_Public_WormSelectionFilter_Int32_Int32_String_String_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663640);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseAccept_Public_WormSelectionFilter_Int32_Int32_String_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663641);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseSkip_Public_WormSelectionFilter_Int32_Int32_String_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663642);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_ForceSkip_Public_WormSelectionFilter_Int32_Int32_String_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663643);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_ClearSelections_Public_WormSelectionFilter_Int32_Int32_String_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663644);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_HasSkipSelection_Private_Boolean_SelectionWithTargetsRequired_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663645);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_SelectAccept_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663646);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_SelectSkip_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663647);
			WormPlayerSelectionFiltering.NativeMethodInfoPtr_ForceSkip_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, 100663648);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0006CED0 File Offset: 0x0006B0D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30430, RefRangeEnd = 30431, XrefRangeStart = 30429, XrefRangeEnd = 30430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerSelectionFiltering(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0006CF1C File Offset: 0x0006B11C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 30442, RefRangeEnd = 30451, XrefRangeStart = 30431, XrefRangeEnd = 30442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func<Entity, bool> SelectArchetype(ArchetypeID archID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_SelectArchetype_Protected_Func_2_Entity_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr3) : null;
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0006CF6C File Offset: 0x0006B16C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 30462, RefRangeEnd = 30471, XrefRangeStart = 30451, XrefRangeEnd = 30462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func<Entity, bool> SelectAbility(AbilityID abilityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(abilityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_SelectAbility_Private_Func_2_Entity_Boolean_AbilityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr3) : null;
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0006CFBC File Offset: 0x0006B1BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30471, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func<Entity, bool> SelectEntity(Func<Entity> entityGen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityGen);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_SelectEntity_Private_Func_2_Entity_Boolean_Func_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr3) : null;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0006D00C File Offset: 0x0006B20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30484, XrefRangeEnd = 30495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func<TargetInformation, SelectionNodeFilterData> SelectTroops(Func<IEnumerable<Entity>> troops, int numTroops)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(troops);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numTroops;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_SelectTroops_Protected_Func_2_TargetInformation_SelectionNodeFilterData_Func_1_IEnumerable_1_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<TargetInformation, SelectionNodeFilterData>>(intPtr3) : null;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0006D06C File Offset: 0x0006B26C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 30519, RefRangeEnd = 30525, XrefRangeStart = 30495, XrefRangeEnd = 30519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionFilter ChooseTroops(int round, int turn, int numTroops, Func<IEnumerable<Entity>> troops, AbilityID abilityID, string prompt, Func<bool> additionalCheck = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref round;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numTroops;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(troops);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abilityID);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseTroops_Public_WormSelectionFilter_Int32_Int32_Int32_Func_1_IEnumerable_1_Entity_AbilityID_String_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectionFilter>(intPtr3) : null;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0006D120 File Offset: 0x0006B320
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 30548, RefRangeEnd = 30555, XrefRangeStart = 30525, XrefRangeEnd = 30548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionFilter ChooseAbility(int round, int turn, AbilityID abilityID, string prompt, Func<bool> additionalCheck = null, bool forced = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref round;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abilityID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCheck);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseAbility_Public_WormSelectionFilter_Int32_Int32_AbilityID_String_Func_1_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectionFilter>(intPtr3) : null;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0006D1C0 File Offset: 0x0006B3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30555, XrefRangeEnd = 30578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionFilter ChooseAbilityTarget(int round, int turn, AbilityID abilityID, string prompt, Func<bool> additionalCheck = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref round;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abilityID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseAbilityTarget_Public_WormSelectionFilter_Int32_Int32_AbilityID_String_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectionFilter>(intPtr3) : null;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0006D254 File Offset: 0x0006B454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30602, RefRangeEnd = 30603, XrefRangeStart = 30578, XrefRangeEnd = 30602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionFilter ChooseAbilityWithString(int round, int turn, AbilityID abilityID, string choice, string prompt, Func<bool> additionalCheck = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref round;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abilityID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choice);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseAbilityWithString_Public_WormSelectionFilter_Int32_Int32_AbilityID_String_String_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectionFilter>(intPtr3) : null;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0006D2FC File Offset: 0x0006B4FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30627, RefRangeEnd = 30628, XrefRangeStart = 30603, XrefRangeEnd = 30627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionFilter ChooseAbilityWithArchetypeTarget(int round, int turn, AbilityID abilityID, ArchetypeID archID, string prompt, Func<bool> additionalCheck = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref round;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abilityID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseAbilityWithArchetypeTarget_Public_WormSelectionFilter_Int32_Int32_AbilityID_ArchetypeID_String_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectionFilter>(intPtr3) : null;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0006D3A4 File Offset: 0x0006B5A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 30652, RefRangeEnd = 30654, XrefRangeStart = 30628, XrefRangeEnd = 30652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionFilter ChooseAbilityWithEntityTarget(int round, int turn, AbilityID abilityID, Func<Entity> entityGen, string prompt, Func<bool> additionalCheck = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref round;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abilityID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entityGen);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseAbilityWithEntityTarget_Public_WormSelectionFilter_Int32_Int32_AbilityID_Func_1_Entity_String_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectionFilter>(intPtr3) : null;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0006D44C File Offset: 0x0006B64C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 30677, RefRangeEnd = 30687, XrefRangeStart = 30654, XrefRangeEnd = 30677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionFilter ChooseArchetype(int round, int turn, ArchetypeID archID, string prompt, Func<bool> additionalCheck = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref round;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseArchetype_Public_WormSelectionFilter_Int32_Int32_ArchetypeID_String_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectionFilter>(intPtr3) : null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0006D4E0 File Offset: 0x0006B6E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30711, RefRangeEnd = 30712, XrefRangeStart = 30687, XrefRangeEnd = 30711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionFilter ChooseArchetypeWithString(int round, int turn, ArchetypeID archID, string choice, string prompt, Func<bool> additionalCheck = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref round;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choice);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseArchetypeWithString_Public_WormSelectionFilter_Int32_Int32_ArchetypeID_String_String_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectionFilter>(intPtr3) : null;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0006D588 File Offset: 0x0006B788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30735, RefRangeEnd = 30736, XrefRangeStart = 30712, XrefRangeEnd = 30735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionFilter ChooseArchetypeTarget(int round, int turn, ArchetypeID archID, string prompt, Func<bool> additionalCheck = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref round;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(archID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseArchetypeTarget_Public_WormSelectionFilter_Int32_Int32_ArchetypeID_String_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectionFilter>(intPtr3) : null;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0006D61C File Offset: 0x0006B81C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 30760, RefRangeEnd = 30774, XrefRangeStart = 30736, XrefRangeEnd = 30760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionFilter ChooseArchetypeTargetWithArchetype(int round, int turn, ArchetypeID firstID, ArchetypeID secondID, string prompt, Func<bool> additionalCheck = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref round;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseArchetypeTargetWithArchetype_Public_WormSelectionFilter_Int32_Int32_ArchetypeID_ArchetypeID_String_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectionFilter>(intPtr3) : null;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0006D6C4 File Offset: 0x0006B8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30774, XrefRangeEnd = 30809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionFilter ChooseArchetypeTargetWithArchetype(int round, int turn, ArchetypeID firstID, ArchetypeID secondID, List<string> prompts, Func<bool> additionalCheck = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref round;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prompts);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseArchetypeTargetWithArchetype_Public_WormSelectionFilter_Int32_Int32_ArchetypeID_ArchetypeID_List_1_String_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectionFilter>(intPtr3) : null;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0006D76C File Offset: 0x0006B96C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30833, RefRangeEnd = 30834, XrefRangeStart = 30809, XrefRangeEnd = 30833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionFilter ChooseCustomWithArchetype(int round, int turn, Func<Entity, bool> filter, ArchetypeID secondID, string prompt, Func<bool> additionalCheck = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref round;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseCustomWithArchetype_Public_WormSelectionFilter_Int32_Int32_Func_2_Entity_Boolean_ArchetypeID_String_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectionFilter>(intPtr3) : null;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0006D814 File Offset: 0x0006BA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30834, XrefRangeEnd = 30856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionFilter ChooseAmount(int round, int turn, int amount, string prompt, Func<bool> additionalCheck = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref round;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseAmount_Public_WormSelectionFilter_Int32_Int32_Int32_String_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectionFilter>(intPtr3) : null;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0006D8A4 File Offset: 0x0006BAA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30879, RefRangeEnd = 30880, XrefRangeStart = 30856, XrefRangeEnd = 30879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionFilter ChooseEntityTarget(int round, int turn, Func<Entity> entityGen, string prompt, Func<bool> additionalCheck = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref round;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entityGen);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseEntityTarget_Public_WormSelectionFilter_Int32_Int32_Func_1_Entity_String_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectionFilter>(intPtr3) : null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0006D938 File Offset: 0x0006BB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30880, XrefRangeEnd = 30903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionFilter ChooseStringValue(int round, int turn, string stringValue, string prompt, Func<bool> additionalCheck = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref round;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stringValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseStringValue_Public_WormSelectionFilter_Int32_Int32_String_String_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectionFilter>(intPtr3) : null;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0006D9CC File Offset: 0x0006BBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30903, XrefRangeEnd = 30924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionFilter ChooseAccept(int round, int turn, string prompt, Func<bool> additionalCheck = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref round;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseAccept_Public_WormSelectionFilter_Int32_Int32_String_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectionFilter>(intPtr3) : null;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0006DA4C File Offset: 0x0006BC4C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30945, RefRangeEnd = 30965, XrefRangeStart = 30924, XrefRangeEnd = 30945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionFilter ChooseSkip(int round, int turn, string prompt, Func<bool> additionalCheck = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref round;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_ChooseSkip_Public_WormSelectionFilter_Int32_Int32_String_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectionFilter>(intPtr3) : null;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0006DACC File Offset: 0x0006BCCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 30986, RefRangeEnd = 30989, XrefRangeStart = 30965, XrefRangeEnd = 30986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionFilter ForceSkip(int round, int turn, string prompt, Func<bool> additionalCheck = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref round;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_ForceSkip_Public_WormSelectionFilter_Int32_Int32_String_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectionFilter>(intPtr3) : null;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0006DB4C File Offset: 0x0006BD4C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 31019, RefRangeEnd = 31028, XrefRangeStart = 30989, XrefRangeEnd = 31019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectionFilter ClearSelections(int round, int turn, string prompt, Func<bool> additionalCheck = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref round;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_ClearSelections_Public_WormSelectionFilter_Int32_Int32_String_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectionFilter>(intPtr3) : null;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0006DBCC File Offset: 0x0006BDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31028, XrefRangeEnd = 31038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSkipSelection(SelectionWithTargetsRequired swtr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(swtr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_HasSkipSelection_Private_Boolean_SelectionWithTargetsRequired_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0006DC1C File Offset: 0x0006BE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31038, XrefRangeEnd = 31043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<IAttribute> SelectAccept(NetworkMessageEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_SelectAccept_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0006DC6C File Offset: 0x0006BE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31043, XrefRangeEnd = 31050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<IAttribute> SelectSkip(NetworkMessageEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_SelectSkip_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0006DCBC File Offset: 0x0006BEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31050, XrefRangeEnd = 31057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<IAttribute> ForceSkip(NetworkMessageEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.NativeMethodInfoPtr_ForceSkip_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000232F File Offset: 0x0000052F
		public WormPlayerSelectionFiltering(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_SelectArchetype_Protected_Func_2_Entity_Boolean_ArchetypeID_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_SelectAbility_Private_Func_2_Entity_Boolean_AbilityID_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_SelectEntity_Private_Func_2_Entity_Boolean_Func_1_Entity_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_SelectTroops_Protected_Func_2_TargetInformation_SelectionNodeFilterData_Func_1_IEnumerable_1_Entity_Int32_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_ChooseTroops_Public_WormSelectionFilter_Int32_Int32_Int32_Func_1_IEnumerable_1_Entity_AbilityID_String_Func_1_Boolean_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_ChooseAbility_Public_WormSelectionFilter_Int32_Int32_AbilityID_String_Func_1_Boolean_Boolean_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_ChooseAbilityTarget_Public_WormSelectionFilter_Int32_Int32_AbilityID_String_Func_1_Boolean_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_ChooseAbilityWithString_Public_WormSelectionFilter_Int32_Int32_AbilityID_String_String_Func_1_Boolean_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_ChooseAbilityWithArchetypeTarget_Public_WormSelectionFilter_Int32_Int32_AbilityID_ArchetypeID_String_Func_1_Boolean_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_ChooseAbilityWithEntityTarget_Public_WormSelectionFilter_Int32_Int32_AbilityID_Func_1_Entity_String_Func_1_Boolean_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_ChooseArchetype_Public_WormSelectionFilter_Int32_Int32_ArchetypeID_String_Func_1_Boolean_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_ChooseArchetypeWithString_Public_WormSelectionFilter_Int32_Int32_ArchetypeID_String_String_Func_1_Boolean_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_ChooseArchetypeTarget_Public_WormSelectionFilter_Int32_Int32_ArchetypeID_String_Func_1_Boolean_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_ChooseArchetypeTargetWithArchetype_Public_WormSelectionFilter_Int32_Int32_ArchetypeID_ArchetypeID_String_Func_1_Boolean_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_ChooseArchetypeTargetWithArchetype_Public_WormSelectionFilter_Int32_Int32_ArchetypeID_ArchetypeID_List_1_String_Func_1_Boolean_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_ChooseCustomWithArchetype_Public_WormSelectionFilter_Int32_Int32_Func_2_Entity_Boolean_ArchetypeID_String_Func_1_Boolean_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_ChooseAmount_Public_WormSelectionFilter_Int32_Int32_Int32_String_Func_1_Boolean_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_ChooseEntityTarget_Public_WormSelectionFilter_Int32_Int32_Func_1_Entity_String_Func_1_Boolean_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_ChooseStringValue_Public_WormSelectionFilter_Int32_Int32_String_String_Func_1_Boolean_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_ChooseAccept_Public_WormSelectionFilter_Int32_Int32_String_Func_1_Boolean_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_ChooseSkip_Public_WormSelectionFilter_Int32_Int32_String_Func_1_Boolean_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_ForceSkip_Public_WormSelectionFilter_Int32_Int32_String_Func_1_Boolean_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_ClearSelections_Public_WormSelectionFilter_Int32_Int32_String_Func_1_Boolean_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_HasSkipSelection_Private_Boolean_SelectionWithTargetsRequired_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_SelectAccept_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_SelectSkip_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_ForceSkip_Protected_IEnumerable_1_IAttribute_NetworkMessageEvent_0;

		// Token: 0x0200056C RID: 1388
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600429F RID: 17055 RVA: 0x0017D10C File Offset: 0x0017B30C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c>.NativeClassPtr, "<>9");
				WormPlayerSelectionFiltering.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c>.NativeClassPtr, "<>9__4_1");
				WormPlayerSelectionFiltering.__c.NativeFieldInfoPtr___9__23_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c>.NativeClassPtr, "<>9__23_1");
				WormPlayerSelectionFiltering.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c>.NativeClassPtr, 100663650);
				WormPlayerSelectionFiltering.__c.NativeMethodInfoPtr__SelectTroops_b__4_1_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c>.NativeClassPtr, 100663651);
				WormPlayerSelectionFiltering.__c.NativeMethodInfoPtr__ClearSelections_b__23_1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c>.NativeClassPtr, 100663652);
			}

			// Token: 0x060042A0 RID: 17056 RVA: 0x0017D1B0 File Offset: 0x0017B3B0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060042A1 RID: 17057 RVA: 0x0017D1EC File Offset: 0x0017B3EC
			[CallerCount(0)]
			public unsafe EntityID _SelectTroops_b__4_1(Entity troop)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(troop);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c.NativeMethodInfoPtr__SelectTroops_b__4_1_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060042A2 RID: 17058 RVA: 0x0017D23C File Offset: 0x0017B43C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30180, XrefRangeEnd = 30183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IAttribute> _ClearSelections_b__23_1(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c.NativeMethodInfoPtr__ClearSelections_b__23_1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
				}
			}

			// Token: 0x060042A3 RID: 17059 RVA: 0x00015815 File Offset: 0x00013A15
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FB7 RID: 4023
			// (get) Token: 0x060042A4 RID: 17060 RVA: 0x0017D28C File Offset: 0x0017B48C
			// (set) Token: 0x060042A5 RID: 17061 RVA: 0x0001581E File Offset: 0x00013A1E
			public unsafe static WormPlayerSelectionFiltering.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayerSelectionFiltering.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerSelectionFiltering.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayerSelectionFiltering.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FB8 RID: 4024
			// (get) Token: 0x060042A6 RID: 17062 RVA: 0x0017D2B4 File Offset: 0x0017B4B4
			// (set) Token: 0x060042A7 RID: 17063 RVA: 0x00015830 File Offset: 0x00013A30
			public unsafe static Func<Entity, EntityID> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayerSelectionFiltering.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayerSelectionFiltering.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FB9 RID: 4025
			// (get) Token: 0x060042A8 RID: 17064 RVA: 0x0017D2DC File Offset: 0x0017B4DC
			// (set) Token: 0x060042A9 RID: 17065 RVA: 0x00015842 File Offset: 0x00013A42
			public unsafe static GetAttrsFunc __9__23_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayerSelectionFiltering.__c.NativeFieldInfoPtr___9__23_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetAttrsFunc>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayerSelectionFiltering.__c.NativeFieldInfoPtr___9__23_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C2B RID: 11307
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002C2C RID: 11308
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x04002C2D RID: 11309
			private static readonly IntPtr NativeFieldInfoPtr___9__23_1;

			// Token: 0x04002C2E RID: 11310
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C2F RID: 11311
			private static readonly IntPtr NativeMethodInfoPtr__SelectTroops_b__4_1_Internal_EntityID_Entity_0;

			// Token: 0x04002C30 RID: 11312
			private static readonly IntPtr NativeMethodInfoPtr__ClearSelections_b__23_1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0;
		}

		// Token: 0x0200056D RID: 1389
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x060042AA RID: 17066 RVA: 0x0017D304 File Offset: 0x0017B504
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass10_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass10_0.NativeFieldInfoPtr_additionalCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass10_0>.NativeClassPtr, "additionalCheck");
				WormPlayerSelectionFiltering.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				WormPlayerSelectionFiltering.__c__DisplayClass10_0.NativeFieldInfoPtr_abilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass10_0>.NativeClassPtr, "abilityID");
				WormPlayerSelectionFiltering.__c__DisplayClass10_0.NativeFieldInfoPtr_entityGen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass10_0>.NativeClassPtr, "entityGen");
				WormPlayerSelectionFiltering.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass10_0>.NativeClassPtr, 100663653);
				WormPlayerSelectionFiltering.__c__DisplayClass10_0.NativeMethodInfoPtr__ChooseAbilityWithEntityTarget_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass10_0>.NativeClassPtr, 100663654);
				WormPlayerSelectionFiltering.__c__DisplayClass10_0.NativeMethodInfoPtr__ChooseAbilityWithEntityTarget_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass10_0>.NativeClassPtr, 100663655);
			}

			// Token: 0x060042AB RID: 17067 RVA: 0x0017D3BC File Offset: 0x0017B5BC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060042AC RID: 17068 RVA: 0x0017D3F8 File Offset: 0x0017B5F8
			[CallerCount(0)]
			public unsafe bool _ChooseAbilityWithEntityTarget_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass10_0.NativeMethodInfoPtr__ChooseAbilityWithEntityTarget_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060042AD RID: 17069 RVA: 0x0017D434 File Offset: 0x0017B634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30183, XrefRangeEnd = 30192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IAttribute> _ChooseAbilityWithEntityTarget_b__1(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass10_0.NativeMethodInfoPtr__ChooseAbilityWithEntityTarget_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
				}
			}

			// Token: 0x060042AE RID: 17070 RVA: 0x00015854 File Offset: 0x00013A54
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FBA RID: 4026
			// (get) Token: 0x060042AF RID: 17071 RVA: 0x0017D484 File Offset: 0x0017B684
			// (set) Token: 0x060042B0 RID: 17072 RVA: 0x0001585D File Offset: 0x00013A5D
			public unsafe Func<bool> additionalCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass10_0.NativeFieldInfoPtr_additionalCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass10_0.NativeFieldInfoPtr_additionalCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FBB RID: 4027
			// (get) Token: 0x060042B1 RID: 17073 RVA: 0x0017D4B4 File Offset: 0x0017B6B4
			// (set) Token: 0x060042B2 RID: 17074 RVA: 0x0001587C File Offset: 0x00013A7C
			public unsafe WormPlayerSelectionFiltering __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerSelectionFiltering>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FBC RID: 4028
			// (get) Token: 0x060042B3 RID: 17075 RVA: 0x0017D4E4 File Offset: 0x0017B6E4
			// (set) Token: 0x060042B4 RID: 17076 RVA: 0x0001589B File Offset: 0x00013A9B
			public unsafe AbilityID abilityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass10_0.NativeFieldInfoPtr_abilityID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass10_0.NativeFieldInfoPtr_abilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FBD RID: 4029
			// (get) Token: 0x060042B5 RID: 17077 RVA: 0x0017D514 File Offset: 0x0017B714
			// (set) Token: 0x060042B6 RID: 17078 RVA: 0x000158BA File Offset: 0x00013ABA
			public unsafe Func<Entity> entityGen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass10_0.NativeFieldInfoPtr_entityGen);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass10_0.NativeFieldInfoPtr_entityGen), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C31 RID: 11313
			private static readonly IntPtr NativeFieldInfoPtr_additionalCheck;

			// Token: 0x04002C32 RID: 11314
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002C33 RID: 11315
			private static readonly IntPtr NativeFieldInfoPtr_abilityID;

			// Token: 0x04002C34 RID: 11316
			private static readonly IntPtr NativeFieldInfoPtr_entityGen;

			// Token: 0x04002C35 RID: 11317
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C36 RID: 11318
			private static readonly IntPtr NativeMethodInfoPtr__ChooseAbilityWithEntityTarget_b__0_Internal_Boolean_0;

			// Token: 0x04002C37 RID: 11319
			private static readonly IntPtr NativeMethodInfoPtr__ChooseAbilityWithEntityTarget_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0;
		}

		// Token: 0x0200056E RID: 1390
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x060042B7 RID: 17079 RVA: 0x0017D544 File Offset: 0x0017B744
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass11_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass11_0.NativeFieldInfoPtr_additionalCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass11_0>.NativeClassPtr, "additionalCheck");
				WormPlayerSelectionFiltering.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				WormPlayerSelectionFiltering.__c__DisplayClass11_0.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass11_0>.NativeClassPtr, "archID");
				WormPlayerSelectionFiltering.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass11_0>.NativeClassPtr, 100663656);
				WormPlayerSelectionFiltering.__c__DisplayClass11_0.NativeMethodInfoPtr__ChooseArchetype_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass11_0>.NativeClassPtr, 100663657);
				WormPlayerSelectionFiltering.__c__DisplayClass11_0.NativeMethodInfoPtr__ChooseArchetype_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass11_0>.NativeClassPtr, 100663658);
			}

			// Token: 0x060042B8 RID: 17080 RVA: 0x0017D5E8 File Offset: 0x0017B7E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060042B9 RID: 17081 RVA: 0x0017D624 File Offset: 0x0017B824
			[CallerCount(0)]
			public unsafe bool _ChooseArchetype_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass11_0.NativeMethodInfoPtr__ChooseArchetype_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060042BA RID: 17082 RVA: 0x0017D660 File Offset: 0x0017B860
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30192, XrefRangeEnd = 30194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IAttribute> _ChooseArchetype_b__1(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass11_0.NativeMethodInfoPtr__ChooseArchetype_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
				}
			}

			// Token: 0x060042BB RID: 17083 RVA: 0x000158D9 File Offset: 0x00013AD9
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FBE RID: 4030
			// (get) Token: 0x060042BC RID: 17084 RVA: 0x0017D6B0 File Offset: 0x0017B8B0
			// (set) Token: 0x060042BD RID: 17085 RVA: 0x000158E2 File Offset: 0x00013AE2
			public unsafe Func<bool> additionalCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass11_0.NativeFieldInfoPtr_additionalCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass11_0.NativeFieldInfoPtr_additionalCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FBF RID: 4031
			// (get) Token: 0x060042BE RID: 17086 RVA: 0x0017D6E0 File Offset: 0x0017B8E0
			// (set) Token: 0x060042BF RID: 17087 RVA: 0x00015901 File Offset: 0x00013B01
			public unsafe WormPlayerSelectionFiltering __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerSelectionFiltering>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FC0 RID: 4032
			// (get) Token: 0x060042C0 RID: 17088 RVA: 0x0017D710 File Offset: 0x0017B910
			// (set) Token: 0x060042C1 RID: 17089 RVA: 0x00015920 File Offset: 0x00013B20
			public unsafe ArchetypeID archID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass11_0.NativeFieldInfoPtr_archID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass11_0.NativeFieldInfoPtr_archID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C38 RID: 11320
			private static readonly IntPtr NativeFieldInfoPtr_additionalCheck;

			// Token: 0x04002C39 RID: 11321
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002C3A RID: 11322
			private static readonly IntPtr NativeFieldInfoPtr_archID;

			// Token: 0x04002C3B RID: 11323
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C3C RID: 11324
			private static readonly IntPtr NativeMethodInfoPtr__ChooseArchetype_b__0_Internal_Boolean_0;

			// Token: 0x04002C3D RID: 11325
			private static readonly IntPtr NativeMethodInfoPtr__ChooseArchetype_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0;
		}

		// Token: 0x0200056F RID: 1391
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x060042C2 RID: 17090 RVA: 0x0017D740 File Offset: 0x0017B940
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass12_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass12_0.NativeFieldInfoPtr_additionalCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass12_0>.NativeClassPtr, "additionalCheck");
				WormPlayerSelectionFiltering.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
				WormPlayerSelectionFiltering.__c__DisplayClass12_0.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass12_0>.NativeClassPtr, "archID");
				WormPlayerSelectionFiltering.__c__DisplayClass12_0.NativeFieldInfoPtr_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass12_0>.NativeClassPtr, "choice");
				WormPlayerSelectionFiltering.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass12_0>.NativeClassPtr, 100663659);
				WormPlayerSelectionFiltering.__c__DisplayClass12_0.NativeMethodInfoPtr__ChooseArchetypeWithString_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass12_0>.NativeClassPtr, 100663660);
				WormPlayerSelectionFiltering.__c__DisplayClass12_0.NativeMethodInfoPtr__ChooseArchetypeWithString_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass12_0>.NativeClassPtr, 100663661);
			}

			// Token: 0x060042C3 RID: 17091 RVA: 0x0017D7F8 File Offset: 0x0017B9F8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060042C4 RID: 17092 RVA: 0x0017D834 File Offset: 0x0017BA34
			[CallerCount(0)]
			public unsafe bool _ChooseArchetypeWithString_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass12_0.NativeMethodInfoPtr__ChooseArchetypeWithString_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060042C5 RID: 17093 RVA: 0x0017D870 File Offset: 0x0017BA70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30194, XrefRangeEnd = 30201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IAttribute> _ChooseArchetypeWithString_b__1(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass12_0.NativeMethodInfoPtr__ChooseArchetypeWithString_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
				}
			}

			// Token: 0x060042C6 RID: 17094 RVA: 0x0001593F File Offset: 0x00013B3F
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FC1 RID: 4033
			// (get) Token: 0x060042C7 RID: 17095 RVA: 0x0017D8C0 File Offset: 0x0017BAC0
			// (set) Token: 0x060042C8 RID: 17096 RVA: 0x00015948 File Offset: 0x00013B48
			public unsafe Func<bool> additionalCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass12_0.NativeFieldInfoPtr_additionalCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass12_0.NativeFieldInfoPtr_additionalCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FC2 RID: 4034
			// (get) Token: 0x060042C9 RID: 17097 RVA: 0x0017D8F0 File Offset: 0x0017BAF0
			// (set) Token: 0x060042CA RID: 17098 RVA: 0x00015967 File Offset: 0x00013B67
			public unsafe WormPlayerSelectionFiltering __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerSelectionFiltering>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FC3 RID: 4035
			// (get) Token: 0x060042CB RID: 17099 RVA: 0x0017D920 File Offset: 0x0017BB20
			// (set) Token: 0x060042CC RID: 17100 RVA: 0x00015986 File Offset: 0x00013B86
			public unsafe ArchetypeID archID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass12_0.NativeFieldInfoPtr_archID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass12_0.NativeFieldInfoPtr_archID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FC4 RID: 4036
			// (get) Token: 0x060042CD RID: 17101 RVA: 0x0017D950 File Offset: 0x0017BB50
			// (set) Token: 0x060042CE RID: 17102 RVA: 0x000159A5 File Offset: 0x00013BA5
			public unsafe string choice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass12_0.NativeFieldInfoPtr_choice);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass12_0.NativeFieldInfoPtr_choice), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04002C3E RID: 11326
			private static readonly IntPtr NativeFieldInfoPtr_additionalCheck;

			// Token: 0x04002C3F RID: 11327
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002C40 RID: 11328
			private static readonly IntPtr NativeFieldInfoPtr_archID;

			// Token: 0x04002C41 RID: 11329
			private static readonly IntPtr NativeFieldInfoPtr_choice;

			// Token: 0x04002C42 RID: 11330
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C43 RID: 11331
			private static readonly IntPtr NativeMethodInfoPtr__ChooseArchetypeWithString_b__0_Internal_Boolean_0;

			// Token: 0x04002C44 RID: 11332
			private static readonly IntPtr NativeMethodInfoPtr__ChooseArchetypeWithString_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0;
		}

		// Token: 0x02000570 RID: 1392
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x060042CF RID: 17103 RVA: 0x0017D978 File Offset: 0x0017BB78
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass13_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass13_0.NativeFieldInfoPtr_additionalCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass13_0>.NativeClassPtr, "additionalCheck");
				WormPlayerSelectionFiltering.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				WormPlayerSelectionFiltering.__c__DisplayClass13_0.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass13_0>.NativeClassPtr, "archID");
				WormPlayerSelectionFiltering.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass13_0>.NativeClassPtr, 100663662);
				WormPlayerSelectionFiltering.__c__DisplayClass13_0.NativeMethodInfoPtr__ChooseArchetypeTarget_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass13_0>.NativeClassPtr, 100663663);
				WormPlayerSelectionFiltering.__c__DisplayClass13_0.NativeMethodInfoPtr__ChooseArchetypeTarget_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass13_0>.NativeClassPtr, 100663664);
			}

			// Token: 0x060042D0 RID: 17104 RVA: 0x0017DA1C File Offset: 0x0017BC1C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060042D1 RID: 17105 RVA: 0x0017DA58 File Offset: 0x0017BC58
			[CallerCount(0)]
			public unsafe bool _ChooseArchetypeTarget_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass13_0.NativeMethodInfoPtr__ChooseArchetypeTarget_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060042D2 RID: 17106 RVA: 0x0017DA94 File Offset: 0x0017BC94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30201, XrefRangeEnd = 30204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IAttribute> _ChooseArchetypeTarget_b__1(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass13_0.NativeMethodInfoPtr__ChooseArchetypeTarget_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
				}
			}

			// Token: 0x060042D3 RID: 17107 RVA: 0x000159C4 File Offset: 0x00013BC4
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FC5 RID: 4037
			// (get) Token: 0x060042D4 RID: 17108 RVA: 0x0017DAE4 File Offset: 0x0017BCE4
			// (set) Token: 0x060042D5 RID: 17109 RVA: 0x000159CD File Offset: 0x00013BCD
			public unsafe Func<bool> additionalCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass13_0.NativeFieldInfoPtr_additionalCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass13_0.NativeFieldInfoPtr_additionalCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FC6 RID: 4038
			// (get) Token: 0x060042D6 RID: 17110 RVA: 0x0017DB14 File Offset: 0x0017BD14
			// (set) Token: 0x060042D7 RID: 17111 RVA: 0x000159EC File Offset: 0x00013BEC
			public unsafe WormPlayerSelectionFiltering __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerSelectionFiltering>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FC7 RID: 4039
			// (get) Token: 0x060042D8 RID: 17112 RVA: 0x0017DB44 File Offset: 0x0017BD44
			// (set) Token: 0x060042D9 RID: 17113 RVA: 0x00015A0B File Offset: 0x00013C0B
			public unsafe ArchetypeID archID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass13_0.NativeFieldInfoPtr_archID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass13_0.NativeFieldInfoPtr_archID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C45 RID: 11333
			private static readonly IntPtr NativeFieldInfoPtr_additionalCheck;

			// Token: 0x04002C46 RID: 11334
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002C47 RID: 11335
			private static readonly IntPtr NativeFieldInfoPtr_archID;

			// Token: 0x04002C48 RID: 11336
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C49 RID: 11337
			private static readonly IntPtr NativeMethodInfoPtr__ChooseArchetypeTarget_b__0_Internal_Boolean_0;

			// Token: 0x04002C4A RID: 11338
			private static readonly IntPtr NativeMethodInfoPtr__ChooseArchetypeTarget_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0;
		}

		// Token: 0x02000571 RID: 1393
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x060042DA RID: 17114 RVA: 0x0017DB74 File Offset: 0x0017BD74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass14_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass14_0.NativeFieldInfoPtr_additionalCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass14_0>.NativeClassPtr, "additionalCheck");
				WormPlayerSelectionFiltering.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				WormPlayerSelectionFiltering.__c__DisplayClass14_0.NativeFieldInfoPtr_firstID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass14_0>.NativeClassPtr, "firstID");
				WormPlayerSelectionFiltering.__c__DisplayClass14_0.NativeFieldInfoPtr_secondID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass14_0>.NativeClassPtr, "secondID");
				WormPlayerSelectionFiltering.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass14_0>.NativeClassPtr, 100663665);
				WormPlayerSelectionFiltering.__c__DisplayClass14_0.NativeMethodInfoPtr__ChooseArchetypeTargetWithArchetype_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass14_0>.NativeClassPtr, 100663666);
				WormPlayerSelectionFiltering.__c__DisplayClass14_0.NativeMethodInfoPtr__ChooseArchetypeTargetWithArchetype_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass14_0>.NativeClassPtr, 100663667);
			}

			// Token: 0x060042DB RID: 17115 RVA: 0x0017DC2C File Offset: 0x0017BE2C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060042DC RID: 17116 RVA: 0x0017DC68 File Offset: 0x0017BE68
			[CallerCount(0)]
			public unsafe bool _ChooseArchetypeTargetWithArchetype_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass14_0.NativeMethodInfoPtr__ChooseArchetypeTargetWithArchetype_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060042DD RID: 17117 RVA: 0x0017DCA4 File Offset: 0x0017BEA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30204, XrefRangeEnd = 30213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IAttribute> _ChooseArchetypeTargetWithArchetype_b__1(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass14_0.NativeMethodInfoPtr__ChooseArchetypeTargetWithArchetype_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
				}
			}

			// Token: 0x060042DE RID: 17118 RVA: 0x00015A2A File Offset: 0x00013C2A
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FC8 RID: 4040
			// (get) Token: 0x060042DF RID: 17119 RVA: 0x0017DCF4 File Offset: 0x0017BEF4
			// (set) Token: 0x060042E0 RID: 17120 RVA: 0x00015A33 File Offset: 0x00013C33
			public unsafe Func<bool> additionalCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass14_0.NativeFieldInfoPtr_additionalCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass14_0.NativeFieldInfoPtr_additionalCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FC9 RID: 4041
			// (get) Token: 0x060042E1 RID: 17121 RVA: 0x0017DD24 File Offset: 0x0017BF24
			// (set) Token: 0x060042E2 RID: 17122 RVA: 0x00015A52 File Offset: 0x00013C52
			public unsafe WormPlayerSelectionFiltering __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerSelectionFiltering>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FCA RID: 4042
			// (get) Token: 0x060042E3 RID: 17123 RVA: 0x0017DD54 File Offset: 0x0017BF54
			// (set) Token: 0x060042E4 RID: 17124 RVA: 0x00015A71 File Offset: 0x00013C71
			public unsafe ArchetypeID firstID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass14_0.NativeFieldInfoPtr_firstID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass14_0.NativeFieldInfoPtr_firstID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FCB RID: 4043
			// (get) Token: 0x060042E5 RID: 17125 RVA: 0x0017DD84 File Offset: 0x0017BF84
			// (set) Token: 0x060042E6 RID: 17126 RVA: 0x00015A90 File Offset: 0x00013C90
			public unsafe ArchetypeID secondID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass14_0.NativeFieldInfoPtr_secondID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass14_0.NativeFieldInfoPtr_secondID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C4B RID: 11339
			private static readonly IntPtr NativeFieldInfoPtr_additionalCheck;

			// Token: 0x04002C4C RID: 11340
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002C4D RID: 11341
			private static readonly IntPtr NativeFieldInfoPtr_firstID;

			// Token: 0x04002C4E RID: 11342
			private static readonly IntPtr NativeFieldInfoPtr_secondID;

			// Token: 0x04002C4F RID: 11343
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C50 RID: 11344
			private static readonly IntPtr NativeMethodInfoPtr__ChooseArchetypeTargetWithArchetype_b__0_Internal_Boolean_0;

			// Token: 0x04002C51 RID: 11345
			private static readonly IntPtr NativeMethodInfoPtr__ChooseArchetypeTargetWithArchetype_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0;
		}

		// Token: 0x02000572 RID: 1394
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Object
		{
			// Token: 0x060042E7 RID: 17127 RVA: 0x0017DDB4 File Offset: 0x0017BFB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass15_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass15_0.NativeFieldInfoPtr_additionalCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass15_0>.NativeClassPtr, "additionalCheck");
				WormPlayerSelectionFiltering.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				WormPlayerSelectionFiltering.__c__DisplayClass15_0.NativeFieldInfoPtr_firstID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass15_0>.NativeClassPtr, "firstID");
				WormPlayerSelectionFiltering.__c__DisplayClass15_0.NativeFieldInfoPtr_secondID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass15_0>.NativeClassPtr, "secondID");
				WormPlayerSelectionFiltering.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass15_0>.NativeClassPtr, 100663668);
				WormPlayerSelectionFiltering.__c__DisplayClass15_0.NativeMethodInfoPtr__ChooseArchetypeTargetWithArchetype_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass15_0>.NativeClassPtr, 100663669);
				WormPlayerSelectionFiltering.__c__DisplayClass15_0.NativeMethodInfoPtr__ChooseArchetypeTargetWithArchetype_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass15_0>.NativeClassPtr, 100663670);
			}

			// Token: 0x060042E8 RID: 17128 RVA: 0x0017DE6C File Offset: 0x0017C06C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060042E9 RID: 17129 RVA: 0x0017DEA8 File Offset: 0x0017C0A8
			[CallerCount(0)]
			public unsafe bool _ChooseArchetypeTargetWithArchetype_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass15_0.NativeMethodInfoPtr__ChooseArchetypeTargetWithArchetype_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060042EA RID: 17130 RVA: 0x0017DEE4 File Offset: 0x0017C0E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30213, XrefRangeEnd = 30222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IAttribute> _ChooseArchetypeTargetWithArchetype_b__1(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass15_0.NativeMethodInfoPtr__ChooseArchetypeTargetWithArchetype_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
				}
			}

			// Token: 0x060042EB RID: 17131 RVA: 0x00015AAF File Offset: 0x00013CAF
			public __c__DisplayClass15_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FCC RID: 4044
			// (get) Token: 0x060042EC RID: 17132 RVA: 0x0017DF34 File Offset: 0x0017C134
			// (set) Token: 0x060042ED RID: 17133 RVA: 0x00015AB8 File Offset: 0x00013CB8
			public unsafe Func<bool> additionalCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass15_0.NativeFieldInfoPtr_additionalCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass15_0.NativeFieldInfoPtr_additionalCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FCD RID: 4045
			// (get) Token: 0x060042EE RID: 17134 RVA: 0x0017DF64 File Offset: 0x0017C164
			// (set) Token: 0x060042EF RID: 17135 RVA: 0x00015AD7 File Offset: 0x00013CD7
			public unsafe WormPlayerSelectionFiltering __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerSelectionFiltering>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FCE RID: 4046
			// (get) Token: 0x060042F0 RID: 17136 RVA: 0x0017DF94 File Offset: 0x0017C194
			// (set) Token: 0x060042F1 RID: 17137 RVA: 0x00015AF6 File Offset: 0x00013CF6
			public unsafe ArchetypeID firstID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass15_0.NativeFieldInfoPtr_firstID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass15_0.NativeFieldInfoPtr_firstID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FCF RID: 4047
			// (get) Token: 0x060042F2 RID: 17138 RVA: 0x0017DFC4 File Offset: 0x0017C1C4
			// (set) Token: 0x060042F3 RID: 17139 RVA: 0x00015B15 File Offset: 0x00013D15
			public unsafe ArchetypeID secondID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass15_0.NativeFieldInfoPtr_secondID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass15_0.NativeFieldInfoPtr_secondID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C52 RID: 11346
			private static readonly IntPtr NativeFieldInfoPtr_additionalCheck;

			// Token: 0x04002C53 RID: 11347
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002C54 RID: 11348
			private static readonly IntPtr NativeFieldInfoPtr_firstID;

			// Token: 0x04002C55 RID: 11349
			private static readonly IntPtr NativeFieldInfoPtr_secondID;

			// Token: 0x04002C56 RID: 11350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C57 RID: 11351
			private static readonly IntPtr NativeMethodInfoPtr__ChooseArchetypeTargetWithArchetype_b__0_Internal_Boolean_0;

			// Token: 0x04002C58 RID: 11352
			private static readonly IntPtr NativeMethodInfoPtr__ChooseArchetypeTargetWithArchetype_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0;
		}

		// Token: 0x02000573 RID: 1395
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass16_0")]
		public new sealed class __c__DisplayClass16_0 : Object
		{
			// Token: 0x060042F4 RID: 17140 RVA: 0x0017DFF4 File Offset: 0x0017C1F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass16_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass16_0.NativeFieldInfoPtr_additionalCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass16_0>.NativeClassPtr, "additionalCheck");
				WormPlayerSelectionFiltering.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
				WormPlayerSelectionFiltering.__c__DisplayClass16_0.NativeFieldInfoPtr_filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass16_0>.NativeClassPtr, "filter");
				WormPlayerSelectionFiltering.__c__DisplayClass16_0.NativeFieldInfoPtr_secondID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass16_0>.NativeClassPtr, "secondID");
				WormPlayerSelectionFiltering.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass16_0>.NativeClassPtr, 100663671);
				WormPlayerSelectionFiltering.__c__DisplayClass16_0.NativeMethodInfoPtr__ChooseCustomWithArchetype_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass16_0>.NativeClassPtr, 100663672);
				WormPlayerSelectionFiltering.__c__DisplayClass16_0.NativeMethodInfoPtr__ChooseCustomWithArchetype_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass16_0>.NativeClassPtr, 100663673);
			}

			// Token: 0x060042F5 RID: 17141 RVA: 0x0017E0AC File Offset: 0x0017C2AC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060042F6 RID: 17142 RVA: 0x0017E0E8 File Offset: 0x0017C2E8
			[CallerCount(0)]
			public unsafe bool _ChooseCustomWithArchetype_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass16_0.NativeMethodInfoPtr__ChooseCustomWithArchetype_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060042F7 RID: 17143 RVA: 0x0017E124 File Offset: 0x0017C324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30222, XrefRangeEnd = 30230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IAttribute> _ChooseCustomWithArchetype_b__1(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass16_0.NativeMethodInfoPtr__ChooseCustomWithArchetype_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
				}
			}

			// Token: 0x060042F8 RID: 17144 RVA: 0x00015B34 File Offset: 0x00013D34
			public __c__DisplayClass16_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FD0 RID: 4048
			// (get) Token: 0x060042F9 RID: 17145 RVA: 0x0017E174 File Offset: 0x0017C374
			// (set) Token: 0x060042FA RID: 17146 RVA: 0x00015B3D File Offset: 0x00013D3D
			public unsafe Func<bool> additionalCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass16_0.NativeFieldInfoPtr_additionalCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass16_0.NativeFieldInfoPtr_additionalCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FD1 RID: 4049
			// (get) Token: 0x060042FB RID: 17147 RVA: 0x0017E1A4 File Offset: 0x0017C3A4
			// (set) Token: 0x060042FC RID: 17148 RVA: 0x00015B5C File Offset: 0x00013D5C
			public unsafe WormPlayerSelectionFiltering __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerSelectionFiltering>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FD2 RID: 4050
			// (get) Token: 0x060042FD RID: 17149 RVA: 0x0017E1D4 File Offset: 0x0017C3D4
			// (set) Token: 0x060042FE RID: 17150 RVA: 0x00015B7B File Offset: 0x00013D7B
			public unsafe Func<Entity, bool> filter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass16_0.NativeFieldInfoPtr_filter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass16_0.NativeFieldInfoPtr_filter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FD3 RID: 4051
			// (get) Token: 0x060042FF RID: 17151 RVA: 0x0017E204 File Offset: 0x0017C404
			// (set) Token: 0x06004300 RID: 17152 RVA: 0x00015B9A File Offset: 0x00013D9A
			public unsafe ArchetypeID secondID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass16_0.NativeFieldInfoPtr_secondID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass16_0.NativeFieldInfoPtr_secondID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C59 RID: 11353
			private static readonly IntPtr NativeFieldInfoPtr_additionalCheck;

			// Token: 0x04002C5A RID: 11354
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002C5B RID: 11355
			private static readonly IntPtr NativeFieldInfoPtr_filter;

			// Token: 0x04002C5C RID: 11356
			private static readonly IntPtr NativeFieldInfoPtr_secondID;

			// Token: 0x04002C5D RID: 11357
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C5E RID: 11358
			private static readonly IntPtr NativeMethodInfoPtr__ChooseCustomWithArchetype_b__0_Internal_Boolean_0;

			// Token: 0x04002C5F RID: 11359
			private static readonly IntPtr NativeMethodInfoPtr__ChooseCustomWithArchetype_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0;
		}

		// Token: 0x02000574 RID: 1396
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Object
		{
			// Token: 0x06004301 RID: 17153 RVA: 0x0017E234 File Offset: 0x0017C434
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass17_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass17_0.NativeFieldInfoPtr_additionalCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass17_0>.NativeClassPtr, "additionalCheck");
				WormPlayerSelectionFiltering.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				WormPlayerSelectionFiltering.__c__DisplayClass17_0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass17_0>.NativeClassPtr, "amount");
				WormPlayerSelectionFiltering.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass17_0>.NativeClassPtr, 100663674);
				WormPlayerSelectionFiltering.__c__DisplayClass17_0.NativeMethodInfoPtr__ChooseAmount_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass17_0>.NativeClassPtr, 100663675);
				WormPlayerSelectionFiltering.__c__DisplayClass17_0.NativeMethodInfoPtr__ChooseAmount_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass17_0>.NativeClassPtr, 100663676);
			}

			// Token: 0x06004302 RID: 17154 RVA: 0x0017E2D8 File Offset: 0x0017C4D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004303 RID: 17155 RVA: 0x0017E314 File Offset: 0x0017C514
			[CallerCount(0)]
			public unsafe bool _ChooseAmount_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass17_0.NativeMethodInfoPtr__ChooseAmount_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004304 RID: 17156 RVA: 0x0017E350 File Offset: 0x0017C550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30230, XrefRangeEnd = 30232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IAttribute> _ChooseAmount_b__1(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass17_0.NativeMethodInfoPtr__ChooseAmount_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
				}
			}

			// Token: 0x06004305 RID: 17157 RVA: 0x00015BB9 File Offset: 0x00013DB9
			public __c__DisplayClass17_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FD4 RID: 4052
			// (get) Token: 0x06004306 RID: 17158 RVA: 0x0017E3A0 File Offset: 0x0017C5A0
			// (set) Token: 0x06004307 RID: 17159 RVA: 0x00015BC2 File Offset: 0x00013DC2
			public unsafe Func<bool> additionalCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass17_0.NativeFieldInfoPtr_additionalCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass17_0.NativeFieldInfoPtr_additionalCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FD5 RID: 4053
			// (get) Token: 0x06004308 RID: 17160 RVA: 0x0017E3D0 File Offset: 0x0017C5D0
			// (set) Token: 0x06004309 RID: 17161 RVA: 0x00015BE1 File Offset: 0x00013DE1
			public unsafe WormPlayerSelectionFiltering __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerSelectionFiltering>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FD6 RID: 4054
			// (get) Token: 0x0600430A RID: 17162 RVA: 0x0017E400 File Offset: 0x0017C600
			// (set) Token: 0x0600430B RID: 17163 RVA: 0x00015C00 File Offset: 0x00013E00
			public unsafe int amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass17_0.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass17_0.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x04002C60 RID: 11360
			private static readonly IntPtr NativeFieldInfoPtr_additionalCheck;

			// Token: 0x04002C61 RID: 11361
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002C62 RID: 11362
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x04002C63 RID: 11363
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C64 RID: 11364
			private static readonly IntPtr NativeMethodInfoPtr__ChooseAmount_b__0_Internal_Boolean_0;

			// Token: 0x04002C65 RID: 11365
			private static readonly IntPtr NativeMethodInfoPtr__ChooseAmount_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0;
		}

		// Token: 0x02000575 RID: 1397
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Object
		{
			// Token: 0x0600430C RID: 17164 RVA: 0x0017E428 File Offset: 0x0017C628
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass18_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass18_0.NativeFieldInfoPtr_additionalCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass18_0>.NativeClassPtr, "additionalCheck");
				WormPlayerSelectionFiltering.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
				WormPlayerSelectionFiltering.__c__DisplayClass18_0.NativeFieldInfoPtr_entityGen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass18_0>.NativeClassPtr, "entityGen");
				WormPlayerSelectionFiltering.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass18_0>.NativeClassPtr, 100663677);
				WormPlayerSelectionFiltering.__c__DisplayClass18_0.NativeMethodInfoPtr__ChooseEntityTarget_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass18_0>.NativeClassPtr, 100663678);
				WormPlayerSelectionFiltering.__c__DisplayClass18_0.NativeMethodInfoPtr__ChooseEntityTarget_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass18_0>.NativeClassPtr, 100663679);
			}

			// Token: 0x0600430D RID: 17165 RVA: 0x0017E4CC File Offset: 0x0017C6CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600430E RID: 17166 RVA: 0x0017E508 File Offset: 0x0017C708
			[CallerCount(0)]
			public unsafe bool _ChooseEntityTarget_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass18_0.NativeMethodInfoPtr__ChooseEntityTarget_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600430F RID: 17167 RVA: 0x0017E544 File Offset: 0x0017C744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30232, XrefRangeEnd = 30235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IAttribute> _ChooseEntityTarget_b__1(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass18_0.NativeMethodInfoPtr__ChooseEntityTarget_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
				}
			}

			// Token: 0x06004310 RID: 17168 RVA: 0x00015C1B File Offset: 0x00013E1B
			public __c__DisplayClass18_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FD7 RID: 4055
			// (get) Token: 0x06004311 RID: 17169 RVA: 0x0017E594 File Offset: 0x0017C794
			// (set) Token: 0x06004312 RID: 17170 RVA: 0x00015C24 File Offset: 0x00013E24
			public unsafe Func<bool> additionalCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass18_0.NativeFieldInfoPtr_additionalCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass18_0.NativeFieldInfoPtr_additionalCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FD8 RID: 4056
			// (get) Token: 0x06004313 RID: 17171 RVA: 0x0017E5C4 File Offset: 0x0017C7C4
			// (set) Token: 0x06004314 RID: 17172 RVA: 0x00015C43 File Offset: 0x00013E43
			public unsafe WormPlayerSelectionFiltering __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerSelectionFiltering>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FD9 RID: 4057
			// (get) Token: 0x06004315 RID: 17173 RVA: 0x0017E5F4 File Offset: 0x0017C7F4
			// (set) Token: 0x06004316 RID: 17174 RVA: 0x00015C62 File Offset: 0x00013E62
			public unsafe Func<Entity> entityGen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass18_0.NativeFieldInfoPtr_entityGen);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass18_0.NativeFieldInfoPtr_entityGen), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C66 RID: 11366
			private static readonly IntPtr NativeFieldInfoPtr_additionalCheck;

			// Token: 0x04002C67 RID: 11367
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002C68 RID: 11368
			private static readonly IntPtr NativeFieldInfoPtr_entityGen;

			// Token: 0x04002C69 RID: 11369
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C6A RID: 11370
			private static readonly IntPtr NativeMethodInfoPtr__ChooseEntityTarget_b__0_Internal_Boolean_0;

			// Token: 0x04002C6B RID: 11371
			private static readonly IntPtr NativeMethodInfoPtr__ChooseEntityTarget_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0;
		}

		// Token: 0x02000576 RID: 1398
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass19_0")]
		public new sealed class __c__DisplayClass19_0 : Object
		{
			// Token: 0x06004317 RID: 17175 RVA: 0x0017E624 File Offset: 0x0017C824
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass19_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass19_0.NativeFieldInfoPtr_additionalCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass19_0>.NativeClassPtr, "additionalCheck");
				WormPlayerSelectionFiltering.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass19_0>.NativeClassPtr, "<>4__this");
				WormPlayerSelectionFiltering.__c__DisplayClass19_0.NativeFieldInfoPtr_stringValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass19_0>.NativeClassPtr, "stringValue");
				WormPlayerSelectionFiltering.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass19_0>.NativeClassPtr, 100663680);
				WormPlayerSelectionFiltering.__c__DisplayClass19_0.NativeMethodInfoPtr__ChooseStringValue_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass19_0>.NativeClassPtr, 100663681);
				WormPlayerSelectionFiltering.__c__DisplayClass19_0.NativeMethodInfoPtr__ChooseStringValue_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass19_0>.NativeClassPtr, 100663682);
			}

			// Token: 0x06004318 RID: 17176 RVA: 0x0017E6C8 File Offset: 0x0017C8C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004319 RID: 17177 RVA: 0x0017E704 File Offset: 0x0017C904
			[CallerCount(0)]
			public unsafe bool _ChooseStringValue_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass19_0.NativeMethodInfoPtr__ChooseStringValue_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600431A RID: 17178 RVA: 0x0017E740 File Offset: 0x0017C940
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30235, XrefRangeEnd = 30237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IAttribute> _ChooseStringValue_b__1(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass19_0.NativeMethodInfoPtr__ChooseStringValue_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
				}
			}

			// Token: 0x0600431B RID: 17179 RVA: 0x00015C81 File Offset: 0x00013E81
			public __c__DisplayClass19_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FDA RID: 4058
			// (get) Token: 0x0600431C RID: 17180 RVA: 0x0017E790 File Offset: 0x0017C990
			// (set) Token: 0x0600431D RID: 17181 RVA: 0x00015C8A File Offset: 0x00013E8A
			public unsafe Func<bool> additionalCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass19_0.NativeFieldInfoPtr_additionalCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass19_0.NativeFieldInfoPtr_additionalCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FDB RID: 4059
			// (get) Token: 0x0600431E RID: 17182 RVA: 0x0017E7C0 File Offset: 0x0017C9C0
			// (set) Token: 0x0600431F RID: 17183 RVA: 0x00015CA9 File Offset: 0x00013EA9
			public unsafe WormPlayerSelectionFiltering __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerSelectionFiltering>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FDC RID: 4060
			// (get) Token: 0x06004320 RID: 17184 RVA: 0x0017E7F0 File Offset: 0x0017C9F0
			// (set) Token: 0x06004321 RID: 17185 RVA: 0x00015CC8 File Offset: 0x00013EC8
			public unsafe string stringValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass19_0.NativeFieldInfoPtr_stringValue);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass19_0.NativeFieldInfoPtr_stringValue), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04002C6C RID: 11372
			private static readonly IntPtr NativeFieldInfoPtr_additionalCheck;

			// Token: 0x04002C6D RID: 11373
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002C6E RID: 11374
			private static readonly IntPtr NativeFieldInfoPtr_stringValue;

			// Token: 0x04002C6F RID: 11375
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C70 RID: 11376
			private static readonly IntPtr NativeMethodInfoPtr__ChooseStringValue_b__0_Internal_Boolean_0;

			// Token: 0x04002C71 RID: 11377
			private static readonly IntPtr NativeMethodInfoPtr__ChooseStringValue_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0;
		}

		// Token: 0x02000577 RID: 1399
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06004322 RID: 17186 RVA: 0x0017E818 File Offset: 0x0017CA18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass1_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass1_0.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass1_0>.NativeClassPtr, "archID");
				WormPlayerSelectionFiltering.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass1_0>.NativeClassPtr, 100663683);
				WormPlayerSelectionFiltering.__c__DisplayClass1_0.NativeMethodInfoPtr__SelectArchetype_b__0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass1_0>.NativeClassPtr, 100663684);
			}

			// Token: 0x06004323 RID: 17187 RVA: 0x0017E880 File Offset: 0x0017CA80
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004324 RID: 17188 RVA: 0x0017E8BC File Offset: 0x0017CABC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30237, XrefRangeEnd = 30253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectArchetype_b__0(Entity ent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass1_0.NativeMethodInfoPtr__SelectArchetype_b__0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004325 RID: 17189 RVA: 0x00015CE7 File Offset: 0x00013EE7
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FDD RID: 4061
			// (get) Token: 0x06004326 RID: 17190 RVA: 0x0017E90C File Offset: 0x0017CB0C
			// (set) Token: 0x06004327 RID: 17191 RVA: 0x00015CF0 File Offset: 0x00013EF0
			public unsafe ArchetypeID archID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass1_0.NativeFieldInfoPtr_archID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass1_0.NativeFieldInfoPtr_archID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C72 RID: 11378
			private static readonly IntPtr NativeFieldInfoPtr_archID;

			// Token: 0x04002C73 RID: 11379
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C74 RID: 11380
			private static readonly IntPtr NativeMethodInfoPtr__SelectArchetype_b__0_Internal_Boolean_Entity_0;
		}

		// Token: 0x02000578 RID: 1400
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Object
		{
			// Token: 0x06004328 RID: 17192 RVA: 0x0017E93C File Offset: 0x0017CB3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass20_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass20_0.NativeFieldInfoPtr_additionalCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass20_0>.NativeClassPtr, "additionalCheck");
				WormPlayerSelectionFiltering.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass20_0>.NativeClassPtr, 100663685);
				WormPlayerSelectionFiltering.__c__DisplayClass20_0.NativeMethodInfoPtr__ChooseAccept_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass20_0>.NativeClassPtr, 100663686);
			}

			// Token: 0x06004329 RID: 17193 RVA: 0x0017E9A4 File Offset: 0x0017CBA4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600432A RID: 17194 RVA: 0x0017E9E0 File Offset: 0x0017CBE0
			[CallerCount(0)]
			public unsafe bool _ChooseAccept_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass20_0.NativeMethodInfoPtr__ChooseAccept_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600432B RID: 17195 RVA: 0x00015D0F File Offset: 0x00013F0F
			public __c__DisplayClass20_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FDE RID: 4062
			// (get) Token: 0x0600432C RID: 17196 RVA: 0x0017EA1C File Offset: 0x0017CC1C
			// (set) Token: 0x0600432D RID: 17197 RVA: 0x00015D18 File Offset: 0x00013F18
			public unsafe Func<bool> additionalCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass20_0.NativeFieldInfoPtr_additionalCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass20_0.NativeFieldInfoPtr_additionalCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C75 RID: 11381
			private static readonly IntPtr NativeFieldInfoPtr_additionalCheck;

			// Token: 0x04002C76 RID: 11382
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C77 RID: 11383
			private static readonly IntPtr NativeMethodInfoPtr__ChooseAccept_b__0_Internal_Boolean_0;
		}

		// Token: 0x02000579 RID: 1401
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Object
		{
			// Token: 0x0600432E RID: 17198 RVA: 0x0017EA4C File Offset: 0x0017CC4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass21_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass21_0.NativeFieldInfoPtr_additionalCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass21_0>.NativeClassPtr, "additionalCheck");
				WormPlayerSelectionFiltering.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass21_0>.NativeClassPtr, 100663687);
				WormPlayerSelectionFiltering.__c__DisplayClass21_0.NativeMethodInfoPtr__ChooseSkip_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass21_0>.NativeClassPtr, 100663688);
			}

			// Token: 0x0600432F RID: 17199 RVA: 0x0017EAB4 File Offset: 0x0017CCB4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004330 RID: 17200 RVA: 0x0017EAF0 File Offset: 0x0017CCF0
			[CallerCount(0)]
			public unsafe bool _ChooseSkip_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass21_0.NativeMethodInfoPtr__ChooseSkip_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004331 RID: 17201 RVA: 0x00015D37 File Offset: 0x00013F37
			public __c__DisplayClass21_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FDF RID: 4063
			// (get) Token: 0x06004332 RID: 17202 RVA: 0x0017EB2C File Offset: 0x0017CD2C
			// (set) Token: 0x06004333 RID: 17203 RVA: 0x00015D40 File Offset: 0x00013F40
			public unsafe Func<bool> additionalCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass21_0.NativeFieldInfoPtr_additionalCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass21_0.NativeFieldInfoPtr_additionalCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C78 RID: 11384
			private static readonly IntPtr NativeFieldInfoPtr_additionalCheck;

			// Token: 0x04002C79 RID: 11385
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C7A RID: 11386
			private static readonly IntPtr NativeMethodInfoPtr__ChooseSkip_b__0_Internal_Boolean_0;
		}

		// Token: 0x0200057A RID: 1402
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Object
		{
			// Token: 0x06004334 RID: 17204 RVA: 0x0017EB5C File Offset: 0x0017CD5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass22_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass22_0.NativeFieldInfoPtr_additionalCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass22_0>.NativeClassPtr, "additionalCheck");
				WormPlayerSelectionFiltering.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass22_0>.NativeClassPtr, 100663689);
				WormPlayerSelectionFiltering.__c__DisplayClass22_0.NativeMethodInfoPtr__ForceSkip_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass22_0>.NativeClassPtr, 100663690);
			}

			// Token: 0x06004335 RID: 17205 RVA: 0x0017EBC4 File Offset: 0x0017CDC4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004336 RID: 17206 RVA: 0x0017EC00 File Offset: 0x0017CE00
			[CallerCount(0)]
			public unsafe bool _ForceSkip_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass22_0.NativeMethodInfoPtr__ForceSkip_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004337 RID: 17207 RVA: 0x00015D5F File Offset: 0x00013F5F
			public __c__DisplayClass22_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FE0 RID: 4064
			// (get) Token: 0x06004338 RID: 17208 RVA: 0x0017EC3C File Offset: 0x0017CE3C
			// (set) Token: 0x06004339 RID: 17209 RVA: 0x00015D68 File Offset: 0x00013F68
			public unsafe Func<bool> additionalCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass22_0.NativeFieldInfoPtr_additionalCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass22_0.NativeFieldInfoPtr_additionalCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C7B RID: 11387
			private static readonly IntPtr NativeFieldInfoPtr_additionalCheck;

			// Token: 0x04002C7C RID: 11388
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C7D RID: 11389
			private static readonly IntPtr NativeMethodInfoPtr__ForceSkip_b__0_Internal_Boolean_0;
		}

		// Token: 0x0200057B RID: 1403
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Object
		{
			// Token: 0x0600433A RID: 17210 RVA: 0x0017EC6C File Offset: 0x0017CE6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass23_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass23_0.NativeFieldInfoPtr_additionalCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass23_0>.NativeClassPtr, "additionalCheck");
				WormPlayerSelectionFiltering.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass23_0>.NativeClassPtr, 100663691);
				WormPlayerSelectionFiltering.__c__DisplayClass23_0.NativeMethodInfoPtr__ClearSelections_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass23_0>.NativeClassPtr, 100663692);
			}

			// Token: 0x0600433B RID: 17211 RVA: 0x0017ECD4 File Offset: 0x0017CED4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600433C RID: 17212 RVA: 0x0017ED10 File Offset: 0x0017CF10
			[CallerCount(0)]
			public unsafe bool _ClearSelections_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass23_0.NativeMethodInfoPtr__ClearSelections_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600433D RID: 17213 RVA: 0x00015D87 File Offset: 0x00013F87
			public __c__DisplayClass23_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FE1 RID: 4065
			// (get) Token: 0x0600433E RID: 17214 RVA: 0x0017ED4C File Offset: 0x0017CF4C
			// (set) Token: 0x0600433F RID: 17215 RVA: 0x00015D90 File Offset: 0x00013F90
			public unsafe Func<bool> additionalCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass23_0.NativeFieldInfoPtr_additionalCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass23_0.NativeFieldInfoPtr_additionalCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C7E RID: 11390
			private static readonly IntPtr NativeFieldInfoPtr_additionalCheck;

			// Token: 0x04002C7F RID: 11391
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C80 RID: 11392
			private static readonly IntPtr NativeMethodInfoPtr__ClearSelections_b__0_Internal_Boolean_0;
		}

		// Token: 0x0200057C RID: 1404
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06004340 RID: 17216 RVA: 0x0017ED7C File Offset: 0x0017CF7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass2_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass2_0.NativeFieldInfoPtr_abilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass2_0>.NativeClassPtr, "abilityID");
				WormPlayerSelectionFiltering.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass2_0>.NativeClassPtr, 100663693);
				WormPlayerSelectionFiltering.__c__DisplayClass2_0.NativeMethodInfoPtr__SelectAbility_b__0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass2_0>.NativeClassPtr, 100663694);
			}

			// Token: 0x06004341 RID: 17217 RVA: 0x0017EDE4 File Offset: 0x0017CFE4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004342 RID: 17218 RVA: 0x0017EE20 File Offset: 0x0017D020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30253, XrefRangeEnd = 30260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectAbility_b__0(Entity ent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass2_0.NativeMethodInfoPtr__SelectAbility_b__0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004343 RID: 17219 RVA: 0x00015DAF File Offset: 0x00013FAF
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FE2 RID: 4066
			// (get) Token: 0x06004344 RID: 17220 RVA: 0x0017EE70 File Offset: 0x0017D070
			// (set) Token: 0x06004345 RID: 17221 RVA: 0x00015DB8 File Offset: 0x00013FB8
			public unsafe AbilityID abilityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass2_0.NativeFieldInfoPtr_abilityID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass2_0.NativeFieldInfoPtr_abilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C81 RID: 11393
			private static readonly IntPtr NativeFieldInfoPtr_abilityID;

			// Token: 0x04002C82 RID: 11394
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C83 RID: 11395
			private static readonly IntPtr NativeMethodInfoPtr__SelectAbility_b__0_Internal_Boolean_Entity_0;
		}

		// Token: 0x0200057D RID: 1405
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06004346 RID: 17222 RVA: 0x0017EEA0 File Offset: 0x0017D0A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass3_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass3_0.NativeFieldInfoPtr_entityGen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass3_0>.NativeClassPtr, "entityGen");
				WormPlayerSelectionFiltering.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass3_0>.NativeClassPtr, 100663695);
				WormPlayerSelectionFiltering.__c__DisplayClass3_0.NativeMethodInfoPtr__SelectEntity_b__0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass3_0>.NativeClassPtr, 100663696);
			}

			// Token: 0x06004347 RID: 17223 RVA: 0x0017EF08 File Offset: 0x0017D108
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004348 RID: 17224 RVA: 0x0017EF44 File Offset: 0x0017D144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30260, XrefRangeEnd = 30262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectEntity_b__0(Entity ent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass3_0.NativeMethodInfoPtr__SelectEntity_b__0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004349 RID: 17225 RVA: 0x00015DD7 File Offset: 0x00013FD7
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FE3 RID: 4067
			// (get) Token: 0x0600434A RID: 17226 RVA: 0x0017EF94 File Offset: 0x0017D194
			// (set) Token: 0x0600434B RID: 17227 RVA: 0x00015DE0 File Offset: 0x00013FE0
			public unsafe Func<Entity> entityGen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass3_0.NativeFieldInfoPtr_entityGen);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass3_0.NativeFieldInfoPtr_entityGen), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C84 RID: 11396
			private static readonly IntPtr NativeFieldInfoPtr_entityGen;

			// Token: 0x04002C85 RID: 11397
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C86 RID: 11398
			private static readonly IntPtr NativeMethodInfoPtr__SelectEntity_b__0_Internal_Boolean_Entity_0;
		}

		// Token: 0x0200057E RID: 1406
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600434C RID: 17228 RVA: 0x0017EFC4 File Offset: 0x0017D1C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass4_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass4_0.NativeFieldInfoPtr_troops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass4_0>.NativeClassPtr, "troops");
				WormPlayerSelectionFiltering.__c__DisplayClass4_0.NativeFieldInfoPtr_numTroops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass4_0>.NativeClassPtr, "numTroops");
				WormPlayerSelectionFiltering.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass4_0>.NativeClassPtr, 100663697);
				WormPlayerSelectionFiltering.__c__DisplayClass4_0.NativeMethodInfoPtr__SelectTroops_b__0_Internal_SelectionNodeFilterData_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass4_0>.NativeClassPtr, 100663698);
			}

			// Token: 0x0600434D RID: 17229 RVA: 0x0017F040 File Offset: 0x0017D240
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600434E RID: 17230 RVA: 0x0017F07C File Offset: 0x0017D27C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30262, XrefRangeEnd = 30301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SelectionNodeFilterData _SelectTroops_b__0(TargetInformation information)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(information);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass4_0.NativeMethodInfoPtr__SelectTroops_b__0_Internal_SelectionNodeFilterData_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionNodeFilterData>(intPtr3) : null;
				}
			}

			// Token: 0x0600434F RID: 17231 RVA: 0x00015DFF File Offset: 0x00013FFF
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FE4 RID: 4068
			// (get) Token: 0x06004350 RID: 17232 RVA: 0x0017F0CC File Offset: 0x0017D2CC
			// (set) Token: 0x06004351 RID: 17233 RVA: 0x00015E08 File Offset: 0x00014008
			public unsafe Func<IEnumerable<Entity>> troops
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass4_0.NativeFieldInfoPtr_troops);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<Entity>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass4_0.NativeFieldInfoPtr_troops), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FE5 RID: 4069
			// (get) Token: 0x06004352 RID: 17234 RVA: 0x0017F0FC File Offset: 0x0017D2FC
			// (set) Token: 0x06004353 RID: 17235 RVA: 0x00015E27 File Offset: 0x00014027
			public unsafe int numTroops
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass4_0.NativeFieldInfoPtr_numTroops);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass4_0.NativeFieldInfoPtr_numTroops)) = value;
				}
			}

			// Token: 0x04002C87 RID: 11399
			private static readonly IntPtr NativeFieldInfoPtr_troops;

			// Token: 0x04002C88 RID: 11400
			private static readonly IntPtr NativeFieldInfoPtr_numTroops;

			// Token: 0x04002C89 RID: 11401
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C8A RID: 11402
			private static readonly IntPtr NativeMethodInfoPtr__SelectTroops_b__0_Internal_SelectionNodeFilterData_TargetInformation_0;
		}

		// Token: 0x0200057F RID: 1407
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass5_0")]
		public new sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06004354 RID: 17236 RVA: 0x0017F124 File Offset: 0x0017D324
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass5_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass5_0.NativeFieldInfoPtr_additionalCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass5_0>.NativeClassPtr, "additionalCheck");
				WormPlayerSelectionFiltering.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
				WormPlayerSelectionFiltering.__c__DisplayClass5_0.NativeFieldInfoPtr_abilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass5_0>.NativeClassPtr, "abilityID");
				WormPlayerSelectionFiltering.__c__DisplayClass5_0.NativeFieldInfoPtr_troops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass5_0>.NativeClassPtr, "troops");
				WormPlayerSelectionFiltering.__c__DisplayClass5_0.NativeFieldInfoPtr_numTroops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass5_0>.NativeClassPtr, "numTroops");
				WormPlayerSelectionFiltering.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass5_0>.NativeClassPtr, 100663699);
				WormPlayerSelectionFiltering.__c__DisplayClass5_0.NativeMethodInfoPtr__ChooseTroops_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass5_0>.NativeClassPtr, 100663700);
				WormPlayerSelectionFiltering.__c__DisplayClass5_0.NativeMethodInfoPtr__ChooseTroops_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass5_0>.NativeClassPtr, 100663701);
			}

			// Token: 0x06004355 RID: 17237 RVA: 0x0017F1F0 File Offset: 0x0017D3F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004356 RID: 17238 RVA: 0x0017F22C File Offset: 0x0017D42C
			[CallerCount(0)]
			public unsafe bool _ChooseTroops_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass5_0.NativeMethodInfoPtr__ChooseTroops_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004357 RID: 17239 RVA: 0x0017F268 File Offset: 0x0017D468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30301, XrefRangeEnd = 30314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IAttribute> _ChooseTroops_b__1(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass5_0.NativeMethodInfoPtr__ChooseTroops_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
				}
			}

			// Token: 0x06004358 RID: 17240 RVA: 0x00015E42 File Offset: 0x00014042
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FE6 RID: 4070
			// (get) Token: 0x06004359 RID: 17241 RVA: 0x0017F2B8 File Offset: 0x0017D4B8
			// (set) Token: 0x0600435A RID: 17242 RVA: 0x00015E4B File Offset: 0x0001404B
			public unsafe Func<bool> additionalCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass5_0.NativeFieldInfoPtr_additionalCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass5_0.NativeFieldInfoPtr_additionalCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FE7 RID: 4071
			// (get) Token: 0x0600435B RID: 17243 RVA: 0x0017F2E8 File Offset: 0x0017D4E8
			// (set) Token: 0x0600435C RID: 17244 RVA: 0x00015E6A File Offset: 0x0001406A
			public unsafe WormPlayerSelectionFiltering __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerSelectionFiltering>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FE8 RID: 4072
			// (get) Token: 0x0600435D RID: 17245 RVA: 0x0017F318 File Offset: 0x0017D518
			// (set) Token: 0x0600435E RID: 17246 RVA: 0x00015E89 File Offset: 0x00014089
			public unsafe AbilityID abilityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass5_0.NativeFieldInfoPtr_abilityID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass5_0.NativeFieldInfoPtr_abilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FE9 RID: 4073
			// (get) Token: 0x0600435F RID: 17247 RVA: 0x0017F348 File Offset: 0x0017D548
			// (set) Token: 0x06004360 RID: 17248 RVA: 0x00015EA8 File Offset: 0x000140A8
			public unsafe Func<IEnumerable<Entity>> troops
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass5_0.NativeFieldInfoPtr_troops);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<Entity>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass5_0.NativeFieldInfoPtr_troops), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FEA RID: 4074
			// (get) Token: 0x06004361 RID: 17249 RVA: 0x0017F378 File Offset: 0x0017D578
			// (set) Token: 0x06004362 RID: 17250 RVA: 0x00015EC7 File Offset: 0x000140C7
			public unsafe int numTroops
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass5_0.NativeFieldInfoPtr_numTroops);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass5_0.NativeFieldInfoPtr_numTroops)) = value;
				}
			}

			// Token: 0x04002C8B RID: 11403
			private static readonly IntPtr NativeFieldInfoPtr_additionalCheck;

			// Token: 0x04002C8C RID: 11404
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002C8D RID: 11405
			private static readonly IntPtr NativeFieldInfoPtr_abilityID;

			// Token: 0x04002C8E RID: 11406
			private static readonly IntPtr NativeFieldInfoPtr_troops;

			// Token: 0x04002C8F RID: 11407
			private static readonly IntPtr NativeFieldInfoPtr_numTroops;

			// Token: 0x04002C90 RID: 11408
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C91 RID: 11409
			private static readonly IntPtr NativeMethodInfoPtr__ChooseTroops_b__0_Internal_Boolean_0;

			// Token: 0x04002C92 RID: 11410
			private static readonly IntPtr NativeMethodInfoPtr__ChooseTroops_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0;
		}

		// Token: 0x02000580 RID: 1408
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass6_0")]
		public new sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06004363 RID: 17251 RVA: 0x0017F3A0 File Offset: 0x0017D5A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass6_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass6_0.NativeFieldInfoPtr_additionalCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass6_0>.NativeClassPtr, "additionalCheck");
				WormPlayerSelectionFiltering.__c__DisplayClass6_0.NativeFieldInfoPtr_forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass6_0>.NativeClassPtr, "forced");
				WormPlayerSelectionFiltering.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				WormPlayerSelectionFiltering.__c__DisplayClass6_0.NativeFieldInfoPtr_abilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass6_0>.NativeClassPtr, "abilityID");
				WormPlayerSelectionFiltering.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass6_0>.NativeClassPtr, 100663702);
				WormPlayerSelectionFiltering.__c__DisplayClass6_0.NativeMethodInfoPtr__ChooseAbility_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass6_0>.NativeClassPtr, 100663703);
				WormPlayerSelectionFiltering.__c__DisplayClass6_0.NativeMethodInfoPtr__ChooseAbility_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass6_0>.NativeClassPtr, 100663704);
			}

			// Token: 0x06004364 RID: 17252 RVA: 0x0017F458 File Offset: 0x0017D658
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004365 RID: 17253 RVA: 0x0017F494 File Offset: 0x0017D694
			[CallerCount(0)]
			public unsafe bool _ChooseAbility_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass6_0.NativeMethodInfoPtr__ChooseAbility_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004366 RID: 17254 RVA: 0x0017F4D0 File Offset: 0x0017D6D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30314, XrefRangeEnd = 30318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IAttribute> _ChooseAbility_b__1(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass6_0.NativeMethodInfoPtr__ChooseAbility_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
				}
			}

			// Token: 0x06004367 RID: 17255 RVA: 0x00015EE2 File Offset: 0x000140E2
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FEB RID: 4075
			// (get) Token: 0x06004368 RID: 17256 RVA: 0x0017F520 File Offset: 0x0017D720
			// (set) Token: 0x06004369 RID: 17257 RVA: 0x00015EEB File Offset: 0x000140EB
			public unsafe Func<bool> additionalCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass6_0.NativeFieldInfoPtr_additionalCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass6_0.NativeFieldInfoPtr_additionalCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FEC RID: 4076
			// (get) Token: 0x0600436A RID: 17258 RVA: 0x0017F550 File Offset: 0x0017D750
			// (set) Token: 0x0600436B RID: 17259 RVA: 0x00015F0A File Offset: 0x0001410A
			public unsafe bool forced
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass6_0.NativeFieldInfoPtr_forced);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass6_0.NativeFieldInfoPtr_forced)) = value;
				}
			}

			// Token: 0x17000FED RID: 4077
			// (get) Token: 0x0600436C RID: 17260 RVA: 0x0017F578 File Offset: 0x0017D778
			// (set) Token: 0x0600436D RID: 17261 RVA: 0x00015F25 File Offset: 0x00014125
			public unsafe WormPlayerSelectionFiltering __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerSelectionFiltering>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FEE RID: 4078
			// (get) Token: 0x0600436E RID: 17262 RVA: 0x0017F5A8 File Offset: 0x0017D7A8
			// (set) Token: 0x0600436F RID: 17263 RVA: 0x00015F44 File Offset: 0x00014144
			public unsafe AbilityID abilityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass6_0.NativeFieldInfoPtr_abilityID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass6_0.NativeFieldInfoPtr_abilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C93 RID: 11411
			private static readonly IntPtr NativeFieldInfoPtr_additionalCheck;

			// Token: 0x04002C94 RID: 11412
			private static readonly IntPtr NativeFieldInfoPtr_forced;

			// Token: 0x04002C95 RID: 11413
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002C96 RID: 11414
			private static readonly IntPtr NativeFieldInfoPtr_abilityID;

			// Token: 0x04002C97 RID: 11415
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C98 RID: 11416
			private static readonly IntPtr NativeMethodInfoPtr__ChooseAbility_b__0_Internal_Boolean_0;

			// Token: 0x04002C99 RID: 11417
			private static readonly IntPtr NativeMethodInfoPtr__ChooseAbility_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0;
		}

		// Token: 0x02000581 RID: 1409
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x06004370 RID: 17264 RVA: 0x0017F5D8 File Offset: 0x0017D7D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass7_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass7_0.NativeFieldInfoPtr_additionalCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass7_0>.NativeClassPtr, "additionalCheck");
				WormPlayerSelectionFiltering.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				WormPlayerSelectionFiltering.__c__DisplayClass7_0.NativeFieldInfoPtr_abilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass7_0>.NativeClassPtr, "abilityID");
				WormPlayerSelectionFiltering.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass7_0>.NativeClassPtr, 100663705);
				WormPlayerSelectionFiltering.__c__DisplayClass7_0.NativeMethodInfoPtr__ChooseAbilityTarget_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass7_0>.NativeClassPtr, 100663706);
				WormPlayerSelectionFiltering.__c__DisplayClass7_0.NativeMethodInfoPtr__ChooseAbilityTarget_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass7_0>.NativeClassPtr, 100663707);
			}

			// Token: 0x06004371 RID: 17265 RVA: 0x0017F67C File Offset: 0x0017D87C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004372 RID: 17266 RVA: 0x0017F6B8 File Offset: 0x0017D8B8
			[CallerCount(0)]
			public unsafe bool _ChooseAbilityTarget_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass7_0.NativeMethodInfoPtr__ChooseAbilityTarget_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004373 RID: 17267 RVA: 0x0017F6F4 File Offset: 0x0017D8F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30318, XrefRangeEnd = 30321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IAttribute> _ChooseAbilityTarget_b__1(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass7_0.NativeMethodInfoPtr__ChooseAbilityTarget_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
				}
			}

			// Token: 0x06004374 RID: 17268 RVA: 0x00015F63 File Offset: 0x00014163
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FEF RID: 4079
			// (get) Token: 0x06004375 RID: 17269 RVA: 0x0017F744 File Offset: 0x0017D944
			// (set) Token: 0x06004376 RID: 17270 RVA: 0x00015F6C File Offset: 0x0001416C
			public unsafe Func<bool> additionalCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass7_0.NativeFieldInfoPtr_additionalCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass7_0.NativeFieldInfoPtr_additionalCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FF0 RID: 4080
			// (get) Token: 0x06004377 RID: 17271 RVA: 0x0017F774 File Offset: 0x0017D974
			// (set) Token: 0x06004378 RID: 17272 RVA: 0x00015F8B File Offset: 0x0001418B
			public unsafe WormPlayerSelectionFiltering __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerSelectionFiltering>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FF1 RID: 4081
			// (get) Token: 0x06004379 RID: 17273 RVA: 0x0017F7A4 File Offset: 0x0017D9A4
			// (set) Token: 0x0600437A RID: 17274 RVA: 0x00015FAA File Offset: 0x000141AA
			public unsafe AbilityID abilityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass7_0.NativeFieldInfoPtr_abilityID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass7_0.NativeFieldInfoPtr_abilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C9A RID: 11418
			private static readonly IntPtr NativeFieldInfoPtr_additionalCheck;

			// Token: 0x04002C9B RID: 11419
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002C9C RID: 11420
			private static readonly IntPtr NativeFieldInfoPtr_abilityID;

			// Token: 0x04002C9D RID: 11421
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C9E RID: 11422
			private static readonly IntPtr NativeMethodInfoPtr__ChooseAbilityTarget_b__0_Internal_Boolean_0;

			// Token: 0x04002C9F RID: 11423
			private static readonly IntPtr NativeMethodInfoPtr__ChooseAbilityTarget_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0;
		}

		// Token: 0x02000582 RID: 1410
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600437B RID: 17275 RVA: 0x0017F7D4 File Offset: 0x0017D9D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass8_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass8_0.NativeFieldInfoPtr_additionalCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass8_0>.NativeClassPtr, "additionalCheck");
				WormPlayerSelectionFiltering.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				WormPlayerSelectionFiltering.__c__DisplayClass8_0.NativeFieldInfoPtr_abilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass8_0>.NativeClassPtr, "abilityID");
				WormPlayerSelectionFiltering.__c__DisplayClass8_0.NativeFieldInfoPtr_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass8_0>.NativeClassPtr, "choice");
				WormPlayerSelectionFiltering.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass8_0>.NativeClassPtr, 100663708);
				WormPlayerSelectionFiltering.__c__DisplayClass8_0.NativeMethodInfoPtr__ChooseAbilityWithString_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass8_0>.NativeClassPtr, 100663709);
				WormPlayerSelectionFiltering.__c__DisplayClass8_0.NativeMethodInfoPtr__ChooseAbilityWithString_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass8_0>.NativeClassPtr, 100663710);
			}

			// Token: 0x0600437C RID: 17276 RVA: 0x0017F88C File Offset: 0x0017DA8C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600437D RID: 17277 RVA: 0x0017F8C8 File Offset: 0x0017DAC8
			[CallerCount(0)]
			public unsafe bool _ChooseAbilityWithString_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass8_0.NativeMethodInfoPtr__ChooseAbilityWithString_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600437E RID: 17278 RVA: 0x0017F904 File Offset: 0x0017DB04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30321, XrefRangeEnd = 30328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IAttribute> _ChooseAbilityWithString_b__1(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass8_0.NativeMethodInfoPtr__ChooseAbilityWithString_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
				}
			}

			// Token: 0x0600437F RID: 17279 RVA: 0x00015FC9 File Offset: 0x000141C9
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FF2 RID: 4082
			// (get) Token: 0x06004380 RID: 17280 RVA: 0x0017F954 File Offset: 0x0017DB54
			// (set) Token: 0x06004381 RID: 17281 RVA: 0x00015FD2 File Offset: 0x000141D2
			public unsafe Func<bool> additionalCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass8_0.NativeFieldInfoPtr_additionalCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass8_0.NativeFieldInfoPtr_additionalCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FF3 RID: 4083
			// (get) Token: 0x06004382 RID: 17282 RVA: 0x0017F984 File Offset: 0x0017DB84
			// (set) Token: 0x06004383 RID: 17283 RVA: 0x00015FF1 File Offset: 0x000141F1
			public unsafe WormPlayerSelectionFiltering __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerSelectionFiltering>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FF4 RID: 4084
			// (get) Token: 0x06004384 RID: 17284 RVA: 0x0017F9B4 File Offset: 0x0017DBB4
			// (set) Token: 0x06004385 RID: 17285 RVA: 0x00016010 File Offset: 0x00014210
			public unsafe AbilityID abilityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass8_0.NativeFieldInfoPtr_abilityID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass8_0.NativeFieldInfoPtr_abilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FF5 RID: 4085
			// (get) Token: 0x06004386 RID: 17286 RVA: 0x0017F9E4 File Offset: 0x0017DBE4
			// (set) Token: 0x06004387 RID: 17287 RVA: 0x0001602F File Offset: 0x0001422F
			public unsafe string choice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass8_0.NativeFieldInfoPtr_choice);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass8_0.NativeFieldInfoPtr_choice), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04002CA0 RID: 11424
			private static readonly IntPtr NativeFieldInfoPtr_additionalCheck;

			// Token: 0x04002CA1 RID: 11425
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002CA2 RID: 11426
			private static readonly IntPtr NativeFieldInfoPtr_abilityID;

			// Token: 0x04002CA3 RID: 11427
			private static readonly IntPtr NativeFieldInfoPtr_choice;

			// Token: 0x04002CA4 RID: 11428
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002CA5 RID: 11429
			private static readonly IntPtr NativeMethodInfoPtr__ChooseAbilityWithString_b__0_Internal_Boolean_0;

			// Token: 0x04002CA6 RID: 11430
			private static readonly IntPtr NativeMethodInfoPtr__ChooseAbilityWithString_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0;
		}

		// Token: 0x02000583 RID: 1411
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x06004388 RID: 17288 RVA: 0x0017FA0C File Offset: 0x0017DC0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass9_0>.NativeClassPtr);
				WormPlayerSelectionFiltering.__c__DisplayClass9_0.NativeFieldInfoPtr_additionalCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass9_0>.NativeClassPtr, "additionalCheck");
				WormPlayerSelectionFiltering.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				WormPlayerSelectionFiltering.__c__DisplayClass9_0.NativeFieldInfoPtr_abilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass9_0>.NativeClassPtr, "abilityID");
				WormPlayerSelectionFiltering.__c__DisplayClass9_0.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass9_0>.NativeClassPtr, "archID");
				WormPlayerSelectionFiltering.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass9_0>.NativeClassPtr, 100663711);
				WormPlayerSelectionFiltering.__c__DisplayClass9_0.NativeMethodInfoPtr__ChooseAbilityWithArchetypeTarget_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass9_0>.NativeClassPtr, 100663712);
				WormPlayerSelectionFiltering.__c__DisplayClass9_0.NativeMethodInfoPtr__ChooseAbilityWithArchetypeTarget_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass9_0>.NativeClassPtr, 100663713);
			}

			// Token: 0x06004389 RID: 17289 RVA: 0x0017FAC4 File Offset: 0x0017DCC4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600438A RID: 17290 RVA: 0x0017FB00 File Offset: 0x0017DD00
			[CallerCount(0)]
			public unsafe bool _ChooseAbilityWithArchetypeTarget_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass9_0.NativeMethodInfoPtr__ChooseAbilityWithArchetypeTarget_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600438B RID: 17291 RVA: 0x0017FB3C File Offset: 0x0017DD3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30328, XrefRangeEnd = 30372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IAttribute> _ChooseAbilityWithArchetypeTarget_b__1(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering.__c__DisplayClass9_0.NativeMethodInfoPtr__ChooseAbilityWithArchetypeTarget_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
				}
			}

			// Token: 0x0600438C RID: 17292 RVA: 0x0001604E File Offset: 0x0001424E
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FF6 RID: 4086
			// (get) Token: 0x0600438D RID: 17293 RVA: 0x0017FB8C File Offset: 0x0017DD8C
			// (set) Token: 0x0600438E RID: 17294 RVA: 0x00016057 File Offset: 0x00014257
			public unsafe Func<bool> additionalCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass9_0.NativeFieldInfoPtr_additionalCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass9_0.NativeFieldInfoPtr_additionalCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FF7 RID: 4087
			// (get) Token: 0x0600438F RID: 17295 RVA: 0x0017FBBC File Offset: 0x0017DDBC
			// (set) Token: 0x06004390 RID: 17296 RVA: 0x00016076 File Offset: 0x00014276
			public unsafe WormPlayerSelectionFiltering __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerSelectionFiltering>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FF8 RID: 4088
			// (get) Token: 0x06004391 RID: 17297 RVA: 0x0017FBEC File Offset: 0x0017DDEC
			// (set) Token: 0x06004392 RID: 17298 RVA: 0x00016095 File Offset: 0x00014295
			public unsafe AbilityID abilityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass9_0.NativeFieldInfoPtr_abilityID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass9_0.NativeFieldInfoPtr_abilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FF9 RID: 4089
			// (get) Token: 0x06004393 RID: 17299 RVA: 0x0017FC1C File Offset: 0x0017DE1C
			// (set) Token: 0x06004394 RID: 17300 RVA: 0x000160B4 File Offset: 0x000142B4
			public unsafe ArchetypeID archID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass9_0.NativeFieldInfoPtr_archID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering.__c__DisplayClass9_0.NativeFieldInfoPtr_archID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002CA7 RID: 11431
			private static readonly IntPtr NativeFieldInfoPtr_additionalCheck;

			// Token: 0x04002CA8 RID: 11432
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002CA9 RID: 11433
			private static readonly IntPtr NativeFieldInfoPtr_abilityID;

			// Token: 0x04002CAA RID: 11434
			private static readonly IntPtr NativeFieldInfoPtr_archID;

			// Token: 0x04002CAB RID: 11435
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002CAC RID: 11436
			private static readonly IntPtr NativeMethodInfoPtr__ChooseAbilityWithArchetypeTarget_b__0_Internal_Boolean_0;

			// Token: 0x04002CAD RID: 11437
			private static readonly IntPtr NativeMethodInfoPtr__ChooseAbilityWithArchetypeTarget_b__1_Internal_IEnumerable_1_IAttribute_NetworkMessageEvent_0;
		}

		// Token: 0x02000584 RID: 1412
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<ForceSkip>d__27")]
		public sealed class _ForceSkip_d__27 : Object
		{
			// Token: 0x06004395 RID: 17301 RVA: 0x0017FC4C File Offset: 0x0017DE4C
			// Note: this type is marked as 'beforefieldinit'.
			static _ForceSkip_d__27()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering._ForceSkip_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<ForceSkip>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering._ForceSkip_d__27>.NativeClassPtr);
				WormPlayerSelectionFiltering._ForceSkip_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering._ForceSkip_d__27>.NativeClassPtr, "<>1__state");
				WormPlayerSelectionFiltering._ForceSkip_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering._ForceSkip_d__27>.NativeClassPtr, "<>2__current");
				WormPlayerSelectionFiltering._ForceSkip_d__27.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering._ForceSkip_d__27>.NativeClassPtr, "<>l__initialThreadId");
				WormPlayerSelectionFiltering._ForceSkip_d__27.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering._ForceSkip_d__27>.NativeClassPtr, "evt");
				WormPlayerSelectionFiltering._ForceSkip_d__27.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering._ForceSkip_d__27>.NativeClassPtr, "<>3__evt");
				WormPlayerSelectionFiltering._ForceSkip_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering._ForceSkip_d__27>.NativeClassPtr, "<>4__this");
				WormPlayerSelectionFiltering._ForceSkip_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._ForceSkip_d__27>.NativeClassPtr, 100663714);
				WormPlayerSelectionFiltering._ForceSkip_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._ForceSkip_d__27>.NativeClassPtr, 100663715);
				WormPlayerSelectionFiltering._ForceSkip_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._ForceSkip_d__27>.NativeClassPtr, 100663716);
				WormPlayerSelectionFiltering._ForceSkip_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._ForceSkip_d__27>.NativeClassPtr, 100663717);
				WormPlayerSelectionFiltering._ForceSkip_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._ForceSkip_d__27>.NativeClassPtr, 100663718);
				WormPlayerSelectionFiltering._ForceSkip_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._ForceSkip_d__27>.NativeClassPtr, 100663719);
				WormPlayerSelectionFiltering._ForceSkip_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._ForceSkip_d__27>.NativeClassPtr, 100663720);
				WormPlayerSelectionFiltering._ForceSkip_d__27.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._ForceSkip_d__27>.NativeClassPtr, 100663721);
			}

			// Token: 0x06004396 RID: 17302 RVA: 0x0017FD90 File Offset: 0x0017DF90
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ForceSkip_d__27(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering._ForceSkip_d__27>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._ForceSkip_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004397 RID: 17303 RVA: 0x0017FDD8 File Offset: 0x0017DFD8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._ForceSkip_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004398 RID: 17304 RVA: 0x0017FE0C File Offset: 0x0017E00C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30372, XrefRangeEnd = 30377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._ForceSkip_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001000 RID: 4096
			// (get) Token: 0x06004399 RID: 17305 RVA: 0x0017FE48 File Offset: 0x0017E048
			public unsafe IAttribute System.Collections.Generic.IEnumerator<Canis.attributes.IAttribute>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._ForceSkip_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
				}
			}

			// Token: 0x0600439A RID: 17306 RVA: 0x0017FE88 File Offset: 0x0017E088
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30377, XrefRangeEnd = 30382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._ForceSkip_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001001 RID: 4097
			// (get) Token: 0x0600439B RID: 17307 RVA: 0x0017FEBC File Offset: 0x0017E0BC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._ForceSkip_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600439C RID: 17308 RVA: 0x0017FEFC File Offset: 0x0017E0FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30382, XrefRangeEnd = 30391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<IAttribute> System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._ForceSkip_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute>>(intPtr3) : null;
			}

			// Token: 0x0600439D RID: 17309 RVA: 0x0017FF3C File Offset: 0x0017E13C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._ForceSkip_d__27.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600439E RID: 17310 RVA: 0x000160D3 File Offset: 0x000142D3
			public _ForceSkip_d__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FFA RID: 4090
			// (get) Token: 0x0600439F RID: 17311 RVA: 0x0017FF7C File Offset: 0x0017E17C
			// (set) Token: 0x060043A0 RID: 17312 RVA: 0x000160DC File Offset: 0x000142DC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._ForceSkip_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._ForceSkip_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FFB RID: 4091
			// (get) Token: 0x060043A1 RID: 17313 RVA: 0x0017FFA4 File Offset: 0x0017E1A4
			// (set) Token: 0x060043A2 RID: 17314 RVA: 0x000160F7 File Offset: 0x000142F7
			public unsafe IAttribute __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._ForceSkip_d__27.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._ForceSkip_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FFC RID: 4092
			// (get) Token: 0x060043A3 RID: 17315 RVA: 0x0017FFD4 File Offset: 0x0017E1D4
			// (set) Token: 0x060043A4 RID: 17316 RVA: 0x00016116 File Offset: 0x00014316
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._ForceSkip_d__27.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._ForceSkip_d__27.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000FFD RID: 4093
			// (get) Token: 0x060043A5 RID: 17317 RVA: 0x0017FFFC File Offset: 0x0017E1FC
			// (set) Token: 0x060043A6 RID: 17318 RVA: 0x00016131 File Offset: 0x00014331
			public unsafe NetworkMessageEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._ForceSkip_d__27.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._ForceSkip_d__27.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FFE RID: 4094
			// (get) Token: 0x060043A7 RID: 17319 RVA: 0x0018002C File Offset: 0x0017E22C
			// (set) Token: 0x060043A8 RID: 17320 RVA: 0x00016150 File Offset: 0x00014350
			public unsafe NetworkMessageEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._ForceSkip_d__27.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._ForceSkip_d__27.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FFF RID: 4095
			// (get) Token: 0x060043A9 RID: 17321 RVA: 0x0018005C File Offset: 0x0017E25C
			// (set) Token: 0x060043AA RID: 17322 RVA: 0x0001616F File Offset: 0x0001436F
			public unsafe WormPlayerSelectionFiltering __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._ForceSkip_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerSelectionFiltering>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._ForceSkip_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002CAE RID: 11438
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002CAF RID: 11439
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002CB0 RID: 11440
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002CB1 RID: 11441
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x04002CB2 RID: 11442
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x04002CB3 RID: 11443
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002CB4 RID: 11444
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002CB5 RID: 11445
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002CB6 RID: 11446
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002CB7 RID: 11447
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0;

			// Token: 0x04002CB8 RID: 11448
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002CB9 RID: 11449
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002CBA RID: 11450
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0;

			// Token: 0x04002CBB RID: 11451
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000585 RID: 1413
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<SelectAccept>d__25")]
		public sealed class _SelectAccept_d__25 : Object
		{
			// Token: 0x060043AB RID: 17323 RVA: 0x0018008C File Offset: 0x0017E28C
			// Note: this type is marked as 'beforefieldinit'.
			static _SelectAccept_d__25()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectAccept_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<SelectAccept>d__25");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectAccept_d__25>.NativeClassPtr);
				WormPlayerSelectionFiltering._SelectAccept_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectAccept_d__25>.NativeClassPtr, "<>1__state");
				WormPlayerSelectionFiltering._SelectAccept_d__25.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectAccept_d__25>.NativeClassPtr, "<>2__current");
				WormPlayerSelectionFiltering._SelectAccept_d__25.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectAccept_d__25>.NativeClassPtr, "<>l__initialThreadId");
				WormPlayerSelectionFiltering._SelectAccept_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectAccept_d__25>.NativeClassPtr, 100663722);
				WormPlayerSelectionFiltering._SelectAccept_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectAccept_d__25>.NativeClassPtr, 100663723);
				WormPlayerSelectionFiltering._SelectAccept_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectAccept_d__25>.NativeClassPtr, 100663724);
				WormPlayerSelectionFiltering._SelectAccept_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectAccept_d__25>.NativeClassPtr, 100663725);
				WormPlayerSelectionFiltering._SelectAccept_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectAccept_d__25>.NativeClassPtr, 100663726);
				WormPlayerSelectionFiltering._SelectAccept_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectAccept_d__25>.NativeClassPtr, 100663727);
				WormPlayerSelectionFiltering._SelectAccept_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectAccept_d__25>.NativeClassPtr, 100663728);
				WormPlayerSelectionFiltering._SelectAccept_d__25.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectAccept_d__25>.NativeClassPtr, 100663729);
			}

			// Token: 0x060043AC RID: 17324 RVA: 0x00180194 File Offset: 0x0017E394
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SelectAccept_d__25(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectAccept_d__25>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._SelectAccept_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060043AD RID: 17325 RVA: 0x001801DC File Offset: 0x0017E3DC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._SelectAccept_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060043AE RID: 17326 RVA: 0x00180210 File Offset: 0x0017E410
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30391, XrefRangeEnd = 30403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._SelectAccept_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001005 RID: 4101
			// (get) Token: 0x060043AF RID: 17327 RVA: 0x0018024C File Offset: 0x0017E44C
			public unsafe IAttribute System.Collections.Generic.IEnumerator<Canis.attributes.IAttribute>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._SelectAccept_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
				}
			}

			// Token: 0x060043B0 RID: 17328 RVA: 0x0018028C File Offset: 0x0017E48C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30403, XrefRangeEnd = 30408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._SelectAccept_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001006 RID: 4102
			// (get) Token: 0x060043B1 RID: 17329 RVA: 0x001802C0 File Offset: 0x0017E4C0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._SelectAccept_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060043B2 RID: 17330 RVA: 0x00180300 File Offset: 0x0017E500
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30408, XrefRangeEnd = 30410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<IAttribute> System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._SelectAccept_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute>>(intPtr3) : null;
			}

			// Token: 0x060043B3 RID: 17331 RVA: 0x00180340 File Offset: 0x0017E540
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._SelectAccept_d__25.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060043B4 RID: 17332 RVA: 0x0001618E File Offset: 0x0001438E
			public _SelectAccept_d__25(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001002 RID: 4098
			// (get) Token: 0x060043B5 RID: 17333 RVA: 0x00180380 File Offset: 0x0017E580
			// (set) Token: 0x060043B6 RID: 17334 RVA: 0x00016197 File Offset: 0x00014397
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._SelectAccept_d__25.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._SelectAccept_d__25.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001003 RID: 4099
			// (get) Token: 0x060043B7 RID: 17335 RVA: 0x001803A8 File Offset: 0x0017E5A8
			// (set) Token: 0x060043B8 RID: 17336 RVA: 0x000161B2 File Offset: 0x000143B2
			public unsafe IAttribute __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._SelectAccept_d__25.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._SelectAccept_d__25.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001004 RID: 4100
			// (get) Token: 0x060043B9 RID: 17337 RVA: 0x001803D8 File Offset: 0x0017E5D8
			// (set) Token: 0x060043BA RID: 17338 RVA: 0x000161D1 File Offset: 0x000143D1
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._SelectAccept_d__25.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._SelectAccept_d__25.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x04002CBC RID: 11452
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002CBD RID: 11453
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002CBE RID: 11454
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002CBF RID: 11455
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002CC0 RID: 11456
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002CC1 RID: 11457
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002CC2 RID: 11458
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0;

			// Token: 0x04002CC3 RID: 11459
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002CC4 RID: 11460
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002CC5 RID: 11461
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0;

			// Token: 0x04002CC6 RID: 11462
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000586 RID: 1414
		[ObfuscatedName("worm.canis.selectionfilters.WormPlayerSelectionFiltering+<SelectSkip>d__26")]
		public sealed class _SelectSkip_d__26 : Object
		{
			// Token: 0x060043BB RID: 17339 RVA: 0x00180400 File Offset: 0x0017E600
			// Note: this type is marked as 'beforefieldinit'.
			static _SelectSkip_d__26()
			{
				Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectSkip_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerSelectionFiltering>.NativeClassPtr, "<SelectSkip>d__26");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectSkip_d__26>.NativeClassPtr);
				WormPlayerSelectionFiltering._SelectSkip_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectSkip_d__26>.NativeClassPtr, "<>1__state");
				WormPlayerSelectionFiltering._SelectSkip_d__26.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectSkip_d__26>.NativeClassPtr, "<>2__current");
				WormPlayerSelectionFiltering._SelectSkip_d__26.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectSkip_d__26>.NativeClassPtr, "<>l__initialThreadId");
				WormPlayerSelectionFiltering._SelectSkip_d__26.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectSkip_d__26>.NativeClassPtr, "evt");
				WormPlayerSelectionFiltering._SelectSkip_d__26.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectSkip_d__26>.NativeClassPtr, "<>3__evt");
				WormPlayerSelectionFiltering._SelectSkip_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectSkip_d__26>.NativeClassPtr, "<>4__this");
				WormPlayerSelectionFiltering._SelectSkip_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectSkip_d__26>.NativeClassPtr, 100663730);
				WormPlayerSelectionFiltering._SelectSkip_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectSkip_d__26>.NativeClassPtr, 100663731);
				WormPlayerSelectionFiltering._SelectSkip_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectSkip_d__26>.NativeClassPtr, 100663732);
				WormPlayerSelectionFiltering._SelectSkip_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectSkip_d__26>.NativeClassPtr, 100663733);
				WormPlayerSelectionFiltering._SelectSkip_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectSkip_d__26>.NativeClassPtr, 100663734);
				WormPlayerSelectionFiltering._SelectSkip_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectSkip_d__26>.NativeClassPtr, 100663735);
				WormPlayerSelectionFiltering._SelectSkip_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectSkip_d__26>.NativeClassPtr, 100663736);
				WormPlayerSelectionFiltering._SelectSkip_d__26.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectSkip_d__26>.NativeClassPtr, 100663737);
			}

			// Token: 0x060043BC RID: 17340 RVA: 0x00180544 File Offset: 0x0017E744
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SelectSkip_d__26(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerSelectionFiltering._SelectSkip_d__26>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._SelectSkip_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060043BD RID: 17341 RVA: 0x0018058C File Offset: 0x0017E78C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._SelectSkip_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060043BE RID: 17342 RVA: 0x001805C0 File Offset: 0x0017E7C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30410, XrefRangeEnd = 30415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._SelectSkip_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700100D RID: 4109
			// (get) Token: 0x060043BF RID: 17343 RVA: 0x001805FC File Offset: 0x0017E7FC
			public unsafe IAttribute System.Collections.Generic.IEnumerator<Canis.attributes.IAttribute>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._SelectSkip_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
				}
			}

			// Token: 0x060043C0 RID: 17344 RVA: 0x0018063C File Offset: 0x0017E83C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30415, XrefRangeEnd = 30420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._SelectSkip_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700100E RID: 4110
			// (get) Token: 0x060043C1 RID: 17345 RVA: 0x00180670 File Offset: 0x0017E870
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._SelectSkip_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060043C2 RID: 17346 RVA: 0x001806B0 File Offset: 0x0017E8B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30420, XrefRangeEnd = 30429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<IAttribute> System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._SelectSkip_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute>>(intPtr3) : null;
			}

			// Token: 0x060043C3 RID: 17347 RVA: 0x001806F0 File Offset: 0x0017E8F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerSelectionFiltering._SelectSkip_d__26.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060043C4 RID: 17348 RVA: 0x000161EC File Offset: 0x000143EC
			public _SelectSkip_d__26(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001007 RID: 4103
			// (get) Token: 0x060043C5 RID: 17349 RVA: 0x00180730 File Offset: 0x0017E930
			// (set) Token: 0x060043C6 RID: 17350 RVA: 0x000161F5 File Offset: 0x000143F5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._SelectSkip_d__26.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._SelectSkip_d__26.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001008 RID: 4104
			// (get) Token: 0x060043C7 RID: 17351 RVA: 0x00180758 File Offset: 0x0017E958
			// (set) Token: 0x060043C8 RID: 17352 RVA: 0x00016210 File Offset: 0x00014410
			public unsafe IAttribute __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._SelectSkip_d__26.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._SelectSkip_d__26.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001009 RID: 4105
			// (get) Token: 0x060043C9 RID: 17353 RVA: 0x00180788 File Offset: 0x0017E988
			// (set) Token: 0x060043CA RID: 17354 RVA: 0x0001622F File Offset: 0x0001442F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._SelectSkip_d__26.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._SelectSkip_d__26.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700100A RID: 4106
			// (get) Token: 0x060043CB RID: 17355 RVA: 0x001807B0 File Offset: 0x0017E9B0
			// (set) Token: 0x060043CC RID: 17356 RVA: 0x0001624A File Offset: 0x0001444A
			public unsafe NetworkMessageEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._SelectSkip_d__26.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._SelectSkip_d__26.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700100B RID: 4107
			// (get) Token: 0x060043CD RID: 17357 RVA: 0x001807E0 File Offset: 0x0017E9E0
			// (set) Token: 0x060043CE RID: 17358 RVA: 0x00016269 File Offset: 0x00014469
			public unsafe NetworkMessageEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._SelectSkip_d__26.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._SelectSkip_d__26.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700100C RID: 4108
			// (get) Token: 0x060043CF RID: 17359 RVA: 0x00180810 File Offset: 0x0017EA10
			// (set) Token: 0x060043D0 RID: 17360 RVA: 0x00016288 File Offset: 0x00014488
			public unsafe WormPlayerSelectionFiltering __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._SelectSkip_d__26.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerSelectionFiltering>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerSelectionFiltering._SelectSkip_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002CC7 RID: 11463
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002CC8 RID: 11464
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002CC9 RID: 11465
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002CCA RID: 11466
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x04002CCB RID: 11467
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x04002CCC RID: 11468
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002CCD RID: 11469
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002CCE RID: 11470
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002CCF RID: 11471
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002CD0 RID: 11472
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0;

			// Token: 0x04002CD1 RID: 11473
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002CD2 RID: 11474
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002CD3 RID: 11475
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0;

			// Token: 0x04002CD4 RID: 11476
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
