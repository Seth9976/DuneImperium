using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020000B8 RID: 184
	[StructLayout(2)]
	public struct MotionState
	{
		// Token: 0x06000BDD RID: 3037 RVA: 0x000504D8 File Offset: 0x0004E6D8
		// Note: this type is marked as 'beforefieldinit'.
		static MotionState()
		{
			Il2CppClassPointerStore<MotionState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "MotionState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionState>.NativeClassPtr);
			MotionState.NativeFieldInfoPtr_RotQuatX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionState>.NativeClassPtr, "RotQuatX");
			MotionState.NativeFieldInfoPtr_RotQuatY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionState>.NativeClassPtr, "RotQuatY");
			MotionState.NativeFieldInfoPtr_RotQuatZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionState>.NativeClassPtr, "RotQuatZ");
			MotionState.NativeFieldInfoPtr_RotQuatW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionState>.NativeClassPtr, "RotQuatW");
			MotionState.NativeFieldInfoPtr_PosAccelX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionState>.NativeClassPtr, "PosAccelX");
			MotionState.NativeFieldInfoPtr_PosAccelY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionState>.NativeClassPtr, "PosAccelY");
			MotionState.NativeFieldInfoPtr_PosAccelZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionState>.NativeClassPtr, "PosAccelZ");
			MotionState.NativeFieldInfoPtr_RotVelX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionState>.NativeClassPtr, "RotVelX");
			MotionState.NativeFieldInfoPtr_RotVelY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionState>.NativeClassPtr, "RotVelY");
			MotionState.NativeFieldInfoPtr_RotVelZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionState>.NativeClassPtr, "RotVelZ");
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00002ECF File Offset: 0x000010CF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MotionState>.NativeClassPtr, ref this));
		}

		// Token: 0x04001278 RID: 4728
		private static readonly IntPtr NativeFieldInfoPtr_RotQuatX;

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeFieldInfoPtr_RotQuatY;

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeFieldInfoPtr_RotQuatZ;

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeFieldInfoPtr_RotQuatW;

		// Token: 0x0400127C RID: 4732
		private static readonly IntPtr NativeFieldInfoPtr_PosAccelX;

		// Token: 0x0400127D RID: 4733
		private static readonly IntPtr NativeFieldInfoPtr_PosAccelY;

		// Token: 0x0400127E RID: 4734
		private static readonly IntPtr NativeFieldInfoPtr_PosAccelZ;

		// Token: 0x0400127F RID: 4735
		private static readonly IntPtr NativeFieldInfoPtr_RotVelX;

		// Token: 0x04001280 RID: 4736
		private static readonly IntPtr NativeFieldInfoPtr_RotVelY;

		// Token: 0x04001281 RID: 4737
		private static readonly IntPtr NativeFieldInfoPtr_RotVelZ;

		// Token: 0x04001282 RID: 4738
		[FieldOffset(0)]
		public float RotQuatX;

		// Token: 0x04001283 RID: 4739
		[FieldOffset(4)]
		public float RotQuatY;

		// Token: 0x04001284 RID: 4740
		[FieldOffset(8)]
		public float RotQuatZ;

		// Token: 0x04001285 RID: 4741
		[FieldOffset(12)]
		public float RotQuatW;

		// Token: 0x04001286 RID: 4742
		[FieldOffset(16)]
		public float PosAccelX;

		// Token: 0x04001287 RID: 4743
		[FieldOffset(20)]
		public float PosAccelY;

		// Token: 0x04001288 RID: 4744
		[FieldOffset(24)]
		public float PosAccelZ;

		// Token: 0x04001289 RID: 4745
		[FieldOffset(28)]
		public float RotVelX;

		// Token: 0x0400128A RID: 4746
		[FieldOffset(32)]
		public float RotVelY;

		// Token: 0x0400128B RID: 4747
		[FieldOffset(36)]
		public float RotVelZ;
	}
}
