using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000167 RID: 359
	[StructLayout(2)]
	public struct SteamInputDeviceDisconnected_t
	{
		// Token: 0x060012A0 RID: 4768 RVA: 0x00065A8C File Offset: 0x00063C8C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInputDeviceDisconnected_t()
		{
			Il2CppClassPointerStore<SteamInputDeviceDisconnected_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamInputDeviceDisconnected_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInputDeviceDisconnected_t>.NativeClassPtr);
			SteamInputDeviceDisconnected_t.NativeFieldInfoPtr_DisconnectedDeviceHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInputDeviceDisconnected_t>.NativeClassPtr, "DisconnectedDeviceHandle");
			SteamInputDeviceDisconnected_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInputDeviceDisconnected_t>.NativeClassPtr, "_datasize");
			SteamInputDeviceDisconnected_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInputDeviceDisconnected_t>.NativeClassPtr, 100667148);
			SteamInputDeviceDisconnected_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInputDeviceDisconnected_t>.NativeClassPtr, 100667149);
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x060012A1 RID: 4769 RVA: 0x00065B0C File Offset: 0x00063D0C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950727, XrefRangeEnd = 950731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInputDeviceDisconnected_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x00065B3C File Offset: 0x00063D3C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInputDeviceDisconnected_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x00005A1A File Offset: 0x00003C1A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInputDeviceDisconnected_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x00065B6C File Offset: 0x00063D6C
		// (set) Token: 0x060012A5 RID: 4773 RVA: 0x00005A2C File Offset: 0x00003C2C
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInputDeviceDisconnected_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInputDeviceDisconnected_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040018B2 RID: 6322
		private static readonly IntPtr NativeFieldInfoPtr_DisconnectedDeviceHandle;

		// Token: 0x040018B3 RID: 6323
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040018B4 RID: 6324
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040018B5 RID: 6325
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040018B6 RID: 6326
		[FieldOffset(0)]
		public ulong DisconnectedDeviceHandle;
	}
}
