using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Linq
{
	// Token: 0x0200001C RID: 28
	public class XStreamingElement : Object
	{
		// Token: 0x06000156 RID: 342 RVA: 0x000083A4 File Offset: 0x000065A4
		// Note: this type is marked as 'beforefieldinit'.
		static XStreamingElement()
		{
			Il2CppClassPointerStore<XStreamingElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.Linq.dll", "System.Xml.Linq", "XStreamingElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XStreamingElement>.NativeClassPtr);
			XStreamingElement.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XStreamingElement>.NativeClassPtr, "name");
			XStreamingElement.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XStreamingElement>.NativeClassPtr, "content");
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000026ED File Offset: 0x000008ED
		public XStreamingElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000083FC File Offset: 0x000065FC
		// (set) Token: 0x06000159 RID: 345 RVA: 0x000026F6 File Offset: 0x000008F6
		public unsafe XName name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XStreamingElement.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XStreamingElement.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0000842C File Offset: 0x0000662C
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00002715 File Offset: 0x00000915
		public unsafe Object content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XStreamingElement.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XStreamingElement.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_content;
	}
}
