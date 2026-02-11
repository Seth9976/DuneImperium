using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.prefabs
{
	// Token: 0x0200010B RID: 267
	[Serializable]
	public class PrefabLookupEntry : Object
	{
		// Token: 0x06000F4C RID: 3916 RVA: 0x00050888 File Offset: 0x0004EA88
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabLookupEntry()
		{
			Il2CppClassPointerStore<PrefabLookupEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs", "PrefabLookupEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabLookupEntry>.NativeClassPtr);
			PrefabLookupEntry.NativeFieldInfoPtr_ResourcePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLookupEntry>.NativeClassPtr, "ResourcePath");
			PrefabLookupEntry.NativeMethodInfoPtr__ctor_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookupEntry>.NativeClassPtr, 100665532);
			PrefabLookupEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookupEntry>.NativeClassPtr, 100665533);
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x000508F4 File Offset: 0x0004EAF4
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabLookupEntry(string resourcePath)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabLookupEntry>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(resourcePath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLookupEntry.NativeMethodInfoPtr__ctor_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00050940 File Offset: 0x0004EB40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 868207, RefRangeEnd = 868208, XrefRangeStart = 868202, XrefRangeEnd = 868207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabLookupEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00007292 File Offset: 0x00005492
		public PrefabLookupEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x00050984 File Offset: 0x0004EB84
		// (set) Token: 0x06000F51 RID: 3921 RVA: 0x0000729B File Offset: 0x0000549B
		public unsafe string ResourcePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLookupEntry.NativeFieldInfoPtr_ResourcePath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLookupEntry.NativeFieldInfoPtr_ResourcePath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeFieldInfoPtr_ResourcePath;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_0;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
