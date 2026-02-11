using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000103 RID: 259
	public class ActiveAxis : Object
	{
		// Token: 0x06001762 RID: 5986 RVA: 0x0007A474 File Offset: 0x00078674
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveAxis()
		{
			Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ActiveAxis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr);
			ActiveAxis.NativeFieldInfoPtr__currentDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr, "_currentDepth");
			ActiveAxis.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr, "_isActive");
			ActiveAxis.NativeFieldInfoPtr__axisTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr, "_axisTree");
			ActiveAxis.NativeFieldInfoPtr__axisStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr, "_axisStack");
			ActiveAxis.NativeMethodInfoPtr_get_CurrentDepth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr, 100666964);
			ActiveAxis.NativeMethodInfoPtr_Reactivate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr, 100666965);
			ActiveAxis.NativeMethodInfoPtr__ctor_Internal_Void_Asttree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr, 100666966);
			ActiveAxis.NativeMethodInfoPtr_MoveToStartElement_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr, 100666967);
			ActiveAxis.NativeMethodInfoPtr_EndElement_Public_Virtual_New_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr, 100666968);
			ActiveAxis.NativeMethodInfoPtr_MoveToAttribute_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr, 100666969);
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x0007A56C File Offset: 0x0007876C
		public unsafe int CurrentDepth
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAxis.NativeMethodInfoPtr_get_CurrentDepth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x0007A5A8 File Offset: 0x000787A8
		[CallerCount(0)]
		public unsafe void Reactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAxis.NativeMethodInfoPtr_Reactivate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x0007A5DC File Offset: 0x000787DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 390713, RefRangeEnd = 390717, XrefRangeStart = 390691, XrefRangeEnd = 390713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveAxis(Asttree axisTree)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveAxis>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axisTree);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAxis.NativeMethodInfoPtr__ctor_Internal_Void_Asttree_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x0007A628 File Offset: 0x00078828
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 390722, RefRangeEnd = 390726, XrefRangeStart = 390717, XrefRangeEnd = 390722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToStartElement(string localname, string URN)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(URN);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAxis.NativeMethodInfoPtr_MoveToStartElement_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x0007A688 File Offset: 0x00078888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390726, XrefRangeEnd = 390730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool EndElement(string localname, string URN)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(URN);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveAxis.NativeMethodInfoPtr_EndElement_Public_Virtual_New_Boolean_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x0007A6F4 File Offset: 0x000788F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 390734, RefRangeEnd = 390736, XrefRangeStart = 390730, XrefRangeEnd = 390734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToAttribute(string localname, string URN)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(URN);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAxis.NativeMethodInfoPtr_MoveToAttribute_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x00009FCD File Offset: 0x000081CD
		public ActiveAxis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x0007A754 File Offset: 0x00078954
		// (set) Token: 0x0600176B RID: 5995 RVA: 0x00009FD6 File Offset: 0x000081D6
		public unsafe int _currentDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAxis.NativeFieldInfoPtr__currentDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAxis.NativeFieldInfoPtr__currentDepth)) = value;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x0007A77C File Offset: 0x0007897C
		// (set) Token: 0x0600176D RID: 5997 RVA: 0x00009FF1 File Offset: 0x000081F1
		public unsafe bool _isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAxis.NativeFieldInfoPtr__isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAxis.NativeFieldInfoPtr__isActive)) = value;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x0007A7A4 File Offset: 0x000789A4
		// (set) Token: 0x0600176F RID: 5999 RVA: 0x0000A00C File Offset: 0x0000820C
		public unsafe Asttree _axisTree
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAxis.NativeFieldInfoPtr__axisTree);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Asttree>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAxis.NativeFieldInfoPtr__axisTree), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x0007A7D4 File Offset: 0x000789D4
		// (set) Token: 0x06001771 RID: 6001 RVA: 0x0000A02B File Offset: 0x0000822B
		public unsafe ArrayList _axisStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAxis.NativeFieldInfoPtr__axisStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAxis.NativeFieldInfoPtr__axisStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeFieldInfoPtr__currentDepth;

		// Token: 0x0400126B RID: 4715
		private static readonly IntPtr NativeFieldInfoPtr__isActive;

		// Token: 0x0400126C RID: 4716
		private static readonly IntPtr NativeFieldInfoPtr__axisTree;

		// Token: 0x0400126D RID: 4717
		private static readonly IntPtr NativeFieldInfoPtr__axisStack;

		// Token: 0x0400126E RID: 4718
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDepth_Public_get_Int32_0;

		// Token: 0x0400126F RID: 4719
		private static readonly IntPtr NativeMethodInfoPtr_Reactivate_Internal_Void_0;

		// Token: 0x04001270 RID: 4720
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Asttree_0;

		// Token: 0x04001271 RID: 4721
		private static readonly IntPtr NativeMethodInfoPtr_MoveToStartElement_Public_Boolean_String_String_0;

		// Token: 0x04001272 RID: 4722
		private static readonly IntPtr NativeMethodInfoPtr_EndElement_Public_Virtual_New_Boolean_String_String_0;

		// Token: 0x04001273 RID: 4723
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Boolean_String_String_0;
	}
}
