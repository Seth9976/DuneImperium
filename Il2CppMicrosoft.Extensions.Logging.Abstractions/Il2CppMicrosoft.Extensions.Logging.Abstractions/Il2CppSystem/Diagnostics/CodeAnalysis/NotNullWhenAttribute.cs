using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x0200000A RID: 10
	public sealed class NotNullWhenAttribute : Attribute
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00002C24 File Offset: 0x00000E24
		// Note: this type is marked as 'beforefieldinit'.
		static NotNullWhenAttribute()
		{
			Il2CppClassPointerStore<NotNullWhenAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.Abstractions.dll", "System.Diagnostics.CodeAnalysis", "NotNullWhenAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotNullWhenAttribute>.NativeClassPtr);
			NotNullWhenAttribute.NativeFieldInfoPtr__ReturnValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotNullWhenAttribute>.NativeClassPtr, "<ReturnValue>k__BackingField");
			NotNullWhenAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotNullWhenAttribute>.NativeClassPtr, 100663307);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002C7C File Offset: 0x00000E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotNullWhenAttribute(bool returnValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotNullWhenAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref returnValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotNullWhenAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000021B3 File Offset: 0x000003B3
		public NotNullWhenAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002CC4 File Offset: 0x00000EC4
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000021BC File Offset: 0x000003BC
		public unsafe bool _ReturnValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotNullWhenAttribute.NativeFieldInfoPtr__ReturnValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotNullWhenAttribute.NativeFieldInfoPtr__ReturnValue_k__BackingField)) = value;
			}
		}

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr__ReturnValue_k__BackingField;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
