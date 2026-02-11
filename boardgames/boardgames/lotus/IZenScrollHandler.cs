using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace lotus
{
	// Token: 0x020000C2 RID: 194
	public class IZenScrollHandler : Il2CppObjectBase
	{
		// Token: 0x060009B5 RID: 2485 RVA: 0x00006680 File Offset: 0x00004880
		// Note: this type is marked as 'beforefieldinit'.
		static IZenScrollHandler()
		{
			Il2CppClassPointerStore<IZenScrollHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "IZenScrollHandler");
			IZenScrollHandler.NativeMethodInfoPtr_HandleScroll_Public_Abstract_Virtual_New_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZenScrollHandler>.NativeClassPtr, 100664883);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00030150 File Offset: 0x0002E350
		[CallerCount(0)]
		public unsafe virtual bool HandleScroll(float scrollDelta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scrollDelta;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZenScrollHandler.NativeMethodInfoPtr_HandleScroll_Public_Abstract_Virtual_New_Boolean_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x000066AF File Offset: 0x000048AF
		public IZenScrollHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_HandleScroll_Public_Abstract_Virtual_New_Boolean_Single_0;
	}
}
