using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.errorInfo
{
	// Token: 0x02000029 RID: 41
	public class IHandleErrorInfo : Il2CppObjectBase
	{
		// Token: 0x0600019D RID: 413 RVA: 0x00002751 File Offset: 0x00000951
		// Note: this type is marked as 'beforefieldinit'.
		static IHandleErrorInfo()
		{
			Il2CppClassPointerStore<IHandleErrorInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "dwd.core.errorInfo", "IHandleErrorInfo");
			IHandleErrorInfo.NativeMethodInfoPtr_Handle_Public_Abstract_Virtual_New_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHandleErrorInfo>.NativeClassPtr, 100663543);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000AB64 File Offset: 0x00008D64
		[CallerCount(0)]
		public unsafe virtual void Handle(ErrorInfo error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(error));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHandleErrorInfo.NativeMethodInfoPtr_Handle_Public_Abstract_Virtual_New_Void_ErrorInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002780 File Offset: 0x00000980
		public IHandleErrorInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_Handle_Public_Abstract_Virtual_New_Void_ErrorInfo_0;
	}
}
