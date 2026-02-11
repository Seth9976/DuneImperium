using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	public class GUILayout : Object
	{
		// Token: 0x060001AC RID: 428 RVA: 0x00009F98 File Offset: 0x00008198
		// Note: this type is marked as 'beforefieldinit'.
		static GUILayout()
		{
			Il2CppClassPointerStore<GUILayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUILayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUILayout>.NativeClassPtr);
			GUILayout.NativeMethodInfoPtr_Width_Public_Static_GUILayoutOption_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663426);
			GUILayout.NativeMethodInfoPtr_Height_Public_Static_GUILayoutOption_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663427);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00009FF0 File Offset: 0x000081F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186069, XrefRangeEnd = 1186077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUILayoutOption Width(float width)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_Width_Public_Static_GUILayoutOption_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutOption>(intPtr3) : null;
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000A030 File Offset: 0x00008230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186077, XrefRangeEnd = 1186085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUILayoutOption Height(float height)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayout.NativeMethodInfoPtr_Height_Public_Static_GUILayoutOption_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutOption>(intPtr3) : null;
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002857 File Offset: 0x00000A57
		public GUILayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002860 File Offset: 0x00000A60
		public static void Label(Texture image, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoLabel(GUIContent.Temp(image), GUI.skin.label, options);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000287A File Offset: 0x00000A7A
		public static void Label(Texture image, params GUILayoutOption[] options)
		{
			GUILayout.Label(image, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002888 File Offset: 0x00000A88
		public static void Label(string text, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoLabel(GUIContent.Temp(text), GUI.skin.label, options);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000028A2 File Offset: 0x00000AA2
		public static void Label(string text, params GUILayoutOption[] options)
		{
			GUILayout.Label(text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000028B0 File Offset: 0x00000AB0
		public static void Label(GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoLabel(content, GUI.skin.label, options);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000028C5 File Offset: 0x00000AC5
		public static void Label(GUIContent content, params GUILayoutOption[] options)
		{
			GUILayout.Label(content, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000028D3 File Offset: 0x00000AD3
		public static void Label(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoLabel(GUIContent.Temp(image), style, options);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000028E4 File Offset: 0x00000AE4
		public static void Label(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Label(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000028F3 File Offset: 0x00000AF3
		public static void Label(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoLabel(GUIContent.Temp(text), style, options);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002904 File Offset: 0x00000B04
		public static void Label(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Label(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002913 File Offset: 0x00000B13
		public static void Label(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoLabel(content, style, options);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000291F File Offset: 0x00000B1F
		public static void Label(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Label(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000292E File Offset: 0x00000B2E
		public static void DoLabel(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUI.Label(GUILayoutUtility.GetRect(content, style, options), content, style);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002941 File Offset: 0x00000B41
		public static void Box(Texture image, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoBox(GUIContent.Temp(image), GUI.skin.box, options);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000295B File Offset: 0x00000B5B
		public static void Box(Texture image, params GUILayoutOption[] options)
		{
			GUILayout.Box(image, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002969 File Offset: 0x00000B69
		public static void Box(string text, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoBox(GUIContent.Temp(text), GUI.skin.box, options);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002983 File Offset: 0x00000B83
		public static void Box(string text, params GUILayoutOption[] options)
		{
			GUILayout.Box(text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002991 File Offset: 0x00000B91
		public static void Box(GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoBox(content, GUI.skin.box, options);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000029A6 File Offset: 0x00000BA6
		public static void Box(GUIContent content, params GUILayoutOption[] options)
		{
			GUILayout.Box(content, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000029B4 File Offset: 0x00000BB4
		public static void Box(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoBox(GUIContent.Temp(image), style, options);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000029C5 File Offset: 0x00000BC5
		public static void Box(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Box(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000029D4 File Offset: 0x00000BD4
		public static void Box(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoBox(GUIContent.Temp(text), style, options);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000029E5 File Offset: 0x00000BE5
		public static void Box(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Box(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000029F4 File Offset: 0x00000BF4
		public static void Box(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.DoBox(content, style, options);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002A00 File Offset: 0x00000C00
		public static void Box(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.Box(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002A0F File Offset: 0x00000C0F
		public static void DoBox(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUI.Box(GUILayoutUtility.GetRect(content, style, options), content, style);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000A070 File Offset: 0x00008270
		public static bool Button(Texture image, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoButton(GUIContent.Temp(image), GUI.skin.button, options);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002A22 File Offset: 0x00000C22
		public static bool Button(Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.Button(image, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000A098 File Offset: 0x00008298
		public static bool Button(string text, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoButton(GUIContent.Temp(text), GUI.skin.button, options);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002A30 File Offset: 0x00000C30
		public static bool Button(string text, params GUILayoutOption[] options)
		{
			return GUILayout.Button(text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000A0C0 File Offset: 0x000082C0
		public static bool Button(GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoButton(content, GUI.skin.button, options);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002A3E File Offset: 0x00000C3E
		public static bool Button(GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.Button(content, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000A0E4 File Offset: 0x000082E4
		public static bool Button(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoButton(GUIContent.Temp(image), style, options);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002A4C File Offset: 0x00000C4C
		public static bool Button(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Button(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000A104 File Offset: 0x00008304
		public static bool Button(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoButton(GUIContent.Temp(text), style, options);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002A5B File Offset: 0x00000C5B
		public static bool Button(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Button(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000A124 File Offset: 0x00008324
		public static bool Button(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoButton(content, style, options);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002A6A File Offset: 0x00000C6A
		public static bool Button(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Button(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000A140 File Offset: 0x00008340
		public static bool DoButton(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUI.Button(GUILayoutUtility.GetRect(content, style, options), content, style);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000A164 File Offset: 0x00008364
		public static bool RepeatButton(Texture image, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoRepeatButton(GUIContent.Temp(image), GUI.skin.button, options);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002A79 File Offset: 0x00000C79
		public static bool RepeatButton(Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(image, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000A18C File Offset: 0x0000838C
		public static bool RepeatButton(string text, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoRepeatButton(GUIContent.Temp(text), GUI.skin.button, options);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002A87 File Offset: 0x00000C87
		public static bool RepeatButton(string text, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000A1B4 File Offset: 0x000083B4
		public static bool RepeatButton(GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoRepeatButton(content, GUI.skin.button, options);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002A95 File Offset: 0x00000C95
		public static bool RepeatButton(GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(content, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000A1D8 File Offset: 0x000083D8
		public static bool RepeatButton(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoRepeatButton(GUIContent.Temp(image), style, options);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002AA3 File Offset: 0x00000CA3
		public static bool RepeatButton(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000A1F8 File Offset: 0x000083F8
		public static bool RepeatButton(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoRepeatButton(GUIContent.Temp(text), style, options);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002AB2 File Offset: 0x00000CB2
		public static bool RepeatButton(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000A218 File Offset: 0x00008418
		public static bool RepeatButton(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoRepeatButton(content, style, options);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002AC1 File Offset: 0x00000CC1
		public static bool RepeatButton(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.RepeatButton(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000A234 File Offset: 0x00008434
		public static bool DoRepeatButton(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUI.RepeatButton(GUILayoutUtility.GetRect(content, style, options), content, style);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000A258 File Offset: 0x00008458
		public static string TextField(string text, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, -1, false, GUI.skin.textField, options);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002AD0 File Offset: 0x00000CD0
		public static string TextField(string text, params GUILayoutOption[] options)
		{
			return GUILayout.TextField(text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000A280 File Offset: 0x00008480
		public static string TextField(string text, int maxLength, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, maxLength, false, GUI.skin.textField, options);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002ADE File Offset: 0x00000CDE
		public static string TextField(string text, int maxLength, params GUILayoutOption[] options)
		{
			return GUILayout.TextField(text, maxLength, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000A2A8 File Offset: 0x000084A8
		public static string TextField(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, -1, false, style, options);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002AED File Offset: 0x00000CED
		public static string TextField(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.TextField(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000A2C4 File Offset: 0x000084C4
		public static string TextField(string text, int maxLength, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, maxLength, false, style, options);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002AFC File Offset: 0x00000CFC
		public static string TextField(string text, int maxLength, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.TextField(text, maxLength, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000A2E0 File Offset: 0x000084E0
		public static string PasswordField(string password, char maskChar, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.PasswordField(password, maskChar, -1, GUI.skin.textField, options);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002B0C File Offset: 0x00000D0C
		public static string PasswordField(string password, char maskChar, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000A308 File Offset: 0x00008508
		public static string PasswordField(string password, char maskChar, int maxLength, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.PasswordField(password, maskChar, maxLength, GUI.skin.textField, options);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002B1B File Offset: 0x00000D1B
		public static string PasswordField(string password, char maskChar, int maxLength, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, maxLength, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000A330 File Offset: 0x00008530
		public static string PasswordField(string password, char maskChar, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.PasswordField(password, maskChar, -1, style, options);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002B2B File Offset: 0x00000D2B
		public static string PasswordField(string password, char maskChar, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000A34C File Offset: 0x0000854C
		public static string PasswordField(string password, char maskChar, int maxLength, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUIContent guicontent = GUIContent.Temp(GUI.PasswordFieldGetStrToShow(password, maskChar));
			return GUI.PasswordField(GUILayoutUtility.GetRect(guicontent, GUI.skin.textField, options), password, maskChar, maxLength, style);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002B3B File Offset: 0x00000D3B
		public static string PasswordField(string password, char maskChar, int maxLength, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.PasswordField(password, maskChar, maxLength, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000A388 File Offset: 0x00008588
		public static string TextArea(string text, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, -1, true, GUI.skin.textArea, options);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002B4D File Offset: 0x00000D4D
		public static string TextArea(string text, params GUILayoutOption[] options)
		{
			return GUILayout.TextArea(text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000A3B0 File Offset: 0x000085B0
		public static string TextArea(string text, int maxLength, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, maxLength, true, GUI.skin.textArea, options);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002B5B File Offset: 0x00000D5B
		public static string TextArea(string text, int maxLength, params GUILayoutOption[] options)
		{
			return GUILayout.TextArea(text, maxLength, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000A3D8 File Offset: 0x000085D8
		public static string TextArea(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, -1, true, style, options);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002B6A File Offset: 0x00000D6A
		public static string TextArea(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.TextArea(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000A3F4 File Offset: 0x000085F4
		public static string TextArea(string text, int maxLength, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoTextField(text, maxLength, true, style, options);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002B79 File Offset: 0x00000D79
		public static string TextArea(string text, int maxLength, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.TextArea(text, maxLength, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000A410 File Offset: 0x00008610
		public static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			int controlID = GUIUtility.GetControlID(FocusType.Keyboard);
			GUIContent guicontent = GUIContent.Temp(text);
			bool flag = GUIUtility.keyboardControl != controlID;
			if (flag)
			{
				guicontent = GUIContent.Temp(text);
			}
			else
			{
				guicontent = GUIContent.Temp(String.Concat(text, GUIUtility.compositionString));
			}
			Rect rect = GUILayoutUtility.GetRect(guicontent, style, options);
			bool flag2 = GUIUtility.keyboardControl == controlID;
			if (flag2)
			{
				guicontent = GUIContent.Temp(text);
			}
			GUI.DoTextField(rect, controlID, guicontent, multiline, maxLength, style);
			return guicontent.text;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000A48C File Offset: 0x0000868C
		public static bool Toggle(bool value, Texture image, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoToggle(value, GUIContent.Temp(image), GUI.skin.toggle, options);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002B89 File Offset: 0x00000D89
		public static bool Toggle(bool value, Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, image, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000A4B8 File Offset: 0x000086B8
		public static bool Toggle(bool value, string text, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoToggle(value, GUIContent.Temp(text), GUI.skin.toggle, options);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002B98 File Offset: 0x00000D98
		public static bool Toggle(bool value, string text, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000A4E4 File Offset: 0x000086E4
		public static bool Toggle(bool value, GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoToggle(value, content, GUI.skin.toggle, options);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002BA7 File Offset: 0x00000DA7
		public static bool Toggle(bool value, GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, content, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000A508 File Offset: 0x00008708
		public static bool Toggle(bool value, Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoToggle(value, GUIContent.Temp(image), style, options);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002BB6 File Offset: 0x00000DB6
		public static bool Toggle(bool value, Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000A528 File Offset: 0x00008728
		public static bool Toggle(bool value, string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoToggle(value, GUIContent.Temp(text), style, options);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002BC6 File Offset: 0x00000DC6
		public static bool Toggle(bool value, string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000A548 File Offset: 0x00008748
		public static bool Toggle(bool value, GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoToggle(value, content, style, options);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002BD6 File Offset: 0x00000DD6
		public static bool Toggle(bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toggle(value, content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000A564 File Offset: 0x00008764
		public static bool DoToggle(bool value, GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUI.Toggle(GUILayoutUtility.GetRect(content, style, options), value, content, style);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000A588 File Offset: 0x00008788
		public static int Toolbar(int selected, Il2CppStringArray texts, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(texts), GUI.skin.button, options);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002BE6 File Offset: 0x00000DE6
		public static int Toolbar(int selected, Il2CppStringArray texts, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, texts, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000A5B4 File Offset: 0x000087B4
		public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(images), GUI.skin.button, options);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002BF5 File Offset: 0x00000DF5
		public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, images, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000A5E0 File Offset: 0x000087E0
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, contents, GUI.skin.button, options);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002C04 File Offset: 0x00000E04
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, contents, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000A604 File Offset: 0x00008804
		public static int Toolbar(int selected, Il2CppStringArray texts, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(texts), style, options);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002C13 File Offset: 0x00000E13
		public static int Toolbar(int selected, Il2CppStringArray texts, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, texts, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000A624 File Offset: 0x00008824
		public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(images), style, options);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002C23 File Offset: 0x00000E23
		public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, images, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000A644 File Offset: 0x00008844
		public static int Toolbar(int selected, Il2CppStringArray texts, GUIStyle style, GUI.ToolbarButtonSize buttonSize, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(texts), style, buttonSize, options);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002C33 File Offset: 0x00000E33
		public static int Toolbar(int selected, Il2CppStringArray texts, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, texts, style, buttonSize, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000A668 File Offset: 0x00008868
		public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, GUIStyle style, GUI.ToolbarButtonSize buttonSize, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, GUIContent.Temp(images), style, buttonSize, options);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002C45 File Offset: 0x00000E45
		public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, images, style, buttonSize, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000A68C File Offset: 0x0000888C
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, contents, style, GUI.ToolbarButtonSize.Fixed, options);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002C57 File Offset: 0x00000E57
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, contents, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000A6A8 File Offset: 0x000088A8
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, GUIStyle style, GUI.ToolbarButtonSize buttonSize, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, contents, null, style, buttonSize, options);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002C67 File Offset: 0x00000E67
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, contents, style, buttonSize, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000A6C8 File Offset: 0x000088C8
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStructArray<bool> enabled, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.Toolbar(selected, contents, enabled, style, GUI.ToolbarButtonSize.Fixed, options);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002C79 File Offset: 0x00000E79
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStructArray<bool> enabled, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, contents, enabled, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002C8B File Offset: 0x00000E8B
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStructArray<bool> enabled, GUIStyle style, GUI.ToolbarButtonSize buttonSize, Il2CppReferenceArray<GUILayoutOption> options)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002C98 File Offset: 0x00000E98
		public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStructArray<bool> enabled, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
		{
			return GUILayout.Toolbar(selected, contents, enabled, style, buttonSize, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000A6E8 File Offset: 0x000088E8
		public static int SelectionGrid(int selected, Il2CppStringArray texts, int xCount, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.SelectionGrid(selected, GUIContent.Temp(texts), xCount, GUI.skin.button, options);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002CAC File Offset: 0x00000EAC
		public static int SelectionGrid(int selected, Il2CppStringArray texts, int xCount, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, texts, xCount, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000A714 File Offset: 0x00008914
		public static int SelectionGrid(int selected, Il2CppReferenceArray<Texture> images, int xCount, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.SelectionGrid(selected, GUIContent.Temp(images), xCount, GUI.skin.button, options);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002CBC File Offset: 0x00000EBC
		public static int SelectionGrid(int selected, Il2CppReferenceArray<Texture> images, int xCount, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, images, xCount, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000A740 File Offset: 0x00008940
		public static int SelectionGrid(int selected, Il2CppReferenceArray<GUIContent> content, int xCount, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.SelectionGrid(selected, content, xCount, GUI.skin.button, options);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002CCC File Offset: 0x00000ECC
		public static int SelectionGrid(int selected, Il2CppReferenceArray<GUIContent> content, int xCount, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, content, xCount, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000A768 File Offset: 0x00008968
		public static int SelectionGrid(int selected, Il2CppStringArray texts, int xCount, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.SelectionGrid(selected, GUIContent.Temp(texts), xCount, style, options);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002CDC File Offset: 0x00000EDC
		public static int SelectionGrid(int selected, Il2CppStringArray texts, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, texts, xCount, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000A78C File Offset: 0x0000898C
		public static int SelectionGrid(int selected, Il2CppReferenceArray<Texture> images, int xCount, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.SelectionGrid(selected, GUIContent.Temp(images), xCount, style, options);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002CEE File Offset: 0x00000EEE
		public static int SelectionGrid(int selected, Il2CppReferenceArray<Texture> images, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, images, xCount, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000A7B0 File Offset: 0x000089B0
		public static int SelectionGrid(int selected, Il2CppReferenceArray<GUIContent> contents, int xCount, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUI.SelectionGrid(GUIGridSizer.GetRect(contents, xCount, style, options), selected, contents, xCount, style);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002D00 File Offset: 0x00000F00
		public static int SelectionGrid(int selected, Il2CppReferenceArray<GUIContent> contents, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.SelectionGrid(selected, contents, xCount, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000A7D8 File Offset: 0x000089D8
		public static float HorizontalSlider(float value, float leftValue, float rightValue, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoHorizontalSlider(value, leftValue, rightValue, GUI.skin.horizontalSlider, GUI.skin.horizontalSliderThumb, options);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002D12 File Offset: 0x00000F12
		public static float HorizontalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return GUILayout.HorizontalSlider(value, leftValue, rightValue, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000A808 File Offset: 0x00008A08
		public static float HorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoHorizontalSlider(value, leftValue, rightValue, slider, thumb, options);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002D22 File Offset: 0x00000F22
		public static float HorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{
			return GUILayout.HorizontalSlider(value, leftValue, rightValue, slider, thumb, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000A828 File Offset: 0x00008A28
		public static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUI.HorizontalSlider(GUILayoutUtility.GetRect(GUIContent.Temp("mmmm"), slider, options), value, leftValue, rightValue, slider, thumb);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000A858 File Offset: 0x00008A58
		public static float VerticalSlider(float value, float leftValue, float rightValue, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoVerticalSlider(value, leftValue, rightValue, GUI.skin.verticalSlider, GUI.skin.verticalSliderThumb, options);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002D36 File Offset: 0x00000F36
		public static float VerticalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return GUILayout.VerticalSlider(value, leftValue, rightValue, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000A888 File Offset: 0x00008A88
		public static float VerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoVerticalSlider(value, leftValue, rightValue, slider, thumb, options);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002D46 File Offset: 0x00000F46
		public static float VerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{
			return GUILayout.VerticalSlider(value, leftValue, rightValue, slider, thumb, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		public static float DoVerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUI.VerticalSlider(GUILayoutUtility.GetRect(GUIContent.Temp("\n\n\n\n\n"), slider, options), value, leftValue, rightValue, slider, thumb);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002D5A File Offset: 0x00000F5A
		public static float DoVerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
		{
			return GUILayout.DoVerticalSlider(value, leftValue, rightValue, slider, thumb, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.HorizontalScrollbar(value, size, leftValue, rightValue, GUI.skin.horizontalScrollbar, options);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002D6E File Offset: 0x00000F6E
		public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return GUILayout.HorizontalScrollbar(value, size, leftValue, rightValue, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000A900 File Offset: 0x00008B00
		public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUI.HorizontalScrollbar(GUILayoutUtility.GetRect(GUIContent.Temp("mmmm"), style, options), value, size, leftValue, rightValue, style);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002D80 File Offset: 0x00000F80
		public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.HorizontalScrollbar(value, size, leftValue, rightValue, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000A930 File Offset: 0x00008B30
		public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.VerticalScrollbar(value, size, topValue, bottomValue, GUI.skin.verticalScrollbar, options);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002D94 File Offset: 0x00000F94
		public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, params GUILayoutOption[] options)
		{
			return GUILayout.VerticalScrollbar(value, size, topValue, bottomValue, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000A958 File Offset: 0x00008B58
		public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUI.VerticalScrollbar(GUILayoutUtility.GetRect(GUIContent.Temp("\n\n\n\n"), style, options), value, size, topValue, bottomValue, style);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002DA6 File Offset: 0x00000FA6
		public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.VerticalScrollbar(value, size, topValue, bottomValue, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002DBA File Offset: 0x00000FBA
		public static void Space(float pixels)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002DC7 File Offset: 0x00000FC7
		public static void FlexibleSpace()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002DD4 File Offset: 0x00000FD4
		public static void BeginHorizontal(Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.BeginHorizontal(GUIContent.none, GUIStyle.none, options);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002DE8 File Offset: 0x00000FE8
		public static void BeginHorizontal(params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002DF5 File Offset: 0x00000FF5
		public static void BeginHorizontal(GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.BeginHorizontal(GUIContent.none, style, options);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002E05 File Offset: 0x00001005
		public static void BeginHorizontal(GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002E13 File Offset: 0x00001013
		public static void BeginHorizontal(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.BeginHorizontal(GUIContent.Temp(text), style, options);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002E24 File Offset: 0x00001024
		public static void BeginHorizontal(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002E33 File Offset: 0x00001033
		public static void BeginHorizontal(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.BeginHorizontal(GUIContent.Temp(image), style, options);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002E44 File Offset: 0x00001044
		public static void BeginHorizontal(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000A988 File Offset: 0x00008B88
		public static void BeginHorizontal(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayoutGroup guilayoutGroup = GUILayoutUtility.BeginLayoutGroup(style, options, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<GUILayoutGroup>()));
			guilayoutGroup.isVertical = false;
			bool flag = style != GUIStyle.none || content != GUIContent.none;
			if (flag)
			{
				GUI.Box(guilayoutGroup.rect, content, style);
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002E53 File Offset: 0x00001053
		public static void BeginHorizontal(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002E62 File Offset: 0x00001062
		public static void EndHorizontal()
		{
			GUILayoutUtility.EndLayoutGroup();
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002E6B File Offset: 0x0000106B
		public static void BeginVertical(Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.BeginVertical(GUIContent.none, GUIStyle.none, options);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002E7F File Offset: 0x0000107F
		public static void BeginVertical(params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002E8C File Offset: 0x0000108C
		public static void BeginVertical(GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.BeginVertical(GUIContent.none, style, options);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002E9C File Offset: 0x0000109C
		public static void BeginVertical(GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002EAA File Offset: 0x000010AA
		public static void BeginVertical(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.BeginVertical(GUIContent.Temp(text), style, options);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002EBB File Offset: 0x000010BB
		public static void BeginVertical(string text, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002ECA File Offset: 0x000010CA
		public static void BeginVertical(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayout.BeginVertical(GUIContent.Temp(image), style, options);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002EDB File Offset: 0x000010DB
		public static void BeginVertical(Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000A9D8 File Offset: 0x00008BD8
		public static void BeginVertical(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUILayoutGroup guilayoutGroup = GUILayoutUtility.BeginLayoutGroup(style, options, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<GUILayoutGroup>()));
			guilayoutGroup.isVertical = true;
			bool flag = style != GUIStyle.none || content != GUIContent.none;
			if (flag)
			{
				GUI.Box(guilayoutGroup.rect, content, style);
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002EEA File Offset: 0x000010EA
		public static void BeginVertical(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002EF9 File Offset: 0x000010F9
		public static void EndVertical()
		{
			GUILayoutUtility.EndLayoutGroup();
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002F02 File Offset: 0x00001102
		public static void BeginArea(Rect screenRect)
		{
			GUILayout.BeginArea(screenRect, GUIContent.none, GUIStyle.none);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002F16 File Offset: 0x00001116
		public static void BeginArea(Rect screenRect, string text)
		{
			GUILayout.BeginArea(screenRect, GUIContent.Temp(text), GUIStyle.none);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002F2B File Offset: 0x0000112B
		public static void BeginArea(Rect screenRect, Texture image)
		{
			GUILayout.BeginArea(screenRect, GUIContent.Temp(image), GUIStyle.none);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002F40 File Offset: 0x00001140
		public static void BeginArea(Rect screenRect, GUIContent content)
		{
			GUILayout.BeginArea(screenRect, content, GUIStyle.none);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002F50 File Offset: 0x00001150
		public static void BeginArea(Rect screenRect, GUIStyle style)
		{
			GUILayout.BeginArea(screenRect, GUIContent.none, style);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002F60 File Offset: 0x00001160
		public static void BeginArea(Rect screenRect, string text, GUIStyle style)
		{
			GUILayout.BeginArea(screenRect, GUIContent.Temp(text), style);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002F71 File Offset: 0x00001171
		public static void BeginArea(Rect screenRect, Texture image, GUIStyle style)
		{
			GUILayout.BeginArea(screenRect, GUIContent.Temp(image), style);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002F82 File Offset: 0x00001182
		public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000AA28 File Offset: 0x00008C28
		public static void EndArea()
		{
			GUIUtility.CheckOnGUI();
			GUILayoutUtility.EndLayoutArea();
			bool flag = Event.current.type == EventType.Used;
			if (!flag)
			{
				GUI.EndGroup();
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000AA5C File Offset: 0x00008C5C
		public static Vector2 BeginScrollView(Vector2 scrollPosition, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.BeginScrollView(scrollPosition, false, false, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.scrollView, options);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002F8F File Offset: 0x0000118F
		public static Vector2 BeginScrollView(Vector2 scrollPosition, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000AA98 File Offset: 0x00008C98
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.scrollView, options);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002F9D File Offset: 0x0000119D
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000AAD4 File Offset: 0x00008CD4
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.BeginScrollView(scrollPosition, false, false, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView, options);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002FAD File Offset: 0x000011AD
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, horizontalScrollbar, verticalScrollbar, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000AAFC File Offset: 0x00008CFC
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style)
		{
			Il2CppReferenceArray<GUILayoutOption> il2CppReferenceArray = null;
			return GUILayout.BeginScrollView(scrollPosition, style, il2CppReferenceArray);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000AB18 File Offset: 0x00008D18
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			string name = style.name;
			GUIStyle guistyle = GUI.skin.FindStyle(String.Concat(name, "VerticalScrollbar"));
			bool flag = guistyle == null;
			if (flag)
			{
				guistyle = GUI.skin.verticalScrollbar;
			}
			GUIStyle guistyle2 = GUI.skin.FindStyle(String.Concat(name, "HorizontalScrollbar"));
			bool flag2 = guistyle2 == null;
			if (flag2)
			{
				guistyle2 = GUI.skin.horizontalScrollbar;
			}
			return GUILayout.BeginScrollView(scrollPosition, false, false, guistyle2, guistyle, style, options);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002FBD File Offset: 0x000011BD
		public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000AB94 File Offset: 0x00008D94
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView, options);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002FCC File Offset: 0x000011CC
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUIUtility.CheckOnGUI();
			GUIScrollGroup guiscrollGroup = GUILayoutUtility.BeginLayoutGroup(background, null, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<GUIScrollGroup>())).Cast<GUIScrollGroup>();
			EventType type = Event.current.type;
			EventType eventType = type;
			if (eventType == EventType.Layout)
			{
				guiscrollGroup.resetCoords = true;
				guiscrollGroup.isVertical = true;
				guiscrollGroup.stretchWidth = 1;
				guiscrollGroup.stretchHeight = 1;
				guiscrollGroup.verticalScrollbar = verticalScrollbar;
				guiscrollGroup.horizontalScrollbar = horizontalScrollbar;
				guiscrollGroup.needsVerticalScrollbar = alwaysShowVertical;
				guiscrollGroup.needsHorizontalScrollbar = alwaysShowHorizontal;
				guiscrollGroup.ApplyOptions(options);
			}
			return GUI.BeginScrollView(guiscrollGroup.rect, scrollPosition, new Rect(0f, 0f, guiscrollGroup.clientWidth, guiscrollGroup.clientHeight), alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002FE0 File Offset: 0x000011E0
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
		{
			return GUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002FF6 File Offset: 0x000011F6
		public static void EndScrollView()
		{
			GUILayout.EndScrollView(true);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00003000 File Offset: 0x00001200
		public static void EndScrollView(bool handleScrollWheel)
		{
			GUILayoutUtility.EndLayoutGroup();
			GUI.EndScrollView(handleScrollWheel);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000AC78 File Offset: 0x00008E78
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoWindow(id, screenRect, func, GUIContent.Temp(text), GUI.skin.window, options);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00003010 File Offset: 0x00001210
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, text, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000ACA4 File Offset: 0x00008EA4
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoWindow(id, screenRect, func, GUIContent.Temp(image), GUI.skin.window, options);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00003022 File Offset: 0x00001222
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, image, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000ACD0 File Offset: 0x00008ED0
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoWindow(id, screenRect, func, content, GUI.skin.window, options);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00003034 File Offset: 0x00001234
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, content, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000ACF8 File Offset: 0x00008EF8
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoWindow(id, screenRect, func, GUIContent.Temp(text), style, options);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00003046 File Offset: 0x00001246
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000AD1C File Offset: 0x00008F1C
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoWindow(id, screenRect, func, GUIContent.Temp(image), style, options);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000305A File Offset: 0x0000125A
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000AD40 File Offset: 0x00008F40
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayout.DoWindow(id, screenRect, func, content, style, options);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000306E File Offset: 0x0000126E
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayout.Window(id, screenRect, func, content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000AD60 File Offset: 0x00008F60
		public static Rect DoWindow(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			GUIUtility.CheckOnGUI();
			GUILayout.LayoutedWindow layoutedWindow = new GUILayout.LayoutedWindow(func, screenRect, content, options, style);
			return GUI.Window(id, screenRect, new GUI.WindowFunction(layoutedWindow.DoWindow), content, style);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000AD9C File Offset: 0x00008F9C
		public static GUILayoutOption MinWidth(float minWidth)
		{
			return new GUILayoutOption(GUILayoutOption.Type.minWidth, minWidth);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000ADBC File Offset: 0x00008FBC
		public static GUILayoutOption MaxWidth(float maxWidth)
		{
			return new GUILayoutOption(GUILayoutOption.Type.maxWidth, maxWidth);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000ADDC File Offset: 0x00008FDC
		public static GUILayoutOption MinHeight(float minHeight)
		{
			return new GUILayoutOption(GUILayoutOption.Type.minHeight, minHeight);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000ADFC File Offset: 0x00008FFC
		public static GUILayoutOption MaxHeight(float maxHeight)
		{
			return new GUILayoutOption(GUILayoutOption.Type.maxHeight, maxHeight);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000AE1C File Offset: 0x0000901C
		public static GUILayoutOption ExpandWidth(bool expand)
		{
			return new GUILayoutOption(GUILayoutOption.Type.stretchWidth, expand ? 1 : 0);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000AE40 File Offset: 0x00009040
		public static GUILayoutOption ExpandHeight(bool expand)
		{
			return new GUILayoutOption(GUILayoutOption.Type.stretchHeight, expand ? 1 : 0);
		}

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_Width_Public_Static_GUILayoutOption_Single_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_Height_Public_Static_GUILayoutOption_Single_0;

		// Token: 0x0200006A RID: 106
		public sealed class LayoutedWindow
		{
		}

		// Token: 0x0200006B RID: 107
		public class HorizontalScope : GUI.Scope
		{
		}

		// Token: 0x0200006C RID: 108
		public class VerticalScope : GUI.Scope
		{
		}

		// Token: 0x0200006D RID: 109
		public class AreaScope : GUI.Scope
		{
		}

		// Token: 0x0200006E RID: 110
		public class ScrollViewScope : GUI.Scope
		{
		}
	}
}
