using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.gameLogs;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x0200027C RID: 636
	public class ResolveTestOfHumanity : global::Canis.actions.Action
	{
		// Token: 0x06001AB2 RID: 6834 RVA: 0x000C0A40 File Offset: 0x000BEC40
		// Note: this type is marked as 'beforefieldinit'.
		static ResolveTestOfHumanity()
		{
			Il2CppClassPointerStore<ResolveTestOfHumanity>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "ResolveTestOfHumanity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveTestOfHumanity>.NativeClassPtr);
			ResolveTestOfHumanity.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveTestOfHumanity>.NativeClassPtr, "wormMatch");
			ResolveTestOfHumanity.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveTestOfHumanity>.NativeClassPtr, "player");
			ResolveTestOfHumanity.NativeFieldInfoPtr_intResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveTestOfHumanity>.NativeClassPtr, "intResponse");
			ResolveTestOfHumanity.NativeFieldInfoPtr_resolved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveTestOfHumanity>.NativeClassPtr, "resolved");
			ResolveTestOfHumanity.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveTestOfHumanity>.NativeClassPtr, 100668473);
			ResolveTestOfHumanity.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveTestOfHumanity>.NativeClassPtr, 100668474);
			ResolveTestOfHumanity.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveTestOfHumanity>.NativeClassPtr, 100668475);
			ResolveTestOfHumanity.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveTestOfHumanity>.NativeClassPtr, 100668476);
			ResolveTestOfHumanity.NativeMethodInfoPtr_Deserialize_Public_Static_ResolveTestOfHumanity_SerializedResolveTestOfHumanity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveTestOfHumanity>.NativeClassPtr, 100668477);
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x000C0B24 File Offset: 0x000BED24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 143859, RefRangeEnd = 143862, XrefRangeStart = 143856, XrefRangeEnd = 143859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResolveTestOfHumanity(WormPlayer player, WormMatch m, int intResponse = -1, bool resolved = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveTestOfHumanity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intResponse;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolved;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveTestOfHumanity.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x000C0BA0 File Offset: 0x000BEDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143862, XrefRangeEnd = 143868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResolveTestOfHumanity.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x000C0BEC File Offset: 0x000BEDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143868, XrefRangeEnd = 143890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HandleReturningAction(global::Canis.actions.Action returningAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResolveTestOfHumanity.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x000C0C3C File Offset: 0x000BEE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143890, XrefRangeEnd = 143895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResolveTestOfHumanity.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x000C0C98 File Offset: 0x000BEE98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143910, RefRangeEnd = 143911, XrefRangeStart = 143895, XrefRangeEnd = 143910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ResolveTestOfHumanity Deserialize(SerializedResolveTestOfHumanity serialized, Match match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveTestOfHumanity.NativeMethodInfoPtr_Deserialize_Public_Static_ResolveTestOfHumanity_SerializedResolveTestOfHumanity_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResolveTestOfHumanity>(intPtr3) : null;
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0000B771 File Offset: 0x00009971
		public ResolveTestOfHumanity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001AB9 RID: 6841 RVA: 0x000C0CF0 File Offset: 0x000BEEF0
		// (set) Token: 0x06001ABA RID: 6842 RVA: 0x0000B77A File Offset: 0x0000997A
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveTestOfHumanity.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveTestOfHumanity.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001ABB RID: 6843 RVA: 0x000C0D20 File Offset: 0x000BEF20
		// (set) Token: 0x06001ABC RID: 6844 RVA: 0x0000B799 File Offset: 0x00009999
		public unsafe WormPlayer player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveTestOfHumanity.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveTestOfHumanity.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001ABD RID: 6845 RVA: 0x000C0D50 File Offset: 0x000BEF50
		// (set) Token: 0x06001ABE RID: 6846 RVA: 0x0000B7B8 File Offset: 0x000099B8
		public unsafe int intResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveTestOfHumanity.NativeFieldInfoPtr_intResponse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveTestOfHumanity.NativeFieldInfoPtr_intResponse)) = value;
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001ABF RID: 6847 RVA: 0x000C0D78 File Offset: 0x000BEF78
		// (set) Token: 0x06001AC0 RID: 6848 RVA: 0x0000B7D3 File Offset: 0x000099D3
		public unsafe bool resolved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveTestOfHumanity.NativeFieldInfoPtr_resolved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveTestOfHumanity.NativeFieldInfoPtr_resolved)) = value;
			}
		}

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeFieldInfoPtr_intResponse;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeFieldInfoPtr_resolved;

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_Int32_Boolean_0;

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0;

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_ResolveTestOfHumanity_SerializedResolveTestOfHumanity_Match_0;

		// Token: 0x020006C3 RID: 1731
		[ObfuscatedName("worm.canis.actions.ResolveTestOfHumanity+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005B9E RID: 23454 RVA: 0x001CB7CC File Offset: 0x001C99CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ResolveTestOfHumanity.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResolveTestOfHumanity>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveTestOfHumanity.__c>.NativeClassPtr);
				ResolveTestOfHumanity.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveTestOfHumanity.__c>.NativeClassPtr, "<>9");
				ResolveTestOfHumanity.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveTestOfHumanity.__c>.NativeClassPtr, "<>9__5_0");
				ResolveTestOfHumanity.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveTestOfHumanity.__c>.NativeClassPtr, 100668479);
				ResolveTestOfHumanity.__c.NativeMethodInfoPtr__execute_b__5_0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveTestOfHumanity.__c>.NativeClassPtr, 100668480);
			}

			// Token: 0x06005B9F RID: 23455 RVA: 0x001CB848 File Offset: 0x001C9A48
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveTestOfHumanity.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveTestOfHumanity.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005BA0 RID: 23456 RVA: 0x001CB884 File Offset: 0x001C9A84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143769, XrefRangeEnd = 143776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _execute_b__5_0(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveTestOfHumanity.__c.NativeMethodInfoPtr__execute_b__5_0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x06005BA1 RID: 23457 RVA: 0x00021FBB File Offset: 0x000201BB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017BF RID: 6079
			// (get) Token: 0x06005BA2 RID: 23458 RVA: 0x001CB8D4 File Offset: 0x001C9AD4
			// (set) Token: 0x06005BA3 RID: 23459 RVA: 0x00021FC4 File Offset: 0x000201C4
			public unsafe static ResolveTestOfHumanity.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResolveTestOfHumanity.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveTestOfHumanity.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResolveTestOfHumanity.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017C0 RID: 6080
			// (get) Token: 0x06005BA4 RID: 23460 RVA: 0x001CB8FC File Offset: 0x001C9AFC
			// (set) Token: 0x06005BA5 RID: 23461 RVA: 0x00021FD6 File Offset: 0x000201D6
			public unsafe static Func<GameLogBuilder, GameLogBuilder> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResolveTestOfHumanity.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameLogBuilder, GameLogBuilder>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResolveTestOfHumanity.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B98 RID: 15256
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003B99 RID: 15257
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04003B9A RID: 15258
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003B9B RID: 15259
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__5_0_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x020006C4 RID: 1732
		[ObfuscatedName("worm.canis.actions.ResolveTestOfHumanity+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06005BA6 RID: 23462 RVA: 0x001CB924 File Offset: 0x001C9B24
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<ResolveTestOfHumanity.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResolveTestOfHumanity>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveTestOfHumanity.__c__DisplayClass6_0>.NativeClassPtr);
				ResolveTestOfHumanity.__c__DisplayClass6_0.NativeFieldInfoPtr_discard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveTestOfHumanity.__c__DisplayClass6_0>.NativeClassPtr, "discard");
				ResolveTestOfHumanity.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveTestOfHumanity.__c__DisplayClass6_0>.NativeClassPtr, 100668481);
				ResolveTestOfHumanity.__c__DisplayClass6_0.NativeMethodInfoPtr__HandleReturningAction_b__0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveTestOfHumanity.__c__DisplayClass6_0>.NativeClassPtr, 100668482);
			}

			// Token: 0x06005BA7 RID: 23463 RVA: 0x001CB98C File Offset: 0x001C9B8C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveTestOfHumanity.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveTestOfHumanity.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005BA8 RID: 23464 RVA: 0x001CB9C8 File Offset: 0x001C9BC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143776, XrefRangeEnd = 143784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _HandleReturningAction_b__0(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveTestOfHumanity.__c__DisplayClass6_0.NativeMethodInfoPtr__HandleReturningAction_b__0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x06005BA9 RID: 23465 RVA: 0x00021FE8 File Offset: 0x000201E8
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017C1 RID: 6081
			// (get) Token: 0x06005BAA RID: 23466 RVA: 0x001CBA18 File Offset: 0x001C9C18
			// (set) Token: 0x06005BAB RID: 23467 RVA: 0x00021FF1 File Offset: 0x000201F1
			public unsafe Discard discard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveTestOfHumanity.__c__DisplayClass6_0.NativeFieldInfoPtr_discard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Discard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveTestOfHumanity.__c__DisplayClass6_0.NativeFieldInfoPtr_discard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B9C RID: 15260
			private static readonly IntPtr NativeFieldInfoPtr_discard;

			// Token: 0x04003B9D RID: 15261
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003B9E RID: 15262
			private static readonly IntPtr NativeMethodInfoPtr__HandleReturningAction_b__0_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x020006C5 RID: 1733
		[ObfuscatedName("worm.canis.actions.ResolveTestOfHumanity+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x06005BAC RID: 23468 RVA: 0x001CBA48 File Offset: 0x001C9C48
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<ResolveTestOfHumanity._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResolveTestOfHumanity>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveTestOfHumanity._execute_d__5>.NativeClassPtr);
				ResolveTestOfHumanity._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveTestOfHumanity._execute_d__5>.NativeClassPtr, "<>1__state");
				ResolveTestOfHumanity._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveTestOfHumanity._execute_d__5>.NativeClassPtr, "<>2__current");
				ResolveTestOfHumanity._execute_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveTestOfHumanity._execute_d__5>.NativeClassPtr, "<>l__initialThreadId");
				ResolveTestOfHumanity._execute_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveTestOfHumanity._execute_d__5>.NativeClassPtr, "<>4__this");
				ResolveTestOfHumanity._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveTestOfHumanity._execute_d__5>.NativeClassPtr, 100668483);
				ResolveTestOfHumanity._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveTestOfHumanity._execute_d__5>.NativeClassPtr, 100668484);
				ResolveTestOfHumanity._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveTestOfHumanity._execute_d__5>.NativeClassPtr, 100668485);
				ResolveTestOfHumanity._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveTestOfHumanity._execute_d__5>.NativeClassPtr, 100668486);
				ResolveTestOfHumanity._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveTestOfHumanity._execute_d__5>.NativeClassPtr, 100668487);
				ResolveTestOfHumanity._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveTestOfHumanity._execute_d__5>.NativeClassPtr, 100668488);
				ResolveTestOfHumanity._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveTestOfHumanity._execute_d__5>.NativeClassPtr, 100668489);
				ResolveTestOfHumanity._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveTestOfHumanity._execute_d__5>.NativeClassPtr, 100668490);
			}

			// Token: 0x06005BAD RID: 23469 RVA: 0x001CBB64 File Offset: 0x001C9D64
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveTestOfHumanity._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveTestOfHumanity._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005BAE RID: 23470 RVA: 0x001CBBAC File Offset: 0x001C9DAC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveTestOfHumanity._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005BAF RID: 23471 RVA: 0x001CBBE0 File Offset: 0x001C9DE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143784, XrefRangeEnd = 143849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveTestOfHumanity._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170017C6 RID: 6086
			// (get) Token: 0x06005BB0 RID: 23472 RVA: 0x001CBC1C File Offset: 0x001C9E1C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveTestOfHumanity._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005BB1 RID: 23473 RVA: 0x001CBC5C File Offset: 0x001C9E5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143849, XrefRangeEnd = 143854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveTestOfHumanity._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170017C7 RID: 6087
			// (get) Token: 0x06005BB2 RID: 23474 RVA: 0x001CBC90 File Offset: 0x001C9E90
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveTestOfHumanity._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005BB3 RID: 23475 RVA: 0x001CBCD0 File Offset: 0x001C9ED0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143854, XrefRangeEnd = 143856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveTestOfHumanity._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005BB4 RID: 23476 RVA: 0x001CBD10 File Offset: 0x001C9F10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolveTestOfHumanity._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005BB5 RID: 23477 RVA: 0x00022010 File Offset: 0x00020210
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170017C2 RID: 6082
			// (get) Token: 0x06005BB6 RID: 23478 RVA: 0x001CBD50 File Offset: 0x001C9F50
			// (set) Token: 0x06005BB7 RID: 23479 RVA: 0x00022019 File Offset: 0x00020219
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveTestOfHumanity._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveTestOfHumanity._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170017C3 RID: 6083
			// (get) Token: 0x06005BB8 RID: 23480 RVA: 0x001CBD78 File Offset: 0x001C9F78
			// (set) Token: 0x06005BB9 RID: 23481 RVA: 0x00022034 File Offset: 0x00020234
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveTestOfHumanity._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveTestOfHumanity._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170017C4 RID: 6084
			// (get) Token: 0x06005BBA RID: 23482 RVA: 0x001CBDA8 File Offset: 0x001C9FA8
			// (set) Token: 0x06005BBB RID: 23483 RVA: 0x00022053 File Offset: 0x00020253
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveTestOfHumanity._execute_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveTestOfHumanity._execute_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170017C5 RID: 6085
			// (get) Token: 0x06005BBC RID: 23484 RVA: 0x001CBDD0 File Offset: 0x001C9FD0
			// (set) Token: 0x06005BBD RID: 23485 RVA: 0x0002206E File Offset: 0x0002026E
			public unsafe ResolveTestOfHumanity __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveTestOfHumanity._execute_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolveTestOfHumanity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolveTestOfHumanity._execute_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003B9F RID: 15263
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003BA0 RID: 15264
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003BA1 RID: 15265
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003BA2 RID: 15266
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003BA3 RID: 15267
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003BA4 RID: 15268
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003BA5 RID: 15269
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003BA6 RID: 15270
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003BA7 RID: 15271
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003BA8 RID: 15272
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003BA9 RID: 15273
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003BAA RID: 15274
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
