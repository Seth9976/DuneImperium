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
	// Token: 0x0200047F RID: 1151
	public class FedaykinDeathCommandoRevealAbility : RevealAbility
	{
		// Token: 0x0600332D RID: 13101 RVA: 0x0013236C File Offset: 0x0013056C
		// Note: this type is marked as 'beforefieldinit'.
		static FedaykinDeathCommandoRevealAbility()
		{
			Il2CppClassPointerStore<FedaykinDeathCommandoRevealAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.BaseSet", "FedaykinDeathCommandoRevealAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FedaykinDeathCommandoRevealAbility>.NativeClassPtr);
			FedaykinDeathCommandoRevealAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FedaykinDeathCommandoRevealAbility>.NativeClassPtr, "AbilityName");
			FedaykinDeathCommandoRevealAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FedaykinDeathCommandoRevealAbility>.NativeClassPtr, "AbilityID");
			FedaykinDeathCommandoRevealAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FedaykinDeathCommandoRevealAbility>.NativeClassPtr, 100679268);
			FedaykinDeathCommandoRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FedaykinDeathCommandoRevealAbility>.NativeClassPtr, 100679269);
			FedaykinDeathCommandoRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FedaykinDeathCommandoRevealAbility>.NativeClassPtr, 100679270);
			FedaykinDeathCommandoRevealAbility.NativeMethodInfoPtr_GetRevealPreviewValue_Public_Virtual_Dictionary_2_String_Int32_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FedaykinDeathCommandoRevealAbility>.NativeClassPtr, 100679271);
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x00132414 File Offset: 0x00130614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234116, XrefRangeEnd = 234120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FedaykinDeathCommandoRevealAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x00132460 File Offset: 0x00130660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234120, XrefRangeEnd = 234136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FedaykinDeathCommandoRevealAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FedaykinDeathCommandoRevealAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FedaykinDeathCommandoRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x001324AC File Offset: 0x001306AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234136, XrefRangeEnd = 234140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FedaykinDeathCommandoRevealAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FedaykinDeathCommandoRevealAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FedaykinDeathCommandoRevealAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x0013251C File Offset: 0x0013071C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234140, XrefRangeEnd = 234177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FedaykinDeathCommandoRevealAbility.NativeMethodInfoPtr_GetRevealPreviewValue_Public_Virtual_Dictionary_2_String_Int32_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr3) : null;
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x00011AF5 File Offset: 0x0000FCF5
		public FedaykinDeathCommandoRevealAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06003333 RID: 13107 RVA: 0x0013258C File Offset: 0x0013078C
		// (set) Token: 0x06003334 RID: 13108 RVA: 0x00011AFE File Offset: 0x0000FCFE
		public new unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FedaykinDeathCommandoRevealAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FedaykinDeathCommandoRevealAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06003335 RID: 13109 RVA: 0x001325AC File Offset: 0x001307AC
		// (set) Token: 0x06003336 RID: 13110 RVA: 0x00011B10 File Offset: 0x0000FD10
		public new unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FedaykinDeathCommandoRevealAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FedaykinDeathCommandoRevealAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002142 RID: 8514
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04002143 RID: 8515
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04002144 RID: 8516
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04002145 RID: 8517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04002146 RID: 8518
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04002147 RID: 8519
		private static readonly IntPtr NativeMethodInfoPtr_GetRevealPreviewValue_Public_Virtual_Dictionary_2_String_Int32_WormMatch_WormPlayer_0;

		// Token: 0x02000AFB RID: 2811
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.FedaykinDeathCommandoRevealAbility+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x0600B186 RID: 45446 RVA: 0x002CB984 File Offset: 0x002C9B84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<FedaykinDeathCommandoRevealAbility.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FedaykinDeathCommandoRevealAbility>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FedaykinDeathCommandoRevealAbility.__c__DisplayClass5_0>.NativeClassPtr);
				FedaykinDeathCommandoRevealAbility.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FedaykinDeathCommandoRevealAbility.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
				FedaykinDeathCommandoRevealAbility.__c__DisplayClass5_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FedaykinDeathCommandoRevealAbility.__c__DisplayClass5_0>.NativeClassPtr, "player");
				FedaykinDeathCommandoRevealAbility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FedaykinDeathCommandoRevealAbility.__c__DisplayClass5_0>.NativeClassPtr, 100679273);
				FedaykinDeathCommandoRevealAbility.__c__DisplayClass5_0.NativeMethodInfoPtr__GetRevealPreviewValue_b__0_Internal_Boolean_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FedaykinDeathCommandoRevealAbility.__c__DisplayClass5_0>.NativeClassPtr, 100679274);
			}

			// Token: 0x0600B187 RID: 45447 RVA: 0x002CBA00 File Offset: 0x002C9C00
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FedaykinDeathCommandoRevealAbility.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FedaykinDeathCommandoRevealAbility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B188 RID: 45448 RVA: 0x002CBA3C File Offset: 0x002C9C3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234111, XrefRangeEnd = 234116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRevealPreviewValue_b__0(WormPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FedaykinDeathCommandoRevealAbility.__c__DisplayClass5_0.NativeMethodInfoPtr__GetRevealPreviewValue_b__0_Internal_Boolean_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600B189 RID: 45449 RVA: 0x00051766 File Offset: 0x0004F966
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003656 RID: 13910
			// (get) Token: 0x0600B18A RID: 45450 RVA: 0x002CBA8C File Offset: 0x002C9C8C
			// (set) Token: 0x0600B18B RID: 45451 RVA: 0x0005176F File Offset: 0x0004F96F
			public unsafe FedaykinDeathCommandoRevealAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FedaykinDeathCommandoRevealAbility.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FedaykinDeathCommandoRevealAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FedaykinDeathCommandoRevealAbility.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003657 RID: 13911
			// (get) Token: 0x0600B18C RID: 45452 RVA: 0x002CBABC File Offset: 0x002C9CBC
			// (set) Token: 0x0600B18D RID: 45453 RVA: 0x0005178E File Offset: 0x0004F98E
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FedaykinDeathCommandoRevealAbility.__c__DisplayClass5_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FedaykinDeathCommandoRevealAbility.__c__DisplayClass5_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006FF9 RID: 28665
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006FFA RID: 28666
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04006FFB RID: 28667
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006FFC RID: 28668
			private static readonly IntPtr NativeMethodInfoPtr__GetRevealPreviewValue_b__0_Internal_Boolean_WormPlayable_0;
		}
	}
}
