using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace Steamworks
{
	// Token: 0x020000C6 RID: 198
	public static class Platform : Object
	{
		// Token: 0x06000CA2 RID: 3234 RVA: 0x000534A8 File Offset: 0x000516A8
		// Note: this type is marked as 'beforefieldinit'.
		static Platform()
		{
			Il2CppClassPointerStore<Platform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "Platform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Platform>.NativeClassPtr);
			Platform.NativeFieldInfoPtr_StructPlatformPackSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Platform>.NativeClassPtr, "StructPlatformPackSize");
			Platform.NativeFieldInfoPtr_LibraryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Platform>.NativeClassPtr, "LibraryName");
			Platform.NativeFieldInfoPtr_CC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Platform>.NativeClassPtr, "CC");
			Platform.NativeFieldInfoPtr_StructPackSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Platform>.NativeClassPtr, "StructPackSize");
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00003290 File Offset: 0x00001490
		public Platform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x00053528 File Offset: 0x00051728
		// (set) Token: 0x06000CA5 RID: 3237 RVA: 0x00003299 File Offset: 0x00001499
		public unsafe static int StructPlatformPackSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Platform.NativeFieldInfoPtr_StructPlatformPackSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Platform.NativeFieldInfoPtr_StructPlatformPackSize, (void*)(&value));
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x00053544 File Offset: 0x00051744
		// (set) Token: 0x06000CA7 RID: 3239 RVA: 0x000032A7 File Offset: 0x000014A7
		public unsafe static string LibraryName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Platform.NativeFieldInfoPtr_LibraryName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Platform.NativeFieldInfoPtr_LibraryName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x00053564 File Offset: 0x00051764
		// (set) Token: 0x06000CA9 RID: 3241 RVA: 0x000032B9 File Offset: 0x000014B9
		public unsafe static CallingConvention CC
		{
			get
			{
				CallingConvention callingConvention;
				IL2CPP.il2cpp_field_static_get_value(Platform.NativeFieldInfoPtr_CC, (void*)(&callingConvention));
				return callingConvention;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Platform.NativeFieldInfoPtr_CC, (void*)(&value));
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x00053580 File Offset: 0x00051780
		// (set) Token: 0x06000CAB RID: 3243 RVA: 0x000032C7 File Offset: 0x000014C7
		public unsafe static int StructPackSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Platform.NativeFieldInfoPtr_StructPackSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Platform.NativeFieldInfoPtr_StructPackSize, (void*)(&value));
			}
		}

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeFieldInfoPtr_StructPlatformPackSize;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeFieldInfoPtr_LibraryName;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeFieldInfoPtr_CC;

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeFieldInfoPtr_StructPackSize;
	}
}
