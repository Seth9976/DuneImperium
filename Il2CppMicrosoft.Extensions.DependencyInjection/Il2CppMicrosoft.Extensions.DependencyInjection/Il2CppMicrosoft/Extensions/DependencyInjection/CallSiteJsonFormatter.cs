using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace Il2CppMicrosoft.Extensions.DependencyInjection
{
	// Token: 0x0200000D RID: 13
	public sealed class CallSiteJsonFormatter : CallSiteVisitor<CallSiteJsonFormatter.CallSiteFormatterContext, Object>
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00004348 File Offset: 0x00002548
		// Note: this type is marked as 'beforefieldinit'.
		static CallSiteJsonFormatter()
		{
			Il2CppClassPointerStore<CallSiteJsonFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection", "CallSiteJsonFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallSiteJsonFormatter>.NativeClassPtr);
			CallSiteJsonFormatter.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteJsonFormatter>.NativeClassPtr, "Instance");
			CallSiteJsonFormatter.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteJsonFormatter>.NativeClassPtr, 100663337);
			CallSiteJsonFormatter.NativeMethodInfoPtr_Format_Public_String_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteJsonFormatter>.NativeClassPtr, 100663338);
			CallSiteJsonFormatter.NativeMethodInfoPtr_VisitConstructor_Protected_Virtual_Object_ConstructorCallSite_CallSiteFormatterContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteJsonFormatter>.NativeClassPtr, 100663339);
			CallSiteJsonFormatter.NativeMethodInfoPtr_VisitCallSiteMain_Protected_Virtual_Object_ServiceCallSite_CallSiteFormatterContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteJsonFormatter>.NativeClassPtr, 100663340);
			CallSiteJsonFormatter.NativeMethodInfoPtr_VisitConstant_Protected_Virtual_Object_ConstantCallSite_CallSiteFormatterContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteJsonFormatter>.NativeClassPtr, 100663341);
			CallSiteJsonFormatter.NativeMethodInfoPtr_VisitServiceProvider_Protected_Virtual_Object_ServiceProviderCallSite_CallSiteFormatterContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteJsonFormatter>.NativeClassPtr, 100663342);
			CallSiteJsonFormatter.NativeMethodInfoPtr_VisitIEnumerable_Protected_Virtual_Object_IEnumerableCallSite_CallSiteFormatterContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteJsonFormatter>.NativeClassPtr, 100663343);
			CallSiteJsonFormatter.NativeMethodInfoPtr_VisitFactory_Protected_Virtual_Object_FactoryCallSite_CallSiteFormatterContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteJsonFormatter>.NativeClassPtr, 100663344);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000442C File Offset: 0x0000262C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203029, XrefRangeEnd = 1203032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallSiteJsonFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSiteJsonFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteJsonFormatter.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004468 File Offset: 0x00002668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203032, XrefRangeEnd = 1203044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Format(ServiceCallSite callSite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteJsonFormatter.NativeMethodInfoPtr_Format_Public_String_ServiceCallSite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000044B0 File Offset: 0x000026B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203044, XrefRangeEnd = 1203055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object VisitConstructor(ConstructorCallSite constructorCallSite, CallSiteJsonFormatter.CallSiteFormatterContext argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructorCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(argument));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteJsonFormatter.NativeMethodInfoPtr_VisitConstructor_Protected_Virtual_Object_ConstructorCallSite_CallSiteFormatterContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004518 File Offset: 0x00002718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203055, XrefRangeEnd = 1203140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object VisitCallSiteMain(ServiceCallSite callSite, CallSiteJsonFormatter.CallSiteFormatterContext argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(argument));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteJsonFormatter.NativeMethodInfoPtr_VisitCallSiteMain_Protected_Virtual_Object_ServiceCallSite_CallSiteFormatterContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004580 File Offset: 0x00002780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203140, XrefRangeEnd = 1203145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object VisitConstant(ConstantCallSite constantCallSite, CallSiteJsonFormatter.CallSiteFormatterContext argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constantCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(argument));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteJsonFormatter.NativeMethodInfoPtr_VisitConstant_Protected_Virtual_Object_ConstantCallSite_CallSiteFormatterContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000045E8 File Offset: 0x000027E8
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object VisitServiceProvider(ServiceProviderCallSite serviceProviderCallSite, CallSiteJsonFormatter.CallSiteFormatterContext argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceProviderCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(argument));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteJsonFormatter.NativeMethodInfoPtr_VisitServiceProvider_Protected_Virtual_Object_ServiceProviderCallSite_CallSiteFormatterContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004650 File Offset: 0x00002850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203145, XrefRangeEnd = 1203162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object VisitIEnumerable(IEnumerableCallSite enumerableCallSite, CallSiteJsonFormatter.CallSiteFormatterContext argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerableCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(argument));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteJsonFormatter.NativeMethodInfoPtr_VisitIEnumerable_Protected_Virtual_Object_IEnumerableCallSite_CallSiteFormatterContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000046B8 File Offset: 0x000028B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203162, XrefRangeEnd = 1203166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object VisitFactory(FactoryCallSite factoryCallSite, CallSiteJsonFormatter.CallSiteFormatterContext argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factoryCallSite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(argument));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteJsonFormatter.NativeMethodInfoPtr_VisitFactory_Protected_Virtual_Object_FactoryCallSite_CallSiteFormatterContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000223D File Offset: 0x0000043D
		public CallSiteJsonFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00004720 File Offset: 0x00002920
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002246 File Offset: 0x00000446
		public unsafe static CallSiteJsonFormatter Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CallSiteJsonFormatter.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallSiteJsonFormatter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallSiteJsonFormatter.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_String_ServiceCallSite_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_VisitConstructor_Protected_Virtual_Object_ConstructorCallSite_CallSiteFormatterContext_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_VisitCallSiteMain_Protected_Virtual_Object_ServiceCallSite_CallSiteFormatterContext_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_VisitConstant_Protected_Virtual_Object_ConstantCallSite_CallSiteFormatterContext_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_VisitServiceProvider_Protected_Virtual_Object_ServiceProviderCallSite_CallSiteFormatterContext_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_VisitIEnumerable_Protected_Virtual_Object_IEnumerableCallSite_CallSiteFormatterContext_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_VisitFactory_Protected_Virtual_Object_FactoryCallSite_CallSiteFormatterContext_0;

		// Token: 0x02000031 RID: 49
		public sealed class CallSiteFormatterContext : ValueType
		{
			// Token: 0x06000231 RID: 561 RVA: 0x0000C1A0 File Offset: 0x0000A3A0
			// Note: this type is marked as 'beforefieldinit'.
			static CallSiteFormatterContext()
			{
				Il2CppClassPointerStore<CallSiteJsonFormatter.CallSiteFormatterContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallSiteJsonFormatter>.NativeClassPtr, "CallSiteFormatterContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallSiteJsonFormatter.CallSiteFormatterContext>.NativeClassPtr);
				CallSiteJsonFormatter.CallSiteFormatterContext.NativeFieldInfoPtr__processedCallSites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteJsonFormatter.CallSiteFormatterContext>.NativeClassPtr, "_processedCallSites");
				CallSiteJsonFormatter.CallSiteFormatterContext.NativeFieldInfoPtr__firstItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteJsonFormatter.CallSiteFormatterContext>.NativeClassPtr, "_firstItem");
				CallSiteJsonFormatter.CallSiteFormatterContext.NativeFieldInfoPtr__Offset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteJsonFormatter.CallSiteFormatterContext>.NativeClassPtr, "<Offset>k__BackingField");
				CallSiteJsonFormatter.CallSiteFormatterContext.NativeFieldInfoPtr__Builder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteJsonFormatter.CallSiteFormatterContext>.NativeClassPtr, "<Builder>k__BackingField");
				CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr__ctor_Public_Void_StringBuilder_Int32_HashSet_1_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteJsonFormatter.CallSiteFormatterContext>.NativeClassPtr, 100663346);
				CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_get_Offset_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteJsonFormatter.CallSiteFormatterContext>.NativeClassPtr, 100663347);
				CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_get_Builder_Public_get_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteJsonFormatter.CallSiteFormatterContext>.NativeClassPtr, 100663348);
				CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_ShouldFormat_Public_Boolean_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteJsonFormatter.CallSiteFormatterContext>.NativeClassPtr, 100663349);
				CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_IncrementOffset_Public_CallSiteFormatterContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteJsonFormatter.CallSiteFormatterContext>.NativeClassPtr, 100663350);
				CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_StartObject_Public_CallSiteFormatterContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteJsonFormatter.CallSiteFormatterContext>.NativeClassPtr, 100663351);
				CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_EndObject_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteJsonFormatter.CallSiteFormatterContext>.NativeClassPtr, 100663352);
				CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_StartProperty_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteJsonFormatter.CallSiteFormatterContext>.NativeClassPtr, 100663353);
				CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_StartArrayItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteJsonFormatter.CallSiteFormatterContext>.NativeClassPtr, 100663354);
				CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_WriteProperty_Public_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteJsonFormatter.CallSiteFormatterContext>.NativeClassPtr, 100663355);
				CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_StartArray_Public_CallSiteFormatterContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteJsonFormatter.CallSiteFormatterContext>.NativeClassPtr, 100663356);
				CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_EndArray_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteJsonFormatter.CallSiteFormatterContext>.NativeClassPtr, 100663357);
			}

			// Token: 0x06000232 RID: 562 RVA: 0x0000C30C File Offset: 0x0000A50C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202981, XrefRangeEnd = 1202983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CallSiteFormatterContext(StringBuilder builder, int offset, HashSet<ServiceCallSite> processedCallSites)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSiteJsonFormatter.CallSiteFormatterContext>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(processedCallSites);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr__ctor_Public_Void_StringBuilder_Int32_HashSet_1_ServiceCallSite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x06000233 RID: 563 RVA: 0x0000C37C File Offset: 0x0000A57C
			public unsafe int Offset
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_get_Offset_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x06000234 RID: 564 RVA: 0x0000C3C0 File Offset: 0x0000A5C0
			public unsafe StringBuilder Builder
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_get_Builder_Public_get_StringBuilder_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x06000235 RID: 565 RVA: 0x0000C404 File Offset: 0x0000A604
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202983, XrefRangeEnd = 1202987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ShouldFormat(ServiceCallSite serviceCallSite)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceCallSite);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_ShouldFormat_Public_Boolean_ServiceCallSite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000236 RID: 566 RVA: 0x0000C458 File Offset: 0x0000A658
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202987, XrefRangeEnd = 1202989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CallSiteJsonFormatter.CallSiteFormatterContext IncrementOffset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_IncrementOffset_Public_CallSiteFormatterContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallSiteJsonFormatter.CallSiteFormatterContext(intPtr);
			}

			// Token: 0x06000237 RID: 567 RVA: 0x0000C494 File Offset: 0x0000A694
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1202992, RefRangeEnd = 1202994, XrefRangeStart = 1202989, XrefRangeEnd = 1202992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CallSiteJsonFormatter.CallSiteFormatterContext StartObject()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_StartObject_Public_CallSiteFormatterContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallSiteJsonFormatter.CallSiteFormatterContext(intPtr);
			}

			// Token: 0x06000238 RID: 568 RVA: 0x0000C4D0 File Offset: 0x0000A6D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202994, XrefRangeEnd = 1202996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndObject()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_EndObject_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000239 RID: 569 RVA: 0x0000C508 File Offset: 0x0000A708
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1203004, RefRangeEnd = 1203007, XrefRangeStart = 1202996, XrefRangeEnd = 1203004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void StartProperty(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_StartProperty_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600023A RID: 570 RVA: 0x0000C550 File Offset: 0x0000A750
			[CallerCount(0)]
			public unsafe void StartArrayItem()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_StartArrayItem_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600023B RID: 571 RVA: 0x0000C588 File Offset: 0x0000A788
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1203017, RefRangeEnd = 1203022, XrefRangeStart = 1203007, XrefRangeEnd = 1203017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteProperty(string name, Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_WriteProperty_Public_Void_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600023C RID: 572 RVA: 0x0000C5E4 File Offset: 0x0000A7E4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1203025, RefRangeEnd = 1203027, XrefRangeStart = 1203022, XrefRangeEnd = 1203025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CallSiteJsonFormatter.CallSiteFormatterContext StartArray()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_StartArray_Public_CallSiteFormatterContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallSiteJsonFormatter.CallSiteFormatterContext(intPtr);
			}

			// Token: 0x0600023D RID: 573 RVA: 0x0000C620 File Offset: 0x0000A820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203027, XrefRangeEnd = 1203029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndArray()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteJsonFormatter.CallSiteFormatterContext.NativeMethodInfoPtr_EndArray_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600023E RID: 574 RVA: 0x00002C9C File Offset: 0x00000E9C
			public CallSiteFormatterContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600023F RID: 575 RVA: 0x00002CA5 File Offset: 0x00000EA5
			public CallSiteFormatterContext()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSiteJsonFormatter.CallSiteFormatterContext>.NativeClassPtr))
			{
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x06000240 RID: 576 RVA: 0x0000C658 File Offset: 0x0000A858
			// (set) Token: 0x06000241 RID: 577 RVA: 0x00002CB7 File Offset: 0x00000EB7
			public unsafe HashSet<ServiceCallSite> _processedCallSites
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteJsonFormatter.CallSiteFormatterContext.NativeFieldInfoPtr__processedCallSites);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<ServiceCallSite>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteJsonFormatter.CallSiteFormatterContext.NativeFieldInfoPtr__processedCallSites), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x06000242 RID: 578 RVA: 0x0000C688 File Offset: 0x0000A888
			// (set) Token: 0x06000243 RID: 579 RVA: 0x00002CD6 File Offset: 0x00000ED6
			public unsafe bool _firstItem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteJsonFormatter.CallSiteFormatterContext.NativeFieldInfoPtr__firstItem);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteJsonFormatter.CallSiteFormatterContext.NativeFieldInfoPtr__firstItem)) = value;
				}
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x06000244 RID: 580 RVA: 0x0000C6B0 File Offset: 0x0000A8B0
			// (set) Token: 0x06000245 RID: 581 RVA: 0x00002CF1 File Offset: 0x00000EF1
			public unsafe int _Offset_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteJsonFormatter.CallSiteFormatterContext.NativeFieldInfoPtr__Offset_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteJsonFormatter.CallSiteFormatterContext.NativeFieldInfoPtr__Offset_k__BackingField)) = value;
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x06000246 RID: 582 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
			// (set) Token: 0x06000247 RID: 583 RVA: 0x00002D0C File Offset: 0x00000F0C
			public unsafe StringBuilder _Builder_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteJsonFormatter.CallSiteFormatterContext.NativeFieldInfoPtr__Builder_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteJsonFormatter.CallSiteFormatterContext.NativeFieldInfoPtr__Builder_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000197 RID: 407
			private static readonly IntPtr NativeFieldInfoPtr__processedCallSites;

			// Token: 0x04000198 RID: 408
			private static readonly IntPtr NativeFieldInfoPtr__firstItem;

			// Token: 0x04000199 RID: 409
			private static readonly IntPtr NativeFieldInfoPtr__Offset_k__BackingField;

			// Token: 0x0400019A RID: 410
			private static readonly IntPtr NativeFieldInfoPtr__Builder_k__BackingField;

			// Token: 0x0400019B RID: 411
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StringBuilder_Int32_HashSet_1_ServiceCallSite_0;

			// Token: 0x0400019C RID: 412
			private static readonly IntPtr NativeMethodInfoPtr_get_Offset_Public_get_Int32_0;

			// Token: 0x0400019D RID: 413
			private static readonly IntPtr NativeMethodInfoPtr_get_Builder_Public_get_StringBuilder_0;

			// Token: 0x0400019E RID: 414
			private static readonly IntPtr NativeMethodInfoPtr_ShouldFormat_Public_Boolean_ServiceCallSite_0;

			// Token: 0x0400019F RID: 415
			private static readonly IntPtr NativeMethodInfoPtr_IncrementOffset_Public_CallSiteFormatterContext_0;

			// Token: 0x040001A0 RID: 416
			private static readonly IntPtr NativeMethodInfoPtr_StartObject_Public_CallSiteFormatterContext_0;

			// Token: 0x040001A1 RID: 417
			private static readonly IntPtr NativeMethodInfoPtr_EndObject_Public_Void_0;

			// Token: 0x040001A2 RID: 418
			private static readonly IntPtr NativeMethodInfoPtr_StartProperty_Public_Void_String_0;

			// Token: 0x040001A3 RID: 419
			private static readonly IntPtr NativeMethodInfoPtr_StartArrayItem_Public_Void_0;

			// Token: 0x040001A4 RID: 420
			private static readonly IntPtr NativeMethodInfoPtr_WriteProperty_Public_Void_String_Object_0;

			// Token: 0x040001A5 RID: 421
			private static readonly IntPtr NativeMethodInfoPtr_StartArray_Public_CallSiteFormatterContext_0;

			// Token: 0x040001A6 RID: 422
			private static readonly IntPtr NativeMethodInfoPtr_EndArray_Public_Void_0;
		}
	}
}
