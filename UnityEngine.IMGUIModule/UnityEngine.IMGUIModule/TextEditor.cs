using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200001F RID: 31
	public class TextEditor : Object
	{
		// Token: 0x06000568 RID: 1384 RVA: 0x00013A14 File Offset: 0x00011C14
		// Note: this type is marked as 'beforefieldinit'.
		static TextEditor()
		{
			Il2CppClassPointerStore<TextEditor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "TextEditor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextEditor>.NativeClassPtr);
			TextEditor.NativeFieldInfoPtr_keyboardOnScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "keyboardOnScreen");
			TextEditor.NativeFieldInfoPtr_controlID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "controlID");
			TextEditor.NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "style");
			TextEditor.NativeFieldInfoPtr_multiline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "multiline");
			TextEditor.NativeFieldInfoPtr_hasHorizontalCursorPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "hasHorizontalCursorPos");
			TextEditor.NativeFieldInfoPtr_isPasswordField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "isPasswordField");
			TextEditor.NativeFieldInfoPtr_scrollOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "scrollOffset");
			TextEditor.NativeFieldInfoPtr_m_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_Content");
			TextEditor.NativeFieldInfoPtr_m_CursorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_CursorIndex");
			TextEditor.NativeFieldInfoPtr_m_SelectIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_SelectIndex");
			TextEditor.NativeFieldInfoPtr_m_RevealCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_RevealCursor");
			TextEditor.NativeFieldInfoPtr_m_MouseDragSelectsWholeWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_MouseDragSelectsWholeWords");
			TextEditor.NativeFieldInfoPtr_m_DblClickInitPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_DblClickInitPos");
			TextEditor.NativeFieldInfoPtr_m_DblClickSnap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_DblClickSnap");
			TextEditor.NativeFieldInfoPtr_m_bJustSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_bJustSelected");
			TextEditor.NativeFieldInfoPtr_m_iAltCursorPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_iAltCursorPos");
			TextEditor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663691);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00013B98 File Offset: 0x00011D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1188564, XrefRangeEnd = 1188583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextEditor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextEditor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0000464A File Offset: 0x0000284A
		public TextEditor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00013BD4 File Offset: 0x00011DD4
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x00004653 File Offset: 0x00002853
		public unsafe TouchScreenKeyboard keyboardOnScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_keyboardOnScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TouchScreenKeyboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_keyboardOnScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00013C04 File Offset: 0x00011E04
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x00004672 File Offset: 0x00002872
		public unsafe int controlID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_controlID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_controlID)) = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00013C2C File Offset: 0x00011E2C
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x0000468D File Offset: 0x0000288D
		public unsafe GUIStyle style
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_style);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_style), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00013C5C File Offset: 0x00011E5C
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x000046AC File Offset: 0x000028AC
		public unsafe bool multiline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_multiline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_multiline)) = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00013C84 File Offset: 0x00011E84
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x000046C7 File Offset: 0x000028C7
		public unsafe bool hasHorizontalCursorPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_hasHorizontalCursorPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_hasHorizontalCursorPos)) = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x00013CAC File Offset: 0x00011EAC
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x000046E2 File Offset: 0x000028E2
		public unsafe bool isPasswordField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_isPasswordField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_isPasswordField)) = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x00013CD4 File Offset: 0x00011ED4
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x000046FD File Offset: 0x000028FD
		public unsafe Vector2 scrollOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_scrollOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_scrollOffset)) = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x00013CFC File Offset: 0x00011EFC
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x00004718 File Offset: 0x00002918
		public unsafe GUIContent m_Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x00013D2C File Offset: 0x00011F2C
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x00004737 File Offset: 0x00002937
		public unsafe int m_CursorIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_CursorIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_CursorIndex)) = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00013D54 File Offset: 0x00011F54
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x00004752 File Offset: 0x00002952
		public unsafe int m_SelectIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_SelectIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_SelectIndex)) = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00013D7C File Offset: 0x00011F7C
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x0000476D File Offset: 0x0000296D
		public unsafe bool m_RevealCursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_RevealCursor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_RevealCursor)) = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00013DA4 File Offset: 0x00011FA4
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x00004788 File Offset: 0x00002988
		public unsafe bool m_MouseDragSelectsWholeWords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_MouseDragSelectsWholeWords);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_MouseDragSelectsWholeWords)) = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00013DCC File Offset: 0x00011FCC
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x000047A3 File Offset: 0x000029A3
		public unsafe int m_DblClickInitPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_DblClickInitPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_DblClickInitPos)) = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x00013DF4 File Offset: 0x00011FF4
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x000047BE File Offset: 0x000029BE
		public unsafe TextEditor.DblClickSnapping m_DblClickSnap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_DblClickSnap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_DblClickSnap)) = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00013E1C File Offset: 0x0001201C
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x000047D9 File Offset: 0x000029D9
		public unsafe bool m_bJustSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_bJustSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_bJustSelected)) = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00013E44 File Offset: 0x00012044
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x000047F4 File Offset: 0x000029F4
		public unsafe int m_iAltCursorPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_iAltCursorPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditor.NativeFieldInfoPtr_m_iAltCursorPos)) = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00013E6C File Offset: 0x0001206C
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x0000480F File Offset: 0x00002A0F
		public GUIContent content
		{
			get
			{
				return this.m_Content;
			}
			set
			{
				this.m_Content = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00013E84 File Offset: 0x00012084
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00004819 File Offset: 0x00002A19
		public string text
		{
			get
			{
				return this.m_Content.text;
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00004826 File Offset: 0x00002A26
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x00004833 File Offset: 0x00002A33
		public Rect position
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00013EA4 File Offset: 0x000120A4
		public virtual Rect localPosition
		{
			get
			{
				return this.position;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00013EBC File Offset: 0x000120BC
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x00004840 File Offset: 0x00002A40
		public int cursorIndex
		{
			get
			{
				return this.m_CursorIndex;
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x00013ED4 File Offset: 0x000120D4
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x0000484D File Offset: 0x00002A4D
		public int selectIndex
		{
			get
			{
				return this.m_SelectIndex;
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0000485A File Offset: 0x00002A5A
		public void ClearCursorPos()
		{
			this.hasHorizontalCursorPos = false;
			this.m_iAltCursorPos = -1;
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00013EEC File Offset: 0x000120EC
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x0000486B File Offset: 0x00002A6B
		public TextEditor.DblClickSnapping doubleClickSnapping
		{
			get
			{
				return this.m_DblClickSnap;
			}
			set
			{
				this.m_DblClickSnap = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00013F04 File Offset: 0x00012104
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x00004875 File Offset: 0x00002A75
		public int altCursorPosition
		{
			get
			{
				return this.m_iAltCursorPos;
			}
			set
			{
				this.m_iAltCursorPos = value;
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0000487F File Offset: 0x00002A7F
		public void OnFocus()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0000488C File Offset: 0x00002A8C
		public void OnLostFocus()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00004899 File Offset: 0x00002A99
		public void GrabGraphicalCursorPos()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00013F1C File Offset: 0x0001211C
		public bool HandleKeyEvent(Event e)
		{
			return this.HandleKeyEvent(e, false);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x000048A6 File Offset: 0x00002AA6
		public bool HandleKeyEvent(Event e, bool textIsReadOnly)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00013F38 File Offset: 0x00012138
		public bool DeleteLineBack()
		{
			bool hasSelection = this.hasSelection;
			bool flag;
			if (hasSelection)
			{
				this.DeleteSelection();
				flag = true;
			}
			else
			{
				int num = this.cursorIndex;
				int num2 = num;
				while (num2-- != 0)
				{
					bool flag2 = this.text.get_Chars(num2) == '\n';
					if (flag2)
					{
						num = num2 + 1;
						break;
					}
				}
				bool flag3 = num2 == -1;
				if (flag3)
				{
					num = 0;
				}
				bool flag4 = this.cursorIndex != num;
				if (flag4)
				{
					this.m_Content.text = this.text.Remove(num, this.cursorIndex - num);
					this.selectIndex = (this.cursorIndex = num);
					flag = true;
				}
				else
				{
					flag = false;
				}
			}
			return flag;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00013FF4 File Offset: 0x000121F4
		public bool DeleteWordBack()
		{
			bool hasSelection = this.hasSelection;
			bool flag;
			if (hasSelection)
			{
				this.DeleteSelection();
				flag = true;
			}
			else
			{
				int num = this.FindEndOfPreviousWord(this.cursorIndex);
				bool flag2 = this.cursorIndex != num;
				if (flag2)
				{
					this.m_Content.text = this.text.Remove(num, this.cursorIndex - num);
					this.selectIndex = (this.cursorIndex = num);
					flag = true;
				}
				else
				{
					flag = false;
				}
			}
			return flag;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00014074 File Offset: 0x00012274
		public bool DeleteWordForward()
		{
			bool hasSelection = this.hasSelection;
			bool flag;
			if (hasSelection)
			{
				this.DeleteSelection();
				flag = true;
			}
			else
			{
				int num = this.FindStartOfNextWord(this.cursorIndex);
				bool flag2 = this.cursorIndex < this.text.Length;
				if (flag2)
				{
					this.m_Content.text = this.text.Remove(this.cursorIndex, num - this.cursorIndex);
					flag = true;
				}
				else
				{
					flag = false;
				}
			}
			return flag;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x000140EC File Offset: 0x000122EC
		public bool Delete()
		{
			bool hasSelection = this.hasSelection;
			bool flag;
			if (hasSelection)
			{
				this.DeleteSelection();
				flag = true;
			}
			else
			{
				bool flag2 = this.cursorIndex < this.text.Length;
				if (flag2)
				{
					this.m_Content.text = this.text.Remove(this.cursorIndex, this.NextCodePointIndex(this.cursorIndex) - this.cursorIndex);
					flag = true;
				}
				else
				{
					flag = false;
				}
			}
			return flag;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00014164 File Offset: 0x00012364
		public bool CanPaste()
		{
			return GUIUtility.systemCopyBuffer.Length != 0;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00014184 File Offset: 0x00012384
		public bool Backspace()
		{
			bool hasSelection = this.hasSelection;
			bool flag;
			if (hasSelection)
			{
				this.DeleteSelection();
				flag = true;
			}
			else
			{
				bool flag2 = this.cursorIndex > 0;
				if (flag2)
				{
					int num = this.PreviousCodePointIndex(this.cursorIndex);
					this.m_Content.text = this.text.Remove(num, this.cursorIndex - num);
					this.selectIndex = (this.cursorIndex = num);
					this.ClearCursorPos();
					flag = true;
				}
				else
				{
					flag = false;
				}
			}
			return flag;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x000048B3 File Offset: 0x00002AB3
		public void SelectAll()
		{
			this.cursorIndex = 0;
			this.selectIndex = this.text.Length;
			this.ClearCursorPos();
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x000048D7 File Offset: 0x00002AD7
		public void SelectNone()
		{
			this.selectIndex = this.cursorIndex;
			this.ClearCursorPos();
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00014208 File Offset: 0x00012408
		public bool hasSelection
		{
			get
			{
				return this.cursorIndex != this.selectIndex;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0001422C File Offset: 0x0001242C
		public string SelectedText
		{
			get
			{
				bool flag = this.cursorIndex == this.selectIndex;
				string text;
				if (flag)
				{
					text = "";
				}
				else
				{
					bool flag2 = this.cursorIndex < this.selectIndex;
					if (flag2)
					{
						text = this.text.Substring(this.cursorIndex, this.selectIndex - this.cursorIndex);
					}
					else
					{
						text = this.text.Substring(this.selectIndex, this.cursorIndex - this.selectIndex);
					}
				}
				return text;
			}
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x000142AC File Offset: 0x000124AC
		public bool DeleteSelection()
		{
			bool flag = this.cursorIndex == this.selectIndex;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = this.cursorIndex < this.selectIndex;
				if (flag3)
				{
					this.m_Content.text = String.Concat(this.text.Substring(0, this.cursorIndex), this.text.Substring(this.selectIndex, this.text.Length - this.selectIndex));
					this.selectIndex = this.cursorIndex;
				}
				else
				{
					this.m_Content.text = String.Concat(this.text.Substring(0, this.selectIndex), this.text.Substring(this.cursorIndex, this.text.Length - this.cursorIndex));
					this.cursorIndex = this.selectIndex;
				}
				this.ClearCursorPos();
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x000143A0 File Offset: 0x000125A0
		public void ReplaceSelection(string replace)
		{
			this.DeleteSelection();
			this.m_Content.text = this.text.Insert(this.cursorIndex, replace);
			this.selectIndex = (this.cursorIndex += replace.Length);
			this.ClearCursorPos();
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x000048EE File Offset: 0x00002AEE
		public void Insert(char c)
		{
			this.ReplaceSelection(c.ToString());
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x000143F8 File Offset: 0x000125F8
		public void MoveSelectionToAltCursor()
		{
			bool flag = this.m_iAltCursorPos == -1;
			if (!flag)
			{
				int iAltCursorPos = this.m_iAltCursorPos;
				string selectedText = this.SelectedText;
				this.m_Content.text = this.text.Insert(iAltCursorPos, selectedText);
				bool flag2 = iAltCursorPos < this.cursorIndex;
				if (flag2)
				{
					this.cursorIndex += selectedText.Length;
					this.selectIndex += selectedText.Length;
				}
				this.DeleteSelection();
				this.selectIndex = (this.cursorIndex = iAltCursorPos);
				this.ClearCursorPos();
			}
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00014498 File Offset: 0x00012698
		public void MoveRight()
		{
			this.ClearCursorPos();
			bool flag = this.selectIndex == this.cursorIndex;
			if (flag)
			{
				this.cursorIndex = this.NextCodePointIndex(this.cursorIndex);
				this.DetectFocusChange();
				this.selectIndex = this.cursorIndex;
			}
			else
			{
				bool flag2 = this.selectIndex > this.cursorIndex;
				if (flag2)
				{
					this.cursorIndex = this.selectIndex;
				}
				else
				{
					this.selectIndex = this.cursorIndex;
				}
			}
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0001451C File Offset: 0x0001271C
		public void MoveLeft()
		{
			bool flag = this.selectIndex == this.cursorIndex;
			if (flag)
			{
				this.cursorIndex = this.PreviousCodePointIndex(this.cursorIndex);
				this.selectIndex = this.cursorIndex;
			}
			else
			{
				bool flag2 = this.selectIndex > this.cursorIndex;
				if (flag2)
				{
					this.selectIndex = this.cursorIndex;
				}
				else
				{
					this.cursorIndex = this.selectIndex;
				}
			}
			this.ClearCursorPos();
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x000048FF File Offset: 0x00002AFF
		public void MoveUp()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0000490C File Offset: 0x00002B0C
		public void MoveDown()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00014598 File Offset: 0x00012798
		public void MoveLineStart()
		{
			int num = ((this.selectIndex < this.cursorIndex) ? this.selectIndex : this.cursorIndex);
			int num2 = num;
			while (num2-- != 0)
			{
				bool flag = this.text.get_Chars(num2) == '\n';
				if (flag)
				{
					this.selectIndex = (this.cursorIndex = num2 + 1);
					return;
				}
			}
			this.selectIndex = (this.cursorIndex = 0);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00014614 File Offset: 0x00012814
		public void MoveLineEnd()
		{
			int num = ((this.selectIndex > this.cursorIndex) ? this.selectIndex : this.cursorIndex);
			int i = num;
			int length = this.text.Length;
			while (i < length)
			{
				bool flag = this.text.get_Chars(i) == '\n';
				if (flag)
				{
					this.selectIndex = (this.cursorIndex = i);
					return;
				}
				i++;
			}
			this.selectIndex = (this.cursorIndex = length);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x000146A0 File Offset: 0x000128A0
		public void MoveGraphicalLineStart()
		{
			this.cursorIndex = (this.selectIndex = this.GetGraphicalLineStart((this.cursorIndex < this.selectIndex) ? this.cursorIndex : this.selectIndex));
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x000146E4 File Offset: 0x000128E4
		public void MoveGraphicalLineEnd()
		{
			this.cursorIndex = (this.selectIndex = this.GetGraphicalLineEnd((this.cursorIndex > this.selectIndex) ? this.cursorIndex : this.selectIndex));
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00014728 File Offset: 0x00012928
		public void MoveTextStart()
		{
			this.selectIndex = (this.cursorIndex = 0);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00014748 File Offset: 0x00012948
		public void MoveTextEnd()
		{
			this.selectIndex = (this.cursorIndex = this.text.Length);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00014774 File Offset: 0x00012974
		public int IndexOfEndOfLine(int startIndex)
		{
			int num = this.text.IndexOf('\n', startIndex);
			return (num != -1) ? num : this.text.Length;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x000147A8 File Offset: 0x000129A8
		public void MoveParagraphForward()
		{
			this.cursorIndex = ((this.cursorIndex > this.selectIndex) ? this.cursorIndex : this.selectIndex);
			bool flag = this.cursorIndex < this.text.Length;
			if (flag)
			{
				this.selectIndex = (this.cursorIndex = this.IndexOfEndOfLine(this.cursorIndex + 1));
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00014814 File Offset: 0x00012A14
		public void MoveParagraphBackward()
		{
			this.cursorIndex = ((this.cursorIndex < this.selectIndex) ? this.cursorIndex : this.selectIndex);
			bool flag = this.cursorIndex > 1;
			if (flag)
			{
				this.selectIndex = (this.cursorIndex = this.text.LastIndexOf('\n', this.cursorIndex - 2) + 1);
			}
			else
			{
				this.selectIndex = (this.cursorIndex = 0);
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00004919 File Offset: 0x00002B19
		public void MoveCursorToPosition(Vector2 cursorPosition)
		{
			this.MoveCursorToPosition_Internal(cursorPosition, Event.current.shift);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00014890 File Offset: 0x00012A90
		public void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift)
		{
			this.selectIndex = this.style.GetCursorStringIndex(this.localPosition, this.m_Content, cursorPosition + this.scrollOffset);
			bool flag = !shift;
			if (flag)
			{
				this.cursorIndex = this.selectIndex;
			}
			this.DetectFocusChange();
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000148E8 File Offset: 0x00012AE8
		public void MoveAltCursorToPosition(Vector2 cursorPosition)
		{
			int cursorStringIndex = this.style.GetCursorStringIndex(this.localPosition, this.m_Content, cursorPosition + this.scrollOffset);
			this.m_iAltCursorPos = Mathf.Min(this.text.Length, cursorStringIndex);
			this.DetectFocusChange();
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00014938 File Offset: 0x00012B38
		public bool IsOverSelection(Vector2 cursorPosition)
		{
			int cursorStringIndex = this.style.GetCursorStringIndex(this.localPosition, this.m_Content, cursorPosition + this.scrollOffset);
			return cursorStringIndex < Mathf.Max(this.cursorIndex, this.selectIndex) && cursorStringIndex > Mathf.Min(this.cursorIndex, this.selectIndex);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0000492E File Offset: 0x00002B2E
		public void SelectToPosition(Vector2 cursorPosition)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0001499C File Offset: 0x00012B9C
		public void SelectLeft()
		{
			bool bJustSelected = this.m_bJustSelected;
			if (bJustSelected)
			{
				bool flag = this.cursorIndex > this.selectIndex;
				if (flag)
				{
					int cursorIndex = this.cursorIndex;
					this.cursorIndex = this.selectIndex;
					this.selectIndex = cursorIndex;
				}
			}
			this.m_bJustSelected = false;
			this.cursorIndex = this.PreviousCodePointIndex(this.cursorIndex);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00014A00 File Offset: 0x00012C00
		public void SelectRight()
		{
			bool bJustSelected = this.m_bJustSelected;
			if (bJustSelected)
			{
				bool flag = this.cursorIndex < this.selectIndex;
				if (flag)
				{
					int cursorIndex = this.cursorIndex;
					this.cursorIndex = this.selectIndex;
					this.selectIndex = cursorIndex;
				}
			}
			this.m_bJustSelected = false;
			this.cursorIndex = this.NextCodePointIndex(this.cursorIndex);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0000493B File Offset: 0x00002B3B
		public void SelectUp()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00004948 File Offset: 0x00002B48
		public void SelectDown()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00004955 File Offset: 0x00002B55
		public void SelectTextEnd()
		{
			this.cursorIndex = this.text.Length;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0000496A File Offset: 0x00002B6A
		public void SelectTextStart()
		{
			this.cursorIndex = 0;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00004975 File Offset: 0x00002B75
		public void MouseDragSelectsWholeWords(bool on)
		{
			this.m_MouseDragSelectsWholeWords = on;
			this.m_DblClickInitPos = this.cursorIndex;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0000498B File Offset: 0x00002B8B
		public void DblClickSnap(TextEditor.DblClickSnapping snapping)
		{
			this.m_DblClickSnap = snapping;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00014A64 File Offset: 0x00012C64
		public int GetGraphicalLineStart(int p)
		{
			Vector2 cursorPixelPosition = this.style.GetCursorPixelPosition(this.localPosition, this.m_Content, p);
			cursorPixelPosition.y += 1f / GUIUtility.pixelsPerPoint;
			cursorPixelPosition.x = 0f;
			return this.style.GetCursorStringIndex(this.localPosition, this.m_Content, cursorPixelPosition);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00014ACC File Offset: 0x00012CCC
		public int GetGraphicalLineEnd(int p)
		{
			Vector2 cursorPixelPosition = this.style.GetCursorPixelPosition(this.localPosition, this.m_Content, p);
			cursorPixelPosition.y += 1f / GUIUtility.pixelsPerPoint;
			cursorPixelPosition.x += 5000f;
			return this.style.GetCursorStringIndex(this.localPosition, this.m_Content, cursorPixelPosition);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00014B38 File Offset: 0x00012D38
		public int FindNextSeperator(int startPos)
		{
			int length = this.text.Length;
			while (startPos < length && this.ClassifyChar(startPos) > TextEditor.CharacterType.LetterLike)
			{
				startPos = this.NextCodePointIndex(startPos);
			}
			while (startPos < length && this.ClassifyChar(startPos) == TextEditor.CharacterType.LetterLike)
			{
				startPos = this.NextCodePointIndex(startPos);
			}
			return startPos;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00014B98 File Offset: 0x00012D98
		public int FindPrevSeperator(int startPos)
		{
			startPos = this.PreviousCodePointIndex(startPos);
			while (startPos > 0 && this.ClassifyChar(startPos) > TextEditor.CharacterType.LetterLike)
			{
				startPos = this.PreviousCodePointIndex(startPos);
			}
			bool flag = startPos == 0;
			int num;
			if (flag)
			{
				num = 0;
			}
			else
			{
				while (startPos > 0 && this.ClassifyChar(startPos) == TextEditor.CharacterType.LetterLike)
				{
					startPos = this.PreviousCodePointIndex(startPos);
				}
				bool flag2 = this.ClassifyChar(startPos) == TextEditor.CharacterType.LetterLike;
				if (flag2)
				{
					num = startPos;
				}
				else
				{
					num = this.NextCodePointIndex(startPos);
				}
			}
			return num;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00014C1C File Offset: 0x00012E1C
		public void MoveWordRight()
		{
			this.cursorIndex = ((this.cursorIndex > this.selectIndex) ? this.cursorIndex : this.selectIndex);
			this.cursorIndex = (this.selectIndex = this.FindNextSeperator(this.cursorIndex));
			this.ClearCursorPos();
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00014C74 File Offset: 0x00012E74
		public void MoveToStartOfNextWord()
		{
			this.ClearCursorPos();
			bool flag = this.cursorIndex != this.selectIndex;
			if (flag)
			{
				this.MoveRight();
			}
			else
			{
				this.cursorIndex = (this.selectIndex = this.FindStartOfNextWord(this.cursorIndex));
			}
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00014CC8 File Offset: 0x00012EC8
		public void MoveToEndOfPreviousWord()
		{
			this.ClearCursorPos();
			bool flag = this.cursorIndex != this.selectIndex;
			if (flag)
			{
				this.MoveLeft();
			}
			else
			{
				this.cursorIndex = (this.selectIndex = this.FindEndOfPreviousWord(this.cursorIndex));
			}
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00004995 File Offset: 0x00002B95
		public void SelectToStartOfNextWord()
		{
			this.ClearCursorPos();
			this.cursorIndex = this.FindStartOfNextWord(this.cursorIndex);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x000049B2 File Offset: 0x00002BB2
		public void SelectToEndOfPreviousWord()
		{
			this.ClearCursorPos();
			this.cursorIndex = this.FindEndOfPreviousWord(this.cursorIndex);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00014D1C File Offset: 0x00012F1C
		public TextEditor.CharacterType ClassifyChar(int index)
		{
			bool flag = Char.IsWhiteSpace(this.text, index);
			TextEditor.CharacterType characterType;
			if (flag)
			{
				characterType = TextEditor.CharacterType.WhiteSpace;
			}
			else
			{
				bool flag2 = Char.IsLetterOrDigit(this.text, index) || this.text.get_Chars(index) == '\'';
				if (flag2)
				{
					characterType = TextEditor.CharacterType.LetterLike;
				}
				else
				{
					characterType = TextEditor.CharacterType.Symbol;
				}
			}
			return characterType;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00014D6C File Offset: 0x00012F6C
		public int FindStartOfNextWord(int p)
		{
			int length = this.text.Length;
			bool flag = p == length;
			int num;
			if (flag)
			{
				num = p;
			}
			else
			{
				TextEditor.CharacterType characterType = this.ClassifyChar(p);
				bool flag2 = characterType != TextEditor.CharacterType.WhiteSpace;
				if (flag2)
				{
					p = this.NextCodePointIndex(p);
					while (p < length && this.ClassifyChar(p) == characterType)
					{
						p = this.NextCodePointIndex(p);
					}
				}
				else
				{
					bool flag3 = this.text.get_Chars(p) == '\t' || this.text.get_Chars(p) == '\n';
					if (flag3)
					{
						return this.NextCodePointIndex(p);
					}
				}
				bool flag4 = p == length;
				if (flag4)
				{
					num = p;
				}
				else
				{
					bool flag5 = this.text.get_Chars(p) == ' ';
					if (flag5)
					{
						while (p < length && this.ClassifyChar(p) == TextEditor.CharacterType.WhiteSpace)
						{
							p = this.NextCodePointIndex(p);
						}
					}
					else
					{
						bool flag6 = this.text.get_Chars(p) == '\t' || this.text.get_Chars(p) == '\n';
						if (flag6)
						{
							return p;
						}
					}
					num = p;
				}
			}
			return num;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00014E8C File Offset: 0x0001308C
		public int FindEndOfPreviousWord(int p)
		{
			bool flag = p == 0;
			int num;
			if (flag)
			{
				num = p;
			}
			else
			{
				p = this.PreviousCodePointIndex(p);
				while (p > 0 && this.text.get_Chars(p) == ' ')
				{
					p = this.PreviousCodePointIndex(p);
				}
				TextEditor.CharacterType characterType = this.ClassifyChar(p);
				bool flag2 = characterType != TextEditor.CharacterType.WhiteSpace;
				if (flag2)
				{
					while (p > 0 && this.ClassifyChar(this.PreviousCodePointIndex(p)) == characterType)
					{
						p = this.PreviousCodePointIndex(p);
					}
				}
				num = p;
			}
			return num;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00014F1C File Offset: 0x0001311C
		public void MoveWordLeft()
		{
			this.cursorIndex = ((this.cursorIndex < this.selectIndex) ? this.cursorIndex : this.selectIndex);
			this.cursorIndex = this.FindPrevSeperator(this.cursorIndex);
			this.selectIndex = this.cursorIndex;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00014F70 File Offset: 0x00013170
		public void SelectWordRight()
		{
			this.ClearCursorPos();
			int selectIndex = this.selectIndex;
			bool flag = this.cursorIndex < this.selectIndex;
			if (flag)
			{
				this.selectIndex = this.cursorIndex;
				this.MoveWordRight();
				this.selectIndex = selectIndex;
				this.cursorIndex = ((this.cursorIndex < this.selectIndex) ? this.cursorIndex : this.selectIndex);
			}
			else
			{
				this.selectIndex = this.cursorIndex;
				this.MoveWordRight();
				this.selectIndex = selectIndex;
			}
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00014FFC File Offset: 0x000131FC
		public void SelectWordLeft()
		{
			this.ClearCursorPos();
			int selectIndex = this.selectIndex;
			bool flag = this.cursorIndex > this.selectIndex;
			if (flag)
			{
				this.selectIndex = this.cursorIndex;
				this.MoveWordLeft();
				this.selectIndex = selectIndex;
				this.cursorIndex = ((this.cursorIndex > this.selectIndex) ? this.cursorIndex : this.selectIndex);
			}
			else
			{
				this.selectIndex = this.cursorIndex;
				this.MoveWordLeft();
				this.selectIndex = selectIndex;
			}
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00015088 File Offset: 0x00013288
		public void ExpandSelectGraphicalLineStart()
		{
			this.ClearCursorPos();
			bool flag = this.cursorIndex < this.selectIndex;
			if (flag)
			{
				this.cursorIndex = this.GetGraphicalLineStart(this.cursorIndex);
			}
			else
			{
				int cursorIndex = this.cursorIndex;
				this.cursorIndex = this.GetGraphicalLineStart(this.selectIndex);
				this.selectIndex = cursorIndex;
			}
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x000150E8 File Offset: 0x000132E8
		public void ExpandSelectGraphicalLineEnd()
		{
			this.ClearCursorPos();
			bool flag = this.cursorIndex > this.selectIndex;
			if (flag)
			{
				this.cursorIndex = this.GetGraphicalLineEnd(this.cursorIndex);
			}
			else
			{
				int cursorIndex = this.cursorIndex;
				this.cursorIndex = this.GetGraphicalLineEnd(this.selectIndex);
				this.selectIndex = cursorIndex;
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x000049CF File Offset: 0x00002BCF
		public void SelectGraphicalLineStart()
		{
			this.ClearCursorPos();
			this.cursorIndex = this.GetGraphicalLineStart(this.cursorIndex);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x000049EC File Offset: 0x00002BEC
		public void SelectGraphicalLineEnd()
		{
			this.ClearCursorPos();
			this.cursorIndex = this.GetGraphicalLineEnd(this.cursorIndex);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00015148 File Offset: 0x00013348
		public void SelectParagraphForward()
		{
			this.ClearCursorPos();
			bool flag = this.cursorIndex < this.selectIndex;
			bool flag2 = this.cursorIndex < this.text.Length;
			if (flag2)
			{
				this.cursorIndex = this.IndexOfEndOfLine(this.cursorIndex + 1);
				bool flag3 = flag && this.cursorIndex > this.selectIndex;
				if (flag3)
				{
					this.cursorIndex = this.selectIndex;
				}
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x000151C0 File Offset: 0x000133C0
		public void SelectParagraphBackward()
		{
			this.ClearCursorPos();
			bool flag = this.cursorIndex > this.selectIndex;
			bool flag2 = this.cursorIndex > 1;
			if (flag2)
			{
				this.cursorIndex = this.text.LastIndexOf('\n', this.cursorIndex - 2) + 1;
				bool flag3 = flag && this.cursorIndex < this.selectIndex;
				if (flag3)
				{
					this.cursorIndex = this.selectIndex;
				}
			}
			else
			{
				this.selectIndex = (this.cursorIndex = 0);
			}
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0001524C File Offset: 0x0001344C
		public void SelectCurrentWord()
		{
			int cursorIndex = this.cursorIndex;
			bool flag = this.cursorIndex < this.selectIndex;
			if (flag)
			{
				this.cursorIndex = this.FindEndOfClassification(cursorIndex, TextEditor.Direction.Backward);
				this.selectIndex = this.FindEndOfClassification(cursorIndex, TextEditor.Direction.Forward);
			}
			else
			{
				this.cursorIndex = this.FindEndOfClassification(cursorIndex, TextEditor.Direction.Forward);
				this.selectIndex = this.FindEndOfClassification(cursorIndex, TextEditor.Direction.Backward);
			}
			this.ClearCursorPos();
			this.m_bJustSelected = true;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x000152C4 File Offset: 0x000134C4
		public int FindEndOfClassification(int p, TextEditor.Direction dir)
		{
			bool flag = this.text.Length == 0;
			int num;
			if (flag)
			{
				num = 0;
			}
			else
			{
				bool flag2 = p == this.text.Length;
				if (flag2)
				{
					p = this.PreviousCodePointIndex(p);
				}
				TextEditor.CharacterType characterType = this.ClassifyChar(p);
				for (;;)
				{
					if (dir != TextEditor.Direction.Forward)
					{
						if (dir == TextEditor.Direction.Backward)
						{
							p = this.PreviousCodePointIndex(p);
							bool flag3 = p == 0;
							if (flag3)
							{
								break;
							}
						}
					}
					else
					{
						p = this.NextCodePointIndex(p);
						bool flag4 = p == this.text.Length;
						if (flag4)
						{
							goto Block_7;
						}
					}
					if (this.ClassifyChar(p) != characterType)
					{
						goto Block_8;
					}
				}
				return (this.ClassifyChar(0) == characterType) ? 0 : this.NextCodePointIndex(0);
				Block_7:
				return this.text.Length;
				Block_8:
				bool flag5 = dir == TextEditor.Direction.Forward;
				if (flag5)
				{
					num = p;
				}
				else
				{
					num = this.NextCodePointIndex(p);
				}
			}
			return num;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x000153AC File Offset: 0x000135AC
		public void SelectCurrentParagraph()
		{
			this.ClearCursorPos();
			int length = this.text.Length;
			bool flag = this.cursorIndex < length;
			if (flag)
			{
				this.cursorIndex = this.IndexOfEndOfLine(this.cursorIndex) + 1;
			}
			bool flag2 = this.selectIndex != 0;
			if (flag2)
			{
				this.selectIndex = this.text.LastIndexOf('\n', this.selectIndex - 1) + 1;
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0001541C File Offset: 0x0001361C
		public void UpdateScrollOffsetIfNeeded(Event evt)
		{
			bool flag = evt.type != EventType.Repaint && evt.type != EventType.Layout;
			if (flag)
			{
				this.UpdateScrollOffset();
			}
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00004A09 File Offset: 0x00002C09
		public void UpdateScrollOffset()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00004A16 File Offset: 0x00002C16
		public void DrawCursor(string newText)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00015450 File Offset: 0x00013650
		public bool PerformOperation(TextEditor.TextEditOp operation, bool textIsReadOnly)
		{
			this.m_RevealCursor = true;
			switch (operation)
			{
			case TextEditor.TextEditOp.MoveLeft:
				this.MoveLeft();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveRight:
				this.MoveRight();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveUp:
				this.MoveUp();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveDown:
				this.MoveDown();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveLineStart:
				this.MoveLineStart();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveLineEnd:
				this.MoveLineEnd();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveTextStart:
				this.MoveTextStart();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveTextEnd:
				this.MoveTextEnd();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveGraphicalLineStart:
				this.MoveGraphicalLineStart();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveGraphicalLineEnd:
				this.MoveGraphicalLineEnd();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveWordLeft:
				this.MoveWordLeft();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveWordRight:
				this.MoveWordRight();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveParagraphForward:
				this.MoveParagraphForward();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveParagraphBackward:
				this.MoveParagraphBackward();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveToStartOfNextWord:
				this.MoveToStartOfNextWord();
				goto IL_0328;
			case TextEditor.TextEditOp.MoveToEndOfPreviousWord:
				this.MoveToEndOfPreviousWord();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectLeft:
				this.SelectLeft();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectRight:
				this.SelectRight();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectUp:
				this.SelectUp();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectDown:
				this.SelectDown();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectTextStart:
				this.SelectTextStart();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectTextEnd:
				this.SelectTextEnd();
				goto IL_0328;
			case TextEditor.TextEditOp.ExpandSelectGraphicalLineStart:
				this.ExpandSelectGraphicalLineStart();
				goto IL_0328;
			case TextEditor.TextEditOp.ExpandSelectGraphicalLineEnd:
				this.ExpandSelectGraphicalLineEnd();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectGraphicalLineStart:
				this.SelectGraphicalLineStart();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectGraphicalLineEnd:
				this.SelectGraphicalLineEnd();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectWordLeft:
				this.SelectWordLeft();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectWordRight:
				this.SelectWordRight();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectToEndOfPreviousWord:
				this.SelectToEndOfPreviousWord();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectToStartOfNextWord:
				this.SelectToStartOfNextWord();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectParagraphBackward:
				this.SelectParagraphBackward();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectParagraphForward:
				this.SelectParagraphForward();
				goto IL_0328;
			case TextEditor.TextEditOp.Delete:
				return !textIsReadOnly && this.Delete();
			case TextEditor.TextEditOp.Backspace:
				return !textIsReadOnly && this.Backspace();
			case TextEditor.TextEditOp.DeleteWordBack:
				return !textIsReadOnly && this.DeleteWordBack();
			case TextEditor.TextEditOp.DeleteWordForward:
				return !textIsReadOnly && this.DeleteWordForward();
			case TextEditor.TextEditOp.DeleteLineBack:
				return !textIsReadOnly && this.DeleteLineBack();
			case TextEditor.TextEditOp.Cut:
				return !textIsReadOnly && this.Cut();
			case TextEditor.TextEditOp.Copy:
				this.Copy();
				goto IL_0328;
			case TextEditor.TextEditOp.Paste:
				return !textIsReadOnly && this.Paste();
			case TextEditor.TextEditOp.SelectAll:
				this.SelectAll();
				goto IL_0328;
			case TextEditor.TextEditOp.SelectNone:
				this.SelectNone();
				goto IL_0328;
			}
			Debug.Log(String.Concat("Unimplemented: ", operation.ToString()));
			IL_0328:
			return false;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00004A23 File Offset: 0x00002C23
		public void SaveBackup()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00004A30 File Offset: 0x00002C30
		public void Undo()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0001578C File Offset: 0x0001398C
		public bool Cut()
		{
			bool isPasswordField = this.isPasswordField;
			bool flag;
			if (isPasswordField)
			{
				flag = false;
			}
			else
			{
				this.Copy();
				flag = this.DeleteSelection();
			}
			return flag;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x000157BC File Offset: 0x000139BC
		public void Copy()
		{
			bool flag = this.selectIndex == this.cursorIndex;
			if (!flag)
			{
				bool isPasswordField = this.isPasswordField;
				if (!isPasswordField)
				{
					string text = this.style.Internal_GetSelectedRenderedText(this.localPosition, this.m_Content, this.selectIndex, this.cursorIndex);
					GUIUtility.systemCopyBuffer = text;
				}
			}
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00015818 File Offset: 0x00013A18
		public Il2CppStructArray<Rect> GetHyperlinksRect()
		{
			return this.style.Internal_GetHyperlinksRect(this.localPosition, this.m_Content);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00015844 File Offset: 0x00013A44
		public static string ReplaceNewlinesWithSpaces(string value)
		{
			value = value.Replace("\r\n", " ");
			value = value.Replace('\n', ' ');
			value = value.Replace('\r', ' ');
			return value;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00015884 File Offset: 0x00013A84
		public bool Paste()
		{
			string text = GUIUtility.systemCopyBuffer;
			bool flag = text != "";
			bool flag3;
			if (flag)
			{
				bool flag2 = !this.multiline;
				if (flag2)
				{
					text = TextEditor.ReplaceNewlinesWithSpaces(text);
				}
				this.ReplaceSelection(text);
				flag3 = true;
			}
			else
			{
				flag3 = false;
			}
			return flag3;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00004A3D File Offset: 0x00002C3D
		public static void MapKey(string key, TextEditor.TextEditOp action)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00004A4A File Offset: 0x00002C4A
		public void InitKeyActions()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00004A57 File Offset: 0x00002C57
		public void DetectFocusChange()
		{
			this.OnDetectFocusChange();
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00004A61 File Offset: 0x00002C61
		public virtual void OnDetectFocusChange()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00004A6E File Offset: 0x00002C6E
		public virtual void OnCursorIndexChange()
		{
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00004A71 File Offset: 0x00002C71
		public virtual void OnSelectIndexChange()
		{
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00004A74 File Offset: 0x00002C74
		public void ClampTextIndex(ref int index)
		{
			index = Mathf.Clamp(index, 0, this.text.Length);
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x000158D0 File Offset: 0x00013AD0
		public void EnsureValidCodePointIndex(ref int index)
		{
			this.ClampTextIndex(ref index);
			bool flag = !this.IsValidCodePointIndex(index);
			if (flag)
			{
				index = this.NextCodePointIndex(index);
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00015900 File Offset: 0x00013B00
		public bool IsValidCodePointIndex(int index)
		{
			bool flag = index < 0 || index > this.text.Length;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = index == 0 || index == this.text.Length;
				flag2 = flag3 || !Char.IsLowSurrogate(this.text.get_Chars(index));
			}
			return flag2;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00015960 File Offset: 0x00013B60
		public int PreviousCodePointIndex(int index)
		{
			bool flag = index > 0;
			if (flag)
			{
				index--;
			}
			while (index > 0 && Char.IsLowSurrogate(this.text.get_Chars(index)))
			{
				index--;
			}
			return index;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x000159A4 File Offset: 0x00013BA4
		public int NextCodePointIndex(int index)
		{
			bool flag = index < this.text.Length;
			if (flag)
			{
				index++;
			}
			while (index < this.text.Length && Char.IsLowSurrogate(this.text.get_Chars(index)))
			{
				index++;
			}
			return index;
		}

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeFieldInfoPtr_keyboardOnScreen;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeFieldInfoPtr_controlID;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeFieldInfoPtr_style;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeFieldInfoPtr_multiline;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeFieldInfoPtr_hasHorizontalCursorPos;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeFieldInfoPtr_isPasswordField;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeFieldInfoPtr_scrollOffset;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeFieldInfoPtr_m_Content;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeFieldInfoPtr_m_CursorIndex;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectIndex;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeFieldInfoPtr_m_RevealCursor;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeFieldInfoPtr_m_MouseDragSelectsWholeWords;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeFieldInfoPtr_m_DblClickInitPos;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeFieldInfoPtr_m_DblClickSnap;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeFieldInfoPtr_m_bJustSelected;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeFieldInfoPtr_m_iAltCursorPos;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000B0 RID: 176
		public enum DblClickSnapping : byte
		{
			// Token: 0x040003B4 RID: 948
			WORDS,
			// Token: 0x040003B5 RID: 949
			PARAGRAPHS
		}

		// Token: 0x020000B1 RID: 177
		public enum CharacterType
		{
			// Token: 0x040003B7 RID: 951
			LetterLike,
			// Token: 0x040003B8 RID: 952
			Symbol,
			// Token: 0x040003B9 RID: 953
			Symbol2,
			// Token: 0x040003BA RID: 954
			WhiteSpace
		}

		// Token: 0x020000B2 RID: 178
		public enum Direction
		{
			// Token: 0x040003BC RID: 956
			Forward,
			// Token: 0x040003BD RID: 957
			Backward
		}

		// Token: 0x020000B3 RID: 179
		public enum TextEditOp
		{
			// Token: 0x040003BF RID: 959
			MoveLeft,
			// Token: 0x040003C0 RID: 960
			MoveRight,
			// Token: 0x040003C1 RID: 961
			MoveUp,
			// Token: 0x040003C2 RID: 962
			MoveDown,
			// Token: 0x040003C3 RID: 963
			MoveLineStart,
			// Token: 0x040003C4 RID: 964
			MoveLineEnd,
			// Token: 0x040003C5 RID: 965
			MoveTextStart,
			// Token: 0x040003C6 RID: 966
			MoveTextEnd,
			// Token: 0x040003C7 RID: 967
			MovePageUp,
			// Token: 0x040003C8 RID: 968
			MovePageDown,
			// Token: 0x040003C9 RID: 969
			MoveGraphicalLineStart,
			// Token: 0x040003CA RID: 970
			MoveGraphicalLineEnd,
			// Token: 0x040003CB RID: 971
			MoveWordLeft,
			// Token: 0x040003CC RID: 972
			MoveWordRight,
			// Token: 0x040003CD RID: 973
			MoveParagraphForward,
			// Token: 0x040003CE RID: 974
			MoveParagraphBackward,
			// Token: 0x040003CF RID: 975
			MoveToStartOfNextWord,
			// Token: 0x040003D0 RID: 976
			MoveToEndOfPreviousWord,
			// Token: 0x040003D1 RID: 977
			SelectLeft,
			// Token: 0x040003D2 RID: 978
			SelectRight,
			// Token: 0x040003D3 RID: 979
			SelectUp,
			// Token: 0x040003D4 RID: 980
			SelectDown,
			// Token: 0x040003D5 RID: 981
			SelectTextStart,
			// Token: 0x040003D6 RID: 982
			SelectTextEnd,
			// Token: 0x040003D7 RID: 983
			SelectPageUp,
			// Token: 0x040003D8 RID: 984
			SelectPageDown,
			// Token: 0x040003D9 RID: 985
			ExpandSelectGraphicalLineStart,
			// Token: 0x040003DA RID: 986
			ExpandSelectGraphicalLineEnd,
			// Token: 0x040003DB RID: 987
			SelectGraphicalLineStart,
			// Token: 0x040003DC RID: 988
			SelectGraphicalLineEnd,
			// Token: 0x040003DD RID: 989
			SelectWordLeft,
			// Token: 0x040003DE RID: 990
			SelectWordRight,
			// Token: 0x040003DF RID: 991
			SelectToEndOfPreviousWord,
			// Token: 0x040003E0 RID: 992
			SelectToStartOfNextWord,
			// Token: 0x040003E1 RID: 993
			SelectParagraphBackward,
			// Token: 0x040003E2 RID: 994
			SelectParagraphForward,
			// Token: 0x040003E3 RID: 995
			Delete,
			// Token: 0x040003E4 RID: 996
			Backspace,
			// Token: 0x040003E5 RID: 997
			DeleteWordBack,
			// Token: 0x040003E6 RID: 998
			DeleteWordForward,
			// Token: 0x040003E7 RID: 999
			DeleteLineBack,
			// Token: 0x040003E8 RID: 1000
			Cut,
			// Token: 0x040003E9 RID: 1001
			Copy,
			// Token: 0x040003EA RID: 1002
			Paste,
			// Token: 0x040003EB RID: 1003
			SelectAll,
			// Token: 0x040003EC RID: 1004
			SelectNone,
			// Token: 0x040003ED RID: 1005
			ScrollStart,
			// Token: 0x040003EE RID: 1006
			ScrollEnd,
			// Token: 0x040003EF RID: 1007
			ScrollPageUp,
			// Token: 0x040003F0 RID: 1008
			ScrollPageDown
		}
	}
}
