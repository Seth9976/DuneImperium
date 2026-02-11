using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace XInputDotNetPure
{
	// Token: 0x02000005 RID: 5
	[StructLayout(2)]
	public struct GamePadButtons
	{
		// Token: 0x0600000E RID: 14 RVA: 0x000076B4 File Offset: 0x000058B4
		// Note: this type is marked as 'beforefieldinit'.
		static GamePadButtons()
		{
			Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "XInputDotNetPure", "GamePadButtons");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr);
			GamePadButtons.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, "start");
			GamePadButtons.NativeFieldInfoPtr_back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, "back");
			GamePadButtons.NativeFieldInfoPtr_leftStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, "leftStick");
			GamePadButtons.NativeFieldInfoPtr_rightStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, "rightStick");
			GamePadButtons.NativeFieldInfoPtr_leftShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, "leftShoulder");
			GamePadButtons.NativeFieldInfoPtr_rightShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, "rightShoulder");
			GamePadButtons.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, "a");
			GamePadButtons.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, "b");
			GamePadButtons.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, "x");
			GamePadButtons.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, "y");
			GamePadButtons.NativeMethodInfoPtr__ctor_Internal_Void_ButtonState_ButtonState_ButtonState_ButtonState_ButtonState_ButtonState_ButtonState_ButtonState_ButtonState_ButtonState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, 100663306);
			GamePadButtons.NativeMethodInfoPtr_get_Start_Public_get_ButtonState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, 100663307);
			GamePadButtons.NativeMethodInfoPtr_get_Back_Public_get_ButtonState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, 100663308);
			GamePadButtons.NativeMethodInfoPtr_get_LeftStick_Public_get_ButtonState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, 100663309);
			GamePadButtons.NativeMethodInfoPtr_get_RightStick_Public_get_ButtonState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, 100663310);
			GamePadButtons.NativeMethodInfoPtr_get_LeftShoulder_Public_get_ButtonState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, 100663311);
			GamePadButtons.NativeMethodInfoPtr_get_RightShoulder_Public_get_ButtonState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, 100663312);
			GamePadButtons.NativeMethodInfoPtr_get_A_Public_get_ButtonState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, 100663313);
			GamePadButtons.NativeMethodInfoPtr_get_B_Public_get_ButtonState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, 100663314);
			GamePadButtons.NativeMethodInfoPtr_get_X_Public_get_ButtonState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, 100663315);
			GamePadButtons.NativeMethodInfoPtr_get_Y_Public_get_ButtonState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, 100663316);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00007888 File Offset: 0x00005A88
		[CallerCount(0)]
		public unsafe GamePadButtons(ButtonState start, ButtonState back, ButtonState leftStick, ButtonState rightStick, ButtonState leftShoulder, ButtonState rightShoulder, ButtonState a, ButtonState b, ButtonState x, ButtonState y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref back;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftStick;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightStick;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftShoulder;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightShoulder;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadButtons.NativeMethodInfoPtr__ctor_Internal_Void_ButtonState_ButtonState_ButtonState_ButtonState_ButtonState_ButtonState_ButtonState_ButtonState_ButtonState_ButtonState_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000793C File Offset: 0x00005B3C
		public unsafe ButtonState Start
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadButtons.NativeMethodInfoPtr_get_Start_Public_get_ButtonState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0000796C File Offset: 0x00005B6C
		public unsafe ButtonState Back
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadButtons.NativeMethodInfoPtr_get_Back_Public_get_ButtonState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0000799C File Offset: 0x00005B9C
		public unsafe ButtonState LeftStick
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadButtons.NativeMethodInfoPtr_get_LeftStick_Public_get_ButtonState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000079CC File Offset: 0x00005BCC
		public unsafe ButtonState RightStick
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadButtons.NativeMethodInfoPtr_get_RightStick_Public_get_ButtonState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000079FC File Offset: 0x00005BFC
		public unsafe ButtonState LeftShoulder
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadButtons.NativeMethodInfoPtr_get_LeftShoulder_Public_get_ButtonState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00007A2C File Offset: 0x00005C2C
		public unsafe ButtonState RightShoulder
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadButtons.NativeMethodInfoPtr_get_RightShoulder_Public_get_ButtonState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00007A5C File Offset: 0x00005C5C
		public unsafe ButtonState A
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadButtons.NativeMethodInfoPtr_get_A_Public_get_ButtonState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00007A8C File Offset: 0x00005C8C
		public unsafe ButtonState B
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadButtons.NativeMethodInfoPtr_get_B_Public_get_ButtonState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00007ABC File Offset: 0x00005CBC
		public unsafe ButtonState X
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadButtons.NativeMethodInfoPtr_get_X_Public_get_ButtonState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00007AEC File Offset: 0x00005CEC
		public unsafe ButtonState Y
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadButtons.NativeMethodInfoPtr_get_Y_Public_get_ButtonState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002062 File Offset: 0x00000262
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GamePadButtons>.NativeClassPtr, ref this));
		}

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_start;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_back;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_leftStick;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_rightStick;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_leftShoulder;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_rightShoulder;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_a;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_b;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ButtonState_ButtonState_ButtonState_ButtonState_ButtonState_ButtonState_ButtonState_ButtonState_ButtonState_ButtonState_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_get_Start_Public_get_ButtonState_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_get_Back_Public_get_ButtonState_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftStick_Public_get_ButtonState_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_get_RightStick_Public_get_ButtonState_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftShoulder_Public_get_ButtonState_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_get_RightShoulder_Public_get_ButtonState_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_get_A_Public_get_ButtonState_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_get_B_Public_get_ButtonState_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_get_X_Public_get_ButtonState_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_get_Y_Public_get_ButtonState_0;

		// Token: 0x04000022 RID: 34
		[FieldOffset(0)]
		public ButtonState start;

		// Token: 0x04000023 RID: 35
		[FieldOffset(4)]
		public ButtonState back;

		// Token: 0x04000024 RID: 36
		[FieldOffset(8)]
		public ButtonState leftStick;

		// Token: 0x04000025 RID: 37
		[FieldOffset(12)]
		public ButtonState rightStick;

		// Token: 0x04000026 RID: 38
		[FieldOffset(16)]
		public ButtonState leftShoulder;

		// Token: 0x04000027 RID: 39
		[FieldOffset(20)]
		public ButtonState rightShoulder;

		// Token: 0x04000028 RID: 40
		[FieldOffset(24)]
		public ButtonState a;

		// Token: 0x04000029 RID: 41
		[FieldOffset(28)]
		public ButtonState b;

		// Token: 0x0400002A RID: 42
		[FieldOffset(32)]
		public ButtonState x;

		// Token: 0x0400002B RID: 43
		[FieldOffset(36)]
		public ButtonState y;
	}
}
