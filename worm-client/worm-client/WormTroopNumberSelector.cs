using System;
using boardgames.match.behaviours;
using boardgames.match.selection;
using Canis.entities;
using Canis.utils.ids;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using worm;

// Token: 0x02000028 RID: 40
public class WormTroopNumberSelector : VersionedView<DBGSelectionResponder>
{
	// Token: 0x060001AA RID: 426 RVA: 0x0001E23C File Offset: 0x0001C43C
	// Note: this type is marked as 'beforefieldinit'.
	static WormTroopNumberSelector()
	{
		Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormTroopNumberSelector");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr);
		WormTroopNumberSelector.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, "root");
		WormTroopNumberSelector.NativeFieldInfoPtr_incrementButtonsTroop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, "incrementButtonsTroop");
		WormTroopNumberSelector.NativeFieldInfoPtr_decrementButtonsTroop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, "decrementButtonsTroop");
		WormTroopNumberSelector.NativeFieldInfoPtr_incrementButtonDreadnought = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, "incrementButtonDreadnought");
		WormTroopNumberSelector.NativeFieldInfoPtr_decrementButtonDreadnought = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, "decrementButtonDreadnought");
		WormTroopNumberSelector.NativeFieldInfoPtr_incrementButtonGeneric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, "incrementButtonGeneric");
		WormTroopNumberSelector.NativeFieldInfoPtr_decrementButtonGeneric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, "decrementButtonGeneric");
		WormTroopNumberSelector.NativeFieldInfoPtr_currentNumberText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, "currentNumberText");
		WormTroopNumberSelector.NativeFieldInfoPtr_deployText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, "deployText");
		WormTroopNumberSelector.NativeFieldInfoPtr_retreatText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, "retreatText");
		WormTroopNumberSelector.NativeFieldInfoPtr_dreadnoughtSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, "dreadnoughtSelector");
		WormTroopNumberSelector.NativeFieldInfoPtr_selectionNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, "selectionNode");
		WormTroopNumberSelector.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, "entities");
		WormTroopNumberSelector.NativeFieldInfoPtr_tutorialDisabledMinus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, "tutorialDisabledMinus");
		WormTroopNumberSelector.NativeFieldInfoPtr_tutorialDisabledPlus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, "tutorialDisabledPlus");
		WormTroopNumberSelector.NativeFieldInfoPtr_isDeploy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, "isDeploy");
		WormTroopNumberSelector.NativeMethodInfoPtr_Event_DisableMinus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, 100663587);
		WormTroopNumberSelector.NativeMethodInfoPtr_Event_DisablePlus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, 100663588);
		WormTroopNumberSelector.NativeMethodInfoPtr_Event_EnableMinus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, 100663589);
		WormTroopNumberSelector.NativeMethodInfoPtr_Event_EnablePlus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, 100663590);
		WormTroopNumberSelector.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, 100663591);
		WormTroopNumberSelector.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, 100663592);
		WormTroopNumberSelector.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, 100663593);
		WormTroopNumberSelector.NativeMethodInfoPtr_Event_Increment_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, 100663594);
		WormTroopNumberSelector.NativeMethodInfoPtr_Event_IncrementGeneric_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, 100663595);
		WormTroopNumberSelector.NativeMethodInfoPtr_Event_DecrementGeneric_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, 100663596);
		WormTroopNumberSelector.NativeMethodInfoPtr_internalIncrement_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, 100663597);
		WormTroopNumberSelector.NativeMethodInfoPtr_Event_Decrement_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, 100663598);
		WormTroopNumberSelector.NativeMethodInfoPtr_internalDecrement_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, 100663599);
		WormTroopNumberSelector.NativeMethodInfoPtr_internalSelect_Private_Boolean_IEnumerable_1_EntityID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, 100663600);
		WormTroopNumberSelector.NativeMethodInfoPtr_UpdateButtonStates_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, 100663601);
		WormTroopNumberSelector.NativeMethodInfoPtr_GetCounts_Private_ValueTuple_2_Int32_Int32_IEnumerable_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, 100663602);
		WormTroopNumberSelector.NativeMethodInfoPtr_UpdateButtonsInteractable_Private_Void_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, 100663603);
		WormTroopNumberSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, 100663604);
		WormTroopNumberSelector.NativeMethodInfoPtr__GetCounts_b__31_0_Private_String_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, 100663605);
	}

	// Token: 0x060001AB RID: 427 RVA: 0x0001E528 File Offset: 0x0001C728
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689457, XrefRangeEnd = 689458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_DisableMinus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.NativeMethodInfoPtr_Event_DisableMinus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001AC RID: 428 RVA: 0x0001E55C File Offset: 0x0001C75C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689458, XrefRangeEnd = 689459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_DisablePlus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.NativeMethodInfoPtr_Event_DisablePlus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001AD RID: 429 RVA: 0x0001E590 File Offset: 0x0001C790
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689459, XrefRangeEnd = 689460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_EnableMinus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.NativeMethodInfoPtr_Event_EnableMinus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001AE RID: 430 RVA: 0x0001E5C4 File Offset: 0x0001C7C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689460, XrefRangeEnd = 689461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_EnablePlus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.NativeMethodInfoPtr_Event_EnablePlus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001AF RID: 431 RVA: 0x0001E5F8 File Offset: 0x0001C7F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689461, XrefRangeEnd = 689472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTroopNumberSelector.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x0001E634 File Offset: 0x0001C834
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689472, XrefRangeEnd = 689477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x0001E674 File Offset: 0x0001C874
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689477, XrefRangeEnd = 689518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void dirtyUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTroopNumberSelector.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x0001E6B0 File Offset: 0x0001C8B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689518, XrefRangeEnd = 689519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_Increment(bool isDreadnought = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isDreadnought;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.NativeMethodInfoPtr_Event_Increment_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x0001E6F0 File Offset: 0x0001C8F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689519, XrefRangeEnd = 689520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_IncrementGeneric()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.NativeMethodInfoPtr_Event_IncrementGeneric_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x0001E724 File Offset: 0x0001C924
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689520, XrefRangeEnd = 689527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_DecrementGeneric()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.NativeMethodInfoPtr_Event_DecrementGeneric_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x0001E758 File Offset: 0x0001C958
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 689551, RefRangeEnd = 689553, XrefRangeStart = 689527, XrefRangeEnd = 689551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void internalIncrement(bool isDreadnought)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isDreadnought;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.NativeMethodInfoPtr_internalIncrement_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x0001E798 File Offset: 0x0001C998
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689553, XrefRangeEnd = 689554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_Decrement(bool isDreadnought = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isDreadnought;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.NativeMethodInfoPtr_Event_Decrement_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x0001E7D8 File Offset: 0x0001C9D8
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 689559, RefRangeEnd = 689562, XrefRangeStart = 689554, XrefRangeEnd = 689559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void internalDecrement(bool isDreadnought)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isDreadnought;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.NativeMethodInfoPtr_internalDecrement_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x0001E818 File Offset: 0x0001CA18
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 689590, RefRangeEnd = 689592, XrefRangeStart = 689562, XrefRangeEnd = 689590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool internalSelect(IEnumerable<EntityID> selectionsList, bool isDreadnought)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionsList);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDreadnought;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.NativeMethodInfoPtr_internalSelect_Private_Boolean_IEnumerable_1_EntityID_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x0001E874 File Offset: 0x0001CA74
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 689610, RefRangeEnd = 689616, XrefRangeStart = 689592, XrefRangeEnd = 689610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateButtonStates()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.NativeMethodInfoPtr_UpdateButtonStates_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001BA RID: 442 RVA: 0x0001E8A8 File Offset: 0x0001CAA8
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 689672, RefRangeEnd = 689676, XrefRangeStart = 689616, XrefRangeEnd = 689672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ValueTuple<int, int> GetCounts(IEnumerable<EntityID> selectionList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.NativeMethodInfoPtr_GetCounts_Private_ValueTuple_2_Int32_Int32_IEnumerable_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<int, int>(intPtr);
		}
	}

	// Token: 0x060001BB RID: 443 RVA: 0x0001E8F0 File Offset: 0x0001CAF0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 689686, RefRangeEnd = 689687, XrefRangeStart = 689676, XrefRangeEnd = 689686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateButtonsInteractable(bool canIncrementTroop, bool canIncrementDreadnought, bool canDecrementTroop, bool canDecrementDreadnought)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref canIncrementTroop;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canIncrementDreadnought;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canDecrementTroop;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canDecrementDreadnought;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.NativeMethodInfoPtr_UpdateButtonsInteractable_Private_Void_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001BC RID: 444 RVA: 0x0001E958 File Offset: 0x0001CB58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689687, XrefRangeEnd = 689697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormTroopNumberSelector()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001BD RID: 445 RVA: 0x0001E994 File Offset: 0x0001CB94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689697, XrefRangeEnd = 689698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string _GetCounts_b__31_0(EntityID id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.NativeMethodInfoPtr__GetCounts_b__31_0_Private_String_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x060001BE RID: 446 RVA: 0x00002C13 File Offset: 0x00000E13
	public WormTroopNumberSelector(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x060001BF RID: 447 RVA: 0x0001E9DC File Offset: 0x0001CBDC
	// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002C1C File Offset: 0x00000E1C
	public unsafe GameObject root
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_root);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x060001C1 RID: 449 RVA: 0x0001EA0C File Offset: 0x0001CC0C
	// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002C3B File Offset: 0x00000E3B
	public unsafe Il2CppReferenceArray<Button> incrementButtonsTroop
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_incrementButtonsTroop);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_incrementButtonsTroop), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x060001C3 RID: 451 RVA: 0x0001EA3C File Offset: 0x0001CC3C
	// (set) Token: 0x060001C4 RID: 452 RVA: 0x00002C5A File Offset: 0x00000E5A
	public unsafe Il2CppReferenceArray<Button> decrementButtonsTroop
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_decrementButtonsTroop);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_decrementButtonsTroop), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x060001C5 RID: 453 RVA: 0x0001EA6C File Offset: 0x0001CC6C
	// (set) Token: 0x060001C6 RID: 454 RVA: 0x00002C79 File Offset: 0x00000E79
	public unsafe Button incrementButtonDreadnought
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_incrementButtonDreadnought);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_incrementButtonDreadnought), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x060001C7 RID: 455 RVA: 0x0001EA9C File Offset: 0x0001CC9C
	// (set) Token: 0x060001C8 RID: 456 RVA: 0x00002C98 File Offset: 0x00000E98
	public unsafe Button decrementButtonDreadnought
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_decrementButtonDreadnought);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_decrementButtonDreadnought), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x060001C9 RID: 457 RVA: 0x0001EACC File Offset: 0x0001CCCC
	// (set) Token: 0x060001CA RID: 458 RVA: 0x00002CB7 File Offset: 0x00000EB7
	public unsafe Button incrementButtonGeneric
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_incrementButtonGeneric);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_incrementButtonGeneric), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x060001CB RID: 459 RVA: 0x0001EAFC File Offset: 0x0001CCFC
	// (set) Token: 0x060001CC RID: 460 RVA: 0x00002CD6 File Offset: 0x00000ED6
	public unsafe Button decrementButtonGeneric
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_decrementButtonGeneric);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_decrementButtonGeneric), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x060001CD RID: 461 RVA: 0x0001EB2C File Offset: 0x0001CD2C
	// (set) Token: 0x060001CE RID: 462 RVA: 0x00002CF5 File Offset: 0x00000EF5
	public unsafe TMP_Text currentNumberText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_currentNumberText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_currentNumberText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x060001CF RID: 463 RVA: 0x0001EB5C File Offset: 0x0001CD5C
	// (set) Token: 0x060001D0 RID: 464 RVA: 0x00002D14 File Offset: 0x00000F14
	public unsafe GameObject deployText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_deployText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_deployText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x060001D1 RID: 465 RVA: 0x0001EB8C File Offset: 0x0001CD8C
	// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002D33 File Offset: 0x00000F33
	public unsafe GameObject retreatText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_retreatText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_retreatText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x060001D3 RID: 467 RVA: 0x0001EBBC File Offset: 0x0001CDBC
	// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002D52 File Offset: 0x00000F52
	public unsafe GameObject dreadnoughtSelector
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_dreadnoughtSelector);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_dreadnoughtSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x060001D5 RID: 469 RVA: 0x0001EBEC File Offset: 0x0001CDEC
	// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002D71 File Offset: 0x00000F71
	public unsafe IEntityListSelection selectionNode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_selectionNode);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEntityListSelection>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_selectionNode), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x060001D7 RID: 471 RVA: 0x0001EC1C File Offset: 0x0001CE1C
	// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002D90 File Offset: 0x00000F90
	public unsafe WormEntities entities
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_entities);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntities>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x060001D9 RID: 473 RVA: 0x0001EC4C File Offset: 0x0001CE4C
	// (set) Token: 0x060001DA RID: 474 RVA: 0x00002DAF File Offset: 0x00000FAF
	public unsafe bool tutorialDisabledMinus
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_tutorialDisabledMinus);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_tutorialDisabledMinus)) = value;
		}
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x060001DB RID: 475 RVA: 0x0001EC74 File Offset: 0x0001CE74
	// (set) Token: 0x060001DC RID: 476 RVA: 0x00002DCA File Offset: 0x00000FCA
	public unsafe bool tutorialDisabledPlus
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_tutorialDisabledPlus);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_tutorialDisabledPlus)) = value;
		}
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x060001DD RID: 477 RVA: 0x0001EC9C File Offset: 0x0001CE9C
	// (set) Token: 0x060001DE RID: 478 RVA: 0x00002DE5 File Offset: 0x00000FE5
	public unsafe bool isDeploy
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_isDeploy);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.NativeFieldInfoPtr_isDeploy)) = value;
		}
	}

	// Token: 0x04000107 RID: 263
	private static readonly IntPtr NativeFieldInfoPtr_root;

	// Token: 0x04000108 RID: 264
	private static readonly IntPtr NativeFieldInfoPtr_incrementButtonsTroop;

	// Token: 0x04000109 RID: 265
	private static readonly IntPtr NativeFieldInfoPtr_decrementButtonsTroop;

	// Token: 0x0400010A RID: 266
	private static readonly IntPtr NativeFieldInfoPtr_incrementButtonDreadnought;

	// Token: 0x0400010B RID: 267
	private static readonly IntPtr NativeFieldInfoPtr_decrementButtonDreadnought;

	// Token: 0x0400010C RID: 268
	private static readonly IntPtr NativeFieldInfoPtr_incrementButtonGeneric;

	// Token: 0x0400010D RID: 269
	private static readonly IntPtr NativeFieldInfoPtr_decrementButtonGeneric;

	// Token: 0x0400010E RID: 270
	private static readonly IntPtr NativeFieldInfoPtr_currentNumberText;

	// Token: 0x0400010F RID: 271
	private static readonly IntPtr NativeFieldInfoPtr_deployText;

	// Token: 0x04000110 RID: 272
	private static readonly IntPtr NativeFieldInfoPtr_retreatText;

	// Token: 0x04000111 RID: 273
	private static readonly IntPtr NativeFieldInfoPtr_dreadnoughtSelector;

	// Token: 0x04000112 RID: 274
	private static readonly IntPtr NativeFieldInfoPtr_selectionNode;

	// Token: 0x04000113 RID: 275
	private static readonly IntPtr NativeFieldInfoPtr_entities;

	// Token: 0x04000114 RID: 276
	private static readonly IntPtr NativeFieldInfoPtr_tutorialDisabledMinus;

	// Token: 0x04000115 RID: 277
	private static readonly IntPtr NativeFieldInfoPtr_tutorialDisabledPlus;

	// Token: 0x04000116 RID: 278
	private static readonly IntPtr NativeFieldInfoPtr_isDeploy;

	// Token: 0x04000117 RID: 279
	private static readonly IntPtr NativeMethodInfoPtr_Event_DisableMinus_Public_Void_0;

	// Token: 0x04000118 RID: 280
	private static readonly IntPtr NativeMethodInfoPtr_Event_DisablePlus_Public_Void_0;

	// Token: 0x04000119 RID: 281
	private static readonly IntPtr NativeMethodInfoPtr_Event_EnableMinus_Public_Void_0;

	// Token: 0x0400011A RID: 282
	private static readonly IntPtr NativeMethodInfoPtr_Event_EnablePlus_Public_Void_0;

	// Token: 0x0400011B RID: 283
	private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

	// Token: 0x0400011C RID: 284
	private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

	// Token: 0x0400011D RID: 285
	private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

	// Token: 0x0400011E RID: 286
	private static readonly IntPtr NativeMethodInfoPtr_Event_Increment_Public_Void_Boolean_0;

	// Token: 0x0400011F RID: 287
	private static readonly IntPtr NativeMethodInfoPtr_Event_IncrementGeneric_Public_Void_0;

	// Token: 0x04000120 RID: 288
	private static readonly IntPtr NativeMethodInfoPtr_Event_DecrementGeneric_Public_Void_0;

	// Token: 0x04000121 RID: 289
	private static readonly IntPtr NativeMethodInfoPtr_internalIncrement_Private_Void_Boolean_0;

	// Token: 0x04000122 RID: 290
	private static readonly IntPtr NativeMethodInfoPtr_Event_Decrement_Public_Void_Boolean_0;

	// Token: 0x04000123 RID: 291
	private static readonly IntPtr NativeMethodInfoPtr_internalDecrement_Private_Void_Boolean_0;

	// Token: 0x04000124 RID: 292
	private static readonly IntPtr NativeMethodInfoPtr_internalSelect_Private_Boolean_IEnumerable_1_EntityID_Boolean_0;

	// Token: 0x04000125 RID: 293
	private static readonly IntPtr NativeMethodInfoPtr_UpdateButtonStates_Private_Void_0;

	// Token: 0x04000126 RID: 294
	private static readonly IntPtr NativeMethodInfoPtr_GetCounts_Private_ValueTuple_2_Int32_Int32_IEnumerable_1_EntityID_0;

	// Token: 0x04000127 RID: 295
	private static readonly IntPtr NativeMethodInfoPtr_UpdateButtonsInteractable_Private_Void_Boolean_Boolean_Boolean_Boolean_0;

	// Token: 0x04000128 RID: 296
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000129 RID: 297
	private static readonly IntPtr NativeMethodInfoPtr__GetCounts_b__31_0_Private_String_EntityID_0;

	// Token: 0x020002C8 RID: 712
	[ObfuscatedName("WormTroopNumberSelector+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x06001D0A RID: 7434 RVA: 0x00071420 File Offset: 0x0006F620
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<WormTroopNumberSelector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTroopNumberSelector.__c>.NativeClassPtr);
			WormTroopNumberSelector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector.__c>.NativeClassPtr, "<>9");
			WormTroopNumberSelector.__c.NativeFieldInfoPtr___9__31_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector.__c>.NativeClassPtr, "<>9__31_1");
			WormTroopNumberSelector.__c.NativeFieldInfoPtr___9__31_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector.__c>.NativeClassPtr, "<>9__31_2");
			WormTroopNumberSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector.__c>.NativeClassPtr, 100663607);
			WormTroopNumberSelector.__c.NativeMethodInfoPtr__GetCounts_b__31_1_Internal_String_IGrouping_2_String_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector.__c>.NativeClassPtr, 100663608);
			WormTroopNumberSelector.__c.NativeMethodInfoPtr__GetCounts_b__31_2_Internal_Int32_IGrouping_2_String_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector.__c>.NativeClassPtr, 100663609);
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x000714C4 File Offset: 0x0006F6C4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTroopNumberSelector.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x00071500 File Offset: 0x0006F700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689433, XrefRangeEnd = 689437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _GetCounts_b__31_1(IGrouping<string, EntityID> g)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.__c.NativeMethodInfoPtr__GetCounts_b__31_1_Internal_String_IGrouping_2_String_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00071548 File Offset: 0x0006F748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689437, XrefRangeEnd = 689440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _GetCounts_b__31_2(IGrouping<string, EntityID> g)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.__c.NativeMethodInfoPtr__GetCounts_b__31_2_Internal_Int32_IGrouping_2_String_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x000109E7 File Offset: 0x0000EBE7
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x00071598 File Offset: 0x0006F798
		// (set) Token: 0x06001D10 RID: 7440 RVA: 0x000109F0 File Offset: 0x0000EBF0
		public unsafe static WormTroopNumberSelector.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTroopNumberSelector.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTroopNumberSelector.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTroopNumberSelector.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x000715C0 File Offset: 0x0006F7C0
		// (set) Token: 0x06001D12 RID: 7442 RVA: 0x00010A02 File Offset: 0x0000EC02
		public unsafe static Func<IGrouping<string, EntityID>, string> __9__31_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTroopNumberSelector.__c.NativeFieldInfoPtr___9__31_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<string, EntityID>, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTroopNumberSelector.__c.NativeFieldInfoPtr___9__31_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x000715E8 File Offset: 0x0006F7E8
		// (set) Token: 0x06001D14 RID: 7444 RVA: 0x00010A14 File Offset: 0x0000EC14
		public unsafe static Func<IGrouping<string, EntityID>, int> __9__31_2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTroopNumberSelector.__c.NativeFieldInfoPtr___9__31_2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<string, EntityID>, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTroopNumberSelector.__c.NativeFieldInfoPtr___9__31_2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeFieldInfoPtr___9__31_1;

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeFieldInfoPtr___9__31_2;

		// Token: 0x040010CA RID: 4298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040010CB RID: 4299
		private static readonly IntPtr NativeMethodInfoPtr__GetCounts_b__31_1_Internal_String_IGrouping_2_String_EntityID_0;

		// Token: 0x040010CC RID: 4300
		private static readonly IntPtr NativeMethodInfoPtr__GetCounts_b__31_2_Internal_Int32_IGrouping_2_String_EntityID_0;
	}

	// Token: 0x020002C9 RID: 713
	[ObfuscatedName("WormTroopNumberSelector+<>c__DisplayClass29_0")]
	public sealed class __c__DisplayClass29_0 : global::Il2CppSystem.Object
	{
		// Token: 0x06001D15 RID: 7445 RVA: 0x00071610 File Offset: 0x0006F810
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass29_0()
		{
			Il2CppClassPointerStore<WormTroopNumberSelector.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, "<>c__DisplayClass29_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTroopNumberSelector.__c__DisplayClass29_0>.NativeClassPtr);
			WormTroopNumberSelector.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector.__c__DisplayClass29_0>.NativeClassPtr, "<>4__this");
			WormTroopNumberSelector.__c__DisplayClass29_0.NativeFieldInfoPtr_entityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector.__c__DisplayClass29_0>.NativeClassPtr, "entityName");
			WormTroopNumberSelector.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector.__c__DisplayClass29_0>.NativeClassPtr, 100663610);
			WormTroopNumberSelector.__c__DisplayClass29_0.NativeMethodInfoPtr__internalSelect_b__0_Internal_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector.__c__DisplayClass29_0>.NativeClassPtr, 100663611);
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x0007168C File Offset: 0x0006F88C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass29_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTroopNumberSelector.__c__DisplayClass29_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x000716C8 File Offset: 0x0006F8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689440, XrefRangeEnd = 689444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _internalSelect_b__0(EntityID s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector.__c__DisplayClass29_0.NativeMethodInfoPtr__internalSelect_b__0_Internal_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x00010A26 File Offset: 0x0000EC26
		public __c__DisplayClass29_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x00071718 File Offset: 0x0006F918
		// (set) Token: 0x06001D1A RID: 7450 RVA: 0x00010A2F File Offset: 0x0000EC2F
		public unsafe WormTroopNumberSelector __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTroopNumberSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x00071748 File Offset: 0x0006F948
		// (set) Token: 0x06001D1C RID: 7452 RVA: 0x00010A4E File Offset: 0x0000EC4E
		public unsafe EntityName entityName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.__c__DisplayClass29_0.NativeFieldInfoPtr_entityName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector.__c__DisplayClass29_0.NativeFieldInfoPtr_entityName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeFieldInfoPtr_entityName;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeMethodInfoPtr__internalSelect_b__0_Internal_Boolean_EntityID_0;
	}

	// Token: 0x020002CA RID: 714
	[ObfuscatedName("WormTroopNumberSelector+<Init>d__21")]
	public sealed class _Init_d__21 : global::Il2CppSystem.Object
	{
		// Token: 0x06001D1D RID: 7453 RVA: 0x00071778 File Offset: 0x0006F978
		// Note: this type is marked as 'beforefieldinit'.
		static _Init_d__21()
		{
			Il2CppClassPointerStore<WormTroopNumberSelector._Init_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTroopNumberSelector>.NativeClassPtr, "<Init>d__21");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTroopNumberSelector._Init_d__21>.NativeClassPtr);
			WormTroopNumberSelector._Init_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector._Init_d__21>.NativeClassPtr, "<>1__state");
			WormTroopNumberSelector._Init_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector._Init_d__21>.NativeClassPtr, "<>2__current");
			WormTroopNumberSelector._Init_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector._Init_d__21>.NativeClassPtr, "<>4__this");
			WormTroopNumberSelector._Init_d__21.NativeFieldInfoPtr__provider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTroopNumberSelector._Init_d__21>.NativeClassPtr, "<provider>5__2");
			WormTroopNumberSelector._Init_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector._Init_d__21>.NativeClassPtr, 100663612);
			WormTroopNumberSelector._Init_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector._Init_d__21>.NativeClassPtr, 100663613);
			WormTroopNumberSelector._Init_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector._Init_d__21>.NativeClassPtr, 100663614);
			WormTroopNumberSelector._Init_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector._Init_d__21>.NativeClassPtr, 100663615);
			WormTroopNumberSelector._Init_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector._Init_d__21>.NativeClassPtr, 100663616);
			WormTroopNumberSelector._Init_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroopNumberSelector._Init_d__21>.NativeClassPtr, 100663617);
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x0007186C File Offset: 0x0006FA6C
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Init_d__21(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTroopNumberSelector._Init_d__21>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector._Init_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x000718B4 File Offset: 0x0006FAB4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector._Init_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x000718E8 File Offset: 0x0006FAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689444, XrefRangeEnd = 689452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector._Init_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x00071924 File Offset: 0x0006FB24
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector._Init_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x00071964 File Offset: 0x0006FB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689452, XrefRangeEnd = 689457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector._Init_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x00071998 File Offset: 0x0006FB98
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroopNumberSelector._Init_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x00010A6D File Offset: 0x0000EC6D
		public _Init_d__21(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x000719D8 File Offset: 0x0006FBD8
		// (set) Token: 0x06001D26 RID: 7462 RVA: 0x00010A76 File Offset: 0x0000EC76
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector._Init_d__21.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector._Init_d__21.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x00071A00 File Offset: 0x0006FC00
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x00010A91 File Offset: 0x0000EC91
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector._Init_d__21.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector._Init_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x00071A30 File Offset: 0x0006FC30
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x00010AB0 File Offset: 0x0000ECB0
		public unsafe WormTroopNumberSelector __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector._Init_d__21.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTroopNumberSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector._Init_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x00071A60 File Offset: 0x0006FC60
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x00010ACF File Offset: 0x0000ECCF
		public unsafe DBGEntitiesProvider _provider_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector._Init_d__21.NativeFieldInfoPtr__provider_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTroopNumberSelector._Init_d__21.NativeFieldInfoPtr__provider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeFieldInfoPtr__provider_5__2;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
