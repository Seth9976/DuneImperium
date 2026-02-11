using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Sprites
{
	// Token: 0x02000183 RID: 387
	public sealed class DataUtility : Object
	{
		// Token: 0x06001D13 RID: 7443 RVA: 0x00085EA4 File Offset: 0x000840A4
		// Note: this type is marked as 'beforefieldinit'.
		static DataUtility()
		{
			Il2CppClassPointerStore<DataUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Sprites", "DataUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataUtility>.NativeClassPtr);
			DataUtility.NativeMethodInfoPtr_GetInnerUV_Public_Static_Vector4_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataUtility>.NativeClassPtr, 100667385);
			DataUtility.NativeMethodInfoPtr_GetOuterUV_Public_Static_Vector4_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataUtility>.NativeClassPtr, 100667386);
			DataUtility.NativeMethodInfoPtr_GetPadding_Public_Static_Vector4_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataUtility>.NativeClassPtr, 100667387);
			DataUtility.NativeMethodInfoPtr_GetMinSize_Public_Static_Vector2_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataUtility>.NativeClassPtr, 100667388);
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x00085F24 File Offset: 0x00084124
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 677426, RefRangeEnd = 677428, XrefRangeStart = 677424, XrefRangeEnd = 677426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetInnerUV(Sprite sprite)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataUtility.NativeMethodInfoPtr_GetInnerUV_Public_Static_Vector4_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x00085F68 File Offset: 0x00084168
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 677430, RefRangeEnd = 677434, XrefRangeStart = 677428, XrefRangeEnd = 677430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetOuterUV(Sprite sprite)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataUtility.NativeMethodInfoPtr_GetOuterUV_Public_Static_Vector4_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x00085FAC File Offset: 0x000841AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 677436, RefRangeEnd = 677438, XrefRangeStart = 677434, XrefRangeEnd = 677436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetPadding(Sprite sprite)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataUtility.NativeMethodInfoPtr_GetPadding_Public_Static_Vector4_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x00085FF0 File Offset: 0x000841F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677438, XrefRangeEnd = 677446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 GetMinSize(Sprite sprite)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataUtility.NativeMethodInfoPtr_GetMinSize_Public_Static_Vector2_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x0000AD12 File Offset: 0x00008F12
		public DataUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019DF RID: 6623
		private static readonly IntPtr NativeMethodInfoPtr_GetInnerUV_Public_Static_Vector4_Sprite_0;

		// Token: 0x040019E0 RID: 6624
		private static readonly IntPtr NativeMethodInfoPtr_GetOuterUV_Public_Static_Vector4_Sprite_0;

		// Token: 0x040019E1 RID: 6625
		private static readonly IntPtr NativeMethodInfoPtr_GetPadding_Public_Static_Vector4_Sprite_0;

		// Token: 0x040019E2 RID: 6626
		private static readonly IntPtr NativeMethodInfoPtr_GetMinSize_Public_Static_Vector2_Sprite_0;
	}
}
