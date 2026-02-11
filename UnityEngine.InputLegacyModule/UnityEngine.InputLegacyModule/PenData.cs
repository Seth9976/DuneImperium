using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	[StructLayout(2)]
	public struct PenData
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00002B1C File Offset: 0x00000D1C
		// Note: this type is marked as 'beforefieldinit'.
		static PenData()
		{
			Il2CppClassPointerStore<PenData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputLegacyModule.dll", "UnityEngine", "PenData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PenData>.NativeClassPtr);
			PenData.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenData>.NativeClassPtr, "position");
			PenData.NativeFieldInfoPtr_tilt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenData>.NativeClassPtr, "tilt");
			PenData.NativeFieldInfoPtr_penStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenData>.NativeClassPtr, "penStatus");
			PenData.NativeFieldInfoPtr_twist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenData>.NativeClassPtr, "twist");
			PenData.NativeFieldInfoPtr_pressure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenData>.NativeClassPtr, "pressure");
			PenData.NativeFieldInfoPtr_contactType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenData>.NativeClassPtr, "contactType");
			PenData.NativeFieldInfoPtr_deltaPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenData>.NativeClassPtr, "deltaPos");
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000020D0 File Offset: 0x000002D0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PenData>.NativeClassPtr, ref this));
		}

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_tilt;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_penStatus;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_twist;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_pressure;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_contactType;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_deltaPos;

		// Token: 0x0400004D RID: 77
		[FieldOffset(0)]
		public Vector2 position;

		// Token: 0x0400004E RID: 78
		[FieldOffset(8)]
		public Vector2 tilt;

		// Token: 0x0400004F RID: 79
		[FieldOffset(16)]
		public PenStatus penStatus;

		// Token: 0x04000050 RID: 80
		[FieldOffset(20)]
		public float twist;

		// Token: 0x04000051 RID: 81
		[FieldOffset(24)]
		public float pressure;

		// Token: 0x04000052 RID: 82
		[FieldOffset(28)]
		public PenEventType contactType;

		// Token: 0x04000053 RID: 83
		[FieldOffset(32)]
		public Vector2 deltaPos;
	}
}
