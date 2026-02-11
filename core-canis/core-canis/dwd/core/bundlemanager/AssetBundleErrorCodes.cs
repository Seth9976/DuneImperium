using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Networking;

namespace dwd.core.bundlemanager
{
	// Token: 0x020001F0 RID: 496
	public static class AssetBundleErrorCodes : Object
	{
		// Token: 0x06001ADB RID: 6875 RVA: 0x0007EC5C File Offset: 0x0007CE5C
		// Note: this type is marked as 'beforefieldinit'.
		static AssetBundleErrorCodes()
		{
			Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.bundlemanager", "AssetBundleErrorCodes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr);
			AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_DOWNLOAD_NO_RESPONSE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, "BUNDLE_DOWNLOAD_NO_RESPONSE");
			AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_DOWNLOAD_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, "BUNDLE_DOWNLOAD_TIMEOUT");
			AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_DOWNLOAD_UNKNOWN_ERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, "BUNDLE_DOWNLOAD_UNKNOWN_ERROR");
			AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_DOWNLOAD_ERROR_PREFIX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, "BUNDLE_DOWNLOAD_ERROR_PREFIX");
			AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_DOWNLOAD_DISK_FULL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, "BUNDLE_DOWNLOAD_DISK_FULL");
			AssetBundleErrorCodes.NativeFieldInfoPtr_MANIFEST_DOWNLOAD_NO_RESPONSE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, "MANIFEST_DOWNLOAD_NO_RESPONSE");
			AssetBundleErrorCodes.NativeFieldInfoPtr_MANIFEST_DOWNLOAD_EXCEPTION_UNSPECIFIC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, "MANIFEST_DOWNLOAD_EXCEPTION_UNSPECIFIC");
			AssetBundleErrorCodes.NativeFieldInfoPtr_MANIFEST_DOWNLOAD_ERROR_PREFIX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, "MANIFEST_DOWNLOAD_ERROR_PREFIX");
			AssetBundleErrorCodes.NativeFieldInfoPtr_MANIFEST_VERSION_DOWNLOAD_NO_RESPONSE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, "MANIFEST_VERSION_DOWNLOAD_NO_RESPONSE");
			AssetBundleErrorCodes.NativeFieldInfoPtr_ASSET_REQUEST_BUNDLE_NULL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, "ASSET_REQUEST_BUNDLE_NULL");
			AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_REQUEST_NULL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, "BUNDLE_REQUEST_NULL");
			AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_REQUEST_BUNDLE_NAME_NOT_IN_MANIFEST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, "BUNDLE_REQUEST_BUNDLE_NAME_NOT_IN_MANIFEST");
			AssetBundleErrorCodes.NativeFieldInfoPtr_MANIFEST_VERSION_DOWNLOAD_ERROR_PREFIX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, "MANIFEST_VERSION_DOWNLOAD_ERROR_PREFIX");
			AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_ASSET_MISSING_ERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, "BUNDLE_ASSET_MISSING_ERROR");
			AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_ASSET_TYPE_ERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, "BUNDLE_ASSET_TYPE_ERROR");
			AssetBundleErrorCodes.NativeFieldInfoPtr_CANT_WRITE_UNSPECIFIC_EXCEPTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, "CANT_WRITE_UNSPECIFIC_EXCEPTION");
			AssetBundleErrorCodes.NativeFieldInfoPtr_CANT_WRITE_NO_PERMISSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, "CANT_WRITE_NO_PERMISSION");
			AssetBundleErrorCodes.NativeFieldInfoPtr_CANT_WRITE_FILE_PATH_INVALID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, "CANT_WRITE_FILE_PATH_INVALID");
			AssetBundleErrorCodes.NativeFieldInfoPtr_CANT_PARSE_MANIFEST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, "CANT_PARSE_MANIFEST");
			AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_CRC_MISMATCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, "BUNDLE_CRC_MISMATCH");
			AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_DOWNLOAD_DEFERRED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, "BUNDLE_DOWNLOAD_DEFERRED");
			AssetBundleErrorCodes.NativeMethodInfoPtr_Get_BUNDLE_DOWNLOAD_ERROR_Public_Static_Int32_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, 100667584);
			AssetBundleErrorCodes.NativeMethodInfoPtr_Get_MANIFEST_DOWNLOAD_ERROR_Public_Static_Int32_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, 100667585);
			AssetBundleErrorCodes.NativeMethodInfoPtr_Get_MANIFEST_DOWNLOAD_ERROR_Public_Static_Int32_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, 100667586);
			AssetBundleErrorCodes.NativeMethodInfoPtr_Get_MANIFEST_VERSION_DOWNLOAD_ERROR_PREFIX_Public_Static_Int32_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleErrorCodes>.NativeClassPtr, 100667587);
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x0007EE80 File Offset: 0x0007D080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884140, XrefRangeEnd = 884142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Get_BUNDLE_DOWNLOAD_ERROR(UnityWebRequest www)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(www);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleErrorCodes.NativeMethodInfoPtr_Get_BUNDLE_DOWNLOAD_ERROR_Public_Static_Int32_UnityWebRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x0007EEC4 File Offset: 0x0007D0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884142, XrefRangeEnd = 884144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Get_MANIFEST_DOWNLOAD_ERROR(UnityWebRequest www)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(www);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleErrorCodes.NativeMethodInfoPtr_Get_MANIFEST_DOWNLOAD_ERROR_Public_Static_Int32_UnityWebRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x0007EF08 File Offset: 0x0007D108
		[CallerCount(0)]
		public unsafe static int Get_MANIFEST_DOWNLOAD_ERROR(ErrorInfo www)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(www));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleErrorCodes.NativeMethodInfoPtr_Get_MANIFEST_DOWNLOAD_ERROR_Public_Static_Int32_ErrorInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x0007EF50 File Offset: 0x0007D150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884144, XrefRangeEnd = 884146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Get_MANIFEST_VERSION_DOWNLOAD_ERROR_PREFIX(UnityWebRequest www)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(www);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleErrorCodes.NativeMethodInfoPtr_Get_MANIFEST_VERSION_DOWNLOAD_ERROR_PREFIX_Public_Static_Int32_UnityWebRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x0000B919 File Offset: 0x00009B19
		public AssetBundleErrorCodes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x0007EF94 File Offset: 0x0007D194
		// (set) Token: 0x06001AE2 RID: 6882 RVA: 0x0000B922 File Offset: 0x00009B22
		public unsafe static int BUNDLE_DOWNLOAD_NO_RESPONSE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_DOWNLOAD_NO_RESPONSE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_DOWNLOAD_NO_RESPONSE, (void*)(&value));
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x0007EFB0 File Offset: 0x0007D1B0
		// (set) Token: 0x06001AE4 RID: 6884 RVA: 0x0000B930 File Offset: 0x00009B30
		public unsafe static int BUNDLE_DOWNLOAD_TIMEOUT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_DOWNLOAD_TIMEOUT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_DOWNLOAD_TIMEOUT, (void*)(&value));
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x0007EFCC File Offset: 0x0007D1CC
		// (set) Token: 0x06001AE6 RID: 6886 RVA: 0x0000B93E File Offset: 0x00009B3E
		public unsafe static int BUNDLE_DOWNLOAD_UNKNOWN_ERROR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_DOWNLOAD_UNKNOWN_ERROR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_DOWNLOAD_UNKNOWN_ERROR, (void*)(&value));
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x0007EFE8 File Offset: 0x0007D1E8
		// (set) Token: 0x06001AE8 RID: 6888 RVA: 0x0000B94C File Offset: 0x00009B4C
		public unsafe static int BUNDLE_DOWNLOAD_ERROR_PREFIX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_DOWNLOAD_ERROR_PREFIX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_DOWNLOAD_ERROR_PREFIX, (void*)(&value));
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001AE9 RID: 6889 RVA: 0x0007F004 File Offset: 0x0007D204
		// (set) Token: 0x06001AEA RID: 6890 RVA: 0x0000B95A File Offset: 0x00009B5A
		public unsafe static int BUNDLE_DOWNLOAD_DISK_FULL
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_DOWNLOAD_DISK_FULL, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_DOWNLOAD_DISK_FULL, (void*)(&value));
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x0007F020 File Offset: 0x0007D220
		// (set) Token: 0x06001AEC RID: 6892 RVA: 0x0000B968 File Offset: 0x00009B68
		public unsafe static int MANIFEST_DOWNLOAD_NO_RESPONSE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleErrorCodes.NativeFieldInfoPtr_MANIFEST_DOWNLOAD_NO_RESPONSE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleErrorCodes.NativeFieldInfoPtr_MANIFEST_DOWNLOAD_NO_RESPONSE, (void*)(&value));
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001AED RID: 6893 RVA: 0x0007F03C File Offset: 0x0007D23C
		// (set) Token: 0x06001AEE RID: 6894 RVA: 0x0000B976 File Offset: 0x00009B76
		public unsafe static int MANIFEST_DOWNLOAD_EXCEPTION_UNSPECIFIC
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleErrorCodes.NativeFieldInfoPtr_MANIFEST_DOWNLOAD_EXCEPTION_UNSPECIFIC, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleErrorCodes.NativeFieldInfoPtr_MANIFEST_DOWNLOAD_EXCEPTION_UNSPECIFIC, (void*)(&value));
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001AEF RID: 6895 RVA: 0x0007F058 File Offset: 0x0007D258
		// (set) Token: 0x06001AF0 RID: 6896 RVA: 0x0000B984 File Offset: 0x00009B84
		public unsafe static int MANIFEST_DOWNLOAD_ERROR_PREFIX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleErrorCodes.NativeFieldInfoPtr_MANIFEST_DOWNLOAD_ERROR_PREFIX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleErrorCodes.NativeFieldInfoPtr_MANIFEST_DOWNLOAD_ERROR_PREFIX, (void*)(&value));
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x0007F074 File Offset: 0x0007D274
		// (set) Token: 0x06001AF2 RID: 6898 RVA: 0x0000B992 File Offset: 0x00009B92
		public unsafe static int MANIFEST_VERSION_DOWNLOAD_NO_RESPONSE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleErrorCodes.NativeFieldInfoPtr_MANIFEST_VERSION_DOWNLOAD_NO_RESPONSE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleErrorCodes.NativeFieldInfoPtr_MANIFEST_VERSION_DOWNLOAD_NO_RESPONSE, (void*)(&value));
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x0007F090 File Offset: 0x0007D290
		// (set) Token: 0x06001AF4 RID: 6900 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		public unsafe static int ASSET_REQUEST_BUNDLE_NULL
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleErrorCodes.NativeFieldInfoPtr_ASSET_REQUEST_BUNDLE_NULL, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleErrorCodes.NativeFieldInfoPtr_ASSET_REQUEST_BUNDLE_NULL, (void*)(&value));
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x0007F0AC File Offset: 0x0007D2AC
		// (set) Token: 0x06001AF6 RID: 6902 RVA: 0x0000B9AE File Offset: 0x00009BAE
		public unsafe static int BUNDLE_REQUEST_NULL
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_REQUEST_NULL, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_REQUEST_NULL, (void*)(&value));
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x0007F0C8 File Offset: 0x0007D2C8
		// (set) Token: 0x06001AF8 RID: 6904 RVA: 0x0000B9BC File Offset: 0x00009BBC
		public unsafe static int BUNDLE_REQUEST_BUNDLE_NAME_NOT_IN_MANIFEST
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_REQUEST_BUNDLE_NAME_NOT_IN_MANIFEST, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_REQUEST_BUNDLE_NAME_NOT_IN_MANIFEST, (void*)(&value));
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x0007F0E4 File Offset: 0x0007D2E4
		// (set) Token: 0x06001AFA RID: 6906 RVA: 0x0000B9CA File Offset: 0x00009BCA
		public unsafe static int MANIFEST_VERSION_DOWNLOAD_ERROR_PREFIX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleErrorCodes.NativeFieldInfoPtr_MANIFEST_VERSION_DOWNLOAD_ERROR_PREFIX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleErrorCodes.NativeFieldInfoPtr_MANIFEST_VERSION_DOWNLOAD_ERROR_PREFIX, (void*)(&value));
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001AFB RID: 6907 RVA: 0x0007F100 File Offset: 0x0007D300
		// (set) Token: 0x06001AFC RID: 6908 RVA: 0x0000B9D8 File Offset: 0x00009BD8
		public unsafe static int BUNDLE_ASSET_MISSING_ERROR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_ASSET_MISSING_ERROR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_ASSET_MISSING_ERROR, (void*)(&value));
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001AFD RID: 6909 RVA: 0x0007F11C File Offset: 0x0007D31C
		// (set) Token: 0x06001AFE RID: 6910 RVA: 0x0000B9E6 File Offset: 0x00009BE6
		public unsafe static int BUNDLE_ASSET_TYPE_ERROR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_ASSET_TYPE_ERROR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_ASSET_TYPE_ERROR, (void*)(&value));
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x0007F138 File Offset: 0x0007D338
		// (set) Token: 0x06001B00 RID: 6912 RVA: 0x0000B9F4 File Offset: 0x00009BF4
		public unsafe static int CANT_WRITE_UNSPECIFIC_EXCEPTION
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleErrorCodes.NativeFieldInfoPtr_CANT_WRITE_UNSPECIFIC_EXCEPTION, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleErrorCodes.NativeFieldInfoPtr_CANT_WRITE_UNSPECIFIC_EXCEPTION, (void*)(&value));
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001B01 RID: 6913 RVA: 0x0007F154 File Offset: 0x0007D354
		// (set) Token: 0x06001B02 RID: 6914 RVA: 0x0000BA02 File Offset: 0x00009C02
		public unsafe static int CANT_WRITE_NO_PERMISSION
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleErrorCodes.NativeFieldInfoPtr_CANT_WRITE_NO_PERMISSION, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleErrorCodes.NativeFieldInfoPtr_CANT_WRITE_NO_PERMISSION, (void*)(&value));
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001B03 RID: 6915 RVA: 0x0007F170 File Offset: 0x0007D370
		// (set) Token: 0x06001B04 RID: 6916 RVA: 0x0000BA10 File Offset: 0x00009C10
		public unsafe static int CANT_WRITE_FILE_PATH_INVALID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleErrorCodes.NativeFieldInfoPtr_CANT_WRITE_FILE_PATH_INVALID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleErrorCodes.NativeFieldInfoPtr_CANT_WRITE_FILE_PATH_INVALID, (void*)(&value));
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001B05 RID: 6917 RVA: 0x0007F18C File Offset: 0x0007D38C
		// (set) Token: 0x06001B06 RID: 6918 RVA: 0x0000BA1E File Offset: 0x00009C1E
		public unsafe static int CANT_PARSE_MANIFEST
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleErrorCodes.NativeFieldInfoPtr_CANT_PARSE_MANIFEST, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleErrorCodes.NativeFieldInfoPtr_CANT_PARSE_MANIFEST, (void*)(&value));
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x0007F1A8 File Offset: 0x0007D3A8
		// (set) Token: 0x06001B08 RID: 6920 RVA: 0x0000BA2C File Offset: 0x00009C2C
		public unsafe static int BUNDLE_CRC_MISMATCH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_CRC_MISMATCH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_CRC_MISMATCH, (void*)(&value));
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x0007F1C4 File Offset: 0x0007D3C4
		// (set) Token: 0x06001B0A RID: 6922 RVA: 0x0000BA3A File Offset: 0x00009C3A
		public unsafe static int BUNDLE_DOWNLOAD_DEFERRED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_DOWNLOAD_DEFERRED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleErrorCodes.NativeFieldInfoPtr_BUNDLE_DOWNLOAD_DEFERRED, (void*)(&value));
			}
		}

		// Token: 0x040012D4 RID: 4820
		private static readonly IntPtr NativeFieldInfoPtr_BUNDLE_DOWNLOAD_NO_RESPONSE;

		// Token: 0x040012D5 RID: 4821
		private static readonly IntPtr NativeFieldInfoPtr_BUNDLE_DOWNLOAD_TIMEOUT;

		// Token: 0x040012D6 RID: 4822
		private static readonly IntPtr NativeFieldInfoPtr_BUNDLE_DOWNLOAD_UNKNOWN_ERROR;

		// Token: 0x040012D7 RID: 4823
		private static readonly IntPtr NativeFieldInfoPtr_BUNDLE_DOWNLOAD_ERROR_PREFIX;

		// Token: 0x040012D8 RID: 4824
		private static readonly IntPtr NativeFieldInfoPtr_BUNDLE_DOWNLOAD_DISK_FULL;

		// Token: 0x040012D9 RID: 4825
		private static readonly IntPtr NativeFieldInfoPtr_MANIFEST_DOWNLOAD_NO_RESPONSE;

		// Token: 0x040012DA RID: 4826
		private static readonly IntPtr NativeFieldInfoPtr_MANIFEST_DOWNLOAD_EXCEPTION_UNSPECIFIC;

		// Token: 0x040012DB RID: 4827
		private static readonly IntPtr NativeFieldInfoPtr_MANIFEST_DOWNLOAD_ERROR_PREFIX;

		// Token: 0x040012DC RID: 4828
		private static readonly IntPtr NativeFieldInfoPtr_MANIFEST_VERSION_DOWNLOAD_NO_RESPONSE;

		// Token: 0x040012DD RID: 4829
		private static readonly IntPtr NativeFieldInfoPtr_ASSET_REQUEST_BUNDLE_NULL;

		// Token: 0x040012DE RID: 4830
		private static readonly IntPtr NativeFieldInfoPtr_BUNDLE_REQUEST_NULL;

		// Token: 0x040012DF RID: 4831
		private static readonly IntPtr NativeFieldInfoPtr_BUNDLE_REQUEST_BUNDLE_NAME_NOT_IN_MANIFEST;

		// Token: 0x040012E0 RID: 4832
		private static readonly IntPtr NativeFieldInfoPtr_MANIFEST_VERSION_DOWNLOAD_ERROR_PREFIX;

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeFieldInfoPtr_BUNDLE_ASSET_MISSING_ERROR;

		// Token: 0x040012E2 RID: 4834
		private static readonly IntPtr NativeFieldInfoPtr_BUNDLE_ASSET_TYPE_ERROR;

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeFieldInfoPtr_CANT_WRITE_UNSPECIFIC_EXCEPTION;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeFieldInfoPtr_CANT_WRITE_NO_PERMISSION;

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeFieldInfoPtr_CANT_WRITE_FILE_PATH_INVALID;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeFieldInfoPtr_CANT_PARSE_MANIFEST;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeFieldInfoPtr_BUNDLE_CRC_MISMATCH;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeFieldInfoPtr_BUNDLE_DOWNLOAD_DEFERRED;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeMethodInfoPtr_Get_BUNDLE_DOWNLOAD_ERROR_Public_Static_Int32_UnityWebRequest_0;

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeMethodInfoPtr_Get_MANIFEST_DOWNLOAD_ERROR_Public_Static_Int32_UnityWebRequest_0;

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeMethodInfoPtr_Get_MANIFEST_DOWNLOAD_ERROR_Public_Static_Int32_ErrorInfo_0;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeMethodInfoPtr_Get_MANIFEST_VERSION_DOWNLOAD_ERROR_PREFIX_Public_Static_Int32_UnityWebRequest_0;
	}
}
