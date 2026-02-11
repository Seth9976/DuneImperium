using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x020004B3 RID: 1203
	public sealed class NotNullIfNotNullAttribute : Attribute
	{
		// Token: 0x06004A2B RID: 18987 RVA: 0x001571F0 File Offset: 0x001553F0
		// Note: this type is marked as 'beforefieldinit'.
		static NotNullIfNotNullAttribute()
		{
			Il2CppClassPointerStore<NotNullIfNotNullAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.CodeAnalysis", "NotNullIfNotNullAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotNullIfNotNullAttribute>.NativeClassPtr);
			NotNullIfNotNullAttribute.NativeFieldInfoPtr__ParameterName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotNullIfNotNullAttribute>.NativeClassPtr, "<ParameterName>k__BackingField");
			NotNullIfNotNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotNullIfNotNullAttribute>.NativeClassPtr, 100674083);
		}

		// Token: 0x06004A2C RID: 18988 RVA: 0x00157248 File Offset: 0x00155448
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotNullIfNotNullAttribute(string parameterName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotNullIfNotNullAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(parameterName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotNullIfNotNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004A2D RID: 18989 RVA: 0x0001B32B File Offset: 0x0001952B
		public NotNullIfNotNullAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x06004A2E RID: 18990 RVA: 0x00157294 File Offset: 0x00155494
		// (set) Token: 0x06004A2F RID: 18991 RVA: 0x0001B334 File Offset: 0x00019534
		public unsafe string _ParameterName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotNullIfNotNullAttribute.NativeFieldInfoPtr__ParameterName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotNullIfNotNullAttribute.NativeFieldInfoPtr__ParameterName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003CCA RID: 15562
		private static readonly IntPtr NativeFieldInfoPtr__ParameterName_k__BackingField;

		// Token: 0x04003CCB RID: 15563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
