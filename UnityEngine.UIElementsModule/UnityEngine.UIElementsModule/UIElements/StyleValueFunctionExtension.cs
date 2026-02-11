using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001CC RID: 460
	public static class StyleValueFunctionExtension : Object
	{
		// Token: 0x06002417 RID: 9239 RVA: 0x0000ED10 File Offset: 0x0000CF10
		// Note: this type is marked as 'beforefieldinit'.
		static StyleValueFunctionExtension()
		{
			Il2CppClassPointerStore<StyleValueFunctionExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleValueFunctionExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleValueFunctionExtension>.NativeClassPtr);
			StyleValueFunctionExtension.NativeMethodInfoPtr_ToUssString_Public_Static_String_StyleValueFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleValueFunctionExtension>.NativeClassPtr, 100668777);
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x000A23A4 File Offset: 0x000A05A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338045, XrefRangeEnd = 338049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToUssString(this StyleValueFunction svf)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref svf;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleValueFunctionExtension.NativeMethodInfoPtr_ToUssString_Public_Static_String_StyleValueFunction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x0000ED49 File Offset: 0x0000CF49
		public StyleValueFunctionExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x000A23DC File Offset: 0x000A05DC
		public static StyleValueFunction FromUssString(string ussValue)
		{
			ussValue = ussValue.ToLowerInvariant();
			string text = ussValue;
			string text2 = text;
			StyleValueFunction styleValueFunction;
			if (!(text2 == "var"))
			{
				if (!(text2 == "env"))
				{
					if (!(text2 == "linear-gradient"))
					{
						throw new ArgumentOutOfRangeException("ussValue", ussValue, "Unknown function name");
					}
					styleValueFunction = StyleValueFunction.LinearGradient;
				}
				else
				{
					styleValueFunction = StyleValueFunction.Env;
				}
			}
			else
			{
				styleValueFunction = StyleValueFunction.Var;
			}
			return styleValueFunction;
		}

		// Token: 0x040019E1 RID: 6625
		private static readonly IntPtr NativeMethodInfoPtr_ToUssString_Public_Static_String_StyleValueFunction_0;

		// Token: 0x040019E2 RID: 6626
		public const string k_Var = "var";

		// Token: 0x040019E3 RID: 6627
		public const string k_Env = "env";

		// Token: 0x040019E4 RID: 6628
		public const string k_LinearGradient = "linear-gradient";
	}
}
