using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000197 RID: 407
	[StructLayout(2)]
	public struct SteamInventoryDefinitionUpdate_t
	{
		// Token: 0x0600145C RID: 5212 RVA: 0x00069FEC File Offset: 0x000681EC
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventoryDefinitionUpdate_t()
		{
			Il2CppClassPointerStore<SteamInventoryDefinitionUpdate_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamInventoryDefinitionUpdate_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventoryDefinitionUpdate_t>.NativeClassPtr);
			SteamInventoryDefinitionUpdate_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryDefinitionUpdate_t>.NativeClassPtr, "_datasize");
			SteamInventoryDefinitionUpdate_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryDefinitionUpdate_t>.NativeClassPtr, 100667293);
			SteamInventoryDefinitionUpdate_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryDefinitionUpdate_t>.NativeClassPtr, 100667294);
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x0006A058 File Offset: 0x00068258
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950927, XrefRangeEnd = 950931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryDefinitionUpdate_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x0006A088 File Offset: 0x00068288
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryDefinitionUpdate_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x00006865 File Offset: 0x00004A65
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInventoryDefinitionUpdate_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x0006A0B8 File Offset: 0x000682B8
		// (set) Token: 0x06001461 RID: 5217 RVA: 0x00006877 File Offset: 0x00004A77
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInventoryDefinitionUpdate_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventoryDefinitionUpdate_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A32 RID: 6706
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A33 RID: 6707
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A34 RID: 6708
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
