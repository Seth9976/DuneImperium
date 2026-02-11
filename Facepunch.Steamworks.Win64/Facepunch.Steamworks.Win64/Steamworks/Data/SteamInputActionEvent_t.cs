using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001C2 RID: 450
	[StructLayout(2)]
	public struct SteamInputActionEvent_t
	{
		// Token: 0x060016A7 RID: 5799 RVA: 0x000702F8 File Offset: 0x0006E4F8
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInputActionEvent_t()
		{
			Il2CppClassPointerStore<SteamInputActionEvent_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamInputActionEvent_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInputActionEvent_t>.NativeClassPtr);
			SteamInputActionEvent_t.NativeFieldInfoPtr_ControllerHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInputActionEvent_t>.NativeClassPtr, "ControllerHandle");
			SteamInputActionEvent_t.NativeFieldInfoPtr_EEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInputActionEvent_t>.NativeClassPtr, "EEventType");
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x000077B4 File Offset: 0x000059B4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInputActionEvent_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001C35 RID: 7221
		private static readonly IntPtr NativeFieldInfoPtr_ControllerHandle;

		// Token: 0x04001C36 RID: 7222
		private static readonly IntPtr NativeFieldInfoPtr_EEventType;

		// Token: 0x04001C37 RID: 7223
		[FieldOffset(0)]
		public ulong ControllerHandle;

		// Token: 0x04001C38 RID: 7224
		[FieldOffset(8)]
		public SteamInputActionEventType EEventType;
	}
}
