using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace dwd.core.data.async
{
	// Token: 0x020001E6 RID: 486
	public class IAsyncData<T> : Il2CppObjectBase
	{
		// Token: 0x06001A96 RID: 6806 RVA: 0x0007DDFC File Offset: 0x0007BFFC
		// Note: this type is marked as 'beforefieldinit'.
		static IAsyncData()
		{
			Il2CppClassPointerStore<IAsyncData<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.async", "IAsyncData`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IAsyncData<T>.NativeMethodInfoPtr_get_Data_Public_Abstract_Virtual_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncData<T>>.NativeClassPtr, 100667515);
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06001A97 RID: 6807 RVA: 0x0007DE74 File Offset: 0x0007C074
		public unsafe virtual T Data
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncData<T>.NativeMethodInfoPtr_get_Data_Public_Abstract_Virtual_New_get_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x0000B755 File Offset: 0x00009955
		public IAsyncData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012AB RID: 4779
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Abstract_Virtual_New_get_T_0;
	}
}
