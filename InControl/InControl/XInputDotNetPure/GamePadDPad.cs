using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace XInputDotNetPure
{
	// Token: 0x02000006 RID: 6
	[StructLayout(2)]
	public struct GamePadDPad
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00007B1C File Offset: 0x00005D1C
		// Note: this type is marked as 'beforefieldinit'.
		static GamePadDPad()
		{
			Il2CppClassPointerStore<GamePadDPad>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "XInputDotNetPure", "GamePadDPad");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamePadDPad>.NativeClassPtr);
			GamePadDPad.NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadDPad>.NativeClassPtr, "up");
			GamePadDPad.NativeFieldInfoPtr_down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadDPad>.NativeClassPtr, "down");
			GamePadDPad.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadDPad>.NativeClassPtr, "left");
			GamePadDPad.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadDPad>.NativeClassPtr, "right");
			GamePadDPad.NativeMethodInfoPtr__ctor_Internal_Void_ButtonState_ButtonState_ButtonState_ButtonState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadDPad>.NativeClassPtr, 100663317);
			GamePadDPad.NativeMethodInfoPtr_get_Up_Public_get_ButtonState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadDPad>.NativeClassPtr, 100663318);
			GamePadDPad.NativeMethodInfoPtr_get_Down_Public_get_ButtonState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadDPad>.NativeClassPtr, 100663319);
			GamePadDPad.NativeMethodInfoPtr_get_Left_Public_get_ButtonState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadDPad>.NativeClassPtr, 100663320);
			GamePadDPad.NativeMethodInfoPtr_get_Right_Public_get_ButtonState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadDPad>.NativeClassPtr, 100663321);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00007C00 File Offset: 0x00005E00
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 608741, RefRangeEnd = 608768, XrefRangeStart = 608741, XrefRangeEnd = 608768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GamePadDPad(ButtonState up, ButtonState down, ButtonState left, ButtonState right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref up;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref down;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref left;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadDPad.NativeMethodInfoPtr__ctor_Internal_Void_ButtonState_ButtonState_ButtonState_ButtonState_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00007C5C File Offset: 0x00005E5C
		public unsafe ButtonState Up
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadDPad.NativeMethodInfoPtr_get_Up_Public_get_ButtonState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00007C8C File Offset: 0x00005E8C
		public unsafe ButtonState Down
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadDPad.NativeMethodInfoPtr_get_Down_Public_get_ButtonState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00007CBC File Offset: 0x00005EBC
		public unsafe ButtonState Left
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadDPad.NativeMethodInfoPtr_get_Left_Public_get_ButtonState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00007CEC File Offset: 0x00005EEC
		public unsafe ButtonState Right
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadDPad.NativeMethodInfoPtr_get_Right_Public_get_ButtonState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002074 File Offset: 0x00000274
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GamePadDPad>.NativeClassPtr, ref this));
		}

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_up;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_down;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_left;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_right;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ButtonState_ButtonState_ButtonState_ButtonState_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_ButtonState_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_get_Down_Public_get_ButtonState_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_get_Left_Public_get_ButtonState_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_ButtonState_0;

		// Token: 0x04000035 RID: 53
		[FieldOffset(0)]
		public ButtonState up;

		// Token: 0x04000036 RID: 54
		[FieldOffset(4)]
		public ButtonState down;

		// Token: 0x04000037 RID: 55
		[FieldOffset(8)]
		public ButtonState left;

		// Token: 0x04000038 RID: 56
		[FieldOffset(12)]
		public ButtonState right;
	}
}
