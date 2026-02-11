using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004F9 RID: 1273
	public sealed class StackDebugView<T> : Object
	{
		// Token: 0x06004EA7 RID: 20135 RVA: 0x0016D2B0 File Offset: 0x0016B4B0
		// Note: this type is marked as 'beforefieldinit'.
		static StackDebugView()
		{
			Il2CppClassPointerStore<StackDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "StackDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x06004EA8 RID: 20136 RVA: 0x0001C660 File Offset: 0x0001A860
		public StackDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
