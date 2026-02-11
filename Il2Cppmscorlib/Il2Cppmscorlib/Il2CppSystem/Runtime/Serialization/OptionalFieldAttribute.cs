using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000334 RID: 820
	public sealed class OptionalFieldAttribute : Attribute
	{
		// Token: 0x06003227 RID: 12839 RVA: 0x000FDC4C File Offset: 0x000FBE4C
		// Note: this type is marked as 'beforefieldinit'.
		static OptionalFieldAttribute()
		{
			Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "OptionalFieldAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr);
			OptionalFieldAttribute.NativeFieldInfoPtr_versionAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr, "versionAdded");
			OptionalFieldAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr, 100671153);
			OptionalFieldAttribute.NativeMethodInfoPtr_set_VersionAdded_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr, 100671154);
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x000FDCB8 File Offset: 0x000FBEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1386094, XrefRangeEnd = 1386095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionalFieldAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFieldAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B59 RID: 2905
		// (set) Token: 0x06003229 RID: 12841 RVA: 0x000FDCF4 File Offset: 0x000FBEF4
		public unsafe int VersionAdded
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFieldAttribute.NativeMethodInfoPtr_set_VersionAdded_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x0001159F File Offset: 0x0000F79F
		public OptionalFieldAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x0600322B RID: 12843 RVA: 0x000FDD34 File Offset: 0x000FBF34
		// (set) Token: 0x0600322C RID: 12844 RVA: 0x000115A8 File Offset: 0x0000F7A8
		public unsafe int versionAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionalFieldAttribute.NativeFieldInfoPtr_versionAdded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionalFieldAttribute.NativeFieldInfoPtr_versionAdded)) = value;
			}
		}

		// Token: 0x04002927 RID: 10535
		private static readonly IntPtr NativeFieldInfoPtr_versionAdded;

		// Token: 0x04002928 RID: 10536
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002929 RID: 10537
		private static readonly IntPtr NativeMethodInfoPtr_set_VersionAdded_Public_set_Void_Int32_0;
	}
}
