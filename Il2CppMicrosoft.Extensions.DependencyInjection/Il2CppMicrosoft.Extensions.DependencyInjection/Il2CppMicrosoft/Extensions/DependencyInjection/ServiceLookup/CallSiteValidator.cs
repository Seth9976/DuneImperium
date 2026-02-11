using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x02000019 RID: 25
	public sealed class CallSiteValidator : CallSiteVisitor<CallSiteValidator.CallSiteValidatorState, Type>
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x000070F8 File Offset: 0x000052F8
		// Note: this type is marked as 'beforefieldinit'.
		static CallSiteValidator()
		{
			Il2CppClassPointerStore<CallSiteValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "CallSiteValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallSiteValidator>.NativeClassPtr);
			CallSiteValidator.NativeFieldInfoPtr__scopedServices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteValidator>.NativeClassPtr, "_scopedServices");
			CallSiteValidator.NativeMethodInfoPtr_ValidateCallSite_Public_Void_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteValidator>.NativeClassPtr, 100663472);
			CallSiteValidator.NativeMethodInfoPtr_ValidateResolution_Public_Void_ServiceCallSite_IServiceScope_IServiceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteValidator>.NativeClassPtr, 100663473);
			CallSiteValidator.NativeMethodInfoPtr_VisitConstructor_Protected_Virtual_Type_ConstructorCallSite_CallSiteValidatorState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteValidator>.NativeClassPtr, 100663474);
			CallSiteValidator.NativeMethodInfoPtr_VisitIEnumerable_Protected_Virtual_Type_IEnumerableCallSite_CallSiteValidatorState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteValidator>.NativeClassPtr, 100663475);
			CallSiteValidator.NativeMethodInfoPtr_VisitRootCache_Protected_Virtual_Type_ServiceCallSite_CallSiteValidatorState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteValidator>.NativeClassPtr, 100663476);
			CallSiteValidator.NativeMethodInfoPtr_VisitScopeCache_Protected_Virtual_Type_ServiceCallSite_CallSiteValidatorState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteValidator>.NativeClassPtr, 100663477);
			CallSiteValidator.NativeMethodInfoPtr_VisitConstant_Protected_Virtual_Type_ConstantCallSite_CallSiteValidatorState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteValidator>.NativeClassPtr, 100663478);
			CallSiteValidator.NativeMethodInfoPtr_VisitServiceProvider_Protected_Virtual_Type_ServiceProviderCallSite_CallSiteValidatorState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteValidator>.NativeClassPtr, 100663479);
			CallSiteValidator.NativeMethodInfoPtr_VisitFactory_Protected_Virtual_Type_FactoryCallSite_CallSiteValidatorState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteValidator>.NativeClassPtr, 100663480);
			CallSiteValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteValidator>.NativeClassPtr, 100663481);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00007204 File Offset: 0x00005404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204435, XrefRangeEnd = 1204442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateCallSite(ServiceCallSite callSite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteValidator.NativeMethodInfoPtr_ValidateCallSite_Public_Void_ServiceCallSite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00007248 File Offset: 0x00005448
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1204449, RefRangeEnd = 1204451, XrefRangeStart = 1204442, XrefRangeEnd = 1204449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateResolution(ServiceCallSite callSite, IServiceScope scope, IServiceScope rootScope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scope);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rootScope);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteValidator.NativeMethodInfoPtr_ValidateResolution_Public_Void_ServiceCallSite_IServiceScope_IServiceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000072B0 File Offset: 0x000054B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204451, XrefRangeEnd = 1204452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type VisitConstructor(ConstructorCallSite constructorCallSite, CallSiteValidator.CallSiteValidatorState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructorCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteValidator.NativeMethodInfoPtr_VisitConstructor_Protected_Virtual_Type_ConstructorCallSite_CallSiteValidatorState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00007318 File Offset: 0x00005518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type VisitIEnumerable(IEnumerableCallSite enumerableCallSite, CallSiteValidator.CallSiteValidatorState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerableCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteValidator.NativeMethodInfoPtr_VisitIEnumerable_Protected_Virtual_Type_IEnumerableCallSite_CallSiteValidatorState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00007380 File Offset: 0x00005580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204452, XrefRangeEnd = 1204453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type VisitRootCache(ServiceCallSite singletonCallSite, CallSiteValidator.CallSiteValidatorState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(singletonCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteValidator.NativeMethodInfoPtr_VisitRootCache_Protected_Virtual_Type_ServiceCallSite_CallSiteValidatorState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000073E8 File Offset: 0x000055E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204453, XrefRangeEnd = 1204460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type VisitScopeCache(ServiceCallSite scopedCallSite, CallSiteValidator.CallSiteValidatorState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scopedCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteValidator.NativeMethodInfoPtr_VisitScopeCache_Protected_Virtual_Type_ServiceCallSite_CallSiteValidatorState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00007450 File Offset: 0x00005650
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type VisitConstant(ConstantCallSite constantCallSite, CallSiteValidator.CallSiteValidatorState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constantCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteValidator.NativeMethodInfoPtr_VisitConstant_Protected_Virtual_Type_ConstantCallSite_CallSiteValidatorState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000074B8 File Offset: 0x000056B8
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type VisitServiceProvider(ServiceProviderCallSite serviceProviderCallSite, CallSiteValidator.CallSiteValidatorState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceProviderCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteValidator.NativeMethodInfoPtr_VisitServiceProvider_Protected_Virtual_Type_ServiceProviderCallSite_CallSiteValidatorState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00007520 File Offset: 0x00005720
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type VisitFactory(FactoryCallSite factoryCallSite, CallSiteValidator.CallSiteValidatorState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factoryCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteValidator.NativeMethodInfoPtr_VisitFactory_Protected_Virtual_Type_FactoryCallSite_CallSiteValidatorState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00007588 File Offset: 0x00005788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204460, XrefRangeEnd = 1204470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallSiteValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSiteValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002522 File Offset: 0x00000722
		public CallSiteValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000FE RID: 254 RVA: 0x000075C4 File Offset: 0x000057C4
		// (set) Token: 0x060000FF RID: 255 RVA: 0x0000252B File Offset: 0x0000072B
		public unsafe ConcurrentDictionary<ServiceCacheKey, Type> _scopedServices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteValidator.NativeFieldInfoPtr__scopedServices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<ServiceCacheKey, Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteValidator.NativeFieldInfoPtr__scopedServices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeFieldInfoPtr__scopedServices;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCallSite_Public_Void_ServiceCallSite_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_ValidateResolution_Public_Void_ServiceCallSite_IServiceScope_IServiceScope_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_VisitConstructor_Protected_Virtual_Type_ConstructorCallSite_CallSiteValidatorState_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_VisitIEnumerable_Protected_Virtual_Type_IEnumerableCallSite_CallSiteValidatorState_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_VisitRootCache_Protected_Virtual_Type_ServiceCallSite_CallSiteValidatorState_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_VisitScopeCache_Protected_Virtual_Type_ServiceCallSite_CallSiteValidatorState_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_VisitConstant_Protected_Virtual_Type_ConstantCallSite_CallSiteValidatorState_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_VisitServiceProvider_Protected_Virtual_Type_ServiceProviderCallSite_CallSiteValidatorState_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_VisitFactory_Protected_Virtual_Type_FactoryCallSite_CallSiteValidatorState_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200003D RID: 61
		public sealed class CallSiteValidatorState : ValueType
		{
			// Token: 0x0600029C RID: 668 RVA: 0x0000D550 File Offset: 0x0000B750
			// Note: this type is marked as 'beforefieldinit'.
			static CallSiteValidatorState()
			{
				Il2CppClassPointerStore<CallSiteValidator.CallSiteValidatorState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallSiteValidator>.NativeClassPtr, "CallSiteValidatorState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallSiteValidator.CallSiteValidatorState>.NativeClassPtr);
				CallSiteValidator.CallSiteValidatorState.NativeFieldInfoPtr__Singleton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteValidator.CallSiteValidatorState>.NativeClassPtr, "<Singleton>k__BackingField");
				CallSiteValidator.CallSiteValidatorState.NativeMethodInfoPtr_get_Singleton_Public_get_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteValidator.CallSiteValidatorState>.NativeClassPtr, 100663482);
				CallSiteValidator.CallSiteValidatorState.NativeMethodInfoPtr_set_Singleton_Public_set_Void_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteValidator.CallSiteValidatorState>.NativeClassPtr, 100663483);
			}

			// Token: 0x170000CE RID: 206
			// (get) Token: 0x0600029D RID: 669 RVA: 0x0000D5B8 File Offset: 0x0000B7B8
			// (set) Token: 0x0600029E RID: 670 RVA: 0x0000D5FC File Offset: 0x0000B7FC
			public unsafe ServiceCallSite Singleton
			{
				[CallerCount(99)]
				[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteValidator.CallSiteValidatorState.NativeMethodInfoPtr_get_Singleton_Public_get_ServiceCallSite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceCallSite>(intPtr3) : null;
				}
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteValidator.CallSiteValidatorState.NativeMethodInfoPtr_set_Singleton_Public_set_Void_ServiceCallSite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600029F RID: 671 RVA: 0x00003002 File Offset: 0x00001202
			public CallSiteValidatorState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060002A0 RID: 672 RVA: 0x0000300B File Offset: 0x0000120B
			public CallSiteValidatorState()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSiteValidator.CallSiteValidatorState>.NativeClassPtr))
			{
			}

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x060002A1 RID: 673 RVA: 0x0000D644 File Offset: 0x0000B844
			// (set) Token: 0x060002A2 RID: 674 RVA: 0x0000301D File Offset: 0x0000121D
			public unsafe ServiceCallSite _Singleton_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteValidator.CallSiteValidatorState.NativeFieldInfoPtr__Singleton_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceCallSite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteValidator.CallSiteValidatorState.NativeFieldInfoPtr__Singleton_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001D2 RID: 466
			private static readonly IntPtr NativeFieldInfoPtr__Singleton_k__BackingField;

			// Token: 0x040001D3 RID: 467
			private static readonly IntPtr NativeMethodInfoPtr_get_Singleton_Public_get_ServiceCallSite_0;

			// Token: 0x040001D4 RID: 468
			private static readonly IntPtr NativeMethodInfoPtr_set_Singleton_Public_set_Void_ServiceCallSite_0;
		}
	}
}
