using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x02000026 RID: 38
	public sealed class ServiceIdentifier : ValueType
	{
		// Token: 0x06000192 RID: 402 RVA: 0x00009DA4 File Offset: 0x00007FA4
		// Note: this type is marked as 'beforefieldinit'.
		static ServiceIdentifier()
		{
			Il2CppClassPointerStore<ServiceIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "ServiceIdentifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceIdentifier>.NativeClassPtr);
			ServiceIdentifier.NativeFieldInfoPtr__ServiceKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceIdentifier>.NativeClassPtr, "<ServiceKey>k__BackingField");
			ServiceIdentifier.NativeFieldInfoPtr__ServiceType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceIdentifier>.NativeClassPtr, "<ServiceType>k__BackingField");
			ServiceIdentifier.NativeMethodInfoPtr_get_ServiceKey_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceIdentifier>.NativeClassPtr, 100663566);
			ServiceIdentifier.NativeMethodInfoPtr_get_ServiceType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceIdentifier>.NativeClassPtr, 100663567);
			ServiceIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceIdentifier>.NativeClassPtr, 100663568);
			ServiceIdentifier.NativeMethodInfoPtr_FromDescriptor_Public_Static_ServiceIdentifier_ServiceDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceIdentifier>.NativeClassPtr, 100663569);
			ServiceIdentifier.NativeMethodInfoPtr_FromServiceType_Public_Static_ServiceIdentifier_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceIdentifier>.NativeClassPtr, 100663570);
			ServiceIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ServiceIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceIdentifier>.NativeClassPtr, 100663571);
			ServiceIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceIdentifier>.NativeClassPtr, 100663572);
			ServiceIdentifier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceIdentifier>.NativeClassPtr, 100663573);
			ServiceIdentifier.NativeMethodInfoPtr_get_IsConstructedGenericType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceIdentifier>.NativeClassPtr, 100663574);
			ServiceIdentifier.NativeMethodInfoPtr_GetGenericTypeDefinition_Public_ServiceIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceIdentifier>.NativeClassPtr, 100663575);
			ServiceIdentifier.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceIdentifier>.NativeClassPtr, 100663576);
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00009ED8 File Offset: 0x000080D8
		public unsafe Object ServiceKey
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceIdentifier.NativeMethodInfoPtr_get_ServiceKey_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00009F1C File Offset: 0x0000811C
		public unsafe Type ServiceType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceIdentifier.NativeMethodInfoPtr_get_ServiceType_Public_get_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00009F60 File Offset: 0x00008160
		[CallerCount(238)]
		[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342357, XrefRangeEnd = 342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceIdentifier(Object serviceKey, Type serviceType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceIdentifier>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Object_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00009FC4 File Offset: 0x000081C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204849, XrefRangeEnd = 1204851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServiceIdentifier FromDescriptor(ServiceDescriptor serviceDescriptor)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceDescriptor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceIdentifier.NativeMethodInfoPtr_FromDescriptor_Public_Static_ServiceIdentifier_ServiceDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ServiceIdentifier(intPtr);
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000A000 File Offset: 0x00008200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204851, XrefRangeEnd = 1204853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServiceIdentifier FromServiceType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceIdentifier.NativeMethodInfoPtr_FromServiceType_Public_Static_ServiceIdentifier_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ServiceIdentifier(intPtr);
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000A03C File Offset: 0x0000823C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1204860, RefRangeEnd = 1204861, XrefRangeStart = 1204853, XrefRangeEnd = 1204860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ServiceIdentifier other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ServiceIdentifier_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000A094 File Offset: 0x00008294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204861, XrefRangeEnd = 1204865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000A0E8 File Offset: 0x000082E8
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceIdentifier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0000A12C File Offset: 0x0000832C
		public unsafe bool IsConstructedGenericType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204865, XrefRangeEnd = 1204866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceIdentifier.NativeMethodInfoPtr_get_IsConstructedGenericType_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000A170 File Offset: 0x00008370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204866, XrefRangeEnd = 1204868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceIdentifier GetGenericTypeDefinition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceIdentifier.NativeMethodInfoPtr_GetGenericTypeDefinition_Public_ServiceIdentifier_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ServiceIdentifier(intPtr);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000A1AC File Offset: 0x000083AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204868, XrefRangeEnd = 1204872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceIdentifier.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000028AB File Offset: 0x00000AAB
		public ServiceIdentifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000028B4 File Offset: 0x00000AB4
		public ServiceIdentifier()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceIdentifier>.NativeClassPtr))
		{
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0000A1E8 File Offset: 0x000083E8
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x000028C6 File Offset: 0x00000AC6
		public unsafe Object _ServiceKey_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceIdentifier.NativeFieldInfoPtr__ServiceKey_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceIdentifier.NativeFieldInfoPtr__ServiceKey_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000A218 File Offset: 0x00008418
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x000028E5 File Offset: 0x00000AE5
		public unsafe Type _ServiceType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceIdentifier.NativeFieldInfoPtr__ServiceType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceIdentifier.NativeFieldInfoPtr__ServiceType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeFieldInfoPtr__ServiceKey_k__BackingField;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeFieldInfoPtr__ServiceType_k__BackingField;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_get_ServiceKey_Public_get_Object_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_get_ServiceType_Public_get_Type_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Type_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_FromDescriptor_Public_Static_ServiceIdentifier_ServiceDescriptor_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_FromServiceType_Public_Static_ServiceIdentifier_Type_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ServiceIdentifier_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConstructedGenericType_Public_get_Boolean_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericTypeDefinition_Public_ServiceIdentifier_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
