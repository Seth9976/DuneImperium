using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Http
{
	// Token: 0x0200002F RID: 47
	public class CreateHttpClientArgs : Object
	{
		// Token: 0x06000213 RID: 531 RVA: 0x0000BBFC File Offset: 0x00009DFC
		// Note: this type is marked as 'beforefieldinit'.
		static CreateHttpClientArgs()
		{
			Il2CppClassPointerStore<CreateHttpClientArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Http", "CreateHttpClientArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateHttpClientArgs>.NativeClassPtr);
			CreateHttpClientArgs.NativeFieldInfoPtr__GZipEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateHttpClientArgs>.NativeClassPtr, "<GZipEnabled>k__BackingField");
			CreateHttpClientArgs.NativeFieldInfoPtr__ApplicationName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateHttpClientArgs>.NativeClassPtr, "<ApplicationName>k__BackingField");
			CreateHttpClientArgs.NativeFieldInfoPtr__Initializers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateHttpClientArgs>.NativeClassPtr, "<Initializers>k__BackingField");
			CreateHttpClientArgs.NativeFieldInfoPtr__GoogleApiClientHeader_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateHttpClientArgs>.NativeClassPtr, "<GoogleApiClientHeader>k__BackingField");
			CreateHttpClientArgs.NativeMethodInfoPtr_get_GZipEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHttpClientArgs>.NativeClassPtr, 100663621);
			CreateHttpClientArgs.NativeMethodInfoPtr_set_GZipEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHttpClientArgs>.NativeClassPtr, 100663622);
			CreateHttpClientArgs.NativeMethodInfoPtr_get_ApplicationName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHttpClientArgs>.NativeClassPtr, 100663623);
			CreateHttpClientArgs.NativeMethodInfoPtr_set_ApplicationName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHttpClientArgs>.NativeClassPtr, 100663624);
			CreateHttpClientArgs.NativeMethodInfoPtr_get_Initializers_Public_get_IList_1_IConfigurableHttpClientInitializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHttpClientArgs>.NativeClassPtr, 100663625);
			CreateHttpClientArgs.NativeMethodInfoPtr_set_Initializers_Private_set_Void_IList_1_IConfigurableHttpClientInitializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHttpClientArgs>.NativeClassPtr, 100663626);
			CreateHttpClientArgs.NativeMethodInfoPtr_get_GoogleApiClientHeader_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHttpClientArgs>.NativeClassPtr, 100663627);
			CreateHttpClientArgs.NativeMethodInfoPtr_set_GoogleApiClientHeader_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHttpClientArgs>.NativeClassPtr, 100663628);
			CreateHttpClientArgs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHttpClientArgs>.NativeClassPtr, 100663629);
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0000BD30 File Offset: 0x00009F30
		// (set) Token: 0x06000215 RID: 533 RVA: 0x0000BD6C File Offset: 0x00009F6C
		public unsafe bool GZipEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHttpClientArgs.NativeMethodInfoPtr_get_GZipEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHttpClientArgs.NativeMethodInfoPtr_set_GZipEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0000BDAC File Offset: 0x00009FAC
		// (set) Token: 0x06000217 RID: 535 RVA: 0x0000BDE4 File Offset: 0x00009FE4
		public unsafe string ApplicationName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHttpClientArgs.NativeMethodInfoPtr_get_ApplicationName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHttpClientArgs.NativeMethodInfoPtr_set_ApplicationName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0000BE28 File Offset: 0x0000A028
		// (set) Token: 0x06000219 RID: 537 RVA: 0x0000BE68 File Offset: 0x0000A068
		public unsafe IList<IConfigurableHttpClientInitializer> Initializers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHttpClientArgs.NativeMethodInfoPtr_get_Initializers_Public_get_IList_1_IConfigurableHttpClientInitializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<IConfigurableHttpClientInitializer>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHttpClientArgs.NativeMethodInfoPtr_set_Initializers_Private_set_Void_IList_1_IConfigurableHttpClientInitializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0000BEAC File Offset: 0x0000A0AC
		// (set) Token: 0x0600021B RID: 539 RVA: 0x0000BEE4 File Offset: 0x0000A0E4
		public unsafe string GoogleApiClientHeader
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHttpClientArgs.NativeMethodInfoPtr_get_GoogleApiClientHeader_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHttpClientArgs.NativeMethodInfoPtr_set_GoogleApiClientHeader_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000BF28 File Offset: 0x0000A128
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1212426, RefRangeEnd = 1212430, XrefRangeStart = 1212418, XrefRangeEnd = 1212426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateHttpClientArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateHttpClientArgs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHttpClientArgs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002CE5 File Offset: 0x00000EE5
		public CreateHttpClientArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0000BF64 File Offset: 0x0000A164
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00002CEE File Offset: 0x00000EEE
		public unsafe bool _GZipEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHttpClientArgs.NativeFieldInfoPtr__GZipEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHttpClientArgs.NativeFieldInfoPtr__GZipEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000220 RID: 544 RVA: 0x0000BF8C File Offset: 0x0000A18C
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00002D09 File Offset: 0x00000F09
		public unsafe string _ApplicationName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHttpClientArgs.NativeFieldInfoPtr__ApplicationName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHttpClientArgs.NativeFieldInfoPtr__ApplicationName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0000BFB4 File Offset: 0x0000A1B4
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00002D28 File Offset: 0x00000F28
		public unsafe IList<IConfigurableHttpClientInitializer> _Initializers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHttpClientArgs.NativeFieldInfoPtr__Initializers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<IConfigurableHttpClientInitializer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHttpClientArgs.NativeFieldInfoPtr__Initializers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0000BFE4 File Offset: 0x0000A1E4
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00002D47 File Offset: 0x00000F47
		public unsafe string _GoogleApiClientHeader_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHttpClientArgs.NativeFieldInfoPtr__GoogleApiClientHeader_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHttpClientArgs.NativeFieldInfoPtr__GoogleApiClientHeader_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr__GZipEnabled_k__BackingField;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr__ApplicationName_k__BackingField;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeFieldInfoPtr__Initializers_k__BackingField;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr__GoogleApiClientHeader_k__BackingField;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_get_GZipEnabled_Public_get_Boolean_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_set_GZipEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_get_ApplicationName_Public_get_String_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_set_ApplicationName_Public_set_Void_String_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_get_Initializers_Public_get_IList_1_IConfigurableHttpClientInitializer_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_set_Initializers_Private_set_Void_IList_1_IConfigurableHttpClientInitializer_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_get_GoogleApiClientHeader_Public_get_String_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_set_GoogleApiClientHeader_Public_set_Void_String_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
