using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000112 RID: 274
	[StructLayout(2)]
	public struct LobbyMatchList_t
	{
		// Token: 0x06000FF0 RID: 4080 RVA: 0x0005EA20 File Offset: 0x0005CC20
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyMatchList_t()
		{
			Il2CppClassPointerStore<LobbyMatchList_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "LobbyMatchList_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyMatchList_t>.NativeClassPtr);
			LobbyMatchList_t.NativeFieldInfoPtr_LobbiesMatching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyMatchList_t>.NativeClassPtr, "LobbiesMatching");
			LobbyMatchList_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyMatchList_t>.NativeClassPtr, "_datasize");
			LobbyMatchList_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMatchList_t>.NativeClassPtr, 100666882);
			LobbyMatchList_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyMatchList_t>.NativeClassPtr, 100666883);
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x0005EAA0 File Offset: 0x0005CCA0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950339, XrefRangeEnd = 950343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyMatchList_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x0005EAD0 File Offset: 0x0005CCD0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyMatchList_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00004696 File Offset: 0x00002896
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyMatchList_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x0005EB00 File Offset: 0x0005CD00
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x000046A8 File Offset: 0x000028A8
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyMatchList_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyMatchList_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400163B RID: 5691
		private static readonly IntPtr NativeFieldInfoPtr_LobbiesMatching;

		// Token: 0x0400163C RID: 5692
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400163D RID: 5693
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400163E RID: 5694
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400163F RID: 5695
		[FieldOffset(0)]
		public uint LobbiesMatching;
	}
}
