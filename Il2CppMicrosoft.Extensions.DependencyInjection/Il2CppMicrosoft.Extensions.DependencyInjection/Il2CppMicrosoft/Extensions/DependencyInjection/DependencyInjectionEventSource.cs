using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Diagnostics.Tracing;
using Il2CppSystem.Text;

namespace Il2CppMicrosoft.Extensions.DependencyInjection
{
	// Token: 0x0200000E RID: 14
	public sealed class DependencyInjectionEventSource : EventSource
	{
		// Token: 0x0600005F RID: 95 RVA: 0x00004748 File Offset: 0x00002948
		// Note: this type is marked as 'beforefieldinit'.
		static DependencyInjectionEventSource()
		{
			Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection", "DependencyInjectionEventSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr);
			DependencyInjectionEventSource.NativeFieldInfoPtr_Log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr, "Log");
			DependencyInjectionEventSource.NativeFieldInfoPtr__providers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr, "_providers");
			DependencyInjectionEventSource.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr, 100663358);
			DependencyInjectionEventSource.NativeMethodInfoPtr_CallSiteBuilt_Private_Void_String_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr, 100663359);
			DependencyInjectionEventSource.NativeMethodInfoPtr_ServiceResolved_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr, 100663360);
			DependencyInjectionEventSource.NativeMethodInfoPtr_DynamicMethodBuilt_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr, 100663361);
			DependencyInjectionEventSource.NativeMethodInfoPtr_ScopeDisposed_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr, 100663362);
			DependencyInjectionEventSource.NativeMethodInfoPtr_ServiceRealizationFailed_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr, 100663363);
			DependencyInjectionEventSource.NativeMethodInfoPtr_ServiceProviderBuilt_Private_Void_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr, 100663364);
			DependencyInjectionEventSource.NativeMethodInfoPtr_ServiceProviderDescriptors_Private_Void_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr, 100663365);
			DependencyInjectionEventSource.NativeMethodInfoPtr_ServiceResolved_Public_Void_ServiceProvider_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr, 100663366);
			DependencyInjectionEventSource.NativeMethodInfoPtr_CallSiteBuilt_Public_Void_ServiceProvider_Type_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr, 100663367);
			DependencyInjectionEventSource.NativeMethodInfoPtr_DynamicMethodBuilt_Public_Void_ServiceProvider_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr, 100663368);
			DependencyInjectionEventSource.NativeMethodInfoPtr_ServiceRealizationFailed_Public_Void_Exception_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr, 100663369);
			DependencyInjectionEventSource.NativeMethodInfoPtr_ServiceProviderBuilt_Public_Void_ServiceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr, 100663370);
			DependencyInjectionEventSource.NativeMethodInfoPtr_ServiceProviderDisposed_Public_Void_ServiceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr, 100663371);
			DependencyInjectionEventSource.NativeMethodInfoPtr_WriteServiceProviderBuilt_Private_Void_ServiceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr, 100663372);
			DependencyInjectionEventSource.NativeMethodInfoPtr_AppendServiceDescriptor_Private_Static_Void_StringBuilder_ServiceDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr, 100663373);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000048E0 File Offset: 0x00002AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203166, XrefRangeEnd = 1203174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DependencyInjectionEventSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependencyInjectionEventSource.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000491C File Offset: 0x00002B1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1203195, RefRangeEnd = 1203196, XrefRangeStart = 1203174, XrefRangeEnd = 1203195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CallSiteBuilt(string serviceType, string callSite, int chunkIndex, int chunkCount, int serviceProviderHashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(serviceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(callSite);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chunkIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chunkCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serviceProviderHashCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependencyInjectionEventSource.NativeMethodInfoPtr_CallSiteBuilt_Private_Void_String_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000499C File Offset: 0x00002B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203196, XrefRangeEnd = 1203197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ServiceResolved(string serviceType, int serviceProviderHashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(serviceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serviceProviderHashCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependencyInjectionEventSource.NativeMethodInfoPtr_ServiceResolved_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000049EC File Offset: 0x00002BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203197, XrefRangeEnd = 1203198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DynamicMethodBuilt(string serviceType, int methodSize, int serviceProviderHashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(serviceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serviceProviderHashCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependencyInjectionEventSource.NativeMethodInfoPtr_DynamicMethodBuilt_Public_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004A4C File Offset: 0x00002C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203198, XrefRangeEnd = 1203199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScopeDisposed(int serviceProviderHashCode, int scopedServicesResolved, int disposableServices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref serviceProviderHashCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopedServicesResolved;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref disposableServices;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependencyInjectionEventSource.NativeMethodInfoPtr_ScopeDisposed_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00004AA8 File Offset: 0x00002CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203199, XrefRangeEnd = 1203200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ServiceRealizationFailed(string exceptionMessage, int serviceProviderHashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(exceptionMessage);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serviceProviderHashCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependencyInjectionEventSource.NativeMethodInfoPtr_ServiceRealizationFailed_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00004AF8 File Offset: 0x00002CF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1203229, RefRangeEnd = 1203230, XrefRangeStart = 1203200, XrefRangeEnd = 1203229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ServiceProviderBuilt(int serviceProviderHashCode, int singletonServices, int scopedServices, int transientServices, int closedGenericsServices, int openGenericsServices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref serviceProviderHashCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref singletonServices;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopedServices;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transientServices;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref closedGenericsServices;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openGenericsServices;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependencyInjectionEventSource.NativeMethodInfoPtr_ServiceProviderBuilt_Private_Void_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00004B7C File Offset: 0x00002D7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1203249, RefRangeEnd = 1203250, XrefRangeStart = 1203230, XrefRangeEnd = 1203249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ServiceProviderDescriptors(int serviceProviderHashCode, string descriptors, int chunkIndex, int chunkCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref serviceProviderHashCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(descriptors);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chunkIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chunkCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependencyInjectionEventSource.NativeMethodInfoPtr_ServiceProviderDescriptors_Private_Void_Int32_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004BE8 File Offset: 0x00002DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203250, XrefRangeEnd = 1203252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ServiceResolved(ServiceProvider provider, Type serviceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependencyInjectionEventSource.NativeMethodInfoPtr_ServiceResolved_Public_Void_ServiceProvider_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004C3C File Offset: 0x00002E3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1203275, RefRangeEnd = 1203276, XrefRangeStart = 1203252, XrefRangeEnd = 1203275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CallSiteBuilt(ServiceProvider provider, Type serviceType, ServiceCallSite callSite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callSite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependencyInjectionEventSource.NativeMethodInfoPtr_CallSiteBuilt_Public_Void_ServiceProvider_Type_ServiceCallSite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004CA4 File Offset: 0x00002EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203276, XrefRangeEnd = 1203278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DynamicMethodBuilt(ServiceProvider provider, Type serviceType, int methodSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependencyInjectionEventSource.NativeMethodInfoPtr_DynamicMethodBuilt_Public_Void_ServiceProvider_Type_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004D08 File Offset: 0x00002F08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1203280, RefRangeEnd = 1203281, XrefRangeStart = 1203278, XrefRangeEnd = 1203280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ServiceRealizationFailed(Exception exception, int serviceProviderHashCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serviceProviderHashCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependencyInjectionEventSource.NativeMethodInfoPtr_ServiceRealizationFailed_Public_Void_Exception_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00004D58 File Offset: 0x00002F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1203297, RefRangeEnd = 1203298, XrefRangeStart = 1203281, XrefRangeEnd = 1203297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ServiceProviderBuilt(ServiceProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependencyInjectionEventSource.NativeMethodInfoPtr_ServiceProviderBuilt_Public_Void_ServiceProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004D9C File Offset: 0x00002F9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1203313, RefRangeEnd = 1203316, XrefRangeStart = 1203298, XrefRangeEnd = 1203313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ServiceProviderDisposed(ServiceProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependencyInjectionEventSource.NativeMethodInfoPtr_ServiceProviderDisposed_Public_Void_ServiceProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004DE0 File Offset: 0x00002FE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1203345, RefRangeEnd = 1203346, XrefRangeStart = 1203316, XrefRangeEnd = 1203345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteServiceProviderBuilt(ServiceProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependencyInjectionEventSource.NativeMethodInfoPtr_WriteServiceProviderBuilt_Private_Void_ServiceProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004E24 File Offset: 0x00003024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1203417, RefRangeEnd = 1203418, XrefRangeStart = 1203346, XrefRangeEnd = 1203417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendServiceDescriptor(StringBuilder builder, ServiceDescriptor descriptor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(descriptor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DependencyInjectionEventSource.NativeMethodInfoPtr_AppendServiceDescriptor_Private_Static_Void_StringBuilder_ServiceDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002258 File Offset: 0x00000458
		public DependencyInjectionEventSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00004E6C File Offset: 0x0000306C
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002261 File Offset: 0x00000461
		public unsafe static DependencyInjectionEventSource Log
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DependencyInjectionEventSource.NativeFieldInfoPtr_Log, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DependencyInjectionEventSource>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DependencyInjectionEventSource.NativeFieldInfoPtr_Log, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00004E94 File Offset: 0x00003094
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00002273 File Offset: 0x00000473
		public unsafe List<WeakReference<ServiceProvider>> _providers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DependencyInjectionEventSource.NativeFieldInfoPtr__providers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WeakReference<ServiceProvider>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DependencyInjectionEventSource.NativeFieldInfoPtr__providers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr_Log;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr__providers;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_CallSiteBuilt_Private_Void_String_String_Int32_Int32_Int32_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_ServiceResolved_Public_Void_String_Int32_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_DynamicMethodBuilt_Public_Void_String_Int32_Int32_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_ScopeDisposed_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_ServiceRealizationFailed_Public_Void_String_Int32_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_ServiceProviderBuilt_Private_Void_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_ServiceProviderDescriptors_Private_Void_Int32_String_Int32_Int32_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_ServiceResolved_Public_Void_ServiceProvider_Type_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_CallSiteBuilt_Public_Void_ServiceProvider_Type_ServiceCallSite_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_DynamicMethodBuilt_Public_Void_ServiceProvider_Type_Int32_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_ServiceRealizationFailed_Public_Void_Exception_Int32_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_ServiceProviderBuilt_Public_Void_ServiceProvider_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_ServiceProviderDisposed_Public_Void_ServiceProvider_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_WriteServiceProviderBuilt_Private_Void_ServiceProvider_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_AppendServiceDescriptor_Private_Static_Void_StringBuilder_ServiceDescriptor_0;

		// Token: 0x02000032 RID: 50
		public static class Keywords : Object
		{
			// Token: 0x06000248 RID: 584 RVA: 0x00002D2B File Offset: 0x00000F2B
			// Note: this type is marked as 'beforefieldinit'.
			static Keywords()
			{
				Il2CppClassPointerStore<DependencyInjectionEventSource.Keywords>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DependencyInjectionEventSource>.NativeClassPtr, "Keywords");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DependencyInjectionEventSource.Keywords>.NativeClassPtr);
				DependencyInjectionEventSource.Keywords.NativeFieldInfoPtr_ServiceProviderInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DependencyInjectionEventSource.Keywords>.NativeClassPtr, "ServiceProviderInitialized");
			}

			// Token: 0x06000249 RID: 585 RVA: 0x00002D5F File Offset: 0x00000F5F
			public Keywords(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x0600024A RID: 586 RVA: 0x0000C708 File Offset: 0x0000A908
			// (set) Token: 0x0600024B RID: 587 RVA: 0x00002D68 File Offset: 0x00000F68
			public unsafe static EventKeywords ServiceProviderInitialized
			{
				get
				{
					EventKeywords eventKeywords;
					IL2CPP.il2cpp_field_static_get_value(DependencyInjectionEventSource.Keywords.NativeFieldInfoPtr_ServiceProviderInitialized, (void*)(&eventKeywords));
					return eventKeywords;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DependencyInjectionEventSource.Keywords.NativeFieldInfoPtr_ServiceProviderInitialized, (void*)(&value));
				}
			}

			// Token: 0x040001A7 RID: 423
			private static readonly IntPtr NativeFieldInfoPtr_ServiceProviderInitialized;
		}
	}
}
