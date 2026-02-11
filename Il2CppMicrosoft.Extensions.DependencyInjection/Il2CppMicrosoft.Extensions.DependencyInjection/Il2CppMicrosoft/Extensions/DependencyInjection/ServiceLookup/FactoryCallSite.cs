using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x0200001F RID: 31
	public sealed class FactoryCallSite : ServiceCallSite
	{
		// Token: 0x0600013A RID: 314 RVA: 0x00008864 File Offset: 0x00006A64
		// Note: this type is marked as 'beforefieldinit'.
		static FactoryCallSite()
		{
			Il2CppClassPointerStore<FactoryCallSite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "FactoryCallSite");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactoryCallSite>.NativeClassPtr);
			FactoryCallSite.NativeFieldInfoPtr__Factory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactoryCallSite>.NativeClassPtr, "<Factory>k__BackingField");
			FactoryCallSite.NativeFieldInfoPtr__ServiceType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactoryCallSite>.NativeClassPtr, "<ServiceType>k__BackingField");
			FactoryCallSite.NativeFieldInfoPtr__Kind_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactoryCallSite>.NativeClassPtr, "<Kind>k__BackingField");
			FactoryCallSite.NativeMethodInfoPtr_get_Factory_Public_get_Func_2_IServiceProvider_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactoryCallSite>.NativeClassPtr, 100663517);
			FactoryCallSite.NativeMethodInfoPtr__ctor_Public_Void_ResultCache_Type_Func_2_IServiceProvider_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactoryCallSite>.NativeClassPtr, 100663518);
			FactoryCallSite.NativeMethodInfoPtr__ctor_Public_Void_ResultCache_Type_Object_Func_3_IServiceProvider_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactoryCallSite>.NativeClassPtr, 100663519);
			FactoryCallSite.NativeMethodInfoPtr_get_ServiceType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactoryCallSite>.NativeClassPtr, 100663520);
			FactoryCallSite.NativeMethodInfoPtr_get_ImplementationType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactoryCallSite>.NativeClassPtr, 100663521);
			FactoryCallSite.NativeMethodInfoPtr_get_Kind_Public_Virtual_get_CallSiteKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactoryCallSite>.NativeClassPtr, 100663522);
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00008948 File Offset: 0x00006B48
		public unsafe Func<IServiceProvider, Object> Factory
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FactoryCallSite.NativeMethodInfoPtr_get_Factory_Public_get_Func_2_IServiceProvider_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<IServiceProvider, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00008988 File Offset: 0x00006B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204705, XrefRangeEnd = 1204709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FactoryCallSite(ResultCache cache, Type serviceType, Func<IServiceProvider, Object> factory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactoryCallSite>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cache));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(factory);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FactoryCallSite.NativeMethodInfoPtr__ctor_Public_Void_ResultCache_Type_Func_2_IServiceProvider_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000089FC File Offset: 0x00006BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204709, XrefRangeEnd = 1204726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FactoryCallSite(ResultCache cache, Type serviceType, Object serviceKey, Func<IServiceProvider, Object, Object> factory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactoryCallSite>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cache));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceKey);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(factory);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FactoryCallSite.NativeMethodInfoPtr__ctor_Public_Void_ResultCache_Type_Object_Func_3_IServiceProvider_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00008A84 File Offset: 0x00006C84
		public unsafe override Type ServiceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FactoryCallSite.NativeMethodInfoPtr_get_ServiceType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00008AC4 File Offset: 0x00006CC4
		public unsafe override Type ImplementationType
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FactoryCallSite.NativeMethodInfoPtr_get_ImplementationType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00008B04 File Offset: 0x00006D04
		public unsafe override CallSiteKind Kind
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318242, RefRangeEnd = 318245, XrefRangeStart = 318242, XrefRangeEnd = 318245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FactoryCallSite.NativeMethodInfoPtr_get_Kind_Public_Virtual_get_CallSiteKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002686 File Offset: 0x00000886
		public FactoryCallSite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00008B40 File Offset: 0x00006D40
		// (set) Token: 0x06000143 RID: 323 RVA: 0x0000268F File Offset: 0x0000088F
		public unsafe Func<IServiceProvider, Object> _Factory_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryCallSite.NativeFieldInfoPtr__Factory_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IServiceProvider, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryCallSite.NativeFieldInfoPtr__Factory_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00008B70 File Offset: 0x00006D70
		// (set) Token: 0x06000145 RID: 325 RVA: 0x000026AE File Offset: 0x000008AE
		public unsafe Type _ServiceType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryCallSite.NativeFieldInfoPtr__ServiceType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryCallSite.NativeFieldInfoPtr__ServiceType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00008BA0 File Offset: 0x00006DA0
		// (set) Token: 0x06000147 RID: 327 RVA: 0x000026CD File Offset: 0x000008CD
		public unsafe CallSiteKind _Kind_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryCallSite.NativeFieldInfoPtr__Kind_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryCallSite.NativeFieldInfoPtr__Kind_k__BackingField)) = value;
			}
		}

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr__Factory_k__BackingField;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr__ServiceType_k__BackingField;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr__Kind_k__BackingField;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_get_Factory_Public_get_Func_2_IServiceProvider_Object_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResultCache_Type_Func_2_IServiceProvider_Object_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResultCache_Type_Object_Func_3_IServiceProvider_Object_Object_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_get_ServiceType_Public_Virtual_get_Type_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_get_ImplementationType_Public_Virtual_get_Type_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_get_Kind_Public_Virtual_get_CallSiteKind_0;

		// Token: 0x0200003F RID: 63
		[ObfuscatedName("Microsoft.Extensions.DependencyInjection.ServiceLookup.FactoryCallSite+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x060002B0 RID: 688 RVA: 0x0000D8B4 File Offset: 0x0000BAB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<FactoryCallSite.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FactoryCallSite>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactoryCallSite.__c__DisplayClass4_0>.NativeClassPtr);
				FactoryCallSite.__c__DisplayClass4_0.NativeFieldInfoPtr_factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactoryCallSite.__c__DisplayClass4_0>.NativeClassPtr, "factory");
				FactoryCallSite.__c__DisplayClass4_0.NativeFieldInfoPtr_serviceKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactoryCallSite.__c__DisplayClass4_0>.NativeClassPtr, "serviceKey");
				FactoryCallSite.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactoryCallSite.__c__DisplayClass4_0>.NativeClassPtr, 100663523);
				FactoryCallSite.__c__DisplayClass4_0.NativeMethodInfoPtr___ctor_b__0_Internal_Object_IServiceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactoryCallSite.__c__DisplayClass4_0>.NativeClassPtr, 100663524);
			}

			// Token: 0x060002B1 RID: 689 RVA: 0x0000D930 File Offset: 0x0000BB30
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactoryCallSite.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FactoryCallSite.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002B2 RID: 690 RVA: 0x0000D96C File Offset: 0x0000BB6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204677, XrefRangeEnd = 1204705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object __ctor_b__0(IServiceProvider sp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sp);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FactoryCallSite.__c__DisplayClass4_0.NativeMethodInfoPtr___ctor_b__0_Internal_Object_IServiceProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002B3 RID: 691 RVA: 0x000030BD File Offset: 0x000012BD
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000D9BC File Offset: 0x0000BBBC
			// (set) Token: 0x060002B5 RID: 693 RVA: 0x000030C6 File Offset: 0x000012C6
			public unsafe Func<IServiceProvider, Object, Object> factory
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryCallSite.__c__DisplayClass4_0.NativeFieldInfoPtr_factory);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IServiceProvider, Object, Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryCallSite.__c__DisplayClass4_0.NativeFieldInfoPtr_factory), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x060002B6 RID: 694 RVA: 0x0000D9EC File Offset: 0x0000BBEC
			// (set) Token: 0x060002B7 RID: 695 RVA: 0x000030E5 File Offset: 0x000012E5
			public unsafe Object serviceKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryCallSite.__c__DisplayClass4_0.NativeFieldInfoPtr_serviceKey);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FactoryCallSite.__c__DisplayClass4_0.NativeFieldInfoPtr_serviceKey), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001DC RID: 476
			private static readonly IntPtr NativeFieldInfoPtr_factory;

			// Token: 0x040001DD RID: 477
			private static readonly IntPtr NativeFieldInfoPtr_serviceKey;

			// Token: 0x040001DE RID: 478
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001DF RID: 479
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_Object_IServiceProvider_0;
		}
	}
}
