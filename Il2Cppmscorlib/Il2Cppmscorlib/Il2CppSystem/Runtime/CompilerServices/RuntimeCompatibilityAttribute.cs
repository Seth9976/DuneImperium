using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003C0 RID: 960
	[Serializable]
	public sealed class RuntimeCompatibilityAttribute : Attribute
	{
		// Token: 0x06003932 RID: 14642 RVA: 0x00115230 File Offset: 0x00113430
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeCompatibilityAttribute()
		{
			Il2CppClassPointerStore<RuntimeCompatibilityAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "RuntimeCompatibilityAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeCompatibilityAttribute>.NativeClassPtr);
			RuntimeCompatibilityAttribute.NativeFieldInfoPtr__WrapNonExceptionThrows_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeCompatibilityAttribute>.NativeClassPtr, "<WrapNonExceptionThrows>k__BackingField");
			RuntimeCompatibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeCompatibilityAttribute>.NativeClassPtr, 100671832);
			RuntimeCompatibilityAttribute.NativeMethodInfoPtr_set_WrapNonExceptionThrows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeCompatibilityAttribute>.NativeClassPtr, 100671833);
		}

		// Token: 0x06003933 RID: 14643 RVA: 0x0011529C File Offset: 0x0011349C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeCompatibilityAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeCompatibilityAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeCompatibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D5E RID: 3422
		// (set) Token: 0x06003934 RID: 14644 RVA: 0x001152D8 File Offset: 0x001134D8
		public unsafe bool WrapNonExceptionThrows
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeCompatibilityAttribute.NativeMethodInfoPtr_set_WrapNonExceptionThrows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003935 RID: 14645 RVA: 0x000152C9 File Offset: 0x000134C9
		public RuntimeCompatibilityAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06003936 RID: 14646 RVA: 0x00115318 File Offset: 0x00113518
		// (set) Token: 0x06003937 RID: 14647 RVA: 0x000152D2 File Offset: 0x000134D2
		public unsafe bool _WrapNonExceptionThrows_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeCompatibilityAttribute.NativeFieldInfoPtr__WrapNonExceptionThrows_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeCompatibilityAttribute.NativeFieldInfoPtr__WrapNonExceptionThrows_k__BackingField)) = value;
			}
		}

		// Token: 0x04002E89 RID: 11913
		private static readonly IntPtr NativeFieldInfoPtr__WrapNonExceptionThrows_k__BackingField;

		// Token: 0x04002E8A RID: 11914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002E8B RID: 11915
		private static readonly IntPtr NativeMethodInfoPtr_set_WrapNonExceptionThrows_Public_set_Void_Boolean_0;
	}
}
