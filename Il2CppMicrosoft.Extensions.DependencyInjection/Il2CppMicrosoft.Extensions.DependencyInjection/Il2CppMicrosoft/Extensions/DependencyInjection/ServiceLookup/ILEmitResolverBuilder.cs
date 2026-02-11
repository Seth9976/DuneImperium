using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Reflection;
using Il2CppSystem.Reflection.Emit;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x0200002D RID: 45
	public sealed class ILEmitResolverBuilder : CallSiteVisitor<ILEmitResolverBuilderContext, Object>
	{
		// Token: 0x060001E9 RID: 489 RVA: 0x0000AFC8 File Offset: 0x000091C8
		// Note: this type is marked as 'beforefieldinit'.
		static ILEmitResolverBuilder()
		{
			Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "ILEmitResolverBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr);
			ILEmitResolverBuilder.NativeFieldInfoPtr_ResolvedServicesGetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, "ResolvedServicesGetter");
			ILEmitResolverBuilder.NativeFieldInfoPtr_ScopeLockGetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, "ScopeLockGetter");
			ILEmitResolverBuilder.NativeFieldInfoPtr_ScopeIsRootScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, "ScopeIsRootScope");
			ILEmitResolverBuilder.NativeFieldInfoPtr_CallSiteRuntimeResolverResolveMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, "CallSiteRuntimeResolverResolveMethod");
			ILEmitResolverBuilder.NativeFieldInfoPtr_CallSiteRuntimeResolverInstanceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, "CallSiteRuntimeResolverInstanceField");
			ILEmitResolverBuilder.NativeFieldInfoPtr_FactoriesField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, "FactoriesField");
			ILEmitResolverBuilder.NativeFieldInfoPtr_ConstantsField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, "ConstantsField");
			ILEmitResolverBuilder.NativeFieldInfoPtr_GetTypeFromHandleMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, "GetTypeFromHandleMethod");
			ILEmitResolverBuilder.NativeFieldInfoPtr_CacheKeyCtor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, "CacheKeyCtor");
			ILEmitResolverBuilder.NativeFieldInfoPtr__rootScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, "_rootScope");
			ILEmitResolverBuilder.NativeFieldInfoPtr__scopeResolverCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, "_scopeResolverCache");
			ILEmitResolverBuilder.NativeFieldInfoPtr__buildTypeDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, "_buildTypeDelegate");
			ILEmitResolverBuilder.NativeMethodInfoPtr__ctor_Public_Void_ServiceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, 100663608);
			ILEmitResolverBuilder.NativeMethodInfoPtr_Build_Public_Func_2_ServiceProviderEngineScope_Object_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, 100663609);
			ILEmitResolverBuilder.NativeMethodInfoPtr_BuildType_Private_GeneratedMethod_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, 100663610);
			ILEmitResolverBuilder.NativeMethodInfoPtr_BuildTypeNoCache_Private_GeneratedMethod_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, 100663611);
			ILEmitResolverBuilder.NativeMethodInfoPtr_VisitDisposeCache_Protected_Virtual_Object_ServiceCallSite_ILEmitResolverBuilderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, 100663612);
			ILEmitResolverBuilder.NativeMethodInfoPtr_VisitConstructor_Protected_Virtual_Object_ConstructorCallSite_ILEmitResolverBuilderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, 100663613);
			ILEmitResolverBuilder.NativeMethodInfoPtr_VisitRootCache_Protected_Virtual_Object_ServiceCallSite_ILEmitResolverBuilderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, 100663614);
			ILEmitResolverBuilder.NativeMethodInfoPtr_VisitScopeCache_Protected_Virtual_Object_ServiceCallSite_ILEmitResolverBuilderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, 100663615);
			ILEmitResolverBuilder.NativeMethodInfoPtr_VisitConstant_Protected_Virtual_Object_ConstantCallSite_ILEmitResolverBuilderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, 100663616);
			ILEmitResolverBuilder.NativeMethodInfoPtr_VisitServiceProvider_Protected_Virtual_Object_ServiceProviderCallSite_ILEmitResolverBuilderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, 100663617);
			ILEmitResolverBuilder.NativeMethodInfoPtr_VisitIEnumerable_Protected_Virtual_Object_IEnumerableCallSite_ILEmitResolverBuilderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, 100663618);
			ILEmitResolverBuilder.NativeMethodInfoPtr_VisitFactory_Protected_Virtual_Object_FactoryCallSite_ILEmitResolverBuilderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, 100663619);
			ILEmitResolverBuilder.NativeMethodInfoPtr_AddConstant_Private_Static_Void_ILEmitResolverBuilderContext_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, 100663620);
			ILEmitResolverBuilder.NativeMethodInfoPtr_AddCacheKey_Private_Static_Void_ILEmitResolverBuilderContext_ServiceCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, 100663621);
			ILEmitResolverBuilder.NativeMethodInfoPtr_GenerateMethodBody_Private_ILEmitResolverBuilderRuntimeContext_ServiceCallSite_ILGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, 100663622);
			ILEmitResolverBuilder.NativeMethodInfoPtr_BeginCaptureDisposable_Private_Static_Void_ILEmitResolverBuilderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, 100663623);
			ILEmitResolverBuilder.NativeMethodInfoPtr_EndCaptureDisposable_Private_Static_Void_ILEmitResolverBuilderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, 100663624);
			ILEmitResolverBuilder.NativeMethodInfoPtr___ctor_b__14_0_Private_GeneratedMethod_ServiceCacheKey_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, 100663626);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000B250 File Offset: 0x00009450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205246, XrefRangeEnd = 1205265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ILEmitResolverBuilder(ServiceProvider serviceProvider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceProvider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilder.NativeMethodInfoPtr__ctor_Public_Void_ServiceProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000B29C File Offset: 0x0000949C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205265, XrefRangeEnd = 1205266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func<ServiceProviderEngineScope, Object> Build(ServiceCallSite callSite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilder.NativeMethodInfoPtr_Build_Public_Func_2_ServiceProviderEngineScope_Object_ServiceCallSite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<ServiceProviderEngineScope, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000B2EC File Offset: 0x000094EC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1205268, RefRangeEnd = 1205273, XrefRangeStart = 1205266, XrefRangeEnd = 1205268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ILEmitResolverBuilder.GeneratedMethod BuildType(ServiceCallSite callSite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilder.NativeMethodInfoPtr_BuildType_Private_GeneratedMethod_ServiceCallSite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ILEmitResolverBuilder.GeneratedMethod(intPtr);
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000B334 File Offset: 0x00009534
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1205319, RefRangeEnd = 1205321, XrefRangeStart = 1205273, XrefRangeEnd = 1205319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ILEmitResolverBuilder.GeneratedMethod BuildTypeNoCache(ServiceCallSite callSite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilder.NativeMethodInfoPtr_BuildTypeNoCache_Private_GeneratedMethod_ServiceCallSite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ILEmitResolverBuilder.GeneratedMethod(intPtr);
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000B37C File Offset: 0x0000957C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205321, XrefRangeEnd = 1205331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object VisitDisposeCache(ServiceCallSite transientCallSite, ILEmitResolverBuilderContext argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transientCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argument);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilder.NativeMethodInfoPtr_VisitDisposeCache_Protected_Virtual_Object_ServiceCallSite_ILEmitResolverBuilderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000B3E0 File Offset: 0x000095E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205331, XrefRangeEnd = 1205344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object VisitConstructor(ConstructorCallSite constructorCallSite, ILEmitResolverBuilderContext argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructorCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argument);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilder.NativeMethodInfoPtr_VisitConstructor_Protected_Virtual_Object_ConstructorCallSite_ILEmitResolverBuilderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000B444 File Offset: 0x00009644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205344, XrefRangeEnd = 1205356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object VisitRootCache(ServiceCallSite callSite, ILEmitResolverBuilderContext argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argument);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilder.NativeMethodInfoPtr_VisitRootCache_Protected_Virtual_Object_ServiceCallSite_ILEmitResolverBuilderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000B4A8 File Offset: 0x000096A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205356, XrefRangeEnd = 1205366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object VisitScopeCache(ServiceCallSite scopedCallSite, ILEmitResolverBuilderContext argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scopedCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argument);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilder.NativeMethodInfoPtr_VisitScopeCache_Protected_Virtual_Object_ServiceCallSite_ILEmitResolverBuilderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000B50C File Offset: 0x0000970C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205366, XrefRangeEnd = 1205370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object VisitConstant(ConstantCallSite constantCallSite, ILEmitResolverBuilderContext argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constantCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argument);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilder.NativeMethodInfoPtr_VisitConstant_Protected_Virtual_Object_ConstantCallSite_ILEmitResolverBuilderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000B570 File Offset: 0x00009770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205370, XrefRangeEnd = 1205374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object VisitServiceProvider(ServiceProviderCallSite serviceProviderCallSite, ILEmitResolverBuilderContext argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceProviderCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argument);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilder.NativeMethodInfoPtr_VisitServiceProvider_Protected_Virtual_Object_ServiceProviderCallSite_ILEmitResolverBuilderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000B5D4 File Offset: 0x000097D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205374, XrefRangeEnd = 1205406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object VisitIEnumerable(IEnumerableCallSite enumerableCallSite, ILEmitResolverBuilderContext argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerableCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argument);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilder.NativeMethodInfoPtr_VisitIEnumerable_Protected_Virtual_Object_IEnumerableCallSite_ILEmitResolverBuilderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000B638 File Offset: 0x00009838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205406, XrefRangeEnd = 1205442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object VisitFactory(FactoryCallSite factoryCallSite, ILEmitResolverBuilderContext argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factoryCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argument);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilder.NativeMethodInfoPtr_VisitFactory_Protected_Virtual_Object_FactoryCallSite_ILEmitResolverBuilderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000B69C File Offset: 0x0000989C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1205470, RefRangeEnd = 1205476, XrefRangeStart = 1205442, XrefRangeEnd = 1205470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddConstant(ILEmitResolverBuilderContext argument, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(argument);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilder.NativeMethodInfoPtr_AddConstant_Private_Static_Void_ILEmitResolverBuilderContext_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000B6E4 File Offset: 0x000098E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205476, XrefRangeEnd = 1205490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddCacheKey(ILEmitResolverBuilderContext argument, ServiceCacheKey key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(argument);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(key));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilder.NativeMethodInfoPtr_AddCacheKey_Private_Static_Void_ILEmitResolverBuilderContext_ServiceCacheKey_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000B734 File Offset: 0x00009934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1205612, RefRangeEnd = 1205613, XrefRangeStart = 1205490, XrefRangeEnd = 1205612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ILEmitResolverBuilder.ILEmitResolverBuilderRuntimeContext GenerateMethodBody(ServiceCallSite callSite, ILGenerator generator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilder.NativeMethodInfoPtr_GenerateMethodBody_Private_ILEmitResolverBuilderRuntimeContext_ServiceCallSite_ILGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILEmitResolverBuilder.ILEmitResolverBuilderRuntimeContext>(intPtr3) : null;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000B798 File Offset: 0x00009998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205613, XrefRangeEnd = 1205618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginCaptureDisposable(ILEmitResolverBuilderContext argument)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(argument);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilder.NativeMethodInfoPtr_BeginCaptureDisposable_Private_Static_Void_ILEmitResolverBuilderContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000B7D0 File Offset: 0x000099D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1205627, RefRangeEnd = 1205629, XrefRangeStart = 1205618, XrefRangeEnd = 1205627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndCaptureDisposable(ILEmitResolverBuilderContext argument)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(argument);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilder.NativeMethodInfoPtr_EndCaptureDisposable_Private_Static_Void_ILEmitResolverBuilderContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000B808 File Offset: 0x00009A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1205629, XrefRangeEnd = 1205630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ILEmitResolverBuilder.GeneratedMethod __ctor_b__14_0(ServiceCacheKey key, ServiceCallSite cs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(key));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilder.NativeMethodInfoPtr___ctor_b__14_0_Private_GeneratedMethod_ServiceCacheKey_ServiceCallSite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ILEmitResolverBuilder.GeneratedMethod(intPtr);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002B0A File Offset: 0x00000D0A
		public ILEmitResolverBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0000B868 File Offset: 0x00009A68
		// (set) Token: 0x060001FE RID: 510 RVA: 0x00002B13 File Offset: 0x00000D13
		public unsafe static MethodInfo ResolvedServicesGetter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ILEmitResolverBuilder.NativeFieldInfoPtr_ResolvedServicesGetter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ILEmitResolverBuilder.NativeFieldInfoPtr_ResolvedServicesGetter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000B890 File Offset: 0x00009A90
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00002B25 File Offset: 0x00000D25
		public unsafe static MethodInfo ScopeLockGetter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ILEmitResolverBuilder.NativeFieldInfoPtr_ScopeLockGetter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ILEmitResolverBuilder.NativeFieldInfoPtr_ScopeLockGetter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000B8B8 File Offset: 0x00009AB8
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00002B37 File Offset: 0x00000D37
		public unsafe static MethodInfo ScopeIsRootScope
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ILEmitResolverBuilder.NativeFieldInfoPtr_ScopeIsRootScope, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ILEmitResolverBuilder.NativeFieldInfoPtr_ScopeIsRootScope, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000B8E0 File Offset: 0x00009AE0
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00002B49 File Offset: 0x00000D49
		public unsafe static MethodInfo CallSiteRuntimeResolverResolveMethod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ILEmitResolverBuilder.NativeFieldInfoPtr_CallSiteRuntimeResolverResolveMethod, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ILEmitResolverBuilder.NativeFieldInfoPtr_CallSiteRuntimeResolverResolveMethod, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0000B908 File Offset: 0x00009B08
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00002B5B File Offset: 0x00000D5B
		public unsafe static MethodInfo CallSiteRuntimeResolverInstanceField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ILEmitResolverBuilder.NativeFieldInfoPtr_CallSiteRuntimeResolverInstanceField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ILEmitResolverBuilder.NativeFieldInfoPtr_CallSiteRuntimeResolverInstanceField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0000B930 File Offset: 0x00009B30
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00002B6D File Offset: 0x00000D6D
		public unsafe static FieldInfo FactoriesField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ILEmitResolverBuilder.NativeFieldInfoPtr_FactoriesField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ILEmitResolverBuilder.NativeFieldInfoPtr_FactoriesField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0000B958 File Offset: 0x00009B58
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00002B7F File Offset: 0x00000D7F
		public unsafe static FieldInfo ConstantsField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ILEmitResolverBuilder.NativeFieldInfoPtr_ConstantsField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ILEmitResolverBuilder.NativeFieldInfoPtr_ConstantsField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0000B980 File Offset: 0x00009B80
		// (set) Token: 0x0600020C RID: 524 RVA: 0x00002B91 File Offset: 0x00000D91
		public unsafe static MethodInfo GetTypeFromHandleMethod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ILEmitResolverBuilder.NativeFieldInfoPtr_GetTypeFromHandleMethod, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ILEmitResolverBuilder.NativeFieldInfoPtr_GetTypeFromHandleMethod, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0000B9A8 File Offset: 0x00009BA8
		// (set) Token: 0x0600020E RID: 526 RVA: 0x00002BA3 File Offset: 0x00000DA3
		public unsafe static ConstructorInfo CacheKeyCtor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ILEmitResolverBuilder.NativeFieldInfoPtr_CacheKeyCtor, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ILEmitResolverBuilder.NativeFieldInfoPtr_CacheKeyCtor, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		// (set) Token: 0x06000210 RID: 528 RVA: 0x00002BB5 File Offset: 0x00000DB5
		public unsafe ServiceProviderEngineScope _rootScope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilder.NativeFieldInfoPtr__rootScope);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceProviderEngineScope>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilder.NativeFieldInfoPtr__rootScope), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000BA00 File Offset: 0x00009C00
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00002BD4 File Offset: 0x00000DD4
		public unsafe ConcurrentDictionary<ServiceCacheKey, ILEmitResolverBuilder.GeneratedMethod> _scopeResolverCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilder.NativeFieldInfoPtr__scopeResolverCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<ServiceCacheKey, ILEmitResolverBuilder.GeneratedMethod>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilder.NativeFieldInfoPtr__scopeResolverCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0000BA30 File Offset: 0x00009C30
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00002BF3 File Offset: 0x00000DF3
		public unsafe Func<ServiceCacheKey, ServiceCallSite, ILEmitResolverBuilder.GeneratedMethod> _buildTypeDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilder.NativeFieldInfoPtr__buildTypeDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ServiceCacheKey, ServiceCallSite, ILEmitResolverBuilder.GeneratedMethod>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilder.NativeFieldInfoPtr__buildTypeDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr_ResolvedServicesGetter;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr_ScopeLockGetter;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr_ScopeIsRootScope;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr_CallSiteRuntimeResolverResolveMethod;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr_CallSiteRuntimeResolverInstanceField;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr_FactoriesField;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr_ConstantsField;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr_GetTypeFromHandleMethod;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeFieldInfoPtr_CacheKeyCtor;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeFieldInfoPtr__rootScope;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeFieldInfoPtr__scopeResolverCache;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeFieldInfoPtr__buildTypeDelegate;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServiceProvider_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Func_2_ServiceProviderEngineScope_Object_ServiceCallSite_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_BuildType_Private_GeneratedMethod_ServiceCallSite_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_BuildTypeNoCache_Private_GeneratedMethod_ServiceCallSite_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_VisitDisposeCache_Protected_Virtual_Object_ServiceCallSite_ILEmitResolverBuilderContext_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_VisitConstructor_Protected_Virtual_Object_ConstructorCallSite_ILEmitResolverBuilderContext_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_VisitRootCache_Protected_Virtual_Object_ServiceCallSite_ILEmitResolverBuilderContext_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_VisitScopeCache_Protected_Virtual_Object_ServiceCallSite_ILEmitResolverBuilderContext_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_VisitConstant_Protected_Virtual_Object_ConstantCallSite_ILEmitResolverBuilderContext_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_VisitServiceProvider_Protected_Virtual_Object_ServiceProviderCallSite_ILEmitResolverBuilderContext_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_VisitIEnumerable_Protected_Virtual_Object_IEnumerableCallSite_ILEmitResolverBuilderContext_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_VisitFactory_Protected_Virtual_Object_FactoryCallSite_ILEmitResolverBuilderContext_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_AddConstant_Private_Static_Void_ILEmitResolverBuilderContext_Object_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_AddCacheKey_Private_Static_Void_ILEmitResolverBuilderContext_ServiceCacheKey_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_GenerateMethodBody_Private_ILEmitResolverBuilderRuntimeContext_ServiceCallSite_ILGenerator_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_BeginCaptureDisposable_Private_Static_Void_ILEmitResolverBuilderContext_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_EndCaptureDisposable_Private_Static_Void_ILEmitResolverBuilderContext_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_0_Private_GeneratedMethod_ServiceCacheKey_ServiceCallSite_0;

		// Token: 0x02000047 RID: 71
		public sealed class ILEmitResolverBuilderRuntimeContext : Object
		{
			// Token: 0x060002E1 RID: 737 RVA: 0x0000E130 File Offset: 0x0000C330
			// Note: this type is marked as 'beforefieldinit'.
			static ILEmitResolverBuilderRuntimeContext()
			{
				Il2CppClassPointerStore<ILEmitResolverBuilder.ILEmitResolverBuilderRuntimeContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, "ILEmitResolverBuilderRuntimeContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ILEmitResolverBuilder.ILEmitResolverBuilderRuntimeContext>.NativeClassPtr);
				ILEmitResolverBuilder.ILEmitResolverBuilderRuntimeContext.NativeFieldInfoPtr_Constants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILEmitResolverBuilder.ILEmitResolverBuilderRuntimeContext>.NativeClassPtr, "Constants");
				ILEmitResolverBuilder.ILEmitResolverBuilderRuntimeContext.NativeFieldInfoPtr_Factories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILEmitResolverBuilder.ILEmitResolverBuilderRuntimeContext>.NativeClassPtr, "Factories");
				ILEmitResolverBuilder.ILEmitResolverBuilderRuntimeContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilder.ILEmitResolverBuilderRuntimeContext>.NativeClassPtr, 100663627);
			}

			// Token: 0x060002E2 RID: 738 RVA: 0x0000E198 File Offset: 0x0000C398
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ILEmitResolverBuilderRuntimeContext()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ILEmitResolverBuilder.ILEmitResolverBuilderRuntimeContext>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilder.ILEmitResolverBuilderRuntimeContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002E3 RID: 739 RVA: 0x000032A4 File Offset: 0x000014A4
			public ILEmitResolverBuilderRuntimeContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x060002E4 RID: 740 RVA: 0x0000E1D4 File Offset: 0x0000C3D4
			// (set) Token: 0x060002E5 RID: 741 RVA: 0x000032AD File Offset: 0x000014AD
			public unsafe Il2CppReferenceArray<Object> Constants
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilder.ILEmitResolverBuilderRuntimeContext.NativeFieldInfoPtr_Constants);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilder.ILEmitResolverBuilderRuntimeContext.NativeFieldInfoPtr_Constants), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x060002E6 RID: 742 RVA: 0x0000E204 File Offset: 0x0000C404
			// (set) Token: 0x060002E7 RID: 743 RVA: 0x000032CC File Offset: 0x000014CC
			public unsafe Il2CppReferenceArray<Func<IServiceProvider, Object>> Factories
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilder.ILEmitResolverBuilderRuntimeContext.NativeFieldInfoPtr_Factories);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Func<IServiceProvider, Object>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilder.ILEmitResolverBuilderRuntimeContext.NativeFieldInfoPtr_Factories), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001F4 RID: 500
			private static readonly IntPtr NativeFieldInfoPtr_Constants;

			// Token: 0x040001F5 RID: 501
			private static readonly IntPtr NativeFieldInfoPtr_Factories;

			// Token: 0x040001F6 RID: 502
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000048 RID: 72
		public sealed class GeneratedMethod : ValueType
		{
			// Token: 0x060002E8 RID: 744 RVA: 0x0000E234 File Offset: 0x0000C434
			// Note: this type is marked as 'beforefieldinit'.
			static GeneratedMethod()
			{
				Il2CppClassPointerStore<ILEmitResolverBuilder.GeneratedMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ILEmitResolverBuilder>.NativeClassPtr, "GeneratedMethod");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ILEmitResolverBuilder.GeneratedMethod>.NativeClassPtr);
				ILEmitResolverBuilder.GeneratedMethod.NativeFieldInfoPtr_Lambda = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILEmitResolverBuilder.GeneratedMethod>.NativeClassPtr, "Lambda");
				ILEmitResolverBuilder.GeneratedMethod.NativeFieldInfoPtr_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILEmitResolverBuilder.GeneratedMethod>.NativeClassPtr, "Context");
				ILEmitResolverBuilder.GeneratedMethod.NativeFieldInfoPtr_DynamicMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILEmitResolverBuilder.GeneratedMethod>.NativeClassPtr, "DynamicMethod");
			}

			// Token: 0x060002E9 RID: 745 RVA: 0x000032EB File Offset: 0x000014EB
			public GeneratedMethod(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060002EA RID: 746 RVA: 0x000032F4 File Offset: 0x000014F4
			public GeneratedMethod()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ILEmitResolverBuilder.GeneratedMethod>.NativeClassPtr))
			{
			}

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x060002EB RID: 747 RVA: 0x0000E29C File Offset: 0x0000C49C
			// (set) Token: 0x060002EC RID: 748 RVA: 0x00003306 File Offset: 0x00001506
			public unsafe Func<ServiceProviderEngineScope, Object> Lambda
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilder.GeneratedMethod.NativeFieldInfoPtr_Lambda);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ServiceProviderEngineScope, Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilder.GeneratedMethod.NativeFieldInfoPtr_Lambda), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x060002ED RID: 749 RVA: 0x0000E2CC File Offset: 0x0000C4CC
			// (set) Token: 0x060002EE RID: 750 RVA: 0x00003325 File Offset: 0x00001525
			public unsafe ILEmitResolverBuilder.ILEmitResolverBuilderRuntimeContext Context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilder.GeneratedMethod.NativeFieldInfoPtr_Context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILEmitResolverBuilder.ILEmitResolverBuilderRuntimeContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilder.GeneratedMethod.NativeFieldInfoPtr_Context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x060002EF RID: 751 RVA: 0x0000E2FC File Offset: 0x0000C4FC
			// (set) Token: 0x060002F0 RID: 752 RVA: 0x00003344 File Offset: 0x00001544
			public unsafe DynamicMethod DynamicMethod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilder.GeneratedMethod.NativeFieldInfoPtr_DynamicMethod);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilder.GeneratedMethod.NativeFieldInfoPtr_DynamicMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001F7 RID: 503
			private static readonly IntPtr NativeFieldInfoPtr_Lambda;

			// Token: 0x040001F8 RID: 504
			private static readonly IntPtr NativeFieldInfoPtr_Context;

			// Token: 0x040001F9 RID: 505
			private static readonly IntPtr NativeFieldInfoPtr_DynamicMethod;
		}
	}
}
