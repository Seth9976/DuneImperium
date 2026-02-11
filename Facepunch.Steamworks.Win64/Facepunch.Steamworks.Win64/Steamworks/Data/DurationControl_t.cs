using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000EE RID: 238
	[StructLayout(2)]
	public struct DurationControl_t
	{
		// Token: 0x06000EFE RID: 3838 RVA: 0x0005BF08 File Offset: 0x0005A108
		// Note: this type is marked as 'beforefieldinit'.
		static DurationControl_t()
		{
			Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "DurationControl_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr);
			DurationControl_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, "Result");
			DurationControl_t.NativeFieldInfoPtr_Appid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, "Appid");
			DurationControl_t.NativeFieldInfoPtr_Applicable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, "Applicable");
			DurationControl_t.NativeFieldInfoPtr_CsecsLast5h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, "CsecsLast5h");
			DurationControl_t.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, "Progress");
			DurationControl_t.NativeFieldInfoPtr_Otification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, "Otification");
			DurationControl_t.NativeFieldInfoPtr_CsecsToday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, "CsecsToday");
			DurationControl_t.NativeFieldInfoPtr_CsecsRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, "CsecsRemaining");
			DurationControl_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, "_datasize");
			DurationControl_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, 100666770);
			DurationControl_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, 100666771);
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x0005C014 File Offset: 0x0005A214
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950175, XrefRangeEnd = 950179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DurationControl_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x0005C044 File Offset: 0x0005A244
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DurationControl_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x000040EB File Offset: 0x000022EB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x0005C074 File Offset: 0x0005A274
		// (set) Token: 0x06000F03 RID: 3843 RVA: 0x000040FD File Offset: 0x000022FD
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DurationControl_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DurationControl_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001520 RID: 5408
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001521 RID: 5409
		private static readonly IntPtr NativeFieldInfoPtr_Appid;

		// Token: 0x04001522 RID: 5410
		private static readonly IntPtr NativeFieldInfoPtr_Applicable;

		// Token: 0x04001523 RID: 5411
		private static readonly IntPtr NativeFieldInfoPtr_CsecsLast5h;

		// Token: 0x04001524 RID: 5412
		private static readonly IntPtr NativeFieldInfoPtr_Progress;

		// Token: 0x04001525 RID: 5413
		private static readonly IntPtr NativeFieldInfoPtr_Otification;

		// Token: 0x04001526 RID: 5414
		private static readonly IntPtr NativeFieldInfoPtr_CsecsToday;

		// Token: 0x04001527 RID: 5415
		private static readonly IntPtr NativeFieldInfoPtr_CsecsRemaining;

		// Token: 0x04001528 RID: 5416
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001529 RID: 5417
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400152A RID: 5418
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400152B RID: 5419
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x0400152C RID: 5420
		[FieldOffset(4)]
		public AppId Appid;

		// Token: 0x0400152D RID: 5421
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool Applicable;

		// Token: 0x0400152E RID: 5422
		[FieldOffset(12)]
		public int CsecsLast5h;

		// Token: 0x0400152F RID: 5423
		[FieldOffset(16)]
		public DurationControlProgress Progress;

		// Token: 0x04001530 RID: 5424
		[FieldOffset(20)]
		public DurationControlNotification Otification;

		// Token: 0x04001531 RID: 5425
		[FieldOffset(24)]
		public int CsecsToday;

		// Token: 0x04001532 RID: 5426
		[FieldOffset(28)]
		public int CsecsRemaining;
	}
}
