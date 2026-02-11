using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000F8 RID: 248
	public class ColorUtility : Object
	{
		// Token: 0x06001380 RID: 4992 RVA: 0x00061A50 File Offset: 0x0005FC50
		// Note: this type is marked as 'beforefieldinit'.
		static ColorUtility()
		{
			Il2CppClassPointerStore<ColorUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ColorUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorUtility>.NativeClassPtr);
			ColorUtility.NativeMethodInfoPtr_ToHtmlStringRGBA_Public_Static_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtility>.NativeClassPtr, 100666050);
			ColorUtility.DoTryParseHtmlColorDelegateField = IL2CPP.ResolveICall<ColorUtility.DoTryParseHtmlColorDelegate>("UnityEngine.ColorUtility::DoTryParseHtmlColor");
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x00061AA4 File Offset: 0x0005FCA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 658278, RefRangeEnd = 658282, XrefRangeStart = 658247, XrefRangeEnd = 658278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToHtmlStringRGBA(Color color)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtility.NativeMethodInfoPtr_ToHtmlStringRGBA_Public_Static_String_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x00008037 File Offset: 0x00006237
		public ColorUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x00008040 File Offset: 0x00006240
		public static bool DoTryParseHtmlColor(string htmlString, out Color32 color)
		{
			return ColorUtility.DoTryParseHtmlColorDelegateField(IL2CPP.ManagedStringToIl2Cpp(htmlString), out color);
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x00061ADC File Offset: 0x0005FCDC
		public static bool TryParseHtmlString(string htmlString, out Color color)
		{
			Color32 color2;
			bool flag = ColorUtility.DoTryParseHtmlColor(htmlString, out color2);
			color = color2;
			return flag;
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x00008053 File Offset: 0x00006253
		public static string ToHtmlStringRGB(Color color)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001288 RID: 4744
		private static readonly IntPtr NativeMethodInfoPtr_ToHtmlStringRGBA_Public_Static_String_Color_0;

		// Token: 0x04001289 RID: 4745
		private static readonly ColorUtility.DoTryParseHtmlColorDelegate DoTryParseHtmlColorDelegateField;

		// Token: 0x020006DE RID: 1758
		// (Invoke) Token: 0x0600369B RID: 13979
		private delegate bool DoTryParseHtmlColorDelegate(IntPtr htmlString, [Out] IntPtr color);
	}
}
