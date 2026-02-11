using System;
using Canis.actions.continuations;
using Canis.data;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.completions
{
	// Token: 0x02000231 RID: 561
	[Serializable]
	public class DefaultCompletion : SelectionCompletion
	{
		// Token: 0x06001761 RID: 5985 RVA: 0x00077164 File Offset: 0x00075364
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultCompletion()
		{
			Il2CppClassPointerStore<DefaultCompletion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.completions", "DefaultCompletion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultCompletion>.NativeClassPtr);
			DefaultCompletion.NativeMethodInfoPtr_CompleteSelection_Public_Virtual_IEnumerable_1_Action_Match_PlayerEntity_PendingSelection_List_1_ActionAcrossTargets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultCompletion>.NativeClassPtr, 100668624);
			DefaultCompletion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultCompletion>.NativeClassPtr, 100668625);
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x000771BC File Offset: 0x000753BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595218, XrefRangeEnd = 595244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultCompletion.NativeMethodInfoPtr_CompleteSelection_Public_Virtual_IEnumerable_1_Action_Match_PlayerEntity_PendingSelection_List_1_ActionAcrossTargets_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x00077250 File Offset: 0x00075450
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultCompletion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultCompletion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultCompletion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x0000B2D6 File Offset: 0x000094D6
		public DefaultCompletion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeMethodInfoPtr_CompleteSelection_Public_Virtual_IEnumerable_1_Action_Match_PlayerEntity_PendingSelection_List_1_ActionAcrossTargets_0;

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200047A RID: 1146
		[ObfuscatedName("Canis.actions.completions.DefaultCompletion+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x0600336F RID: 13167 RVA: 0x000D245C File Offset: 0x000D065C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<DefaultCompletion.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultCompletion>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultCompletion.__c__DisplayClass0_0>.NativeClassPtr);
				DefaultCompletion.__c__DisplayClass0_0.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultCompletion.__c__DisplayClass0_0>.NativeClassPtr, "selection");
				DefaultCompletion.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultCompletion.__c__DisplayClass0_0>.NativeClassPtr, 100668626);
				DefaultCompletion.__c__DisplayClass0_0.NativeMethodInfoPtr__CompleteSelection_b__0_Internal_Boolean_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultCompletion.__c__DisplayClass0_0>.NativeClassPtr, 100668627);
			}

			// Token: 0x06003370 RID: 13168 RVA: 0x000D24C4 File Offset: 0x000D06C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultCompletion.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultCompletion.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003371 RID: 13169 RVA: 0x000D2500 File Offset: 0x000D0700
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595216, XrefRangeEnd = 595218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CompleteSelection_b__0(PendingSelection ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultCompletion.__c__DisplayClass0_0.NativeMethodInfoPtr__CompleteSelection_b__0_Internal_Boolean_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003372 RID: 13170 RVA: 0x00018B5D File Offset: 0x00016D5D
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DAE RID: 3502
			// (get) Token: 0x06003373 RID: 13171 RVA: 0x000D2550 File Offset: 0x000D0750
			// (set) Token: 0x06003374 RID: 13172 RVA: 0x00018B66 File Offset: 0x00016D66
			public unsafe PendingSelection selection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultCompletion.__c__DisplayClass0_0.NativeFieldInfoPtr_selection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendingSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultCompletion.__c__DisplayClass0_0.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400201F RID: 8223
			private static readonly IntPtr NativeFieldInfoPtr_selection;

			// Token: 0x04002020 RID: 8224
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002021 RID: 8225
			private static readonly IntPtr NativeMethodInfoPtr__CompleteSelection_b__0_Internal_Boolean_PendingSelection_0;
		}
	}
}
