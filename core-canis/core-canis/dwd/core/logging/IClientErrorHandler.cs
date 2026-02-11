using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.logging
{
	// Token: 0x02000174 RID: 372
	public class IClientErrorHandler : Il2CppObjectBase
	{
		// Token: 0x06001571 RID: 5489 RVA: 0x00009755 File Offset: 0x00007955
		// Note: this type is marked as 'beforefieldinit'.
		static IClientErrorHandler()
		{
			Il2CppClassPointerStore<IClientErrorHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.logging", "IClientErrorHandler");
			IClientErrorHandler.NativeMethodInfoPtr_HandleError_Public_Abstract_Virtual_New_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClientErrorHandler>.NativeClassPtr, 100666531);
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x00069B80 File Offset: 0x00067D80
		[CallerCount(0)]
		public unsafe virtual void HandleError(string errorMessage, string stackTrace, string additionalInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(errorMessage);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(additionalInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IClientErrorHandler.NativeMethodInfoPtr_HandleError_Public_Abstract_Virtual_New_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x00009784 File Offset: 0x00007984
		public IClientErrorHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F41 RID: 3905
		private static readonly IntPtr NativeMethodInfoPtr_HandleError_Public_Abstract_Virtual_New_Void_String_String_String_0;
	}
}
