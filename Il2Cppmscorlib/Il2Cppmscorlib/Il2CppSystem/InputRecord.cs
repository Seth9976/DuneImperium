using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000179 RID: 377
	[StructLayout(2)]
	public struct InputRecord
	{
		// Token: 0x0600193F RID: 6463 RVA: 0x0009CC28 File Offset: 0x0009AE28
		// Note: this type is marked as 'beforefieldinit'.
		static InputRecord()
		{
			Il2CppClassPointerStore<InputRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "InputRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputRecord>.NativeClassPtr);
			InputRecord.NativeFieldInfoPtr_EventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "EventType");
			InputRecord.NativeFieldInfoPtr_KeyDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "KeyDown");
			InputRecord.NativeFieldInfoPtr_RepeatCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "RepeatCount");
			InputRecord.NativeFieldInfoPtr_VirtualKeyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "VirtualKeyCode");
			InputRecord.NativeFieldInfoPtr_VirtualScanCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "VirtualScanCode");
			InputRecord.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "Character");
			InputRecord.NativeFieldInfoPtr_ControlKeyState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "ControlKeyState");
			InputRecord.NativeFieldInfoPtr_pad1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "pad1");
			InputRecord.NativeFieldInfoPtr_pad2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "pad2");
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x000081DB File Offset: 0x000063DB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, ref this));
		}

		// Token: 0x04001749 RID: 5961
		private static readonly IntPtr NativeFieldInfoPtr_EventType;

		// Token: 0x0400174A RID: 5962
		private static readonly IntPtr NativeFieldInfoPtr_KeyDown;

		// Token: 0x0400174B RID: 5963
		private static readonly IntPtr NativeFieldInfoPtr_RepeatCount;

		// Token: 0x0400174C RID: 5964
		private static readonly IntPtr NativeFieldInfoPtr_VirtualKeyCode;

		// Token: 0x0400174D RID: 5965
		private static readonly IntPtr NativeFieldInfoPtr_VirtualScanCode;

		// Token: 0x0400174E RID: 5966
		private static readonly IntPtr NativeFieldInfoPtr_Character;

		// Token: 0x0400174F RID: 5967
		private static readonly IntPtr NativeFieldInfoPtr_ControlKeyState;

		// Token: 0x04001750 RID: 5968
		private static readonly IntPtr NativeFieldInfoPtr_pad1;

		// Token: 0x04001751 RID: 5969
		private static readonly IntPtr NativeFieldInfoPtr_pad2;

		// Token: 0x04001752 RID: 5970
		[FieldOffset(0)]
		public short EventType;

		// Token: 0x04001753 RID: 5971
		[FieldOffset(2)]
		[MarshalAs(4)]
		public bool KeyDown;

		// Token: 0x04001754 RID: 5972
		[FieldOffset(4)]
		public short RepeatCount;

		// Token: 0x04001755 RID: 5973
		[FieldOffset(6)]
		public short VirtualKeyCode;

		// Token: 0x04001756 RID: 5974
		[FieldOffset(8)]
		public short VirtualScanCode;

		// Token: 0x04001757 RID: 5975
		[FieldOffset(10)]
		public char Character;

		// Token: 0x04001758 RID: 5976
		[FieldOffset(12)]
		public int ControlKeyState;

		// Token: 0x04001759 RID: 5977
		[FieldOffset(16)]
		public int pad1;

		// Token: 0x0400175A RID: 5978
		[FieldOffset(20)]
		[MarshalAs(4)]
		public bool pad2;
	}
}
