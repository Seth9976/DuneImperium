using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings
{
	// Token: 0x020000AD RID: 173
	public class ISetting : Il2CppObjectBase
	{
		// Token: 0x06000B5F RID: 2911 RVA: 0x00006025 File Offset: 0x00004225
		// Note: this type is marked as 'beforefieldinit'.
		static ISetting()
		{
			Il2CppClassPointerStore<ISetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings", "ISetting");
			ISetting.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISetting>.NativeClassPtr, 100664881);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0003ED64 File Offset: 0x0003CF64
		[CallerCount(0)]
		public unsafe virtual Object Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISetting.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00006054 File Offset: 0x00004254
		public ISetting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_Object_0;
	}
}
