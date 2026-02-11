using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace lotus
{
	// Token: 0x02000042 RID: 66
	public class AttributeValueRenderer : Observer
	{
		// Token: 0x06000410 RID: 1040 RVA: 0x00016200 File Offset: 0x00014400
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeValueRenderer()
		{
			Il2CppClassPointerStore<AttributeValueRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "AttributeValueRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeValueRenderer>.NativeClassPtr);
			AttributeValueRenderer.NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueRenderer>.NativeClassPtr, "format");
			AttributeValueRenderer.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueRenderer>.NativeClassPtr, "label");
			AttributeValueRenderer.NativeFieldInfoPtr_attributeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueRenderer>.NativeClassPtr, "attributeKey");
			AttributeValueRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueRenderer>.NativeClassPtr, 100663756);
			AttributeValueRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueRenderer>.NativeClassPtr, 100663757);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00016294 File Offset: 0x00014494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109601, XrefRangeEnd = 1109604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeValueRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x000162D0 File Offset: 0x000144D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109604, XrefRangeEnd = 1109609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeValueRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeValueRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x000041FE File Offset: 0x000023FE
		public AttributeValueRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x0001630C File Offset: 0x0001450C
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x00004207 File Offset: 0x00002407
		public unsafe string format
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueRenderer.NativeFieldInfoPtr_format);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueRenderer.NativeFieldInfoPtr_format), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00016334 File Offset: 0x00014534
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x00004226 File Offset: 0x00002426
		public unsafe TMP_Text label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueRenderer.NativeFieldInfoPtr_label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueRenderer.NativeFieldInfoPtr_label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00016364 File Offset: 0x00014564
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x00004245 File Offset: 0x00002445
		public unsafe int attributeKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueRenderer.NativeFieldInfoPtr_attributeKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueRenderer.NativeFieldInfoPtr_attributeKey)) = value;
			}
		}

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeFieldInfoPtr_format;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeFieldInfoPtr_attributeKey;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
