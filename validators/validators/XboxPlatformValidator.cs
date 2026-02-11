using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace validators
{
	// Token: 0x0200001C RID: 28
	public class XboxPlatformValidator : MonoBehaviour
	{
		// Token: 0x060000EF RID: 239 RVA: 0x00005544 File Offset: 0x00003744
		// Note: this type is marked as 'beforefieldinit'.
		static XboxPlatformValidator()
		{
			Il2CppClassPointerStore<XboxPlatformValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("validators.dll", "validators", "XboxPlatformValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XboxPlatformValidator>.NativeClassPtr);
			XboxPlatformValidator.NativeFieldInfoPtr_invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxPlatformValidator>.NativeClassPtr, "invert");
			XboxPlatformValidator.NativeFieldInfoPtr__Valid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxPlatformValidator>.NativeClassPtr, "<Valid>k__BackingField");
			XboxPlatformValidator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxPlatformValidator>.NativeClassPtr, 100663393);
			XboxPlatformValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxPlatformValidator>.NativeClassPtr, 100663394);
			XboxPlatformValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxPlatformValidator>.NativeClassPtr, 100663395);
			XboxPlatformValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxPlatformValidator>.NativeClassPtr, 100663396);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000055EC File Offset: 0x000037EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267786, XrefRangeEnd = 1267787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxPlatformValidator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00005620 File Offset: 0x00003820
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000565C File Offset: 0x0000385C
		public unsafe virtual bool Valid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxPlatformValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxPlatformValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000569C File Offset: 0x0000389C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XboxPlatformValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XboxPlatformValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxPlatformValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002700 File Offset: 0x00000900
		public XboxPlatformValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000056D8 File Offset: 0x000038D8
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00002709 File Offset: 0x00000909
		public unsafe bool invert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxPlatformValidator.NativeFieldInfoPtr_invert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxPlatformValidator.NativeFieldInfoPtr_invert)) = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00005700 File Offset: 0x00003900
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00002724 File Offset: 0x00000924
		public unsafe bool _Valid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxPlatformValidator.NativeFieldInfoPtr__Valid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxPlatformValidator.NativeFieldInfoPtr__Valid_k__BackingField)) = value;
			}
		}

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr_invert;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr__Valid_k__BackingField;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
