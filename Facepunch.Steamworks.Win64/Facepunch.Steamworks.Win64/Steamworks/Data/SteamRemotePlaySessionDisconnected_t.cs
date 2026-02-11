using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200019F RID: 415
	[StructLayout(2)]
	public struct SteamRemotePlaySessionDisconnected_t
	{
		// Token: 0x0600149A RID: 5274 RVA: 0x0006AA20 File Offset: 0x00068C20
		// Note: this type is marked as 'beforefieldinit'.
		static SteamRemotePlaySessionDisconnected_t()
		{
			Il2CppClassPointerStore<SteamRemotePlaySessionDisconnected_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamRemotePlaySessionDisconnected_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamRemotePlaySessionDisconnected_t>.NativeClassPtr);
			SteamRemotePlaySessionDisconnected_t.NativeFieldInfoPtr_SessionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRemotePlaySessionDisconnected_t>.NativeClassPtr, "SessionID");
			SteamRemotePlaySessionDisconnected_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRemotePlaySessionDisconnected_t>.NativeClassPtr, "_datasize");
			SteamRemotePlaySessionDisconnected_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlaySessionDisconnected_t>.NativeClassPtr, 100667319);
			SteamRemotePlaySessionDisconnected_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlaySessionDisconnected_t>.NativeClassPtr, 100667320);
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x0006AAA0 File Offset: 0x00068CA0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950968, XrefRangeEnd = 950972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlaySessionDisconnected_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x0006AAD0 File Offset: 0x00068CD0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlaySessionDisconnected_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x00006A06 File Offset: 0x00004C06
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamRemotePlaySessionDisconnected_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x0600149E RID: 5278 RVA: 0x0006AB00 File Offset: 0x00068D00
		// (set) Token: 0x0600149F RID: 5279 RVA: 0x00006A18 File Offset: 0x00004C18
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamRemotePlaySessionDisconnected_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamRemotePlaySessionDisconnected_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A65 RID: 6757
		private static readonly IntPtr NativeFieldInfoPtr_SessionID;

		// Token: 0x04001A66 RID: 6758
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A67 RID: 6759
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A68 RID: 6760
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001A69 RID: 6761
		[FieldOffset(0)]
		public uint SessionID;
	}
}
