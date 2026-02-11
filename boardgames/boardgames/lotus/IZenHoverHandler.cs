using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace lotus
{
	// Token: 0x020000C1 RID: 193
	public class IZenHoverHandler : Il2CppObjectBase
	{
		// Token: 0x060009B2 RID: 2482 RVA: 0x00006648 File Offset: 0x00004848
		// Note: this type is marked as 'beforefieldinit'.
		static IZenHoverHandler()
		{
			Il2CppClassPointerStore<IZenHoverHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "IZenHoverHandler");
			IZenHoverHandler.NativeMethodInfoPtr_BlocksHover_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZenHoverHandler>.NativeClassPtr, 100664882);
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00030108 File Offset: 0x0002E308
		[CallerCount(0)]
		public unsafe virtual bool BlocksHover()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZenHoverHandler.NativeMethodInfoPtr_BlocksHover_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00006677 File Offset: 0x00004877
		public IZenHoverHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr_BlocksHover_Public_Abstract_Virtual_New_Boolean_0;
	}
}
