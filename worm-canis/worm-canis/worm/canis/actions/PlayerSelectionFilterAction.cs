using System;
using Canis;
using Canis.actions;
using Canis.attributes;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.actions
{
	// Token: 0x02000270 RID: 624
	public class PlayerSelectionFilterAction : global::Canis.actions.Action
	{
		// Token: 0x06001A5D RID: 6749 RVA: 0x000BF684 File Offset: 0x000BD884
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerSelectionFilterAction()
		{
			Il2CppClassPointerStore<PlayerSelectionFilterAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "PlayerSelectionFilterAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSelectionFilterAction>.NativeClassPtr);
			PlayerSelectionFilterAction.NativeFieldInfoPtr_attrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFilterAction>.NativeClassPtr, "attrs");
			PlayerSelectionFilterAction.NativeFieldInfoPtr_overrideTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFilterAction>.NativeClassPtr, "overrideTarget");
			PlayerSelectionFilterAction.NativeFieldInfoPtr_entityIDAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFilterAction>.NativeClassPtr, "entityIDAttributes");
			PlayerSelectionFilterAction.NativeFieldInfoPtr_listEntityIDAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFilterAction>.NativeClassPtr, "listEntityIDAttributes");
			PlayerSelectionFilterAction.NativeFieldInfoPtr_intAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFilterAction>.NativeClassPtr, "intAttributes");
			PlayerSelectionFilterAction.NativeFieldInfoPtr_boolAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFilterAction>.NativeClassPtr, "boolAttributes");
			PlayerSelectionFilterAction.NativeMethodInfoPtr__ctor_Public_Void_List_1_IAttribute_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFilterAction>.NativeClassPtr, 100668321);
			PlayerSelectionFilterAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFilterAction>.NativeClassPtr, 100668322);
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x000BF754 File Offset: 0x000BD954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142035, RefRangeEnd = 142036, XrefRangeStart = 141945, XrefRangeEnd = 142035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerSelectionFilterAction(List<IAttribute> attrs, Match m, Entity overrideTarget = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSelectionFilterAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideTarget);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFilterAction.NativeMethodInfoPtr__ctor_Public_Void_List_1_IAttribute_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x000BF7C4 File Offset: 0x000BD9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142036, XrefRangeEnd = 142042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSelectionFilterAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x0000B57A File Offset: 0x0000977A
		public PlayerSelectionFilterAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001A61 RID: 6753 RVA: 0x000BF810 File Offset: 0x000BDA10
		// (set) Token: 0x06001A62 RID: 6754 RVA: 0x0000B583 File Offset: 0x00009783
		public unsafe List<IAttribute> attrs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction.NativeFieldInfoPtr_attrs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IAttribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction.NativeFieldInfoPtr_attrs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001A63 RID: 6755 RVA: 0x000BF840 File Offset: 0x000BDA40
		// (set) Token: 0x06001A64 RID: 6756 RVA: 0x0000B5A2 File Offset: 0x000097A2
		public unsafe Entity overrideTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction.NativeFieldInfoPtr_overrideTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction.NativeFieldInfoPtr_overrideTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001A65 RID: 6757 RVA: 0x000BF870 File Offset: 0x000BDA70
		// (set) Token: 0x06001A66 RID: 6758 RVA: 0x0000B5C1 File Offset: 0x000097C1
		public unsafe List<AttributeDefinition<EntityID>> entityIDAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction.NativeFieldInfoPtr_entityIDAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AttributeDefinition<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction.NativeFieldInfoPtr_entityIDAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x000BF8A0 File Offset: 0x000BDAA0
		// (set) Token: 0x06001A68 RID: 6760 RVA: 0x0000B5E0 File Offset: 0x000097E0
		public unsafe List<AttributeDefinition<List<EntityID>>> listEntityIDAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction.NativeFieldInfoPtr_listEntityIDAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AttributeDefinition<List<EntityID>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction.NativeFieldInfoPtr_listEntityIDAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x000BF8D0 File Offset: 0x000BDAD0
		// (set) Token: 0x06001A6A RID: 6762 RVA: 0x0000B5FF File Offset: 0x000097FF
		public unsafe List<AttributeDefinition<Nullable<int>>> intAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction.NativeFieldInfoPtr_intAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AttributeDefinition<Nullable<int>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction.NativeFieldInfoPtr_intAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001A6B RID: 6763 RVA: 0x000BF900 File Offset: 0x000BDB00
		// (set) Token: 0x06001A6C RID: 6764 RVA: 0x0000B61E File Offset: 0x0000981E
		public unsafe List<AttributeDefinition<Nullable<bool>>> boolAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction.NativeFieldInfoPtr_boolAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AttributeDefinition<Nullable<bool>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction.NativeFieldInfoPtr_boolAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeFieldInfoPtr_attrs;

		// Token: 0x04001047 RID: 4167
		private static readonly IntPtr NativeFieldInfoPtr_overrideTarget;

		// Token: 0x04001048 RID: 4168
		private static readonly IntPtr NativeFieldInfoPtr_entityIDAttributes;

		// Token: 0x04001049 RID: 4169
		private static readonly IntPtr NativeFieldInfoPtr_listEntityIDAttributes;

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeFieldInfoPtr_intAttributes;

		// Token: 0x0400104B RID: 4171
		private static readonly IntPtr NativeFieldInfoPtr_boolAttributes;

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_IAttribute_Match_Entity_0;

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x020006B0 RID: 1712
		[ObfuscatedName("worm.canis.actions.PlayerSelectionFilterAction+<execute>d__7")]
		public sealed class _execute_d__7 : Object
		{
			// Token: 0x06005A2D RID: 23085 RVA: 0x001C7474 File Offset: 0x001C5674
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__7()
			{
				Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSelectionFilterAction>.NativeClassPtr, "<execute>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr);
				PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, "<>1__state");
				PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, "<>2__current");
				PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, "<>l__initialThreadId");
				PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, "<>4__this");
				PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr__sh_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, "<sh>5__2");
				PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr__selectionEntity_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, "<selectionEntity>5__3");
				PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, "<>7__wrap3");
				PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, "<>7__wrap4");
				PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, "<>7__wrap5");
				PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___7__wrap6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, "<>7__wrap6");
				PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___7__wrap7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, "<>7__wrap7");
				PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, 100668323);
				PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, 100668324);
				PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, 100668325);
				PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, 100668326);
				PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, 100668327);
				PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, 100668328);
				PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr___m__Finally4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, 100668329);
				PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr___m__Finally5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, 100668330);
				PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, 100668331);
				PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, 100668332);
				PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, 100668333);
				PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, 100668334);
				PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr, 100668335);
			}

			// Token: 0x06005A2E RID: 23086 RVA: 0x001C7680 File Offset: 0x001C5880
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSelectionFilterAction._execute_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005A2F RID: 23087 RVA: 0x001C76C8 File Offset: 0x001C58C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141463, XrefRangeEnd = 141488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A30 RID: 23088 RVA: 0x001C76FC File Offset: 0x001C58FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141488, XrefRangeEnd = 141919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005A31 RID: 23089 RVA: 0x001C7738 File Offset: 0x001C5938
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 141922, RefRangeEnd = 141923, XrefRangeStart = 141919, XrefRangeEnd = 141922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A32 RID: 23090 RVA: 0x001C776C File Offset: 0x001C596C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 141926, RefRangeEnd = 141927, XrefRangeStart = 141923, XrefRangeEnd = 141926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A33 RID: 23091 RVA: 0x001C77A0 File Offset: 0x001C59A0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 141930, RefRangeEnd = 141931, XrefRangeStart = 141927, XrefRangeEnd = 141930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A34 RID: 23092 RVA: 0x001C77D4 File Offset: 0x001C59D4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 141934, RefRangeEnd = 141935, XrefRangeStart = 141931, XrefRangeEnd = 141934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr___m__Finally4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005A35 RID: 23093 RVA: 0x001C7808 File Offset: 0x001C5A08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141935, XrefRangeEnd = 141938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr___m__Finally5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001747 RID: 5959
			// (get) Token: 0x06005A36 RID: 23094 RVA: 0x001C783C File Offset: 0x001C5A3C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005A37 RID: 23095 RVA: 0x001C787C File Offset: 0x001C5A7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141938, XrefRangeEnd = 141943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001748 RID: 5960
			// (get) Token: 0x06005A38 RID: 23096 RVA: 0x001C78B0 File Offset: 0x001C5AB0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005A39 RID: 23097 RVA: 0x001C78F0 File Offset: 0x001C5AF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141943, XrefRangeEnd = 141945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005A3A RID: 23098 RVA: 0x001C7930 File Offset: 0x001C5B30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFilterAction._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005A3B RID: 23099 RVA: 0x00021268 File Offset: 0x0001F468
			public _execute_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700173C RID: 5948
			// (get) Token: 0x06005A3C RID: 23100 RVA: 0x001C7970 File Offset: 0x001C5B70
			// (set) Token: 0x06005A3D RID: 23101 RVA: 0x00021271 File Offset: 0x0001F471
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700173D RID: 5949
			// (get) Token: 0x06005A3E RID: 23102 RVA: 0x001C7998 File Offset: 0x001C5B98
			// (set) Token: 0x06005A3F RID: 23103 RVA: 0x0002128C File Offset: 0x0001F48C
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700173E RID: 5950
			// (get) Token: 0x06005A40 RID: 23104 RVA: 0x001C79C8 File Offset: 0x001C5BC8
			// (set) Token: 0x06005A41 RID: 23105 RVA: 0x000212AB File Offset: 0x0001F4AB
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700173F RID: 5951
			// (get) Token: 0x06005A42 RID: 23106 RVA: 0x001C79F0 File Offset: 0x001C5BF0
			// (set) Token: 0x06005A43 RID: 23107 RVA: 0x000212C6 File Offset: 0x0001F4C6
			public unsafe PlayerSelectionFilterAction __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerSelectionFilterAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001740 RID: 5952
			// (get) Token: 0x06005A44 RID: 23108 RVA: 0x001C7A20 File Offset: 0x001C5C20
			// (set) Token: 0x06005A45 RID: 23109 RVA: 0x000212E5 File Offset: 0x0001F4E5
			public unsafe SequenceHelper _sh_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr__sh_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr__sh_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001741 RID: 5953
			// (get) Token: 0x06005A46 RID: 23110 RVA: 0x001C7A50 File Offset: 0x001C5C50
			// (set) Token: 0x06005A47 RID: 23111 RVA: 0x00021304 File Offset: 0x0001F504
			public unsafe Entity _selectionEntity_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr__selectionEntity_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr__selectionEntity_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001742 RID: 5954
			// (get) Token: 0x06005A48 RID: 23112 RVA: 0x001C7A80 File Offset: 0x001C5C80
			// (set) Token: 0x06005A49 RID: 23113 RVA: 0x00021323 File Offset: 0x0001F523
			public List<AttributeDefinition<EntityID>>.Enumerator __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___7__wrap3);
					return new List<AttributeDefinition<EntityID>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<AttributeDefinition<EntityID>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___7__wrap3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<AttributeDefinition<EntityID>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001743 RID: 5955
			// (get) Token: 0x06005A4A RID: 23114 RVA: 0x001C7AB0 File Offset: 0x001C5CB0
			// (set) Token: 0x06005A4B RID: 23115 RVA: 0x00021351 File Offset: 0x0001F551
			public List<AttributeDefinition<List<EntityID>>>.Enumerator __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___7__wrap4);
					return new List<AttributeDefinition<List<EntityID>>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<AttributeDefinition<List<EntityID>>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___7__wrap4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<AttributeDefinition<List<EntityID>>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001744 RID: 5956
			// (get) Token: 0x06005A4C RID: 23116 RVA: 0x001C7AE0 File Offset: 0x001C5CE0
			// (set) Token: 0x06005A4D RID: 23117 RVA: 0x0002137F File Offset: 0x0001F57F
			public List<AttributeDefinition<Nullable<int>>>.Enumerator __7__wrap5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___7__wrap5);
					return new List<AttributeDefinition<Nullable<int>>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<AttributeDefinition<Nullable<int>>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___7__wrap5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<AttributeDefinition<Nullable<int>>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001745 RID: 5957
			// (get) Token: 0x06005A4E RID: 23118 RVA: 0x001C7B10 File Offset: 0x001C5D10
			// (set) Token: 0x06005A4F RID: 23119 RVA: 0x000213AD File Offset: 0x0001F5AD
			public List<AttributeDefinition<Nullable<bool>>>.Enumerator __7__wrap6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___7__wrap6);
					return new List<AttributeDefinition<Nullable<bool>>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<AttributeDefinition<Nullable<bool>>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___7__wrap6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<AttributeDefinition<Nullable<bool>>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001746 RID: 5958
			// (get) Token: 0x06005A50 RID: 23120 RVA: 0x001C7B40 File Offset: 0x001C5D40
			// (set) Token: 0x06005A51 RID: 23121 RVA: 0x000213DB File Offset: 0x0001F5DB
			public List<IAttribute>.Enumerator __7__wrap7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___7__wrap7);
					return new List<IAttribute>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<IAttribute>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilterAction._execute_d__7.NativeFieldInfoPtr___7__wrap7), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<IAttribute>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04003ABA RID: 15034
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003ABB RID: 15035
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003ABC RID: 15036
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003ABD RID: 15037
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003ABE RID: 15038
			private static readonly IntPtr NativeFieldInfoPtr__sh_5__2;

			// Token: 0x04003ABF RID: 15039
			private static readonly IntPtr NativeFieldInfoPtr__selectionEntity_5__3;

			// Token: 0x04003AC0 RID: 15040
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04003AC1 RID: 15041
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x04003AC2 RID: 15042
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap5;

			// Token: 0x04003AC3 RID: 15043
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap6;

			// Token: 0x04003AC4 RID: 15044
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap7;

			// Token: 0x04003AC5 RID: 15045
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003AC6 RID: 15046
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003AC7 RID: 15047
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003AC8 RID: 15048
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003AC9 RID: 15049
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04003ACA RID: 15050
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x04003ACB RID: 15051
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally4_Private_Void_0;

			// Token: 0x04003ACC RID: 15052
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally5_Private_Void_0;

			// Token: 0x04003ACD RID: 15053
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003ACE RID: 15054
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003ACF RID: 15055
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003AD0 RID: 15056
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003AD1 RID: 15057
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
