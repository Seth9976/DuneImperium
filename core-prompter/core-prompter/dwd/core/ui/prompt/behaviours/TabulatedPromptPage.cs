using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.ui.prompt.behaviours
{
	// Token: 0x02000043 RID: 67
	public class TabulatedPromptPage : MonoBehaviour
	{
		// Token: 0x0600026A RID: 618 RVA: 0x0000BB88 File Offset: 0x00009D88
		// Note: this type is marked as 'beforefieldinit'.
		static TabulatedPromptPage()
		{
			Il2CppClassPointerStore<TabulatedPromptPage>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.behaviours", "TabulatedPromptPage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TabulatedPromptPage>.NativeClassPtr);
			TabulatedPromptPage.NativeFieldInfoPtr__TabIdentifier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabulatedPromptPage>.NativeClassPtr, "<TabIdentifier>k__BackingField");
			TabulatedPromptPage.NativeMethodInfoPtr_get_TabIdentifier_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabulatedPromptPage>.NativeClassPtr, 100663593);
			TabulatedPromptPage.NativeMethodInfoPtr_set_TabIdentifier_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabulatedPromptPage>.NativeClassPtr, 100663594);
			TabulatedPromptPage.NativeMethodInfoPtr_SetTabIdentifier_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabulatedPromptPage>.NativeClassPtr, 100663595);
			TabulatedPromptPage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabulatedPromptPage>.NativeClassPtr, 100663596);
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0000BC1C File Offset: 0x00009E1C
		// (set) Token: 0x0600026C RID: 620 RVA: 0x0000BC58 File Offset: 0x00009E58
		public unsafe int TabIdentifier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabulatedPromptPage.NativeMethodInfoPtr_get_TabIdentifier_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabulatedPromptPage.NativeMethodInfoPtr_set_TabIdentifier_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000BC98 File Offset: 0x00009E98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTabIdentifier(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabulatedPromptPage.NativeMethodInfoPtr_SetTabIdentifier_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000BCD8 File Offset: 0x00009ED8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TabulatedPromptPage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TabulatedPromptPage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabulatedPromptPage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00003396 File Offset: 0x00001596
		public TabulatedPromptPage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0000BD14 File Offset: 0x00009F14
		// (set) Token: 0x06000271 RID: 625 RVA: 0x0000339F File Offset: 0x0000159F
		public unsafe int _TabIdentifier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabulatedPromptPage.NativeFieldInfoPtr__TabIdentifier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabulatedPromptPage.NativeFieldInfoPtr__TabIdentifier_k__BackingField)) = value;
			}
		}

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr__TabIdentifier_k__BackingField;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_get_TabIdentifier_Public_get_Int32_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_set_TabIdentifier_Private_set_Void_Int32_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_SetTabIdentifier_Public_Void_Int32_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
