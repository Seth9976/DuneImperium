using System;
using Canis.actions;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.undo
{
	// Token: 0x02000034 RID: 52
	public class IHasUndoableActions : Il2CppObjectBase
	{
		// Token: 0x06000352 RID: 850 RVA: 0x000268B8 File Offset: 0x00024AB8
		// Note: this type is marked as 'beforefieldinit'.
		static IHasUndoableActions()
		{
			Il2CppClassPointerStore<IHasUndoableActions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.undo", "IHasUndoableActions");
			IHasUndoableActions.NativeMethodInfoPtr_GetUndoEntity_Public_Abstract_Virtual_New_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasUndoableActions>.NativeClassPtr, 100664007);
			IHasUndoableActions.NativeMethodInfoPtr_GetRedoEntity_Public_Abstract_Virtual_New_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasUndoableActions>.NativeClassPtr, 100664008);
			IHasUndoableActions.NativeMethodInfoPtr_GameSpecificUndoIsAvailable_Public_Abstract_Virtual_New_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasUndoableActions>.NativeClassPtr, 100664009);
			IHasUndoableActions.NativeMethodInfoPtr_GameSpecificUndoBehavior_Public_Abstract_Virtual_New_IEnumerable_1_Action_PlayerEntity_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasUndoableActions>.NativeClassPtr, 100664010);
			IHasUndoableActions.NativeMethodInfoPtr_AddUndoNode_Public_Abstract_Virtual_New_Action_UndoNode_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasUndoableActions>.NativeClassPtr, 100664011);
			IHasUndoableActions.NativeMethodInfoPtr_RemoveUndoNode_Public_Abstract_Virtual_New_Action_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasUndoableActions>.NativeClassPtr, 100664012);
			IHasUndoableActions.NativeMethodInfoPtr_get_UseAttributeUndo_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasUndoableActions>.NativeClassPtr, 100664013);
			IHasUndoableActions.NativeMethodInfoPtr_get_StoreLastCompletedSelection_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasUndoableActions>.NativeClassPtr, 100664014);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00026980 File Offset: 0x00024B80
		[CallerCount(0)]
		public unsafe virtual Entity GetUndoEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasUndoableActions.NativeMethodInfoPtr_GetUndoEntity_Public_Abstract_Virtual_New_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x000269CC File Offset: 0x00024BCC
		[CallerCount(0)]
		public unsafe virtual Entity GetRedoEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasUndoableActions.NativeMethodInfoPtr_GetRedoEntity_Public_Abstract_Virtual_New_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00026A18 File Offset: 0x00024C18
		[CallerCount(0)]
		public unsafe virtual bool GameSpecificUndoIsAvailable(PlayerEntity selectingPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasUndoableActions.NativeMethodInfoPtr_GameSpecificUndoIsAvailable_Public_Abstract_Virtual_New_Boolean_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00026A70 File Offset: 0x00024C70
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Action> GameSpecificUndoBehavior(PlayerEntity undoPlayer, UndoNode undoNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoPlayer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(undoNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasUndoableActions.NativeMethodInfoPtr_GameSpecificUndoBehavior_Public_Abstract_Virtual_New_IEnumerable_1_Action_PlayerEntity_UndoNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00026AE0 File Offset: 0x00024CE0
		[CallerCount(0)]
		public unsafe virtual Action AddUndoNode(UndoNode undoNode, UndoNode parentUndoNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentUndoNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasUndoableActions.NativeMethodInfoPtr_AddUndoNode_Public_Abstract_Virtual_New_Action_UndoNode_UndoNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00026B50 File Offset: 0x00024D50
		[CallerCount(0)]
		public unsafe virtual Action RemoveUndoNode(UndoNode undoNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasUndoableActions.NativeMethodInfoPtr_RemoveUndoNode_Public_Abstract_Virtual_New_Action_UndoNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000359 RID: 857 RVA: 0x00026BAC File Offset: 0x00024DAC
		public unsafe virtual bool UseAttributeUndo
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasUndoableActions.NativeMethodInfoPtr_get_UseAttributeUndo_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00026BF4 File Offset: 0x00024DF4
		public unsafe virtual bool StoreLastCompletedSelection
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasUndoableActions.NativeMethodInfoPtr_get_StoreLastCompletedSelection_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x000037CD File Offset: 0x000019CD
		public IHasUndoableActions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_GetUndoEntity_Public_Abstract_Virtual_New_Entity_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_GetRedoEntity_Public_Abstract_Virtual_New_Entity_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_GameSpecificUndoIsAvailable_Public_Abstract_Virtual_New_Boolean_PlayerEntity_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_GameSpecificUndoBehavior_Public_Abstract_Virtual_New_IEnumerable_1_Action_PlayerEntity_UndoNode_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_AddUndoNode_Public_Abstract_Virtual_New_Action_UndoNode_UndoNode_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_RemoveUndoNode_Public_Abstract_Virtual_New_Action_UndoNode_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_get_UseAttributeUndo_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_get_StoreLastCompletedSelection_Public_Virtual_New_get_Boolean_0;
	}
}
