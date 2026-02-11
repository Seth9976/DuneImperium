using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Networking.selection.messages.outgoing
{
	// Token: 0x02000087 RID: 135
	public class ISelectionCounter : Il2CppObjectBase
	{
		// Token: 0x0600048C RID: 1164 RVA: 0x00004CE4 File Offset: 0x00002EE4
		// Note: this type is marked as 'beforefieldinit'.
		static ISelectionCounter()
		{
			Il2CppClassPointerStore<ISelectionCounter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.messages.outgoing", "ISelectionCounter");
			ISelectionCounter.NativeMethodInfoPtr_GetCounter_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectionCounter>.NativeClassPtr, 100663592);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00012124 File Offset: 0x00010324
		[CallerCount(0)]
		public unsafe virtual int GetCounter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISelectionCounter.NativeMethodInfoPtr_GetCounter_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00004D13 File Offset: 0x00002F13
		public ISelectionCounter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_GetCounter_Public_Abstract_Virtual_New_Int32_0;
	}
}
