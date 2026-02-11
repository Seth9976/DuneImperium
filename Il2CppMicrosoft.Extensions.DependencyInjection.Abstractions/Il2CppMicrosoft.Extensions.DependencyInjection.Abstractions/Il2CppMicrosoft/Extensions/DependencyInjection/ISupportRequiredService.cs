using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection
{
	// Token: 0x02000014 RID: 20
	public class ISupportRequiredService : Il2CppObjectBase
	{
		// Token: 0x0600004D RID: 77 RVA: 0x000022FB File Offset: 0x000004FB
		// Note: this type is marked as 'beforefieldinit'.
		static ISupportRequiredService()
		{
			Il2CppClassPointerStore<ISupportRequiredService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.Abstractions.dll", "Microsoft.Extensions.DependencyInjection", "ISupportRequiredService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISupportRequiredService>.NativeClassPtr);
			ISupportRequiredService.NativeMethodInfoPtr_GetRequiredService_Public_Abstract_Virtual_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISupportRequiredService>.NativeClassPtr, 100663323);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002FF8 File Offset: 0x000011F8
		[CallerCount(0)]
		public unsafe virtual Object GetRequiredService(Type serviceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISupportRequiredService.NativeMethodInfoPtr_GetRequiredService_Public_Abstract_Virtual_New_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002334 File Offset: 0x00000534
		public ISupportRequiredService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_GetRequiredService_Public_Abstract_Virtual_New_Object_Type_0;
	}
}
