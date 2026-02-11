using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000394 RID: 916
	public sealed class FieldOffsetAttribute : Attribute
	{
		// Token: 0x060037E5 RID: 14309 RVA: 0x00110AA4 File Offset: 0x0010ECA4
		// Note: this type is marked as 'beforefieldinit'.
		static FieldOffsetAttribute()
		{
			Il2CppClassPointerStore<FieldOffsetAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "FieldOffsetAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldOffsetAttribute>.NativeClassPtr);
			FieldOffsetAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldOffsetAttribute>.NativeClassPtr, "_val");
			FieldOffsetAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldOffsetAttribute>.NativeClassPtr, 100671646);
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x00110AFC File Offset: 0x0010ECFC
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldOffsetAttribute(int offset)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldOffsetAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldOffsetAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037E7 RID: 14311 RVA: 0x0001485B File Offset: 0x00012A5B
		public FieldOffsetAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x060037E8 RID: 14312 RVA: 0x00110B44 File Offset: 0x0010ED44
		// (set) Token: 0x060037E9 RID: 14313 RVA: 0x00014864 File Offset: 0x00012A64
		public unsafe int _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldOffsetAttribute.NativeFieldInfoPtr__val);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldOffsetAttribute.NativeFieldInfoPtr__val)) = value;
			}
		}

		// Token: 0x04002DAD RID: 11693
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x04002DAE RID: 11694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
	}
}
