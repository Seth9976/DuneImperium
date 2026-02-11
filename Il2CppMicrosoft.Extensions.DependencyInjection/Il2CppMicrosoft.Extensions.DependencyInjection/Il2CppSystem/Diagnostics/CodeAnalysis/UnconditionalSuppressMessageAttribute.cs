using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x0200000B RID: 11
	public sealed class UnconditionalSuppressMessageAttribute : Attribute
	{
		// Token: 0x06000044 RID: 68 RVA: 0x000040CC File Offset: 0x000022CC
		// Note: this type is marked as 'beforefieldinit'.
		static UnconditionalSuppressMessageAttribute()
		{
			Il2CppClassPointerStore<UnconditionalSuppressMessageAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "System.Diagnostics.CodeAnalysis", "UnconditionalSuppressMessageAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnconditionalSuppressMessageAttribute>.NativeClassPtr);
			UnconditionalSuppressMessageAttribute.NativeFieldInfoPtr__Category_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconditionalSuppressMessageAttribute>.NativeClassPtr, "<Category>k__BackingField");
			UnconditionalSuppressMessageAttribute.NativeFieldInfoPtr__CheckId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconditionalSuppressMessageAttribute>.NativeClassPtr, "<CheckId>k__BackingField");
			UnconditionalSuppressMessageAttribute.NativeFieldInfoPtr__Justification_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconditionalSuppressMessageAttribute>.NativeClassPtr, "<Justification>k__BackingField");
			UnconditionalSuppressMessageAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconditionalSuppressMessageAttribute>.NativeClassPtr, 100663334);
			UnconditionalSuppressMessageAttribute.NativeMethodInfoPtr_set_Justification_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconditionalSuppressMessageAttribute>.NativeClassPtr, 100663335);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004160 File Offset: 0x00002360
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 442634, RefRangeEnd = 442638, XrefRangeStart = 442634, XrefRangeEnd = 442638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnconditionalSuppressMessageAttribute(string category, string checkId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnconditionalSuppressMessageAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(checkId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnconditionalSuppressMessageAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000022 RID: 34
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000041C0 File Offset: 0x000023C0
		public unsafe string Justification
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnconditionalSuppressMessageAttribute.NativeMethodInfoPtr_set_Justification_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000021AF File Offset: 0x000003AF
		public UnconditionalSuppressMessageAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00004204 File Offset: 0x00002404
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000021B8 File Offset: 0x000003B8
		public unsafe string _Category_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconditionalSuppressMessageAttribute.NativeFieldInfoPtr__Category_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconditionalSuppressMessageAttribute.NativeFieldInfoPtr__Category_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0000422C File Offset: 0x0000242C
		// (set) Token: 0x0600004B RID: 75 RVA: 0x000021D7 File Offset: 0x000003D7
		public unsafe string _CheckId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconditionalSuppressMessageAttribute.NativeFieldInfoPtr__CheckId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconditionalSuppressMessageAttribute.NativeFieldInfoPtr__CheckId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00004254 File Offset: 0x00002454
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000021F6 File Offset: 0x000003F6
		public unsafe string _Justification_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconditionalSuppressMessageAttribute.NativeFieldInfoPtr__Justification_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconditionalSuppressMessageAttribute.NativeFieldInfoPtr__Justification_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr__Category_k__BackingField;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr__CheckId_k__BackingField;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr__Justification_k__BackingField;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_set_Justification_Public_set_Void_String_0;
	}
}
