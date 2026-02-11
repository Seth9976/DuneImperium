using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x02000016 RID: 22
	public sealed class CallSiteRuntimeResolver : CallSiteVisitor<RuntimeResolverContext, Object>
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x00006884 File Offset: 0x00004A84
		// Note: this type is marked as 'beforefieldinit'.
		static CallSiteRuntimeResolver()
		{
			Il2CppClassPointerStore<CallSiteRuntimeResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "CallSiteRuntimeResolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallSiteRuntimeResolver>.NativeClassPtr);
			CallSiteRuntimeResolver.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteRuntimeResolver>.NativeClassPtr, "<Instance>k__BackingField");
			CallSiteRuntimeResolver.NativeMethodInfoPtr_get_Instance_Public_Static_get_CallSiteRuntimeResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteRuntimeResolver>.NativeClassPtr, 100663454);
			CallSiteRuntimeResolver.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteRuntimeResolver>.NativeClassPtr, 100663455);
			CallSiteRuntimeResolver.NativeMethodInfoPtr_Resolve_Public_Object_ServiceCallSite_ServiceProviderEngineScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteRuntimeResolver>.NativeClassPtr, 100663456);
			CallSiteRuntimeResolver.NativeMethodInfoPtr_VisitDisposeCache_Protected_Virtual_Object_ServiceCallSite_RuntimeResolverContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteRuntimeResolver>.NativeClassPtr, 100663457);
			CallSiteRuntimeResolver.NativeMethodInfoPtr_VisitConstructor_Protected_Virtual_Object_ConstructorCallSite_RuntimeResolverContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteRuntimeResolver>.NativeClassPtr, 100663458);
			CallSiteRuntimeResolver.NativeMethodInfoPtr_VisitRootCache_Protected_Virtual_Object_ServiceCallSite_RuntimeResolverContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteRuntimeResolver>.NativeClassPtr, 100663459);
			CallSiteRuntimeResolver.NativeMethodInfoPtr_VisitScopeCache_Protected_Virtual_Object_ServiceCallSite_RuntimeResolverContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteRuntimeResolver>.NativeClassPtr, 100663460);
			CallSiteRuntimeResolver.NativeMethodInfoPtr_VisitCache_Private_Object_ServiceCallSite_RuntimeResolverContext_ServiceProviderEngineScope_RuntimeResolverLock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteRuntimeResolver>.NativeClassPtr, 100663461);
			CallSiteRuntimeResolver.NativeMethodInfoPtr_VisitConstant_Protected_Virtual_Object_ConstantCallSite_RuntimeResolverContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteRuntimeResolver>.NativeClassPtr, 100663462);
			CallSiteRuntimeResolver.NativeMethodInfoPtr_VisitServiceProvider_Protected_Virtual_Object_ServiceProviderCallSite_RuntimeResolverContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteRuntimeResolver>.NativeClassPtr, 100663463);
			CallSiteRuntimeResolver.NativeMethodInfoPtr_VisitIEnumerable_Protected_Virtual_Object_IEnumerableCallSite_RuntimeResolverContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteRuntimeResolver>.NativeClassPtr, 100663464);
			CallSiteRuntimeResolver.NativeMethodInfoPtr_VisitFactory_Protected_Virtual_Object_FactoryCallSite_RuntimeResolverContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteRuntimeResolver>.NativeClassPtr, 100663465);
			CallSiteRuntimeResolver.NativeMethodInfoPtr_Method_Internal_Static_Array_Type_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteRuntimeResolver>.NativeClassPtr, 100663467);
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000069CC File Offset: 0x00004BCC
		public unsafe static CallSiteRuntimeResolver Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204385, XrefRangeEnd = 1204389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteRuntimeResolver.NativeMethodInfoPtr_get_Instance_Public_Static_get_CallSiteRuntimeResolver_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallSiteRuntimeResolver>(intPtr3) : null;
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00006A00 File Offset: 0x00004C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204389, XrefRangeEnd = 1204392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallSiteRuntimeResolver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSiteRuntimeResolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteRuntimeResolver.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00006A3C File Offset: 0x00004C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204392, XrefRangeEnd = 1204393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Resolve(ServiceCallSite callSite, ServiceProviderEngineScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scope);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteRuntimeResolver.NativeMethodInfoPtr_Resolve_Public_Object_ServiceCallSite_ServiceProviderEngineScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00006AA0 File Offset: 0x00004CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204393, XrefRangeEnd = 1204395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object VisitDisposeCache(ServiceCallSite transientCallSite, RuntimeResolverContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transientCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteRuntimeResolver.NativeMethodInfoPtr_VisitDisposeCache_Protected_Virtual_Object_ServiceCallSite_RuntimeResolverContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00006B08 File Offset: 0x00004D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204395, XrefRangeEnd = 1204404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object VisitConstructor(ConstructorCallSite constructorCallSite, RuntimeResolverContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructorCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteRuntimeResolver.NativeMethodInfoPtr_VisitConstructor_Protected_Virtual_Object_ConstructorCallSite_RuntimeResolverContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00006B70 File Offset: 0x00004D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204404, XrefRangeEnd = 1204413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object VisitRootCache(ServiceCallSite callSite, RuntimeResolverContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteRuntimeResolver.NativeMethodInfoPtr_VisitRootCache_Protected_Virtual_Object_ServiceCallSite_RuntimeResolverContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00006BD8 File Offset: 0x00004DD8
		[CallerCount(0)]
		public unsafe override Object VisitScopeCache(ServiceCallSite callSite, RuntimeResolverContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteRuntimeResolver.NativeMethodInfoPtr_VisitScopeCache_Protected_Virtual_Object_ServiceCallSite_RuntimeResolverContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00006C40 File Offset: 0x00004E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204413, XrefRangeEnd = 1204427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object VisitCache(ServiceCallSite callSite, RuntimeResolverContext context, ServiceProviderEngineScope serviceProviderEngine, RuntimeResolverLock lockType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceProviderEngine);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteRuntimeResolver.NativeMethodInfoPtr_VisitCache_Private_Object_ServiceCallSite_RuntimeResolverContext_ServiceProviderEngineScope_RuntimeResolverLock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00006CC8 File Offset: 0x00004EC8
		[CallerCount(0)]
		public unsafe override Object VisitConstant(ConstantCallSite constantCallSite, RuntimeResolverContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constantCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteRuntimeResolver.NativeMethodInfoPtr_VisitConstant_Protected_Virtual_Object_ConstantCallSite_RuntimeResolverContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00006D30 File Offset: 0x00004F30
		[CallerCount(0)]
		public unsafe override Object VisitServiceProvider(ServiceProviderCallSite serviceProviderCallSite, RuntimeResolverContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceProviderCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteRuntimeResolver.NativeMethodInfoPtr_VisitServiceProvider_Protected_Virtual_Object_ServiceProviderCallSite_RuntimeResolverContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00006D98 File Offset: 0x00004F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204427, XrefRangeEnd = 1204433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object VisitIEnumerable(IEnumerableCallSite enumerableCallSite, RuntimeResolverContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerableCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteRuntimeResolver.NativeMethodInfoPtr_VisitIEnumerable_Protected_Virtual_Object_IEnumerableCallSite_RuntimeResolverContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00006E00 File Offset: 0x00005000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204433, XrefRangeEnd = 1204434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object VisitFactory(FactoryCallSite factoryCallSite, RuntimeResolverContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factoryCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteRuntimeResolver.NativeMethodInfoPtr_VisitFactory_Protected_Virtual_Object_FactoryCallSite_RuntimeResolverContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00006E68 File Offset: 0x00005068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204434, XrefRangeEnd = 1204435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array Method_Internal_Static_Array_Type_Int32_PDM_0(Type elementType, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteRuntimeResolver.NativeMethodInfoPtr_Method_Internal_Static_Array_Type_Int32_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000024B2 File Offset: 0x000006B2
		public CallSiteRuntimeResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00006EBC File Offset: 0x000050BC
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x000024BB File Offset: 0x000006BB
		public unsafe static CallSiteRuntimeResolver _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CallSiteRuntimeResolver.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallSiteRuntimeResolver>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallSiteRuntimeResolver.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_CallSiteRuntimeResolver_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Object_ServiceCallSite_ServiceProviderEngineScope_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_VisitDisposeCache_Protected_Virtual_Object_ServiceCallSite_RuntimeResolverContext_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_VisitConstructor_Protected_Virtual_Object_ConstructorCallSite_RuntimeResolverContext_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_VisitRootCache_Protected_Virtual_Object_ServiceCallSite_RuntimeResolverContext_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_VisitScopeCache_Protected_Virtual_Object_ServiceCallSite_RuntimeResolverContext_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_VisitCache_Private_Object_ServiceCallSite_RuntimeResolverContext_ServiceProviderEngineScope_RuntimeResolverLock_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_VisitConstant_Protected_Virtual_Object_ConstantCallSite_RuntimeResolverContext_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_VisitServiceProvider_Protected_Virtual_Object_ServiceProviderCallSite_RuntimeResolverContext_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_VisitIEnumerable_Protected_Virtual_Object_IEnumerableCallSite_RuntimeResolverContext_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_VisitFactory_Protected_Virtual_Object_FactoryCallSite_RuntimeResolverContext_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Array_Type_Int32_PDM_0;
	}
}
