using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200016F RID: 367
	[StructLayout(2)]
	public struct UserFavoriteItemsListChanged_t
	{
		// Token: 0x060012E3 RID: 4835 RVA: 0x000665D8 File Offset: 0x000647D8
		// Note: this type is marked as 'beforefieldinit'.
		static UserFavoriteItemsListChanged_t()
		{
			Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "UserFavoriteItemsListChanged_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr);
			UserFavoriteItemsListChanged_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr, "PublishedFileId");
			UserFavoriteItemsListChanged_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr, "Result");
			UserFavoriteItemsListChanged_t.NativeFieldInfoPtr_WasAddRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr, "WasAddRequest");
			UserFavoriteItemsListChanged_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr, "_datasize");
			UserFavoriteItemsListChanged_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr, 100667173);
			UserFavoriteItemsListChanged_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr, 100667174);
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x060012E4 RID: 4836 RVA: 0x00066680 File Offset: 0x00064880
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950763, XrefRangeEnd = 950767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserFavoriteItemsListChanged_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060012E5 RID: 4837 RVA: 0x000666B0 File Offset: 0x000648B0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserFavoriteItemsListChanged_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00005C1B File Offset: 0x00003E1B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserFavoriteItemsListChanged_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x060012E7 RID: 4839 RVA: 0x000666E0 File Offset: 0x000648E0
		// (set) Token: 0x060012E8 RID: 4840 RVA: 0x00005C2D File Offset: 0x00003E2D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserFavoriteItemsListChanged_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserFavoriteItemsListChanged_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040018F9 RID: 6393
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x040018FA RID: 6394
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040018FB RID: 6395
		private static readonly IntPtr NativeFieldInfoPtr_WasAddRequest;

		// Token: 0x040018FC RID: 6396
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040018FD RID: 6397
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040018FE RID: 6398
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040018FF RID: 6399
		[FieldOffset(0)]
		public PublishedFileId PublishedFileId;

		// Token: 0x04001900 RID: 6400
		[FieldOffset(8)]
		public Result Result;

		// Token: 0x04001901 RID: 6401
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool WasAddRequest;
	}
}
