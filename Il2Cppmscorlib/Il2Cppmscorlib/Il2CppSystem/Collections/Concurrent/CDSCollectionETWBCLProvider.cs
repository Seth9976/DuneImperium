using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Diagnostics.Tracing;

namespace Il2CppSystem.Collections.Concurrent
{
	// Token: 0x020004D3 RID: 1235
	public sealed class CDSCollectionETWBCLProvider : EventSource
	{
		// Token: 0x06004C26 RID: 19494 RVA: 0x0015FA64 File Offset: 0x0015DC64
		// Note: this type is marked as 'beforefieldinit'.
		static CDSCollectionETWBCLProvider()
		{
			Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Concurrent", "CDSCollectionETWBCLProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr);
			CDSCollectionETWBCLProvider.NativeFieldInfoPtr_Log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr, "Log");
			CDSCollectionETWBCLProvider.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr, 100674593);
			CDSCollectionETWBCLProvider.NativeMethodInfoPtr_ConcurrentDictionary_AcquiringAllLocks_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr, 100674594);
		}

		// Token: 0x06004C27 RID: 19495 RVA: 0x0015FAD0 File Offset: 0x0015DCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CDSCollectionETWBCLProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CDSCollectionETWBCLProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CDSCollectionETWBCLProvider.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C28 RID: 19496 RVA: 0x0015FB0C File Offset: 0x0015DD0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1417696, RefRangeEnd = 1417697, XrefRangeStart = 1417694, XrefRangeEnd = 1417696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConcurrentDictionary_AcquiringAllLocks(int numOfBuckets)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numOfBuckets;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CDSCollectionETWBCLProvider.NativeMethodInfoPtr_ConcurrentDictionary_AcquiringAllLocks_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x0001BCEA File Offset: 0x00019EEA
		public CDSCollectionETWBCLProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x06004C2A RID: 19498 RVA: 0x0015FB4C File Offset: 0x0015DD4C
		// (set) Token: 0x06004C2B RID: 19499 RVA: 0x0001BCF3 File Offset: 0x00019EF3
		public unsafe static CDSCollectionETWBCLProvider Log
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CDSCollectionETWBCLProvider.NativeFieldInfoPtr_Log, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CDSCollectionETWBCLProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CDSCollectionETWBCLProvider.NativeFieldInfoPtr_Log, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003E4C RID: 15948
		private static readonly IntPtr NativeFieldInfoPtr_Log;

		// Token: 0x04003E4D RID: 15949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04003E4E RID: 15950
		private static readonly IntPtr NativeMethodInfoPtr_ConcurrentDictionary_AcquiringAllLocks_Public_Void_Int32_0;
	}
}
