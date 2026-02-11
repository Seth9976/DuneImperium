using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200001C RID: 28
	public class HtmlTernaryTree : Object
	{
		// Token: 0x0600021A RID: 538 RVA: 0x0001DD48 File Offset: 0x0001BF48
		// Note: this type is marked as 'beforefieldinit'.
		static HtmlTernaryTree()
		{
			Il2CppClassPointerStore<HtmlTernaryTree>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "HtmlTernaryTree");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HtmlTernaryTree>.NativeClassPtr);
			HtmlTernaryTree.NativeFieldInfoPtr_htmlElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTernaryTree>.NativeClassPtr, "htmlElements");
			HtmlTernaryTree.NativeFieldInfoPtr_htmlAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HtmlTernaryTree>.NativeClassPtr, "htmlAttributes");
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002DF1 File Offset: 0x00000FF1
		public HtmlTernaryTree(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600021C RID: 540 RVA: 0x0001DDA0 File Offset: 0x0001BFA0
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00002DFA File Offset: 0x00000FFA
		public unsafe static Il2CppStructArray<byte> htmlElements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HtmlTernaryTree.NativeFieldInfoPtr_htmlElements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HtmlTernaryTree.NativeFieldInfoPtr_htmlElements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0001DDC8 File Offset: 0x0001BFC8
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00002E0C File Offset: 0x0000100C
		public unsafe static Il2CppStructArray<byte> htmlAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HtmlTernaryTree.NativeFieldInfoPtr_htmlAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HtmlTernaryTree.NativeFieldInfoPtr_htmlAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeFieldInfoPtr_htmlElements;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeFieldInfoPtr_htmlAttributes;
	}
}
