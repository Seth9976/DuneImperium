using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppMicrosoft.Extensions.Options
{
	// Token: 0x02000020 RID: 32
	public class ValidateOptionsResult : Object
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x00004DC4 File Offset: 0x00002FC4
		// Note: this type is marked as 'beforefieldinit'.
		static ValidateOptionsResult()
		{
			Il2CppClassPointerStore<ValidateOptionsResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "Microsoft.Extensions.Options", "ValidateOptionsResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidateOptionsResult>.NativeClassPtr);
			ValidateOptionsResult.NativeFieldInfoPtr_Skip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateOptionsResult>.NativeClassPtr, "Skip");
			ValidateOptionsResult.NativeFieldInfoPtr_Success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateOptionsResult>.NativeClassPtr, "Success");
			ValidateOptionsResult.NativeFieldInfoPtr__Succeeded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateOptionsResult>.NativeClassPtr, "<Succeeded>k__BackingField");
			ValidateOptionsResult.NativeFieldInfoPtr__Skipped_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateOptionsResult>.NativeClassPtr, "<Skipped>k__BackingField");
			ValidateOptionsResult.NativeFieldInfoPtr__Failed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateOptionsResult>.NativeClassPtr, "<Failed>k__BackingField");
			ValidateOptionsResult.NativeFieldInfoPtr__Failures_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateOptionsResult>.NativeClassPtr, "<Failures>k__BackingField");
			ValidateOptionsResult.NativeMethodInfoPtr_set_Succeeded_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateOptionsResult>.NativeClassPtr, 100663374);
			ValidateOptionsResult.NativeMethodInfoPtr_set_Skipped_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateOptionsResult>.NativeClassPtr, 100663375);
			ValidateOptionsResult.NativeMethodInfoPtr_get_Failed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateOptionsResult>.NativeClassPtr, 100663376);
			ValidateOptionsResult.NativeMethodInfoPtr_get_Failures_Public_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateOptionsResult>.NativeClassPtr, 100663377);
			ValidateOptionsResult.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateOptionsResult>.NativeClassPtr, 100663378);
		}

		// Token: 0x1700002A RID: 42
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00004ED0 File Offset: 0x000030D0
		public unsafe bool Succeeded
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateOptionsResult.NativeMethodInfoPtr_set_Succeeded_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00004F10 File Offset: 0x00003110
		public unsafe bool Skipped
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateOptionsResult.NativeMethodInfoPtr_set_Skipped_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00004F50 File Offset: 0x00003150
		public unsafe bool Failed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateOptionsResult.NativeMethodInfoPtr_get_Failed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00004F8C File Offset: 0x0000318C
		public unsafe IEnumerable<string> Failures
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateOptionsResult.NativeMethodInfoPtr_get_Failures_Public_get_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00004FCC File Offset: 0x000031CC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidateOptionsResult()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidateOptionsResult>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateOptionsResult.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000251F File Offset: 0x0000071F
		public ValidateOptionsResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00005008 File Offset: 0x00003208
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00002528 File Offset: 0x00000728
		public unsafe static ValidateOptionsResult Skip
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ValidateOptionsResult.NativeFieldInfoPtr_Skip, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidateOptionsResult>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValidateOptionsResult.NativeFieldInfoPtr_Skip, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00005030 File Offset: 0x00003230
		// (set) Token: 0x060000AF RID: 175 RVA: 0x0000253A File Offset: 0x0000073A
		public unsafe static ValidateOptionsResult Success
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ValidateOptionsResult.NativeFieldInfoPtr_Success, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidateOptionsResult>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValidateOptionsResult.NativeFieldInfoPtr_Success, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00005058 File Offset: 0x00003258
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x0000254C File Offset: 0x0000074C
		public unsafe bool _Succeeded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateOptionsResult.NativeFieldInfoPtr__Succeeded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateOptionsResult.NativeFieldInfoPtr__Succeeded_k__BackingField)) = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00005080 File Offset: 0x00003280
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00002567 File Offset: 0x00000767
		public unsafe bool _Skipped_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateOptionsResult.NativeFieldInfoPtr__Skipped_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateOptionsResult.NativeFieldInfoPtr__Skipped_k__BackingField)) = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000050A8 File Offset: 0x000032A8
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00002582 File Offset: 0x00000782
		public unsafe bool _Failed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateOptionsResult.NativeFieldInfoPtr__Failed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateOptionsResult.NativeFieldInfoPtr__Failed_k__BackingField)) = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000050D0 File Offset: 0x000032D0
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000259D File Offset: 0x0000079D
		public unsafe IEnumerable<string> _Failures_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateOptionsResult.NativeFieldInfoPtr__Failures_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidateOptionsResult.NativeFieldInfoPtr__Failures_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_Skip;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_Success;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr__Succeeded_k__BackingField;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr__Skipped_k__BackingField;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr__Failed_k__BackingField;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr__Failures_k__BackingField;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_set_Succeeded_Protected_set_Void_Boolean_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_set_Skipped_Protected_set_Void_Boolean_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_get_Failed_Public_get_Boolean_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_get_Failures_Public_get_IEnumerable_1_String_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
