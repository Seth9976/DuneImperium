using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace dwd.core.settings
{
	// Token: 0x020000AE RID: 174
	public class ISetting<T> : Il2CppObjectBase
	{
		// Token: 0x06000B62 RID: 2914 RVA: 0x0003EDB0 File Offset: 0x0003CFB0
		// Note: this type is marked as 'beforefieldinit'.
		static ISetting()
		{
			Il2CppClassPointerStore<ISetting<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings", "ISetting`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			ISetting<T>.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISetting<T>>.NativeClassPtr, 100664882);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0003EE28 File Offset: 0x0003D028
		[CallerCount(0)]
		public unsafe virtual T Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISetting<T>.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0000605D File Offset: 0x0000425D
		public ISetting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_T_0;
	}
}
