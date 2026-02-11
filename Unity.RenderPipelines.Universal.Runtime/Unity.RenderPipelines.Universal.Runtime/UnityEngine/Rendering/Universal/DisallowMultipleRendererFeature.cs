using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000C6 RID: 198
	public class DisallowMultipleRendererFeature : Attribute
	{
		// Token: 0x06000F76 RID: 3958 RVA: 0x0004A824 File Offset: 0x00048A24
		// Note: this type is marked as 'beforefieldinit'.
		static DisallowMultipleRendererFeature()
		{
			Il2CppClassPointerStore<DisallowMultipleRendererFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DisallowMultipleRendererFeature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisallowMultipleRendererFeature>.NativeClassPtr);
			DisallowMultipleRendererFeature.NativeFieldInfoPtr__customTitle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisallowMultipleRendererFeature>.NativeClassPtr, "<customTitle>k__BackingField");
			DisallowMultipleRendererFeature.NativeMethodInfoPtr_set_customTitle_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisallowMultipleRendererFeature>.NativeClassPtr, 100665238);
			DisallowMultipleRendererFeature.NativeMethodInfoPtr_get_customTitle_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisallowMultipleRendererFeature>.NativeClassPtr, 100665239);
			DisallowMultipleRendererFeature.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisallowMultipleRendererFeature>.NativeClassPtr, 100665240);
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06000F78 RID: 3960 RVA: 0x0004A8E8 File Offset: 0x00048AE8
		// (set) Token: 0x06000F77 RID: 3959 RVA: 0x0004A8A4 File Offset: 0x00048AA4
		public unsafe string customTitle
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisallowMultipleRendererFeature.NativeMethodInfoPtr_get_customTitle_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisallowMultipleRendererFeature.NativeMethodInfoPtr_set_customTitle_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x0004A920 File Offset: 0x00048B20
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisallowMultipleRendererFeature(string customTitle = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisallowMultipleRendererFeature>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(customTitle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisallowMultipleRendererFeature.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00009872 File Offset: 0x00007A72
		public DisallowMultipleRendererFeature(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x0004A96C File Offset: 0x00048B6C
		// (set) Token: 0x06000F7C RID: 3964 RVA: 0x0000987B File Offset: 0x00007A7B
		public unsafe string _customTitle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisallowMultipleRendererFeature.NativeFieldInfoPtr__customTitle_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisallowMultipleRendererFeature.NativeFieldInfoPtr__customTitle_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeFieldInfoPtr__customTitle_k__BackingField;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeMethodInfoPtr_set_customTitle_Private_set_Void_String_0;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeMethodInfoPtr_get_customTitle_Public_get_String_0;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
