using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace dwd.core.platformdependent
{
	// Token: 0x02000016 RID: 22
	[Serializable]
	public class PlatformDependentLayoutElementAdjustment : PlatformDependentAdjustment
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00005098 File Offset: 0x00003298
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDependentLayoutElementAdjustment()
		{
			Il2CppClassPointerStore<PlatformDependentLayoutElementAdjustment>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformDependentLayoutElementAdjustment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjustment>.NativeClassPtr);
			PlatformDependentLayoutElementAdjustment.NativeFieldInfoPtr_ignoreLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjustment>.NativeClassPtr, "ignoreLayout");
			PlatformDependentLayoutElementAdjustment.NativeFieldInfoPtr_minWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjustment>.NativeClassPtr, "minWidth");
			PlatformDependentLayoutElementAdjustment.NativeFieldInfoPtr_minHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjustment>.NativeClassPtr, "minHeight");
			PlatformDependentLayoutElementAdjustment.NativeFieldInfoPtr_preferredWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjustment>.NativeClassPtr, "preferredWidth");
			PlatformDependentLayoutElementAdjustment.NativeFieldInfoPtr_preferredHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjustment>.NativeClassPtr, "preferredHeight");
			PlatformDependentLayoutElementAdjustment.NativeFieldInfoPtr_flexibleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjustment>.NativeClassPtr, "flexibleWidth");
			PlatformDependentLayoutElementAdjustment.NativeFieldInfoPtr_flexibleHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjustment>.NativeClassPtr, "flexibleHeight");
			PlatformDependentLayoutElementAdjustment.NativeMethodInfoPtr_ApplyAdjustment_Public_Virtual_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjustment>.NativeClassPtr, 100663380);
			PlatformDependentLayoutElementAdjustment.NativeMethodInfoPtr_Approximately_Public_Boolean_LayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjustment>.NativeClassPtr, 100663381);
			PlatformDependentLayoutElementAdjustment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjustment>.NativeClassPtr, 100663382);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00005190 File Offset: 0x00003390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239182, XrefRangeEnd = 1239186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyAdjustment(GameObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentLayoutElementAdjustment.NativeMethodInfoPtr_ApplyAdjustment_Public_Virtual_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000051E0 File Offset: 0x000033E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239186, XrefRangeEnd = 1239192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Approximately(LayoutElement layout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(layout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentLayoutElementAdjustment.NativeMethodInfoPtr_Approximately_Public_Boolean_LayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00005230 File Offset: 0x00003430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239192, XrefRangeEnd = 1239193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDependentLayoutElementAdjustment()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentLayoutElementAdjustment>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentLayoutElementAdjustment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000242E File Offset: 0x0000062E
		public PlatformDependentLayoutElementAdjustment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000526C File Offset: 0x0000346C
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00002437 File Offset: 0x00000637
		public unsafe bool ignoreLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutElementAdjustment.NativeFieldInfoPtr_ignoreLayout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutElementAdjustment.NativeFieldInfoPtr_ignoreLayout)) = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00005294 File Offset: 0x00003494
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002452 File Offset: 0x00000652
		public unsafe float minWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutElementAdjustment.NativeFieldInfoPtr_minWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutElementAdjustment.NativeFieldInfoPtr_minWidth)) = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x000052BC File Offset: 0x000034BC
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0000246D File Offset: 0x0000066D
		public unsafe float minHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutElementAdjustment.NativeFieldInfoPtr_minHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutElementAdjustment.NativeFieldInfoPtr_minHeight)) = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000AA RID: 170 RVA: 0x000052E4 File Offset: 0x000034E4
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00002488 File Offset: 0x00000688
		public unsafe float preferredWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutElementAdjustment.NativeFieldInfoPtr_preferredWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutElementAdjustment.NativeFieldInfoPtr_preferredWidth)) = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000530C File Offset: 0x0000350C
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000024A3 File Offset: 0x000006A3
		public unsafe float preferredHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutElementAdjustment.NativeFieldInfoPtr_preferredHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutElementAdjustment.NativeFieldInfoPtr_preferredHeight)) = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00005334 File Offset: 0x00003534
		// (set) Token: 0x060000AF RID: 175 RVA: 0x000024BE File Offset: 0x000006BE
		public unsafe float flexibleWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutElementAdjustment.NativeFieldInfoPtr_flexibleWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutElementAdjustment.NativeFieldInfoPtr_flexibleWidth)) = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0000535C File Offset: 0x0000355C
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000024D9 File Offset: 0x000006D9
		public unsafe float flexibleHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutElementAdjustment.NativeFieldInfoPtr_flexibleHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutElementAdjustment.NativeFieldInfoPtr_flexibleHeight)) = value;
			}
		}

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_ignoreLayout;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_minWidth;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_minHeight;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_preferredWidth;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_preferredHeight;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_flexibleWidth;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_flexibleHeight;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAdjustment_Public_Virtual_Void_GameObject_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Boolean_LayoutElement_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
