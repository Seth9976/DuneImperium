using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x020004B2 RID: 1202
	public sealed class NotNullWhenAttribute : Attribute
	{
		// Token: 0x06004A26 RID: 18982 RVA: 0x00157128 File Offset: 0x00155328
		// Note: this type is marked as 'beforefieldinit'.
		static NotNullWhenAttribute()
		{
			Il2CppClassPointerStore<NotNullWhenAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.CodeAnalysis", "NotNullWhenAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotNullWhenAttribute>.NativeClassPtr);
			NotNullWhenAttribute.NativeFieldInfoPtr__ReturnValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotNullWhenAttribute>.NativeClassPtr, "<ReturnValue>k__BackingField");
			NotNullWhenAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotNullWhenAttribute>.NativeClassPtr, 100674082);
		}

		// Token: 0x06004A27 RID: 18983 RVA: 0x00157180 File Offset: 0x00155380
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

		// Token: 0x06004A28 RID: 18984 RVA: 0x0001B307 File Offset: 0x00019507
		public NotNullWhenAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x06004A29 RID: 18985 RVA: 0x001571C8 File Offset: 0x001553C8
		// (set) Token: 0x06004A2A RID: 18986 RVA: 0x0001B310 File Offset: 0x00019510
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

		// Token: 0x04003CC8 RID: 15560
		private static readonly IntPtr NativeFieldInfoPtr__ReturnValue_k__BackingField;

		// Token: 0x04003CC9 RID: 15561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
