using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x02000014 RID: 20
	public class ILogger<TCategoryName> : Il2CppObjectBase
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00003C48 File Offset: 0x00001E48
		// Note: this type is marked as 'beforefieldinit'.
		static ILogger()
		{
			Il2CppClassPointerStore<ILogger<TCategoryName>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.Abstractions.dll", "Microsoft.Extensions.Logging", "ILogger`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCategoryName>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ILogger<TCategoryName>>.NativeClassPtr);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000248D File Offset: 0x0000068D
		public ILogger(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
