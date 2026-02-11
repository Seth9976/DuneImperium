using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000196 RID: 406
	[StructLayout(2)]
	public struct SteamInventoryFullUpdate_t
	{
		// Token: 0x06001456 RID: 5206 RVA: 0x00069EF0 File Offset: 0x000680F0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventoryFullUpdate_t()
		{
			Il2CppClassPointerStore<SteamInventoryFullUpdate_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamInventoryFullUpdate_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventoryFullUpdate_t>.NativeClassPtr);
			SteamInventoryFullUpdate_t.NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryFullUpdate_t>.NativeClassPtr, "Handle");
			SteamInventoryFullUpdate_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryFullUpdate_t>.NativeClassPtr, "_datasize");
			SteamInventoryFullUpdate_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryFullUpdate_t>.NativeClassPtr, 100667290);
			SteamInventoryFullUpdate_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryFullUpdate_t>.NativeClassPtr, 100667291);
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x00069F70 File Offset: 0x00068170
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950923, XrefRangeEnd = 950927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryFullUpdate_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x00069FA0 File Offset: 0x000681A0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryFullUpdate_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00006845 File Offset: 0x00004A45
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInventoryFullUpdate_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x00069FD0 File Offset: 0x000681D0
		// (set) Token: 0x0600145B RID: 5211 RVA: 0x00006857 File Offset: 0x00004A57
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInventoryFullUpdate_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventoryFullUpdate_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A2D RID: 6701
		private static readonly IntPtr NativeFieldInfoPtr_Handle;

		// Token: 0x04001A2E RID: 6702
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A2F RID: 6703
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A30 RID: 6704
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001A31 RID: 6705
		[FieldOffset(0)]
		public int Handle;
	}
}
