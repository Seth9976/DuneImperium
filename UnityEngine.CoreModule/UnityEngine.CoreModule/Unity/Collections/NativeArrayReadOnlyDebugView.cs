using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000040 RID: 64
	public sealed class NativeArrayReadOnlyDebugView<T> : Object where T : new()
	{
		// Token: 0x06000240 RID: 576 RVA: 0x0001C258 File Offset: 0x0001A458
		// Note: this type is marked as 'beforefieldinit'.
		static NativeArrayReadOnlyDebugView()
		{
			Il2CppClassPointerStore<NativeArrayReadOnlyDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeArrayReadOnlyDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayReadOnlyDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000032A7 File Offset: 0x000014A7
		public NativeArrayReadOnlyDebugView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000242 RID: 578 RVA: 0x000032B0 File Offset: 0x000014B0
		public Il2CppArrayBase<T> Items
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
