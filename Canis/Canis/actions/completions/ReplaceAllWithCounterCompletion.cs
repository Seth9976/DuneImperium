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
	// Token: 0x02000233 RID: 563
	[Serializable]
	public class ReplaceAllWithCounterCompletion : SelectionCompletion
	{
		// Token: 0x0600176B RID: 5995 RVA: 0x000773F0 File Offset: 0x000755F0
		// Note: this type is marked as 'beforefieldinit'.
		static ReplaceAllWithCounterCompletion()
		{
			Il2CppClassPointerStore<ReplaceAllWithCounterCompletion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.completions", "ReplaceAllWithCounterCompletion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion>.NativeClassPtr);
			ReplaceAllWithCounterCompletion.NativeMethodInfoPtr_CompleteSelection_Public_Virtual_IEnumerable_1_Action_Match_PlayerEntity_PendingSelection_List_1_ActionAcrossTargets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion>.NativeClassPtr, 100668655);
			ReplaceAllWithCounterCompletion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion>.NativeClassPtr, 100668656);
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x00077448 File Offset: 0x00075648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595795, XrefRangeEnd = 595804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReplaceAllWithCounterCompletion.NativeMethodInfoPtr_CompleteSelection_Public_Virtual_IEnumerable_1_Action_Match_PlayerEntity_PendingSelection_List_1_ActionAcrossTargets_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x000774DC File Offset: 0x000756DC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReplaceAllWithCounterCompletion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceAllWithCounterCompletion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x0000B303 File Offset: 0x00009503
		public ReplaceAllWithCounterCompletion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeMethodInfoPtr_CompleteSelection_Public_Virtual_IEnumerable_1_Action_Match_PlayerEntity_PendingSelection_List_1_ActionAcrossTargets_0;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200047E RID: 1150
		[ObfuscatedName("Canis.actions.completions.ReplaceAllWithCounterCompletion+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060033C3 RID: 13251 RVA: 0x000D3438 File Offset: 0x000D1638
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ReplaceAllWithCounterCompletion.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion.__c>.NativeClassPtr);
				ReplaceAllWithCounterCompletion.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion.__c>.NativeClassPtr, "<>9");
				ReplaceAllWithCounterCompletion.__c.NativeFieldInfoPtr___9__0_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion.__c>.NativeClassPtr, "<>9__0_4");
				ReplaceAllWithCounterCompletion.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion.__c>.NativeClassPtr, 100668658);
				ReplaceAllWithCounterCompletion.__c.NativeMethodInfoPtr__CompleteSelection_b__0_4_Internal_ActionContinuation_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion.__c>.NativeClassPtr, 100668659);
			}

			// Token: 0x060033C4 RID: 13252 RVA: 0x000D34B4 File Offset: 0x000D16B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceAllWithCounterCompletion.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033C5 RID: 13253 RVA: 0x000D34F0 File Offset: 0x000D16F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595547, XrefRangeEnd = 595550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActionContinuation _CompleteSelection_b__0_4(PendingSelection _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceAllWithCounterCompletion.__c.NativeMethodInfoPtr__CompleteSelection_b__0_4_Internal_ActionContinuation_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionContinuation>(intPtr3) : null;
				}
			}

			// Token: 0x060033C6 RID: 13254 RVA: 0x00018E59 File Offset: 0x00017059
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DC9 RID: 3529
			// (get) Token: 0x060033C7 RID: 13255 RVA: 0x000D3540 File Offset: 0x000D1740
			// (set) Token: 0x060033C8 RID: 13256 RVA: 0x00018E62 File Offset: 0x00017062
			public unsafe static ReplaceAllWithCounterCompletion.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReplaceAllWithCounterCompletion.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReplaceAllWithCounterCompletion.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReplaceAllWithCounterCompletion.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DCA RID: 3530
			// (get) Token: 0x060033C9 RID: 13257 RVA: 0x000D3568 File Offset: 0x000D1768
			// (set) Token: 0x060033CA RID: 13258 RVA: 0x00018E74 File Offset: 0x00017074
			public unsafe static Func<PendingSelection, ActionContinuation> __9__0_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ReplaceAllWithCounterCompletion.__c.NativeFieldInfoPtr___9__0_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, ActionContinuation>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ReplaceAllWithCounterCompletion.__c.NativeFieldInfoPtr___9__0_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002052 RID: 8274
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002053 RID: 8275
			private static readonly IntPtr NativeFieldInfoPtr___9__0_4;

			// Token: 0x04002054 RID: 8276
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002055 RID: 8277
			private static readonly IntPtr NativeMethodInfoPtr__CompleteSelection_b__0_4_Internal_ActionContinuation_PendingSelection_0;
		}

		// Token: 0x0200047F RID: 1151
		[ObfuscatedName("Canis.actions.completions.ReplaceAllWithCounterCompletion+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x060033CB RID: 13259 RVA: 0x000D3590 File Offset: 0x000D1790
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<ReplaceAllWithCounterCompletion.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion.__c__DisplayClass0_0>.NativeClassPtr);
				ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion.__c__DisplayClass0_0>.NativeClassPtr, "selection");
				ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion.__c__DisplayClass0_0>.NativeClassPtr, "<>9__1");
				ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion.__c__DisplayClass0_0>.NativeClassPtr, "<>9__2");
				ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion.__c__DisplayClass0_0>.NativeClassPtr, "<>9__3");
				ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion.__c__DisplayClass0_0>.NativeClassPtr, 100668660);
				ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeMethodInfoPtr__CompleteSelection_b__1_Internal_Boolean_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion.__c__DisplayClass0_0>.NativeClassPtr, 100668661);
				ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeMethodInfoPtr__CompleteSelection_b__0_Internal_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion.__c__DisplayClass0_0>.NativeClassPtr, 100668662);
				ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeMethodInfoPtr__CompleteSelection_b__2_Internal_Boolean_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion.__c__DisplayClass0_0>.NativeClassPtr, 100668663);
				ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeMethodInfoPtr__CompleteSelection_b__3_Internal_Boolean_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion.__c__DisplayClass0_0>.NativeClassPtr, 100668664);
			}

			// Token: 0x060033CC RID: 13260 RVA: 0x000D3670 File Offset: 0x000D1870
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033CD RID: 13261 RVA: 0x000D36AC File Offset: 0x000D18AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CompleteSelection_b__1(PendingSelection ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeMethodInfoPtr__CompleteSelection_b__1_Internal_Boolean_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060033CE RID: 13262 RVA: 0x000D36FC File Offset: 0x000D18FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595550, XrefRangeEnd = 595561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CompleteSelection_b__0(PlayerEntity p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeMethodInfoPtr__CompleteSelection_b__0_Internal_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060033CF RID: 13263 RVA: 0x000D374C File Offset: 0x000D194C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595561, XrefRangeEnd = 595563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CompleteSelection_b__2(PendingSelection ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeMethodInfoPtr__CompleteSelection_b__2_Internal_Boolean_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060033D0 RID: 13264 RVA: 0x000D379C File Offset: 0x000D199C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CompleteSelection_b__3(PendingSelection ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeMethodInfoPtr__CompleteSelection_b__3_Internal_Boolean_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060033D1 RID: 13265 RVA: 0x00018E86 File Offset: 0x00017086
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DCB RID: 3531
			// (get) Token: 0x060033D2 RID: 13266 RVA: 0x000D37EC File Offset: 0x000D19EC
			// (set) Token: 0x060033D3 RID: 13267 RVA: 0x00018E8F File Offset: 0x0001708F
			public unsafe PendingSelection selection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeFieldInfoPtr_selection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendingSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DCC RID: 3532
			// (get) Token: 0x060033D4 RID: 13268 RVA: 0x000D381C File Offset: 0x000D1A1C
			// (set) Token: 0x060033D5 RID: 13269 RVA: 0x00018EAE File Offset: 0x000170AE
			public unsafe Func<PendingSelection, bool> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DCD RID: 3533
			// (get) Token: 0x060033D6 RID: 13270 RVA: 0x000D384C File Offset: 0x000D1A4C
			// (set) Token: 0x060033D7 RID: 13271 RVA: 0x00018ECD File Offset: 0x000170CD
			public unsafe Func<PendingSelection, bool> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DCE RID: 3534
			// (get) Token: 0x060033D8 RID: 13272 RVA: 0x000D387C File Offset: 0x000D1A7C
			// (set) Token: 0x060033D9 RID: 13273 RVA: 0x00018EEC File Offset: 0x000170EC
			public unsafe Func<PendingSelection, bool> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion.__c__DisplayClass0_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002056 RID: 8278
			private static readonly IntPtr NativeFieldInfoPtr_selection;

			// Token: 0x04002057 RID: 8279
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04002058 RID: 8280
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04002059 RID: 8281
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x0400205A RID: 8282
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400205B RID: 8283
			private static readonly IntPtr NativeMethodInfoPtr__CompleteSelection_b__1_Internal_Boolean_PendingSelection_0;

			// Token: 0x0400205C RID: 8284
			private static readonly IntPtr NativeMethodInfoPtr__CompleteSelection_b__0_Internal_Boolean_PlayerEntity_0;

			// Token: 0x0400205D RID: 8285
			private static readonly IntPtr NativeMethodInfoPtr__CompleteSelection_b__2_Internal_Boolean_PendingSelection_0;

			// Token: 0x0400205E RID: 8286
			private static readonly IntPtr NativeMethodInfoPtr__CompleteSelection_b__3_Internal_Boolean_PendingSelection_0;
		}

		// Token: 0x02000480 RID: 1152
		[ObfuscatedName("Canis.actions.completions.ReplaceAllWithCounterCompletion+<CompleteSelection>d__0")]
		public sealed class _CompleteSelection_d__0 : Object
		{
			// Token: 0x060033DA RID: 13274 RVA: 0x000D38AC File Offset: 0x000D1AAC
			// Note: this type is marked as 'beforefieldinit'.
			static _CompleteSelection_d__0()
			{
				Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion>.NativeClassPtr, "<CompleteSelection>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr);
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, "<>1__state");
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, "<>2__current");
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, "<>l__initialThreadId");
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, "selection");
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___3__selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, "<>3__selection");
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, "<>4__this");
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, "match");
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, "<>3__match");
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr_selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, "selectingPlayer");
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___3__selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, "<>3__selectingPlayer");
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, "<>8__1");
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, "<>7__wrap1");
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, 100668665);
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, 100668666);
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, 100668667);
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, 100668668);
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, 100668669);
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, 100668670);
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr___m__Finally4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, 100668671);
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr___m__Finally5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, 100668672);
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, 100668673);
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, 100668674);
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, 100668675);
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, 100668676);
				ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr, 100668677);
			}

			// Token: 0x060033DB RID: 13275 RVA: 0x000D3ACC File Offset: 0x000D1CCC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CompleteSelection_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaceAllWithCounterCompletion._CompleteSelection_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060033DC RID: 13276 RVA: 0x000D3B14 File Offset: 0x000D1D14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595563, XrefRangeEnd = 595588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033DD RID: 13277 RVA: 0x000D3B48 File Offset: 0x000D1D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595588, XrefRangeEnd = 595764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060033DE RID: 13278 RVA: 0x000D3B84 File Offset: 0x000D1D84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595764, XrefRangeEnd = 595767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033DF RID: 13279 RVA: 0x000D3BB8 File Offset: 0x000D1DB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595767, XrefRangeEnd = 595770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033E0 RID: 13280 RVA: 0x000D3BEC File Offset: 0x000D1DEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595770, XrefRangeEnd = 595773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033E1 RID: 13281 RVA: 0x000D3C20 File Offset: 0x000D1E20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595773, XrefRangeEnd = 595776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr___m__Finally4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033E2 RID: 13282 RVA: 0x000D3C54 File Offset: 0x000D1E54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595776, XrefRangeEnd = 595779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr___m__Finally5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DDB RID: 3547
			// (get) Token: 0x060033E3 RID: 13283 RVA: 0x000D3C88 File Offset: 0x000D1E88
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x060033E4 RID: 13284 RVA: 0x000D3CC8 File Offset: 0x000D1EC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595779, XrefRangeEnd = 595784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DDC RID: 3548
			// (get) Token: 0x060033E5 RID: 13285 RVA: 0x000D3CFC File Offset: 0x000D1EFC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060033E6 RID: 13286 RVA: 0x000D3D3C File Offset: 0x000D1F3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595784, XrefRangeEnd = 595795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x060033E7 RID: 13287 RVA: 0x000D3D7C File Offset: 0x000D1F7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060033E8 RID: 13288 RVA: 0x00018F0B File Offset: 0x0001710B
			public _CompleteSelection_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DCF RID: 3535
			// (get) Token: 0x060033E9 RID: 13289 RVA: 0x000D3DBC File Offset: 0x000D1FBC
			// (set) Token: 0x060033EA RID: 13290 RVA: 0x00018F14 File Offset: 0x00017114
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000DD0 RID: 3536
			// (get) Token: 0x060033EB RID: 13291 RVA: 0x000D3DE4 File Offset: 0x000D1FE4
			// (set) Token: 0x060033EC RID: 13292 RVA: 0x00018F2F File Offset: 0x0001712F
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DD1 RID: 3537
			// (get) Token: 0x060033ED RID: 13293 RVA: 0x000D3E14 File Offset: 0x000D2014
			// (set) Token: 0x060033EE RID: 13294 RVA: 0x00018F4E File Offset: 0x0001714E
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000DD2 RID: 3538
			// (get) Token: 0x060033EF RID: 13295 RVA: 0x000D3E3C File Offset: 0x000D203C
			// (set) Token: 0x060033F0 RID: 13296 RVA: 0x00018F69 File Offset: 0x00017169
			public unsafe PendingSelection selection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr_selection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendingSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DD3 RID: 3539
			// (get) Token: 0x060033F1 RID: 13297 RVA: 0x000D3E6C File Offset: 0x000D206C
			// (set) Token: 0x060033F2 RID: 13298 RVA: 0x00018F88 File Offset: 0x00017188
			public unsafe PendingSelection __3__selection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___3__selection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendingSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___3__selection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DD4 RID: 3540
			// (get) Token: 0x060033F3 RID: 13299 RVA: 0x000D3E9C File Offset: 0x000D209C
			// (set) Token: 0x060033F4 RID: 13300 RVA: 0x00018FA7 File Offset: 0x000171A7
			public unsafe ReplaceAllWithCounterCompletion __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReplaceAllWithCounterCompletion>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DD5 RID: 3541
			// (get) Token: 0x060033F5 RID: 13301 RVA: 0x000D3ECC File Offset: 0x000D20CC
			// (set) Token: 0x060033F6 RID: 13302 RVA: 0x00018FC6 File Offset: 0x000171C6
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DD6 RID: 3542
			// (get) Token: 0x060033F7 RID: 13303 RVA: 0x000D3EFC File Offset: 0x000D20FC
			// (set) Token: 0x060033F8 RID: 13304 RVA: 0x00018FE5 File Offset: 0x000171E5
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DD7 RID: 3543
			// (get) Token: 0x060033F9 RID: 13305 RVA: 0x000D3F2C File Offset: 0x000D212C
			// (set) Token: 0x060033FA RID: 13306 RVA: 0x00019004 File Offset: 0x00017204
			public unsafe PlayerEntity selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr_selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr_selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DD8 RID: 3544
			// (get) Token: 0x060033FB RID: 13307 RVA: 0x000D3F5C File Offset: 0x000D215C
			// (set) Token: 0x060033FC RID: 13308 RVA: 0x00019023 File Offset: 0x00017223
			public unsafe PlayerEntity __3__selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___3__selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___3__selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DD9 RID: 3545
			// (get) Token: 0x060033FD RID: 13309 RVA: 0x000D3F8C File Offset: 0x000D218C
			// (set) Token: 0x060033FE RID: 13310 RVA: 0x00019042 File Offset: 0x00017242
			public unsafe ReplaceAllWithCounterCompletion.__c__DisplayClass0_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReplaceAllWithCounterCompletion.__c__DisplayClass0_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DDA RID: 3546
			// (get) Token: 0x060033FF RID: 13311 RVA: 0x000D3FBC File Offset: 0x000D21BC
			// (set) Token: 0x06003400 RID: 13312 RVA: 0x00019061 File Offset: 0x00017261
			public unsafe IEnumerator<Action> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplaceAllWithCounterCompletion._CompleteSelection_d__0.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400205F RID: 8287
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002060 RID: 8288
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002061 RID: 8289
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002062 RID: 8290
			private static readonly IntPtr NativeFieldInfoPtr_selection;

			// Token: 0x04002063 RID: 8291
			private static readonly IntPtr NativeFieldInfoPtr___3__selection;

			// Token: 0x04002064 RID: 8292
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002065 RID: 8293
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04002066 RID: 8294
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04002067 RID: 8295
			private static readonly IntPtr NativeFieldInfoPtr_selectingPlayer;

			// Token: 0x04002068 RID: 8296
			private static readonly IntPtr NativeFieldInfoPtr___3__selectingPlayer;

			// Token: 0x04002069 RID: 8297
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400206A RID: 8298
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400206B RID: 8299
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400206C RID: 8300
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400206D RID: 8301
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400206E RID: 8302
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400206F RID: 8303
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04002070 RID: 8304
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x04002071 RID: 8305
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally4_Private_Void_0;

			// Token: 0x04002072 RID: 8306
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally5_Private_Void_0;

			// Token: 0x04002073 RID: 8307
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002074 RID: 8308
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002075 RID: 8309
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002076 RID: 8310
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002077 RID: 8311
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
