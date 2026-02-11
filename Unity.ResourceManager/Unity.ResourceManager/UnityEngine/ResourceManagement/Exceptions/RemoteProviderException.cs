using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.Exceptions
{
	// Token: 0x02000012 RID: 18
	public class RemoteProviderException : ProviderException
	{
		// Token: 0x06000142 RID: 322 RVA: 0x00009FF0 File Offset: 0x000081F0
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteProviderException()
		{
			Il2CppClassPointerStore<RemoteProviderException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Exceptions", "RemoteProviderException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteProviderException>.NativeClassPtr);
			RemoteProviderException.NativeFieldInfoPtr__WebRequestResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteProviderException>.NativeClassPtr, "<WebRequestResult>k__BackingField");
			RemoteProviderException.NativeMethodInfoPtr__ctor_Public_Void_String_IResourceLocation_UnityWebRequestResult_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteProviderException>.NativeClassPtr, 100663494);
			RemoteProviderException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteProviderException>.NativeClassPtr, 100663495);
			RemoteProviderException.NativeMethodInfoPtr_get_WebRequestResult_Public_get_UnityWebRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteProviderException>.NativeClassPtr, 100663496);
			RemoteProviderException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteProviderException>.NativeClassPtr, 100663497);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000A084 File Offset: 0x00008284
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1137451, RefRangeEnd = 1137459, XrefRangeStart = 1137445, XrefRangeEnd = 1137451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoteProviderException(string message, IResourceLocation location = null, UnityWebRequestResult uwrResult = null, Exception innerException = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteProviderException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(location);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uwrResult);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteProviderException.NativeMethodInfoPtr__ctor_Public_Void_String_IResourceLocation_UnityWebRequestResult_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0000A108 File Offset: 0x00008308
		public unsafe override string Message
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1017349, RefRangeEnd = 1017351, XrefRangeStart = 1017349, XrefRangeEnd = 1017351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RemoteProviderException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000A14C File Offset: 0x0000834C
		public unsafe UnityWebRequestResult WebRequestResult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteProviderException.NativeMethodInfoPtr_get_WebRequestResult_Public_get_UnityWebRequestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityWebRequestResult>(intPtr3) : null;
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000A18C File Offset: 0x0000838C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137459, XrefRangeEnd = 1137466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RemoteProviderException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000286F File Offset: 0x00000A6F
		public RemoteProviderException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000A1D0 File Offset: 0x000083D0
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00002878 File Offset: 0x00000A78
		public unsafe UnityWebRequestResult _WebRequestResult_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteProviderException.NativeFieldInfoPtr__WebRequestResult_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequestResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteProviderException.NativeFieldInfoPtr__WebRequestResult_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeFieldInfoPtr__WebRequestResult_k__BackingField;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IResourceLocation_UnityWebRequestResult_Exception_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_get_WebRequestResult_Public_get_UnityWebRequestResult_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
