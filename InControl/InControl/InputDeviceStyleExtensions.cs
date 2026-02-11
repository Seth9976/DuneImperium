using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x0200003E RID: 62
	public static class InputDeviceStyleExtensions : Object
	{
		// Token: 0x06000559 RID: 1369 RVA: 0x0001B50C File Offset: 0x0001970C
		// Note: this type is marked as 'beforefieldinit'.
		static InputDeviceStyleExtensions()
		{
			Il2CppClassPointerStore<InputDeviceStyleExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "InputDeviceStyleExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDeviceStyleExtensions>.NativeClassPtr);
			InputDeviceStyleExtensions.NativeFieldInfoPtr_defaultLeftCommandControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceStyleExtensions>.NativeClassPtr, "defaultLeftCommandControl");
			InputDeviceStyleExtensions.NativeFieldInfoPtr_defaultRightCommandControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceStyleExtensions>.NativeClassPtr, "defaultRightCommandControl");
			InputDeviceStyleExtensions.NativeMethodInfoPtr_LeftCommandControl_Public_Static_InputControlType_InputDeviceStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceStyleExtensions>.NativeClassPtr, 100664022);
			InputDeviceStyleExtensions.NativeMethodInfoPtr_RightCommandControl_Public_Static_InputControlType_InputDeviceStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceStyleExtensions>.NativeClassPtr, 100664023);
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0001B58C File Offset: 0x0001978C
		[CallerCount(0)]
		public unsafe static InputControlType LeftCommandControl(this InputDeviceStyle deviceStyle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceStyle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceStyleExtensions.NativeMethodInfoPtr_LeftCommandControl_Public_Static_InputControlType_InputDeviceStyle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0001B5CC File Offset: 0x000197CC
		[CallerCount(0)]
		public unsafe static InputControlType RightCommandControl(this InputDeviceStyle deviceStyle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceStyle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDeviceStyleExtensions.NativeMethodInfoPtr_RightCommandControl_Public_Static_InputControlType_InputDeviceStyle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x000040F3 File Offset: 0x000022F3
		public InputDeviceStyleExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x0001B60C File Offset: 0x0001980C
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x000040FC File Offset: 0x000022FC
		public unsafe static InputControlType defaultLeftCommandControl
		{
			get
			{
				InputControlType inputControlType;
				IL2CPP.il2cpp_field_static_get_value(InputDeviceStyleExtensions.NativeFieldInfoPtr_defaultLeftCommandControl, (void*)(&inputControlType));
				return inputControlType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputDeviceStyleExtensions.NativeFieldInfoPtr_defaultLeftCommandControl, (void*)(&value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x0001B628 File Offset: 0x00019828
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x0000410A File Offset: 0x0000230A
		public unsafe static InputControlType defaultRightCommandControl
		{
			get
			{
				InputControlType inputControlType;
				IL2CPP.il2cpp_field_static_get_value(InputDeviceStyleExtensions.NativeFieldInfoPtr_defaultRightCommandControl, (void*)(&inputControlType));
				return inputControlType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputDeviceStyleExtensions.NativeFieldInfoPtr_defaultRightCommandControl, (void*)(&value));
			}
		}

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeFieldInfoPtr_defaultLeftCommandControl;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeFieldInfoPtr_defaultRightCommandControl;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_LeftCommandControl_Public_Static_InputControlType_InputDeviceStyle_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_RightCommandControl_Public_Static_InputControlType_InputDeviceStyle_0;
	}
}
