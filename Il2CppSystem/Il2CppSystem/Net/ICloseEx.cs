using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Net
{
	// Token: 0x020001D0 RID: 464
	public class ICloseEx : Il2CppObjectBase
	{
		// Token: 0x06001C91 RID: 7313 RVA: 0x0000C254 File Offset: 0x0000A454
		// Note: this type is marked as 'beforefieldinit'.
		static ICloseEx()
		{
			Il2CppClassPointerStore<ICloseEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ICloseEx");
			ICloseEx.NativeMethodInfoPtr_CloseEx_Public_Abstract_Virtual_New_Void_CloseExState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICloseEx>.NativeClassPtr, 100667674);
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x0008B89C File Offset: 0x00089A9C
		[CallerCount(0)]
		public unsafe virtual void CloseEx(CloseExState closeState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref closeState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICloseEx.NativeMethodInfoPtr_CloseEx_Public_Abstract_Virtual_New_Void_CloseExState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x0000C283 File Offset: 0x0000A483
		public ICloseEx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040016B9 RID: 5817
		private static readonly IntPtr NativeMethodInfoPtr_CloseEx_Public_Abstract_Virtual_New_Void_CloseExState_0;
	}
}
