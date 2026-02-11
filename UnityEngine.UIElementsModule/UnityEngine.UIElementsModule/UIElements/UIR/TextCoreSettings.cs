using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200026D RID: 621
	[StructLayout(2)]
	public struct TextCoreSettings
	{
		// Token: 0x06002E02 RID: 11778 RVA: 0x000C4558 File Offset: 0x000C2758
		// Note: this type is marked as 'beforefieldinit'.
		static TextCoreSettings()
		{
			Il2CppClassPointerStore<TextCoreSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "TextCoreSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextCoreSettings>.NativeClassPtr);
			TextCoreSettings.NativeFieldInfoPtr_faceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextCoreSettings>.NativeClassPtr, "faceColor");
			TextCoreSettings.NativeFieldInfoPtr_outlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextCoreSettings>.NativeClassPtr, "outlineColor");
			TextCoreSettings.NativeFieldInfoPtr_outlineWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextCoreSettings>.NativeClassPtr, "outlineWidth");
			TextCoreSettings.NativeFieldInfoPtr_underlayColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextCoreSettings>.NativeClassPtr, "underlayColor");
			TextCoreSettings.NativeFieldInfoPtr_underlayOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextCoreSettings>.NativeClassPtr, "underlayOffset");
			TextCoreSettings.NativeFieldInfoPtr_underlaySoftness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextCoreSettings>.NativeClassPtr, "underlaySoftness");
			TextCoreSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextCoreSettings>.NativeClassPtr, 100670003);
			TextCoreSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextCoreSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextCoreSettings>.NativeClassPtr, 100670004);
			TextCoreSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextCoreSettings>.NativeClassPtr, 100670005);
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x000C463C File Offset: 0x000C283C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351745, XrefRangeEnd = 351749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextCoreSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x000C4680 File Offset: 0x000C2880
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351749, RefRangeEnd = 351750, XrefRangeStart = 351749, XrefRangeEnd = 351749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(TextCoreSettings other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextCoreSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextCoreSettings_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x000C46C0 File Offset: 0x000C28C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351750, XrefRangeEnd = 351757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextCoreSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x00012EAB File Offset: 0x000110AB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextCoreSettings>.NativeClassPtr, ref this));
		}

		// Token: 0x04002113 RID: 8467
		private static readonly IntPtr NativeFieldInfoPtr_faceColor;

		// Token: 0x04002114 RID: 8468
		private static readonly IntPtr NativeFieldInfoPtr_outlineColor;

		// Token: 0x04002115 RID: 8469
		private static readonly IntPtr NativeFieldInfoPtr_outlineWidth;

		// Token: 0x04002116 RID: 8470
		private static readonly IntPtr NativeFieldInfoPtr_underlayColor;

		// Token: 0x04002117 RID: 8471
		private static readonly IntPtr NativeFieldInfoPtr_underlayOffset;

		// Token: 0x04002118 RID: 8472
		private static readonly IntPtr NativeFieldInfoPtr_underlaySoftness;

		// Token: 0x04002119 RID: 8473
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400211A RID: 8474
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextCoreSettings_0;

		// Token: 0x0400211B RID: 8475
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400211C RID: 8476
		[FieldOffset(0)]
		public Color faceColor;

		// Token: 0x0400211D RID: 8477
		[FieldOffset(16)]
		public Color outlineColor;

		// Token: 0x0400211E RID: 8478
		[FieldOffset(32)]
		public float outlineWidth;

		// Token: 0x0400211F RID: 8479
		[FieldOffset(36)]
		public Color underlayColor;

		// Token: 0x04002120 RID: 8480
		[FieldOffset(52)]
		public Vector2 underlayOffset;

		// Token: 0x04002121 RID: 8481
		[FieldOffset(60)]
		public float underlaySoftness;
	}
}
