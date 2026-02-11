using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.commands
{
	// Token: 0x02000029 RID: 41
	public class IFailable : Il2CppObjectBase
	{
		// Token: 0x0600019D RID: 413 RVA: 0x0000B350 File Offset: 0x00009550
		// Note: this type is marked as 'beforefieldinit'.
		static IFailable()
		{
			Il2CppClassPointerStore<IFailable>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.commands", "IFailable");
			IFailable.NativeMethodInfoPtr_Status_Public_Abstract_Virtual_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFailable>.NativeClassPtr, 100663757);
			IFailable.NativeMethodInfoPtr_get_Completed_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFailable>.NativeClassPtr, 100663758);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000B3A0 File Offset: 0x000095A0
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFailable.NativeMethodInfoPtr_Status_Public_Abstract_Virtual_New_ErrorInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000B3E4 File Offset: 0x000095E4
		public unsafe virtual bool Completed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFailable.NativeMethodInfoPtr_get_Completed_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002A9E File Offset: 0x00000C9E
		public IFailable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Abstract_Virtual_New_ErrorInfo_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_get_Completed_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
