using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000384 RID: 900
	public sealed class InterfaceTypeAttribute : Attribute
	{
		// Token: 0x0600379F RID: 14239 RVA: 0x0011003C File Offset: 0x0010E23C
		// Note: this type is marked as 'beforefieldinit'.
		static InterfaceTypeAttribute()
		{
			Il2CppClassPointerStore<InterfaceTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "InterfaceTypeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InterfaceTypeAttribute>.NativeClassPtr);
			InterfaceTypeAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceTypeAttribute>.NativeClassPtr, "_val");
			InterfaceTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_ComInterfaceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterfaceTypeAttribute>.NativeClassPtr, 100671630);
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x00110094 File Offset: 0x0010E294
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InterfaceTypeAttribute(ComInterfaceType interfaceType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InterfaceTypeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref interfaceType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterfaceTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_ComInterfaceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x0001452D File Offset: 0x0001272D
		public InterfaceTypeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x060037A2 RID: 14242 RVA: 0x001100DC File Offset: 0x0010E2DC
		// (set) Token: 0x060037A3 RID: 14243 RVA: 0x00014536 File Offset: 0x00012736
		public unsafe ComInterfaceType _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterfaceTypeAttribute.NativeFieldInfoPtr__val);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterfaceTypeAttribute.NativeFieldInfoPtr__val)) = value;
			}
		}

		// Token: 0x04002D2E RID: 11566
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x04002D2F RID: 11567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComInterfaceType_0;
	}
}
