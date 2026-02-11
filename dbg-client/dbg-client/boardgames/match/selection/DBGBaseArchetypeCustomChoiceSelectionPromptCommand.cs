using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.data.composition;
using dwd.core.match;
using dwd.core.match.selection;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match.selection
{
	// Token: 0x02000262 RID: 610
	public class DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType> : DBGEntityComponentChoicesSelectionPromptCommand<TNodeType> where TNodeType : class
	{
		// Token: 0x06001C00 RID: 7168 RVA: 0x000798F8 File Offset: 0x00077AF8
		// Note: this type is marked as 'beforefieldinit'.
		static DBGBaseArchetypeCustomChoiceSelectionPromptCommand()
		{
			Il2CppClassPointerStore<DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "DBGBaseArchetypeCustomChoiceSelectionPromptCommand`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNodeType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>>.NativeClassPtr);
			DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.NativeFieldInfoPtr_promptData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>>.NativeClassPtr, "promptData");
			DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.NativeFieldInfoPtr_promptFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>>.NativeClassPtr, "promptFlavors");
			DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667853);
			DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667854);
			DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667855);
			DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667856);
			DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_tryGetChoices_Protected_Virtual_Boolean_byref_List_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667857);
			DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_getPromptData_Protected_Virtual_New_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667858);
			DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_getPromptFlavors_Protected_Virtual_New_PrefabFlavorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>>.NativeClassPtr, 100667859);
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x00079A18 File Offset: 0x00077C18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 534539, RefRangeEnd = 534541, XrefRangeStart = 534525, XrefRangeEnd = 534539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGBaseArchetypeCustomChoiceSelectionPromptCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x00079A74 File Offset: 0x00077C74
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool autoAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x00079ABC File Offset: 0x00077CBC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void enterNode(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x00079B08 File Offset: 0x00077D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534541, XrefRangeEnd = 534582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool submitSelection(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x00079B60 File Offset: 0x00077D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534582, XrefRangeEnd = 534648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool tryGetChoices(out List<EntityComponent> choices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_tryGetChoices_Protected_Virtual_Boolean_byref_List_1_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				choices = ((intPtr4 == 0) ? null : new List<EntityComponent>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x00079BCC File Offset: 0x00077DCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 534667, RefRangeEnd = 534668, XrefRangeStart = 534648, XrefRangeEnd = 534667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DataComposition getPromptData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_getPromptData_Protected_Virtual_New_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x00079C18 File Offset: 0x00077E18
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PrefabFlavorContext getPromptFlavors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.NativeMethodInfoPtr_getPromptFlavors_Protected_Virtual_New_PrefabFlavorContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new PrefabFlavorContext(intPtr);
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0000F187 File Offset: 0x0000D387
		public DBGBaseArchetypeCustomChoiceSelectionPromptCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x00079C5C File Offset: 0x00077E5C
		// (set) Token: 0x06001C0A RID: 7178 RVA: 0x0000F190 File Offset: 0x0000D390
		public unsafe DataComposition promptData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.NativeFieldInfoPtr_promptData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.NativeFieldInfoPtr_promptData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001C0B RID: 7179 RVA: 0x00079C8C File Offset: 0x00077E8C
		// (set) Token: 0x06001C0C RID: 7180 RVA: 0x0000F1AF File Offset: 0x0000D3AF
		public PrefabFlavorContext promptFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.NativeFieldInfoPtr_promptFlavors);
				return new PrefabFlavorContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.NativeFieldInfoPtr_promptFlavors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeFieldInfoPtr_promptData;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeFieldInfoPtr_promptFlavors;

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_EntityID_0;

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeMethodInfoPtr_tryGetChoices_Protected_Virtual_Boolean_byref_List_1_EntityComponent_0;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeMethodInfoPtr_getPromptData_Protected_Virtual_New_DataComposition_0;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeMethodInfoPtr_getPromptFlavors_Protected_Virtual_New_PrefabFlavorContext_0;

		// Token: 0x02000457 RID: 1111
		[ObfuscatedName("boardgames.match.selection.DBGBaseArchetypeCustomChoiceSelectionPromptCommand`1+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x060034DE RID: 13534 RVA: 0x000C6370 File Offset: 0x000C4570
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>>.NativeClassPtr, "<>c__DisplayClass5_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNodeType>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.__c__DisplayClass5_0>.NativeClassPtr);
				DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.__c__DisplayClass5_0.NativeFieldInfoPtr_entityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.__c__DisplayClass5_0>.NativeClassPtr, "entityID");
				DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.__c__DisplayClass5_0.NativeFieldInfoPtr_archetypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.__c__DisplayClass5_0>.NativeClassPtr, "archetypeID");
				DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.__c__DisplayClass5_0>.NativeClassPtr, 100667860);
				DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.__c__DisplayClass5_0.NativeMethodInfoPtr__submitSelection_b__0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.__c__DisplayClass5_0>.NativeClassPtr, 100667861);
				DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.__c__DisplayClass5_0.NativeMethodInfoPtr__submitSelection_b__1_Internal_Boolean_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.__c__DisplayClass5_0>.NativeClassPtr, 100667862);
			}

			// Token: 0x060034DF RID: 13535 RVA: 0x000C643C File Offset: 0x000C463C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060034E0 RID: 13536 RVA: 0x000C6478 File Offset: 0x000C4678
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534505, XrefRangeEnd = 534510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _submitSelection_b__0(EntityComponent choice)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(choice);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.__c__DisplayClass5_0.NativeMethodInfoPtr__submitSelection_b__0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060034E1 RID: 13537 RVA: 0x000C64C8 File Offset: 0x000C46C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534510, XrefRangeEnd = 534525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _submitSelection_b__1(ReadOnlyAttributes button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(button);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.__c__DisplayClass5_0.NativeMethodInfoPtr__submitSelection_b__1_Internal_Boolean_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060034E2 RID: 13538 RVA: 0x0001B524 File Offset: 0x00019724
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F85 RID: 3973
			// (get) Token: 0x060034E3 RID: 13539 RVA: 0x000C6518 File Offset: 0x000C4718
			// (set) Token: 0x060034E4 RID: 13540 RVA: 0x0001B52D File Offset: 0x0001972D
			public unsafe EntityID entityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.__c__DisplayClass5_0.NativeFieldInfoPtr_entityID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.__c__DisplayClass5_0.NativeFieldInfoPtr_entityID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F86 RID: 3974
			// (get) Token: 0x060034E5 RID: 13541 RVA: 0x000C6548 File Offset: 0x000C4748
			// (set) Token: 0x060034E6 RID: 13542 RVA: 0x0001B54C File Offset: 0x0001974C
			public unsafe ArchetypeID archetypeID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.__c__DisplayClass5_0.NativeFieldInfoPtr_archetypeID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBaseArchetypeCustomChoiceSelectionPromptCommand<TNodeType>.__c__DisplayClass5_0.NativeFieldInfoPtr_archetypeID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002096 RID: 8342
			private static readonly IntPtr NativeFieldInfoPtr_entityID;

			// Token: 0x04002097 RID: 8343
			private static readonly IntPtr NativeFieldInfoPtr_archetypeID;

			// Token: 0x04002098 RID: 8344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002099 RID: 8345
			private static readonly IntPtr NativeMethodInfoPtr__submitSelection_b__0_Internal_Boolean_EntityComponent_0;

			// Token: 0x0400209A RID: 8346
			private static readonly IntPtr NativeMethodInfoPtr__submitSelection_b__1_Internal_Boolean_ReadOnlyAttributes_0;
		}
	}
}
