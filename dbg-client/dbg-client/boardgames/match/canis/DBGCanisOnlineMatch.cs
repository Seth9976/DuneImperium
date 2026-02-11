using System;
using Canis.boardgames;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.match.canis
{
	// Token: 0x0200027E RID: 638
	public class DBGCanisOnlineMatch : CanisOnlineMatch
	{
		// Token: 0x06001DF5 RID: 7669 RVA: 0x00081794 File Offset: 0x0007F994
		// Note: this type is marked as 'beforefieldinit'.
		static DBGCanisOnlineMatch()
		{
			Il2CppClassPointerStore<DBGCanisOnlineMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.canis", "DBGCanisOnlineMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGCanisOnlineMatch>.NativeClassPtr);
			DBGCanisOnlineMatch.NativeMethodInfoPtr_GetLeaveMatchDueToError_Public_Virtual_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCanisOnlineMatch>.NativeClassPtr, 100668211);
			DBGCanisOnlineMatch.NativeMethodInfoPtr_GetLeaveMatchDueToIdleTimeout_Public_Virtual_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCanisOnlineMatch>.NativeClassPtr, 100668212);
			DBGCanisOnlineMatch.NativeMethodInfoPtr_reloadMatch_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCanisOnlineMatch>.NativeClassPtr, 100668213);
			DBGCanisOnlineMatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCanisOnlineMatch>.NativeClassPtr, 100668214);
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x00081814 File Offset: 0x0007FA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537977, XrefRangeEnd = 538034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Command GetLeaveMatchDueToError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGCanisOnlineMatch.NativeMethodInfoPtr_GetLeaveMatchDueToError_Public_Virtual_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x00081860 File Offset: 0x0007FA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538034, XrefRangeEnd = 538079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Command GetLeaveMatchDueToIdleTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGCanisOnlineMatch.NativeMethodInfoPtr_GetLeaveMatchDueToIdleTimeout_Public_Virtual_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x000818AC File Offset: 0x0007FAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538079, XrefRangeEnd = 538085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void reloadMatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGCanisOnlineMatch.NativeMethodInfoPtr_reloadMatch_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x000818E8 File Offset: 0x0007FAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538085, XrefRangeEnd = 538086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGCanisOnlineMatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGCanisOnlineMatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCanisOnlineMatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x0000FD24 File Offset: 0x0000DF24
		public DBGCanisOnlineMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeMethodInfoPtr_GetLeaveMatchDueToError_Public_Virtual_Command_0;

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeMethodInfoPtr_GetLeaveMatchDueToIdleTimeout_Public_Virtual_Command_0;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeMethodInfoPtr_reloadMatch_Protected_Virtual_Void_0;

		// Token: 0x040012F2 RID: 4850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
