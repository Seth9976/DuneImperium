using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000074 RID: 116
	public sealed class CachedAssetBundle : ValueType
	{
		// Token: 0x06000410 RID: 1040 RVA: 0x00021874 File Offset: 0x0001FA74
		// Note: this type is marked as 'beforefieldinit'.
		static CachedAssetBundle()
		{
			Il2CppClassPointerStore<CachedAssetBundle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CachedAssetBundle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CachedAssetBundle>.NativeClassPtr);
			CachedAssetBundle.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedAssetBundle>.NativeClassPtr, "m_Name");
			CachedAssetBundle.NativeFieldInfoPtr_m_Hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedAssetBundle>.NativeClassPtr, "m_Hash");
			CachedAssetBundle.NativeMethodInfoPtr__ctor_Public_Void_String_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedAssetBundle>.NativeClassPtr, 100663694);
			CachedAssetBundle.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedAssetBundle>.NativeClassPtr, 100663695);
			CachedAssetBundle.NativeMethodInfoPtr_get_hash_Public_get_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedAssetBundle>.NativeClassPtr, 100663696);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00021908 File Offset: 0x0001FB08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 645163, RefRangeEnd = 645166, XrefRangeStart = 645162, XrefRangeEnd = 645163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CachedAssetBundle(string name, Hash128 hash)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachedAssetBundle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachedAssetBundle.NativeMethodInfoPtr__ctor_Public_Void_String_Hash128_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00021968 File Offset: 0x0001FB68
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x00003FD2 File Offset: 0x000021D2
		public unsafe string name
		{
			[CallerCount(128)]
			[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachedAssetBundle.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x000219A4 File Offset: 0x0001FBA4
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00003FDC File Offset: 0x000021DC
		public unsafe Hash128 hash
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 645166, RefRangeEnd = 645168, XrefRangeStart = 645166, XrefRangeEnd = 645166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachedAssetBundle.NativeMethodInfoPtr_get_hash_Public_get_Hash128_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Hash = value;
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00003F7D File Offset: 0x0000217D
		public CachedAssetBundle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00003F86 File Offset: 0x00002186
		public CachedAssetBundle()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachedAssetBundle>.NativeClassPtr))
		{
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x000219E8 File Offset: 0x0001FBE8
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x00003F98 File Offset: 0x00002198
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedAssetBundle.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedAssetBundle.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00021A10 File Offset: 0x0001FC10
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x00003FB7 File Offset: 0x000021B7
		public unsafe Hash128 m_Hash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedAssetBundle.NativeFieldInfoPtr_m_Hash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedAssetBundle.NativeFieldInfoPtr_m_Hash)) = value;
			}
		}

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeFieldInfoPtr_m_Hash;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Hash128_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_get_hash_Public_get_Hash128_0;
	}
}
