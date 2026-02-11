using System;
using Canis.actions;
using Canis.actions.serialized;
using Canis.attributes;
using Canis.context;
using Canis.messages;
using Canis.undo;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis.entities
{
	// Token: 0x020000F2 RID: 242
	public class UndoNode : Entity
	{
		// Token: 0x06000ABA RID: 2746 RVA: 0x00047438 File Offset: 0x00045638
		// Note: this type is marked as 'beforefieldinit'.
		static UndoNode()
		{
			Il2CppClassPointerStore<UndoNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "UndoNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UndoNode>.NativeClassPtr);
			UndoNode.NativeFieldInfoPtr_actionToUndo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoNode>.NativeClassPtr, "actionToUndo");
			UndoNode.NativeMethodInfoPtr_get_SerializedActionToUndo_Private_get_SerializedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode>.NativeClassPtr, 100665636);
			UndoNode.NativeMethodInfoPtr_get_ActionToUndo_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode>.NativeClassPtr, 100665637);
			UndoNode.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode>.NativeClassPtr, 100665638);
			UndoNode.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_AbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode>.NativeClassPtr, 100665639);
			UndoNode.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode>.NativeClassPtr, 100665640);
			UndoNode.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_SerializedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode>.NativeClassPtr, 100665641);
			UndoNode.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode>.NativeClassPtr, 100665642);
			UndoNode.NativeMethodInfoPtr_Serialize_Public_Virtual_SerializedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode>.NativeClassPtr, 100665643);
			UndoNode.NativeMethodInfoPtr_UndoAbility_Public_IAbilityDefinitionWithUndo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode>.NativeClassPtr, 100665644);
			UndoNode.NativeMethodInfoPtr_ChangeAttribute_Public_Action_AttributeDefinition_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode>.NativeClassPtr, 100665645);
			UndoNode.NativeMethodInfoPtr_RunUndo_Public_IEnumerable_1_Action_PlayerEntity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode>.NativeClassPtr, 100665646);
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x00047558 File Offset: 0x00045758
		public unsafe SerializedAction SerializedActionToUndo
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 567738, RefRangeEnd = 567740, XrefRangeStart = 567728, XrefRangeEnd = 567738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoNode.NativeMethodInfoPtr_get_SerializedActionToUndo_Private_get_SerializedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00047598 File Offset: 0x00045798
		public unsafe Canis.actions.Action ActionToUndo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 567743, RefRangeEnd = 567744, XrefRangeStart = 567740, XrefRangeEnd = 567743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoNode.NativeMethodInfoPtr_get_ActionToUndo_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x000475D8 File Offset: 0x000457D8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 553228, RefRangeEnd = 553234, XrefRangeStart = 553228, XrefRangeEnd = 553234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UndoNode(SerializedEntity se, Match match, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoNode.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x00047648 File Offset: 0x00045848
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 567754, RefRangeEnd = 567756, XrefRangeStart = 567744, XrefRangeEnd = 567754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UndoNode(Match m, PlayerEntity owningPlayer, AbilityDefinition undoAbility)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(undoAbility);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoNode.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_AbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x000476B8 File Offset: 0x000458B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 567760, RefRangeEnd = 567761, XrefRangeStart = 567756, XrefRangeEnd = 567760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UndoNode(Match m, PlayerEntity owningPlayer, Canis.actions.Action actionToUndo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionToUndo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoNode.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00047728 File Offset: 0x00045928
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 567776, RefRangeEnd = 567778, XrefRangeStart = 567761, XrefRangeEnd = 567776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UndoNode(Match m, PlayerEntity owningPlayer, SerializedAction serializedActionToUndo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serializedActionToUndo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoNode.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_SerializedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00047798 File Offset: 0x00045998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567778, XrefRangeEnd = 567859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UndoNode.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x000477DC File Offset: 0x000459DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567859, XrefRangeEnd = 567874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedEntity Serialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UndoNode.NativeMethodInfoPtr_Serialize_Public_Virtual_SerializedEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedEntity>(intPtr3) : null;
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00047828 File Offset: 0x00045A28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 567891, RefRangeEnd = 567893, XrefRangeStart = 567874, XrefRangeEnd = 567891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAbilityDefinitionWithUndo UndoAbility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoNode.NativeMethodInfoPtr_UndoAbility_Public_IAbilityDefinitionWithUndo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAbilityDefinitionWithUndo>(intPtr3) : null;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00047868 File Offset: 0x00045A68
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 567911, RefRangeEnd = 567920, XrefRangeStart = 567893, XrefRangeEnd = 567911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action ChangeAttribute<T>(AttributeDefinition<T> attribute, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UndoNode.MethodInfoStoreGeneric_ChangeAttribute_Public_Action_AttributeDefinition_1_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr4) : null;
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00047900 File Offset: 0x00045B00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 567928, RefRangeEnd = 567929, XrefRangeStart = 567920, XrefRangeEnd = 567928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Canis.actions.Action> RunUndo(PlayerEntity player, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoNode.NativeMethodInfoPtr_RunUndo_Public_IEnumerable_1_Action_PlayerEntity_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00005E6C File Offset: 0x0000406C
		public UndoNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x00047964 File Offset: 0x00045B64
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x00005E75 File Offset: 0x00004075
		public unsafe Canis.actions.Action actionToUndo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode.NativeFieldInfoPtr_actionToUndo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode.NativeFieldInfoPtr_actionToUndo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeFieldInfoPtr_actionToUndo;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr_get_SerializedActionToUndo_Private_get_SerializedAction_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionToUndo_Public_get_Action_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_AbilityDefinition_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Action_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_SerializedAction_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_SerializedEntity_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_UndoAbility_Public_IAbilityDefinitionWithUndo_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_ChangeAttribute_Public_Action_AttributeDefinition_1_T_T_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_RunUndo_Public_IEnumerable_1_Action_PlayerEntity_Context_0;

		// Token: 0x02000339 RID: 825
		[ObfuscatedName("Canis.entities.UndoNode+<RunUndo>d__13")]
		public sealed class _RunUndo_d__13 : Object
		{
			// Token: 0x06002283 RID: 8835 RVA: 0x0009B4A4 File Offset: 0x000996A4
			// Note: this type is marked as 'beforefieldinit'.
			static _RunUndo_d__13()
			{
				Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UndoNode>.NativeClassPtr, "<RunUndo>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr);
				UndoNode._RunUndo_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, "<>1__state");
				UndoNode._RunUndo_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, "<>2__current");
				UndoNode._RunUndo_d__13.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, "<>l__initialThreadId");
				UndoNode._RunUndo_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, "<>4__this");
				UndoNode._RunUndo_d__13.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, "player");
				UndoNode._RunUndo_d__13.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, "<>3__player");
				UndoNode._RunUndo_d__13.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, "context");
				UndoNode._RunUndo_d__13.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, "<>3__context");
				UndoNode._RunUndo_d__13.NativeFieldInfoPtr__matchWithUndos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, "<matchWithUndos>5__2");
				UndoNode._RunUndo_d__13.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, "<>7__wrap2");
				UndoNode._RunUndo_d__13.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, "<>7__wrap3");
				UndoNode._RunUndo_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, 100665647);
				UndoNode._RunUndo_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, 100665648);
				UndoNode._RunUndo_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, 100665649);
				UndoNode._RunUndo_d__13.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, 100665650);
				UndoNode._RunUndo_d__13.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, 100665651);
				UndoNode._RunUndo_d__13.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, 100665652);
				UndoNode._RunUndo_d__13.NativeMethodInfoPtr___m__Finally4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, 100665653);
				UndoNode._RunUndo_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, 100665654);
				UndoNode._RunUndo_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, 100665655);
				UndoNode._RunUndo_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, 100665656);
				UndoNode._RunUndo_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, 100665657);
				UndoNode._RunUndo_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr, 100665658);
			}

			// Token: 0x06002284 RID: 8836 RVA: 0x0009B69C File Offset: 0x0009989C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunUndo_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoNode._RunUndo_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoNode._RunUndo_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002285 RID: 8837 RVA: 0x0009B6E4 File Offset: 0x000998E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567554, XrefRangeEnd = 567574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoNode._RunUndo_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002286 RID: 8838 RVA: 0x0009B718 File Offset: 0x00099918
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567574, XrefRangeEnd = 567701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoNode._RunUndo_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002287 RID: 8839 RVA: 0x0009B754 File Offset: 0x00099954
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567701, XrefRangeEnd = 567704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoNode._RunUndo_d__13.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002288 RID: 8840 RVA: 0x0009B788 File Offset: 0x00099988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567704, XrefRangeEnd = 567707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoNode._RunUndo_d__13.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002289 RID: 8841 RVA: 0x0009B7BC File Offset: 0x000999BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567707, XrefRangeEnd = 567710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoNode._RunUndo_d__13.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600228A RID: 8842 RVA: 0x0009B7F0 File Offset: 0x000999F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567710, XrefRangeEnd = 567713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoNode._RunUndo_d__13.NativeMethodInfoPtr___m__Finally4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700086E RID: 2158
			// (get) Token: 0x0600228B RID: 8843 RVA: 0x0009B824 File Offset: 0x00099A24
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoNode._RunUndo_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600228C RID: 8844 RVA: 0x0009B864 File Offset: 0x00099A64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567713, XrefRangeEnd = 567718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoNode._RunUndo_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700086F RID: 2159
			// (get) Token: 0x0600228D RID: 8845 RVA: 0x0009B898 File Offset: 0x00099A98
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoNode._RunUndo_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600228E RID: 8846 RVA: 0x0009B8D8 File Offset: 0x00099AD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567718, XrefRangeEnd = 567728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoNode._RunUndo_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600228F RID: 8847 RVA: 0x0009B918 File Offset: 0x00099B18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoNode._RunUndo_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002290 RID: 8848 RVA: 0x00010936 File Offset: 0x0000EB36
			public _RunUndo_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000863 RID: 2147
			// (get) Token: 0x06002291 RID: 8849 RVA: 0x0009B958 File Offset: 0x00099B58
			// (set) Token: 0x06002292 RID: 8850 RVA: 0x0001093F File Offset: 0x0000EB3F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000864 RID: 2148
			// (get) Token: 0x06002293 RID: 8851 RVA: 0x0009B980 File Offset: 0x00099B80
			// (set) Token: 0x06002294 RID: 8852 RVA: 0x0001095A File Offset: 0x0000EB5A
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000865 RID: 2149
			// (get) Token: 0x06002295 RID: 8853 RVA: 0x0009B9B0 File Offset: 0x00099BB0
			// (set) Token: 0x06002296 RID: 8854 RVA: 0x00010979 File Offset: 0x0000EB79
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000866 RID: 2150
			// (get) Token: 0x06002297 RID: 8855 RVA: 0x0009B9D8 File Offset: 0x00099BD8
			// (set) Token: 0x06002298 RID: 8856 RVA: 0x00010994 File Offset: 0x0000EB94
			public unsafe UndoNode __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000867 RID: 2151
			// (get) Token: 0x06002299 RID: 8857 RVA: 0x0009BA08 File Offset: 0x00099C08
			// (set) Token: 0x0600229A RID: 8858 RVA: 0x000109B3 File Offset: 0x0000EBB3
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000868 RID: 2152
			// (get) Token: 0x0600229B RID: 8859 RVA: 0x0009BA38 File Offset: 0x00099C38
			// (set) Token: 0x0600229C RID: 8860 RVA: 0x000109D2 File Offset: 0x0000EBD2
			public unsafe PlayerEntity __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000869 RID: 2153
			// (get) Token: 0x0600229D RID: 8861 RVA: 0x0009BA68 File Offset: 0x00099C68
			// (set) Token: 0x0600229E RID: 8862 RVA: 0x000109F1 File Offset: 0x0000EBF1
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700086A RID: 2154
			// (get) Token: 0x0600229F RID: 8863 RVA: 0x0009BA98 File Offset: 0x00099C98
			// (set) Token: 0x060022A0 RID: 8864 RVA: 0x00010A10 File Offset: 0x0000EC10
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700086B RID: 2155
			// (get) Token: 0x060022A1 RID: 8865 RVA: 0x0009BAC8 File Offset: 0x00099CC8
			// (set) Token: 0x060022A2 RID: 8866 RVA: 0x00010A2F File Offset: 0x0000EC2F
			public unsafe IHasUndoableActions _matchWithUndos_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr__matchWithUndos_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHasUndoableActions>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr__matchWithUndos_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700086C RID: 2156
			// (get) Token: 0x060022A3 RID: 8867 RVA: 0x0009BAF8 File Offset: 0x00099CF8
			// (set) Token: 0x060022A4 RID: 8868 RVA: 0x00010A4E File Offset: 0x0000EC4E
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700086D RID: 2157
			// (get) Token: 0x060022A5 RID: 8869 RVA: 0x0009BB28 File Offset: 0x00099D28
			// (set) Token: 0x060022A6 RID: 8870 RVA: 0x00010A6D File Offset: 0x0000EC6D
			public unsafe IEnumerator<UndoNode> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<UndoNode>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoNode._RunUndo_d__13.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015B2 RID: 5554
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015B3 RID: 5555
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040015B4 RID: 5556
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040015B5 RID: 5557
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015B6 RID: 5558
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040015B7 RID: 5559
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x040015B8 RID: 5560
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040015B9 RID: 5561
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x040015BA RID: 5562
			private static readonly IntPtr NativeFieldInfoPtr__matchWithUndos_5__2;

			// Token: 0x040015BB RID: 5563
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040015BC RID: 5564
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x040015BD RID: 5565
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040015BE RID: 5566
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015BF RID: 5567
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040015C0 RID: 5568
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040015C1 RID: 5569
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040015C2 RID: 5570
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x040015C3 RID: 5571
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally4_Private_Void_0;

			// Token: 0x040015C4 RID: 5572
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040015C5 RID: 5573
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015C6 RID: 5574
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040015C7 RID: 5575
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040015C8 RID: 5576
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200033A RID: 826
		private sealed class MethodInfoStoreGeneric_ChangeAttribute_Public_Action_AttributeDefinition_1_T_T_0<T>
		{
			// Token: 0x040015C9 RID: 5577
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UndoNode.NativeMethodInfoPtr_ChangeAttribute_Public_Action_AttributeDefinition_1_T_T_0, Il2CppClassPointerStore<UndoNode>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
