using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000E3 RID: 227
	public static class TileLayoutUtils : Object
	{
		// Token: 0x0600107D RID: 4221 RVA: 0x0004BEE0 File Offset: 0x0004A0E0
		// Note: this type is marked as 'beforefieldinit'.
		static TileLayoutUtils()
		{
			Il2CppClassPointerStore<TileLayoutUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "TileLayoutUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileLayoutUtils>.NativeClassPtr);
			TileLayoutUtils.NativeMethodInfoPtr_TryLayoutByTiles_Public_Static_Boolean_RectInt_UInt32_byref_RectInt_byref_RectInt_byref_RectInt_byref_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayoutUtils>.NativeClassPtr, 100665735);
			TileLayoutUtils.NativeMethodInfoPtr_TryLayoutByRow_Public_Static_Boolean_RectInt_UInt32_byref_RectInt_byref_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayoutUtils>.NativeClassPtr, 100665736);
			TileLayoutUtils.NativeMethodInfoPtr_TryLayoutByCol_Public_Static_Boolean_RectInt_UInt32_byref_RectInt_byref_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayoutUtils>.NativeClassPtr, 100665737);
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0004BF4C File Offset: 0x0004A14C
		[CallerCount(0)]
		public unsafe static bool TryLayoutByTiles(RectInt src, uint tileSize, out RectInt main, out RectInt topRow, out RectInt rightCol, out RectInt topRight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref src;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &main;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &topRow;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rightCol;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &topRight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileLayoutUtils.NativeMethodInfoPtr_TryLayoutByTiles_Public_Static_Boolean_RectInt_UInt32_byref_RectInt_byref_RectInt_byref_RectInt_byref_RectInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x0004BFD4 File Offset: 0x0004A1D4
		[CallerCount(0)]
		public unsafe static bool TryLayoutByRow(RectInt src, uint tileSize, out RectInt main, out RectInt other)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref src;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &main;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileLayoutUtils.NativeMethodInfoPtr_TryLayoutByRow_Public_Static_Boolean_RectInt_UInt32_byref_RectInt_byref_RectInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x0004C03C File Offset: 0x0004A23C
		[CallerCount(0)]
		public unsafe static bool TryLayoutByCol(RectInt src, uint tileSize, out RectInt main, out RectInt other)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref src;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &main;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileLayoutUtils.NativeMethodInfoPtr_TryLayoutByCol_Public_Static_Boolean_RectInt_UInt32_byref_RectInt_byref_RectInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x00008B62 File Offset: 0x00006D62
		public TileLayoutUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeMethodInfoPtr_TryLayoutByTiles_Public_Static_Boolean_RectInt_UInt32_byref_RectInt_byref_RectInt_byref_RectInt_byref_RectInt_0;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeMethodInfoPtr_TryLayoutByRow_Public_Static_Boolean_RectInt_UInt32_byref_RectInt_byref_RectInt_0;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeMethodInfoPtr_TryLayoutByCol_Public_Static_Boolean_RectInt_UInt32_byref_RectInt_byref_RectInt_0;
	}
}
