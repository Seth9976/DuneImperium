using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000E1 RID: 225
	[StructLayout(2)]
	public struct SteamServersConnected_t
	{
		// Token: 0x06000EA8 RID: 3752 RVA: 0x0005AFFC File Offset: 0x000591FC
		// Note: this type is marked as 'beforefieldinit'.
		static SteamServersConnected_t()
		{
			Il2CppClassPointerStore<SteamServersConnected_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamServersConnected_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamServersConnected_t>.NativeClassPtr);
			SteamServersConnected_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServersConnected_t>.NativeClassPtr, "_datasize");
			SteamServersConnected_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServersConnected_t>.NativeClassPtr, 100666729);
			SteamServersConnected_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServersConnected_t>.NativeClassPtr, 100666730);
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x0005B068 File Offset: 0x00059268
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950113, XrefRangeEnd = 950117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServersConnected_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x0005B098 File Offset: 0x00059298
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServersConnected_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00003EFB File Offset: 0x000020FB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamServersConnected_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x0005B0C8 File Offset: 0x000592C8
		// (set) Token: 0x06000EAD RID: 3757 RVA: 0x00003F0D File Offset: 0x0000210D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamServersConnected_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServersConnected_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040014C7 RID: 5319
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040014C8 RID: 5320
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040014C9 RID: 5321
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
