using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Versioning
{
	// Token: 0x02000312 RID: 786
	public sealed class TargetFrameworkAttribute : Attribute
	{
		// Token: 0x0600306B RID: 12395 RVA: 0x000F74E8 File Offset: 0x000F56E8
		// Note: this type is marked as 'beforefieldinit'.
		static TargetFrameworkAttribute()
		{
			Il2CppClassPointerStore<TargetFrameworkAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Versioning", "TargetFrameworkAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetFrameworkAttribute>.NativeClassPtr);
			TargetFrameworkAttribute.NativeFieldInfoPtr__frameworkName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetFrameworkAttribute>.NativeClassPtr, "_frameworkName");
			TargetFrameworkAttribute.NativeFieldInfoPtr__frameworkDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetFrameworkAttribute>.NativeClassPtr, "_frameworkDisplayName");
			TargetFrameworkAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetFrameworkAttribute>.NativeClassPtr, 100670942);
			TargetFrameworkAttribute.NativeMethodInfoPtr_get_FrameworkName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetFrameworkAttribute>.NativeClassPtr, 100670943);
			TargetFrameworkAttribute.NativeMethodInfoPtr_set_FrameworkDisplayName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetFrameworkAttribute>.NativeClassPtr, 100670944);
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x000F757C File Offset: 0x000F577C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384449, XrefRangeEnd = 1384457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetFrameworkAttribute(string frameworkName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetFrameworkAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(frameworkName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetFrameworkAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x0600306D RID: 12397 RVA: 0x000F75C8 File Offset: 0x000F57C8
		public unsafe string FrameworkName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetFrameworkAttribute.NativeMethodInfoPtr_get_FrameworkName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (set) Token: 0x0600306E RID: 12398 RVA: 0x000F7600 File Offset: 0x000F5800
		public unsafe string FrameworkDisplayName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetFrameworkAttribute.NativeMethodInfoPtr_set_FrameworkDisplayName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x000109B5 File Offset: 0x0000EBB5
		public TargetFrameworkAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06003070 RID: 12400 RVA: 0x000F7644 File Offset: 0x000F5844
		// (set) Token: 0x06003071 RID: 12401 RVA: 0x000109BE File Offset: 0x0000EBBE
		public unsafe string _frameworkName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetFrameworkAttribute.NativeFieldInfoPtr__frameworkName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetFrameworkAttribute.NativeFieldInfoPtr__frameworkName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06003072 RID: 12402 RVA: 0x000F766C File Offset: 0x000F586C
		// (set) Token: 0x06003073 RID: 12403 RVA: 0x000109DD File Offset: 0x0000EBDD
		public unsafe string _frameworkDisplayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetFrameworkAttribute.NativeFieldInfoPtr__frameworkDisplayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetFrameworkAttribute.NativeFieldInfoPtr__frameworkDisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400280A RID: 10250
		private static readonly IntPtr NativeFieldInfoPtr__frameworkName;

		// Token: 0x0400280B RID: 10251
		private static readonly IntPtr NativeFieldInfoPtr__frameworkDisplayName;

		// Token: 0x0400280C RID: 10252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400280D RID: 10253
		private static readonly IntPtr NativeMethodInfoPtr_get_FrameworkName_Public_get_String_0;

		// Token: 0x0400280E RID: 10254
		private static readonly IntPtr NativeMethodInfoPtr_set_FrameworkDisplayName_Public_set_Void_String_0;
	}
}
