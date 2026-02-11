using System;
using Canis;
using Canis.entities;
using Canis.json.events;
using Canis.messages;
using Canis.obfuscation;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.obfuscation
{
	// Token: 0x02000014 RID: 20
	public class AsymmetricTopChildVisible : DescendantsVisibility
	{
		// Token: 0x06000110 RID: 272 RVA: 0x0006E514 File Offset: 0x0006C714
		// Note: this type is marked as 'beforefieldinit'.
		static AsymmetricTopChildVisible()
		{
			Il2CppClassPointerStore<AsymmetricTopChildVisible>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.obfuscation", "AsymmetricTopChildVisible");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsymmetricTopChildVisible>.NativeClassPtr);
			AsymmetricTopChildVisible.NativeFieldInfoPtr_VisibleChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricTopChildVisible>.NativeClassPtr, "VisibleChild");
			AsymmetricTopChildVisible.NativeFieldInfoPtr_VisiblePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricTopChildVisible>.NativeClassPtr, "VisiblePlayer");
			AsymmetricTopChildVisible.NativeMethodInfoPtr_WithVisibleFor_Public_AsymmetricTopChildVisible_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricTopChildVisible>.NativeClassPtr, 100663756);
			AsymmetricTopChildVisible.NativeMethodInfoPtr_GetVisibleChildDescendents_Private_IEnumerable_1_Entity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricTopChildVisible>.NativeClassPtr, 100663757);
			AsymmetricTopChildVisible.NativeMethodInfoPtr_MakeVisibilityForDescendent_Public_Virtual_Visibility_EntityID_EntityID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricTopChildVisible>.NativeClassPtr, 100663758);
			AsymmetricTopChildVisible.NativeMethodInfoPtr_EntityChildrenHidden_Public_Virtual_Boolean_EntityID_AccountID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricTopChildVisible>.NativeClassPtr, 100663759);
			AsymmetricTopChildVisible.NativeMethodInfoPtr_NumChildrenHidden_Public_Virtual_Int32_EntityID_AccountID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricTopChildVisible>.NativeClassPtr, 100663760);
			AsymmetricTopChildVisible.NativeMethodInfoPtr_PostMove_Public_Virtual_IEnumerable_1_NetworkMessageEvent_EntityMoved_EntityID_AccountID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricTopChildVisible>.NativeClassPtr, 100663761);
			AsymmetricTopChildVisible.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricTopChildVisible>.NativeClassPtr, 100663762);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0006E5F8 File Offset: 0x0006C7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31216, XrefRangeEnd = 31218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsymmetricTopChildVisible WithVisibleFor(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricTopChildVisible.NativeMethodInfoPtr_WithVisibleFor_Public_AsymmetricTopChildVisible_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsymmetricTopChildVisible>(intPtr3) : null;
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0006E648 File Offset: 0x0006C848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31218, XrefRangeEnd = 31222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> GetVisibleChildDescendents(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricTopChildVisible.NativeMethodInfoPtr_GetVisibleChildDescendents_Private_IEnumerable_1_Entity_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0006E698 File Offset: 0x0006C898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31222, XrefRangeEnd = 31250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Visibility MakeVisibilityForDescendent(EntityID ancestor, EntityID descendent, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ancestor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(descendent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsymmetricTopChildVisible.NativeMethodInfoPtr_MakeVisibilityForDescendent_Public_Virtual_Visibility_EntityID_EntityID_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Visibility>(intPtr3) : null;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0006E718 File Offset: 0x0006C918
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool EntityChildrenHidden(EntityID parent, AccountID perspective, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(perspective);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsymmetricTopChildVisible.NativeMethodInfoPtr_EntityChildrenHidden_Public_Virtual_Boolean_EntityID_AccountID_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0006E794 File Offset: 0x0006C994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31250, XrefRangeEnd = 31254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int NumChildrenHidden(EntityID parent, AccountID perspective, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(perspective);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsymmetricTopChildVisible.NativeMethodInfoPtr_NumChildrenHidden_Public_Virtual_Int32_EntityID_AccountID_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0006E810 File Offset: 0x0006CA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31254, XrefRangeEnd = 31264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<NetworkMessageEvent> PostMove(EntityMoved entityMoved, EntityID parentID, AccountID perspective, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityMoved);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(perspective);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsymmetricTopChildVisible.NativeMethodInfoPtr_PostMove_Public_Virtual_IEnumerable_1_NetworkMessageEvent_EntityMoved_EntityID_AccountID_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<NetworkMessageEvent>>(intPtr3) : null;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0006E8A4 File Offset: 0x0006CAA4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsymmetricTopChildVisible()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsymmetricTopChildVisible>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricTopChildVisible.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000246B File Offset: 0x0000066B
		public AsymmetricTopChildVisible(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0006E8E0 File Offset: 0x0006CAE0
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00002474 File Offset: 0x00000674
		public unsafe EntityID VisibleChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible.NativeFieldInfoPtr_VisibleChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible.NativeFieldInfoPtr_VisibleChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0006E910 File Offset: 0x0006CB10
		// (set) Token: 0x0600011C RID: 284 RVA: 0x00002493 File Offset: 0x00000693
		public unsafe AccountID VisiblePlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible.NativeFieldInfoPtr_VisiblePlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible.NativeFieldInfoPtr_VisiblePlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeFieldInfoPtr_VisibleChild;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeFieldInfoPtr_VisiblePlayer;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_WithVisibleFor_Public_AsymmetricTopChildVisible_AccountID_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_GetVisibleChildDescendents_Private_IEnumerable_1_Entity_Match_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_MakeVisibilityForDescendent_Public_Virtual_Visibility_EntityID_EntityID_Match_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_EntityChildrenHidden_Public_Virtual_Boolean_EntityID_AccountID_Match_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_NumChildrenHidden_Public_Virtual_Int32_EntityID_AccountID_Match_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_PostMove_Public_Virtual_IEnumerable_1_NetworkMessageEvent_EntityMoved_EntityID_AccountID_Match_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000588 RID: 1416
		[ObfuscatedName("worm.canis.obfuscation.AsymmetricTopChildVisible+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x060043EF RID: 17391 RVA: 0x00180D90 File Offset: 0x0017EF90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<AsymmetricTopChildVisible.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsymmetricTopChildVisible>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsymmetricTopChildVisible.__c__DisplayClass4_0>.NativeClassPtr);
				AsymmetricTopChildVisible.__c__DisplayClass4_0.NativeFieldInfoPtr_descendent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricTopChildVisible.__c__DisplayClass4_0>.NativeClassPtr, "descendent");
				AsymmetricTopChildVisible.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricTopChildVisible.__c__DisplayClass4_0>.NativeClassPtr, 100663763);
				AsymmetricTopChildVisible.__c__DisplayClass4_0.NativeMethodInfoPtr__MakeVisibilityForDescendent_b__0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricTopChildVisible.__c__DisplayClass4_0>.NativeClassPtr, 100663764);
			}

			// Token: 0x060043F0 RID: 17392 RVA: 0x00180DF8 File Offset: 0x0017EFF8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsymmetricTopChildVisible.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricTopChildVisible.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060043F1 RID: 17393 RVA: 0x00180E34 File Offset: 0x0017F034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31189, XrefRangeEnd = 31194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MakeVisibilityForDescendent_b__0(Entity vcd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(vcd);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricTopChildVisible.__c__DisplayClass4_0.NativeMethodInfoPtr__MakeVisibilityForDescendent_b__0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060043F2 RID: 17394 RVA: 0x000163DE File Offset: 0x000145DE
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700101B RID: 4123
			// (get) Token: 0x060043F3 RID: 17395 RVA: 0x00180E84 File Offset: 0x0017F084
			// (set) Token: 0x060043F4 RID: 17396 RVA: 0x000163E7 File Offset: 0x000145E7
			public unsafe EntityID descendent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible.__c__DisplayClass4_0.NativeFieldInfoPtr_descendent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible.__c__DisplayClass4_0.NativeFieldInfoPtr_descendent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002CE7 RID: 11495
			private static readonly IntPtr NativeFieldInfoPtr_descendent;

			// Token: 0x04002CE8 RID: 11496
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002CE9 RID: 11497
			private static readonly IntPtr NativeMethodInfoPtr__MakeVisibilityForDescendent_b__0_Internal_Boolean_Entity_0;
		}

		// Token: 0x02000589 RID: 1417
		[ObfuscatedName("worm.canis.obfuscation.AsymmetricTopChildVisible+<PostMove>d__7")]
		public sealed class _PostMove_d__7 : Object
		{
			// Token: 0x060043F5 RID: 17397 RVA: 0x00180EB4 File Offset: 0x0017F0B4
			// Note: this type is marked as 'beforefieldinit'.
			static _PostMove_d__7()
			{
				Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsymmetricTopChildVisible>.NativeClassPtr, "<PostMove>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr);
				AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr, "<>1__state");
				AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr, "<>2__current");
				AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr, "<>l__initialThreadId");
				AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr_perspective = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr, "perspective");
				AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___3__perspective = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr, "<>3__perspective");
				AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr, "<>4__this");
				AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr, "match");
				AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr, "<>3__match");
				AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr_parentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr, "parentID");
				AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___3__parentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr, "<>3__parentID");
				AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr_entityMoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr, "entityMoved");
				AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___3__entityMoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr, "<>3__entityMoved");
				AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr__newVisibleEntity_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr, "<newVisibleEntity>5__2");
				AsymmetricTopChildVisible._PostMove_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr, 100663765);
				AsymmetricTopChildVisible._PostMove_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr, 100663766);
				AsymmetricTopChildVisible._PostMove_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr, 100663767);
				AsymmetricTopChildVisible._PostMove_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_json_events_NetworkMessageEvent__get_Current_Private_Virtual_Final_New_get_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr, 100663768);
				AsymmetricTopChildVisible._PostMove_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr, 100663769);
				AsymmetricTopChildVisible._PostMove_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr, 100663770);
				AsymmetricTopChildVisible._PostMove_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr, 100663771);
				AsymmetricTopChildVisible._PostMove_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr, 100663772);
			}

			// Token: 0x060043F6 RID: 17398 RVA: 0x00181084 File Offset: 0x0017F284
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PostMove_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsymmetricTopChildVisible._PostMove_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricTopChildVisible._PostMove_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060043F7 RID: 17399 RVA: 0x001810CC File Offset: 0x0017F2CC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricTopChildVisible._PostMove_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060043F8 RID: 17400 RVA: 0x00181100 File Offset: 0x0017F300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31194, XrefRangeEnd = 31199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricTopChildVisible._PostMove_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001029 RID: 4137
			// (get) Token: 0x060043F9 RID: 17401 RVA: 0x0018113C File Offset: 0x0017F33C
			public unsafe NetworkMessageEvent System.Collections.Generic.IEnumerator<Canis.json.events.NetworkMessageEvent>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricTopChildVisible._PostMove_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_json_events_NetworkMessageEvent__get_Current_Private_Virtual_Final_New_get_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr3) : null;
				}
			}

			// Token: 0x060043FA RID: 17402 RVA: 0x0018117C File Offset: 0x0017F37C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31199, XrefRangeEnd = 31204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricTopChildVisible._PostMove_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700102A RID: 4138
			// (get) Token: 0x060043FB RID: 17403 RVA: 0x001811B0 File Offset: 0x0017F3B0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricTopChildVisible._PostMove_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060043FC RID: 17404 RVA: 0x001811F0 File Offset: 0x0017F3F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31204, XrefRangeEnd = 31216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<NetworkMessageEvent> System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricTopChildVisible._PostMove_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<NetworkMessageEvent>>(intPtr3) : null;
			}

			// Token: 0x060043FD RID: 17405 RVA: 0x00181230 File Offset: 0x0017F430
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricTopChildVisible._PostMove_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060043FE RID: 17406 RVA: 0x00016406 File Offset: 0x00014606
			public _PostMove_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700101C RID: 4124
			// (get) Token: 0x060043FF RID: 17407 RVA: 0x00181270 File Offset: 0x0017F470
			// (set) Token: 0x06004400 RID: 17408 RVA: 0x0001640F File Offset: 0x0001460F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700101D RID: 4125
			// (get) Token: 0x06004401 RID: 17409 RVA: 0x00181298 File Offset: 0x0017F498
			// (set) Token: 0x06004402 RID: 17410 RVA: 0x0001642A File Offset: 0x0001462A
			public unsafe NetworkMessageEvent __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700101E RID: 4126
			// (get) Token: 0x06004403 RID: 17411 RVA: 0x001812C8 File Offset: 0x0017F4C8
			// (set) Token: 0x06004404 RID: 17412 RVA: 0x00016449 File Offset: 0x00014649
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700101F RID: 4127
			// (get) Token: 0x06004405 RID: 17413 RVA: 0x001812F0 File Offset: 0x0017F4F0
			// (set) Token: 0x06004406 RID: 17414 RVA: 0x00016464 File Offset: 0x00014664
			public unsafe AccountID perspective
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr_perspective);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr_perspective), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001020 RID: 4128
			// (get) Token: 0x06004407 RID: 17415 RVA: 0x00181320 File Offset: 0x0017F520
			// (set) Token: 0x06004408 RID: 17416 RVA: 0x00016483 File Offset: 0x00014683
			public unsafe AccountID __3__perspective
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___3__perspective);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___3__perspective), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001021 RID: 4129
			// (get) Token: 0x06004409 RID: 17417 RVA: 0x00181350 File Offset: 0x0017F550
			// (set) Token: 0x0600440A RID: 17418 RVA: 0x000164A2 File Offset: 0x000146A2
			public unsafe AsymmetricTopChildVisible __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsymmetricTopChildVisible>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001022 RID: 4130
			// (get) Token: 0x0600440B RID: 17419 RVA: 0x00181380 File Offset: 0x0017F580
			// (set) Token: 0x0600440C RID: 17420 RVA: 0x000164C1 File Offset: 0x000146C1
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001023 RID: 4131
			// (get) Token: 0x0600440D RID: 17421 RVA: 0x001813B0 File Offset: 0x0017F5B0
			// (set) Token: 0x0600440E RID: 17422 RVA: 0x000164E0 File Offset: 0x000146E0
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001024 RID: 4132
			// (get) Token: 0x0600440F RID: 17423 RVA: 0x001813E0 File Offset: 0x0017F5E0
			// (set) Token: 0x06004410 RID: 17424 RVA: 0x000164FF File Offset: 0x000146FF
			public unsafe EntityID parentID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr_parentID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr_parentID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001025 RID: 4133
			// (get) Token: 0x06004411 RID: 17425 RVA: 0x00181410 File Offset: 0x0017F610
			// (set) Token: 0x06004412 RID: 17426 RVA: 0x0001651E File Offset: 0x0001471E
			public unsafe EntityID __3__parentID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___3__parentID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___3__parentID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001026 RID: 4134
			// (get) Token: 0x06004413 RID: 17427 RVA: 0x00181440 File Offset: 0x0017F640
			// (set) Token: 0x06004414 RID: 17428 RVA: 0x0001653D File Offset: 0x0001473D
			public unsafe EntityMoved entityMoved
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr_entityMoved);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityMoved>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr_entityMoved), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001027 RID: 4135
			// (get) Token: 0x06004415 RID: 17429 RVA: 0x00181470 File Offset: 0x0017F670
			// (set) Token: 0x06004416 RID: 17430 RVA: 0x0001655C File Offset: 0x0001475C
			public unsafe EntityMoved __3__entityMoved
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___3__entityMoved);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityMoved>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr___3__entityMoved), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001028 RID: 4136
			// (get) Token: 0x06004417 RID: 17431 RVA: 0x001814A0 File Offset: 0x0017F6A0
			// (set) Token: 0x06004418 RID: 17432 RVA: 0x0001657B File Offset: 0x0001477B
			public unsafe Entity _newVisibleEntity_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr__newVisibleEntity_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricTopChildVisible._PostMove_d__7.NativeFieldInfoPtr__newVisibleEntity_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002CEA RID: 11498
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002CEB RID: 11499
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002CEC RID: 11500
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002CED RID: 11501
			private static readonly IntPtr NativeFieldInfoPtr_perspective;

			// Token: 0x04002CEE RID: 11502
			private static readonly IntPtr NativeFieldInfoPtr___3__perspective;

			// Token: 0x04002CEF RID: 11503
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002CF0 RID: 11504
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04002CF1 RID: 11505
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04002CF2 RID: 11506
			private static readonly IntPtr NativeFieldInfoPtr_parentID;

			// Token: 0x04002CF3 RID: 11507
			private static readonly IntPtr NativeFieldInfoPtr___3__parentID;

			// Token: 0x04002CF4 RID: 11508
			private static readonly IntPtr NativeFieldInfoPtr_entityMoved;

			// Token: 0x04002CF5 RID: 11509
			private static readonly IntPtr NativeFieldInfoPtr___3__entityMoved;

			// Token: 0x04002CF6 RID: 11510
			private static readonly IntPtr NativeFieldInfoPtr__newVisibleEntity_5__2;

			// Token: 0x04002CF7 RID: 11511
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002CF8 RID: 11512
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002CF9 RID: 11513
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002CFA RID: 11514
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_json_events_NetworkMessageEvent__get_Current_Private_Virtual_Final_New_get_NetworkMessageEvent_0;

			// Token: 0x04002CFB RID: 11515
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002CFC RID: 11516
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002CFD RID: 11517
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_json_events_NetworkMessageEvent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_NetworkMessageEvent_0;

			// Token: 0x04002CFE RID: 11518
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
