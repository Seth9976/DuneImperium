using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace validators
{
	// Token: 0x02000016 RID: 22
	public class ReferenceValidator : MonoBehaviour
	{
		// Token: 0x060000AF RID: 175 RVA: 0x0000494C File Offset: 0x00002B4C
		// Note: this type is marked as 'beforefieldinit'.
		static ReferenceValidator()
		{
			Il2CppClassPointerStore<ReferenceValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("validators.dll", "validators", "ReferenceValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReferenceValidator>.NativeClassPtr);
			ReferenceValidator.NativeFieldInfoPtr_references = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceValidator>.NativeClassPtr, "references");
			ReferenceValidator.NativeFieldInfoPtr__Valid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceValidator>.NativeClassPtr, "<Valid>k__BackingField");
			ReferenceValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceValidator>.NativeClassPtr, 100663366);
			ReferenceValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceValidator>.NativeClassPtr, 100663367);
			ReferenceValidator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceValidator>.NativeClassPtr, 100663368);
			ReferenceValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceValidator>.NativeClassPtr, 100663369);
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000049F4 File Offset: 0x00002BF4
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00004A30 File Offset: 0x00002C30
		public unsafe virtual bool Valid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferenceValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferenceValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00004A70 File Offset: 0x00002C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267742, XrefRangeEnd = 1267749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferenceValidator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00004AA4 File Offset: 0x00002CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267749, XrefRangeEnd = 1267754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReferenceValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReferenceValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferenceValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000253C File Offset: 0x0000073C
		public ReferenceValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00004AE0 File Offset: 0x00002CE0
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002545 File Offset: 0x00000745
		public unsafe Il2CppReferenceArray<ReferenceValidator.ValidatorReference> references
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReferenceValidator.NativeFieldInfoPtr_references);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ReferenceValidator.ValidatorReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReferenceValidator.NativeFieldInfoPtr_references), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00004B10 File Offset: 0x00002D10
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002564 File Offset: 0x00000764
		public unsafe bool _Valid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReferenceValidator.NativeFieldInfoPtr__Valid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReferenceValidator.NativeFieldInfoPtr__Valid_k__BackingField)) = value;
			}
		}

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_references;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr__Valid_k__BackingField;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000021 RID: 33
		[Serializable]
		public class ValidatorReference : global::Il2CppSystem.Object
		{
			// Token: 0x06000114 RID: 276 RVA: 0x00005A70 File Offset: 0x00003C70
			// Note: this type is marked as 'beforefieldinit'.
			static ValidatorReference()
			{
				Il2CppClassPointerStore<ReferenceValidator.ValidatorReference>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReferenceValidator>.NativeClassPtr, "ValidatorReference");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReferenceValidator.ValidatorReference>.NativeClassPtr);
				ReferenceValidator.ValidatorReference.NativeFieldInfoPtr_reference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceValidator.ValidatorReference>.NativeClassPtr, "reference");
				ReferenceValidator.ValidatorReference.NativeFieldInfoPtr_invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceValidator.ValidatorReference>.NativeClassPtr, "invert");
				ReferenceValidator.ValidatorReference.NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceValidator.ValidatorReference>.NativeClassPtr, 100663370);
				ReferenceValidator.ValidatorReference.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceValidator.ValidatorReference>.NativeClassPtr, 100663371);
				ReferenceValidator.ValidatorReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceValidator.ValidatorReference>.NativeClassPtr, 100663372);
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x06000115 RID: 277 RVA: 0x00005B00 File Offset: 0x00003D00
			public unsafe bool Valid
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267722, XrefRangeEnd = 1267728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferenceValidator.ValidatorReference.NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000116 RID: 278 RVA: 0x00005B3C File Offset: 0x00003D3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267728, XrefRangeEnd = 1267734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReferenceValidator.ValidatorReference.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06000117 RID: 279 RVA: 0x00005B80 File Offset: 0x00003D80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267734, XrefRangeEnd = 1267742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValidatorReference()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReferenceValidator.ValidatorReference>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferenceValidator.ValidatorReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000118 RID: 280 RVA: 0x0000283B File Offset: 0x00000A3B
			public ValidatorReference(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x06000119 RID: 281 RVA: 0x00005BBC File Offset: 0x00003DBC
			// (set) Token: 0x0600011A RID: 282 RVA: 0x00002844 File Offset: 0x00000A44
			public unsafe SerializedInterface<IValidator> reference
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReferenceValidator.ValidatorReference.NativeFieldInfoPtr_reference);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedInterface<IValidator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReferenceValidator.ValidatorReference.NativeFieldInfoPtr_reference), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x0600011B RID: 283 RVA: 0x00005BEC File Offset: 0x00003DEC
			// (set) Token: 0x0600011C RID: 284 RVA: 0x00002863 File Offset: 0x00000A63
			public unsafe bool invert
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReferenceValidator.ValidatorReference.NativeFieldInfoPtr_invert);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReferenceValidator.ValidatorReference.NativeFieldInfoPtr_invert)) = value;
				}
			}

			// Token: 0x040000A4 RID: 164
			private static readonly IntPtr NativeFieldInfoPtr_reference;

			// Token: 0x040000A5 RID: 165
			private static readonly IntPtr NativeFieldInfoPtr_invert;

			// Token: 0x040000A6 RID: 166
			private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0;

			// Token: 0x040000A7 RID: 167
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x040000A8 RID: 168
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
