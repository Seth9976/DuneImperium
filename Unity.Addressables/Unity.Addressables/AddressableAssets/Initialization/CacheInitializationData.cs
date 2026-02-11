using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.AddressableAssets.Initialization
{
	// Token: 0x02000027 RID: 39
	[Serializable]
	public class CacheInitializationData : Object
	{
		// Token: 0x06000300 RID: 768 RVA: 0x00011D44 File Offset: 0x0000FF44
		// Note: this type is marked as 'beforefieldinit'.
		static CacheInitializationData()
		{
			Il2CppClassPointerStore<CacheInitializationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets.Initialization", "CacheInitializationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CacheInitializationData>.NativeClassPtr);
			CacheInitializationData.NativeFieldInfoPtr_m_CompressionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheInitializationData>.NativeClassPtr, "m_CompressionEnabled");
			CacheInitializationData.NativeFieldInfoPtr_m_CacheDirectoryOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheInitializationData>.NativeClassPtr, "m_CacheDirectoryOverride");
			CacheInitializationData.NativeFieldInfoPtr_m_ExpirationDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheInitializationData>.NativeClassPtr, "m_ExpirationDelay");
			CacheInitializationData.NativeFieldInfoPtr_m_LimitCacheSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheInitializationData>.NativeClassPtr, "m_LimitCacheSize");
			CacheInitializationData.NativeFieldInfoPtr_m_MaximumCacheSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheInitializationData>.NativeClassPtr, "m_MaximumCacheSize");
			CacheInitializationData.NativeMethodInfoPtr_get_CompressionEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitializationData>.NativeClassPtr, 100663898);
			CacheInitializationData.NativeMethodInfoPtr_set_CompressionEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitializationData>.NativeClassPtr, 100663899);
			CacheInitializationData.NativeMethodInfoPtr_get_CacheDirectoryOverride_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitializationData>.NativeClassPtr, 100663900);
			CacheInitializationData.NativeMethodInfoPtr_set_CacheDirectoryOverride_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitializationData>.NativeClassPtr, 100663901);
			CacheInitializationData.NativeMethodInfoPtr_get_ExpirationDelay_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitializationData>.NativeClassPtr, 100663902);
			CacheInitializationData.NativeMethodInfoPtr_set_ExpirationDelay_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitializationData>.NativeClassPtr, 100663903);
			CacheInitializationData.NativeMethodInfoPtr_get_LimitCacheSize_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitializationData>.NativeClassPtr, 100663904);
			CacheInitializationData.NativeMethodInfoPtr_set_LimitCacheSize_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitializationData>.NativeClassPtr, 100663905);
			CacheInitializationData.NativeMethodInfoPtr_get_MaximumCacheSize_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitializationData>.NativeClassPtr, 100663906);
			CacheInitializationData.NativeMethodInfoPtr_set_MaximumCacheSize_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitializationData>.NativeClassPtr, 100663907);
			CacheInitializationData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheInitializationData>.NativeClassPtr, 100663908);
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000301 RID: 769 RVA: 0x00011EB4 File Offset: 0x000100B4
		// (set) Token: 0x06000302 RID: 770 RVA: 0x00011EF0 File Offset: 0x000100F0
		public unsafe bool CompressionEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheInitializationData.NativeMethodInfoPtr_get_CompressionEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheInitializationData.NativeMethodInfoPtr_set_CompressionEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000303 RID: 771 RVA: 0x00011F30 File Offset: 0x00010130
		// (set) Token: 0x06000304 RID: 772 RVA: 0x00011F68 File Offset: 0x00010168
		public unsafe string CacheDirectoryOverride
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheInitializationData.NativeMethodInfoPtr_get_CacheDirectoryOverride_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheInitializationData.NativeMethodInfoPtr_set_CacheDirectoryOverride_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000305 RID: 773 RVA: 0x00011FAC File Offset: 0x000101AC
		// (set) Token: 0x06000306 RID: 774 RVA: 0x00011FE8 File Offset: 0x000101E8
		public unsafe int ExpirationDelay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheInitializationData.NativeMethodInfoPtr_get_ExpirationDelay_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheInitializationData.NativeMethodInfoPtr_set_ExpirationDelay_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00012028 File Offset: 0x00010228
		// (set) Token: 0x06000308 RID: 776 RVA: 0x00012064 File Offset: 0x00010264
		public unsafe bool LimitCacheSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheInitializationData.NativeMethodInfoPtr_get_LimitCacheSize_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheInitializationData.NativeMethodInfoPtr_set_LimitCacheSize_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000309 RID: 777 RVA: 0x000120A4 File Offset: 0x000102A4
		// (set) Token: 0x0600030A RID: 778 RVA: 0x000120E0 File Offset: 0x000102E0
		public unsafe long MaximumCacheSize
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheInitializationData.NativeMethodInfoPtr_get_MaximumCacheSize_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 312312, RefRangeEnd = 312313, XrefRangeStart = 312312, XrefRangeEnd = 312313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheInitializationData.NativeMethodInfoPtr_set_MaximumCacheSize_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00012120 File Offset: 0x00010320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164747, XrefRangeEnd = 1164752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CacheInitializationData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CacheInitializationData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheInitializationData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002FDB File Offset: 0x000011DB
		public CacheInitializationData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0001215C File Offset: 0x0001035C
		// (set) Token: 0x0600030E RID: 782 RVA: 0x00002FE4 File Offset: 0x000011E4
		public unsafe bool m_CompressionEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheInitializationData.NativeFieldInfoPtr_m_CompressionEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheInitializationData.NativeFieldInfoPtr_m_CompressionEnabled)) = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00012184 File Offset: 0x00010384
		// (set) Token: 0x06000310 RID: 784 RVA: 0x00002FFF File Offset: 0x000011FF
		public unsafe string m_CacheDirectoryOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheInitializationData.NativeFieldInfoPtr_m_CacheDirectoryOverride);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheInitializationData.NativeFieldInfoPtr_m_CacheDirectoryOverride), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000311 RID: 785 RVA: 0x000121AC File Offset: 0x000103AC
		// (set) Token: 0x06000312 RID: 786 RVA: 0x0000301E File Offset: 0x0000121E
		public unsafe int m_ExpirationDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheInitializationData.NativeFieldInfoPtr_m_ExpirationDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheInitializationData.NativeFieldInfoPtr_m_ExpirationDelay)) = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000313 RID: 787 RVA: 0x000121D4 File Offset: 0x000103D4
		// (set) Token: 0x06000314 RID: 788 RVA: 0x00003039 File Offset: 0x00001239
		public unsafe bool m_LimitCacheSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheInitializationData.NativeFieldInfoPtr_m_LimitCacheSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheInitializationData.NativeFieldInfoPtr_m_LimitCacheSize)) = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000315 RID: 789 RVA: 0x000121FC File Offset: 0x000103FC
		// (set) Token: 0x06000316 RID: 790 RVA: 0x00003054 File Offset: 0x00001254
		public unsafe long m_MaximumCacheSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheInitializationData.NativeFieldInfoPtr_m_MaximumCacheSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheInitializationData.NativeFieldInfoPtr_m_MaximumCacheSize)) = value;
			}
		}

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeFieldInfoPtr_m_CompressionEnabled;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeFieldInfoPtr_m_CacheDirectoryOverride;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeFieldInfoPtr_m_ExpirationDelay;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeFieldInfoPtr_m_LimitCacheSize;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeFieldInfoPtr_m_MaximumCacheSize;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_get_CompressionEnabled_Public_get_Boolean_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_set_CompressionEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_get_CacheDirectoryOverride_Public_get_String_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_set_CacheDirectoryOverride_Public_set_Void_String_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_get_ExpirationDelay_Public_get_Int32_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_set_ExpirationDelay_Public_set_Void_Int32_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_get_LimitCacheSize_Public_get_Boolean_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_set_LimitCacheSize_Public_set_Void_Boolean_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_get_MaximumCacheSize_Public_get_Int64_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_set_MaximumCacheSize_Public_set_Void_Int64_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
