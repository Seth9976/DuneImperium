using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.context;
using Canis.entities;
using Canis.entities.ai;
using Canis.hasExecutionStack;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.ai.choices;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x02000260 RID: 608
	public class LoseAlliance : global::Canis.actions.Action
	{
		// Token: 0x060019FB RID: 6651 RVA: 0x000BDE58 File Offset: 0x000BC058
		// Note: this type is marked as 'beforefieldinit'.
		static LoseAlliance()
		{
			Il2CppClassPointerStore<LoseAlliance>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "LoseAlliance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoseAlliance>.NativeClassPtr);
			LoseAlliance.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance>.NativeClassPtr, "wormMatch");
			LoseAlliance.NativeFieldInfoPtr_factionTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance>.NativeClassPtr, "factionTrack");
			LoseAlliance.NativeFieldInfoPtr__ExecutingStack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance>.NativeClassPtr, "<ExecutingStack>k__BackingField");
			LoseAlliance.NativeMethodInfoPtr_get_ExecutingStack_Public_Virtual_Final_New_get_IHasExecutionStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance>.NativeClassPtr, 100668107);
			LoseAlliance.NativeMethodInfoPtr_set_ExecutingStack_Public_Virtual_Final_New_set_Void_IHasExecutionStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance>.NativeClassPtr, 100668108);
			LoseAlliance.NativeMethodInfoPtr__ctor_Public_Void_WormFactionTrack_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance>.NativeClassPtr, 100668109);
			LoseAlliance.NativeMethodInfoPtr__ctor_Public_Void_SerializedLoseAlliance_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance>.NativeClassPtr, 100668110);
			LoseAlliance.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance>.NativeClassPtr, 100668111);
			LoseAlliance.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance>.NativeClassPtr, 100668112);
			LoseAlliance.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance>.NativeClassPtr, 100668113);
			LoseAlliance.NativeMethodInfoPtr_EvaluateResolutionChoice_Private_WormAIChoice_AIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance>.NativeClassPtr, 100668114);
			LoseAlliance.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance>.NativeClassPtr, 100668115);
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x000BDF78 File Offset: 0x000BC178
		// (set) Token: 0x060019FD RID: 6653 RVA: 0x000BDFB8 File Offset: 0x000BC1B8
		public unsafe virtual IHasExecutionStack ExecutingStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance.NativeMethodInfoPtr_get_ExecutingStack_Public_Virtual_Final_New_get_IHasExecutionStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasExecutionStack>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139777, XrefRangeEnd = 139778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance.NativeMethodInfoPtr_set_ExecutingStack_Public_Virtual_Final_New_set_Void_IHasExecutionStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x000BDFFC File Offset: 0x000BC1FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 139781, RefRangeEnd = 139782, XrefRangeStart = 139778, XrefRangeEnd = 139781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoseAlliance(WormFactionTrack factionTrack, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoseAlliance>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factionTrack);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance.NativeMethodInfoPtr__ctor_Public_Void_WormFactionTrack_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x000BE05C File Offset: 0x000BC25C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 139795, RefRangeEnd = 139796, XrefRangeStart = 139782, XrefRangeEnd = 139795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoseAlliance(SerializedLoseAlliance serialized, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoseAlliance>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance.NativeMethodInfoPtr__ctor_Public_Void_SerializedLoseAlliance_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x000BE0BC File Offset: 0x000BC2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139796, XrefRangeEnd = 139801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoseAlliance.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x000BE108 File Offset: 0x000BC308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139801, XrefRangeEnd = 139807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoseAlliance.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x000BE164 File Offset: 0x000BC364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139807, XrefRangeEnd = 139809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HandleReturningAction(global::Canis.actions.Action returningAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoseAlliance.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x000BE1B4 File Offset: 0x000BC3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139809, XrefRangeEnd = 139848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAIChoice EvaluateResolutionChoice(AIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance.NativeMethodInfoPtr_EvaluateResolutionChoice_Private_WormAIChoice_AIChoiceContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x000BE204 File Offset: 0x000BC404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139848, XrefRangeEnd = 139853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoseAlliance.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x0000B2E1 File Offset: 0x000094E1
		public LoseAlliance(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001A06 RID: 6662 RVA: 0x000BE260 File Offset: 0x000BC460
		// (set) Token: 0x06001A07 RID: 6663 RVA: 0x0000B2EA File Offset: 0x000094EA
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001A08 RID: 6664 RVA: 0x000BE290 File Offset: 0x000BC490
		// (set) Token: 0x06001A09 RID: 6665 RVA: 0x0000B309 File Offset: 0x00009509
		public unsafe WormFactionTrack factionTrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance.NativeFieldInfoPtr_factionTrack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormFactionTrack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance.NativeFieldInfoPtr_factionTrack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001A0A RID: 6666 RVA: 0x000BE2C0 File Offset: 0x000BC4C0
		// (set) Token: 0x06001A0B RID: 6667 RVA: 0x0000B328 File Offset: 0x00009528
		public unsafe IHasExecutionStack _ExecutingStack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance.NativeFieldInfoPtr__ExecutingStack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHasExecutionStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance.NativeFieldInfoPtr__ExecutingStack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400100C RID: 4108
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x0400100D RID: 4109
		private static readonly IntPtr NativeFieldInfoPtr_factionTrack;

		// Token: 0x0400100E RID: 4110
		private static readonly IntPtr NativeFieldInfoPtr__ExecutingStack_k__BackingField;

		// Token: 0x0400100F RID: 4111
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutingStack_Public_Virtual_Final_New_get_IHasExecutionStack_0;

		// Token: 0x04001010 RID: 4112
		private static readonly IntPtr NativeMethodInfoPtr_set_ExecutingStack_Public_Virtual_Final_New_set_Void_IHasExecutionStack_0;

		// Token: 0x04001011 RID: 4113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormFactionTrack_WormMatch_0;

		// Token: 0x04001012 RID: 4114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedLoseAlliance_Match_0;

		// Token: 0x04001013 RID: 4115
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04001014 RID: 4116
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x04001015 RID: 4117
		private static readonly IntPtr NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0;

		// Token: 0x04001016 RID: 4118
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateResolutionChoice_Private_WormAIChoice_AIChoiceContext_0;

		// Token: 0x04001017 RID: 4119
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x02000699 RID: 1689
		[ObfuscatedName("worm.canis.actions.LoseAlliance+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005843 RID: 22595 RVA: 0x001C1930 File Offset: 0x001BFB30
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LoseAlliance.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoseAlliance>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoseAlliance.__c>.NativeClassPtr);
				LoseAlliance.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance.__c>.NativeClassPtr, "<>9");
				LoseAlliance.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance.__c>.NativeClassPtr, "<>9__8_1");
				LoseAlliance.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance.__c>.NativeClassPtr, "<>9__11_0");
				LoseAlliance.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance.__c>.NativeClassPtr, 100668117);
				LoseAlliance.__c.NativeMethodInfoPtr__execute_b__8_1_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance.__c>.NativeClassPtr, 100668118);
				LoseAlliance.__c.NativeMethodInfoPtr__EvaluateResolutionChoice_b__11_0_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance.__c>.NativeClassPtr, 100668119);
			}

			// Token: 0x06005844 RID: 22596 RVA: 0x001C19D4 File Offset: 0x001BFBD4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoseAlliance.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005845 RID: 22597 RVA: 0x001C1A10 File Offset: 0x001BFC10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _execute_b__8_1(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance.__c.NativeMethodInfoPtr__execute_b__8_1_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005846 RID: 22598 RVA: 0x001C1A60 File Offset: 0x001BFC60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _EvaluateResolutionChoice_b__11_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance.__c.NativeMethodInfoPtr__EvaluateResolutionChoice_b__11_0_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005847 RID: 22599 RVA: 0x00020175 File Offset: 0x0001E375
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700168A RID: 5770
			// (get) Token: 0x06005848 RID: 22600 RVA: 0x001C1AB0 File Offset: 0x001BFCB0
			// (set) Token: 0x06005849 RID: 22601 RVA: 0x0002017E File Offset: 0x0001E37E
			public unsafe static LoseAlliance.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoseAlliance.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoseAlliance.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoseAlliance.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700168B RID: 5771
			// (get) Token: 0x0600584A RID: 22602 RVA: 0x001C1AD8 File Offset: 0x001BFCD8
			// (set) Token: 0x0600584B RID: 22603 RVA: 0x00020190 File Offset: 0x0001E390
			public unsafe static Func<WormPlayer, int> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoseAlliance.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoseAlliance.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700168C RID: 5772
			// (get) Token: 0x0600584C RID: 22604 RVA: 0x001C1B00 File Offset: 0x001BFD00
			// (set) Token: 0x0600584D RID: 22605 RVA: 0x000201A2 File Offset: 0x0001E3A2
			public unsafe static Func<WormPlayer, int> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoseAlliance.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoseAlliance.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400398C RID: 14732
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400398D RID: 14733
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x0400398E RID: 14734
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x0400398F RID: 14735
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003990 RID: 14736
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__8_1_Internal_Int32_WormPlayer_0;

			// Token: 0x04003991 RID: 14737
			private static readonly IntPtr NativeMethodInfoPtr__EvaluateResolutionChoice_b__11_0_Internal_Int32_WormPlayer_0;
		}

		// Token: 0x0200069A RID: 1690
		[ObfuscatedName("worm.canis.actions.LoseAlliance+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600584E RID: 22606 RVA: 0x001C1B28 File Offset: 0x001BFD28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<LoseAlliance.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoseAlliance>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoseAlliance.__c__DisplayClass8_0>.NativeClassPtr);
				LoseAlliance.__c__DisplayClass8_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance.__c__DisplayClass8_0>.NativeClassPtr, "player");
				LoseAlliance.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				LoseAlliance.__c__DisplayClass8_0.NativeFieldInfoPtr_highestOpponentRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance.__c__DisplayClass8_0>.NativeClassPtr, "highestOpponentRank");
				LoseAlliance.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance.__c__DisplayClass8_0>.NativeClassPtr, 100668120);
				LoseAlliance.__c__DisplayClass8_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance.__c__DisplayClass8_0>.NativeClassPtr, 100668121);
			}

			// Token: 0x0600584F RID: 22607 RVA: 0x001C1BB8 File Offset: 0x001BFDB8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoseAlliance.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005850 RID: 22608 RVA: 0x001C1BF4 File Offset: 0x001BFDF4
			[CallerCount(0)]
			public unsafe bool _execute_b__0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance.__c__DisplayClass8_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005851 RID: 22609 RVA: 0x000201B4 File Offset: 0x0001E3B4
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700168D RID: 5773
			// (get) Token: 0x06005852 RID: 22610 RVA: 0x001C1C44 File Offset: 0x001BFE44
			// (set) Token: 0x06005853 RID: 22611 RVA: 0x000201BD File Offset: 0x0001E3BD
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance.__c__DisplayClass8_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance.__c__DisplayClass8_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700168E RID: 5774
			// (get) Token: 0x06005854 RID: 22612 RVA: 0x001C1C74 File Offset: 0x001BFE74
			// (set) Token: 0x06005855 RID: 22613 RVA: 0x000201DC File Offset: 0x0001E3DC
			public unsafe LoseAlliance __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoseAlliance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700168F RID: 5775
			// (get) Token: 0x06005856 RID: 22614 RVA: 0x001C1CA4 File Offset: 0x001BFEA4
			// (set) Token: 0x06005857 RID: 22615 RVA: 0x000201FB File Offset: 0x0001E3FB
			public unsafe int highestOpponentRank
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance.__c__DisplayClass8_0.NativeFieldInfoPtr_highestOpponentRank);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance.__c__DisplayClass8_0.NativeFieldInfoPtr_highestOpponentRank)) = value;
				}
			}

			// Token: 0x04003992 RID: 14738
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04003993 RID: 14739
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003994 RID: 14740
			private static readonly IntPtr NativeFieldInfoPtr_highestOpponentRank;

			// Token: 0x04003995 RID: 14741
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003996 RID: 14742
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x0200069B RID: 1691
		[ObfuscatedName("worm.canis.actions.LoseAlliance+<execute>d__8")]
		public sealed class _execute_d__8 : Object
		{
			// Token: 0x06005858 RID: 22616 RVA: 0x001C1CCC File Offset: 0x001BFECC
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__8()
			{
				Il2CppClassPointerStore<LoseAlliance._execute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoseAlliance>.NativeClassPtr, "<execute>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoseAlliance._execute_d__8>.NativeClassPtr);
				LoseAlliance._execute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance._execute_d__8>.NativeClassPtr, "<>1__state");
				LoseAlliance._execute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance._execute_d__8>.NativeClassPtr, "<>2__current");
				LoseAlliance._execute_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance._execute_d__8>.NativeClassPtr, "<>l__initialThreadId");
				LoseAlliance._execute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance._execute_d__8>.NativeClassPtr, "<>4__this");
				LoseAlliance._execute_d__8.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance._execute_d__8>.NativeClassPtr, "<>8__1");
				LoseAlliance._execute_d__8.NativeFieldInfoPtr__allianceToken_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance._execute_d__8>.NativeClassPtr, "<allianceToken>5__2");
				LoseAlliance._execute_d__8.NativeFieldInfoPtr__playerAllianceTokenVP_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance._execute_d__8>.NativeClassPtr, "<playerAllianceTokenVP>5__3");
				LoseAlliance._execute_d__8.NativeFieldInfoPtr__childUndo_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance._execute_d__8>.NativeClassPtr, "<childUndo>5__4");
				LoseAlliance._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance._execute_d__8>.NativeClassPtr, 100668122);
				LoseAlliance._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance._execute_d__8>.NativeClassPtr, 100668123);
				LoseAlliance._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance._execute_d__8>.NativeClassPtr, 100668124);
				LoseAlliance._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance._execute_d__8>.NativeClassPtr, 100668125);
				LoseAlliance._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance._execute_d__8>.NativeClassPtr, 100668126);
				LoseAlliance._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance._execute_d__8>.NativeClassPtr, 100668127);
				LoseAlliance._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance._execute_d__8>.NativeClassPtr, 100668128);
				LoseAlliance._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance._execute_d__8>.NativeClassPtr, 100668129);
			}

			// Token: 0x06005859 RID: 22617 RVA: 0x001C1E38 File Offset: 0x001C0038
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoseAlliance._execute_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600585A RID: 22618 RVA: 0x001C1E80 File Offset: 0x001C0080
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600585B RID: 22619 RVA: 0x001C1EB4 File Offset: 0x001C00B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139411, XrefRangeEnd = 139707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001698 RID: 5784
			// (get) Token: 0x0600585C RID: 22620 RVA: 0x001C1EF0 File Offset: 0x001C00F0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600585D RID: 22621 RVA: 0x001C1F30 File Offset: 0x001C0130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139707, XrefRangeEnd = 139712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001699 RID: 5785
			// (get) Token: 0x0600585E RID: 22622 RVA: 0x001C1F64 File Offset: 0x001C0164
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600585F RID: 22623 RVA: 0x001C1FA4 File Offset: 0x001C01A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139712, XrefRangeEnd = 139714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005860 RID: 22624 RVA: 0x001C1FE4 File Offset: 0x001C01E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005861 RID: 22625 RVA: 0x00020216 File Offset: 0x0001E416
			public _execute_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001690 RID: 5776
			// (get) Token: 0x06005862 RID: 22626 RVA: 0x001C2024 File Offset: 0x001C0224
			// (set) Token: 0x06005863 RID: 22627 RVA: 0x0002021F File Offset: 0x0001E41F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._execute_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._execute_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001691 RID: 5777
			// (get) Token: 0x06005864 RID: 22628 RVA: 0x001C204C File Offset: 0x001C024C
			// (set) Token: 0x06005865 RID: 22629 RVA: 0x0002023A File Offset: 0x0001E43A
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._execute_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._execute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001692 RID: 5778
			// (get) Token: 0x06005866 RID: 22630 RVA: 0x001C207C File Offset: 0x001C027C
			// (set) Token: 0x06005867 RID: 22631 RVA: 0x00020259 File Offset: 0x0001E459
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._execute_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._execute_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001693 RID: 5779
			// (get) Token: 0x06005868 RID: 22632 RVA: 0x001C20A4 File Offset: 0x001C02A4
			// (set) Token: 0x06005869 RID: 22633 RVA: 0x00020274 File Offset: 0x0001E474
			public unsafe LoseAlliance __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._execute_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoseAlliance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._execute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001694 RID: 5780
			// (get) Token: 0x0600586A RID: 22634 RVA: 0x001C20D4 File Offset: 0x001C02D4
			// (set) Token: 0x0600586B RID: 22635 RVA: 0x00020293 File Offset: 0x0001E493
			public unsafe LoseAlliance.__c__DisplayClass8_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._execute_d__8.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoseAlliance.__c__DisplayClass8_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._execute_d__8.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001695 RID: 5781
			// (get) Token: 0x0600586C RID: 22636 RVA: 0x001C2104 File Offset: 0x001C0304
			// (set) Token: 0x0600586D RID: 22637 RVA: 0x000202B2 File Offset: 0x0001E4B2
			public unsafe WormEntity _allianceToken_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._execute_d__8.NativeFieldInfoPtr__allianceToken_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._execute_d__8.NativeFieldInfoPtr__allianceToken_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001696 RID: 5782
			// (get) Token: 0x0600586E RID: 22638 RVA: 0x001C2134 File Offset: 0x001C0334
			// (set) Token: 0x0600586F RID: 22639 RVA: 0x000202D1 File Offset: 0x0001E4D1
			public unsafe int _playerAllianceTokenVP_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._execute_d__8.NativeFieldInfoPtr__playerAllianceTokenVP_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._execute_d__8.NativeFieldInfoPtr__playerAllianceTokenVP_5__3)) = value;
				}
			}

			// Token: 0x17001697 RID: 5783
			// (get) Token: 0x06005870 RID: 22640 RVA: 0x001C215C File Offset: 0x001C035C
			// (set) Token: 0x06005871 RID: 22641 RVA: 0x000202EC File Offset: 0x0001E4EC
			public unsafe UndoNode _childUndo_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._execute_d__8.NativeFieldInfoPtr__childUndo_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._execute_d__8.NativeFieldInfoPtr__childUndo_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003997 RID: 14743
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003998 RID: 14744
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003999 RID: 14745
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400399A RID: 14746
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400399B RID: 14747
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400399C RID: 14748
			private static readonly IntPtr NativeFieldInfoPtr__allianceToken_5__2;

			// Token: 0x0400399D RID: 14749
			private static readonly IntPtr NativeFieldInfoPtr__playerAllianceTokenVP_5__3;

			// Token: 0x0400399E RID: 14750
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__4;

			// Token: 0x0400399F RID: 14751
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040039A0 RID: 14752
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040039A1 RID: 14753
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040039A2 RID: 14754
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040039A3 RID: 14755
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040039A4 RID: 14756
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040039A5 RID: 14757
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040039A6 RID: 14758
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200069C RID: 1692
		[ObfuscatedName("worm.canis.actions.LoseAlliance+<undo>d__9")]
		public sealed class _undo_d__9 : Object
		{
			// Token: 0x06005872 RID: 22642 RVA: 0x001C218C File Offset: 0x001C038C
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__9()
			{
				Il2CppClassPointerStore<LoseAlliance._undo_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoseAlliance>.NativeClassPtr, "<undo>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoseAlliance._undo_d__9>.NativeClassPtr);
				LoseAlliance._undo_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance._undo_d__9>.NativeClassPtr, "<>1__state");
				LoseAlliance._undo_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance._undo_d__9>.NativeClassPtr, "<>2__current");
				LoseAlliance._undo_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance._undo_d__9>.NativeClassPtr, "<>l__initialThreadId");
				LoseAlliance._undo_d__9.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance._undo_d__9>.NativeClassPtr, "undoContext");
				LoseAlliance._undo_d__9.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance._undo_d__9>.NativeClassPtr, "<>3__undoContext");
				LoseAlliance._undo_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseAlliance._undo_d__9>.NativeClassPtr, "<>4__this");
				LoseAlliance._undo_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance._undo_d__9>.NativeClassPtr, 100668130);
				LoseAlliance._undo_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance._undo_d__9>.NativeClassPtr, 100668131);
				LoseAlliance._undo_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance._undo_d__9>.NativeClassPtr, 100668132);
				LoseAlliance._undo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance._undo_d__9>.NativeClassPtr, 100668133);
				LoseAlliance._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance._undo_d__9>.NativeClassPtr, 100668134);
				LoseAlliance._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance._undo_d__9>.NativeClassPtr, 100668135);
				LoseAlliance._undo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance._undo_d__9>.NativeClassPtr, 100668136);
				LoseAlliance._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseAlliance._undo_d__9>.NativeClassPtr, 100668137);
			}

			// Token: 0x06005873 RID: 22643 RVA: 0x001C22D0 File Offset: 0x001C04D0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoseAlliance._undo_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance._undo_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005874 RID: 22644 RVA: 0x001C2318 File Offset: 0x001C0518
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance._undo_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005875 RID: 22645 RVA: 0x001C234C File Offset: 0x001C054C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139714, XrefRangeEnd = 139750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance._undo_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170016A0 RID: 5792
			// (get) Token: 0x06005876 RID: 22646 RVA: 0x001C2388 File Offset: 0x001C0588
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance._undo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005877 RID: 22647 RVA: 0x001C23C8 File Offset: 0x001C05C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139750, XrefRangeEnd = 139761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170016A1 RID: 5793
			// (get) Token: 0x06005878 RID: 22648 RVA: 0x001C23FC File Offset: 0x001C05FC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005879 RID: 22649 RVA: 0x001C243C File Offset: 0x001C063C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139761, XrefRangeEnd = 139770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance._undo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600587A RID: 22650 RVA: 0x001C247C File Offset: 0x001C067C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseAlliance._undo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600587B RID: 22651 RVA: 0x0002030B File Offset: 0x0001E50B
			public _undo_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700169A RID: 5786
			// (get) Token: 0x0600587C RID: 22652 RVA: 0x001C24BC File Offset: 0x001C06BC
			// (set) Token: 0x0600587D RID: 22653 RVA: 0x00020314 File Offset: 0x0001E514
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._undo_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._undo_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700169B RID: 5787
			// (get) Token: 0x0600587E RID: 22654 RVA: 0x001C24E4 File Offset: 0x001C06E4
			// (set) Token: 0x0600587F RID: 22655 RVA: 0x0002032F File Offset: 0x0001E52F
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._undo_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._undo_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700169C RID: 5788
			// (get) Token: 0x06005880 RID: 22656 RVA: 0x001C2514 File Offset: 0x001C0714
			// (set) Token: 0x06005881 RID: 22657 RVA: 0x0002034E File Offset: 0x0001E54E
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._undo_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._undo_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700169D RID: 5789
			// (get) Token: 0x06005882 RID: 22658 RVA: 0x001C253C File Offset: 0x001C073C
			// (set) Token: 0x06005883 RID: 22659 RVA: 0x00020369 File Offset: 0x0001E569
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._undo_d__9.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._undo_d__9.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700169E RID: 5790
			// (get) Token: 0x06005884 RID: 22660 RVA: 0x001C256C File Offset: 0x001C076C
			// (set) Token: 0x06005885 RID: 22661 RVA: 0x00020388 File Offset: 0x0001E588
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._undo_d__9.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._undo_d__9.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700169F RID: 5791
			// (get) Token: 0x06005886 RID: 22662 RVA: 0x001C259C File Offset: 0x001C079C
			// (set) Token: 0x06005887 RID: 22663 RVA: 0x000203A7 File Offset: 0x0001E5A7
			public unsafe LoseAlliance __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._undo_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoseAlliance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseAlliance._undo_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040039A7 RID: 14759
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040039A8 RID: 14760
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040039A9 RID: 14761
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040039AA RID: 14762
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x040039AB RID: 14763
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x040039AC RID: 14764
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040039AD RID: 14765
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040039AE RID: 14766
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040039AF RID: 14767
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040039B0 RID: 14768
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040039B1 RID: 14769
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040039B2 RID: 14770
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040039B3 RID: 14771
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040039B4 RID: 14772
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
