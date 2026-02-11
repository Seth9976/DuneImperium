using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using validators;

namespace lib.validators.validationResolvers
{
	// Token: 0x02000007 RID: 7
	public class EnableValidationResolver : AbstractValidationResolver
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002CD8 File Offset: 0x00000ED8
		// Note: this type is marked as 'beforefieldinit'.
		static EnableValidationResolver()
		{
			Il2CppClassPointerStore<EnableValidationResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("validators.dll", "lib.validators.validationResolvers", "EnableValidationResolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnableValidationResolver>.NativeClassPtr);
			EnableValidationResolver.NativeFieldInfoPtr_enableBehaviours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableValidationResolver>.NativeClassPtr, "enableBehaviours");
			EnableValidationResolver.NativeMethodInfoPtr_onValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableValidationResolver>.NativeClassPtr, 100663305);
			EnableValidationResolver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableValidationResolver>.NativeClassPtr, 100663306);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002D44 File Offset: 0x00000F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267440, XrefRangeEnd = 1267447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void onValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnableValidationResolver.NativeMethodInfoPtr_onValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002D80 File Offset: 0x00000F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267447, XrefRangeEnd = 1267452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnableValidationResolver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnableValidationResolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnableValidationResolver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000210F File Offset: 0x0000030F
		public EnableValidationResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002DBC File Offset: 0x00000FBC
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002118 File Offset: 0x00000318
		public unsafe Il2CppReferenceArray<MonoBehaviour> enableBehaviours
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnableValidationResolver.NativeFieldInfoPtr_enableBehaviours);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MonoBehaviour>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnableValidationResolver.NativeFieldInfoPtr_enableBehaviours), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_enableBehaviours;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_onValidate_Protected_Virtual_Void_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
