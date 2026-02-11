using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000106 RID: 262
	[StructLayout(2)]
	public struct SteamShutdown_t
	{
		// Token: 0x06000FA8 RID: 4008 RVA: 0x0005DCC0 File Offset: 0x0005BEC0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamShutdown_t()
		{
			Il2CppClassPointerStore<SteamShutdown_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamShutdown_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamShutdown_t>.NativeClassPtr);
			SteamShutdown_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamShutdown_t>.NativeClassPtr, "_datasize");
			SteamShutdown_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamShutdown_t>.NativeClassPtr, 100666846);
			SteamShutdown_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamShutdown_t>.NativeClassPtr, 100666847);
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x0005DD2C File Offset: 0x0005BF2C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950291, XrefRangeEnd = 950295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamShutdown_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x0005DD5C File Offset: 0x0005BF5C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamShutdown_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00004516 File Offset: 0x00002716
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamShutdown_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x0005DD8C File Offset: 0x0005BF8C
		// (set) Token: 0x06000FAD RID: 4013 RVA: 0x00004528 File Offset: 0x00002728
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamShutdown_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamShutdown_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040015D7 RID: 5591
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040015D8 RID: 5592
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040015D9 RID: 5593
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
