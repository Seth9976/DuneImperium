using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Linq
{
	// Token: 0x0200001A RID: 26
	public class XObjectChangeEventArgs : EventArgs
	{
		// Token: 0x0600013A RID: 314 RVA: 0x00007E14 File Offset: 0x00006014
		// Note: this type is marked as 'beforefieldinit'.
		static XObjectChangeEventArgs()
		{
			Il2CppClassPointerStore<XObjectChangeEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.Linq.dll", "System.Xml.Linq", "XObjectChangeEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XObjectChangeEventArgs>.NativeClassPtr);
			XObjectChangeEventArgs.NativeFieldInfoPtr__objectChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XObjectChangeEventArgs>.NativeClassPtr, "_objectChange");
			XObjectChangeEventArgs.NativeFieldInfoPtr_Add = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XObjectChangeEventArgs>.NativeClassPtr, "Add");
			XObjectChangeEventArgs.NativeFieldInfoPtr_Remove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XObjectChangeEventArgs>.NativeClassPtr, "Remove");
			XObjectChangeEventArgs.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XObjectChangeEventArgs>.NativeClassPtr, "Name");
			XObjectChangeEventArgs.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XObjectChangeEventArgs>.NativeClassPtr, "Value");
			XObjectChangeEventArgs.NativeMethodInfoPtr__ctor_Public_Void_XObjectChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObjectChangeEventArgs>.NativeClassPtr, 100663520);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00007EBC File Offset: 0x000060BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238551, XrefRangeEnd = 1238555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XObjectChangeEventArgs(XObjectChange objectChange)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XObjectChangeEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectChange;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XObjectChangeEventArgs.NativeMethodInfoPtr__ctor_Public_Void_XObjectChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000263A File Offset: 0x0000083A
		public XObjectChangeEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00007F04 File Offset: 0x00006104
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00002643 File Offset: 0x00000843
		public unsafe XObjectChange _objectChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XObjectChangeEventArgs.NativeFieldInfoPtr__objectChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XObjectChangeEventArgs.NativeFieldInfoPtr__objectChange)) = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00007F2C File Offset: 0x0000612C
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0000265E File Offset: 0x0000085E
		public unsafe static XObjectChangeEventArgs Add
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XObjectChangeEventArgs.NativeFieldInfoPtr_Add, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XObjectChangeEventArgs>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XObjectChangeEventArgs.NativeFieldInfoPtr_Add, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00007F54 File Offset: 0x00006154
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00002670 File Offset: 0x00000870
		public unsafe static XObjectChangeEventArgs Remove
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XObjectChangeEventArgs.NativeFieldInfoPtr_Remove, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XObjectChangeEventArgs>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XObjectChangeEventArgs.NativeFieldInfoPtr_Remove, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00007F7C File Offset: 0x0000617C
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00002682 File Offset: 0x00000882
		public unsafe static XObjectChangeEventArgs Name
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XObjectChangeEventArgs.NativeFieldInfoPtr_Name, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XObjectChangeEventArgs>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XObjectChangeEventArgs.NativeFieldInfoPtr_Name, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00007FA4 File Offset: 0x000061A4
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00002694 File Offset: 0x00000894
		public unsafe static XObjectChangeEventArgs Value
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XObjectChangeEventArgs.NativeFieldInfoPtr_Value, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XObjectChangeEventArgs>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XObjectChangeEventArgs.NativeFieldInfoPtr_Value, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeFieldInfoPtr__objectChange;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeFieldInfoPtr_Add;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr_Remove;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XObjectChange_0;
	}
}
