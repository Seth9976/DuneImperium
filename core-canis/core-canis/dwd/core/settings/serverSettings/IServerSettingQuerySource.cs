using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings.serverSettings
{
	// Token: 0x020000B6 RID: 182
	public class IServerSettingQuerySource<T> : Il2CppObjectBase
	{
		// Token: 0x06000B9A RID: 2970 RVA: 0x0003FD64 File Offset: 0x0003DF64
		// Note: this type is marked as 'beforefieldinit'.
		static IServerSettingQuerySource()
		{
			Il2CppClassPointerStore<IServerSettingQuerySource<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.serverSettings", "IServerSettingQuerySource`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IServerSettingQuerySource<T>.NativeMethodInfoPtr_GetServerSettingByKey_Public_Abstract_Virtual_New_ServerSetting_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IServerSettingQuerySource<T>>.NativeClassPtr, 100664908);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0003FDDC File Offset: 0x0003DFDC
		[CallerCount(0)]
		public unsafe virtual ServerSetting<T> GetServerSettingByKey(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IServerSettingQuerySource<T>.NativeMethodInfoPtr_GetServerSettingByKey_Public_Abstract_Virtual_New_ServerSetting_1_T_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerSetting<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00006163 File Offset: 0x00004363
		public IServerSettingQuerySource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_GetServerSettingByKey_Public_Abstract_Virtual_New_ServerSetting_1_T_Int32_0;
	}
}
