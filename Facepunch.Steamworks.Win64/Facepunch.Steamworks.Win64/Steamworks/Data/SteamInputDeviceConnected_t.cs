using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000166 RID: 358
	[StructLayout(2)]
	public struct SteamInputDeviceConnected_t
	{
		// Token: 0x0600129A RID: 4762 RVA: 0x00065990 File Offset: 0x00063B90
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInputDeviceConnected_t()
		{
			Il2CppClassPointerStore<SteamInputDeviceConnected_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamInputDeviceConnected_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInputDeviceConnected_t>.NativeClassPtr);
			SteamInputDeviceConnected_t.NativeFieldInfoPtr_ConnectedDeviceHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInputDeviceConnected_t>.NativeClassPtr, "ConnectedDeviceHandle");
			SteamInputDeviceConnected_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInputDeviceConnected_t>.NativeClassPtr, "_datasize");
			SteamInputDeviceConnected_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInputDeviceConnected_t>.NativeClassPtr, 100667145);
			SteamInputDeviceConnected_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInputDeviceConnected_t>.NativeClassPtr, 100667146);
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x00065A10 File Offset: 0x00063C10
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950723, XrefRangeEnd = 950727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInputDeviceConnected_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x0600129C RID: 4764 RVA: 0x00065A40 File Offset: 0x00063C40
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInputDeviceConnected_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x000059FA File Offset: 0x00003BFA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInputDeviceConnected_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x00065A70 File Offset: 0x00063C70
		// (set) Token: 0x0600129F RID: 4767 RVA: 0x00005A0C File Offset: 0x00003C0C
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInputDeviceConnected_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInputDeviceConnected_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040018AD RID: 6317
		private static readonly IntPtr NativeFieldInfoPtr_ConnectedDeviceHandle;

		// Token: 0x040018AE RID: 6318
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040018AF RID: 6319
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040018B0 RID: 6320
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040018B1 RID: 6321
		[FieldOffset(0)]
		public ulong ConnectedDeviceHandle;
	}
}
