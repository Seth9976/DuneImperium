using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001BC RID: 444
	[StructLayout(2)]
	public struct NetMsg
	{
		// Token: 0x0600169A RID: 5786 RVA: 0x0006FEC0 File Offset: 0x0006E0C0
		// Note: this type is marked as 'beforefieldinit'.
		static NetMsg()
		{
			Il2CppClassPointerStore<NetMsg>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "NetMsg");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetMsg>.NativeClassPtr);
			NetMsg.NativeFieldInfoPtr_DataPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMsg>.NativeClassPtr, "DataPtr");
			NetMsg.NativeFieldInfoPtr_DataSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMsg>.NativeClassPtr, "DataSize");
			NetMsg.NativeFieldInfoPtr_Connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMsg>.NativeClassPtr, "Connection");
			NetMsg.NativeFieldInfoPtr_Identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMsg>.NativeClassPtr, "Identity");
			NetMsg.NativeFieldInfoPtr_ConnectionUserData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMsg>.NativeClassPtr, "ConnectionUserData");
			NetMsg.NativeFieldInfoPtr_RecvTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMsg>.NativeClassPtr, "RecvTime");
			NetMsg.NativeFieldInfoPtr_MessageNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMsg>.NativeClassPtr, "MessageNumber");
			NetMsg.NativeFieldInfoPtr_FreeDataPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMsg>.NativeClassPtr, "FreeDataPtr");
			NetMsg.NativeFieldInfoPtr_ReleasePtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMsg>.NativeClassPtr, "ReleasePtr");
			NetMsg.NativeFieldInfoPtr_Channel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMsg>.NativeClassPtr, "Channel");
			NetMsg.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMsg>.NativeClassPtr, "Flags");
			NetMsg.NativeFieldInfoPtr_UserData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMsg>.NativeClassPtr, "UserData");
			NetMsg.NativeFieldInfoPtr_IdxLane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMsg>.NativeClassPtr, "IdxLane");
			NetMsg.NativeFieldInfoPtr__pad1__ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetMsg>.NativeClassPtr, "_pad1__");
			NetMsg.NativeMethodInfoPtr_InternalRelease_Internal_Static_Void_ptr_NetMsg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetMsg>.NativeClassPtr, 100667478);
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x0007001C File Offset: 0x0006E21C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 951387, RefRangeEnd = 951391, XrefRangeStart = 951385, XrefRangeEnd = 951387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalRelease(NetMsg* self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetMsg.NativeMethodInfoPtr_InternalRelease_Internal_Static_Void_ptr_NetMsg_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x00007748 File Offset: 0x00005948
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetMsg>.NativeClassPtr, ref this));
		}

		// Token: 0x04001BEC RID: 7148
		private static readonly IntPtr NativeFieldInfoPtr_DataPtr;

		// Token: 0x04001BED RID: 7149
		private static readonly IntPtr NativeFieldInfoPtr_DataSize;

		// Token: 0x04001BEE RID: 7150
		private static readonly IntPtr NativeFieldInfoPtr_Connection;

		// Token: 0x04001BEF RID: 7151
		private static readonly IntPtr NativeFieldInfoPtr_Identity;

		// Token: 0x04001BF0 RID: 7152
		private static readonly IntPtr NativeFieldInfoPtr_ConnectionUserData;

		// Token: 0x04001BF1 RID: 7153
		private static readonly IntPtr NativeFieldInfoPtr_RecvTime;

		// Token: 0x04001BF2 RID: 7154
		private static readonly IntPtr NativeFieldInfoPtr_MessageNumber;

		// Token: 0x04001BF3 RID: 7155
		private static readonly IntPtr NativeFieldInfoPtr_FreeDataPtr;

		// Token: 0x04001BF4 RID: 7156
		private static readonly IntPtr NativeFieldInfoPtr_ReleasePtr;

		// Token: 0x04001BF5 RID: 7157
		private static readonly IntPtr NativeFieldInfoPtr_Channel;

		// Token: 0x04001BF6 RID: 7158
		private static readonly IntPtr NativeFieldInfoPtr_Flags;

		// Token: 0x04001BF7 RID: 7159
		private static readonly IntPtr NativeFieldInfoPtr_UserData;

		// Token: 0x04001BF8 RID: 7160
		private static readonly IntPtr NativeFieldInfoPtr_IdxLane;

		// Token: 0x04001BF9 RID: 7161
		private static readonly IntPtr NativeFieldInfoPtr__pad1__;

		// Token: 0x04001BFA RID: 7162
		private static readonly IntPtr NativeMethodInfoPtr_InternalRelease_Internal_Static_Void_ptr_NetMsg_0;

		// Token: 0x04001BFB RID: 7163
		[FieldOffset(0)]
		public IntPtr DataPtr;

		// Token: 0x04001BFC RID: 7164
		[FieldOffset(8)]
		public int DataSize;

		// Token: 0x04001BFD RID: 7165
		[FieldOffset(12)]
		public Connection Connection;

		// Token: 0x04001BFE RID: 7166
		[FieldOffset(16)]
		public NetIdentity Identity;

		// Token: 0x04001BFF RID: 7167
		[FieldOffset(152)]
		public long ConnectionUserData;

		// Token: 0x04001C00 RID: 7168
		[FieldOffset(160)]
		public long RecvTime;

		// Token: 0x04001C01 RID: 7169
		[FieldOffset(168)]
		public long MessageNumber;

		// Token: 0x04001C02 RID: 7170
		[FieldOffset(176)]
		public IntPtr FreeDataPtr;

		// Token: 0x04001C03 RID: 7171
		[FieldOffset(184)]
		public IntPtr ReleasePtr;

		// Token: 0x04001C04 RID: 7172
		[FieldOffset(192)]
		public int Channel;

		// Token: 0x04001C05 RID: 7173
		[FieldOffset(196)]
		public SendType Flags;

		// Token: 0x04001C06 RID: 7174
		[FieldOffset(200)]
		public long UserData;

		// Token: 0x04001C07 RID: 7175
		[FieldOffset(208)]
		public ushort IdxLane;

		// Token: 0x04001C08 RID: 7176
		[FieldOffset(210)]
		public ushort _pad1__;
	}
}
