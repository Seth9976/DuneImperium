using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
	// Token: 0x02000184 RID: 388
	public sealed class FontDefinition : ValueType
	{
		// Token: 0x06001D14 RID: 7444 RVA: 0x00084C2C File Offset: 0x00082E2C
		// Note: this type is marked as 'beforefieldinit'.
		static FontDefinition()
		{
			Il2CppClassPointerStore<FontDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "FontDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontDefinition>.NativeClassPtr);
			FontDefinition.NativeFieldInfoPtr_m_Font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontDefinition>.NativeClassPtr, "m_Font");
			FontDefinition.NativeFieldInfoPtr_m_FontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontDefinition>.NativeClassPtr, "m_FontAsset");
			FontDefinition.NativeMethodInfoPtr_get_font_Public_get_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontDefinition>.NativeClassPtr, 100667576);
			FontDefinition.NativeMethodInfoPtr_get_fontAsset_Public_get_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontDefinition>.NativeClassPtr, 100667577);
			FontDefinition.NativeMethodInfoPtr_FromFont_Public_Static_FontDefinition_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontDefinition>.NativeClassPtr, 100667578);
			FontDefinition.NativeMethodInfoPtr_FromSDFFont_Public_Static_FontDefinition_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontDefinition>.NativeClassPtr, 100667579);
			FontDefinition.NativeMethodInfoPtr_FromObject_Internal_Static_FontDefinition_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontDefinition>.NativeClassPtr, 100667580);
			FontDefinition.NativeMethodInfoPtr_IsEmpty_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontDefinition>.NativeClassPtr, 100667581);
			FontDefinition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontDefinition>.NativeClassPtr, 100667582);
			FontDefinition.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FontDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontDefinition>.NativeClassPtr, 100667583);
			FontDefinition.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontDefinition>.NativeClassPtr, 100667584);
			FontDefinition.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontDefinition>.NativeClassPtr, 100667585);
			FontDefinition.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FontDefinition_FontDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontDefinition>.NativeClassPtr, 100667586);
			FontDefinition.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FontDefinition_FontDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontDefinition>.NativeClassPtr, 100667587);
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x00084D74 File Offset: 0x00082F74
		// (set) Token: 0x06001D27 RID: 7463 RVA: 0x00085140 File Offset: 0x00083340
		public unsafe Font font
		{
			[CallerCount(128)]
			[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontDefinition.NativeMethodInfoPtr_get_font_Public_get_Font_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Font>(intPtr3) : null;
			}
			set
			{
				bool flag = value != null && this.fontAsset != null;
				if (flag)
				{
					throw new InvalidOperationException("Cannot set both Font and FontAsset on FontDefinition");
				}
				this.m_Font = value;
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x00084DB8 File Offset: 0x00082FB8
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x0008517C File Offset: 0x0008337C
		public unsafe FontAsset fontAsset
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 323759, RefRangeEnd = 323772, XrefRangeStart = 323759, XrefRangeEnd = 323772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontDefinition.NativeMethodInfoPtr_get_fontAsset_Public_get_FontAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr3) : null;
			}
			set
			{
				bool flag = value != null && this.font != null;
				if (flag)
				{
					throw new InvalidOperationException("Cannot set both Font and FontAsset on FontDefinition");
				}
				this.m_FontAsset = value;
			}
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x00084DFC File Offset: 0x00082FFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328489, RefRangeEnd = 328490, XrefRangeStart = 328488, XrefRangeEnd = 328489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FontDefinition FromFont(Font f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontDefinition.NativeMethodInfoPtr_FromFont_Public_Static_FontDefinition_Font_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new FontDefinition(intPtr);
			}
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x00084E38 File Offset: 0x00083038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328491, RefRangeEnd = 328492, XrefRangeStart = 328490, XrefRangeEnd = 328491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FontDefinition FromSDFFont(FontAsset f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontDefinition.NativeMethodInfoPtr_FromSDFFont_Public_Static_FontDefinition_FontAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new FontDefinition(intPtr);
			}
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x00084E74 File Offset: 0x00083074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328508, RefRangeEnd = 328509, XrefRangeStart = 328492, XrefRangeEnd = 328508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FontDefinition FromObject(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontDefinition.NativeMethodInfoPtr_FromObject_Internal_Static_FontDefinition_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new FontDefinition(intPtr);
			}
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x00084EB0 File Offset: 0x000830B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328513, RefRangeEnd = 328514, XrefRangeStart = 328509, XrefRangeEnd = 328513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontDefinition.NativeMethodInfoPtr_IsEmpty_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x00084EF4 File Offset: 0x000830F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328514, XrefRangeEnd = 328521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontDefinition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x00084F30 File Offset: 0x00083130
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328522, RefRangeEnd = 328524, XrefRangeStart = 328521, XrefRangeEnd = 328522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(FontDefinition other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontDefinition.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FontDefinition_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x00084F88 File Offset: 0x00083188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328524, XrefRangeEnd = 328529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontDefinition.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x00084FDC File Offset: 0x000831DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328537, RefRangeEnd = 328539, XrefRangeStart = 328529, XrefRangeEnd = 328537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontDefinition.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x00085020 File Offset: 0x00083220
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328522, RefRangeEnd = 328524, XrefRangeStart = 328522, XrefRangeEnd = 328524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(FontDefinition left, FontDefinition right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontDefinition.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FontDefinition_FontDefinition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x00085080 File Offset: 0x00083280
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 328540, RefRangeEnd = 328543, XrefRangeStart = 328539, XrefRangeEnd = 328540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(FontDefinition left, FontDefinition right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontDefinition.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FontDefinition_FontDefinition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x0000CE0B File Offset: 0x0000B00B
		public FontDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x0000CE14 File Offset: 0x0000B014
		public FontDefinition()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontDefinition>.NativeClassPtr))
		{
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x000850E0 File Offset: 0x000832E0
		// (set) Token: 0x06001D24 RID: 7460 RVA: 0x0000CE26 File Offset: 0x0000B026
		public unsafe Font m_Font
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontDefinition.NativeFieldInfoPtr_m_Font);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontDefinition.NativeFieldInfoPtr_m_Font), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x00085110 File Offset: 0x00083310
		// (set) Token: 0x06001D26 RID: 7462 RVA: 0x0000CE45 File Offset: 0x0000B045
		public unsafe FontAsset m_FontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontDefinition.NativeFieldInfoPtr_m_FontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FontDefinition.NativeFieldInfoPtr_m_FontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x000851B8 File Offset: 0x000833B8
		public static IEnumerable<Type> allowedAssetTypes
		{
			get
			{
				return new FontDefinition.<get_allowedAssetTypes>d__12(-2);
			}
		}

		// Token: 0x04001451 RID: 5201
		private static readonly IntPtr NativeFieldInfoPtr_m_Font;

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeFieldInfoPtr_m_FontAsset;

		// Token: 0x04001453 RID: 5203
		private static readonly IntPtr NativeMethodInfoPtr_get_font_Public_get_Font_0;

		// Token: 0x04001454 RID: 5204
		private static readonly IntPtr NativeMethodInfoPtr_get_fontAsset_Public_get_FontAsset_0;

		// Token: 0x04001455 RID: 5205
		private static readonly IntPtr NativeMethodInfoPtr_FromFont_Public_Static_FontDefinition_Font_0;

		// Token: 0x04001456 RID: 5206
		private static readonly IntPtr NativeMethodInfoPtr_FromSDFFont_Public_Static_FontDefinition_FontAsset_0;

		// Token: 0x04001457 RID: 5207
		private static readonly IntPtr NativeMethodInfoPtr_FromObject_Internal_Static_FontDefinition_Object_0;

		// Token: 0x04001458 RID: 5208
		private static readonly IntPtr NativeMethodInfoPtr_IsEmpty_Internal_Boolean_0;

		// Token: 0x04001459 RID: 5209
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FontDefinition_0;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400145C RID: 5212
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400145D RID: 5213
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FontDefinition_FontDefinition_0;

		// Token: 0x0400145E RID: 5214
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FontDefinition_FontDefinition_0;

		// Token: 0x020004A1 RID: 1185
		public sealed class <get_allowedAssetTypes>d__12
		{
		}
	}
}
