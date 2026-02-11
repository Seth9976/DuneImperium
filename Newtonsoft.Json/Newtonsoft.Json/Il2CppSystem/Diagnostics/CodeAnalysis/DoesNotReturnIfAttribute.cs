using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x0200000A RID: 10
	public class DoesNotReturnIfAttribute : Attribute
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00012304 File Offset: 0x00010504
		// Note: this type is marked as 'beforefieldinit'.
		static DoesNotReturnIfAttribute()
		{
			Il2CppClassPointerStore<DoesNotReturnIfAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "System.Diagnostics.CodeAnalysis", "DoesNotReturnIfAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoesNotReturnIfAttribute>.NativeClassPtr);
			DoesNotReturnIfAttribute.NativeFieldInfoPtr__ParameterValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoesNotReturnIfAttribute>.NativeClassPtr, "<ParameterValue>k__BackingField");
			DoesNotReturnIfAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoesNotReturnIfAttribute>.NativeClassPtr, 100663307);
			DoesNotReturnIfAttribute.NativeMethodInfoPtr_get_ParameterValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoesNotReturnIfAttribute>.NativeClassPtr, 100663308);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00012370 File Offset: 0x00010570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoesNotReturnIfAttribute(bool parameterValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoesNotReturnIfAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref parameterValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoesNotReturnIfAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000123B8 File Offset: 0x000105B8
		public unsafe bool ParameterValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoesNotReturnIfAttribute.NativeMethodInfoPtr_get_ParameterValue_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000220A File Offset: 0x0000040A
		public DoesNotReturnIfAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000123F4 File Offset: 0x000105F4
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002213 File Offset: 0x00000413
		public unsafe bool _ParameterValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoesNotReturnIfAttribute.NativeFieldInfoPtr__ParameterValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoesNotReturnIfAttribute.NativeFieldInfoPtr__ParameterValue_k__BackingField)) = value;
			}
		}

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr__ParameterValue_k__BackingField;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_get_ParameterValue_Public_get_Boolean_0;
	}
}
