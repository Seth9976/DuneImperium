using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings
{
	// Token: 0x020000B3 RID: 179
	public class IWritableSettingDefinition<T> : Il2CppObjectBase
	{
		// Token: 0x06000B72 RID: 2930 RVA: 0x0003F180 File Offset: 0x0003D380
		// Note: this type is marked as 'beforefieldinit'.
		static IWritableSettingDefinition()
		{
			Il2CppClassPointerStore<IWritableSettingDefinition<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings", "IWritableSettingDefinition`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IWritableSettingDefinition<T>.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_IWritableSetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWritableSettingDefinition<T>>.NativeClassPtr, 100664888);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0003F1F8 File Offset: 0x0003D3F8
		[CallerCount(0)]
		public unsafe virtual IWritableSetting<T> Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWritableSettingDefinition<T>.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_IWritableSetting_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWritableSetting<T>>(intPtr3) : null;
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x000060B9 File Offset: 0x000042B9
		public IWritableSettingDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_IWritableSetting_1_T_0;
	}
}
