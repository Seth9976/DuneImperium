using System;
using dwd.core.networking.downloadHandlers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Networking;

namespace dwd.core.networking.commands
{
	// Token: 0x0200012B RID: 299
	public class SubmitWWWPostingJSON : HttpPostRequest
	{
		// Token: 0x060010E8 RID: 4328 RVA: 0x000569E0 File Offset: 0x00054BE0
		// Note: this type is marked as 'beforefieldinit'.
		static SubmitWWWPostingJSON()
		{
			Il2CppClassPointerStore<SubmitWWWPostingJSON>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.networking.commands", "SubmitWWWPostingJSON");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubmitWWWPostingJSON>.NativeClassPtr);
			SubmitWWWPostingJSON.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitWWWPostingJSON>.NativeClassPtr, 100665758);
			SubmitWWWPostingJSON.NativeMethodInfoPtr_get_ErrorMessage_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitWWWPostingJSON>.NativeClassPtr, 100665759);
			SubmitWWWPostingJSON.NativeMethodInfoPtr_get_ResponseContent_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitWWWPostingJSON>.NativeClassPtr, 100665760);
			SubmitWWWPostingJSON.NativeMethodInfoPtr__ctor_Public_Void_String_Object_IDictionary_2_String_String_DwdDownloadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitWWWPostingJSON>.NativeClassPtr, 100665761);
			SubmitWWWPostingJSON.NativeMethodInfoPtr_initWebRequest_Private_Static_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitWWWPostingJSON>.NativeClassPtr, 100665762);
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x00056A74 File Offset: 0x00054C74
		public unsafe bool Success
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 870358, RefRangeEnd = 870360, XrefRangeStart = 870355, XrefRangeEnd = 870358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitWWWPostingJSON.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x00056AB0 File Offset: 0x00054CB0
		public unsafe string ErrorMessage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870360, XrefRangeEnd = 870363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitWWWPostingJSON.NativeMethodInfoPtr_get_ErrorMessage_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x00056AE8 File Offset: 0x00054CE8
		public unsafe string ResponseContent
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 870368, RefRangeEnd = 870369, XrefRangeStart = 870363, XrefRangeEnd = 870368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitWWWPostingJSON.NativeMethodInfoPtr_get_ResponseContent_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x00056B20 File Offset: 0x00054D20
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 870386, RefRangeEnd = 870390, XrefRangeStart = 870369, XrefRangeEnd = 870386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubmitWWWPostingJSON(string url, Object postData, IDictionary<string, string> headers = null, DwdDownloadHandler downloadHandler = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubmitWWWPostingJSON>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(postData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(downloadHandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitWWWPostingJSON.NativeMethodInfoPtr__ctor_Public_Void_String_Object_IDictionary_2_String_String_DwdDownloadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x00056BA4 File Offset: 0x00054DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870390, XrefRangeEnd = 870395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void initWebRequest(UnityWebRequest unityWebRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unityWebRequest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubmitWWWPostingJSON.NativeMethodInfoPtr_initWebRequest_Private_Static_Void_UnityWebRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x00007E81 File Offset: 0x00006081
		public SubmitWWWPostingJSON(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeMethodInfoPtr_get_Success_Public_get_Boolean_0;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorMessage_Public_get_String_0;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseContent_Public_get_String_0;

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Object_IDictionary_2_String_String_DwdDownloadHandler_0;

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeMethodInfoPtr_initWebRequest_Private_Static_Void_UnityWebRequest_0;

		// Token: 0x020002CE RID: 718
		[ObfuscatedName("dwd.core.networking.commands.SubmitWWWPostingJSON+<>O")]
		public static class __O : Object
		{
			// Token: 0x0600216A RID: 8554 RVA: 0x0000E4EC File Offset: 0x0000C6EC
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<SubmitWWWPostingJSON.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SubmitWWWPostingJSON>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubmitWWWPostingJSON.__O>.NativeClassPtr);
				SubmitWWWPostingJSON.__O.NativeFieldInfoPtr__0___initWebRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitWWWPostingJSON.__O>.NativeClassPtr, "<0>__initWebRequest");
			}

			// Token: 0x0600216B RID: 8555 RVA: 0x0000E520 File Offset: 0x0000C720
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700091F RID: 2335
			// (get) Token: 0x0600216C RID: 8556 RVA: 0x00095B30 File Offset: 0x00093D30
			// (set) Token: 0x0600216D RID: 8557 RVA: 0x0000E529 File Offset: 0x0000C729
			public unsafe static Action<UnityWebRequest> _0___initWebRequest
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SubmitWWWPostingJSON.__O.NativeFieldInfoPtr__0___initWebRequest, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SubmitWWWPostingJSON.__O.NativeFieldInfoPtr__0___initWebRequest, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001735 RID: 5941
			private static readonly IntPtr NativeFieldInfoPtr__0___initWebRequest;
		}
	}
}
