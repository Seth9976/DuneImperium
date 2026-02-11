using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x02000043 RID: 67
	[Serializable]
	public class ProviderLoadRequestOptions : Object
	{
		// Token: 0x06000352 RID: 850 RVA: 0x00011C40 File Offset: 0x0000FE40
		// Note: this type is marked as 'beforefieldinit'.
		static ProviderLoadRequestOptions()
		{
			Il2CppClassPointerStore<ProviderLoadRequestOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "ProviderLoadRequestOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProviderLoadRequestOptions>.NativeClassPtr);
			ProviderLoadRequestOptions.NativeFieldInfoPtr_m_IgnoreFailures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderLoadRequestOptions>.NativeClassPtr, "m_IgnoreFailures");
			ProviderLoadRequestOptions.NativeFieldInfoPtr_m_WebRequestTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderLoadRequestOptions>.NativeClassPtr, "m_WebRequestTimeout");
			ProviderLoadRequestOptions.NativeMethodInfoPtr_Copy_Public_ProviderLoadRequestOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderLoadRequestOptions>.NativeClassPtr, 100663846);
			ProviderLoadRequestOptions.NativeMethodInfoPtr_get_IgnoreFailures_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderLoadRequestOptions>.NativeClassPtr, 100663847);
			ProviderLoadRequestOptions.NativeMethodInfoPtr_set_IgnoreFailures_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderLoadRequestOptions>.NativeClassPtr, 100663848);
			ProviderLoadRequestOptions.NativeMethodInfoPtr_get_WebRequestTimeout_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderLoadRequestOptions>.NativeClassPtr, 100663849);
			ProviderLoadRequestOptions.NativeMethodInfoPtr_set_WebRequestTimeout_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderLoadRequestOptions>.NativeClassPtr, 100663850);
			ProviderLoadRequestOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderLoadRequestOptions>.NativeClassPtr, 100663851);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00011D10 File Offset: 0x0000FF10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1140894, RefRangeEnd = 1140897, XrefRangeStart = 1140891, XrefRangeEnd = 1140894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProviderLoadRequestOptions Copy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderLoadRequestOptions.NativeMethodInfoPtr_Copy_Public_ProviderLoadRequestOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProviderLoadRequestOptions>(intPtr3) : null;
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00011D50 File Offset: 0x0000FF50
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00011D8C File Offset: 0x0000FF8C
		public unsafe bool IgnoreFailures
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderLoadRequestOptions.NativeMethodInfoPtr_get_IgnoreFailures_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderLoadRequestOptions.NativeMethodInfoPtr_set_IgnoreFailures_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00011DCC File Offset: 0x0000FFCC
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00011E08 File Offset: 0x00010008
		public unsafe int WebRequestTimeout
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderLoadRequestOptions.NativeMethodInfoPtr_get_WebRequestTimeout_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderLoadRequestOptions.NativeMethodInfoPtr_set_WebRequestTimeout_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00011E48 File Offset: 0x00010048
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProviderLoadRequestOptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProviderLoadRequestOptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderLoadRequestOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00003547 File Offset: 0x00001747
		public ProviderLoadRequestOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00011E84 File Offset: 0x00010084
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00003550 File Offset: 0x00001750
		public unsafe bool m_IgnoreFailures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderLoadRequestOptions.NativeFieldInfoPtr_m_IgnoreFailures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderLoadRequestOptions.NativeFieldInfoPtr_m_IgnoreFailures)) = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00011EAC File Offset: 0x000100AC
		// (set) Token: 0x0600035D RID: 861 RVA: 0x0000356B File Offset: 0x0000176B
		public unsafe int m_WebRequestTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderLoadRequestOptions.NativeFieldInfoPtr_m_WebRequestTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderLoadRequestOptions.NativeFieldInfoPtr_m_WebRequestTimeout)) = value;
			}
		}

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeFieldInfoPtr_m_IgnoreFailures;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeFieldInfoPtr_m_WebRequestTimeout;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_ProviderLoadRequestOptions_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreFailures_Public_get_Boolean_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreFailures_Public_set_Void_Boolean_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_get_WebRequestTimeout_Public_get_Int32_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_set_WebRequestTimeout_Public_set_Void_Int32_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
