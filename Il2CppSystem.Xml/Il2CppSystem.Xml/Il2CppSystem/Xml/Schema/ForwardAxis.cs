using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000105 RID: 261
	public class ForwardAxis : Object
	{
		// Token: 0x0600177A RID: 6010 RVA: 0x0007A9F0 File Offset: 0x00078BF0
		// Note: this type is marked as 'beforefieldinit'.
		static ForwardAxis()
		{
			Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ForwardAxis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr);
			ForwardAxis.NativeFieldInfoPtr__topNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, "_topNode");
			ForwardAxis.NativeFieldInfoPtr__rootNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, "_rootNode");
			ForwardAxis.NativeFieldInfoPtr__isAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, "_isAttribute");
			ForwardAxis.NativeFieldInfoPtr__isDss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, "_isDss");
			ForwardAxis.NativeFieldInfoPtr__isSelfAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, "_isSelfAxis");
			ForwardAxis.NativeMethodInfoPtr_get_RootNode_Internal_get_DoubleLinkAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, 100666974);
			ForwardAxis.NativeMethodInfoPtr_get_TopNode_Internal_get_DoubleLinkAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, 100666975);
			ForwardAxis.NativeMethodInfoPtr_get_IsAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, 100666976);
			ForwardAxis.NativeMethodInfoPtr_get_IsDss_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, 100666977);
			ForwardAxis.NativeMethodInfoPtr_get_IsSelfAxis_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, 100666978);
			ForwardAxis.NativeMethodInfoPtr__ctor_Public_Void_DoubleLinkAxis_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr, 100666979);
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x0600177B RID: 6011 RVA: 0x0007AAFC File Offset: 0x00078CFC
		public unsafe DoubleLinkAxis RootNode
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardAxis.NativeMethodInfoPtr_get_RootNode_Internal_get_DoubleLinkAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DoubleLinkAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x0600177C RID: 6012 RVA: 0x0007AB3C File Offset: 0x00078D3C
		public unsafe DoubleLinkAxis TopNode
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardAxis.NativeMethodInfoPtr_get_TopNode_Internal_get_DoubleLinkAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DoubleLinkAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x0007AB7C File Offset: 0x00078D7C
		public unsafe bool IsAttribute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardAxis.NativeMethodInfoPtr_get_IsAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x0007ABB8 File Offset: 0x00078DB8
		public unsafe bool IsDss
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardAxis.NativeMethodInfoPtr_get_IsDss_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x0600177F RID: 6015 RVA: 0x0007ABF4 File Offset: 0x00078DF4
		public unsafe bool IsSelfAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardAxis.NativeMethodInfoPtr_get_IsSelfAxis_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x0007AC30 File Offset: 0x00078E30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390764, RefRangeEnd = 390765, XrefRangeStart = 390754, XrefRangeEnd = 390764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForwardAxis(DoubleLinkAxis axis, bool isdesorself)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForwardAxis>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isdesorself;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForwardAxis.NativeMethodInfoPtr__ctor_Public_Void_DoubleLinkAxis_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x0000A072 File Offset: 0x00008272
		public ForwardAxis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001782 RID: 6018 RVA: 0x0007AC8C File Offset: 0x00078E8C
		// (set) Token: 0x06001783 RID: 6019 RVA: 0x0000A07B File Offset: 0x0000827B
		public unsafe DoubleLinkAxis _topNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardAxis.NativeFieldInfoPtr__topNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DoubleLinkAxis>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardAxis.NativeFieldInfoPtr__topNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001784 RID: 6020 RVA: 0x0007ACBC File Offset: 0x00078EBC
		// (set) Token: 0x06001785 RID: 6021 RVA: 0x0000A09A File Offset: 0x0000829A
		public unsafe DoubleLinkAxis _rootNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardAxis.NativeFieldInfoPtr__rootNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DoubleLinkAxis>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardAxis.NativeFieldInfoPtr__rootNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x0007ACEC File Offset: 0x00078EEC
		// (set) Token: 0x06001787 RID: 6023 RVA: 0x0000A0B9 File Offset: 0x000082B9
		public unsafe bool _isAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardAxis.NativeFieldInfoPtr__isAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardAxis.NativeFieldInfoPtr__isAttribute)) = value;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x0007AD14 File Offset: 0x00078F14
		// (set) Token: 0x06001789 RID: 6025 RVA: 0x0000A0D4 File Offset: 0x000082D4
		public unsafe bool _isDss
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardAxis.NativeFieldInfoPtr__isDss);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardAxis.NativeFieldInfoPtr__isDss)) = value;
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x0007AD3C File Offset: 0x00078F3C
		// (set) Token: 0x0600178B RID: 6027 RVA: 0x0000A0EF File Offset: 0x000082EF
		public unsafe bool _isSelfAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardAxis.NativeFieldInfoPtr__isSelfAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForwardAxis.NativeFieldInfoPtr__isSelfAxis)) = value;
			}
		}

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeFieldInfoPtr__topNode;

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeFieldInfoPtr__rootNode;

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeFieldInfoPtr__isAttribute;

		// Token: 0x0400127C RID: 4732
		private static readonly IntPtr NativeFieldInfoPtr__isDss;

		// Token: 0x0400127D RID: 4733
		private static readonly IntPtr NativeFieldInfoPtr__isSelfAxis;

		// Token: 0x0400127E RID: 4734
		private static readonly IntPtr NativeMethodInfoPtr_get_RootNode_Internal_get_DoubleLinkAxis_0;

		// Token: 0x0400127F RID: 4735
		private static readonly IntPtr NativeMethodInfoPtr_get_TopNode_Internal_get_DoubleLinkAxis_0;

		// Token: 0x04001280 RID: 4736
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAttribute_Internal_get_Boolean_0;

		// Token: 0x04001281 RID: 4737
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDss_Internal_get_Boolean_0;

		// Token: 0x04001282 RID: 4738
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSelfAxis_Internal_get_Boolean_0;

		// Token: 0x04001283 RID: 4739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DoubleLinkAxis_Boolean_0;
	}
}
