using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000105 RID: 261
	public sealed class DelegatingTypeDescriptionProvider : TypeDescriptionProvider
	{
		// Token: 0x06001059 RID: 4185 RVA: 0x00059FA4 File Offset: 0x000581A4
		// Note: this type is marked as 'beforefieldinit'.
		static DelegatingTypeDescriptionProvider()
		{
			Il2CppClassPointerStore<DelegatingTypeDescriptionProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "DelegatingTypeDescriptionProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegatingTypeDescriptionProvider>.NativeClassPtr);
			DelegatingTypeDescriptionProvider.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegatingTypeDescriptionProvider>.NativeClassPtr, "_type");
			DelegatingTypeDescriptionProvider.NativeMethodInfoPtr__ctor_Internal_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegatingTypeDescriptionProvider>.NativeClassPtr, 100665659);
			DelegatingTypeDescriptionProvider.NativeMethodInfoPtr_get_Provider_Internal_get_TypeDescriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegatingTypeDescriptionProvider>.NativeClassPtr, 100665660);
			DelegatingTypeDescriptionProvider.NativeMethodInfoPtr_CreateInstance_Public_Virtual_Object_IServiceProvider_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegatingTypeDescriptionProvider>.NativeClassPtr, 100665661);
			DelegatingTypeDescriptionProvider.NativeMethodInfoPtr_GetCache_Public_Virtual_IDictionary_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegatingTypeDescriptionProvider>.NativeClassPtr, 100665662);
			DelegatingTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedTypeDescriptor_Public_Virtual_ICustomTypeDescriptor_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegatingTypeDescriptionProvider>.NativeClassPtr, 100665663);
			DelegatingTypeDescriptionProvider.NativeMethodInfoPtr_GetExtenderProviders_FamOrAssem_Virtual_Il2CppReferenceArray_1_IExtenderProvider_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegatingTypeDescriptionProvider>.NativeClassPtr, 100665664);
			DelegatingTypeDescriptionProvider.NativeMethodInfoPtr_GetReflectionType_Public_Virtual_Type_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegatingTypeDescriptionProvider>.NativeClassPtr, 100665665);
			DelegatingTypeDescriptionProvider.NativeMethodInfoPtr_GetTypeDescriptor_Public_Virtual_ICustomTypeDescriptor_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegatingTypeDescriptionProvider>.NativeClassPtr, 100665666);
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0005A088 File Offset: 0x00058288
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 458838, RefRangeEnd = 458841, XrefRangeStart = 458836, XrefRangeEnd = 458838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelegatingTypeDescriptionProvider(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegatingTypeDescriptionProvider>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegatingTypeDescriptionProvider.NativeMethodInfoPtr__ctor_Internal_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x0600105B RID: 4187 RVA: 0x0005A0D4 File Offset: 0x000582D4
		public unsafe TypeDescriptionProvider Provider
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458841, XrefRangeEnd = 458845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegatingTypeDescriptionProvider.NativeMethodInfoPtr_get_Provider_Internal_get_TypeDescriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeDescriptionProvider>(intPtr3) : null;
			}
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x0005A114 File Offset: 0x00058314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458845, XrefRangeEnd = 458850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object CreateInstance(IServiceProvider provider, Type objectType, Il2CppReferenceArray<Type> argTypes, Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argTypes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegatingTypeDescriptionProvider.NativeMethodInfoPtr_CreateInstance_Public_Virtual_Object_IServiceProvider_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x0005A19C File Offset: 0x0005839C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458850, XrefRangeEnd = 458855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IDictionary GetCache(Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegatingTypeDescriptionProvider.NativeMethodInfoPtr_GetCache_Public_Virtual_IDictionary_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x0005A1EC File Offset: 0x000583EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458855, XrefRangeEnd = 458860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ICustomTypeDescriptor GetExtendedTypeDescriptor(Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegatingTypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedTypeDescriptor_Public_Virtual_ICustomTypeDescriptor_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICustomTypeDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x0005A23C File Offset: 0x0005843C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458860, XrefRangeEnd = 458865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<IExtenderProvider> GetExtenderProviders(Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegatingTypeDescriptionProvider.NativeMethodInfoPtr_GetExtenderProviders_FamOrAssem_Virtual_Il2CppReferenceArray_1_IExtenderProvider_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IExtenderProvider>>(intPtr3) : null;
			}
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x0005A28C File Offset: 0x0005848C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458865, XrefRangeEnd = 458870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetReflectionType(Type objectType, Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegatingTypeDescriptionProvider.NativeMethodInfoPtr_GetReflectionType_Public_Virtual_Type_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x0005A2F0 File Offset: 0x000584F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458870, XrefRangeEnd = 458875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegatingTypeDescriptionProvider.NativeMethodInfoPtr_GetTypeDescriptor_Public_Virtual_ICustomTypeDescriptor_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICustomTypeDescriptor>(intPtr3) : null;
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00007D53 File Offset: 0x00005F53
		public DelegatingTypeDescriptionProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001063 RID: 4195 RVA: 0x0005A354 File Offset: 0x00058554
		// (set) Token: 0x06001064 RID: 4196 RVA: 0x00007D5C File Offset: 0x00005F5C
		public unsafe Type _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegatingTypeDescriptionProvider.NativeFieldInfoPtr__type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegatingTypeDescriptionProvider.NativeFieldInfoPtr__type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_0;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeMethodInfoPtr_get_Provider_Internal_get_TypeDescriptionProvider_0;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_Object_IServiceProvider_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeMethodInfoPtr_GetCache_Public_Virtual_IDictionary_Object_0;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeMethodInfoPtr_GetExtendedTypeDescriptor_Public_Virtual_ICustomTypeDescriptor_Object_0;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeMethodInfoPtr_GetExtenderProviders_FamOrAssem_Virtual_Il2CppReferenceArray_1_IExtenderProvider_Object_0;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr_GetReflectionType_Public_Virtual_Type_Type_Object_0;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeDescriptor_Public_Virtual_ICustomTypeDescriptor_Type_Object_0;
	}
}
