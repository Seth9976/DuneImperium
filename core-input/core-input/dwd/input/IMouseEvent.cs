using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.input
{
	// Token: 0x02000019 RID: 25
	public class IMouseEvent : Il2CppObjectBase
	{
		// Token: 0x060000E4 RID: 228 RVA: 0x00002666 File Offset: 0x00000866
		// Note: this type is marked as 'beforefieldinit'.
		static IMouseEvent()
		{
			Il2CppClassPointerStore<IMouseEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.input", "IMouseEvent");
			IMouseEvent.NativeMethodInfoPtr_get_OriginalSource_Public_Abstract_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEvent>.NativeClassPtr, 100663433);
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000A200 File Offset: 0x00008400
		public unsafe virtual Transform OriginalSource
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEvent.NativeMethodInfoPtr_get_OriginalSource_Public_Abstract_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002695 File Offset: 0x00000895
		public IMouseEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalSource_Public_Abstract_Virtual_New_get_Transform_0;
	}
}
