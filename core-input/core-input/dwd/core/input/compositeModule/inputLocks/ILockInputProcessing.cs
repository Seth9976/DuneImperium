using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.input.compositeModule.inputLocks
{
	// Token: 0x02000097 RID: 151
	public class ILockInputProcessing : Il2CppObjectBase
	{
		// Token: 0x06000682 RID: 1666 RVA: 0x00005879 File Offset: 0x00003A79
		// Note: this type is marked as 'beforefieldinit'.
		static ILockInputProcessing()
		{
			Il2CppClassPointerStore<ILockInputProcessing>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule.inputLocks", "ILockInputProcessing");
			ILockInputProcessing.NativeMethodInfoPtr_get_IsInputLocked_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILockInputProcessing>.NativeClassPtr, 100664096);
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x0001BAAC File Offset: 0x00019CAC
		public unsafe virtual bool IsInputLocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILockInputProcessing.NativeMethodInfoPtr_get_IsInputLocked_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x000058A8 File Offset: 0x00003AA8
		public ILockInputProcessing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInputLocked_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
