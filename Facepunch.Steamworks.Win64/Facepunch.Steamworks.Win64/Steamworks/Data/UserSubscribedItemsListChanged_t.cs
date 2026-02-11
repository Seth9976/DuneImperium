using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200017A RID: 378
	[StructLayout(2)]
	public struct UserSubscribedItemsListChanged_t
	{
		// Token: 0x06001330 RID: 4912 RVA: 0x00067348 File Offset: 0x00065548
		// Note: this type is marked as 'beforefieldinit'.
		static UserSubscribedItemsListChanged_t()
		{
			Il2CppClassPointerStore<UserSubscribedItemsListChanged_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "UserSubscribedItemsListChanged_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserSubscribedItemsListChanged_t>.NativeClassPtr);
			UserSubscribedItemsListChanged_t.NativeFieldInfoPtr_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserSubscribedItemsListChanged_t>.NativeClassPtr, "AppID");
			UserSubscribedItemsListChanged_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserSubscribedItemsListChanged_t>.NativeClassPtr, "_datasize");
			UserSubscribedItemsListChanged_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserSubscribedItemsListChanged_t>.NativeClassPtr, 100667206);
			UserSubscribedItemsListChanged_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserSubscribedItemsListChanged_t>.NativeClassPtr, 100667207);
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x000673C8 File Offset: 0x000655C8
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950811, XrefRangeEnd = 950815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserSubscribedItemsListChanged_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x000673F8 File Offset: 0x000655F8
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserSubscribedItemsListChanged_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x00005E0F File Offset: 0x0000400F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserSubscribedItemsListChanged_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x00067428 File Offset: 0x00065628
		// (set) Token: 0x06001335 RID: 4917 RVA: 0x00005E21 File Offset: 0x00004021
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserSubscribedItemsListChanged_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserSubscribedItemsListChanged_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001955 RID: 6485
		private static readonly IntPtr NativeFieldInfoPtr_AppID;

		// Token: 0x04001956 RID: 6486
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001957 RID: 6487
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001958 RID: 6488
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001959 RID: 6489
		[FieldOffset(0)]
		public AppId AppID;
	}
}
