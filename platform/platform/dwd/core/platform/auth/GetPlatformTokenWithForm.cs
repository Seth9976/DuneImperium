using System;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.platform.auth
{
	// Token: 0x02000054 RID: 84
	public class GetPlatformTokenWithForm : GetPlatformTokenBase
	{
		// Token: 0x0600035B RID: 859 RVA: 0x00010760 File Offset: 0x0000E960
		// Note: this type is marked as 'beforefieldinit'.
		static GetPlatformTokenWithForm()
		{
			Il2CppClassPointerStore<GetPlatformTokenWithForm>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.auth", "GetPlatformTokenWithForm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPlatformTokenWithForm>.NativeClassPtr);
			GetPlatformTokenWithForm.NativeFieldInfoPtr_form = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPlatformTokenWithForm>.NativeClassPtr, "form");
			GetPlatformTokenWithForm.NativeMethodInfoPtr__ctor_Public_Void_String_WWWForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformTokenWithForm>.NativeClassPtr, 100663821);
			GetPlatformTokenWithForm.NativeMethodInfoPtr__ctor_Public_Void_String_IEnumerable_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformTokenWithForm>.NativeClassPtr, 100663822);
			GetPlatformTokenWithForm.NativeMethodInfoPtr_generateHttpPostRequest_Protected_Virtual_HttpPostRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetPlatformTokenWithForm>.NativeClassPtr, 100663823);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x000107E0 File Offset: 0x0000E9E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1169958, RefRangeEnd = 1169959, XrefRangeStart = 1169958, XrefRangeEnd = 1169959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetPlatformTokenWithForm(string authServerURL, WWWForm form)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetPlatformTokenWithForm>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authServerURL);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(form);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetPlatformTokenWithForm.NativeMethodInfoPtr__ctor_Public_Void_String_WWWForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00010840 File Offset: 0x0000EA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170007, XrefRangeEnd = 1170034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetPlatformTokenWithForm(string authServerURL, IEnumerable<KeyValuePair<string, string>> formFields)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetPlatformTokenWithForm>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authServerURL);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formFields);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetPlatformTokenWithForm.NativeMethodInfoPtr__ctor_Public_Void_String_IEnumerable_1_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x000108A0 File Offset: 0x0000EAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1170034, XrefRangeEnd = 1170064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override HttpPostRequest generateHttpPostRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetPlatformTokenWithForm.NativeMethodInfoPtr_generateHttpPostRequest_Protected_Virtual_HttpPostRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpPostRequest>(intPtr3) : null;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x000038E1 File Offset: 0x00001AE1
		public GetPlatformTokenWithForm(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000360 RID: 864 RVA: 0x000108EC File Offset: 0x0000EAEC
		// (set) Token: 0x06000361 RID: 865 RVA: 0x000038EA File Offset: 0x00001AEA
		public unsafe WWWForm form
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetPlatformTokenWithForm.NativeFieldInfoPtr_form);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WWWForm>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetPlatformTokenWithForm.NativeFieldInfoPtr_form), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeFieldInfoPtr_form;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_WWWForm_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IEnumerable_1_KeyValuePair_2_String_String_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_generateHttpPostRequest_Protected_Virtual_HttpPostRequest_0;
	}
}
