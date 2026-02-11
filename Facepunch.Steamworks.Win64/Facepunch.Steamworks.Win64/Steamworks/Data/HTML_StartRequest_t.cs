using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000180 RID: 384
	public sealed class HTML_StartRequest_t : ValueType
	{
		// Token: 0x0600136D RID: 4973 RVA: 0x00067CA0 File Offset: 0x00065EA0
		// Note: this type is marked as 'beforefieldinit'.
		static HTML_StartRequest_t()
		{
			Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTML_StartRequest_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr);
			HTML_StartRequest_t.NativeFieldInfoPtr_UnBrowserHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr, "UnBrowserHandle");
			HTML_StartRequest_t.NativeFieldInfoPtr_PchURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr, "PchURL");
			HTML_StartRequest_t.NativeFieldInfoPtr_PchTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr, "PchTarget");
			HTML_StartRequest_t.NativeFieldInfoPtr_PchPostData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr, "PchPostData");
			HTML_StartRequest_t.NativeFieldInfoPtr_BIsRedirect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr, "BIsRedirect");
			HTML_StartRequest_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr, "_datasize");
			HTML_StartRequest_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr, 100667224);
			HTML_StartRequest_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr, 100667225);
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x00067D70 File Offset: 0x00065F70
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950835, XrefRangeEnd = 950839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_StartRequest_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x00067DB4 File Offset: 0x00065FB4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTML_StartRequest_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00006020 File Offset: 0x00004220
		public HTML_StartRequest_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x00006029 File Offset: 0x00004229
		public HTML_StartRequest_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HTML_StartRequest_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x00067DF8 File Offset: 0x00065FF8
		// (set) Token: 0x06001373 RID: 4979 RVA: 0x0000603B File Offset: 0x0000423B
		public unsafe uint UnBrowserHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_UnBrowserHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_UnBrowserHandle)) = value;
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x00067E20 File Offset: 0x00066020
		// (set) Token: 0x06001375 RID: 4981 RVA: 0x00006056 File Offset: 0x00004256
		public unsafe string PchURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_PchURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_PchURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x00067E48 File Offset: 0x00066048
		// (set) Token: 0x06001377 RID: 4983 RVA: 0x00006075 File Offset: 0x00004275
		public unsafe string PchTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_PchTarget);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_PchTarget), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x00067E70 File Offset: 0x00066070
		// (set) Token: 0x06001379 RID: 4985 RVA: 0x00006094 File Offset: 0x00004294
		public unsafe string PchPostData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_PchPostData);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_PchPostData), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x0600137A RID: 4986 RVA: 0x00067E98 File Offset: 0x00066098
		// (set) Token: 0x0600137B RID: 4987 RVA: 0x000060B3 File Offset: 0x000042B3
		public unsafe bool BIsRedirect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_BIsRedirect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HTML_StartRequest_t.NativeFieldInfoPtr_BIsRedirect)) = value;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x00067EC0 File Offset: 0x000660C0
		// (set) Token: 0x0600137D RID: 4989 RVA: 0x000060CE File Offset: 0x000042CE
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HTML_StartRequest_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTML_StartRequest_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400198B RID: 6539
		private static readonly IntPtr NativeFieldInfoPtr_UnBrowserHandle;

		// Token: 0x0400198C RID: 6540
		private static readonly IntPtr NativeFieldInfoPtr_PchURL;

		// Token: 0x0400198D RID: 6541
		private static readonly IntPtr NativeFieldInfoPtr_PchTarget;

		// Token: 0x0400198E RID: 6542
		private static readonly IntPtr NativeFieldInfoPtr_PchPostData;

		// Token: 0x0400198F RID: 6543
		private static readonly IntPtr NativeFieldInfoPtr_BIsRedirect;

		// Token: 0x04001990 RID: 6544
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001991 RID: 6545
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001992 RID: 6546
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
