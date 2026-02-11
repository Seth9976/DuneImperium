using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x02000008 RID: 8
	public sealed class DynamicallyAccessedMembersAttribute : Attribute
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002C7C File Offset: 0x00000E7C
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicallyAccessedMembersAttribute()
		{
			Il2CppClassPointerStore<DynamicallyAccessedMembersAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "System.Diagnostics.CodeAnalysis", "DynamicallyAccessedMembersAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicallyAccessedMembersAttribute>.NativeClassPtr);
			DynamicallyAccessedMembersAttribute.NativeFieldInfoPtr__MemberTypes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicallyAccessedMembersAttribute>.NativeClassPtr, "<MemberTypes>k__BackingField");
			DynamicallyAccessedMembersAttribute.NativeMethodInfoPtr__ctor_Public_Void_DynamicallyAccessedMemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicallyAccessedMembersAttribute>.NativeClassPtr, 100663305);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002CD4 File Offset: 0x00000ED4
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicallyAccessedMembersAttribute(DynamicallyAccessedMemberTypes memberTypes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicallyAccessedMembersAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref memberTypes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicallyAccessedMembersAttribute.NativeMethodInfoPtr__ctor_Public_Void_DynamicallyAccessedMemberTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000212F File Offset: 0x0000032F
		public DynamicallyAccessedMembersAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002D1C File Offset: 0x00000F1C
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002138 File Offset: 0x00000338
		public unsafe DynamicallyAccessedMemberTypes _MemberTypes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicallyAccessedMembersAttribute.NativeFieldInfoPtr__MemberTypes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicallyAccessedMembersAttribute.NativeFieldInfoPtr__MemberTypes_k__BackingField)) = value;
			}
		}

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr__MemberTypes_k__BackingField;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DynamicallyAccessedMemberTypes_0;
	}
}
