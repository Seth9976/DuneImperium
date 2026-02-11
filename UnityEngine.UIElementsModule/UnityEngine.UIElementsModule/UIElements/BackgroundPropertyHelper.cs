using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200001E RID: 30
	public static class BackgroundPropertyHelper : Object
	{
		// Token: 0x060001C2 RID: 450 RVA: 0x00022ABC File Offset: 0x00020CBC
		// Note: this type is marked as 'beforefieldinit'.
		static BackgroundPropertyHelper()
		{
			Il2CppClassPointerStore<BackgroundPropertyHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BackgroundPropertyHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BackgroundPropertyHelper>.NativeClassPtr);
			BackgroundPropertyHelper.NativeMethodInfoPtr_ConvertScaleModeToBackgroundPosition_Public_Static_BackgroundPosition_ScaleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundPropertyHelper>.NativeClassPtr, 100663518);
			BackgroundPropertyHelper.NativeMethodInfoPtr_ConvertScaleModeToBackgroundRepeat_Public_Static_BackgroundRepeat_ScaleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundPropertyHelper>.NativeClassPtr, 100663519);
			BackgroundPropertyHelper.NativeMethodInfoPtr_ConvertScaleModeToBackgroundSize_Public_Static_BackgroundSize_ScaleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundPropertyHelper>.NativeClassPtr, 100663520);
			BackgroundPropertyHelper.NativeMethodInfoPtr_ResolveUnityBackgroundScaleMode_Public_Static_ScaleMode_BackgroundPosition_BackgroundPosition_BackgroundRepeat_BackgroundSize_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundPropertyHelper>.NativeClassPtr, 100663521);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00022B3C File Offset: 0x00020D3C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 283499, RefRangeEnd = 283507, XrefRangeStart = 283499, XrefRangeEnd = 283507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BackgroundPosition ConvertScaleModeToBackgroundPosition(ScaleMode scaleMode = ScaleMode.StretchToFill)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scaleMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundPropertyHelper.NativeMethodInfoPtr_ConvertScaleModeToBackgroundPosition_Public_Static_BackgroundPosition_ScaleMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00022B7C File Offset: 0x00020D7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 283534, RefRangeEnd = 283537, XrefRangeStart = 283534, XrefRangeEnd = 283534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BackgroundRepeat ConvertScaleModeToBackgroundRepeat(ScaleMode scaleMode = ScaleMode.StretchToFill)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scaleMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundPropertyHelper.NativeMethodInfoPtr_ConvertScaleModeToBackgroundRepeat_Public_Static_BackgroundRepeat_ScaleMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00022BBC File Offset: 0x00020DBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 283543, RefRangeEnd = 283546, XrefRangeStart = 283537, XrefRangeEnd = 283543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BackgroundSize ConvertScaleModeToBackgroundSize(ScaleMode scaleMode = ScaleMode.StretchToFill)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scaleMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundPropertyHelper.NativeMethodInfoPtr_ConvertScaleModeToBackgroundSize_Public_Static_BackgroundSize_ScaleMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00022BFC File Offset: 0x00020DFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283576, RefRangeEnd = 283577, XrefRangeStart = 283546, XrefRangeEnd = 283576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScaleMode ResolveUnityBackgroundScaleMode(BackgroundPosition backgroundPositionX, BackgroundPosition backgroundPositionY, BackgroundRepeat backgroundRepeat, BackgroundSize backgroundSize, out bool valid)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref backgroundPositionX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backgroundPositionY;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backgroundRepeat;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backgroundSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &valid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundPropertyHelper.NativeMethodInfoPtr_ResolveUnityBackgroundScaleMode_Public_Static_ScaleMode_BackgroundPosition_BackgroundPosition_BackgroundRepeat_BackgroundSize_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000027B3 File Offset: 0x000009B3
		public BackgroundPropertyHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_ConvertScaleModeToBackgroundPosition_Public_Static_BackgroundPosition_ScaleMode_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_ConvertScaleModeToBackgroundRepeat_Public_Static_BackgroundRepeat_ScaleMode_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_ConvertScaleModeToBackgroundSize_Public_Static_BackgroundSize_ScaleMode_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_ResolveUnityBackgroundScaleMode_Public_Static_ScaleMode_BackgroundPosition_BackgroundPosition_BackgroundRepeat_BackgroundSize_byref_Boolean_0;
	}
}
