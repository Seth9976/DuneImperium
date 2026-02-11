using System;
using Google.Apis.Http;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net.Http;

namespace Google.Apis.Upload
{
	// Token: 0x0200000B RID: 11
	public sealed class ResumableUploadOptions : Object
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x00007730 File Offset: 0x00005930
		// Note: this type is marked as 'beforefieldinit'.
		static ResumableUploadOptions()
		{
			Il2CppClassPointerStore<ResumableUploadOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Upload", "ResumableUploadOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumableUploadOptions>.NativeClassPtr);
			ResumableUploadOptions.NativeFieldInfoPtr__HttpClient_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUploadOptions>.NativeClassPtr, "<HttpClient>k__BackingField");
			ResumableUploadOptions.NativeFieldInfoPtr__ModifySessionInitiationRequest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUploadOptions>.NativeClassPtr, "<ModifySessionInitiationRequest>k__BackingField");
			ResumableUploadOptions.NativeFieldInfoPtr__Serializer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUploadOptions>.NativeClassPtr, "<Serializer>k__BackingField");
			ResumableUploadOptions.NativeFieldInfoPtr__ServiceName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumableUploadOptions>.NativeClassPtr, "<ServiceName>k__BackingField");
			ResumableUploadOptions.NativeMethodInfoPtr_get_HttpClient_Public_get_HttpClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUploadOptions>.NativeClassPtr, 100663427);
			ResumableUploadOptions.NativeMethodInfoPtr_set_HttpClient_Public_set_Void_HttpClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUploadOptions>.NativeClassPtr, 100663428);
			ResumableUploadOptions.NativeMethodInfoPtr_get_ModifySessionInitiationRequest_Public_get_Action_1_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUploadOptions>.NativeClassPtr, 100663429);
			ResumableUploadOptions.NativeMethodInfoPtr_set_ModifySessionInitiationRequest_Public_set_Void_Action_1_HttpRequestMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUploadOptions>.NativeClassPtr, 100663430);
			ResumableUploadOptions.NativeMethodInfoPtr_get_Serializer_Public_get_ISerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUploadOptions>.NativeClassPtr, 100663431);
			ResumableUploadOptions.NativeMethodInfoPtr_set_Serializer_Public_set_Void_ISerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUploadOptions>.NativeClassPtr, 100663432);
			ResumableUploadOptions.NativeMethodInfoPtr_get_ServiceName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUploadOptions>.NativeClassPtr, 100663433);
			ResumableUploadOptions.NativeMethodInfoPtr_set_ServiceName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUploadOptions>.NativeClassPtr, 100663434);
			ResumableUploadOptions.NativeMethodInfoPtr_get_ConfigurableHttpClient_Internal_get_ConfigurableHttpClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUploadOptions>.NativeClassPtr, 100663435);
			ResumableUploadOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumableUploadOptions>.NativeClassPtr, 100663436);
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00007878 File Offset: 0x00005A78
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000078B8 File Offset: 0x00005AB8
		public unsafe HttpClient HttpClient
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUploadOptions.NativeMethodInfoPtr_get_HttpClient_Public_get_HttpClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpClient>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUploadOptions.NativeMethodInfoPtr_set_HttpClient_Public_set_Void_HttpClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000078FC File Offset: 0x00005AFC
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000793C File Offset: 0x00005B3C
		public unsafe Action<HttpRequestMessage> ModifySessionInitiationRequest
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUploadOptions.NativeMethodInfoPtr_get_ModifySessionInitiationRequest_Public_get_Action_1_HttpRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<HttpRequestMessage>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUploadOptions.NativeMethodInfoPtr_set_ModifySessionInitiationRequest_Public_set_Void_Action_1_HttpRequestMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00007980 File Offset: 0x00005B80
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x000079C0 File Offset: 0x00005BC0
		public unsafe ISerializer Serializer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUploadOptions.NativeMethodInfoPtr_get_Serializer_Public_get_ISerializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISerializer>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUploadOptions.NativeMethodInfoPtr_set_Serializer_Public_set_Void_ISerializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00007A04 File Offset: 0x00005C04
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00007A3C File Offset: 0x00005C3C
		public unsafe string ServiceName
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUploadOptions.NativeMethodInfoPtr_get_ServiceName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUploadOptions.NativeMethodInfoPtr_set_ServiceName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00007A80 File Offset: 0x00005C80
		public unsafe ConfigurableHttpClient ConfigurableHttpClient
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1196806, XrefRangeEnd = 1196807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUploadOptions.NativeMethodInfoPtr_get_ConfigurableHttpClient_Internal_get_ConfigurableHttpClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurableHttpClient>(intPtr3) : null;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00007AC0 File Offset: 0x00005CC0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResumableUploadOptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumableUploadOptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumableUploadOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000242B File Offset: 0x0000062B
		public ResumableUploadOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00007AFC File Offset: 0x00005CFC
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002434 File Offset: 0x00000634
		public unsafe HttpClient _HttpClient_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUploadOptions.NativeFieldInfoPtr__HttpClient_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpClient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUploadOptions.NativeFieldInfoPtr__HttpClient_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00007B2C File Offset: 0x00005D2C
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00002453 File Offset: 0x00000653
		public unsafe Action<HttpRequestMessage> _ModifySessionInitiationRequest_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUploadOptions.NativeFieldInfoPtr__ModifySessionInitiationRequest_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<HttpRequestMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUploadOptions.NativeFieldInfoPtr__ModifySessionInitiationRequest_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00007B5C File Offset: 0x00005D5C
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00002472 File Offset: 0x00000672
		public unsafe ISerializer _Serializer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUploadOptions.NativeFieldInfoPtr__Serializer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISerializer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUploadOptions.NativeFieldInfoPtr__Serializer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00007B8C File Offset: 0x00005D8C
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00002491 File Offset: 0x00000691
		public unsafe string _ServiceName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUploadOptions.NativeFieldInfoPtr__ServiceName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumableUploadOptions.NativeFieldInfoPtr__ServiceName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr__HttpClient_k__BackingField;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr__ModifySessionInitiationRequest_k__BackingField;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr__Serializer_k__BackingField;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr__ServiceName_k__BackingField;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_get_HttpClient_Public_get_HttpClient_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_set_HttpClient_Public_set_Void_HttpClient_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_get_ModifySessionInitiationRequest_Public_get_Action_1_HttpRequestMessage_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_set_ModifySessionInitiationRequest_Public_set_Void_Action_1_HttpRequestMessage_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_get_Serializer_Public_get_ISerializer_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_set_Serializer_Public_set_Void_ISerializer_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_get_ServiceName_Public_get_String_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_set_ServiceName_Public_set_Void_String_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigurableHttpClient_Internal_get_ConfigurableHttpClient_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
