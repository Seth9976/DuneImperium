using System;
using Canis.actions;
using Canis.attributes;
using Canis.context;
using Canis.entities;
using Canis.events;
using Canis.gameLogs;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.abilities.TriggeredAbilities.Skirmish
{
	// Token: 0x0200033F RID: 831
	public class RoundEndMostResourceGainReward : RuleModAbility
	{
		// Token: 0x060021DF RID: 8671 RVA: 0x000DE7EC File Offset: 0x000DC9EC
		// Note: this type is marked as 'beforefieldinit'.
		static RoundEndMostResourceGainReward()
		{
			Il2CppClassPointerStore<RoundEndMostResourceGainReward>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Skirmish", "RoundEndMostResourceGainReward");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundEndMostResourceGainReward>.NativeClassPtr);
			RoundEndMostResourceGainReward.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndMostResourceGainReward>.NativeClassPtr, 100671845);
			RoundEndMostResourceGainReward.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndMostResourceGainReward>.NativeClassPtr, 100671846);
			RoundEndMostResourceGainReward.NativeMethodInfoPtr_get_ComparedResource_Protected_Virtual_New_get_AttributeDefinition_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndMostResourceGainReward>.NativeClassPtr, 100671847);
			RoundEndMostResourceGainReward.NativeMethodInfoPtr_get_GainedResource_Protected_Virtual_New_get_AttributeDefinition_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndMostResourceGainReward>.NativeClassPtr, 100671848);
			RoundEndMostResourceGainReward.NativeMethodInfoPtr_get_Amount_Protected_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndMostResourceGainReward>.NativeClassPtr, 100671849);
			RoundEndMostResourceGainReward.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndMostResourceGainReward>.NativeClassPtr, 100671850);
			RoundEndMostResourceGainReward.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndMostResourceGainReward>.NativeClassPtr, 100671851);
			RoundEndMostResourceGainReward.NativeMethodInfoPtr__IsValidFor_b__8_0_Private_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndMostResourceGainReward>.NativeClassPtr, 100671852);
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x000DE8BC File Offset: 0x000DCABC
		[CallerCount(154)]
		[CachedScanResults(RefRangeStart = 176120, RefRangeEnd = 176274, XrefRangeStart = 176120, XrefRangeEnd = 176274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoundEndMostResourceGainReward(WormMatch m, string name = "", PlayerEntity owningPlayer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundEndMostResourceGainReward>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundEndMostResourceGainReward.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x000DE92C File Offset: 0x000DCB2C
		[CallerCount(314)]
		[CachedScanResults(RefRangeStart = 176275, RefRangeEnd = 176589, XrefRangeStart = 176275, XrefRangeEnd = 176589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoundEndMostResourceGainReward(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundEndMostResourceGainReward>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundEndMostResourceGainReward.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x060021E2 RID: 8674 RVA: 0x000DE99C File Offset: 0x000DCB9C
		public unsafe virtual AttributeDefinition<Nullable<int>> ComparedResource
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179405, XrefRangeEnd = 179409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoundEndMostResourceGainReward.NativeMethodInfoPtr_get_ComparedResource_Protected_Virtual_New_get_AttributeDefinition_1_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x060021E3 RID: 8675 RVA: 0x000DE9E8 File Offset: 0x000DCBE8
		public unsafe virtual AttributeDefinition<Nullable<int>> GainedResource
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179409, XrefRangeEnd = 179413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoundEndMostResourceGainReward.NativeMethodInfoPtr_get_GainedResource_Protected_Virtual_New_get_AttributeDefinition_1_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x060021E4 RID: 8676 RVA: 0x000DEA34 File Offset: 0x000DCC34
		public unsafe virtual int Amount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoundEndMostResourceGainReward.NativeMethodInfoPtr_get_Amount_Protected_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x000DEA7C File Offset: 0x000DCC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179413, XrefRangeEnd = 179429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoundEndMostResourceGainReward.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x000DEAD8 File Offset: 0x000DCCD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179429, XrefRangeEnd = 179437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Canis.actions.Action> BeginExecution(WormActiveAbility activeAbility, WormMatch match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoundEndMostResourceGainReward.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x000DEB58 File Offset: 0x000DCD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179437, XrefRangeEnd = 179441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _IsValidFor_b__8_0(WormPlayer _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundEndMostResourceGainReward.NativeMethodInfoPtr__IsValidFor_b__8_0_Private_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x0000DBC6 File Offset: 0x0000BDC6
		public RoundEndMostResourceGainReward(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001566 RID: 5478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_PlayerEntity_0;

		// Token: 0x04001567 RID: 5479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001568 RID: 5480
		private static readonly IntPtr NativeMethodInfoPtr_get_ComparedResource_Protected_Virtual_New_get_AttributeDefinition_1_Nullable_1_Int32_0;

		// Token: 0x04001569 RID: 5481
		private static readonly IntPtr NativeMethodInfoPtr_get_GainedResource_Protected_Virtual_New_get_AttributeDefinition_1_Nullable_1_Int32_0;

		// Token: 0x0400156A RID: 5482
		private static readonly IntPtr NativeMethodInfoPtr_get_Amount_Protected_Virtual_New_get_Int32_0;

		// Token: 0x0400156B RID: 5483
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x0400156C RID: 5484
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x0400156D RID: 5485
		private static readonly IntPtr NativeMethodInfoPtr__IsValidFor_b__8_0_Private_Int32_WormPlayer_0;

		// Token: 0x02000817 RID: 2071
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.RoundEndMostResourceGainReward+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06007670 RID: 30320 RVA: 0x0021E1B4 File Offset: 0x0021C3B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<RoundEndMostResourceGainReward.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoundEndMostResourceGainReward>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundEndMostResourceGainReward.__c__DisplayClass8_0>.NativeClassPtr);
				RoundEndMostResourceGainReward.__c__DisplayClass8_0.NativeFieldInfoPtr_maxResource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundEndMostResourceGainReward.__c__DisplayClass8_0>.NativeClassPtr, "maxResource");
				RoundEndMostResourceGainReward.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundEndMostResourceGainReward.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				RoundEndMostResourceGainReward.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndMostResourceGainReward.__c__DisplayClass8_0>.NativeClassPtr, 100671853);
				RoundEndMostResourceGainReward.__c__DisplayClass8_0.NativeMethodInfoPtr__IsValidFor_b__1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndMostResourceGainReward.__c__DisplayClass8_0>.NativeClassPtr, 100671854);
			}

			// Token: 0x06007671 RID: 30321 RVA: 0x0021E230 File Offset: 0x0021C430
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundEndMostResourceGainReward.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundEndMostResourceGainReward.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007672 RID: 30322 RVA: 0x0021E26C File Offset: 0x0021C46C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179188, XrefRangeEnd = 179191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsValidFor_b__1(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundEndMostResourceGainReward.__c__DisplayClass8_0.NativeMethodInfoPtr__IsValidFor_b__1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06007673 RID: 30323 RVA: 0x0002FC74 File Offset: 0x0002DE74
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020F8 RID: 8440
			// (get) Token: 0x06007674 RID: 30324 RVA: 0x0021E2BC File Offset: 0x0021C4BC
			// (set) Token: 0x06007675 RID: 30325 RVA: 0x0002FC7D File Offset: 0x0002DE7D
			public unsafe int maxResource
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward.__c__DisplayClass8_0.NativeFieldInfoPtr_maxResource);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward.__c__DisplayClass8_0.NativeFieldInfoPtr_maxResource)) = value;
				}
			}

			// Token: 0x170020F9 RID: 8441
			// (get) Token: 0x06007676 RID: 30326 RVA: 0x0021E2E4 File Offset: 0x0021C4E4
			// (set) Token: 0x06007677 RID: 30327 RVA: 0x0002FC98 File Offset: 0x0002DE98
			public unsafe RoundEndMostResourceGainReward __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundEndMostResourceGainReward>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004C57 RID: 19543
			private static readonly IntPtr NativeFieldInfoPtr_maxResource;

			// Token: 0x04004C58 RID: 19544
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004C59 RID: 19545
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004C5A RID: 19546
			private static readonly IntPtr NativeMethodInfoPtr__IsValidFor_b__1_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x02000818 RID: 2072
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.RoundEndMostResourceGainReward+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x06007678 RID: 30328 RVA: 0x0021E314 File Offset: 0x0021C514
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<RoundEndMostResourceGainReward.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoundEndMostResourceGainReward>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundEndMostResourceGainReward.__c__DisplayClass9_0>.NativeClassPtr);
				RoundEndMostResourceGainReward.__c__DisplayClass9_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundEndMostResourceGainReward.__c__DisplayClass9_0>.NativeClassPtr, "player");
				RoundEndMostResourceGainReward.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndMostResourceGainReward.__c__DisplayClass9_0>.NativeClassPtr, 100671855);
				RoundEndMostResourceGainReward.__c__DisplayClass9_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndMostResourceGainReward.__c__DisplayClass9_0>.NativeClassPtr, 100671856);
			}

			// Token: 0x06007679 RID: 30329 RVA: 0x0021E37C File Offset: 0x0021C57C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundEndMostResourceGainReward.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundEndMostResourceGainReward.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600767A RID: 30330 RVA: 0x0021E3B8 File Offset: 0x0021C5B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179191, XrefRangeEnd = 179356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _BeginExecution_b__0(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundEndMostResourceGainReward.__c__DisplayClass9_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600767B RID: 30331 RVA: 0x0002FCB7 File Offset: 0x0002DEB7
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020FA RID: 8442
			// (get) Token: 0x0600767C RID: 30332 RVA: 0x0021E408 File Offset: 0x0021C608
			// (set) Token: 0x0600767D RID: 30333 RVA: 0x0002FCC0 File Offset: 0x0002DEC0
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward.__c__DisplayClass9_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward.__c__DisplayClass9_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004C5B RID: 19547
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04004C5C RID: 19548
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004C5D RID: 19549
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000819 RID: 2073
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Skirmish.RoundEndMostResourceGainReward+<BeginExecution>d__9")]
		public sealed class _BeginExecution_d__9 : Object
		{
			// Token: 0x0600767E RID: 30334 RVA: 0x0021E438 File Offset: 0x0021C638
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__9()
			{
				Il2CppClassPointerStore<RoundEndMostResourceGainReward._BeginExecution_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoundEndMostResourceGainReward>.NativeClassPtr, "<BeginExecution>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundEndMostResourceGainReward._BeginExecution_d__9>.NativeClassPtr);
				RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundEndMostResourceGainReward._BeginExecution_d__9>.NativeClassPtr, "<>1__state");
				RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundEndMostResourceGainReward._BeginExecution_d__9>.NativeClassPtr, "<>2__current");
				RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundEndMostResourceGainReward._BeginExecution_d__9>.NativeClassPtr, "<>l__initialThreadId");
				RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundEndMostResourceGainReward._BeginExecution_d__9>.NativeClassPtr, "activeAbility");
				RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundEndMostResourceGainReward._BeginExecution_d__9>.NativeClassPtr, "<>3__activeAbility");
				RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundEndMostResourceGainReward._BeginExecution_d__9>.NativeClassPtr, "<>4__this");
				RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundEndMostResourceGainReward._BeginExecution_d__9>.NativeClassPtr, "match");
				RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundEndMostResourceGainReward._BeginExecution_d__9>.NativeClassPtr, "<>3__match");
				RoundEndMostResourceGainReward._BeginExecution_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndMostResourceGainReward._BeginExecution_d__9>.NativeClassPtr, 100671857);
				RoundEndMostResourceGainReward._BeginExecution_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndMostResourceGainReward._BeginExecution_d__9>.NativeClassPtr, 100671858);
				RoundEndMostResourceGainReward._BeginExecution_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndMostResourceGainReward._BeginExecution_d__9>.NativeClassPtr, 100671859);
				RoundEndMostResourceGainReward._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndMostResourceGainReward._BeginExecution_d__9>.NativeClassPtr, 100671860);
				RoundEndMostResourceGainReward._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndMostResourceGainReward._BeginExecution_d__9>.NativeClassPtr, 100671861);
				RoundEndMostResourceGainReward._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndMostResourceGainReward._BeginExecution_d__9>.NativeClassPtr, 100671862);
				RoundEndMostResourceGainReward._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndMostResourceGainReward._BeginExecution_d__9>.NativeClassPtr, 100671863);
				RoundEndMostResourceGainReward._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundEndMostResourceGainReward._BeginExecution_d__9>.NativeClassPtr, 100671864);
			}

			// Token: 0x0600767F RID: 30335 RVA: 0x0021E5A4 File Offset: 0x0021C7A4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundEndMostResourceGainReward._BeginExecution_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06007680 RID: 30336 RVA: 0x0021E5EC File Offset: 0x0021C7EC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007681 RID: 30337 RVA: 0x0021E620 File Offset: 0x0021C820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179356, XrefRangeEnd = 179390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002103 RID: 8451
			// (get) Token: 0x06007682 RID: 30338 RVA: 0x0021E65C File Offset: 0x0021C85C
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06007683 RID: 30339 RVA: 0x0021E69C File Offset: 0x0021C89C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179390, XrefRangeEnd = 179395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002104 RID: 8452
			// (get) Token: 0x06007684 RID: 30340 RVA: 0x0021E6D0 File Offset: 0x0021C8D0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007685 RID: 30341 RVA: 0x0021E710 File Offset: 0x0021C910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179395, XrefRangeEnd = 179405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06007686 RID: 30342 RVA: 0x0021E750 File Offset: 0x0021C950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007687 RID: 30343 RVA: 0x0002FCDF File Offset: 0x0002DEDF
			public _BeginExecution_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020FB RID: 8443
			// (get) Token: 0x06007688 RID: 30344 RVA: 0x0021E790 File Offset: 0x0021C990
			// (set) Token: 0x06007689 RID: 30345 RVA: 0x0002FCE8 File Offset: 0x0002DEE8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170020FC RID: 8444
			// (get) Token: 0x0600768A RID: 30346 RVA: 0x0021E7B8 File Offset: 0x0021C9B8
			// (set) Token: 0x0600768B RID: 30347 RVA: 0x0002FD03 File Offset: 0x0002DF03
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020FD RID: 8445
			// (get) Token: 0x0600768C RID: 30348 RVA: 0x0021E7E8 File Offset: 0x0021C9E8
			// (set) Token: 0x0600768D RID: 30349 RVA: 0x0002FD22 File Offset: 0x0002DF22
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170020FE RID: 8446
			// (get) Token: 0x0600768E RID: 30350 RVA: 0x0021E810 File Offset: 0x0021CA10
			// (set) Token: 0x0600768F RID: 30351 RVA: 0x0002FD3D File Offset: 0x0002DF3D
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170020FF RID: 8447
			// (get) Token: 0x06007690 RID: 30352 RVA: 0x0021E840 File Offset: 0x0021CA40
			// (set) Token: 0x06007691 RID: 30353 RVA: 0x0002FD5C File Offset: 0x0002DF5C
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002100 RID: 8448
			// (get) Token: 0x06007692 RID: 30354 RVA: 0x0021E870 File Offset: 0x0021CA70
			// (set) Token: 0x06007693 RID: 30355 RVA: 0x0002FD7B File Offset: 0x0002DF7B
			public unsafe RoundEndMostResourceGainReward __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundEndMostResourceGainReward>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002101 RID: 8449
			// (get) Token: 0x06007694 RID: 30356 RVA: 0x0021E8A0 File Offset: 0x0021CAA0
			// (set) Token: 0x06007695 RID: 30357 RVA: 0x0002FD9A File Offset: 0x0002DF9A
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002102 RID: 8450
			// (get) Token: 0x06007696 RID: 30358 RVA: 0x0021E8D0 File Offset: 0x0021CAD0
			// (set) Token: 0x06007697 RID: 30359 RVA: 0x0002FDB9 File Offset: 0x0002DFB9
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundEndMostResourceGainReward._BeginExecution_d__9.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004C5E RID: 19550
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004C5F RID: 19551
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004C60 RID: 19552
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004C61 RID: 19553
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04004C62 RID: 19554
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04004C63 RID: 19555
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004C64 RID: 19556
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04004C65 RID: 19557
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04004C66 RID: 19558
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004C67 RID: 19559
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004C68 RID: 19560
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004C69 RID: 19561
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004C6A RID: 19562
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004C6B RID: 19563
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004C6C RID: 19564
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004C6D RID: 19565
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
