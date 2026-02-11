using System;
using dwd.core.notifications.messages.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;

namespace dwd.core.notifications
{
	// Token: 0x0200011B RID: 283
	public class INotificationsSource : Il2CppObjectBase
	{
		// Token: 0x0600100F RID: 4111 RVA: 0x000535D4 File Offset: 0x000517D4
		// Note: this type is marked as 'beforefieldinit'.
		static INotificationsSource()
		{
			Il2CppClassPointerStore<INotificationsSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.notifications", "INotificationsSource");
			INotificationsSource.NativeMethodInfoPtr_get_Initialized_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotificationsSource>.NativeClassPtr, 100665640);
			INotificationsSource.NativeMethodInfoPtr_get_All_Public_Abstract_Virtual_New_get_ReadOnlyCollection_1_Notification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotificationsSource>.NativeClassPtr, 100665641);
			INotificationsSource.NativeMethodInfoPtr_Acknowledge_Public_Abstract_Virtual_New_Void_Notification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotificationsSource>.NativeClassPtr, 100665642);
			INotificationsSource.NativeMethodInfoPtr_Request_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotificationsSource>.NativeClassPtr, 100665643);
			INotificationsSource.NativeMethodInfoPtr_get_RequestError_Public_Virtual_New_get_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotificationsSource>.NativeClassPtr, 100665644);
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x00053660 File Offset: 0x00051860
		public unsafe virtual bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INotificationsSource.NativeMethodInfoPtr_get_Initialized_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001011 RID: 4113 RVA: 0x000536A8 File Offset: 0x000518A8
		public unsafe virtual ReadOnlyCollection<Notification> All
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INotificationsSource.NativeMethodInfoPtr_get_All_Public_Abstract_Virtual_New_get_ReadOnlyCollection_1_Notification_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Notification>>(intPtr3) : null;
			}
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x000536F4 File Offset: 0x000518F4
		[CallerCount(0)]
		public unsafe virtual void Acknowledge(Notification notice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INotificationsSource.NativeMethodInfoPtr_Acknowledge_Public_Abstract_Virtual_New_Void_Notification_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x00053744 File Offset: 0x00051944
		[CallerCount(0)]
		public unsafe virtual void Request()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INotificationsSource.NativeMethodInfoPtr_Request_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x00053780 File Offset: 0x00051980
		public unsafe virtual ErrorInfo RequestError
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869361, XrefRangeEnd = 869365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INotificationsSource.NativeMethodInfoPtr_get_RequestError_Public_Virtual_New_get_ErrorInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ErrorInfo(intPtr);
			}
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x0000787A File Offset: 0x00005A7A
		public INotificationsSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeMethodInfoPtr_get_All_Public_Abstract_Virtual_New_get_ReadOnlyCollection_1_Notification_0;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeMethodInfoPtr_Acknowledge_Public_Abstract_Virtual_New_Void_Notification_0;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_Request_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestError_Public_Virtual_New_get_ErrorInfo_0;
	}
}
