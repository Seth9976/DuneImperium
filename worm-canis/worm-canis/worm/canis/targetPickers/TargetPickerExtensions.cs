using System;
using Canis.actions;
using Canis.entities;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lib.canis.Canis.data;
using Networking.selection.messages.outgoing;
using worm.canis.entities;

namespace worm.canis.targetPickers
{
	// Token: 0x0200000E RID: 14
	public static class TargetPickerExtensions : Object
	{
		// Token: 0x060000CB RID: 203 RVA: 0x000022ED File Offset: 0x000004ED
		// Note: this type is marked as 'beforefieldinit'.
		static TargetPickerExtensions()
		{
			Il2CppClassPointerStore<TargetPickerExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.targetPickers", "TargetPickerExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetPickerExtensions>.NativeClassPtr);
			TargetPickerExtensions.NativeMethodInfoPtr_AddHintingAndUnusualSelections_Public_Static_Void_TargetPicker_1_EntityIDTargetResponses_IEnumerable_1_AbilityDefinitionForGame_1_WormMatch_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPickerExtensions>.NativeClassPtr, 100663618);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0006CC04 File Offset: 0x0006AE04
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 30176, RefRangeEnd = 30180, XrefRangeStart = 30032, XrefRangeEnd = 30176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddHintingAndUnusualSelections(this TargetPicker<EntityIDTargetResponses> picker, IEnumerable<AbilityDefinitionForGame<WormMatch>> abilities, WormMatch match, WormPlayer player)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(picker);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(abilities);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPickerExtensions.NativeMethodInfoPtr_AddHintingAndUnusualSelections_Public_Static_Void_TargetPicker_1_EntityIDTargetResponses_IEnumerable_1_AbilityDefinitionForGame_1_WormMatch_WormMatch_WormPlayer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002326 File Offset: 0x00000526
		public TargetPickerExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_AddHintingAndUnusualSelections_Public_Static_Void_TargetPicker_1_EntityIDTargetResponses_IEnumerable_1_AbilityDefinitionForGame_1_WormMatch_WormMatch_WormPlayer_0;

		// Token: 0x0200056B RID: 1387
		[ObfuscatedName("worm.canis.targetPickers.TargetPickerExtensions+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x06004299 RID: 17049 RVA: 0x0017CFE8 File Offset: 0x0017B1E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<TargetPickerExtensions.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetPickerExtensions>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetPickerExtensions.__c__DisplayClass0_0>.NativeClassPtr);
				TargetPickerExtensions.__c__DisplayClass0_0.NativeFieldInfoPtr_warningText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPickerExtensions.__c__DisplayClass0_0>.NativeClassPtr, "warningText");
				TargetPickerExtensions.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPickerExtensions.__c__DisplayClass0_0>.NativeClassPtr, 100663619);
				TargetPickerExtensions.__c__DisplayClass0_0.NativeMethodInfoPtr__AddHintingAndUnusualSelections_b__0_Internal_Boolean_UnusualSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPickerExtensions.__c__DisplayClass0_0>.NativeClassPtr, 100663620);
			}

			// Token: 0x0600429A RID: 17050 RVA: 0x0017D050 File Offset: 0x0017B250
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetPickerExtensions.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPickerExtensions.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600429B RID: 17051 RVA: 0x0017D08C File Offset: 0x0017B28C
			[CallerCount(0)]
			public unsafe bool _AddHintingAndUnusualSelections_b__0(UnusualSelection us)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(us);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPickerExtensions.__c__DisplayClass0_0.NativeMethodInfoPtr__AddHintingAndUnusualSelections_b__0_Internal_Boolean_UnusualSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600429C RID: 17052 RVA: 0x000157ED File Offset: 0x000139ED
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FB6 RID: 4022
			// (get) Token: 0x0600429D RID: 17053 RVA: 0x0017D0DC File Offset: 0x0017B2DC
			// (set) Token: 0x0600429E RID: 17054 RVA: 0x000157F6 File Offset: 0x000139F6
			public unsafe LocalizableTextVariables warningText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPickerExtensions.__c__DisplayClass0_0.NativeFieldInfoPtr_warningText);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPickerExtensions.__c__DisplayClass0_0.NativeFieldInfoPtr_warningText), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C28 RID: 11304
			private static readonly IntPtr NativeFieldInfoPtr_warningText;

			// Token: 0x04002C29 RID: 11305
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C2A RID: 11306
			private static readonly IntPtr NativeMethodInfoPtr__AddHintingAndUnusualSelections_b__0_Internal_Boolean_UnusualSelection_0;
		}
	}
}
