using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020000F0 RID: 240
	[Serializable]
	public class BoolParameter : VolumeParameter<bool>
	{
		// Token: 0x0600113B RID: 4411 RVA: 0x0004F0C4 File Offset: 0x0004D2C4
		// Note: this type is marked as 'beforefieldinit'.
		static BoolParameter()
		{
			Il2CppClassPointerStore<BoolParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "BoolParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolParameter>.NativeClassPtr);
			BoolParameter.NativeFieldInfoPtr_displayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolParameter>.NativeClassPtr, "displayType");
			BoolParameter.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolParameter>.NativeClassPtr, 100665851);
			BoolParameter.NativeMethodInfoPtr__ctor_Public_Void_Boolean_DisplayType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolParameter>.NativeClassPtr, 100665852);
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x0004F130 File Offset: 0x0004D330
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 978882, RefRangeEnd = 978887, XrefRangeStart = 978879, XrefRangeEnd = 978882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolParameter(bool value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolParameter.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x0004F188 File Offset: 0x0004D388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978887, XrefRangeEnd = 978890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolParameter(bool value, BoolParameter.DisplayType displayType, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref displayType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolParameter.NativeMethodInfoPtr__ctor_Public_Void_Boolean_DisplayType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00008F6D File Offset: 0x0000716D
		public BoolParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x0004F1EC File Offset: 0x0004D3EC
		// (set) Token: 0x06001140 RID: 4416 RVA: 0x00008F76 File Offset: 0x00007176
		public unsafe BoolParameter.DisplayType displayType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolParameter.NativeFieldInfoPtr_displayType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolParameter.NativeFieldInfoPtr_displayType)) = value;
			}
		}

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeFieldInfoPtr_displayType;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_DisplayType_Boolean_0;

		// Token: 0x0200020B RID: 523
		public enum DisplayType
		{
			// Token: 0x040013BF RID: 5055
			Checkbox,
			// Token: 0x040013C0 RID: 5056
			EnumPopup
		}
	}
}
