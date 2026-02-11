using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Events;

namespace dwd.core
{
	// Token: 0x02000033 RID: 51
	[Serializable]
	public class UnityEventTwoParam<T0, T1> : UnityEvent<T0, T1>
	{
		// Token: 0x06000187 RID: 391 RVA: 0x0000BC94 File Offset: 0x00009E94
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventTwoParam()
		{
			Il2CppClassPointerStore<UnityEventTwoParam<T0, T1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core", "UnityEventTwoParam`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventTwoParam<T0, T1>>.NativeClassPtr);
			UnityEventTwoParam<T0, T1>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventTwoParam<T0, T1>>.NativeClassPtr, 100663506);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000BD28 File Offset: 0x00009F28
		[CallerCount(0)]
		public unsafe UnityEventTwoParam()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventTwoParam<T0, T1>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventTwoParam<T0, T1>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002E66 File Offset: 0x00001066
		public UnityEventTwoParam(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
