using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x020004B1 RID: 1201
	public sealed class MaybeNullWhenAttribute : Attribute
	{
		// Token: 0x06004A21 RID: 18977 RVA: 0x00157060 File Offset: 0x00155260
		// Note: this type is marked as 'beforefieldinit'.
		static MaybeNullWhenAttribute()
		{
			Il2CppClassPointerStore<MaybeNullWhenAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.CodeAnalysis", "MaybeNullWhenAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaybeNullWhenAttribute>.NativeClassPtr);
			MaybeNullWhenAttribute.NativeFieldInfoPtr__ReturnValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaybeNullWhenAttribute>.NativeClassPtr, "<ReturnValue>k__BackingField");
			MaybeNullWhenAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaybeNullWhenAttribute>.NativeClassPtr, 100674081);
		}

		// Token: 0x06004A22 RID: 18978 RVA: 0x001570B8 File Offset: 0x001552B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaybeNullWhenAttribute(bool returnValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaybeNullWhenAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref returnValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaybeNullWhenAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004A23 RID: 18979 RVA: 0x0001B2E3 File Offset: 0x000194E3
		public MaybeNullWhenAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x06004A24 RID: 18980 RVA: 0x00157100 File Offset: 0x00155300
		// (set) Token: 0x06004A25 RID: 18981 RVA: 0x0001B2EC File Offset: 0x000194EC
		public unsafe bool _ReturnValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaybeNullWhenAttribute.NativeFieldInfoPtr__ReturnValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaybeNullWhenAttribute.NativeFieldInfoPtr__ReturnValue_k__BackingField)) = value;
			}
		}

		// Token: 0x04003CC6 RID: 15558
		private static readonly IntPtr NativeFieldInfoPtr__ReturnValue_k__BackingField;

		// Token: 0x04003CC7 RID: 15559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
