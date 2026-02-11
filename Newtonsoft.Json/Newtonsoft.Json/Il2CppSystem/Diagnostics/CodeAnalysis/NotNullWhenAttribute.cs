using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x02000007 RID: 7
	public sealed class NotNullWhenAttribute : Attribute
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00012174 File Offset: 0x00010374
		// Note: this type is marked as 'beforefieldinit'.
		static NotNullWhenAttribute()
		{
			Il2CppClassPointerStore<NotNullWhenAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "System.Diagnostics.CodeAnalysis", "NotNullWhenAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotNullWhenAttribute>.NativeClassPtr);
			NotNullWhenAttribute.NativeFieldInfoPtr__ReturnValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotNullWhenAttribute>.NativeClassPtr, "<ReturnValue>k__BackingField");
			NotNullWhenAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotNullWhenAttribute>.NativeClassPtr, 100663303);
			NotNullWhenAttribute.NativeMethodInfoPtr_get_ReturnValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotNullWhenAttribute>.NativeClassPtr, 100663304);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000121E0 File Offset: 0x000103E0
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

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00012228 File Offset: 0x00010428
		public unsafe bool ReturnValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotNullWhenAttribute.NativeMethodInfoPtr_get_ReturnValue_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002162 File Offset: 0x00000362
		public NotNullWhenAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00012264 File Offset: 0x00010464
		// (set) Token: 0x0600001A RID: 26 RVA: 0x0000216B File Offset: 0x0000036B
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

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr__ReturnValue_k__BackingField;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnValue_Public_get_Boolean_0;
	}
}
