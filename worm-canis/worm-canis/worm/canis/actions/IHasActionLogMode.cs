using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace worm.canis.actions
{
	// Token: 0x0200025A RID: 602
	public class IHasActionLogMode : Il2CppObjectBase
	{
		// Token: 0x060019E2 RID: 6626 RVA: 0x000BD884 File Offset: 0x000BBA84
		// Note: this type is marked as 'beforefieldinit'.
		static IHasActionLogMode()
		{
			Il2CppClassPointerStore<IHasActionLogMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "IHasActionLogMode");
			IHasActionLogMode.NativeMethodInfoPtr_get_LogMode_Public_Abstract_Virtual_New_get_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasActionLogMode>.NativeClassPtr, 100668063);
			IHasActionLogMode.NativeMethodInfoPtr_set_LogMode_Public_Abstract_Virtual_New_set_Void_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasActionLogMode>.NativeClassPtr, 100668064);
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x060019E3 RID: 6627 RVA: 0x000BD8D4 File Offset: 0x000BBAD4
		// (set) Token: 0x060019E4 RID: 6628 RVA: 0x000BD91C File Offset: 0x000BBB1C
		public unsafe virtual ActionLogModes LogMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasActionLogMode.NativeMethodInfoPtr_get_LogMode_Public_Abstract_Virtual_New_get_ActionLogModes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasActionLogMode.NativeMethodInfoPtr_set_LogMode_Public_Abstract_Virtual_New_set_Void_ActionLogModes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x0000B23D File Offset: 0x0000943D
		public IHasActionLogMode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeMethodInfoPtr_get_LogMode_Public_Abstract_Virtual_New_get_ActionLogModes_0;

		// Token: 0x04000FFB RID: 4091
		private static readonly IntPtr NativeMethodInfoPtr_set_LogMode_Public_Abstract_Virtual_New_set_Void_ActionLogModes_0;
	}
}
