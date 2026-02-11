using System;
using Canis.actions;
using Canis.actions.completions;
using Canis.actions.continuations;
using Canis.actions.responseparsers;
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

namespace Canis.context.targetpickers
{
	// Token: 0x0200011B RID: 283
	public class AllSelectTargetsFrom : TargetPicker<EntityIDTargetResponses>
	{
		// Token: 0x06000CD7 RID: 3287 RVA: 0x00050AA4 File Offset: 0x0004ECA4
		// Note: this type is marked as 'beforefieldinit'.
		static AllSelectTargetsFrom()
		{
			Il2CppClassPointerStore<AllSelectTargetsFrom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.targetpickers", "AllSelectTargetsFrom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllSelectTargetsFrom>.NativeClassPtr);
			AllSelectTargetsFrom.NativeFieldInfoPtr_allTargetMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllSelectTargetsFrom>.NativeClassPtr, "allTargetMaps");
			AllSelectTargetsFrom.NativeFieldInfoPtr_forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllSelectTargetsFrom>.NativeClassPtr, "forced");
			AllSelectTargetsFrom.NativeFieldInfoPtr_ignoreFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllSelectTargetsFrom>.NativeClassPtr, "ignoreFirst");
			AllSelectTargetsFrom.NativeFieldInfoPtr_selectionSourceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllSelectTargetsFrom>.NativeClassPtr, "selectionSourceID");
			AllSelectTargetsFrom.NativeFieldInfoPtr_generateContinuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllSelectTargetsFrom>.NativeClassPtr, "generateContinuation");
			AllSelectTargetsFrom.NativeFieldInfoPtr_generateCompletion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllSelectTargetsFrom>.NativeClassPtr, "generateCompletion");
			AllSelectTargetsFrom.NativeMethodInfoPtr_WithSource_Public_AllSelectTargetsFrom_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllSelectTargetsFrom>.NativeClassPtr, 100666232);
			AllSelectTargetsFrom.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_AccountID_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllSelectTargetsFrom>.NativeClassPtr, 100666233);
			AllSelectTargetsFrom.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_AccountID_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_Boolean_Boolean_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllSelectTargetsFrom>.NativeClassPtr, 100666234);
			AllSelectTargetsFrom.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_EntityIDTargetResponses_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllSelectTargetsFrom>.NativeClassPtr, 100666235);
			AllSelectTargetsFrom.NativeMethodInfoPtr_MakeContinuation_Protected_Virtual_ActionContinuation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllSelectTargetsFrom>.NativeClassPtr, 100666236);
			AllSelectTargetsFrom.NativeMethodInfoPtr_MakeCompletion_Protected_Virtual_SelectionCompletion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllSelectTargetsFrom>.NativeClassPtr, 100666237);
			AllSelectTargetsFrom.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllSelectTargetsFrom>.NativeClassPtr, 100666238);
			AllSelectTargetsFrom.NativeMethodInfoPtr_WithContinuation_Public_AllSelectTargetsFrom_Func_1_ActionContinuation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllSelectTargetsFrom>.NativeClassPtr, 100666239);
			AllSelectTargetsFrom.NativeMethodInfoPtr_WithCompletion_Public_AllSelectTargetsFrom_Func_1_SelectionCompletion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllSelectTargetsFrom>.NativeClassPtr, 100666240);
			AllSelectTargetsFrom.NativeMethodInfoPtr__MakeContinuation_b__11_0_Private_PlayerEntity_KeyValuePair_2_AccountID_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllSelectTargetsFrom>.NativeClassPtr, 100666241);
			AllSelectTargetsFrom.NativeMethodInfoPtr__PickTargets_b__13_0_Private_SelectionMessage_KeyValuePair_2_AccountID_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllSelectTargetsFrom>.NativeClassPtr, 100666242);
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00050C28 File Offset: 0x0004EE28
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 575803, RefRangeEnd = 575811, XrefRangeStart = 575802, XrefRangeEnd = 575803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AllSelectTargetsFrom WithSource(EntityID eid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllSelectTargetsFrom.NativeMethodInfoPtr_WithSource_Public_AllSelectTargetsFrom_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AllSelectTargetsFrom>(intPtr3) : null;
			}
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00050C78 File Offset: 0x0004EE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575811, XrefRangeEnd = 575816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AllSelectTargetsFrom(Dictionary<AccountID, Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>>> allTargetMaps, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllSelectTargetsFrom>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allTargetMaps);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllSelectTargetsFrom.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_AccountID_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00050CD8 File Offset: 0x0004EED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575816, XrefRangeEnd = 575821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AllSelectTargetsFrom(Dictionary<AccountID, Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>>> allTargetMaps, bool forced, bool ignoreFirst, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllSelectTargetsFrom>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allTargetMaps);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreFirst;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllSelectTargetsFrom.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_AccountID_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_Boolean_Boolean_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x00050D54 File Offset: 0x0004EF54
		public unsafe override ResponseParser<EntityIDTargetResponses> responseParser
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575821, XrefRangeEnd = 575825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AllSelectTargetsFrom.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_EntityIDTargetResponses_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResponseParser<EntityIDTargetResponses>>(intPtr3) : null;
			}
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00050DA0 File Offset: 0x0004EFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575825, XrefRangeEnd = 575836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ActionContinuation MakeContinuation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AllSelectTargetsFrom.NativeMethodInfoPtr_MakeContinuation_Protected_Virtual_ActionContinuation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionContinuation>(intPtr3) : null;
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00050DEC File Offset: 0x0004EFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575836, XrefRangeEnd = 575840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SelectionCompletion MakeCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AllSelectTargetsFrom.NativeMethodInfoPtr_MakeCompletion_Protected_Virtual_SelectionCompletion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionCompletion>(intPtr3) : null;
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00050E38 File Offset: 0x0004F038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575840, XrefRangeEnd = 575863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SelectionRequest PickTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AllSelectTargetsFrom.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionRequest>(intPtr3) : null;
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00050E84 File Offset: 0x0004F084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575863, XrefRangeEnd = 575864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AllSelectTargetsFrom WithContinuation(Func<ActionContinuation> generateContinuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(generateContinuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllSelectTargetsFrom.NativeMethodInfoPtr_WithContinuation_Public_AllSelectTargetsFrom_Func_1_ActionContinuation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AllSelectTargetsFrom>(intPtr3) : null;
			}
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00050ED4 File Offset: 0x0004F0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575864, XrefRangeEnd = 575865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AllSelectTargetsFrom WithCompletion(Func<SelectionCompletion> generateCompletion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(generateCompletion);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllSelectTargetsFrom.NativeMethodInfoPtr_WithCompletion_Public_AllSelectTargetsFrom_Func_1_SelectionCompletion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AllSelectTargetsFrom>(intPtr3) : null;
			}
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00050F24 File Offset: 0x0004F124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575865, XrefRangeEnd = 575867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerEntity _MakeContinuation_b__11_0(KeyValuePair<AccountID, Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>>> pair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllSelectTargetsFrom.NativeMethodInfoPtr__MakeContinuation_b__11_0_Private_PlayerEntity_KeyValuePair_2_AccountID_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
			}
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00050F7C File Offset: 0x0004F17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575867, XrefRangeEnd = 575884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionMessage _PickTargets_b__13_0(KeyValuePair<AccountID, Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>>> pair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllSelectTargetsFrom.NativeMethodInfoPtr__PickTargets_b__13_0_Private_SelectionMessage_KeyValuePair_2_AccountID_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x0000685E File Offset: 0x00004A5E
		public AllSelectTargetsFrom(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x00050FD4 File Offset: 0x0004F1D4
		// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x00006867 File Offset: 0x00004A67
		public unsafe Dictionary<AccountID, Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>>> allTargetMaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllSelectTargetsFrom.NativeFieldInfoPtr_allTargetMaps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllSelectTargetsFrom.NativeFieldInfoPtr_allTargetMaps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00051004 File Offset: 0x0004F204
		// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x00006886 File Offset: 0x00004A86
		public unsafe bool forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllSelectTargetsFrom.NativeFieldInfoPtr_forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllSelectTargetsFrom.NativeFieldInfoPtr_forced)) = value;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x0005102C File Offset: 0x0004F22C
		// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x000068A1 File Offset: 0x00004AA1
		public unsafe bool ignoreFirst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllSelectTargetsFrom.NativeFieldInfoPtr_ignoreFirst);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllSelectTargetsFrom.NativeFieldInfoPtr_ignoreFirst)) = value;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x00051054 File Offset: 0x0004F254
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x000068BC File Offset: 0x00004ABC
		public unsafe EntityID selectionSourceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllSelectTargetsFrom.NativeFieldInfoPtr_selectionSourceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllSelectTargetsFrom.NativeFieldInfoPtr_selectionSourceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x00051084 File Offset: 0x0004F284
		// (set) Token: 0x06000CED RID: 3309 RVA: 0x000068DB File Offset: 0x00004ADB
		public unsafe Func<ActionContinuation> generateContinuation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllSelectTargetsFrom.NativeFieldInfoPtr_generateContinuation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ActionContinuation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllSelectTargetsFrom.NativeFieldInfoPtr_generateContinuation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x000510B4 File Offset: 0x0004F2B4
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x000068FA File Offset: 0x00004AFA
		public unsafe Func<SelectionCompletion> generateCompletion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllSelectTargetsFrom.NativeFieldInfoPtr_generateCompletion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SelectionCompletion>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllSelectTargetsFrom.NativeFieldInfoPtr_generateCompletion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeFieldInfoPtr_allTargetMaps;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeFieldInfoPtr_forced;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeFieldInfoPtr_ignoreFirst;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeFieldInfoPtr_selectionSourceID;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeFieldInfoPtr_generateContinuation;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeFieldInfoPtr_generateCompletion;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeMethodInfoPtr_WithSource_Public_AllSelectTargetsFrom_EntityID_0;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_AccountID_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_Match_0;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_AccountID_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_Boolean_Boolean_Match_0;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_EntityIDTargetResponses_0;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeMethodInfoPtr_MakeContinuation_Protected_Virtual_ActionContinuation_0;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeMethodInfoPtr_MakeCompletion_Protected_Virtual_SelectionCompletion_0;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeMethodInfoPtr_WithContinuation_Public_AllSelectTargetsFrom_Func_1_ActionContinuation_0;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeMethodInfoPtr_WithCompletion_Public_AllSelectTargetsFrom_Func_1_SelectionCompletion_0;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeMethodInfoPtr__MakeContinuation_b__11_0_Private_PlayerEntity_KeyValuePair_2_AccountID_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeMethodInfoPtr__PickTargets_b__13_0_Private_SelectionMessage_KeyValuePair_2_AccountID_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0;
	}
}
