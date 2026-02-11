using System;
using dwd.core.rendererManagement.configData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using lotus;

namespace voodoo.kabbage
{
	// Token: 0x02000025 RID: 37
	public class TransformBlendRootModule : VoodooRootModule
	{
		// Token: 0x06000134 RID: 308 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		// Note: this type is marked as 'beforefieldinit'.
		static TransformBlendRootModule()
		{
			Il2CppClassPointerStore<TransformBlendRootModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.kabbage", "TransformBlendRootModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformBlendRootModule>.NativeClassPtr);
			TransformBlendRootModule.NativeFieldInfoPtr_positionStartBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformBlendRootModule>.NativeClassPtr, "positionStartBlend");
			TransformBlendRootModule.NativeFieldInfoPtr_positionEndBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformBlendRootModule>.NativeClassPtr, "positionEndBlend");
			TransformBlendRootModule.NativeFieldInfoPtr_rotationStartBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformBlendRootModule>.NativeClassPtr, "rotationStartBlend");
			TransformBlendRootModule.NativeFieldInfoPtr_rotationEndBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformBlendRootModule>.NativeClassPtr, "rotationEndBlend");
			TransformBlendRootModule.NativeFieldInfoPtr_scaleStartBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformBlendRootModule>.NativeClassPtr, "scaleStartBlend");
			TransformBlendRootModule.NativeFieldInfoPtr_scaleEndBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformBlendRootModule>.NativeClassPtr, "scaleEndBlend");
			TransformBlendRootModule.NativeFieldInfoPtr_manualZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformBlendRootModule>.NativeClassPtr, "manualZ");
			TransformBlendRootModule.NativeFieldInfoPtr_manualRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformBlendRootModule>.NativeClassPtr, "manualRotation");
			TransformBlendRootModule.NativeFieldInfoPtr_manualScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformBlendRootModule>.NativeClassPtr, "manualScale");
			TransformBlendRootModule.NativeFieldInfoPtr_executionOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformBlendRootModule>.NativeClassPtr, "executionOrder");
			TransformBlendRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformBlendRootModule>.NativeClassPtr, 100663425);
			TransformBlendRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformBlendRootModule>.NativeClassPtr, 100663426);
			TransformBlendRootModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformBlendRootModule>.NativeClassPtr, 100663427);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000CEFC File Offset: 0x0000B0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107127, XrefRangeEnd = 1107143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateConfig(VoodooRenderRoot root, UnitView unit, VisibilityConfiguration config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unit);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(config);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransformBlendRootModule.NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0000CF70 File Offset: 0x0000B170
		public unsafe override int ExecutionOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransformBlendRootModule.NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000CFB8 File Offset: 0x0000B1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107143, XrefRangeEnd = 1107144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransformBlendRootModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformBlendRootModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformBlendRootModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002ABB File Offset: 0x00000CBB
		public TransformBlendRootModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0000CFF4 File Offset: 0x0000B1F4
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00002AC4 File Offset: 0x00000CC4
		public unsafe float positionStartBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformBlendRootModule.NativeFieldInfoPtr_positionStartBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformBlendRootModule.NativeFieldInfoPtr_positionStartBlend)) = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000D01C File Offset: 0x0000B21C
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00002ADF File Offset: 0x00000CDF
		public unsafe float positionEndBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformBlendRootModule.NativeFieldInfoPtr_positionEndBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformBlendRootModule.NativeFieldInfoPtr_positionEndBlend)) = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000D044 File Offset: 0x0000B244
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00002AFA File Offset: 0x00000CFA
		public unsafe float rotationStartBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformBlendRootModule.NativeFieldInfoPtr_rotationStartBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformBlendRootModule.NativeFieldInfoPtr_rotationStartBlend)) = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000D06C File Offset: 0x0000B26C
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00002B15 File Offset: 0x00000D15
		public unsafe float rotationEndBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformBlendRootModule.NativeFieldInfoPtr_rotationEndBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformBlendRootModule.NativeFieldInfoPtr_rotationEndBlend)) = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0000D094 File Offset: 0x0000B294
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00002B30 File Offset: 0x00000D30
		public unsafe float scaleStartBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformBlendRootModule.NativeFieldInfoPtr_scaleStartBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformBlendRootModule.NativeFieldInfoPtr_scaleStartBlend)) = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0000D0BC File Offset: 0x0000B2BC
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00002B4B File Offset: 0x00000D4B
		public unsafe float scaleEndBlend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformBlendRootModule.NativeFieldInfoPtr_scaleEndBlend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformBlendRootModule.NativeFieldInfoPtr_scaleEndBlend)) = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000D0E4 File Offset: 0x0000B2E4
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00002B66 File Offset: 0x00000D66
		public unsafe bool manualZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformBlendRootModule.NativeFieldInfoPtr_manualZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformBlendRootModule.NativeFieldInfoPtr_manualZ)) = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0000D10C File Offset: 0x0000B30C
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00002B81 File Offset: 0x00000D81
		public unsafe bool manualRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformBlendRootModule.NativeFieldInfoPtr_manualRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformBlendRootModule.NativeFieldInfoPtr_manualRotation)) = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0000D134 File Offset: 0x0000B334
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00002B9C File Offset: 0x00000D9C
		public unsafe bool manualScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformBlendRootModule.NativeFieldInfoPtr_manualScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformBlendRootModule.NativeFieldInfoPtr_manualScale)) = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0000D15C File Offset: 0x0000B35C
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00002BB7 File Offset: 0x00000DB7
		public unsafe int executionOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformBlendRootModule.NativeFieldInfoPtr_executionOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformBlendRootModule.NativeFieldInfoPtr_executionOrder)) = value;
			}
		}

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeFieldInfoPtr_positionStartBlend;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_positionEndBlend;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr_rotationStartBlend;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr_rotationEndBlend;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeFieldInfoPtr_scaleStartBlend;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeFieldInfoPtr_scaleEndBlend;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_manualZ;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr_manualRotation;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeFieldInfoPtr_manualScale;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeFieldInfoPtr_executionOrder;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_UpdateConfig_Public_Virtual_Void_VoodooRenderRoot_UnitView_VisibilityConfiguration_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutionOrder_Protected_Virtual_get_Int32_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
