using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Networking.selection.targetinformation
{
	// Token: 0x0200006D RID: 109
	public class FlippableOrientation : Object
	{
		// Token: 0x0600039C RID: 924 RVA: 0x0000F3FC File Offset: 0x0000D5FC
		// Note: this type is marked as 'beforefieldinit'.
		static FlippableOrientation()
		{
			Il2CppClassPointerStore<FlippableOrientation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "FlippableOrientation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlippableOrientation>.NativeClassPtr);
			FlippableOrientation.NativeFieldInfoPtr_Orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlippableOrientation>.NativeClassPtr, "Orientation");
			FlippableOrientation.NativeFieldInfoPtr_Flip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlippableOrientation>.NativeClassPtr, "Flip");
			FlippableOrientation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlippableOrientation>.NativeClassPtr, 100663501);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000F468 File Offset: 0x0000D668
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlippableOrientation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlippableOrientation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlippableOrientation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00004509 File Offset: 0x00002709
		public FlippableOrientation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600039F RID: 927 RVA: 0x0000F4A4 File Offset: 0x0000D6A4
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x00004512 File Offset: 0x00002712
		public unsafe int Orientation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlippableOrientation.NativeFieldInfoPtr_Orientation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlippableOrientation.NativeFieldInfoPtr_Orientation)) = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0000F4CC File Offset: 0x0000D6CC
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x0000452D File Offset: 0x0000272D
		public unsafe int Flip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlippableOrientation.NativeFieldInfoPtr_Flip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlippableOrientation.NativeFieldInfoPtr_Flip)) = value;
			}
		}

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeFieldInfoPtr_Orientation;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeFieldInfoPtr_Flip;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
