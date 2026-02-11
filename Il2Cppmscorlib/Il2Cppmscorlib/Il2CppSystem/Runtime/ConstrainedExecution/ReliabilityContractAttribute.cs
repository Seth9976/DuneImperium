using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.ConstrainedExecution
{
	// Token: 0x020003A5 RID: 933
	public sealed class ReliabilityContractAttribute : Attribute
	{
		// Token: 0x060038A9 RID: 14505 RVA: 0x00113AF8 File Offset: 0x00111CF8
		// Note: this type is marked as 'beforefieldinit'.
		static ReliabilityContractAttribute()
		{
			Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.ConstrainedExecution", "ReliabilityContractAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr);
			ReliabilityContractAttribute.NativeFieldInfoPtr__ConsistencyGuarantee_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr, "<ConsistencyGuarantee>k__BackingField");
			ReliabilityContractAttribute.NativeFieldInfoPtr__Cer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr, "<Cer>k__BackingField");
			ReliabilityContractAttribute.NativeMethodInfoPtr__ctor_Public_Void_Consistency_Cer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr, 100671770);
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x00113B64 File Offset: 0x00111D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReliabilityContractAttribute(Consistency consistencyGuarantee, Cer cer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref consistencyGuarantee;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReliabilityContractAttribute.NativeMethodInfoPtr__ctor_Public_Void_Consistency_Cer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x00014C72 File Offset: 0x00012E72
		public ReliabilityContractAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x060038AC RID: 14508 RVA: 0x00113BBC File Offset: 0x00111DBC
		// (set) Token: 0x060038AD RID: 14509 RVA: 0x00014C7B File Offset: 0x00012E7B
		public unsafe Consistency _ConsistencyGuarantee_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReliabilityContractAttribute.NativeFieldInfoPtr__ConsistencyGuarantee_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReliabilityContractAttribute.NativeFieldInfoPtr__ConsistencyGuarantee_k__BackingField)) = value;
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x060038AE RID: 14510 RVA: 0x00113BE4 File Offset: 0x00111DE4
		// (set) Token: 0x060038AF RID: 14511 RVA: 0x00014C96 File Offset: 0x00012E96
		public unsafe Cer _Cer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReliabilityContractAttribute.NativeFieldInfoPtr__Cer_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReliabilityContractAttribute.NativeFieldInfoPtr__Cer_k__BackingField)) = value;
			}
		}

		// Token: 0x04002E4B RID: 11851
		private static readonly IntPtr NativeFieldInfoPtr__ConsistencyGuarantee_k__BackingField;

		// Token: 0x04002E4C RID: 11852
		private static readonly IntPtr NativeFieldInfoPtr__Cer_k__BackingField;

		// Token: 0x04002E4D RID: 11853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Consistency_Cer_0;
	}
}
