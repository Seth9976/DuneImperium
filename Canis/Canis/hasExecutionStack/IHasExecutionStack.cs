using System;
using Canis.actions;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.hasExecutionStack
{
	// Token: 0x0200008C RID: 140
	public class IHasExecutionStack : Il2CppObjectBase
	{
		// Token: 0x06000765 RID: 1893 RVA: 0x000376FC File Offset: 0x000358FC
		// Note: this type is marked as 'beforefieldinit'.
		static IHasExecutionStack()
		{
			Il2CppClassPointerStore<IHasExecutionStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.hasExecutionStack", "IHasExecutionStack");
			IHasExecutionStack.NativeMethodInfoPtr_PushAction_Public_Abstract_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasExecutionStack>.NativeClassPtr, 100664826);
			IHasExecutionStack.NativeMethodInfoPtr_Run_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasExecutionStack>.NativeClassPtr, 100664827);
			IHasExecutionStack.NativeMethodInfoPtr_HasPendingResponses_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasExecutionStack>.NativeClassPtr, 100664828);
			IHasExecutionStack.NativeMethodInfoPtr_HasPendingResponse_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasExecutionStack>.NativeClassPtr, 100664829);
			IHasExecutionStack.NativeMethodInfoPtr_GetPlayerEntityForCounter_Public_Abstract_Virtual_New_PlayerEntity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasExecutionStack>.NativeClassPtr, 100664830);
			IHasExecutionStack.NativeMethodInfoPtr_GetCounterForPlayerEntity_Public_Abstract_Virtual_New_Int32_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasExecutionStack>.NativeClassPtr, 100664831);
			IHasExecutionStack.NativeMethodInfoPtr_ConsumeCounter_Public_Abstract_Virtual_New_Boolean_Int32_Object_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasExecutionStack>.NativeClassPtr, 100664832);
			IHasExecutionStack.NativeMethodInfoPtr_CancelPendingResponse_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasExecutionStack>.NativeClassPtr, 100664833);
			IHasExecutionStack.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasExecutionStack>.NativeClassPtr, 100664834);
			IHasExecutionStack.NativeMethodInfoPtr_IsInSelectionLoop_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasExecutionStack>.NativeClassPtr, 100664835);
			IHasExecutionStack.NativeMethodInfoPtr_DumpPendingResponses_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasExecutionStack>.NativeClassPtr, 100664836);
			IHasExecutionStack.NativeMethodInfoPtr_DebugInfo_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasExecutionStack>.NativeClassPtr, 100664837);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00037814 File Offset: 0x00035A14
		[CallerCount(0)]
		public unsafe virtual void PushAction(Canis.actions.Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasExecutionStack.NativeMethodInfoPtr_PushAction_Public_Abstract_Virtual_New_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00037864 File Offset: 0x00035A64
		[CallerCount(0)]
		public unsafe virtual void Run(bool allowSaves = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allowSaves;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasExecutionStack.NativeMethodInfoPtr_Run_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x000378B0 File Offset: 0x00035AB0
		[CallerCount(0)]
		public unsafe virtual bool HasPendingResponses()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasExecutionStack.NativeMethodInfoPtr_HasPendingResponses_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x000378F8 File Offset: 0x00035AF8
		[CallerCount(0)]
		public unsafe virtual bool HasPendingResponse(int selectionCounter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selectionCounter;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasExecutionStack.NativeMethodInfoPtr_HasPendingResponse_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0003794C File Offset: 0x00035B4C
		[CallerCount(0)]
		public unsafe virtual PlayerEntity GetPlayerEntityForCounter(int selectionCounter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selectionCounter;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasExecutionStack.NativeMethodInfoPtr_GetPlayerEntityForCounter_Public_Abstract_Virtual_New_PlayerEntity_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
			}
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x000379A4 File Offset: 0x00035BA4
		[CallerCount(0)]
		public unsafe virtual int GetCounterForPlayerEntity(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasExecutionStack.NativeMethodInfoPtr_GetCounterForPlayerEntity_Public_Abstract_Virtual_New_Int32_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x000379FC File Offset: 0x00035BFC
		[CallerCount(0)]
		public unsafe virtual bool ConsumeCounter(int counter, Object response, PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref counter;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(response);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasExecutionStack.NativeMethodInfoPtr_ConsumeCounter_Public_Abstract_Virtual_New_Boolean_Int32_Object_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00037A74 File Offset: 0x00035C74
		[CallerCount(0)]
		public unsafe virtual bool CancelPendingResponse(int counter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref counter;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasExecutionStack.NativeMethodInfoPtr_CancelPendingResponse_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00037AC8 File Offset: 0x00035CC8
		[CallerCount(0)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasExecutionStack.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00037B04 File Offset: 0x00035D04
		[CallerCount(0)]
		public unsafe virtual bool IsInSelectionLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasExecutionStack.NativeMethodInfoPtr_IsInSelectionLoop_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00037B4C File Offset: 0x00035D4C
		[CallerCount(0)]
		public unsafe virtual string DumpPendingResponses()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasExecutionStack.NativeMethodInfoPtr_DumpPendingResponses_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00037B90 File Offset: 0x00035D90
		[CallerCount(0)]
		public unsafe virtual string DebugInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasExecutionStack.NativeMethodInfoPtr_DebugInfo_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00004D3A File Offset: 0x00002F3A
		public IHasExecutionStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_PushAction_Public_Abstract_Virtual_New_Void_Action_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_HasPendingResponses_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr_HasPendingResponse_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerEntityForCounter_Public_Abstract_Virtual_New_PlayerEntity_Int32_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_GetCounterForPlayerEntity_Public_Abstract_Virtual_New_Int32_PlayerEntity_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeCounter_Public_Abstract_Virtual_New_Boolean_Int32_Object_PlayerEntity_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_CancelPendingResponse_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr_IsInSelectionLoop_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_DumpPendingResponses_Public_Abstract_Virtual_New_String_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_DebugInfo_Public_Abstract_Virtual_New_String_0;
	}
}
