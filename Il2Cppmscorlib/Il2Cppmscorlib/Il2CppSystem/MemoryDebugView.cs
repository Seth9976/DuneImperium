using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x020000C4 RID: 196
	public sealed class MemoryDebugView<T> : Object
	{
		// Token: 0x06000CE1 RID: 3297 RVA: 0x00061674 File Offset: 0x0005F874
		// Note: this type is marked as 'beforefieldinit'.
		static MemoryDebugView()
		{
			Il2CppClassPointerStore<MemoryDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MemoryDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00005277 File Offset: 0x00003477
		public MemoryDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
