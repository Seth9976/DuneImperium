using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngineInternal
{
	// Token: 0x02000007 RID: 7
	[Serializable]
	public class TypeInferenceRuleAttribute : Attribute
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00016B48 File Offset: 0x00014D48
		// Note: this type is marked as 'beforefieldinit'.
		static TypeInferenceRuleAttribute()
		{
			Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngineInternal", "TypeInferenceRuleAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr);
			TypeInferenceRuleAttribute.NativeFieldInfoPtr__rule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr, "_rule");
			TypeInferenceRuleAttribute.NativeMethodInfoPtr__ctor_Public_Void_TypeInferenceRules_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr, 100663301);
			TypeInferenceRuleAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr, 100663302);
			TypeInferenceRuleAttribute.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr, 100663303);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00016BC8 File Offset: 0x00014DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642845, XrefRangeEnd = 642850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeInferenceRuleAttribute(TypeInferenceRules rule)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rule;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInferenceRuleAttribute.NativeMethodInfoPtr__ctor_Public_Void_TypeInferenceRules_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00016C10 File Offset: 0x00014E10
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeInferenceRuleAttribute(string rule)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(rule);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInferenceRuleAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00016C5C File Offset: 0x00014E5C
		[CallerCount(169)]
		[CachedScanResults(RefRangeStart = 282426, RefRangeEnd = 282595, XrefRangeStart = 282426, XrefRangeEnd = 282595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeInferenceRuleAttribute.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002152 File Offset: 0x00000352
		public TypeInferenceRuleAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00016CA0 File Offset: 0x00014EA0
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000215B File Offset: 0x0000035B
		public unsafe string _rule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInferenceRuleAttribute.NativeFieldInfoPtr__rule);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInferenceRuleAttribute.NativeFieldInfoPtr__rule), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr__rule;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TypeInferenceRules_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
