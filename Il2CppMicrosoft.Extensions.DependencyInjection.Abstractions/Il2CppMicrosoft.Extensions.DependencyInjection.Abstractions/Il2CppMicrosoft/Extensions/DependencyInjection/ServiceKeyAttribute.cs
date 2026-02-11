using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection
{
	// Token: 0x02000018 RID: 24
	public class ServiceKeyAttribute : Attribute
	{
		// Token: 0x06000097 RID: 151 RVA: 0x00002448 File Offset: 0x00000648
		// Note: this type is marked as 'beforefieldinit'.
		static ServiceKeyAttribute()
		{
			Il2CppClassPointerStore<ServiceKeyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.Abstractions.dll", "Microsoft.Extensions.DependencyInjection", "ServiceKeyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceKeyAttribute>.NativeClassPtr);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000246D File Offset: 0x0000066D
		public ServiceKeyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
