using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Http
{
	// Token: 0x0200002A RID: 42
	public class ExponentialBackOffInitializer : Object
	{
		// Token: 0x060001EB RID: 491 RVA: 0x0000B48C File Offset: 0x0000968C
		// Note: this type is marked as 'beforefieldinit'.
		static ExponentialBackOffInitializer()
		{
			Il2CppClassPointerStore<ExponentialBackOffInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Http", "ExponentialBackOffInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExponentialBackOffInitializer>.NativeClassPtr);
			ExponentialBackOffInitializer.NativeFieldInfoPtr__Policy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExponentialBackOffInitializer>.NativeClassPtr, "<Policy>k__BackingField");
			ExponentialBackOffInitializer.NativeFieldInfoPtr__CreateBackOff_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExponentialBackOffInitializer>.NativeClassPtr, "<CreateBackOff>k__BackingField");
			ExponentialBackOffInitializer.NativeMethodInfoPtr_get_Policy_Private_get_ExponentialBackOffPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExponentialBackOffInitializer>.NativeClassPtr, 100663603);
			ExponentialBackOffInitializer.NativeMethodInfoPtr_set_Policy_Private_set_Void_ExponentialBackOffPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExponentialBackOffInitializer>.NativeClassPtr, 100663604);
			ExponentialBackOffInitializer.NativeMethodInfoPtr_get_CreateBackOff_Private_get_Func_1_BackOffHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExponentialBackOffInitializer>.NativeClassPtr, 100663605);
			ExponentialBackOffInitializer.NativeMethodInfoPtr_set_CreateBackOff_Private_set_Void_Func_1_BackOffHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExponentialBackOffInitializer>.NativeClassPtr, 100663606);
			ExponentialBackOffInitializer.NativeMethodInfoPtr__ctor_Public_Void_ExponentialBackOffPolicy_Func_1_BackOffHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExponentialBackOffInitializer>.NativeClassPtr, 100663607);
			ExponentialBackOffInitializer.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_ConfigurableHttpClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExponentialBackOffInitializer>.NativeClassPtr, 100663608);
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000B55C File Offset: 0x0000975C
		// (set) Token: 0x060001ED RID: 493 RVA: 0x0000B598 File Offset: 0x00009798
		public unsafe ExponentialBackOffPolicy Policy
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExponentialBackOffInitializer.NativeMethodInfoPtr_get_Policy_Private_get_ExponentialBackOffPolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExponentialBackOffInitializer.NativeMethodInfoPtr_set_Policy_Private_set_Void_ExponentialBackOffPolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000B5D8 File Offset: 0x000097D8
		// (set) Token: 0x060001EF RID: 495 RVA: 0x0000B618 File Offset: 0x00009818
		public unsafe Func<BackOffHandler> CreateBackOff
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExponentialBackOffInitializer.NativeMethodInfoPtr_get_CreateBackOff_Private_get_Func_1_BackOffHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<BackOffHandler>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExponentialBackOffInitializer.NativeMethodInfoPtr_set_CreateBackOff_Private_set_Void_Func_1_BackOffHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000B65C File Offset: 0x0000985C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 422885, RefRangeEnd = 422893, XrefRangeStart = 422885, XrefRangeEnd = 422893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExponentialBackOffInitializer(ExponentialBackOffPolicy policy, Func<BackOffHandler> createBackOff)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExponentialBackOffInitializer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref policy;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createBackOff);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExponentialBackOffInitializer.NativeMethodInfoPtr__ctor_Public_Void_ExponentialBackOffPolicy_Func_1_BackOffHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000B6B8 File Offset: 0x000098B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212315, XrefRangeEnd = 1212317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(ConfigurableHttpClient httpClient)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(httpClient);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExponentialBackOffInitializer.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_ConfigurableHttpClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002BE3 File Offset: 0x00000DE3
		public ExponentialBackOffInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x0000B6FC File Offset: 0x000098FC
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x00002BEC File Offset: 0x00000DEC
		public unsafe ExponentialBackOffPolicy _Policy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExponentialBackOffInitializer.NativeFieldInfoPtr__Policy_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExponentialBackOffInitializer.NativeFieldInfoPtr__Policy_k__BackingField)) = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0000B724 File Offset: 0x00009924
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00002C07 File Offset: 0x00000E07
		public unsafe Func<BackOffHandler> _CreateBackOff_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExponentialBackOffInitializer.NativeFieldInfoPtr__CreateBackOff_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BackOffHandler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExponentialBackOffInitializer.NativeFieldInfoPtr__CreateBackOff_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeFieldInfoPtr__Policy_k__BackingField;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeFieldInfoPtr__CreateBackOff_k__BackingField;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_get_Policy_Private_get_ExponentialBackOffPolicy_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_set_Policy_Private_set_Void_ExponentialBackOffPolicy_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_get_CreateBackOff_Private_get_Func_1_BackOffHandler_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_set_CreateBackOff_Private_set_Void_Func_1_BackOffHandler_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ExponentialBackOffPolicy_Func_1_BackOffHandler_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_ConfigurableHttpClient_0;
	}
}
