using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000B7 RID: 183
	public class XmlElementEventArgs : EventArgs
	{
		// Token: 0x0600127B RID: 4731 RVA: 0x00067904 File Offset: 0x00065B04
		// Note: this type is marked as 'beforefieldinit'.
		static XmlElementEventArgs()
		{
			Il2CppClassPointerStore<XmlElementEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlElementEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlElementEventArgs>.NativeClassPtr);
			XmlElementEventArgs.NativeFieldInfoPtr_o = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElementEventArgs>.NativeClassPtr, "o");
			XmlElementEventArgs.NativeFieldInfoPtr_elem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElementEventArgs>.NativeClassPtr, "elem");
			XmlElementEventArgs.NativeFieldInfoPtr_qnames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElementEventArgs>.NativeClassPtr, "qnames");
			XmlElementEventArgs.NativeFieldInfoPtr_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElementEventArgs>.NativeClassPtr, "lineNumber");
			XmlElementEventArgs.NativeFieldInfoPtr_linePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElementEventArgs>.NativeClassPtr, "linePosition");
			XmlElementEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_XmlElement_Int32_Int32_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementEventArgs>.NativeClassPtr, 100666343);
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x000679AC File Offset: 0x00065BAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383785, RefRangeEnd = 383786, XrefRangeStart = 383778, XrefRangeEnd = 383785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlElementEventArgs(XmlElement elem, int lineNumber, int linePosition, Object o, string qnames)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlElementEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(qnames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_XmlElement_Int32_Int32_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00007D07 File Offset: 0x00005F07
		public XmlElementEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x00067A3C File Offset: 0x00065C3C
		// (set) Token: 0x0600127F RID: 4735 RVA: 0x00007D10 File Offset: 0x00005F10
		public unsafe Object o
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementEventArgs.NativeFieldInfoPtr_o);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementEventArgs.NativeFieldInfoPtr_o), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001280 RID: 4736 RVA: 0x00067A6C File Offset: 0x00065C6C
		// (set) Token: 0x06001281 RID: 4737 RVA: 0x00007D2F File Offset: 0x00005F2F
		public unsafe XmlElement elem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementEventArgs.NativeFieldInfoPtr_elem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementEventArgs.NativeFieldInfoPtr_elem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001282 RID: 4738 RVA: 0x00067A9C File Offset: 0x00065C9C
		// (set) Token: 0x06001283 RID: 4739 RVA: 0x00007D4E File Offset: 0x00005F4E
		public unsafe string qnames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementEventArgs.NativeFieldInfoPtr_qnames);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementEventArgs.NativeFieldInfoPtr_qnames), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x00067AC4 File Offset: 0x00065CC4
		// (set) Token: 0x06001285 RID: 4741 RVA: 0x00007D6D File Offset: 0x00005F6D
		public unsafe int lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementEventArgs.NativeFieldInfoPtr_lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementEventArgs.NativeFieldInfoPtr_lineNumber)) = value;
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001286 RID: 4742 RVA: 0x00067AEC File Offset: 0x00065CEC
		// (set) Token: 0x06001287 RID: 4743 RVA: 0x00007D88 File Offset: 0x00005F88
		public unsafe int linePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementEventArgs.NativeFieldInfoPtr_linePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElementEventArgs.NativeFieldInfoPtr_linePosition)) = value;
			}
		}

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeFieldInfoPtr_o;

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeFieldInfoPtr_elem;

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeFieldInfoPtr_qnames;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeFieldInfoPtr_lineNumber;

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeFieldInfoPtr_linePosition;

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlElement_Int32_Int32_Object_String_0;
	}
}
