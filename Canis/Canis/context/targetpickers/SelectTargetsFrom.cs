using System;
using Canis.actions;
using Canis.actions.responseparsers;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Networking.selection.messages;
using Networking.selection.messages.outgoing;
using Networking.selection.targetinformation;
using Networking.selection.targetresponse;

namespace Canis.context.targetpickers
{
	// Token: 0x02000124 RID: 292
	public class SelectTargetsFrom : TargetPicker<EntityIDTargetResponses>
	{
		// Token: 0x06000D94 RID: 3476 RVA: 0x000535B4 File Offset: 0x000517B4
		// Note: this type is marked as 'beforefieldinit'.
		static SelectTargetsFrom()
		{
			Il2CppClassPointerStore<SelectTargetsFrom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.targetpickers", "SelectTargetsFrom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectTargetsFrom>.NativeClassPtr);
			SelectTargetsFrom.NativeFieldInfoPtr_fromTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectTargetsFrom>.NativeClassPtr, "fromTargets");
			SelectTargetsFrom.NativeFieldInfoPtr_forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectTargetsFrom>.NativeClassPtr, "forced");
			SelectTargetsFrom.NativeFieldInfoPtr_ignoreFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectTargetsFrom>.NativeClassPtr, "ignoreFirst");
			SelectTargetsFrom.NativeFieldInfoPtr_selectionSourceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectTargetsFrom>.NativeClassPtr, "selectionSourceID");
			SelectTargetsFrom.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_Match_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectTargetsFrom>.NativeClassPtr, 100666323);
			SelectTargetsFrom.NativeMethodInfoPtr_WithSource_Public_SelectTargetsFrom_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectTargetsFrom>.NativeClassPtr, 100666324);
			SelectTargetsFrom.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_EntityIDTargetResponses_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectTargetsFrom>.NativeClassPtr, 100666325);
			SelectTargetsFrom.NativeMethodInfoPtr_get_SelectedTargets_Public_get_IEnumerable_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectTargetsFrom>.NativeClassPtr, 100666326);
			SelectTargetsFrom.NativeMethodInfoPtr_GetSelectionMessage_Public_Virtual_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectTargetsFrom>.NativeClassPtr, 100666327);
			SelectTargetsFrom.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectTargetsFrom>.NativeClassPtr, 100666328);
			SelectTargetsFrom.NativeMethodInfoPtr_GetEntityTargets_Public_Static_Nullable_1_ValueTuple_2_Entity_IEnumerable_1_T_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectTargetsFrom>.NativeClassPtr, 100666329);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x000536C0 File Offset: 0x000518C0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 576758, RefRangeEnd = 576766, XrefRangeStart = 576754, XrefRangeEnd = 576758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectTargetsFrom(Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>> fromTargets, Match m, bool waitForResponse, bool forced = true, bool ignoreFirst = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectTargetsFrom>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fromTargets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitForResponse;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreFirst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectTargetsFrom.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_Match_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00053748 File Offset: 0x00051948
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 575803, RefRangeEnd = 575811, XrefRangeStart = 575803, XrefRangeEnd = 575811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectTargetsFrom WithSource(EntityID eid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectTargetsFrom.NativeMethodInfoPtr_WithSource_Public_SelectTargetsFrom_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectTargetsFrom>(intPtr3) : null;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x00053798 File Offset: 0x00051998
		public unsafe override ResponseParser<EntityIDTargetResponses> responseParser
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576766, XrefRangeEnd = 576770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectTargetsFrom.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_EntityIDTargetResponses_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResponseParser<EntityIDTargetResponses>>(intPtr3) : null;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x000537E4 File Offset: 0x000519E4
		public unsafe IEnumerable<EntityID> SelectedTargets
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576770, XrefRangeEnd = 576788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectTargetsFrom.NativeMethodInfoPtr_get_SelectedTargets_Public_get_IEnumerable_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00053824 File Offset: 0x00051A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576788, XrefRangeEnd = 576813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SelectionMessage GetSelectionMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectTargetsFrom.NativeMethodInfoPtr_GetSelectionMessage_Public_Virtual_SelectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr3) : null;
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00053870 File Offset: 0x00051A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576813, XrefRangeEnd = 576822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SelectionRequest PickTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectTargetsFrom.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionRequest>(intPtr3) : null;
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x000538BC File Offset: 0x00051ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576822, XrefRangeEnd = 576853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<ValueTuple<Entity, IEnumerable<T>>> GetEntityTargets<T>(Match match, Context context) where T : Entity
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectTargetsFrom.MethodInfoStoreGeneric_GetEntityTargets_Public_Static_Nullable_1_ValueTuple_2_Entity_IEnumerable_1_T_Match_Context_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<ValueTuple<Entity, IEnumerable<T>>>(intPtr);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00006EA6 File Offset: 0x000050A6
		public SelectTargetsFrom(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x0005390C File Offset: 0x00051B0C
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x00006EAF File Offset: 0x000050AF
		public unsafe Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>> fromTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectTargetsFrom.NativeFieldInfoPtr_fromTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, Il2CppReferenceArray<TargetInformation>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectTargetsFrom.NativeFieldInfoPtr_fromTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x0005393C File Offset: 0x00051B3C
		// (set) Token: 0x06000DA0 RID: 3488 RVA: 0x00006ECE File Offset: 0x000050CE
		public unsafe bool forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectTargetsFrom.NativeFieldInfoPtr_forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectTargetsFrom.NativeFieldInfoPtr_forced)) = value;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x00053964 File Offset: 0x00051B64
		// (set) Token: 0x06000DA2 RID: 3490 RVA: 0x00006EE9 File Offset: 0x000050E9
		public unsafe bool ignoreFirst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectTargetsFrom.NativeFieldInfoPtr_ignoreFirst);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectTargetsFrom.NativeFieldInfoPtr_ignoreFirst)) = value;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x0005398C File Offset: 0x00051B8C
		// (set) Token: 0x06000DA4 RID: 3492 RVA: 0x00006F04 File Offset: 0x00005104
		public unsafe EntityID selectionSourceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectTargetsFrom.NativeFieldInfoPtr_selectionSourceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectTargetsFrom.NativeFieldInfoPtr_selectionSourceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeFieldInfoPtr_fromTargets;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeFieldInfoPtr_forced;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeFieldInfoPtr_ignoreFirst;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeFieldInfoPtr_selectionSourceID;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_EntityID_Il2CppReferenceArray_1_TargetInformation_Match_Boolean_Boolean_Boolean_0;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_WithSource_Public_SelectTargetsFrom_EntityID_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_EntityIDTargetResponses_0;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedTargets_Public_get_IEnumerable_1_EntityID_0;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectionMessage_Public_Virtual_SelectionMessage_0;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeMethodInfoPtr_GetEntityTargets_Public_Static_Nullable_1_ValueTuple_2_Entity_IEnumerable_1_T_Match_Context_0;

		// Token: 0x02000389 RID: 905
		[ObfuscatedName("Canis.context.targetpickers.SelectTargetsFrom+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060025D3 RID: 9683 RVA: 0x000A73C8 File Offset: 0x000A55C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SelectTargetsFrom.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectTargetsFrom>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectTargetsFrom.__c>.NativeClassPtr);
				SelectTargetsFrom.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectTargetsFrom.__c>.NativeClassPtr, "<>9");
				SelectTargetsFrom.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectTargetsFrom.__c>.NativeClassPtr, "<>9__9_1");
				SelectTargetsFrom.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectTargetsFrom.__c>.NativeClassPtr, "<>9__9_0");
				SelectTargetsFrom.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectTargetsFrom.__c>.NativeClassPtr, 100666331);
				SelectTargetsFrom.__c.NativeMethodInfoPtr__get_SelectedTargets_b__9_0_Internal_IEnumerable_1_EntityID_EntityIDTargetResponses_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectTargetsFrom.__c>.NativeClassPtr, 100666332);
				SelectTargetsFrom.__c.NativeMethodInfoPtr__get_SelectedTargets_b__9_1_Internal_IEnumerable_1_EntityID_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectTargetsFrom.__c>.NativeClassPtr, 100666333);
			}

			// Token: 0x060025D4 RID: 9684 RVA: 0x000A746C File Offset: 0x000A566C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectTargetsFrom.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectTargetsFrom.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025D5 RID: 9685 RVA: 0x000A74A8 File Offset: 0x000A56A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576723, XrefRangeEnd = 576742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<EntityID> _get_SelectedTargets_b__9_0(EntityIDTargetResponses response)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectTargetsFrom.__c.NativeMethodInfoPtr__get_SelectedTargets_b__9_0_Internal_IEnumerable_1_EntityID_EntityIDTargetResponses_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<EntityID>>(intPtr3) : null;
				}
			}

			// Token: 0x060025D6 RID: 9686 RVA: 0x000A74F8 File Offset: 0x000A56F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576742, XrefRangeEnd = 576744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<EntityID> _get_SelectedTargets_b__9_1(TargetResponse targetResponse)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetResponse);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectTargetsFrom.__c.NativeMethodInfoPtr__get_SelectedTargets_b__9_1_Internal_IEnumerable_1_EntityID_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<EntityID>>(intPtr3) : null;
				}
			}

			// Token: 0x060025D7 RID: 9687 RVA: 0x000120C9 File Offset: 0x000102C9
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700094D RID: 2381
			// (get) Token: 0x060025D8 RID: 9688 RVA: 0x000A7548 File Offset: 0x000A5748
			// (set) Token: 0x060025D9 RID: 9689 RVA: 0x000120D2 File Offset: 0x000102D2
			public unsafe static SelectTargetsFrom.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectTargetsFrom.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectTargetsFrom.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectTargetsFrom.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700094E RID: 2382
			// (get) Token: 0x060025DA RID: 9690 RVA: 0x000A7570 File Offset: 0x000A5770
			// (set) Token: 0x060025DB RID: 9691 RVA: 0x000120E4 File Offset: 0x000102E4
			public unsafe static Func<TargetResponse, IEnumerable<EntityID>> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectTargetsFrom.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TargetResponse, IEnumerable<EntityID>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectTargetsFrom.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700094F RID: 2383
			// (get) Token: 0x060025DC RID: 9692 RVA: 0x000A7598 File Offset: 0x000A5798
			// (set) Token: 0x060025DD RID: 9693 RVA: 0x000120F6 File Offset: 0x000102F6
			public unsafe static Func<EntityIDTargetResponses, IEnumerable<EntityID>> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectTargetsFrom.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityIDTargetResponses, IEnumerable<EntityID>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectTargetsFrom.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017A1 RID: 6049
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040017A2 RID: 6050
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x040017A3 RID: 6051
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x040017A4 RID: 6052
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017A5 RID: 6053
			private static readonly IntPtr NativeMethodInfoPtr__get_SelectedTargets_b__9_0_Internal_IEnumerable_1_EntityID_EntityIDTargetResponses_0;

			// Token: 0x040017A6 RID: 6054
			private static readonly IntPtr NativeMethodInfoPtr__get_SelectedTargets_b__9_1_Internal_IEnumerable_1_EntityID_TargetResponse_0;
		}

		// Token: 0x0200038A RID: 906
		[ObfuscatedName("Canis.context.targetpickers.SelectTargetsFrom+<>c__DisplayClass12_0`1")]
		public sealed class __c__DisplayClass12_0<T> : Object where T : Entity
		{
			// Token: 0x060025DE RID: 9694 RVA: 0x000A75C0 File Offset: 0x000A57C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<SelectTargetsFrom.__c__DisplayClass12_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectTargetsFrom>.NativeClassPtr, "<>c__DisplayClass12_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectTargetsFrom.__c__DisplayClass12_0<T>>.NativeClassPtr);
				SelectTargetsFrom.__c__DisplayClass12_0<T>.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectTargetsFrom.__c__DisplayClass12_0<T>>.NativeClassPtr, "match");
				SelectTargetsFrom.__c__DisplayClass12_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectTargetsFrom.__c__DisplayClass12_0<T>>.NativeClassPtr, 100666334);
				SelectTargetsFrom.__c__DisplayClass12_0<T>.NativeMethodInfoPtr__GetEntityTargets_b__0_Internal_IEnumerable_1_Entity_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectTargetsFrom.__c__DisplayClass12_0<T>>.NativeClassPtr, 100666335);
			}

			// Token: 0x060025DF RID: 9695 RVA: 0x000A7664 File Offset: 0x000A5864
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectTargetsFrom.__c__DisplayClass12_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectTargetsFrom.__c__DisplayClass12_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025E0 RID: 9696 RVA: 0x000A76A0 File Offset: 0x000A58A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576744, XrefRangeEnd = 576754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Entity> _GetEntityTargets_b__0(EntityID entID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entID);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectTargetsFrom.__c__DisplayClass12_0<T>.NativeMethodInfoPtr__GetEntityTargets_b__0_Internal_IEnumerable_1_Entity_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x060025E1 RID: 9697 RVA: 0x00012108 File Offset: 0x00010308
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000950 RID: 2384
			// (get) Token: 0x060025E2 RID: 9698 RVA: 0x000A76F0 File Offset: 0x000A58F0
			// (set) Token: 0x060025E3 RID: 9699 RVA: 0x00012111 File Offset: 0x00010311
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectTargetsFrom.__c__DisplayClass12_0<T>.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectTargetsFrom.__c__DisplayClass12_0<T>.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017A7 RID: 6055
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040017A8 RID: 6056
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017A9 RID: 6057
			private static readonly IntPtr NativeMethodInfoPtr__GetEntityTargets_b__0_Internal_IEnumerable_1_Entity_EntityID_0;
		}

		// Token: 0x0200038B RID: 907
		private sealed class MethodInfoStoreGeneric_GetEntityTargets_Public_Static_Nullable_1_ValueTuple_2_Entity_IEnumerable_1_T_Match_Context_0<T>
		{
			// Token: 0x040017AA RID: 6058
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SelectTargetsFrom.NativeMethodInfoPtr_GetEntityTargets_Public_Static_Nullable_1_ValueTuple_2_Entity_IEnumerable_1_T_Match_Context_0, Il2CppClassPointerStore<SelectTargetsFrom>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
