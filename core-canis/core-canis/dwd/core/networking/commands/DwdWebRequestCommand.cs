using System;
using dwd.core.commands;
using dwd.core.networking.downloadHandlers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Networking;

namespace dwd.core.networking.commands
{
	// Token: 0x02000129 RID: 297
	public class DwdWebRequestCommand : Command
	{
		// Token: 0x060010B8 RID: 4280 RVA: 0x00055FA0 File Offset: 0x000541A0
		// Note: this type is marked as 'beforefieldinit'.
		static DwdWebRequestCommand()
		{
			Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.networking.commands", "DwdWebRequestCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr);
			DwdWebRequestCommand.NativeFieldInfoPtr_DefaultTimeoutSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, "DefaultTimeoutSeconds");
			DwdWebRequestCommand.NativeFieldInfoPtr__UploadProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, "<UploadProgress>k__BackingField");
			DwdWebRequestCommand.NativeFieldInfoPtr__DownloadProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, "<DownloadProgress>k__BackingField");
			DwdWebRequestCommand.NativeFieldInfoPtr__AverageDownloadRate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, "<AverageDownloadRate>k__BackingField");
			DwdWebRequestCommand.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, "url");
			DwdWebRequestCommand.NativeFieldInfoPtr_requestMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, "requestMethod");
			DwdWebRequestCommand.NativeFieldInfoPtr_downloadHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, "downloadHandler");
			DwdWebRequestCommand.NativeFieldInfoPtr_uploadHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, "uploadHandler");
			DwdWebRequestCommand.NativeFieldInfoPtr_requestHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, "requestHeaders");
			DwdWebRequestCommand.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, "timeout");
			DwdWebRequestCommand.NativeFieldInfoPtr_requestInitializer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, "requestInitializer");
			DwdWebRequestCommand.NativeFieldInfoPtr_internalErrorInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, "internalErrorInfo");
			DwdWebRequestCommand.NativeFieldInfoPtr_responseData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, "responseData");
			DwdWebRequestCommand.NativeFieldInfoPtr_disableErrorLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, "disableErrorLogs");
			DwdWebRequestCommand.NativeFieldInfoPtr__logErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, "_logErrors");
			DwdWebRequestCommand.NativeMethodInfoPtr_get_UploadProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, 100665731);
			DwdWebRequestCommand.NativeMethodInfoPtr_set_UploadProgress_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, 100665732);
			DwdWebRequestCommand.NativeMethodInfoPtr_get_DownloadProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, 100665733);
			DwdWebRequestCommand.NativeMethodInfoPtr_set_DownloadProgress_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, 100665734);
			DwdWebRequestCommand.NativeMethodInfoPtr_get_AverageDownloadRate_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, 100665735);
			DwdWebRequestCommand.NativeMethodInfoPtr_set_AverageDownloadRate_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, 100665736);
			DwdWebRequestCommand.NativeMethodInfoPtr_get_Response_Public_get_WebResponseData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, 100665737);
			DwdWebRequestCommand.NativeMethodInfoPtr__ctor_Public_Void_String_String_IDictionary_2_String_String_DwdDownloadHandler_UploadHandler_Int32_Action_1_UnityWebRequest_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, 100665738);
			DwdWebRequestCommand.NativeMethodInfoPtr_DisableErrorLog_Public_DwdWebRequestCommand_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, 100665739);
			DwdWebRequestCommand.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, 100665740);
			DwdWebRequestCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, 100665741);
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x000561D8 File Offset: 0x000543D8
		// (set) Token: 0x060010BA RID: 4282 RVA: 0x00056214 File Offset: 0x00054414
		public unsafe float UploadProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand.NativeMethodInfoPtr_get_UploadProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand.NativeMethodInfoPtr_set_UploadProgress_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x00056254 File Offset: 0x00054454
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x00056290 File Offset: 0x00054490
		public unsafe float DownloadProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand.NativeMethodInfoPtr_get_DownloadProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 604705, RefRangeEnd = 604706, XrefRangeStart = 604705, XrefRangeEnd = 604706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand.NativeMethodInfoPtr_set_DownloadProgress_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x060010BD RID: 4285 RVA: 0x000562D0 File Offset: 0x000544D0
		// (set) Token: 0x060010BE RID: 4286 RVA: 0x0005630C File Offset: 0x0005450C
		public unsafe int AverageDownloadRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand.NativeMethodInfoPtr_get_AverageDownloadRate_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand.NativeMethodInfoPtr_set_AverageDownloadRate_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x0005634C File Offset: 0x0005454C
		public unsafe DwdWebRequestCommand.WebResponseData Response
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 870181, RefRangeEnd = 870239, XrefRangeStart = 870178, XrefRangeEnd = 870181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand.NativeMethodInfoPtr_get_Response_Public_get_WebResponseData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DwdWebRequestCommand.WebResponseData(intPtr);
			}
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00056384 File Offset: 0x00054584
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 870267, RefRangeEnd = 870294, XrefRangeStart = 870239, XrefRangeEnd = 870267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdWebRequestCommand(string url, string requestMethod = "GET", IDictionary<string, string> requestHeaders = null, DwdDownloadHandler downloadHandler = null, UploadHandler uploadHandler = null, int timeout = 30, Action<UnityWebRequest> requestInitializer = null, bool logErrors = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(requestMethod);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestHeaders);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(downloadHandler);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uploadHandler);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestInitializer);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logErrors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand.NativeMethodInfoPtr__ctor_Public_Void_String_String_IDictionary_2_String_String_DwdDownloadHandler_UploadHandler_Int32_Action_1_UnityWebRequest_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x00056448 File Offset: 0x00054648
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 870304, RefRangeEnd = 870306, XrefRangeStart = 870294, XrefRangeEnd = 870304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdWebRequestCommand DisableErrorLog(long httpCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref httpCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand.NativeMethodInfoPtr_DisableErrorLog_Public_DwdWebRequestCommand_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DwdWebRequestCommand>(intPtr3) : null;
			}
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00056494 File Offset: 0x00054694
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x000564CC File Offset: 0x000546CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870306, XrefRangeEnd = 870311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DwdWebRequestCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00007CA5 File Offset: 0x00005EA5
		public DwdWebRequestCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x00056518 File Offset: 0x00054718
		// (set) Token: 0x060010C6 RID: 4294 RVA: 0x00007CAE File Offset: 0x00005EAE
		public unsafe static int DefaultTimeoutSeconds
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DwdWebRequestCommand.NativeFieldInfoPtr_DefaultTimeoutSeconds, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdWebRequestCommand.NativeFieldInfoPtr_DefaultTimeoutSeconds, (void*)(&value));
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x00056534 File Offset: 0x00054734
		// (set) Token: 0x060010C8 RID: 4296 RVA: 0x00007CBC File Offset: 0x00005EBC
		public unsafe float _UploadProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr__UploadProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr__UploadProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x0005655C File Offset: 0x0005475C
		// (set) Token: 0x060010CA RID: 4298 RVA: 0x00007CD7 File Offset: 0x00005ED7
		public unsafe float _DownloadProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr__DownloadProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr__DownloadProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x00056584 File Offset: 0x00054784
		// (set) Token: 0x060010CC RID: 4300 RVA: 0x00007CF2 File Offset: 0x00005EF2
		public unsafe int _AverageDownloadRate_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr__AverageDownloadRate_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr__AverageDownloadRate_k__BackingField)) = value;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x000565AC File Offset: 0x000547AC
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x00007D0D File Offset: 0x00005F0D
		public unsafe string url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr_url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x000565D4 File Offset: 0x000547D4
		// (set) Token: 0x060010D0 RID: 4304 RVA: 0x00007D2C File Offset: 0x00005F2C
		public unsafe string requestMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr_requestMethod);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr_requestMethod), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x000565FC File Offset: 0x000547FC
		// (set) Token: 0x060010D2 RID: 4306 RVA: 0x00007D4B File Offset: 0x00005F4B
		public unsafe DwdDownloadHandler downloadHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr_downloadHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdDownloadHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr_downloadHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x0005662C File Offset: 0x0005482C
		// (set) Token: 0x060010D4 RID: 4308 RVA: 0x00007D6A File Offset: 0x00005F6A
		public unsafe UploadHandler uploadHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr_uploadHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UploadHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr_uploadHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x0005665C File Offset: 0x0005485C
		// (set) Token: 0x060010D6 RID: 4310 RVA: 0x00007D89 File Offset: 0x00005F89
		public unsafe IDictionary<string, string> requestHeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr_requestHeaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr_requestHeaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x0005668C File Offset: 0x0005488C
		// (set) Token: 0x060010D8 RID: 4312 RVA: 0x00007DA8 File Offset: 0x00005FA8
		public unsafe int timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr_timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr_timeout)) = value;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x000566B4 File Offset: 0x000548B4
		// (set) Token: 0x060010DA RID: 4314 RVA: 0x00007DC3 File Offset: 0x00005FC3
		public unsafe Action<UnityWebRequest> requestInitializer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr_requestInitializer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr_requestInitializer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060010DB RID: 4315 RVA: 0x000566E4 File Offset: 0x000548E4
		// (set) Token: 0x060010DC RID: 4316 RVA: 0x00007DE2 File Offset: 0x00005FE2
		public ErrorInfo internalErrorInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr_internalErrorInfo);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr_internalErrorInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x060010DD RID: 4317 RVA: 0x00056714 File Offset: 0x00054914
		// (set) Token: 0x060010DE RID: 4318 RVA: 0x00007E10 File Offset: 0x00006010
		public Nullable<DwdWebRequestCommand.WebResponseData> responseData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr_responseData);
				return new Nullable<DwdWebRequestCommand.WebResponseData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<DwdWebRequestCommand.WebResponseData>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr_responseData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<DwdWebRequestCommand.WebResponseData>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x00056744 File Offset: 0x00054944
		// (set) Token: 0x060010E0 RID: 4320 RVA: 0x00007E3E File Offset: 0x0000603E
		public unsafe List<long> disableErrorLogs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr_disableErrorLogs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr_disableErrorLogs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x00056774 File Offset: 0x00054974
		// (set) Token: 0x060010E2 RID: 4322 RVA: 0x00007E5D File Offset: 0x0000605D
		public unsafe bool _logErrors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr__logErrors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.NativeFieldInfoPtr__logErrors)) = value;
			}
		}

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeFieldInfoPtr_DefaultTimeoutSeconds;

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeFieldInfoPtr__UploadProgress_k__BackingField;

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeFieldInfoPtr__DownloadProgress_k__BackingField;

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeFieldInfoPtr__AverageDownloadRate_k__BackingField;

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeFieldInfoPtr_url;

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeFieldInfoPtr_requestMethod;

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeFieldInfoPtr_downloadHandler;

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeFieldInfoPtr_uploadHandler;

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeFieldInfoPtr_requestHeaders;

		// Token: 0x04000BEB RID: 3051
		private static readonly IntPtr NativeFieldInfoPtr_timeout;

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeFieldInfoPtr_requestInitializer;

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeFieldInfoPtr_internalErrorInfo;

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeFieldInfoPtr_responseData;

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeFieldInfoPtr_disableErrorLogs;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeFieldInfoPtr__logErrors;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeMethodInfoPtr_get_UploadProgress_Public_get_Single_0;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeMethodInfoPtr_set_UploadProgress_Private_set_Void_Single_0;

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeMethodInfoPtr_get_DownloadProgress_Public_get_Single_0;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeMethodInfoPtr_set_DownloadProgress_Private_set_Void_Single_0;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeMethodInfoPtr_get_AverageDownloadRate_Public_get_Int32_0;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeMethodInfoPtr_set_AverageDownloadRate_Private_set_Void_Int32_0;

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeMethodInfoPtr_get_Response_Public_get_WebResponseData_0;

		// Token: 0x04000BF8 RID: 3064
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_IDictionary_2_String_String_DwdDownloadHandler_UploadHandler_Int32_Action_1_UnityWebRequest_Boolean_0;

		// Token: 0x04000BF9 RID: 3065
		private static readonly IntPtr NativeMethodInfoPtr_DisableErrorLog_Public_DwdWebRequestCommand_Int64_0;

		// Token: 0x04000BFA RID: 3066
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x020002CB RID: 715
		public enum ErrorCodes
		{
			// Token: 0x0400171F RID: 5919
			NetworkError = 900952
		}

		// Token: 0x020002CC RID: 716
		public sealed class WebResponseData : ValueType
		{
			// Token: 0x06002148 RID: 8520 RVA: 0x00095450 File Offset: 0x00093650
			// Note: this type is marked as 'beforefieldinit'.
			static WebResponseData()
			{
				Il2CppClassPointerStore<DwdWebRequestCommand.WebResponseData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, "WebResponseData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdWebRequestCommand.WebResponseData>.NativeClassPtr);
				DwdWebRequestCommand.WebResponseData.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand.WebResponseData>.NativeClassPtr, "Data");
				DwdWebRequestCommand.WebResponseData.NativeFieldInfoPtr_Code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand.WebResponseData>.NativeClassPtr, "Code");
				DwdWebRequestCommand.WebResponseData.NativeFieldInfoPtr_Headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand.WebResponseData>.NativeClassPtr, "Headers");
				DwdWebRequestCommand.WebResponseData.NativeFieldInfoPtr_ErrorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand.WebResponseData>.NativeClassPtr, "ErrorMessage");
				DwdWebRequestCommand.WebResponseData.NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand.WebResponseData>.NativeClassPtr, 100665742);
				DwdWebRequestCommand.WebResponseData.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand.WebResponseData>.NativeClassPtr, 100665743);
				DwdWebRequestCommand.WebResponseData.NativeMethodInfoPtr_get_HasHttpError_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand.WebResponseData>.NativeClassPtr, 100665744);
				DwdWebRequestCommand.WebResponseData.NativeMethodInfoPtr_get_HasNetworkError_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand.WebResponseData>.NativeClassPtr, 100665745);
				DwdWebRequestCommand.WebResponseData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_IDictionary_2_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand.WebResponseData>.NativeClassPtr, 100665746);
				DwdWebRequestCommand.WebResponseData.NativeMethodInfoPtr__ctor_Public_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand.WebResponseData>.NativeClassPtr, 100665747);
			}

			// Token: 0x17000915 RID: 2325
			// (get) Token: 0x06002149 RID: 8521 RVA: 0x00095544 File Offset: 0x00093744
			public unsafe string Text
			{
				[CallerCount(40)]
				[CachedScanResults(RefRangeStart = 869956, RefRangeEnd = 869996, XrefRangeStart = 869954, XrefRangeEnd = 869956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand.WebResponseData.NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000916 RID: 2326
			// (get) Token: 0x0600214A RID: 8522 RVA: 0x00095580 File Offset: 0x00093780
			public unsafe bool Success
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 869996, RefRangeEnd = 870000, XrefRangeStart = 869996, XrefRangeEnd = 869996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand.WebResponseData.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000917 RID: 2327
			// (get) Token: 0x0600214B RID: 8523 RVA: 0x000955C4 File Offset: 0x000937C4
			public unsafe bool HasHttpError
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 870000, RefRangeEnd = 870003, XrefRangeStart = 870000, XrefRangeEnd = 870000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand.WebResponseData.NativeMethodInfoPtr_get_HasHttpError_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000918 RID: 2328
			// (get) Token: 0x0600214C RID: 8524 RVA: 0x00095608 File Offset: 0x00093808
			public unsafe bool HasNetworkError
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 318072, RefRangeEnd = 318096, XrefRangeStart = 318072, XrefRangeEnd = 318096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand.WebResponseData.NativeMethodInfoPtr_get_HasNetworkError_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600214D RID: 8525 RVA: 0x0009564C File Offset: 0x0009384C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 870006, RefRangeEnd = 870007, XrefRangeStart = 870003, XrefRangeEnd = 870006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WebResponseData(Il2CppStructArray<byte> data, int code, IDictionary<string, string> headers, string errorMessage)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdWebRequestCommand.WebResponseData>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref code;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(errorMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand.WebResponseData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_IDictionary_2_String_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600214E RID: 8526 RVA: 0x000956D0 File Offset: 0x000938D0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 870021, RefRangeEnd = 870022, XrefRangeStart = 870007, XrefRangeEnd = 870021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WebResponseData(UnityWebRequest finishedRequest)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdWebRequestCommand.WebResponseData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(finishedRequest);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand.WebResponseData.NativeMethodInfoPtr__ctor_Public_Void_UnityWebRequest_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600214F RID: 8527 RVA: 0x0000E3D8 File Offset: 0x0000C5D8
			public WebResponseData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002150 RID: 8528 RVA: 0x0000E3E1 File Offset: 0x0000C5E1
			public WebResponseData()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdWebRequestCommand.WebResponseData>.NativeClassPtr))
			{
			}

			// Token: 0x17000911 RID: 2321
			// (get) Token: 0x06002151 RID: 8529 RVA: 0x00095720 File Offset: 0x00093920
			// (set) Token: 0x06002152 RID: 8530 RVA: 0x0000E3F3 File Offset: 0x0000C5F3
			public unsafe Il2CppStructArray<byte> Data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.WebResponseData.NativeFieldInfoPtr_Data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.WebResponseData.NativeFieldInfoPtr_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000912 RID: 2322
			// (get) Token: 0x06002153 RID: 8531 RVA: 0x00095750 File Offset: 0x00093950
			// (set) Token: 0x06002154 RID: 8532 RVA: 0x0000E412 File Offset: 0x0000C612
			public unsafe int Code
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.WebResponseData.NativeFieldInfoPtr_Code);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.WebResponseData.NativeFieldInfoPtr_Code)) = value;
				}
			}

			// Token: 0x17000913 RID: 2323
			// (get) Token: 0x06002155 RID: 8533 RVA: 0x00095778 File Offset: 0x00093978
			// (set) Token: 0x06002156 RID: 8534 RVA: 0x0000E42D File Offset: 0x0000C62D
			public unsafe IDictionary<string, string> Headers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.WebResponseData.NativeFieldInfoPtr_Headers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.WebResponseData.NativeFieldInfoPtr_Headers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000914 RID: 2324
			// (get) Token: 0x06002157 RID: 8535 RVA: 0x000957A8 File Offset: 0x000939A8
			// (set) Token: 0x06002158 RID: 8536 RVA: 0x0000E44C File Offset: 0x0000C64C
			public unsafe string ErrorMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.WebResponseData.NativeFieldInfoPtr_ErrorMessage);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand.WebResponseData.NativeFieldInfoPtr_ErrorMessage), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001720 RID: 5920
			private static readonly IntPtr NativeFieldInfoPtr_Data;

			// Token: 0x04001721 RID: 5921
			private static readonly IntPtr NativeFieldInfoPtr_Code;

			// Token: 0x04001722 RID: 5922
			private static readonly IntPtr NativeFieldInfoPtr_Headers;

			// Token: 0x04001723 RID: 5923
			private static readonly IntPtr NativeFieldInfoPtr_ErrorMessage;

			// Token: 0x04001724 RID: 5924
			private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;

			// Token: 0x04001725 RID: 5925
			private static readonly IntPtr NativeMethodInfoPtr_get_Success_Public_get_Boolean_0;

			// Token: 0x04001726 RID: 5926
			private static readonly IntPtr NativeMethodInfoPtr_get_HasHttpError_Public_get_Boolean_0;

			// Token: 0x04001727 RID: 5927
			private static readonly IntPtr NativeMethodInfoPtr_get_HasNetworkError_Public_get_Boolean_0;

			// Token: 0x04001728 RID: 5928
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_IDictionary_2_String_String_String_0;

			// Token: 0x04001729 RID: 5929
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UnityWebRequest_0;
		}

		// Token: 0x020002CD RID: 717
		[ObfuscatedName("dwd.core.networking.commands.DwdWebRequestCommand+<execute>d__31")]
		public sealed class _execute_d__31 : Object
		{
			// Token: 0x06002159 RID: 8537 RVA: 0x000957D0 File Offset: 0x000939D0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__31()
			{
				Il2CppClassPointerStore<DwdWebRequestCommand._execute_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DwdWebRequestCommand>.NativeClassPtr, "<execute>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdWebRequestCommand._execute_d__31>.NativeClassPtr);
				DwdWebRequestCommand._execute_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand._execute_d__31>.NativeClassPtr, "<>1__state");
				DwdWebRequestCommand._execute_d__31.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand._execute_d__31>.NativeClassPtr, "<>2__current");
				DwdWebRequestCommand._execute_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand._execute_d__31>.NativeClassPtr, "<>4__this");
				DwdWebRequestCommand._execute_d__31.NativeFieldInfoPtr__request_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdWebRequestCommand._execute_d__31>.NativeClassPtr, "<request>5__2");
				DwdWebRequestCommand._execute_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand._execute_d__31>.NativeClassPtr, 100665748);
				DwdWebRequestCommand._execute_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand._execute_d__31>.NativeClassPtr, 100665749);
				DwdWebRequestCommand._execute_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand._execute_d__31>.NativeClassPtr, 100665750);
				DwdWebRequestCommand._execute_d__31.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand._execute_d__31>.NativeClassPtr, 100665751);
				DwdWebRequestCommand._execute_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand._execute_d__31>.NativeClassPtr, 100665752);
				DwdWebRequestCommand._execute_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand._execute_d__31>.NativeClassPtr, 100665753);
				DwdWebRequestCommand._execute_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdWebRequestCommand._execute_d__31>.NativeClassPtr, 100665754);
			}

			// Token: 0x0600215A RID: 8538 RVA: 0x000958D8 File Offset: 0x00093AD8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__31(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdWebRequestCommand._execute_d__31>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand._execute_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600215B RID: 8539 RVA: 0x00095920 File Offset: 0x00093B20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870022, XrefRangeEnd = 870027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand._execute_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600215C RID: 8540 RVA: 0x00095954 File Offset: 0x00093B54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870027, XrefRangeEnd = 870170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand._execute_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600215D RID: 8541 RVA: 0x00095990 File Offset: 0x00093B90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870170, XrefRangeEnd = 870173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand._execute_d__31.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700091D RID: 2333
			// (get) Token: 0x0600215E RID: 8542 RVA: 0x000959C4 File Offset: 0x00093BC4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand._execute_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600215F RID: 8543 RVA: 0x00095A04 File Offset: 0x00093C04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870173, XrefRangeEnd = 870178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand._execute_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700091E RID: 2334
			// (get) Token: 0x06002160 RID: 8544 RVA: 0x00095A38 File Offset: 0x00093C38
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdWebRequestCommand._execute_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002161 RID: 8545 RVA: 0x0000E46B File Offset: 0x0000C66B
			public _execute_d__31(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000919 RID: 2329
			// (get) Token: 0x06002162 RID: 8546 RVA: 0x00095A78 File Offset: 0x00093C78
			// (set) Token: 0x06002163 RID: 8547 RVA: 0x0000E474 File Offset: 0x0000C674
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand._execute_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand._execute_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700091A RID: 2330
			// (get) Token: 0x06002164 RID: 8548 RVA: 0x00095AA0 File Offset: 0x00093CA0
			// (set) Token: 0x06002165 RID: 8549 RVA: 0x0000E48F File Offset: 0x0000C68F
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand._execute_d__31.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand._execute_d__31.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700091B RID: 2331
			// (get) Token: 0x06002166 RID: 8550 RVA: 0x00095AD0 File Offset: 0x00093CD0
			// (set) Token: 0x06002167 RID: 8551 RVA: 0x0000E4AE File Offset: 0x0000C6AE
			public unsafe DwdWebRequestCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand._execute_d__31.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdWebRequestCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand._execute_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700091C RID: 2332
			// (get) Token: 0x06002168 RID: 8552 RVA: 0x00095B00 File Offset: 0x00093D00
			// (set) Token: 0x06002169 RID: 8553 RVA: 0x0000E4CD File Offset: 0x0000C6CD
			public unsafe UnityWebRequest _request_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand._execute_d__31.NativeFieldInfoPtr__request_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdWebRequestCommand._execute_d__31.NativeFieldInfoPtr__request_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400172A RID: 5930
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400172B RID: 5931
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400172C RID: 5932
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400172D RID: 5933
			private static readonly IntPtr NativeFieldInfoPtr__request_5__2;

			// Token: 0x0400172E RID: 5934
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400172F RID: 5935
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001730 RID: 5936
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001731 RID: 5937
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001732 RID: 5938
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001733 RID: 5939
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001734 RID: 5940
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
