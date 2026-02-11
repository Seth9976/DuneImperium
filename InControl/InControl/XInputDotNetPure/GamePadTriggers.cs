using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace XInputDotNetPure
{
	// Token: 0x02000008 RID: 8
	[StructLayout(2)]
	public struct GamePadTriggers
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00007E50 File Offset: 0x00006050
		// Note: this type is marked as 'beforefieldinit'.
		static GamePadTriggers()
		{
			Il2CppClassPointerStore<GamePadTriggers>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "XInputDotNetPure", "GamePadTriggers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamePadTriggers>.NativeClassPtr);
			GamePadTriggers.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadTriggers>.NativeClassPtr, "left");
			GamePadTriggers.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadTriggers>.NativeClassPtr, "right");
			GamePadTriggers.NativeMethodInfoPtr__ctor_Internal_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadTriggers>.NativeClassPtr, 100663329);
			GamePadTriggers.NativeMethodInfoPtr_get_Left_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadTriggers>.NativeClassPtr, 100663330);
			GamePadTriggers.NativeMethodInfoPtr_get_Right_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadTriggers>.NativeClassPtr, 100663331);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00007EE4 File Offset: 0x000060E4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 611799, RefRangeEnd = 611804, XrefRangeStart = 611799, XrefRangeEnd = 611804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GamePadTriggers(float left, float right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadTriggers.NativeMethodInfoPtr__ctor_Internal_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00007F24 File Offset: 0x00006124
		public unsafe float Left
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadTriggers.NativeMethodInfoPtr_get_Left_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00007F54 File Offset: 0x00006154
		public unsafe float Right
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadTriggers.NativeMethodInfoPtr_get_Right_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002098 File Offset: 0x00000298
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GamePadTriggers>.NativeClassPtr, ref this));
		}

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_left;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_right;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Single_Single_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_get_Left_Public_get_Single_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Single_0;

		// Token: 0x04000045 RID: 69
		[FieldOffset(0)]
		public float left;

		// Token: 0x04000046 RID: 70
		[FieldOffset(4)]
		public float right;
	}
}
