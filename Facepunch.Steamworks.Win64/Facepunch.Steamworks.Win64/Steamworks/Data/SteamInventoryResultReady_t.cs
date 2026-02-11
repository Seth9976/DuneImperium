using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000195 RID: 405
	[StructLayout(2)]
	public struct SteamInventoryResultReady_t
	{
		// Token: 0x06001450 RID: 5200 RVA: 0x00069DE0 File Offset: 0x00067FE0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventoryResultReady_t()
		{
			Il2CppClassPointerStore<SteamInventoryResultReady_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamInventoryResultReady_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventoryResultReady_t>.NativeClassPtr);
			SteamInventoryResultReady_t.NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryResultReady_t>.NativeClassPtr, "Handle");
			SteamInventoryResultReady_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryResultReady_t>.NativeClassPtr, "Result");
			SteamInventoryResultReady_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryResultReady_t>.NativeClassPtr, "_datasize");
			SteamInventoryResultReady_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResultReady_t>.NativeClassPtr, 100667287);
			SteamInventoryResultReady_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResultReady_t>.NativeClassPtr, 100667288);
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x00069E74 File Offset: 0x00068074
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950919, XrefRangeEnd = 950923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResultReady_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001452 RID: 5202 RVA: 0x00069EA4 File Offset: 0x000680A4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResultReady_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x00006825 File Offset: 0x00004A25
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInventoryResultReady_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x00069ED4 File Offset: 0x000680D4
		// (set) Token: 0x06001455 RID: 5205 RVA: 0x00006837 File Offset: 0x00004A37
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInventoryResultReady_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventoryResultReady_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A26 RID: 6694
		private static readonly IntPtr NativeFieldInfoPtr_Handle;

		// Token: 0x04001A27 RID: 6695
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001A28 RID: 6696
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A29 RID: 6697
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A2A RID: 6698
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001A2B RID: 6699
		[FieldOffset(0)]
		public int Handle;

		// Token: 0x04001A2C RID: 6700
		[FieldOffset(4)]
		public Result Result;
	}
}
