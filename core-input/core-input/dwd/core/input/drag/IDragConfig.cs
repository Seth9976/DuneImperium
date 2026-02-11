using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.input.drag
{
	// Token: 0x02000072 RID: 114
	public class IDragConfig : Il2CppObjectBase
	{
		// Token: 0x0600045C RID: 1116 RVA: 0x0000482A File Offset: 0x00002A2A
		// Note: this type is marked as 'beforefieldinit'.
		static IDragConfig()
		{
			Il2CppClassPointerStore<IDragConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.drag", "IDragConfig");
			IDragConfig.NativeMethodInfoPtr_get_DragSlop_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDragConfig>.NativeClassPtr, 100663789);
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x000146B4 File Offset: 0x000128B4
		public unsafe virtual float DragSlop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDragConfig.NativeMethodInfoPtr_get_DragSlop_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00004859 File Offset: 0x00002A59
		public IDragConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_get_DragSlop_Public_Abstract_Virtual_New_get_Single_0;
	}
}
