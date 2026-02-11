using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000177 RID: 375
	[StructLayout(2)]
	public struct RemoveAppDependencyResult_t
	{
		// Token: 0x06001313 RID: 4883 RVA: 0x00066ED0 File Offset: 0x000650D0
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveAppDependencyResult_t()
		{
			Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoveAppDependencyResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr);
			RemoveAppDependencyResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr, "Result");
			RemoveAppDependencyResult_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr, "PublishedFileId");
			RemoveAppDependencyResult_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr, "AppID");
			RemoveAppDependencyResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr, "_datasize");
			RemoveAppDependencyResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr, 100667197);
			RemoveAppDependencyResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr, 100667198);
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001314 RID: 4884 RVA: 0x00066F78 File Offset: 0x00065178
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950799, XrefRangeEnd = 950803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveAppDependencyResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001315 RID: 4885 RVA: 0x00066FA8 File Offset: 0x000651A8
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveAppDependencyResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00005D1B File Offset: 0x00003F1B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoveAppDependencyResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001317 RID: 4887 RVA: 0x00066FD8 File Offset: 0x000651D8
		// (set) Token: 0x06001318 RID: 4888 RVA: 0x00005D2D File Offset: 0x00003F2D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoveAppDependencyResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoveAppDependencyResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400193D RID: 6461
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x0400193E RID: 6462
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x0400193F RID: 6463
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x04001940 RID: 6464
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001941 RID: 6465
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001942 RID: 6466
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001943 RID: 6467
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x04001944 RID: 6468
		[FieldOffset(8)]
		public PublishedFileId PublishedFileId;

		// Token: 0x04001945 RID: 6469
		[FieldOffset(16)]
		public AppId AppID;
	}
}
