using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x0200001B RID: 27
	public class CompiledServiceProviderEngine : ServiceProviderEngine
	{
		// Token: 0x06000110 RID: 272 RVA: 0x00007EC4 File Offset: 0x000060C4
		// Note: this type is marked as 'beforefieldinit'.
		static CompiledServiceProviderEngine()
		{
			Il2CppClassPointerStore<CompiledServiceProviderEngine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "CompiledServiceProviderEngine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompiledServiceProviderEngine>.NativeClassPtr);
			CompiledServiceProviderEngine.NativeFieldInfoPtr__ResolverBuilder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledServiceProviderEngine>.NativeClassPtr, "<ResolverBuilder>k__BackingField");
			CompiledServiceProviderEngine.NativeMethodInfoPtr_get_ResolverBuilder_Public_get_ILEmitResolverBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompiledServiceProviderEngine>.NativeClassPtr, 100663496);
			CompiledServiceProviderEngine.NativeMethodInfoPtr__ctor_Public_Void_ServiceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompiledServiceProviderEngine>.NativeClassPtr, 100663497);
			CompiledServiceProviderEngine.NativeMethodInfoPtr_RealizeService_Public_Virtual_Func_2_ServiceProviderEngineScope_Object_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompiledServiceProviderEngine>.NativeClassPtr, 100663498);
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00007F44 File Offset: 0x00006144
		public unsafe ILEmitResolverBuilder ResolverBuilder
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompiledServiceProviderEngine.NativeMethodInfoPtr_get_ResolverBuilder_Public_get_ILEmitResolverBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILEmitResolverBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00007F84 File Offset: 0x00006184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204524, XrefRangeEnd = 1204548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompiledServiceProviderEngine(ServiceProvider provider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompiledServiceProviderEngine>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompiledServiceProviderEngine.NativeMethodInfoPtr__ctor_Public_Void_ServiceProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00007FD0 File Offset: 0x000061D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204548, XrefRangeEnd = 1204549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Func<ServiceProviderEngineScope, Object> RealizeService(ServiceCallSite callSite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callSite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompiledServiceProviderEngine.NativeMethodInfoPtr_RealizeService_Public_Virtual_Func_2_ServiceProviderEngineScope_Object_ServiceCallSite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<ServiceProviderEngineScope, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002572 File Offset: 0x00000772
		public CompiledServiceProviderEngine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000802C File Offset: 0x0000622C
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0000257B File Offset: 0x0000077B
		public unsafe ILEmitResolverBuilder _ResolverBuilder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledServiceProviderEngine.NativeFieldInfoPtr__ResolverBuilder_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILEmitResolverBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledServiceProviderEngine.NativeFieldInfoPtr__ResolverBuilder_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr__ResolverBuilder_k__BackingField;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_get_ResolverBuilder_Public_get_ILEmitResolverBuilder_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServiceProvider_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_RealizeService_Public_Virtual_Func_2_ServiceProviderEngineScope_Object_ServiceCallSite_0;
	}
}
