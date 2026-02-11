using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000043 RID: 67
	public sealed class NativeSliceDebugView<T> : Object where T : new()
	{
		// Token: 0x0600026E RID: 622 RVA: 0x0001CD58 File Offset: 0x0001AF58
		// Note: this type is marked as 'beforefieldinit'.
		static NativeSliceDebugView()
		{
			Il2CppClassPointerStore<NativeSliceDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeSliceDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeSliceDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00003338 File Offset: 0x00001538
		public NativeSliceDebugView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00003341 File Offset: 0x00001541
		public Il2CppArrayBase<T> Items
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
