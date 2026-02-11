using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.Exceptions
{
	// Token: 0x0200000F RID: 15
	public class UnknownResourceProviderException : ResourceManagerException
	{
		// Token: 0x0600012B RID: 299 RVA: 0x000099DC File Offset: 0x00007BDC
		// Note: this type is marked as 'beforefieldinit'.
		static UnknownResourceProviderException()
		{
			Il2CppClassPointerStore<UnknownResourceProviderException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Exceptions", "UnknownResourceProviderException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnknownResourceProviderException>.NativeClassPtr);
			UnknownResourceProviderException.NativeFieldInfoPtr__Location_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnknownResourceProviderException>.NativeClassPtr, "<Location>k__BackingField");
			UnknownResourceProviderException.NativeMethodInfoPtr_get_Location_Public_get_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownResourceProviderException>.NativeClassPtr, 100663481);
			UnknownResourceProviderException.NativeMethodInfoPtr_set_Location_Private_set_Void_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownResourceProviderException>.NativeClassPtr, 100663482);
			UnknownResourceProviderException.NativeMethodInfoPtr__ctor_Public_Void_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownResourceProviderException>.NativeClassPtr, 100663483);
			UnknownResourceProviderException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownResourceProviderException>.NativeClassPtr, 100663484);
			UnknownResourceProviderException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownResourceProviderException>.NativeClassPtr, 100663485);
			UnknownResourceProviderException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownResourceProviderException>.NativeClassPtr, 100663486);
			UnknownResourceProviderException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownResourceProviderException>.NativeClassPtr, 100663487);
			UnknownResourceProviderException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownResourceProviderException>.NativeClassPtr, 100663488);
			UnknownResourceProviderException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnknownResourceProviderException>.NativeClassPtr, 100663489);
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00009AD4 File Offset: 0x00007CD4
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00009B14 File Offset: 0x00007D14
		public unsafe IResourceLocation Location
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownResourceProviderException.NativeMethodInfoPtr_get_Location_Public_get_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownResourceProviderException.NativeMethodInfoPtr_set_Location_Private_set_Void_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00009B58 File Offset: 0x00007D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137396, XrefRangeEnd = 1137401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnknownResourceProviderException(IResourceLocation location)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnknownResourceProviderException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownResourceProviderException.NativeMethodInfoPtr__ctor_Public_Void_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00009BA4 File Offset: 0x00007DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnknownResourceProviderException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnknownResourceProviderException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownResourceProviderException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00009BE0 File Offset: 0x00007DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnknownResourceProviderException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnknownResourceProviderException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownResourceProviderException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00009C2C File Offset: 0x00007E2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1137386, RefRangeEnd = 1137387, XrefRangeStart = 1137386, XrefRangeEnd = 1137387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnknownResourceProviderException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnknownResourceProviderException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownResourceProviderException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00009C8C File Offset: 0x00007E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnknownResourceProviderException(SerializationInfo message, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnknownResourceProviderException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnknownResourceProviderException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00009CF0 File Offset: 0x00007EF0
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137401, XrefRangeEnd = 1137421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnknownResourceProviderException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00009D34 File Offset: 0x00007F34
		[CallerCount(0)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnknownResourceProviderException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002816 File Offset: 0x00000A16
		public UnknownResourceProviderException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00009D78 File Offset: 0x00007F78
		// (set) Token: 0x06000137 RID: 311 RVA: 0x0000281F File Offset: 0x00000A1F
		public unsafe IResourceLocation _Location_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnknownResourceProviderException.NativeFieldInfoPtr__Location_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnknownResourceProviderException.NativeFieldInfoPtr__Location_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeFieldInfoPtr__Location_k__BackingField;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_get_Location_Public_get_IResourceLocation_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_set_Location_Private_set_Void_IResourceLocation_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IResourceLocation_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
