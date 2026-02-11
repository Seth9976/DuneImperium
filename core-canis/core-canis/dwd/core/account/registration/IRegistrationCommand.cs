using System;
using dwd.core.account.messages;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.account.registration
{
	// Token: 0x02000222 RID: 546
	public class IRegistrationCommand : Il2CppObjectBase
	{
		// Token: 0x06001DC2 RID: 7618 RVA: 0x00089538 File Offset: 0x00087738
		// Note: this type is marked as 'beforefieldinit'.
		static IRegistrationCommand()
		{
			Il2CppClassPointerStore<IRegistrationCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.account.registration", "IRegistrationCommand");
			IRegistrationCommand.NativeMethodInfoPtr_get_Response_Public_Abstract_Virtual_New_get_WebResponseData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRegistrationCommand>.NativeClassPtr, 100668079);
			IRegistrationCommand.NativeMethodInfoPtr_get_ErrorDetails_Public_Abstract_Virtual_New_get_RegistrationResponseError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRegistrationCommand>.NativeClassPtr, 100668080);
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x00089588 File Offset: 0x00087788
		public unsafe virtual DwdWebRequestCommand.WebResponseData Response
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRegistrationCommand.NativeMethodInfoPtr_get_Response_Public_Abstract_Virtual_New_get_WebResponseData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DwdWebRequestCommand.WebResponseData(intPtr);
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x000895CC File Offset: 0x000877CC
		public unsafe virtual RegistrationResponseError ErrorDetails
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRegistrationCommand.NativeMethodInfoPtr_get_ErrorDetails_Public_Abstract_Virtual_New_get_RegistrationResponseError_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistrationResponseError>(intPtr3) : null;
			}
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x0000CAFE File Offset: 0x0000ACFE
		public IRegistrationCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014D1 RID: 5329
		private static readonly IntPtr NativeMethodInfoPtr_get_Response_Public_Abstract_Virtual_New_get_WebResponseData_0;

		// Token: 0x040014D2 RID: 5330
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorDetails_Public_Abstract_Virtual_New_get_RegistrationResponseError_0;
	}
}
