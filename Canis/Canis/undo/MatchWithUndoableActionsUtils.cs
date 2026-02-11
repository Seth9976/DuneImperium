using System;
using Canis.actions;
using Canis.actions.serialized;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Canis.undo
{
	// Token: 0x02000035 RID: 53
	public static class MatchWithUndoableActionsUtils : Object
	{
		// Token: 0x0600035C RID: 860 RVA: 0x00026C3C File Offset: 0x00024E3C
		// Note: this type is marked as 'beforefieldinit'.
		static MatchWithUndoableActionsUtils()
		{
			Il2CppClassPointerStore<MatchWithUndoableActionsUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.undo", "MatchWithUndoableActionsUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchWithUndoableActionsUtils>.NativeClassPtr);
			MatchWithUndoableActionsUtils.NativeMethodInfoPtr_CreateNewUndoEntry_Public_Static_Action_Match_PlayerEntity_AbilityDefinition_byref_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchWithUndoableActionsUtils>.NativeClassPtr, 100664015);
			MatchWithUndoableActionsUtils.NativeMethodInfoPtr_CreateNewUndoEntry_Public_Static_Action_Match_PlayerEntity_Action_byref_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchWithUndoableActionsUtils>.NativeClassPtr, 100664016);
			MatchWithUndoableActionsUtils.NativeMethodInfoPtr_CreateNewUndoEntry_Public_Static_Action_Match_PlayerEntity_SerializedAction_byref_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchWithUndoableActionsUtils>.NativeClassPtr, 100664017);
			MatchWithUndoableActionsUtils.NativeMethodInfoPtr_CreateChildUndoEntry_Public_Static_Action_Match_PlayerEntity_UndoNode_AbilityDefinition_byref_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchWithUndoableActionsUtils>.NativeClassPtr, 100664018);
			MatchWithUndoableActionsUtils.NativeMethodInfoPtr_CreateChildUndoEntry_Public_Static_Action_Match_PlayerEntity_UndoNode_Action_byref_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchWithUndoableActionsUtils>.NativeClassPtr, 100664019);
			MatchWithUndoableActionsUtils.NativeMethodInfoPtr_CreateChildUndoEntry_Public_Static_Action_Match_PlayerEntity_UndoNode_SerializedAction_byref_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchWithUndoableActionsUtils>.NativeClassPtr, 100664020);
			MatchWithUndoableActionsUtils.NativeMethodInfoPtr_GetLatestUndoNode_Public_Static_UndoNode_MatchWithUndos_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchWithUndoableActionsUtils>.NativeClassPtr, 100664021);
			MatchWithUndoableActionsUtils.NativeMethodInfoPtr_GetLatestUndoNode_Public_Static_UndoNode_IHasUndoableActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchWithUndoableActionsUtils>.NativeClassPtr, 100664022);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00026D0C File Offset: 0x00024F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549729, XrefRangeEnd = 549747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action CreateNewUndoEntry(this Match match, PlayerEntity player, AbilityDefinition undoAbility, out UndoNode undoNode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(undoAbility);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MatchWithUndoableActionsUtils.NativeMethodInfoPtr_CreateNewUndoEntry_Public_Static_Action_Match_PlayerEntity_AbilityDefinition_byref_UndoNode_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			undoNode = ((intPtr4 == 0) ? null : new UndoNode(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr5) : null;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00026D98 File Offset: 0x00024F98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 549748, RefRangeEnd = 549749, XrefRangeStart = 549747, XrefRangeEnd = 549748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action CreateNewUndoEntry(this Match match, PlayerEntity player, Canis.actions.Action actionToUndo, out UndoNode undoNode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionToUndo);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MatchWithUndoableActionsUtils.NativeMethodInfoPtr_CreateNewUndoEntry_Public_Static_Action_Match_PlayerEntity_Action_byref_UndoNode_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			undoNode = ((intPtr4 == 0) ? null : new UndoNode(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr5) : null;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00026E24 File Offset: 0x00025024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549749, XrefRangeEnd = 549767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action CreateNewUndoEntry(this Match match, PlayerEntity player, SerializedAction actionToUndo, out UndoNode undoNode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionToUndo);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MatchWithUndoableActionsUtils.NativeMethodInfoPtr_CreateNewUndoEntry_Public_Static_Action_Match_PlayerEntity_SerializedAction_byref_UndoNode_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			undoNode = ((intPtr4 == 0) ? null : new UndoNode(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr5) : null;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00026EB0 File Offset: 0x000250B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 549785, RefRangeEnd = 549786, XrefRangeStart = 549767, XrefRangeEnd = 549785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action CreateChildUndoEntry(this Match match, PlayerEntity player, UndoNode parentUndoNode, AbilityDefinition undoAbility, out UndoNode undoNode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentUndoNode);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(undoAbility);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MatchWithUndoableActionsUtils.NativeMethodInfoPtr_CreateChildUndoEntry_Public_Static_Action_Match_PlayerEntity_UndoNode_AbilityDefinition_byref_UndoNode_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			undoNode = ((intPtr4 == 0) ? null : new UndoNode(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr5) : null;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00026F50 File Offset: 0x00025150
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 549804, RefRangeEnd = 549842, XrefRangeStart = 549786, XrefRangeEnd = 549804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action CreateChildUndoEntry(this Match match, PlayerEntity player, UndoNode parentUndoNode, Canis.actions.Action actionToUndo, out UndoNode undoNode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentUndoNode);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionToUndo);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MatchWithUndoableActionsUtils.NativeMethodInfoPtr_CreateChildUndoEntry_Public_Static_Action_Match_PlayerEntity_UndoNode_Action_byref_UndoNode_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			undoNode = ((intPtr4 == 0) ? null : new UndoNode(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr5) : null;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00026FF0 File Offset: 0x000251F0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 549860, RefRangeEnd = 549865, XrefRangeStart = 549842, XrefRangeEnd = 549860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Canis.actions.Action CreateChildUndoEntry(this Match match, PlayerEntity player, UndoNode parentUndoNode, SerializedAction actionToUndo, out UndoNode undoNode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentUndoNode);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionToUndo);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MatchWithUndoableActionsUtils.NativeMethodInfoPtr_CreateChildUndoEntry_Public_Static_Action_Match_PlayerEntity_UndoNode_SerializedAction_byref_UndoNode_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			undoNode = ((intPtr4 == 0) ? null : new UndoNode(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr5) : null;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00027090 File Offset: 0x00025290
		[CallerCount(86)]
		[CachedScanResults(RefRangeStart = 549866, RefRangeEnd = 549952, XrefRangeStart = 549865, XrefRangeEnd = 549866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UndoNode GetLatestUndoNode<MatchWithUndos>(this MatchWithUndos hua) where MatchWithUndos : Match
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(MatchWithUndos).IsValueType)
				{
					MatchWithUndos matchWithUndos = hua;
					intPtr = ((matchWithUndos is string) ? IL2CPP.ManagedStringToIl2Cpp(matchWithUndos as string) : IL2CPP.Il2CppObjectBaseToPtr(matchWithUndos as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref hua;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MatchWithUndoableActionsUtils.MethodInfoStoreGeneric_GetLatestUndoNode_Public_Static_UndoNode_MatchWithUndos_0<MatchWithUndos>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr4) : null;
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0002710C File Offset: 0x0002530C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 549960, RefRangeEnd = 549963, XrefRangeStart = 549952, XrefRangeEnd = 549960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UndoNode GetLatestUndoNode(this IHasUndoableActions hua)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hua);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchWithUndoableActionsUtils.NativeMethodInfoPtr_GetLatestUndoNode_Public_Static_UndoNode_IHasUndoableActions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x000037D6 File Offset: 0x000019D6
		public MatchWithUndoableActionsUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_CreateNewUndoEntry_Public_Static_Action_Match_PlayerEntity_AbilityDefinition_byref_UndoNode_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_CreateNewUndoEntry_Public_Static_Action_Match_PlayerEntity_Action_byref_UndoNode_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_CreateNewUndoEntry_Public_Static_Action_Match_PlayerEntity_SerializedAction_byref_UndoNode_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_CreateChildUndoEntry_Public_Static_Action_Match_PlayerEntity_UndoNode_AbilityDefinition_byref_UndoNode_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_CreateChildUndoEntry_Public_Static_Action_Match_PlayerEntity_UndoNode_Action_byref_UndoNode_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_CreateChildUndoEntry_Public_Static_Action_Match_PlayerEntity_UndoNode_SerializedAction_byref_UndoNode_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_GetLatestUndoNode_Public_Static_UndoNode_MatchWithUndos_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_GetLatestUndoNode_Public_Static_UndoNode_IHasUndoableActions_0;

		// Token: 0x02000282 RID: 642
		private sealed class MethodInfoStoreGeneric_GetLatestUndoNode_Public_Static_UndoNode_MatchWithUndos_0<MatchWithUndos>
		{
			// Token: 0x04001168 RID: 4456
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MatchWithUndoableActionsUtils.NativeMethodInfoPtr_GetLatestUndoNode_Public_Static_UndoNode_MatchWithUndos_0, Il2CppClassPointerStore<MatchWithUndoableActionsUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MatchWithUndos>.NativeClassPtr)) }))));
		}
	}
}
