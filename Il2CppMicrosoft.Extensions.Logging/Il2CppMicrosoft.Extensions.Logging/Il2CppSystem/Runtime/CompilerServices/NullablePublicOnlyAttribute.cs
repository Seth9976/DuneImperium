using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000005 RID: 5
	public sealed class NullablePublicOnlyAttribute : Attribute
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002B6C File Offset: 0x00000D6C
		// Note: this type is marked as 'beforefieldinit'.
		static NullablePublicOnlyAttribute()
		{
			Il2CppClassPointerStore<NullablePublicOnlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.dll", "System.Runtime.CompilerServices", "NullablePublicOnlyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullablePublicOnlyAttribute>.NativeClassPtr);
			NullablePublicOnlyAttribute.NativeFieldInfoPtr_IncludesInternals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullablePublicOnlyAttribute>.NativeClassPtr, "IncludesInternals");
			NullablePublicOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullablePublicOnlyAttribute>.NativeClassPtr, 100663301);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002BC4 File Offset: 0x00000DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullablePublicOnlyAttribute(bool A_1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullablePublicOnlyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullablePublicOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020DE File Offset: 0x000002DE
		public NullablePublicOnlyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002C0C File Offset: 0x00000E0C
		// (set) Token: 0x06000013 RID: 19 RVA: 0x000020E7 File Offset: 0x000002E7
		public unsafe bool IncludesInternals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullablePublicOnlyAttribute.NativeFieldInfoPtr_IncludesInternals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullablePublicOnlyAttribute.NativeFieldInfoPtr_IncludesInternals)) = value;
			}
		}

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr_IncludesInternals;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
