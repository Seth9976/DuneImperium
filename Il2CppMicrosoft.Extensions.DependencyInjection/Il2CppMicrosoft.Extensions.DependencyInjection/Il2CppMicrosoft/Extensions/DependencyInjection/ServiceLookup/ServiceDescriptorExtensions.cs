using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x02000025 RID: 37
	public static class ServiceDescriptorExtensions : Object
	{
		// Token: 0x0600018B RID: 395 RVA: 0x00009B9C File Offset: 0x00007D9C
		// Note: this type is marked as 'beforefieldinit'.
		static ServiceDescriptorExtensions()
		{
			Il2CppClassPointerStore<ServiceDescriptorExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "ServiceDescriptorExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceDescriptorExtensions>.NativeClassPtr);
			ServiceDescriptorExtensions.NativeMethodInfoPtr_HasImplementationInstance_Public_Static_Boolean_ServiceDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptorExtensions>.NativeClassPtr, 100663561);
			ServiceDescriptorExtensions.NativeMethodInfoPtr_HasImplementationType_Public_Static_Boolean_ServiceDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptorExtensions>.NativeClassPtr, 100663562);
			ServiceDescriptorExtensions.NativeMethodInfoPtr_GetImplementationInstance_Public_Static_Object_ServiceDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptorExtensions>.NativeClassPtr, 100663563);
			ServiceDescriptorExtensions.NativeMethodInfoPtr_GetImplementationType_Public_Static_Type_ServiceDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptorExtensions>.NativeClassPtr, 100663564);
			ServiceDescriptorExtensions.NativeMethodInfoPtr_TryGetImplementationType_Public_Static_Boolean_ServiceDescriptor_byref_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptorExtensions>.NativeClassPtr, 100663565);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00009C30 File Offset: 0x00007E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204820, XrefRangeEnd = 1204822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasImplementationInstance(this ServiceDescriptor serviceDescriptor)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceDescriptor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptorExtensions.NativeMethodInfoPtr_HasImplementationInstance_Public_Static_Boolean_ServiceDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00009C74 File Offset: 0x00007E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204822, XrefRangeEnd = 1204831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasImplementationType(this ServiceDescriptor serviceDescriptor)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceDescriptor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptorExtensions.NativeMethodInfoPtr_HasImplementationType_Public_Static_Boolean_ServiceDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00009CB8 File Offset: 0x00007EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204831, XrefRangeEnd = 1204835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetImplementationInstance(this ServiceDescriptor serviceDescriptor)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceDescriptor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptorExtensions.NativeMethodInfoPtr_GetImplementationInstance_Public_Static_Object_ServiceDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00009CFC File Offset: 0x00007EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204835, XrefRangeEnd = 1204839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetImplementationType(this ServiceDescriptor serviceDescriptor)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceDescriptor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptorExtensions.NativeMethodInfoPtr_GetImplementationType_Public_Static_Type_ServiceDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00009D40 File Offset: 0x00007F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204839, XrefRangeEnd = 1204849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetImplementationType(this ServiceDescriptor serviceDescriptor, out Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceDescriptor);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptorExtensions.NativeMethodInfoPtr_TryGetImplementationType_Public_Static_Boolean_ServiceDescriptor_byref_Type_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			type = ((intPtr4 == 0) ? null : new Type(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000028A2 File Offset: 0x00000AA2
		public ServiceDescriptorExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_HasImplementationInstance_Public_Static_Boolean_ServiceDescriptor_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_HasImplementationType_Public_Static_Boolean_ServiceDescriptor_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_GetImplementationInstance_Public_Static_Object_ServiceDescriptor_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_GetImplementationType_Public_Static_Type_ServiceDescriptor_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_TryGetImplementationType_Public_Static_Boolean_ServiceDescriptor_byref_Type_0;
	}
}
