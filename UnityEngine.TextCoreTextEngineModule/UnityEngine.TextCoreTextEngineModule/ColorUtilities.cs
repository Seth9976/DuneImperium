using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000003 RID: 3
	public static class ColorUtilities : Object
	{
		// Token: 0x06000006 RID: 6 RVA: 0x0000675C File Offset: 0x0000495C
		// Note: this type is marked as 'beforefieldinit'.
		static ColorUtilities()
		{
			Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "ColorUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr);
			ColorUtilities.NativeMethodInfoPtr_CompareColors_Internal_Static_Boolean_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr, 100663300);
			ColorUtilities.NativeMethodInfoPtr_MultiplyColors_Internal_Static_Color32_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtilities>.NativeClassPtr, 100663301);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000067B4 File Offset: 0x000049B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1097843, RefRangeEnd = 1097844, XrefRangeStart = 1097843, XrefRangeEnd = 1097843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CompareColors(Color32 a, Color32 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtilities.NativeMethodInfoPtr_CompareColors_Internal_Static_Boolean_Color32_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00006800 File Offset: 0x00004A00
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1097844, RefRangeEnd = 1097856, XrefRangeStart = 1097844, XrefRangeEnd = 1097844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 MultiplyColors(Color32 c1, Color32 c2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtilities.NativeMethodInfoPtr_MultiplyColors_Internal_Static_Color32_Color32_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002059 File Offset: 0x00000259
		public ColorUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000684C File Offset: 0x00004A4C
		public static bool CompareColorsRgb(Color32 a, Color32 b)
		{
			return a.r == b.r && a.g == b.g && a.b == b.b;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000688C File Offset: 0x00004A8C
		public static bool CompareColors(Color a, Color b)
		{
			return Mathf.Approximately(a.r, b.r) && Mathf.Approximately(a.g, b.g) && Mathf.Approximately(a.b, b.b) && Mathf.Approximately(a.a, b.a);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000068EC File Offset: 0x00004AEC
		public static bool CompareColorsRgb(Color a, Color b)
		{
			return Mathf.Approximately(a.r, b.r) && Mathf.Approximately(a.g, b.g) && Mathf.Approximately(a.b, b.b);
		}

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_CompareColors_Internal_Static_Boolean_Color32_Color32_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_MultiplyColors_Internal_Static_Color32_Color32_Color32_0;
	}
}
