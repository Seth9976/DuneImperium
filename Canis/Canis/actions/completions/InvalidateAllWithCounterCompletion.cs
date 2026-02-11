using System;
using Canis.actions.continuations;
using Canis.data;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.completions
{
	// Token: 0x02000232 RID: 562
	[Serializable]
	public class InvalidateAllWithCounterCompletion : SelectionCompletion
	{
		// Token: 0x06001765 RID: 5989 RVA: 0x0007728C File Offset: 0x0007548C
		// Note: this type is marked as 'beforefieldinit'.
		static InvalidateAllWithCounterCompletion()
		{
			Il2CppClassPointerStore<InvalidateAllWithCounterCompletion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.completions", "InvalidateAllWithCounterCompletion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion>.NativeClassPtr);
			InvalidateAllWithCounterCompletion.NativeFieldInfoPtr_InvalidateOnSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion>.NativeClassPtr, "InvalidateOnSkip");
			InvalidateAllWithCounterCompletion.NativeMethodInfoPtr_CompleteSelection_Public_Virtual_IEnumerable_1_Action_Match_PlayerEntity_PendingSelection_List_1_ActionAcrossTargets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion>.NativeClassPtr, 100668628);
			InvalidateAllWithCounterCompletion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion>.NativeClassPtr, 100668629);
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x000772F8 File Offset: 0x000754F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595537, XrefRangeEnd = 595547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> CompleteSelection(Match match, PlayerEntity selectingPlayer, PendingSelection selection, List<ActionAcrossTargets> ranActions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selection);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ranActions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InvalidateAllWithCounterCompletion.NativeMethodInfoPtr_CompleteSelection_Public_Virtual_IEnumerable_1_Action_Match_PlayerEntity_PendingSelection_List_1_ActionAcrossTargets_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x0007738C File Offset: 0x0007558C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidateAllWithCounterCompletion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x0000B2DF File Offset: 0x000094DF
		public InvalidateAllWithCounterCompletion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x000773C8 File Offset: 0x000755C8
		// (set) Token: 0x0600176A RID: 5994 RVA: 0x0000B2E8 File Offset: 0x000094E8
		public unsafe bool InvalidateOnSkip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion.NativeFieldInfoPtr_InvalidateOnSkip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion.NativeFieldInfoPtr_InvalidateOnSkip)) = value;
			}
		}

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeFieldInfoPtr_InvalidateOnSkip;

		// Token: 0x04000F01 RID: 3841
		private static readonly IntPtr NativeMethodInfoPtr_CompleteSelection_Public_Virtual_IEnumerable_1_Action_Match_PlayerEntity_PendingSelection_List_1_ActionAcrossTargets_0;

		// Token: 0x04000F02 RID: 3842
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200047B RID: 1147
		[ObfuscatedName("Canis.actions.completions.InvalidateAllWithCounterCompletion+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06003375 RID: 13173 RVA: 0x000D2580 File Offset: 0x000D0780
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c>.NativeClassPtr);
				InvalidateAllWithCounterCompletion.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c>.NativeClassPtr, "<>9");
				InvalidateAllWithCounterCompletion.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c>.NativeClassPtr, "<>9__1_0");
				InvalidateAllWithCounterCompletion.__c.NativeFieldInfoPtr___9__1_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c>.NativeClassPtr, "<>9__1_6");
				InvalidateAllWithCounterCompletion.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c>.NativeClassPtr, 100668631);
				InvalidateAllWithCounterCompletion.__c.NativeMethodInfoPtr__CompleteSelection_b__1_0_Internal_Boolean_ActionAcrossTargets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c>.NativeClassPtr, 100668632);
				InvalidateAllWithCounterCompletion.__c.NativeMethodInfoPtr__CompleteSelection_b__1_6_Internal_ActionContinuation_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c>.NativeClassPtr, 100668633);
			}

			// Token: 0x06003376 RID: 13174 RVA: 0x000D2624 File Offset: 0x000D0824
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003377 RID: 13175 RVA: 0x000D2660 File Offset: 0x000D0860
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595244, XrefRangeEnd = 595246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CompleteSelection_b__1_0(ActionAcrossTargets ra)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ra);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion.__c.NativeMethodInfoPtr__CompleteSelection_b__1_0_Internal_Boolean_ActionAcrossTargets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003378 RID: 13176 RVA: 0x000D26B0 File Offset: 0x000D08B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595246, XrefRangeEnd = 595249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActionContinuation _CompleteSelection_b__1_6(PendingSelection _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion.__c.NativeMethodInfoPtr__CompleteSelection_b__1_6_Internal_ActionContinuation_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionContinuation>(intPtr3) : null;
				}
			}

			// Token: 0x06003379 RID: 13177 RVA: 0x00018B85 File Offset: 0x00016D85
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DAF RID: 3503
			// (get) Token: 0x0600337A RID: 13178 RVA: 0x000D2700 File Offset: 0x000D0900
			// (set) Token: 0x0600337B RID: 13179 RVA: 0x00018B8E File Offset: 0x00016D8E
			public unsafe static InvalidateAllWithCounterCompletion.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InvalidateAllWithCounterCompletion.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InvalidateAllWithCounterCompletion.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InvalidateAllWithCounterCompletion.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB0 RID: 3504
			// (get) Token: 0x0600337C RID: 13180 RVA: 0x000D2728 File Offset: 0x000D0928
			// (set) Token: 0x0600337D RID: 13181 RVA: 0x00018BA0 File Offset: 0x00016DA0
			public unsafe static Func<ActionAcrossTargets, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InvalidateAllWithCounterCompletion.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ActionAcrossTargets, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InvalidateAllWithCounterCompletion.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB1 RID: 3505
			// (get) Token: 0x0600337E RID: 13182 RVA: 0x000D2750 File Offset: 0x000D0950
			// (set) Token: 0x0600337F RID: 13183 RVA: 0x00018BB2 File Offset: 0x00016DB2
			public unsafe static Func<PendingSelection, ActionContinuation> __9__1_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InvalidateAllWithCounterCompletion.__c.NativeFieldInfoPtr___9__1_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, ActionContinuation>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InvalidateAllWithCounterCompletion.__c.NativeFieldInfoPtr___9__1_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002022 RID: 8226
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002023 RID: 8227
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04002024 RID: 8228
			private static readonly IntPtr NativeFieldInfoPtr___9__1_6;

			// Token: 0x04002025 RID: 8229
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002026 RID: 8230
			private static readonly IntPtr NativeMethodInfoPtr__CompleteSelection_b__1_0_Internal_Boolean_ActionAcrossTargets_0;

			// Token: 0x04002027 RID: 8231
			private static readonly IntPtr NativeMethodInfoPtr__CompleteSelection_b__1_6_Internal_ActionContinuation_PendingSelection_0;
		}

		// Token: 0x0200047C RID: 1148
		[ObfuscatedName("Canis.actions.completions.InvalidateAllWithCounterCompletion+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06003380 RID: 13184 RVA: 0x000D2778 File Offset: 0x000D0978
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c__DisplayClass1_0>.NativeClassPtr);
				InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeFieldInfoPtr_selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c__DisplayClass1_0>.NativeClassPtr, "selectingPlayer");
				InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c__DisplayClass1_0>.NativeClassPtr, "selection");
				InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c__DisplayClass1_0>.NativeClassPtr, "<>9__2");
				InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c__DisplayClass1_0>.NativeClassPtr, "<>9__4");
				InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c__DisplayClass1_0>.NativeClassPtr, "<>9__5");
				InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeFieldInfoPtr___9__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c__DisplayClass1_0>.NativeClassPtr, "<>9__7");
				InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c__DisplayClass1_0>.NativeClassPtr, 100668634);
				InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeMethodInfoPtr__CompleteSelection_b__1_Internal_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c__DisplayClass1_0>.NativeClassPtr, 100668635);
				InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeMethodInfoPtr__CompleteSelection_b__2_Internal_Boolean_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c__DisplayClass1_0>.NativeClassPtr, 100668636);
				InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeMethodInfoPtr__CompleteSelection_b__3_Internal_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c__DisplayClass1_0>.NativeClassPtr, 100668637);
				InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeMethodInfoPtr__CompleteSelection_b__4_Internal_Boolean_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c__DisplayClass1_0>.NativeClassPtr, 100668638);
				InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeMethodInfoPtr__CompleteSelection_b__5_Internal_Boolean_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c__DisplayClass1_0>.NativeClassPtr, 100668639);
				InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeMethodInfoPtr__CompleteSelection_b__7_Internal_Boolean_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c__DisplayClass1_0>.NativeClassPtr, 100668640);
			}

			// Token: 0x06003381 RID: 13185 RVA: 0x000D28A8 File Offset: 0x000D0AA8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003382 RID: 13186 RVA: 0x000D28E4 File Offset: 0x000D0AE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595249, XrefRangeEnd = 595252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CompleteSelection_b__1(PlayerEntity p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeMethodInfoPtr__CompleteSelection_b__1_Internal_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003383 RID: 13187 RVA: 0x000D2934 File Offset: 0x000D0B34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595252, XrefRangeEnd = 595254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CompleteSelection_b__2(PendingSelection ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeMethodInfoPtr__CompleteSelection_b__2_Internal_Boolean_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003384 RID: 13188 RVA: 0x000D2984 File Offset: 0x000D0B84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595254, XrefRangeEnd = 595257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CompleteSelection_b__3(PlayerEntity p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeMethodInfoPtr__CompleteSelection_b__3_Internal_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003385 RID: 13189 RVA: 0x000D29D4 File Offset: 0x000D0BD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CompleteSelection_b__4(PendingSelection ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeMethodInfoPtr__CompleteSelection_b__4_Internal_Boolean_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003386 RID: 13190 RVA: 0x000D2A24 File Offset: 0x000D0C24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CompleteSelection_b__5(PendingSelection ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeMethodInfoPtr__CompleteSelection_b__5_Internal_Boolean_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003387 RID: 13191 RVA: 0x000D2A74 File Offset: 0x000D0C74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595257, XrefRangeEnd = 595259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CompleteSelection_b__7(PendingSelection ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeMethodInfoPtr__CompleteSelection_b__7_Internal_Boolean_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003388 RID: 13192 RVA: 0x00018BC4 File Offset: 0x00016DC4
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DB2 RID: 3506
			// (get) Token: 0x06003389 RID: 13193 RVA: 0x000D2AC4 File Offset: 0x000D0CC4
			// (set) Token: 0x0600338A RID: 13194 RVA: 0x00018BCD File Offset: 0x00016DCD
			public unsafe PlayerEntity selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeFieldInfoPtr_selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeFieldInfoPtr_selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB3 RID: 3507
			// (get) Token: 0x0600338B RID: 13195 RVA: 0x000D2AF4 File Offset: 0x000D0CF4
			// (set) Token: 0x0600338C RID: 13196 RVA: 0x00018BEC File Offset: 0x00016DEC
			public unsafe PendingSelection selection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeFieldInfoPtr_selection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendingSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB4 RID: 3508
			// (get) Token: 0x0600338D RID: 13197 RVA: 0x000D2B24 File Offset: 0x000D0D24
			// (set) Token: 0x0600338E RID: 13198 RVA: 0x00018C0B File Offset: 0x00016E0B
			public unsafe Func<PendingSelection, bool> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB5 RID: 3509
			// (get) Token: 0x0600338F RID: 13199 RVA: 0x000D2B54 File Offset: 0x000D0D54
			// (set) Token: 0x06003390 RID: 13200 RVA: 0x00018C2A File Offset: 0x00016E2A
			public unsafe Func<PendingSelection, bool> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB6 RID: 3510
			// (get) Token: 0x06003391 RID: 13201 RVA: 0x000D2B84 File Offset: 0x000D0D84
			// (set) Token: 0x06003392 RID: 13202 RVA: 0x00018C49 File Offset: 0x00016E49
			public unsafe Func<PendingSelection, bool> __9__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeFieldInfoPtr___9__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB7 RID: 3511
			// (get) Token: 0x06003393 RID: 13203 RVA: 0x000D2BB4 File Offset: 0x000D0DB4
			// (set) Token: 0x06003394 RID: 13204 RVA: 0x00018C68 File Offset: 0x00016E68
			public unsafe Func<PendingSelection, bool> __9__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeFieldInfoPtr___9__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion.__c__DisplayClass1_0.NativeFieldInfoPtr___9__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002028 RID: 8232
			private static readonly IntPtr NativeFieldInfoPtr_selectingPlayer;

			// Token: 0x04002029 RID: 8233
			private static readonly IntPtr NativeFieldInfoPtr_selection;

			// Token: 0x0400202A RID: 8234
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x0400202B RID: 8235
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x0400202C RID: 8236
			private static readonly IntPtr NativeFieldInfoPtr___9__5;

			// Token: 0x0400202D RID: 8237
			private static readonly IntPtr NativeFieldInfoPtr___9__7;

			// Token: 0x0400202E RID: 8238
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400202F RID: 8239
			private static readonly IntPtr NativeMethodInfoPtr__CompleteSelection_b__1_Internal_Boolean_PlayerEntity_0;

			// Token: 0x04002030 RID: 8240
			private static readonly IntPtr NativeMethodInfoPtr__CompleteSelection_b__2_Internal_Boolean_PendingSelection_0;

			// Token: 0x04002031 RID: 8241
			private static readonly IntPtr NativeMethodInfoPtr__CompleteSelection_b__3_Internal_Boolean_PlayerEntity_0;

			// Token: 0x04002032 RID: 8242
			private static readonly IntPtr NativeMethodInfoPtr__CompleteSelection_b__4_Internal_Boolean_PendingSelection_0;

			// Token: 0x04002033 RID: 8243
			private static readonly IntPtr NativeMethodInfoPtr__CompleteSelection_b__5_Internal_Boolean_PendingSelection_0;

			// Token: 0x04002034 RID: 8244
			private static readonly IntPtr NativeMethodInfoPtr__CompleteSelection_b__7_Internal_Boolean_PendingSelection_0;
		}

		// Token: 0x0200047D RID: 1149
		[ObfuscatedName("Canis.actions.completions.InvalidateAllWithCounterCompletion+<CompleteSelection>d__1")]
		public sealed class _CompleteSelection_d__1 : Object
		{
			// Token: 0x06003395 RID: 13205 RVA: 0x000D2BE4 File Offset: 0x000D0DE4
			// Note: this type is marked as 'beforefieldinit'.
			static _CompleteSelection_d__1()
			{
				Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion>.NativeClassPtr, "<CompleteSelection>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr);
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, "<>1__state");
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, "<>2__current");
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, "<>l__initialThreadId");
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr_selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, "selectingPlayer");
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___3__selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, "<>3__selectingPlayer");
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, "selection");
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___3__selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, "<>3__selection");
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr_ranActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, "ranActions");
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___3__ranActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, "<>3__ranActions");
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, "<>4__this");
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, "match");
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, "<>3__match");
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, "<>8__1");
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, "<>7__wrap1");
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, "<>7__wrap2");
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, 100668641);
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, 100668642);
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, 100668643);
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, 100668644);
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, 100668645);
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, 100668646);
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr___m__Finally4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, 100668647);
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr___m__Finally5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, 100668648);
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr___m__Finally6_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, 100668649);
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, 100668650);
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, 100668651);
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, 100668652);
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, 100668653);
				InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr, 100668654);
			}

			// Token: 0x06003396 RID: 13206 RVA: 0x000D2E54 File Offset: 0x000D1054
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CompleteSelection_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidateAllWithCounterCompletion._CompleteSelection_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003397 RID: 13207 RVA: 0x000D2E9C File Offset: 0x000D109C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595259, XrefRangeEnd = 595282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003398 RID: 13208 RVA: 0x000D2ED0 File Offset: 0x000D10D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595282, XrefRangeEnd = 595502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003399 RID: 13209 RVA: 0x000D2F0C File Offset: 0x000D110C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595502, XrefRangeEnd = 595505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600339A RID: 13210 RVA: 0x000D2F40 File Offset: 0x000D1140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595505, XrefRangeEnd = 595508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600339B RID: 13211 RVA: 0x000D2F74 File Offset: 0x000D1174
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595508, XrefRangeEnd = 595511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600339C RID: 13212 RVA: 0x000D2FA8 File Offset: 0x000D11A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595511, XrefRangeEnd = 595514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr___m__Finally4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600339D RID: 13213 RVA: 0x000D2FDC File Offset: 0x000D11DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595514, XrefRangeEnd = 595517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr___m__Finally5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600339E RID: 13214 RVA: 0x000D3010 File Offset: 0x000D1210
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595517, XrefRangeEnd = 595520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr___m__Finally6_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DC7 RID: 3527
			// (get) Token: 0x0600339F RID: 13215 RVA: 0x000D3044 File Offset: 0x000D1244
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x060033A0 RID: 13216 RVA: 0x000D3084 File Offset: 0x000D1284
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595520, XrefRangeEnd = 595525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DC8 RID: 3528
			// (get) Token: 0x060033A1 RID: 13217 RVA: 0x000D30B8 File Offset: 0x000D12B8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060033A2 RID: 13218 RVA: 0x000D30F8 File Offset: 0x000D12F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595525, XrefRangeEnd = 595537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x060033A3 RID: 13219 RVA: 0x000D3138 File Offset: 0x000D1338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060033A4 RID: 13220 RVA: 0x00018C87 File Offset: 0x00016E87
			public _CompleteSelection_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DB8 RID: 3512
			// (get) Token: 0x060033A5 RID: 13221 RVA: 0x000D3178 File Offset: 0x000D1378
			// (set) Token: 0x060033A6 RID: 13222 RVA: 0x00018C90 File Offset: 0x00016E90
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000DB9 RID: 3513
			// (get) Token: 0x060033A7 RID: 13223 RVA: 0x000D31A0 File Offset: 0x000D13A0
			// (set) Token: 0x060033A8 RID: 13224 RVA: 0x00018CAB File Offset: 0x00016EAB
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DBA RID: 3514
			// (get) Token: 0x060033A9 RID: 13225 RVA: 0x000D31D0 File Offset: 0x000D13D0
			// (set) Token: 0x060033AA RID: 13226 RVA: 0x00018CCA File Offset: 0x00016ECA
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000DBB RID: 3515
			// (get) Token: 0x060033AB RID: 13227 RVA: 0x000D31F8 File Offset: 0x000D13F8
			// (set) Token: 0x060033AC RID: 13228 RVA: 0x00018CE5 File Offset: 0x00016EE5
			public unsafe PlayerEntity selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr_selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr_selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DBC RID: 3516
			// (get) Token: 0x060033AD RID: 13229 RVA: 0x000D3228 File Offset: 0x000D1428
			// (set) Token: 0x060033AE RID: 13230 RVA: 0x00018D04 File Offset: 0x00016F04
			public unsafe PlayerEntity __3__selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___3__selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___3__selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DBD RID: 3517
			// (get) Token: 0x060033AF RID: 13231 RVA: 0x000D3258 File Offset: 0x000D1458
			// (set) Token: 0x060033B0 RID: 13232 RVA: 0x00018D23 File Offset: 0x00016F23
			public unsafe PendingSelection selection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr_selection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendingSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DBE RID: 3518
			// (get) Token: 0x060033B1 RID: 13233 RVA: 0x000D3288 File Offset: 0x000D1488
			// (set) Token: 0x060033B2 RID: 13234 RVA: 0x00018D42 File Offset: 0x00016F42
			public unsafe PendingSelection __3__selection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___3__selection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendingSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___3__selection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DBF RID: 3519
			// (get) Token: 0x060033B3 RID: 13235 RVA: 0x000D32B8 File Offset: 0x000D14B8
			// (set) Token: 0x060033B4 RID: 13236 RVA: 0x00018D61 File Offset: 0x00016F61
			public unsafe List<ActionAcrossTargets> ranActions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr_ranActions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ActionAcrossTargets>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr_ranActions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DC0 RID: 3520
			// (get) Token: 0x060033B5 RID: 13237 RVA: 0x000D32E8 File Offset: 0x000D14E8
			// (set) Token: 0x060033B6 RID: 13238 RVA: 0x00018D80 File Offset: 0x00016F80
			public unsafe List<ActionAcrossTargets> __3__ranActions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___3__ranActions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ActionAcrossTargets>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___3__ranActions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DC1 RID: 3521
			// (get) Token: 0x060033B7 RID: 13239 RVA: 0x000D3318 File Offset: 0x000D1518
			// (set) Token: 0x060033B8 RID: 13240 RVA: 0x00018D9F File Offset: 0x00016F9F
			public unsafe InvalidateAllWithCounterCompletion __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InvalidateAllWithCounterCompletion>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DC2 RID: 3522
			// (get) Token: 0x060033B9 RID: 13241 RVA: 0x000D3348 File Offset: 0x000D1548
			// (set) Token: 0x060033BA RID: 13242 RVA: 0x00018DBE File Offset: 0x00016FBE
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DC3 RID: 3523
			// (get) Token: 0x060033BB RID: 13243 RVA: 0x000D3378 File Offset: 0x000D1578
			// (set) Token: 0x060033BC RID: 13244 RVA: 0x00018DDD File Offset: 0x00016FDD
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DC4 RID: 3524
			// (get) Token: 0x060033BD RID: 13245 RVA: 0x000D33A8 File Offset: 0x000D15A8
			// (set) Token: 0x060033BE RID: 13246 RVA: 0x00018DFC File Offset: 0x00016FFC
			public unsafe InvalidateAllWithCounterCompletion.__c__DisplayClass1_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InvalidateAllWithCounterCompletion.__c__DisplayClass1_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DC5 RID: 3525
			// (get) Token: 0x060033BF RID: 13247 RVA: 0x000D33D8 File Offset: 0x000D15D8
			// (set) Token: 0x060033C0 RID: 13248 RVA: 0x00018E1B File Offset: 0x0001701B
			public unsafe IEnumerator<PlayerEntity> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DC6 RID: 3526
			// (get) Token: 0x060033C1 RID: 13249 RVA: 0x000D3408 File Offset: 0x000D1608
			// (set) Token: 0x060033C2 RID: 13250 RVA: 0x00018E3A File Offset: 0x0001703A
			public unsafe IEnumerator<Action> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvalidateAllWithCounterCompletion._CompleteSelection_d__1.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002035 RID: 8245
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002036 RID: 8246
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002037 RID: 8247
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002038 RID: 8248
			private static readonly IntPtr NativeFieldInfoPtr_selectingPlayer;

			// Token: 0x04002039 RID: 8249
			private static readonly IntPtr NativeFieldInfoPtr___3__selectingPlayer;

			// Token: 0x0400203A RID: 8250
			private static readonly IntPtr NativeFieldInfoPtr_selection;

			// Token: 0x0400203B RID: 8251
			private static readonly IntPtr NativeFieldInfoPtr___3__selection;

			// Token: 0x0400203C RID: 8252
			private static readonly IntPtr NativeFieldInfoPtr_ranActions;

			// Token: 0x0400203D RID: 8253
			private static readonly IntPtr NativeFieldInfoPtr___3__ranActions;

			// Token: 0x0400203E RID: 8254
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400203F RID: 8255
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04002040 RID: 8256
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04002041 RID: 8257
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04002042 RID: 8258
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04002043 RID: 8259
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04002044 RID: 8260
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002045 RID: 8261
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002046 RID: 8262
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002047 RID: 8263
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04002048 RID: 8264
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04002049 RID: 8265
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x0400204A RID: 8266
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally4_Private_Void_0;

			// Token: 0x0400204B RID: 8267
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally5_Private_Void_0;

			// Token: 0x0400204C RID: 8268
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally6_Private_Void_0;

			// Token: 0x0400204D RID: 8269
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400204E RID: 8270
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400204F RID: 8271
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002050 RID: 8272
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002051 RID: 8273
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
