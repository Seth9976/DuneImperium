using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace XInputDotNetPure
{
	// Token: 0x02000009 RID: 9
	[StructLayout(2)]
	public struct GamePadState
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00007F84 File Offset: 0x00006184
		// Note: this type is marked as 'beforefieldinit'.
		static GamePadState()
		{
			Il2CppClassPointerStore<GamePadState>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "XInputDotNetPure", "GamePadState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamePadState>.NativeClassPtr);
			GamePadState.NativeFieldInfoPtr_isConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadState>.NativeClassPtr, "isConnected");
			GamePadState.NativeFieldInfoPtr_packetNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadState>.NativeClassPtr, "packetNumber");
			GamePadState.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadState>.NativeClassPtr, "buttons");
			GamePadState.NativeFieldInfoPtr_dPad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadState>.NativeClassPtr, "dPad");
			GamePadState.NativeFieldInfoPtr_thumbSticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadState>.NativeClassPtr, "thumbSticks");
			GamePadState.NativeFieldInfoPtr_triggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadState>.NativeClassPtr, "triggers");
			GamePadState.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_RawState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadState>.NativeClassPtr, 100663332);
			GamePadState.NativeMethodInfoPtr_get_PacketNumber_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadState>.NativeClassPtr, 100663333);
			GamePadState.NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadState>.NativeClassPtr, 100663334);
			GamePadState.NativeMethodInfoPtr_get_Buttons_Public_get_GamePadButtons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadState>.NativeClassPtr, 100663335);
			GamePadState.NativeMethodInfoPtr_get_DPad_Public_get_GamePadDPad_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadState>.NativeClassPtr, 100663336);
			GamePadState.NativeMethodInfoPtr_get_Triggers_Public_get_GamePadTriggers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadState>.NativeClassPtr, 100663337);
			GamePadState.NativeMethodInfoPtr_get_ThumbSticks_Public_get_GamePadThumbSticks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadState>.NativeClassPtr, 100663338);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000080B8 File Offset: 0x000062B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 767549, RefRangeEnd = 767550, XrefRangeStart = 767549, XrefRangeEnd = 767549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GamePadState(bool isConnected, GamePadState.RawState rawState)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isConnected;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rawState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadState.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_RawState_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000080F8 File Offset: 0x000062F8
		public unsafe uint PacketNumber
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadState.NativeMethodInfoPtr_get_PacketNumber_Public_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00008128 File Offset: 0x00006328
		public unsafe bool IsConnected
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 441993, RefRangeEnd = 442038, XrefRangeStart = 441993, XrefRangeEnd = 442038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadState.NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00008158 File Offset: 0x00006358
		public unsafe GamePadButtons Buttons
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadState.NativeMethodInfoPtr_get_Buttons_Public_get_GamePadButtons_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00008188 File Offset: 0x00006388
		public unsafe GamePadDPad DPad
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadState.NativeMethodInfoPtr_get_DPad_Public_get_GamePadDPad_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000081B8 File Offset: 0x000063B8
		public unsafe GamePadTriggers Triggers
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadState.NativeMethodInfoPtr_get_Triggers_Public_get_GamePadTriggers_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000081E8 File Offset: 0x000063E8
		public unsafe GamePadThumbSticks ThumbSticks
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadState.NativeMethodInfoPtr_get_ThumbSticks_Public_get_GamePadThumbSticks_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000020AA File Offset: 0x000002AA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GamePadState>.NativeClassPtr, ref this));
		}

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_isConnected;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_packetNumber;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_dPad;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_thumbSticks;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_triggers;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_RawState_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_get_PacketNumber_Public_get_UInt32_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConnected_Public_get_Boolean_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_get_Buttons_Public_get_GamePadButtons_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_get_DPad_Public_get_GamePadDPad_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_get_Triggers_Public_get_GamePadTriggers_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_get_ThumbSticks_Public_get_GamePadThumbSticks_0;

		// Token: 0x04000054 RID: 84
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool isConnected;

		// Token: 0x04000055 RID: 85
		[FieldOffset(4)]
		public uint packetNumber;

		// Token: 0x04000056 RID: 86
		[FieldOffset(8)]
		public GamePadButtons buttons;

		// Token: 0x04000057 RID: 87
		[FieldOffset(48)]
		public GamePadDPad dPad;

		// Token: 0x04000058 RID: 88
		[FieldOffset(64)]
		public GamePadThumbSticks thumbSticks;

		// Token: 0x04000059 RID: 89
		[FieldOffset(80)]
		public GamePadTriggers triggers;

		// Token: 0x0200020E RID: 526
		[StructLayout(2)]
		public struct RawState
		{
			// Token: 0x0600117B RID: 4475 RVA: 0x00044B84 File Offset: 0x00042D84
			// Note: this type is marked as 'beforefieldinit'.
			static RawState()
			{
				Il2CppClassPointerStore<GamePadState.RawState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GamePadState>.NativeClassPtr, "RawState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamePadState.RawState>.NativeClassPtr);
				GamePadState.RawState.NativeFieldInfoPtr_dwPacketNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadState.RawState>.NativeClassPtr, "dwPacketNumber");
				GamePadState.RawState.NativeFieldInfoPtr_Gamepad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadState.RawState>.NativeClassPtr, "Gamepad");
			}

			// Token: 0x0600117C RID: 4476 RVA: 0x0000706A File Offset: 0x0000526A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GamePadState.RawState>.NativeClassPtr, ref this));
			}

			// Token: 0x04000D71 RID: 3441
			private static readonly IntPtr NativeFieldInfoPtr_dwPacketNumber;

			// Token: 0x04000D72 RID: 3442
			private static readonly IntPtr NativeFieldInfoPtr_Gamepad;

			// Token: 0x04000D73 RID: 3443
			[FieldOffset(0)]
			public uint dwPacketNumber;

			// Token: 0x04000D74 RID: 3444
			[FieldOffset(4)]
			public GamePadState.RawState.GamePad Gamepad;

			// Token: 0x0200022C RID: 556
			[StructLayout(2)]
			public struct GamePad
			{
				// Token: 0x060011DF RID: 4575 RVA: 0x0004614C File Offset: 0x0004434C
				// Note: this type is marked as 'beforefieldinit'.
				static GamePad()
				{
					Il2CppClassPointerStore<GamePadState.RawState.GamePad>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GamePadState.RawState>.NativeClassPtr, "GamePad");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamePadState.RawState.GamePad>.NativeClassPtr);
					GamePadState.RawState.GamePad.NativeFieldInfoPtr_dwButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadState.RawState.GamePad>.NativeClassPtr, "dwButtons");
					GamePadState.RawState.GamePad.NativeFieldInfoPtr_bLeftTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadState.RawState.GamePad>.NativeClassPtr, "bLeftTrigger");
					GamePadState.RawState.GamePad.NativeFieldInfoPtr_bRightTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadState.RawState.GamePad>.NativeClassPtr, "bRightTrigger");
					GamePadState.RawState.GamePad.NativeFieldInfoPtr_sThumbLX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadState.RawState.GamePad>.NativeClassPtr, "sThumbLX");
					GamePadState.RawState.GamePad.NativeFieldInfoPtr_sThumbLY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadState.RawState.GamePad>.NativeClassPtr, "sThumbLY");
					GamePadState.RawState.GamePad.NativeFieldInfoPtr_sThumbRX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadState.RawState.GamePad>.NativeClassPtr, "sThumbRX");
					GamePadState.RawState.GamePad.NativeFieldInfoPtr_sThumbRY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadState.RawState.GamePad>.NativeClassPtr, "sThumbRY");
				}

				// Token: 0x060011E0 RID: 4576 RVA: 0x00007315 File Offset: 0x00005515
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GamePadState.RawState.GamePad>.NativeClassPtr, ref this));
				}

				// Token: 0x04000E2F RID: 3631
				private static readonly IntPtr NativeFieldInfoPtr_dwButtons;

				// Token: 0x04000E30 RID: 3632
				private static readonly IntPtr NativeFieldInfoPtr_bLeftTrigger;

				// Token: 0x04000E31 RID: 3633
				private static readonly IntPtr NativeFieldInfoPtr_bRightTrigger;

				// Token: 0x04000E32 RID: 3634
				private static readonly IntPtr NativeFieldInfoPtr_sThumbLX;

				// Token: 0x04000E33 RID: 3635
				private static readonly IntPtr NativeFieldInfoPtr_sThumbLY;

				// Token: 0x04000E34 RID: 3636
				private static readonly IntPtr NativeFieldInfoPtr_sThumbRX;

				// Token: 0x04000E35 RID: 3637
				private static readonly IntPtr NativeFieldInfoPtr_sThumbRY;

				// Token: 0x04000E36 RID: 3638
				[FieldOffset(0)]
				public ushort dwButtons;

				// Token: 0x04000E37 RID: 3639
				[FieldOffset(2)]
				public byte bLeftTrigger;

				// Token: 0x04000E38 RID: 3640
				[FieldOffset(3)]
				public byte bRightTrigger;

				// Token: 0x04000E39 RID: 3641
				[FieldOffset(4)]
				public short sThumbLX;

				// Token: 0x04000E3A RID: 3642
				[FieldOffset(6)]
				public short sThumbLY;

				// Token: 0x04000E3B RID: 3643
				[FieldOffset(8)]
				public short sThumbRX;

				// Token: 0x04000E3C RID: 3644
				[FieldOffset(10)]
				public short sThumbRY;
			}
		}

		// Token: 0x0200020F RID: 527
		public enum ButtonsConstants
		{
			// Token: 0x04000D76 RID: 3446
			DPadUp = 1,
			// Token: 0x04000D77 RID: 3447
			DPadDown,
			// Token: 0x04000D78 RID: 3448
			DPadLeft = 4,
			// Token: 0x04000D79 RID: 3449
			DPadRight = 8,
			// Token: 0x04000D7A RID: 3450
			Start = 16,
			// Token: 0x04000D7B RID: 3451
			Back = 32,
			// Token: 0x04000D7C RID: 3452
			LeftThumb = 64,
			// Token: 0x04000D7D RID: 3453
			RightThumb = 128,
			// Token: 0x04000D7E RID: 3454
			LeftShoulder = 256,
			// Token: 0x04000D7F RID: 3455
			RightShoulder = 512,
			// Token: 0x04000D80 RID: 3456
			A = 4096,
			// Token: 0x04000D81 RID: 3457
			B = 8192,
			// Token: 0x04000D82 RID: 3458
			X = 16384,
			// Token: 0x04000D83 RID: 3459
			Y = 32768
		}
	}
}
