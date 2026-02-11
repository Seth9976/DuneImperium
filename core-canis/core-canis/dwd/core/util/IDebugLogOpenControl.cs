using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.util
{
	// Token: 0x0200008D RID: 141
	public class IDebugLogOpenControl : Il2CppObjectBase
	{
		// Token: 0x06000A20 RID: 2592 RVA: 0x00005937 File Offset: 0x00003B37
		// Note: this type is marked as 'beforefieldinit'.
		static IDebugLogOpenControl()
		{
			Il2CppClassPointerStore<IDebugLogOpenControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.util", "IDebugLogOpenControl");
			IDebugLogOpenControl.NativeMethodInfoPtr_get_ShouldOpen_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDebugLogOpenControl>.NativeClassPtr, 100664708);
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x0003A308 File Offset: 0x00038508
		public unsafe virtual bool ShouldOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDebugLogOpenControl.NativeMethodInfoPtr_get_ShouldOpen_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00005966 File Offset: 0x00003B66
		public IDebugLogOpenControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldOpen_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
