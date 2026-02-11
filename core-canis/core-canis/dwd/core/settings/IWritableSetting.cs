using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings
{
	// Token: 0x020000B1 RID: 177
	public class IWritableSetting : Il2CppObjectBase
	{
		// Token: 0x06000B6B RID: 2923 RVA: 0x0003EF7C File Offset: 0x0003D17C
		// Note: this type is marked as 'beforefieldinit'.
		static IWritableSetting()
		{
			Il2CppClassPointerStore<IWritableSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings", "IWritableSetting");
			IWritableSetting.NativeMethodInfoPtr_Set_Public_Abstract_Virtual_New_ISaveSettingRequest_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWritableSetting>.NativeClassPtr, 100664885);
			IWritableSetting.NativeMethodInfoPtr_Delete_Public_Abstract_Virtual_New_ISaveSettingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWritableSetting>.NativeClassPtr, 100664886);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x0003EFCC File Offset: 0x0003D1CC
		[CallerCount(0)]
		public unsafe virtual ISaveSettingRequest Set(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWritableSetting.NativeMethodInfoPtr_Set_Public_Abstract_Virtual_New_ISaveSettingRequest_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0003F028 File Offset: 0x0003D228
		[CallerCount(0)]
		public unsafe virtual ISaveSettingRequest Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWritableSetting.NativeMethodInfoPtr_Delete_Public_Abstract_Virtual_New_ISaveSettingRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x000060A7 File Offset: 0x000042A7
		public IWritableSetting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Abstract_Virtual_New_ISaveSettingRequest_Object_0;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Abstract_Virtual_New_ISaveSettingRequest_0;
	}
}
