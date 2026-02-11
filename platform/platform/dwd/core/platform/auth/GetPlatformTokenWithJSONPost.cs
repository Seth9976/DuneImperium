using System;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.platform.auth
{
	// Token: 0x02000055 RID: 85
	public class GetPlatformTokenWithJSONPost : GetPlatformTokenBase
	{
		// Token: 0x06000362 RID: 866 RVA: 0x0001091C File Offset: 0x0000EB1C
		// Note: this type is marked as 'beforefieldinit'.
		static GetPlatformTokenWithJSONPost()
		{
			Il2CppClassPointerStore<GetPlatformTokenWithJSONPost>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.auth", "GetPlatformTokenWithJSONPost");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlatformTokenWithJSONPost>.NativeClassPtr);
			GetPlatformTokenWithJSONPost.NativeFieldInfoPtr_jsonData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlatformTokenWithJSONPost>.NativeClassPtr, "jsonData");
			GetPlatformTokenWithJSONPost.NativeMethodInfoPtr__ctor_Public_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformTokenWithJSONPost>.NativeClassPtr, 100663824);
			GetPlatformTokenWithJSONPost.NativeMethodInfoPtr_generateHttpPostRequest_Protected_Virtual_HttpPostRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformTokenWithJSONPost>.NativeClassPtr, 100663825);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00010988 File Offset: 0x0000EB88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1169958, RefRangeEnd = 1169959, XrefRangeStart = 1169958, XrefRangeEnd = 1169959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetPlatformTokenWithJSONPost(string authServerURL, Object jsonData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetPlatformTokenWithJSONPost>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authServerURL);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(jsonData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetPlatformTokenWithJSONPost.NativeMethodInfoPtr__ctor_Public_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000109E8 File Offset: 0x0000EBE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170064, XrefRangeEnd = 1170068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override HttpPostRequest generateHttpPostRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetPlatformTokenWithJSONPost.NativeMethodInfoPtr_generateHttpPostRequest_Protected_Virtual_HttpPostRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpPostRequest>(intPtr3) : null;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00003909 File Offset: 0x00001B09
		public GetPlatformTokenWithJSONPost(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00010A34 File Offset: 0x0000EC34
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00003912 File Offset: 0x00001B12
		public unsafe Object jsonData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetPlatformTokenWithJSONPost.NativeFieldInfoPtr_jsonData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetPlatformTokenWithJSONPost.NativeFieldInfoPtr_jsonData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeFieldInfoPtr_jsonData;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Object_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_generateHttpPostRequest_Protected_Virtual_HttpPostRequest_0;
	}
}
