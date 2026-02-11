using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x02000022 RID: 34
	public sealed class RuntimeServiceProviderEngine : ServiceProviderEngine
	{
		// Token: 0x06000164 RID: 356 RVA: 0x00009244 File Offset: 0x00007444
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeServiceProviderEngine()
		{
			Il2CppClassPointerStore<RuntimeServiceProviderEngine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "RuntimeServiceProviderEngine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeServiceProviderEngine>.NativeClassPtr);
			RuntimeServiceProviderEngine.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeServiceProviderEngine>.NativeClassPtr, "<Instance>k__BackingField");
			RuntimeServiceProviderEngine.NativeMethodInfoPtr_get_Instance_Public_Static_get_RuntimeServiceProviderEngine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeServiceProviderEngine>.NativeClassPtr, 100663538);
			RuntimeServiceProviderEngine.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeServiceProviderEngine>.NativeClassPtr, 100663539);
			RuntimeServiceProviderEngine.NativeMethodInfoPtr_RealizeService_Public_Virtual_Func_2_ServiceProviderEngineScope_Object_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeServiceProviderEngine>.NativeClassPtr, 100663540);
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000092C4 File Offset: 0x000074C4
		public unsafe static RuntimeServiceProviderEngine Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204767, XrefRangeEnd = 1204771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeServiceProviderEngine.NativeMethodInfoPtr_get_Instance_Public_Static_get_RuntimeServiceProviderEngine_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeServiceProviderEngine>(intPtr3) : null;
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000092F8 File Offset: 0x000074F8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeServiceProviderEngine()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeServiceProviderEngine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeServiceProviderEngine.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00009334 File Offset: 0x00007534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204771, XrefRangeEnd = 1204782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Func<ServiceProviderEngineScope, Object> RealizeService(ServiceCallSite callSite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeServiceProviderEngine.NativeMethodInfoPtr_RealizeService_Public_Virtual_Func_2_ServiceProviderEngineScope_Object_ServiceCallSite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<ServiceProviderEngineScope, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000027AE File Offset: 0x000009AE
		public RuntimeServiceProviderEngine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00009384 File Offset: 0x00007584
		// (set) Token: 0x0600016A RID: 362 RVA: 0x000027B7 File Offset: 0x000009B7
		public unsafe static RuntimeServiceProviderEngine _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeServiceProviderEngine.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeServiceProviderEngine>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeServiceProviderEngine.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_RuntimeServiceProviderEngine_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_RealizeService_Public_Virtual_Func_2_ServiceProviderEngineScope_Object_ServiceCallSite_0;

		// Token: 0x02000040 RID: 64
		[ObfuscatedName("Microsoft.Extensions.DependencyInjection.ServiceLookup.RuntimeServiceProviderEngine+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x060002B8 RID: 696 RVA: 0x0000DA1C File Offset: 0x0000BC1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<RuntimeServiceProviderEngine.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeServiceProviderEngine>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeServiceProviderEngine.__c__DisplayClass4_0>.NativeClassPtr);
				RuntimeServiceProviderEngine.__c__DisplayClass4_0.NativeFieldInfoPtr_callSite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeServiceProviderEngine.__c__DisplayClass4_0>.NativeClassPtr, "callSite");
				RuntimeServiceProviderEngine.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeServiceProviderEngine.__c__DisplayClass4_0>.NativeClassPtr, 100663542);
				RuntimeServiceProviderEngine.__c__DisplayClass4_0.NativeMethodInfoPtr__RealizeService_b__0_Internal_Object_ServiceProviderEngineScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeServiceProviderEngine.__c__DisplayClass4_0>.NativeClassPtr, 100663543);
			}

			// Token: 0x060002B9 RID: 697 RVA: 0x0000DA84 File Offset: 0x0000BC84
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeServiceProviderEngine.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeServiceProviderEngine.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002BA RID: 698 RVA: 0x0000DAC0 File Offset: 0x0000BCC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204759, XrefRangeEnd = 1204767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _RealizeService_b__0(ServiceProviderEngineScope scope)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(scope);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeServiceProviderEngine.__c__DisplayClass4_0.NativeMethodInfoPtr__RealizeService_b__0_Internal_Object_ServiceProviderEngineScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002BB RID: 699 RVA: 0x00003104 File Offset: 0x00001304
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x060002BC RID: 700 RVA: 0x0000DB10 File Offset: 0x0000BD10
			// (set) Token: 0x060002BD RID: 701 RVA: 0x0000310D File Offset: 0x0000130D
			public unsafe ServiceCallSite callSite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeServiceProviderEngine.__c__DisplayClass4_0.NativeFieldInfoPtr_callSite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceCallSite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeServiceProviderEngine.__c__DisplayClass4_0.NativeFieldInfoPtr_callSite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001E0 RID: 480
			private static readonly IntPtr NativeFieldInfoPtr_callSite;

			// Token: 0x040001E1 RID: 481
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001E2 RID: 482
			private static readonly IntPtr NativeMethodInfoPtr__RealizeService_b__0_Internal_Object_ServiceProviderEngineScope_0;
		}
	}
}
