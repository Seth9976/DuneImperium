using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	public sealed class AssetReferenceUILabelRestriction : AssetReferenceUIRestriction
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00004B78 File Offset: 0x00002D78
		// Note: this type is marked as 'beforefieldinit'.
		static AssetReferenceUILabelRestriction()
		{
			Il2CppClassPointerStore<AssetReferenceUILabelRestriction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine", "AssetReferenceUILabelRestriction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetReferenceUILabelRestriction>.NativeClassPtr);
			AssetReferenceUILabelRestriction.NativeFieldInfoPtr_m_AllowedLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferenceUILabelRestriction>.NativeClassPtr, "m_AllowedLabels");
			AssetReferenceUILabelRestriction.NativeFieldInfoPtr_m_CachedToString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferenceUILabelRestriction>.NativeClassPtr, "m_CachedToString");
			AssetReferenceUILabelRestriction.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceUILabelRestriction>.NativeClassPtr, 100663306);
			AssetReferenceUILabelRestriction.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceUILabelRestriction>.NativeClassPtr, 100663307);
			AssetReferenceUILabelRestriction.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceUILabelRestriction>.NativeClassPtr, 100663308);
			AssetReferenceUILabelRestriction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceUILabelRestriction>.NativeClassPtr, 100663309);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00004C20 File Offset: 0x00002E20
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetReferenceUILabelRestriction([Optional] Il2CppStringArray allowedLabels)
		{
			if (allowedLabels == null)
			{
				allowedLabels = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetReferenceUILabelRestriction>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allowedLabels);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReferenceUILabelRestriction.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00004C78 File Offset: 0x00002E78
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ValidateAsset(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReferenceUILabelRestriction.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00004CC8 File Offset: 0x00002EC8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ValidateAsset(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReferenceUILabelRestriction.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00004D18 File Offset: 0x00002F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157706, XrefRangeEnd = 1157715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReferenceUILabelRestriction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000208A File Offset: 0x0000028A
		public AssetReferenceUILabelRestriction(params string[] allowedLabels)
			: this(new Il2CppStringArray(allowedLabels))
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002098 File Offset: 0x00000298
		public AssetReferenceUILabelRestriction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00004D50 File Offset: 0x00002F50
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000020A1 File Offset: 0x000002A1
		public unsafe Il2CppStringArray m_AllowedLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetReferenceUILabelRestriction.NativeFieldInfoPtr_m_AllowedLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetReferenceUILabelRestriction.NativeFieldInfoPtr_m_AllowedLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00004D80 File Offset: 0x00002F80
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000020C0 File Offset: 0x000002C0
		public unsafe string m_CachedToString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetReferenceUILabelRestriction.NativeFieldInfoPtr_m_CachedToString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetReferenceUILabelRestriction.NativeFieldInfoPtr_m_CachedToString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_m_AllowedLabels;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedToString;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAsset_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAsset_Public_Virtual_Boolean_String_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
