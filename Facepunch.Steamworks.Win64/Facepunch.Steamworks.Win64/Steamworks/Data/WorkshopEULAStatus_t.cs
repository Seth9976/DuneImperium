using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200017B RID: 379
	[StructLayout(2)]
	public struct WorkshopEULAStatus_t
	{
		// Token: 0x06001336 RID: 4918 RVA: 0x00067444 File Offset: 0x00065644
		// Note: this type is marked as 'beforefieldinit'.
		static WorkshopEULAStatus_t()
		{
			Il2CppClassPointerStore<WorkshopEULAStatus_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "WorkshopEULAStatus_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkshopEULAStatus_t>.NativeClassPtr);
			WorkshopEULAStatus_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopEULAStatus_t>.NativeClassPtr, "Result");
			WorkshopEULAStatus_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopEULAStatus_t>.NativeClassPtr, "AppID");
			WorkshopEULAStatus_t.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopEULAStatus_t>.NativeClassPtr, "Version");
			WorkshopEULAStatus_t.NativeFieldInfoPtr_TAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopEULAStatus_t>.NativeClassPtr, "TAction");
			WorkshopEULAStatus_t.NativeFieldInfoPtr_Accepted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopEULAStatus_t>.NativeClassPtr, "Accepted");
			WorkshopEULAStatus_t.NativeFieldInfoPtr_NeedsAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopEULAStatus_t>.NativeClassPtr, "NeedsAction");
			WorkshopEULAStatus_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopEULAStatus_t>.NativeClassPtr, "_datasize");
			WorkshopEULAStatus_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopEULAStatus_t>.NativeClassPtr, 100667209);
			WorkshopEULAStatus_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopEULAStatus_t>.NativeClassPtr, 100667210);
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x00067528 File Offset: 0x00065728
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950815, XrefRangeEnd = 950819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkshopEULAStatus_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x00067558 File Offset: 0x00065758
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkshopEULAStatus_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00005E2F File Offset: 0x0000402F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorkshopEULAStatus_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x00067588 File Offset: 0x00065788
		// (set) Token: 0x0600133B RID: 4923 RVA: 0x00005E41 File Offset: 0x00004041
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WorkshopEULAStatus_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorkshopEULAStatus_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400195A RID: 6490
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x0400195B RID: 6491
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x0400195C RID: 6492
		private static readonly IntPtr NativeFieldInfoPtr_Version;

		// Token: 0x0400195D RID: 6493
		private static readonly IntPtr NativeFieldInfoPtr_TAction;

		// Token: 0x0400195E RID: 6494
		private static readonly IntPtr NativeFieldInfoPtr_Accepted;

		// Token: 0x0400195F RID: 6495
		private static readonly IntPtr NativeFieldInfoPtr_NeedsAction;

		// Token: 0x04001960 RID: 6496
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001961 RID: 6497
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001962 RID: 6498
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001963 RID: 6499
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x04001964 RID: 6500
		[FieldOffset(4)]
		public AppId AppID;

		// Token: 0x04001965 RID: 6501
		[FieldOffset(8)]
		public uint Version;

		// Token: 0x04001966 RID: 6502
		[FieldOffset(12)]
		public uint TAction;

		// Token: 0x04001967 RID: 6503
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool Accepted;

		// Token: 0x04001968 RID: 6504
		[FieldOffset(17)]
		[MarshalAs(4)]
		public bool NeedsAction;
	}
}
