using System;
using Canis.actions;
using Canis.actions.responseparsers;
using Canis.attributes;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection;
using Networking.selection.targetinformation;

namespace Canis.context.targetpickers
{
	// Token: 0x02000122 RID: 290
	public class SelectedFrom : TargetPicker<Entity>
	{
		// Token: 0x06000D5A RID: 3418 RVA: 0x00052888 File Offset: 0x00050A88
		// Note: this type is marked as 'beforefieldinit'.
		static SelectedFrom()
		{
			Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.targetpickers", "SelectedFrom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr);
			SelectedFrom.NativeFieldInfoPtr_propertiesPhrases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, "propertiesPhrases");
			SelectedFrom.NativeFieldInfoPtr_hintTargetMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, "hintTargetMap");
			SelectedFrom.NativeFieldInfoPtr_targetInfoAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, "targetInfoAttributes");
			SelectedFrom.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, "entities");
			SelectedFrom.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, "max");
			SelectedFrom.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, "min");
			SelectedFrom.NativeFieldInfoPtr_autoSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, "autoSelect");
			SelectedFrom.NativeFieldInfoPtr_autoForceOuter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, "autoForceOuter");
			SelectedFrom.NativeFieldInfoPtr_targetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, "targetEntity");
			SelectedFrom.NativeFieldInfoPtr_sendSelectionFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, "sendSelectionFinished");
			SelectedFrom.NativeFieldInfoPtr_fromReveal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, "fromReveal");
			SelectedFrom.NativeFieldInfoPtr__Forced_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, "<Forced>k__BackingField");
			SelectedFrom.NativeFieldInfoPtr__SelectionSource_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, "<SelectionSource>k__BackingField");
			SelectedFrom.NativeMethodInfoPtr_get_Forced_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, 100666291);
			SelectedFrom.NativeMethodInfoPtr_set_Forced_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, 100666292);
			SelectedFrom.NativeMethodInfoPtr_get_SelectionSource_Public_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, 100666293);
			SelectedFrom.NativeMethodInfoPtr_set_SelectionSource_Protected_set_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, 100666294);
			SelectedFrom.NativeMethodInfoPtr__ctor_Public_Void_Entity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, 100666295);
			SelectedFrom.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Entity_Match_Boolean_Int32_Int32_Boolean_Entity_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, 100666296);
			SelectedFrom.NativeMethodInfoPtr_WithSource_Public_SelectedFrom_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, 100666297);
			SelectedFrom.NativeMethodInfoPtr_WithTargetHighlights_Public_SelectedFrom_Dictionary_2_TargetStrength_Il2CppReferenceArray_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, 100666298);
			SelectedFrom.NativeMethodInfoPtr_WithTargetInfoAttributes_Public_SelectedFrom_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, 100666299);
			SelectedFrom.NativeMethodInfoPtr_With_Public_SelectedFrom_Func_2_Context_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, 100666300);
			SelectedFrom.NativeMethodInfoPtr_WithAutoSelect_Public_SelectedFrom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, 100666301);
			SelectedFrom.NativeMethodInfoPtr_FromReveal_Public_SelectedFrom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, 100666302);
			SelectedFrom.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, 100666303);
			SelectedFrom.NativeMethodInfoPtr_GetTargetMap_Public_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, 100666304);
			SelectedFrom.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, 100666305);
			SelectedFrom.NativeMethodInfoPtr__GetTargetMap_b__29_0_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, 100666306);
			SelectedFrom.NativeMethodInfoPtr__PickTargets_b__30_0_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, 100666307);
			SelectedFrom.NativeMethodInfoPtr__PickTargets_b__30_2_Private_Entity_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, 100666308);
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x00052B24 File Offset: 0x00050D24
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x00052B60 File Offset: 0x00050D60
		public unsafe bool Forced
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.NativeMethodInfoPtr_get_Forced_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.NativeMethodInfoPtr_set_Forced_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x00052BA0 File Offset: 0x00050DA0
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x00052BE0 File Offset: 0x00050DE0
		public unsafe EntityID SelectionSource
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.NativeMethodInfoPtr_get_SelectionSource_Public_get_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.NativeMethodInfoPtr_set_SelectionSource_Protected_set_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00052C24 File Offset: 0x00050E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576422, XrefRangeEnd = 576437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedFrom(Entity pile, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.NativeMethodInfoPtr__ctor_Public_Void_Entity_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00052C84 File Offset: 0x00050E84
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 576452, RefRangeEnd = 576461, XrefRangeStart = 576437, XrefRangeEnd = 576452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedFrom(IEnumerable<Entity> entities, Match m, bool forced = true, int max = 1, int min = -1, bool autoForceOuter = false, Entity targetEntity = null, bool sendSelectionFinished = false, bool waitForResponse = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entities);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoForceOuter;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetEntity);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendSelectionFinished;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitForResponse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Entity_Match_Boolean_Int32_Int32_Boolean_Entity_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00052D4C File Offset: 0x00050F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576461, XrefRangeEnd = 576462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedFrom WithSource(EntityID eid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.NativeMethodInfoPtr_WithSource_Public_SelectedFrom_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectedFrom>(intPtr3) : null;
			}
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00052D9C File Offset: 0x00050F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedFrom WithTargetHighlights(Dictionary<TargetStrength, Il2CppReferenceArray<EntityID>> hintTargetMap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hintTargetMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.NativeMethodInfoPtr_WithTargetHighlights_Public_SelectedFrom_Dictionary_2_TargetStrength_Il2CppReferenceArray_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectedFrom>(intPtr3) : null;
			}
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00052DEC File Offset: 0x00050FEC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 575803, RefRangeEnd = 575811, XrefRangeStart = 575803, XrefRangeEnd = 575811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedFrom WithTargetInfoAttributes(ReadOnlyAttributes attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.NativeMethodInfoPtr_WithTargetInfoAttributes_Public_SelectedFrom_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectedFrom>(intPtr3) : null;
			}
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00052E3C File Offset: 0x0005103C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576462, XrefRangeEnd = 576465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedFrom With(Func<Context, bool> propertiesPhrase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertiesPhrase);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.NativeMethodInfoPtr_With_Public_SelectedFrom_Func_2_Context_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectedFrom>(intPtr3) : null;
			}
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00052E8C File Offset: 0x0005108C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 576465, RefRangeEnd = 576467, XrefRangeStart = 576465, XrefRangeEnd = 576465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedFrom WithAutoSelect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.NativeMethodInfoPtr_WithAutoSelect_Public_SelectedFrom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectedFrom>(intPtr3) : null;
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00052ECC File Offset: 0x000510CC
		[CallerCount(0)]
		public unsafe SelectedFrom FromReveal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.NativeMethodInfoPtr_FromReveal_Public_SelectedFrom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectedFrom>(intPtr3) : null;
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x00052F0C File Offset: 0x0005110C
		public unsafe override ResponseParser<Entity> responseParser
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576467, XrefRangeEnd = 576471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectedFrom.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResponseParser<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00052F58 File Offset: 0x00051158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576471, XrefRangeEnd = 576575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>> GetTargetMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.NativeMethodInfoPtr_GetTargetMap_Public_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>>>(intPtr3) : null;
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00052F98 File Offset: 0x00051198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576575, XrefRangeEnd = 576628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SelectionRequest PickTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectedFrom.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionRequest>(intPtr3) : null;
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00052FE4 File Offset: 0x000511E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576628, XrefRangeEnd = 576644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetTargetMap_b__29_0(Entity _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.NativeMethodInfoPtr__GetTargetMap_b__29_0_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00053034 File Offset: 0x00051234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576644, XrefRangeEnd = 576660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PickTargets_b__30_0(Entity _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.NativeMethodInfoPtr__PickTargets_b__30_0_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00053084 File Offset: 0x00051284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576660, XrefRangeEnd = 576664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity _PickTargets_b__30_2(EntityID _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.NativeMethodInfoPtr__PickTargets_b__30_2_Private_Entity_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00006CC4 File Offset: 0x00004EC4
		public SelectedFrom(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x000530D4 File Offset: 0x000512D4
		// (set) Token: 0x06000D6F RID: 3439 RVA: 0x00006CCD File Offset: 0x00004ECD
		public unsafe List<Func<Context, bool>> propertiesPhrases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_propertiesPhrases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Func<Context, bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_propertiesPhrases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x00053104 File Offset: 0x00051304
		// (set) Token: 0x06000D71 RID: 3441 RVA: 0x00006CEC File Offset: 0x00004EEC
		public unsafe Dictionary<TargetStrength, Il2CppReferenceArray<EntityID>> hintTargetMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_hintTargetMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TargetStrength, Il2CppReferenceArray<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_hintTargetMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x00053134 File Offset: 0x00051334
		// (set) Token: 0x06000D73 RID: 3443 RVA: 0x00006D0B File Offset: 0x00004F0B
		public unsafe ReadOnlyAttributes targetInfoAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_targetInfoAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_targetInfoAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000D74 RID: 3444 RVA: 0x00053164 File Offset: 0x00051364
		// (set) Token: 0x06000D75 RID: 3445 RVA: 0x00006D2A File Offset: 0x00004F2A
		public unsafe List<Entity> entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x00053194 File Offset: 0x00051394
		// (set) Token: 0x06000D77 RID: 3447 RVA: 0x00006D49 File Offset: 0x00004F49
		public unsafe int max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x000531BC File Offset: 0x000513BC
		// (set) Token: 0x06000D79 RID: 3449 RVA: 0x00006D64 File Offset: 0x00004F64
		public unsafe int min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x000531E4 File Offset: 0x000513E4
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x00006D7F File Offset: 0x00004F7F
		public unsafe bool autoSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_autoSelect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_autoSelect)) = value;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x0005320C File Offset: 0x0005140C
		// (set) Token: 0x06000D7D RID: 3453 RVA: 0x00006D9A File Offset: 0x00004F9A
		public unsafe bool autoForceOuter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_autoForceOuter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_autoForceOuter)) = value;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x00053234 File Offset: 0x00051434
		// (set) Token: 0x06000D7F RID: 3455 RVA: 0x00006DB5 File Offset: 0x00004FB5
		public unsafe Entity targetEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_targetEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_targetEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x00053264 File Offset: 0x00051464
		// (set) Token: 0x06000D81 RID: 3457 RVA: 0x00006DD4 File Offset: 0x00004FD4
		public unsafe bool sendSelectionFinished
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_sendSelectionFinished);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_sendSelectionFinished)) = value;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x0005328C File Offset: 0x0005148C
		// (set) Token: 0x06000D83 RID: 3459 RVA: 0x00006DEF File Offset: 0x00004FEF
		public unsafe bool fromReveal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_fromReveal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr_fromReveal)) = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x000532B4 File Offset: 0x000514B4
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x00006E0A File Offset: 0x0000500A
		public unsafe bool _Forced_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr__Forced_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr__Forced_k__BackingField)) = value;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x000532DC File Offset: 0x000514DC
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x00006E25 File Offset: 0x00005025
		public unsafe EntityID _SelectionSource_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr__SelectionSource_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.NativeFieldInfoPtr__SelectionSource_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeFieldInfoPtr_propertiesPhrases;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeFieldInfoPtr_hintTargetMap;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeFieldInfoPtr_targetInfoAttributes;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeFieldInfoPtr_autoSelect;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeFieldInfoPtr_autoForceOuter;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeFieldInfoPtr_targetEntity;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeFieldInfoPtr_sendSelectionFinished;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeFieldInfoPtr_fromReveal;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeFieldInfoPtr__Forced_k__BackingField;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeFieldInfoPtr__SelectionSource_k__BackingField;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeMethodInfoPtr_get_Forced_Public_get_Boolean_0;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeMethodInfoPtr_set_Forced_Protected_set_Void_Boolean_0;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectionSource_Public_get_EntityID_0;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectionSource_Protected_set_Void_EntityID_0;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Match_0;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Entity_Match_Boolean_Int32_Int32_Boolean_Entity_Boolean_Boolean_0;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeMethodInfoPtr_WithSource_Public_SelectedFrom_EntityID_0;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeMethodInfoPtr_WithTargetHighlights_Public_SelectedFrom_Dictionary_2_TargetStrength_Il2CppReferenceArray_1_EntityID_0;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeMethodInfoPtr_WithTargetInfoAttributes_Public_SelectedFrom_ReadOnlyAttributes_0;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeMethodInfoPtr_With_Public_SelectedFrom_Func_2_Context_Boolean_0;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeMethodInfoPtr_WithAutoSelect_Public_SelectedFrom_0;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeMethodInfoPtr_FromReveal_Public_SelectedFrom_0;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Entity_0;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetMap_Public_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeMethodInfoPtr__GetTargetMap_b__29_0_Private_Boolean_Entity_0;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeMethodInfoPtr__PickTargets_b__30_0_Private_Boolean_Entity_0;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeMethodInfoPtr__PickTargets_b__30_2_Private_Entity_EntityID_0;

		// Token: 0x02000386 RID: 902
		[ObfuscatedName("Canis.context.targetpickers.SelectedFrom+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060025B2 RID: 9650 RVA: 0x000A6DC0 File Offset: 0x000A4FC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SelectedFrom.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedFrom.__c>.NativeClassPtr);
				SelectedFrom.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom.__c>.NativeClassPtr, "<>9");
				SelectedFrom.__c.NativeFieldInfoPtr___9__29_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom.__c>.NativeClassPtr, "<>9__29_1");
				SelectedFrom.__c.NativeFieldInfoPtr___9__29_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom.__c>.NativeClassPtr, "<>9__29_3");
				SelectedFrom.__c.NativeFieldInfoPtr___9__29_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom.__c>.NativeClassPtr, "<>9__29_4");
				SelectedFrom.__c.NativeFieldInfoPtr___9__30_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom.__c>.NativeClassPtr, "<>9__30_1");
				SelectedFrom.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom.__c>.NativeClassPtr, 100666310);
				SelectedFrom.__c.NativeMethodInfoPtr__GetTargetMap_b__29_1_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom.__c>.NativeClassPtr, 100666311);
				SelectedFrom.__c.NativeMethodInfoPtr__GetTargetMap_b__29_3_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom.__c>.NativeClassPtr, 100666312);
				SelectedFrom.__c.NativeMethodInfoPtr__GetTargetMap_b__29_4_Internal_ReadOnlyAttributes_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom.__c>.NativeClassPtr, 100666313);
				SelectedFrom.__c.NativeMethodInfoPtr__PickTargets_b__30_1_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom.__c>.NativeClassPtr, 100666314);
			}

			// Token: 0x060025B3 RID: 9651 RVA: 0x000A6EB4 File Offset: 0x000A50B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedFrom.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025B4 RID: 9652 RVA: 0x000A6EF0 File Offset: 0x000A50F0
			[CallerCount(0)]
			public unsafe EntityID _GetTargetMap_b__29_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.__c.NativeMethodInfoPtr__GetTargetMap_b__29_1_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060025B5 RID: 9653 RVA: 0x000A6F40 File Offset: 0x000A5140
			[CallerCount(0)]
			public unsafe EntityID _GetTargetMap_b__29_3(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.__c.NativeMethodInfoPtr__GetTargetMap_b__29_3_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060025B6 RID: 9654 RVA: 0x000A6F90 File Offset: 0x000A5190
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576418, XrefRangeEnd = 576420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnlyAttributes _GetTargetMap_b__29_4(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.__c.NativeMethodInfoPtr__GetTargetMap_b__29_4_Internal_ReadOnlyAttributes_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
				}
			}

			// Token: 0x060025B7 RID: 9655 RVA: 0x000A6FE0 File Offset: 0x000A51E0
			[CallerCount(0)]
			public unsafe EntityID _PickTargets_b__30_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.__c.NativeMethodInfoPtr__PickTargets_b__30_1_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060025B8 RID: 9656 RVA: 0x00011FD8 File Offset: 0x000101D8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000944 RID: 2372
			// (get) Token: 0x060025B9 RID: 9657 RVA: 0x000A7030 File Offset: 0x000A5230
			// (set) Token: 0x060025BA RID: 9658 RVA: 0x00011FE1 File Offset: 0x000101E1
			public unsafe static SelectedFrom.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectedFrom.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectedFrom.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectedFrom.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000945 RID: 2373
			// (get) Token: 0x060025BB RID: 9659 RVA: 0x000A7058 File Offset: 0x000A5258
			// (set) Token: 0x060025BC RID: 9660 RVA: 0x00011FF3 File Offset: 0x000101F3
			public unsafe static Func<Entity, EntityID> __9__29_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectedFrom.__c.NativeFieldInfoPtr___9__29_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectedFrom.__c.NativeFieldInfoPtr___9__29_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000946 RID: 2374
			// (get) Token: 0x060025BD RID: 9661 RVA: 0x000A7080 File Offset: 0x000A5280
			// (set) Token: 0x060025BE RID: 9662 RVA: 0x00012005 File Offset: 0x00010205
			public unsafe static Func<Entity, EntityID> __9__29_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectedFrom.__c.NativeFieldInfoPtr___9__29_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectedFrom.__c.NativeFieldInfoPtr___9__29_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000947 RID: 2375
			// (get) Token: 0x060025BF RID: 9663 RVA: 0x000A70A8 File Offset: 0x000A52A8
			// (set) Token: 0x060025C0 RID: 9664 RVA: 0x00012017 File Offset: 0x00010217
			public unsafe static Func<Entity, ReadOnlyAttributes> __9__29_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectedFrom.__c.NativeFieldInfoPtr___9__29_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, ReadOnlyAttributes>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectedFrom.__c.NativeFieldInfoPtr___9__29_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000948 RID: 2376
			// (get) Token: 0x060025C1 RID: 9665 RVA: 0x000A70D0 File Offset: 0x000A52D0
			// (set) Token: 0x060025C2 RID: 9666 RVA: 0x00012029 File Offset: 0x00010229
			public unsafe static Func<Entity, EntityID> __9__30_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectedFrom.__c.NativeFieldInfoPtr___9__30_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectedFrom.__c.NativeFieldInfoPtr___9__30_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400178F RID: 6031
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001790 RID: 6032
			private static readonly IntPtr NativeFieldInfoPtr___9__29_1;

			// Token: 0x04001791 RID: 6033
			private static readonly IntPtr NativeFieldInfoPtr___9__29_3;

			// Token: 0x04001792 RID: 6034
			private static readonly IntPtr NativeFieldInfoPtr___9__29_4;

			// Token: 0x04001793 RID: 6035
			private static readonly IntPtr NativeFieldInfoPtr___9__30_1;

			// Token: 0x04001794 RID: 6036
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001795 RID: 6037
			private static readonly IntPtr NativeMethodInfoPtr__GetTargetMap_b__29_1_Internal_EntityID_Entity_0;

			// Token: 0x04001796 RID: 6038
			private static readonly IntPtr NativeMethodInfoPtr__GetTargetMap_b__29_3_Internal_EntityID_Entity_0;

			// Token: 0x04001797 RID: 6039
			private static readonly IntPtr NativeMethodInfoPtr__GetTargetMap_b__29_4_Internal_ReadOnlyAttributes_Entity_0;

			// Token: 0x04001798 RID: 6040
			private static readonly IntPtr NativeMethodInfoPtr__PickTargets_b__30_1_Internal_EntityID_Entity_0;
		}

		// Token: 0x02000387 RID: 903
		[ObfuscatedName("Canis.context.targetpickers.SelectedFrom+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Object
		{
			// Token: 0x060025C3 RID: 9667 RVA: 0x000A70F8 File Offset: 0x000A52F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<SelectedFrom.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedFrom.__c__DisplayClass29_0>.NativeClassPtr);
				SelectedFrom.__c__DisplayClass29_0.NativeFieldInfoPtr__ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom.__c__DisplayClass29_0>.NativeClassPtr, "_");
				SelectedFrom.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom.__c__DisplayClass29_0>.NativeClassPtr, "<>4__this");
				SelectedFrom.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom.__c__DisplayClass29_0>.NativeClassPtr, 100666315);
				SelectedFrom.__c__DisplayClass29_0.NativeMethodInfoPtr__GetTargetMap_b__2_Internal_Boolean_Func_2_Context_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom.__c__DisplayClass29_0>.NativeClassPtr, 100666316);
			}

			// Token: 0x060025C4 RID: 9668 RVA: 0x000A7174 File Offset: 0x000A5374
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedFrom.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025C5 RID: 9669 RVA: 0x000A71B0 File Offset: 0x000A53B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576420, XrefRangeEnd = 576422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetTargetMap_b__2(Func<Context, bool> allow)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(allow);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.__c__DisplayClass29_0.NativeMethodInfoPtr__GetTargetMap_b__2_Internal_Boolean_Func_2_Context_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060025C6 RID: 9670 RVA: 0x0001203B File Offset: 0x0001023B
			public __c__DisplayClass29_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000949 RID: 2377
			// (get) Token: 0x060025C7 RID: 9671 RVA: 0x000A7200 File Offset: 0x000A5400
			// (set) Token: 0x060025C8 RID: 9672 RVA: 0x00012044 File Offset: 0x00010244
			public unsafe Entity _
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.__c__DisplayClass29_0.NativeFieldInfoPtr__);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.__c__DisplayClass29_0.NativeFieldInfoPtr__), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700094A RID: 2378
			// (get) Token: 0x060025C9 RID: 9673 RVA: 0x000A7230 File Offset: 0x000A5430
			// (set) Token: 0x060025CA RID: 9674 RVA: 0x00012063 File Offset: 0x00010263
			public unsafe SelectedFrom __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectedFrom>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001799 RID: 6041
			private static readonly IntPtr NativeFieldInfoPtr__;

			// Token: 0x0400179A RID: 6042
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400179B RID: 6043
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400179C RID: 6044
			private static readonly IntPtr NativeMethodInfoPtr__GetTargetMap_b__2_Internal_Boolean_Func_2_Context_Boolean_0;
		}

		// Token: 0x02000388 RID: 904
		[ObfuscatedName("Canis.context.targetpickers.SelectedFrom+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Object
		{
			// Token: 0x060025CB RID: 9675 RVA: 0x000A7260 File Offset: 0x000A5460
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<SelectedFrom.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectedFrom>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedFrom.__c__DisplayClass30_0>.NativeClassPtr);
				SelectedFrom.__c__DisplayClass30_0.NativeFieldInfoPtr__ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom.__c__DisplayClass30_0>.NativeClassPtr, "_");
				SelectedFrom.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedFrom.__c__DisplayClass30_0>.NativeClassPtr, "<>4__this");
				SelectedFrom.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom.__c__DisplayClass30_0>.NativeClassPtr, 100666317);
				SelectedFrom.__c__DisplayClass30_0.NativeMethodInfoPtr__PickTargets_b__3_Internal_Boolean_Func_2_Context_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedFrom.__c__DisplayClass30_0>.NativeClassPtr, 100666318);
			}

			// Token: 0x060025CC RID: 9676 RVA: 0x000A72DC File Offset: 0x000A54DC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedFrom.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025CD RID: 9677 RVA: 0x000A7318 File Offset: 0x000A5518
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PickTargets_b__3(Func<Context, bool> allow)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(allow);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedFrom.__c__DisplayClass30_0.NativeMethodInfoPtr__PickTargets_b__3_Internal_Boolean_Func_2_Context_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060025CE RID: 9678 RVA: 0x00012082 File Offset: 0x00010282
			public __c__DisplayClass30_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700094B RID: 2379
			// (get) Token: 0x060025CF RID: 9679 RVA: 0x000A7368 File Offset: 0x000A5568
			// (set) Token: 0x060025D0 RID: 9680 RVA: 0x0001208B File Offset: 0x0001028B
			public unsafe Entity _
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.__c__DisplayClass30_0.NativeFieldInfoPtr__);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.__c__DisplayClass30_0.NativeFieldInfoPtr__), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700094C RID: 2380
			// (get) Token: 0x060025D1 RID: 9681 RVA: 0x000A7398 File Offset: 0x000A5598
			// (set) Token: 0x060025D2 RID: 9682 RVA: 0x000120AA File Offset: 0x000102AA
			public unsafe SelectedFrom __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectedFrom>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedFrom.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400179D RID: 6045
			private static readonly IntPtr NativeFieldInfoPtr__;

			// Token: 0x0400179E RID: 6046
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400179F RID: 6047
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017A0 RID: 6048
			private static readonly IntPtr NativeMethodInfoPtr__PickTargets_b__3_Internal_Boolean_Func_2_Context_Boolean_0;
		}
	}
}
