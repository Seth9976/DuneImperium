using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Extensions.DependencyInjection;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x02000015 RID: 21
	public class ILoggingBuilder : Il2CppObjectBase
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00002496 File Offset: 0x00000696
		// Note: this type is marked as 'beforefieldinit'.
		static ILoggingBuilder()
		{
			Il2CppClassPointerStore<ILoggingBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.Abstractions.dll", "Microsoft.Extensions.Logging", "ILoggingBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ILoggingBuilder>.NativeClassPtr);
			ILoggingBuilder.NativeMethodInfoPtr_get_Services_Public_Abstract_Virtual_New_get_IServiceCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILoggingBuilder>.NativeClassPtr, 100663353);
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00003CB4 File Offset: 0x00001EB4
		public unsafe virtual IServiceCollection Services
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILoggingBuilder.NativeMethodInfoPtr_get_Services_Public_Abstract_Virtual_New_get_IServiceCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IServiceCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000024CF File Offset: 0x000006CF
		public ILoggingBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_get_Services_Public_Abstract_Virtual_New_get_IServiceCollection_0;
	}
}
