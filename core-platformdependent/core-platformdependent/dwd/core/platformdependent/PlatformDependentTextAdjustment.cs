using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace dwd.core.platformdependent
{
	// Token: 0x0200001D RID: 29
	[Serializable]
	public class PlatformDependentTextAdjustment : PlatformDependentAdjustment
	{
		// Token: 0x060000EF RID: 239 RVA: 0x00005EB8 File Offset: 0x000040B8
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDependentTextAdjustment()
		{
			Il2CppClassPointerStore<PlatformDependentTextAdjustment>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformDependentTextAdjustment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentTextAdjustment>.NativeClassPtr);
			PlatformDependentTextAdjustment.NativeFieldInfoPtr_TEXT_ANCHOR_UNDEFINED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTextAdjustment>.NativeClassPtr, "TEXT_ANCHOR_UNDEFINED");
			PlatformDependentTextAdjustment.NativeFieldInfoPtr_fontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTextAdjustment>.NativeClassPtr, "fontSize");
			PlatformDependentTextAdjustment.NativeFieldInfoPtr_bestFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTextAdjustment>.NativeClassPtr, "bestFit");
			PlatformDependentTextAdjustment.NativeFieldInfoPtr_minSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTextAdjustment>.NativeClassPtr, "minSize");
			PlatformDependentTextAdjustment.NativeFieldInfoPtr_maxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTextAdjustment>.NativeClassPtr, "maxSize");
			PlatformDependentTextAdjustment.NativeFieldInfoPtr_alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTextAdjustment>.NativeClassPtr, "alignment");
			PlatformDependentTextAdjustment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentTextAdjustment>.NativeClassPtr, 100663404);
			PlatformDependentTextAdjustment.NativeMethodInfoPtr_ApplyAdjustment_Public_Virtual_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentTextAdjustment>.NativeClassPtr, 100663405);
			PlatformDependentTextAdjustment.NativeMethodInfoPtr_Approximately_Public_Boolean_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentTextAdjustment>.NativeClassPtr, 100663406);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00005F9C File Offset: 0x0000419C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239430, XrefRangeEnd = 1239431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDependentTextAdjustment()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentTextAdjustment>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentTextAdjustment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00005FD8 File Offset: 0x000041D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239431, XrefRangeEnd = 1239439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyAdjustment(GameObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentTextAdjustment.NativeMethodInfoPtr_ApplyAdjustment_Public_Virtual_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00006028 File Offset: 0x00004228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239439, XrefRangeEnd = 1239443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Approximately(Text text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentTextAdjustment.NativeMethodInfoPtr_Approximately_Public_Boolean_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000026EA File Offset: 0x000008EA
		public PlatformDependentTextAdjustment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00006078 File Offset: 0x00004278
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x000026F3 File Offset: 0x000008F3
		public unsafe static int TEXT_ANCHOR_UNDEFINED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PlatformDependentTextAdjustment.NativeFieldInfoPtr_TEXT_ANCHOR_UNDEFINED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformDependentTextAdjustment.NativeFieldInfoPtr_TEXT_ANCHOR_UNDEFINED, (void*)(&value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00006094 File Offset: 0x00004294
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002701 File Offset: 0x00000901
		public unsafe int fontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTextAdjustment.NativeFieldInfoPtr_fontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTextAdjustment.NativeFieldInfoPtr_fontSize)) = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x000060BC File Offset: 0x000042BC
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x0000271C File Offset: 0x0000091C
		public unsafe bool bestFit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTextAdjustment.NativeFieldInfoPtr_bestFit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTextAdjustment.NativeFieldInfoPtr_bestFit)) = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000FA RID: 250 RVA: 0x000060E4 File Offset: 0x000042E4
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00002737 File Offset: 0x00000937
		public unsafe int minSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTextAdjustment.NativeFieldInfoPtr_minSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTextAdjustment.NativeFieldInfoPtr_minSize)) = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000610C File Offset: 0x0000430C
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00002752 File Offset: 0x00000952
		public unsafe int maxSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTextAdjustment.NativeFieldInfoPtr_maxSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTextAdjustment.NativeFieldInfoPtr_maxSize)) = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00006134 File Offset: 0x00004334
		// (set) Token: 0x060000FF RID: 255 RVA: 0x0000276D File Offset: 0x0000096D
		public unsafe TextAnchor alignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTextAdjustment.NativeFieldInfoPtr_alignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTextAdjustment.NativeFieldInfoPtr_alignment)) = value;
			}
		}

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_TEXT_ANCHOR_UNDEFINED;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_fontSize;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_bestFit;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_minSize;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_maxSize;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr_alignment;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAdjustment_Public_Virtual_Void_GameObject_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Boolean_Text_0;
	}
}
