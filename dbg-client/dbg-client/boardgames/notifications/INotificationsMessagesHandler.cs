using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace boardgames.notifications
{
	// Token: 0x0200010B RID: 267
	public class INotificationsMessagesHandler : Il2CppObjectBase
	{
		// Token: 0x06000BC8 RID: 3016 RVA: 0x00007A51 File Offset: 0x00005C51
		// Note: this type is marked as 'beforefieldinit'.
		static INotificationsMessagesHandler()
		{
			Il2CppClassPointerStore<INotificationsMessagesHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.notifications", "INotificationsMessagesHandler");
			INotificationsMessagesHandler.NativeMethodInfoPtr_AddMessageHandlers_Public_Abstract_Virtual_New_Void_INotifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotificationsMessagesHandler>.NativeClassPtr, 100665057);
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x00042D74 File Offset: 0x00040F74
		[CallerCount(0)]
		public unsafe virtual void AddMessageHandlers(INotifications notifications)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notifications);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INotificationsMessagesHandler.NativeMethodInfoPtr_AddMessageHandlers_Public_Abstract_Virtual_New_Void_INotifications_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00007A80 File Offset: 0x00005C80
		public INotificationsMessagesHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr_AddMessageHandlers_Public_Abstract_Virtual_New_Void_INotifications_0;
	}
}
