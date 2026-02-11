using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Threading;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x0200001E RID: 30
	public sealed class DynamicServiceProviderEngine : CompiledServiceProviderEngine
	{
		// Token: 0x06000133 RID: 307 RVA: 0x000086C8 File Offset: 0x000068C8
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicServiceProviderEngine()
		{
			Il2CppClassPointerStore<DynamicServiceProviderEngine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "DynamicServiceProviderEngine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicServiceProviderEngine>.NativeClassPtr);
			DynamicServiceProviderEngine.NativeFieldInfoPtr__serviceProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicServiceProviderEngine>.NativeClassPtr, "_serviceProvider");
			DynamicServiceProviderEngine.NativeMethodInfoPtr__ctor_Public_Void_ServiceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicServiceProviderEngine>.NativeClassPtr, 100663511);
			DynamicServiceProviderEngine.NativeMethodInfoPtr_RealizeService_Public_Virtual_Func_2_ServiceProviderEngineScope_Object_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicServiceProviderEngine>.NativeClassPtr, 100663512);
			DynamicServiceProviderEngine.NativeMethodInfoPtr___n__0_Private_Func_2_ServiceProviderEngineScope_Object_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicServiceProviderEngine>.NativeClassPtr, 100663513);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00008748 File Offset: 0x00006948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204640, XrefRangeEnd = 1204665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicServiceProviderEngine(ServiceProvider serviceProvider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicServiceProviderEngine>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceProvider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicServiceProviderEngine.NativeMethodInfoPtr__ctor_Public_Void_ServiceProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00008794 File Offset: 0x00006994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204665, XrefRangeEnd = 1204677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Func<ServiceProviderEngineScope, Object> RealizeService(ServiceCallSite callSite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicServiceProviderEngine.NativeMethodInfoPtr_RealizeService_Public_Virtual_Func_2_ServiceProviderEngineScope_Object_ServiceCallSite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<ServiceProviderEngineScope, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000087E4 File Offset: 0x000069E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func<ServiceProviderEngineScope, Object> __n__0(ServiceCallSite callSite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicServiceProviderEngine.NativeMethodInfoPtr___n__0_Private_Func_2_ServiceProviderEngineScope_Object_ServiceCallSite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<ServiceProviderEngineScope, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000265E File Offset: 0x0000085E
		public DynamicServiceProviderEngine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00008834 File Offset: 0x00006A34
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00002667 File Offset: 0x00000867
		public unsafe ServiceProvider _serviceProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicServiceProviderEngine.NativeFieldInfoPtr__serviceProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicServiceProviderEngine.NativeFieldInfoPtr__serviceProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr__serviceProvider;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServiceProvider_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_RealizeService_Public_Virtual_Func_2_ServiceProviderEngineScope_Object_ServiceCallSite_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_Func_2_ServiceProviderEngineScope_Object_ServiceCallSite_0;

		// Token: 0x0200003E RID: 62
		[ObfuscatedName("Microsoft.Extensions.DependencyInjection.ServiceLookup.DynamicServiceProviderEngine+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x060002A3 RID: 675 RVA: 0x0000D674 File Offset: 0x0000B874
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DynamicServiceProviderEngine.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicServiceProviderEngine>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicServiceProviderEngine.__c__DisplayClass2_0>.NativeClassPtr);
				DynamicServiceProviderEngine.__c__DisplayClass2_0.NativeFieldInfoPtr_callSite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicServiceProviderEngine.__c__DisplayClass2_0>.NativeClassPtr, "callSite");
				DynamicServiceProviderEngine.__c__DisplayClass2_0.NativeFieldInfoPtr_callCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicServiceProviderEngine.__c__DisplayClass2_0>.NativeClassPtr, "callCount");
				DynamicServiceProviderEngine.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicServiceProviderEngine.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
				DynamicServiceProviderEngine.__c__DisplayClass2_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicServiceProviderEngine.__c__DisplayClass2_0>.NativeClassPtr, "<>9__1");
				DynamicServiceProviderEngine.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicServiceProviderEngine.__c__DisplayClass2_0>.NativeClassPtr, 100663514);
				DynamicServiceProviderEngine.__c__DisplayClass2_0.NativeMethodInfoPtr__RealizeService_b__0_Internal_Object_ServiceProviderEngineScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicServiceProviderEngine.__c__DisplayClass2_0>.NativeClassPtr, 100663515);
				DynamicServiceProviderEngine.__c__DisplayClass2_0.NativeMethodInfoPtr__RealizeService_b__1_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicServiceProviderEngine.__c__DisplayClass2_0>.NativeClassPtr, 100663516);
			}

			// Token: 0x060002A4 RID: 676 RVA: 0x0000D72C File Offset: 0x0000B92C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicServiceProviderEngine.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicServiceProviderEngine.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002A5 RID: 677 RVA: 0x0000D768 File Offset: 0x0000B968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204606, XrefRangeEnd = 1204623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _RealizeService_b__0(ServiceProviderEngineScope scope)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(scope);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicServiceProviderEngine.__c__DisplayClass2_0.NativeMethodInfoPtr__RealizeService_b__0_Internal_Object_ServiceProviderEngineScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002A6 RID: 678 RVA: 0x0000D7B8 File Offset: 0x0000B9B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204623, XrefRangeEnd = 1204640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RealizeService_b__1(Object _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicServiceProviderEngine.__c__DisplayClass2_0.NativeMethodInfoPtr__RealizeService_b__1_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002A7 RID: 679 RVA: 0x0000303C File Offset: 0x0000123C
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000CF RID: 207
			// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000D7FC File Offset: 0x0000B9FC
			// (set) Token: 0x060002A9 RID: 681 RVA: 0x00003045 File Offset: 0x00001245
			public unsafe ServiceCallSite callSite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicServiceProviderEngine.__c__DisplayClass2_0.NativeFieldInfoPtr_callSite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceCallSite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicServiceProviderEngine.__c__DisplayClass2_0.NativeFieldInfoPtr_callSite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x060002AA RID: 682 RVA: 0x0000D82C File Offset: 0x0000BA2C
			// (set) Token: 0x060002AB RID: 683 RVA: 0x00003064 File Offset: 0x00001264
			public unsafe int callCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicServiceProviderEngine.__c__DisplayClass2_0.NativeFieldInfoPtr_callCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicServiceProviderEngine.__c__DisplayClass2_0.NativeFieldInfoPtr_callCount)) = value;
				}
			}

			// Token: 0x170000D1 RID: 209
			// (get) Token: 0x060002AC RID: 684 RVA: 0x0000D854 File Offset: 0x0000BA54
			// (set) Token: 0x060002AD RID: 685 RVA: 0x0000307F File Offset: 0x0000127F
			public unsafe DynamicServiceProviderEngine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicServiceProviderEngine.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicServiceProviderEngine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicServiceProviderEngine.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D2 RID: 210
			// (get) Token: 0x060002AE RID: 686 RVA: 0x0000D884 File Offset: 0x0000BA84
			// (set) Token: 0x060002AF RID: 687 RVA: 0x0000309E File Offset: 0x0000129E
			public unsafe WaitCallback __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicServiceProviderEngine.__c__DisplayClass2_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicServiceProviderEngine.__c__DisplayClass2_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001D5 RID: 469
			private static readonly IntPtr NativeFieldInfoPtr_callSite;

			// Token: 0x040001D6 RID: 470
			private static readonly IntPtr NativeFieldInfoPtr_callCount;

			// Token: 0x040001D7 RID: 471
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040001D8 RID: 472
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x040001D9 RID: 473
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001DA RID: 474
			private static readonly IntPtr NativeMethodInfoPtr__RealizeService_b__0_Internal_Object_ServiceProviderEngineScope_0;

			// Token: 0x040001DB RID: 475
			private static readonly IntPtr NativeMethodInfoPtr__RealizeService_b__1_Internal_Void_Object_0;
		}
	}
}
