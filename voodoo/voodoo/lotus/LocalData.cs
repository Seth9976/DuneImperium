using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace lotus
{
	// Token: 0x02000048 RID: 72
	public class LocalData<T> : Il2CppObjectBase
	{
		// Token: 0x06000477 RID: 1143 RVA: 0x00017984 File Offset: 0x00015B84
		// Note: this type is marked as 'beforefieldinit'.
		static LocalData()
		{
			Il2CppClassPointerStore<LocalData<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "LocalData`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			LocalData<T>.NativeMethodInfoPtr_GetKey_Public_Abstract_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalData<T>>.NativeClassPtr, 100663821);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x000179FC File Offset: 0x00015BFC
		[CallerCount(0)]
		public unsafe virtual T GetKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalData<T>.NativeMethodInfoPtr_GetKey_Public_Abstract_Virtual_New_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x000044D4 File Offset: 0x000026D4
		public LocalData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_Abstract_Virtual_New_T_0;
	}
}
