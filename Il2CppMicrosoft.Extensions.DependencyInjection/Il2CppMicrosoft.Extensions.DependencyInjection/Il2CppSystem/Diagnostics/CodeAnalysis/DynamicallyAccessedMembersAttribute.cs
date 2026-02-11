using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x02000009 RID: 9
	public sealed class DynamicallyAccessedMembersAttribute : Attribute
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00004004 File Offset: 0x00002204
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicallyAccessedMembersAttribute()
		{
			Il2CppClassPointerStore<DynamicallyAccessedMembersAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "System.Diagnostics.CodeAnalysis", "DynamicallyAccessedMembersAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicallyAccessedMembersAttribute>.NativeClassPtr);
			DynamicallyAccessedMembersAttribute.NativeFieldInfoPtr__MemberTypes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicallyAccessedMembersAttribute>.NativeClassPtr, "<MemberTypes>k__BackingField");
			DynamicallyAccessedMembersAttribute.NativeMethodInfoPtr__ctor_Public_Void_DynamicallyAccessedMemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicallyAccessedMembersAttribute>.NativeClassPtr, 100663333);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000405C File Offset: 0x0000225C
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

		// Token: 0x06000041 RID: 65 RVA: 0x0000218B File Offset: 0x0000038B
		public DynamicallyAccessedMembersAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000040A4 File Offset: 0x000022A4
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002194 File Offset: 0x00000394
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

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr__MemberTypes_k__BackingField;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DynamicallyAccessedMemberTypes_0;
	}
}
