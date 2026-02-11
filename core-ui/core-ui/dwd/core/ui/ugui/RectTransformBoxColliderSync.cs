using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace dwd.core.ui.ugui
{
	// Token: 0x02000017 RID: 23
	public class RectTransformBoxColliderSync : UIBehaviour
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x0000594C File Offset: 0x00003B4C
		// Note: this type is marked as 'beforefieldinit'.
		static RectTransformBoxColliderSync()
		{
			Il2CppClassPointerStore<RectTransformBoxColliderSync>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-ui.dll", "dwd.core.ui.ugui", "RectTransformBoxColliderSync");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectTransformBoxColliderSync>.NativeClassPtr);
			RectTransformBoxColliderSync.NativeFieldInfoPtr_corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransformBoxColliderSync>.NativeClassPtr, "corners");
			RectTransformBoxColliderSync.NativeFieldInfoPtr_rt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransformBoxColliderSync>.NativeClassPtr, "rt");
			RectTransformBoxColliderSync.NativeFieldInfoPtr_bc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransformBoxColliderSync>.NativeClassPtr, "bc");
			RectTransformBoxColliderSync.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransformBoxColliderSync>.NativeClassPtr, "initialized");
			RectTransformBoxColliderSync.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformBoxColliderSync>.NativeClassPtr, 100663414);
			RectTransformBoxColliderSync.NativeMethodInfoPtr_initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformBoxColliderSync>.NativeClassPtr, 100663415);
			RectTransformBoxColliderSync.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformBoxColliderSync>.NativeClassPtr, 100663416);
			RectTransformBoxColliderSync.NativeMethodInfoPtr_resize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformBoxColliderSync>.NativeClassPtr, 100663417);
			RectTransformBoxColliderSync.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformBoxColliderSync>.NativeClassPtr, 100663418);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00005A30 File Offset: 0x00003C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254342, XrefRangeEnd = 1254357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectTransformBoxColliderSync.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00005A6C File Offset: 0x00003C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254357, XrefRangeEnd = 1254371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformBoxColliderSync.NativeMethodInfoPtr_initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00005AA0 File Offset: 0x00003CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254371, XrefRangeEnd = 1254373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectTransformBoxColliderSync.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00005ADC File Offset: 0x00003CDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1254394, RefRangeEnd = 1254397, XrefRangeStart = 1254373, XrefRangeEnd = 1254394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void resize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformBoxColliderSync.NativeMethodInfoPtr_resize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00005B10 File Offset: 0x00003D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254397, XrefRangeEnd = 1254402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransformBoxColliderSync()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectTransformBoxColliderSync>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformBoxColliderSync.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002653 File Offset: 0x00000853
		public RectTransformBoxColliderSync(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00005B4C File Offset: 0x00003D4C
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0000265C File Offset: 0x0000085C
		public unsafe Il2CppStructArray<Vector3> corners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformBoxColliderSync.NativeFieldInfoPtr_corners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformBoxColliderSync.NativeFieldInfoPtr_corners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00005B7C File Offset: 0x00003D7C
		// (set) Token: 0x060000ED RID: 237 RVA: 0x0000267B File Offset: 0x0000087B
		public unsafe RectTransform rt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformBoxColliderSync.NativeFieldInfoPtr_rt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformBoxColliderSync.NativeFieldInfoPtr_rt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00005BAC File Offset: 0x00003DAC
		// (set) Token: 0x060000EF RID: 239 RVA: 0x0000269A File Offset: 0x0000089A
		public unsafe BoxCollider bc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformBoxColliderSync.NativeFieldInfoPtr_bc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformBoxColliderSync.NativeFieldInfoPtr_bc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00005BDC File Offset: 0x00003DDC
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x000026B9 File Offset: 0x000008B9
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformBoxColliderSync.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformBoxColliderSync.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_corners;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeFieldInfoPtr_rt;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr_bc;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Private_Void_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_resize_Private_Void_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
