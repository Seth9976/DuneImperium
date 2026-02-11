using System;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities.Immortality
{
	// Token: 0x02000461 RID: 1121
	public class LisanAlGaibRevealPreviewAbility : RevealAbility
	{
		// Token: 0x06003170 RID: 12656 RVA: 0x001296E0 File Offset: 0x001278E0
		// Note: this type is marked as 'beforefieldinit'.
		static LisanAlGaibRevealPreviewAbility()
		{
			Il2CppClassPointerStore<LisanAlGaibRevealPreviewAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.Immortality", "LisanAlGaibRevealPreviewAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LisanAlGaibRevealPreviewAbility>.NativeClassPtr);
			LisanAlGaibRevealPreviewAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LisanAlGaibRevealPreviewAbility>.NativeClassPtr, "AbilityName");
			LisanAlGaibRevealPreviewAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LisanAlGaibRevealPreviewAbility>.NativeClassPtr, "AbilityID");
			LisanAlGaibRevealPreviewAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LisanAlGaibRevealPreviewAbility>.NativeClassPtr, 100678571);
			LisanAlGaibRevealPreviewAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LisanAlGaibRevealPreviewAbility>.NativeClassPtr, 100678572);
			LisanAlGaibRevealPreviewAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LisanAlGaibRevealPreviewAbility>.NativeClassPtr, 100678573);
			LisanAlGaibRevealPreviewAbility.NativeMethodInfoPtr_GetRevealPreviewValue_Public_Virtual_Dictionary_2_String_Int32_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LisanAlGaibRevealPreviewAbility>.NativeClassPtr, 100678574);
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x00129788 File Offset: 0x00127988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228163, XrefRangeEnd = 228167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LisanAlGaibRevealPreviewAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003172 RID: 12658 RVA: 0x001297D4 File Offset: 0x001279D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228167, XrefRangeEnd = 228183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LisanAlGaibRevealPreviewAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LisanAlGaibRevealPreviewAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LisanAlGaibRevealPreviewAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003173 RID: 12659 RVA: 0x00129820 File Offset: 0x00127A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228183, XrefRangeEnd = 228187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LisanAlGaibRevealPreviewAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LisanAlGaibRevealPreviewAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LisanAlGaibRevealPreviewAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003174 RID: 12660 RVA: 0x00129890 File Offset: 0x00127A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228187, XrefRangeEnd = 228220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Dictionary<string, int> GetRevealPreviewValue(WormMatch match, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LisanAlGaibRevealPreviewAbility.NativeMethodInfoPtr_GetRevealPreviewValue_Public_Virtual_Dictionary_2_String_Int32_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr3) : null;
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x0001154F File Offset: 0x0000F74F
		public LisanAlGaibRevealPreviewAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x06003176 RID: 12662 RVA: 0x00129900 File Offset: 0x00127B00
		// (set) Token: 0x06003177 RID: 12663 RVA: 0x00011558 File Offset: 0x0000F758
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LisanAlGaibRevealPreviewAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LisanAlGaibRevealPreviewAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x06003178 RID: 12664 RVA: 0x00129920 File Offset: 0x00127B20
		// (set) Token: 0x06003179 RID: 12665 RVA: 0x0001156A File Offset: 0x0000F76A
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LisanAlGaibRevealPreviewAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LisanAlGaibRevealPreviewAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002003 RID: 8195
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04002004 RID: 8196
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04002005 RID: 8197
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04002006 RID: 8198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04002007 RID: 8199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04002008 RID: 8200
		private static readonly IntPtr NativeMethodInfoPtr_GetRevealPreviewValue_Public_Virtual_Dictionary_2_String_Int32_WormMatch_WormPlayer_0;

		// Token: 0x02000AB2 RID: 2738
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.Immortality.LisanAlGaibRevealPreviewAbility+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x0600AC4B RID: 44107 RVA: 0x002BC448 File Offset: 0x002BA648
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<LisanAlGaibRevealPreviewAbility.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LisanAlGaibRevealPreviewAbility>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LisanAlGaibRevealPreviewAbility.__c__DisplayClass5_0>.NativeClassPtr);
				LisanAlGaibRevealPreviewAbility.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LisanAlGaibRevealPreviewAbility.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
				LisanAlGaibRevealPreviewAbility.__c__DisplayClass5_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LisanAlGaibRevealPreviewAbility.__c__DisplayClass5_0>.NativeClassPtr, "player");
				LisanAlGaibRevealPreviewAbility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LisanAlGaibRevealPreviewAbility.__c__DisplayClass5_0>.NativeClassPtr, 100678576);
				LisanAlGaibRevealPreviewAbility.__c__DisplayClass5_0.NativeMethodInfoPtr__GetRevealPreviewValue_b__0_Internal_Boolean_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LisanAlGaibRevealPreviewAbility.__c__DisplayClass5_0>.NativeClassPtr, 100678577);
			}

			// Token: 0x0600AC4C RID: 44108 RVA: 0x002BC4C4 File Offset: 0x002BA6C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LisanAlGaibRevealPreviewAbility.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LisanAlGaibRevealPreviewAbility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AC4D RID: 44109 RVA: 0x002BC500 File Offset: 0x002BA700
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228158, XrefRangeEnd = 228163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRevealPreviewValue_b__0(WormPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LisanAlGaibRevealPreviewAbility.__c__DisplayClass5_0.NativeMethodInfoPtr__GetRevealPreviewValue_b__0_Internal_Boolean_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600AC4E RID: 44110 RVA: 0x0004E898 File Offset: 0x0004CA98
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003483 RID: 13443
			// (get) Token: 0x0600AC4F RID: 44111 RVA: 0x002BC550 File Offset: 0x002BA750
			// (set) Token: 0x0600AC50 RID: 44112 RVA: 0x0004E8A1 File Offset: 0x0004CAA1
			public unsafe LisanAlGaibRevealPreviewAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LisanAlGaibRevealPreviewAbility.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LisanAlGaibRevealPreviewAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LisanAlGaibRevealPreviewAbility.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003484 RID: 13444
			// (get) Token: 0x0600AC51 RID: 44113 RVA: 0x002BC580 File Offset: 0x002BA780
			// (set) Token: 0x0600AC52 RID: 44114 RVA: 0x0004E8C0 File Offset: 0x0004CAC0
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LisanAlGaibRevealPreviewAbility.__c__DisplayClass5_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LisanAlGaibRevealPreviewAbility.__c__DisplayClass5_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006CDF RID: 27871
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006CE0 RID: 27872
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04006CE1 RID: 27873
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006CE2 RID: 27874
			private static readonly IntPtr NativeMethodInfoPtr__GetRevealPreviewValue_b__0_Internal_Boolean_WormPlayable_0;
		}
	}
}
