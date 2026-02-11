using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020000B9 RID: 185
	[StructLayout(2)]
	public struct DigitalState
	{
		// Token: 0x06000BDF RID: 3039 RVA: 0x000505D0 File Offset: 0x0004E7D0
		// Note: this type is marked as 'beforefieldinit'.
		static DigitalState()
		{
			Il2CppClassPointerStore<DigitalState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "DigitalState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DigitalState>.NativeClassPtr);
			DigitalState.NativeFieldInfoPtr_BState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalState>.NativeClassPtr, "BState");
			DigitalState.NativeFieldInfoPtr_BActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalState>.NativeClassPtr, "BActive");
			DigitalState.NativeMethodInfoPtr_get_Pressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalState>.NativeClassPtr, 100666219);
			DigitalState.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalState>.NativeClassPtr, 100666220);
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x00050650 File Offset: 0x0004E850
		public unsafe bool Pressed
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalState.NativeMethodInfoPtr_get_Pressed_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x00050680 File Offset: 0x0004E880
		public unsafe bool Active
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalState.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x00002EE1 File Offset: 0x000010E1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DigitalState>.NativeClassPtr, ref this));
		}

		// Token: 0x0400128C RID: 4748
		private static readonly IntPtr NativeFieldInfoPtr_BState;

		// Token: 0x0400128D RID: 4749
		private static readonly IntPtr NativeFieldInfoPtr_BActive;

		// Token: 0x0400128E RID: 4750
		private static readonly IntPtr NativeMethodInfoPtr_get_Pressed_Public_get_Boolean_0;

		// Token: 0x0400128F RID: 4751
		private static readonly IntPtr NativeMethodInfoPtr_get_Active_Public_get_Boolean_0;

		// Token: 0x04001290 RID: 4752
		[FieldOffset(0)]
		public byte BState;

		// Token: 0x04001291 RID: 4753
		[FieldOffset(1)]
		public byte BActive;
	}
}
