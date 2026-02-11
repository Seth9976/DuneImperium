using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace zen.src.menus
{
	// Token: 0x02000052 RID: 82
	public class ConfirmDialog : DialogRenderer
	{
		// Token: 0x0600044D RID: 1101 RVA: 0x0001D80C File Offset: 0x0001BA0C
		// Note: this type is marked as 'beforefieldinit'.
		static ConfirmDialog()
		{
			Il2CppClassPointerStore<ConfirmDialog>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.menus", "ConfirmDialog");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfirmDialog>.NativeClassPtr);
			ConfirmDialog.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDialog>.NativeClassPtr, "title");
			ConfirmDialog.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDialog>.NativeClassPtr, "message");
			ConfirmDialog.NativeFieldInfoPtr_DefaultErrorTitleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDialog>.NativeClassPtr, "DefaultErrorTitleKey");
			ConfirmDialog.NativeFieldInfoPtr_confirmed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDialog>.NativeClassPtr, "confirmed");
			ConfirmDialog.NativeMethodInfoPtr_WithMessage_Public_ConfirmDialog_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDialog>.NativeClassPtr, 100663848);
			ConfirmDialog.NativeMethodInfoPtr_Ok_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDialog>.NativeClassPtr, 100663849);
			ConfirmDialog.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDialog>.NativeClassPtr, 100663850);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0001D8C8 File Offset: 0x0001BAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985865, XrefRangeEnd = 985875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmDialog WithMessage(string message, string titleLabel = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(titleLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDialog.NativeMethodInfoPtr_WithMessage_Public_ConfirmDialog_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfirmDialog>(intPtr3) : null;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0001D92C File Offset: 0x0001BB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985875, XrefRangeEnd = 985899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Ok()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDialog.NativeMethodInfoPtr_Ok_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0001D960 File Offset: 0x0001BB60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 985903, RefRangeEnd = 985904, XrefRangeStart = 985899, XrefRangeEnd = 985903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmDialog()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmDialog>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDialog.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00003F73 File Offset: 0x00002173
		public ConfirmDialog(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x0001D99C File Offset: 0x0001BB9C
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x00003F7C File Offset: 0x0000217C
		public unsafe TMP_Text title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDialog.NativeFieldInfoPtr_title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDialog.NativeFieldInfoPtr_title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x0001D9CC File Offset: 0x0001BBCC
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00003F9B File Offset: 0x0000219B
		public unsafe TMP_Text message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDialog.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDialog.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0001D9FC File Offset: 0x0001BBFC
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x00003FBA File Offset: 0x000021BA
		public unsafe static string DefaultErrorTitleKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConfirmDialog.NativeFieldInfoPtr_DefaultErrorTitleKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfirmDialog.NativeFieldInfoPtr_DefaultErrorTitleKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x0001DA1C File Offset: 0x0001BC1C
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x00003FCC File Offset: 0x000021CC
		public unsafe bool confirmed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDialog.NativeFieldInfoPtr_confirmed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDialog.NativeFieldInfoPtr_confirmed)) = value;
			}
		}

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeFieldInfoPtr_DefaultErrorTitleKey;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr_confirmed;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr_WithMessage_Public_ConfirmDialog_String_String_0;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr_Ok_Public_Void_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
