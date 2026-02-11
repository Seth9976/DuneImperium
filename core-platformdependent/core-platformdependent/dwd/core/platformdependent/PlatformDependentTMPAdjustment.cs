using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using TMPro;
using UnityEngine;

namespace dwd.core.platformdependent
{
	// Token: 0x0200001F RID: 31
	[Serializable]
	public class PlatformDependentTMPAdjustment : PlatformDependentAdjustment
	{
		// Token: 0x06000107 RID: 263 RVA: 0x000062C0 File Offset: 0x000044C0
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDependentTMPAdjustment()
		{
			Il2CppClassPointerStore<PlatformDependentTMPAdjustment>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformDependentTMPAdjustment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentTMPAdjustment>.NativeClassPtr);
			PlatformDependentTMPAdjustment.NativeFieldInfoPtr_TEXT_ANCHOR_UNDEFINED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTMPAdjustment>.NativeClassPtr, "TEXT_ANCHOR_UNDEFINED");
			PlatformDependentTMPAdjustment.NativeFieldInfoPtr_fontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTMPAdjustment>.NativeClassPtr, "fontSize");
			PlatformDependentTMPAdjustment.NativeFieldInfoPtr_autoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTMPAdjustment>.NativeClassPtr, "autoSize");
			PlatformDependentTMPAdjustment.NativeFieldInfoPtr_minSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTMPAdjustment>.NativeClassPtr, "minSize");
			PlatformDependentTMPAdjustment.NativeFieldInfoPtr_maxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTMPAdjustment>.NativeClassPtr, "maxSize");
			PlatformDependentTMPAdjustment.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTMPAdjustment>.NativeClassPtr, "left");
			PlatformDependentTMPAdjustment.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTMPAdjustment>.NativeClassPtr, "top");
			PlatformDependentTMPAdjustment.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTMPAdjustment>.NativeClassPtr, "right");
			PlatformDependentTMPAdjustment.NativeFieldInfoPtr_bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTMPAdjustment>.NativeClassPtr, "bottom");
			PlatformDependentTMPAdjustment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentTMPAdjustment>.NativeClassPtr, 100663411);
			PlatformDependentTMPAdjustment.NativeMethodInfoPtr_ApplyAdjustment_Public_Virtual_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentTMPAdjustment>.NativeClassPtr, 100663412);
			PlatformDependentTMPAdjustment.NativeMethodInfoPtr_Approximately_Public_Boolean_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentTMPAdjustment>.NativeClassPtr, 100663413);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000063E0 File Offset: 0x000045E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239505, XrefRangeEnd = 1239506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDependentTMPAdjustment()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentTMPAdjustment>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentTMPAdjustment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000641C File Offset: 0x0000461C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239506, XrefRangeEnd = 1239513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyAdjustment(GameObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentTMPAdjustment.NativeMethodInfoPtr_ApplyAdjustment_Public_Virtual_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000646C File Offset: 0x0000466C
		[CallerCount(0)]
		public unsafe bool Approximately(TMP_Text text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentTMPAdjustment.NativeMethodInfoPtr_Approximately_Public_Boolean_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000027B0 File Offset: 0x000009B0
		public PlatformDependentTMPAdjustment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600010C RID: 268 RVA: 0x000064BC File Offset: 0x000046BC
		// (set) Token: 0x0600010D RID: 269 RVA: 0x000027B9 File Offset: 0x000009B9
		public unsafe static int TEXT_ANCHOR_UNDEFINED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PlatformDependentTMPAdjustment.NativeFieldInfoPtr_TEXT_ANCHOR_UNDEFINED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformDependentTMPAdjustment.NativeFieldInfoPtr_TEXT_ANCHOR_UNDEFINED, (void*)(&value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600010E RID: 270 RVA: 0x000064D8 File Offset: 0x000046D8
		// (set) Token: 0x0600010F RID: 271 RVA: 0x000027C7 File Offset: 0x000009C7
		public unsafe float fontSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjustment.NativeFieldInfoPtr_fontSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjustment.NativeFieldInfoPtr_fontSize)) = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00006500 File Offset: 0x00004700
		// (set) Token: 0x06000111 RID: 273 RVA: 0x000027E2 File Offset: 0x000009E2
		public unsafe bool autoSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjustment.NativeFieldInfoPtr_autoSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjustment.NativeFieldInfoPtr_autoSize)) = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00006528 File Offset: 0x00004728
		// (set) Token: 0x06000113 RID: 275 RVA: 0x000027FD File Offset: 0x000009FD
		public unsafe float minSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjustment.NativeFieldInfoPtr_minSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjustment.NativeFieldInfoPtr_minSize)) = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00006550 File Offset: 0x00004750
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00002818 File Offset: 0x00000A18
		public unsafe float maxSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjustment.NativeFieldInfoPtr_maxSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjustment.NativeFieldInfoPtr_maxSize)) = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00006578 File Offset: 0x00004778
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00002833 File Offset: 0x00000A33
		public unsafe float left
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjustment.NativeFieldInfoPtr_left);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjustment.NativeFieldInfoPtr_left)) = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000118 RID: 280 RVA: 0x000065A0 File Offset: 0x000047A0
		// (set) Token: 0x06000119 RID: 281 RVA: 0x0000284E File Offset: 0x00000A4E
		public unsafe float top
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjustment.NativeFieldInfoPtr_top);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjustment.NativeFieldInfoPtr_top)) = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600011A RID: 282 RVA: 0x000065C8 File Offset: 0x000047C8
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002869 File Offset: 0x00000A69
		public unsafe float right
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjustment.NativeFieldInfoPtr_right);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjustment.NativeFieldInfoPtr_right)) = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600011C RID: 284 RVA: 0x000065F0 File Offset: 0x000047F0
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002884 File Offset: 0x00000A84
		public unsafe float bottom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjustment.NativeFieldInfoPtr_bottom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTMPAdjustment.NativeFieldInfoPtr_bottom)) = value;
			}
		}

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_TEXT_ANCHOR_UNDEFINED;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_fontSize;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_autoSize;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_minSize;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_maxSize;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_left;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_top;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_right;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_bottom;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAdjustment_Public_Virtual_Void_GameObject_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Boolean_TMP_Text_0;
	}
}
