using System;
using Canis;
using canis.archetypes;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.abilities.PlayAbilities;

namespace worm.canis.entities
{
	// Token: 0x0200002D RID: 45
	public class WormIntriguePlayable : WormPlayable
	{
		// Token: 0x06000392 RID: 914 RVA: 0x000776C0 File Offset: 0x000758C0
		// Note: this type is marked as 'beforefieldinit'.
		static WormIntriguePlayable()
		{
			Il2CppClassPointerStore<WormIntriguePlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormIntriguePlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormIntriguePlayable>.NativeClassPtr);
			WormIntriguePlayable.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntriguePlayable>.NativeClassPtr, 100664108);
			WormIntriguePlayable.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntriguePlayable>.NativeClassPtr, 100664109);
			WormIntriguePlayable.NativeMethodInfoPtr_IsBadIntrigue_Public_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntriguePlayable>.NativeClassPtr, 100664110);
			WormIntriguePlayable.NativeMethodInfoPtr_IsInPlay_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntriguePlayable>.NativeClassPtr, 100664111);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00077740 File Offset: 0x00075940
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38681, RefRangeEnd = 38682, XrefRangeStart = 38675, XrefRangeEnd = 38681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormIntriguePlayable(Match m, PlayerEntity owner, Archetype arch)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormIntriguePlayable>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntriguePlayable.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x000777B0 File Offset: 0x000759B0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 35608, RefRangeEnd = 35618, XrefRangeStart = 35608, XrefRangeEnd = 35618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormIntriguePlayable(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormIntriguePlayable>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntriguePlayable.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00077820 File Offset: 0x00075A20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 38704, RefRangeEnd = 38706, XrefRangeStart = 38682, XrefRangeEnd = 38704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBadIntrigue(WormMatch match, WormPlayer player)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntriguePlayable.NativeMethodInfoPtr_IsBadIntrigue_Public_Boolean_WormMatch_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00077880 File Offset: 0x00075A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38706, XrefRangeEnd = 38717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsInPlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormIntriguePlayable.NativeMethodInfoPtr_IsInPlay_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000373C File Offset: 0x0000193C
		public WormIntriguePlayable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Archetype_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_IsBadIntrigue_Public_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_IsInPlay_Public_Virtual_Boolean_0;

		// Token: 0x0200059E RID: 1438
		[ObfuscatedName("worm.canis.entities.WormIntriguePlayable+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x060044FF RID: 17663 RVA: 0x00183D5C File Offset: 0x00181F5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<WormIntriguePlayable.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormIntriguePlayable>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormIntriguePlayable.__c__DisplayClass2_0>.NativeClassPtr);
				WormIntriguePlayable.__c__DisplayClass2_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntriguePlayable.__c__DisplayClass2_0>.NativeClassPtr, "match");
				WormIntriguePlayable.__c__DisplayClass2_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntriguePlayable.__c__DisplayClass2_0>.NativeClassPtr, "player");
				WormIntriguePlayable.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntriguePlayable.__c__DisplayClass2_0>.NativeClassPtr, 100664112);
				WormIntriguePlayable.__c__DisplayClass2_0.NativeMethodInfoPtr__IsBadIntrigue_b__0_Internal_Boolean_IntrigueAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntriguePlayable.__c__DisplayClass2_0>.NativeClassPtr, 100664113);
			}

			// Token: 0x06004500 RID: 17664 RVA: 0x00183DD8 File Offset: 0x00181FD8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormIntriguePlayable.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntriguePlayable.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004501 RID: 17665 RVA: 0x00183E14 File Offset: 0x00182014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38674, XrefRangeEnd = 38675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsBadIntrigue_b__0(IntrigueAbility ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntriguePlayable.__c__DisplayClass2_0.NativeMethodInfoPtr__IsBadIntrigue_b__0_Internal_Boolean_IntrigueAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004502 RID: 17666 RVA: 0x00016D6F File Offset: 0x00014F6F
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700106F RID: 4207
			// (get) Token: 0x06004503 RID: 17667 RVA: 0x00183E64 File Offset: 0x00182064
			// (set) Token: 0x06004504 RID: 17668 RVA: 0x00016D78 File Offset: 0x00014F78
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntriguePlayable.__c__DisplayClass2_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntriguePlayable.__c__DisplayClass2_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001070 RID: 4208
			// (get) Token: 0x06004505 RID: 17669 RVA: 0x00183E94 File Offset: 0x00182094
			// (set) Token: 0x06004506 RID: 17670 RVA: 0x00016D97 File Offset: 0x00014F97
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntriguePlayable.__c__DisplayClass2_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntriguePlayable.__c__DisplayClass2_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D81 RID: 11649
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04002D82 RID: 11650
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002D83 RID: 11651
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D84 RID: 11652
			private static readonly IntPtr NativeMethodInfoPtr__IsBadIntrigue_b__0_Internal_Boolean_IntrigueAbility_0;
		}
	}
}
