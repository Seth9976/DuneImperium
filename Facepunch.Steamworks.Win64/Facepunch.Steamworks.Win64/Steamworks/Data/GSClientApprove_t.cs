using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001A5 RID: 421
	[StructLayout(2)]
	public struct GSClientApprove_t
	{
		// Token: 0x060014DA RID: 5338 RVA: 0x0006B3AC File Offset: 0x000695AC
		// Note: this type is marked as 'beforefieldinit'.
		static GSClientApprove_t()
		{
			Il2CppClassPointerStore<GSClientApprove_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GSClientApprove_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSClientApprove_t>.NativeClassPtr);
			GSClientApprove_t.NativeFieldInfoPtr_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientApprove_t>.NativeClassPtr, "SteamID");
			GSClientApprove_t.NativeFieldInfoPtr_OwnerSteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientApprove_t>.NativeClassPtr, "OwnerSteamID");
			GSClientApprove_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientApprove_t>.NativeClassPtr, "_datasize");
			GSClientApprove_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSClientApprove_t>.NativeClassPtr, 100667339);
			GSClientApprove_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSClientApprove_t>.NativeClassPtr, 100667340);
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x0006B440 File Offset: 0x00069640
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951000, XrefRangeEnd = 951004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSClientApprove_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x0006B470 File Offset: 0x00069670
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSClientApprove_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x00006C41 File Offset: 0x00004E41
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSClientApprove_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x0006B4A0 File Offset: 0x000696A0
		// (set) Token: 0x060014DF RID: 5343 RVA: 0x00006C53 File Offset: 0x00004E53
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSClientApprove_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSClientApprove_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A88 RID: 6792
		private static readonly IntPtr NativeFieldInfoPtr_SteamID;

		// Token: 0x04001A89 RID: 6793
		private static readonly IntPtr NativeFieldInfoPtr_OwnerSteamID;

		// Token: 0x04001A8A RID: 6794
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A8B RID: 6795
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A8C RID: 6796
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001A8D RID: 6797
		[FieldOffset(0)]
		public ulong SteamID;

		// Token: 0x04001A8E RID: 6798
		[FieldOffset(8)]
		public ulong OwnerSteamID;
	}
}
