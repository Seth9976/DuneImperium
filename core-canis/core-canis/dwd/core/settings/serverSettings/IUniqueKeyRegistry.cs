using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.settings.serverSettings
{
	// Token: 0x020000B7 RID: 183
	public class IUniqueKeyRegistry : Il2CppObjectBase
	{
		// Token: 0x06000B9D RID: 2973 RVA: 0x0000616C File Offset: 0x0000436C
		// Note: this type is marked as 'beforefieldinit'.
		static IUniqueKeyRegistry()
		{
			Il2CppClassPointerStore<IUniqueKeyRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.serverSettings", "IUniqueKeyRegistry");
			IUniqueKeyRegistry.NativeMethodInfoPtr_registerKey_Public_Abstract_Virtual_New_Void_Int32_ISettingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUniqueKeyRegistry>.NativeClassPtr, 100664909);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0003FE34 File Offset: 0x0003E034
		[CallerCount(0)]
		public unsafe virtual void registerKey(int key, ISettingDefinition setting)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setting);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUniqueKeyRegistry.NativeMethodInfoPtr_registerKey_Public_Abstract_Virtual_New_Void_Int32_ISettingDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0000619B File Offset: 0x0000439B
		public IUniqueKeyRegistry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr_registerKey_Public_Abstract_Virtual_New_Void_Int32_ISettingDefinition_0;
	}
}
