using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000385 RID: 901
	public sealed class ComDefaultInterfaceAttribute : Attribute
	{
		// Token: 0x060037A4 RID: 14244 RVA: 0x00110104 File Offset: 0x0010E304
		// Note: this type is marked as 'beforefieldinit'.
		static ComDefaultInterfaceAttribute()
		{
			Il2CppClassPointerStore<ComDefaultInterfaceAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ComDefaultInterfaceAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComDefaultInterfaceAttribute>.NativeClassPtr);
			ComDefaultInterfaceAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComDefaultInterfaceAttribute>.NativeClassPtr, "_val");
			ComDefaultInterfaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComDefaultInterfaceAttribute>.NativeClassPtr, 100671631);
		}

		// Token: 0x060037A5 RID: 14245 RVA: 0x0011015C File Offset: 0x0010E35C
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComDefaultInterfaceAttribute(Type defaultInterface)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComDefaultInterfaceAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(defaultInterface);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComDefaultInterfaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x00014551 File Offset: 0x00012751
		public ComDefaultInterfaceAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x060037A7 RID: 14247 RVA: 0x001101A8 File Offset: 0x0010E3A8
		// (set) Token: 0x060037A8 RID: 14248 RVA: 0x0001455A File Offset: 0x0001275A
		public unsafe Type _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComDefaultInterfaceAttribute.NativeFieldInfoPtr__val);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComDefaultInterfaceAttribute.NativeFieldInfoPtr__val), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002D30 RID: 11568
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x04002D31 RID: 11569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
