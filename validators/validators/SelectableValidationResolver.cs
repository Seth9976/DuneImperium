using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace validators
{
	// Token: 0x0200000B RID: 11
	public class SelectableValidationResolver : AbstractValidationResolver
	{
		// Token: 0x0600003E RID: 62 RVA: 0x000033A8 File Offset: 0x000015A8
		// Note: this type is marked as 'beforefieldinit'.
		static SelectableValidationResolver()
		{
			Il2CppClassPointerStore<SelectableValidationResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("validators.dll", "validators", "SelectableValidationResolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectableValidationResolver>.NativeClassPtr);
			SelectableValidationResolver.NativeFieldInfoPtr_validatable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableValidationResolver>.NativeClassPtr, "validatable");
			SelectableValidationResolver.NativeMethodInfoPtr_onValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableValidationResolver>.NativeClassPtr, 100663318);
			SelectableValidationResolver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableValidationResolver>.NativeClassPtr, 100663319);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003414 File Offset: 0x00001614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267523, XrefRangeEnd = 1267533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void onValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectableValidationResolver.NativeMethodInfoPtr_onValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003450 File Offset: 0x00001650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectableValidationResolver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectableValidationResolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableValidationResolver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002236 File Offset: 0x00000436
		public SelectableValidationResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0000348C File Offset: 0x0000168C
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0000223F File Offset: 0x0000043F
		public unsafe Selectable validatable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableValidationResolver.NativeFieldInfoPtr_validatable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableValidationResolver.NativeFieldInfoPtr_validatable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_validatable;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_onValidate_Protected_Virtual_Void_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
