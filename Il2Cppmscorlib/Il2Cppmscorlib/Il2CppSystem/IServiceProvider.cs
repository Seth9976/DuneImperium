using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000111 RID: 273
	public class IServiceProvider : Il2CppObjectBase
	{
		// Token: 0x0600124E RID: 4686 RVA: 0x000060BB File Offset: 0x000042BB
		// Note: this type is marked as 'beforefieldinit'.
		static IServiceProvider()
		{
			Il2CppClassPointerStore<IServiceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IServiceProvider");
			IServiceProvider.NativeMethodInfoPtr_GetService_Public_Abstract_Virtual_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IServiceProvider>.NativeClassPtr, 100666489);
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x0007E060 File Offset: 0x0007C260
		[CallerCount(0)]
		public unsafe virtual Object GetService(Type serviceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IServiceProvider.NativeMethodInfoPtr_GetService_Public_Abstract_Virtual_New_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x000060EA File Offset: 0x000042EA
		public IServiceProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EF6 RID: 3830
		private static readonly IntPtr NativeMethodInfoPtr_GetService_Public_Abstract_Virtual_New_Object_Type_0;
	}
}
