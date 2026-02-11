using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000E3 RID: 227
	[StructLayout(2)]
	public struct SteamServersDisconnected_t
	{
		// Token: 0x06000EB4 RID: 3764 RVA: 0x0005B1F4 File Offset: 0x000593F4
		// Note: this type is marked as 'beforefieldinit'.
		static SteamServersDisconnected_t()
		{
			Il2CppClassPointerStore<SteamServersDisconnected_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamServersDisconnected_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamServersDisconnected_t>.NativeClassPtr);
			SteamServersDisconnected_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServersDisconnected_t>.NativeClassPtr, "Result");
			SteamServersDisconnected_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServersDisconnected_t>.NativeClassPtr, "_datasize");
			SteamServersDisconnected_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServersDisconnected_t>.NativeClassPtr, 100666735);
			SteamServersDisconnected_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServersDisconnected_t>.NativeClassPtr, 100666736);
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x0005B274 File Offset: 0x00059474
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950121, XrefRangeEnd = 950125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServersDisconnected_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x0005B2A4 File Offset: 0x000594A4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServersDisconnected_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00003F3B File Offset: 0x0000213B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamServersDisconnected_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x0005B2D4 File Offset: 0x000594D4
		// (set) Token: 0x06000EB9 RID: 3769 RVA: 0x00003F4D File Offset: 0x0000214D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamServersDisconnected_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServersDisconnected_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040014D1 RID: 5329
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040014D2 RID: 5330
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040014D3 RID: 5331
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040014D4 RID: 5332
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040014D5 RID: 5333
		[FieldOffset(0)]
		public Result Result;
	}
}
