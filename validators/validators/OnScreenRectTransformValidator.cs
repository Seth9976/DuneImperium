using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace validators
{
	// Token: 0x02000012 RID: 18
	public class OnScreenRectTransformValidator : MonoBehaviour
	{
		// Token: 0x06000074 RID: 116 RVA: 0x00003EDC File Offset: 0x000020DC
		// Note: this type is marked as 'beforefieldinit'.
		static OnScreenRectTransformValidator()
		{
			Il2CppClassPointerStore<OnScreenRectTransformValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("validators.dll", "validators", "OnScreenRectTransformValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnScreenRectTransformValidator>.NativeClassPtr);
			OnScreenRectTransformValidator.NativeFieldInfoPtr_mainCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnScreenRectTransformValidator>.NativeClassPtr, "mainCam");
			OnScreenRectTransformValidator.NativeFieldInfoPtr_visibilityCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnScreenRectTransformValidator>.NativeClassPtr, "visibilityCollider");
			OnScreenRectTransformValidator.NativeFieldInfoPtr__Valid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnScreenRectTransformValidator>.NativeClassPtr, "<Valid>k__BackingField");
			OnScreenRectTransformValidator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenRectTransformValidator>.NativeClassPtr, 100663347);
			OnScreenRectTransformValidator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenRectTransformValidator>.NativeClassPtr, 100663348);
			OnScreenRectTransformValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenRectTransformValidator>.NativeClassPtr, 100663349);
			OnScreenRectTransformValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenRectTransformValidator>.NativeClassPtr, 100663350);
			OnScreenRectTransformValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenRectTransformValidator>.NativeClassPtr, 100663351);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003FAC File Offset: 0x000021AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267642, XrefRangeEnd = 1267661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenRectTransformValidator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003FE0 File Offset: 0x000021E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267661, XrefRangeEnd = 1267671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenRectTransformValidator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00004014 File Offset: 0x00002214
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00004050 File Offset: 0x00002250
		public unsafe virtual bool Valid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenRectTransformValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenRectTransformValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00004090 File Offset: 0x00002290
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnScreenRectTransformValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnScreenRectTransformValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenRectTransformValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002350 File Offset: 0x00000550
		public OnScreenRectTransformValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000040CC File Offset: 0x000022CC
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00002359 File Offset: 0x00000559
		public unsafe Camera mainCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnScreenRectTransformValidator.NativeFieldInfoPtr_mainCam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnScreenRectTransformValidator.NativeFieldInfoPtr_mainCam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000040FC File Offset: 0x000022FC
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00002378 File Offset: 0x00000578
		public unsafe RectTransform visibilityCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnScreenRectTransformValidator.NativeFieldInfoPtr_visibilityCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnScreenRectTransformValidator.NativeFieldInfoPtr_visibilityCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000412C File Offset: 0x0000232C
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00002397 File Offset: 0x00000597
		public unsafe bool _Valid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnScreenRectTransformValidator.NativeFieldInfoPtr__Valid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnScreenRectTransformValidator.NativeFieldInfoPtr__Valid_k__BackingField)) = value;
			}
		}

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_mainCam;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_visibilityCollider;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr__Valid_k__BackingField;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
