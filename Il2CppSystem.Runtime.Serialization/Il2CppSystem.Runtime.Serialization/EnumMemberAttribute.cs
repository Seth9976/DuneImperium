using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000004 RID: 4
	public sealed class EnumMemberAttribute : Attribute
	{
		// Token: 0x06000014 RID: 20 RVA: 0x0000245C File Offset: 0x0000065C
		// Note: this type is marked as 'beforefieldinit'.
		static EnumMemberAttribute()
		{
			Il2CppClassPointerStore<EnumMemberAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Runtime.Serialization.dll", "System.Runtime.Serialization", "EnumMemberAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumMemberAttribute>.NativeClassPtr);
			EnumMemberAttribute.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumMemberAttribute>.NativeClassPtr, "value");
			EnumMemberAttribute.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumMemberAttribute>.NativeClassPtr, 100663302);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000024B4 File Offset: 0x000006B4
		public unsafe string Value
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumMemberAttribute.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020ED File Offset: 0x000002ED
		public EnumMemberAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000024EC File Offset: 0x000006EC
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000020F6 File Offset: 0x000002F6
		public unsafe string value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMemberAttribute.NativeFieldInfoPtr_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumMemberAttribute.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;
	}
}
