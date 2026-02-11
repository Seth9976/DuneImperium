using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace validators
{
	// Token: 0x0200000A RID: 10
	public class ActiveValidationResolver : AbstractValidationResolver
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00003250 File Offset: 0x00001450
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveValidationResolver()
		{
			Il2CppClassPointerStore<ActiveValidationResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("validators.dll", "validators", "ActiveValidationResolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveValidationResolver>.NativeClassPtr);
			ActiveValidationResolver.NativeFieldInfoPtr_validatable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveValidationResolver>.NativeClassPtr, "validatable");
			ActiveValidationResolver.NativeFieldInfoPtr_validatableGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveValidationResolver>.NativeClassPtr, "validatableGameObjects");
			ActiveValidationResolver.NativeMethodInfoPtr_onValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveValidationResolver>.NativeClassPtr, 100663316);
			ActiveValidationResolver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveValidationResolver>.NativeClassPtr, 100663317);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000032D0 File Offset: 0x000014D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267496, XrefRangeEnd = 1267518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void onValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveValidationResolver.NativeMethodInfoPtr_onValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000330C File Offset: 0x0000150C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267518, XrefRangeEnd = 1267523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveValidationResolver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveValidationResolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveValidationResolver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000021EF File Offset: 0x000003EF
		public ActiveValidationResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00003348 File Offset: 0x00001548
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000021F8 File Offset: 0x000003F8
		public unsafe GameObject validatable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveValidationResolver.NativeFieldInfoPtr_validatable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveValidationResolver.NativeFieldInfoPtr_validatable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00003378 File Offset: 0x00001578
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002217 File Offset: 0x00000417
		public unsafe Il2CppReferenceArray<GameObject> validatableGameObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveValidationResolver.NativeFieldInfoPtr_validatableGameObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveValidationResolver.NativeFieldInfoPtr_validatableGameObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_validatable;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_validatableGameObjects;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_onValidate_Protected_Virtual_Void_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
