using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Networking.selection.targetinformation
{
	// Token: 0x02000072 RID: 114
	public class IHasTargetValidity : Il2CppObjectBase
	{
		// Token: 0x060003CD RID: 973 RVA: 0x000045E9 File Offset: 0x000027E9
		// Note: this type is marked as 'beforefieldinit'.
		static IHasTargetValidity()
		{
			Il2CppClassPointerStore<IHasTargetValidity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "IHasTargetValidity");
			IHasTargetValidity.NativeMethodInfoPtr_get_HasValidTarget_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasTargetValidity>.NativeClassPtr, 100663534);
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060003CE RID: 974 RVA: 0x0000FFA4 File Offset: 0x0000E1A4
		public unsafe virtual bool HasValidTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasTargetValidity.NativeMethodInfoPtr_get_HasValidTarget_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00004618 File Offset: 0x00002818
		public IHasTargetValidity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_get_HasValidTarget_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
