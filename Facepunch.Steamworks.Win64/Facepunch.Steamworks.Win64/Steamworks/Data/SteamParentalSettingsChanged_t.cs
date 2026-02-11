using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200019D RID: 413
	[StructLayout(2)]
	public struct SteamParentalSettingsChanged_t
	{
		// Token: 0x0600148E RID: 5262 RVA: 0x0006A83C File Offset: 0x00068A3C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamParentalSettingsChanged_t()
		{
			Il2CppClassPointerStore<SteamParentalSettingsChanged_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamParentalSettingsChanged_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamParentalSettingsChanged_t>.NativeClassPtr);
			SteamParentalSettingsChanged_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParentalSettingsChanged_t>.NativeClassPtr, "_datasize");
			SteamParentalSettingsChanged_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParentalSettingsChanged_t>.NativeClassPtr, 100667313);
			SteamParentalSettingsChanged_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParentalSettingsChanged_t>.NativeClassPtr, 100667314);
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x0006A8A8 File Offset: 0x00068AA8
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950960, XrefRangeEnd = 950964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParentalSettingsChanged_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x0006A8D8 File Offset: 0x00068AD8
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParentalSettingsChanged_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x000069C6 File Offset: 0x00004BC6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamParentalSettingsChanged_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x0006A908 File Offset: 0x00068B08
		// (set) Token: 0x06001493 RID: 5267 RVA: 0x000069D8 File Offset: 0x00004BD8
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamParentalSettingsChanged_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamParentalSettingsChanged_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A5D RID: 6749
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A5E RID: 6750
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A5F RID: 6751
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
