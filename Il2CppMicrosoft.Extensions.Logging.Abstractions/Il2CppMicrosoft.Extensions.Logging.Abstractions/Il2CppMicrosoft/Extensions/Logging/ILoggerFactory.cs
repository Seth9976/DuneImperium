using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x02000012 RID: 18
	public class ILoggerFactory : Il2CppObjectBase
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00002409 File Offset: 0x00000609
		// Note: this type is marked as 'beforefieldinit'.
		static ILoggerFactory()
		{
			Il2CppClassPointerStore<ILoggerFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.Abstractions.dll", "Microsoft.Extensions.Logging", "ILoggerFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ILoggerFactory>.NativeClassPtr);
			ILoggerFactory.NativeMethodInfoPtr_CreateLogger_Public_Abstract_Virtual_New_ILogger_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILoggerFactory>.NativeClassPtr, 100663351);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003B90 File Offset: 0x00001D90
		[CallerCount(0)]
		public unsafe virtual ILogger CreateLogger(string categoryName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILoggerFactory.NativeMethodInfoPtr_CreateLogger_Public_Abstract_Virtual_New_ILogger_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002442 File Offset: 0x00000642
		public ILoggerFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_CreateLogger_Public_Abstract_Virtual_New_ILogger_String_0;
	}
}
