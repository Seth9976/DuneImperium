using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public sealed class AssetFileNameExtensionAttribute : Attribute
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000284C File Offset: 0x00000A4C
		// Note: this type is marked as 'beforefieldinit'.
		static AssetFileNameExtensionAttribute()
		{
			Il2CppClassPointerStore<AssetFileNameExtensionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine", "AssetFileNameExtensionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetFileNameExtensionAttribute>.NativeClassPtr);
			AssetFileNameExtensionAttribute.NativeFieldInfoPtr__preferredExtension_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetFileNameExtensionAttribute>.NativeClassPtr, "<preferredExtension>k__BackingField");
			AssetFileNameExtensionAttribute.NativeFieldInfoPtr__otherExtensions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetFileNameExtensionAttribute>.NativeClassPtr, "<otherExtensions>k__BackingField");
			AssetFileNameExtensionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetFileNameExtensionAttribute>.NativeClassPtr, 100663297);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000028B8 File Offset: 0x00000AB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 442634, RefRangeEnd = 442638, XrefRangeStart = 442634, XrefRangeEnd = 442638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetFileNameExtensionAttribute(string preferredExtension, [Optional] Il2CppStringArray otherExtensions)
		{
			if (otherExtensions == null)
			{
				otherExtensions = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetFileNameExtensionAttribute>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(preferredExtension);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(otherExtensions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetFileNameExtensionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		public AssetFileNameExtensionAttribute(string preferredExtension, params string[] otherExtensions)
			: this(preferredExtension, new Il2CppStringArray(otherExtensions))
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000205F File Offset: 0x0000025F
		public AssetFileNameExtensionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002924 File Offset: 0x00000B24
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002068 File Offset: 0x00000268
		public unsafe string _preferredExtension_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetFileNameExtensionAttribute.NativeFieldInfoPtr__preferredExtension_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetFileNameExtensionAttribute.NativeFieldInfoPtr__preferredExtension_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000294C File Offset: 0x00000B4C
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002087 File Offset: 0x00000287
		public unsafe IEnumerable<string> _otherExtensions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetFileNameExtensionAttribute.NativeFieldInfoPtr__otherExtensions_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetFileNameExtensionAttribute.NativeFieldInfoPtr__otherExtensions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020A6 File Offset: 0x000002A6
		public string preferredExtension
		{
			get
			{
				return this._preferredExtension_k__BackingField;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000020AE File Offset: 0x000002AE
		public IEnumerable<string> otherExtensions
		{
			get
			{
				return this._otherExtensions_k__BackingField;
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr__preferredExtension_k__BackingField;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr__otherExtensions_k__BackingField;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0;
	}
}
