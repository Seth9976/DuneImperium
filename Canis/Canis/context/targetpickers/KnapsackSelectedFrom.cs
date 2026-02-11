using System;
using Canis.actions;
using Canis.actions.responseparsers;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetinformation;

namespace Canis.context.targetpickers
{
	// Token: 0x0200011F RID: 287
	public class KnapsackSelectedFrom : TargetPicker<Entity>
	{
		// Token: 0x06000D22 RID: 3362 RVA: 0x00051CCC File Offset: 0x0004FECC
		// Note: this type is marked as 'beforefieldinit'.
		static KnapsackSelectedFrom()
		{
			Il2CppClassPointerStore<KnapsackSelectedFrom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.targetpickers", "KnapsackSelectedFrom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnapsackSelectedFrom>.NativeClassPtr);
			KnapsackSelectedFrom.NativeFieldInfoPtr_propertiesPhrases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackSelectedFrom>.NativeClassPtr, "propertiesPhrases");
			KnapsackSelectedFrom.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackSelectedFrom>.NativeClassPtr, "entities");
			KnapsackSelectedFrom.NativeFieldInfoPtr_targetWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackSelectedFrom>.NativeClassPtr, "targetWeight");
			KnapsackSelectedFrom.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackSelectedFrom>.NativeClassPtr, "mode");
			KnapsackSelectedFrom.NativeFieldInfoPtr_forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackSelectedFrom>.NativeClassPtr, "forced");
			KnapsackSelectedFrom.NativeFieldInfoPtr_autoSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackSelectedFrom>.NativeClassPtr, "autoSelect");
			KnapsackSelectedFrom.NativeFieldInfoPtr_autoForceOuter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackSelectedFrom>.NativeClassPtr, "autoForceOuter");
			KnapsackSelectedFrom.NativeFieldInfoPtr_targetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackSelectedFrom>.NativeClassPtr, "targetEntity");
			KnapsackSelectedFrom.NativeFieldInfoPtr_sendSelectionFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackSelectedFrom>.NativeClassPtr, "sendSelectionFinished");
			KnapsackSelectedFrom.NativeFieldInfoPtr_selectionSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackSelectedFrom>.NativeClassPtr, "selectionSource");
			KnapsackSelectedFrom.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Entity_Int32_Match_Boolean_Int32_KnapsackSelectionMode_Boolean_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackSelectedFrom>.NativeClassPtr, 100666265);
			KnapsackSelectedFrom.NativeMethodInfoPtr_WithSource_Public_KnapsackSelectedFrom_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackSelectedFrom>.NativeClassPtr, 100666266);
			KnapsackSelectedFrom.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackSelectedFrom>.NativeClassPtr, 100666267);
			KnapsackSelectedFrom.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackSelectedFrom>.NativeClassPtr, 100666268);
			KnapsackSelectedFrom.NativeMethodInfoPtr__PickTargets_b__14_0_Private_Boolean_KeyValuePair_2_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackSelectedFrom>.NativeClassPtr, 100666269);
			KnapsackSelectedFrom.NativeMethodInfoPtr__PickTargets_b__14_5_Private_IEnumerable_1_Entity_KeyValuePair_2_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackSelectedFrom>.NativeClassPtr, 100666270);
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00051E3C File Offset: 0x0005003C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576139, XrefRangeEnd = 576151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KnapsackSelectedFrom(Dictionary<Entity, int> entities, Match m, bool forced = true, int targetWeight = 1, KnapsackSelectionMode mode = KnapsackSelectionMode.AsMuchAsPossibleButNoMoreThan, bool autoForceOuter = false, Entity targetEntity = null, bool sendSelectionFinished = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KnapsackSelectedFrom>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entities);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetWeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoForceOuter;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetEntity);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendSelectionFinished;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackSelectedFrom.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Entity_Int32_Match_Boolean_Int32_KnapsackSelectionMode_Boolean_Entity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00051EF4 File Offset: 0x000500F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576151, XrefRangeEnd = 576152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KnapsackSelectedFrom WithSource(EntityID eid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackSelectedFrom.NativeMethodInfoPtr_WithSource_Public_KnapsackSelectedFrom_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<KnapsackSelectedFrom>(intPtr3) : null;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x00051F44 File Offset: 0x00050144
		public unsafe override ResponseParser<Entity> responseParser
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576152, XrefRangeEnd = 576156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KnapsackSelectedFrom.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResponseParser<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00051F90 File Offset: 0x00050190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576156, XrefRangeEnd = 576257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SelectionRequest PickTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KnapsackSelectedFrom.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionRequest>(intPtr3) : null;
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00051FDC File Offset: 0x000501DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576257, XrefRangeEnd = 576273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PickTargets_b__14_0(KeyValuePair<Entity, int> _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackSelectedFrom.NativeMethodInfoPtr__PickTargets_b__14_0_Private_Boolean_KeyValuePair_2_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00052030 File Offset: 0x00050230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576273, XrefRangeEnd = 576284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> _PickTargets_b__14_5(KeyValuePair<EntityID, int> _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackSelectedFrom.NativeMethodInfoPtr__PickTargets_b__14_5_Private_IEnumerable_1_Entity_KeyValuePair_2_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00006AB6 File Offset: 0x00004CB6
		public KnapsackSelectedFrom(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x00052088 File Offset: 0x00050288
		// (set) Token: 0x06000D2B RID: 3371 RVA: 0x00006ABF File Offset: 0x00004CBF
		public unsafe List<Func<Context, bool>> propertiesPhrases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.NativeFieldInfoPtr_propertiesPhrases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Func<Context, bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.NativeFieldInfoPtr_propertiesPhrases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x000520B8 File Offset: 0x000502B8
		// (set) Token: 0x06000D2D RID: 3373 RVA: 0x00006ADE File Offset: 0x00004CDE
		public unsafe Dictionary<Entity, int> entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Entity, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x000520E8 File Offset: 0x000502E8
		// (set) Token: 0x06000D2F RID: 3375 RVA: 0x00006AFD File Offset: 0x00004CFD
		public unsafe int targetWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.NativeFieldInfoPtr_targetWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.NativeFieldInfoPtr_targetWeight)) = value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x00052110 File Offset: 0x00050310
		// (set) Token: 0x06000D31 RID: 3377 RVA: 0x00006B18 File Offset: 0x00004D18
		public unsafe KnapsackSelectionMode mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.NativeFieldInfoPtr_mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.NativeFieldInfoPtr_mode)) = value;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x00052138 File Offset: 0x00050338
		// (set) Token: 0x06000D33 RID: 3379 RVA: 0x00006B33 File Offset: 0x00004D33
		public unsafe bool forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.NativeFieldInfoPtr_forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.NativeFieldInfoPtr_forced)) = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x00052160 File Offset: 0x00050360
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x00006B4E File Offset: 0x00004D4E
		public unsafe bool autoSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.NativeFieldInfoPtr_autoSelect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.NativeFieldInfoPtr_autoSelect)) = value;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x00052188 File Offset: 0x00050388
		// (set) Token: 0x06000D37 RID: 3383 RVA: 0x00006B69 File Offset: 0x00004D69
		public unsafe bool autoForceOuter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.NativeFieldInfoPtr_autoForceOuter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.NativeFieldInfoPtr_autoForceOuter)) = value;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x000521B0 File Offset: 0x000503B0
		// (set) Token: 0x06000D39 RID: 3385 RVA: 0x00006B84 File Offset: 0x00004D84
		public unsafe Entity targetEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.NativeFieldInfoPtr_targetEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.NativeFieldInfoPtr_targetEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x000521E0 File Offset: 0x000503E0
		// (set) Token: 0x06000D3B RID: 3387 RVA: 0x00006BA3 File Offset: 0x00004DA3
		public unsafe bool sendSelectionFinished
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.NativeFieldInfoPtr_sendSelectionFinished);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.NativeFieldInfoPtr_sendSelectionFinished)) = value;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x00052208 File Offset: 0x00050408
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x00006BBE File Offset: 0x00004DBE
		public unsafe EntityID selectionSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.NativeFieldInfoPtr_selectionSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.NativeFieldInfoPtr_selectionSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeFieldInfoPtr_propertiesPhrases;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeFieldInfoPtr_targetWeight;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeFieldInfoPtr_forced;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeFieldInfoPtr_autoSelect;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeFieldInfoPtr_autoForceOuter;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeFieldInfoPtr_targetEntity;

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeFieldInfoPtr_sendSelectionFinished;

		// Token: 0x04000909 RID: 2313
		private static readonly IntPtr NativeFieldInfoPtr_selectionSource;

		// Token: 0x0400090A RID: 2314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Entity_Int32_Match_Boolean_Int32_KnapsackSelectionMode_Boolean_Entity_Boolean_0;

		// Token: 0x0400090B RID: 2315
		private static readonly IntPtr NativeMethodInfoPtr_WithSource_Public_KnapsackSelectedFrom_EntityID_0;

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Entity_0;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0;

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeMethodInfoPtr__PickTargets_b__14_0_Private_Boolean_KeyValuePair_2_Entity_Int32_0;

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeMethodInfoPtr__PickTargets_b__14_5_Private_IEnumerable_1_Entity_KeyValuePair_2_EntityID_Int32_0;

		// Token: 0x02000383 RID: 899
		[ObfuscatedName("Canis.context.targetpickers.KnapsackSelectedFrom+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002594 RID: 9620 RVA: 0x000A6858 File Offset: 0x000A4A58
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<KnapsackSelectedFrom.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KnapsackSelectedFrom>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnapsackSelectedFrom.__c>.NativeClassPtr);
				KnapsackSelectedFrom.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackSelectedFrom.__c>.NativeClassPtr, "<>9");
				KnapsackSelectedFrom.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackSelectedFrom.__c>.NativeClassPtr, "<>9__14_1");
				KnapsackSelectedFrom.__c.NativeFieldInfoPtr___9__14_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackSelectedFrom.__c>.NativeClassPtr, "<>9__14_2");
				KnapsackSelectedFrom.__c.NativeFieldInfoPtr___9__14_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackSelectedFrom.__c>.NativeClassPtr, "<>9__14_3");
				KnapsackSelectedFrom.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackSelectedFrom.__c>.NativeClassPtr, 100666272);
				KnapsackSelectedFrom.__c.NativeMethodInfoPtr__PickTargets_b__14_1_Internal_EntityID_KeyValuePair_2_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackSelectedFrom.__c>.NativeClassPtr, 100666273);
				KnapsackSelectedFrom.__c.NativeMethodInfoPtr__PickTargets_b__14_2_Internal_Int32_KeyValuePair_2_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackSelectedFrom.__c>.NativeClassPtr, 100666274);
				KnapsackSelectedFrom.__c.NativeMethodInfoPtr__PickTargets_b__14_3_Internal_Int32_KeyValuePair_2_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackSelectedFrom.__c>.NativeClassPtr, 100666275);
			}

			// Token: 0x06002595 RID: 9621 RVA: 0x000A6924 File Offset: 0x000A4B24
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KnapsackSelectedFrom.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackSelectedFrom.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002596 RID: 9622 RVA: 0x000A6960 File Offset: 0x000A4B60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576132, XrefRangeEnd = 576133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityID _PickTargets_b__14_1(KeyValuePair<Entity, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackSelectedFrom.__c.NativeMethodInfoPtr__PickTargets_b__14_1_Internal_EntityID_KeyValuePair_2_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06002597 RID: 9623 RVA: 0x000A69B8 File Offset: 0x000A4BB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576133, XrefRangeEnd = 576134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _PickTargets_b__14_2(KeyValuePair<Entity, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackSelectedFrom.__c.NativeMethodInfoPtr__PickTargets_b__14_2_Internal_Int32_KeyValuePair_2_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002598 RID: 9624 RVA: 0x000A6A0C File Offset: 0x000A4C0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576134, XrefRangeEnd = 576135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _PickTargets_b__14_3(KeyValuePair<EntityID, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackSelectedFrom.__c.NativeMethodInfoPtr__PickTargets_b__14_3_Internal_Int32_KeyValuePair_2_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002599 RID: 9625 RVA: 0x00011F04 File Offset: 0x00010104
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700093C RID: 2364
			// (get) Token: 0x0600259A RID: 9626 RVA: 0x000A6A60 File Offset: 0x000A4C60
			// (set) Token: 0x0600259B RID: 9627 RVA: 0x00011F0D File Offset: 0x0001010D
			public unsafe static KnapsackSelectedFrom.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KnapsackSelectedFrom.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KnapsackSelectedFrom.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KnapsackSelectedFrom.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700093D RID: 2365
			// (get) Token: 0x0600259C RID: 9628 RVA: 0x000A6A88 File Offset: 0x000A4C88
			// (set) Token: 0x0600259D RID: 9629 RVA: 0x00011F1F File Offset: 0x0001011F
			public unsafe static Func<KeyValuePair<Entity, int>, EntityID> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KnapsackSelectedFrom.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Entity, int>, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KnapsackSelectedFrom.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700093E RID: 2366
			// (get) Token: 0x0600259E RID: 9630 RVA: 0x000A6AB0 File Offset: 0x000A4CB0
			// (set) Token: 0x0600259F RID: 9631 RVA: 0x00011F31 File Offset: 0x00010131
			public unsafe static Func<KeyValuePair<Entity, int>, int> __9__14_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KnapsackSelectedFrom.__c.NativeFieldInfoPtr___9__14_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Entity, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KnapsackSelectedFrom.__c.NativeFieldInfoPtr___9__14_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700093F RID: 2367
			// (get) Token: 0x060025A0 RID: 9632 RVA: 0x000A6AD8 File Offset: 0x000A4CD8
			// (set) Token: 0x060025A1 RID: 9633 RVA: 0x00011F43 File Offset: 0x00010143
			public unsafe static Func<KeyValuePair<EntityID, int>, int> __9__14_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KnapsackSelectedFrom.__c.NativeFieldInfoPtr___9__14_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<EntityID, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KnapsackSelectedFrom.__c.NativeFieldInfoPtr___9__14_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400177F RID: 6015
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001780 RID: 6016
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x04001781 RID: 6017
			private static readonly IntPtr NativeFieldInfoPtr___9__14_2;

			// Token: 0x04001782 RID: 6018
			private static readonly IntPtr NativeFieldInfoPtr___9__14_3;

			// Token: 0x04001783 RID: 6019
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001784 RID: 6020
			private static readonly IntPtr NativeMethodInfoPtr__PickTargets_b__14_1_Internal_EntityID_KeyValuePair_2_Entity_Int32_0;

			// Token: 0x04001785 RID: 6021
			private static readonly IntPtr NativeMethodInfoPtr__PickTargets_b__14_2_Internal_Int32_KeyValuePair_2_Entity_Int32_0;

			// Token: 0x04001786 RID: 6022
			private static readonly IntPtr NativeMethodInfoPtr__PickTargets_b__14_3_Internal_Int32_KeyValuePair_2_EntityID_Int32_0;
		}

		// Token: 0x02000384 RID: 900
		[ObfuscatedName("Canis.context.targetpickers.KnapsackSelectedFrom+<>c__DisplayClass14_0")]
		public new sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x060025A2 RID: 9634 RVA: 0x000A6B00 File Offset: 0x000A4D00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<KnapsackSelectedFrom.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KnapsackSelectedFrom>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnapsackSelectedFrom.__c__DisplayClass14_0>.NativeClassPtr);
				KnapsackSelectedFrom.__c__DisplayClass14_0.NativeFieldInfoPtr__ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackSelectedFrom.__c__DisplayClass14_0>.NativeClassPtr, "_");
				KnapsackSelectedFrom.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnapsackSelectedFrom.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				KnapsackSelectedFrom.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackSelectedFrom.__c__DisplayClass14_0>.NativeClassPtr, 100666276);
				KnapsackSelectedFrom.__c__DisplayClass14_0.NativeMethodInfoPtr__PickTargets_b__4_Internal_Boolean_Func_2_Context_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnapsackSelectedFrom.__c__DisplayClass14_0>.NativeClassPtr, 100666277);
			}

			// Token: 0x060025A3 RID: 9635 RVA: 0x000A6B7C File Offset: 0x000A4D7C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KnapsackSelectedFrom.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackSelectedFrom.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025A4 RID: 9636 RVA: 0x000A6BB8 File Offset: 0x000A4DB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576135, XrefRangeEnd = 576139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PickTargets_b__4(Func<Context, bool> allow)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(allow);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnapsackSelectedFrom.__c__DisplayClass14_0.NativeMethodInfoPtr__PickTargets_b__4_Internal_Boolean_Func_2_Context_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060025A5 RID: 9637 RVA: 0x00011F55 File Offset: 0x00010155
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000940 RID: 2368
			// (get) Token: 0x060025A6 RID: 9638 RVA: 0x000A6C08 File Offset: 0x000A4E08
			// (set) Token: 0x060025A7 RID: 9639 RVA: 0x00011F5E File Offset: 0x0001015E
			public KeyValuePair<Entity, int> _
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.__c__DisplayClass14_0.NativeFieldInfoPtr__);
					return new KeyValuePair<Entity, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<Entity, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.__c__DisplayClass14_0.NativeFieldInfoPtr__), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<Entity, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000941 RID: 2369
			// (get) Token: 0x060025A8 RID: 9640 RVA: 0x000A6C38 File Offset: 0x000A4E38
			// (set) Token: 0x060025A9 RID: 9641 RVA: 0x00011F8C File Offset: 0x0001018C
			public unsafe KnapsackSelectedFrom __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KnapsackSelectedFrom>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KnapsackSelectedFrom.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001787 RID: 6023
			private static readonly IntPtr NativeFieldInfoPtr__;

			// Token: 0x04001788 RID: 6024
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001789 RID: 6025
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400178A RID: 6026
			private static readonly IntPtr NativeMethodInfoPtr__PickTargets_b__4_Internal_Boolean_Func_2_Context_Boolean_0;
		}
	}
}
