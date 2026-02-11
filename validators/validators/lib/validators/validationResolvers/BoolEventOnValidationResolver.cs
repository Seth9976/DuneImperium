using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using validators;

namespace lib.validators.validationResolvers
{
	// Token: 0x02000006 RID: 6
	public class BoolEventOnValidationResolver : AbstractValidationResolver
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002BC4 File Offset: 0x00000DC4
		// Note: this type is marked as 'beforefieldinit'.
		static BoolEventOnValidationResolver()
		{
			Il2CppClassPointerStore<BoolEventOnValidationResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("validators.dll", "lib.validators.validationResolvers", "BoolEventOnValidationResolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolEventOnValidationResolver>.NativeClassPtr);
			BoolEventOnValidationResolver.NativeFieldInfoPtr_onModuleActiveStateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolEventOnValidationResolver>.NativeClassPtr, "onModuleActiveStateChange");
			BoolEventOnValidationResolver.NativeMethodInfoPtr_onValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolEventOnValidationResolver>.NativeClassPtr, 100663303);
			BoolEventOnValidationResolver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolEventOnValidationResolver>.NativeClassPtr, 100663304);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002C30 File Offset: 0x00000E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267427, XrefRangeEnd = 1267434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void onValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoolEventOnValidationResolver.NativeMethodInfoPtr_onValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002C6C File Offset: 0x00000E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267434, XrefRangeEnd = 1267440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolEventOnValidationResolver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolEventOnValidationResolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolEventOnValidationResolver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020E7 File Offset: 0x000002E7
		public BoolEventOnValidationResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002CA8 File Offset: 0x00000EA8
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000020F0 File Offset: 0x000002F0
		public unsafe BoolUnityEvents onModuleActiveStateChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolEventOnValidationResolver.NativeFieldInfoPtr_onModuleActiveStateChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolEventOnValidationResolver.NativeFieldInfoPtr_onModuleActiveStateChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_onModuleActiveStateChange;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_onValidate_Protected_Virtual_Void_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
