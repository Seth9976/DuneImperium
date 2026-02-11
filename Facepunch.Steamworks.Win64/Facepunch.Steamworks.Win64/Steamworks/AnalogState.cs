using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020000B7 RID: 183
	[StructLayout(2)]
	public struct AnalogState
	{
		// Token: 0x06000BDA RID: 3034 RVA: 0x00050414 File Offset: 0x0004E614
		// Note: this type is marked as 'beforefieldinit'.
		static AnalogState()
		{
			Il2CppClassPointerStore<AnalogState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "AnalogState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalogState>.NativeClassPtr);
			AnalogState.NativeFieldInfoPtr_EMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogState>.NativeClassPtr, "EMode");
			AnalogState.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogState>.NativeClassPtr, "X");
			AnalogState.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogState>.NativeClassPtr, "Y");
			AnalogState.NativeFieldInfoPtr_BActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalogState>.NativeClassPtr, "BActive");
			AnalogState.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalogState>.NativeClassPtr, 100666218);
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x000504A8 File Offset: 0x0004E6A8
		public unsafe bool Active
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalogState.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00002EBD File Offset: 0x000010BD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnalogState>.NativeClassPtr, ref this));
		}

		// Token: 0x0400126F RID: 4719
		private static readonly IntPtr NativeFieldInfoPtr_EMode;

		// Token: 0x04001270 RID: 4720
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x04001271 RID: 4721
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x04001272 RID: 4722
		private static readonly IntPtr NativeFieldInfoPtr_BActive;

		// Token: 0x04001273 RID: 4723
		private static readonly IntPtr NativeMethodInfoPtr_get_Active_Public_get_Boolean_0;

		// Token: 0x04001274 RID: 4724
		[FieldOffset(0)]
		public InputSourceMode EMode;

		// Token: 0x04001275 RID: 4725
		[FieldOffset(4)]
		public float X;

		// Token: 0x04001276 RID: 4726
		[FieldOffset(8)]
		public float Y;

		// Token: 0x04001277 RID: 4727
		[FieldOffset(12)]
		public byte BActive;
	}
}
