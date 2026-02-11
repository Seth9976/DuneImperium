using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x020000E3 RID: 227
	public sealed class SpanDebugView<T> : Object
	{
		// Token: 0x06000ED3 RID: 3795 RVA: 0x0006B024 File Offset: 0x00069224
		// Note: this type is marked as 'beforefieldinit'.
		static SpanDebugView()
		{
			Il2CppClassPointerStore<SpanDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "SpanDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpanDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0000594A File Offset: 0x00003B4A
		public SpanDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
