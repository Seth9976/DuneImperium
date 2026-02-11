using System;
using System.Runtime.InteropServices;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages;
using Networking.selection.messages.outgoing;
using Networking.selection.targetinformation;
using Networking.selection.targetresponse;
using worm.canis.abilities;

namespace worm.canis.ai.choices
{
	// Token: 0x02000221 RID: 545
	public class WormAIChoiceSelectionWithTargets : WormAIChoice
	{
		// Token: 0x060017F3 RID: 6131 RVA: 0x000B5CFC File Offset: 0x000B3EFC
		// Note: this type is marked as 'beforefieldinit'.
		static WormAIChoiceSelectionWithTargets()
		{
			Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.ai.choices", "WormAIChoiceSelectionWithTargets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr);
			WormAIChoiceSelectionWithTargets.NativeFieldInfoPtr_response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, "response");
			WormAIChoiceSelectionWithTargets.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, "selection");
			WormAIChoiceSelectionWithTargets.NativeFieldInfoPtr__FirstSelectionID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, "<FirstSelectionID>k__BackingField");
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_get_FirstSelectionID_Public_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667347);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_set_FirstSelectionID_Public_set_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667348);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667349);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_WormAbilityDefinition_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667350);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_get_IgnoreFirst_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667351);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_UpdateTargets_Public_Void_Double_Il2CppReferenceArray_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667352);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_UpdateSelectionTargets_Public_Void_Double_EntityID_Il2CppReferenceArray_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667353);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_UpdateResponses_Public_Void_Double_Il2CppReferenceArray_1_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667354);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_UpdateSelectionResponses_Public_Void_Double_EntityID_Il2CppReferenceArray_1_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667355);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_GetTargetMap_Public_Dictionary_2_Entity_Il2CppReferenceArray_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667356);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_GetTargetInfos_Public_Il2CppReferenceArray_1_TargetInformation_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667357);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_GetTargetInfo_Public_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667358);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_GetEntityTargetInfo_Public_EntityListTargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667359);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_GetTargets_Public_IEnumerable_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667360);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_GetTargets_Public_IEnumerable_1_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667361);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_GetFlattenedTargets_Public_IEnumerable_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667362);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_GetResponse_Public_Virtual_ISelectionCounter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667363);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_Combine_Public_Static_WormAIChoiceSelectionWithTargets_WormAIChoiceSelectionWithTargets_WormAIChoiceSelectionWithTargets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667364);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667365);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr__GetTargets_b__18_0_Private_IEnumerable_1_Entity_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667366);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr__GetTargets_b__19_0_Private_IEnumerable_1_Entity_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667367);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr__GetFlattenedTargets_b__20_0_Private_IEnumerable_1_Entity_KeyValuePair_2_Entity_Il2CppReferenceArray_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667368);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr__GetFlattenedTargets_b__20_1_Private_IEnumerable_1_Entity_EntityListTargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667369);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr__GetFlattenedTargets_b__20_2_Private_IEnumerable_1_Entity_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667370);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr__ToString_b__23_0_Private_IEnumerable_1_String_EntityListTargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667371);
			WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr__ToString_b__23_2_Private_String_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, 100667372);
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x060017F4 RID: 6132 RVA: 0x000B5F70 File Offset: 0x000B4170
		// (set) Token: 0x060017F5 RID: 6133 RVA: 0x000B5FB0 File Offset: 0x000B41B0
		public unsafe EntityID FirstSelectionID
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_get_FirstSelectionID_Public_get_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129672, XrefRangeEnd = 129673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_set_FirstSelectionID_Public_set_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x000B5FF4 File Offset: 0x000B41F4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 129674, RefRangeEnd = 129686, XrefRangeStart = 129673, XrefRangeEnd = 129674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAIChoiceSelectionWithTargets(WormAIChoiceContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_WormAIChoiceContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x000B6040 File Offset: 0x000B4240
		[CallerCount(193)]
		[CachedScanResults(RefRangeStart = 129703, RefRangeEnd = 129896, XrefRangeStart = 129686, XrefRangeEnd = 129703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAIChoiceSelectionWithTargets(WormAbilityDefinition ability, WormAIChoiceContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr__ctor_Public_Void_WormAbilityDefinition_WormAIChoiceContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x060017F8 RID: 6136 RVA: 0x000B60A0 File Offset: 0x000B42A0
		public unsafe bool IgnoreFirst
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_get_IgnoreFirst_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x000B60DC File Offset: 0x000B42DC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 129897, RefRangeEnd = 129902, XrefRangeStart = 129896, XrefRangeEnd = 129897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTargets(double value, [Optional] Il2CppReferenceArray<EntityID> targets)
		{
			if (targets == null)
			{
				targets = new Il2CppReferenceArray<EntityID>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targets);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_UpdateTargets_Public_Void_Double_Il2CppReferenceArray_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x000B613C File Offset: 0x000B433C
		[CallerCount(165)]
		[CachedScanResults(RefRangeStart = 129920, RefRangeEnd = 130085, XrefRangeStart = 129902, XrefRangeEnd = 129920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSelectionTargets(double value, EntityID firstSelectionID, [Optional] Il2CppReferenceArray<EntityID> targets)
		{
			if (targets == null)
			{
				targets = new Il2CppReferenceArray<EntityID>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstSelectionID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targets);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_UpdateSelectionTargets_Public_Void_Double_EntityID_Il2CppReferenceArray_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x000B61AC File Offset: 0x000B43AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130097, RefRangeEnd = 130099, XrefRangeStart = 130085, XrefRangeEnd = 130097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateResponses(double value, [Optional] Il2CppReferenceArray<TargetResponse> responses)
		{
			if (responses == null)
			{
				responses = new Il2CppReferenceArray<TargetResponse>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responses);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_UpdateResponses_Public_Void_Double_Il2CppReferenceArray_1_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x000B620C File Offset: 0x000B440C
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 130111, RefRangeEnd = 130169, XrefRangeStart = 130099, XrefRangeEnd = 130111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSelectionResponses(double value, EntityID firstSelectionID, [Optional] Il2CppReferenceArray<TargetResponse> responses)
		{
			if (responses == null)
			{
				responses = new Il2CppReferenceArray<TargetResponse>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstSelectionID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responses);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_UpdateSelectionResponses_Public_Void_Double_EntityID_Il2CppReferenceArray_1_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x000B627C File Offset: 0x000B447C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 130205, RefRangeEnd = 130208, XrefRangeStart = 130169, XrefRangeEnd = 130205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<Entity, Il2CppReferenceArray<TargetInformation>> GetTargetMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_GetTargetMap_Public_Dictionary_2_Entity_Il2CppReferenceArray_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<Entity, Il2CppReferenceArray<TargetInformation>>>(intPtr3) : null;
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x000B62BC File Offset: 0x000B44BC
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 130221, RefRangeEnd = 130255, XrefRangeStart = 130208, XrefRangeEnd = 130221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TargetInformation> GetTargetInfos(Entity owner = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_GetTargetInfos_Public_Il2CppReferenceArray_1_TargetInformation_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TargetInformation>>(intPtr3) : null;
			}
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x000B630C File Offset: 0x000B450C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130255, XrefRangeEnd = 130264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetInformation GetTargetInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_GetTargetInfo_Public_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr3) : null;
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x000B634C File Offset: 0x000B454C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130264, XrefRangeEnd = 130279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityListTargetInformation GetEntityTargetInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_GetEntityTargetInfo_Public_EntityListTargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityListTargetInformation>(intPtr3) : null;
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x000B638C File Offset: 0x000B458C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 130308, RefRangeEnd = 130320, XrefRangeStart = 130279, XrefRangeEnd = 130308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> GetTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_GetTargets_Public_IEnumerable_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x000B63CC File Offset: 0x000B45CC
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 130342, RefRangeEnd = 130408, XrefRangeStart = 130320, XrefRangeEnd = 130342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> GetTargets(Entity source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_GetTargets_Public_IEnumerable_1_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x000B641C File Offset: 0x000B461C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130408, XrefRangeEnd = 130418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> GetFlattenedTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_GetFlattenedTargets_Public_IEnumerable_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x000B645C File Offset: 0x000B465C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130418, XrefRangeEnd = 130450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISelectionCounter GetResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_GetResponse_Public_Virtual_ISelectionCounter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionCounter>(intPtr3) : null;
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x000B64A8 File Offset: 0x000B46A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130450, XrefRangeEnd = 130461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WormAIChoiceSelectionWithTargets Combine(WormAIChoiceSelectionWithTargets choice1, WormAIChoiceSelectionWithTargets choice2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(choice1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(choice2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_Combine_Public_Static_WormAIChoiceSelectionWithTargets_WormAIChoiceSelectionWithTargets_WormAIChoiceSelectionWithTargets_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoiceSelectionWithTargets>(intPtr3) : null;
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x000B6500 File Offset: 0x000B4700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130461, XrefRangeEnd = 130533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x000B6544 File Offset: 0x000B4744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130533, XrefRangeEnd = 130543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> _GetTargets_b__18_0(EntityID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr__GetTargets_b__18_0_Private_IEnumerable_1_Entity_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x000B6594 File Offset: 0x000B4794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130543, XrefRangeEnd = 130553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> _GetTargets_b__19_0(EntityID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr__GetTargets_b__19_0_Private_IEnumerable_1_Entity_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x000B65E4 File Offset: 0x000B47E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130553, XrefRangeEnd = 130566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> _GetFlattenedTargets_b__20_0(KeyValuePair<Entity, Il2CppReferenceArray<TargetInformation>> kvp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr__GetFlattenedTargets_b__20_0_Private_IEnumerable_1_Entity_KeyValuePair_2_Entity_Il2CppReferenceArray_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x000B663C File Offset: 0x000B483C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130566, XrefRangeEnd = 130576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> _GetFlattenedTargets_b__20_1(EntityListTargetInformation _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr__GetFlattenedTargets_b__20_1_Private_IEnumerable_1_Entity_EntityListTargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x000B668C File Offset: 0x000B488C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130576, XrefRangeEnd = 130586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> _GetFlattenedTargets_b__20_2(EntityID eid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr__GetFlattenedTargets_b__20_2_Private_IEnumerable_1_Entity_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x000B66DC File Offset: 0x000B48DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130586, XrefRangeEnd = 130596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<string> _ToString_b__23_0(EntityListTargetResponse eltr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eltr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr__ToString_b__23_0_Private_IEnumerable_1_String_EntityListTargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x000B672C File Offset: 0x000B492C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130596, XrefRangeEnd = 130600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _ToString_b__23_2(EntityID eid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.NativeMethodInfoPtr__ToString_b__23_2_Private_String_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x0000A6D5 File Offset: 0x000088D5
		public void UpdateTargets(double value, params EntityID[] targets)
		{
			this.UpdateTargets(value, new Il2CppReferenceArray<EntityID>(targets));
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x0000A6E4 File Offset: 0x000088E4
		public void UpdateSelectionTargets(double value, EntityID firstSelectionID, params EntityID[] targets)
		{
			this.UpdateSelectionTargets(value, firstSelectionID, new Il2CppReferenceArray<EntityID>(targets));
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x0000A6F4 File Offset: 0x000088F4
		public void UpdateResponses(double value, params TargetResponse[] responses)
		{
			this.UpdateResponses(value, new Il2CppReferenceArray<TargetResponse>(responses));
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x0000A703 File Offset: 0x00008903
		public void UpdateSelectionResponses(double value, EntityID firstSelectionID, params TargetResponse[] responses)
		{
			this.UpdateSelectionResponses(value, firstSelectionID, new Il2CppReferenceArray<TargetResponse>(responses));
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x0000A713 File Offset: 0x00008913
		public WormAIChoiceSelectionWithTargets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x000B6774 File Offset: 0x000B4974
		// (set) Token: 0x06001814 RID: 6164 RVA: 0x0000A71C File Offset: 0x0000891C
		public unsafe List<TargetResponse> response
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceSelectionWithTargets.NativeFieldInfoPtr_response);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TargetResponse>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceSelectionWithTargets.NativeFieldInfoPtr_response), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x000B67A4 File Offset: 0x000B49A4
		// (set) Token: 0x06001816 RID: 6166 RVA: 0x0000A73B File Offset: 0x0000893B
		public unsafe SelectionWithTargetsRequired selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceSelectionWithTargets.NativeFieldInfoPtr_selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionWithTargetsRequired>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceSelectionWithTargets.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001817 RID: 6167 RVA: 0x000B67D4 File Offset: 0x000B49D4
		// (set) Token: 0x06001818 RID: 6168 RVA: 0x0000A75A File Offset: 0x0000895A
		public unsafe EntityID _FirstSelectionID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceSelectionWithTargets.NativeFieldInfoPtr__FirstSelectionID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceSelectionWithTargets.NativeFieldInfoPtr__FirstSelectionID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeFieldInfoPtr_response;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeFieldInfoPtr__FirstSelectionID_k__BackingField;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeMethodInfoPtr_get_FirstSelectionID_Public_get_EntityID_0;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeMethodInfoPtr_set_FirstSelectionID_Public_set_Void_EntityID_0;

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormAIChoiceContext_0;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormAbilityDefinition_WormAIChoiceContext_0;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreFirst_Public_get_Boolean_0;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTargets_Public_Void_Double_Il2CppReferenceArray_1_EntityID_0;

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSelectionTargets_Public_Void_Double_EntityID_Il2CppReferenceArray_1_EntityID_0;

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeMethodInfoPtr_UpdateResponses_Public_Void_Double_Il2CppReferenceArray_1_TargetResponse_0;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSelectionResponses_Public_Void_Double_EntityID_Il2CppReferenceArray_1_TargetResponse_0;

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetMap_Public_Dictionary_2_Entity_Il2CppReferenceArray_1_TargetInformation_0;

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetInfos_Public_Il2CppReferenceArray_1_TargetInformation_Entity_0;

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetInfo_Public_TargetInformation_0;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeMethodInfoPtr_GetEntityTargetInfo_Public_EntityListTargetInformation_0;

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeMethodInfoPtr_GetTargets_Public_IEnumerable_1_Entity_0;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeMethodInfoPtr_GetTargets_Public_IEnumerable_1_Entity_Entity_0;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeMethodInfoPtr_GetFlattenedTargets_Public_IEnumerable_1_Entity_0;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_Virtual_ISelectionCounter_0;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_WormAIChoiceSelectionWithTargets_WormAIChoiceSelectionWithTargets_WormAIChoiceSelectionWithTargets_0;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeMethodInfoPtr__GetTargets_b__18_0_Private_IEnumerable_1_Entity_EntityID_0;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeMethodInfoPtr__GetTargets_b__19_0_Private_IEnumerable_1_Entity_EntityID_0;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr__GetFlattenedTargets_b__20_0_Private_IEnumerable_1_Entity_KeyValuePair_2_Entity_Il2CppReferenceArray_1_TargetInformation_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr__GetFlattenedTargets_b__20_1_Private_IEnumerable_1_Entity_EntityListTargetInformation_0;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeMethodInfoPtr__GetFlattenedTargets_b__20_2_Private_IEnumerable_1_Entity_EntityID_0;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeMethodInfoPtr__ToString_b__23_0_Private_IEnumerable_1_String_EntityListTargetResponse_0;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeMethodInfoPtr__ToString_b__23_2_Private_String_EntityID_0;

		// Token: 0x0200064D RID: 1613
		[ObfuscatedName("worm.canis.ai.choices.WormAIChoiceSelectionWithTargets+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060051EA RID: 20970 RVA: 0x001AEE28 File Offset: 0x001AD028
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets.__c>.NativeClassPtr);
				WormAIChoiceSelectionWithTargets.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets.__c>.NativeClassPtr, "<>9");
				WormAIChoiceSelectionWithTargets.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets.__c>.NativeClassPtr, "<>9__21_0");
				WormAIChoiceSelectionWithTargets.__c.NativeFieldInfoPtr___9__23_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets.__c>.NativeClassPtr, "<>9__23_1");
				WormAIChoiceSelectionWithTargets.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets.__c>.NativeClassPtr, 100667374);
				WormAIChoiceSelectionWithTargets.__c.NativeMethodInfoPtr__GetResponse_b__21_0_Internal_EntityID_KeyValuePair_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets.__c>.NativeClassPtr, 100667375);
				WormAIChoiceSelectionWithTargets.__c.NativeMethodInfoPtr__ToString_b__23_1_Internal_String_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets.__c>.NativeClassPtr, 100667376);
			}

			// Token: 0x060051EB RID: 20971 RVA: 0x001AEECC File Offset: 0x001AD0CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAIChoiceSelectionWithTargets.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051EC RID: 20972 RVA: 0x001AEF08 File Offset: 0x001AD108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129659, XrefRangeEnd = 129660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityID _GetResponse_b__21_0(KeyValuePair<EntityID, Il2CppReferenceArray<TargetInformation>> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.__c.NativeMethodInfoPtr__GetResponse_b__21_0_Internal_EntityID_KeyValuePair_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060051ED RID: 20973 RVA: 0x001AEF60 File Offset: 0x001AD160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129660, XrefRangeEnd = 129671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__23_1(IEnumerable<string> tl)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tl);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceSelectionWithTargets.__c.NativeMethodInfoPtr__ToString_b__23_1_Internal_String_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060051EE RID: 20974 RVA: 0x0001C781 File Offset: 0x0001A981
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700143C RID: 5180
			// (get) Token: 0x060051EF RID: 20975 RVA: 0x001AEFA8 File Offset: 0x001AD1A8
			// (set) Token: 0x060051F0 RID: 20976 RVA: 0x0001C78A File Offset: 0x0001A98A
			public unsafe static WormAIChoiceSelectionWithTargets.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIChoiceSelectionWithTargets.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIChoiceSelectionWithTargets.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIChoiceSelectionWithTargets.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700143D RID: 5181
			// (get) Token: 0x060051F1 RID: 20977 RVA: 0x001AEFD0 File Offset: 0x001AD1D0
			// (set) Token: 0x060051F2 RID: 20978 RVA: 0x0001C79C File Offset: 0x0001A99C
			public unsafe static Func<KeyValuePair<EntityID, Il2CppReferenceArray<TargetInformation>>, EntityID> __9__21_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIChoiceSelectionWithTargets.__c.NativeFieldInfoPtr___9__21_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<EntityID, Il2CppReferenceArray<TargetInformation>>, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIChoiceSelectionWithTargets.__c.NativeFieldInfoPtr___9__21_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700143E RID: 5182
			// (get) Token: 0x060051F3 RID: 20979 RVA: 0x001AEFF8 File Offset: 0x001AD1F8
			// (set) Token: 0x060051F4 RID: 20980 RVA: 0x0001C7AE File Offset: 0x0001A9AE
			public unsafe static Func<IEnumerable<string>, string> __9__23_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIChoiceSelectionWithTargets.__c.NativeFieldInfoPtr___9__23_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<string>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIChoiceSelectionWithTargets.__c.NativeFieldInfoPtr___9__23_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040035AF RID: 13743
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040035B0 RID: 13744
			private static readonly IntPtr NativeFieldInfoPtr___9__21_0;

			// Token: 0x040035B1 RID: 13745
			private static readonly IntPtr NativeFieldInfoPtr___9__23_1;

			// Token: 0x040035B2 RID: 13746
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040035B3 RID: 13747
			private static readonly IntPtr NativeMethodInfoPtr__GetResponse_b__21_0_Internal_EntityID_KeyValuePair_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0;

			// Token: 0x040035B4 RID: 13748
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__23_1_Internal_String_IEnumerable_1_String_0;
		}
	}
}
