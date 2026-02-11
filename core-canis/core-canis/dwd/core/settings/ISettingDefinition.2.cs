using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings
{
	// Token: 0x020000B0 RID: 176
	public class ISettingDefinition<T> : Il2CppObjectBase
	{
		// Token: 0x06000B68 RID: 2920 RVA: 0x0003EEB8 File Offset: 0x0003D0B8
		// Note: this type is marked as 'beforefieldinit'.
		static ISettingDefinition()
		{
			Il2CppClassPointerStore<ISettingDefinition<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings", "ISettingDefinition`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			ISettingDefinition<T>.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_ISetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingDefinition<T>>.NativeClassPtr, 100664884);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0003EF30 File Offset: 0x0003D130
		[CallerCount(0)]
		public unsafe virtual ISetting<T> Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISettingDefinition<T>.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_ISetting_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISetting<T>>(intPtr3) : null;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0000609E File Offset: 0x0000429E
		public ISettingDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_ISetting_1_T_0;
	}
}
