using System;
using Canis.utils.ids;
using dwd.core.match;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match.selection
{
	// Token: 0x02000266 RID: 614
	public class DBGEntityComponentChoicesSelectionPromptCommand<TNodeType> : DBGSelectionPromptCommand<TNodeType> where TNodeType : class
	{
		// Token: 0x06001C5F RID: 7263 RVA: 0x0007B270 File Offset: 0x00079470
		// Note: this type is marked as 'beforefieldinit'.
		static DBGEntityComponentChoicesSelectionPromptCommand()
		{
			Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "DBGEntityComponentChoicesSelectionPromptCommand`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNodeType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>>.NativeClassPtr);
			DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.NativeFieldInfoPtr_choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>>.NativeClassPtr, "choices");
			DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.NativeFieldInfoPtr_getChoicesFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>>.NativeClassPtr, "getChoicesFailed");
			DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667937);
			DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_EntityIsSelectable_Public_Virtual_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667938);
			DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_tryGetChoices_Protected_Abstract_Virtual_New_Boolean_byref_List_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667939);
			DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667940);
			DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667941);
			DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_SetSelectableHints_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667942);
			DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr___n__0_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667943);
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x0007B390 File Offset: 0x00079590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 535503, RefRangeEnd = 535504, XrefRangeStart = 535492, XrefRangeEnd = 535503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGEntityComponentChoicesSelectionPromptCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x0007B3EC File Offset: 0x000795EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535504, XrefRangeEnd = 535516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool EntityIsSelectable(EntityID entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_EntityIsSelectable_Public_Virtual_Boolean_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x0007B444 File Offset: 0x00079644
		[CallerCount(0)]
		public unsafe virtual bool tryGetChoices(out List<EntityComponent> entityComponents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_tryGetChoices_Protected_Abstract_Virtual_New_Boolean_byref_List_1_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				entityComponents = ((intPtr4 == 0) ? null : new List<EntityComponent>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x0007B4B0 File Offset: 0x000796B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535516, XrefRangeEnd = 535520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator idle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x0007B4FC File Offset: 0x000796FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 535549, RefRangeEnd = 535551, XrefRangeStart = 535520, XrefRangeEnd = 535549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void exitNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x0007B538 File Offset: 0x00079738
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 535573, RefRangeEnd = 535575, XrefRangeStart = 535551, XrefRangeEnd = 535573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectableHints(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_SetSelectableHints_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x0007B578 File Offset: 0x00079778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535575, XrefRangeEnd = 535579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator __n__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr___n__0_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x0000F3B5 File Offset: 0x0000D5B5
		public DBGEntityComponentChoicesSelectionPromptCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001C68 RID: 7272 RVA: 0x0007B5B8 File Offset: 0x000797B8
		// (set) Token: 0x06001C69 RID: 7273 RVA: 0x0000F3BE File Offset: 0x0000D5BE
		public unsafe List<EntityComponent> choices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.NativeFieldInfoPtr_choices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.NativeFieldInfoPtr_choices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x0007B5E8 File Offset: 0x000797E8
		// (set) Token: 0x06001C6B RID: 7275 RVA: 0x0000F3DD File Offset: 0x0000D5DD
		public unsafe bool getChoicesFailed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.NativeFieldInfoPtr_getChoicesFailed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.NativeFieldInfoPtr_getChoicesFailed)) = value;
			}
		}

		// Token: 0x040011D1 RID: 4561
		private static readonly IntPtr NativeFieldInfoPtr_choices;

		// Token: 0x040011D2 RID: 4562
		private static readonly IntPtr NativeFieldInfoPtr_getChoicesFailed;

		// Token: 0x040011D3 RID: 4563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x040011D4 RID: 4564
		private static readonly IntPtr NativeMethodInfoPtr_EntityIsSelectable_Public_Virtual_Boolean_EntityID_0;

		// Token: 0x040011D5 RID: 4565
		private static readonly IntPtr NativeMethodInfoPtr_tryGetChoices_Protected_Abstract_Virtual_New_Boolean_byref_List_1_EntityComponent_0;

		// Token: 0x040011D6 RID: 4566
		private static readonly IntPtr NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0;

		// Token: 0x040011D7 RID: 4567
		private static readonly IntPtr NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0;

		// Token: 0x040011D8 RID: 4568
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectableHints_Protected_Void_Boolean_0;

		// Token: 0x040011D9 RID: 4569
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_0;

		// Token: 0x0200045E RID: 1118
		[ObfuscatedName("boardgames.match.selection.DBGEntityComponentChoicesSelectionPromptCommand`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600352F RID: 13615 RVA: 0x000C7398 File Offset: 0x000C5598
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNodeType>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c>.NativeClassPtr);
				DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c>.NativeClassPtr, "<>9");
				DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c>.NativeClassPtr, "<>9__7_0");
				DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c>.NativeClassPtr, 100667945);
				DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c.NativeMethodInfoPtr__SetSelectableHints_b__7_0_Internal_EntityID_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c>.NativeClassPtr, 100667946);
			}

			// Token: 0x06003530 RID: 13616 RVA: 0x000C7450 File Offset: 0x000C5650
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003531 RID: 13617 RVA: 0x000C748C File Offset: 0x000C568C
			[CallerCount(0)]
			public unsafe EntityID _SetSelectableHints_b__7_0(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c.NativeMethodInfoPtr__SetSelectableHints_b__7_0_Internal_EntityID_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06003532 RID: 13618 RVA: 0x0001B790 File Offset: 0x00019990
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F9F RID: 3999
			// (get) Token: 0x06003533 RID: 13619 RVA: 0x000C74DC File Offset: 0x000C56DC
			// (set) Token: 0x06003534 RID: 13620 RVA: 0x0001B799 File Offset: 0x00019999
			public unsafe static DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FA0 RID: 4000
			// (get) Token: 0x06003535 RID: 13621 RVA: 0x000C7504 File Offset: 0x000C5704
			// (set) Token: 0x06003536 RID: 13622 RVA: 0x0001B7AB File Offset: 0x000199AB
			public unsafe static Func<EntityComponent, EntityID> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020C7 RID: 8391
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040020C8 RID: 8392
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040020C9 RID: 8393
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040020CA RID: 8394
			private static readonly IntPtr NativeMethodInfoPtr__SetSelectableHints_b__7_0_Internal_EntityID_EntityComponent_0;
		}

		// Token: 0x0200045F RID: 1119
		[ObfuscatedName("boardgames.match.selection.DBGEntityComponentChoicesSelectionPromptCommand`1+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06003537 RID: 13623 RVA: 0x000C752C File Offset: 0x000C572C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>>.NativeClassPtr, "<>c__DisplayClass3_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNodeType>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass3_0>.NativeClassPtr);
				DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass3_0.NativeFieldInfoPtr_entityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass3_0>.NativeClassPtr, "entityId");
				DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass3_0>.NativeClassPtr, 100667947);
				DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass3_0.NativeMethodInfoPtr__EntityIsSelectable_b__0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass3_0>.NativeClassPtr, 100667948);
			}

			// Token: 0x06003538 RID: 13624 RVA: 0x000C75D0 File Offset: 0x000C57D0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003539 RID: 13625 RVA: 0x000C760C File Offset: 0x000C580C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535480, XrefRangeEnd = 535485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EntityIsSelectable_b__0(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass3_0.NativeMethodInfoPtr__EntityIsSelectable_b__0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600353A RID: 13626 RVA: 0x0001B7BD File Offset: 0x000199BD
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FA1 RID: 4001
			// (get) Token: 0x0600353B RID: 13627 RVA: 0x000C765C File Offset: 0x000C585C
			// (set) Token: 0x0600353C RID: 13628 RVA: 0x0001B7C6 File Offset: 0x000199C6
			public unsafe EntityID entityId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass3_0.NativeFieldInfoPtr_entityId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass3_0.NativeFieldInfoPtr_entityId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020CB RID: 8395
			private static readonly IntPtr NativeFieldInfoPtr_entityId;

			// Token: 0x040020CC RID: 8396
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040020CD RID: 8397
			private static readonly IntPtr NativeMethodInfoPtr__EntityIsSelectable_b__0_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000460 RID: 1120
		[ObfuscatedName("boardgames.match.selection.DBGEntityComponentChoicesSelectionPromptCommand`1+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x0600353D RID: 13629 RVA: 0x000C768C File Offset: 0x000C588C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>>.NativeClassPtr, "<>c__DisplayClass6_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNodeType>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass6_0>.NativeClassPtr);
				DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass6_0.NativeFieldInfoPtr_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass6_0>.NativeClassPtr, "choice");
				DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass6_0>.NativeClassPtr, 100667949);
				DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass6_0.NativeMethodInfoPtr__exitNode_b__0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass6_0>.NativeClassPtr, 100667950);
			}

			// Token: 0x0600353E RID: 13630 RVA: 0x000C7730 File Offset: 0x000C5930
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600353F RID: 13631 RVA: 0x000C776C File Offset: 0x000C596C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535485, XrefRangeEnd = 535490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _exitNode_b__0(EntityComponent te)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(te);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass6_0.NativeMethodInfoPtr__exitNode_b__0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003540 RID: 13632 RVA: 0x0001B7E5 File Offset: 0x000199E5
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FA2 RID: 4002
			// (get) Token: 0x06003541 RID: 13633 RVA: 0x000C77BC File Offset: 0x000C59BC
			// (set) Token: 0x06003542 RID: 13634 RVA: 0x0001B7EE File Offset: 0x000199EE
			public unsafe EntityComponent choice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass6_0.NativeFieldInfoPtr_choice);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>.__c__DisplayClass6_0.NativeFieldInfoPtr_choice), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020CE RID: 8398
			private static readonly IntPtr NativeFieldInfoPtr_choice;

			// Token: 0x040020CF RID: 8399
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040020D0 RID: 8400
			private static readonly IntPtr NativeMethodInfoPtr__exitNode_b__0_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000461 RID: 1121
		[ObfuscatedName("boardgames.match.selection.DBGEntityComponentChoicesSelectionPromptCommand`1+<idle>d__5")]
		public sealed class _idle_d__5 : Object
		{
			// Token: 0x06003543 RID: 13635 RVA: 0x000C77EC File Offset: 0x000C59EC
			// Note: this type is marked as 'beforefieldinit'.
			static _idle_d__5()
			{
				Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>>.NativeClassPtr, "<idle>d__5"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNodeType>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5>.NativeClassPtr);
				DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5>.NativeClassPtr, "<>1__state");
				DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5>.NativeClassPtr, "<>2__current");
				DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5>.NativeClassPtr, "<>4__this");
				DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5>.NativeClassPtr, 100667951);
				DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5>.NativeClassPtr, 100667952);
				DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5>.NativeClassPtr, 100667953);
				DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5>.NativeClassPtr, 100667954);
				DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5>.NativeClassPtr, 100667955);
				DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5>.NativeClassPtr, 100667956);
			}

			// Token: 0x06003544 RID: 13636 RVA: 0x000C7908 File Offset: 0x000C5B08
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _idle_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003545 RID: 13637 RVA: 0x000C7950 File Offset: 0x000C5B50
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003546 RID: 13638 RVA: 0x000C7984 File Offset: 0x000C5B84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535490, XrefRangeEnd = 535492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000FA6 RID: 4006
			// (get) Token: 0x06003547 RID: 13639 RVA: 0x000C79C0 File Offset: 0x000C5BC0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003548 RID: 13640 RVA: 0x000C7A00 File Offset: 0x000C5C00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000FA7 RID: 4007
			// (get) Token: 0x06003549 RID: 13641 RVA: 0x000C7A34 File Offset: 0x000C5C34
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600354A RID: 13642 RVA: 0x0001B80D File Offset: 0x00019A0D
			public _idle_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FA3 RID: 4003
			// (get) Token: 0x0600354B RID: 13643 RVA: 0x000C7A74 File Offset: 0x000C5C74
			// (set) Token: 0x0600354C RID: 13644 RVA: 0x0001B816 File Offset: 0x00019A16
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FA4 RID: 4004
			// (get) Token: 0x0600354D RID: 13645 RVA: 0x000C7A9C File Offset: 0x000C5C9C
			// (set) Token: 0x0600354E RID: 13646 RVA: 0x0001B831 File Offset: 0x00019A31
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FA5 RID: 4005
			// (get) Token: 0x0600354F RID: 13647 RVA: 0x000C7ACC File Offset: 0x000C5CCC
			// (set) Token: 0x06003550 RID: 13648 RVA: 0x0001B850 File Offset: 0x00019A50
			public unsafe DBGEntityComponentChoicesSelectionPromptCommand<TNodeType> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntityComponentChoicesSelectionPromptCommand<TNodeType>._idle_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020D1 RID: 8401
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040020D2 RID: 8402
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040020D3 RID: 8403
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040020D4 RID: 8404
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040020D5 RID: 8405
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020D6 RID: 8406
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040020D7 RID: 8407
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040020D8 RID: 8408
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020D9 RID: 8409
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
