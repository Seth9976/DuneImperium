using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000408 RID: 1032
	public sealed class DefaultMemberAttribute : Attribute
	{
		// Token: 0x06003BCF RID: 15311 RVA: 0x0011ED10 File Offset: 0x0011CF10
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultMemberAttribute()
		{
			Il2CppClassPointerStore<DefaultMemberAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "DefaultMemberAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultMemberAttribute>.NativeClassPtr);
			DefaultMemberAttribute.NativeFieldInfoPtr__MemberName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultMemberAttribute>.NativeClassPtr, "<MemberName>k__BackingField");
			DefaultMemberAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMemberAttribute>.NativeClassPtr, 100672205);
			DefaultMemberAttribute.NativeMethodInfoPtr_get_MemberName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMemberAttribute>.NativeClassPtr, 100672206);
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x0011ED7C File Offset: 0x0011CF7C
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultMemberAttribute(string memberName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultMemberAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(memberName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultMemberAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06003BD1 RID: 15313 RVA: 0x0011EDC8 File Offset: 0x0011CFC8
		public unsafe string MemberName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultMemberAttribute.NativeMethodInfoPtr_get_MemberName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x0001645A File Offset: 0x0001465A
		public DefaultMemberAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06003BD3 RID: 15315 RVA: 0x0011EE00 File Offset: 0x0011D000
		// (set) Token: 0x06003BD4 RID: 15316 RVA: 0x00016463 File Offset: 0x00014663
		public unsafe string _MemberName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultMemberAttribute.NativeFieldInfoPtr__MemberName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultMemberAttribute.NativeFieldInfoPtr__MemberName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003066 RID: 12390
		private static readonly IntPtr NativeFieldInfoPtr__MemberName_k__BackingField;

		// Token: 0x04003067 RID: 12391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04003068 RID: 12392
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberName_Public_get_String_0;
	}
}
