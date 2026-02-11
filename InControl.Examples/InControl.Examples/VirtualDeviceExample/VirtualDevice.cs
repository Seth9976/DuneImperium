using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using InControl;
using UnityEngine;

namespace VirtualDeviceExample
{
	// Token: 0x02000008 RID: 8
	public class VirtualDevice : InputDevice
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00004010 File Offset: 0x00002210
		// Note: this type is marked as 'beforefieldinit'.
		static VirtualDevice()
		{
			Il2CppClassPointerStore<VirtualDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.Examples.dll", "VirtualDeviceExample", "VirtualDevice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VirtualDevice>.NativeClassPtr);
			VirtualDevice.NativeFieldInfoPtr_Sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualDevice>.NativeClassPtr, "Sensitivity");
			VirtualDevice.NativeFieldInfoPtr_MouseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualDevice>.NativeClassPtr, "MouseScale");
			VirtualDevice.NativeFieldInfoPtr_kx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualDevice>.NativeClassPtr, "kx");
			VirtualDevice.NativeFieldInfoPtr_ky = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualDevice>.NativeClassPtr, "ky");
			VirtualDevice.NativeFieldInfoPtr_mx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualDevice>.NativeClassPtr, "mx");
			VirtualDevice.NativeFieldInfoPtr_my = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualDevice>.NativeClassPtr, "my");
			VirtualDevice.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualDevice>.NativeClassPtr, 100663345);
			VirtualDevice.NativeMethodInfoPtr_Update_Public_Virtual_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualDevice>.NativeClassPtr, 100663346);
			VirtualDevice.NativeMethodInfoPtr_GetVectorFromKeyboard_Private_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualDevice>.NativeClassPtr, 100663347);
			VirtualDevice.NativeMethodInfoPtr_GetXFromKeyboard_Private_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualDevice>.NativeClassPtr, 100663348);
			VirtualDevice.NativeMethodInfoPtr_GetYFromKeyboard_Private_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualDevice>.NativeClassPtr, 100663349);
			VirtualDevice.NativeMethodInfoPtr_GetVectorFromMouse_Private_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualDevice>.NativeClassPtr, 100663350);
			VirtualDevice.NativeMethodInfoPtr_ApplySmoothing_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualDevice>.NativeClassPtr, 100663351);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004144 File Offset: 0x00002344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251473, XrefRangeEnd = 1251519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VirtualDevice()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VirtualDevice>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VirtualDevice.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00004180 File Offset: 0x00002380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251519, XrefRangeEnd = 1251545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update(ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateTick;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VirtualDevice.NativeMethodInfoPtr_Update_Public_Virtual_Void_UInt64_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000041D8 File Offset: 0x000023D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251545, XrefRangeEnd = 1251560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetVectorFromKeyboard(float deltaTime, bool smoothed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deltaTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VirtualDevice.NativeMethodInfoPtr_GetVectorFromKeyboard_Private_Vector2_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004230 File Offset: 0x00002430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251560, XrefRangeEnd = 1251563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetXFromKeyboard()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VirtualDevice.NativeMethodInfoPtr_GetXFromKeyboard_Private_Static_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004260 File Offset: 0x00002460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251563, XrefRangeEnd = 1251566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetYFromKeyboard()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VirtualDevice.NativeMethodInfoPtr_GetYFromKeyboard_Private_Static_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00004290 File Offset: 0x00002490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251566, XrefRangeEnd = 1251578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetVectorFromMouse(float deltaTime, bool smoothed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deltaTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VirtualDevice.NativeMethodInfoPtr_GetVectorFromMouse_Private_Vector2_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000042E8 File Offset: 0x000024E8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1251582, RefRangeEnd = 1251590, XrefRangeStart = 1251578, XrefRangeEnd = 1251582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ApplySmoothing(float lastValue, float thisValue, float deltaTime, float sensitivity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lastValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref thisValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensitivity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VirtualDevice.NativeMethodInfoPtr_ApplySmoothing_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000023DE File Offset: 0x000005DE
		public VirtualDevice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00004350 File Offset: 0x00002550
		// (set) Token: 0x06000074 RID: 116 RVA: 0x000023E7 File Offset: 0x000005E7
		public unsafe static float Sensitivity
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(VirtualDevice.NativeFieldInfoPtr_Sensitivity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VirtualDevice.NativeFieldInfoPtr_Sensitivity, (void*)(&value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000436C File Offset: 0x0000256C
		// (set) Token: 0x06000076 RID: 118 RVA: 0x000023F5 File Offset: 0x000005F5
		public unsafe static float MouseScale
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(VirtualDevice.NativeFieldInfoPtr_MouseScale, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VirtualDevice.NativeFieldInfoPtr_MouseScale, (void*)(&value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00004388 File Offset: 0x00002588
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00002403 File Offset: 0x00000603
		public unsafe float kx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualDevice.NativeFieldInfoPtr_kx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualDevice.NativeFieldInfoPtr_kx)) = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000043B0 File Offset: 0x000025B0
		// (set) Token: 0x0600007A RID: 122 RVA: 0x0000241E File Offset: 0x0000061E
		public unsafe float ky
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualDevice.NativeFieldInfoPtr_ky);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualDevice.NativeFieldInfoPtr_ky)) = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000043D8 File Offset: 0x000025D8
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00002439 File Offset: 0x00000639
		public unsafe float mx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualDevice.NativeFieldInfoPtr_mx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualDevice.NativeFieldInfoPtr_mx)) = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00004400 File Offset: 0x00002600
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00002454 File Offset: 0x00000654
		public unsafe float my
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualDevice.NativeFieldInfoPtr_my);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualDevice.NativeFieldInfoPtr_my)) = value;
			}
		}

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_Sensitivity;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_MouseScale;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_kx;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_ky;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_mx;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_my;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_UInt64_Single_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_GetVectorFromKeyboard_Private_Vector2_Single_Boolean_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_GetXFromKeyboard_Private_Static_Single_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_GetYFromKeyboard_Private_Static_Single_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_GetVectorFromMouse_Private_Vector2_Single_Boolean_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_ApplySmoothing_Private_Static_Single_Single_Single_Single_Single_0;
	}
}
