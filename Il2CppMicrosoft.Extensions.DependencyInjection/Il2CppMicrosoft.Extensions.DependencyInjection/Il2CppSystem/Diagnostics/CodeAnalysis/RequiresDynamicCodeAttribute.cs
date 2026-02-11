using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x0200000C RID: 12
	public sealed class RequiresDynamicCodeAttribute : Attribute
	{
		// Token: 0x0600004E RID: 78 RVA: 0x0000427C File Offset: 0x0000247C
		// Note: this type is marked as 'beforefieldinit'.
		static RequiresDynamicCodeAttribute()
		{
			Il2CppClassPointerStore<RequiresDynamicCodeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "System.Diagnostics.CodeAnalysis", "RequiresDynamicCodeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequiresDynamicCodeAttribute>.NativeClassPtr);
			RequiresDynamicCodeAttribute.NativeFieldInfoPtr__Message_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequiresDynamicCodeAttribute>.NativeClassPtr, "<Message>k__BackingField");
			RequiresDynamicCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequiresDynamicCodeAttribute>.NativeClassPtr, 100663336);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000042D4 File Offset: 0x000024D4
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequiresDynamicCodeAttribute(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequiresDynamicCodeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequiresDynamicCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002215 File Offset: 0x00000415
		public RequiresDynamicCodeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00004320 File Offset: 0x00002520
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0000221E File Offset: 0x0000041E
		public unsafe string _Message_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequiresDynamicCodeAttribute.NativeFieldInfoPtr__Message_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequiresDynamicCodeAttribute.NativeFieldInfoPtr__Message_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr__Message_k__BackingField;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
