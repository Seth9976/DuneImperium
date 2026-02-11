using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.settings
{
	// Token: 0x020000AA RID: 170
	public class ISaveSettingRequest : Il2CppObjectBase
	{
		// Token: 0x06000B54 RID: 2900 RVA: 0x0003EAAC File Offset: 0x0003CCAC
		// Note: this type is marked as 'beforefieldinit'.
		static ISaveSettingRequest()
		{
			Il2CppClassPointerStore<ISaveSettingRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings", "ISaveSettingRequest");
			ISaveSettingRequest.NativeMethodInfoPtr_get_Completed_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveSettingRequest>.NativeClassPtr, 100664876);
			ISaveSettingRequest.NativeMethodInfoPtr_get_Success_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveSettingRequest>.NativeClassPtr, 100664877);
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x0003EAFC File Offset: 0x0003CCFC
		public unsafe virtual bool Completed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveSettingRequest.NativeMethodInfoPtr_get_Completed_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x0003EB44 File Offset: 0x0003CD44
		public unsafe virtual bool Success
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveSettingRequest.NativeMethodInfoPtr_get_Success_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0000600A File Offset: 0x0000420A
		public ISaveSettingRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr_get_Completed_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr_get_Success_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
