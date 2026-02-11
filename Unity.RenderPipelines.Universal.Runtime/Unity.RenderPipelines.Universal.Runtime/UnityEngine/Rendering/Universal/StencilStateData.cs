using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000040 RID: 64
	[Serializable]
	public class StencilStateData : Object
	{
		// Token: 0x060005C8 RID: 1480 RVA: 0x00029A0C File Offset: 0x00027C0C
		// Note: this type is marked as 'beforefieldinit'.
		static StencilStateData()
		{
			Il2CppClassPointerStore<StencilStateData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "StencilStateData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StencilStateData>.NativeClassPtr);
			StencilStateData.NativeFieldInfoPtr_overrideStencilState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilStateData>.NativeClassPtr, "overrideStencilState");
			StencilStateData.NativeFieldInfoPtr_stencilReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilStateData>.NativeClassPtr, "stencilReference");
			StencilStateData.NativeFieldInfoPtr_stencilCompareFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilStateData>.NativeClassPtr, "stencilCompareFunction");
			StencilStateData.NativeFieldInfoPtr_passOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilStateData>.NativeClassPtr, "passOperation");
			StencilStateData.NativeFieldInfoPtr_failOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilStateData>.NativeClassPtr, "failOperation");
			StencilStateData.NativeFieldInfoPtr_zFailOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilStateData>.NativeClassPtr, "zFailOperation");
			StencilStateData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilStateData>.NativeClassPtr, 100663969);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00029AC8 File Offset: 0x00027CC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 603335, RefRangeEnd = 603338, XrefRangeStart = 603207, XrefRangeEnd = 603335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StencilStateData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StencilStateData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilStateData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x000048A9 File Offset: 0x00002AA9
		public StencilStateData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00029B04 File Offset: 0x00027D04
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x000048B2 File Offset: 0x00002AB2
		public unsafe bool overrideStencilState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilStateData.NativeFieldInfoPtr_overrideStencilState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilStateData.NativeFieldInfoPtr_overrideStencilState)) = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00029B2C File Offset: 0x00027D2C
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x000048CD File Offset: 0x00002ACD
		public unsafe int stencilReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilStateData.NativeFieldInfoPtr_stencilReference);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilStateData.NativeFieldInfoPtr_stencilReference)) = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x00029B54 File Offset: 0x00027D54
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x000048E8 File Offset: 0x00002AE8
		public unsafe CompareFunction stencilCompareFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilStateData.NativeFieldInfoPtr_stencilCompareFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilStateData.NativeFieldInfoPtr_stencilCompareFunction)) = value;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x00029B7C File Offset: 0x00027D7C
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x00004903 File Offset: 0x00002B03
		public unsafe StencilOp passOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilStateData.NativeFieldInfoPtr_passOperation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilStateData.NativeFieldInfoPtr_passOperation)) = value;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00029BA4 File Offset: 0x00027DA4
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x0000491E File Offset: 0x00002B1E
		public unsafe StencilOp failOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilStateData.NativeFieldInfoPtr_failOperation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilStateData.NativeFieldInfoPtr_failOperation)) = value;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x00029BCC File Offset: 0x00027DCC
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x00004939 File Offset: 0x00002B39
		public unsafe StencilOp zFailOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilStateData.NativeFieldInfoPtr_zFailOperation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilStateData.NativeFieldInfoPtr_zFailOperation)) = value;
			}
		}

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeFieldInfoPtr_overrideStencilState;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeFieldInfoPtr_stencilReference;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeFieldInfoPtr_stencilCompareFunction;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeFieldInfoPtr_passOperation;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeFieldInfoPtr_failOperation;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeFieldInfoPtr_zFailOperation;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
