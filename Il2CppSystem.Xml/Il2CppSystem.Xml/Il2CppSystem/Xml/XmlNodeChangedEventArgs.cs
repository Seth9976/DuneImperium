using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000074 RID: 116
	public class XmlNodeChangedEventArgs : EventArgs
	{
		// Token: 0x06000E20 RID: 3616 RVA: 0x00053F5C File Offset: 0x0005215C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNodeChangedEventArgs()
		{
			Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlNodeChangedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr);
			XmlNodeChangedEventArgs.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, "action");
			XmlNodeChangedEventArgs.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, "node");
			XmlNodeChangedEventArgs.NativeFieldInfoPtr_oldParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, "oldParent");
			XmlNodeChangedEventArgs.NativeFieldInfoPtr_newParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, "newParent");
			XmlNodeChangedEventArgs.NativeFieldInfoPtr_oldValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, "oldValue");
			XmlNodeChangedEventArgs.NativeFieldInfoPtr_newValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, "newValue");
			XmlNodeChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, 100665629);
			XmlNodeChangedEventArgs.NativeMethodInfoPtr_get_Action_Public_get_XmlNodeChangedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr, 100665630);
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x0005402C File Offset: 0x0005222C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375630, RefRangeEnd = 375631, XrefRangeStart = 375621, XrefRangeEnd = 375630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNodeChangedEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNodeChangedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldParent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newParent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x000540D0 File Offset: 0x000522D0
		public unsafe XmlNodeChangedAction Action
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeChangedEventArgs.NativeMethodInfoPtr_get_Action_Public_get_XmlNodeChangedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00006A16 File Offset: 0x00004C16
		public XmlNodeChangedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x0005410C File Offset: 0x0005230C
		// (set) Token: 0x06000E25 RID: 3621 RVA: 0x00006A1F File Offset: 0x00004C1F
		public unsafe XmlNodeChangedAction action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_action);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_action)) = value;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000E26 RID: 3622 RVA: 0x00054134 File Offset: 0x00052334
		// (set) Token: 0x06000E27 RID: 3623 RVA: 0x00006A3A File Offset: 0x00004C3A
		public unsafe XmlNode node
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_node);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x00054164 File Offset: 0x00052364
		// (set) Token: 0x06000E29 RID: 3625 RVA: 0x00006A59 File Offset: 0x00004C59
		public unsafe XmlNode oldParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_oldParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_oldParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x00054194 File Offset: 0x00052394
		// (set) Token: 0x06000E2B RID: 3627 RVA: 0x00006A78 File Offset: 0x00004C78
		public unsafe XmlNode newParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_newParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_newParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x000541C4 File Offset: 0x000523C4
		// (set) Token: 0x06000E2D RID: 3629 RVA: 0x00006A97 File Offset: 0x00004C97
		public unsafe string oldValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_oldValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_oldValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x000541EC File Offset: 0x000523EC
		// (set) Token: 0x06000E2F RID: 3631 RVA: 0x00006AB6 File Offset: 0x00004CB6
		public unsafe string newValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_newValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeChangedEventArgs.NativeFieldInfoPtr_newValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeFieldInfoPtr_action;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeFieldInfoPtr_node;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeFieldInfoPtr_oldParent;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeFieldInfoPtr_newParent;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeFieldInfoPtr_oldValue;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeFieldInfoPtr_newValue;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction_0;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr_get_Action_Public_get_XmlNodeChangedAction_0;
	}
}
