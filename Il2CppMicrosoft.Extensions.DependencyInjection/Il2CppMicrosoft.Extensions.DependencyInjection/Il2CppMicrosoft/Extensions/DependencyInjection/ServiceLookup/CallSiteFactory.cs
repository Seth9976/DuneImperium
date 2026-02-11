using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Diagnostics.CodeAnalysis;
using Il2CppSystem.Reflection;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x02000013 RID: 19
	public sealed class CallSiteFactory : Object
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x00005D38 File Offset: 0x00003F38
		// Note: this type is marked as 'beforefieldinit'.
		static CallSiteFactory()
		{
			Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "CallSiteFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr);
			CallSiteFactory.NativeFieldInfoPtr__descriptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, "_descriptors");
			CallSiteFactory.NativeFieldInfoPtr__callSiteCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, "_callSiteCache");
			CallSiteFactory.NativeFieldInfoPtr__descriptorLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, "_descriptorLookup");
			CallSiteFactory.NativeFieldInfoPtr__callSiteLocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, "_callSiteLocks");
			CallSiteFactory.NativeFieldInfoPtr__stackGuard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, "_stackGuard");
			CallSiteFactory.NativeMethodInfoPtr__ctor_Public_Void_ICollection_1_ServiceDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, 100663423);
			CallSiteFactory.NativeMethodInfoPtr_get_Descriptors_Internal_get_Il2CppReferenceArray_1_ServiceDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, 100663424);
			CallSiteFactory.NativeMethodInfoPtr_Populate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, 100663425);
			CallSiteFactory.NativeMethodInfoPtr_ValidateTrimmingAnnotations_Private_Static_Void_Type_Il2CppReferenceArray_1_Type_Type_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, 100663426);
			CallSiteFactory.NativeMethodInfoPtr_GetDynamicallyAccessedMemberTypes_Private_Static_DynamicallyAccessedMemberTypes_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, 100663427);
			CallSiteFactory.NativeMethodInfoPtr_AreCompatible_Private_Static_Boolean_DynamicallyAccessedMemberTypes_DynamicallyAccessedMemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, 100663428);
			CallSiteFactory.NativeMethodInfoPtr_GetCallSite_Internal_ServiceCallSite_ServiceIdentifier_CallSiteChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, 100663429);
			CallSiteFactory.NativeMethodInfoPtr_GetCallSite_Internal_ServiceCallSite_ServiceDescriptor_CallSiteChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, 100663430);
			CallSiteFactory.NativeMethodInfoPtr_CreateCallSite_Private_ServiceCallSite_ServiceIdentifier_CallSiteChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, 100663431);
			CallSiteFactory.NativeMethodInfoPtr_TryCreateExact_Private_ServiceCallSite_ServiceIdentifier_CallSiteChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, 100663432);
			CallSiteFactory.NativeMethodInfoPtr_TryCreateOpenGeneric_Private_ServiceCallSite_ServiceIdentifier_CallSiteChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, 100663433);
			CallSiteFactory.NativeMethodInfoPtr_TryCreateEnumerable_Private_ServiceCallSite_ServiceIdentifier_CallSiteChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, 100663434);
			CallSiteFactory.NativeMethodInfoPtr_GetCommonCacheLocation_Private_Static_CallSiteResultCacheLocation_CallSiteResultCacheLocation_CallSiteResultCacheLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, 100663435);
			CallSiteFactory.NativeMethodInfoPtr_TryCreateExact_Private_ServiceCallSite_ServiceDescriptor_ServiceIdentifier_CallSiteChain_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, 100663436);
			CallSiteFactory.NativeMethodInfoPtr_TryCreateOpenGeneric_Private_ServiceCallSite_ServiceDescriptor_ServiceIdentifier_CallSiteChain_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, 100663437);
			CallSiteFactory.NativeMethodInfoPtr_CreateConstructorCallSite_Private_ConstructorCallSite_ResultCache_ServiceIdentifier_Type_CallSiteChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, 100663438);
			CallSiteFactory.NativeMethodInfoPtr_CreateArgumentCallSites_Private_Il2CppReferenceArray_1_ServiceCallSite_ServiceIdentifier_Type_CallSiteChain_Il2CppReferenceArray_1_ParameterInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, 100663439);
			CallSiteFactory.NativeMethodInfoPtr_VerifyOpenGenericAotCompatibility_Private_Static_Void_Type_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, 100663440);
			CallSiteFactory.NativeMethodInfoPtr_Add_Public_Void_ServiceIdentifier_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, 100663441);
			CallSiteFactory.NativeMethodInfoPtr_KeysMatch_Private_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, 100663442);
			CallSiteFactory.NativeMethodInfoPtr_Method_Internal_Static_Void_ServiceCallSite_Int32_byref___c__DisplayClass19_0_byref___c__DisplayClass19_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, 100663443);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00005F70 File Offset: 0x00004170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1203971, RefRangeEnd = 1203972, XrefRangeStart = 1203932, XrefRangeEnd = 1203971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallSiteFactory(ICollection<ServiceDescriptor> descriptors)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(descriptors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.NativeMethodInfoPtr__ctor_Public_Void_ICollection_1_ServiceDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00005FBC File Offset: 0x000041BC
		public unsafe Il2CppReferenceArray<ServiceDescriptor> Descriptors
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.NativeMethodInfoPtr_get_Descriptors_Internal_get_Il2CppReferenceArray_1_ServiceDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ServiceDescriptor>>(intPtr3) : null;
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00005FFC File Offset: 0x000041FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1204009, RefRangeEnd = 1204010, XrefRangeStart = 1203972, XrefRangeEnd = 1204009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Populate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.NativeMethodInfoPtr_Populate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00006030 File Offset: 0x00004230
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1204013, RefRangeEnd = 1204014, XrefRangeStart = 1204010, XrefRangeEnd = 1204013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateTrimmingAnnotations(Type serviceType, Il2CppReferenceArray<Type> serviceTypeGenericArguments, Type implementationType, Il2CppReferenceArray<Type> implementationTypeGenericArguments)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceTypeGenericArguments);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(implementationType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(implementationTypeGenericArguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.NativeMethodInfoPtr_ValidateTrimmingAnnotations_Private_Static_Void_Type_Il2CppReferenceArray_1_Type_Type_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000609C File Offset: 0x0000429C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1204044, RefRangeEnd = 1204046, XrefRangeStart = 1204014, XrefRangeEnd = 1204044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static global::Il2CppSystem.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes GetDynamicallyAccessedMemberTypes(Type serviceGenericType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceGenericType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.NativeMethodInfoPtr_GetDynamicallyAccessedMemberTypes_Private_Static_DynamicallyAccessedMemberTypes_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000060E0 File Offset: 0x000042E0
		[CallerCount(0)]
		public unsafe static bool AreCompatible(global::Il2CppSystem.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes serviceDynamicallyAccessedMembers, global::Il2CppSystem.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes implementationDynamicallyAccessedMembers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref serviceDynamicallyAccessedMembers;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref implementationDynamicallyAccessedMembers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.NativeMethodInfoPtr_AreCompatible_Private_Static_Boolean_DynamicallyAccessedMemberTypes_DynamicallyAccessedMemberTypes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000612C File Offset: 0x0000432C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1204050, RefRangeEnd = 1204053, XrefRangeStart = 1204046, XrefRangeEnd = 1204050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceCallSite GetCallSite(ServiceIdentifier serviceIdentifier, CallSiteChain callSiteChain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(serviceIdentifier));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callSiteChain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.NativeMethodInfoPtr_GetCallSite_Internal_ServiceCallSite_ServiceIdentifier_CallSiteChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceCallSite>(intPtr3) : null;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00006194 File Offset: 0x00004394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204053, XrefRangeEnd = 1204058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceCallSite GetCallSite(ServiceDescriptor serviceDescriptor, CallSiteChain callSiteChain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceDescriptor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callSiteChain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.NativeMethodInfoPtr_GetCallSite_Internal_ServiceCallSite_ServiceDescriptor_CallSiteChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceCallSite>(intPtr3) : null;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000061F8 File Offset: 0x000043F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204058, XrefRangeEnd = 1204072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceCallSite CreateCallSite(ServiceIdentifier serviceIdentifier, CallSiteChain callSiteChain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(serviceIdentifier));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callSiteChain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.NativeMethodInfoPtr_CreateCallSite_Private_ServiceCallSite_ServiceIdentifier_CallSiteChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceCallSite>(intPtr3) : null;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00006260 File Offset: 0x00004460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204072, XrefRangeEnd = 1204091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceCallSite TryCreateExact(ServiceIdentifier serviceIdentifier, CallSiteChain callSiteChain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(serviceIdentifier));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callSiteChain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.NativeMethodInfoPtr_TryCreateExact_Private_ServiceCallSite_ServiceIdentifier_CallSiteChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceCallSite>(intPtr3) : null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000062C8 File Offset: 0x000044C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204091, XrefRangeEnd = 1204110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceCallSite TryCreateOpenGeneric(ServiceIdentifier serviceIdentifier, CallSiteChain callSiteChain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(serviceIdentifier));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callSiteChain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.NativeMethodInfoPtr_TryCreateOpenGeneric_Private_ServiceCallSite_ServiceIdentifier_CallSiteChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceCallSite>(intPtr3) : null;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00006330 File Offset: 0x00004530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204110, XrefRangeEnd = 1204222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceCallSite TryCreateEnumerable(ServiceIdentifier serviceIdentifier, CallSiteChain callSiteChain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(serviceIdentifier));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callSiteChain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.NativeMethodInfoPtr_TryCreateEnumerable_Private_ServiceCallSite_ServiceIdentifier_CallSiteChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceCallSite>(intPtr3) : null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00006398 File Offset: 0x00004598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204222, XrefRangeEnd = 1204226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CallSiteResultCacheLocation GetCommonCacheLocation(CallSiteResultCacheLocation locationA, CallSiteResultCacheLocation locationB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref locationA;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locationB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.NativeMethodInfoPtr_GetCommonCacheLocation_Private_Static_CallSiteResultCacheLocation_CallSiteResultCacheLocation_CallSiteResultCacheLocation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000063E4 File Offset: 0x000045E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1204234, RefRangeEnd = 1204237, XrefRangeStart = 1204226, XrefRangeEnd = 1204234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceCallSite TryCreateExact(ServiceDescriptor descriptor, ServiceIdentifier serviceIdentifier, CallSiteChain callSiteChain, int slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(descriptor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(serviceIdentifier));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callSiteChain);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.NativeMethodInfoPtr_TryCreateExact_Private_ServiceCallSite_ServiceDescriptor_ServiceIdentifier_CallSiteChain_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceCallSite>(intPtr3) : null;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000646C File Offset: 0x0000466C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1204264, RefRangeEnd = 1204266, XrefRangeStart = 1204237, XrefRangeEnd = 1204264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceCallSite TryCreateOpenGeneric(ServiceDescriptor descriptor, ServiceIdentifier serviceIdentifier, CallSiteChain callSiteChain, int slot, bool throwOnConstraintViolation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(descriptor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(serviceIdentifier));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callSiteChain);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slot;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnConstraintViolation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.NativeMethodInfoPtr_TryCreateOpenGeneric_Private_ServiceCallSite_ServiceDescriptor_ServiceIdentifier_CallSiteChain_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceCallSite>(intPtr3) : null;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00006504 File Offset: 0x00004704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1204331, RefRangeEnd = 1204332, XrefRangeStart = 1204266, XrefRangeEnd = 1204331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructorCallSite CreateConstructorCallSite(ResultCache lifetime, ServiceIdentifier serviceIdentifier, Type implementationType, CallSiteChain callSiteChain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lifetime));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(serviceIdentifier));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(implementationType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callSiteChain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.NativeMethodInfoPtr_CreateConstructorCallSite_Private_ConstructorCallSite_ResultCache_ServiceIdentifier_Type_CallSiteChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorCallSite>(intPtr3) : null;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00006598 File Offset: 0x00004798
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1204364, RefRangeEnd = 1204366, XrefRangeStart = 1204332, XrefRangeEnd = 1204364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<ServiceCallSite> CreateArgumentCallSites(ServiceIdentifier serviceIdentifier, Type implementationType, CallSiteChain callSiteChain, Il2CppReferenceArray<ParameterInfo> parameters, bool throwIfCallSiteNotFound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(serviceIdentifier));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(implementationType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callSiteChain);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwIfCallSiteNotFound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.NativeMethodInfoPtr_CreateArgumentCallSites_Private_Il2CppReferenceArray_1_ServiceCallSite_ServiceIdentifier_Type_CallSiteChain_Il2CppReferenceArray_1_ParameterInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ServiceCallSite>>(intPtr3) : null;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00006634 File Offset: 0x00004834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204366, XrefRangeEnd = 1204368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void VerifyOpenGenericAotCompatibility(Type serviceType, Il2CppReferenceArray<Type> genericTypeArguments)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genericTypeArguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.NativeMethodInfoPtr_VerifyOpenGenericAotCompatibility_Private_Static_Void_Type_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000667C File Offset: 0x0000487C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204368, XrefRangeEnd = 1204372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(ServiceIdentifier serviceIdentifier, ServiceCallSite serviceCallSite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(serviceIdentifier));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceCallSite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.NativeMethodInfoPtr_Add_Public_Void_ServiceIdentifier_ServiceCallSite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000066D8 File Offset: 0x000048D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204372, XrefRangeEnd = 1204373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool KeysMatch(Object key1, Object key2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.NativeMethodInfoPtr_KeysMatch_Private_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000672C File Offset: 0x0000492C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1204383, RefRangeEnd = 1204385, XrefRangeStart = 1204373, XrefRangeEnd = 1204383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_ServiceCallSite_Int32_byref___c__DisplayClass19_0_byref___c__DisplayClass19_1_0(ServiceCallSite callSite, int index, ref CallSiteFactory.__c__DisplayClass19_0 A_2, ref CallSiteFactory.__c__DisplayClass19_1 A_3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.NativeMethodInfoPtr_Method_Internal_Static_Void_ServiceCallSite_Int32_byref___c__DisplayClass19_0_byref___c__DisplayClass19_1_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000240E File Offset: 0x0000060E
		public CallSiteFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00006794 File Offset: 0x00004994
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00002417 File Offset: 0x00000617
		public unsafe Il2CppReferenceArray<ServiceDescriptor> _descriptors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteFactory.NativeFieldInfoPtr__descriptors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ServiceDescriptor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteFactory.NativeFieldInfoPtr__descriptors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000067C4 File Offset: 0x000049C4
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00002436 File Offset: 0x00000636
		public unsafe ConcurrentDictionary<ServiceCacheKey, ServiceCallSite> _callSiteCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteFactory.NativeFieldInfoPtr__callSiteCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<ServiceCacheKey, ServiceCallSite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteFactory.NativeFieldInfoPtr__callSiteCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000067F4 File Offset: 0x000049F4
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002455 File Offset: 0x00000655
		public unsafe Dictionary<ServiceIdentifier, CallSiteFactory.ServiceDescriptorCacheItem> _descriptorLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteFactory.NativeFieldInfoPtr__descriptorLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ServiceIdentifier, CallSiteFactory.ServiceDescriptorCacheItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteFactory.NativeFieldInfoPtr__descriptorLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00006824 File Offset: 0x00004A24
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00002474 File Offset: 0x00000674
		public unsafe ConcurrentDictionary<ServiceIdentifier, Object> _callSiteLocks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteFactory.NativeFieldInfoPtr__callSiteLocks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<ServiceIdentifier, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteFactory.NativeFieldInfoPtr__callSiteLocks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00006854 File Offset: 0x00004A54
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00002493 File Offset: 0x00000693
		public unsafe StackGuard _stackGuard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteFactory.NativeFieldInfoPtr__stackGuard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StackGuard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteFactory.NativeFieldInfoPtr__stackGuard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr__descriptors;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr__callSiteCache;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr__descriptorLookup;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr__callSiteLocks;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr__stackGuard;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ICollection_1_ServiceDescriptor_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_get_Descriptors_Internal_get_Il2CppReferenceArray_1_ServiceDescriptor_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_Populate_Private_Void_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_ValidateTrimmingAnnotations_Private_Static_Void_Type_Il2CppReferenceArray_1_Type_Type_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicallyAccessedMemberTypes_Private_Static_DynamicallyAccessedMemberTypes_Type_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_AreCompatible_Private_Static_Boolean_DynamicallyAccessedMemberTypes_DynamicallyAccessedMemberTypes_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_GetCallSite_Internal_ServiceCallSite_ServiceIdentifier_CallSiteChain_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_GetCallSite_Internal_ServiceCallSite_ServiceDescriptor_CallSiteChain_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_CreateCallSite_Private_ServiceCallSite_ServiceIdentifier_CallSiteChain_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_TryCreateExact_Private_ServiceCallSite_ServiceIdentifier_CallSiteChain_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_TryCreateOpenGeneric_Private_ServiceCallSite_ServiceIdentifier_CallSiteChain_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_TryCreateEnumerable_Private_ServiceCallSite_ServiceIdentifier_CallSiteChain_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_GetCommonCacheLocation_Private_Static_CallSiteResultCacheLocation_CallSiteResultCacheLocation_CallSiteResultCacheLocation_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_TryCreateExact_Private_ServiceCallSite_ServiceDescriptor_ServiceIdentifier_CallSiteChain_Int32_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_TryCreateOpenGeneric_Private_ServiceCallSite_ServiceDescriptor_ServiceIdentifier_CallSiteChain_Int32_Boolean_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_CreateConstructorCallSite_Private_ConstructorCallSite_ResultCache_ServiceIdentifier_Type_CallSiteChain_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_CreateArgumentCallSites_Private_Il2CppReferenceArray_1_ServiceCallSite_ServiceIdentifier_Type_CallSiteChain_Il2CppReferenceArray_1_ParameterInfo_Boolean_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_VerifyOpenGenericAotCompatibility_Private_Static_Void_Type_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_ServiceIdentifier_ServiceCallSite_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_KeysMatch_Private_Static_Boolean_Object_Object_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_ServiceCallSite_Int32_byref___c__DisplayClass19_0_byref___c__DisplayClass19_1_0;

		// Token: 0x02000039 RID: 57
		public sealed class ServiceDescriptorCacheItem : ValueType
		{
			// Token: 0x06000279 RID: 633 RVA: 0x0000CF40 File Offset: 0x0000B140
			// Note: this type is marked as 'beforefieldinit'.
			static ServiceDescriptorCacheItem()
			{
				Il2CppClassPointerStore<CallSiteFactory.ServiceDescriptorCacheItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, "ServiceDescriptorCacheItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallSiteFactory.ServiceDescriptorCacheItem>.NativeClassPtr);
				CallSiteFactory.ServiceDescriptorCacheItem.NativeFieldInfoPtr__item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteFactory.ServiceDescriptorCacheItem>.NativeClassPtr, "_item");
				CallSiteFactory.ServiceDescriptorCacheItem.NativeFieldInfoPtr__items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteFactory.ServiceDescriptorCacheItem>.NativeClassPtr, "_items");
				CallSiteFactory.ServiceDescriptorCacheItem.NativeMethodInfoPtr_get_Last_Public_get_ServiceDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory.ServiceDescriptorCacheItem>.NativeClassPtr, 100663444);
				CallSiteFactory.ServiceDescriptorCacheItem.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory.ServiceDescriptorCacheItem>.NativeClassPtr, 100663445);
				CallSiteFactory.ServiceDescriptorCacheItem.NativeMethodInfoPtr_get_Item_Public_get_ServiceDescriptor_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory.ServiceDescriptorCacheItem>.NativeClassPtr, 100663446);
				CallSiteFactory.ServiceDescriptorCacheItem.NativeMethodInfoPtr_GetSlot_Public_Int32_ServiceDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory.ServiceDescriptorCacheItem>.NativeClassPtr, 100663447);
				CallSiteFactory.ServiceDescriptorCacheItem.NativeMethodInfoPtr_Add_Public_ServiceDescriptorCacheItem_ServiceDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory.ServiceDescriptorCacheItem>.NativeClassPtr, 100663448);
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x0600027A RID: 634 RVA: 0x0000CFF8 File Offset: 0x0000B1F8
			public unsafe ServiceDescriptor Last
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203896, XrefRangeEnd = 1203900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.ServiceDescriptorCacheItem.NativeMethodInfoPtr_get_Last_Public_get_ServiceDescriptor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceDescriptor>(intPtr3) : null;
				}
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x0600027B RID: 635 RVA: 0x0000D03C File Offset: 0x0000B23C
			public unsafe int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203900, XrefRangeEnd = 1203901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.ServiceDescriptorCacheItem.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170000C6 RID: 198
			public unsafe ServiceDescriptor this[int index]
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1203907, RefRangeEnd = 1203908, XrefRangeStart = 1203901, XrefRangeEnd = 1203907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.ServiceDescriptorCacheItem.NativeMethodInfoPtr_get_Item_Public_get_ServiceDescriptor_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceDescriptor>(intPtr3) : null;
					}
				}
			}

			// Token: 0x0600027D RID: 637 RVA: 0x0000D0D4 File Offset: 0x0000B2D4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1203912, RefRangeEnd = 1203913, XrefRangeStart = 1203908, XrefRangeEnd = 1203912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetSlot(ServiceDescriptor descriptor)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(descriptor);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.ServiceDescriptorCacheItem.NativeMethodInfoPtr_GetSlot_Public_Int32_ServiceDescriptor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600027E RID: 638 RVA: 0x0000D128 File Offset: 0x0000B328
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1203924, RefRangeEnd = 1203925, XrefRangeStart = 1203913, XrefRangeEnd = 1203924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CallSiteFactory.ServiceDescriptorCacheItem Add(ServiceDescriptor descriptor)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(descriptor);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.ServiceDescriptorCacheItem.NativeMethodInfoPtr_Add_Public_ServiceDescriptorCacheItem_ServiceDescriptor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new CallSiteFactory.ServiceDescriptorCacheItem(intPtr);
				}
			}

			// Token: 0x0600027F RID: 639 RVA: 0x00002EBD File Offset: 0x000010BD
			public ServiceDescriptorCacheItem(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000280 RID: 640 RVA: 0x00002EC6 File Offset: 0x000010C6
			public ServiceDescriptorCacheItem()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSiteFactory.ServiceDescriptorCacheItem>.NativeClassPtr))
			{
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x06000281 RID: 641 RVA: 0x0000D178 File Offset: 0x0000B378
			// (set) Token: 0x06000282 RID: 642 RVA: 0x00002ED8 File Offset: 0x000010D8
			public unsafe ServiceDescriptor _item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteFactory.ServiceDescriptorCacheItem.NativeFieldInfoPtr__item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceDescriptor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteFactory.ServiceDescriptorCacheItem.NativeFieldInfoPtr__item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x06000283 RID: 643 RVA: 0x0000D1A8 File Offset: 0x0000B3A8
			// (set) Token: 0x06000284 RID: 644 RVA: 0x00002EF7 File Offset: 0x000010F7
			public unsafe List<ServiceDescriptor> _items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteFactory.ServiceDescriptorCacheItem.NativeFieldInfoPtr__items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ServiceDescriptor>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteFactory.ServiceDescriptorCacheItem.NativeFieldInfoPtr__items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001BF RID: 447
			private static readonly IntPtr NativeFieldInfoPtr__item;

			// Token: 0x040001C0 RID: 448
			private static readonly IntPtr NativeFieldInfoPtr__items;

			// Token: 0x040001C1 RID: 449
			private static readonly IntPtr NativeMethodInfoPtr_get_Last_Public_get_ServiceDescriptor_0;

			// Token: 0x040001C2 RID: 450
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

			// Token: 0x040001C3 RID: 451
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_ServiceDescriptor_Int32_0;

			// Token: 0x040001C4 RID: 452
			private static readonly IntPtr NativeMethodInfoPtr_GetSlot_Public_Int32_ServiceDescriptor_0;

			// Token: 0x040001C5 RID: 453
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_ServiceDescriptorCacheItem_ServiceDescriptor_0;
		}

		// Token: 0x0200003A RID: 58
		[ObfuscatedName("Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteFactory+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000285 RID: 645 RVA: 0x0000D1D8 File Offset: 0x0000B3D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CallSiteFactory.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallSiteFactory.__c>.NativeClassPtr);
				CallSiteFactory.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteFactory.__c>.NativeClassPtr, "<>9");
				CallSiteFactory.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteFactory.__c>.NativeClassPtr, "<>9__16_0");
				CallSiteFactory.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteFactory.__c>.NativeClassPtr, "<>9__19_0");
				CallSiteFactory.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteFactory.__c>.NativeClassPtr, "<>9__23_0");
				CallSiteFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory.__c>.NativeClassPtr, 100663450);
				CallSiteFactory.__c.NativeMethodInfoPtr__CreateCallSite_b__16_0_Internal_Object_ServiceIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory.__c>.NativeClassPtr, 100663451);
				CallSiteFactory.__c.NativeMethodInfoPtr__TryCreateEnumerable_b__19_0_Internal_Int32_KeyValuePair_2_Int32_ServiceCallSite_KeyValuePair_2_Int32_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory.__c>.NativeClassPtr, 100663452);
				CallSiteFactory.__c.NativeMethodInfoPtr__CreateConstructorCallSite_b__23_0_Internal_Int32_ConstructorInfo_ConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteFactory.__c>.NativeClassPtr, 100663453);
			}

			// Token: 0x06000286 RID: 646 RVA: 0x0000D2A4 File Offset: 0x0000B4A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSiteFactory.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000287 RID: 647 RVA: 0x0000D2E0 File Offset: 0x0000B4E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203925, XrefRangeEnd = 1203929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _CreateCallSite_b__16_0(ServiceIdentifier _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.__c.NativeMethodInfoPtr__CreateCallSite_b__16_0_Internal_Object_ServiceIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000288 RID: 648 RVA: 0x0000D338 File Offset: 0x0000B538
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203929, XrefRangeEnd = 1203931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _TryCreateEnumerable_b__19_0(KeyValuePair<int, ServiceCallSite> a, KeyValuePair<int, ServiceCallSite> b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.__c.NativeMethodInfoPtr__TryCreateEnumerable_b__19_0_Internal_Int32_KeyValuePair_2_Int32_ServiceCallSite_KeyValuePair_2_Int32_ServiceCallSite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000289 RID: 649 RVA: 0x0000D3A4 File Offset: 0x0000B5A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203931, XrefRangeEnd = 1203932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CreateConstructorCallSite_b__23_0(ConstructorInfo a, ConstructorInfo b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteFactory.__c.NativeMethodInfoPtr__CreateConstructorCallSite_b__23_0_Internal_Int32_ConstructorInfo_ConstructorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600028A RID: 650 RVA: 0x00002F16 File Offset: 0x00001116
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x0600028B RID: 651 RVA: 0x0000D404 File Offset: 0x0000B604
			// (set) Token: 0x0600028C RID: 652 RVA: 0x00002F1F File Offset: 0x0000111F
			public unsafe static CallSiteFactory.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CallSiteFactory.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallSiteFactory.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CallSiteFactory.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x0600028D RID: 653 RVA: 0x0000D42C File Offset: 0x0000B62C
			// (set) Token: 0x0600028E RID: 654 RVA: 0x00002F31 File Offset: 0x00001131
			public unsafe static Func<ServiceIdentifier, Object> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CallSiteFactory.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ServiceIdentifier, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CallSiteFactory.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C9 RID: 201
			// (get) Token: 0x0600028F RID: 655 RVA: 0x0000D454 File Offset: 0x0000B654
			// (set) Token: 0x06000290 RID: 656 RVA: 0x00002F43 File Offset: 0x00001143
			public unsafe static Comparison<KeyValuePair<int, ServiceCallSite>> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CallSiteFactory.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<KeyValuePair<int, ServiceCallSite>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CallSiteFactory.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000CA RID: 202
			// (get) Token: 0x06000291 RID: 657 RVA: 0x0000D47C File Offset: 0x0000B67C
			// (set) Token: 0x06000292 RID: 658 RVA: 0x00002F55 File Offset: 0x00001155
			public unsafe static Comparison<ConstructorInfo> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CallSiteFactory.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ConstructorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CallSiteFactory.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001C6 RID: 454
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040001C7 RID: 455
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x040001C8 RID: 456
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x040001C9 RID: 457
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x040001CA RID: 458
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001CB RID: 459
			private static readonly IntPtr NativeMethodInfoPtr__CreateCallSite_b__16_0_Internal_Object_ServiceIdentifier_0;

			// Token: 0x040001CC RID: 460
			private static readonly IntPtr NativeMethodInfoPtr__TryCreateEnumerable_b__19_0_Internal_Int32_KeyValuePair_2_Int32_ServiceCallSite_KeyValuePair_2_Int32_ServiceCallSite_0;

			// Token: 0x040001CD RID: 461
			private static readonly IntPtr NativeMethodInfoPtr__CreateConstructorCallSite_b__23_0_Internal_Int32_ConstructorInfo_ConstructorInfo_0;
		}

		// Token: 0x0200003B RID: 59
		[ObfuscatedName("Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteFactory+<>c__DisplayClass19_0")]
		[StructLayout(2)]
		public struct __c__DisplayClass19_0
		{
			// Token: 0x06000293 RID: 659 RVA: 0x00002F67 File Offset: 0x00001167
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<CallSiteFactory.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallSiteFactory.__c__DisplayClass19_0>.NativeClassPtr);
				CallSiteFactory.__c__DisplayClass19_0.NativeFieldInfoPtr_cacheLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteFactory.__c__DisplayClass19_0>.NativeClassPtr, "cacheLocation");
			}

			// Token: 0x06000294 RID: 660 RVA: 0x00002F9B File Offset: 0x0000119B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallSiteFactory.__c__DisplayClass19_0>.NativeClassPtr, ref this));
			}

			// Token: 0x040001CE RID: 462
			private static readonly IntPtr NativeFieldInfoPtr_cacheLocation;

			// Token: 0x040001CF RID: 463
			[FieldOffset(0)]
			public CallSiteResultCacheLocation cacheLocation;
		}

		// Token: 0x0200003C RID: 60
		[ObfuscatedName("Microsoft.Extensions.DependencyInjection.ServiceLookup.CallSiteFactory+<>c__DisplayClass19_1")]
		public sealed class __c__DisplayClass19_1 : ValueType
		{
			// Token: 0x06000295 RID: 661 RVA: 0x0000D4A4 File Offset: 0x0000B6A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_1()
			{
				Il2CppClassPointerStore<CallSiteFactory.__c__DisplayClass19_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallSiteFactory>.NativeClassPtr, "<>c__DisplayClass19_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallSiteFactory.__c__DisplayClass19_1>.NativeClassPtr);
				CallSiteFactory.__c__DisplayClass19_1.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteFactory.__c__DisplayClass19_1>.NativeClassPtr, "slot");
				CallSiteFactory.__c__DisplayClass19_1.NativeFieldInfoPtr_callSitesByIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteFactory.__c__DisplayClass19_1>.NativeClassPtr, "callSitesByIndex");
			}

			// Token: 0x06000296 RID: 662 RVA: 0x00002FAD File Offset: 0x000011AD
			public __c__DisplayClass19_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000297 RID: 663 RVA: 0x00002FB6 File Offset: 0x000011B6
			public __c__DisplayClass19_1()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSiteFactory.__c__DisplayClass19_1>.NativeClassPtr))
			{
			}

			// Token: 0x170000CB RID: 203
			// (get) Token: 0x06000298 RID: 664 RVA: 0x0000D4F8 File Offset: 0x0000B6F8
			// (set) Token: 0x06000299 RID: 665 RVA: 0x00002FC8 File Offset: 0x000011C8
			public unsafe int slot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteFactory.__c__DisplayClass19_1.NativeFieldInfoPtr_slot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteFactory.__c__DisplayClass19_1.NativeFieldInfoPtr_slot)) = value;
				}
			}

			// Token: 0x170000CC RID: 204
			// (get) Token: 0x0600029A RID: 666 RVA: 0x0000D520 File Offset: 0x0000B720
			// (set) Token: 0x0600029B RID: 667 RVA: 0x00002FE3 File Offset: 0x000011E3
			public unsafe List<KeyValuePair<int, ServiceCallSite>> callSitesByIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteFactory.__c__DisplayClass19_1.NativeFieldInfoPtr_callSitesByIndex);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<int, ServiceCallSite>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteFactory.__c__DisplayClass19_1.NativeFieldInfoPtr_callSitesByIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001D0 RID: 464
			private static readonly IntPtr NativeFieldInfoPtr_slot;

			// Token: 0x040001D1 RID: 465
			private static readonly IntPtr NativeFieldInfoPtr_callSitesByIndex;
		}
	}
}
