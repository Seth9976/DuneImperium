using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004F7 RID: 1271
	public sealed class QueueDebugView<T> : Object
	{
		// Token: 0x06004E88 RID: 20104 RVA: 0x0016CA78 File Offset: 0x0016AC78
		// Note: this type is marked as 'beforefieldinit'.
		static QueueDebugView()
		{
			Il2CppClassPointerStore<QueueDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "QueueDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueueDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x06004E89 RID: 20105 RVA: 0x0001C5CC File Offset: 0x0001A7CC
		public QueueDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
