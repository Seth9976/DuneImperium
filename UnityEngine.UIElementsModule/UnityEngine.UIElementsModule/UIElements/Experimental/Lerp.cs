using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.Experimental
{
	// Token: 0x020002A7 RID: 679
	public static class Lerp : Object
	{
		// Token: 0x06003222 RID: 12834 RVA: 0x000D4604 File Offset: 0x000D2804
		// Note: this type is marked as 'beforefieldinit'.
		static Lerp()
		{
			Il2CppClassPointerStore<Lerp>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.Experimental", "Lerp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lerp>.NativeClassPtr);
			Lerp.NativeMethodInfoPtr_Interpolate_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lerp>.NativeClassPtr, 100670585);
			Lerp.NativeMethodInfoPtr_Interpolate_Public_Static_Color_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lerp>.NativeClassPtr, 100670586);
			Lerp.NativeMethodInfoPtr_Interpolate_Internal_Static_StyleValues_StyleValues_StyleValues_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lerp>.NativeClassPtr, 100670587);
		}

		// Token: 0x06003223 RID: 12835 RVA: 0x000D4670 File Offset: 0x000D2870
		[CallerCount(0)]
		public unsafe static float Interpolate(float start, float end, float ratio)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ratio;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lerp.NativeMethodInfoPtr_Interpolate_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x000D46CC File Offset: 0x000D28CC
		[CallerCount(0)]
		public unsafe static Color Interpolate(Color start, Color end, float ratio)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ratio;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lerp.NativeMethodInfoPtr_Interpolate_Public_Static_Color_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x000D4728 File Offset: 0x000D2928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359698, XrefRangeEnd = 359721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StyleValues Interpolate(StyleValues start, StyleValues end, float ratio)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(start));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(end));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ratio;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lerp.NativeMethodInfoPtr_Interpolate_Internal_Static_StyleValues_StyleValues_StyleValues_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new StyleValues(intPtr);
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x000144A4 File Offset: 0x000126A4
		public Lerp(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x000D4790 File Offset: 0x000D2990
		public static int Interpolate(int start, int end, float ratio)
		{
			return Mathf.RoundToInt(Mathf.LerpUnclamped((float)start, (float)end, ratio));
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x000D47B4 File Offset: 0x000D29B4
		public static Rect Interpolate(Rect r1, Rect r2, float ratio)
		{
			return new Rect(Mathf.LerpUnclamped(r1.x, r2.x, ratio), Mathf.LerpUnclamped(r1.y, r2.y, ratio), Mathf.LerpUnclamped(r1.width, r2.width, ratio), Mathf.LerpUnclamped(r1.height, r2.height, ratio));
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x000D481C File Offset: 0x000D2A1C
		public static Vector2 Interpolate(Vector2 start, Vector2 end, float ratio)
		{
			return Vector2.LerpUnclamped(start, end, ratio);
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x000D4838 File Offset: 0x000D2A38
		public static Vector3 Interpolate(Vector3 start, Vector3 end, float ratio)
		{
			return Vector3.LerpUnclamped(start, end, ratio);
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x000D4854 File Offset: 0x000D2A54
		public static Quaternion Interpolate(Quaternion start, Quaternion end, float ratio)
		{
			return Quaternion.SlerpUnclamped(start, end, ratio);
		}

		// Token: 0x040024CC RID: 9420
		private static readonly IntPtr NativeMethodInfoPtr_Interpolate_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x040024CD RID: 9421
		private static readonly IntPtr NativeMethodInfoPtr_Interpolate_Public_Static_Color_Color_Color_Single_0;

		// Token: 0x040024CE RID: 9422
		private static readonly IntPtr NativeMethodInfoPtr_Interpolate_Internal_Static_StyleValues_StyleValues_StyleValues_Single_0;
	}
}
