using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x0200000A RID: 10
	public sealed class DynamicallyAccessedMembersAttribute : Attribute
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00002CE8 File Offset: 0x00000EE8
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicallyAccessedMembersAttribute()
		{
			Il2CppClassPointerStore<DynamicallyAccessedMembersAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.Abstractions.dll", "System.Diagnostics.CodeAnalysis", "DynamicallyAccessedMembersAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicallyAccessedMembersAttribute>.NativeClassPtr);
			DynamicallyAccessedMembersAttribute.NativeFieldInfoPtr__MemberTypes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicallyAccessedMembersAttribute>.NativeClassPtr, "<MemberTypes>k__BackingField");
			DynamicallyAccessedMembersAttribute.NativeMethodInfoPtr__ctor_Public_Void_DynamicallyAccessedMemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicallyAccessedMembersAttribute>.NativeClassPtr, 100663316);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002D40 File Offset: 0x00000F40
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

		// Token: 0x06000031 RID: 49 RVA: 0x00002186 File Offset: 0x00000386
		public DynamicallyAccessedMembersAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002D88 File Offset: 0x00000F88
		// (set) Token: 0x06000033 RID: 51 RVA: 0x0000218F File Offset: 0x0000038F
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

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr__MemberTypes_k__BackingField;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DynamicallyAccessedMemberTypes_0;
	}
}
