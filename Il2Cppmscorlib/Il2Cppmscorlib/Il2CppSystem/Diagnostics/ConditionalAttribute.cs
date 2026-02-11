using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x0200049A RID: 1178
	[Serializable]
	public sealed class ConditionalAttribute : Attribute
	{
		// Token: 0x0600496B RID: 18795 RVA: 0x00154A30 File Offset: 0x00152C30
		// Note: this type is marked as 'beforefieldinit'.
		static ConditionalAttribute()
		{
			Il2CppClassPointerStore<ConditionalAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "ConditionalAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalAttribute>.NativeClassPtr);
			ConditionalAttribute.NativeFieldInfoPtr__ConditionString_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalAttribute>.NativeClassPtr, "<ConditionString>k__BackingField");
			ConditionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalAttribute>.NativeClassPtr, 100674000);
		}

		// Token: 0x0600496C RID: 18796 RVA: 0x00154A88 File Offset: 0x00152C88
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConditionalAttribute(string conditionString)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionalAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(conditionString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600496D RID: 18797 RVA: 0x0001ACF0 File Offset: 0x00018EF0
		public ConditionalAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x0600496E RID: 18798 RVA: 0x00154AD4 File Offset: 0x00152CD4
		// (set) Token: 0x0600496F RID: 18799 RVA: 0x0001ACF9 File Offset: 0x00018EF9
		public unsafe string _ConditionString_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalAttribute.NativeFieldInfoPtr__ConditionString_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalAttribute.NativeFieldInfoPtr__ConditionString_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003C3D RID: 15421
		private static readonly IntPtr NativeFieldInfoPtr__ConditionString_k__BackingField;

		// Token: 0x04003C3E RID: 15422
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
