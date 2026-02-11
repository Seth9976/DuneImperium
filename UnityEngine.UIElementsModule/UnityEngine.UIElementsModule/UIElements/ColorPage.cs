using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	// Token: 0x0200016D RID: 365
	[StructLayout(2)]
	public struct ColorPage
	{
		// Token: 0x06001AFF RID: 6911 RVA: 0x0007C680 File Offset: 0x0007A880
		// Note: this type is marked as 'beforefieldinit'.
		static ColorPage()
		{
			Il2CppClassPointerStore<ColorPage>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ColorPage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorPage>.NativeClassPtr);
			ColorPage.NativeFieldInfoPtr_isValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorPage>.NativeClassPtr, "isValid");
			ColorPage.NativeFieldInfoPtr_pageAndID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorPage>.NativeClassPtr, "pageAndID");
			ColorPage.NativeMethodInfoPtr_Init_Public_Static_ColorPage_RenderChain_BMPAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPage>.NativeClassPtr, 100667239);
			ColorPage.NativeMethodInfoPtr_ToNativeColorPage_Public_NativeColorPage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPage>.NativeClassPtr, 100667240);
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x0007C700 File Offset: 0x0007A900
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 322631, RefRangeEnd = 322637, XrefRangeStart = 322623, XrefRangeEnd = 322631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ColorPage Init(UnityEngine.UIElements.UIR.RenderChain renderChain, UnityEngine.UIElements.UIR.BMPAlloc alloc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alloc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPage.NativeMethodInfoPtr_Init_Public_Static_ColorPage_RenderChain_BMPAlloc_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x0007C750 File Offset: 0x0007A950
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 322637, RefRangeEnd = 322639, XrefRangeStart = 322637, XrefRangeEnd = 322637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshBuilderNative.NativeColorPage ToNativeColorPage()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPage.NativeMethodInfoPtr_ToNativeColorPage_Public_NativeColorPage_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x0000C469 File Offset: 0x0000A669
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorPage>.NativeClassPtr, ref this));
		}

		// Token: 0x040012BB RID: 4795
		private static readonly IntPtr NativeFieldInfoPtr_isValid;

		// Token: 0x040012BC RID: 4796
		private static readonly IntPtr NativeFieldInfoPtr_pageAndID;

		// Token: 0x040012BD RID: 4797
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_ColorPage_RenderChain_BMPAlloc_0;

		// Token: 0x040012BE RID: 4798
		private static readonly IntPtr NativeMethodInfoPtr_ToNativeColorPage_Public_NativeColorPage_0;

		// Token: 0x040012BF RID: 4799
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool isValid;

		// Token: 0x040012C0 RID: 4800
		[FieldOffset(4)]
		public Color32 pageAndID;
	}
}
