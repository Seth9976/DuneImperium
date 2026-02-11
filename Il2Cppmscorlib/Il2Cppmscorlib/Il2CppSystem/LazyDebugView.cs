using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x020000BE RID: 190
	public sealed class LazyDebugView<T> : Object
	{
		// Token: 0x06000C6B RID: 3179 RVA: 0x0005F2E0 File Offset: 0x0005D4E0
		// Note: this type is marked as 'beforefieldinit'.
		static LazyDebugView()
		{
			Il2CppClassPointerStore<LazyDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "LazyDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LazyDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0000518C File Offset: 0x0000338C
		public LazyDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
