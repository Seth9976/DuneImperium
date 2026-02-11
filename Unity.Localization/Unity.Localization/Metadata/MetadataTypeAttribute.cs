using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.Metadata
{
	// Token: 0x020000CE RID: 206
	public class MetadataTypeAttribute : PropertyAttribute
	{
		// Token: 0x06000AB6 RID: 2742 RVA: 0x00031A54 File Offset: 0x0002FC54
		// Note: this type is marked as 'beforefieldinit'.
		static MetadataTypeAttribute()
		{
			Il2CppClassPointerStore<MetadataTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Metadata", "MetadataTypeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetadataTypeAttribute>.NativeClassPtr);
			MetadataTypeAttribute.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetadataTypeAttribute>.NativeClassPtr, "<Type>k__BackingField");
			MetadataTypeAttribute.NativeMethodInfoPtr_get_Type_Public_get_MetadataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataTypeAttribute>.NativeClassPtr, 100665084);
			MetadataTypeAttribute.NativeMethodInfoPtr_set_Type_Public_set_Void_MetadataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataTypeAttribute>.NativeClassPtr, 100665085);
			MetadataTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_MetadataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataTypeAttribute>.NativeClassPtr, 100665086);
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x00031AD4 File Offset: 0x0002FCD4
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x00031B10 File Offset: 0x0002FD10
		public unsafe MetadataType Type
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataTypeAttribute.NativeMethodInfoPtr_get_Type_Public_get_MetadataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataTypeAttribute.NativeMethodInfoPtr_set_Type_Public_set_Void_MetadataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x00031B50 File Offset: 0x0002FD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetadataTypeAttribute(MetadataType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetadataTypeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_MetadataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x000067BA File Offset: 0x000049BA
		public MetadataTypeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x00031B98 File Offset: 0x0002FD98
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x000067C3 File Offset: 0x000049C3
		public unsafe MetadataType _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataTypeAttribute.NativeFieldInfoPtr__Type_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetadataTypeAttribute.NativeFieldInfoPtr__Type_k__BackingField)) = value;
			}
		}

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_MetadataType_0;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_MetadataType_0;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MetadataType_0;
	}
}
