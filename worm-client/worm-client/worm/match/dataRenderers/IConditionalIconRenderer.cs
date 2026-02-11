using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace worm.match.dataRenderers
{
	// Token: 0x020000F3 RID: 243
	public class IConditionalIconRenderer : Il2CppObjectBase
	{
		// Token: 0x06000AB0 RID: 2736 RVA: 0x00007939 File Offset: 0x00005B39
		// Note: this type is marked as 'beforefieldinit'.
		static IConditionalIconRenderer()
		{
			Il2CppClassPointerStore<IConditionalIconRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "IConditionalIconRenderer");
			IConditionalIconRenderer.NativeMethodInfoPtr_get_ShowIcons_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConditionalIconRenderer>.NativeClassPtr, 100664771);
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x00038A28 File Offset: 0x00036C28
		public unsafe virtual bool ShowIcons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConditionalIconRenderer.NativeMethodInfoPtr_get_ShowIcons_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00007968 File Offset: 0x00005B68
		public IConditionalIconRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr_get_ShowIcons_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
