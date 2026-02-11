using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dbgclient.aspectratio
{
	// Token: 0x020000DD RID: 221
	public class AspectRatioConfiguration : ScriptableObject
	{
		// Token: 0x0600096B RID: 2411 RVA: 0x0003B448 File Offset: 0x00039648
		// Note: this type is marked as 'beforefieldinit'.
		static AspectRatioConfiguration()
		{
			Il2CppClassPointerStore<AspectRatioConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.aspectratio", "AspectRatioConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AspectRatioConfiguration>.NativeClassPtr);
			AspectRatioConfiguration.NativeFieldInfoPtr_TargetResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioConfiguration>.NativeClassPtr, "TargetResolution");
			AspectRatioConfiguration.NativeFieldInfoPtr_ScaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioConfiguration>.NativeClassPtr, "ScaleFactor");
			AspectRatioConfiguration.NativeFieldInfoPtr_MinRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioConfiguration>.NativeClassPtr, "MinRatio");
			AspectRatioConfiguration.NativeFieldInfoPtr_MaxRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioConfiguration>.NativeClassPtr, "MaxRatio");
			AspectRatioConfiguration.NativeFieldInfoPtr_VerticalFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioConfiguration>.NativeClassPtr, "VerticalFOV");
			AspectRatioConfiguration.NativeMethodInfoPtr_SafeArea_Public_Static_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfiguration>.NativeClassPtr, 100664672);
			AspectRatioConfiguration.NativeMethodInfoPtr_GetCurrentRatio_Public_Static_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfiguration>.NativeClassPtr, 100664673);
			AspectRatioConfiguration.NativeMethodInfoPtr_get_HasSafeArea_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfiguration>.NativeClassPtr, 100664674);
			AspectRatioConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioConfiguration>.NativeClassPtr, 100664675);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0003B52C File Offset: 0x0003972C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505902, XrefRangeEnd = 505903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect SafeArea()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfiguration.NativeMethodInfoPtr_SafeArea_Public_Static_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0003B55C File Offset: 0x0003975C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 505905, RefRangeEnd = 505907, XrefRangeStart = 505903, XrefRangeEnd = 505905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetCurrentRatio(bool respectSafeArea)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref respectSafeArea;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfiguration.NativeMethodInfoPtr_GetCurrentRatio_Public_Static_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x0003B59C File Offset: 0x0003979C
		public unsafe static bool HasSafeArea
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 505910, RefRangeEnd = 505912, XrefRangeStart = 505907, XrefRangeEnd = 505910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfiguration.NativeMethodInfoPtr_get_HasSafeArea_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0003B5CC File Offset: 0x000397CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505912, XrefRangeEnd = 505913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AspectRatioConfiguration()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AspectRatioConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0000674A File Offset: 0x0000494A
		public AspectRatioConfiguration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x0003B608 File Offset: 0x00039808
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x00006753 File Offset: 0x00004953
		public unsafe Vector2Int TargetResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfiguration.NativeFieldInfoPtr_TargetResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfiguration.NativeFieldInfoPtr_TargetResolution)) = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x0003B630 File Offset: 0x00039830
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x0000676E File Offset: 0x0000496E
		public unsafe float ScaleFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfiguration.NativeFieldInfoPtr_ScaleFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfiguration.NativeFieldInfoPtr_ScaleFactor)) = value;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x0003B658 File Offset: 0x00039858
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x00006789 File Offset: 0x00004989
		public unsafe float MinRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfiguration.NativeFieldInfoPtr_MinRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfiguration.NativeFieldInfoPtr_MinRatio)) = value;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x0003B680 File Offset: 0x00039880
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x000067A4 File Offset: 0x000049A4
		public unsafe float MaxRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfiguration.NativeFieldInfoPtr_MaxRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfiguration.NativeFieldInfoPtr_MaxRatio)) = value;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x0003B6A8 File Offset: 0x000398A8
		// (set) Token: 0x0600097A RID: 2426 RVA: 0x000067BF File Offset: 0x000049BF
		public unsafe float VerticalFOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfiguration.NativeFieldInfoPtr_VerticalFOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioConfiguration.NativeFieldInfoPtr_VerticalFOV)) = value;
			}
		}

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeFieldInfoPtr_TargetResolution;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeFieldInfoPtr_ScaleFactor;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeFieldInfoPtr_MinRatio;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeFieldInfoPtr_MaxRatio;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeFieldInfoPtr_VerticalFOV;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeMethodInfoPtr_SafeArea_Public_Static_Rect_0;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentRatio_Public_Static_Single_Boolean_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSafeArea_Public_Static_get_Boolean_0;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
