using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200019C RID: 412
	[StructLayout(2)]
	public struct GetOPFSettingsResult_t
	{
		// Token: 0x06001488 RID: 5256 RVA: 0x0006A72C File Offset: 0x0006892C
		// Note: this type is marked as 'beforefieldinit'.
		static GetOPFSettingsResult_t()
		{
			Il2CppClassPointerStore<GetOPFSettingsResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GetOPFSettingsResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetOPFSettingsResult_t>.NativeClassPtr);
			GetOPFSettingsResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOPFSettingsResult_t>.NativeClassPtr, "Result");
			GetOPFSettingsResult_t.NativeFieldInfoPtr_VideoAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOPFSettingsResult_t>.NativeClassPtr, "VideoAppID");
			GetOPFSettingsResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOPFSettingsResult_t>.NativeClassPtr, "_datasize");
			GetOPFSettingsResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetOPFSettingsResult_t>.NativeClassPtr, 100667310);
			GetOPFSettingsResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetOPFSettingsResult_t>.NativeClassPtr, 100667311);
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x0006A7C0 File Offset: 0x000689C0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950956, XrefRangeEnd = 950960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetOPFSettingsResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x0006A7F0 File Offset: 0x000689F0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetOPFSettingsResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x000069A6 File Offset: 0x00004BA6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetOPFSettingsResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x0006A820 File Offset: 0x00068A20
		// (set) Token: 0x0600148D RID: 5261 RVA: 0x000069B8 File Offset: 0x00004BB8
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GetOPFSettingsResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetOPFSettingsResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A56 RID: 6742
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001A57 RID: 6743
		private static readonly IntPtr NativeFieldInfoPtr_VideoAppID;

		// Token: 0x04001A58 RID: 6744
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A59 RID: 6745
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A5A RID: 6746
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001A5B RID: 6747
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x04001A5C RID: 6748
		[FieldOffset(4)]
		public AppId VideoAppID;
	}
}
