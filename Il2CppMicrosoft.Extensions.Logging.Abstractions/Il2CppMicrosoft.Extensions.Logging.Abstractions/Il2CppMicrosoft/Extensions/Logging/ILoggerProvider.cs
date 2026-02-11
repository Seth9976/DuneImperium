using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x02000013 RID: 19
	public class ILoggerProvider : Il2CppObjectBase
	{
		// Token: 0x06000070 RID: 112 RVA: 0x0000244B File Offset: 0x0000064B
		// Note: this type is marked as 'beforefieldinit'.
		static ILoggerProvider()
		{
			Il2CppClassPointerStore<ILoggerProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.Abstractions.dll", "Microsoft.Extensions.Logging", "ILoggerProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ILoggerProvider>.NativeClassPtr);
			ILoggerProvider.NativeMethodInfoPtr_CreateLogger_Public_Abstract_Virtual_New_ILogger_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILoggerProvider>.NativeClassPtr, 100663352);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003BEC File Offset: 0x00001DEC
		[CallerCount(0)]
		public unsafe virtual ILogger CreateLogger(string categoryName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILoggerProvider.NativeMethodInfoPtr_CreateLogger_Public_Abstract_Virtual_New_ILogger_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002484 File Offset: 0x00000684
		public ILoggerProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_CreateLogger_Public_Abstract_Virtual_New_ILogger_String_0;
	}
}
