using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.commands
{
	// Token: 0x0200001A RID: 26
	public class IInterruptable : Il2CppObjectBase
	{
		// Token: 0x0600010C RID: 268 RVA: 0x00009034 File Offset: 0x00007234
		// Note: this type is marked as 'beforefieldinit'.
		static IInterruptable()
		{
			Il2CppClassPointerStore<IInterruptable>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.commands", "IInterruptable");
			IInterruptable.NativeMethodInfoPtr_Interrupt_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInterruptable>.NativeClassPtr, 100663559);
			IInterruptable.NativeMethodInfoPtr_get_Interrupted_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInterruptable>.NativeClassPtr, 100663560);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00009084 File Offset: 0x00007284
		[CallerCount(0)]
		public unsafe virtual void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInterruptable.NativeMethodInfoPtr_Interrupt_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600010E RID: 270 RVA: 0x000090C0 File Offset: 0x000072C0
		public unsafe virtual bool Interrupted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInterruptable.NativeMethodInfoPtr_get_Interrupted_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002664 File Offset: 0x00000864
		public IInterruptable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_get_Interrupted_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
