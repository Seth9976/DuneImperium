using System;
using Canis.utils.ids;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.match.selection
{
	// Token: 0x02000272 RID: 626
	public static class SimultaneousSelectionResponderUtil : Object
	{
		// Token: 0x06001D43 RID: 7491 RVA: 0x0007ECB8 File Offset: 0x0007CEB8
		// Note: this type is marked as 'beforefieldinit'.
		static SimultaneousSelectionResponderUtil()
		{
			Il2CppClassPointerStore<SimultaneousSelectionResponderUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "SimultaneousSelectionResponderUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimultaneousSelectionResponderUtil>.NativeClassPtr);
			SimultaneousSelectionResponderUtil.NativeMethodInfoPtr_GetSelectionHandlerForAccount_Public_Static_SelectionRootHandler_DBGSelectionResponder_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponderUtil>.NativeClassPtr, 100668110);
			SimultaneousSelectionResponderUtil.NativeMethodInfoPtr_GetSelectionHandlerForSelectionRoot_Public_Static_SelectionRootHandler_DBGSelectionResponder_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponderUtil>.NativeClassPtr, 100668111);
			SimultaneousSelectionResponderUtil.NativeMethodInfoPtr_GetAccountIDForSelectionRoot_Public_Static_AccountID_DBGSelectionResponder_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponderUtil>.NativeClassPtr, 100668112);
			SimultaneousSelectionResponderUtil.NativeMethodInfoPtr_HasSelectionForPlayer_Public_Static_Boolean_DBGSelectionResponder_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimultaneousSelectionResponderUtil>.NativeClassPtr, 100668113);
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x0007ED38 File Offset: 0x0007CF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536802, XrefRangeEnd = 536809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SelectionRootHandler GetSelectionHandlerForAccount(this DBGSelectionResponder responder, AccountID accountID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(responder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelectionResponderUtil.NativeMethodInfoPtr_GetSelectionHandlerForAccount_Public_Static_SelectionRootHandler_DBGSelectionResponder_AccountID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionRootHandler>(intPtr3) : null;
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x0007ED90 File Offset: 0x0007CF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536809, XrefRangeEnd = 536812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SelectionRootHandler GetSelectionHandlerForSelectionRoot(this DBGSelectionResponder responder, ISelectionRoot selectionRoot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(responder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectionRoot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelectionResponderUtil.NativeMethodInfoPtr_GetSelectionHandlerForSelectionRoot_Public_Static_SelectionRootHandler_DBGSelectionResponder_ISelectionRoot_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionRootHandler>(intPtr3) : null;
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x0007EDE8 File Offset: 0x0007CFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536812, XrefRangeEnd = 536830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AccountID GetAccountIDForSelectionRoot(this DBGSelectionResponder responder, ISelectionRoot selectionRoot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(responder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectionRoot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelectionResponderUtil.NativeMethodInfoPtr_GetAccountIDForSelectionRoot_Public_Static_AccountID_DBGSelectionResponder_ISelectionRoot_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x0007EE40 File Offset: 0x0007D040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 536830, XrefRangeEnd = 536833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasSelectionForPlayer(this DBGSelectionResponder responder, AccountID accountID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(responder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimultaneousSelectionResponderUtil.NativeMethodInfoPtr_HasSelectionForPlayer_Public_Static_Boolean_DBGSelectionResponder_AccountID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x0000F88F File Offset: 0x0000DA8F
		public SimultaneousSelectionResponderUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001278 RID: 4728
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectionHandlerForAccount_Public_Static_SelectionRootHandler_DBGSelectionResponder_AccountID_0;

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectionHandlerForSelectionRoot_Public_Static_SelectionRootHandler_DBGSelectionResponder_ISelectionRoot_0;

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeMethodInfoPtr_GetAccountIDForSelectionRoot_Public_Static_AccountID_DBGSelectionResponder_ISelectionRoot_0;

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeMethodInfoPtr_HasSelectionForPlayer_Public_Static_Boolean_DBGSelectionResponder_AccountID_0;
	}
}
