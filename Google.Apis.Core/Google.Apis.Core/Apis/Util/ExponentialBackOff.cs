using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Util
{
	// Token: 0x02000005 RID: 5
	public class ExponentialBackOff : Object
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00004970 File Offset: 0x00002B70
		// Note: this type is marked as 'beforefieldinit'.
		static ExponentialBackOff()
		{
			Il2CppClassPointerStore<ExponentialBackOff>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Util", "ExponentialBackOff");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExponentialBackOff>.NativeClassPtr);
			ExponentialBackOff.NativeFieldInfoPtr_MaxAllowedNumRetries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExponentialBackOff>.NativeClassPtr, "MaxAllowedNumRetries");
			ExponentialBackOff.NativeFieldInfoPtr_deltaBackOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExponentialBackOff>.NativeClassPtr, "deltaBackOff");
			ExponentialBackOff.NativeFieldInfoPtr_maxNumOfRetries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExponentialBackOff>.NativeClassPtr, "maxNumOfRetries");
			ExponentialBackOff.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExponentialBackOff>.NativeClassPtr, "random");
			ExponentialBackOff.NativeMethodInfoPtr_get_DeltaBackOff_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExponentialBackOff>.NativeClassPtr, 100663314);
			ExponentialBackOff.NativeMethodInfoPtr_get_MaxNumOfRetries_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExponentialBackOff>.NativeClassPtr, 100663315);
			ExponentialBackOff.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExponentialBackOff>.NativeClassPtr, 100663316);
			ExponentialBackOff.NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExponentialBackOff>.NativeClassPtr, 100663317);
			ExponentialBackOff.NativeMethodInfoPtr_GetNextBackOff_Public_Virtual_Final_New_TimeSpan_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExponentialBackOff>.NativeClassPtr, 100663318);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00004A54 File Offset: 0x00002C54
		public unsafe TimeSpan DeltaBackOff
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExponentialBackOff.NativeMethodInfoPtr_get_DeltaBackOff_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00004A90 File Offset: 0x00002C90
		public unsafe virtual int MaxNumOfRetries
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExponentialBackOff.NativeMethodInfoPtr_get_MaxNumOfRetries_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004ACC File Offset: 0x00002CCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1209895, RefRangeEnd = 1209898, XrefRangeStart = 1209876, XrefRangeEnd = 1209895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExponentialBackOff()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExponentialBackOff>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExponentialBackOff.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004B08 File Offset: 0x00002D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209898, XrefRangeEnd = 1209913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExponentialBackOff(TimeSpan deltaBackOff, int maximumNumOfRetries = 10)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExponentialBackOff>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deltaBackOff;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maximumNumOfRetries;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExponentialBackOff.NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00004B60 File Offset: 0x00002D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209913, XrefRangeEnd = 1209923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TimeSpan GetNextBackOff(int currentRetry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentRetry;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExponentialBackOff.NativeMethodInfoPtr_GetNextBackOff_Public_Virtual_Final_New_TimeSpan_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000020D6 File Offset: 0x000002D6
		public ExponentialBackOff(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00004BAC File Offset: 0x00002DAC
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000020DF File Offset: 0x000002DF
		public unsafe static int MaxAllowedNumRetries
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ExponentialBackOff.NativeFieldInfoPtr_MaxAllowedNumRetries, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExponentialBackOff.NativeFieldInfoPtr_MaxAllowedNumRetries, (void*)(&value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00004BC8 File Offset: 0x00002DC8
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000020ED File Offset: 0x000002ED
		public unsafe TimeSpan deltaBackOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExponentialBackOff.NativeFieldInfoPtr_deltaBackOff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExponentialBackOff.NativeFieldInfoPtr_deltaBackOff)) = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00004BF0 File Offset: 0x00002DF0
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00002108 File Offset: 0x00000308
		public unsafe int maxNumOfRetries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExponentialBackOff.NativeFieldInfoPtr_maxNumOfRetries);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExponentialBackOff.NativeFieldInfoPtr_maxNumOfRetries)) = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00004C18 File Offset: 0x00002E18
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002123 File Offset: 0x00000323
		public unsafe Random random
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExponentialBackOff.NativeFieldInfoPtr_random);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Random>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExponentialBackOff.NativeFieldInfoPtr_random), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_MaxAllowedNumRetries;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_deltaBackOff;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_maxNumOfRetries;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_random;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_get_DeltaBackOff_Public_get_TimeSpan_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxNumOfRetries_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TimeSpan_Int32_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_GetNextBackOff_Public_Virtual_Final_New_TimeSpan_Int32_0;
	}
}
