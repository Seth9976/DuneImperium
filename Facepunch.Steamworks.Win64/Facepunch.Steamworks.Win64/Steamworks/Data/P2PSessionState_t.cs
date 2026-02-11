using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001C1 RID: 449
	[StructLayout(2)]
	public struct P2PSessionState_t
	{
		// Token: 0x060016A5 RID: 5797 RVA: 0x00070228 File Offset: 0x0006E428
		// Note: this type is marked as 'beforefieldinit'.
		static P2PSessionState_t()
		{
			Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "P2PSessionState_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr);
			P2PSessionState_t.NativeFieldInfoPtr_ConnectionActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "ConnectionActive");
			P2PSessionState_t.NativeFieldInfoPtr_Connecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "Connecting");
			P2PSessionState_t.NativeFieldInfoPtr_P2PSessionError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "P2PSessionError");
			P2PSessionState_t.NativeFieldInfoPtr_UsingRelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "UsingRelay");
			P2PSessionState_t.NativeFieldInfoPtr_BytesQueuedForSend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "BytesQueuedForSend");
			P2PSessionState_t.NativeFieldInfoPtr_PacketsQueuedForSend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "PacketsQueuedForSend");
			P2PSessionState_t.NativeFieldInfoPtr_RemoteIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "RemoteIP");
			P2PSessionState_t.NativeFieldInfoPtr_RemotePort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, "RemotePort");
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x000077A2 File Offset: 0x000059A2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<P2PSessionState_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001C25 RID: 7205
		private static readonly IntPtr NativeFieldInfoPtr_ConnectionActive;

		// Token: 0x04001C26 RID: 7206
		private static readonly IntPtr NativeFieldInfoPtr_Connecting;

		// Token: 0x04001C27 RID: 7207
		private static readonly IntPtr NativeFieldInfoPtr_P2PSessionError;

		// Token: 0x04001C28 RID: 7208
		private static readonly IntPtr NativeFieldInfoPtr_UsingRelay;

		// Token: 0x04001C29 RID: 7209
		private static readonly IntPtr NativeFieldInfoPtr_BytesQueuedForSend;

		// Token: 0x04001C2A RID: 7210
		private static readonly IntPtr NativeFieldInfoPtr_PacketsQueuedForSend;

		// Token: 0x04001C2B RID: 7211
		private static readonly IntPtr NativeFieldInfoPtr_RemoteIP;

		// Token: 0x04001C2C RID: 7212
		private static readonly IntPtr NativeFieldInfoPtr_RemotePort;

		// Token: 0x04001C2D RID: 7213
		[FieldOffset(0)]
		public byte ConnectionActive;

		// Token: 0x04001C2E RID: 7214
		[FieldOffset(1)]
		public byte Connecting;

		// Token: 0x04001C2F RID: 7215
		[FieldOffset(2)]
		public byte P2PSessionError;

		// Token: 0x04001C30 RID: 7216
		[FieldOffset(3)]
		public byte UsingRelay;

		// Token: 0x04001C31 RID: 7217
		[FieldOffset(4)]
		public int BytesQueuedForSend;

		// Token: 0x04001C32 RID: 7218
		[FieldOffset(8)]
		public int PacketsQueuedForSend;

		// Token: 0x04001C33 RID: 7219
		[FieldOffset(12)]
		public uint RemoteIP;

		// Token: 0x04001C34 RID: 7220
		[FieldOffset(16)]
		public ushort RemotePort;
	}
}
