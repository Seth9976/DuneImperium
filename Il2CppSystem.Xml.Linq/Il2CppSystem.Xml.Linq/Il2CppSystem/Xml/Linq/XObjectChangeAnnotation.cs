using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Linq
{
	// Token: 0x02000019 RID: 25
	public class XObjectChangeAnnotation : Object
	{
		// Token: 0x06000134 RID: 308 RVA: 0x00007D5C File Offset: 0x00005F5C
		// Note: this type is marked as 'beforefieldinit'.
		static XObjectChangeAnnotation()
		{
			Il2CppClassPointerStore<XObjectChangeAnnotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.Linq.dll", "System.Xml.Linq", "XObjectChangeAnnotation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XObjectChangeAnnotation>.NativeClassPtr);
			XObjectChangeAnnotation.NativeFieldInfoPtr_changing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XObjectChangeAnnotation>.NativeClassPtr, "changing");
			XObjectChangeAnnotation.NativeFieldInfoPtr_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XObjectChangeAnnotation>.NativeClassPtr, "changed");
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000025F3 File Offset: 0x000007F3
		public XObjectChangeAnnotation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00007DB4 File Offset: 0x00005FB4
		// (set) Token: 0x06000137 RID: 311 RVA: 0x000025FC File Offset: 0x000007FC
		public unsafe EventHandler<XObjectChangeEventArgs> changing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XObjectChangeAnnotation.NativeFieldInfoPtr_changing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<XObjectChangeEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XObjectChangeAnnotation.NativeFieldInfoPtr_changing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00007DE4 File Offset: 0x00005FE4
		// (set) Token: 0x06000139 RID: 313 RVA: 0x0000261B File Offset: 0x0000081B
		public unsafe EventHandler<XObjectChangeEventArgs> changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XObjectChangeAnnotation.NativeFieldInfoPtr_changed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<XObjectChangeEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XObjectChangeAnnotation.NativeFieldInfoPtr_changed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeFieldInfoPtr_changing;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeFieldInfoPtr_changed;
	}
}
