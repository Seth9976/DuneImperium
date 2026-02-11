using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using MS.Internal.Xml.XPath;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000106 RID: 262
	public class Asttree : Object
	{
		// Token: 0x0600178C RID: 6028 RVA: 0x0007AD64 File Offset: 0x00078F64
		// Note: this type is marked as 'beforefieldinit'.
		static Asttree()
		{
			Il2CppClassPointerStore<Asttree>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Asttree");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Asttree>.NativeClassPtr);
			Asttree.NativeFieldInfoPtr__fAxisArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Asttree>.NativeClassPtr, "_fAxisArray");
			Asttree.NativeFieldInfoPtr__xpathexpr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Asttree>.NativeClassPtr, "_xpathexpr");
			Asttree.NativeFieldInfoPtr__isField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Asttree>.NativeClassPtr, "_isField");
			Asttree.NativeFieldInfoPtr__nsmgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Asttree>.NativeClassPtr, "_nsmgr");
			Asttree.NativeMethodInfoPtr_get_SubtreeArray_Internal_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100666980);
			Asttree.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100666981);
			Asttree.NativeMethodInfoPtr_IsNameTest_Private_Static_Boolean_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100666982);
			Asttree.NativeMethodInfoPtr_IsAttribute_Internal_Static_Boolean_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100666983);
			Asttree.NativeMethodInfoPtr_IsDescendantOrSelf_Private_Static_Boolean_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100666984);
			Asttree.NativeMethodInfoPtr_IsSelf_Internal_Static_Boolean_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100666985);
			Asttree.NativeMethodInfoPtr_CompileXPath_Public_Void_String_Boolean_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100666986);
			Asttree.NativeMethodInfoPtr_SetURN_Private_Void_Axis_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Asttree>.NativeClassPtr, 100666987);
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x0007AE84 File Offset: 0x00079084
		public unsafe ArrayList SubtreeArray
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Asttree.NativeMethodInfoPtr_get_SubtreeArray_Internal_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x0007AEC4 File Offset: 0x000790C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390769, RefRangeEnd = 390770, XrefRangeStart = 390765, XrefRangeEnd = 390769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Asttree(string xPath, bool isField, XmlNamespaceManager nsmgr)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Asttree>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isField;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Asttree.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x0007AF30 File Offset: 0x00079130
		[CallerCount(0)]
		public unsafe static bool IsNameTest(Axis ast)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ast);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Asttree.NativeMethodInfoPtr_IsNameTest_Private_Static_Boolean_Axis_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x0007AF74 File Offset: 0x00079174
		[CallerCount(0)]
		public unsafe static bool IsAttribute(Axis ast)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ast);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Asttree.NativeMethodInfoPtr_IsAttribute_Internal_Static_Boolean_Axis_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x0007AFB8 File Offset: 0x000791B8
		[CallerCount(0)]
		public unsafe static bool IsDescendantOrSelf(Axis ast)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ast);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Asttree.NativeMethodInfoPtr_IsDescendantOrSelf_Private_Static_Boolean_Axis_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x0007AFFC File Offset: 0x000791FC
		[CallerCount(0)]
		public unsafe static bool IsSelf(Axis ast)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ast);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Asttree.NativeMethodInfoPtr_IsSelf_Internal_Static_Boolean_Axis_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x0007B040 File Offset: 0x00079240
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 390813, RefRangeEnd = 390815, XrefRangeStart = 390770, XrefRangeEnd = 390813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isField;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Asttree.NativeMethodInfoPtr_CompileXPath_Public_Void_String_Boolean_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x0007B0A4 File Offset: 0x000792A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 390818, RefRangeEnd = 390820, XrefRangeStart = 390815, XrefRangeEnd = 390818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetURN(Axis axis, XmlNamespaceManager nsmgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Asttree.NativeMethodInfoPtr_SetURN_Private_Void_Axis_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x0000A10A File Offset: 0x0000830A
		public Asttree(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001796 RID: 6038 RVA: 0x0007B0F8 File Offset: 0x000792F8
		// (set) Token: 0x06001797 RID: 6039 RVA: 0x0000A113 File Offset: 0x00008313
		public unsafe ArrayList _fAxisArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Asttree.NativeFieldInfoPtr__fAxisArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Asttree.NativeFieldInfoPtr__fAxisArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x0007B128 File Offset: 0x00079328
		// (set) Token: 0x06001799 RID: 6041 RVA: 0x0000A132 File Offset: 0x00008332
		public unsafe string _xpathexpr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Asttree.NativeFieldInfoPtr__xpathexpr);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Asttree.NativeFieldInfoPtr__xpathexpr), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x0007B150 File Offset: 0x00079350
		// (set) Token: 0x0600179B RID: 6043 RVA: 0x0000A151 File Offset: 0x00008351
		public unsafe bool _isField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Asttree.NativeFieldInfoPtr__isField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Asttree.NativeFieldInfoPtr__isField)) = value;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x0007B178 File Offset: 0x00079378
		// (set) Token: 0x0600179D RID: 6045 RVA: 0x0000A16C File Offset: 0x0000836C
		public unsafe XmlNamespaceManager _nsmgr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Asttree.NativeFieldInfoPtr__nsmgr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Asttree.NativeFieldInfoPtr__nsmgr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001284 RID: 4740
		private static readonly IntPtr NativeFieldInfoPtr__fAxisArray;

		// Token: 0x04001285 RID: 4741
		private static readonly IntPtr NativeFieldInfoPtr__xpathexpr;

		// Token: 0x04001286 RID: 4742
		private static readonly IntPtr NativeFieldInfoPtr__isField;

		// Token: 0x04001287 RID: 4743
		private static readonly IntPtr NativeFieldInfoPtr__nsmgr;

		// Token: 0x04001288 RID: 4744
		private static readonly IntPtr NativeMethodInfoPtr_get_SubtreeArray_Internal_get_ArrayList_0;

		// Token: 0x04001289 RID: 4745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_XmlNamespaceManager_0;

		// Token: 0x0400128A RID: 4746
		private static readonly IntPtr NativeMethodInfoPtr_IsNameTest_Private_Static_Boolean_Axis_0;

		// Token: 0x0400128B RID: 4747
		private static readonly IntPtr NativeMethodInfoPtr_IsAttribute_Internal_Static_Boolean_Axis_0;

		// Token: 0x0400128C RID: 4748
		private static readonly IntPtr NativeMethodInfoPtr_IsDescendantOrSelf_Private_Static_Boolean_Axis_0;

		// Token: 0x0400128D RID: 4749
		private static readonly IntPtr NativeMethodInfoPtr_IsSelf_Internal_Static_Boolean_Axis_0;

		// Token: 0x0400128E RID: 4750
		private static readonly IntPtr NativeMethodInfoPtr_CompileXPath_Public_Void_String_Boolean_XmlNamespaceManager_0;

		// Token: 0x0400128F RID: 4751
		private static readonly IntPtr NativeMethodInfoPtr_SetURN_Private_Void_Axis_XmlNamespaceManager_0;
	}
}
