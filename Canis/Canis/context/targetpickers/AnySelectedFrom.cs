using System;
using Canis.actions;
using Canis.actions.completions;
using Canis.actions.continuations;
using Canis.actions.responseparsers;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Networking.selection.messages;

namespace Canis.context.targetpickers
{
	// Token: 0x0200011C RID: 284
	public class AnySelectedFrom : TargetPicker<Entity>
	{
		// Token: 0x06000CF0 RID: 3312 RVA: 0x000510E4 File Offset: 0x0004F2E4
		// Note: this type is marked as 'beforefieldinit'.
		static AnySelectedFrom()
		{
			Il2CppClassPointerStore<AnySelectedFrom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.targetpickers", "AnySelectedFrom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnySelectedFrom>.NativeClassPtr);
			AnySelectedFrom.NativeFieldInfoPtr_allTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnySelectedFrom>.NativeClassPtr, "allTargets");
			AnySelectedFrom.NativeFieldInfoPtr_forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnySelectedFrom>.NativeClassPtr, "forced");
			AnySelectedFrom.NativeFieldInfoPtr_forceOuter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnySelectedFrom>.NativeClassPtr, "forceOuter");
			AnySelectedFrom.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnySelectedFrom>.NativeClassPtr, "max");
			AnySelectedFrom.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnySelectedFrom>.NativeClassPtr, "min");
			AnySelectedFrom.NativeFieldInfoPtr_invalidOnSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnySelectedFrom>.NativeClassPtr, "invalidOnSkip");
			AnySelectedFrom.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_AccountID_List_1_Entity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnySelectedFrom>.NativeClassPtr, 100666243);
			AnySelectedFrom.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_AccountID_List_1_Entity_Boolean_Int32_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnySelectedFrom>.NativeClassPtr, 100666244);
			AnySelectedFrom.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_AccountID_List_1_Entity_Boolean_Nullable_1_Boolean_Int32_Int32_Boolean_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnySelectedFrom>.NativeClassPtr, 100666245);
			AnySelectedFrom.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnySelectedFrom>.NativeClassPtr, 100666246);
			AnySelectedFrom.NativeMethodInfoPtr_MakeContinuation_Protected_Virtual_ActionContinuation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnySelectedFrom>.NativeClassPtr, 100666247);
			AnySelectedFrom.NativeMethodInfoPtr_MakeCompletion_Protected_Virtual_SelectionCompletion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnySelectedFrom>.NativeClassPtr, 100666248);
			AnySelectedFrom.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnySelectedFrom>.NativeClassPtr, 100666249);
			AnySelectedFrom.NativeMethodInfoPtr__PickTargets_b__13_0_Private_SelectionMessage_KeyValuePair_2_AccountID_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnySelectedFrom>.NativeClassPtr, 100666250);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0005122C File Offset: 0x0004F42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575885, XrefRangeEnd = 575886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnySelectedFrom(Dictionary<AccountID, List<Entity>> allTargets, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnySelectedFrom>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allTargets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnySelectedFrom.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_AccountID_List_1_Entity_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0005128C File Offset: 0x0004F48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575886, XrefRangeEnd = 575887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnySelectedFrom(Dictionary<AccountID, List<Entity>> allTargets, bool forced, int max, int min, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnySelectedFrom>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allTargets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnySelectedFrom.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_AccountID_List_1_Entity_Boolean_Int32_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00051314 File Offset: 0x0004F514
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 575897, RefRangeEnd = 575899, XrefRangeStart = 575887, XrefRangeEnd = 575897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnySelectedFrom(Dictionary<AccountID, List<Entity>> allTargets, bool forced, Nullable<bool> forceOuter, int max, int min, bool invalidOnSkip, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnySelectedFrom>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allTargets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(forceOuter));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invalidOnSkip;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnySelectedFrom.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_AccountID_List_1_Entity_Boolean_Nullable_1_Boolean_Int32_Int32_Boolean_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x000513C4 File Offset: 0x0004F5C4
		public unsafe override ResponseParser<Entity> responseParser
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575899, XrefRangeEnd = 575903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnySelectedFrom.NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResponseParser<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00051410 File Offset: 0x0004F610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575903, XrefRangeEnd = 575926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ActionContinuation MakeContinuation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnySelectedFrom.NativeMethodInfoPtr_MakeContinuation_Protected_Virtual_ActionContinuation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionContinuation>(intPtr3) : null;
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x0005145C File Offset: 0x0004F65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575926, XrefRangeEnd = 575930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SelectionCompletion MakeCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnySelectedFrom.NativeMethodInfoPtr_MakeCompletion_Protected_Virtual_SelectionCompletion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionCompletion>(intPtr3) : null;
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x000514A8 File Offset: 0x0004F6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575930, XrefRangeEnd = 575953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SelectionRequest PickTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnySelectedFrom.NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionRequest>(intPtr3) : null;
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x000514F4 File Offset: 0x0004F6F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575953, XrefRangeEnd = 576026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionMessage _PickTargets_b__13_0(KeyValuePair<AccountID, List<Entity>> pair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnySelectedFrom.NativeMethodInfoPtr__PickTargets_b__13_0_Private_SelectionMessage_KeyValuePair_2_AccountID_List_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00006919 File Offset: 0x00004B19
		public AnySelectedFrom(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x0005154C File Offset: 0x0004F74C
		// (set) Token: 0x06000CFB RID: 3323 RVA: 0x00006922 File Offset: 0x00004B22
		public unsafe ReadOnlyDictionary<AccountID, List<Entity>> allTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnySelectedFrom.NativeFieldInfoPtr_allTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyDictionary<AccountID, List<Entity>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnySelectedFrom.NativeFieldInfoPtr_allTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x0005157C File Offset: 0x0004F77C
		// (set) Token: 0x06000CFD RID: 3325 RVA: 0x00006941 File Offset: 0x00004B41
		public unsafe bool forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnySelectedFrom.NativeFieldInfoPtr_forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnySelectedFrom.NativeFieldInfoPtr_forced)) = value;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x000515A4 File Offset: 0x0004F7A4
		// (set) Token: 0x06000CFF RID: 3327 RVA: 0x0000695C File Offset: 0x00004B5C
		public Nullable<bool> forceOuter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnySelectedFrom.NativeFieldInfoPtr_forceOuter);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnySelectedFrom.NativeFieldInfoPtr_forceOuter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x000515D4 File Offset: 0x0004F7D4
		// (set) Token: 0x06000D01 RID: 3329 RVA: 0x0000698A File Offset: 0x00004B8A
		public unsafe int max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnySelectedFrom.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnySelectedFrom.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x000515FC File Offset: 0x0004F7FC
		// (set) Token: 0x06000D03 RID: 3331 RVA: 0x000069A5 File Offset: 0x00004BA5
		public unsafe int min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnySelectedFrom.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnySelectedFrom.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x00051624 File Offset: 0x0004F824
		// (set) Token: 0x06000D05 RID: 3333 RVA: 0x000069C0 File Offset: 0x00004BC0
		public unsafe bool invalidOnSkip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnySelectedFrom.NativeFieldInfoPtr_invalidOnSkip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnySelectedFrom.NativeFieldInfoPtr_invalidOnSkip)) = value;
			}
		}

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeFieldInfoPtr_allTargets;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeFieldInfoPtr_forced;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeFieldInfoPtr_forceOuter;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeFieldInfoPtr_invalidOnSkip;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_AccountID_List_1_Entity_Match_0;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_AccountID_List_1_Entity_Boolean_Int32_Int32_Match_0;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_AccountID_List_1_Entity_Boolean_Nullable_1_Boolean_Int32_Int32_Boolean_Match_0;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeMethodInfoPtr_get_responseParser_Public_Virtual_get_ResponseParser_1_Entity_0;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeMethodInfoPtr_MakeContinuation_Protected_Virtual_ActionContinuation_0;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeMethodInfoPtr_MakeCompletion_Protected_Virtual_SelectionCompletion_0;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeMethodInfoPtr_PickTargets_Public_Virtual_SelectionRequest_0;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeMethodInfoPtr__PickTargets_b__13_0_Private_SelectionMessage_KeyValuePair_2_AccountID_List_1_Entity_0;

		// Token: 0x02000382 RID: 898
		[ObfuscatedName("Canis.context.targetpickers.AnySelectedFrom+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002589 RID: 9609 RVA: 0x000A6658 File Offset: 0x000A4858
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AnySelectedFrom.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnySelectedFrom>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnySelectedFrom.__c>.NativeClassPtr);
				AnySelectedFrom.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnySelectedFrom.__c>.NativeClassPtr, "<>9");
				AnySelectedFrom.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnySelectedFrom.__c>.NativeClassPtr, "<>9__11_0");
				AnySelectedFrom.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnySelectedFrom.__c>.NativeClassPtr, "<>9__13_1");
				AnySelectedFrom.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnySelectedFrom.__c>.NativeClassPtr, 100666252);
				AnySelectedFrom.__c.NativeMethodInfoPtr__MakeContinuation_b__11_0_Internal_AccountID_KeyValuePair_2_AccountID_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnySelectedFrom.__c>.NativeClassPtr, 100666253);
				AnySelectedFrom.__c.NativeMethodInfoPtr__PickTargets_b__13_1_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnySelectedFrom.__c>.NativeClassPtr, 100666254);
			}

			// Token: 0x0600258A RID: 9610 RVA: 0x000A66FC File Offset: 0x000A48FC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnySelectedFrom.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnySelectedFrom.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600258B RID: 9611 RVA: 0x000A6738 File Offset: 0x000A4938
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 575884, XrefRangeEnd = 575885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AccountID _MakeContinuation_b__11_0(KeyValuePair<AccountID, List<Entity>> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnySelectedFrom.__c.NativeMethodInfoPtr__MakeContinuation_b__11_0_Internal_AccountID_KeyValuePair_2_AccountID_List_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x0600258C RID: 9612 RVA: 0x000A6790 File Offset: 0x000A4990
			[CallerCount(0)]
			public unsafe EntityID _PickTargets_b__13_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnySelectedFrom.__c.NativeMethodInfoPtr__PickTargets_b__13_1_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x0600258D RID: 9613 RVA: 0x00011EC5 File Offset: 0x000100C5
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000939 RID: 2361
			// (get) Token: 0x0600258E RID: 9614 RVA: 0x000A67E0 File Offset: 0x000A49E0
			// (set) Token: 0x0600258F RID: 9615 RVA: 0x00011ECE File Offset: 0x000100CE
			public unsafe static AnySelectedFrom.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AnySelectedFrom.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnySelectedFrom.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AnySelectedFrom.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700093A RID: 2362
			// (get) Token: 0x06002590 RID: 9616 RVA: 0x000A6808 File Offset: 0x000A4A08
			// (set) Token: 0x06002591 RID: 9617 RVA: 0x00011EE0 File Offset: 0x000100E0
			public unsafe static Func<KeyValuePair<AccountID, List<Entity>>, AccountID> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AnySelectedFrom.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<AccountID, List<Entity>>, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AnySelectedFrom.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700093B RID: 2363
			// (get) Token: 0x06002592 RID: 9618 RVA: 0x000A6830 File Offset: 0x000A4A30
			// (set) Token: 0x06002593 RID: 9619 RVA: 0x00011EF2 File Offset: 0x000100F2
			public unsafe static Func<Entity, EntityID> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AnySelectedFrom.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AnySelectedFrom.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001779 RID: 6009
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400177A RID: 6010
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x0400177B RID: 6011
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x0400177C RID: 6012
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400177D RID: 6013
			private static readonly IntPtr NativeMethodInfoPtr__MakeContinuation_b__11_0_Internal_AccountID_KeyValuePair_2_AccountID_List_1_Entity_0;

			// Token: 0x0400177E RID: 6014
			private static readonly IntPtr NativeMethodInfoPtr__PickTargets_b__13_1_Internal_EntityID_Entity_0;
		}
	}
}
