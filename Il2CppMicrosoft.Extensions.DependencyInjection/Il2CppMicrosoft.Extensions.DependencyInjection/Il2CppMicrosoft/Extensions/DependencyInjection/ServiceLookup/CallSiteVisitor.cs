using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x0200001A RID: 26
	public class CallSiteVisitor<TArgument, TResult> : Object
	{
		// Token: 0x06000100 RID: 256 RVA: 0x000075F4 File Offset: 0x000057F4
		// Note: this type is marked as 'beforefieldinit'.
		static CallSiteVisitor()
		{
			Il2CppClassPointerStore<CallSiteVisitor<TArgument, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "CallSiteVisitor`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArgument>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallSiteVisitor<TArgument, TResult>>.NativeClassPtr);
			CallSiteVisitor<TArgument, TResult>.NativeFieldInfoPtr__stackGuard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteVisitor<TArgument, TResult>>.NativeClassPtr, "_stackGuard");
			CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteVisitor<TArgument, TResult>>.NativeClassPtr, 100663484);
			CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitCallSite_Protected_Virtual_New_TResult_ServiceCallSite_TArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteVisitor<TArgument, TResult>>.NativeClassPtr, 100663485);
			CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitCallSiteMain_Protected_Virtual_New_TResult_ServiceCallSite_TArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteVisitor<TArgument, TResult>>.NativeClassPtr, 100663486);
			CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitNoCache_Protected_Virtual_New_TResult_ServiceCallSite_TArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteVisitor<TArgument, TResult>>.NativeClassPtr, 100663487);
			CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitDisposeCache_Protected_Virtual_New_TResult_ServiceCallSite_TArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteVisitor<TArgument, TResult>>.NativeClassPtr, 100663488);
			CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitRootCache_Protected_Virtual_New_TResult_ServiceCallSite_TArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteVisitor<TArgument, TResult>>.NativeClassPtr, 100663489);
			CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitScopeCache_Protected_Virtual_New_TResult_ServiceCallSite_TArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteVisitor<TArgument, TResult>>.NativeClassPtr, 100663490);
			CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitConstructor_Protected_Abstract_Virtual_New_TResult_ConstructorCallSite_TArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteVisitor<TArgument, TResult>>.NativeClassPtr, 100663491);
			CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitConstant_Protected_Abstract_Virtual_New_TResult_ConstantCallSite_TArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteVisitor<TArgument, TResult>>.NativeClassPtr, 100663492);
			CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitServiceProvider_Protected_Abstract_Virtual_New_TResult_ServiceProviderCallSite_TArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteVisitor<TArgument, TResult>>.NativeClassPtr, 100663493);
			CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitIEnumerable_Protected_Abstract_Virtual_New_TResult_IEnumerableCallSite_TArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteVisitor<TArgument, TResult>>.NativeClassPtr, 100663494);
			CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitFactory_Protected_Abstract_Virtual_New_TResult_FactoryCallSite_TArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteVisitor<TArgument, TResult>>.NativeClassPtr, 100663495);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00007778 File Offset: 0x00005978
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1204482, RefRangeEnd = 1204487, XrefRangeStart = 1204470, XrefRangeEnd = 1204482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallSiteVisitor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSiteVisitor<TArgument, TResult>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000077B4 File Offset: 0x000059B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204487, XrefRangeEnd = 1204488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TResult VisitCallSite(ServiceCallSite callSite, TArgument argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TArgument).IsValueType)
			{
				TArgument targument = argument;
				intPtr = ((targument is string) ? IL2CPP.ManagedStringToIl2Cpp(targument as string) : IL2CPP.Il2CppObjectBaseToPtr(targument as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref argument;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitCallSite_Protected_Virtual_New_TResult_ServiceCallSite_TArgument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00007854 File Offset: 0x00005A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204488, XrefRangeEnd = 1204524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TResult VisitCallSiteMain(ServiceCallSite callSite, TArgument argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TArgument).IsValueType)
			{
				TArgument targument = argument;
				intPtr = ((targument is string) ? IL2CPP.ManagedStringToIl2Cpp(targument as string) : IL2CPP.Il2CppObjectBaseToPtr(targument as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref argument;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitCallSiteMain_Protected_Virtual_New_TResult_ServiceCallSite_TArgument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000078F4 File Offset: 0x00005AF4
		[CallerCount(0)]
		public unsafe virtual TResult VisitNoCache(ServiceCallSite callSite, TArgument argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TArgument).IsValueType)
			{
				TArgument targument = argument;
				intPtr = ((targument is string) ? IL2CPP.ManagedStringToIl2Cpp(targument as string) : IL2CPP.Il2CppObjectBaseToPtr(targument as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref argument;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitNoCache_Protected_Virtual_New_TResult_ServiceCallSite_TArgument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00007994 File Offset: 0x00005B94
		[CallerCount(0)]
		public unsafe virtual TResult VisitDisposeCache(ServiceCallSite callSite, TArgument argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TArgument).IsValueType)
			{
				TArgument targument = argument;
				intPtr = ((targument is string) ? IL2CPP.ManagedStringToIl2Cpp(targument as string) : IL2CPP.Il2CppObjectBaseToPtr(targument as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref argument;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitDisposeCache_Protected_Virtual_New_TResult_ServiceCallSite_TArgument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00007A34 File Offset: 0x00005C34
		[CallerCount(0)]
		public unsafe virtual TResult VisitRootCache(ServiceCallSite callSite, TArgument argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TArgument).IsValueType)
			{
				TArgument targument = argument;
				intPtr = ((targument is string) ? IL2CPP.ManagedStringToIl2Cpp(targument as string) : IL2CPP.Il2CppObjectBaseToPtr(targument as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref argument;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitRootCache_Protected_Virtual_New_TResult_ServiceCallSite_TArgument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00007AD4 File Offset: 0x00005CD4
		[CallerCount(0)]
		public unsafe virtual TResult VisitScopeCache(ServiceCallSite callSite, TArgument argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TArgument).IsValueType)
			{
				TArgument targument = argument;
				intPtr = ((targument is string) ? IL2CPP.ManagedStringToIl2Cpp(targument as string) : IL2CPP.Il2CppObjectBaseToPtr(targument as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref argument;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitScopeCache_Protected_Virtual_New_TResult_ServiceCallSite_TArgument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00007B74 File Offset: 0x00005D74
		[CallerCount(0)]
		public unsafe virtual TResult VisitConstructor(ConstructorCallSite constructorCallSite, TArgument argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructorCallSite);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TArgument).IsValueType)
			{
				TArgument targument = argument;
				intPtr = ((targument is string) ? IL2CPP.ManagedStringToIl2Cpp(targument as string) : IL2CPP.Il2CppObjectBaseToPtr(targument as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref argument;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitConstructor_Protected_Abstract_Virtual_New_TResult_ConstructorCallSite_TArgument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00007C14 File Offset: 0x00005E14
		[CallerCount(0)]
		public unsafe virtual TResult VisitConstant(ConstantCallSite constantCallSite, TArgument argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constantCallSite);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TArgument).IsValueType)
			{
				TArgument targument = argument;
				intPtr = ((targument is string) ? IL2CPP.ManagedStringToIl2Cpp(targument as string) : IL2CPP.Il2CppObjectBaseToPtr(targument as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref argument;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitConstant_Protected_Abstract_Virtual_New_TResult_ConstantCallSite_TArgument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00007CB4 File Offset: 0x00005EB4
		[CallerCount(0)]
		public unsafe virtual TResult VisitServiceProvider(ServiceProviderCallSite serviceProviderCallSite, TArgument argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceProviderCallSite);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TArgument).IsValueType)
			{
				TArgument targument = argument;
				intPtr = ((targument is string) ? IL2CPP.ManagedStringToIl2Cpp(targument as string) : IL2CPP.Il2CppObjectBaseToPtr(targument as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref argument;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitServiceProvider_Protected_Abstract_Virtual_New_TResult_ServiceProviderCallSite_TArgument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00007D54 File Offset: 0x00005F54
		[CallerCount(0)]
		public unsafe virtual TResult VisitIEnumerable(IEnumerableCallSite enumerableCallSite, TArgument argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerableCallSite);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TArgument).IsValueType)
			{
				TArgument targument = argument;
				intPtr = ((targument is string) ? IL2CPP.ManagedStringToIl2Cpp(targument as string) : IL2CPP.Il2CppObjectBaseToPtr(targument as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref argument;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitIEnumerable_Protected_Abstract_Virtual_New_TResult_IEnumerableCallSite_TArgument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00007DF4 File Offset: 0x00005FF4
		[CallerCount(0)]
		public unsafe virtual TResult VisitFactory(FactoryCallSite factoryCallSite, TArgument argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factoryCallSite);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TArgument).IsValueType)
			{
				TArgument targument = argument;
				intPtr = ((targument is string) ? IL2CPP.ManagedStringToIl2Cpp(targument as string) : IL2CPP.Il2CppObjectBaseToPtr(targument as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref argument;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallSiteVisitor<TArgument, TResult>.NativeMethodInfoPtr_VisitFactory_Protected_Abstract_Virtual_New_TResult_FactoryCallSite_TArgument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000254A File Offset: 0x0000074A
		public CallSiteVisitor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00007E94 File Offset: 0x00006094
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00002553 File Offset: 0x00000753
		public unsafe StackGuard _stackGuard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteVisitor<TArgument, TResult>.NativeFieldInfoPtr__stackGuard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StackGuard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteVisitor<TArgument, TResult>.NativeFieldInfoPtr__stackGuard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr__stackGuard;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_VisitCallSite_Protected_Virtual_New_TResult_ServiceCallSite_TArgument_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_VisitCallSiteMain_Protected_Virtual_New_TResult_ServiceCallSite_TArgument_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_VisitNoCache_Protected_Virtual_New_TResult_ServiceCallSite_TArgument_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_VisitDisposeCache_Protected_Virtual_New_TResult_ServiceCallSite_TArgument_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_VisitRootCache_Protected_Virtual_New_TResult_ServiceCallSite_TArgument_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_VisitScopeCache_Protected_Virtual_New_TResult_ServiceCallSite_TArgument_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_VisitConstructor_Protected_Abstract_Virtual_New_TResult_ConstructorCallSite_TArgument_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_VisitConstant_Protected_Abstract_Virtual_New_TResult_ConstantCallSite_TArgument_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_VisitServiceProvider_Protected_Abstract_Virtual_New_TResult_ServiceProviderCallSite_TArgument_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_VisitIEnumerable_Protected_Abstract_Virtual_New_TResult_IEnumerableCallSite_TArgument_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_VisitFactory_Protected_Abstract_Virtual_New_TResult_FactoryCallSite_TArgument_0;
	}
}
