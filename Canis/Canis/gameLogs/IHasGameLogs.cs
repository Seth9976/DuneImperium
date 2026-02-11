using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.gameLogs
{
	// Token: 0x020000A4 RID: 164
	public class IHasGameLogs : Il2CppObjectBase
	{
		// Token: 0x060007EF RID: 2031 RVA: 0x000397B0 File Offset: 0x000379B0
		// Note: this type is marked as 'beforefieldinit'.
		static IHasGameLogs()
		{
			Il2CppClassPointerStore<IHasGameLogs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.gameLogs", "IHasGameLogs");
			IHasGameLogs.NativeMethodInfoPtr_get_StoredGameLogs_Public_Abstract_Virtual_New_get_IEnumerable_1_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasGameLogs>.NativeClassPtr, 100664922);
			IHasGameLogs.NativeMethodInfoPtr_GetStoredLog_Public_Abstract_Virtual_New_SerializedGameLog_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasGameLogs>.NativeClassPtr, 100664923);
			IHasGameLogs.NativeMethodInfoPtr_StoreGameLog_Public_Abstract_Virtual_New_SerializedGameLog_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasGameLogs>.NativeClassPtr, 100664924);
			IHasGameLogs.NativeMethodInfoPtr_StoreGameLog_Public_Abstract_Virtual_New_Boolean_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasGameLogs>.NativeClassPtr, 100664925);
			IHasGameLogs.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Abstract_Virtual_New_GameLogBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasGameLogs>.NativeClassPtr, 100664926);
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x0003983C File Offset: 0x00037A3C
		public unsafe virtual IEnumerable<SerializedGameLog> StoredGameLogs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasGameLogs.NativeMethodInfoPtr_get_StoredGameLogs_Public_Abstract_Virtual_New_get_IEnumerable_1_SerializedGameLog_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SerializedGameLog>>(intPtr3) : null;
			}
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00039888 File Offset: 0x00037A88
		[CallerCount(0)]
		public unsafe virtual SerializedGameLog GetStoredLog(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasGameLogs.NativeMethodInfoPtr_GetStoredLog_Public_Abstract_Virtual_New_SerializedGameLog_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr3) : null;
			}
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x000398E0 File Offset: 0x00037AE0
		[CallerCount(0)]
		public unsafe virtual SerializedGameLog StoreGameLog(GameLogBuilder logBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasGameLogs.NativeMethodInfoPtr_StoreGameLog_Public_Abstract_Virtual_New_SerializedGameLog_GameLogBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr3) : null;
			}
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0003993C File Offset: 0x00037B3C
		[CallerCount(0)]
		public unsafe virtual bool StoreGameLog(SerializedGameLog log)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(log);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasGameLogs.NativeMethodInfoPtr_StoreGameLog_Public_Abstract_Virtual_New_Boolean_SerializedGameLog_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00039994 File Offset: 0x00037B94
		[CallerCount(0)]
		public unsafe virtual GameLogBuilder MakeGameLogBuilder(string logToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(logToken);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasGameLogs.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Abstract_Virtual_New_GameLogBuilder_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x000051A0 File Offset: 0x000033A0
		public IHasGameLogs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_get_StoredGameLogs_Public_Abstract_Virtual_New_get_IEnumerable_1_SerializedGameLog_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_GetStoredLog_Public_Abstract_Virtual_New_SerializedGameLog_Int32_0;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_StoreGameLog_Public_Abstract_Virtual_New_SerializedGameLog_GameLogBuilder_0;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeMethodInfoPtr_StoreGameLog_Public_Abstract_Virtual_New_Boolean_SerializedGameLog_0;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Abstract_Virtual_New_GameLogBuilder_String_0;
	}
}
