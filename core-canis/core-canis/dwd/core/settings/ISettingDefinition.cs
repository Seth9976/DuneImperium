using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.settings
{
	// Token: 0x020000AF RID: 175
	public class ISettingDefinition : Il2CppObjectBase
	{
		// Token: 0x06000B65 RID: 2917 RVA: 0x00006066 File Offset: 0x00004266
		// Note: this type is marked as 'beforefieldinit'.
		static ISettingDefinition()
		{
			Il2CppClassPointerStore<ISettingDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings", "ISettingDefinition");
			ISettingDefinition.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_ISetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingDefinition>.NativeClassPtr, 100664883);
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0003EE6C File Offset: 0x0003D06C
		[CallerCount(0)]
		public unsafe virtual ISetting Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISettingDefinition.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_ISetting_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISetting>(intPtr3) : null;
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00006095 File Offset: 0x00004295
		public ISettingDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_ISetting_0;
	}
}
