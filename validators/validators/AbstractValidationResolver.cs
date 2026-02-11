using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace validators
{
	// Token: 0x02000009 RID: 9
	public class AbstractValidationResolver : MonoBehaviour
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002F44 File Offset: 0x00001144
		// Note: this type is marked as 'beforefieldinit'.
		static AbstractValidationResolver()
		{
			Il2CppClassPointerStore<AbstractValidationResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("validators.dll", "validators", "AbstractValidationResolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbstractValidationResolver>.NativeClassPtr);
			AbstractValidationResolver.NativeFieldInfoPtr_resolveOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractValidationResolver>.NativeClassPtr, "resolveOn");
			AbstractValidationResolver.NativeFieldInfoPtr_validators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractValidationResolver>.NativeClassPtr, "validators");
			AbstractValidationResolver.NativeFieldInfoPtr_valid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractValidationResolver>.NativeClassPtr, "valid");
			AbstractValidationResolver.NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractValidationResolver>.NativeClassPtr, 100663309);
			AbstractValidationResolver.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractValidationResolver>.NativeClassPtr, 100663310);
			AbstractValidationResolver.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractValidationResolver>.NativeClassPtr, 100663311);
			AbstractValidationResolver.NativeMethodInfoPtr_resolveValidation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractValidationResolver>.NativeClassPtr, 100663312);
			AbstractValidationResolver.NativeMethodInfoPtr_initializeValidatable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractValidationResolver>.NativeClassPtr, 100663313);
			AbstractValidationResolver.NativeMethodInfoPtr_onValidate_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractValidationResolver>.NativeClassPtr, 100663314);
			AbstractValidationResolver.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractValidationResolver>.NativeClassPtr, 100663315);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0000303C File Offset: 0x0000123C
		public unsafe bool Valid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267478, XrefRangeEnd = 1267480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractValidationResolver.NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003078 File Offset: 0x00001278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267480, XrefRangeEnd = 1267484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractValidationResolver.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000030AC File Offset: 0x000012AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267484, XrefRangeEnd = 1267485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractValidationResolver.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000030E0 File Offset: 0x000012E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1267494, RefRangeEnd = 1267495, XrefRangeStart = 1267485, XrefRangeEnd = 1267494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void resolveValidation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractValidationResolver.NativeMethodInfoPtr_resolveValidation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003114 File Offset: 0x00001314
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void initializeValidatable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbstractValidationResolver.NativeMethodInfoPtr_initializeValidatable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003150 File Offset: 0x00001350
		[CallerCount(0)]
		public unsafe virtual void onValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbstractValidationResolver.NativeMethodInfoPtr_onValidate_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000318C File Offset: 0x0000138C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267495, XrefRangeEnd = 1267496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbstractValidationResolver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbstractValidationResolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractValidationResolver.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000217E File Offset: 0x0000037E
		public AbstractValidationResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000031C8 File Offset: 0x000013C8
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00002187 File Offset: 0x00000387
		public unsafe AbstractValidationResolver.ResolveType resolveOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractValidationResolver.NativeFieldInfoPtr_resolveOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractValidationResolver.NativeFieldInfoPtr_resolveOn)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000031F0 File Offset: 0x000013F0
		// (set) Token: 0x06000033 RID: 51 RVA: 0x000021A2 File Offset: 0x000003A2
		public unsafe Il2CppReferenceArray<IValidator> validators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractValidationResolver.NativeFieldInfoPtr_validators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IValidator>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractValidationResolver.NativeFieldInfoPtr_validators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00003220 File Offset: 0x00001420
		// (set) Token: 0x06000035 RID: 53 RVA: 0x000021C1 File Offset: 0x000003C1
		public Nullable<bool> valid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractValidationResolver.NativeFieldInfoPtr_valid);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractValidationResolver.NativeFieldInfoPtr_valid), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_resolveOn;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_validators;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_valid;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_resolveValidation_Private_Void_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_initializeValidatable_Protected_Virtual_New_Void_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_onValidate_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0200001F RID: 31
		public enum ResolveType
		{
			// Token: 0x0400009E RID: 158
			Any,
			// Token: 0x0400009F RID: 159
			All
		}
	}
}
