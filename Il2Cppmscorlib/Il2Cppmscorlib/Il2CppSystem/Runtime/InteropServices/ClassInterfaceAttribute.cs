using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000387 RID: 903
	public sealed class ClassInterfaceAttribute : Attribute
	{
		// Token: 0x060037A9 RID: 14249 RVA: 0x001101D8 File Offset: 0x0010E3D8
		// Note: this type is marked as 'beforefieldinit'.
		static ClassInterfaceAttribute()
		{
			Il2CppClassPointerStore<ClassInterfaceAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ClassInterfaceAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClassInterfaceAttribute>.NativeClassPtr);
			ClassInterfaceAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassInterfaceAttribute>.NativeClassPtr, "_val");
			ClassInterfaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_ClassInterfaceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassInterfaceAttribute>.NativeClassPtr, 100671632);
		}

		// Token: 0x060037AA RID: 14250 RVA: 0x00110230 File Offset: 0x0010E430
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClassInterfaceAttribute(ClassInterfaceType classInterfaceType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClassInterfaceAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref classInterfaceType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassInterfaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_ClassInterfaceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037AB RID: 14251 RVA: 0x00014579 File Offset: 0x00012779
		public ClassInterfaceAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x060037AC RID: 14252 RVA: 0x00110278 File Offset: 0x0010E478
		// (set) Token: 0x060037AD RID: 14253 RVA: 0x00014582 File Offset: 0x00012782
		public unsafe ClassInterfaceType _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassInterfaceAttribute.NativeFieldInfoPtr__val);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClassInterfaceAttribute.NativeFieldInfoPtr__val)) = value;
			}
		}

		// Token: 0x04002D36 RID: 11574
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x04002D37 RID: 11575
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ClassInterfaceType_0;
	}
}
