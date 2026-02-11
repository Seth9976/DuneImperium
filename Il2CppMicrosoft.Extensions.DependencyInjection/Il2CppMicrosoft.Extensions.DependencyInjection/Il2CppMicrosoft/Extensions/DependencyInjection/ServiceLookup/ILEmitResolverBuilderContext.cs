using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection.Emit;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x0200002E RID: 46
	public sealed class ILEmitResolverBuilderContext : Object
	{
		// Token: 0x06000215 RID: 533 RVA: 0x0000BA60 File Offset: 0x00009C60
		// Note: this type is marked as 'beforefieldinit'.
		static ILEmitResolverBuilderContext()
		{
			Il2CppClassPointerStore<ILEmitResolverBuilderContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "ILEmitResolverBuilderContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ILEmitResolverBuilderContext>.NativeClassPtr);
			ILEmitResolverBuilderContext.NativeFieldInfoPtr__Generator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILEmitResolverBuilderContext>.NativeClassPtr, "<Generator>k__BackingField");
			ILEmitResolverBuilderContext.NativeFieldInfoPtr__Constants_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILEmitResolverBuilderContext>.NativeClassPtr, "<Constants>k__BackingField");
			ILEmitResolverBuilderContext.NativeFieldInfoPtr__Factories_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILEmitResolverBuilderContext>.NativeClassPtr, "<Factories>k__BackingField");
			ILEmitResolverBuilderContext.NativeMethodInfoPtr__ctor_Public_Void_ILGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilderContext>.NativeClassPtr, 100663628);
			ILEmitResolverBuilderContext.NativeMethodInfoPtr_get_Generator_Public_get_ILGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilderContext>.NativeClassPtr, 100663629);
			ILEmitResolverBuilderContext.NativeMethodInfoPtr_get_Constants_Public_get_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilderContext>.NativeClassPtr, 100663630);
			ILEmitResolverBuilderContext.NativeMethodInfoPtr_set_Constants_Public_set_Void_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilderContext>.NativeClassPtr, 100663631);
			ILEmitResolverBuilderContext.NativeMethodInfoPtr_get_Factories_Public_get_List_1_Func_2_IServiceProvider_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilderContext>.NativeClassPtr, 100663632);
			ILEmitResolverBuilderContext.NativeMethodInfoPtr_set_Factories_Public_set_Void_List_1_Func_2_IServiceProvider_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILEmitResolverBuilderContext>.NativeClassPtr, 100663633);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000BB44 File Offset: 0x00009D44
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ILEmitResolverBuilderContext(ILGenerator generator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ILEmitResolverBuilderContext>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(generator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilderContext.NativeMethodInfoPtr__ctor_Public_Void_ILGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0000BB90 File Offset: 0x00009D90
		public unsafe ILGenerator Generator
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilderContext.NativeMethodInfoPtr_get_Generator_Public_get_ILGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILGenerator>(intPtr3) : null;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0000BBD0 File Offset: 0x00009DD0
		// (set) Token: 0x06000219 RID: 537 RVA: 0x0000BC10 File Offset: 0x00009E10
		public unsafe List<Object> Constants
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilderContext.NativeMethodInfoPtr_get_Constants_Public_get_List_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Object>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilderContext.NativeMethodInfoPtr_set_Constants_Public_set_Void_List_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0000BC54 File Offset: 0x00009E54
		// (set) Token: 0x0600021B RID: 539 RVA: 0x0000BC94 File Offset: 0x00009E94
		public unsafe List<Func<IServiceProvider, Object>> Factories
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilderContext.NativeMethodInfoPtr_get_Factories_Public_get_List_1_Func_2_IServiceProvider_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Func<IServiceProvider, Object>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILEmitResolverBuilderContext.NativeMethodInfoPtr_set_Factories_Public_set_Void_List_1_Func_2_IServiceProvider_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002C12 File Offset: 0x00000E12
		public ILEmitResolverBuilderContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000BCD8 File Offset: 0x00009ED8
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00002C1B File Offset: 0x00000E1B
		public unsafe ILGenerator _Generator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilderContext.NativeFieldInfoPtr__Generator_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilderContext.NativeFieldInfoPtr__Generator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0000BD08 File Offset: 0x00009F08
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00002C3A File Offset: 0x00000E3A
		public unsafe List<Object> _Constants_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilderContext.NativeFieldInfoPtr__Constants_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilderContext.NativeFieldInfoPtr__Constants_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0000BD38 File Offset: 0x00009F38
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00002C59 File Offset: 0x00000E59
		public unsafe List<Func<IServiceProvider, Object>> _Factories_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilderContext.NativeFieldInfoPtr__Factories_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Func<IServiceProvider, Object>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILEmitResolverBuilderContext.NativeFieldInfoPtr__Factories_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeFieldInfoPtr__Generator_k__BackingField;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeFieldInfoPtr__Constants_k__BackingField;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeFieldInfoPtr__Factories_k__BackingField;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ILGenerator_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_get_Generator_Public_get_ILGenerator_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_get_Constants_Public_get_List_1_Object_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_set_Constants_Public_set_Void_List_1_Object_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_get_Factories_Public_get_List_1_Func_2_IServiceProvider_Object_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_set_Factories_Public_set_Void_List_1_Func_2_IServiceProvider_Object_0;
	}
}
