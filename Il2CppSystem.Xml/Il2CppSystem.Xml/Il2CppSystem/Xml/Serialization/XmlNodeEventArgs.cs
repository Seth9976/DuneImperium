using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000B9 RID: 185
	public class XmlNodeEventArgs : EventArgs
	{
		// Token: 0x0600128F RID: 4751 RVA: 0x00067C14 File Offset: 0x00065E14
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNodeEventArgs()
		{
			Il2CppClassPointerStore<XmlNodeEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlNodeEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNodeEventArgs>.NativeClassPtr);
			XmlNodeEventArgs.NativeFieldInfoPtr_o = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeEventArgs>.NativeClassPtr, "o");
			XmlNodeEventArgs.NativeFieldInfoPtr_xmlNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeEventArgs>.NativeClassPtr, "xmlNode");
			XmlNodeEventArgs.NativeFieldInfoPtr_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeEventArgs>.NativeClassPtr, "lineNumber");
			XmlNodeEventArgs.NativeFieldInfoPtr_linePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeEventArgs>.NativeClassPtr, "linePosition");
			XmlNodeEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_XmlNode_Int32_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeEventArgs>.NativeClassPtr, 100666346);
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00067CA8 File Offset: 0x00065EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383786, XrefRangeEnd = 383792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNodeEventArgs(XmlNode xmlNode, int lineNumber, int linePosition, Object o)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNodeEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_XmlNode_Int32_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x00007DD3 File Offset: 0x00005FD3
		public XmlNodeEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x00067D24 File Offset: 0x00065F24
		// (set) Token: 0x06001293 RID: 4755 RVA: 0x00007DDC File Offset: 0x00005FDC
		public unsafe Object o
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeEventArgs.NativeFieldInfoPtr_o);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeEventArgs.NativeFieldInfoPtr_o), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x00067D54 File Offset: 0x00065F54
		// (set) Token: 0x06001295 RID: 4757 RVA: 0x00007DFB File Offset: 0x00005FFB
		public unsafe XmlNode xmlNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeEventArgs.NativeFieldInfoPtr_xmlNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeEventArgs.NativeFieldInfoPtr_xmlNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x00067D84 File Offset: 0x00065F84
		// (set) Token: 0x06001297 RID: 4759 RVA: 0x00007E1A File Offset: 0x0000601A
		public unsafe int lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeEventArgs.NativeFieldInfoPtr_lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeEventArgs.NativeFieldInfoPtr_lineNumber)) = value;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x00067DAC File Offset: 0x00065FAC
		// (set) Token: 0x06001299 RID: 4761 RVA: 0x00007E35 File Offset: 0x00006035
		public unsafe int linePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeEventArgs.NativeFieldInfoPtr_linePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeEventArgs.NativeFieldInfoPtr_linePosition)) = value;
			}
		}

		// Token: 0x04000F23 RID: 3875
		private static readonly IntPtr NativeFieldInfoPtr_o;

		// Token: 0x04000F24 RID: 3876
		private static readonly IntPtr NativeFieldInfoPtr_xmlNode;

		// Token: 0x04000F25 RID: 3877
		private static readonly IntPtr NativeFieldInfoPtr_lineNumber;

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeFieldInfoPtr_linePosition;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlNode_Int32_Int32_Object_0;
	}
}
