using System;
using Canis;
using canis.archetypes;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.abilities;
using worm.canis.abilities.ConflictAbilities;

namespace worm.canis.entities
{
	// Token: 0x02000025 RID: 37
	public class WormConflictPlayable : WormPlayable
	{
		// Token: 0x0600033A RID: 826 RVA: 0x00075ABC File Offset: 0x00073CBC
		// Note: this type is marked as 'beforefieldinit'.
		static WormConflictPlayable()
		{
			Il2CppClassPointerStore<WormConflictPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormConflictPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictPlayable>.NativeClassPtr);
			WormConflictPlayable.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictPlayable>.NativeClassPtr, 100663991);
			WormConflictPlayable.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictPlayable>.NativeClassPtr, 100663992);
			WormConflictPlayable.NativeMethodInfoPtr_RewardForPlacement_Public_ConflictAbility_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictPlayable>.NativeClassPtr, 100663993);
			WormConflictPlayable.NativeMethodInfoPtr_ConflictValue_Public_Double_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictPlayable>.NativeClassPtr, 100663994);
			WormConflictPlayable.NativeMethodInfoPtr_IsInPlay_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictPlayable>.NativeClassPtr, 100663995);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00075B50 File Offset: 0x00073D50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35606, RefRangeEnd = 35607, XrefRangeStart = 35600, XrefRangeEnd = 35606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormConflictPlayable(Match m, PlayerEntity owner, Archetype arch)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictPlayable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arch);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictPlayable.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00075BC0 File Offset: 0x00073DC0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 35608, RefRangeEnd = 35618, XrefRangeStart = 35607, XrefRangeEnd = 35608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormConflictPlayable(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictPlayable>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictPlayable.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00075C30 File Offset: 0x00073E30
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 35638, RefRangeEnd = 35643, XrefRangeStart = 35618, XrefRangeEnd = 35638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConflictAbility RewardForPlacement(int place)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref place;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictPlayable.NativeMethodInfoPtr_RewardForPlacement_Public_ConflictAbility_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConflictAbility>(intPtr3) : null;
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00075C7C File Offset: 0x00073E7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35661, RefRangeEnd = 35662, XrefRangeStart = 35643, XrefRangeEnd = 35661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double ConflictValue(WormPlayer forPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(forPlayer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictPlayable.NativeMethodInfoPtr_ConflictValue_Public_Double_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00075CCC File Offset: 0x00073ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35662, XrefRangeEnd = 35671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsInPlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConflictPlayable.NativeMethodInfoPtr_IsInPlay_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00003681 File Offset: 0x00001881
		public WormConflictPlayable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Archetype_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_RewardForPlacement_Public_ConflictAbility_Int32_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_ConflictValue_Public_Double_WormPlayer_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_IsInPlay_Public_Virtual_Boolean_0;

		// Token: 0x02000593 RID: 1427
		[ObfuscatedName("worm.canis.entities.WormConflictPlayable+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06004457 RID: 17495 RVA: 0x00181F3C File Offset: 0x0018013C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<WormConflictPlayable.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictPlayable>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictPlayable.__c__DisplayClass2_0>.NativeClassPtr);
				WormConflictPlayable.__c__DisplayClass2_0.NativeFieldInfoPtr_place = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictPlayable.__c__DisplayClass2_0>.NativeClassPtr, "place");
				WormConflictPlayable.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictPlayable.__c__DisplayClass2_0>.NativeClassPtr, 100663996);
				WormConflictPlayable.__c__DisplayClass2_0.NativeMethodInfoPtr__RewardForPlacement_b__0_Internal_Boolean_ConflictAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictPlayable.__c__DisplayClass2_0>.NativeClassPtr, 100663997);
			}

			// Token: 0x06004458 RID: 17496 RVA: 0x00181FA4 File Offset: 0x001801A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictPlayable.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictPlayable.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004459 RID: 17497 RVA: 0x00181FE0 File Offset: 0x001801E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35586, XrefRangeEnd = 35593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RewardForPlacement_b__0(ConflictAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictPlayable.__c__DisplayClass2_0.NativeMethodInfoPtr__RewardForPlacement_b__0_Internal_Boolean_ConflictAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600445A RID: 17498 RVA: 0x000167D2 File Offset: 0x000149D2
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001039 RID: 4153
			// (get) Token: 0x0600445B RID: 17499 RVA: 0x00182030 File Offset: 0x00180230
			// (set) Token: 0x0600445C RID: 17500 RVA: 0x000167DB File Offset: 0x000149DB
			public unsafe int place
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayable.__c__DisplayClass2_0.NativeFieldInfoPtr_place);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayable.__c__DisplayClass2_0.NativeFieldInfoPtr_place)) = value;
				}
			}

			// Token: 0x04002D21 RID: 11553
			private static readonly IntPtr NativeFieldInfoPtr_place;

			// Token: 0x04002D22 RID: 11554
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D23 RID: 11555
			private static readonly IntPtr NativeMethodInfoPtr__RewardForPlacement_b__0_Internal_Boolean_ConflictAbility_0;
		}

		// Token: 0x02000594 RID: 1428
		[ObfuscatedName("worm.canis.entities.WormConflictPlayable+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600445D RID: 17501 RVA: 0x00182058 File Offset: 0x00180258
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<WormConflictPlayable.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictPlayable>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictPlayable.__c__DisplayClass3_0>.NativeClassPtr);
				WormConflictPlayable.__c__DisplayClass3_0.NativeFieldInfoPtr_forPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictPlayable.__c__DisplayClass3_0>.NativeClassPtr, "forPlayer");
				WormConflictPlayable.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictPlayable.__c__DisplayClass3_0>.NativeClassPtr, 100663998);
				WormConflictPlayable.__c__DisplayClass3_0.NativeMethodInfoPtr__ConflictValue_b__0_Internal_Double_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictPlayable.__c__DisplayClass3_0>.NativeClassPtr, 100663999);
			}

			// Token: 0x0600445E RID: 17502 RVA: 0x001820C0 File Offset: 0x001802C0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictPlayable.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictPlayable.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600445F RID: 17503 RVA: 0x001820FC File Offset: 0x001802FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35593, XrefRangeEnd = 35600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _ConflictValue_b__0(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictPlayable.__c__DisplayClass3_0.NativeMethodInfoPtr__ConflictValue_b__0_Internal_Double_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004460 RID: 17504 RVA: 0x000167F6 File Offset: 0x000149F6
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700103A RID: 4154
			// (get) Token: 0x06004461 RID: 17505 RVA: 0x0018214C File Offset: 0x0018034C
			// (set) Token: 0x06004462 RID: 17506 RVA: 0x000167FF File Offset: 0x000149FF
			public unsafe WormPlayer forPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayable.__c__DisplayClass3_0.NativeFieldInfoPtr_forPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayable.__c__DisplayClass3_0.NativeFieldInfoPtr_forPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D24 RID: 11556
			private static readonly IntPtr NativeFieldInfoPtr_forPlayer;

			// Token: 0x04002D25 RID: 11557
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D26 RID: 11558
			private static readonly IntPtr NativeMethodInfoPtr__ConflictValue_b__0_Internal_Double_WormAbilityDefinition_0;
		}
	}
}
