using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000388 RID: 904
	public sealed class ComVisibleAttribute : Attribute
	{
		// Token: 0x060037AE RID: 14254 RVA: 0x001102A0 File Offset: 0x0010E4A0
		// Note: this type is marked as 'beforefieldinit'.
		static ComVisibleAttribute()
		{
			Il2CppClassPointerStore<ComVisibleAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ComVisibleAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComVisibleAttribute>.NativeClassPtr);
			ComVisibleAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComVisibleAttribute>.NativeClassPtr, "_val");
			ComVisibleAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComVisibleAttribute>.NativeClassPtr, 100671633);
		}

		// Token: 0x060037AF RID: 14255 RVA: 0x001102F8 File Offset: 0x0010E4F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComVisibleAttribute(bool visibility)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComVisibleAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visibility;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComVisibleAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037B0 RID: 14256 RVA: 0x0001459D File Offset: 0x0001279D
		public ComVisibleAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x060037B1 RID: 14257 RVA: 0x00110340 File Offset: 0x0010E540
		// (set) Token: 0x060037B2 RID: 14258 RVA: 0x000145A6 File Offset: 0x000127A6
		public unsafe bool _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComVisibleAttribute.NativeFieldInfoPtr__val);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComVisibleAttribute.NativeFieldInfoPtr__val)) = value;
			}
		}

		// Token: 0x04002D38 RID: 11576
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x04002D39 RID: 11577
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
