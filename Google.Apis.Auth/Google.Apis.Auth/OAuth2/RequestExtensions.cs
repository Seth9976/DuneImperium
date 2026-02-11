using System;
using Google.Apis.Requests;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x0200001B RID: 27
	public static class RequestExtensions : Object
	{
		// Token: 0x06000139 RID: 313 RVA: 0x0000287D File Offset: 0x00000A7D
		// Note: this type is marked as 'beforefieldinit'.
		static RequestExtensions()
		{
			Il2CppClassPointerStore<RequestExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "RequestExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestExtensions>.NativeClassPtr);
			RequestExtensions.NativeMethodInfoPtr_AddCredential_Public_Static_T_T_ICredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestExtensions>.NativeClassPtr, 100663607);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000B254 File Offset: 0x00009454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155215, XrefRangeEnd = 1155235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T AddCredential<T>(this T request, ICredential credential) where T : ClientServiceRequest
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = request;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref request;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credential);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RequestExtensions.MethodInfoStoreGeneric_AddCredential_Public_Static_T_T_ICredential_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000028B6 File Offset: 0x00000AB6
		public RequestExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_AddCredential_Public_Static_T_T_ICredential_0;

		// Token: 0x02000052 RID: 82
		private sealed class MethodInfoStoreGeneric_AddCredential_Public_Static_T_T_ICredential_0<T>
		{
			// Token: 0x04000326 RID: 806
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RequestExtensions.NativeMethodInfoPtr_AddCredential_Public_Static_T_T_ICredential_0, Il2CppClassPointerStore<RequestExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
