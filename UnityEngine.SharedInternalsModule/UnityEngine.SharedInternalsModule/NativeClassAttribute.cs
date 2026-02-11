using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	public sealed class NativeClassAttribute : Attribute
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002A6C File Offset: 0x00000C6C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassAttribute()
		{
			Il2CppClassPointerStore<NativeClassAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine", "NativeClassAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeClassAttribute>.NativeClassPtr);
			NativeClassAttribute.NativeFieldInfoPtr__QualifiedNativeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeClassAttribute>.NativeClassPtr, "<QualifiedNativeName>k__BackingField");
			NativeClassAttribute.NativeFieldInfoPtr__Declaration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeClassAttribute>.NativeClassPtr, "<Declaration>k__BackingField");
			NativeClassAttribute.NativeMethodInfoPtr_set_QualifiedNativeName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeClassAttribute>.NativeClassPtr, 100663302);
			NativeClassAttribute.NativeMethodInfoPtr_set_Declaration_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeClassAttribute>.NativeClassPtr, 100663303);
			NativeClassAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeClassAttribute>.NativeClassPtr, 100663304);
			NativeClassAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeClassAttribute>.NativeClassPtr, 100663305);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002205 File Offset: 0x00000405
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002B14 File Offset: 0x00000D14
		public unsafe string QualifiedNativeName
		{
			get
			{
				return this._QualifiedNativeName_k__BackingField;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeClassAttribute.NativeMethodInfoPtr_set_QualifiedNativeName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000220D File Offset: 0x0000040D
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002B58 File Offset: 0x00000D58
		public unsafe string Declaration
		{
			get
			{
				return this._Declaration_k__BackingField;
			}
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeClassAttribute.NativeMethodInfoPtr_set_Declaration_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002B9C File Offset: 0x00000D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268985, XrefRangeEnd = 1268991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeClassAttribute(string qualifiedCppName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeClassAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(qualifiedCppName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeClassAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002BE8 File Offset: 0x00000DE8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 442634, RefRangeEnd = 442638, XrefRangeStart = 442634, XrefRangeEnd = 442638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeClassAttribute(string qualifiedCppName, string declaration)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeClassAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(qualifiedCppName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(declaration);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeClassAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000021BE File Offset: 0x000003BE
		public NativeClassAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002C48 File Offset: 0x00000E48
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000021C7 File Offset: 0x000003C7
		public unsafe string _QualifiedNativeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeClassAttribute.NativeFieldInfoPtr__QualifiedNativeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeClassAttribute.NativeFieldInfoPtr__QualifiedNativeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002C70 File Offset: 0x00000E70
		// (set) Token: 0x06000020 RID: 32 RVA: 0x000021E6 File Offset: 0x000003E6
		public unsafe string _Declaration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeClassAttribute.NativeFieldInfoPtr__Declaration_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeClassAttribute.NativeFieldInfoPtr__Declaration_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeFieldInfoPtr__QualifiedNativeName_k__BackingField;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr__Declaration_k__BackingField;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_set_QualifiedNativeName_Private_set_Void_String_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_set_Declaration_Private_set_Void_String_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
	}
}
