using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200010F RID: 271
	public class SelectorActiveAxis : ActiveAxis
	{
		// Token: 0x0600185A RID: 6234 RVA: 0x0007E05C File Offset: 0x0007C25C
		// Note: this type is marked as 'beforefieldinit'.
		static SelectorActiveAxis()
		{
			Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SelectorActiveAxis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr);
			SelectorActiveAxis.NativeFieldInfoPtr_cs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, "cs");
			SelectorActiveAxis.NativeFieldInfoPtr_KSs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, "KSs");
			SelectorActiveAxis.NativeFieldInfoPtr_KSpointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, "KSpointer");
			SelectorActiveAxis.NativeMethodInfoPtr_get_lastDepth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, 100667077);
			SelectorActiveAxis.NativeMethodInfoPtr__ctor_Public_Void_Asttree_ConstraintStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, 100667078);
			SelectorActiveAxis.NativeMethodInfoPtr_EndElement_Public_Virtual_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, 100667079);
			SelectorActiveAxis.NativeMethodInfoPtr_PushKS_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, 100667080);
			SelectorActiveAxis.NativeMethodInfoPtr_PopKS_Public_KeySequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, 100667081);
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x0007E12C File Offset: 0x0007C32C
		public unsafe int lastDepth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391893, XrefRangeEnd = 391894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectorActiveAxis.NativeMethodInfoPtr_get_lastDepth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x0007E168 File Offset: 0x0007C368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391894, XrefRangeEnd = 391901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectorActiveAxis(Asttree axisTree, ConstraintStruct cs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axisTree);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectorActiveAxis.NativeMethodInfoPtr__ctor_Public_Void_Asttree_ConstraintStruct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x0007E1C8 File Offset: 0x0007C3C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391901, XrefRangeEnd = 391909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool EndElement(string localname, string URN)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectorActiveAxis.NativeMethodInfoPtr_EndElement_Public_Virtual_Boolean_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x0007E234 File Offset: 0x0007C434
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 391934, RefRangeEnd = 391936, XrefRangeStart = 391909, XrefRangeEnd = 391934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int PushKS(int errline, int errcol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errline;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errcol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectorActiveAxis.NativeMethodInfoPtr_PushKS_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x0007E28C File Offset: 0x0007C48C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 391938, RefRangeEnd = 391940, XrefRangeStart = 391936, XrefRangeEnd = 391938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeySequence PopKS()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectorActiveAxis.NativeMethodInfoPtr_PopKS_Public_KeySequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<KeySequence>(intPtr3) : null;
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x0000A6B8 File Offset: 0x000088B8
		public SelectorActiveAxis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001861 RID: 6241 RVA: 0x0007E2CC File Offset: 0x0007C4CC
		// (set) Token: 0x06001862 RID: 6242 RVA: 0x0000A6C1 File Offset: 0x000088C1
		public unsafe ConstraintStruct cs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectorActiveAxis.NativeFieldInfoPtr_cs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstraintStruct>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectorActiveAxis.NativeFieldInfoPtr_cs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001863 RID: 6243 RVA: 0x0007E2FC File Offset: 0x0007C4FC
		// (set) Token: 0x06001864 RID: 6244 RVA: 0x0000A6E0 File Offset: 0x000088E0
		public unsafe ArrayList KSs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectorActiveAxis.NativeFieldInfoPtr_KSs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectorActiveAxis.NativeFieldInfoPtr_KSs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x0007E32C File Offset: 0x0007C52C
		// (set) Token: 0x06001866 RID: 6246 RVA: 0x0000A6FF File Offset: 0x000088FF
		public unsafe int KSpointer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectorActiveAxis.NativeFieldInfoPtr_KSpointer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectorActiveAxis.NativeFieldInfoPtr_KSpointer)) = value;
			}
		}

		// Token: 0x04001312 RID: 4882
		private static readonly IntPtr NativeFieldInfoPtr_cs;

		// Token: 0x04001313 RID: 4883
		private static readonly IntPtr NativeFieldInfoPtr_KSs;

		// Token: 0x04001314 RID: 4884
		private static readonly IntPtr NativeFieldInfoPtr_KSpointer;

		// Token: 0x04001315 RID: 4885
		private static readonly IntPtr NativeMethodInfoPtr_get_lastDepth_Public_get_Int32_0;

		// Token: 0x04001316 RID: 4886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Asttree_ConstraintStruct_0;

		// Token: 0x04001317 RID: 4887
		private static readonly IntPtr NativeMethodInfoPtr_EndElement_Public_Virtual_Boolean_String_String_0;

		// Token: 0x04001318 RID: 4888
		private static readonly IntPtr NativeMethodInfoPtr_PushKS_Public_Int32_Int32_Int32_0;

		// Token: 0x04001319 RID: 4889
		private static readonly IntPtr NativeMethodInfoPtr_PopKS_Public_KeySequence_0;
	}
}
