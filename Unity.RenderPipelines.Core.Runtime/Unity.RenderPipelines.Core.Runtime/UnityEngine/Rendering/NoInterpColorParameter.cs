using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000105 RID: 261
	[Serializable]
	public class NoInterpColorParameter : VolumeParameter<Color>
	{
		// Token: 0x060011CC RID: 4556 RVA: 0x00051098 File Offset: 0x0004F298
		// Note: this type is marked as 'beforefieldinit'.
		static NoInterpColorParameter()
		{
			Il2CppClassPointerStore<NoInterpColorParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "NoInterpColorParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoInterpColorParameter>.NativeClassPtr);
			NoInterpColorParameter.NativeFieldInfoPtr_hdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoInterpColorParameter>.NativeClassPtr, "hdr");
			NoInterpColorParameter.NativeFieldInfoPtr_showAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoInterpColorParameter>.NativeClassPtr, "showAlpha");
			NoInterpColorParameter.NativeFieldInfoPtr_showEyeDropper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoInterpColorParameter>.NativeClassPtr, "showEyeDropper");
			NoInterpColorParameter.NativeMethodInfoPtr__ctor_Public_Void_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpColorParameter>.NativeClassPtr, 100665906);
			NoInterpColorParameter.NativeMethodInfoPtr__ctor_Public_Void_Color_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoInterpColorParameter>.NativeClassPtr, 100665907);
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x0005112C File Offset: 0x0004F32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979006, XrefRangeEnd = 979009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoInterpColorParameter(Color value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInterpColorParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoInterpColorParameter.NativeMethodInfoPtr__ctor_Public_Void_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00051184 File Offset: 0x0004F384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979009, XrefRangeEnd = 979012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoInterpColorParameter(Color value, bool hdr, bool showAlpha, bool showEyeDropper, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoInterpColorParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hdr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showAlpha;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showEyeDropper;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoInterpColorParameter.NativeMethodInfoPtr__ctor_Public_Void_Color_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0000935D File Offset: 0x0000755D
		public NoInterpColorParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x00051204 File Offset: 0x0004F404
		// (set) Token: 0x060011D1 RID: 4561 RVA: 0x00009366 File Offset: 0x00007566
		public unsafe bool hdr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpColorParameter.NativeFieldInfoPtr_hdr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpColorParameter.NativeFieldInfoPtr_hdr)) = value;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x0005122C File Offset: 0x0004F42C
		// (set) Token: 0x060011D3 RID: 4563 RVA: 0x00009381 File Offset: 0x00007581
		public unsafe bool showAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpColorParameter.NativeFieldInfoPtr_showAlpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpColorParameter.NativeFieldInfoPtr_showAlpha)) = value;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x00051254 File Offset: 0x0004F454
		// (set) Token: 0x060011D5 RID: 4565 RVA: 0x0000939C File Offset: 0x0000759C
		public unsafe bool showEyeDropper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpColorParameter.NativeFieldInfoPtr_showEyeDropper);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoInterpColorParameter.NativeFieldInfoPtr_showEyeDropper)) = value;
			}
		}

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeFieldInfoPtr_hdr;

		// Token: 0x04000D64 RID: 3428
		private static readonly IntPtr NativeFieldInfoPtr_showAlpha;

		// Token: 0x04000D65 RID: 3429
		private static readonly IntPtr NativeFieldInfoPtr_showEyeDropper;

		// Token: 0x04000D66 RID: 3430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_Boolean_0;

		// Token: 0x04000D67 RID: 3431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_Boolean_Boolean_Boolean_Boolean_0;
	}
}
