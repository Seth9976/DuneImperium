using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000115 RID: 277
	public sealed class TextAreaAttribute : PropertyAttribute
	{
		// Token: 0x060016A7 RID: 5799 RVA: 0x0006D004 File Offset: 0x0006B204
		// Note: this type is marked as 'beforefieldinit'.
		static TextAreaAttribute()
		{
			Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TextAreaAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr);
			TextAreaAttribute.NativeFieldInfoPtr_minLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr, "minLines");
			TextAreaAttribute.NativeFieldInfoPtr_maxLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr, "maxLines");
			TextAreaAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr, 100666434);
			TextAreaAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr, 100666435);
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x0006D084 File Offset: 0x0006B284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660174, XrefRangeEnd = 660175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextAreaAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAreaAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x0006D0C0 File Offset: 0x0006B2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextAreaAttribute(int minLines, int maxLines)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minLines;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLines;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAreaAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00008EEE File Offset: 0x000070EE
		public TextAreaAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x060016AB RID: 5803 RVA: 0x0006D118 File Offset: 0x0006B318
		// (set) Token: 0x060016AC RID: 5804 RVA: 0x00008EF7 File Offset: 0x000070F7
		public unsafe int minLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextAreaAttribute.NativeFieldInfoPtr_minLines);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextAreaAttribute.NativeFieldInfoPtr_minLines)) = value;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x060016AD RID: 5805 RVA: 0x0006D140 File Offset: 0x0006B340
		// (set) Token: 0x060016AE RID: 5806 RVA: 0x00008F12 File Offset: 0x00007112
		public unsafe int maxLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextAreaAttribute.NativeFieldInfoPtr_maxLines);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextAreaAttribute.NativeFieldInfoPtr_maxLines)) = value;
			}
		}

		// Token: 0x040014C3 RID: 5315
		private static readonly IntPtr NativeFieldInfoPtr_minLines;

		// Token: 0x040014C4 RID: 5316
		private static readonly IntPtr NativeFieldInfoPtr_maxLines;

		// Token: 0x040014C5 RID: 5317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040014C6 RID: 5318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
	}
}
