using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x0200003F RID: 63
	public sealed class NativeArrayDebugView<T> : Object where T : new()
	{
		// Token: 0x0600023D RID: 573 RVA: 0x0001C1EC File Offset: 0x0001A3EC
		// Note: this type is marked as 'beforefieldinit'.
		static NativeArrayDebugView()
		{
			Il2CppClassPointerStore<NativeArrayDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeArrayDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00003291 File Offset: 0x00001491
		public NativeArrayDebugView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600023F RID: 575 RVA: 0x0000329A File Offset: 0x0000149A
		public Il2CppArrayBase<T> Items
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
