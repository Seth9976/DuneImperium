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

namespace worm.canis.abilities.PlayAbilities.BaseSet
{
	// Token: 0x02000494 RID: 1172
	public class SietchReverendMotherRevealAbility : RevealAbility
	{
		// Token: 0x0600345D RID: 13405 RVA: 0x00138280 File Offset: 0x00136480
		// Note: this type is marked as 'beforefieldinit'.
		static SietchReverendMotherRevealAbility()
		{
			Il2CppClassPointerStore<SietchReverendMotherRevealAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.BaseSet", "SietchReverendMotherRevealAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SietchReverendMotherRevealAbility>.NativeClassPtr);
			SietchReverendMotherRevealAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SietchReverendMotherRevealAbility>.NativeClassPtr, "AbilityName");
			SietchReverendMotherRevealAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SietchReverendMotherRevealAbility>.NativeClassPtr, "AbilityID");
			SietchReverendMotherRevealAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SietchReverendMotherRevealAbility>.NativeClassPtr, 100679793);
			SietchReverendMotherRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SietchReverendMotherRevealAbility>.NativeClassPtr, 100679794);
			SietchReverendMotherRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SietchReverendMotherRevealAbility>.NativeClassPtr, 100679795);
			SietchReverendMotherRevealAbility.NativeMethodInfoPtr_GetRevealPreviewValue_Public_Virtual_Dictionary_2_String_Int32_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SietchReverendMotherRevealAbility>.NativeClassPtr, 100679796);
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x00138328 File Offset: 0x00136528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238985, XrefRangeEnd = 238989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SietchReverendMotherRevealAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x00138374 File Offset: 0x00136574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238989, XrefRangeEnd = 239005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SietchReverendMotherRevealAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SietchReverendMotherRevealAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SietchReverendMotherRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x001383C0 File Offset: 0x001365C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239005, XrefRangeEnd = 239009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SietchReverendMotherRevealAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SietchReverendMotherRevealAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SietchReverendMotherRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003461 RID: 13409 RVA: 0x00138430 File Offset: 0x00136630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239009, XrefRangeEnd = 239042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SietchReverendMotherRevealAbility.NativeMethodInfoPtr_GetRevealPreviewValue_Public_Virtual_Dictionary_2_String_Int32_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr3) : null;
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x00011EF1 File Offset: 0x000100F1
		public SietchReverendMotherRevealAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06003463 RID: 13411 RVA: 0x001384A0 File Offset: 0x001366A0
		// (set) Token: 0x06003464 RID: 13412 RVA: 0x00011EFA File Offset: 0x000100FA
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SietchReverendMotherRevealAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SietchReverendMotherRevealAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06003465 RID: 13413 RVA: 0x001384C0 File Offset: 0x001366C0
		// (set) Token: 0x06003466 RID: 13414 RVA: 0x00011F0C File Offset: 0x0001010C
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SietchReverendMotherRevealAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SietchReverendMotherRevealAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002219 RID: 8729
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x0400221A RID: 8730
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x0400221B RID: 8731
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x0400221C RID: 8732
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400221D RID: 8733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400221E RID: 8734
		private static readonly IntPtr NativeMethodInfoPtr_GetRevealPreviewValue_Public_Virtual_Dictionary_2_String_Int32_WormMatch_WormPlayer_0;

		// Token: 0x02000B3B RID: 2875
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.SietchReverendMotherRevealAbility+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x0600B5E0 RID: 46560 RVA: 0x002D8334 File Offset: 0x002D6534
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<SietchReverendMotherRevealAbility.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SietchReverendMotherRevealAbility>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SietchReverendMotherRevealAbility.__c__DisplayClass5_0>.NativeClassPtr);
				SietchReverendMotherRevealAbility.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SietchReverendMotherRevealAbility.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
				SietchReverendMotherRevealAbility.__c__DisplayClass5_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SietchReverendMotherRevealAbility.__c__DisplayClass5_0>.NativeClassPtr, "player");
				SietchReverendMotherRevealAbility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SietchReverendMotherRevealAbility.__c__DisplayClass5_0>.NativeClassPtr, 100679798);
				SietchReverendMotherRevealAbility.__c__DisplayClass5_0.NativeMethodInfoPtr__GetRevealPreviewValue_b__0_Internal_Boolean_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SietchReverendMotherRevealAbility.__c__DisplayClass5_0>.NativeClassPtr, 100679799);
			}

			// Token: 0x0600B5E1 RID: 46561 RVA: 0x002D83B0 File Offset: 0x002D65B0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SietchReverendMotherRevealAbility.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SietchReverendMotherRevealAbility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B5E2 RID: 46562 RVA: 0x002D83EC File Offset: 0x002D65EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238980, XrefRangeEnd = 238985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRevealPreviewValue_b__0(WormPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SietchReverendMotherRevealAbility.__c__DisplayClass5_0.NativeMethodInfoPtr__GetRevealPreviewValue_b__0_Internal_Boolean_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600B5E3 RID: 46563 RVA: 0x00053F15 File Offset: 0x00052115
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170037D8 RID: 14296
			// (get) Token: 0x0600B5E4 RID: 46564 RVA: 0x002D843C File Offset: 0x002D663C
			// (set) Token: 0x0600B5E5 RID: 46565 RVA: 0x00053F1E File Offset: 0x0005211E
			public unsafe SietchReverendMotherRevealAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SietchReverendMotherRevealAbility.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SietchReverendMotherRevealAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SietchReverendMotherRevealAbility.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037D9 RID: 14297
			// (get) Token: 0x0600B5E6 RID: 46566 RVA: 0x002D846C File Offset: 0x002D666C
			// (set) Token: 0x0600B5E7 RID: 46567 RVA: 0x00053F3D File Offset: 0x0005213D
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SietchReverendMotherRevealAbility.__c__DisplayClass5_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SietchReverendMotherRevealAbility.__c__DisplayClass5_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007285 RID: 29317
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007286 RID: 29318
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04007287 RID: 29319
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007288 RID: 29320
			private static readonly IntPtr NativeMethodInfoPtr__GetRevealPreviewValue_b__0_Internal_Boolean_WormPlayable_0;
		}
	}
}
