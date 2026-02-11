using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001A7 RID: 423
	[StructLayout(2)]
	public struct GSClientKick_t
	{
		// Token: 0x060014EE RID: 5358 RVA: 0x0006B6D8 File Offset: 0x000698D8
		// Note: this type is marked as 'beforefieldinit'.
		static GSClientKick_t()
		{
			Il2CppClassPointerStore<GSClientKick_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GSClientKick_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSClientKick_t>.NativeClassPtr);
			GSClientKick_t.NativeFieldInfoPtr_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientKick_t>.NativeClassPtr, "SteamID");
			GSClientKick_t.NativeFieldInfoPtr_DenyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientKick_t>.NativeClassPtr, "DenyReason");
			GSClientKick_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSClientKick_t>.NativeClassPtr, "_datasize");
			GSClientKick_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSClientKick_t>.NativeClassPtr, 100667346);
			GSClientKick_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSClientKick_t>.NativeClassPtr, 100667347);
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x0006B76C File Offset: 0x0006996C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951012, XrefRangeEnd = 951016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSClientKick_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x0006B79C File Offset: 0x0006999C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSClientKick_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x00006CDF File Offset: 0x00004EDF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSClientKick_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x0006B7CC File Offset: 0x000699CC
		// (set) Token: 0x060014F3 RID: 5363 RVA: 0x00006CF1 File Offset: 0x00004EF1
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSClientKick_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSClientKick_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A96 RID: 6806
		private static readonly IntPtr NativeFieldInfoPtr_SteamID;

		// Token: 0x04001A97 RID: 6807
		private static readonly IntPtr NativeFieldInfoPtr_DenyReason;

		// Token: 0x04001A98 RID: 6808
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A99 RID: 6809
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A9A RID: 6810
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001A9B RID: 6811
		[FieldOffset(0)]
		public ulong SteamID;

		// Token: 0x04001A9C RID: 6812
		[FieldOffset(8)]
		public DenyReason DenyReason;
	}
}
