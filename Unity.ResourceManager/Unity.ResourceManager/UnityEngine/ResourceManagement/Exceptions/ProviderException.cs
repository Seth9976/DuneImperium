using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.Exceptions
{
	// Token: 0x02000011 RID: 17
	public class ProviderException : OperationException
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00009EA4 File Offset: 0x000080A4
		// Note: this type is marked as 'beforefieldinit'.
		static ProviderException()
		{
			Il2CppClassPointerStore<ProviderException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Exceptions", "ProviderException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProviderException>.NativeClassPtr);
			ProviderException.NativeFieldInfoPtr__Location_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderException>.NativeClassPtr, "<Location>k__BackingField");
			ProviderException.NativeMethodInfoPtr__ctor_Public_Void_String_IResourceLocation_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderException>.NativeClassPtr, 100663492);
			ProviderException.NativeMethodInfoPtr_get_Location_Public_get_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderException>.NativeClassPtr, 100663493);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00009F10 File Offset: 0x00008110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137440, XrefRangeEnd = 1137445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProviderException(string message, IResourceLocation location = null, Exception innerException = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProviderException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(location);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderException.NativeMethodInfoPtr__ctor_Public_Void_String_IResourceLocation_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00009F80 File Offset: 0x00008180
		public unsafe IResourceLocation Location
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderException.NativeMethodInfoPtr_get_Location_Public_get_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr3) : null;
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002847 File Offset: 0x00000A47
		public ProviderException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00009FC0 File Offset: 0x000081C0
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00002850 File Offset: 0x00000A50
		public unsafe IResourceLocation _Location_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderException.NativeFieldInfoPtr__Location_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderException.NativeFieldInfoPtr__Location_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr__Location_k__BackingField;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IResourceLocation_Exception_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_get_Location_Public_get_IResourceLocation_0;
	}
}
