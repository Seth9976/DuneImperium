using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000299 RID: 665
	[Serializable]
	public class ObjRef : Object
	{
		// Token: 0x06002A67 RID: 10855 RVA: 0x000E164C File Offset: 0x000DF84C
		// Note: this type is marked as 'beforefieldinit'.
		static ObjRef()
		{
			Il2CppClassPointerStore<ObjRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ObjRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjRef>.NativeClassPtr);
			ObjRef.NativeFieldInfoPtr_channel_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "channel_info");
			ObjRef.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "uri");
			ObjRef.NativeFieldInfoPtr_typeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "typeInfo");
			ObjRef.NativeFieldInfoPtr_envoyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "envoyInfo");
			ObjRef.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "flags");
			ObjRef.NativeFieldInfoPtr__serverType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "_serverType");
			ObjRef.NativeFieldInfoPtr_MarshalledObjectRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "MarshalledObjectRef");
			ObjRef.NativeFieldInfoPtr_WellKnowObjectRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "WellKnowObjectRef");
			ObjRef.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100670198);
			ObjRef.NativeMethodInfoPtr__ctor_Internal_Void_String_IChannelInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100670199);
			ObjRef.NativeMethodInfoPtr_DeserializeInTheCurrentDomain_Internal_ObjRef_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100670200);
			ObjRef.NativeMethodInfoPtr_SerializeType_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100670201);
			ObjRef.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100670202);
			ObjRef.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100670203);
			ObjRef.NativeMethodInfoPtr_get_IsReferenceToWellKnow_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100670204);
			ObjRef.NativeMethodInfoPtr_get_ChannelInfo_Public_Virtual_New_get_IChannelInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100670205);
			ObjRef.NativeMethodInfoPtr_get_EnvoyInfo_Public_Virtual_New_get_IEnvoyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100670206);
			ObjRef.NativeMethodInfoPtr_set_EnvoyInfo_Public_Virtual_New_set_Void_IEnvoyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100670207);
			ObjRef.NativeMethodInfoPtr_get_TypeInfo_Public_Virtual_New_get_IRemotingTypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100670208);
			ObjRef.NativeMethodInfoPtr_set_TypeInfo_Public_Virtual_New_set_Void_IRemotingTypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100670209);
			ObjRef.NativeMethodInfoPtr_get_URI_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100670210);
			ObjRef.NativeMethodInfoPtr_set_URI_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100670211);
			ObjRef.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100670212);
			ObjRef.NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100670213);
			ObjRef.NativeMethodInfoPtr_UpdateChannelInfo_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100670214);
			ObjRef.NativeMethodInfoPtr_get_ServerType_Internal_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100670215);
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x000E1884 File Offset: 0x000DFA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376919, XrefRangeEnd = 1376921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjRef()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjRef>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x000E18C0 File Offset: 0x000DFAC0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 558839, RefRangeEnd = 558843, XrefRangeStart = 558839, XrefRangeEnd = 558843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjRef(string uri, IChannelInfo cinfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjRef>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cinfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr__ctor_Internal_Void_String_IChannelInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x000E1920 File Offset: 0x000DFB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376921, XrefRangeEnd = 1376941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjRef DeserializeInTheCurrentDomain(int domainId, Il2CppStructArray<byte> tInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domainId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr_DeserializeInTheCurrentDomain_Internal_ObjRef_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr3) : null;
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x000E1980 File Offset: 0x000DFB80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1376949, RefRangeEnd = 1376951, XrefRangeStart = 1376941, XrefRangeEnd = 1376949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> SerializeType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr_SerializeType_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x000E19C0 File Offset: 0x000DFBC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1376967, RefRangeEnd = 1376970, XrefRangeStart = 1376951, XrefRangeEnd = 1376967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjRef(Type type, string url, Object remoteChannelData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjRef>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteChannelData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x000E1A30 File Offset: 0x000DFC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376970, XrefRangeEnd = 1377054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjRef(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjRef>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06002A6E RID: 10862 RVA: 0x000E1A94 File Offset: 0x000DFC94
		public unsafe bool IsReferenceToWellKnow
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1377058, RefRangeEnd = 1377059, XrefRangeStart = 1377054, XrefRangeEnd = 1377058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr_get_IsReferenceToWellKnow_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06002A6F RID: 10863 RVA: 0x000E1AD0 File Offset: 0x000DFCD0
		public unsafe virtual IChannelInfo ChannelInfo
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_get_ChannelInfo_Public_Virtual_New_get_IChannelInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IChannelInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06002A70 RID: 10864 RVA: 0x000E1B1C File Offset: 0x000DFD1C
		// (set) Token: 0x06002A71 RID: 10865 RVA: 0x000E1B68 File Offset: 0x000DFD68
		public unsafe virtual IEnvoyInfo EnvoyInfo
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_get_EnvoyInfo_Public_Virtual_New_get_IEnvoyInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnvoyInfo>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_set_EnvoyInfo_Public_Virtual_New_set_Void_IEnvoyInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06002A72 RID: 10866 RVA: 0x000E1BB8 File Offset: 0x000DFDB8
		// (set) Token: 0x06002A73 RID: 10867 RVA: 0x000E1C04 File Offset: 0x000DFE04
		public unsafe virtual IRemotingTypeInfo TypeInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_get_TypeInfo_Public_Virtual_New_get_IRemotingTypeInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRemotingTypeInfo>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_set_TypeInfo_Public_Virtual_New_set_Void_IRemotingTypeInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06002A74 RID: 10868 RVA: 0x000E1C54 File Offset: 0x000DFE54
		// (set) Token: 0x06002A75 RID: 10869 RVA: 0x000E1C98 File Offset: 0x000DFE98
		public unsafe virtual string URI
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_get_URI_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_set_URI_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x000E1CE8 File Offset: 0x000DFEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1377059, XrefRangeEnd = 1377089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x000E1D4C File Offset: 0x000DFF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1377089, XrefRangeEnd = 1377094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetRealObject(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x000E1DAC File Offset: 0x000DFFAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1377107, RefRangeEnd = 1377109, XrefRangeStart = 1377094, XrefRangeEnd = 1377107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateChannelInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr_UpdateChannelInfo_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06002A79 RID: 10873 RVA: 0x000E1DE0 File Offset: 0x000DFFE0
		public unsafe Type ServerType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1377109, XrefRangeEnd = 1377124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr_get_ServerType_Internal_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
		public ObjRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06002A7B RID: 10875 RVA: 0x000E1E20 File Offset: 0x000E0020
		// (set) Token: 0x06002A7C RID: 10876 RVA: 0x0000E1B1 File Offset: 0x0000C3B1
		public unsafe IChannelInfo channel_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_channel_info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IChannelInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_channel_info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06002A7D RID: 10877 RVA: 0x000E1E50 File Offset: 0x000E0050
		// (set) Token: 0x06002A7E RID: 10878 RVA: 0x0000E1D0 File Offset: 0x0000C3D0
		public unsafe string uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_uri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_uri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06002A7F RID: 10879 RVA: 0x000E1E78 File Offset: 0x000E0078
		// (set) Token: 0x06002A80 RID: 10880 RVA: 0x0000E1EF File Offset: 0x0000C3EF
		public unsafe IRemotingTypeInfo typeInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_typeInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IRemotingTypeInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_typeInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06002A81 RID: 10881 RVA: 0x000E1EA8 File Offset: 0x000E00A8
		// (set) Token: 0x06002A82 RID: 10882 RVA: 0x0000E20E File Offset: 0x0000C40E
		public unsafe IEnvoyInfo envoyInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_envoyInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnvoyInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_envoyInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06002A83 RID: 10883 RVA: 0x000E1ED8 File Offset: 0x000E00D8
		// (set) Token: 0x06002A84 RID: 10884 RVA: 0x0000E22D File Offset: 0x0000C42D
		public unsafe int flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06002A85 RID: 10885 RVA: 0x000E1F00 File Offset: 0x000E0100
		// (set) Token: 0x06002A86 RID: 10886 RVA: 0x0000E248 File Offset: 0x0000C448
		public unsafe Type _serverType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr__serverType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr__serverType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06002A87 RID: 10887 RVA: 0x000E1F30 File Offset: 0x000E0130
		// (set) Token: 0x06002A88 RID: 10888 RVA: 0x0000E267 File Offset: 0x0000C467
		public unsafe static int MarshalledObjectRef
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ObjRef.NativeFieldInfoPtr_MarshalledObjectRef, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjRef.NativeFieldInfoPtr_MarshalledObjectRef, (void*)(&value));
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06002A89 RID: 10889 RVA: 0x000E1F4C File Offset: 0x000E014C
		// (set) Token: 0x06002A8A RID: 10890 RVA: 0x0000E275 File Offset: 0x0000C475
		public unsafe static int WellKnowObjectRef
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ObjRef.NativeFieldInfoPtr_WellKnowObjectRef, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjRef.NativeFieldInfoPtr_WellKnowObjectRef, (void*)(&value));
			}
		}

		// Token: 0x0400240F RID: 9231
		private static readonly IntPtr NativeFieldInfoPtr_channel_info;

		// Token: 0x04002410 RID: 9232
		private static readonly IntPtr NativeFieldInfoPtr_uri;

		// Token: 0x04002411 RID: 9233
		private static readonly IntPtr NativeFieldInfoPtr_typeInfo;

		// Token: 0x04002412 RID: 9234
		private static readonly IntPtr NativeFieldInfoPtr_envoyInfo;

		// Token: 0x04002413 RID: 9235
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04002414 RID: 9236
		private static readonly IntPtr NativeFieldInfoPtr__serverType;

		// Token: 0x04002415 RID: 9237
		private static readonly IntPtr NativeFieldInfoPtr_MarshalledObjectRef;

		// Token: 0x04002416 RID: 9238
		private static readonly IntPtr NativeFieldInfoPtr_WellKnowObjectRef;

		// Token: 0x04002417 RID: 9239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002418 RID: 9240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_IChannelInfo_0;

		// Token: 0x04002419 RID: 9241
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeInTheCurrentDomain_Internal_ObjRef_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400241A RID: 9242
		private static readonly IntPtr NativeMethodInfoPtr_SerializeType_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400241B RID: 9243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Object_0;

		// Token: 0x0400241C RID: 9244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400241D RID: 9245
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReferenceToWellKnow_Internal_get_Boolean_0;

		// Token: 0x0400241E RID: 9246
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelInfo_Public_Virtual_New_get_IChannelInfo_0;

		// Token: 0x0400241F RID: 9247
		private static readonly IntPtr NativeMethodInfoPtr_get_EnvoyInfo_Public_Virtual_New_get_IEnvoyInfo_0;

		// Token: 0x04002420 RID: 9248
		private static readonly IntPtr NativeMethodInfoPtr_set_EnvoyInfo_Public_Virtual_New_set_Void_IEnvoyInfo_0;

		// Token: 0x04002421 RID: 9249
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeInfo_Public_Virtual_New_get_IRemotingTypeInfo_0;

		// Token: 0x04002422 RID: 9250
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeInfo_Public_Virtual_New_set_Void_IRemotingTypeInfo_0;

		// Token: 0x04002423 RID: 9251
		private static readonly IntPtr NativeMethodInfoPtr_get_URI_Public_Virtual_New_get_String_0;

		// Token: 0x04002424 RID: 9252
		private static readonly IntPtr NativeMethodInfoPtr_set_URI_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04002425 RID: 9253
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002426 RID: 9254
		private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0;

		// Token: 0x04002427 RID: 9255
		private static readonly IntPtr NativeMethodInfoPtr_UpdateChannelInfo_Internal_Void_0;

		// Token: 0x04002428 RID: 9256
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerType_Internal_get_Type_0;
	}
}
