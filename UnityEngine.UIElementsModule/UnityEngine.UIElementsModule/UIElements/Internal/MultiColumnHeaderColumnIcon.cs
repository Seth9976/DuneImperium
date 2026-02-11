using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements.Internal
{
	// Token: 0x020002B1 RID: 689
	public class MultiColumnHeaderColumnIcon : Image
	{
		// Token: 0x06003354 RID: 13140 RVA: 0x000D8A60 File Offset: 0x000D6C60
		// Note: this type is marked as 'beforefieldinit'.
		static MultiColumnHeaderColumnIcon()
		{
			Il2CppClassPointerStore<MultiColumnHeaderColumnIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.Internal", "MultiColumnHeaderColumnIcon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnHeaderColumnIcon>.NativeClassPtr);
			MultiColumnHeaderColumnIcon.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumnIcon>.NativeClassPtr, "ussClassName");
			MultiColumnHeaderColumnIcon.NativeFieldInfoPtr__isImageInline_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumnIcon>.NativeClassPtr, "<isImageInline>k__BackingField");
			MultiColumnHeaderColumnIcon.NativeMethodInfoPtr_get_isImageInline_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumnIcon>.NativeClassPtr, 100670748);
			MultiColumnHeaderColumnIcon.NativeMethodInfoPtr_set_isImageInline_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumnIcon>.NativeClassPtr, 100670749);
			MultiColumnHeaderColumnIcon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumnIcon>.NativeClassPtr, 100670750);
			MultiColumnHeaderColumnIcon.NativeMethodInfoPtr_UpdateClassList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumnIcon>.NativeClassPtr, 100670751);
			MultiColumnHeaderColumnIcon.NativeMethodInfoPtr___ctor_b__5_0_Private_Void_CustomStyleResolvedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumnIcon>.NativeClassPtr, 100670753);
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06003355 RID: 13141 RVA: 0x000D8B1C File Offset: 0x000D6D1C
		// (set) Token: 0x06003356 RID: 13142 RVA: 0x000D8B58 File Offset: 0x000D6D58
		public unsafe bool isImageInline
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumnIcon.NativeMethodInfoPtr_get_isImageInline_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumnIcon.NativeMethodInfoPtr_set_isImageInline_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x000D8B98 File Offset: 0x000D6D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361639, XrefRangeEnd = 361657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiColumnHeaderColumnIcon()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnHeaderColumnIcon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumnIcon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x000D8BD4 File Offset: 0x000D6DD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 361678, RefRangeEnd = 361680, XrefRangeStart = 361657, XrefRangeEnd = 361678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateClassList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumnIcon.NativeMethodInfoPtr_UpdateClassList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x000D8C08 File Offset: 0x000D6E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361680, XrefRangeEnd = 361681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__5_0(CustomStyleResolvedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumnIcon.NativeMethodInfoPtr___ctor_b__5_0_Private_Void_CustomStyleResolvedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x00014C56 File Offset: 0x00012E56
		public MultiColumnHeaderColumnIcon(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x0600335B RID: 13147 RVA: 0x000D8C4C File Offset: 0x000D6E4C
		// (set) Token: 0x0600335C RID: 13148 RVA: 0x00014C5F File Offset: 0x00012E5F
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumnIcon.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumnIcon.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x0600335D RID: 13149 RVA: 0x000D8C6C File Offset: 0x000D6E6C
		// (set) Token: 0x0600335E RID: 13150 RVA: 0x00014C71 File Offset: 0x00012E71
		public unsafe bool _isImageInline_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnHeaderColumnIcon.NativeFieldInfoPtr__isImageInline_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnHeaderColumnIcon.NativeFieldInfoPtr__isImageInline_k__BackingField)) = value;
			}
		}

		// Token: 0x040025A1 RID: 9633
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x040025A2 RID: 9634
		private static readonly IntPtr NativeFieldInfoPtr__isImageInline_k__BackingField;

		// Token: 0x040025A3 RID: 9635
		private static readonly IntPtr NativeMethodInfoPtr_get_isImageInline_Public_get_Boolean_0;

		// Token: 0x040025A4 RID: 9636
		private static readonly IntPtr NativeMethodInfoPtr_set_isImageInline_Public_set_Void_Boolean_0;

		// Token: 0x040025A5 RID: 9637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040025A6 RID: 9638
		private static readonly IntPtr NativeMethodInfoPtr_UpdateClassList_Public_Void_0;

		// Token: 0x040025A7 RID: 9639
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__5_0_Private_Void_CustomStyleResolvedEvent_0;
	}
}
