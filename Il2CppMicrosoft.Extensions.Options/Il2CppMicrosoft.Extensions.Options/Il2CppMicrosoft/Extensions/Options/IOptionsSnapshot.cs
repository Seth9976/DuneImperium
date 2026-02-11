using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Options
{
	// Token: 0x02000015 RID: 21
	public class IOptionsSnapshot<TOptions> : Il2CppObjectBase where TOptions : class
	{
		// Token: 0x06000050 RID: 80 RVA: 0x000038D4 File Offset: 0x00001AD4
		// Note: this type is marked as 'beforefieldinit'.
		static IOptionsSnapshot()
		{
			Il2CppClassPointerStore<IOptionsSnapshot<TOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "Microsoft.Extensions.Options", "IOptionsSnapshot`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOptionsSnapshot<TOptions>>.NativeClassPtr);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002267 File Offset: 0x00000467
		public IOptionsSnapshot(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
