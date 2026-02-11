using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Networking;

namespace dwd.core.networking.downloadHandlers
{
	// Token: 0x02000126 RID: 294
	public class DwdDownloadHandler : DownloadHandlerScript
	{
		// Token: 0x06001081 RID: 4225 RVA: 0x00055348 File Offset: 0x00053548
		// Note: this type is marked as 'beforefieldinit'.
		static DwdDownloadHandler()
		{
			Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.networking.downloadHandlers", "DwdDownloadHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr);
			DwdDownloadHandler.NativeFieldInfoPtr_averageDownloadRateSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr, "averageDownloadRateSampler");
			DwdDownloadHandler.NativeFieldInfoPtr_bytesSinceLastSample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr, "bytesSinceLastSample");
			DwdDownloadHandler.NativeFieldInfoPtr_nextAverageTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr, "nextAverageTime");
			DwdDownloadHandler.NativeFieldInfoPtr_bytesExpected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr, "bytesExpected");
			DwdDownloadHandler.NativeFieldInfoPtr_bytesRecieved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr, "bytesRecieved");
			DwdDownloadHandler.NativeFieldInfoPtr_DownloadRateSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr, "DownloadRateSamples");
			DwdDownloadHandler.NativeFieldInfoPtr_DownloadRateSampleTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr, "DownloadRateSampleTime");
			DwdDownloadHandler.NativeMethodInfoPtr_get_Status_Public_Abstract_Virtual_New_get_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr, 100665708);
			DwdDownloadHandler.NativeMethodInfoPtr_get_AverageDownloadRate_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr, 100665709);
			DwdDownloadHandler.NativeMethodInfoPtr_get_HasData_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr, 100665710);
			DwdDownloadHandler.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr, 100665711);
			DwdDownloadHandler.NativeMethodInfoPtr__ctor_Protected_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr, 100665712);
			DwdDownloadHandler.NativeMethodInfoPtr_GetProgress_Protected_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr, 100665713);
			DwdDownloadHandler.NativeMethodInfoPtr_ReceiveContentLength_Protected_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr, 100665714);
			DwdDownloadHandler.NativeMethodInfoPtr_ReceiveData_Protected_Virtual_Final_Boolean_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr, 100665715);
			DwdDownloadHandler.NativeMethodInfoPtr_receiveData_Protected_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr, 100665716);
			DwdDownloadHandler.NativeMethodInfoPtr_GetData_Protected_Virtual_Final_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr, 100665717);
			DwdDownloadHandler.NativeMethodInfoPtr_getData_Protected_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr, 100665718);
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x000554E0 File Offset: 0x000536E0
		public unsafe virtual ErrorInfo Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DwdDownloadHandler.NativeMethodInfoPtr_get_Status_Public_Abstract_Virtual_New_get_ErrorInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ErrorInfo(intPtr);
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001083 RID: 4227 RVA: 0x00055524 File Offset: 0x00053724
		public unsafe int AverageDownloadRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdDownloadHandler.NativeMethodInfoPtr_get_AverageDownloadRate_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x00055560 File Offset: 0x00053760
		public unsafe virtual bool HasData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DwdDownloadHandler.NativeMethodInfoPtr_get_HasData_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x000555A8 File Offset: 0x000537A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869841, XrefRangeEnd = 869854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdDownloadHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdDownloadHandler.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x000555E4 File Offset: 0x000537E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869854, XrefRangeEnd = 869867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdDownloadHandler(Il2CppStructArray<byte> preallocatedBuffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdDownloadHandler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(preallocatedBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdDownloadHandler.NativeMethodInfoPtr__ctor_Protected_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x00055630 File Offset: 0x00053830
		[CallerCount(0)]
		public unsafe override float GetProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DwdDownloadHandler.NativeMethodInfoPtr_GetProgress_Protected_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x00055678 File Offset: 0x00053878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869867, XrefRangeEnd = 869868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReceiveContentLength(int contentLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DwdDownloadHandler.NativeMethodInfoPtr_ReceiveContentLength_Protected_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x000556C4 File Offset: 0x000538C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869868, XrefRangeEnd = 869872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReceiveData(Il2CppStructArray<byte> newData, int dataLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdDownloadHandler.NativeMethodInfoPtr_ReceiveData_Protected_Virtual_Final_Boolean_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00055720 File Offset: 0x00053920
		[CallerCount(0)]
		public unsafe virtual bool receiveData(Il2CppStructArray<byte> newData, int dataLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DwdDownloadHandler.NativeMethodInfoPtr_receiveData_Protected_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00055788 File Offset: 0x00053988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869872, XrefRangeEnd = 869878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdDownloadHandler.NativeMethodInfoPtr_GetData_Protected_Virtual_Final_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x000557C8 File Offset: 0x000539C8
		[CallerCount(0)]
		public unsafe virtual Il2CppStructArray<byte> getData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DwdDownloadHandler.NativeMethodInfoPtr_getData_Protected_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x00007B13 File Offset: 0x00005D13
		public DwdDownloadHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x0600108E RID: 4238 RVA: 0x00055814 File Offset: 0x00053A14
		// (set) Token: 0x0600108F RID: 4239 RVA: 0x00007B1C File Offset: 0x00005D1C
		public unsafe AverageIntFromSamples averageDownloadRateSampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandler.NativeFieldInfoPtr_averageDownloadRateSampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AverageIntFromSamples>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandler.NativeFieldInfoPtr_averageDownloadRateSampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001090 RID: 4240 RVA: 0x00055844 File Offset: 0x00053A44
		// (set) Token: 0x06001091 RID: 4241 RVA: 0x00007B3B File Offset: 0x00005D3B
		public unsafe int bytesSinceLastSample
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandler.NativeFieldInfoPtr_bytesSinceLastSample);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandler.NativeFieldInfoPtr_bytesSinceLastSample)) = value;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x0005586C File Offset: 0x00053A6C
		// (set) Token: 0x06001093 RID: 4243 RVA: 0x00007B56 File Offset: 0x00005D56
		public unsafe int nextAverageTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandler.NativeFieldInfoPtr_nextAverageTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandler.NativeFieldInfoPtr_nextAverageTime)) = value;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001094 RID: 4244 RVA: 0x00055894 File Offset: 0x00053A94
		// (set) Token: 0x06001095 RID: 4245 RVA: 0x00007B71 File Offset: 0x00005D71
		public unsafe int bytesExpected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandler.NativeFieldInfoPtr_bytesExpected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandler.NativeFieldInfoPtr_bytesExpected)) = value;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x000558BC File Offset: 0x00053ABC
		// (set) Token: 0x06001097 RID: 4247 RVA: 0x00007B8C File Offset: 0x00005D8C
		public unsafe int bytesRecieved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandler.NativeFieldInfoPtr_bytesRecieved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdDownloadHandler.NativeFieldInfoPtr_bytesRecieved)) = value;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x000558E4 File Offset: 0x00053AE4
		// (set) Token: 0x06001099 RID: 4249 RVA: 0x00007BA7 File Offset: 0x00005DA7
		public unsafe static uint DownloadRateSamples
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(DwdDownloadHandler.NativeFieldInfoPtr_DownloadRateSamples, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdDownloadHandler.NativeFieldInfoPtr_DownloadRateSamples, (void*)(&value));
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x00055900 File Offset: 0x00053B00
		// (set) Token: 0x0600109B RID: 4251 RVA: 0x00007BB5 File Offset: 0x00005DB5
		public unsafe static int DownloadRateSampleTime
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DwdDownloadHandler.NativeFieldInfoPtr_DownloadRateSampleTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdDownloadHandler.NativeFieldInfoPtr_DownloadRateSampleTime, (void*)(&value));
			}
		}

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeFieldInfoPtr_averageDownloadRateSampler;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeFieldInfoPtr_bytesSinceLastSample;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeFieldInfoPtr_nextAverageTime;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeFieldInfoPtr_bytesExpected;

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeFieldInfoPtr_bytesRecieved;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeFieldInfoPtr_DownloadRateSamples;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeFieldInfoPtr_DownloadRateSampleTime;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_Abstract_Virtual_New_get_ErrorInfo_0;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeMethodInfoPtr_get_AverageDownloadRate_Public_get_Int32_0;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeMethodInfoPtr_get_HasData_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeMethodInfoPtr_GetProgress_Protected_Virtual_Single_0;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveContentLength_Protected_Virtual_Void_Int32_0;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveData_Protected_Virtual_Final_Boolean_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeMethodInfoPtr_receiveData_Protected_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Protected_Virtual_Final_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeMethodInfoPtr_getData_Protected_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0;
	}
}
